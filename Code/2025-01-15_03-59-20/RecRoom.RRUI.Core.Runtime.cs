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
				[Cpp2IlInjected.Address(RVA = "0x78FCF10", Offset = "0x78FC310", VA = "0x1878FCF10")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x78FCF70", Offset = "0x78FC370", VA = "0x1878FCF70")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x78FCED0", Offset = "0x78FC2D0", VA = "0x1878FCED0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x78FCA10", Offset = "0x78FBE10", VA = "0x1878FCA10")]
			public void FDPGJKLAGDO(PointerEventData NLPHHMBGCOO, RectTransform HMPKPJDDGPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x78FCB60", Offset = "0x78FBF60", VA = "0x1878FCB60")]
			public void GLFOANGINCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x78FCDF0", Offset = "0x78FC1F0", VA = "0x1878FCDF0")]
			public void MLMCOLPEEMF(PointerEventData NLPHHMBGCOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x78FCB10", Offset = "0x78FBF10", VA = "0x1878FCB10")]
			public void FGGFHDEJKNE(float INHHJLEGKNB, RectTransform HMPKPJDDGPD, Vector3 ENJPHPPLHAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly FABEAAEBPBG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FABEAAEBPBG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly FABEAAEBPBG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly FABEAAEBPBG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FABEAAEBPBG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly MIPKPFFHABJ PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData GJILJMMDAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool BNIDKDLOEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool MLAMDHLIIDN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CODCPGOFPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DC0", Offset = "0x8D01C0", VA = "0x1808D0DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x78FC250", Offset = "0x78FB650", VA = "0x1878FC250")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HNJLHNAAODM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8D0C90", Offset = "0x8D0090", VA = "0x1808D0C90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x78FC1A0", Offset = "0x78FB5A0", VA = "0x1878FC1A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x78FC1D0", Offset = "0x78FB5D0", VA = "0x1878FC1D0")]
		private bool KCCNCFCGGGP(PointerEventData IAAPABJLNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78FC6D0", Offset = "0x78FBAD0", VA = "0x1878FC6D0", Slot = "5")]
		public void OnPointerDown(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x78FC790", Offset = "0x78FBB90", VA = "0x1878FC790", Slot = "11")]
		public void OnPointerUp(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78FC540", Offset = "0x78FB940", VA = "0x1878FC540", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78FC280", Offset = "0x78FB680", VA = "0x1878FC280", Slot = "7")]
		public void OnBeginDrag(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78FC390", Offset = "0x78FB790", VA = "0x1878FC390", Slot = "4")]
		public void OnDrag(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78FC470", Offset = "0x78FB870", VA = "0x1878FC470", Slot = "8")]
		public void OnEndDrag(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78FC730", Offset = "0x78FBB30", VA = "0x1878FC730", Slot = "9")]
		public void OnPointerEnter(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x78FC760", Offset = "0x78FBB60", VA = "0x1878FC760", Slot = "10")]
		public void OnPointerExit(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78FC350", Offset = "0x78FB750", VA = "0x1878FC350")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78FC7F0", Offset = "0x78FBBF0", VA = "0x1878FC7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78F7820", Offset = "0x78F6C20", VA = "0x1878F7820")]
		public void SetCanvasSortingOrder(short EGGAIAGCNMH, bool ACMKDEIHJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData CNBCFFIAMIP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78F7AE0", Offset = "0x78F6EE0", VA = "0x1878F7AE0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78F79C0", Offset = "0x78F6DC0", VA = "0x1878F79C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78F7910", Offset = "0x78F6D10", VA = "0x1878F7910")]
		private void HOHNDDMEBII(GameObject KNDKNOGLFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78F7DC0", Offset = "0x78F71C0", VA = "0x1878F7DC0")]
		public void SetOptionsWithNoDefault(List<string> KLODBELJCDF, [Optional] string IPCNOINENNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78F7CD0", Offset = "0x78F70D0", VA = "0x1878F7CD0")]
		public void SetOptionsWithNoDefault(List<OptionData> MFKLHLPHDGD, [Optional] string IPCNOINENNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78F7C00", Offset = "0x78F7000", VA = "0x1878F7C00", Slot = "42")]
		public override void OnPointerClick(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas IOFKCACCOAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78F7FE0", Offset = "0x78F73E0", VA = "0x1878F7FE0")]
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
		private sealed class FHDGCLLPPFO : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public FHDGCLLPPFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x78F8030", Offset = "0x78F7430", VA = "0x1878F8030", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x78F8540", Offset = "0x78F7940", VA = "0x1878F8540", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[KHGLLLAOHAN(PGGKFLBMAKK.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly JNFLJAOLJJI<object> EACCEOGCGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool IMCNJNBOJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? KGJDKJIFEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? BENJPDBOHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? IAICBMBPEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool KGEPNDLCBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool KONACMLPFAE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KAHKOBAJGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x78F9050", Offset = "0x78F8450", VA = "0x1878F9050", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KDNDEHAHJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x78F9000", Offset = "0x78F8400", VA = "0x1878F9000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AGICCAKPPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9118D0", Offset = "0x910CD0", VA = "0x1809118D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x78F9210", Offset = "0x78F8610", VA = "0x1878F9210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HABGIGPHPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x78F8F60", Offset = "0x78F8360", VA = "0x1878F8F60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x78F9170", Offset = "0x78F8570", VA = "0x1878F9170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78F89A0", Offset = "0x78F7DA0", VA = "0x1878F89A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78F8D40", Offset = "0x78F8140", VA = "0x1878F8D40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78F8CF0", Offset = "0x78F80F0", VA = "0x1878F8CF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x78F8B60", Offset = "0x78F7F60", VA = "0x1878F8B60")]
		public void Hide(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78F8EC0", Offset = "0x78F82C0", VA = "0x1878F8EC0")]
		public void Show(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78F8DD0", Offset = "0x78F81D0", VA = "0x1878F8DD0")]
		public void Set(object CMNJCPJBHGE, bool NGLCLDMHMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78F8AB0", Offset = "0x78F7EB0", VA = "0x1878F8AB0")]
		public void Clear(bool DPIOHMMFDHC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78F8B70", Offset = "0x78F7F70", VA = "0x1878F8B70")]
		private void NKJEKPHJAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78F8A30", Offset = "0x78F7E30", VA = "0x1878F8A30")]
		[IteratorStateMachine(typeof(FHDGCLLPPFO))]
		private IEnumerator<ONHNFKGBFKG> CHBIOABEPEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78F8B20", Offset = "0x78F7F20", VA = "0x1878F8B20", Slot = "5")]
		public virtual void DoHideOrShow(bool HPKOFPMOIEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78F8ED0", Offset = "0x78F82D0", VA = "0x1878F8ED0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KKPGONKJGAI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8CE810", Offset = "0x8CDC10", VA = "0x1808CE810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> APPNPNIOHPK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x78F9370", Offset = "0x78F8770", VA = "0x1878F9370")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x78F94D0", Offset = "0x78F88D0", VA = "0x1878F94D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> KHGGOPPOJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x78F9420", Offset = "0x78F8820", VA = "0x1878F9420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x78F9580", Offset = "0x78F8980", VA = "0x1878F9580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x78F9330", Offset = "0x78F8730", VA = "0x1878F9330", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x78F9350", Offset = "0x78F8750", VA = "0x1878F9350", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1280800", Offset = "0x127FC00", VA = "0x181280800")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1280800", Offset = "0x127FC00", VA = "0x181280800")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OONJCFHLMKN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DPAHOPBCHKI
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static GMAGBLHDHPN MOOGDCNOPIG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static GMAGBLHDHPN FHBDCDMPPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x78F9FE0", Offset = "0x78F93E0", VA = "0x1878F9FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static DPAHOPBCHKI LIDKAKHPOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x78FA3E0", Offset = "0x78F97E0", VA = "0x1878FA3E0")]
		get
		{
			return default(DPAHOPBCHKI);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78FA280", Offset = "0x78F9680", VA = "0x1878FA280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<DPAHOPBCHKI> CHJNGGMPOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78FA1B0", Offset = "0x78F95B0", VA = "0x1878FA1B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x78FA0E0", Offset = "0x78F94E0", VA = "0x1878FA0E0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEJILGJANCL : MMEEJDMFAJP, HAOHOHNEFEJ, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, FOPBHNMPPLH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	MIPKPFFHABJ MHDKLLPIAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JNDAODDCIHF Clear();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject FIDMHGJFAFJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JNDAODDCIHF Spawn<T>(int LKJNIGDLHMF, IReadOnlyList<T> JGCOLLOOLHL, GameObject FIDMHGJFAFJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JNDAODDCIHF Spawn<T>(int LKJNIGDLHMF, IReadOnlyList<T> JGCOLLOOLHL, GameObject EPCKAIFNIAH, Func<int, GameObject> EEPBAJMOPIE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int IIACLAMOIEE, float EGJIEDFEAPF);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum PBPOCENPOKB : byte
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
		private static readonly int OAONDAAIJJN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<PBPOCENPOKB, string> MJEAIHNDKGI;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int MJKNLNMIMKE = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int CPDJHDEHCIN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int AGLPLNGPLDG;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int OHMFPGMPKCM;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int IHFBOFFIHGJ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int GOONHDAHGPN;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int MLOEJEAGNAG;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int GLHPBBLBHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool DJOJNKPLDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool FJEFJDAAPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] AEPLAEHMIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private PBPOCENPOKB type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly PBPOCENPOKB[] FHOPPGDKGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[HFJGENLBJBK("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly PBPOCENPOKB[] OPLFGFOOMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[HFJGENLBJBK("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[HFJGENLBJBK("type", PBPOCENPOKB.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[HFJGENLBJBK("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic PJAJBADICAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool MAGOIADKMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient PIEMKOHBKME
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x78FBFF0", Offset = "0x78FB3F0", VA = "0x1878FBFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public PBPOCENPOKB KBPCMAIENME
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAE8480", Offset = "0xAE7880", VA = "0x180AE8480")]
			get
			{
				return default(PBPOCENPOKB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x78FC170", Offset = "0x78FB570", VA = "0x1878FC170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool IGHJCBOBNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x78FB000", Offset = "0x78FA400", VA = "0x1878FB000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 NPBGNPJNJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x78FBF60", Offset = "0x78FB360", VA = "0x1878FBF60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x78FBFA0", Offset = "0x78FB3A0", VA = "0x1878FBFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool HMHNNFOOILD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x78FA9D0", Offset = "0x78F9DD0", VA = "0x1878FA9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 DPCBCCMILLG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x78FBF80", Offset = "0x78FB380", VA = "0x1878FBF80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x78FC120", Offset = "0x78FB520", VA = "0x1878FC120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float ANDJAGIMJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xC80050", Offset = "0xC7F450", VA = "0x180C80050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1B5CA00", Offset = "0x1B5BE00", VA = "0x181B5CA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 ANCDKABHJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x78FB070", Offset = "0x78FA470", VA = "0x1878FB070")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 LFEFOANIALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x78FAA40", Offset = "0x78F9E40", VA = "0x1878FAA40")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float KDOIIFFFEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8E1EF0", Offset = "0x8E12F0", VA = "0x1808E1EF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x78FC180", Offset = "0x78FB580", VA = "0x1878FC180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x78FAAB0", Offset = "0x78F9EB0", VA = "0x1878FAAB0", Slot = "12")]
		protected override void DBBKKDKJOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x78FAC50", Offset = "0x78FA050", VA = "0x1878FAC50")]
		private void GKDFOEEFMOM(Color[] AJNPNIPCAKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x78FB0C0", Offset = "0x78FA4C0", VA = "0x1878FB0C0", Slot = "13")]
		protected override void PLCHDCJIEFA(Material BEDNCOELNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x78FADE0", Offset = "0x78FA1E0", VA = "0x1878FADE0", Slot = "14")]
		protected override void NIFELHMNLGK(Material BEDNCOELNMN, bool JCDOMELOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78FBEB0", Offset = "0x78FB2B0", VA = "0x1878FBEB0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly LPIBCNIIJKI EGAIFMPKEKK;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite CAEAPNKCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material CPBDFNNHCGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material HOJIELBCNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool EJMIFFLLEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool IMCNJNBOJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool IEDJFBHKMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool LPGCJAILGBC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic PJAJBADICAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader NDACCPMCFKK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool MAGOIADKMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool JJOHCAGMOID
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform HMPKPJDDGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x78FD350", Offset = "0x78FC750", VA = "0x1878FD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect JENCENGCHME
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x78FD3E0", Offset = "0x78FC7E0", VA = "0x1878FD3E0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite ECMBKKGFFAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x78FD640", Offset = "0x78FCA40", VA = "0x1878FD640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x78FD160", Offset = "0x78FC560", VA = "0x1878FD160", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x78FE120", Offset = "0x78FD520", VA = "0x1878FE120", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x78FE420", Offset = "0x78FD820", VA = "0x1878FE420", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78FE2D0", Offset = "0x78FD6D0", VA = "0x1878FE2D0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x78FDCE0", Offset = "0x78FD0E0", VA = "0x1878FDCE0")]
		private void LCBBDHDMEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x78FDB70", Offset = "0x78FCF70", VA = "0x1878FDB70")]
		private void KMIBFALIELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x78FD3B0", Offset = "0x78FC7B0", VA = "0x1878FD3B0")]
		private void DNDLMGJGKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x78FE0D0", Offset = "0x78FD4D0", VA = "0x1878FE0D0")]
		private void NJKEIGAIMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x78FDE70", Offset = "0x78FD270", VA = "0x1878FDE70")]
		protected void NJBKGKPMOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x78FD500", Offset = "0x78FC900", VA = "0x1878FD500")]
		private void GMDFFGFDCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "12")]
		protected virtual void DBBKKDKJOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "13")]
		protected virtual void PLCHDCJIEFA(Material BEDNCOELNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "14")]
		protected virtual void NIFELHMNLGK(Material BEDNCOELNMN, bool JCDOMELOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x78FD820", Offset = "0x78FCC20", VA = "0x1878FD820")]
		private void IBKFOGLGMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
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
		private static readonly int JCDICMIAPCI;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int PHJIACEKDII;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int FKJBPOKKNHO;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int JJJHGCBJNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
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
		private Color[] AEPLAEHMIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] FGKIHCBKIKO;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic PJAJBADICAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool JJOHCAGMOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> JFHINEHGOJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 NPBGNPJNJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x78FEE50", Offset = "0x78FE250", VA = "0x1878FEE50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x78FEE70", Offset = "0x78FE270", VA = "0x1878FEE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x78FEB10", Offset = "0x78FDF10", VA = "0x1878FEB10")]
		public void SetRingLayers(IReadOnlyList<RingLayer> BPMDOOPCJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x78FE8D0", Offset = "0x78FDCD0", VA = "0x1878FE8D0")]
		public bool SetRingLayerColor(int HOGNIHDLFAI, Color IGJDLCJEHCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78FEA20", Offset = "0x78FDE20", VA = "0x1878FEA20")]
		public bool SetRingLayerSize(int HOGNIHDLFAI, float BGDDCGNLDBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x78FE5D0", Offset = "0x78FD9D0", VA = "0x1878FE5D0", Slot = "12")]
		protected override void DBBKKDKJOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x78FE760", Offset = "0x78FDB60", VA = "0x1878FE760", Slot = "13")]
		protected override void PLCHDCJIEFA(Material BEDNCOELNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x78FE710", Offset = "0x78FDB10", VA = "0x1878FE710", Slot = "14")]
		protected override void NIFELHMNLGK(Material BEDNCOELNMN, bool JCDOMELOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x78FEC60", Offset = "0x78FE060", VA = "0x1878FEC60")]
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
		public enum PAILEIHKBKK
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int LPMGCBMCGED;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int AFCGPDFEMOP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int IENOAPGMAOA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int GGJOAGBMHMM;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int GKDAPHCJKKM;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int FMNADKJEEIC;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int PHGKPAHOBDO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int LKGNNNEPAGK;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int IFENFFLLFIN;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int FNKKBEHDELL;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KMGHJGJFJIK;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int LDBHJBIFJCG;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int EODNOJONJCN;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int KPFHCNGAABO;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int OFLMIDBCFNE;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int JEDDPGGIFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
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
		private PAILEIHKBKK animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[HFJGENLBJBK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[HFJGENLBJBK("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic PJAJBADICAA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool JJOHCAGMOID
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite DNGCKJELNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x78FFC70", Offset = "0x78FF070", VA = "0x1878FFC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x78FFE90", Offset = "0x78FF290", VA = "0x1878FFE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color FGLIHKLNPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE8460", Offset = "0xAE7860", VA = "0x180AE8460")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x78FFF20", Offset = "0x78FF320", VA = "0x1878FFF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color MMFJLMECGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xC8EA70", Offset = "0xC8DE70", VA = "0x180C8EA70")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x78FFD60", Offset = "0x78FF160", VA = "0x1878FFD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float ABLOIALGMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xC80060", Offset = "0xC7F460", VA = "0x180C80060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x78FFE20", Offset = "0x78FF220", VA = "0x1878FFE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 OKHLNEACFDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x78FFC50", Offset = "0x78FF050", VA = "0x1878FFC50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x78FFE40", Offset = "0x78FF240", VA = "0x1878FFE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float KLPNABMJIFK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B50", Offset = "0x8E0F50", VA = "0x1808E1B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x78FFDE0", Offset = "0x78FF1E0", VA = "0x1878FFDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 PCIKJIMCAJF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x106F390", Offset = "0x106E790", VA = "0x18106F390")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x78FFFA0", Offset = "0x78FF3A0", VA = "0x1878FFFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float JOOEKFFOBIN
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC7A940", Offset = "0xC79D40", VA = "0x180C7A940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x78FFD30", Offset = "0x78FF130", VA = "0x1878FFD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 CBIFMFKGPHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x78FEEC0", Offset = "0x78FE2C0", VA = "0x1878FEEC0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public PAILEIHKBKK CEBGOFLCMBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA677E0", VA = "0x180A683E0")]
			get
			{
				return default(PAILEIHKBKK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x78FFD50", Offset = "0x78FF150", VA = "0x1878FFD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float AEBIPEGLIGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x11BDA20", Offset = "0x11BCE20", VA = "0x1811BDA20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x78FFE00", Offset = "0x78FF200", VA = "0x1878FFE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float GKHKGLNEDHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1155350", Offset = "0x1154750", VA = "0x181155350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x78FFD10", Offset = "0x78FF110", VA = "0x1878FFD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x78FF250", Offset = "0x78FE650", VA = "0x1878FF250", Slot = "13")]
		protected override void PLCHDCJIEFA(Material BEDNCOELNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x78FEF50", Offset = "0x78FE350", VA = "0x1878FEF50")]
		private void JEBBFNLDAEK(Sprite CEJAAOBJFDC, [Out] Vector2 AEHOLHEPADM, [Out] Vector2 FABKOLECIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x78FF200", Offset = "0x78FE600", VA = "0x1878FF200", Slot = "14")]
		protected override void NIFELHMNLGK(Material BEDNCOELNMN, bool JCDOMELOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x78FFBC0", Offset = "0x78FEFC0", VA = "0x1878FFBC0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader KKIDNPBMBAA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader NDACCPMCFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7900040", Offset = "0x78FF440", VA = "0x187900040", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78FFFF0", Offset = "0x78FF3F0", VA = "0x1878FFFF0")]
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
		private SerializableRectTransform AOEJEPKBKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool DEPAHEJCFFA;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78FA510", Offset = "0x78F9910", VA = "0x1878FA510")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x78FA7F0", Offset = "0x78F9BF0", VA = "0x1878FA7F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78FA6A0", Offset = "0x78F9AA0", VA = "0x1878FA6A0")]
		private void CDOFLCKMGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78FA720", Offset = "0x78F9B20", VA = "0x1878FA720")]
		private void NKJEKPHJAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LPIBCNIIJKI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct CHJIPPECCJO : IEquatable<CHJIPPECCJO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component NOIHGGNEIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action MABMIDLLKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int GPMLEEGCGHN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component NLOFPLJHNIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x78F77B0", Offset = "0x78F6BB0", VA = "0x1878F77B0")]
		public CHJIPPECCJO(Component NOIHGGNEIML, Action MABMIDLLKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x78F7730", Offset = "0x78F6B30", VA = "0x1878F7730")]
		public void POOMJEGGIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x78F7720", Offset = "0x78F6B20", VA = "0x1878F7720", Slot = "4")]
		public bool Equals(CHJIPPECCJO BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x78F7690", Offset = "0x78F6A90", VA = "0x1878F7690", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GGEJIOPFMGA : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public LPIBCNIIJKI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public GGEJIOPFMGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x78F8590", Offset = "0x78F7990", VA = "0x1878F8590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x78F8950", Offset = "0x78F7D50", VA = "0x1878F8950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JOFMHFKJPEL DEMMIJCLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int NCCLDIMAIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int AAJCGAEPMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> NMGGCKPOFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, CHJIPPECCJO> DOBPFMJLHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<CHJIPPECCJO> PPMMJPANONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<CHJIPPECCJO> LBGHMHEOBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GLHJGEGNDCM HNFGIBBIKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ELDCPMFDOPF MGMCOBDEGAF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private ELDCPMFDOPF FOOKADLJLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x78F9DD0", Offset = "0x78F91D0", VA = "0x1878F9DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x78F9E60", Offset = "0x78F9260", VA = "0x1878F9E60")]
	public LPIBCNIIJKI(JOFMHFKJPEL DEMMIJCLNKO, int NCCLDIMAIHC = -1, int AAJCGAEPMGD = -1, [Optional] Func<Component, float> NMGGCKPOFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x78F9B50", Offset = "0x78F8F50", VA = "0x1878F9B50")]
	public void KHGPIELJFNN(Component NOIHGGNEIML, Action CGENICICIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x78F9940", Offset = "0x78F8D40", VA = "0x1878F9940")]
	public void GGJFOIFPKDN(Component NOIHGGNEIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x78F9860", Offset = "0x78F8C60", VA = "0x1878F9860")]
	public bool DFKJNPPCBLB(Component HFEBDCHJGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x78F9630", Offset = "0x78F8A30", VA = "0x1878F9630")]
	private void ALOPDFLFMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x78F9AD0", Offset = "0x78F8ED0", VA = "0x1878F9AD0")]
	[IteratorStateMachine(typeof(GGEJIOPFMGA))]
	private IEnumerator<ONHNFKGBFKG> IPECCDIENKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x9FDA10", Offset = "0x9FCE10", VA = "0x1809FDA10")]
	[CompilerGenerated]
	private void AGFHHOAGCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x78F98C0", Offset = "0x78F8CC0", VA = "0x1878F98C0")]
	[CompilerGenerated]
	private float FJJANHBABPH(CHJIPPECCJO CGENICICIAO)
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
