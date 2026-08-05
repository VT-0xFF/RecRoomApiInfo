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
		[Cpp2IlInjected.Address(RVA = "0x6E3FCB0", Offset = "0x6E3F0B0", VA = "0x186E3FCB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[HJLAABANLKG]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<KNONOKPNJJL>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KNONOKPNJJL Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2258480", Offset = "0x2257880", VA = "0x182258480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E2B3C0", Offset = "0x6E2A7C0", VA = "0x186E2B3C0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E2B760", Offset = "0x6E2AB60", VA = "0x186E2B760", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E2B4C0", Offset = "0x6E2A8C0", VA = "0x186E2B4C0")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "20")]
		protected override void OnDataUpdated(KNONOKPNJJL dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E2B860", Offset = "0x6E2AC60", VA = "0x186E2B860")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[HJLAABANLKG]
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
		[Cpp2IlInjected.Address(RVA = "0x6E2C470", Offset = "0x6E2B870", VA = "0x186E2C470", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C590", Offset = "0x6E2B990", VA = "0x186E2C590", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C880", Offset = "0x6E2BC80", VA = "0x186E2C880")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[HJLAABANLKG]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C8C0", Offset = "0x6E2BCC0", VA = "0x186E2C8C0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C970", Offset = "0x6E2BD70", VA = "0x186E2C970")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[HJLAABANLKG]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C9B0", Offset = "0x6E2BDB0", VA = "0x186E2C9B0", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CA50", Offset = "0x6E2BE50", VA = "0x186E2CA50")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[HJLAABANLKG]
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
			[Cpp2IlInjected.Address(RVA = "0x6E3F0E0", Offset = "0x6E3E4E0", VA = "0x186E3F0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
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
		private PLBFKJMGACI<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E470", Offset = "0x6E2D870", VA = "0x186E2E470", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E6A0", Offset = "0x6E2DAA0", VA = "0x186E2E6A0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E7D0", Offset = "0x6E2DBD0", VA = "0x186E2E7D0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E5F0", Offset = "0x6E2D9F0", VA = "0x186E2E5F0")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__7))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E990", Offset = "0x6E2DD90", VA = "0x186E2E990")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[HJLAABANLKG]
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
		[Cpp2IlInjected.Address(RVA = "0x6E31500", Offset = "0x6E30900", VA = "0x186E31500", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E315A0", Offset = "0x6E309A0", VA = "0x186E315A0")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[HJLAABANLKG]
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
		[Cpp2IlInjected.Address(RVA = "0x6E315E0", Offset = "0x6E309E0", VA = "0x186E315E0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E317A0", Offset = "0x6E30BA0", VA = "0x186E317A0")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[HJLAABANLKG]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E37F80", Offset = "0x6E37380", VA = "0x186E37F80", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E38010", Offset = "0x6E37410", VA = "0x186E38010")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[HJLAABANLKG]
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
		[HFJGENLBJBK("useQueryDataInUri")]
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
		[HFJGENLBJBK("overrideLoadSceneSource")]
		[SerializeField]
		private LNCAGIPKDAL loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LCFAMOPOKBO vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A3D0", Offset = "0x6E397D0", VA = "0x186E3A3D0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A760", Offset = "0x6E39B60", VA = "0x186E3A760", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A560", Offset = "0x6E39960", VA = "0x186E3A560")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A840", Offset = "0x6E39C40", VA = "0x186E3A840")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[HJLAABANLKG]
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
		[Cpp2IlInjected.Address(RVA = "0x6E3F380", Offset = "0x6E3E780", VA = "0x186E3F380", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F5F0", Offset = "0x6E3E9F0", VA = "0x186E3F5F0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F680", Offset = "0x6E3EA80", VA = "0x186E3F680", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F9F0", Offset = "0x6E3EDF0", VA = "0x186E3F9F0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F8F0", Offset = "0x6E3ECF0", VA = "0x186E3F8F0", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F850", Offset = "0x6E3EC50", VA = "0x186E3F850", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F730", Offset = "0x6E3EB30", VA = "0x186E3F730", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F7A0", Offset = "0x6E3EBA0", VA = "0x186E3F7A0")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FC60", Offset = "0x6E3F060", VA = "0x186E3FC60")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class DDGIIPAHMND
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string ELEOCLIMMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string> JOKCDIDFONH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2EAA0", Offset = "0x6E2DEA0", VA = "0x186E2EAA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E9D0", Offset = "0x6E2DDD0", VA = "0x186E2E9D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E2EA80", Offset = "0x6E2DE80", VA = "0x186E2EA80")]
	protected void CIOAIGABPCC([CallerMemberName] string NHHEMHBDHEB = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected DDGIIPAHMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKBLADILMEE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KNJNENKNCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	double LKIPKFIMEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NDONOGOEAKC : CKBLADILMEE
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static string NDFLOBPECGD;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static string GBPBFDLLJOA;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static string CFHMINJEPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PBMDMFNAGKG AEGFBMCHPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool? DIOHBHFMGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private double? DACNCKDDKPD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KNJNENKNCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E36190", Offset = "0x6E35590", VA = "0x186E36190", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double LKIPKFIMEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E36320", Offset = "0x6E35720", VA = "0x186E36320", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E364B0", Offset = "0x6E358B0", VA = "0x186E364B0")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	[UnityEngine.Scripting.Preserve]
	internal NDONOGOEAKC([NotNull][CNGCCDLPGOD(null)] PBMDMFNAGKG AEGFBMCHPJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FEJAMCIDIDM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GFIBKFLBFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NBBFDDCCLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CGMAEKIMOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ONIIKLOPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LCFAMOPOKBO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IEFGEALKNFF HPKIHMOGCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MBJIEKCHNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool NKHAIAPBLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long AKBNDPELFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GJBMCNJAGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BEDFKKENLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool LOMLLJANJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JOHFDAGBHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CBKEIDPFIMB(BrowserModel JAPKNLBAAMP, Uri ELAJMIEMCCG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MPEMDLOBJCN(BrowserModel JAPKNLBAAMP, Uri AGDCNDNIGKN, RoomListQueryData GLMFHHIGGDM, bool HGDMGPPDIFB = false, LNCAGIPKDAL LDAKNAMJFIK = LNCAGIPKDAL.NOT_SET);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string BHDEPLCKBCF(RoomListQueryData GLMFHHIGGDM);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string EEMEDACCHOB(RoomListQueryData GLMFHHIGGDM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KNONOKPNJJL DAJDFFNGILA(string PLEFLLOBFNH, [Optional] string OMBFFJPPECC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task MELBFKFJAEG(GLFEDGLGEEF.NBPJEHFNFFH KLPFEOBMCNM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool FAPMPHNBOKC(BrowserModel JAPKNLBAAMP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IMKNOKOCOLD([Out] FABEAAEBPBG<bool> MGOPNJHLCIA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KNGAHONCLAA(string NKFJKDHEIEK);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KMLMNLLCLHN(string KMKFNKLCAIF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<bool> HBPAIEJEIKE(long GGLEGKBAGLC, CancellationToken CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<BEANCEBHDPC> KFFAIMOFNCJ(NLMAEEICDJF CIOKBAAIBPO, CancellationToken CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EAEGHMCLOAB(PIPCEIFGMAA MFIGDOAMPLE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task EHNOEADOBOH(DialogListModel HPEGEJMLADC, JELLMLEOJEP NCFFAKDPOCC, CancellationToken CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool AFEHJBNKHGE(bool OLAMLAEDCDH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KMBCLDFLLLF(BrowserModel JAPKNLBAAMP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum HPJGCNNDELB
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
public enum KNONOKPNJJL
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
			public CKAOGCJJDMC platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public KNONOKPNJJL HighlightStyle;

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
			public HPJGCNNDELB CarouselType;

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
		private sealed class OINOKHEAIFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public BrowserModel browserModel;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public OINOKHEAIFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6E376B0", Offset = "0x6E36AB0", VA = "0x186E376B0")]
			internal bool PPLJKLJGNHP(Uri uri)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KCCLFPCBFFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HPJGCNNDELB carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public KCCLFPCBFFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F0B0", Offset = "0x6E2E4B0", VA = "0x186E2F0B0")]
			internal bool PABFOLJCEOO(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class MAMINEBNOHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public HPJGCNNDELB carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MAMINEBNOHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F0B0", Offset = "0x6E2E4B0", VA = "0x186E2F0B0")]
			internal bool EMJNPEAGGJJ(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OPPOJKBINPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HPJGCNNDELB carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public OPPOJKBINPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F0B0", Offset = "0x6E2E4B0", VA = "0x186E2F0B0")]
			internal bool CIGOHFCDDFB(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IOPDAOKNBLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public HPJGCNNDELB carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public IOPDAOKNBLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F0B0", Offset = "0x6E2E4B0", VA = "0x186E2F0B0")]
			internal bool BGMAKGOJGKE(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class FBBAKALOIAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HPJGCNNDELB carouselType;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public FBBAKALOIAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F0B0", Offset = "0x6E2E4B0", VA = "0x186E2F0B0")]
			internal bool JOBLMFMCDIL(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FOECMBILOOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public KNONOKPNJJL highlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CarouselDisplayConfig <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public FOECMBILOOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F0C0", Offset = "0x6E2E4C0", VA = "0x186E2F0C0")]
			internal bool DKELBNPGIGE(HighlightCardDataObject a)
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
		private LCFAMOPOKBO vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6E2BDB0", Offset = "0x6E2B1B0", VA = "0x186E2BDB0")]
		public bool ANFIAIFMCCK(BrowserModel JAPKNLBAAMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C220", Offset = "0x6E2B620", VA = "0x186E2C220")]
		public float IDADBNOEADN(KNONOKPNJJL CBOIILIMPMC, HPJGCNNDELB BDFPPFNDJFA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E2BE90", Offset = "0x6E2B290", VA = "0x186E2BE90")]
		public float APBBJHODPLC(KNONOKPNJJL CBOIILIMPMC, HPJGCNNDELB BDFPPFNDJFA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E2BA20", Offset = "0x6E2AE20", VA = "0x186E2BA20")]
		public float AMFNFOKKNIC(KNONOKPNJJL CBOIILIMPMC, HPJGCNNDELB BDFPPFNDJFA, int GAGDJPKICPM = 1, bool BDBPGLDAOBO = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C360", Offset = "0x6E2B760", VA = "0x186E2C360")]
		public RectOffset MILPJDAKNPD(HPJGCNNDELB BDFPPFNDJFA, int GAGDJPKICPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C0E0", Offset = "0x6E2B4E0", VA = "0x186E2C0E0")]
		public int HBKAKMEFPMK(bool CJPKLAIABHM, KNONOKPNJJL CBOIILIMPMC, HPJGCNNDELB BDFPPFNDJFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C0B0", Offset = "0x6E2B4B0", VA = "0x186E2C0B0")]
		public int GEOAAFJCNEJ(bool CJPKLAIABHM, KNONOKPNJJL CBOIILIMPMC, HPJGCNNDELB BDFPPFNDJFA, int JCGKPCPEFCL = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C000", Offset = "0x6E2B400", VA = "0x186E2C000")]
		public int DDOJAIGAAGF(bool CJPKLAIABHM, KNONOKPNJJL CBOIILIMPMC, HPJGCNNDELB BDFPPFNDJFA, int JCGKPCPEFCL = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2B8A0", Offset = "0x6E2ACA0", VA = "0x186E2B8A0")]
		private HighlightCardDataObject ABLDPANBJOM(KNONOKPNJJL CBOIILIMPMC)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C450", Offset = "0x6E2B850", VA = "0x186E2C450")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private const int FPDEKMLLHPO = 20;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private const int DMNHOMOOIOJ = 6;

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
		private HPJGCNNDELB carouselType;

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
		private CKAOGCJJDMC hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool DMBOFGLLMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int KBPEBAHOHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private float? DCJCCNNAGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private float? PFDMBEECDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string DOCEGEJIOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private KNONOKPNJJL CBOIILIMPMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private LCFAMOPOKBO PIDFKCNJJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private BrowserModel JAPKNLBAAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private DiscoveryDisplayMetadata HLEEHBHKAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private string PLEFLLOBFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int AABLKHGGPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int GOAOKCBHHMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<IDataItem> JICKFHECGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private DataItem<bool> KLENJAEGIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private DataItem<int> OHDMFAHALEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private DataItem<float?> EAAKEEFBCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private DataItem<float?> EFKKGFBKMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private DataItem<string> OEMIGEKPCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private DataItem<KNONOKPNJJL> CKHEOFJGEMF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool JAIFPMGIJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DC0", Offset = "0x8D01C0", VA = "0x1808D0DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6E2CA90", Offset = "0x6E2BE90", VA = "0x186E2CA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int AMCEENCGBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAB20A0", Offset = "0xAB14A0", VA = "0x180AB20A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6E2D7B0", Offset = "0x6E2CBB0", VA = "0x186E2D7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? CPLNPJGCGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6E2E350", Offset = "0x6E2D750", VA = "0x186E2E350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[BindableData(3, "The width override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? JAJOFMCDGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF20", Offset = "0x8CA320", VA = "0x1808CAF20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6E2E3E0", Offset = "0x6E2D7E0", VA = "0x186E2E3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string MMFJLMECGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CEDF0", VA = "0x1808CF9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6E2D0D0", Offset = "0x6E2C4D0", VA = "0x186E2D0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public KNONOKPNJJL CEPCJPOIJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xEAE200", Offset = "0xEAD600", VA = "0x180EAE200")]
			get
			{
				return default(KNONOKPNJJL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6E2CAF0", Offset = "0x6E2BEF0", VA = "0x186E2CAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int HFHDMFOHAHK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA97210", Offset = "0xA96610", VA = "0x180A97210")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA97150", Offset = "0xA96550", VA = "0x180A97150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int JKJENMMDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2146880", Offset = "0x2145C80", VA = "0x182146880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override List<IDataItem> HADEMOLMDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6E2E310", Offset = "0x6E2D710", VA = "0x186E2E310", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected override bool LJMECHDFELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CBE0", Offset = "0x6E2BFE0", VA = "0x186E2CBE0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2DB10", Offset = "0x6E2CF10", VA = "0x186E2DB10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CCB0", Offset = "0x6E2C0B0", VA = "0x186E2CCB0")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata HLEEHBHKAHP, string PLEFLLOBFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D960", Offset = "0x6E2CD60", VA = "0x186E2D960")]
		private int NFFNIBLELEB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CFE0", Offset = "0x6E2C3E0", VA = "0x186E2CFE0")]
		private KNONOKPNJJL FDNEKOEIKBJ()
		{
			return default(KNONOKPNJJL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CB50", Offset = "0x6E2BF50", VA = "0x186E2CB50")]
		private void AOEFKCKIJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E2DBC0", Offset = "0x6E2CFC0", VA = "0x186E2DBC0")]
		private void PDPNPFKFBOO(int BIDCCNEFIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CEF0", Offset = "0x6E2C2F0", VA = "0x186E2CEF0")]
		private string EEFEAIGEJAK(KNONOKPNJJL HPCAJFCKIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D140", Offset = "0x6E2C540", VA = "0x186E2D140", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D800", Offset = "0x6E2CC00", VA = "0x186E2D800")]
		private void KJLMDLIGKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E090", Offset = "0x6E2D490", VA = "0x186E2E090")]
		public CarouselViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D0DC0", Offset = "0x8D01C0", VA = "0x1808D0DC0")]
		[CompilerGenerated]
		private bool JLACOHPOHAC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CA90", Offset = "0x6E2BE90", VA = "0x186E2CA90")]
		[CompilerGenerated]
		private void AGPIFMGAPOF(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAB20A0", Offset = "0xAB14A0", VA = "0x180AB20A0")]
		[CompilerGenerated]
		private int ANAMGNNGGON()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D7B0", Offset = "0x6E2CBB0", VA = "0x186E2D7B0")]
		[CompilerGenerated]
		private void JIDIHPIDHMK(int LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00")]
		[CompilerGenerated]
		private float? FLOAHKKIFNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CCA0", Offset = "0x6E2C0A0", VA = "0x186E2CCA0")]
		[CompilerGenerated]
		private void CKIPLGMELGK(float? LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF20", Offset = "0x8CA320", VA = "0x1808CAF20")]
		[CompilerGenerated]
		private float? DNJIKDJPNJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D0C0", Offset = "0x6E2C4C0", VA = "0x186E2D0C0")]
		[CompilerGenerated]
		private void FKHCPDOCOJN(float? LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CEDF0", VA = "0x1808CF9F0")]
		[CompilerGenerated]
		private string MCNCAJFJNJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D0D0", Offset = "0x6E2C4D0", VA = "0x186E2D0D0")]
		[CompilerGenerated]
		private void GMPEDBNOIMK(string LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xEAE200", Offset = "0xEAD600", VA = "0x180EAE200")]
		[CompilerGenerated]
		private KNONOKPNJJL GCHNCNAOEEK()
		{
			return default(KNONOKPNJJL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CAF0", Offset = "0x6E2BEF0", VA = "0x186E2CAF0")]
		[CompilerGenerated]
		private void AILMCNKHDNP(KNONOKPNJJL LLKDJGHBOID)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private LCFAMOPOKBO vNextBridge;

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
		private IEFGEALKNFF[] unsupportedPlatformTypes;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private IEFGEALKNFF[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6E2EF80", Offset = "0x6E2E380", VA = "0x186E2EF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6E2EF20", Offset = "0x6E2E320", VA = "0x186E2EF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6E2EB50", Offset = "0x6E2DF50", VA = "0x186E2EB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6E2EBB0", Offset = "0x6E2DFB0", VA = "0x186E2EBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2210A20", Offset = "0x220FE20", VA = "0x182210A20")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int BAMMBDHFILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private long BIGDGNGNMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private long MFGEKOHJFGA;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int EOPHBJLKEPF
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8E4C50", Offset = "0x8E4050", VA = "0x1808E4C50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6E30170", Offset = "0x6E2F570", VA = "0x186E30170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long AKBNDPELFBD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6E30220", Offset = "0x6E2F620", VA = "0x186E30220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long GAOIJKNCCIP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6E301C0", Offset = "0x6E2F5C0", VA = "0x186E301C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E2FFF0", Offset = "0x6E2F3F0", VA = "0x186E2FFF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E2FE90", Offset = "0x6E2F290", VA = "0x186E2FE90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E2FD40", Offset = "0x6E2F140", VA = "0x186E2FD40")]
		private void DHJADNOBGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E2FB40", Offset = "0x6E2EF40", VA = "0x186E2FB40")]
		private void AMGLIEAJLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E30150", Offset = "0x6E2F550", VA = "0x186E30150")]
		public GlobalDataViewModel()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BMAIDOBAHDC : DDGIIPAHMND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private PJONPPOEIME PECGIMGEMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool ABDBEIMHOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private int EIBHHHKOPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool JFDCMPDGIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int CLBFMAAPOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool DIMIDJCOHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool AKKKLPKDDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool BJGBPNKJMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool MLIEJOCFJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool BLPIIBPJCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool NICIILOJDKA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PJONPPOEIME IECFCCEKJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AF90", Offset = "0x6E2A390", VA = "0x186E2AF90")]
		get
		{
			return default(PJONPPOEIME);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AD10", Offset = "0x6E2A110", VA = "0x186E2AD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HOBHKOLMDNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F6200", Offset = "0x8F5600", VA = "0x1808F6200")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E2ADB0", Offset = "0x6E2A1B0", VA = "0x186E2ADB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JPMPNJODHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA540F0", Offset = "0xA534F0", VA = "0x180A540F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AED0", Offset = "0x6E2A2D0", VA = "0x186E2AED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int AKCBHKADOEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0EB0", VA = "0x1809F1AB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE70", Offset = "0x6E2A270", VA = "0x186E2AE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DLAGJPIMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xD91910", Offset = "0xD90D10", VA = "0x180D91910")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E2B030", Offset = "0x6E2A430", VA = "0x186E2B030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PLBKBMCKCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x979C10", Offset = "0x979010", VA = "0x180979C10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AF30", Offset = "0x6E2A330", VA = "0x186E2AF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DKBBCKFLJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6635F80", Offset = "0x6635380", VA = "0x186635F80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E2ACB0", Offset = "0x6E2A0B0", VA = "0x186E2ACB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool LINABEKAFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E2ACA0", Offset = "0x6E2A0A0", VA = "0x186E2ACA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PJAFCKNDKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x12792C0", Offset = "0x12786C0", VA = "0x1812792C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AFD0", Offset = "0x6E2A3D0", VA = "0x186E2AFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PBPPGFPNKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x12793A0", Offset = "0x12787A0", VA = "0x1812793A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE10", Offset = "0x6E2A210", VA = "0x186E2AE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B090", Offset = "0x6E2A490", VA = "0x186E2B090")]
	public BMAIDOBAHDC()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, FEJAMCIDIDM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct PAEBPLLOBKI : IAsyncStateMachine
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
			private TaskAwaiter<List<PIPCEIFGMAA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6E376F0", Offset = "0x6E36AF0", VA = "0x186E376F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private LCFAMOPOKBO PIDFKCNJJLG;

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
		private LNCAGIPKDAL loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private JOLGMCMGLGG PMGOPFIOELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private CancellationTokenSource BPPNMIHDBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private BrowserModel JAPKNLBAAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private bool FKJMEBEHGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private List<long> BEGHFBAGOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int IOGOENDIBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool GMNNGPCNGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private DataList<long> CJEDNCAHEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private string KEFHOFNMIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool BAACFFNFODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private BMAIDOBAHDC BBPNDHDAAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private List<IDataItem> JICKFHECGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DataItem<string> AFGOKCJPNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DataItem<bool> PIEOLDJFLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private DataItem<RoomListQueryData> CCCKNNJIDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DataItem<BMAIDOBAHDC> GIALIKJJLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DataItemList PMIAKAJAEFG;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> MLEPEBANPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA20", Offset = "0x8CEE20", VA = "0x1808CFA20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6E3A360", Offset = "0x6E39760", VA = "0x186E3A360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string EOIOGDGBCML
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A00", Offset = "0x9A3E00", VA = "0x1809A4A00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6E3A2E0", Offset = "0x6E396E0", VA = "0x186E3A2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool FDPEAALJBMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA540F0", Offset = "0xA534F0", VA = "0x180A540F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6E392E0", Offset = "0x6E386E0", VA = "0x186E392E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData MFHCOOECLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public BMAIDOBAHDC JEKDHNMMHHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6E39130", Offset = "0x6E38530", VA = "0x186E39130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GFIBKFLBFLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA8C040", Offset = "0xA8B440", VA = "0x180A8C040", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA8C2A0", Offset = "0xA8B6A0", VA = "0x180A8C2A0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NBBFDDCCLKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F39440", Offset = "0x1F38840", VA = "0x181F39440", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F39430", Offset = "0x1F38830", VA = "0x181F39430", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CGMAEKIMOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x208B750", Offset = "0x208AB50", VA = "0x18208B750", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x208A2C0", Offset = "0x20896C0", VA = "0x18208A2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ONIIKLOPDCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5E485A0", Offset = "0x5E479A0", VA = "0x185E485A0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x5E4A270", Offset = "0x5E49670", VA = "0x185E4A270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool IEHBGMHAKLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAE8480", Offset = "0xAE7880", VA = "0x180AE8480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public LNCAGIPKDAL EAICCJHEIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCF7110", Offset = "0xCF6510", VA = "0x180CF7110")]
			get
			{
				return default(LNCAGIPKDAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override List<IDataItem> HADEMOLMDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6E3A2A0", Offset = "0x6E396A0", VA = "0x186E3A2A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected override bool LJMECHDFELG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E39DE0", Offset = "0x6E391E0", VA = "0x186E39DE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E39A40", Offset = "0x6E38E40", VA = "0x186E39A40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E39D20", Offset = "0x6E39120", VA = "0x186E39D20")]
		public void SetQueryData(RoomListQueryData CELDGNNJCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E39BE0", Offset = "0x6E38FE0", VA = "0x186E39BE0")]
		public void SetDiscoverySectionId(string COEPMGNCEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E38130", Offset = "0x6E37530", VA = "0x186E38130")]
		[AsyncStateMachine(typeof(PAEBPLLOBKI))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E39C90", Offset = "0x6E39090", VA = "0x186E39C90")]
		public void SetMaxItems(int IHGFKGDHEKC, int AIGDBBJMKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6E39CF0", Offset = "0x6E390F0", VA = "0x186E39CF0")]
		public void SetMinItems(int ICKECKDKIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6E38450", Offset = "0x6E37850", VA = "0x186E38450")]
		private void GLMJPKIEBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6E381E0", Offset = "0x6E375E0", VA = "0x186E381E0")]
		private string GDKBGBCJHAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1F39440", Offset = "0x1F38840", VA = "0x181F39440")]
		private bool OPJCALBJKOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E39340", Offset = "0x6E38740", VA = "0x186E39340")]
		private void OLBMOFHOBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E38970", Offset = "0x6E37D70", VA = "0x186E38970")]
		private void IPDHILLCJJP(ImpressionTracker FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6E38AF0", Offset = "0x6E37EF0", VA = "0x186E38AF0", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E391A0", Offset = "0x6E385A0", VA = "0x186E391A0")]
		private void KJLMDLIGKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E39F80", Offset = "0x6E39380", VA = "0x186E39F80")]
		public RoomListViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9A4A00", Offset = "0x9A3E00", VA = "0x1809A4A00")]
		[CompilerGenerated]
		private string DCGEPAEALPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E38050", Offset = "0x6E37450", VA = "0x186E38050")]
		[CompilerGenerated]
		private void BOANJFLGONG(string LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA540F0", Offset = "0xA534F0", VA = "0x180A540F0")]
		[CompilerGenerated]
		private bool MLNEMDOKDLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E392E0", Offset = "0x6E386E0", VA = "0x186E392E0")]
		[CompilerGenerated]
		private void LIOOGDIBEAD(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0")]
		[CompilerGenerated]
		private RoomListQueryData BNOHKBEPFHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290")]
		[CompilerGenerated]
		private BMAIDOBAHDC OFGPMHINGEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E39130", Offset = "0x6E38530", VA = "0x186E39130")]
		[CompilerGenerated]
		private void JOPMPLPMJCI(BMAIDOBAHDC LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA20", Offset = "0x8CEE20", VA = "0x1808CFA20")]
		[CompilerGenerated]
		private DataList ILHCMAJBEEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E38060", Offset = "0x6E37460", VA = "0x186E38060")]
		[CompilerGenerated]
		private void CFLPEPONIPL(DataList LLKDJGHBOID)
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
		private struct JAOAHACEEOG : IAsyncStateMachine
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
			private TaskAwaiter<PIPCEIFGMAA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6E357B0", Offset = "0x6E34BB0", VA = "0x186E357B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct GCFFLCINCKA : IAsyncStateMachine
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
			private NLMAEEICDJF <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private TaskAwaiter<NLMAEEICDJF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F150", Offset = "0x6E2E550", VA = "0x186E2F150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class JFGLGLLKGFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public NLMAEEICDJF roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public bool randomSubroom;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public JFGLGLLKGFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x6E35AD0", Offset = "0x6E34ED0", VA = "0x186E35AD0")]
			internal void PIKHMCFHCDE()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct KOIODGNGACG : IAsyncStateMachine
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
			public NLMAEEICDJF roomDetails;

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

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x6E35B10", Offset = "0x6E34F10", VA = "0x186E35B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class LDIDNPBGEND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public NLMAEEICDJF roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public BEANCEBHDPC subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public LDIDNPBGEND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x6E360A0", Offset = "0x6E354A0", VA = "0x186E360A0")]
			internal void ICODMFFKPEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class GIOALENHHLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public GNODDIAAKFD latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public LDIDNPBGEND CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public GIOALENHHLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x6E2FA40", Offset = "0x6E2EE40", VA = "0x186E2FA40")]
			internal void OKJBKFCGOGC()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct HAGDLPCPAFM : IAsyncStateMachine
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
			public NLMAEEICDJF roomDetails;

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
			private LDIDNPBGEND <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private GIOALENHHLH <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private TaskAwaiter<BEANCEBHDPC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private HNLNCDFMAHN <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private TaskAwaiter<GNODDIAAKFD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x6E30280", Offset = "0x6E2F680", VA = "0x186E30280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private const string AOIMLPBCKIH = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private const char EKCMJHCBJGG = '.';

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
		private JOLGMCMGLGG GIFMKPBDKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private AIDPAHIFJDL NJGNMKNFBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private LCFAMOPOKBO PIDFKCNJJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private CancellationTokenSource BPPNMIHDBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private PJONPPOEIME PECGIMGEMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private BrowserModel JAPKNLBAAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DialogListModel HPEGEJMLADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int NKAFCADOJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int NGIKCFLEJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int AHAFONDBFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private bool MCCCMOOPOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DateTime? FJGBMJIBNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private bool ENCKLABGONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private long GGLEGKBAGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private string MMNDGHPNBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private string JADMIFIBKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private string MDMALADOMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private bool MOFONHBAMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private string ELIDPCIAJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool LPKKEGFJLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private bool HAEMOKNOJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private string IGDNBLJBIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool AFEGPJLACNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private bool OPFHHLAGPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x152")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private bool CNGAFOAEFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x153")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private bool IIPDPHBAKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private bool NMMMMLBPHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x155")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool LMHKNIOOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x156")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private bool AKKKLPKDDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x157")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private bool JBNELLEIFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool BLPIIBPJCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private bool NICIILOJDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<IDataItem> JICKFHECGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private DataItem<long> GMHAPCMALLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private DataItem<string> NKMLHBJINFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private DataItem<string> ABJKBDJHABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private DataItem<string> AEOGCFCMBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private DataItem<bool> JAKLGOGPIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private DataItem<string> AHFFOAOJFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private DataItem<bool> CGAAIHJOANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private DataItem<bool> FIFMOJEHGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private DataItem<string> JHIMCDGDEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private DataItem<bool> MAKILIOOLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private DataItem<bool> NMPJCDEPLOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DataItem<bool> FMKMDEPJKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private DataItem<bool> FEMPPPEGJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private DataItem<bool> PACICIGBDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private DataItem<bool> AOLIDLLKKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DataItem<bool> EFMHHGIALLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private DataItem<bool> EEIJGNIDNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private DataItem<bool> EEJLIOEOGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private DataItem<bool> KEAGJKBNHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DataItemAction BAACPIEDJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private DataItemAction BHNONMHKAMI;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long JHIEDJKCDNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9774E0", Offset = "0x9768E0", VA = "0x1809774E0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EFE0", Offset = "0x6E3E3E0", VA = "0x186E3EFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string MMGKHNMJLMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x979E80", Offset = "0x979280", VA = "0x180979E80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EEE0", Offset = "0x6E3E2E0", VA = "0x186E3EEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string PGKBPOBAJDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x991150", Offset = "0x990550", VA = "0x180991150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EE60", Offset = "0x6E3E260", VA = "0x186E3EE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string ONLELMCGHGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9EBB00", Offset = "0x9EAF00", VA = "0x1809EBB00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EF60", Offset = "0x6E3E360", VA = "0x186E3EF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool CAEJGLDHDCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1525050", Offset = "0x1524450", VA = "0x181525050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6E3B590", Offset = "0x6E3A990", VA = "0x186E3B590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string LDKIDAOBALE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9EBB20", Offset = "0x9EAF20", VA = "0x1809EBB20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EDE0", Offset = "0x6E3E1E0", VA = "0x186E3EDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool DNGPBNGNGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x16F0120", Offset = "0x16EF520", VA = "0x1816F0120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6E3A880", Offset = "0x6E39C80", VA = "0x186E3A880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool BMENKNLDAJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1D44830", Offset = "0x1D43C30", VA = "0x181D44830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D560", Offset = "0x6E3C960", VA = "0x186E3D560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string LMALGAHPPFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x985B20", Offset = "0x984F20", VA = "0x180985B20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6E3ED60", Offset = "0x6E3E160", VA = "0x186E3ED60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool PGLMOJGKPBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1457C10", Offset = "0x1457010", VA = "0x181457C10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6E3DF80", Offset = "0x6E3D380", VA = "0x186E3DF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool MACJHICEIJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1530870", Offset = "0x152FC70", VA = "0x181530870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D190", Offset = "0x6E3C590", VA = "0x186E3D190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool FHFIFCIPEKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1530880", Offset = "0x152FC80", VA = "0x181530880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D5C0", Offset = "0x6E3C9C0", VA = "0x186E3D5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool LJNFAIEPDII
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6E3B0E0", Offset = "0x6E3A4E0", VA = "0x186E3B0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6E3B0F0", Offset = "0x6E3A4F0", VA = "0x186E3B0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool PILJHJLEEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x17D7E40", Offset = "0x17D7240", VA = "0x1817D7E40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6E3AAE0", Offset = "0x6E39EE0", VA = "0x186E3AAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool MGJCPGJFGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D630", Offset = "0x6E3CA30", VA = "0x186E3D630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6E3E040", Offset = "0x6E3D440", VA = "0x186E3E040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool PLBKBMCKCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6E3B580", Offset = "0x6E3A980", VA = "0x186E3B580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6E3AA80", Offset = "0x6E39E80", VA = "0x186E3AA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool MDHMOKNDOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6E3BAF0", Offset = "0x6E3AEF0", VA = "0x186E3BAF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6E3B520", Offset = "0x6E3A920", VA = "0x186E3B520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool PJAFCKNDKMN
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x11A6F20", Offset = "0x11A6320", VA = "0x1811A6F20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6E3E340", Offset = "0x6E3D740", VA = "0x186E3E340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool PBPPGFPNKAN
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x1A19CF0", Offset = "0x1A190F0", VA = "0x181A19CF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6E3DFE0", Offset = "0x6E3D3E0", VA = "0x186E3DFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool AHBOFIGJIFN
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EC90", Offset = "0x6E3E090", VA = "0x186E3EC90", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D620", Offset = "0x6E3CA20", VA = "0x186E3D620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override List<IDataItem> HADEMOLMDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EC50", Offset = "0x6E3E050", VA = "0x186E3EC50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected override bool LJMECHDFELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ILoadable> KHANIEHIGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6E3EB90", Offset = "0x6E3DF90", VA = "0x186E3EB90", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6E3ECA0", Offset = "0x6E3E0A0", VA = "0x186E3ECA0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AB40", Offset = "0x6E39F40", VA = "0x186E3AB40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E480", Offset = "0x6E3D880", VA = "0x186E3E480")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E290", Offset = "0x6E3D690", VA = "0x186E3E290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E3A0", Offset = "0x6E3D7A0", VA = "0x186E3E3A0", Slot = "12")]
		public override void SetBindingData(int OCLLKPEICCI, int ELHJOOLDFFH, int IIACLAMOIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AD80", Offset = "0x6E3A180", VA = "0x186E3AD80")]
		private void DAHOKPNHDDK(IDataSource MOKJOEJBOBF, int ELHJOOLDFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B030", Offset = "0x6E3A430", VA = "0x186E3B030")]
		[AsyncStateMachine(typeof(JAOAHACEEOG))]
		private void DGHABMIHKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B6F0", Offset = "0x6E3AAF0", VA = "0x186E3B6F0")]
		private void GNGAKEFMCML(PIPCEIFGMAA EGAKKFKFNCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D640", Offset = "0x6E3CA40", VA = "0x186E3D640")]
		private void NJPEBPMMEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B150", Offset = "0x6E3A550", VA = "0x186E3B150")]
		private void EAKMIOGJNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E0A0", Offset = "0x6E3D4A0", VA = "0x186E3E0A0")]
		private void OJMDAPICDAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6E3CCF0", Offset = "0x6E3C0F0", VA = "0x186E3CCF0")]
		[BindableAction(100, null)]
		private void KDNGJNPMMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AF80", Offset = "0x6E3A380", VA = "0x186E3AF80")]
		[AsyncStateMachine(typeof(GCFFLCINCKA))]
		[BindableAction(101, null)]
		private void DDNGFBMBHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B5F0", Offset = "0x6E3A9F0", VA = "0x186E3B5F0")]
		[AsyncStateMachine(typeof(KOIODGNGACG))]
		private void GKDIAPILJHM(bool HFOCFDLPOMD, NLMAEEICDJF CIOKBAAIBPO, bool KEKGACNLDFK = false, bool GIJPNEDECFF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AC70", Offset = "0x6E3A070", VA = "0x186E3AC70")]
		[AsyncStateMachine(typeof(HAGDLPCPAFM))]
		private void CKPPNOBNKKK(NLMAEEICDJF CIOKBAAIBPO, bool HFOCFDLPOMD, bool KEKGACNLDFK, bool GIJPNEDECFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E0C0", Offset = "0x6E3D4C0", VA = "0x186E3E0C0")]
		private void OLBMOFHOBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A8F0", Offset = "0x6E39CF0", VA = "0x186E3A8F0")]
		private void AILPDKPPJOL(string BLKCDEMMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6E3BB00", Offset = "0x6E3AF00", VA = "0x186E3BB00", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D1F0", Offset = "0x6E3C5F0", VA = "0x186E3D1F0")]
		private void KJLMDLIGKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E540", Offset = "0x6E3D940", VA = "0x186E3E540")]
		public RoomViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9774E0", Offset = "0x9768E0", VA = "0x1809774E0")]
		[CompilerGenerated]
		private long HKOFCNEPBMI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AC60", Offset = "0x6E3A060", VA = "0x186E3AC60")]
		[CompilerGenerated]
		private void CAABLGANFNN(long LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x979E80", Offset = "0x979280", VA = "0x180979E80")]
		[CompilerGenerated]
		private string CGBEDKEKCHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x991150", Offset = "0x990550", VA = "0x180991150")]
		[CompilerGenerated]
		private string BOJHHFCMCOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB00", Offset = "0x9EAF00", VA = "0x1809EBB00")]
		[CompilerGenerated]
		private string GNCKJJGLACB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A8E0", Offset = "0x6E39CE0", VA = "0x186E3A8E0")]
		[CompilerGenerated]
		private void ADMIOCDBMMH(string LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1525050", Offset = "0x1524450", VA = "0x181525050")]
		[CompilerGenerated]
		private bool AILAIPDKHCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B590", Offset = "0x6E3A990", VA = "0x186E3B590")]
		[CompilerGenerated]
		private void FOACBNNHAMN(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB20", Offset = "0x9EAF20", VA = "0x1809EBB20")]
		[CompilerGenerated]
		private string AJCKLFKPMBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AC40", Offset = "0x6E3A040", VA = "0x186E3AC40")]
		[CompilerGenerated]
		private void BBEDIENIGAG(string LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x16F0120", Offset = "0x16EF520", VA = "0x1816F0120")]
		[CompilerGenerated]
		private bool NCLEDGCJBHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A880", Offset = "0x6E39C80", VA = "0x186E3A880")]
		[CompilerGenerated]
		private void ACPAAHECNGN(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1D44830", Offset = "0x1D43C30", VA = "0x181D44830")]
		[CompilerGenerated]
		private bool GPOEJGKKMMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D560", Offset = "0x6E3C960", VA = "0x186E3D560")]
		[CompilerGenerated]
		private void LJDICCIIFDC(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x985B20", Offset = "0x984F20", VA = "0x180985B20")]
		[CompilerGenerated]
		private string COLDNKHLAFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AC50", Offset = "0x6E3A050", VA = "0x186E3AC50")]
		[CompilerGenerated]
		private void BDFIBNDLOPF(string LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1457C10", Offset = "0x1457010", VA = "0x181457C10")]
		[CompilerGenerated]
		private bool FGALHAMNKNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6E3DF80", Offset = "0x6E3D380", VA = "0x186E3DF80")]
		[CompilerGenerated]
		private void NKPONFBJLAD(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1530870", Offset = "0x152FC70", VA = "0x181530870")]
		[CompilerGenerated]
		private bool DGMPKDEOLKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D190", Offset = "0x6E3C590", VA = "0x186E3D190")]
		[CompilerGenerated]
		private void KFAHHFBLCKO(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1530880", Offset = "0x152FC80", VA = "0x181530880")]
		[CompilerGenerated]
		private bool KMPMHEMKHCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D5C0", Offset = "0x6E3C9C0", VA = "0x186E3D5C0")]
		[CompilerGenerated]
		private void LMBKAPKNPFP(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B0E0", Offset = "0x6E3A4E0", VA = "0x186E3B0E0")]
		[CompilerGenerated]
		private bool DMBFAMEIFPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B0F0", Offset = "0x6E3A4F0", VA = "0x186E3B0F0")]
		[CompilerGenerated]
		private void DOCBDGDCAMG(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x17D7E40", Offset = "0x17D7240", VA = "0x1817D7E40")]
		[CompilerGenerated]
		private bool KJNFLIIAGMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AAE0", Offset = "0x6E39EE0", VA = "0x186E3AAE0")]
		[CompilerGenerated]
		private void AOLIJOMPDOE(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D630", Offset = "0x6E3CA30", VA = "0x186E3D630")]
		[CompilerGenerated]
		private bool NIDEIFGOKOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E040", Offset = "0x6E3D440", VA = "0x186E3E040")]
		[CompilerGenerated]
		private void OHDGOKFKCAC(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B580", Offset = "0x6E3A980", VA = "0x186E3B580")]
		[CompilerGenerated]
		private bool FMIOFBNAPBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6E3AA80", Offset = "0x6E39E80", VA = "0x186E3AA80")]
		[CompilerGenerated]
		private void AKBCGNDBHIF(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6E3BAF0", Offset = "0x6E3AEF0", VA = "0x186E3BAF0")]
		[CompilerGenerated]
		private bool ICMHPEGJLBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6E3B520", Offset = "0x6E3A920", VA = "0x186E3B520")]
		[CompilerGenerated]
		private void EHGHFADLEAL(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x11A6F20", Offset = "0x11A6320", VA = "0x1811A6F20")]
		[CompilerGenerated]
		private bool FIHJGCKJOMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E340", Offset = "0x6E3D740", VA = "0x186E3E340")]
		[CompilerGenerated]
		private void PDLNGLCIBMA(bool LLKDJGHBOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1A19CF0", Offset = "0x1A190F0", VA = "0x181A19CF0")]
		[CompilerGenerated]
		private bool CJOEGBEKEAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3DFE0", Offset = "0x6E3D3E0", VA = "0x186E3DFE0")]
		[CompilerGenerated]
		private void OAKFDAHJPDD(bool LLKDJGHBOID)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override string FHMDFGKNGEH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x6E37F20", Offset = "0x6E37320", VA = "0x186E37F20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6E37F10", Offset = "0x6E37310", VA = "0x186E37F10")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected override string FHMDFGKNGEH
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x6E37F50", Offset = "0x6E37350", VA = "0x186E37F50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6E37F10", Offset = "0x6E37310", VA = "0x186E37F10")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NJJLDJDLMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public Dictionary<string, int> EJKKIGPNJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public Dictionary<string, float> CMJHPNCNMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public Dictionary<string, long> GELFOPAJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Dictionary<string, string> EAHLBDNCANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Dictionary<string, Guid> MADEMOEMAHD;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6E36AF0", Offset = "0x6E35EF0", VA = "0x186E36AF0")]
	public bool HHEAHCCKEEG(string LDCKBFKFIKC, [Out] string EGJNKINGMMA, string LAKAMCGCHJB = "")
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E36680", Offset = "0x6E35A80", VA = "0x186E36680")]
	public GLFEDGLGEEF.NBPJEHFNFFH EHCJHHNFLEC(string LDCKBFKFIKC, GLFEDGLGEEF.NBPJEHFNFFH EBHMEHANGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E368C0", Offset = "0x6E35CC0", VA = "0x186E368C0")]
	public void GBLOIPJOGHN(string LDCKBFKFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E36CD0", Offset = "0x6E360D0", VA = "0x186E36CD0")]
	public void MLBLEPOGDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E36DB0", Offset = "0x6E361B0", VA = "0x186E36DB0")]
	public void MMPOHNCIFOH(NJJLDJDLMLC LFPGKOFOABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E374F0", Offset = "0x6E368F0", VA = "0x186E374F0")]
	public NJJLDJDLMLC()
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
		internal enum MBFMPEIBEPI
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
		internal enum FHDOCKGMIFI
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct CNJDBCOEBEO : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x6E2B0B0", Offset = "0x6E2A4B0", VA = "0x186E2B0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static EDMMGCJIHED<NJJLDJDLMLC> JFLNPBCIGAJ;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private const float JOPBECFPBCH = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private const string GCPHGNMAHFA = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private MBFMPEIBEPI logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private FHDOCKGMIFI logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private NJJLDJDLMLC OBILHOLGAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int DKKPKGLFLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Dictionary<int, string> BIBLBIKBAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Dictionary<string, int> DPGEGEFNFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private List<int> LMHPMGKCOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private List<int> IFNNENAFHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private List<ImpressionTracker> BJLHBCBIKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private List<ImpressionTracker> GACJIPFPKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private List<int> OJFDEMJGOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private List<int> KCGENIBCLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Dictionary<int, int> HGOMPALINLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private List<int> HJAMLAABCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Dictionary<int, string> ABIICMIFGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Dictionary<string, string> PGHHGMLHDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private List<NJJLDJDLMLC> PEKMELKBHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<NJJLDJDLMLC> EKNONEFKMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private LCFAMOPOKBO PIDFKCNJJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private BrowserModel JAPKNLBAAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Uri DNBIDICHIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool MFJDFFGKNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private ImpressionTracker OCLGEJJLINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private bool AGFINCENILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private StringBuilder MLDBDEEBMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool AKHGHPDBLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xDFDC90", Offset = "0xDFD090", VA = "0x180DFDC90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x174E580", Offset = "0x174D980", VA = "0x18174E580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6E31AA0", Offset = "0x6E30EA0", VA = "0x186E31AA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6E335A0", Offset = "0x6E329A0", VA = "0x186E335A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6E33BD0", Offset = "0x6E32FD0", VA = "0x186E33BD0")]
		public void SetDataToCollateFromChildrenOnLog(string LDCKBFKFIKC, string EKFBHIJFHMA, bool CEFIHBMCBMO = false, string GLGJPBPEDMM = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6E33CF0", Offset = "0x6E330F0", VA = "0x186E33CF0")]
		public void SetDataToRecordOnClickThrough(string LDCKBFKFIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6E327C0", Offset = "0x6E31BC0", VA = "0x186E327C0")]
		public void LogImpression(bool MKNFMGNFODH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6E33270", Offset = "0x6E32670", VA = "0x186E33270")]
		[AsyncStateMachine(typeof(CNJDBCOEBEO))]
		private void MIHJPOHAJKC(Task PCIGJHKGNNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6E34B40", Offset = "0x6E33F40", VA = "0x186E34B40")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6E34EE0", Offset = "0x6E342E0", VA = "0x186E34EE0")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6E34EA0", Offset = "0x6E342A0", VA = "0x186E34EA0")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6E33960", Offset = "0x6E32D60", VA = "0x186E33960")]
		public void RecordClickThrough([Optional] string CDAABEECPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6E34900", Offset = "0x6E33D00", VA = "0x186E34900")]
		public void SetString(string LDCKBFKFIKC, string JGCOLLOOLHL, bool KMMKLLMLHGB = false, bool KLHMHIFHJNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6E33FB0", Offset = "0x6E333B0", VA = "0x186E33FB0")]
		public void SetGuid(string LDCKBFKFIKC, Guid JGCOLLOOLHL, bool KMMKLLMLHGB = false, bool KLHMHIFHJNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6E34460", Offset = "0x6E33860", VA = "0x186E34460")]
		public void SetLong(string LDCKBFKFIKC, long JGCOLLOOLHL, bool KMMKLLMLHGB = false, bool KLHMHIFHJNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6E33D60", Offset = "0x6E33160", VA = "0x186E33D60")]
		public void SetFloat(string LDCKBFKFIKC, float JGCOLLOOLHL, bool KMMKLLMLHGB = false, bool KLHMHIFHJNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6E346A0", Offset = "0x6E33AA0", VA = "0x186E346A0")]
		public void SetObject(string LDCKBFKFIKC, object JGCOLLOOLHL, bool KMMKLLMLHGB = false, bool KLHMHIFHJNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6E34220", Offset = "0x6E33620", VA = "0x186E34220")]
		public void SetInt(string LDCKBFKFIKC, int JGCOLLOOLHL, bool KMMKLLMLHGB = false, bool KLHMHIFHJNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6E35230", Offset = "0x6E34630", VA = "0x186E35230")]
		public bool TryGetValueAsString(string LDCKBFKFIKC, [Out] string EGJNKINGMMA, string LAKAMCGCHJB = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6E31E10", Offset = "0x6E31210", VA = "0x186E31E10")]
		public void ClearData(string LDCKBFKFIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6E334B0", Offset = "0x6E328B0", VA = "0x186E334B0")]
		private int NKBDKPDLFGN(string LDCKBFKFIKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6E32730", Offset = "0x6E31B30", VA = "0x186E32730")]
		private string LOADOEJKDJA(int LPMIIFILJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6E32220", Offset = "0x6E31620", VA = "0x186E32220")]
		private void FPDMEJKOHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6E33710", Offset = "0x6E32B10", VA = "0x186E33710")]
		private void PHHHNMOOHLJ(ImpressionTracker FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6E32020", Offset = "0x6E31420", VA = "0x186E32020")]
		private void EDHCECJMJCJ(ImpressionTracker FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6E33350", Offset = "0x6E32750", VA = "0x186E33350")]
		private void NFBCIHMLKIN(bool GMHKIAOJLFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6E338C0", Offset = "0x6E32CC0", VA = "0x186E338C0")]
		private void PIEKJCCKMKN(PageWrapper AGDCNDNIGKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6E31D80", Offset = "0x6E31180", VA = "0x186E31D80")]
		private void BMHPBEGHDLO(bool CNLBKNLGCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6E326A0", Offset = "0x6E31AA0", VA = "0x186E326A0")]
		private void KCLHIPNNCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6E317E0", Offset = "0x6E30BE0", VA = "0x186E317E0")]
		private void AMPAODHPDJA(string LDCKBFKFIKC, ImpressionTracker FKLPGABAEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6E322E0", Offset = "0x6E316E0", VA = "0x186E322E0")]
		private string JFJPIFGDDNI(int IOPFDLJFIKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6E32130", Offset = "0x6E31530", VA = "0x186E32130")]
		private int EEJDDKOELII(NJJLDJDLMLC FGFJFGGJOII, NJJLDJDLMLC CABLGFIBABJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6E33340", Offset = "0x6E32740", VA = "0x186E33340")]
		private bool NACDNHMBKNL(MBFMPEIBEPI HLGIEEHODPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6E35360", Offset = "0x6E34760", VA = "0x186E35360")]
		public ImpressionTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class HJLAABANLKG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
	public HJLAABANLKG()
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
