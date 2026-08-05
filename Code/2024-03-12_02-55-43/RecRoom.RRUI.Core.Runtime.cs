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
				[Cpp2IlInjected.Address(RVA = "0x68EA2E0", Offset = "0x68E94E0", VA = "0x1868EA2E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x68EA340", Offset = "0x68E9540", VA = "0x1868EA340")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x68EA290", Offset = "0x68E9490", VA = "0x1868EA290")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x68EA190", Offset = "0x68E9390", VA = "0x1868EA190")]
			public void OFJPLPDCOHN(PointerEventData DJNDAOADMOO, RectTransform CMPAFCOPLDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x68E9DD0", Offset = "0x68E8FD0", VA = "0x1868E9DD0")]
			public void DPLPCHLFBMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68EA0B0", Offset = "0x68E92B0", VA = "0x1868EA0B0")]
			public void OCLKBKEGBGD(PointerEventData DJNDAOADMOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68EA060", Offset = "0x68E9260", VA = "0x1868EA060")]
			public void EJBHPOJFOFA(float NOKLEELGLPA, RectTransform CMPAFCOPLDG, Vector3 FFOFALOECNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly APOAGECOPGB<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly APOAGECOPGB<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly APOAGECOPGB<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly APOAGECOPGB<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly APOAGECOPGB<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DIKKIJJDOON PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData PIHLGDCEJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool IMEMPGGLGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool AAAMEHGADDF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OOIGFOHBFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C1D00", Offset = "0x7C0F00", VA = "0x1807C1D00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x68E9610", Offset = "0x68E8810", VA = "0x1868E9610")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LGJKHJODNGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C1CE0", Offset = "0x7C0EE0", VA = "0x1807C1CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x68E9560", Offset = "0x68E8760", VA = "0x1868E9560")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68E9590", Offset = "0x68E8790", VA = "0x1868E9590")]
		private bool GENNEJKCAFF(PointerEventData KGOCMEOMNLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68E9A90", Offset = "0x68E8C90", VA = "0x1868E9A90", Slot = "5")]
		public void OnPointerDown(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68E9B50", Offset = "0x68E8D50", VA = "0x1868E9B50", Slot = "11")]
		public void OnPointerUp(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68E9900", Offset = "0x68E8B00", VA = "0x1868E9900", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68E9640", Offset = "0x68E8840", VA = "0x1868E9640", Slot = "7")]
		public void OnBeginDrag(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68E9750", Offset = "0x68E8950", VA = "0x1868E9750", Slot = "4")]
		public void OnDrag(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68E9830", Offset = "0x68E8A30", VA = "0x1868E9830", Slot = "8")]
		public void OnEndDrag(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68E9AF0", Offset = "0x68E8CF0", VA = "0x1868E9AF0", Slot = "9")]
		public void OnPointerEnter(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68E9B20", Offset = "0x68E8D20", VA = "0x1868E9B20", Slot = "10")]
		public void OnPointerExit(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68E9710", Offset = "0x68E8910", VA = "0x1868E9710")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68E9BB0", Offset = "0x68E8DB0", VA = "0x1868E9BB0")]
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
		private OptionData MBEGHLCCEID;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68E5660", Offset = "0x68E4860", VA = "0x1868E5660", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68E5560", Offset = "0x68E4760", VA = "0x1868E5560", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68E54B0", Offset = "0x68E46B0", VA = "0x1868E54B0")]
		private void BMFEBMIMDKC(GameObject KNKHEJLLPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68E5920", Offset = "0x68E4B20", VA = "0x1868E5920")]
		public void SetOptionsWithNoDefault(List<string> OJPPDIEMMAB, [Optional] string JDJICHKJPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68E5830", Offset = "0x68E4A30", VA = "0x1868E5830")]
		public void SetOptionsWithNoDefault(List<OptionData> AGAKJLDACOH, [Optional] string JDJICHKJPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68E5760", Offset = "0x68E4960", VA = "0x1868E5760", Slot = "42")]
		public override void OnPointerClick(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas BLDCLDOCBJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68E5B50", Offset = "0x68E4D50", VA = "0x1868E5B50")]
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
		private sealed class HBPCAJOMAOB : IEnumerator<DHJAFLNNJKE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private DHJAFLNNJKE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DHJAFLNNJKE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
			[DebuggerHidden]
			public HBPCAJOMAOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x68E5BA0", Offset = "0x68E4DA0", VA = "0x1868E5BA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x68E6090", Offset = "0x68E5290", VA = "0x1868E6090", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[FNMOBJNDEPF(DOGHHGCAALN.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly COECADDMBED POGCLEDBCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool FNDGEIIMMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? PKPFECDOIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? GKMDIFHJMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? HDBDNGAAHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool PDBOAODFFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool HGBPDNNJDBK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AMJMGJGMPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68E6760", Offset = "0x68E5960", VA = "0x1868E6760", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool GMAOPNOBPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68E6740", Offset = "0x68E5940", VA = "0x1868E6740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OJKNMDLFPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8065F0", Offset = "0x8057F0", VA = "0x1808065F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68E6910", Offset = "0x68E5B10", VA = "0x1868E6910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KMGOKPJBAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68E66A0", Offset = "0x68E58A0", VA = "0x1868E66A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68E6870", Offset = "0x68E5A70", VA = "0x1868E6870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68E60E0", Offset = "0x68E52E0", VA = "0x1868E60E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68E62B0", Offset = "0x68E54B0", VA = "0x1868E62B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68E61B0", Offset = "0x68E53B0", VA = "0x1868E61B0")]
		public void Hide(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68E65A0", Offset = "0x68E57A0", VA = "0x1868E65A0")]
		public void Show(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68E6500", Offset = "0x68E5700", VA = "0x1868E6500")]
		public void Set(object COAGHPOILPB, bool EBKGMFFHKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68E6340", Offset = "0x68E5540", VA = "0x1868E6340")]
		private void PCPLNOGIBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68E6230", Offset = "0x68E5430", VA = "0x1868E6230")]
		[IteratorStateMachine(typeof(HBPCAJOMAOB))]
		private IEnumerator<DHJAFLNNJKE> NGEACOKGDGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68E6170", Offset = "0x68E5370", VA = "0x1868E6170", Slot = "5")]
		public virtual void DoHideOrShow(bool BMKJPADMFJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68E6620", Offset = "0x68E5820", VA = "0x1868E6620")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HGCMGIMLMCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82CC20", Offset = "0x82BE20", VA = "0x18082CC20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C6280", Offset = "0x7C5480", VA = "0x1807C6280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> GEILCPJIDGO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x68E6A70", Offset = "0x68E5C70", VA = "0x1868E6A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x68E6BD0", Offset = "0x68E5DD0", VA = "0x1868E6BD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> IIMHLGFDNOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x68E6B20", Offset = "0x68E5D20", VA = "0x1868E6B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x68E6C80", Offset = "0x68E5E80", VA = "0x1868E6C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68E6A30", Offset = "0x68E5C30", VA = "0x1868E6A30", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68E6A50", Offset = "0x68E5C50", VA = "0x1868E6A50", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData KGOCMEOMNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCAB100", Offset = "0xCAA300", VA = "0x180CAB100")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCAB100", Offset = "0xCAA300", VA = "0x180CAB100")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NOPMNHEANIK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MJEGDGDENHP
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static LLFFGFOHLHF PDFBCJAHPKD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static LLFFGFOHLHF JHOMCAGIEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68E7140", Offset = "0x68E6340", VA = "0x1868E7140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MJEGDGDENHP NELMLIFNADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68E72F0", Offset = "0x68E64F0", VA = "0x1868E72F0")]
		get
		{
			return default(MJEGDGDENHP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68E7420", Offset = "0x68E6620", VA = "0x1868E7420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<MJEGDGDENHP> GJJOBDDJADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68E7580", Offset = "0x68E6780", VA = "0x1868E7580")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68E7210", Offset = "0x68E6410", VA = "0x1868E7210")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GJDJOBFJDNJ : GIGPDAGJHIM, FEJEKNNFJOJ, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KIDGADDAONM<GameObject, int> HELHNAGFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HHNANIHJCKD<GameObject, int, bool> KLMFNDIPPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	APOAGECOPGB<bool> JBDNHNJGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JHEPMAJIHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float IDFFHANNOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	APOAGECOPGB<float> LBOMNAFDINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DIKKIJJDOON JMNFOPIFBLC
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
	void SpawnLoadingPlaceholders(GameObject ODLCGLNOMBE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GACIPGFALDC Spawn<T>(int FHGKNALHIPB, IReadOnlyList<T> GKNJGNIHLDH, GameObject ODLCGLNOMBE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GACIPGFALDC Spawn<T>(int FHGKNALHIPB, IReadOnlyList<T> GKNJGNIHLDH, GameObject JGFALDCJADJ, Func<int, GameObject> OHGBMBINPLI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int ILNNGHKJMBD, float ODGHFCFMCIB);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DAEJBHMHJMC : byte
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
		private static readonly int EHIDBENOIMO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<DAEJBHMHJMC, string> EIFNALDKHKD;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int GPLLMPKIPBD = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int GCFBOIBFEHL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int GFEGGBGICGJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int FCNLHHEJFFM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int JIKCKGPKFEO;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int NNNPEAPPJJL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int MBNJLJBBJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool NDKMFAHBNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool COJHBALALNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] OAJOLGODGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private DAEJBHMHJMC type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DAEJBHMHJMC[] GJHGIMKOKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[HCLAHHHOAJN("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly DAEJBHMHJMC[] PDEKJLHCEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[HCLAHHHOAJN("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[HCLAHHHOAJN("type", DAEJBHMHJMC.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[HCLAHHHOAJN("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic BFMEMCDAABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BEILPNAAAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient DMFCEDLENAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7C1D40", Offset = "0x7C0F40", VA = "0x1807C1D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x68E93B0", Offset = "0x68E85B0", VA = "0x1868E93B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DAEJBHMHJMC OFDHKLACDLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD6E220", Offset = "0xD6D420", VA = "0x180D6E220")]
			get
			{
				return default(DAEJBHMHJMC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x68E9530", Offset = "0x68E8730", VA = "0x1868E9530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool BLBPFEAKMLC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x68E80C0", Offset = "0x68E72C0", VA = "0x1868E80C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 DBNNONHHNII
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x68E9320", Offset = "0x68E8520", VA = "0x1868E9320")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x68E9360", Offset = "0x68E8560", VA = "0x1868E9360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool IBKALGPAHPC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x68E8BD0", Offset = "0x68E7DD0", VA = "0x1868E8BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 NGBMLCGBOBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x68E9340", Offset = "0x68E8540", VA = "0x1868E9340")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x68E94E0", Offset = "0x68E86E0", VA = "0x1868E94E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float PKHMICMBJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8C1950", Offset = "0x8C0B50", VA = "0x1808C1950")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x13DD0B0", Offset = "0x13DC2B0", VA = "0x1813DD0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 LNJIJPDLMMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x68E87C0", Offset = "0x68E79C0", VA = "0x1868E87C0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 DBMLADBINAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x68E8C40", Offset = "0x68E7E40", VA = "0x1868E8C40")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NGKDBMCNMHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D66D0", Offset = "0x7D58D0", VA = "0x1807D66D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x68E9540", Offset = "0x68E8740", VA = "0x1868E9540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68E8810", Offset = "0x68E7A10", VA = "0x1868E8810", Slot = "12")]
		protected override void LEFHGMOLFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68E8CD0", Offset = "0x68E7ED0", VA = "0x1868E8CD0")]
		private void OPEALCEHGIJ(Color[] IHHHBMAIMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68E8130", Offset = "0x68E7330", VA = "0x1868E8130", Slot = "13")]
		protected override void ELGNBALGEMP(Material FCJNMBKENDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68E89B0", Offset = "0x68E7BB0", VA = "0x1868E89B0", Slot = "14")]
		protected override void MCDMDFKMKED(Material FCJNMBKENDK, bool CMIINBJIIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68E9270", Offset = "0x68E8470", VA = "0x1868E9270")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly OIELFMDAPBE HALKPGJMLFG;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite AKJCKJJHLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material KCOEGBALNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material IAADCADIBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool OHFEOMEKEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool FNDGEIIMMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool KEFKGKIKPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool GKGGHLKKBHH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic BFMEMCDAABK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader OOKOIFOBAPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool BEILPNAAAEG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool PPFAEGEHGCE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform CMPAFCOPLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x68EB250", Offset = "0x68EA450", VA = "0x1868EB250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect HHGIIFGJPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x68EAA20", Offset = "0x68E9C20", VA = "0x1868EAA20")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite FLGHMLMMHDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x68EAB40", Offset = "0x68E9D40", VA = "0x1868EAB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68EA530", Offset = "0x68E9730", VA = "0x1868EA530", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68EB2B0", Offset = "0x68EA4B0", VA = "0x1868EB2B0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68EB5B0", Offset = "0x68EA7B0", VA = "0x1868EB5B0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68EB460", Offset = "0x68EA660", VA = "0x1868EB460", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68EA890", Offset = "0x68E9A90", VA = "0x1868EA890")]
		private void EDDGFNAEIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68EAD40", Offset = "0x68E9F40", VA = "0x1868EAD40")]
		private void FOKBFDKGJLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68EA860", Offset = "0x68E9A60", VA = "0x1868EA860")]
		private void EBIALNHDDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68EB200", Offset = "0x68EA400", VA = "0x1868EB200")]
		private void MMJAKENBBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68EB5C0", Offset = "0x68EA7C0", VA = "0x1868EB5C0")]
		protected void POANLBKNFCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68EA720", Offset = "0x68E9920", VA = "0x1868EA720")]
		private void CDPFPEPOAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "12")]
		protected virtual void LEFHGMOLFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "13")]
		protected virtual void ELGNBALGEMP(Material FCJNMBKENDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "14")]
		protected virtual void MCDMDFKMKED(Material FCJNMBKENDK, bool CMIINBJIIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68EAEB0", Offset = "0x68EA0B0", VA = "0x1868EAEB0")]
		private void KKMHAFNKOOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
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
		private static readonly int IBODEAPNLLM;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int PDDOCFOOBPK;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int MACKBKFAAPB;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int HAHLOAPDMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
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
		private Color[] OAJOLGODGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] NPFNCMFPFCD;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic BFMEMCDAABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool PPFAEGEHGCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> OFDJCILAIFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 DBNNONHHNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x68EC2F0", Offset = "0x68EB4F0", VA = "0x1868EC2F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x68EC310", Offset = "0x68EB510", VA = "0x1868EC310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68EBF30", Offset = "0x68EB130", VA = "0x1868EBF30")]
		public void SetRingLayers(IReadOnlyList<RingLayer> GNJPAOFHMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x68EBCF0", Offset = "0x68EAEF0", VA = "0x1868EBCF0")]
		public bool SetRingLayerColor(int OFPJHGLBOBN, Color DKDNEEAJCMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68EBE40", Offset = "0x68EB040", VA = "0x1868EBE40")]
		public bool SetRingLayerSize(int OFPJHGLBOBN, float DKMFLNHKFDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x68EBB60", Offset = "0x68EAD60", VA = "0x1868EBB60", Slot = "12")]
		protected override void LEFHGMOLFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68EB9E0", Offset = "0x68EABE0", VA = "0x1868EB9E0", Slot = "13")]
		protected override void ELGNBALGEMP(Material FCJNMBKENDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x68EBCA0", Offset = "0x68EAEA0", VA = "0x1868EBCA0", Slot = "14")]
		protected override void MCDMDFKMKED(Material FCJNMBKENDK, bool CMIINBJIIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x68EC080", Offset = "0x68EB280", VA = "0x1868EC080")]
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
		public enum JJHEMCFEMNP
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int OPIHCMPBIGO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int JHGJLBCPGFJ;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int PKKJGDAGHLE;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int ABJHBOKHGAI;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int MHHIEEMCOAE;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int FAOCEPKNBDM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int DMNOBFLCKKL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int GAAEIAPPHFI;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int ABPDIHNBHEL;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int PECDOPLGHLO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int MBIHGHJMKHM;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int NJBNLNJPJLN;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int NFDFDOPPGHH;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int PCNIKAMBMDD;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int BNEJGFGDOJB;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GMGNAEPADDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
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
		private JJHEMCFEMNP animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[HCLAHHHOAJN("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[HCLAHHHOAJN("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic BFMEMCDAABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool PPFAEGEHGCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite AMPOBNPGOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x68ED180", Offset = "0x68EC380", VA = "0x1868ED180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x68ED3A0", Offset = "0x68EC5A0", VA = "0x1868ED3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color ALEDFFAFCOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA11E80", Offset = "0xA11080", VA = "0x180A11E80")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x68ED430", Offset = "0x68EC630", VA = "0x1868ED430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color FLIFIFLKKNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1C31200", Offset = "0x1C30400", VA = "0x181C31200")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x68ED270", Offset = "0x68EC470", VA = "0x1868ED270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float OIJNOBLHOLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA10", Offset = "0xA79C10", VA = "0x180A7AA10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x68ED330", Offset = "0x68EC530", VA = "0x1868ED330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 ICIPCHJFFNN
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x68ED160", Offset = "0x68EC360", VA = "0x1868ED160")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x68ED350", Offset = "0x68EC550", VA = "0x1868ED350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float DAFNKFGPHDC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7D6310", Offset = "0x7D5510", VA = "0x1807D6310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x68ED2F0", Offset = "0x68EC4F0", VA = "0x1868ED2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 MFALDKMBGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB2E820", Offset = "0xB2DA20", VA = "0x180B2E820")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x68ED4B0", Offset = "0x68EC6B0", VA = "0x1868ED4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float EELNGOMJHFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB36230", Offset = "0xB35430", VA = "0x180B36230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x68ED240", Offset = "0x68EC440", VA = "0x1868ED240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 IDPGJEHOFLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x68ECA60", Offset = "0x68EBC60", VA = "0x1868ECA60")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public JJHEMCFEMNP EIIIMJDFBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAE2140", Offset = "0xAE1340", VA = "0x180AE2140")]
			get
			{
				return default(JJHEMCFEMNP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x68ED260", Offset = "0x68EC460", VA = "0x1868ED260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float IJGBDJAEFAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xBF9F10", Offset = "0xBF9110", VA = "0x180BF9F10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x68ED310", Offset = "0x68EC510", VA = "0x1868ED310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float NNJEOHMOGNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xBFA060", Offset = "0xBF9260", VA = "0x180BFA060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x68ED220", Offset = "0x68EC420", VA = "0x1868ED220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x68EC360", Offset = "0x68EB560", VA = "0x1868EC360", Slot = "13")]
		protected override void ELGNBALGEMP(Material FCJNMBKENDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x68ECB40", Offset = "0x68EBD40", VA = "0x1868ECB40")]
		private void NMLEJIBLLBO(Sprite IPPBMALNFBG, [Out] Vector2 ECNGHNGJBFC, [Out] Vector2 FKOABOBGBOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68ECAF0", Offset = "0x68EBCF0", VA = "0x1868ECAF0", Slot = "14")]
		protected override void MCDMDFKMKED(Material FCJNMBKENDK, bool CMIINBJIIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68ED0D0", Offset = "0x68EC2D0", VA = "0x1868ED0D0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader HKCPFALNPEJ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader OOKOIFOBAPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x68ED550", Offset = "0x68EC750", VA = "0x1868ED550", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68ED500", Offset = "0x68EC700", VA = "0x1868ED500")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OIELFMDAPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct CDHEKGIJDAA : IEquatable<CDHEKGIJDAA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component HFFDKMJEBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action LDDJPNJDBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int DNBDEJMENOP;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component MLAEABNMBBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68E5440", Offset = "0x68E4640", VA = "0x1868E5440")]
		public CDHEKGIJDAA(Component HFFDKMJEBIA, Action LDDJPNJDBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68E53C0", Offset = "0x68E45C0", VA = "0x1868E53C0")]
		public void PABGJEDHKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x68E53B0", Offset = "0x68E45B0", VA = "0x1868E53B0", Slot = "4")]
		public bool Equals(CDHEKGIJDAA NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68E5320", Offset = "0x68E4520", VA = "0x1868E5320", Slot = "0")]
		public override bool Equals(object MFLACBLODGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NFPPMMJAFDA : IEnumerator<DHJAFLNNJKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private DHJAFLNNJKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public OIELFMDAPBE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private DHJAFLNNJKE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public NFPPMMJAFDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x68E6D30", Offset = "0x68E5F30", VA = "0x1868E6D30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68E70F0", Offset = "0x68E62F0", VA = "0x1868E70F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly AMGLBFPAKKD JIKCEFPAKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int IFCGKCEFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int LEOLLJANLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> ADBFMOPGFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, CDHEKGIJDAA> FDDKGDMDNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<CDHEKGIJDAA> ELAIKAJPKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<CDHEKGIJDAA> CHADLABAONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EKIPFMKCMNP AGINPPEIKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private BGEDJPEDFIP LGOOAINFMPG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private BGEDJPEDFIP OMANBLBJFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x68E7660", Offset = "0x68E6860", VA = "0x1868E7660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x68E7E60", Offset = "0x68E7060", VA = "0x1868E7E60")]
	public OIELFMDAPBE(AMGLBFPAKKD JIKCEFPAKFA, int IFCGKCEFOFI = -1, int LEOLLJANLCL = -1, [Optional] Func<Component, float> ADBFMOPGFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x68E7B80", Offset = "0x68E6D80", VA = "0x1868E7B80")]
	public void KKONILPKLPK(Component HFFDKMJEBIA, Action ECMAAOKDBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68E79F0", Offset = "0x68E6BF0", VA = "0x1868E79F0")]
	public void GOPMCJLDLLI(Component HFFDKMJEBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68E76D0", Offset = "0x68E68D0", VA = "0x1868E76D0")]
	public bool BPMPDGBFEII(Component OLMPJIPAILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68E77B0", Offset = "0x68E69B0", VA = "0x1868E77B0")]
	private void ECAKAKOKHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x68E7730", Offset = "0x68E6930", VA = "0x1868E7730")]
	[IteratorStateMachine(typeof(NFPPMMJAFDA))]
	private IEnumerator<DHJAFLNNJKE> CFFCBPIKHPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x952F80", Offset = "0x952180", VA = "0x180952F80")]
	[CompilerGenerated]
	private void GILCEMEJKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x68E7DE0", Offset = "0x68E6FE0", VA = "0x1868E7DE0")]
	[CompilerGenerated]
	private float PJNKIIOPFLM(CDHEKGIJDAA ECMAAOKDBON)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JECFGECIINF
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	INHBDMGKIGB IALEMHEBFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool CJDAEGOALKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	APOAGECOPGB<INHBDMGKIGB> HCNIAFBALDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMPKMKEDJKK(INHBDMGKIGB OKEHOKIIBML, bool IEHIHOGHJHG = false);
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
