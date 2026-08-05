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
		[Cpp2IlInjected.Address(RVA = "0x70C0AA0", Offset = "0x70BF8A0", VA = "0x1870C0AA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[GKEBDKFMNEH]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<GBKIANCNBBH>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GBKIANCNBBH Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2461670", Offset = "0x2460470", VA = "0x182461670")]
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
		[Cpp2IlInjected.Address(RVA = "0x70AAF40", Offset = "0x70A9D40", VA = "0x1870AAF40", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70AB2E0", Offset = "0x70AA0E0", VA = "0x1870AB2E0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70AB040", Offset = "0x70A9E40", VA = "0x1870AB040")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "20")]
		protected override void OnDataUpdated(GBKIANCNBBH dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70AB3E0", Offset = "0x70AA1E0", VA = "0x1870AB3E0")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[GKEBDKFMNEH]
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
		[Cpp2IlInjected.Address(RVA = "0x70AC000", Offset = "0x70AAE00", VA = "0x1870AC000", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70AC120", Offset = "0x70AAF20", VA = "0x1870AC120", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70AC410", Offset = "0x70AB210", VA = "0x1870AC410")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[GKEBDKFMNEH]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70AC450", Offset = "0x70AB250", VA = "0x1870AC450", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70AC500", Offset = "0x70AB300", VA = "0x1870AC500")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[GKEBDKFMNEH]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x70AC540", Offset = "0x70AB340", VA = "0x1870AC540", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70AC5E0", Offset = "0x70AB3E0", VA = "0x1870AC5E0")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[GKEBDKFMNEH]
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
			[Cpp2IlInjected.Address(RVA = "0x70BFED0", Offset = "0x70BECD0", VA = "0x1870BFED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
		private MEPEJIIMKOI<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x70AE010", Offset = "0x70ACE10", VA = "0x1870AE010", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70AE240", Offset = "0x70AD040", VA = "0x1870AE240", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70AE370", Offset = "0x70AD170", VA = "0x1870AE370", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70AE190", Offset = "0x70ACF90", VA = "0x1870AE190")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__7))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70AE530", Offset = "0x70AD330", VA = "0x1870AE530")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[GKEBDKFMNEH]
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
		[Cpp2IlInjected.Address(RVA = "0x70B1900", Offset = "0x70B0700", VA = "0x1870B1900", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70B19A0", Offset = "0x70B07A0", VA = "0x1870B19A0")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[GKEBDKFMNEH]
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
		[Cpp2IlInjected.Address(RVA = "0x70B19E0", Offset = "0x70B07E0", VA = "0x1870B19E0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70B1BA0", Offset = "0x70B09A0", VA = "0x1870B1BA0")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[GKEBDKFMNEH]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x70B8D30", Offset = "0x70B7B30", VA = "0x1870B8D30", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70B8DC0", Offset = "0x70B7BC0", VA = "0x1870B8DC0")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[GKEBDKFMNEH]
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
		[POFEBHABCEJ("useQueryDataInUri")]
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
		[POFEBHABCEJ("overrideLoadSceneSource")]
		[SerializeField]
		private IAGGOKLIGKK loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private AHNHHJAMLMD vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70BB190", Offset = "0x70B9F90", VA = "0x1870BB190", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70BB520", Offset = "0x70BA320", VA = "0x1870BB520", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70BB320", Offset = "0x70BA120", VA = "0x1870BB320")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70BB600", Offset = "0x70BA400", VA = "0x1870BB600")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[GKEBDKFMNEH]
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
		[Cpp2IlInjected.Address(RVA = "0x70C0170", Offset = "0x70BEF70", VA = "0x1870C0170", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70C03E0", Offset = "0x70BF1E0", VA = "0x1870C03E0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70C0470", Offset = "0x70BF270", VA = "0x1870C0470", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70C07E0", Offset = "0x70BF5E0", VA = "0x1870C07E0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x70C06E0", Offset = "0x70BF4E0", VA = "0x1870C06E0", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70C0640", Offset = "0x70BF440", VA = "0x1870C0640", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70C0520", Offset = "0x70BF320", VA = "0x1870C0520", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70C0590", Offset = "0x70BF390", VA = "0x1870C0590")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70C0A50", Offset = "0x70BF850", VA = "0x1870C0A50")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class EFKJIBMICJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string KCGMHBKJKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string> KMHEKGDIILI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x70AEDA0", Offset = "0x70ADBA0", VA = "0x1870AEDA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70AECD0", Offset = "0x70ADAD0", VA = "0x1870AECD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70AED80", Offset = "0x70ADB80", VA = "0x1870AED80")]
	protected void JDBMPFIHBCP([CallerMemberName] string FINLDKJJAEK = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected EFKJIBMICJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AEONMJKOFHL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GMNMANGBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	double LADCJMAJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ABHNHLFJPBN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CKJKBKFNNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ECAHEKMOIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GAMKKEJCIBM HKGPOFCMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KCOOCDLMDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KFEBALKMFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HBKHHMNLGCL;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMGKKAHBBFB();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNJLGFGGJKM();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAICLJLGBKM();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJFOBDOJIBF();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OKPKEJIEMMI : AEONMJKOFHL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static string BECKKBHICDB;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static string ELMNJOOJOJI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static string APHFNPBPNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JGLLKCGMCOF CFAHKFAPMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool? JEKHKOJHMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private double? KGFIDDNIDCP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GMNMANGBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70B6B20", Offset = "0x70B5920", VA = "0x1870B6B20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LADCJMAJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70B6CC0", Offset = "0x70B5AC0", VA = "0x1870B6CC0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70B6E60", Offset = "0x70B5C60", VA = "0x1870B6E60")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void LHLKGADJEGF(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	[UnityEngine.Scripting.Preserve]
	internal OKPKEJIEMMI([NotNull][MHFJPMCEEAM(null)] JGLLKCGMCOF CFAHKFAPMFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IOFOHCLEFIE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NIOMIHIBKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PPHAECCCLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool PLOLMAPLAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GHBOKGOHHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AHNHHJAMLMD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KMJAIICLEBG EHDAADEDMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BJDFFCGMLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NNOJIEMHDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	long ABCPBJPNJOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool POGGACODJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CKHIIKALODK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool ADMKKDNMHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NCPGGLDPIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DNMHNLLPEAL(BrowserModel HLMLAELFHGL, Uri AJIGOEHNOOF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IIMLADJKBJF(BrowserModel HLMLAELFHGL, Uri ONIEEKPNMII, RoomListQueryData CGNDNFEKAPC, bool JHAMDONMHFB = false, IAGGOKLIGKK CMGBBEOCMNE = IAGGOKLIGKK.NOT_SET);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string IIMGEOOEDED(RoomListQueryData CGNDNFEKAPC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string JEBABNCDEKC(RoomListQueryData CGNDNFEKAPC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GBKIANCNBBH IGNAKDAGNAL(string JOPCDOKKGGN, [Optional] string NAIGMOJPPOH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task PJIPDMCAKEO(NMLAFBBNCED.JDLHEEOEBBA LBFOILADPHJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BJBCFBLAOAE(BrowserModel HLMLAELFHGL);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JEBOGIDAIGD([Out] OJCBODLGMBO<bool> ILHNICMCKKN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MHLHHJLPCGL(string JKCAODJCFBE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<bool> IIBDGANAMJF(long OGMIFIGJENM, CancellationToken HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<DADBLAJODHB> BFFFKCDOINJ(DGCCNGNLMNC KGMCCCOKBDB, CancellationToken HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IDIOGPKFDGN(PJIJPHIAAAH EFFHEJGJIEE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task OIKIIOLAMMC(DialogListModel LHNPDDPEGME, CANPBGPEBBJ PCCEHHDCKDD, CancellationToken HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JEIBDDJMMEN(bool DMBPMPDLBHL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DDHKLFFGNAM(BrowserModel HLMLAELFHGL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum HDDLLFLPLLB
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
public enum GBKIANCNBBH
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
			public FIFPHMMOLPN platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public GBKIANCNBBH HighlightStyle;

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
			public HDDLLFLPLLB CarouselType;

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
		private sealed class AIGADIHFEDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public BrowserModel browserModel;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public AIGADIHFEDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x70AABB0", Offset = "0x70A99B0", VA = "0x1870AABB0")]
			internal bool DKIPAKIBAJG(Uri uri)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KHDCKDDMMOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HDDLLFLPLLB carouselType;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public KHDCKDDMMOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x70AE670", Offset = "0x70AD470", VA = "0x1870AE670")]
			internal bool NDFLONHLJMJ(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FBMNGDEKEOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public HDDLLFLPLLB carouselType;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public FBMNGDEKEOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x70AE670", Offset = "0x70AD470", VA = "0x1870AE670")]
			internal bool PPAOLPPDKKH(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DCJFFOAGAGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HDDLLFLPLLB carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DCJFFOAGAGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x70AE670", Offset = "0x70AD470", VA = "0x1870AE670")]
			internal bool GHMAJJEOIBF(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PDGNDFKIIIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public HDDLLFLPLLB carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public PDGNDFKIIIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x70AE670", Offset = "0x70AD470", VA = "0x1870AE670")]
			internal bool NGMMAIOBNMJ(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class IBHCAJBIOMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HDDLLFLPLLB carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public IBHCAJBIOMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x70AE670", Offset = "0x70AD470", VA = "0x1870AE670")]
			internal bool EFKBKPMFOKH(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class OFCFFFIIKCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public GBKIANCNBBH highlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool isInVRDisplayMode;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public OFCFFFIIKCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x70B6AD0", Offset = "0x70B58D0", VA = "0x1870B6AD0")]
			internal bool PIMBMEMHDGJ(HighlightCardDataObject a)
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
		private AHNHHJAMLMD vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70ABB60", Offset = "0x70AA960", VA = "0x1870ABB60")]
		public bool FIMLFBFBEOF(BrowserModel HLMLAELFHGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70ABEA0", Offset = "0x70AACA0", VA = "0x1870ABEA0")]
		public float NPJCPPHPKCC(GBKIANCNBBH AHGOKLCELLK, HDDLLFLPLLB PAMIHODPBAD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x70ABD30", Offset = "0x70AAB30", VA = "0x1870ABD30")]
		public float MFLOKGBLAPD(GBKIANCNBBH AHGOKLCELLK, HDDLLFLPLLB PAMIHODPBAD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70AB7A0", Offset = "0x70AA5A0", VA = "0x1870AB7A0")]
		public float EFGDMBOEAOM(GBKIANCNBBH AHGOKLCELLK, HDDLLFLPLLB PAMIHODPBAD, int ILCNOLFFBOH = 1, bool MNFMLBAPAFF = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x70ABC40", Offset = "0x70AAA40", VA = "0x1870ABC40")]
		public RectOffset FMCNDALJMLL(HDDLLFLPLLB PAMIHODPBAD, int ILCNOLFFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x70AB420", Offset = "0x70AA220", VA = "0x1870AB420")]
		public int BCKKJGFKNEJ(bool BNPCEEKCGBE, GBKIANCNBBH AHGOKLCELLK, HDDLLFLPLLB PAMIHODPBAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x70ABB30", Offset = "0x70AA930", VA = "0x1870ABB30")]
		public int FDPBFANKCNN(bool BNPCEEKCGBE, GBKIANCNBBH AHGOKLCELLK, HDDLLFLPLLB PAMIHODPBAD, int BLLEMPJAOFD = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x70AB560", Offset = "0x70AA360", VA = "0x1870AB560")]
		public int BHAADICIHGG(bool BNPCEEKCGBE, GBKIANCNBBH AHGOKLCELLK, HDDLLFLPLLB PAMIHODPBAD, int BLLEMPJAOFD = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70AB610", Offset = "0x70AA410", VA = "0x1870AB610")]
		private HighlightCardDataObject CMKPPDLMHFO(GBKIANCNBBH AHGOKLCELLK)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70ABFE0", Offset = "0x70AADE0", VA = "0x1870ABFE0")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private const int IOBMBBAEPFA = 20;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private const int NDHEOJIIHIH = 6;

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
		private HDDLLFLPLLB carouselType;

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
		private FIFPHMMOLPN hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool LBFEPFEIAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int OOENKJMDPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private float? DAPPOMKIPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private float? MFAOFLKCLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string FPMNJDFMAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private GBKIANCNBBH AHGOKLCELLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private AHNHHJAMLMD ANLHEFAJNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private BrowserModel HLMLAELFHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private DiscoveryDisplayMetadata EJOEHOBJABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private string JOPCDOKKGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int BNHDPFNNEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int NLNNFGGACJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<IDataItem> PGFAABNJHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private DataItem<bool> IICGIDBBNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private DataItem<int> PGNDJPJFFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private DataItem<float?> KFIOFAIOBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private DataItem<float?> CHLFKFFMFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private DataItem<string> CNNHAEDPHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private DataItem<GBKIANCNBBH> LPDPLJCBOLE;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool IALPAOIFHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8F4200", Offset = "0x8F3000", VA = "0x1808F4200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x70ADB10", Offset = "0x70AC910", VA = "0x1870ADB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int KEBJPFFIMBE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD0B400", Offset = "0xD0A200", VA = "0x180D0B400")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x70ADAC0", Offset = "0x70AC8C0", VA = "0x1870ADAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? CCCFNEANCEK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x70ADEF0", Offset = "0x70ACCF0", VA = "0x1870ADEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[BindableData(3, "The width override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? GPPHBNAHCMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8F4240", Offset = "0x8F3040", VA = "0x1808F4240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x70ADF80", Offset = "0x70ACD80", VA = "0x1870ADF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string IOJJOMFCOFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8FC440", Offset = "0x8FB240", VA = "0x1808FC440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x70AD050", Offset = "0x70ABE50", VA = "0x1870AD050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public GBKIANCNBBH LCODOMBNOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAB2C20", Offset = "0xAB1A20", VA = "0x180AB2C20")]
			get
			{
				return default(GBKIANCNBBH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x70AD270", Offset = "0x70AC070", VA = "0x1870AD270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int LBAMBGPCPMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD0D3D0", Offset = "0xD0C1D0", VA = "0x180D0D3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD0D0C0", Offset = "0xD0BEC0", VA = "0x180D0D0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int MKHDJGAABGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xADC4F0", Offset = "0xADB2F0", VA = "0x180ADC4F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected override List<IDataItem> GBOMAICOHHH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x70ADEB0", Offset = "0x70ACCB0", VA = "0x1870ADEB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected override bool LNFIDKCGALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x70ACB00", Offset = "0x70AB900", VA = "0x1870ACB00", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x70ADB70", Offset = "0x70AC970", VA = "0x1870ADB70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x70ACCB0", Offset = "0x70ABAB0", VA = "0x1870ACCB0")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata EJOEHOBJABL, string JOPCDOKKGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x70AD0C0", Offset = "0x70ABEC0", VA = "0x1870AD0C0")]
		private int IAAAKGBBODD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x70AD9E0", Offset = "0x70AC7E0", VA = "0x1870AD9E0")]
		private GBKIANCNBBH LAEAECFBJMA()
		{
			return default(GBKIANCNBBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x70AD2D0", Offset = "0x70AC0D0", VA = "0x1870AD2D0")]
		private void IKMBFKOPFLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x70AC630", Offset = "0x70AB430", VA = "0x1870AC630")]
		private void AMHFNDIHBMO(int PLEOCEJNHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x70ACBC0", Offset = "0x70AB9C0", VA = "0x1870ACBC0")]
		private string CFCHLONFODN(GBKIANCNBBH ALMMMPDFNED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x70AD360", Offset = "0x70AC160", VA = "0x1870AD360", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x70ACEF0", Offset = "0x70ABCF0", VA = "0x1870ACEF0")]
		private void FKMJOJMEFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x70ADC20", Offset = "0x70ACA20", VA = "0x1870ADC20")]
		public CarouselViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8F4200", Offset = "0x8F3000", VA = "0x1808F4200")]
		[CompilerGenerated]
		private bool NLELHBJECPN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x70ADB10", Offset = "0x70AC910", VA = "0x1870ADB10")]
		[CompilerGenerated]
		private void MJCJABACKOF(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD0B400", Offset = "0xD0A200", VA = "0x180D0B400")]
		[CompilerGenerated]
		private int FNMADLFFGJA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x70ADAC0", Offset = "0x70AC8C0", VA = "0x1870ADAC0")]
		[CompilerGenerated]
		private void LPIKIPMNNAB(int MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450")]
		[CompilerGenerated]
		private float? NGFCPGIMJOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x70AD9D0", Offset = "0x70AC7D0", VA = "0x1870AD9D0")]
		[CompilerGenerated]
		private void JMINEBLICHK(float? MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4240", Offset = "0x8F3040", VA = "0x1808F4240")]
		[CompilerGenerated]
		private float? NOPNCOMKFDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x70AC620", Offset = "0x70AB420", VA = "0x1870AC620")]
		[CompilerGenerated]
		private void AJLOKMFOOIE(float? MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC440", Offset = "0x8FB240", VA = "0x1808FC440")]
		[CompilerGenerated]
		private string FHIOJIADNGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x70AD050", Offset = "0x70ABE50", VA = "0x1870AD050")]
		[CompilerGenerated]
		private void GOBJDJICDMN(string MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAB2C20", Offset = "0xAB1A20", VA = "0x180AB2C20")]
		[CompilerGenerated]
		private GBKIANCNBBH NNBPFINAIML()
		{
			return default(GBKIANCNBBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x70AD270", Offset = "0x70AC070", VA = "0x1870AD270")]
		[CompilerGenerated]
		private void ICCCOBHOCGD(GBKIANCNBBH MFHMIEFHEKN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private AHNHHJAMLMD vNextBridge;

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
		private KMJAIICLEBG[] unsupportedPlatformTypes;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KMJAIICLEBG[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x70AEBA0", Offset = "0x70AD9A0", VA = "0x1870AEBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x70AEB40", Offset = "0x70AD940", VA = "0x1870AEB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x70AE770", Offset = "0x70AD570", VA = "0x1870AE770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x70AE7D0", Offset = "0x70AD5D0", VA = "0x1870AE7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2419250", Offset = "0x2418050", VA = "0x182419250")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int OIFKPGENLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private long KEEDKFJGFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private long GCKPNNAGMAO;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int ACOKEIMNLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x914100", Offset = "0x912F00", VA = "0x180914100")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x70B14D0", Offset = "0x70B02D0", VA = "0x1870B14D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long ABCPBJPNJOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x70B1580", Offset = "0x70B0380", VA = "0x1870B1580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long EAFBFJIKFBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x70B1520", Offset = "0x70B0320", VA = "0x1870B1520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70B1340", Offset = "0x70B0140", VA = "0x1870B1340")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x70B0FE0", Offset = "0x70AFDE0", VA = "0x1870B0FE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x70B0E80", Offset = "0x70AFC80", VA = "0x1870B0E80")]
		private void MAKHHHDOBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x70B1140", Offset = "0x70AFF40", VA = "0x1870B1140")]
		private void POKBKKOGPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x70B14B0", Offset = "0x70B02B0", VA = "0x1870B14B0")]
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
		private ABHNHLFJPBN LFGEOIBGEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private List<IDataItem> PGFAABNJHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private DataItem<bool> IBIBBOCKMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private DataItem<bool> FHJHBDIFOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private DataItem<bool> DNKKKIHMKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private DataItem<bool> ABHHKLEJIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private DataItemAction MBCCAJNHOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private DataItemAction LIKHHOIFJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private DataItemAction AGKJBIEPJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private DataItemAction NIPODAFEPEP;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool CKJKBKFNNIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x70B6700", Offset = "0x70B5500", VA = "0x1870B6700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool ECAHEKMOIJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x70B67B0", Offset = "0x70B55B0", VA = "0x1870B67B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool KCOOCDLMDEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x70B5E90", Offset = "0x70B4C90", VA = "0x1870B5E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool KFEBALKMFPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x70B60F0", Offset = "0x70B4EF0", VA = "0x1870B60F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected override List<IDataItem> GBOMAICOHHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x70B6AA0", Offset = "0x70B58A0", VA = "0x1870B6AA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool LNFIDKCGALF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x70B5BE0", Offset = "0x70B49E0", VA = "0x1870B5BE0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x70B6850", Offset = "0x70B5650", VA = "0x1870B6850")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x70B6800", Offset = "0x70B5600", VA = "0x1870B6800")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x70B66A0", Offset = "0x70B54A0", VA = "0x1870B66A0")]
		private void JMMKLCLOAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x70B60A0", Offset = "0x70B4EA0", VA = "0x1870B60A0")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70B6050", Offset = "0x70B4E50", VA = "0x1870B6050")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70B6750", Offset = "0x70B5550", VA = "0x1870B6750")]
		private void MNIAPHGLLMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x70B6140", Offset = "0x70B4F40", VA = "0x1870B6140", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x70B5EE0", Offset = "0x70B4CE0", VA = "0x1870B5EE0")]
		private void FKMJOJMEFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x70B68A0", Offset = "0x70B56A0", VA = "0x1870B68A0")]
		public MakerPenHUDViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x70B6700", Offset = "0x70B5500", VA = "0x1870B6700")]
		[CompilerGenerated]
		private bool LIHDDAPGIGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x70B67B0", Offset = "0x70B55B0", VA = "0x1870B67B0")]
		[CompilerGenerated]
		private bool NCMKHBHHIGH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x70B5E90", Offset = "0x70B4C90", VA = "0x1870B5E90")]
		[CompilerGenerated]
		private bool ELMAPGDLIEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x70B60F0", Offset = "0x70B4EF0", VA = "0x1870B60F0")]
		[CompilerGenerated]
		private bool HPENEKFNHBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ONNJFKFNCFG : EFKJIBMICJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private JMKHKMHBFBD LICNKOFLGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool HKLFJIBBLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int AMHDFOLPFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool AMOBLBDGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int NGNDNBCJMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool EPOINLKADMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool LKDABLGCHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool AEJIEDDEGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool PNCJLEAEAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool EMOGDACMMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool KJADLJODCPB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JMKHKMHBFBD AAGJDDBGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x70B7220", Offset = "0x70B6020", VA = "0x1870B7220")]
		get
		{
			return default(JMKHKMHBFBD);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x70B72C0", Offset = "0x70B60C0", VA = "0x1870B72C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MDICBDHKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x925160", Offset = "0x923F60", VA = "0x180925160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x70B7040", Offset = "0x70B5E40", VA = "0x1870B7040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FFKGJHMPIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xCE5790", Offset = "0xCE4590", VA = "0x180CE5790")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x70B7160", Offset = "0x70B5F60", VA = "0x1870B7160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int DACFNPHAMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xC75810", Offset = "0xC74610", VA = "0x180C75810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x70B70A0", Offset = "0x70B5EA0", VA = "0x1870B70A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LDDLBMLJLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB3ACC0", Offset = "0xB39AC0", VA = "0x180B3ACC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x70B73D0", Offset = "0x70B61D0", VA = "0x1870B73D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HHBBKMMICEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xBF03F0", Offset = "0xBEF1F0", VA = "0x180BF03F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x70B7360", Offset = "0x70B6160", VA = "0x1870B7360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FINJLDAFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1B5A9A0", Offset = "0x1B597A0", VA = "0x181B5A9A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x70B71C0", Offset = "0x70B5FC0", VA = "0x1870B71C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool COPOGNGKJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x70B73C0", Offset = "0x70B61C0", VA = "0x1870B73C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool INLKKIDBHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x151BE50", Offset = "0x151AC50", VA = "0x18151BE50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x70B7100", Offset = "0x70B5F00", VA = "0x1870B7100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool GHKJOHLPAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x151ACF0", Offset = "0x1519AF0", VA = "0x18151ACF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x70B7260", Offset = "0x70B6060", VA = "0x1870B7260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x70B7430", Offset = "0x70B6230", VA = "0x1870B7430")]
	public ONNJFKFNCFG()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, IOFOHCLEFIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct FHOIIOMIKBF : IAsyncStateMachine
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
			private TaskAwaiter<List<PJIJPHIAAAH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x70B00D0", Offset = "0x70AEED0", VA = "0x1870B00D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private AHNHHJAMLMD ANLHEFAJNHK;

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
		private IAGGOKLIGKK loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private KBEMJLBENNH PBLCNLMNGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private CancellationTokenSource PCBNIHHNEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private BrowserModel HLMLAELFHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private bool LOADCMBJCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<long> EJKOBJGIKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int BAOHAAGJHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool FCEDOALKLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DataList<long> NIAKDPBOMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string CEADDCMALDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool EFAOHGIIHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private ONNJFKFNCFG OGEEHHBNDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<IDataItem> PGFAABNJHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private DataItem<string> DJNMABMHMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private DataItem<bool> ICAMABNHPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private DataItem<RoomListQueryData> JFJPCDEJNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private DataItem<ONNJFKFNCFG> PLMGMMNMLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private DataItemList FALMDKNBFNM;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> IAHFMPIFHLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8FC330", Offset = "0x8FB130", VA = "0x1808FC330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x70BB120", Offset = "0x70B9F20", VA = "0x1870BB120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string FJHFLFEGJNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA9F410", Offset = "0xA9E210", VA = "0x180A9F410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x70BB0A0", Offset = "0x70B9EA0", VA = "0x1870BB0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool LLECEOLACLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCE5790", Offset = "0xCE4590", VA = "0x180CE5790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x70BA280", Offset = "0x70B9080", VA = "0x1870BA280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData DMPPOPCMMPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public ONNJFKFNCFG OFCCHEIBDFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x70BA210", Offset = "0x70B9010", VA = "0x1870BA210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool NIOMIHIBKNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xCFFCF0", Offset = "0xCFEAF0", VA = "0x180CFFCF0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xCFFD00", Offset = "0xCFEB00", VA = "0x180CFFD00", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool PPHAECCCLKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x22BB5D0", Offset = "0x22BA3D0", VA = "0x1822BB5D0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x22BA0A0", Offset = "0x22B8EA0", VA = "0x1822BA0A0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool PLOLMAPLAON
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x22BB5E0", Offset = "0x22BA3E0", VA = "0x1822BB5E0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x22B8A60", Offset = "0x22B7860", VA = "0x1822B8A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool GHBOKGOHHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x566B120", Offset = "0x5669F20", VA = "0x18566B120", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x566B140", Offset = "0x5669F40", VA = "0x18566B140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool DGHJILLCABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xB45480", Offset = "0xB44280", VA = "0x180B45480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public IAGGOKLIGKK BGHOKAIGONO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xF8ECF0", Offset = "0xF8DAF0", VA = "0x180F8ECF0")]
			get
			{
				return default(IAGGOKLIGKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override List<IDataItem> GBOMAICOHHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x70BB060", Offset = "0x70B9E60", VA = "0x1870BB060", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override bool LNFIDKCGALF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x70BABA0", Offset = "0x70B99A0", VA = "0x1870BABA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x70BA2E0", Offset = "0x70B90E0", VA = "0x1870BA2E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x70BAAE0", Offset = "0x70B98E0", VA = "0x1870BAAE0")]
		public void SetQueryData(RoomListQueryData AFOHJLJJKCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x70BA9A0", Offset = "0x70B97A0", VA = "0x1870BA9A0")]
		public void SetDiscoverySectionId(string GBKKPGADBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x70B91A0", Offset = "0x70B7FA0", VA = "0x1870B91A0")]
		[AsyncStateMachine(typeof(FHOIIOMIKBF))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x70BAA50", Offset = "0x70B9850", VA = "0x1870BAA50")]
		public void SetMaxItems(int ODCGLOFPAEN, int DFJLPJBBADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x70BAAB0", Offset = "0x70B98B0", VA = "0x1870BAAB0")]
		public void SetMinItems(int PDCGIKBHGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x70BA480", Offset = "0x70B9280", VA = "0x1870BA480")]
		private void PBIFNJLLIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x70B9250", Offset = "0x70B8050", VA = "0x1870B9250")]
		private string HEHFJILBNCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x22BB5D0", Offset = "0x22BA3D0", VA = "0x1822BB5D0")]
		private bool HNBOEAFDFMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x70B9B00", Offset = "0x70B8900", VA = "0x1870B9B00")]
		private void JDGPPMOPHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70B8EE0", Offset = "0x70B7CE0", VA = "0x1870B8EE0")]
		private void DJLPIPHMFBG(ImpressionTracker DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x70B94C0", Offset = "0x70B82C0", VA = "0x1870B94C0", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x70B9060", Offset = "0x70B7E60", VA = "0x1870B9060")]
		private void FKMJOJMEFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x70BAD40", Offset = "0x70B9B40", VA = "0x1870BAD40")]
		public RoomListViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA9F410", Offset = "0xA9E210", VA = "0x180A9F410")]
		[CompilerGenerated]
		private string FIFIDGFIIND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x70B8E00", Offset = "0x70B7C00", VA = "0x1870B8E00")]
		[CompilerGenerated]
		private void CCFJBPCJAFP(string MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xCE5790", Offset = "0xCE4590", VA = "0x180CE5790")]
		[CompilerGenerated]
		private bool IMOGHMIFPKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x70BA280", Offset = "0x70B9080", VA = "0x1870BA280")]
		[CompilerGenerated]
		private void NIDKNMKBCHJ(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330")]
		[CompilerGenerated]
		private RoomListQueryData JCEMJCOHEMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70")]
		[CompilerGenerated]
		private ONNJFKFNCFG GGJPBFIDPJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x70BA210", Offset = "0x70B9010", VA = "0x1870BA210")]
		[CompilerGenerated]
		private void JHPNECHIBLL(ONNJFKFNCFG MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8FC330", Offset = "0x8FB130", VA = "0x1808FC330")]
		[CompilerGenerated]
		private DataList DLMHJECHFLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x70B8E10", Offset = "0x70B7C10", VA = "0x1870B8E10")]
		[CompilerGenerated]
		private void CPDHMPFBJOA(DataList MFHMIEFHEKN)
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
		private struct HEAJHINBLNA : IAsyncStateMachine
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
			private TaskAwaiter<PJIJPHIAAAH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x70B15E0", Offset = "0x70B03E0", VA = "0x1870B15E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct PGBNGGNNAMH : IAsyncStateMachine
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
			private DGCCNGNLMNC <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private TaskAwaiter<DGCCNGNLMNC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x70B7450", Offset = "0x70B6250", VA = "0x1870B7450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class CELLCDMIAAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public DGCCNGNLMNC roomDetails;

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
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CELLCDMIAAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x70AAF00", Offset = "0x70A9D00", VA = "0x1870AAF00")]
			internal void JPNHKGLCLAL()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct FIOIEEOAGFA : IAsyncStateMachine
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
			public DGCCNGNLMNC roomDetails;

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
			[Cpp2IlInjected.Address(RVA = "0x70B08F0", Offset = "0x70AF6F0", VA = "0x1870B08F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class DFEFNPGMBOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public DGCCNGNLMNC roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public DADBLAJODHB subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DFEFNPGMBOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x70AE680", Offset = "0x70AD480", VA = "0x1870AE680")]
			internal void KAKBBEJLCAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class DBBIHGPANGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public KGAIHJLHFDH latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public DFEFNPGMBOL CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DBBIHGPANGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x70AE570", Offset = "0x70AD370", VA = "0x1870AE570")]
			internal void PEDGADJAGCD()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct FGPMGMCHBEO : IAsyncStateMachine
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
			public DGCCNGNLMNC roomDetails;

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
			private DFEFNPGMBOL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private DBBIHGPANGJ <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private TaskAwaiter<DADBLAJODHB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private PPLLAFJKCAI <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private TaskAwaiter<KGAIHJLHFDH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x70AEE50", Offset = "0x70ADC50", VA = "0x1870AEE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private const string EJAGJNOMEMJ = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private const char IGJIFADFFGE = '.';

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
		private KBEMJLBENNH CJACPHJCNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NPAGANPMLFE EEHEODIENOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private AHNHHJAMLMD ANLHEFAJNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private CancellationTokenSource PCBNIHHNEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private JMKHKMHBFBD LICNKOFLGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private BrowserModel HLMLAELFHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private DialogListModel LHNPDDPEGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int KLLBFBLAGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int JHCMAEPOGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int IPHJMBDJDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private bool BOLOHJGKBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DateTime? GFKONMOGKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool HLOKAOKBOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private long OGMIFIGJENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private string LCKALKOAHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private string CHJIHJFAIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private string GIEEKCOLJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool CHMHKBEHIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private string COMHOJNHJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private bool LMIAJKDIFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool OJHHCFCBKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private string FDGAIEIBEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private bool EIIMNGLFNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private bool COKAEOEGAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x152")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private bool BCOJOKANOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x153")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private bool MEFJFMMHGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private bool JJFCJIJCOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x155")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool KNGHNFCKNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x156")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool LKDABLGCHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x157")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool PPAGKIFEMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool EMOGDACMMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool KJADLJODCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private List<IDataItem> PGFAABNJHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private DataItem<long> KPLIHBOAEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DataItem<string> FICOHBPBFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private DataItem<string> EAOKGGKDIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private DataItem<string> POGONAFABGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private DataItem<bool> HIPMGHHOINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DataItem<string> MBPDIHEPOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private DataItem<bool> MMGLKJIJKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private DataItem<bool> DGHCCIHFHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private DataItem<string> JKJDMECBNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DataItem<bool> KADNNBBGKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private DataItem<bool> KLOHLLKMOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DataItem<bool> MFEAKGMEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private DataItem<bool> CGBIKHKFBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private DataItem<bool> ACEJLOJHIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private DataItem<bool> LFDABNEICPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private DataItem<bool> PFODAGJOCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private DataItem<bool> LFBAJGCENOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private DataItem<bool> EMFCICOIGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private DataItem<bool> CFAEBCIEEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private DataItemAction NKIHMFNAHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DataItemAction EGKBFGNDLLG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long IPJEADBLJAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xBEDD00", Offset = "0xBECB00", VA = "0x180BEDD00")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x70BFDD0", Offset = "0x70BEBD0", VA = "0x1870BFDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string GNMFKMDDMKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDC0", Offset = "0xA1BBC0", VA = "0x180A1CDC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x70BFCD0", Offset = "0x70BEAD0", VA = "0x1870BFCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string FIKGLOIENEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE770", Offset = "0x9AD570", VA = "0x1809AE770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC50", Offset = "0x70BEA50", VA = "0x1870BFC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string PNPHKCCKGPA
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x97E860", Offset = "0x97D660", VA = "0x18097E860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x70BFD50", Offset = "0x70BEB50", VA = "0x1870BFD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool NBOJIHPFJBM
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x982990", Offset = "0x981790", VA = "0x180982990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x70BE240", Offset = "0x70BD040", VA = "0x1870BE240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string ADGAGCDIOCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x97DFE0", Offset = "0x97CDE0", VA = "0x18097DFE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x70BFBD0", Offset = "0x70BE9D0", VA = "0x1870BFBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool FHDAGNJNMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15E1450", Offset = "0x15E0250", VA = "0x1815E1450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x70BC220", Offset = "0x70BB020", VA = "0x1870BC220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool LPDMAMNBAEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xD181E0", Offset = "0xD16FE0", VA = "0x180D181E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x70BC160", Offset = "0x70BAF60", VA = "0x1870BC160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string FMBACOLNJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x96DA80", Offset = "0x96C880", VA = "0x18096DA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB50", Offset = "0x70BE950", VA = "0x1870BFB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool BBEDCHJLIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x16DA940", Offset = "0x16D9740", VA = "0x1816DA940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x70BC1C0", Offset = "0x70BAFC0", VA = "0x1870BC1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool DHFJLPMBIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x17F8F50", Offset = "0x17F7D50", VA = "0x1817F8F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x70BB880", Offset = "0x70BA680", VA = "0x1870BB880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool GJBLLEIENGF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x17F8F60", Offset = "0x17F7D60", VA = "0x1817F8F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x70BEF20", Offset = "0x70BDD20", VA = "0x1870BEF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool EJPNPKFFBFC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x70BE2A0", Offset = "0x70BD0A0", VA = "0x1870BE2A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x70BE100", Offset = "0x70BCF00", VA = "0x1870BE100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool LLGCGIMNFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x1B80FD0", Offset = "0x1B7FDD0", VA = "0x181B80FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x70BE160", Offset = "0x70BCF60", VA = "0x1870BE160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool GHLMNOCJLGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x70BB640", Offset = "0x70BA440", VA = "0x1870BB640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x70BEEC0", Offset = "0x70BDCC0", VA = "0x1870BEEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool HHBBKMMICEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x70BD480", Offset = "0x70BC280", VA = "0x1870BD480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x70BEE60", Offset = "0x70BDC60", VA = "0x1870BEE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool LKJMNIMPDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x70BE2B0", Offset = "0x70BD0B0", VA = "0x1870BE2B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x70BC100", Offset = "0x70BAF00", VA = "0x1870BC100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool INLKKIDBHCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x1193C50", Offset = "0x1192A50", VA = "0x181193C50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x70BE1E0", Offset = "0x70BCFE0", VA = "0x1870BE1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool GHKJOHLPAJG
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1DC8D60", Offset = "0x1DC7B60", VA = "0x181DC8D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x70BB820", Offset = "0x70BA620", VA = "0x1870BB820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HFFFEGIENAA
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x70BFA80", Offset = "0x70BE880", VA = "0x1870BFA80", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x70BE2D0", Offset = "0x70BD0D0", VA = "0x1870BE2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected override List<IDataItem> GBOMAICOHHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x70BFA40", Offset = "0x70BE840", VA = "0x1870BFA40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected override bool LNFIDKCGALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ILoadable> PEFNFFAHCNN
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x70BF980", Offset = "0x70BE780", VA = "0x1870BF980", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x70BFA90", Offset = "0x70BE890", VA = "0x1870BFA90", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x70BB710", Offset = "0x70BA510", VA = "0x1870BB710", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x70BF260", Offset = "0x70BE060", VA = "0x1870BF260")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x70BE2E0", Offset = "0x70BD0E0", VA = "0x1870BE2E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x70BF180", Offset = "0x70BDF80", VA = "0x1870BF180", Slot = "12")]
		public override void SetBindingData(int PIKNBAHHMKC, int JAKPCLIAKMF, int KNCPCNBMDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x70BEF80", Offset = "0x70BDD80", VA = "0x1870BEF80")]
		private void PPNDIAEJEKL(IDataSource PHILCPIMGAG, int JAKPCLIAKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x70BB8E0", Offset = "0x70BA6E0", VA = "0x1870BB8E0")]
		[AsyncStateMachine(typeof(HEAJHINBLNA))]
		private void EIFDGCFOCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x70BB990", Offset = "0x70BA790", VA = "0x1870BB990")]
		private void FFKOPJOENFL(PJIJPHIAAAH MPJCIJDMKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x70BE390", Offset = "0x70BD190", VA = "0x1870BE390")]
		private void PDPOIPLGNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x70BDD20", Offset = "0x70BCB20", VA = "0x1870BDD20")]
		private void KGPBMFHEMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x70BE1C0", Offset = "0x70BCFC0", VA = "0x1870BE1C0")]
		private void LDGFFKKCAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x70BD660", Offset = "0x70BC460", VA = "0x1870BD660")]
		[BindableAction(100, null)]
		private void JEEBCKCBDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x70BB650", Offset = "0x70BA450", VA = "0x1870BB650")]
		[AsyncStateMachine(typeof(PGBNGGNNAMH))]
		[BindableAction(101, null)]
		private void AOJCLEABGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x70BDC20", Offset = "0x70BCA20", VA = "0x1870BDC20")]
		[AsyncStateMachine(typeof(FIOIEEOAGFA))]
		private void KGIBBNBGAOH(bool CJCLLIDDKED, DGCCNGNLMNC KGMCCCOKBDB, bool MOBLEHBACEP = false, bool IFNBNHBHKGL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x70BDB10", Offset = "0x70BC910", VA = "0x1870BDB10")]
		[AsyncStateMachine(typeof(FGPMGMCHBEO))]
		private void KEFEAMPAOLE(DGCCNGNLMNC KGMCCCOKBDB, bool CJCLLIDDKED, bool MOBLEHBACEP, bool IFNBNHBHKGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x70BD490", Offset = "0x70BC290", VA = "0x1870BD490")]
		private void JDGPPMOPHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x70BECD0", Offset = "0x70BDAD0", VA = "0x1870BECD0")]
		private void PKKFNPANCKH(string BDNMKKMFMCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x70BC290", Offset = "0x70BB090", VA = "0x1870BC290", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x70BBD90", Offset = "0x70BAB90", VA = "0x1870BBD90")]
		private void FKMJOJMEFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x70BF320", Offset = "0x70BE120", VA = "0x1870BF320")]
		public RoomViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xBEDD00", Offset = "0xBECB00", VA = "0x180BEDD00")]
		[CompilerGenerated]
		private long ENDNFJMHKDM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x70BDB00", Offset = "0x70BC900", VA = "0x1870BDB00")]
		[CompilerGenerated]
		private void JHNFCKOBHOL(long MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA1CDC0", Offset = "0xA1BBC0", VA = "0x180A1CDC0")]
		[CompilerGenerated]
		private string GMKOMDPLCMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9AE770", Offset = "0x9AD570", VA = "0x1809AE770")]
		[CompilerGenerated]
		private string FLNIBKLANHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x97E860", Offset = "0x97D660", VA = "0x18097E860")]
		[CompilerGenerated]
		private string DHHDBMMGCLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x70BB700", Offset = "0x70BA500", VA = "0x1870BB700")]
		[CompilerGenerated]
		private void AOLKOJLKKHK(string MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x982990", Offset = "0x981790", VA = "0x180982990")]
		[CompilerGenerated]
		private bool FBEMBMLOIEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x70BE240", Offset = "0x70BD040", VA = "0x1870BE240")]
		[CompilerGenerated]
		private void MCAOFFJDBEG(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x97DFE0", Offset = "0x97CDE0", VA = "0x18097DFE0")]
		[CompilerGenerated]
		private string LMKOJOBICBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x70BE2C0", Offset = "0x70BD0C0", VA = "0x1870BE2C0")]
		[CompilerGenerated]
		private void NNJBOBIOMNL(string MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x15E1450", Offset = "0x15E0250", VA = "0x1815E1450")]
		[CompilerGenerated]
		private bool NJHHOFHFDNF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x70BC220", Offset = "0x70BB020", VA = "0x1870BC220")]
		[CompilerGenerated]
		private void GNJJICLOOOM(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xD181E0", Offset = "0xD16FE0", VA = "0x180D181E0")]
		[CompilerGenerated]
		private bool FBBNBOBGPCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x70BC160", Offset = "0x70BAF60", VA = "0x1870BC160")]
		[CompilerGenerated]
		private void GLDDMCICBPC(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x96DA80", Offset = "0x96C880", VA = "0x18096DA80")]
		[CompilerGenerated]
		private string GEAJJFADMNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x70BC280", Offset = "0x70BB080", VA = "0x1870BC280")]
		[CompilerGenerated]
		private void HHIOMMJFPAI(string MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x16DA940", Offset = "0x16D9740", VA = "0x1816DA940")]
		[CompilerGenerated]
		private bool KKPMDEFLIFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x70BC1C0", Offset = "0x70BAFC0", VA = "0x1870BC1C0")]
		[CompilerGenerated]
		private void GLIPFNNCCKH(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x17F8F50", Offset = "0x17F7D50", VA = "0x1817F8F50")]
		[CompilerGenerated]
		private bool PNHKOOKHKCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x70BB880", Offset = "0x70BA680", VA = "0x1870BB880")]
		[CompilerGenerated]
		private void CKJGBEJPIOH(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x17F8F60", Offset = "0x17F7D60", VA = "0x1817F8F60")]
		[CompilerGenerated]
		private bool IJPLLPDKACP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x70BEF20", Offset = "0x70BDD20", VA = "0x1870BEF20")]
		[CompilerGenerated]
		private void PNGGGKJMDFC(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x70BE2A0", Offset = "0x70BD0A0", VA = "0x1870BE2A0")]
		[CompilerGenerated]
		private bool MDIMMDMPHLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x70BE100", Offset = "0x70BCF00", VA = "0x1870BE100")]
		[CompilerGenerated]
		private void KHNLBILFKPB(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1B80FD0", Offset = "0x1B7FDD0", VA = "0x181B80FD0")]
		[CompilerGenerated]
		private bool AHHGHLFAECC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x70BE160", Offset = "0x70BCF60", VA = "0x1870BE160")]
		[CompilerGenerated]
		private void LDGFEAANOML(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x70BB640", Offset = "0x70BA440", VA = "0x1870BB640")]
		[CompilerGenerated]
		private bool AINEAKMALNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x70BEEC0", Offset = "0x70BDCC0", VA = "0x1870BEEC0")]
		[CompilerGenerated]
		private void PMNNPKDGIEB(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x70BD480", Offset = "0x70BC280", VA = "0x1870BD480")]
		[CompilerGenerated]
		private bool JCPCPDDBLHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x70BEE60", Offset = "0x70BDC60", VA = "0x1870BEE60")]
		[CompilerGenerated]
		private void PLAAHEDELMI(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x70BE2B0", Offset = "0x70BD0B0", VA = "0x1870BE2B0")]
		[CompilerGenerated]
		private bool NJGAOCCKKCI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x70BC100", Offset = "0x70BAF00", VA = "0x1870BC100")]
		[CompilerGenerated]
		private void GCEMOPGMPMK(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1193C50", Offset = "0x1192A50", VA = "0x181193C50")]
		[CompilerGenerated]
		private bool LOMMJFDAEOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x70BE1E0", Offset = "0x70BCFE0", VA = "0x1870BE1E0")]
		[CompilerGenerated]
		private void LPKKGOJNCOK(bool MFHMIEFHEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8D60", Offset = "0x1DC7B60", VA = "0x181DC8D60")]
		[CompilerGenerated]
		private bool KHMOILCGIHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x70BB820", Offset = "0x70BA620", VA = "0x1870BB820")]
		[CompilerGenerated]
		private void BPIGAFNOJBC(bool MFHMIEFHEKN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override string ADEDIKMGFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x70B8CD0", Offset = "0x70B7AD0", VA = "0x1870B8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x70B8CC0", Offset = "0x70B7AC0", VA = "0x1870B8CC0")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected override string ADEDIKMGFCI
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x70B8D00", Offset = "0x70B7B00", VA = "0x1870B8D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x70B8CC0", Offset = "0x70B7AC0", VA = "0x1870B8CC0")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class PHILNLACLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Dictionary<string, int> LPPPHFOOKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Dictionary<string, float> OIFOMOGKHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Dictionary<string, long> IDDOKBGOALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Dictionary<string, string> PMMNCMKEPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Dictionary<string, Guid> MCIPFKLMPLF;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x70B7C90", Offset = "0x70B6A90", VA = "0x1870B7C90")]
	public bool FBAOIKDCMBK(string FFOHLCGHDKA, [Out] string IIIOPPOKOFN, string IKCALPFNNBN = "")
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x70B8690", Offset = "0x70B7490", VA = "0x1870B8690")]
	public NMLAFBBNCED.JDLHEEOEBBA PCFDHFPAPEP(string FFOHLCGHDKA, NMLAFBBNCED.JDLHEEOEBBA BFMJINOLMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x70B88D0", Offset = "0x70B76D0", VA = "0x1870B88D0")]
	public void PCKKIJFPKIP(string FFOHLCGHDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x70B85B0", Offset = "0x70B73B0", VA = "0x1870B85B0")]
	public void LOIOKLLCCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x70B7E70", Offset = "0x70B6C70", VA = "0x1870B7E70")]
	public void HIJIJLCAHBM(PHILNLACLOA ELAKBNOPIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x70B8B00", Offset = "0x70B7900", VA = "0x1870B8B00")]
	public PHILNLACLOA()
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
		internal enum DOGIANENOHH
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
		internal enum ENFCJHIFHMA
		{
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct CEJKAPLMDAP : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x70AABF0", Offset = "0x70A99F0", VA = "0x1870AABF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private static PJDOOEEFCKB<PHILNLACLOA> BIFPLBNJGKG;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private const float OMACNOHFPMN = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private const string KCBIFCKIJBP = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private DOGIANENOHH logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private ENFCJHIFHMA logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private PHILNLACLOA IODJCBFAOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int HBEBHFIJEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Dictionary<int, string> PACPGDPLGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Dictionary<string, int> LMONLICPAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private List<int> BEBKFCNAFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<int> KAJPKMLBHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private List<ImpressionTracker> PLCCDMAJDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private List<ImpressionTracker> HHPDKOMLOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private List<int> CMCOJCOIKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private List<int> CDMOBMPHJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Dictionary<int, int> GBNCINFJLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private List<int> CDABLFLNAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<int, string> KAJOJEMHEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Dictionary<string, string> LFJMNFFPKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private List<PHILNLACLOA> GICKMAFOBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private List<PHILNLACLOA> HBEBFGHGFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private AHNHHJAMLMD ANLHEFAJNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private BrowserModel HLMLAELFHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Uri GPILNNINMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private bool GOODPGGAEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private ImpressionTracker JADJKLGLLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private bool MAJMIGJBOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private StringBuilder DIEAPOCHPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool PAMPOMLHDAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9AD7A0", Offset = "0x9AC5A0", VA = "0x1809AD7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAAE2A0", Offset = "0xAAD0A0", VA = "0x180AAE2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x70B1BE0", Offset = "0x70B09E0", VA = "0x1870B1BE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x70B3C00", Offset = "0x70B2A00", VA = "0x1870B3C00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x70B3FE0", Offset = "0x70B2DE0", VA = "0x1870B3FE0")]
		public void SetDataToCollateFromChildrenOnLog(string FFOHLCGHDKA, string KBHDDKCAINE, bool IIPDBCCEEEC = false, string KIAMLJENKKE = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x70B4100", Offset = "0x70B2F00", VA = "0x1870B4100")]
		public void SetDataToRecordOnClickThrough(string FFOHLCGHDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x70B2D90", Offset = "0x70B1B90", VA = "0x1870B2D90")]
		public void LogImpression(bool MKKNPGPEIPF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x70B2BC0", Offset = "0x70B19C0", VA = "0x1870B2BC0")]
		[AsyncStateMachine(typeof(CEJKAPLMDAP))]
		private void LHFPAHJGJNJ(Task BNIAMBMGHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x70B4F50", Offset = "0x70B3D50", VA = "0x1870B4F50")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x70B52F0", Offset = "0x70B40F0", VA = "0x1870B52F0")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x70B52B0", Offset = "0x70B40B0", VA = "0x1870B52B0")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x70B3D70", Offset = "0x70B2B70", VA = "0x1870B3D70")]
		public void RecordClickThrough([Optional] string OBJNNCEDCAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x70B4D10", Offset = "0x70B3B10", VA = "0x1870B4D10")]
		public void SetString(string FFOHLCGHDKA, string JOAPLPPIFPC, bool FJDHFKPOEDF = false, bool MAODMDHPCEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x70B43C0", Offset = "0x70B31C0", VA = "0x1870B43C0")]
		public void SetGuid(string FFOHLCGHDKA, Guid JOAPLPPIFPC, bool FJDHFKPOEDF = false, bool MAODMDHPCEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x70B4870", Offset = "0x70B3670", VA = "0x1870B4870")]
		public void SetLong(string FFOHLCGHDKA, long JOAPLPPIFPC, bool FJDHFKPOEDF = false, bool MAODMDHPCEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x70B4170", Offset = "0x70B2F70", VA = "0x1870B4170")]
		public void SetFloat(string FFOHLCGHDKA, float JOAPLPPIFPC, bool FJDHFKPOEDF = false, bool MAODMDHPCEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x70B4AB0", Offset = "0x70B38B0", VA = "0x1870B4AB0")]
		public void SetObject(string FFOHLCGHDKA, object JOAPLPPIFPC, bool FJDHFKPOEDF = false, bool MAODMDHPCEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x70B4630", Offset = "0x70B3430", VA = "0x1870B4630")]
		public void SetInt(string FFOHLCGHDKA, int JOAPLPPIFPC, bool FJDHFKPOEDF = false, bool MAODMDHPCEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x70B5640", Offset = "0x70B4440", VA = "0x1870B5640")]
		public bool TryGetValueAsString(string FFOHLCGHDKA, [Out] string IIIOPPOKOFN, string IKCALPFNNBN = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x70B2300", Offset = "0x70B1100", VA = "0x1870B2300")]
		public void ClearData(string FFOHLCGHDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x70B2C90", Offset = "0x70B1A90", VA = "0x1870B2C90")]
		private int LIDOJGPDGDI(string FFOHLCGHDKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x70B2B20", Offset = "0x70B1920", VA = "0x1870B2B20")]
		private string LBENCEDEOAP(int MIFPCBFGGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x70B25A0", Offset = "0x70B13A0", VA = "0x1870B25A0")]
		private void GJMKIONCAJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x70B2970", Offset = "0x70B1770", VA = "0x1870B2970")]
		private void KIGMAHIIIMP(ImpressionTracker DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x70B2700", Offset = "0x70B1500", VA = "0x1870B2700")]
		private void HKPJNHJPNMN(ImpressionTracker DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x70B2810", Offset = "0x70B1610", VA = "0x1870B2810")]
		private void JKBBHKLLFKN(bool GDCAFGBKNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x70B2660", Offset = "0x70B1460", VA = "0x1870B2660")]
		private void GMOMAAAEJMK(PageWrapper ONIEEKPNMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x70B2510", Offset = "0x70B1310", VA = "0x1870B2510")]
		private void DOHFDJJGHEB(bool MPONKCIIOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x70B1FB0", Offset = "0x70B0DB0", VA = "0x1870B1FB0")]
		private void BPIGBJEIDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x70B2040", Offset = "0x70B0E40", VA = "0x1870B2040")]
		private void CAPPKCEFJHB(string FFOHLCGHDKA, ImpressionTracker DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x70B3840", Offset = "0x70B2640", VA = "0x1870B3840")]
		private string MIEFGNLBFEC(int OODLBPJFNOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x70B1EC0", Offset = "0x70B0CC0", VA = "0x1870B1EC0")]
		private int BFJDAJAAPGE(PHILNLACLOA NMOPBJNEFKL, PHILNLACLOA KCJDGOIFCIF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x70B2D80", Offset = "0x70B1B80", VA = "0x1870B2D80")]
		private bool LOPIHHGDMLM(DOGIANENOHH NFKHKFICCIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x70B5790", Offset = "0x70B4590", VA = "0x1870B5790")]
		public ImpressionTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class GKEBDKFMNEH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public GKEBDKFMNEH()
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
