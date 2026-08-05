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
				[Cpp2IlInjected.Address(RVA = "0x86922A0", Offset = "0x86914A0", VA = "0x1886922A0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8692300", Offset = "0x8691500", VA = "0x188692300")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8692260", Offset = "0x8691460", VA = "0x188692260")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8691DA0", Offset = "0x8690FA0", VA = "0x188691DA0")]
			public void BFJJPEOEMLB(PointerEventData GCDOLJPFGAB, RectTransform LEIPBPLPMDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8691EF0", Offset = "0x86910F0", VA = "0x188691EF0")]
			public void DGHJHMPGKLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8692180", Offset = "0x8691380", VA = "0x188692180")]
			public void FGDPBIKOHGB(PointerEventData GCDOLJPFGAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8691EA0", Offset = "0x86910A0", VA = "0x188691EA0")]
			public void CAOHOHLKELO(float LPIECFNKJEI, RectTransform LEIPBPLPMDI, Vector3 KGEICFIBDCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly NDCOIAMFCNJ<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NDCOIAMFCNJ<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly NDCOIAMFCNJ<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly NDCOIAMFCNJ<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly NDCOIAMFCNJ<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly JGNOJICCDHE PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData OJBGGCAEMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OCECBNGNNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PIMMBPOEMIP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FECEANBPIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D80", Offset = "0x9F5F80", VA = "0x1809F6D80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x86915E0", Offset = "0x86907E0", VA = "0x1886915E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JBAIDFIOLDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D50", Offset = "0x9F5F50", VA = "0x1809F6D50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8691530", Offset = "0x8690730", VA = "0x188691530")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8691560", Offset = "0x8690760", VA = "0x188691560")]
		private bool MOPEEBENIKA(PointerEventData ELJMGFIBFCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8691A60", Offset = "0x8690C60", VA = "0x188691A60", Slot = "5")]
		public void OnPointerDown(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8691B20", Offset = "0x8690D20", VA = "0x188691B20", Slot = "11")]
		public void OnPointerUp(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86918D0", Offset = "0x8690AD0", VA = "0x1886918D0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8691610", Offset = "0x8690810", VA = "0x188691610", Slot = "7")]
		public void OnBeginDrag(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8691720", Offset = "0x8690920", VA = "0x188691720", Slot = "4")]
		public void OnDrag(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8691800", Offset = "0x8690A00", VA = "0x188691800", Slot = "8")]
		public void OnEndDrag(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8691AC0", Offset = "0x8690CC0", VA = "0x188691AC0", Slot = "9")]
		public void OnPointerEnter(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8691AF0", Offset = "0x8690CF0", VA = "0x188691AF0", Slot = "10")]
		public void OnPointerExit(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86916E0", Offset = "0x86908E0", VA = "0x1886916E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8691B80", Offset = "0x8690D80", VA = "0x188691B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x868D250", Offset = "0x868C450", VA = "0x18868D250")]
		public void SetCanvasSortingOrder(short JOIDHAINDIA, bool BPFLEAEKLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData DLJOBLHNGLC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x868D510", Offset = "0x868C710", VA = "0x18868D510", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x868D3F0", Offset = "0x868C5F0", VA = "0x18868D3F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x868D340", Offset = "0x868C540", VA = "0x18868D340")]
		private void KOHGGPAELHK(GameObject NBIHFEJAGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x868D7F0", Offset = "0x868C9F0", VA = "0x18868D7F0")]
		public void SetOptionsWithNoDefault(List<string> CPMBLPBIGIH, [Optional] string ALBOBHNONAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x868D700", Offset = "0x868C900", VA = "0x18868D700")]
		public void SetOptionsWithNoDefault(List<OptionData> KDLGPMFPDII, [Optional] string ALBOBHNONAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x868D630", Offset = "0x868C830", VA = "0x18868D630", Slot = "42")]
		public override void OnPointerClick(PointerEventData ELJMGFIBFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas OILDMABFDFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x868DA10", Offset = "0x868CC10", VA = "0x18868DA10")]
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
		private sealed class LDOMNKACIPG : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private EAALCCOKLJL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
			[DebuggerHidden]
			public LDOMNKACIPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x868F340", Offset = "0x868E540", VA = "0x18868F340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x868F850", Offset = "0x868EA50", VA = "0x18868F850", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly NNNGNLOOJFG<object> ENMAJICKMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool LKGNBIFPAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? IMBKGKCOKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? BABAKIGAKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? KHKFHFFLNCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool FBPCFAKEMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool LFHCMDPFNBE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MDEHMBIJEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x868EAC0", Offset = "0x868DCC0", VA = "0x18868EAC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HLCLOPJHKBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x868EA70", Offset = "0x868DC70", VA = "0x18868EA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MAFKFCHAGNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA3D020", Offset = "0xA3C220", VA = "0x180A3D020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x868EC80", Offset = "0x868DE80", VA = "0x18868EC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MMNNBIBGHCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x868E9D0", Offset = "0x868DBD0", VA = "0x18868E9D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x868EBE0", Offset = "0x868DDE0", VA = "0x18868EBE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x868E410", Offset = "0x868D610", VA = "0x18868E410")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868E7B0", Offset = "0x868D9B0", VA = "0x18868E7B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x868E760", Offset = "0x868D960", VA = "0x18868E760")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x868E6D0", Offset = "0x868D8D0", VA = "0x18868E6D0")]
		public void Hide(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x868E930", Offset = "0x868DB30", VA = "0x18868E930")]
		public void Show(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x868E840", Offset = "0x868DA40", VA = "0x18868E840")]
		public void Set(object PPOILDCNBFL, bool DGLBPAJEHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x868E4A0", Offset = "0x868D6A0", VA = "0x18868E4A0")]
		public void Clear(bool BCJFFBMDDHA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x868E550", Offset = "0x868D750", VA = "0x18868E550")]
		private void EKKFJPFEFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x868E6E0", Offset = "0x868D8E0", VA = "0x18868E6E0")]
		[IteratorStateMachine(typeof(LDOMNKACIPG))]
		private IEnumerator<EAALCCOKLJL> KJKNNLFLJAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x868E510", Offset = "0x868D710", VA = "0x18868E510", Slot = "5")]
		public virtual void DoHideOrShow(bool BPENGBOBBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x868E940", Offset = "0x868DB40", VA = "0x18868E940")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AOAOLGAEKCN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum KNACEEKFIOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static GGLODBMJCPL IIPPGKBGAFL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static GGLODBMJCPL EHBMKICDKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x868D150", Offset = "0x868C350", VA = "0x18868D150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static KNACEEKFIOE BKENCLCMBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x868CF50", Offset = "0x868C150", VA = "0x18868CF50")]
		get
		{
			return default(KNACEEKFIOE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x868CD20", Offset = "0x868BF20", VA = "0x18868CD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<KNACEEKFIOE> OIHBKLIFPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x868CE80", Offset = "0x868C080", VA = "0x18868CE80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x868D080", Offset = "0x868C280", VA = "0x18868D080")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HPIOBMDDPJP : NHJNLMDFINE, CKEPJJJDNBI, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, IGPKHCFBGGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JGNOJICCDHE IFPMOHCBKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCMBNCCDKOG Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject IGJKKFNOEMM);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GCMBNCCDKOG Spawn<T>(int MIGBBDEFNCL, IReadOnlyList<T> DHAOEHNLNON, GameObject IGJKKFNOEMM);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCMBNCCDKOG Spawn<T>(int MIGBBDEFNCL, IReadOnlyList<T> DHAOEHNLNON, GameObject ECAINMDJAGD, Func<int, GameObject> PMABFBGJHOO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int NIBICIJAIGM, float OCGMHAIKCLK);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum MLEFLLDPGCE : byte
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
		private static readonly int LBANAKDNMMI;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<MLEFLLDPGCE, string> NLKFDAFIOIP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int NDFBOLCJDEJ = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int FKCCLJEBHAG;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int NKDFIOMAKGO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int AOAJADPBDMO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int FBBDKBPLOJC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int CKAFBHOMFDH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int MICFEHIDMAI;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int OHNFCEHANLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool PFAHPHLKCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool ACOKEAGHHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] MMPDAMAFEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private MLEFLLDPGCE type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly MLEFLLDPGCE[] BEIMAKIGJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[GLHFIOJNDCO("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly MLEFLLDPGCE[] LFHPBAEJFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[GLHFIOJNDCO("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[GLHFIOJNDCO("type", MLEFLLDPGCE.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[GLHFIOJNDCO("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic HIMBMEGDKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CLMOFPKGKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient DBBJIFGOFEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8691380", Offset = "0x8690580", VA = "0x188691380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MLEFLLDPGCE AFGCMPJBOON
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xC63350", Offset = "0xC62550", VA = "0x180C63350")]
			get
			{
				return default(MLEFLLDPGCE);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8691500", Offset = "0x8690700", VA = "0x188691500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool NEHBEOCDNBH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x868FF60", Offset = "0x868F160", VA = "0x18868FF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 GCIHHJGOJDE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x86912F0", Offset = "0x86904F0", VA = "0x1886912F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8691330", Offset = "0x8690530", VA = "0x188691330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool CDIEMALONIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x868FD60", Offset = "0x868EF60", VA = "0x18868FD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 MKNJDDMDEKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8691310", Offset = "0x8690510", VA = "0x188691310")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x86914B0", Offset = "0x86906B0", VA = "0x1886914B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MGMMNPMJAEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xC8D230", Offset = "0xC8C430", VA = "0x180C8D230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x21C6B70", Offset = "0x21C5D70", VA = "0x1821C6B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 IHEMANKGMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x868FFD0", Offset = "0x868F1D0", VA = "0x18868FFD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 CIJKKBGCCHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8690C50", Offset = "0x868FE50", VA = "0x188690C50")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float HJDANGAGBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA0B9A0", Offset = "0xA0ABA0", VA = "0x180A0B9A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8691510", Offset = "0x8690710", VA = "0x188691510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8690CC0", Offset = "0x868FEC0", VA = "0x188690CC0", Slot = "12")]
		protected override void PLKIGLOOEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x868FDD0", Offset = "0x868EFD0", VA = "0x18868FDD0")]
		private void GEOPPMHFFDL(Color[] DLJBBPPIDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8690240", Offset = "0x868F440", VA = "0x188690240", Slot = "13")]
		protected override void OPBMDNBCGKI(Material OHHEKLKCMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8690020", Offset = "0x868F220", VA = "0x188690020", Slot = "14")]
		protected override void JPOGDIJNCAI(Material OHHEKLKCMJA, bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8691240", Offset = "0x8690440", VA = "0x188691240")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly GOBAFMHDFPC HACCDGNBPJF;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite BHDPNFODPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material HIJGCKDFEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material JMKFNDKNLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool KMIOHJABPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool LKGNBIFPAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool IKLLPPJBIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool IEGCCOGGMII;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic HIMBMEGDKJE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader PGKFBHKJFEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool CLMOFPKGKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool AKNONIHOOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform LEIPBPLPMDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8692D10", Offset = "0x8691F10", VA = "0x188692D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect ELCJHDOKLDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x86931B0", Offset = "0x86923B0", VA = "0x1886931B0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite PGDCNJDCCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x86932D0", Offset = "0x86924D0", VA = "0x1886932D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86924F0", Offset = "0x86916F0", VA = "0x1886924F0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86934B0", Offset = "0x86926B0", VA = "0x1886934B0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86937B0", Offset = "0x86929B0", VA = "0x1886937B0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8693660", Offset = "0x8692860", VA = "0x188693660", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8692FD0", Offset = "0x86921D0", VA = "0x188692FD0")]
		private void KHJFKDEMCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x86926E0", Offset = "0x86918E0", VA = "0x1886926E0")]
		private void CLKEDDCJJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8692CE0", Offset = "0x8691EE0", VA = "0x188692CE0")]
		private void GCGOOOEBLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8693160", Offset = "0x8692360", VA = "0x188693160")]
		private void OEAEPDAIAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8692D70", Offset = "0x8691F70", VA = "0x188692D70")]
		protected void JAKNKBOBGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8692850", Offset = "0x8691A50", VA = "0x188692850")]
		private void DIBAINALNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "12")]
		protected virtual void PLKIGLOOEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "13")]
		protected virtual void OPBMDNBCGKI(Material OHHEKLKCMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "14")]
		protected virtual void JPOGDIJNCAI(Material OHHEKLKCMJA, bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8692990", Offset = "0x8691B90", VA = "0x188692990")]
		private void FLPOAKIKODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
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
		private static readonly int LFIHLMIEHCB;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int BGNPHGCDBPB;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int HEGDFLIFJDD;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int FOHPEONENEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
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
		private Color[] MMPDAMAFEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] NEAEHNFAAAD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic HIMBMEGDKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool AKNONIHOOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> GLKLNJAAJND
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 GCIHHJGOJDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x86942A0", Offset = "0x86934A0", VA = "0x1886942A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x86942C0", Offset = "0x86934C0", VA = "0x1886942C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8693EA0", Offset = "0x86930A0", VA = "0x188693EA0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> FKBHFACJPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8693C60", Offset = "0x8692E60", VA = "0x188693C60")]
		public bool SetRingLayerColor(int LFADMJJFICC, Color EKKMKLFENBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8693DB0", Offset = "0x8692FB0", VA = "0x188693DB0")]
		public bool SetRingLayerSize(int LFADMJJFICC, float JAFKPMJIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8693B20", Offset = "0x8692D20", VA = "0x188693B20", Slot = "12")]
		protected override void PLKIGLOOEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86939B0", Offset = "0x8692BB0", VA = "0x1886939B0", Slot = "13")]
		protected override void OPBMDNBCGKI(Material OHHEKLKCMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8693960", Offset = "0x8692B60", VA = "0x188693960", Slot = "14")]
		protected override void JPOGDIJNCAI(Material OHHEKLKCMJA, bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8693FF0", Offset = "0x86931F0", VA = "0x188693FF0")]
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
		public enum BJKKKJBCPCH
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int GLOJLHPBIAM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int EAIAMLOGBGD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int ILKMFKNHOPM;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int NKIFJPCNDOA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int BBFBCGKFJGP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int OEGPCEKMDJB;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int FBGFGOOPGMB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int LHNOCFFANDM;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int EGFGKJEGLHF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int OKPDBAINKNE;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int GOHIIMKEBHO;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int FBHFLLPJABD;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int HNCKPEDBGOL;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int ILMHAFDPHOH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int KAJKNNMJOKA;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int HOOONPBMAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
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
		private BJKKKJBCPCH animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[GLHFIOJNDCO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[GLHFIOJNDCO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic HIMBMEGDKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool AKNONIHOOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite PIMNJEKBIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x86950C0", Offset = "0x86942C0", VA = "0x1886950C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x86952E0", Offset = "0x86944E0", VA = "0x1886952E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color CAKNDOPJFPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xED4410", Offset = "0xED3610", VA = "0x180ED4410")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8695370", Offset = "0x8694570", VA = "0x188695370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color EFMMGJNOOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x10F7640", Offset = "0x10F6840", VA = "0x1810F7640")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x86951B0", Offset = "0x86943B0", VA = "0x1886951B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float EDJIKNLFMFL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xC8D720", Offset = "0xC8C920", VA = "0x180C8D720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8695270", Offset = "0x8694470", VA = "0x188695270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 FFOBHBEHKFI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x86950A0", Offset = "0x86942A0", VA = "0x1886950A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8695290", Offset = "0x8694490", VA = "0x188695290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float EKHHHLINNHK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA0B600", Offset = "0xA0A800", VA = "0x180A0B600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8695230", Offset = "0x8694430", VA = "0x188695230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 OBPAEIDOCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1507CB0", Offset = "0x1506EB0", VA = "0x181507CB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x86953F0", Offset = "0x86945F0", VA = "0x1886953F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float FBLNOBCFLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10CA160", Offset = "0x10C9360", VA = "0x1810CA160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8695180", Offset = "0x8694380", VA = "0x188695180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 HMHPNNEMJAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8694310", Offset = "0x8693510", VA = "0x188694310")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public BJKKKJBCPCH OHDLIJCJMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xE45440", Offset = "0xE44640", VA = "0x180E45440")]
			get
			{
				return default(BJKKKJBCPCH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x86951A0", Offset = "0x86943A0", VA = "0x1886951A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float MAGHKBNOEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x169B780", Offset = "0x169A980", VA = "0x18169B780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8695250", Offset = "0x8694450", VA = "0x188695250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float BCLBJBOPLLP
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1632230", Offset = "0x1631430", VA = "0x181632230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8695160", Offset = "0x8694360", VA = "0x188695160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86946A0", Offset = "0x86938A0", VA = "0x1886946A0", Slot = "13")]
		protected override void OPBMDNBCGKI(Material OHHEKLKCMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86943F0", Offset = "0x86935F0", VA = "0x1886943F0")]
		private void LJACDBDIMFE(Sprite KOKDCBLJHCB, [Out] Vector2 NPJBAJNAMKA, [Out] Vector2 MGDLELJDEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86943A0", Offset = "0x86935A0", VA = "0x1886943A0", Slot = "14")]
		protected override void JPOGDIJNCAI(Material OHHEKLKCMJA, bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8695010", Offset = "0x8694210", VA = "0x188695010")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader AGMPGPGKOHM;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader PGKFBHKJFEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8695490", Offset = "0x8694690", VA = "0x188695490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8695440", Offset = "0x8694640", VA = "0x188695440")]
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
		private SerializableRectTransform GOLCABDODOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool GFIOGMDBNFP;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x868F8A0", Offset = "0x868EAA0", VA = "0x18868F8A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x868FB80", Offset = "0x868ED80", VA = "0x18868FB80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x868FB00", Offset = "0x868ED00", VA = "0x18868FB00")]
		private void HLKHDHPDJAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x868FA30", Offset = "0x868EC30", VA = "0x18868FA30")]
		private void EKKFJPFEFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GOBAFMHDFPC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct JPMAIDOMPLJ : IEquatable<JPMAIDOMPLJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component OPJOIGJBJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action DNIGNBAEFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int PHJEDIMIEGC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component CCKIMEINDKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x868EEC0", Offset = "0x868E0C0", VA = "0x18868EEC0")]
		public JPMAIDOMPLJ(Component OPJOIGJBJKN, Action DNIGNBAEFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x868EE40", Offset = "0x868E040", VA = "0x18868EE40")]
		public void LKPFOCCLOAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x868EDA0", Offset = "0x868DFA0", VA = "0x18868EDA0", Slot = "4")]
		public bool Equals(JPMAIDOMPLJ FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x868EDB0", Offset = "0x868DFB0", VA = "0x18868EDB0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KDHFICGOLHG : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GOBAFMHDFPC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public KDHFICGOLHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x868EF30", Offset = "0x868E130", VA = "0x18868EF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x868F2F0", Offset = "0x868E4F0", VA = "0x18868F2F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GOAPOICKGNJ ADAOGJIIIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int KBGPFGIKKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int ODKFKHAPNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> JHOCJCIEEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, JPMAIDOMPLJ> LNDKGEKCDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<JPMAIDOMPLJ> FIOLKDFAMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<JPMAIDOMPLJ> LALILEBFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PEFNPNHCEAP MLGHHDLFMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JCJNPKLKHAD JNLPNFCDFDG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private JCJNPKLKHAD FBPEJAMFOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x868DF20", Offset = "0x868D120", VA = "0x18868DF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x868E290", Offset = "0x868D490", VA = "0x18868E290")]
	public GOBAFMHDFPC(GOAPOICKGNJ ADAOGJIIIMH, int KBGPFGIKKFD = -1, int ODKFKHAPNGI = -1, [Optional] Func<Component, float> JHOCJCIEEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x868E010", Offset = "0x868D210", VA = "0x18868E010")]
	public void IBKACBNIDNK(Component OPJOIGJBJKN, Action AFMEMNMIOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x868DD90", Offset = "0x868CF90", VA = "0x18868DD90")]
	public void EJAFOKFHAEL(Component OPJOIGJBJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x868DFB0", Offset = "0x868D1B0", VA = "0x18868DFB0")]
	public bool GMJDKCKNMLJ(Component CBNJHLDNKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x868DB60", Offset = "0x868CD60", VA = "0x18868DB60")]
	private void DDHAJBFKAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x868DA60", Offset = "0x868CC60", VA = "0x18868DA60")]
	[IteratorStateMachine(typeof(KDHFICGOLHG))]
	private IEnumerator<EAALCCOKLJL> ALKIOHNAKLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xDE3560", Offset = "0xDE2760", VA = "0x180DE3560")]
	[CompilerGenerated]
	private void EBPBLKGDDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x868DAE0", Offset = "0x868CCE0", VA = "0x18868DAE0")]
	[CompilerGenerated]
	private float CFDMANLCHIK(JPMAIDOMPLJ AFMEMNMIOCM)
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
