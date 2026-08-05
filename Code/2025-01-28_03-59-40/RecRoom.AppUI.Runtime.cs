using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using MVVMDatabinding;
using RRUI;
using RRUI.Data;
using RRUI.Dialogs;
using RRUI.Navigation;
using RecRoom.AppUI.Data;
using RecRoom.Attributes;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7063720", Offset = "0x7062920", VA = "0x187063720", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[LNMBOPCLEEH]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<BKFGPPLDJIJ>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BKFGPPLDJIJ Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2442EB0", Offset = "0x24420B0", VA = "0x182442EB0")]
			public HighlightStyleAspectRatio()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AspectRatioFitter aspectRatioFitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private List<HighlightStyleAspectRatio> aspectRatios;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x704DC50", Offset = "0x704CE50", VA = "0x18704DC50", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x704DFF0", Offset = "0x704D1F0", VA = "0x18704DFF0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x704DD50", Offset = "0x704CF50", VA = "0x18704DD50")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "20")]
		protected override void OnDataUpdated(BKFGPPLDJIJ dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x704E0F0", Offset = "0x704D2F0", VA = "0x18704E0F0")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[LNMBOPCLEEH]
	public class CarouselHeightBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private LayoutElementSizeBinder.LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x704ED10", Offset = "0x704DF10", VA = "0x18704ED10", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x704EE30", Offset = "0x704E030", VA = "0x18704EE30", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x704F120", Offset = "0x704E320", VA = "0x18704F120")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[LNMBOPCLEEH]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x704F160", Offset = "0x704E360", VA = "0x18704F160", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x704F210", Offset = "0x704E410", VA = "0x18704F210")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[LNMBOPCLEEH]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x704F250", Offset = "0x704E450", VA = "0x18704F250", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x704F2F0", Offset = "0x704E4F0", VA = "0x18704F2F0")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[LNMBOPCLEEH]
	public class ConditionalPrefabSpawnBinder : BaseBinder<bool>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <LoadPrefab>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public ConditionalPrefabSpawnBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7062B50", Offset = "0x7061D50", VA = "0x187062B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private MultiPrefabSpawner prefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private AssetReference prefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private bool prependSpawnedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private PDBMJMIDPNE<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7050D20", Offset = "0x704FF20", VA = "0x187050D20", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7050F50", Offset = "0x7050150", VA = "0x187050F50", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7051080", Offset = "0x7050280", VA = "0x187051080", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7050EA0", Offset = "0x70500A0", VA = "0x187050EA0")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__7))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7051240", Offset = "0x7050440", VA = "0x187051240")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[LNMBOPCLEEH]
	public class HideableBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7053DE0", Offset = "0x7052FE0", VA = "0x187053DE0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7053E80", Offset = "0x7053080", VA = "0x187053E80")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[LNMBOPCLEEH]
	public class HtmlColorStringToColorBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private List<Image> targetList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Color htmlColor;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7053EC0", Offset = "0x70530C0", VA = "0x187053EC0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7054080", Offset = "0x7053280", VA = "0x187054080")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[LNMBOPCLEEH]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x705B9B0", Offset = "0x705ABB0", VA = "0x18705B9B0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x705BA40", Offset = "0x705AC40", VA = "0x18705BA40")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[LNMBOPCLEEH]
	public class RoomSourceUriLinkButtonBinder : BaseBinder<RoomListQueryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Uri targetUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool useQueryDataInUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[CGOLJFLDDGE("useQueryDataInUri")]
		private bool overrideQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private RoomListQueryData queryDataOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[CGOLJFLDDGE("overrideLoadSceneSource")]
		[SerializeField]
		private BKEBPJOBIEL loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private BCEFHNJDDKG vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x705DE10", Offset = "0x705D010", VA = "0x18705DE10", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x705E1A0", Offset = "0x705D3A0", VA = "0x18705E1A0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x705DFA0", Offset = "0x705D1A0", VA = "0x18705DFA0")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x705E280", Offset = "0x705D480", VA = "0x18705E280")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[LNMBOPCLEEH]
	public class VirtualizedScrollRectListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7062DF0", Offset = "0x7061FF0", VA = "0x187062DF0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7063060", Offset = "0x7062260", VA = "0x187063060", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70630F0", Offset = "0x70622F0", VA = "0x1870630F0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7063460", Offset = "0x7062660", VA = "0x187063460", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7063360", Offset = "0x7062560", VA = "0x187063360", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70632C0", Offset = "0x70624C0", VA = "0x1870632C0", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70631A0", Offset = "0x70623A0", VA = "0x1870631A0", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7063210", Offset = "0x7062410", VA = "0x187063210")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70636D0", Offset = "0x70628D0", VA = "0x1870636D0")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KOAHBHGKKPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string GOEAAFMGDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string> MIPCOMCHKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7058AB0", Offset = "0x7057CB0", VA = "0x187058AB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7058A00", Offset = "0x7057C00", VA = "0x187058A00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7058B60", Offset = "0x7057D60", VA = "0x187058B60")]
	protected void KLKAIMMBGDF([CallerMemberName] string LFNMBEJGJCH = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected KOAHBHGKKPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PLMAOIMLEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MPAJFOGCJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	double EFCHGKNHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NPCLBPPFOGE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NPHHGGENGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PKKABJHHLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AEJLNDNFINA HNHNHIPBHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FFBHKFEHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GGMAHMICIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HDIFLBEGPGH;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEBDILIFNEH();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIGIGLPHMME();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMMIPGHNPPP();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HPJEELECOGO();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GKBFPBFKAHA : PLMAOIMLEIA
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static string COBMPCHGKBI;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static string HGBNKALEELD;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static string EFOJHNFKLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private DEGKPLDMDPH MODLCDELJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool? IBOCKEOGBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private double? OAKGEHNPPFL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MPAJFOGCJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7052380", Offset = "0x7051580", VA = "0x187052380", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double EFCHGKNHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70520F0", Offset = "0x70512F0", VA = "0x1870520F0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7052290", Offset = "0x7051490", VA = "0x187052290")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	[UnityEngine.Scripting.Preserve]
	internal GKBFPBFKAHA([NotNull][FMJHJHHALCB(null)] DEGKPLDMDPH MODLCDELJFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AOMACMDHNJF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LAAENINCFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool FMDCAMPPMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KDDOFLCNENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool AJIGDEIMOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BCEFHNJDDKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	LDFCGIKJOLB NPLDGLOLBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool AHFJIMBNKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MCCFKGEGNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	long ANBHAJBEADG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool KGMOBHHOBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JJEMNDGOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NFKIJEIOPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int GMKCJMMJLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BIPKEDJGDFE(BrowserModel LBGIMJJNDHO, Uri MMLIIHENJDP);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFCFJCKAJHJ(BrowserModel LBGIMJJNDHO, Uri OALKPAGBJMB, RoomListQueryData APCBJIPDHLK, bool ICOKOJIIFKJ = false, BKEBPJOBIEL MFABFKLHCLP = BKEBPJOBIEL.NOT_SET);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string BDEPPGCKKDO(RoomListQueryData APCBJIPDHLK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string PAJHBODLMBH(RoomListQueryData APCBJIPDHLK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BKFGPPLDJIJ POMONLAFALA(string PMBIJJGFHCI, [Optional] string NGCECCKMBGE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task GHDIFJFPJEA(IMJGKDJGPIG.PEMFBPJEIIL OGMFHNEAMII);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool ODJJIGMNKDB(BrowserModel LBGIMJJNDHO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IMNFGGEDIDO([Out] DBOBDIFJBBN<bool> AKPLHEPHKKO);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PFIOFJCFODG(string PMBHIKIJPOE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<bool> LOMOKFEHKLG(long MOMKFNIIPAA, CancellationToken BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<CNMPJHKKKIM> MCFPBIDCDIO(OAOBEPBAJLE BGDELDLHBMB, CancellationToken BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CKDHBLGELIE(ADGABPOJFPO PBPEOMJKKKC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task JEAJGAHKMCA(DialogListModel BALGFLNFJCJ, KAFHAFBGCFO NFLNABLBKGF, CancellationToken BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool BMPGGJILAJM(bool MIJEPFGGIJG);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ODLKMGBOOLL(BrowserModel LBGIMJJNDHO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum OFIOLONGALF
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Club,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	StoreItem,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Account
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum BKFGPPLDJIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Scale150,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Portrait,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Scale75,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Scale100
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public GJKOFLMPCIN platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public BKFGPPLDJIJ HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			[ReadOnlyField]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public OFIOLONGALF CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			[ReadOnlyField]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[FormerlySerializedAs("rowBottomPadding")]
			[Tooltip("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			public int rowPaddingBottom;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HGLJGJCAFOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public BrowserModel browserModel;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HGLJGJCAFOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7052D70", Offset = "0x7051F70", VA = "0x187052D70")]
			internal bool OCIDCDDDELG(Uri uri)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HPGBBLGDHHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public OFIOLONGALF carouselType;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HPGBBLGDHHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x704D830", Offset = "0x704CA30", VA = "0x18704D830")]
			internal bool PHPEJNEGINH(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class KCKINODMLBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public OFIOLONGALF carouselType;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public KCKINODMLBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x704D830", Offset = "0x704CA30", VA = "0x18704D830")]
			internal bool OLNAHPJPEGE(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KKBHIDAEBMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public OFIOLONGALF carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public KKBHIDAEBMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x704D830", Offset = "0x704CA30", VA = "0x18704D830")]
			internal bool PGEJMKMDEID(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NKOBBBOKIKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public OFIOLONGALF carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public NKOBBBOKIKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x704D830", Offset = "0x704CA30", VA = "0x18704D830")]
			internal bool GBGHBMODGEK(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class AAEOHFPJGEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public OFIOLONGALF carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public AAEOHFPJGEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x704D830", Offset = "0x704CA30", VA = "0x18704D830")]
			internal bool MGDFDLFDJGO(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class KKOBLIJKODC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public BKFGPPLDJIJ highlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool isInVRDisplayMode;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public KKOBLIJKODC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x70589B0", Offset = "0x7057BB0", VA = "0x1870589B0")]
			internal bool IOFCHBPHPFH(HighlightCardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		[SerializeField]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		[Tooltip("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BCEFHNJDDKG vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x704EAD0", Offset = "0x704DCD0", VA = "0x18704EAD0")]
		public bool ODCCDJAKNAC(BrowserModel LBGIMJJNDHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x704E600", Offset = "0x704D800", VA = "0x18704E600")]
		public float NJLABMEIMAD(BKFGPPLDJIJ IKIGMIGLPAJ, OFIOLONGALF CPKLIKEFIPK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x704E1E0", Offset = "0x704D3E0", VA = "0x18704E1E0")]
		public float DPJICKCAJGB(BKFGPPLDJIJ IKIGMIGLPAJ, OFIOLONGALF CPKLIKEFIPK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x704E740", Offset = "0x704D940", VA = "0x18704E740")]
		public float NMBLFDHNGOP(BKFGPPLDJIJ IKIGMIGLPAJ, OFIOLONGALF CPKLIKEFIPK, int JEEHOCCCENK = 1, bool MBJIBEKJFAO = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x704E380", Offset = "0x704D580", VA = "0x18704E380")]
		public RectOffset KCCKPCFJLMD(OFIOLONGALF CPKLIKEFIPK, int JEEHOCCCENK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x704EBB0", Offset = "0x704DDB0", VA = "0x18704EBB0")]
		public int PAPAIJELNJF(bool JMDCIEMNHDJ, BKFGPPLDJIJ IKIGMIGLPAJ, OFIOLONGALF CPKLIKEFIPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x704E350", Offset = "0x704D550", VA = "0x18704E350")]
		public int EBFIPEFNGHK(bool JMDCIEMNHDJ, BKFGPPLDJIJ IKIGMIGLPAJ, OFIOLONGALF CPKLIKEFIPK, int BIBEFALIFCF = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x704E130", Offset = "0x704D330", VA = "0x18704E130")]
		public int AAMDKNMLMNM(bool JMDCIEMNHDJ, BKFGPPLDJIJ IKIGMIGLPAJ, OFIOLONGALF CPKLIKEFIPK, int BIBEFALIFCF = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x704E470", Offset = "0x704D670", VA = "0x18704E470")]
		private HighlightCardDataObject LNMDAGEFFPA(BKFGPPLDJIJ IKIGMIGLPAJ)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x704ECF0", Offset = "0x704DEF0", VA = "0x18704ECF0")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private const int BHFCBDFLHFM = 20;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private const int GEBMFMGMBFO = 6;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const string HighlightStyleDefault = "highlight_default";

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public const string HighlightStyleScale150 = "highlight_scale_150";

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public const string HighlightStylePortrait = "highlight_portrait";

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public const string HighlightStyleScale75 = "highlight_scale_75";

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string HighlightStyleScale100 = "highlight_scale_100";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private OFIOLONGALF carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private GJKOFLMPCIN hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool JDOHPCDLKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int LAFEDMOJGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private float? BAMKHGMKKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private float? PLAFJPJAHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string FNGDNNADEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private BKFGPPLDJIJ IKIGMIGLPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private BCEFHNJDDKG POIDAFKFBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private BrowserModel LBGIMJJNDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private DiscoveryDisplayMetadata BGNPOBABJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private string PMBIJJGFHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int POMDEFEGAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int PGCAINCBPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<IDataItem> JIEMHGGKGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private DataItem<bool> BNCDIDMFBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private DataItem<int> LCLKAHNHMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private DataItem<float?> ACBOGGGHGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private DataItem<float?> EPMBCCIMLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private DataItem<string> FPFHFOCEOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private DataItem<BKFGPPLDJIJ> HPFPNGIIMNE;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool CPFIHCGDDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x901960", Offset = "0x900B60", VA = "0x180901960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x704F920", Offset = "0x704EB20", VA = "0x18704F920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int HGAFJDBCODI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCE9B30", Offset = "0xCE8D30", VA = "0x180CE9B30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x704F330", Offset = "0x704E530", VA = "0x18704F330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? CNMJLPHLDPN
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7050C00", Offset = "0x704FE00", VA = "0x187050C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[BindableData(3, "The width override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? CFJBALPFGOK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8F21C0", Offset = "0x8F13C0", VA = "0x1808F21C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7050C90", Offset = "0x704FE90", VA = "0x187050C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string EKJCMJCBKHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8F9230", Offset = "0x8F8430", VA = "0x1808F9230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x70508C0", Offset = "0x704FAC0", VA = "0x1870508C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public BKFGPPLDJIJ ILMIBIBNOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA921A0", Offset = "0xA913A0", VA = "0x180A921A0")]
			get
			{
				return default(BKFGPPLDJIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x704FED0", Offset = "0x704F0D0", VA = "0x18704FED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int MGCOCNDMJLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCECD50", Offset = "0xCEBF50", VA = "0x180CECD50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xCECD60", Offset = "0xCEBF60", VA = "0x180CECD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int OFGMAKBEJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xABC6E0", Offset = "0xABB8E0", VA = "0x180ABC6E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected override List<IDataItem> FGOBMIHKELO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7050BC0", Offset = "0x704FDC0", VA = "0x187050BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected override bool MPMMGFJCFOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x704F850", Offset = "0x704EA50", VA = "0x18704F850", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7050810", Offset = "0x704FA10", VA = "0x187050810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x704F980", Offset = "0x704EB80", VA = "0x18704F980")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata BGNPOBABJPM, string PMBIJJGFHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x704FD20", Offset = "0x704EF20", VA = "0x18704FD20")]
		private int IDCEJHOEEBD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x70505B0", Offset = "0x704F7B0", VA = "0x1870505B0")]
		private BKFGPPLDJIJ MKCJCFICKJF()
		{
			return default(BKFGPPLDJIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7050690", Offset = "0x704F890", VA = "0x187050690")]
		private void NAMBEFPAOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x704F380", Offset = "0x704E580", VA = "0x18704F380")]
		private void AEGANOJDHDE(int NDJFGEFFAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7050720", Offset = "0x704F920", VA = "0x187050720")]
		private string NECINBHOKEC(BKFGPPLDJIJ NLAOMDLPAIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x704FF30", Offset = "0x704F130", VA = "0x18704FF30", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x704FBC0", Offset = "0x704EDC0", VA = "0x18704FBC0")]
		private void GKNPOFDCGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7050930", Offset = "0x704FB30", VA = "0x187050930")]
		public CarouselViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x901960", Offset = "0x900B60", VA = "0x180901960")]
		[CompilerGenerated]
		private bool EEAMKPKEGGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x704F920", Offset = "0x704EB20", VA = "0x18704F920")]
		[CompilerGenerated]
		private void CBHDLOOLKEB(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCE9B30", Offset = "0xCE8D30", VA = "0x180CE9B30")]
		[CompilerGenerated]
		private int EFHEKGKONGJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x704F330", Offset = "0x704E530", VA = "0x18704F330")]
		[CompilerGenerated]
		private void AEBHEMFGBKA(int PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210")]
		[CompilerGenerated]
		private float? DONCIGCDMCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x70505A0", Offset = "0x704F7A0", VA = "0x1870505A0")]
		[CompilerGenerated]
		private void KKAGDGBINNF(float? PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8F21C0", Offset = "0x8F13C0", VA = "0x1808F21C0")]
		[CompilerGenerated]
		private float? KBMHAEJEDFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x704F910", Offset = "0x704EB10", VA = "0x18704F910")]
		[CompilerGenerated]
		private void BIHEKBCFILD(float? PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9230", Offset = "0x8F8430", VA = "0x1808F9230")]
		[CompilerGenerated]
		private string BOEPHOJKAKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x70508C0", Offset = "0x704FAC0", VA = "0x1870508C0")]
		[CompilerGenerated]
		private void PBNDMANPNIK(string PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA921A0", Offset = "0xA913A0", VA = "0x180A921A0")]
		[CompilerGenerated]
		private BKFGPPLDJIJ EGPOFGDNGCN()
		{
			return default(BKFGPPLDJIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x704FED0", Offset = "0x704F0D0", VA = "0x18704FED0")]
		[CompilerGenerated]
		private void IPFANDDAJBG(BKFGPPLDJIJ PBNOOPEKDOL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private BCEFHNJDDKG vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public string[] unsupportedPlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public string[] unsupportedInteractionCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool excludeJuniors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private LDFCGIKJOLB[] unsupportedPlatformTypes;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private LDFCGIKJOLB[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7051ED0", Offset = "0x70510D0", VA = "0x187051ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7051E70", Offset = "0x7051070", VA = "0x187051E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7051AA0", Offset = "0x7050CA0", VA = "0x187051AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7051B00", Offset = "0x7050D00", VA = "0x187051B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x23FAB50", Offset = "0x23F9D50", VA = "0x1823FAB50")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int KGEKDMBFAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private long FDEFIGKIDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private long PPMCCNHKJND;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int KKFAFGGDINP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x911450", Offset = "0x910650", VA = "0x180911450")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7052C60", Offset = "0x7051E60", VA = "0x187052C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long ANBHAJBEADG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7052D10", Offset = "0x7051F10", VA = "0x187052D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long GFJBBCJPGDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7052CB0", Offset = "0x7051EB0", VA = "0x187052CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7052AD0", Offset = "0x7051CD0", VA = "0x187052AD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7052970", Offset = "0x7051B70", VA = "0x187052970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7052810", Offset = "0x7051A10", VA = "0x187052810")]
		private void DGGKBBMBMHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7052610", Offset = "0x7051810", VA = "0x187052610")]
		private void CIJOLLLNAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7052C40", Offset = "0x7051E40", VA = "0x187052C40")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ViewModel]
	public class MakerPenHUDViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NPCLBPPFOGE LAEOFELKEIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private List<IDataItem> JIEMHGGKGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private DataItem<bool> KFELDKLMPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private DataItem<bool> NBPAAIOLEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private DataItem<bool> FACBJLHLMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private DataItem<bool> OFIKOCNMOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private DataItemAction KFENDAIGLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private DataItemAction AACFPFIPMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private DataItemAction CFHGFCIGIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private DataItemAction DMLFIOJCFAE;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool NPHHGGENGMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x705B160", Offset = "0x705A360", VA = "0x18705B160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool PKKABJHHLHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x705B1B0", Offset = "0x705A3B0", VA = "0x18705B1B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool FFBHKFEHKNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x705A940", Offset = "0x7059B40", VA = "0x18705A940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool GGMAHMICIHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x705A640", Offset = "0x7059840", VA = "0x18705A640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected override List<IDataItem> FGOBMIHKELO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x705B500", Offset = "0x705A700", VA = "0x18705B500", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool MPMMGFJCFOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x705A690", Offset = "0x7059890", VA = "0x18705A690", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x705B2B0", Offset = "0x705A4B0", VA = "0x18705B2B0")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x705B260", Offset = "0x705A460", VA = "0x18705B260")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x705ABA0", Offset = "0x7059DA0", VA = "0x18705ABA0")]
		private void HLGBCPOODGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x705AB50", Offset = "0x7059D50", VA = "0x18705AB50")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x705AB00", Offset = "0x7059D00", VA = "0x18705AB00")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x705B200", Offset = "0x705A400", VA = "0x18705B200")]
		private void NAFJMAJDNHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x705AC00", Offset = "0x7059E00", VA = "0x18705AC00", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x705A990", Offset = "0x7059B90", VA = "0x18705A990")]
		private void GKNPOFDCGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x705B300", Offset = "0x705A500", VA = "0x18705B300")]
		public MakerPenHUDViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x705B160", Offset = "0x705A360", VA = "0x18705B160")]
		[CompilerGenerated]
		private bool KODNPKNNHKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x705B1B0", Offset = "0x705A3B0", VA = "0x18705B1B0")]
		[CompilerGenerated]
		private bool LCLHKPOKCFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x705A940", Offset = "0x7059B40", VA = "0x18705A940")]
		[CompilerGenerated]
		private bool BOMECKFDELJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x705A640", Offset = "0x7059840", VA = "0x18705A640")]
		[CompilerGenerated]
		private bool AJEJPOBBGOA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NFJILMHMEJO : KOAHBHGKKPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PNIOOCKILGF GOBLJIHJHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool KJCJGAPGOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int NGGNPHHLHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool PHGEFDIOHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int KEBFOLIDOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool CCAHKJFKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool CCDFHEJIPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool LHFJHFAFIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool BENDLHGLMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool KACLJDECJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool DDPNCLNLOLD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PNIOOCKILGF PFAHLCBMLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x705B880", Offset = "0x705AA80", VA = "0x18705B880")]
		get
		{
			return default(PNIOOCKILGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x705B530", Offset = "0x705A730", VA = "0x18705B530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FEPIGEGJHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x923770", Offset = "0x922970", VA = "0x180923770")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x705B820", Offset = "0x705AA20", VA = "0x18705B820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OLBGGMPPCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xCC4400", Offset = "0xCC3600", VA = "0x180CC4400")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x705B690", Offset = "0x705A890", VA = "0x18705B690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PKMLGCOJBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xC587C0", Offset = "0xC579C0", VA = "0x180C587C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x705B630", Offset = "0x705A830", VA = "0x18705B630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HBGNLHNODEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB1A850", Offset = "0xB19A50", VA = "0x180B1A850")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x705B760", Offset = "0x705A960", VA = "0x18705B760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool FCBGBIMDOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xBCE5C0", Offset = "0xBCD7C0", VA = "0x180BCE5C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x705B8C0", Offset = "0x705AAC0", VA = "0x18705B8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PJKDDFCHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6848570", Offset = "0x6847770", VA = "0x186848570")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x705B6F0", Offset = "0x705A8F0", VA = "0x18705B6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool BDMJOLJANEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x705B750", Offset = "0x705A950", VA = "0x18705B750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OKCNKOGGJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x14ED4B0", Offset = "0x14EC6B0", VA = "0x1814ED4B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x705B7C0", Offset = "0x705A9C0", VA = "0x18705B7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool IJMALGDBJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x14ECF80", Offset = "0x14EC180", VA = "0x1814ECF80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x705B5D0", Offset = "0x705A7D0", VA = "0x18705B5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x705B920", Offset = "0x705AB20", VA = "0x18705B920")]
	public NFJILMHMEJO()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, AOMACMDHNJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct DJCJANCMFMB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter<List<ADGABPOJFPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7051280", Offset = "0x7050480", VA = "0x187051280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private BCEFHNJDDKG POIDAFKFBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private BKEBPJOBIEL loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private BHNGCGAOKPE HDPHONDDHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private CancellationTokenSource BCFACPBIPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private BrowserModel LBGIMJJNDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private bool JKHEIIMCJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<long> JNAIFFABPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int MHIEIACAIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool JHEJOBLPAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DataList<long> MKGPENJKPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string PLOLMICDNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool IKHGDNHPBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NFJILMHMEJO LLFPMHPPIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<IDataItem> JIEMHGGKGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private DataItem<string> MKEALKFLGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private DataItem<bool> AHDPDDMMDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private DataItem<RoomListQueryData> PBAGOJFIHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private DataItem<NFJILMHMEJO> BMPIPDBBLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private DataItemList NJLCIIDCPLJ;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> BAMJFHGLGJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8F91C0", Offset = "0x8F83C0", VA = "0x1808F91C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x705DDA0", Offset = "0x705CFA0", VA = "0x18705DDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string FJLPIBJLKOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA8A360", Offset = "0xA89560", VA = "0x180A8A360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x705DD20", Offset = "0x705CF20", VA = "0x18705DD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool PFEIHHGIHCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCC4400", Offset = "0xCC3600", VA = "0x180CC4400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x705D350", Offset = "0x705C550", VA = "0x18705D350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData FHAFCGCKMHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public NFJILMHMEJO MJIMEIAHMLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB79F30", Offset = "0xB79130", VA = "0x180B79F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x705C120", Offset = "0x705B320", VA = "0x18705C120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool LAAENINCFKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xCEA760", Offset = "0xCE9960", VA = "0x180CEA760", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xCEA7D0", Offset = "0xCE99D0", VA = "0x180CEA7D0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool FMDCAMPPMJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x229A800", Offset = "0x2299A00", VA = "0x18229A800", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2297860", Offset = "0x2296A60", VA = "0x182297860", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool KDDOFLCNENB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x229A810", Offset = "0x2299A10", VA = "0x18229A810", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2299370", Offset = "0x2298570", VA = "0x182299370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool AJIGDEIMOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4C6C7B0", Offset = "0x4C6B9B0", VA = "0x184C6C7B0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4C71C70", Offset = "0x4C70E70", VA = "0x184C71C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool MIAFPJPCADH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xB2C4F0", Offset = "0xB2B6F0", VA = "0x180B2C4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public BKEBPJOBIEL NIJPPCHNPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xF4CFF0", Offset = "0xF4C1F0", VA = "0x180F4CFF0")]
			get
			{
				return default(BKEBPJOBIEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override List<IDataItem> FGOBMIHKELO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x705DCE0", Offset = "0x705CEE0", VA = "0x18705DCE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override bool MPMMGFJCFOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x705D820", Offset = "0x705CA20", VA = "0x18705D820")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x705D3B0", Offset = "0x705C5B0", VA = "0x18705D3B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x705D760", Offset = "0x705C960", VA = "0x18705D760")]
		public void SetQueryData(RoomListQueryData BPMMLNCGODG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x705D620", Offset = "0x705C820", VA = "0x18705D620")]
		public void SetDiscoverySectionId(string GEDGPNGNBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x705C8A0", Offset = "0x705BAA0", VA = "0x18705C8A0")]
		[AsyncStateMachine(typeof(DJCJANCMFMB))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x705D6D0", Offset = "0x705C8D0", VA = "0x18705D6D0")]
		public void SetMaxItems(int HJIBGPMPPNC, int FCAJOFEPBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x705D730", Offset = "0x705C930", VA = "0x18705D730")]
		public void SetMinItems(int LFABHIDPEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x705BA80", Offset = "0x705AC80", VA = "0x18705BA80")]
		private void AMBEAJOJOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x705D0E0", Offset = "0x705C2E0", VA = "0x18705D0E0")]
		private string LAGHFIAOPNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x229A800", Offset = "0x2299A00", VA = "0x18229A800")]
		private bool KLAOJOOFNCI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x705C190", Offset = "0x705B390", VA = "0x18705C190")]
		private void EKMFBLBLLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x705BFA0", Offset = "0x705B1A0", VA = "0x18705BFA0")]
		private void BFFIPMOEGBN(ImpressionTracker KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x705CAA0", Offset = "0x705BCA0", VA = "0x18705CAA0", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x705C950", Offset = "0x705BB50", VA = "0x18705C950")]
		private void GKNPOFDCGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x705D9C0", Offset = "0x705CBC0", VA = "0x18705D9C0")]
		public RoomListViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA8A360", Offset = "0xA89560", VA = "0x180A8A360")]
		[CompilerGenerated]
		private string IKLOBPKJKGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x705CA90", Offset = "0x705BC90", VA = "0x18705CA90")]
		[CompilerGenerated]
		private void HJECBNIDDIP(string PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xCC4400", Offset = "0xCC3600", VA = "0x180CC4400")]
		[CompilerGenerated]
		private bool PKKNMGNLHNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x705D350", Offset = "0x705C550", VA = "0x18705D350")]
		[CompilerGenerated]
		private void OGKDJGGKKIB(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0")]
		[CompilerGenerated]
		private RoomListQueryData IGFFBENBDFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xB79F30", Offset = "0xB79130", VA = "0x180B79F30")]
		[CompilerGenerated]
		private NFJILMHMEJO FBBKHCCICLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x705C120", Offset = "0x705B320", VA = "0x18705C120")]
		[CompilerGenerated]
		private void DPJCONJCOKI(NFJILMHMEJO PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8F91C0", Offset = "0x8F83C0", VA = "0x1808F91C0")]
		[CompilerGenerated]
		private DataList EDDENDJNOEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x705D550", Offset = "0x705C750", VA = "0x18705D550")]
		[CompilerGenerated]
		private void PAOMCIJNJCJ(DataList PBNOOPEKDOL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private struct IMOFELMKACA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private TaskAwaiter<ADGABPOJFPO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7054100", Offset = "0x7053300", VA = "0x187054100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct MMCGFFIJNPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private OAOBEPBAJLE <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private TaskAwaiter<OAOBEPBAJLE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7059E00", Offset = "0x7059000", VA = "0x187059E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class IBCEMPEMOFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public OAOBEPBAJLE roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public bool randomSubroom;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public IBCEMPEMOFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x70540C0", Offset = "0x70532C0", VA = "0x1870540C0")]
			internal void DLOOEHBDBBL()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct JKFEPIIHPCK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public OAOBEPBAJLE roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x7058420", Offset = "0x7057620", VA = "0x187058420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class GGAILJHJINP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public OAOBEPBAJLE roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public CNMPJHKKKIM subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public GGAILJHJINP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x7052000", Offset = "0x7051200", VA = "0x187052000")]
			internal void CKOHEKLODHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class BPCLIHLOIGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public GLPOHAHMIGG latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public GGAILJHJINP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public BPCLIHLOIGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x704D840", Offset = "0x704CA40", VA = "0x18704D840")]
			internal void MAOBGGEOFIB()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct KPBAGEFOIAM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public OAOBEPBAJLE roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private GGAILJHJINP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private BPCLIHLOIGE <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private TaskAwaiter<CNMPJHKKKIM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private DGCJNLNOHCD <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private TaskAwaiter<GLPOHAHMIGG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x7058B80", Offset = "0x7057D80", VA = "0x187058B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private const string LEHOECLKOHJ = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private const char BBLEIOKFEKF = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private BHNGCGAOKPE NEHAMENJHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DOBANDLDJLB EFJEGGEAPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private BCEFHNJDDKG POIDAFKFBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private CancellationTokenSource BCFACPBIPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private PNIOOCKILGF GOBLJIHJHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private BrowserModel LBGIMJJNDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private DialogListModel BALGFLNFJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int KGLJDONMEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int GHAGBOFCOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int COKGNHFKNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private bool CJPOCBLANMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DateTime? AOGJFPGFJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool DNIIADLMFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private long MOMKFNIIPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private string JJDGHGFHPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private string MEAHMKBIOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private string JEBBABKCJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool GJDJLCGPEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private string FHOHOHADNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private bool PFFMFDNHCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool NAJNMFFPMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private string LGIIJBOGGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private bool NHHEBCKLAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private bool MEAEFGMPGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x152")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private bool NOPLKPPOHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x153")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private bool JENJMFHEFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private bool FDLNOFOIMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x155")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool NIBEIAIJFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x156")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool CCDFHEJIPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x157")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool LCNLBPBFCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool KACLJDECJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool DDPNCLNLOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private List<IDataItem> JIEMHGGKGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private DataItem<long> IEHOEAGKBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DataItem<string> BJJFOGONCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private DataItem<string> PHIPCENGHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private DataItem<string> GBIJLAKMKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private DataItem<bool> KLIKNHOCKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DataItem<string> JDIJJKCDNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private DataItem<bool> MPMFBCBLKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private DataItem<bool> NPNBICKDDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private DataItem<string> MINJFLCCCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DataItem<bool> HKEIDPAHLAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private DataItem<bool> EAFMKPPFFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DataItem<bool> AHEEFIENEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private DataItem<bool> ACKLMDJALFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private DataItem<bool> CDCMAOOKBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private DataItem<bool> CODLBEOODKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private DataItem<bool> KOPJNCGHNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private DataItem<bool> PMEDHKFOEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private DataItem<bool> OMPMGHHPEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private DataItem<bool> AFGKFPPHKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private DataItemAction AMDBJOCMDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DataItemAction BPDGCNJNLJJ;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long KLKOLHDJPGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xBCC9F0", Offset = "0xBCBBF0", VA = "0x180BCC9F0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7062A50", Offset = "0x7061C50", VA = "0x187062A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string NPGAINIAFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xA03FE0", Offset = "0xA031E0", VA = "0x180A03FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7062950", Offset = "0x7061B50", VA = "0x187062950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string KFOBCGDCHKK
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x995C30", Offset = "0x994E30", VA = "0x180995C30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x70628D0", Offset = "0x7061AD0", VA = "0x1870628D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string KALIAHLPFOA
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x963E00", Offset = "0x963000", VA = "0x180963E00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x70629D0", Offset = "0x7061BD0", VA = "0x1870629D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool BKFAPJPGEHI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x968DE0", Offset = "0x967FE0", VA = "0x180968DE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7061B20", Offset = "0x7060D20", VA = "0x187061B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string MLDANNJLFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x966400", Offset = "0x965600", VA = "0x180966400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7062850", Offset = "0x7061A50", VA = "0x187062850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool JBCIOGKIFCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15B9D70", Offset = "0x15B8F70", VA = "0x1815B9D70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x705F600", Offset = "0x705E800", VA = "0x18705F600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool NGECCPLHFFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCF7710", Offset = "0xCF6910", VA = "0x180CF7710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x705EFF0", Offset = "0x705E1F0", VA = "0x18705EFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string MADONBNDEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x960D50", Offset = "0x95FF50", VA = "0x180960D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x70627D0", Offset = "0x70619D0", VA = "0x1870627D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool HBIMIKHEHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x16AEBB0", Offset = "0x16ADDB0", VA = "0x1816AEBB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x705F490", Offset = "0x705E690", VA = "0x18705F490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool AEKONJJAAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x17D2B40", Offset = "0x17D1D40", VA = "0x1817D2B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x705F5A0", Offset = "0x705E7A0", VA = "0x18705F5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool DCLKEAIHOCK
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x17D2B50", Offset = "0x17D1D50", VA = "0x1817D2B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x705F9D0", Offset = "0x705EBD0", VA = "0x18705F9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool IEJIHFBKOEL
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x705F050", Offset = "0x705E250", VA = "0x18705F050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x705FA30", Offset = "0x705EC30", VA = "0x18705FA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool NGDHKAMDHOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x1B58950", Offset = "0x1B57B50", VA = "0x181B58950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7061C30", Offset = "0x7060E30", VA = "0x187061C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool EEOABDIOGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x705EDB0", Offset = "0x705DFB0", VA = "0x18705EDB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x705F430", Offset = "0x705E630", VA = "0x18705F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool FCBGBIMDOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x70616B0", Offset = "0x70608B0", VA = "0x1870616B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7061C90", Offset = "0x7060E90", VA = "0x187061C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool HGLBGAFNAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x70616C0", Offset = "0x70608C0", VA = "0x1870616C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7061140", Offset = "0x7060340", VA = "0x187061140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool OKCNKOGGJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x1168880", Offset = "0x1167A80", VA = "0x181168880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7061650", Offset = "0x7060850", VA = "0x187061650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool IJMALGDBJJH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1D9E1D0", Offset = "0x1D9D3D0", VA = "0x181D9E1D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x70616D0", Offset = "0x70608D0", VA = "0x1870616D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool GKCHFFGLEMK
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7062700", Offset = "0x7061900", VA = "0x187062700", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x705EED0", Offset = "0x705E0D0", VA = "0x18705EED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected override List<IDataItem> FGOBMIHKELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x70626C0", Offset = "0x70618C0", VA = "0x1870626C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected override bool MPMMGFJCFOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ILoadable> NBNDJCIMKHM
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7062600", Offset = "0x7061800", VA = "0x187062600", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7062710", Offset = "0x7061910", VA = "0x187062710", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x705EDC0", Offset = "0x705DFC0", VA = "0x18705EDC0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7061EE0", Offset = "0x70610E0", VA = "0x187061EE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7061B80", Offset = "0x7060D80", VA = "0x187061B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7061E00", Offset = "0x7061000", VA = "0x187061E00", Slot = "12")]
		public override void SetBindingData(int DFEOMGGJCIJ, int JLMMKKDGEHI, int CPLNODNGKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x705F060", Offset = "0x705E260", VA = "0x18705F060")]
		private void DDEPKAGDGML(IDataSource GMMMMKOHNPH, int JLMMKKDGEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x705F4F0", Offset = "0x705E6F0", VA = "0x18705F4F0")]
		[AsyncStateMachine(typeof(IMOFELMKACA))]
		private void GAKKDIHLJGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x705FA90", Offset = "0x705EC90", VA = "0x18705FA90")]
		private void IACJOABGLLC(ADGABPOJFPO OLGBIEBNCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x705E2C0", Offset = "0x705D4C0", VA = "0x18705E2C0")]
		private void ADHDHPFCIFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7061730", Offset = "0x7060930", VA = "0x187061730")]
		private void NGJEGAJNHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x705EC00", Offset = "0x705DE00", VA = "0x18705EC00")]
		private void ADHMPJEDMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x70611A0", Offset = "0x70603A0", VA = "0x1870611A0")]
		[BindableAction(100, null)]
		private void LDJHKPKMJDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7061090", Offset = "0x7060290", VA = "0x187061090")]
		[AsyncStateMachine(typeof(MMCGFFIJNPM))]
		[BindableAction(101, null)]
		private void JHBAOHHOHPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x705EEF0", Offset = "0x705E0F0", VA = "0x18705EEF0")]
		[AsyncStateMachine(typeof(JKFEPIIHPCK))]
		private void BMNALFNJKHB(bool JDNCDKFOJGA, OAOBEPBAJLE BGDELDLHBMB, bool NLEMGKLPIPA = false, bool DJJJGLEKAGN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7061CF0", Offset = "0x7060EF0", VA = "0x187061CF0")]
		[AsyncStateMachine(typeof(KPBAGEFOIAM))]
		private void POOPPODIDCI(OAOBEPBAJLE BGDELDLHBMB, bool JDNCDKFOJGA, bool NLEMGKLPIPA, bool DJJJGLEKAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x705F260", Offset = "0x705E460", VA = "0x18705F260")]
		private void EKMFBLBLLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x705EC20", Offset = "0x705DE20", VA = "0x18705EC20")]
		private void AIPBPPLAPFJ(string OFJGBHACMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x705FEA0", Offset = "0x705F0A0", VA = "0x18705FEA0", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x705F660", Offset = "0x705E860", VA = "0x18705F660")]
		private void GKNPOFDCGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7061FA0", Offset = "0x70611A0", VA = "0x187061FA0")]
		public RoomViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xBCC9F0", Offset = "0xBCBBF0", VA = "0x180BCC9F0")]
		[CompilerGenerated]
		private long KOHPEANJOAD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7061B10", Offset = "0x7060D10", VA = "0x187061B10")]
		[CompilerGenerated]
		private void NOIFNHHCMGP(long PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA03FE0", Offset = "0xA031E0", VA = "0x180A03FE0")]
		[CompilerGenerated]
		private string JMEJBOIMBIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x995C30", Offset = "0x994E30", VA = "0x180995C30")]
		[CompilerGenerated]
		private string CJOAEAAGGJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x963E00", Offset = "0x963000", VA = "0x180963E00")]
		[CompilerGenerated]
		private string FEMMOOEPAFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7061640", Offset = "0x7060840", VA = "0x187061640")]
		[CompilerGenerated]
		private void LJDNLLDFODE(string PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x968DE0", Offset = "0x967FE0", VA = "0x180968DE0")]
		[CompilerGenerated]
		private bool JLNKODKFKAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7061B20", Offset = "0x7060D20", VA = "0x187061B20")]
		[CompilerGenerated]
		private void OBJEIOIBHJI(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x966400", Offset = "0x965600", VA = "0x180966400")]
		[CompilerGenerated]
		private string DPDPFMHPDPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x705FE90", Offset = "0x705F090", VA = "0x18705FE90")]
		[CompilerGenerated]
		private void IDFLLGLCHMM(string PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x15B9D70", Offset = "0x15B8F70", VA = "0x1815B9D70")]
		[CompilerGenerated]
		private bool KLKOAACBAHP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x705F600", Offset = "0x705E800", VA = "0x18705F600")]
		[CompilerGenerated]
		private void GJFCBMMGNJH(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xCF7710", Offset = "0xCF6910", VA = "0x180CF7710")]
		[CompilerGenerated]
		private bool JMALOBOBIPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x705EFF0", Offset = "0x705E1F0", VA = "0x18705EFF0")]
		[CompilerGenerated]
		private void CHEPLFBCIDH(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x960D50", Offset = "0x95FF50", VA = "0x180960D50")]
		[CompilerGenerated]
		private string IMFPCILNOPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x705EEE0", Offset = "0x705E0E0", VA = "0x18705EEE0")]
		[CompilerGenerated]
		private void BMCEMGIPLDA(string PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x16AEBB0", Offset = "0x16ADDB0", VA = "0x1816AEBB0")]
		[CompilerGenerated]
		private bool GNAAIICDBON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x705F490", Offset = "0x705E690", VA = "0x18705F490")]
		[CompilerGenerated]
		private void EOBMLDKBDBE(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x17D2B40", Offset = "0x17D1D40", VA = "0x1817D2B40")]
		[CompilerGenerated]
		private bool ABDEHPCDKLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x705F5A0", Offset = "0x705E7A0", VA = "0x18705F5A0")]
		[CompilerGenerated]
		private void GCHIAOGGDDF(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x17D2B50", Offset = "0x17D1D50", VA = "0x1817D2B50")]
		[CompilerGenerated]
		private bool MELFHOJAHJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x705F9D0", Offset = "0x705EBD0", VA = "0x18705F9D0")]
		[CompilerGenerated]
		private void HMDALFDIOKC(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x705F050", Offset = "0x705E250", VA = "0x18705F050")]
		[CompilerGenerated]
		private bool CNCKJLNMELB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x705FA30", Offset = "0x705EC30", VA = "0x18705FA30")]
		[CompilerGenerated]
		private void HOBPMAKFOLP(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1B58950", Offset = "0x1B57B50", VA = "0x181B58950")]
		[CompilerGenerated]
		private bool BIMJNMJFFFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7061C30", Offset = "0x7060E30", VA = "0x187061C30")]
		[CompilerGenerated]
		private void PIELMFOEFPF(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x705EDB0", Offset = "0x705DFB0", VA = "0x18705EDB0")]
		[CompilerGenerated]
		private bool AJGNNOMKOEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x705F430", Offset = "0x705E630", VA = "0x18705F430")]
		[CompilerGenerated]
		private void EOBEHEBFBCE(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x70616B0", Offset = "0x70608B0", VA = "0x1870616B0")]
		[CompilerGenerated]
		private bool MHMLEBFHAOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7061C90", Offset = "0x7060E90", VA = "0x187061C90")]
		[CompilerGenerated]
		private void PLJKFILALAH(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x70616C0", Offset = "0x70608C0", VA = "0x1870616C0")]
		[CompilerGenerated]
		private bool MLAODELAKPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7061140", Offset = "0x7060340", VA = "0x187061140")]
		[CompilerGenerated]
		private void KCHMFNDKOIM(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1168880", Offset = "0x1167A80", VA = "0x181168880")]
		[CompilerGenerated]
		private bool KJKBADEAPAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7061650", Offset = "0x7060850", VA = "0x187061650")]
		[CompilerGenerated]
		private void MBGIPFMAJFH(bool PBNOOPEKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E1D0", Offset = "0x1D9D3D0", VA = "0x181D9E1D0")]
		[CompilerGenerated]
		private bool HDJHLDHKCGH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x70616D0", Offset = "0x70608D0", VA = "0x1870616D0")]
		[CompilerGenerated]
		private void NDAHHLFGFGB(bool PBNOOPEKDOL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override string BPEFDKBBOMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x705B950", Offset = "0x705AB50", VA = "0x18705B950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x705B940", Offset = "0x705AB40", VA = "0x18705B940")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected override string BPEFDKBBOMK
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x705B980", Offset = "0x705AB80", VA = "0x18705B980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x705B940", Offset = "0x705AB40", VA = "0x18705B940")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HHGNGGMPEPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Dictionary<string, int> EEJBKAJACLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Dictionary<string, float> NENHHIEDNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Dictionary<string, long> GIMJJMNLHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Dictionary<string, string> OOEPOFMKKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Dictionary<string, Guid> PAALEKOHNME;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7053A40", Offset = "0x7052C40", VA = "0x187053A40")]
	public bool PJHPJFILPHP(string OFPBICPHALF, [Out] string CLHOGAAJHEC, string HNCNCHKHLCP = "")
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7052DB0", Offset = "0x7051FB0", VA = "0x187052DB0")]
	public IMJGKDJGPIG.PEMFBPJEIIL ABPCPPJDJIE(string OFPBICPHALF, IMJGKDJGPIG.PEMFBPJEIIL ADHNLNENHHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7052FF0", Offset = "0x70521F0", VA = "0x187052FF0")]
	public void ACBLJGAKIIL(string OFPBICPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7053960", Offset = "0x7052B60", VA = "0x187053960")]
	public void LNHGKNLCNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7053220", Offset = "0x7052420", VA = "0x187053220")]
	public void BBDIIHLDJGE(HHGNGGMPEPO JHDAOCMCGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7053C20", Offset = "0x7052E20", VA = "0x187053C20")]
	public HHGNGGMPEPO()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[Flags]
		internal enum HLBKMCKCBID
		{
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			OnStopTracking = 8
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		internal enum EBKHPMCJGHA
		{
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct CGNOPFELAJF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x704D940", Offset = "0x704CB40", VA = "0x18704D940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private static IJCHBBENNEN<HHGNGGMPEPO> NAMKJFNKIOM;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private const float DOPCIENBJAJ = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private const string NBLAELLKBNO = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private HLBKMCKCBID logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private EBKHPMCJGHA logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private HHGNGGMPEPO ANGPPGKOHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int NPPFFEEMGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Dictionary<int, string> GMAOBKBAAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Dictionary<string, int> KNKPCLOPFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private List<int> AKPAJMILPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<int> IFKDMPHGEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private List<ImpressionTracker> OLIOHFAJCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private List<ImpressionTracker> CAODPMALMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private List<int> LCFCIAEFEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private List<int> PPHAAJEPCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Dictionary<int, int> FJLEPCDCIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private List<int> DDKDPCIILAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<int, string> HHCFALHCDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Dictionary<string, string> HCNFIONCBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private List<HHGNGGMPEPO> MBGPICOJIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private List<HHGNGGMPEPO> HIEMMMFIBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private BCEFHNJDDKG POIDAFKFBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private BrowserModel LBGIMJJNDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Uri JCLKMEIKPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private bool KHLPAGPOPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private ImpressionTracker DLFDMCPIJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private bool DKAJNBAEPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private StringBuilder GCJDHBLADMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool OPMFFNCCIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x98A910", Offset = "0x989B10", VA = "0x18098A910")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA8E870", Offset = "0xA8DA70", VA = "0x180A8E870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7054420", Offset = "0x7053620", VA = "0x187054420")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7056090", Offset = "0x7055290", VA = "0x187056090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7056820", Offset = "0x7055A20", VA = "0x187056820")]
		public void SetDataToCollateFromChildrenOnLog(string OFPBICPHALF, string JEBHMGJFPIP, bool GACBDIINLMN = false, string CPNGDJLGHMF = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7056940", Offset = "0x7055B40", VA = "0x187056940")]
		public void SetDataToRecordOnClickThrough(string OFPBICPHALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x70554B0", Offset = "0x70546B0", VA = "0x1870554B0")]
		public void LogImpression(bool DCOODACAFGM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7055190", Offset = "0x7054390", VA = "0x187055190")]
		[AsyncStateMachine(typeof(CGNOPFELAJF))]
		private void KAMBIGBJFKD(Task NHHLJEHPOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7057790", Offset = "0x7056990", VA = "0x187057790")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7057B30", Offset = "0x7056D30", VA = "0x187057B30")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7057AF0", Offset = "0x7056CF0", VA = "0x187057AF0")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x70565B0", Offset = "0x70557B0", VA = "0x1870565B0")]
		public void RecordClickThrough([Optional] string PIIJHDCCIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7057550", Offset = "0x7056750", VA = "0x187057550")]
		public void SetString(string OFPBICPHALF, string LFDKFEEPNFP, bool GBHLDJNIEKF = false, bool NLDCAFPLAFD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7056C00", Offset = "0x7055E00", VA = "0x187056C00")]
		public void SetGuid(string OFPBICPHALF, Guid LFDKFEEPNFP, bool GBHLDJNIEKF = false, bool NLDCAFPLAFD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x70570B0", Offset = "0x70562B0", VA = "0x1870570B0")]
		public void SetLong(string OFPBICPHALF, long LFDKFEEPNFP, bool GBHLDJNIEKF = false, bool NLDCAFPLAFD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x70569B0", Offset = "0x7055BB0", VA = "0x1870569B0")]
		public void SetFloat(string OFPBICPHALF, float LFDKFEEPNFP, bool GBHLDJNIEKF = false, bool NLDCAFPLAFD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x70572F0", Offset = "0x70564F0", VA = "0x1870572F0")]
		public void SetObject(string OFPBICPHALF, object LFDKFEEPNFP, bool GBHLDJNIEKF = false, bool NLDCAFPLAFD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7056E70", Offset = "0x7056070", VA = "0x187056E70")]
		public void SetInt(string OFPBICPHALF, int LFDKFEEPNFP, bool GBHLDJNIEKF = false, bool NLDCAFPLAFD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7057E80", Offset = "0x7057080", VA = "0x187057E80")]
		public bool TryGetValueAsString(string OFPBICPHALF, [Out] string CLHOGAAJHEC, string HNCNCHKHLCP = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7054810", Offset = "0x7053A10", VA = "0x187054810")]
		public void ClearData(string OFPBICPHALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7055300", Offset = "0x7054500", VA = "0x187055300")]
		private int KEGMFJHHEBO(string OFPBICPHALF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x70550F0", Offset = "0x70542F0", VA = "0x1870550F0")]
		private string IIFDHOMEMAO(int BEHEHKFONGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x70553F0", Offset = "0x70545F0", VA = "0x1870553F0")]
		private void KHBJFOFILJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7054F40", Offset = "0x7054140", VA = "0x187054F40")]
		private void GLBNKNOAEJD(ImpressionTracker KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7054700", Offset = "0x7053900", VA = "0x187054700")]
		private void BJBMLPIKIGN(ImpressionTracker KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7054A20", Offset = "0x7053C20", VA = "0x187054A20")]
		private void DDHLNMBOEHO(bool DGANKCELALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7055260", Offset = "0x7054460", VA = "0x187055260")]
		private void KDBIJHBIIEK(PageWrapper OALKPAGBJMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7055F60", Offset = "0x7055160", VA = "0x187055F60")]
		private void MAFPFHDAHPP(bool JKLGIMIFLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7056000", Offset = "0x7055200", VA = "0x187056000")]
		private void NBNIIBNCHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x70562F0", Offset = "0x70554F0", VA = "0x1870562F0")]
		private void PDMODHKDIEO(string OFPBICPHALF, ImpressionTracker KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7054B80", Offset = "0x7053D80", VA = "0x187054B80")]
		private string EKMBILAHOKD(int HAHGBGCJOAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7056200", Offset = "0x7055400", VA = "0x187056200")]
		private int PBABBDGAANH(HHGNGGMPEPO FBCBJPMNPEK, HHGNGGMPEPO HHDMEFHBCOI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7055FF0", Offset = "0x70551F0", VA = "0x187055FF0")]
		private bool MODJFDIIFCE(HLBKMCKCBID ODCEMAFJPHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7057FD0", Offset = "0x70571D0", VA = "0x187057FD0")]
		public ImpressionTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class LNMBOPCLEEH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
	public LNMBOPCLEEH()
	{
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
