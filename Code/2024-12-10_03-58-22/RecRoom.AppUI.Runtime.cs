using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using JetBrains.Annotations;
using MVVMDatabinding;
using RRUI;
using RRUI.Data;
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
		[Cpp2IlInjected.Address(RVA = "0x6A921E0", Offset = "0x6A90DE0", VA = "0x186A921E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[JGCKPKGNBPI]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<GOAKHIIGGJN>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GOAKHIIGGJN Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2091AD0", Offset = "0x20906D0", VA = "0x182091AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A88EF0", Offset = "0x6A87AF0", VA = "0x186A88EF0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A89290", Offset = "0x6A87E90", VA = "0x186A89290", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A88FF0", Offset = "0x6A87BF0", VA = "0x186A88FF0")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "20")]
		protected override void OnDataUpdated(GOAKHIIGGJN dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A89390", Offset = "0x6A87F90", VA = "0x186A89390")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[JGCKPKGNBPI]
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
		[Cpp2IlInjected.Address(RVA = "0x6A89FA0", Offset = "0x6A88BA0", VA = "0x186A89FA0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A2B0", Offset = "0x6A88EB0", VA = "0x186A8A2B0")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[JGCKPKGNBPI]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A2F0", Offset = "0x6A88EF0", VA = "0x186A8A2F0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A3A0", Offset = "0x6A88FA0", VA = "0x186A8A3A0")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[JGCKPKGNBPI]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A3E0", Offset = "0x6A88FE0", VA = "0x186A8A3E0", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A480", Offset = "0x6A89080", VA = "0x186A8A480")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[JGCKPKGNBPI]
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

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A91690", Offset = "0x6A90290", VA = "0x186A91690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private PrefabSpawner prefabSpawner;

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
		private MGEGMLPKNPK<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BFB0", Offset = "0x6A8ABB0", VA = "0x186A8BFB0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C1E0", Offset = "0x6A8ADE0", VA = "0x186A8C1E0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C310", Offset = "0x6A8AF10", VA = "0x186A8C310", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C130", Offset = "0x6A8AD30", VA = "0x186A8C130")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__7))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C4D0", Offset = "0x6A8B0D0", VA = "0x186A8C4D0")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[JGCKPKGNBPI]
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

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D2D0", Offset = "0x6A8BED0", VA = "0x186A8D2D0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D370", Offset = "0x6A8BF70", VA = "0x186A8D370")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[JGCKPKGNBPI]
	public class HtmlColorStringToColorBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private List<Image> targetList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Color htmlColor;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D3B0", Offset = "0x6A8BFB0", VA = "0x186A8D3B0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D570", Offset = "0x6A8C170", VA = "0x186A8D570")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[JGCKPKGNBPI]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E290", Offset = "0x6A8CE90", VA = "0x186A8E290", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E320", Offset = "0x6A8CF20", VA = "0x186A8E320")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[JGCKPKGNBPI]
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
		[ELBALDKMPMI("useQueryDataInUri")]
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
		[ELBALDKMPMI("overrideLoadSceneSource")]
		[SerializeField]
		private HLALLIHPPCG loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private BAECBDCPPBO vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F240", Offset = "0x6A8DE40", VA = "0x186A8F240", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F5E0", Offset = "0x6A8E1E0", VA = "0x186A8F5E0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F3D0", Offset = "0x6A8DFD0", VA = "0x186A8F3D0")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F6C0", Offset = "0x6A8E2C0", VA = "0x186A8F6C0")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[JGCKPKGNBPI]
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

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A91950", Offset = "0x6A90550", VA = "0x186A91950", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A91BC0", Offset = "0x6A907C0", VA = "0x186A91BC0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6A91C50", Offset = "0x6A90850", VA = "0x186A91C50", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A91F20", Offset = "0x6A90B20", VA = "0x186A91F20", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A91E20", Offset = "0x6A90A20", VA = "0x186A91E20", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A91D00", Offset = "0x6A90900", VA = "0x186A91D00", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A91D70", Offset = "0x6A90970", VA = "0x186A91D70")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A92190", Offset = "0x6A90D90", VA = "0x186A92190")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KIFIKAOCPDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AFDKIHHOMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	double IABFLCKADDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IIOCGOOOEJI : KIFIKAOCPDD
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static string BCMEIBHBAMJ;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static string MADEOMOCEIN;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static string PCAHHPDAAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OAJBCHCNOFD KOHAHHMJMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool? FEMALLFPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private double? ENGLJHLLHAM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AFDKIHHOMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D5B0", Offset = "0x6A8C1B0", VA = "0x186A8D5B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double IABFLCKADDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D740", Offset = "0x6A8C340", VA = "0x186A8D740", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D8D0", Offset = "0x6A8C4D0", VA = "0x186A8D8D0")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void PKCPHNKIBBJ(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	[UnityEngine.Scripting.Preserve]
	internal IIOCGOOOEJI([JGAMIMHCGFI(null)][NotNull] OAJBCHCNOFD KOHAHHMJMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BAECBDCPPBO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JFGFJBAFOGP EDPBHKNEOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HKKDNHCOMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FADLJAIGOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFAANBOEPMK(BrowserModel JJIFJGLCMKN, Uri GIPAACKAAKI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBJLNALOAIA(BrowserModel JJIFJGLCMKN, Uri KAPCGFEMMED, RoomListQueryData JONFNMFHMHH, bool OLHMGKAMDJB = false, HLALLIHPPCG PKDODAIEKPH = HLALLIHPPCG.NOT_SET);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	string LAOMAJIDFBB(RoomListQueryData JONFNMFHMHH);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOAKHIIGGJN NENNLCHEPEE(string BFGAPILENFH, [Optional] string GMEDHLPDBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum HLABKDGGEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Club,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	StoreItem,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Account
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum GOAKHIIGGJN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Scale150,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Portrait,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Scale75,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Scale100
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public GEOPBELCJPG platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public GOAKHIIGGJN HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			[ReadOnlyField]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public HLABKDGGEGJ CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			[ReadOnlyField]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[FormerlySerializedAs("rowBottomPadding")]
			[Tooltip("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			public int rowPaddingBottom;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class OMANOLPHFFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public BrowserModel browserModel;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public OMANOLPHFFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6A8E1E0", Offset = "0x6A8CDE0", VA = "0x186A8E1E0")]
			internal bool KEPHIALEEEF(Uri uri)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class JPNFFLNHHHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public HLABKDGGEGJ carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public JPNFFLNHHHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CB80", Offset = "0x6A8B780", VA = "0x186A8CB80")]
			internal bool GEAKOCLKMMO(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PMECJAIENOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public HLABKDGGEGJ carouselType;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PMECJAIENOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CB80", Offset = "0x6A8B780", VA = "0x186A8CB80")]
			internal bool HDIFMEEINHM(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HAJOGKFONHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HLABKDGGEGJ carouselType;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public HAJOGKFONHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CB80", Offset = "0x6A8B780", VA = "0x186A8CB80")]
			internal bool CLPNIECCFHB(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HKMABGIDNBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public HLABKDGGEGJ carouselType;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public HKMABGIDNBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CB80", Offset = "0x6A8B780", VA = "0x186A8CB80")]
			internal bool AAJEDKDCFAL(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class FOJFOMEAPCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HLABKDGGEGJ carouselType;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public FOJFOMEAPCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CB80", Offset = "0x6A8B780", VA = "0x186A8CB80")]
			internal bool PJDPNGFPKBJ(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DBNIMLOMBDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public GOAKHIIGGJN highlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CarouselDisplayConfig <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public DBNIMLOMBDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C510", Offset = "0x6A8B110", VA = "0x186A8C510")]
			internal bool FDEBAIGMBLN(HighlightCardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[Tooltip("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		[SerializeField]
		[Tooltip("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private BAECBDCPPBO vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A89E70", Offset = "0x6A88A70", VA = "0x186A89E70")]
		public bool NOHOLEGFPEF(BrowserModel JJIFJGLCMKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A893D0", Offset = "0x6A87FD0", VA = "0x186A893D0")]
		public float EHEKHOPHBGN(GOAKHIIGGJN PLDCKMNEHFP, HLABKDGGEGJ BMIBNHNODLN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6A89510", Offset = "0x6A88110", VA = "0x186A89510")]
		public float FMMNCBBPAFB(GOAKHIIGGJN PLDCKMNEHFP, HLABKDGGEGJ BMIBNHNODLN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A899F0", Offset = "0x6A885F0", VA = "0x186A899F0")]
		public float LJLJFHGBDCG(GOAKHIIGGJN PLDCKMNEHFP, HLABKDGGEGJ BMIBNHNODLN, int NCHMLLIJANL = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A89D80", Offset = "0x6A88980", VA = "0x186A89D80")]
		public RectOffset MBCKLEEGHFB(HLABKDGGEGJ BMIBNHNODLN, int NCHMLLIJANL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A89800", Offset = "0x6A88400", VA = "0x186A89800")]
		public int HDIOPOHGLIP(bool GBKPDNALAOB, GOAKHIIGGJN PLDCKMNEHFP, HLABKDGGEGJ BMIBNHNODLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A89F50", Offset = "0x6A88B50", VA = "0x186A89F50")]
		public int OHDPAFMINFJ(bool GBKPDNALAOB, GOAKHIIGGJN PLDCKMNEHFP, HLABKDGGEGJ BMIBNHNODLN, int INALFHCKHGD = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A89940", Offset = "0x6A88540", VA = "0x186A89940")]
		public int IGMFFIBLAIM(bool GBKPDNALAOB, GOAKHIIGGJN PLDCKMNEHFP, HLABKDGGEGJ BMIBNHNODLN, int INALFHCKHGD = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A89680", Offset = "0x6A88280", VA = "0x186A89680")]
		private HighlightCardDataObject GPOAANPGJGO(GOAKHIIGGJN PLDCKMNEHFP)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A89F80", Offset = "0x6A88B80", VA = "0x186A89F80")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private const int CNALACCHCIO = 20;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private const int EBPAKJEJLEE = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private HLABKDGGEGJ carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private GEOPBELCJPG hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool LHMECNJJENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int OEENHJFMIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private float? DIGFGEOEEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private float? PGBJOENDMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private string ENILEKAMLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GOAKHIIGGJN PLDCKMNEHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private BAECBDCPPBO HIFLFHCBCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private BrowserModel JJIFJGLCMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private DiscoveryDisplayMetadata FNMKELFFBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private string BFGAPILENFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int OIMDFNMICAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int MALCOMOEAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<IDataItem> BDPOFPDKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private DataItem<bool> PMNIHICNILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private DataItem<int> LIFAHDHGHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private DataItem<float?> CDGNPCIPHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DataItem<float?> PBPDACCOFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DataItem<string> GDOFDKHGKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private DataItem<GOAKHIIGGJN> LJIMKIOLFFO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool CIJCJDCGADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x10605F0", Offset = "0x105F1F0", VA = "0x1810605F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6A8B0D0", Offset = "0x6A89CD0", VA = "0x186A8B0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int ENCPBNEAEGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB6DC10", Offset = "0xB6C810", VA = "0x180B6DC10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A4C0", Offset = "0x6A890C0", VA = "0x186A8A4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? FFABMPODGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5CF2280", Offset = "0x5CF0E80", VA = "0x185CF2280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BE90", Offset = "0x6A8AA90", VA = "0x186A8BE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[BindableData(3, "The width override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? BFABMEGACMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x62C5E30", Offset = "0x62C4A30", VA = "0x1862C5E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BF20", Offset = "0x6A8AB20", VA = "0x186A8BF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string LIMAAAEHLHI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x88C490", Offset = "0x88B090", VA = "0x18088C490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A8F0", Offset = "0x6A894F0", VA = "0x186A8A8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public GOAKHIIGGJN CHNINEIDGPE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA3D5E0", Offset = "0xA3C1E0", VA = "0x180A3D5E0")]
			get
			{
				return default(GOAKHIIGGJN);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A510", Offset = "0x6A89110", VA = "0x186A8A510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int HANDGDMJOLG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x892200", Offset = "0x890E00", VA = "0x180892200")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x892220", Offset = "0x890E20", VA = "0x180892220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int GBDPPKKNEAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCE97D0", Offset = "0xCE83D0", VA = "0x180CE97D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override List<IDataItem> MAOGLDMKLNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BE50", Offset = "0x6A8AA50", VA = "0x186A8BE50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override bool FKMBLKBCNAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A560", Offset = "0x6A89160", VA = "0x186A8A560", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B9B0", Offset = "0x6A8A5B0", VA = "0x186A8B9B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A6B0", Offset = "0x6A892B0", VA = "0x186A8A6B0")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata FNMKELFFBNB, string BFGAPILENFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B130", Offset = "0x6A89D30", VA = "0x186A8B130")]
		private int JKNJNOPIEED()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A970", Offset = "0x6A89570", VA = "0x186A8A970")]
		private GOAKHIIGGJN GBNCPGJBFBG()
		{
			return default(GOAKHIIGGJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A620", Offset = "0x6A89220", VA = "0x186A8A620")]
		private void BNJBHPOOCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B2E0", Offset = "0x6A89EE0", VA = "0x186A8B2E0")]
		private void LECJKGECIEB(int JBMILNKAHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8AA60", Offset = "0x6A89660", VA = "0x186A8AA60", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BA70", Offset = "0x6A8A670", VA = "0x186A8BA70")]
		private void PHENNFOBPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BBD0", Offset = "0x6A8A7D0", VA = "0x186A8BBD0")]
		public CarouselViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10605F0", Offset = "0x105F1F0", VA = "0x1810605F0")]
		[CompilerGenerated]
		private bool PCODKCIDNCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B0D0", Offset = "0x6A89CD0", VA = "0x186A8B0D0")]
		[CompilerGenerated]
		private void JJEPNBCKCHP(bool PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB6DC10", Offset = "0xB6C810", VA = "0x180B6DC10")]
		[CompilerGenerated]
		private int GJEAHMIKGID()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A4C0", Offset = "0x6A890C0", VA = "0x186A8A4C0")]
		[CompilerGenerated]
		private void AJNPKIOHEBB(int PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2280", Offset = "0x5CF0E80", VA = "0x185CF2280")]
		[CompilerGenerated]
		private float? PHMBAHIIHLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A960", Offset = "0x6A89560", VA = "0x186A8A960")]
		[CompilerGenerated]
		private void FKGDABBMPEB(float? PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62C5E30", Offset = "0x62C4A30", VA = "0x1862C5E30")]
		[CompilerGenerated]
		private float? NIOHGDBKCNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BA60", Offset = "0x6A8A660", VA = "0x186A8BA60")]
		[CompilerGenerated]
		private void PCFAEEAJPNA(float? PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88C490", Offset = "0x88B090", VA = "0x18088C490")]
		[CompilerGenerated]
		private string LJOHOEPFMPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A8F0", Offset = "0x6A894F0", VA = "0x186A8A8F0")]
		[CompilerGenerated]
		private void EJFOFKHFGEE(string PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5E0", Offset = "0xA3C1E0", VA = "0x180A3D5E0")]
		[CompilerGenerated]
		private GOAKHIIGGJN CDBDHONABPE()
		{
			return default(GOAKHIIGGJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A510", Offset = "0x6A89110", VA = "0x186A8A510")]
		[CompilerGenerated]
		private void AOPMMMKCGMF(GOAKHIIGGJN PPIEANOJMKF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class DiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private BAECBDCPPBO vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public string[] unsupportedPlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public string[] unsupportedInteractionCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool excludeJuniors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JFGFJBAFOGP[] unsupportedPlatformTypes;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JFGFJBAFOGP[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CA50", Offset = "0x6A8B650", VA = "0x186A8CA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C9F0", Offset = "0x6A8B5F0", VA = "0x186A8C9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C5A0", Offset = "0x6A8B1A0", VA = "0x186A8C5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C600", Offset = "0x6A8B200", VA = "0x186A8C600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2049F40", Offset = "0x2048B40", VA = "0x182049F40")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int DFLMBJJIGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private long LCHHEANIAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private long MHCIBOENJFA;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int LBKAPONNNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8A6460", Offset = "0x8A5060", VA = "0x1808A6460")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6A8D1C0", Offset = "0x6A8BDC0", VA = "0x186A8D1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long IDDALPFFPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6A8D270", Offset = "0x6A8BE70", VA = "0x186A8D270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long ONMDJIACKAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A8D210", Offset = "0x6A8BE10", VA = "0x186A8D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D040", Offset = "0x6A8BC40", VA = "0x186A8D040")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CEE0", Offset = "0x6A8BAE0", VA = "0x186A8CEE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CB90", Offset = "0x6A8B790", VA = "0x186A8CB90")]
		private void BLLDDBJGAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CCE0", Offset = "0x6A8B8E0", VA = "0x186A8CCE0")]
		private void JCNPHGDMBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D1A0", Offset = "0x6A8BDA0", VA = "0x186A8D1A0")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct KAICEABNAAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private CancellationTokenSource <tokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter<List<EKHCBLLPBBB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6A8DAB0", Offset = "0x6A8C6B0", VA = "0x186A8DAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private BAECBDCPPBO HIFLFHCBCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IPLIGOLFCIB LHJNIOHMIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CancellationTokenSource IMJPMIKGHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private BrowserModel JJIFJGLCMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool CECOGJADJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<long> JKMHPMFGDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int NKMBCGOKAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private DataList<long> ECEPPAFCLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private string BBPPPAJJMMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool GAPDFHGBEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private List<IDataItem> BDPOFPDKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private DataItem<string> EAEJPMFJNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private DataItem<bool> HHBFAMDGIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private DataItem<RoomListQueryData> DBEIIJNEJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private DataItemList HCPCKOPICOM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> HADJACAJLIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x88EA10", Offset = "0x88D610", VA = "0x18088EA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6A8F1E0", Offset = "0x6A8DDE0", VA = "0x186A8F1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string ANNKLIJEHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x88E9F0", Offset = "0x88D5F0", VA = "0x18088E9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8F160", Offset = "0x6A8DD60", VA = "0x186A8F160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool PEBIHPCGOKK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xDDD6C0", Offset = "0xDDC2C0", VA = "0x180DDD6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6A8E360", Offset = "0x6A8CF60", VA = "0x186A8E360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData EGKGIKBNIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected override List<IDataItem> MAOGLDMKLNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6A8F120", Offset = "0x6A8DD20", VA = "0x186A8F120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected override bool FKMBLKBCNAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A8EE40", Offset = "0x6A8DA40", VA = "0x186A8EE40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A8EC50", Offset = "0x6A8D850", VA = "0x186A8EC50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A8EDD0", Offset = "0x6A8D9D0", VA = "0x186A8EDD0")]
		public void SetQueryData(RoomListQueryData MHPLDPLACLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E490", Offset = "0x6A8D090", VA = "0x186A8E490")]
		[AsyncStateMachine(typeof(KAICEABNAAE))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A8ED80", Offset = "0x6A8D980", VA = "0x186A8ED80")]
		public void SetMaxItems(int NOKBFMJECOJ, int NKMBCGOKAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E980", Offset = "0x6A8D580", VA = "0x186A8E980")]
		private string KPBFFGGPLPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E540", Offset = "0x6A8D140", VA = "0x186A8E540", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A8EC70", Offset = "0x6A8D870", VA = "0x186A8EC70")]
		private void PHENNFOBPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8EEB0", Offset = "0x6A8DAB0", VA = "0x186A8EEB0")]
		public RoomListViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88E9F0", Offset = "0x88D5F0", VA = "0x18088E9F0")]
		[CompilerGenerated]
		private string FEJENCGDONH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E970", Offset = "0x6A8D570", VA = "0x186A8E970")]
		[CompilerGenerated]
		private void KJLJHFJKBID(string PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xDDD6C0", Offset = "0xDDC2C0", VA = "0x180DDD6C0")]
		[CompilerGenerated]
		private bool MGLLJPOPLNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E360", Offset = "0x6A8CF60", VA = "0x186A8E360")]
		[CompilerGenerated]
		private void CACJJGOJHIO(bool PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520")]
		[CompilerGenerated]
		private RoomListQueryData PGNNGAHICCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x88EA10", Offset = "0x88D610", VA = "0x18088EA10")]
		[CompilerGenerated]
		private DataList OHGIPBFLIAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E3C0", Offset = "0x6A8CFC0", VA = "0x186A8E3C0")]
		[CompilerGenerated]
		private void EFNFGCOLOEK(DataList PPIEANOJMKF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct BABGBOKNKCA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<EKHCBLLPBBB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6A88A70", Offset = "0x6A87670", VA = "0x186A88A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IPLIGOLFCIB OAGDDEADDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private BAECBDCPPBO HIFLFHCBCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private CancellationTokenSource IMJPMIKGHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private FJKPHHCBEPP FMKALFLOKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private BrowserModel JJIFJGLCMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private long GLOFJPFEAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private string BGDNHPBDDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private string FAAMMCFGOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private string NMALPFABKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool IKGFHCDOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private string GBAEPGBDPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private bool ALILCEEBHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool GEEAOKKMOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int DMICBOPBEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private List<IDataItem> BDPOFPDKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private DataItem<long> BNMMEJAPKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private DataItem<string> LFEAILAKLNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DataItem<string> BIHPJCDEOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DataItem<string> AFPLAOGPIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private DataItem<bool> FJIEENPHDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DataItem<string> PFMEHDKOPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DataItem<bool> CECFOONBJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private DataItem<bool> MGMAHOFNOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private DataItemAction ODNCJIOLIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private DataItemAction IOANLNCFMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private DataItemAction DLOIHCFCLLM;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long IGGPMOFIGBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C8E0", VA = "0x18094DCE0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6A91590", Offset = "0x6A90190", VA = "0x186A91590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string HMHDAJIDPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7D0", Offset = "0xA5A3D0", VA = "0x180A5B7D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6A91490", Offset = "0x6A90090", VA = "0x186A91490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string KBIMOODPBAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8963C0", Offset = "0x894FC0", VA = "0x1808963C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6A91410", Offset = "0x6A90010", VA = "0x186A91410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string MOAEFANAIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA62860", Offset = "0xA61460", VA = "0x180A62860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6A91510", Offset = "0x6A90110", VA = "0x186A91510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool LKHCOJIOOKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x920FC0", Offset = "0x91FBC0", VA = "0x180920FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6A8F870", Offset = "0x6A8E470", VA = "0x186A8F870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string DEOBHPNEKNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA62A80", Offset = "0xA61680", VA = "0x180A62A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6A91390", Offset = "0x6A8FF90", VA = "0x186A91390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool PFIOFOFMEEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8F6CD0", Offset = "0x8F58D0", VA = "0x1808F6CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6A8FBD0", Offset = "0x6A8E7D0", VA = "0x186A8FBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool LJOGLPLGNNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8F6CB0", Offset = "0x8F58B0", VA = "0x1808F6CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6A8F8D0", Offset = "0x6A8E4D0", VA = "0x186A8F8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool GJBPLEMJIKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x132A0E0", Offset = "0x1328CE0", VA = "0x18132A0E0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1353830", Offset = "0x1352430", VA = "0x181353830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected override List<IDataItem> MAOGLDMKLNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6A91290", Offset = "0x6A8FE90", VA = "0x186A91290", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool FKMBLKBCNAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<ILoadable> FDPOMPELPOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6A911D0", Offset = "0x6A8FDD0", VA = "0x186A911D0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6A912D0", Offset = "0x6A8FED0", VA = "0x186A912D0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A90D30", Offset = "0x6A8F930", VA = "0x186A90D30", Slot = "12")]
		public override void SetBindingData(int MDNMDBDHDKP, int HKNGKNOKFAF, int MFJLAMOCOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F930", Offset = "0x6A8E530", VA = "0x186A8F930")]
		private void EMDLHAPGOCC(IDataSource HNPJMNFJLHK, int HKNGKNOKFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A90A50", Offset = "0x6A8F650", VA = "0x186A90A50")]
		[AsyncStateMachine(typeof(BABGBOKNKCA))]
		private void KHGDHBBCBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F700", Offset = "0x6A8E300", VA = "0x186A8F700")]
		private void AKICAFBNCCK(EKHCBLLPBBB IOPJOIBLNPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A90550", Offset = "0x6A8F150", VA = "0x186A90550")]
		private void JBIEDHKKJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A906C0", Offset = "0x6A8F2C0", VA = "0x186A906C0")]
		[BindableAction(100, null)]
		private void KAAJIFPGIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		[BindableAction(101, null)]
		private void ICBMBDOJJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		[BindableAction(102, null)]
		private void OMCGKFKLALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FC30", Offset = "0x6A8E830", VA = "0x186A8FC30", Slot = "10")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A90B20", Offset = "0x6A8F720", VA = "0x186A90B20")]
		private void PHENNFOBPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A90E10", Offset = "0x6A8FA10", VA = "0x186A90E10")]
		public RoomViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C8E0", VA = "0x18094DCE0")]
		[CompilerGenerated]
		private long KDJHGBHHPGN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A90B10", Offset = "0x6A8F710", VA = "0x186A90B10")]
		[CompilerGenerated]
		private void MMINIIEEBNH(long PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B7D0", Offset = "0xA5A3D0", VA = "0x180A5B7D0")]
		[CompilerGenerated]
		private string POMIEGIHMJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8963C0", Offset = "0x894FC0", VA = "0x1808963C0")]
		[CompilerGenerated]
		private string LPBJDCKDLFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA62860", Offset = "0xA61460", VA = "0x180A62860")]
		[CompilerGenerated]
		private string MCJPABPKFMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A90B00", Offset = "0x6A8F700", VA = "0x186A90B00")]
		[CompilerGenerated]
		private void LNCBGPBAFLB(string PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x920FC0", Offset = "0x91FBC0", VA = "0x180920FC0")]
		[CompilerGenerated]
		private bool HIGLFJGJEGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F870", Offset = "0x6A8E470", VA = "0x186A8F870")]
		[CompilerGenerated]
		private void COOGKFMIKCN(bool PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA62A80", Offset = "0xA61680", VA = "0x180A62A80")]
		[CompilerGenerated]
		private string GLLAGCPFEOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FBC0", Offset = "0x6A8E7C0", VA = "0x186A8FBC0")]
		[CompilerGenerated]
		private void FFENKMAKGEN(string PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8F6CD0", Offset = "0x8F58D0", VA = "0x1808F6CD0")]
		[CompilerGenerated]
		private bool CDDMGDHMNPI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FBD0", Offset = "0x6A8E7D0", VA = "0x186A8FBD0")]
		[CompilerGenerated]
		private void HMOADILJLAF(bool PPIEANOJMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8F6CB0", Offset = "0x8F58B0", VA = "0x1808F6CB0")]
		[CompilerGenerated]
		private bool BGLPLAGDKHN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A8F8D0", Offset = "0x6A8E4D0", VA = "0x186A8F8D0")]
		[CompilerGenerated]
		private void DDODDLFLGDI(bool PPIEANOJMKF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected override string HAFGAIMHAOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6A8E230", Offset = "0x6A8CE30", VA = "0x186A8E230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E220", Offset = "0x6A8CE20", VA = "0x186A8E220")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected override string HAFGAIMHAOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6A8E260", Offset = "0x6A8CE60", VA = "0x186A8E260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E220", Offset = "0x6A8CE20", VA = "0x186A8E220")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class JGCKPKGNBPI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
	public JGCKPKGNBPI()
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
