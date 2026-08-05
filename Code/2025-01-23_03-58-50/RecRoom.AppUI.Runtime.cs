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
		[Cpp2IlInjected.Address(RVA = "0x6D936D0", Offset = "0x6D91ED0", VA = "0x186D936D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CJGGPBMOFJO]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<BDOJIIDPDDP>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BDOJIIDPDDP Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x224C510", Offset = "0x224AD10", VA = "0x18224C510")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D7E6A0", Offset = "0x6D7CEA0", VA = "0x186D7E6A0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EA40", Offset = "0x6D7D240", VA = "0x186D7EA40", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E7A0", Offset = "0x6D7CFA0", VA = "0x186D7E7A0")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "20")]
		protected override void OnDataUpdated(BDOJIIDPDDP dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EB40", Offset = "0x6D7D340", VA = "0x186D7EB40")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CJGGPBMOFJO]
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
		[Cpp2IlInjected.Address(RVA = "0x6D7F750", Offset = "0x6D7DF50", VA = "0x186D7F750", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F870", Offset = "0x6D7E070", VA = "0x186D7F870", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FB60", Offset = "0x6D7E360", VA = "0x186D7FB60")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CJGGPBMOFJO]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FBA0", Offset = "0x6D7E3A0", VA = "0x186D7FBA0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FC50", Offset = "0x6D7E450", VA = "0x186D7FC50")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CJGGPBMOFJO]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FC90", Offset = "0x6D7E490", VA = "0x186D7FC90", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FD30", Offset = "0x6D7E530", VA = "0x186D7FD30")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CJGGPBMOFJO]
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
			[Cpp2IlInjected.Address(RVA = "0x6D92B00", Offset = "0x6D91300", VA = "0x186D92B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
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
		private MGNFCCKNAGM<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D81760", Offset = "0x6D7FF60", VA = "0x186D81760", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D81990", Offset = "0x6D80190", VA = "0x186D81990", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D81AC0", Offset = "0x6D802C0", VA = "0x186D81AC0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D818E0", Offset = "0x6D800E0", VA = "0x186D818E0")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__7))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D81C80", Offset = "0x6D80480", VA = "0x186D81C80")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CJGGPBMOFJO]
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
		[Cpp2IlInjected.Address(RVA = "0x6D85760", Offset = "0x6D83F60", VA = "0x186D85760", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D85800", Offset = "0x6D84000", VA = "0x186D85800")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CJGGPBMOFJO]
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
		[Cpp2IlInjected.Address(RVA = "0x6D85840", Offset = "0x6D84040", VA = "0x186D85840", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D85A00", Offset = "0x6D84200", VA = "0x186D85A00")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CJGGPBMOFJO]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B960", Offset = "0x6D8A160", VA = "0x186D8B960", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B9F0", Offset = "0x6D8A1F0", VA = "0x186D8B9F0")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CJGGPBMOFJO]
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
		[HIDMLHMKHPD("useQueryDataInUri")]
		[SerializeField]
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
		[HIDMLHMKHPD("overrideLoadSceneSource")]
		[SerializeField]
		private PDEHFKIJFKD loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ONHENLFCNGI vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DDC0", Offset = "0x6D8C5C0", VA = "0x186D8DDC0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E150", Offset = "0x6D8C950", VA = "0x186D8E150", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DF50", Offset = "0x6D8C750", VA = "0x186D8DF50")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E230", Offset = "0x6D8CA30", VA = "0x186D8E230")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CJGGPBMOFJO]
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
		[Cpp2IlInjected.Address(RVA = "0x6D92DA0", Offset = "0x6D915A0", VA = "0x186D92DA0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D93010", Offset = "0x6D91810", VA = "0x186D93010", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D930A0", Offset = "0x6D918A0", VA = "0x186D930A0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D93410", Offset = "0x6D91C10", VA = "0x186D93410", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D93310", Offset = "0x6D91B10", VA = "0x186D93310", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D93270", Offset = "0x6D91A70", VA = "0x186D93270", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D93150", Offset = "0x6D91950", VA = "0x186D93150", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D931C0", Offset = "0x6D919C0", VA = "0x186D931C0")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D93680", Offset = "0x6D91E80", VA = "0x186D93680")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class GBHEMMPFAOO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string GEGICKJGCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string> GLOHMKEBACE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D84E80", Offset = "0x6D83680", VA = "0x186D84E80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D84F50", Offset = "0x6D83750", VA = "0x186D84F50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D84F30", Offset = "0x6D83730", VA = "0x186D84F30")]
	protected void FCLEDGDGBID([CallerMemberName] string FHDOKEGCLOA = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected GBHEMMPFAOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JAEMGLNPNHE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IGKCEMAMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	double IPGFHCPFEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DOGHAGMDDEG : JAEMGLNPNHE
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static string GGCOGBIAEFK;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static string FCDBGCMCGAO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static string ODNOOCFHJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KHOLIEJJFCA BJHDMMPNPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool? HMMGKBKDMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private double? DPIEGJLOLDG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IGKCEMAMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D83FA0", Offset = "0x6D827A0", VA = "0x186D83FA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double IPGFHCPFEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D84230", Offset = "0x6D82A30", VA = "0x186D84230", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D84140", Offset = "0x6D82940", VA = "0x186D84140")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void ANCFBKBPAGI(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	[UnityEngine.Scripting.Preserve]
	internal DOGHAGMDDEG([NotNull][NDCFMLCHJCI(null)] KHOLIEJJFCA BJHDMMPNPNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AJMHNKDJIDH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OHDGIIBHJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MHOIKJNNOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EFFPMMBNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OHFKHNABPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ONHENLFCNGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DILGPODPEFI MOOKGAPLHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OLCMDFCMDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PIHOAIJKFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long BHPHCFMHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool AIACPLKBAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool LKHNDEOENHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool LENMIMENANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int NLIEAFNBHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKCKDLKAOCK(BrowserModel OBAAJNHMAHC, Uri MLADFGFNGHG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DBFFFMCBICM(BrowserModel OBAAJNHMAHC, Uri BMFAJJJDNFI, RoomListQueryData KHOJHIPAGPL, bool AGEKEBEBJAI = false, PDEHFKIJFKD KABMBIKNGOP = PDEHFKIJFKD.NOT_SET);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string FIGIGAEMIKN(RoomListQueryData KHOJHIPAGPL);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string BIKJJKINHFA(RoomListQueryData KHOJHIPAGPL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BDOJIIDPDDP BNIDONCMEOD(string EMPGHADLLBP, [Optional] string PJBGIKNECEF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JOMHAPADFNM(DHLFCDCDCJK.OMFEPOCLDCL GEJHPJCOLID);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DFPLJFEEGLC(BrowserModel OBAAJNHMAHC);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LAHHEBLINKI([Out] ANHAMBLCGDC<bool> DFKHOGNOGCG);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EEOHLGDIMGN(string NCCPKEDAFOP);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<bool> MLINPJGLMLK(long NKDNOGOOODN, CancellationToken DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<IPKCPHEECFE> IOOCENEFDAJ(NIHPFEHJKNJ GKCMIIJJFKC, CancellationToken DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AHCMPBDFACN(AFBHIMGNKPK HCDBJHBHLNA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task MOLJBHKBFCB(DialogListModel BGAJAELEJJL, JHGJPPCLBHO LCIIIDDDCHI, CancellationToken DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool EDPLJCHLJNG(bool OLDINANOJBB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JHINDCJFIEP(BrowserModel OBAAJNHMAHC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum GPMHLIKKNJN
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
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum BDOJIIDPDDP
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
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IDMEJNGCKAP platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public BDOJIIDPDDP HighlightStyle;

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
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public GPMHLIKKNJN CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			[ReadOnlyField]
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
			[Tooltip("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			[FormerlySerializedAs("rowBottomPadding")]
			public int rowPaddingBottom;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class OCGBFDPPONE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public BrowserModel browserModel;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public OCGBFDPPONE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A780", Offset = "0x6D88F80", VA = "0x186D8A780")]
			internal bool EECKKFEADOL(Uri uri)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OPAAEACIBNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public GPMHLIKKNJN carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public OPAAEACIBNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6D844C0", Offset = "0x6D82CC0", VA = "0x186D844C0")]
			internal bool BBEDOENPIDM(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class NKIPFHNHKNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public GPMHLIKKNJN carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public NKIPFHNHKNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6D844C0", Offset = "0x6D82CC0", VA = "0x186D844C0")]
			internal bool LDDCOCHMDPO(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FBHJMMNPONJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public GPMHLIKKNJN carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FBHJMMNPONJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6D844C0", Offset = "0x6D82CC0", VA = "0x186D844C0")]
			internal bool PKJNGPBJEGD(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class JLCPFPNGEID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public GPMHLIKKNJN carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public JLCPFPNGEID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6D844C0", Offset = "0x6D82CC0", VA = "0x186D844C0")]
			internal bool OCCAGGHLFLB(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DOJKPGFFPND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public GPMHLIKKNJN carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DOJKPGFFPND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6D844C0", Offset = "0x6D82CC0", VA = "0x186D844C0")]
			internal bool DAEJKJANKIP(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class JNJDGBAEIJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public BDOJIIDPDDP highlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CarouselDisplayConfig <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public JNJDGBAEIJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6D89A40", Offset = "0x6D88240", VA = "0x186D89A40")]
			internal bool EOGKOGBGGKH(HighlightCardDataObject a)
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
		[SerializeField]
		[Tooltip("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
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
		private ONHENLFCNGI vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F1C0", Offset = "0x6D7D9C0", VA = "0x186D7F1C0")]
		public bool MEOOFIFGOJA(BrowserModel OBAAJNHMAHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6D7ECF0", Offset = "0x6D7D4F0", VA = "0x186D7ECF0")]
		public float GAJBAMLAKJI(BDOJIIDPDDP ACHMHKCNDGG, GPMHLIKKNJN JJKBLNDHMBE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F5C0", Offset = "0x6D7DDC0", VA = "0x186D7F5C0")]
		public float PHPFMGCMBLJ(BDOJIIDPDDP ACHMHKCNDGG, GPMHLIKKNJN JJKBLNDHMBE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EE30", Offset = "0x6D7D630", VA = "0x186D7EE30")]
		public float GFJLNGIMAMN(BDOJIIDPDDP ACHMHKCNDGG, GPMHLIKKNJN JJKBLNDHMBE, int OGNFGBEGEIP = 1, bool CDLCCONIANL = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F420", Offset = "0x6D7DC20", VA = "0x186D7F420")]
		public RectOffset MNOIKGNDJOF(GPMHLIKKNJN JJKBLNDHMBE, int OGNFGBEGEIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EBB0", Offset = "0x6D7D3B0", VA = "0x186D7EBB0")]
		public int CPMKJFAPDNF(bool JPIENBNGANC, BDOJIIDPDDP ACHMHKCNDGG, GPMHLIKKNJN JJKBLNDHMBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EB80", Offset = "0x6D7D380", VA = "0x186D7EB80")]
		public int BDBMLJGFJND(bool JPIENBNGANC, BDOJIIDPDDP ACHMHKCNDGG, GPMHLIKKNJN JJKBLNDHMBE, int CMOBBFJBOJC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F510", Offset = "0x6D7DD10", VA = "0x186D7F510")]
		public int OBNGEKGEMLF(bool JPIENBNGANC, BDOJIIDPDDP ACHMHKCNDGG, GPMHLIKKNJN JJKBLNDHMBE, int CMOBBFJBOJC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F2A0", Offset = "0x6D7DAA0", VA = "0x186D7F2A0")]
		private HighlightCardDataObject MMCMKJDDFEM(BDOJIIDPDDP ACHMHKCNDGG)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F730", Offset = "0x6D7DF30", VA = "0x186D7F730")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private const int HHJOCGAKNBL = 20;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private const int JADCFCDIEJM = 6;

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
		private GPMHLIKKNJN carouselType;

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
		private IDMEJNGCKAP hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool KPBOHGNNHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int MECOKBIMDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private float? OBPLICJJFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private float? ILJOHJKEALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string KPKGOALLAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private BDOJIIDPDDP ACHMHKCNDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private ONHENLFCNGI HGFKGNLJPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private BrowserModel OBAAJNHMAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private DiscoveryDisplayMetadata DDONBCFKBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private string EMPGHADLLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int HKLNGBKNFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int IJJFBEPGCDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<IDataItem> NCIJOOILIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private DataItem<bool> DGEKCBNAELI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private DataItem<int> BINENMHIBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private DataItem<float?> KLHHHBHEJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private DataItem<float?> LCAHJIHAKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private DataItem<string> GHIGAPOJENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private DataItem<BDOJIIDPDDP> KKAELPEPFEB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool FNMLAIFJDGB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8BD190", Offset = "0x8BB990", VA = "0x1808BD190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6D80070", Offset = "0x6D7E870", VA = "0x186D80070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int ECMKFMIJOCG
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA99A80", Offset = "0xA98280", VA = "0x180A99A80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6D80B50", Offset = "0x6D7F350", VA = "0x186D80B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? ANBHMJAJIBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5D30", VA = "0x1808B7530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6D81640", Offset = "0x6D7FE40", VA = "0x186D81640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[BindableData(3, "The width override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? EBNOPBICGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8B7580", Offset = "0x8B5D80", VA = "0x1808B7580")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6D816D0", Offset = "0x6D7FED0", VA = "0x186D816D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string LDAMIBLIAEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8BC110", Offset = "0x8BA910", VA = "0x1808BC110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6D800F0", Offset = "0x6D7E8F0", VA = "0x186D800F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public BDOJIIDPDDP IAIGCKOCCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9FB6F0", Offset = "0x9F9EF0", VA = "0x1809FB6F0")]
			get
			{
				return default(BDOJIIDPDDP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6D803F0", Offset = "0x6D7EBF0", VA = "0x186D803F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int FOMBHJAHDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA88C20", Offset = "0xA87420", VA = "0x180A88C20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA88C60", Offset = "0xA87460", VA = "0x180A88C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int DCNBLNMDAIO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x21372C0", Offset = "0x2135AC0", VA = "0x1821372C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override List<IDataItem> FGDCACPICFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6D81600", Offset = "0x6D7FE00", VA = "0x186D81600", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected override bool BKIDOPFPEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FD70", Offset = "0x6D7E570", VA = "0x186D7FD70", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D812C0", Offset = "0x6D7FAC0", VA = "0x186D812C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FE30", Offset = "0x6D7E630", VA = "0x186D7FE30")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata DDONBCFKBCG, string EMPGHADLLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D80160", Offset = "0x6D7E960", VA = "0x186D80160")]
		private int GFPOFGJBHLP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D80310", Offset = "0x6D7EB10", VA = "0x186D80310")]
		private BDOJIIDPDDP GIAEKINGBAO()
		{
			return default(BDOJIIDPDDP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D80AC0", Offset = "0x6D7F2C0", VA = "0x186D80AC0")]
		private void JOLODKKLBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D80C90", Offset = "0x6D7F490", VA = "0x186D80C90")]
		private void LECKOLIDDGH(int BAEPKGAHDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D80BA0", Offset = "0x6D7F3A0", VA = "0x186D80BA0")]
		private string KPOOOIMAPHL(BDOJIIDPDDP AJBODPNMPHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D80450", Offset = "0x6D7EC50", VA = "0x186D80450", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D81160", Offset = "0x6D7F960", VA = "0x186D81160")]
		private void NPAKOOPELCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D81370", Offset = "0x6D7FB70", VA = "0x186D81370")]
		public CarouselViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BD190", Offset = "0x8BB990", VA = "0x1808BD190")]
		[CompilerGenerated]
		private bool EFAALPEPFHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D80070", Offset = "0x6D7E870", VA = "0x186D80070")]
		[CompilerGenerated]
		private void ECNLHAGIAAB(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA99A80", Offset = "0xA98280", VA = "0x180A99A80")]
		[CompilerGenerated]
		private int GJPDMILBOHF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D80B50", Offset = "0x6D7F350", VA = "0x186D80B50")]
		[CompilerGenerated]
		private void KKAKJDHBGJF(int JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5D30", VA = "0x1808B7530")]
		[CompilerGenerated]
		private float? LDHGCLOMJBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D800E0", Offset = "0x6D7E8E0", VA = "0x186D800E0")]
		[CompilerGenerated]
		private void EPBKDMBIGBE(float? JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7580", Offset = "0x8B5D80", VA = "0x1808B7580")]
		[CompilerGenerated]
		private float? LLFHDBICOCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D800D0", Offset = "0x6D7E8D0", VA = "0x186D800D0")]
		[CompilerGenerated]
		private void EOGEOGDNNOA(float? JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BC110", Offset = "0x8BA910", VA = "0x1808BC110")]
		[CompilerGenerated]
		private string NMCEEJLABEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6D800F0", Offset = "0x6D7E8F0", VA = "0x186D800F0")]
		[CompilerGenerated]
		private void FOAFJJBCCKH(string JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9FB6F0", Offset = "0x9F9EF0", VA = "0x1809FB6F0")]
		[CompilerGenerated]
		private BDOJIIDPDDP BCBOMKCLJGP()
		{
			return default(BDOJIIDPDDP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D803F0", Offset = "0x6D7EBF0", VA = "0x186D803F0")]
		[CompilerGenerated]
		private void GJAGCNPKNCF(BDOJIIDPDDP JBEGGBDGOGM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private ONHENLFCNGI vNextBridge;

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
		private DILGPODPEFI[] unsupportedPlatformTypes;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private DILGPODPEFI[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6D84900", Offset = "0x6D83100", VA = "0x186D84900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6D848A0", Offset = "0x6D830A0", VA = "0x186D848A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6D844D0", Offset = "0x6D82CD0", VA = "0x186D844D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6D84530", Offset = "0x6D82D30", VA = "0x186D84530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x22041F0", Offset = "0x22029F0", VA = "0x1822041F0")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int DKDPHHNIHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private long EDCJCABGHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private long NAMODFNAHLL;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int JLJJNDLBOAB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8D4630", Offset = "0x8D2E30", VA = "0x1808D4630")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6D85650", Offset = "0x6D83E50", VA = "0x186D85650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long BHPHCFMHFDK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6D85700", Offset = "0x6D83F00", VA = "0x186D85700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long DMNHEBAFDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6D856A0", Offset = "0x6D83EA0", VA = "0x186D856A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D854C0", Offset = "0x6D83CC0", VA = "0x186D854C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D85360", Offset = "0x6D83B60", VA = "0x186D85360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D85200", Offset = "0x6D83A00", VA = "0x186D85200")]
		private void GEENAIAPPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D85000", Offset = "0x6D83800", VA = "0x186D85000")]
		private void GACKLKHCGLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D85630", Offset = "0x6D83E30", VA = "0x186D85630")]
		public GlobalDataViewModel()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MDPGKJGHNMF : GBHEMMPFAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private FMLNOLMCCDJ PPNGOCODPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool PACDDKKNIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private int FIJFJAICMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool ALNIGPMOPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int FONOPDPLBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool FMHALELBKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool DNHEDKAPBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool OCBLBGDGMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool HBBIFMCFJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool HKMJANHFCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool NJMKIFMEPCG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FMLNOLMCCDJ MKOOGBMBIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A3B0", Offset = "0x6D88BB0", VA = "0x186D8A3B0")]
		get
		{
			return default(FMLNOLMCCDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A250", Offset = "0x6D88A50", VA = "0x186D8A250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool BIAAJIKBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E6110", Offset = "0x8E4910", VA = "0x1808E6110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A120", Offset = "0x6D88920", VA = "0x186D8A120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool KOOMEIPFCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B0", Offset = "0xA3A8B0", VA = "0x180A3C0B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A180", Offset = "0x6D88980", VA = "0x186D8A180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int MOIEJPEEBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9E31B0", Offset = "0x9E19B0", VA = "0x1809E31B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A350", Offset = "0x6D88B50", VA = "0x186D8A350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CKCKFDMOEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xD84C80", Offset = "0xD83480", VA = "0x180D84C80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A1E0", Offset = "0x6D889E0", VA = "0x186D8A1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BJPEPJJHHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x96AD10", Offset = "0x969510", VA = "0x18096AD10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A2F0", Offset = "0x6D88AF0", VA = "0x186D8A2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BJAAPADNNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x657DBB0", Offset = "0x657C3B0", VA = "0x18657DBB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A0C0", Offset = "0x6D888C0", VA = "0x186D8A0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CGEAMEOAFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A240", Offset = "0x6D88A40", VA = "0x186D8A240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LBCKIPOOKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1259D30", Offset = "0x1258530", VA = "0x181259D30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A060", Offset = "0x6D88860", VA = "0x186D8A060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NAHCGJPPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x125A590", Offset = "0x1258D90", VA = "0x18125A590")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A3F0", Offset = "0x6D88BF0", VA = "0x186D8A3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A450", Offset = "0x6D88C50", VA = "0x186D8A450")]
	public MDPGKJGHNMF()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, AJMHNKDJIDH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct DBPLIEHMOEB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<List<AFBHIMGNKPK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6D81CC0", Offset = "0x6D804C0", VA = "0x186D81CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private ONHENLFCNGI HGFKGNLJPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private PDEHFKIJFKD loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private DGFEBJBABLP LJHFAOJDMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private CancellationTokenSource OENGEKBIAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private BrowserModel OBAAJNHMAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private bool OEAAOCILGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private List<long> DHNHEFDJKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int CMHBILHKBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool EDNBHPELMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private DataList<long> BCMDPBPMIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private string HNPDJEIDCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool AMDPFFCDCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private MDPGKJGHNMF AELNCNJPNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private List<IDataItem> NCIJOOILIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DataItem<string> PIKMDBEHLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DataItem<bool> KHIFDPMPHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private DataItem<RoomListQueryData> KKPOKHEILAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DataItem<MDPGKJGHNMF> LOHDIOGONPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DataItemList BCEJNMCADOB;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> EILJEJAEJDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0D0", Offset = "0x8BA8D0", VA = "0x1808BC0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DD50", Offset = "0x6D8C550", VA = "0x186D8DD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string FDEIIGAJJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x996E90", Offset = "0x995690", VA = "0x180996E90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DCD0", Offset = "0x6D8C4D0", VA = "0x186D8DCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool KNBOMHGCNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA3C0B0", Offset = "0xA3A8B0", VA = "0x180A3C0B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D8CA00", Offset = "0x6D8B200", VA = "0x186D8CA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData JDFLGNGJNOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public MDPGKJGHNMF KLKEDPELBML
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF10", Offset = "0xA7C710", VA = "0x180A7DF10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6D8BF50", Offset = "0x6D8A750", VA = "0x186D8BF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool OHDGIIBHJPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA8F280", Offset = "0xA8DA80", VA = "0x180A8F280", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA8F030", Offset = "0xA8D830", VA = "0x180A8F030", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool MHOIKJNNOMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F33C90", Offset = "0x1F32490", VA = "0x181F33C90", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F33C80", Offset = "0x1F32480", VA = "0x181F33C80", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool EFFPMMBNMBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x207E310", Offset = "0x207CB10", VA = "0x18207E310", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x207B2F0", Offset = "0x2079AF0", VA = "0x18207B2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OHFKHNABPKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x538B5B0", Offset = "0x5389DB0", VA = "0x18538B5B0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x538D230", Offset = "0x538BA30", VA = "0x18538D230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool PKIDLFFNHMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAE86A0", Offset = "0xAE6EA0", VA = "0x180AE86A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public PDEHFKIJFKD MOACNIALKKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xCEF580", Offset = "0xCEDD80", VA = "0x180CEF580")]
			get
			{
				return default(PDEHFKIJFKD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override List<IDataItem> FGDCACPICFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DC90", Offset = "0x6D8C490", VA = "0x186D8DC90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected override bool BKIDOPFPEAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D7D0", Offset = "0x6D8BFD0", VA = "0x186D8D7D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D430", Offset = "0x6D8BC30", VA = "0x186D8D430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D710", Offset = "0x6D8BF10", VA = "0x186D8D710")]
		public void SetQueryData(RoomListQueryData GCBAEAFGELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D5D0", Offset = "0x6D8BDD0", VA = "0x186D8D5D0")]
		public void SetDiscoverySectionId(string IBCDEEGNADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C240", Offset = "0x6D8AA40", VA = "0x186D8C240")]
		[AsyncStateMachine(typeof(DBPLIEHMOEB))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D680", Offset = "0x6D8BE80", VA = "0x186D8D680")]
		public void SetMaxItems(int DOLIGDBCDHO, int IBCCCGIJLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D6E0", Offset = "0x6D8BEE0", VA = "0x186D8D6E0")]
		public void SetMinItems(int KOOCDFPNCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BA30", Offset = "0x6D8A230", VA = "0x186D8BA30")]
		private void COINGDFGNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BFD0", Offset = "0x6D8A7D0", VA = "0x186D8BFD0")]
		private string FLCGFIOCBOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1F33C90", Offset = "0x1F32490", VA = "0x181F33C90")]
		private bool KBJFLOFFKEE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CBE0", Offset = "0x6D8B3E0", VA = "0x186D8CBE0")]
		private void MMLAKKCIFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CA60", Offset = "0x6D8B260", VA = "0x186D8CA60")]
		private void MGGLDJJHOFP(ImpressionTracker IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C3C0", Offset = "0x6D8ABC0", VA = "0x186D8C3C0", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D2F0", Offset = "0x6D8BAF0", VA = "0x186D8D2F0")]
		private void NPAKOOPELCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D970", Offset = "0x6D8C170", VA = "0x186D8D970")]
		public RoomListViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x996E90", Offset = "0x995690", VA = "0x180996E90")]
		[CompilerGenerated]
		private string LIPFHONGAOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BFC0", Offset = "0x6D8A7C0", VA = "0x186D8BFC0")]
		[CompilerGenerated]
		private void ENMNIPOLONE(string JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B0", Offset = "0xA3A8B0", VA = "0x180A3C0B0")]
		[CompilerGenerated]
		private bool PPPIHNIMHIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CA00", Offset = "0x6D8B200", VA = "0x186D8CA00")]
		[CompilerGenerated]
		private void JCFKENHMKEA(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0")]
		[CompilerGenerated]
		private RoomListQueryData AFLPDECCEEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF10", Offset = "0xA7C710", VA = "0x180A7DF10")]
		[CompilerGenerated]
		private MDPGKJGHNMF DLBODFHPBIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BF50", Offset = "0x6D8A750", VA = "0x186D8BF50")]
		[CompilerGenerated]
		private void DJLNCBDMIHL(MDPGKJGHNMF JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0D0", Offset = "0x8BA8D0", VA = "0x1808BC0D0")]
		[CompilerGenerated]
		private DataList CGGELCOIBPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C2F0", Offset = "0x6D8AAF0", VA = "0x186D8C2F0")]
		[CompilerGenerated]
		private void HKOOEJKOBIG(DataList JBEGGBDGOGM)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct FGKPFGMPICA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private TaskAwaiter<AFBHIMGNKPK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x6D84A70", Offset = "0x6D83270", VA = "0x186D84A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct DGJKMJEEPMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private NIHPFEHJKNJ <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private TaskAwaiter<NIHPFEHJKNJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x6D83760", Offset = "0x6D81F60", VA = "0x186D83760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class ECCMNBEGAIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public NIHPFEHJKNJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public bool randomSubroom;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public ECCMNBEGAIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x6D84A30", Offset = "0x6D83230", VA = "0x186D84A30")]
			internal void HOBLDIKPKAO()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct LLDLABGBLPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public NIHPFEHJKNJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x6D89AD0", Offset = "0x6D882D0", VA = "0x186D89AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class FIJFLGLIBAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public NIHPFEHJKNJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public IPKCPHEECFE subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public FIJFLGLIBAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x6D84D90", Offset = "0x6D83590", VA = "0x186D84D90")]
			internal void ALNGKCNKOOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class OFAGBMMHGGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public DJPINPOMHEF latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public FIJFLGLIBAP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public OFAGBMMHGGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A7C0", Offset = "0x6D88FC0", VA = "0x186D8A7C0")]
			internal void CKLIPPKBHNB()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct DFCNHAEGCMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public NIHPFEHJKNJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private FIJFLGLIBAP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private OFAGBMMHGGA <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private TaskAwaiter<IPKCPHEECFE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private GKGMCFDCOMB <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private TaskAwaiter<DJPINPOMHEF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x6D824E0", Offset = "0x6D80CE0", VA = "0x186D824E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private const string PFNGFBDOFEL = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private const char GNJHEBOJPHF = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private DGFEBJBABLP NCCMMDNGIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private CMMLIFBHOJC CJCGPBFNKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private ONHENLFCNGI HGFKGNLJPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private CancellationTokenSource OENGEKBIAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FMLNOLMCCDJ PPNGOCODPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private BrowserModel OBAAJNHMAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DialogListModel BGAJAELEJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int NOCGOBJMFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int AMPDOMJMIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int DGBBFEEAFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private bool ECFDMLEIFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DateTime? KPBGPNKLDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private bool ODOHFGKGJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private long NKDNOGOOODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private string FLCBDBJFLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private string GIMKNCGKHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private string DFDGAJNBHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private bool IJOEGMAJJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private string BMIHKAEDGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool JMKGBDAHKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private bool DKNHHJABDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private string NPDHDBJHDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool LEAMDEEOLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private bool IBMMEAAOKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x152")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private bool CLBDGMADGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x153")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private bool KCIJMHKOJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private bool LOJODNMMIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x155")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool IGDALEKFFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x156")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private bool DNHEDKAPBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x157")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private bool GNMICPAMOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool HKMJANHFCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private bool NJMKIFMEPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<IDataItem> NCIJOOILIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private DataItem<long> GFAPOFGIOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private DataItem<string> JGGCCNIDFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private DataItem<string> CNKFPDBKIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private DataItem<string> FGCOHKPLLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private DataItem<bool> FMAEIKMHJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private DataItem<string> DHGEFPFENND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private DataItem<bool> MNBOCAFKDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private DataItem<bool> FFCPDAGNGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private DataItem<string> MNOPBAKJIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private DataItem<bool> FGJBAPELKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private DataItem<bool> EKPGINNLLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DataItem<bool> KEANKGMLOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private DataItem<bool> EPAPAHFNODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private DataItem<bool> MIJDACLONBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private DataItem<bool> PEAKBJNPGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DataItem<bool> GDEBIGKOKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private DataItem<bool> FPPBBBHBGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private DataItem<bool> ILIADJAPDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private DataItem<bool> OKHGLNNAPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DataItemAction EPAOELAPAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private DataItemAction JLGHIKBMEPB;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long FMJKOMLKOEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x968B60", Offset = "0x967360", VA = "0x180968B60")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6D92A00", Offset = "0x6D91200", VA = "0x186D92A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string ELDADDDNLAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x96AF80", Offset = "0x969780", VA = "0x18096AF80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6D92900", Offset = "0x6D91100", VA = "0x186D92900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string ELBEDLFIJGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x981E20", Offset = "0x980620", VA = "0x180981E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6D92880", Offset = "0x6D91080", VA = "0x186D92880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string JHOHNEPBCJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9DB460", Offset = "0x9D9C60", VA = "0x1809DB460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6D92980", Offset = "0x6D91180", VA = "0x186D92980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool OFHLHPAJAHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1518030", Offset = "0x1516830", VA = "0x181518030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6D8FDB0", Offset = "0x6D8E5B0", VA = "0x186D8FDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string BPDOFIFOCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x9DB480", Offset = "0x9D9C80", VA = "0x1809DB480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6D92800", Offset = "0x6D91000", VA = "0x186D92800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool LOMBLGOPGKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x16E49C0", Offset = "0x16E31C0", VA = "0x1816E49C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E9B0", Offset = "0x6D8D1B0", VA = "0x186D8E9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool BFJHBENDJCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xA94A20", Offset = "0xA93220", VA = "0x180A94A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6D91000", Offset = "0x6D8F800", VA = "0x186D91000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string ANNPFDKKFLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x976780", Offset = "0x974F80", VA = "0x180976780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6D92780", Offset = "0x6D90F80", VA = "0x186D92780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool KCEFHMFGGHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x144A1A0", Offset = "0x14489A0", VA = "0x18144A1A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6D91180", Offset = "0x6D8F980", VA = "0x186D91180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool MLCONLHHFOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1523760", Offset = "0x1521F60", VA = "0x181523760")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6D91120", Offset = "0x6D8F920", VA = "0x186D91120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool CNMGNDGPMHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1523770", Offset = "0x1521F70", VA = "0x181523770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6D911F0", Offset = "0x6D8F9F0", VA = "0x186D911F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool KCEKBIDPAJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6D8EEB0", Offset = "0x6D8D6B0", VA = "0x186D8EEB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E4A0", Offset = "0x6D8CCA0", VA = "0x186D8E4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool GJNHFEOMPEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x17CE7E0", Offset = "0x17CCFE0", VA = "0x1817CE7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6D8F0B0", Offset = "0x6D8D8B0", VA = "0x186D8F0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool OHOAHIEPOOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E270", Offset = "0x6D8CA70", VA = "0x186D8E270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6D8FC80", Offset = "0x6D8E480", VA = "0x186D8FC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool BJPEPJJHHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E9A0", Offset = "0x6D8D1A0", VA = "0x186D8E9A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E560", Offset = "0x6D8CD60", VA = "0x186D8E560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool HBCEHINCIMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6D8FCE0", Offset = "0x6D8E4E0", VA = "0x186D8FCE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E500", Offset = "0x6D8CD00", VA = "0x186D8E500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool LBCKIPOOKFF
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x119BA70", Offset = "0x119A270", VA = "0x18119BA70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6D8F050", Offset = "0x6D8D850", VA = "0x186D8F050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool NAHCGJPPLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1A0F390", Offset = "0x1A0DB90", VA = "0x181A0F390")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6D91C90", Offset = "0x6D90490", VA = "0x186D91C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool MPKEMAPKLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6D926B0", Offset = "0x6D90EB0", VA = "0x186D926B0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6D91060", Offset = "0x6D8F860", VA = "0x186D91060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override List<IDataItem> FGDCACPICFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6D92670", Offset = "0x6D90E70", VA = "0x186D92670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected override bool BKIDOPFPEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ILoadable> AALFHEPHCCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x6D925B0", Offset = "0x6D90DB0", VA = "0x186D925B0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6D926C0", Offset = "0x6D90EC0", VA = "0x186D926C0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E280", Offset = "0x6D8CA80", VA = "0x186D8E280", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D91E90", Offset = "0x6D90690", VA = "0x186D91E90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6D91CF0", Offset = "0x6D904F0", VA = "0x186D91CF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6D91DB0", Offset = "0x6D905B0", VA = "0x186D91DB0", Slot = "12")]
		public override void SetBindingData(int MBJMFFOKPPF, int FGAKIHGJJAJ, int ECDOOAABOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FA80", Offset = "0x6D8E280", VA = "0x186D8FA80")]
		private void GPEMNCGCLPF(IDataSource NBGOBNCCEHE, int FGAKIHGJJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6D91070", Offset = "0x6D8F870", VA = "0x186D91070")]
		[AsyncStateMachine(typeof(FGKPFGMPICA))]
		private void JOINEEHKPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D91890", Offset = "0x6D90090", VA = "0x186D91890")]
		private void OAIEDMAKCKP(AFBHIMGNKPK HENLAMJJAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F140", Offset = "0x6D8D940", VA = "0x186D8F140")]
		private void GONALNMBBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E5C0", Offset = "0x6D8CDC0", VA = "0x186D8E5C0")]
		private void COPOONPOPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F110", Offset = "0x6D8D910", VA = "0x186D8F110")]
		private void FJGCGGLGJFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8EA10", Offset = "0x6D8D210", VA = "0x186D8EA10")]
		[BindableAction(100, null)]
		private void DKOMMBOGMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FD00", Offset = "0x6D8E500", VA = "0x186D8FD00")]
		[AsyncStateMachine(typeof(DGJKMJEEPMK))]
		[BindableAction(101, null)]
		private void IGHLFDENOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6D91250", Offset = "0x6D8FA50", VA = "0x186D91250")]
		[AsyncStateMachine(typeof(LLDLABGBLPE))]
		private void LGOKMLGGPEF(bool JNIDMKGIDJJ, NIHPFEHJKNJ GKCMIIJJFKC, bool FMDJBMHPCGB = false, bool LDGAOELMOMH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E390", Offset = "0x6D8CB90", VA = "0x186D8E390")]
		[AsyncStateMachine(typeof(DFCNHAEGCMM))]
		private void BEJAPGCDFIB(NIHPFEHJKNJ GKCMIIJJFKC, bool JNIDMKGIDJJ, bool FMDJBMHPCGB, bool LDGAOELMOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6D91350", Offset = "0x6D8FB50", VA = "0x186D91350")]
		private void MMLAKKCIFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6D8EEC0", Offset = "0x6D8D6C0", VA = "0x186D8EEC0")]
		private void DNHJFGIGFHO(string DDEFEGMMKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FE10", Offset = "0x6D8E610", VA = "0x186D8FE10", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6D91520", Offset = "0x6D8FD20", VA = "0x186D91520")]
		private void NPAKOOPELCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6D91F50", Offset = "0x6D90750", VA = "0x186D91F50")]
		public RoomViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x968B60", Offset = "0x967360", VA = "0x180968B60")]
		[CompilerGenerated]
		private long HILMGICJCAB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FCF0", Offset = "0x6D8E4F0", VA = "0x186D8FCF0")]
		[CompilerGenerated]
		private void IDCOEIOLLIG(long JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x96AF80", Offset = "0x969780", VA = "0x18096AF80")]
		[CompilerGenerated]
		private string JDCLBPDPCPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x981E20", Offset = "0x980620", VA = "0x180981E20")]
		[CompilerGenerated]
		private string FACCBEPBKBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB460", Offset = "0x9D9C60", VA = "0x1809DB460")]
		[CompilerGenerated]
		private string OMEPBPKOKKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D911E0", Offset = "0x6D8F9E0", VA = "0x186D911E0")]
		[CompilerGenerated]
		private void KJNDDJDPHOE(string JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1518030", Offset = "0x1516830", VA = "0x181518030")]
		[CompilerGenerated]
		private bool BCDLDEAJCHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FDB0", Offset = "0x6D8E5B0", VA = "0x186D8FDB0")]
		[CompilerGenerated]
		private void IKGKAAJIMIO(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB480", Offset = "0x9D9C80", VA = "0x1809DB480")]
		[CompilerGenerated]
		private string PNNAPDNEPLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6D91DA0", Offset = "0x6D905A0", VA = "0x186D91DA0")]
		[CompilerGenerated]
		private void PHHAHIJILDD(string JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x16E49C0", Offset = "0x16E31C0", VA = "0x1816E49C0")]
		[CompilerGenerated]
		private bool GNHOCBLENFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E9B0", Offset = "0x6D8D1B0", VA = "0x186D8E9B0")]
		[CompilerGenerated]
		private void DJGPNMLLGOP(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA94A20", Offset = "0xA93220", VA = "0x180A94A20")]
		[CompilerGenerated]
		private bool BNLLCOKFOEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D91000", Offset = "0x6D8F800", VA = "0x186D91000")]
		[CompilerGenerated]
		private void JGKDIOHOHMN(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x976780", Offset = "0x974F80", VA = "0x180976780")]
		[CompilerGenerated]
		private string OIDJLJDIDAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F130", Offset = "0x6D8D930", VA = "0x186D8F130")]
		[CompilerGenerated]
		private void GIDOGFOCAJI(string JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x144A1A0", Offset = "0x14489A0", VA = "0x18144A1A0")]
		[CompilerGenerated]
		private bool BAFAGABHPGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6D91180", Offset = "0x6D8F980", VA = "0x186D91180")]
		[CompilerGenerated]
		private void KIPLHEHGIHI(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1523760", Offset = "0x1521F60", VA = "0x181523760")]
		[CompilerGenerated]
		private bool LDNFFDNMLKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6D91120", Offset = "0x6D8F920", VA = "0x186D91120")]
		[CompilerGenerated]
		private void KFADFBJHKJF(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1523770", Offset = "0x1521F70", VA = "0x181523770")]
		[CompilerGenerated]
		private bool DNGIMANFCCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6D911F0", Offset = "0x6D8F9F0", VA = "0x186D911F0")]
		[CompilerGenerated]
		private void KKOBLIOOMNF(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8EEB0", Offset = "0x6D8D6B0", VA = "0x186D8EEB0")]
		[CompilerGenerated]
		private bool DNGBOLBKHFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E4A0", Offset = "0x6D8CCA0", VA = "0x186D8E4A0")]
		[CompilerGenerated]
		private void CEHADGDAPKL(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x17CE7E0", Offset = "0x17CCFE0", VA = "0x1817CE7E0")]
		[CompilerGenerated]
		private bool OFMNILGBHMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F0B0", Offset = "0x6D8D8B0", VA = "0x186D8F0B0")]
		[CompilerGenerated]
		private void EPDEPBAHFHL(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E270", Offset = "0x6D8CA70", VA = "0x186D8E270")]
		[CompilerGenerated]
		private bool AGNIEDDPALF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FC80", Offset = "0x6D8E480", VA = "0x186D8FC80")]
		[CompilerGenerated]
		private void HKHIGKMKLGB(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E9A0", Offset = "0x6D8D1A0", VA = "0x186D8E9A0")]
		[CompilerGenerated]
		private bool DFBKOFNBPJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E560", Offset = "0x6D8CD60", VA = "0x186D8E560")]
		[CompilerGenerated]
		private void CKLNGFJINHG(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FCE0", Offset = "0x6D8E4E0", VA = "0x186D8FCE0")]
		[CompilerGenerated]
		private bool HONHECCOKIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E500", Offset = "0x6D8CD00", VA = "0x186D8E500")]
		[CompilerGenerated]
		private void CGEPBOJDJLK(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x119BA70", Offset = "0x119A270", VA = "0x18119BA70")]
		[CompilerGenerated]
		private bool LIHFJLCGGBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F050", Offset = "0x6D8D850", VA = "0x186D8F050")]
		[CompilerGenerated]
		private void ENKEFAGOLOC(bool JBEGGBDGOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F390", Offset = "0x1A0DB90", VA = "0x181A0F390")]
		[CompilerGenerated]
		private bool BIPICIBLCCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6D91C90", Offset = "0x6D90490", VA = "0x186D91C90")]
		[CompilerGenerated]
		private void OGPIDFELOFC(bool JBEGGBDGOGM)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override string KHENIHOCIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B900", Offset = "0x6D8A100", VA = "0x186D8B900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B8F0", Offset = "0x6D8A0F0", VA = "0x186D8B8F0")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected override string KHENIHOCIGK
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B930", Offset = "0x6D8A130", VA = "0x186D8B930", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B8F0", Offset = "0x6D8A0F0", VA = "0x186D8B8F0")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OJGMFDCBPLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public Dictionary<string, int> PELCIPLOKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public Dictionary<string, float> CDIKHFBJNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public Dictionary<string, long> FEJHGIACIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Dictionary<string, string> IFGANGBECMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Dictionary<string, Guid> LCCKAAPBNBG;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B320", Offset = "0x6D89B20", VA = "0x186D8B320")]
	public bool MCKFPNNNHEK(string KCGKBDGKIOP, [Out] string BOOGKJGGGOK, string AENEDEDOEJK = "")
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A8C0", Offset = "0x6D890C0", VA = "0x186D8A8C0")]
	public DHLFCDCDCJK.OMFEPOCLDCL AJGFDONBJMP(string KCGKBDGKIOP, DHLFCDCDCJK.OMFEPOCLDCL PIHEOEPKNKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B500", Offset = "0x6D89D00", VA = "0x186D8B500")]
	public void NLKFAANPANN(string KCGKBDGKIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D8AB00", Offset = "0x6D89300", VA = "0x186D8AB00")]
	public void IDGPJAEFAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D8ABE0", Offset = "0x6D893E0", VA = "0x186D8ABE0")]
	public void KCPFALLGEGM(OJGMFDCBPLE NDDFPKIACFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B730", Offset = "0x6D89F30", VA = "0x186D8B730")]
	public OJGMFDCBPLE()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[Flags]
		internal enum IIGJKKEIJJN
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			OnStopTracking = 8
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		internal enum CFNAIHJJAJF
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct MEGLCBCGCIC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A470", Offset = "0x6D88C70", VA = "0x186D8A470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static GNKJMBHDKKJ<OJGMFDCBPLE> OIFAJAPBIAP;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private const float PMLEFMBGHCG = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private const string OFAFLJLFNFN = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private IIGJKKEIJJN logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private CFNAIHJJAJF logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private OJGMFDCBPLE HIJFNJOIBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int FDHOBJHFGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Dictionary<int, string> NLFNPEHCHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Dictionary<string, int> BECGHBGJDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private List<int> EHEOLMKLEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private List<int> DKMAJFBGMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private List<ImpressionTracker> CAJGHKGIDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private List<ImpressionTracker> HBNDEOJBGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private List<int> NBHLCFJPLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private List<int> BEOPLFDJBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Dictionary<int, int> JKPCCPJKBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private List<int> NBBFDPLCBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Dictionary<int, string> KGMHAEOAGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Dictionary<string, string> CEIHEEAKEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private List<OJGMFDCBPLE> FEGJCNGEPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<OJGMFDCBPLE> MPAOCJONKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private ONHENLFCNGI HGFKGNLJPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private BrowserModel OBAAJNHMAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Uri DCCIALPPCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool MJFMKKHMAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private ImpressionTracker JFNBBLCFJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private bool ACOHJENFEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private StringBuilder LNKHHEKHMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool FGGCIAGOFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xDF0DC0", Offset = "0xDEF5C0", VA = "0x180DF0DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x17404D0", Offset = "0x173ECD0", VA = "0x1817404D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6D85A40", Offset = "0x6D84240", VA = "0x186D85A40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6D87A60", Offset = "0x6D86260", VA = "0x186D87A60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6D87E40", Offset = "0x6D86640", VA = "0x186D87E40")]
		public void SetDataToCollateFromChildrenOnLog(string KCGKBDGKIOP, string DFEJJOPGBKP, bool FFNNLGALNMJ = false, string ECKHKBICHDL = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6D87F60", Offset = "0x6D86760", VA = "0x186D87F60")]
		public void SetDataToRecordOnClickThrough(string KCGKBDGKIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6D86DF0", Offset = "0x6D855F0", VA = "0x186D86DF0")]
		public void LogImpression(bool KHDIFEIJFDB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6D878A0", Offset = "0x6D860A0", VA = "0x186D878A0")]
		[AsyncStateMachine(typeof(MEGLCBCGCIC))]
		private void MHGMNCBJGCN(Task MLKCGOMCHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6D88DB0", Offset = "0x6D875B0", VA = "0x186D88DB0")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6D89150", Offset = "0x6D87950", VA = "0x186D89150")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6D89110", Offset = "0x6D87910", VA = "0x186D89110")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6D87BD0", Offset = "0x6D863D0", VA = "0x186D87BD0")]
		public void RecordClickThrough([Optional] string HJGFDIPCBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6D88B70", Offset = "0x6D87370", VA = "0x186D88B70")]
		public void SetString(string KCGKBDGKIOP, string EBNFOODJNOB, bool NGPJFFKFGPE = false, bool IDBDKIHMCED = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6D88220", Offset = "0x6D86A20", VA = "0x186D88220")]
		public void SetGuid(string KCGKBDGKIOP, Guid EBNFOODJNOB, bool NGPJFFKFGPE = false, bool IDBDKIHMCED = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6D886D0", Offset = "0x6D86ED0", VA = "0x186D886D0")]
		public void SetLong(string KCGKBDGKIOP, long EBNFOODJNOB, bool NGPJFFKFGPE = false, bool IDBDKIHMCED = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6D87FD0", Offset = "0x6D867D0", VA = "0x186D87FD0")]
		public void SetFloat(string KCGKBDGKIOP, float EBNFOODJNOB, bool NGPJFFKFGPE = false, bool IDBDKIHMCED = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6D88910", Offset = "0x6D87110", VA = "0x186D88910")]
		public void SetObject(string KCGKBDGKIOP, object EBNFOODJNOB, bool NGPJFFKFGPE = false, bool IDBDKIHMCED = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6D88490", Offset = "0x6D86C90", VA = "0x186D88490")]
		public void SetInt(string KCGKBDGKIOP, int EBNFOODJNOB, bool NGPJFFKFGPE = false, bool IDBDKIHMCED = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6D894A0", Offset = "0x6D87CA0", VA = "0x186D894A0")]
		public bool TryGetValueAsString(string KCGKBDGKIOP, [Out] string BOOGKJGGGOK, string AENEDEDOEJK = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6D85ED0", Offset = "0x6D846D0", VA = "0x186D85ED0")]
		public void ClearData(string KCGKBDGKIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6D87970", Offset = "0x6D86170", VA = "0x186D87970")]
		private int MHJICEHMJOL(string KCGKBDGKIOP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6D86CA0", Offset = "0x6D854A0", VA = "0x186D86CA0")]
		private string LCHGOJJKHNJ(int DOBPKLNCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6D85D20", Offset = "0x6D84520", VA = "0x186D85D20")]
		private void BMKFDCILGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6D86AF0", Offset = "0x6D852F0", VA = "0x186D86AF0")]
		private void KMLDMJDEPAM(ImpressionTracker IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6D86950", Offset = "0x6D85150", VA = "0x186D86950")]
		private void JHCLFMPGLIB(ImpressionTracker IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6D86530", Offset = "0x6D84D30", VA = "0x186D86530")]
		private void GBAAJENNOHE(bool EMGABJHBLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6D86D50", Offset = "0x6D85550", VA = "0x186D86D50")]
		private void LFLKPIIMMAE(PageWrapper BMFAJJJDNFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6D860E0", Offset = "0x6D848E0", VA = "0x186D860E0")]
		private void DDAFOKGCNPC(bool MEDIHDNMHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6D86A60", Offset = "0x6D85260", VA = "0x186D86A60")]
		private void JMIBGADAIBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6D86690", Offset = "0x6D84E90", VA = "0x186D86690")]
		private void HLNNGGCIAOP(string KCGKBDGKIOP, ImpressionTracker IDCFOEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6D86170", Offset = "0x6D84970", VA = "0x186D86170")]
		private string EPPDGNPCKMG(int MPKGOMEHMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6D85DE0", Offset = "0x6D845E0", VA = "0x186D85DE0")]
		private int CLOPGEHNNGB(OJGMFDCBPLE GJAJAHIEACP, OJGMFDCBPLE MCEIDNFODED)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6D86D40", Offset = "0x6D85540", VA = "0x186D86D40")]
		private bool LDKFAONLLMN(IIGJKKEIJJN BMGEHAEKNOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6D895F0", Offset = "0x6D87DF0", VA = "0x186D895F0")]
		public ImpressionTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class CJGGPBMOFJO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
	public CJGGPBMOFJO()
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
