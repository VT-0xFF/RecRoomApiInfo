using System;
using System.Collections;
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
using RRUI.Framework;
using RRUI.Framework.Views;
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
		[Cpp2IlInjected.Address(RVA = "0x72EC4A0", Offset = "0x72EB0A0", VA = "0x1872EC4A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[NDEPMHMGKLI]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<GKDGGKNHMIE>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GKDGGKNHMIE Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x24665F0", Offset = "0x24651F0", VA = "0x1824665F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D5790", Offset = "0x72D4390", VA = "0x1872D5790", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72D5B30", Offset = "0x72D4730", VA = "0x1872D5B30", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72D5890", Offset = "0x72D4490", VA = "0x1872D5890")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "20")]
		protected override void OnDataUpdated(GKDGGKNHMIE dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72D5C30", Offset = "0x72D4830", VA = "0x1872D5C30")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[NDEPMHMGKLI]
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
		[Cpp2IlInjected.Address(RVA = "0x72D6850", Offset = "0x72D5450", VA = "0x1872D6850", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72D6970", Offset = "0x72D5570", VA = "0x1872D6970", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72D6C60", Offset = "0x72D5860", VA = "0x1872D6C60")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[NDEPMHMGKLI]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72D6CA0", Offset = "0x72D58A0", VA = "0x1872D6CA0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72D6D50", Offset = "0x72D5950", VA = "0x1872D6D50")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[NDEPMHMGKLI]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72D6D90", Offset = "0x72D5990", VA = "0x1872D6D90", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72D6E30", Offset = "0x72D5A30", VA = "0x1872D6E30")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[NDEPMHMGKLI]
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
			[Cpp2IlInjected.Address(RVA = "0x72EB8C0", Offset = "0x72EA4C0", VA = "0x1872EB8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
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
		private OBLFPJIHAJD<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72D8860", Offset = "0x72D7460", VA = "0x1872D8860", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72D8A90", Offset = "0x72D7690", VA = "0x1872D8A90", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72D8BC0", Offset = "0x72D77C0", VA = "0x1872D8BC0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72D89E0", Offset = "0x72D75E0", VA = "0x1872D89E0")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__7))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72D8D80", Offset = "0x72D7980", VA = "0x1872D8D80")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NDEPMHMGKLI]
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
		[Cpp2IlInjected.Address(RVA = "0x72DAFB0", Offset = "0x72D9BB0", VA = "0x1872DAFB0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72DB050", Offset = "0x72D9C50", VA = "0x1872DB050")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[NDEPMHMGKLI]
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
		[Cpp2IlInjected.Address(RVA = "0x72DB090", Offset = "0x72D9C90", VA = "0x1872DB090", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72DB250", Offset = "0x72D9E50", VA = "0x1872DB250")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[NDEPMHMGKLI]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72E4740", Offset = "0x72E3340", VA = "0x1872E4740", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72E47D0", Offset = "0x72E33D0", VA = "0x1872E47D0")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[NDEPMHMGKLI]
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
		[HDIPNKIBINK("useQueryDataInUri")]
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
		[SerializeField]
		[HDIPNKIBINK("overrideLoadSceneSource")]
		private GBICFCGNPDI loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LKJANOHFCKM vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72E6BA0", Offset = "0x72E57A0", VA = "0x1872E6BA0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72E6F30", Offset = "0x72E5B30", VA = "0x1872E6F30", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72E6D30", Offset = "0x72E5930", VA = "0x1872E6D30")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72E7010", Offset = "0x72E5C10", VA = "0x1872E7010")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[NDEPMHMGKLI]
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
		[Cpp2IlInjected.Address(RVA = "0x72EBB70", Offset = "0x72EA770", VA = "0x1872EBB70", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72EBDE0", Offset = "0x72EA9E0", VA = "0x1872EBDE0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72EBE70", Offset = "0x72EAA70", VA = "0x1872EBE70", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72EC1E0", Offset = "0x72EADE0", VA = "0x1872EC1E0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72EC0E0", Offset = "0x72EACE0", VA = "0x1872EC0E0", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72EC040", Offset = "0x72EAC40", VA = "0x1872EC040", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72EBF20", Offset = "0x72EAB20", VA = "0x1872EBF20", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72EBF90", Offset = "0x72EAB90", VA = "0x1872EBF90")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72EC450", Offset = "0x72EB050", VA = "0x1872EC450")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class AIOFNMFIBJI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string HKCNHNAIALA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string> AJBDNMMBNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72D2170", Offset = "0x72D0D70", VA = "0x1872D2170", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x72D20C0", Offset = "0x72D0CC0", VA = "0x1872D20C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72D2220", Offset = "0x72D0E20", VA = "0x1872D2220")]
	protected void HAPHEGKMKPH([CallerMemberName] string MFGAOHOJBEJ = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected AIOFNMFIBJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IHNMJGKPLGN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NIFMPEPDHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	double ECKFHIAIBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PFJNLCEFAPL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHBGLADMOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NKDIKIJDLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NCEKLMPIJLO BOOBDNCHJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AHINNMKELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GHKFIKGFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LGPHDGBOGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BBABMBFDPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KMFBIMOOLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HMHIDHEGPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JGEABMFHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BIOOAMJBOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IDMOOBGINAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HHGLCDHMFFI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ECPPMAMIFAA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action ENPOBNJMCOH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGKFCOHHFBK();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCEEIJBLIMJ();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJOGIHJDKEJ();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJENAIHPMNG();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDINIGEHKMM();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HJKPLJEHBNF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LPJOOEKCHLP();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DEHCKECHOOF();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NHHKIEOKDEN();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LFDCOOKPNED();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CMLKIADNIKP
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<int> KPCAEFHCLEF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJNFJOIJKLH(int BIEEMEKMINN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CBHGOJDMPPK : IHNMJGKPLGN
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static string NIFAKOCKNHE;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static string HPKEBJKGPPM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static string ENPPGLLCHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private CMLMNIGHOGD KFLIBGLPLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool? HMNMDJFIGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private double? OGIICNPGPFA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NIFMPEPDHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72D42D0", Offset = "0x72D2ED0", VA = "0x1872D42D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double ECKFHIAIBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x72D4140", Offset = "0x72D2D40", VA = "0x1872D4140", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72D4460", Offset = "0x72D3060", VA = "0x1872D4460")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void OPGDNJLIDJN(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	[UnityEngine.Scripting.Preserve]
	internal CBHGOJDMPPK([NotNull][GJMNBPKNJPO(null)] CMLMNIGHOGD KFLIBGLPLOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KDJAHCFGGJL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool EOIPOMJELGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool FFGAJJCODKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool IHFDHHFLKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LKFEGLCNKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LKJANOHFCKM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EFDBCIJNJGP BMAGMGJDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CKLIOMDLIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PEIFPAIFKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	long NDFMNBHDFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ALFDNIFFJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CBAGAHHKDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EPCIKDGOMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int LLNKONNMLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool PLFDPIOMEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FKNJPMGEPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool AKMGKODHDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GDBEFONKCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OCACEFFKBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IOGMHPBDMHH();

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KOFLJKPAKLI();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CJOGBDODGJK();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KGGKGIOGEKP(BrowserModel HPCFHMDKJDF, Uri EEBNBIFBONC);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AHNEBFKEKMF(BrowserModel HPCFHMDKJDF, Uri BPJHMDBCFPK, RoomListQueryData BAHFLOKBEBD, bool BCGJKHNGJOA = false, GBICFCGNPDI GMFENNGDFAE = GBICFCGNPDI.NOT_SET);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	string NPBBEOONPEN(RoomListQueryData BAHFLOKBEBD);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "19")]
	string CMNIPEDAFAG(RoomListQueryData BAHFLOKBEBD);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GKDGGKNHMIE BNFBABADLCB(string MKFCBJGLHEP, [Optional] string AMKKKMJOAAB);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task KNAHGKHNLMI(BDKGKPLHPOD.INEHONOFCNC DBNLDMMHLGD);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HLOJNLJFLOJ(BrowserModel HPCFHMDKJDF);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool JEBJKFBKGEM([Out] ONIGKBMFFEH<bool> LGPONHIHGEN);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GNDHFPJJJGC(string KDPLCEGEIGE);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<bool> KNJELDOCBAF(long EPGJLNEAJPA, CancellationToken IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<FFBHBDHOGKB> NKMHEOIPCKI(BCPENJPKFJJ MDPGCFDKEND, CancellationToken IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DCMAGHOLELH(JCOCCFMLIAE JPHOBLFNMNH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task OLIPGCGFKLE(DialogListModel CHNOLLKAAII, OIDEDLHOEML ENMICEGEHKG, CancellationToken IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool FIAHOKJLMIN(bool EABHMMCEMLL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NPPLPCHFICL(BrowserModel HPCFHMDKJDF);
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class AppNavMenu : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class LGAMCOCDHLI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public LGAMCOCDHLI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x72DF770", Offset = "0x72DE370", VA = "0x1872DF770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x72DFAC0", Offset = "0x72DE6C0", VA = "0x1872DFAC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class LBPHJPDGKAF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public LBPHJPDGKAF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x72DF5C0", Offset = "0x72DE1C0", VA = "0x1872DF5C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x72DF720", Offset = "0x72DE320", VA = "0x1872DF720", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class LKFPBEPCEFG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public LKFPBEPCEFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x72DFB10", Offset = "0x72DE710", VA = "0x1872DFB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x72DFBA0", Offset = "0x72DE7A0", VA = "0x1872DFBA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string AppNavLayerName = "interfaces_2025q1_appnav";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string UseAppNavParameterName = "use_app_nav";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private Canvas menuCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private HydrateBase appNavHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private Vector2 touchCanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private Vector2 screensCanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private bool reparentToCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private RRUIButton closeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private RRUIButton openWatchButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private Coroutine DGNNLNIHMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private LKJANOHFCKM HBDBBINAAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private CMLMNIGHOGD JMOHGPBLMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Transform HHCMFCLGFNN;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool AOIDIJKDNLE
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAEB2E0", Offset = "0xAE9EE0", VA = "0x180AEB2E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAEA6A0", Offset = "0xAE92A0", VA = "0x180AEA6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool ICPPCHJLLDM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1371A70", Offset = "0x1370670", VA = "0x181371A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1371C50", Offset = "0x1370850", VA = "0x181371C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool NPHEFPJLBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x28A5230", Offset = "0x28A3E30", VA = "0x1828A5230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28A4A40", Offset = "0x28A3640", VA = "0x1828A4A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Camera NLDOGEKACBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x963180", Offset = "0x961D80", VA = "0x180963180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9631B0", Offset = "0x961DB0", VA = "0x1809631B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ONIDAAIGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB933A0", Offset = "0xB91FA0", VA = "0x180B933A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x12E1AC0", Offset = "0x12E06C0", VA = "0x1812E1AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action LDHCBIIBDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x72D2DA0", Offset = "0x72D19A0", VA = "0x1872D2DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x72D2F00", Offset = "0x72D1B00", VA = "0x1872D2F00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action NAPDFGOCOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x72D2CF0", Offset = "0x72D18F0", VA = "0x1872D2CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x72D2E50", Offset = "0x72D1A50", VA = "0x1872D2E50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x72D2240", Offset = "0x72D0E40", VA = "0x1872D2240")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1B02E90", Offset = "0x1B01A90", VA = "0x181B02E90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x72D2980", Offset = "0x72D1580", VA = "0x1872D2980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x72D2A80", Offset = "0x72D1680", VA = "0x1872D2A80")]
		public void OpenMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x72D2650", Offset = "0x72D1250", VA = "0x1872D2650")]
		public void CloseMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x72D2B30", Offset = "0x72D1730", VA = "0x1872D2B30")]
		public void OpenWatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72D2710", Offset = "0x72D1310", VA = "0x1872D2710")]
		[IteratorStateMachine(typeof(LGAMCOCDHLI))]
		private IEnumerator FKOMDJICHJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x72D2790", Offset = "0x72D1390", VA = "0x1872D2790")]
		[IteratorStateMachine(typeof(LBPHJPDGKAF))]
		private IEnumerator JHDLGBKCJNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72D2810", Offset = "0x72D1410", VA = "0x1872D2810")]
		[IteratorStateMachine(typeof(LKFPBEPCEFG))]
		private IEnumerator KOJHAMABBMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72D2890", Offset = "0x72D1490", VA = "0x1872D2890")]
		private void MDAMEAPCEMP(Vector2 FJJGAGKDECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72D2C60", Offset = "0x72D1860", VA = "0x1872D2C60")]
		public AppNavMenu()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DONAHEKKOOG
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Club,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	StoreItem,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Account
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GKDGGKNHMIE
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Scale150,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Portrait,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Scale75,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Scale100
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public FOPDBIBCPLJ platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public GKDGGKNHMIE HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[ReadOnlyField]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public DONAHEKKOOG CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[ReadOnlyField]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[Tooltip("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			[FormerlySerializedAs("rowBottomPadding")]
			public int rowPaddingBottom;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HFEIELFEKNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public BrowserModel browserModel;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HFEIELFEKNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x72DAE80", Offset = "0x72D9A80", VA = "0x1872DAE80")]
			internal bool BDJIEAOFNMM(Uri uri)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class HOILGHEDJHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public DONAHEKKOOG carouselType;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HOILGHEDJHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x72D20B0", Offset = "0x72D0CB0", VA = "0x1872D20B0")]
			internal bool PPMBNNHJNJC(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class LFMBBAIMAGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public DONAHEKKOOG carouselType;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public LFMBBAIMAGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x72D20B0", Offset = "0x72D0CB0", VA = "0x1872D20B0")]
			internal bool AIGLKEIKEOB(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class POPBHKNGOLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public DONAHEKKOOG carouselType;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public POPBHKNGOLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x72D20B0", Offset = "0x72D0CB0", VA = "0x1872D20B0")]
			internal bool GGBKBNABALI(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class AGGOJKGGIPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public DONAHEKKOOG carouselType;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public AGGOJKGGIPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x72D20B0", Offset = "0x72D0CB0", VA = "0x1872D20B0")]
			internal bool JBNHHPHBDHI(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class NCFALMBPEJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public DONAHEKKOOG carouselType;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public NCFALMBPEJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x72D20B0", Offset = "0x72D0CB0", VA = "0x1872D20B0")]
			internal bool CBPCMFLFOGO(CardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class EFINDPBJIOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public GKDGGKNHMIE highlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool isInVRDisplayMode;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public EFINDPBJIOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x72DA160", Offset = "0x72D8D60", VA = "0x1872DA160")]
			internal bool DIDAAFJAFKJ(HighlightCardDataObject a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[Tooltip("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		[Tooltip("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		[SerializeField]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LKJANOHFCKM vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x72D6750", Offset = "0x72D5350", VA = "0x1872D6750")]
		public bool OLKPPPNEMNJ(BrowserModel HPCFHMDKJDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72D5F20", Offset = "0x72D4B20", VA = "0x1872D5F20")]
		public float IOAMNGNBMFO(GKDGGKNHMIE HOEPIFPOJFI, DONAHEKKOOG EPNLONKOPCL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72D5DB0", Offset = "0x72D49B0", VA = "0x1872D5DB0")]
		public float GDOPLNNFIHP(GKDGGKNHMIE HOEPIFPOJFI, DONAHEKKOOG EPNLONKOPCL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72D6060", Offset = "0x72D4C60", VA = "0x1872D6060")]
		public float JMKDLGDHFOH(GKDGGKNHMIE HOEPIFPOJFI, DONAHEKKOOG EPNLONKOPCL, int KCLFKDBNCPF = 1, bool JBNNEBOEOBA = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72D6660", Offset = "0x72D5260", VA = "0x1872D6660")]
		public RectOffset ODHMPLNBGIG(DONAHEKKOOG EPNLONKOPCL, int KCLFKDBNCPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72D5C70", Offset = "0x72D4870", VA = "0x1872D5C70")]
		public int EJPKFKGGHID(bool PJAPMBBADBN, GKDGGKNHMIE HOEPIFPOJFI, DONAHEKKOOG EPNLONKOPCL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72D64A0", Offset = "0x72D50A0", VA = "0x1872D64A0")]
		public int MIGPKGIABNL(bool PJAPMBBADBN, GKDGGKNHMIE HOEPIFPOJFI, DONAHEKKOOG EPNLONKOPCL, int HFMIDLLPEHH = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72D63F0", Offset = "0x72D4FF0", VA = "0x1872D63F0")]
		public int KALAHHBLHII(bool PJAPMBBADBN, GKDGGKNHMIE HOEPIFPOJFI, DONAHEKKOOG EPNLONKOPCL, int HFMIDLLPEHH = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72D64D0", Offset = "0x72D50D0", VA = "0x1872D64D0")]
		private HighlightCardDataObject NNMEODAHPOK(GKDGGKNHMIE HOEPIFPOJFI)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72D6830", Offset = "0x72D5430", VA = "0x1872D6830")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private const int MDKCKLFFECI = 20;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private const int JANLICHMOMI = 6;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public const string HighlightStyleDefault = "highlight_default";

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public const string HighlightStyleScale150 = "highlight_scale_150";

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public const string HighlightStylePortrait = "highlight_portrait";

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public const string HighlightStyleScale75 = "highlight_scale_75";

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public const string HighlightStyleScale100 = "highlight_scale_100";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private DONAHEKKOOG carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private FOPDBIBCPLJ hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool HIPCGBJOBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int OGCGADGCMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private float? BMLELHOIPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private float? HPGCPHPHJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private string JBEMHIKMBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private GKDGGKNHMIE HOEPIFPOJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private LKJANOHFCKM HBDBBINAAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private BrowserModel HPCFHMDKJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private DiscoveryDisplayMetadata JCBDKHBPNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private string MKFCBJGLHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int NNEIDIGBCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int ODMFGNDFLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private List<IDataItem> DOGAEHACBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private DataItem<bool> NFJHPJOMPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private DataItem<int> PJBFHLJCBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private DataItem<float?> INFLICICGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private DataItem<float?> POGCPIHJHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private DataItem<string> AFJAEHPGEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private DataItem<GKDGGKNHMIE> ELDCHGOMHJE;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool PEJLHOCLIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960270", VA = "0x180961670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x72D7580", Offset = "0x72D6180", VA = "0x1872D7580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int LIGCHFMMCAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCFFAC0", Offset = "0xCFE6C0", VA = "0x180CFFAC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x72D6E70", Offset = "0x72D5A70", VA = "0x1872D6E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? AFOEAIFCNPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x72D8740", Offset = "0x72D7340", VA = "0x1872D8740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		[BindableData(3, "The width override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? HMIOIPFOFHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960220", VA = "0x180961620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x72D87D0", Offset = "0x72D73D0", VA = "0x1872D87D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string FIABGPEFIPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x963230", Offset = "0x961E30", VA = "0x180963230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x72D6F80", Offset = "0x72D5B80", VA = "0x1872D6F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public GKDGGKNHMIE JOBJHJKGBHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAAC910", Offset = "0xAAB510", VA = "0x180AAC910")]
			get
			{
				return default(GKDGGKNHMIE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x72D7C50", Offset = "0x72D6850", VA = "0x1872D7C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int DKCANPFJDEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1032450", Offset = "0x1031050", VA = "0x181032450")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x10324A0", Offset = "0x10310A0", VA = "0x1810324A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int IGGJKDPLDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F00", Offset = "0xAB1B00", VA = "0x180AB2F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override List<IDataItem> JJFBPALMPOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x72D8700", Offset = "0x72D7300", VA = "0x1872D8700", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override bool EIDFACFKIMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72D6EC0", Offset = "0x72D5AC0", VA = "0x1872D6EC0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72D83D0", Offset = "0x72D6FD0", VA = "0x1872D83D0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x72D6FF0", Offset = "0x72D5BF0", VA = "0x1872D6FF0")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata JCBDKHBPNLO, string MKFCBJGLHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72D7330", Offset = "0x72D5F30", VA = "0x1872D7330")]
		private int ELGIIIGPMKF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x72D7240", Offset = "0x72D5E40", VA = "0x1872D7240")]
		private GKDGGKNHMIE EDGNCMLPJLB()
		{
			return default(GKDGGKNHMIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x72D74F0", Offset = "0x72D60F0", VA = "0x1872D74F0")]
		private void HCJCPBAOJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x72D7F00", Offset = "0x72D6B00", VA = "0x1872D7F00")]
		private void MFGJBLPMGHE(int IGNAFOPIKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x72D7E10", Offset = "0x72D6A10", VA = "0x1872D7E10")]
		private string LFDCJCBDHMJ(GKDGGKNHMIE ENINOIDHNPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x72D75E0", Offset = "0x72D61E0", VA = "0x1872D75E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x72D7CB0", Offset = "0x72D68B0", VA = "0x1872D7CB0")]
		private void KMEOEKFEAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x72D8480", Offset = "0x72D7080", VA = "0x1872D8480")]
		public CarouselViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960270", VA = "0x180961670")]
		[CompilerGenerated]
		private bool OHKGKBIJIDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x72D7580", Offset = "0x72D6180", VA = "0x1872D7580")]
		[CompilerGenerated]
		private void IFOHIAIEDMJ(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xCFFAC0", Offset = "0xCFE6C0", VA = "0x180CFFAC0")]
		[CompilerGenerated]
		private int GEPCAKANFKE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x72D6E70", Offset = "0x72D5A70", VA = "0x1872D6E70")]
		[CompilerGenerated]
		private void AAJHMINGCHC(int FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520")]
		[CompilerGenerated]
		private float? HLLCBFHCOIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x72D74E0", Offset = "0x72D60E0", VA = "0x1872D74E0")]
		[CompilerGenerated]
		private void FBPPLDOHCBC(float? FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960220", VA = "0x180961620")]
		[CompilerGenerated]
		private float? ENAMOEBLAKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x72D7230", Offset = "0x72D5E30", VA = "0x1872D7230")]
		[CompilerGenerated]
		private void DFPDBBMGCLA(float? FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x963230", Offset = "0x961E30", VA = "0x180963230")]
		[CompilerGenerated]
		private string GPCEADFFKNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x72D6F80", Offset = "0x72D5B80", VA = "0x1872D6F80")]
		[CompilerGenerated]
		private void CFJDGBBDNIK(string FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC910", Offset = "0xAAB510", VA = "0x180AAC910")]
		[CompilerGenerated]
		private GKDGGKNHMIE HLEIGNIJBEO()
		{
			return default(GKDGGKNHMIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x72D7C50", Offset = "0x72D6850", VA = "0x1872D7C50")]
		[CompilerGenerated]
		private void JEGAJNPGECL(GKDGGKNHMIE FABNDDIHAPL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private LKJANOHFCKM vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IFAADHHANFK recNetAccounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public string[] unsupportedPlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public string[] unsupportedInteractionCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public bool excludeJuniors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int accountAgeMinDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int accountAgeMaxDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private EFDBCIJNJGP[] unsupportedPlatformTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private double? accountAgeInDays;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private EFDBCIJNJGP[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x72DA020", Offset = "0x72D8C20", VA = "0x1872DA020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x72D9FC0", Offset = "0x72D8BC0", VA = "0x1872D9FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x72D9B70", Offset = "0x72D8770", VA = "0x1872D9B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private double AccountAgeInDays
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x72D9980", Offset = "0x72D8580", VA = "0x1872D9980")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x72D9BD0", Offset = "0x72D87D0", VA = "0x1872D9BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x72D9970", Offset = "0x72D8570", VA = "0x1872D9970")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int JFDIIMGDHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private long EKMEHIKOLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long EKEENPIFADN;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int JAAJNMEFHGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9766D0", Offset = "0x9752D0", VA = "0x1809766D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x72DAD70", Offset = "0x72D9970", VA = "0x1872DAD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long NDFMNBHDFFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x72DAE20", Offset = "0x72D9A20", VA = "0x1872DAE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long HMLCLOGJJPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x72DADC0", Offset = "0x72D99C0", VA = "0x1872DADC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72DABF0", Offset = "0x72D97F0", VA = "0x1872DABF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x72DAA90", Offset = "0x72D9690", VA = "0x1872DAA90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x72DA740", Offset = "0x72D9340", VA = "0x1872DA740")]
		private void DKDMAJADGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x72DA890", Offset = "0x72D9490", VA = "0x1872DA890")]
		private void FLBKKPIGKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72DAD50", Offset = "0x72D9950", VA = "0x1872DAD50")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[ViewModel]
	public class CreateModeHotbarSlotViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private CMLKIADNIKP LJFMMDGLNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private Texture KALPLJJMOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool HKPBMOFEHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int BIEEMEKMINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private Texture KFPFMIJCPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private bool OMMHNJIICCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private bool KJHCEDCPNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<IDataItem> DOGAEHACBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private DataItem<int> FPKHECKDIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private DataItem<Texture> FFKNLCIHKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private DataItem<bool> ALOMCJLIHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private DataItem<bool> IPHMLOBEOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private DataItemAction DNJGMMPAIHK;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int AHDPANGFLKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x117DDC0", Offset = "0x117C9C0", VA = "0x18117DDC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x72D9860", Offset = "0x72D8460", VA = "0x1872D9860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		[BindableData(2, "The image that should be displayed for this hotbar item", DataPermissions.ReadOnly)]
		public Texture BKBJGMKONNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x72D9760", Offset = "0x72D8360", VA = "0x1872D9760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[BindableData(3, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool JAKEEAFJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA9BC40", Offset = "0xA9A840", VA = "0x180A9BC40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x72D9910", Offset = "0x72D8510", VA = "0x1872D9910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[BindableData(5, "Whether or not the Image property is set", DataPermissions.ReadOnly)]
		public bool MOABJCNLNBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xF56AF0", Offset = "0xF556F0", VA = "0x180F56AF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x72D98B0", Offset = "0x72D84B0", VA = "0x1872D98B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override List<IDataItem> JJFBPALMPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x72D9730", Offset = "0x72D8330", VA = "0x1872D9730", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override bool EIDFACFKIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x72D92C0", Offset = "0x72D7EC0", VA = "0x1872D92C0")]
		[BindableAction(4, "Selects this hotbar item")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x72D9380", Offset = "0x72D7F80", VA = "0x1872D9380")]
		public void SetImageInNextUpdate(Texture LDIBCOFKEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x72D93A0", Offset = "0x72D7FA0", VA = "0x1872D93A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x72D9460", Offset = "0x72D8060", VA = "0x1872D9460")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x72D8DC0", Offset = "0x72D79C0", VA = "0x1872D8DC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x72D91A0", Offset = "0x72D7DA0", VA = "0x1872D91A0")]
		private void KMEOEKFEAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72D9590", Offset = "0x72D8190", VA = "0x1872D9590")]
		public CreateModeHotbarSlotViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x117DDC0", Offset = "0x117C9C0", VA = "0x18117DDC0")]
		[CompilerGenerated]
		private int LLJKLEBLIBE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000")]
		[CompilerGenerated]
		private Texture NPIBGBEMHCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA9BC40", Offset = "0xA9A840", VA = "0x180A9BC40")]
		[CompilerGenerated]
		private bool CPGNGOABLJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xF56AF0", Offset = "0xF556F0", VA = "0x180F56AF0")]
		[CompilerGenerated]
		private bool LGKOJNNOMKH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[ViewModel]
	public class MakerPenHUDSelectToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private PFJNLCEFAPL LJFMMDGLNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private bool KFLJEKPIFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private bool CHLFNMFPBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private bool NGAINLNGOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private bool LHOAKCFPOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private bool LGNEBLOHFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private bool JADFBOIEIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private bool HKMKAJMCPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private List<IDataItem> DOGAEHACBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DataItem<bool> OJICINPKFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private DataItem<bool> LADHOAAIONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private DataItem<bool> BGJOOAFDIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private DataItem<bool> JCCFLMJJKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private DataItem<bool> LANPDBPEKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private DataItem<bool> IEKLJNBAIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private DataItem<bool> DKCHIIAPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private DataItemAction BEOFDKANAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private DataItemAction NJODJONHGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private DataItemAction ABGJNOIJDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DataItemAction IMAFLOLDOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private DataItemAction FJMDAMHDGCF;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[BindableData(6, "Is Delete Allowed", DataPermissions.ReadWrite)]
		public bool JGEABMFHNCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAB3FC0", Offset = "0xAB2BC0", VA = "0x180AB3FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x72E2BA0", Offset = "0x72E17A0", VA = "0x1872E2BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[BindableData(7, "OnCloneMode", DataPermissions.ReadWrite)]
		public bool LGPHDGBOGNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xBFF790", Offset = "0xBFE390", VA = "0x180BFF790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x72E2B40", Offset = "0x72E1740", VA = "0x1872E2B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		[BindableData(8, "In Transfrom Mode And Move On", DataPermissions.ReadWrite)]
		public bool DKHHCNBDIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1BE3480", Offset = "0x1BE2080", VA = "0x181BE3480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x72E2A80", Offset = "0x72E1680", VA = "0x1872E2A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[BindableData(9, "In Transform Mode And Rotate On", DataPermissions.ReadWrite)]
		public bool KMFBIMOOLNF
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1200", Offset = "0x1CEFE00", VA = "0x181CF1200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x72E2DF0", Offset = "0x72E19F0", VA = "0x1872E2DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[BindableData(10, "In Transform Mode And Scale On", DataPermissions.ReadWrite)]
		public bool HMHIDHEGPAA
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x145BA80", Offset = "0x145A680", VA = "0x18145BA80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x72E2AE0", Offset = "0x72E16E0", VA = "0x1872E2AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[BindableData(11, "Is Recolor Tool Allowed", DataPermissions.ReadWrite)]
		public bool BIOOAMJBOAD
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6991A90", Offset = "0x6990690", VA = "0x186991A90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x72E2040", Offset = "0x72E0C40", VA = "0x1872E2040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[BindableData(12, "Is Transform Tool Active", DataPermissions.ReadWrite)]
		public bool IDMOOBGINAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6991A80", Offset = "0x6990680", VA = "0x186991A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x72E1AE0", Offset = "0x72E06E0", VA = "0x1872E1AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected override List<IDataItem> JJFBPALMPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x72E3650", Offset = "0x72E2250", VA = "0x1872E3650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override bool EIDFACFKIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72E1B40", Offset = "0x72E0740", VA = "0x1872E1B40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x72E2E50", Offset = "0x72E1A50", VA = "0x1872E2E50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72E2FC0", Offset = "0x72E1BC0", VA = "0x1872E2FC0")]
		[BindableAction(1, "Press Clone button")]
		public void ToggleCloneMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72E3020", Offset = "0x72E1C20", VA = "0x1872E3020")]
		[BindableAction(2, "Press Move button")]
		public void ToggleMoveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72E3130", Offset = "0x72E1D30", VA = "0x1872E3130")]
		[BindableAction(3, "Press Rotate button")]
		public void ToggleRotateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x72E3240", Offset = "0x72E1E40", VA = "0x1872E3240")]
		[BindableAction(4, "Press Scale button")]
		public void ToggleScaleMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x72E1D30", Offset = "0x72E0930", VA = "0x1872E1D30")]
		[BindableAction(5, "Press Delete button")]
		public void DeleteSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x72E1D90", Offset = "0x72E0990", VA = "0x1872E1D90")]
		private void GPKDAGEDFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72E20A0", Offset = "0x72E0CA0", VA = "0x1872E20A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x72E2C00", Offset = "0x72E1800", VA = "0x1872E2C00")]
		private void KMEOEKFEAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x72E3350", Offset = "0x72E1F50", VA = "0x1872E3350")]
		public MakerPenHUDSelectToolbarViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FC0", Offset = "0xAB2BC0", VA = "0x180AB3FC0")]
		[CompilerGenerated]
		private bool PLJDCOBJHMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x72E2BA0", Offset = "0x72E17A0", VA = "0x1872E2BA0")]
		[CompilerGenerated]
		private void KJOIJFGCBJK(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xBFF790", Offset = "0xBFE390", VA = "0x180BFF790")]
		[CompilerGenerated]
		private bool AJOBCJLBNKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72E2B40", Offset = "0x72E1740", VA = "0x1872E2B40")]
		[CompilerGenerated]
		private void KDBLDCDGOLB(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1BE3480", Offset = "0x1BE2080", VA = "0x181BE3480")]
		[CompilerGenerated]
		private bool CONLADJDOPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72E2A80", Offset = "0x72E1680", VA = "0x1872E2A80")]
		[CompilerGenerated]
		private void JKMBMGFOGFP(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1CF1200", Offset = "0x1CEFE00", VA = "0x181CF1200")]
		[CompilerGenerated]
		private bool MNOBIMODIMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x72E2DF0", Offset = "0x72E19F0", VA = "0x1872E2DF0")]
		[CompilerGenerated]
		private void LALMLJKGPJJ(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x145BA80", Offset = "0x145A680", VA = "0x18145BA80")]
		[CompilerGenerated]
		private bool NCHCINPHPLI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x72E2AE0", Offset = "0x72E16E0", VA = "0x1872E2AE0")]
		[CompilerGenerated]
		private void KBDENJBPCKF(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6991A90", Offset = "0x6990690", VA = "0x186991A90")]
		[CompilerGenerated]
		private bool MPCMPNFLKOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x72E2040", Offset = "0x72E0C40", VA = "0x1872E2040")]
		[CompilerGenerated]
		private void HNJIFNFNJOJ(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6991A80", Offset = "0x6990680", VA = "0x186991A80")]
		[CompilerGenerated]
		private bool OCPPPICLPFC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x72E1AE0", Offset = "0x72E06E0", VA = "0x1872E1AE0")]
		[CompilerGenerated]
		private void ADNJPEDFINE(bool FABNDDIHAPL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[ViewModel]
	public class MakerPenHUDViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private PFJNLCEFAPL LJFMMDGLNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private List<IDataItem> DOGAEHACBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private DataItem<bool> BIPNKMJKNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private DataItem<bool> PKABLCGAJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private DataItem<bool> GDBCOJECPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private DataItem<bool> JJBHJKFHPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private DataItemAction JBIPKKBBKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private DataItemAction AECEGNAGIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private DataItemAction HFFLFGNBLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private DataItemAction CLKMNLODJLB;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool EHBGLADMOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x72E4170", Offset = "0x72E2D70", VA = "0x1872E4170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool NKDIKIJDLFI
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x72E4120", Offset = "0x72E2D20", VA = "0x1872E4120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool GHKFIKGFFDG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x72E40D0", Offset = "0x72E2CD0", VA = "0x1872E40D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool AHINNMKELBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x72E38B0", Offset = "0x72E24B0", VA = "0x1872E38B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected override List<IDataItem> JJFBPALMPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x72E45A0", Offset = "0x72E31A0", VA = "0x1872E45A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override bool EIDFACFKIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x72E3680", Offset = "0x72E2280", VA = "0x1872E3680", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x72E41C0", Offset = "0x72E2DC0", VA = "0x1872E41C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x72E4350", Offset = "0x72E2F50", VA = "0x1872E4350")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x72E4300", Offset = "0x72E2F00", VA = "0x1872E4300")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x72E3F00", Offset = "0x72E2B00", VA = "0x1872E3F00")]
		private void KFDEEPPNAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x72E3950", Offset = "0x72E2550", VA = "0x1872E3950")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x72E3900", Offset = "0x72E2500", VA = "0x1872E3900")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x72E3850", Offset = "0x72E2450", VA = "0x1872E3850")]
		private void DJCHIJIBKCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x72E39A0", Offset = "0x72E25A0", VA = "0x1872E39A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x72E3F60", Offset = "0x72E2B60", VA = "0x1872E3F60")]
		private void KMEOEKFEAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x72E43A0", Offset = "0x72E2FA0", VA = "0x1872E43A0")]
		public MakerPenHUDViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x72E4170", Offset = "0x72E2D70", VA = "0x1872E4170")]
		[CompilerGenerated]
		private bool NLFLJKPPIFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x72E4120", Offset = "0x72E2D20", VA = "0x1872E4120")]
		[CompilerGenerated]
		private bool MJEAPOGNLFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72E40D0", Offset = "0x72E2CD0", VA = "0x1872E40D0")]
		[CompilerGenerated]
		private bool LCJNMKIFEDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72E38B0", Offset = "0x72E24B0", VA = "0x1872E38B0")]
		[CompilerGenerated]
		private bool GOAOMMFMHAK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MOFEEGPONNI : AIOFNMFIBJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private PINBABNPMHD OELIJILGNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool GEKEIPOEEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int MFOLDMOPIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool OLNIEGEEGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int PIHKEDDJLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool EEABBOIEOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool DELENICJCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool FAEIEOEGOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool KGABEJDFPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool FEGAGPBDBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool CKBIKDMIAMM;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public PINBABNPMHD OBAPDIAOMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x72E1950", Offset = "0x72E0550", VA = "0x1872E1950")]
		get
		{
			return default(PINBABNPMHD);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x72E16D0", Offset = "0x72E02D0", VA = "0x1872E16D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool CCLIBCCFGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9885B0", Offset = "0x9871B0", VA = "0x1809885B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x72E1770", Offset = "0x72E0370", VA = "0x1872E1770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool GMCAMDMMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xCC3830", Offset = "0xCC2430", VA = "0x180CC3830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x72E1A00", Offset = "0x72E0600", VA = "0x1872E1A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int PNGJFKKMAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xC392C0", Offset = "0xC37EC0", VA = "0x180C392C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x72E18F0", Offset = "0x72E04F0", VA = "0x1872E18F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool FFOHDNFDBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xB12C20", Offset = "0xB11820", VA = "0x180B12C20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x72E1A60", Offset = "0x72E0660", VA = "0x1872E1A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool GHOJKMLENKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xBE55D0", Offset = "0xBE41D0", VA = "0x180BE55D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x72E17D0", Offset = "0x72E03D0", VA = "0x1872E17D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool MFEHNKBGGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1B52B20", Offset = "0x1B51720", VA = "0x181B52B20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x72E1890", Offset = "0x72E0490", VA = "0x1872E1890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool OLJIEEMOJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x72E19F0", Offset = "0x72E05F0", VA = "0x1872E19F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool EFEBJENCFND
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x150EE90", Offset = "0x150DA90", VA = "0x18150EE90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x72E1830", Offset = "0x72E0430", VA = "0x1872E1830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool BBIHMKHNAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x15103A0", Offset = "0x150EFA0", VA = "0x1815103A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x72E1990", Offset = "0x72E0590", VA = "0x1872E1990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72E1AC0", Offset = "0x72E06C0", VA = "0x1872E1AC0")]
	public MOFEEGPONNI()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, KDJAHCFGGJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct CCCLIMIMAHD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private TaskAwaiter<List<JCOCCFMLIAE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x72D4640", Offset = "0x72D3240", VA = "0x1872D4640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private LKJANOHFCKM HBDBBINAAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeField]
		private GBICFCGNPDI loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private OJNIPBPGFNF DLLPIFCOMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private CancellationTokenSource HGGNOAGNIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private BrowserModel HPCFHMDKJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool GBIGDDIOEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<long> FPONIKPEGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private int OJEJGCKLMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool GHCJANFKJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DataList<long> PDGELIADKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private string NEDNFKCJIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private bool DLEAOIDPPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MOFEEGPONNI EFLKFIICMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<IDataItem> DOGAEHACBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DataItem<string> BOBBCBLADKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private DataItem<bool> DEPNONBEOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private DataItem<RoomListQueryData> HCGLLMAEPCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private DataItem<MOFEEGPONNI> HDFDGALDEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private DataItemList KMGCPKMMNFG;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> CAANFAOOPHO
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9631F0", Offset = "0x961DF0", VA = "0x1809631F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x72E6B30", Offset = "0x72E5730", VA = "0x1872E6B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string JJHPPAHMLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA79300", Offset = "0xA77F00", VA = "0x180A79300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x72E6AB0", Offset = "0x72E56B0", VA = "0x1872E6AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool NOMCAEMBHIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xCC3830", Offset = "0xCC2430", VA = "0x180CC3830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x72E4810", Offset = "0x72E3410", VA = "0x1872E4810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData LGELNCGEJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public MOFEEGPONNI KIAKHNPILMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xB8FC30", Offset = "0xB8E830", VA = "0x180B8FC30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x72E4870", Offset = "0x72E3470", VA = "0x1872E4870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool EOIPOMJELGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xCF5CF0", Offset = "0xCF48F0", VA = "0x180CF5CF0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xCF5D40", Offset = "0xCF4940", VA = "0x180CF5D40", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool FFGAJJCODKF
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x2305140", Offset = "0x2303D40", VA = "0x182305140", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x2305150", Offset = "0x2303D50", VA = "0x182305150", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool IHFDHHFLKHI
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x28878E0", Offset = "0x28864E0", VA = "0x1828878E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2887870", Offset = "0x2886470", VA = "0x182887870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool LKFEGLCNKBK
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x69703B0", Offset = "0x696EFB0", VA = "0x1869703B0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x6970340", Offset = "0x696EF40", VA = "0x186970340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool EDIAGLFCKKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAFA9E0", Offset = "0xAF95E0", VA = "0x180AFA9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public GBICFCGNPDI IICPPDPJPKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xF56BD0", Offset = "0xF557D0", VA = "0x180F56BD0")]
			get
			{
				return default(GBICFCGNPDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected override List<IDataItem> JJFBPALMPOO
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x72E6A70", Offset = "0x72E5670", VA = "0x1872E6A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected override bool EIDFACFKIMP
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x72E65B0", Offset = "0x72E51B0", VA = "0x1872E65B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x72E6080", Offset = "0x72E4C80", VA = "0x1872E6080", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x72E64F0", Offset = "0x72E50F0", VA = "0x1872E64F0")]
		public void SetQueryData(RoomListQueryData JHNDBDEKNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x72E63B0", Offset = "0x72E4FB0", VA = "0x1872E63B0")]
		public void SetDiscoverySectionId(string BKDDJLELCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x72E48E0", Offset = "0x72E34E0", VA = "0x1872E48E0")]
		[AsyncStateMachine(typeof(CCCLIMIMAHD))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x72E6460", Offset = "0x72E5060", VA = "0x1872E6460")]
		public void SetMaxItems(int FGLDOIHNIEA, int OBIELNDEGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72E64C0", Offset = "0x72E50C0", VA = "0x1872E64C0")]
		public void SetMinItems(int LGFEFOCFBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x72E5460", Offset = "0x72E4060", VA = "0x1872E5460")]
		private void LPAPBMIEABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x72E50B0", Offset = "0x72E3CB0", VA = "0x1872E50B0")]
		private string KCJIPPIBGDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2305140", Offset = "0x2303D40", VA = "0x182305140")]
		private bool NBFEPJOEIFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x72E5980", Offset = "0x72E4580", VA = "0x1872E5980")]
		private void OBDJIGPANBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x72E6230", Offset = "0x72E4E30", VA = "0x1872E6230")]
		private void PPHJFLNADBJ(ImpressionTracker DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72E4A70", Offset = "0x72E3670", VA = "0x1872E4A70", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72E5320", Offset = "0x72E3F20", VA = "0x1872E5320")]
		private void KMEOEKFEAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x72E6750", Offset = "0x72E5350", VA = "0x1872E6750")]
		public RoomListViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA79300", Offset = "0xA77F00", VA = "0x180A79300")]
		[CompilerGenerated]
		private string DMAHNAOAGHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x72E4A60", Offset = "0x72E3660", VA = "0x1872E4A60")]
		[CompilerGenerated]
		private void IMDLKHFDHCI(string FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xCC3830", Offset = "0xCC2430", VA = "0x180CC3830")]
		[CompilerGenerated]
		private bool NODGOAMGPNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72E4810", Offset = "0x72E3410", VA = "0x1872E4810")]
		[CompilerGenerated]
		private void BPNHNEAFBBD(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640")]
		[CompilerGenerated]
		private RoomListQueryData PPPKHMMKBHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xB8FC30", Offset = "0xB8E830", VA = "0x180B8FC30")]
		[CompilerGenerated]
		private MOFEEGPONNI PKOMJHPECFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x72E4870", Offset = "0x72E3470", VA = "0x1872E4870")]
		[CompilerGenerated]
		private void COCBEHOBGKI(MOFEEGPONNI FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9631F0", Offset = "0x961DF0", VA = "0x1809631F0")]
		[CompilerGenerated]
		private DataList BBAJDFJDGLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x72E4990", Offset = "0x72E3590", VA = "0x1872E4990")]
		[CompilerGenerated]
		private void HDPKBNCOEEL(DataList FABNDDIHAPL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private struct IGNOMCADLLJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private TaskAwaiter<JCOCCFMLIAE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x72DB290", Offset = "0x72D9E90", VA = "0x1872DB290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private struct MDGLNPHACFD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private BCPENJPKFJJ <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private TaskAwaiter<BCPENJPKFJJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x72DFBF0", Offset = "0x72DE7F0", VA = "0x1872DFBF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class IPPFGONCAPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public BCPENJPKFJJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public bool randomSubroom;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IPPFGONCAPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x72DB5B0", Offset = "0x72DA1B0", VA = "0x1872DB5B0")]
			internal void OGBOGLFHFOF()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct FGMHPKAFELB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public BCPENJPKFJJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x72DA1B0", Offset = "0x72D8DB0", VA = "0x1872DA1B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class HGAOKEEPFLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public BCPENJPKFJJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public FFBHBDHOGKB subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HGAOKEEPFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x72DAEC0", Offset = "0x72D9AC0", VA = "0x1872DAEC0")]
			internal void OGMJLOLCCCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class NLOJBPBNEEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public IPHHHIANCDI latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public HGAOKEEPFLP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public NLOJBPBNEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x72E45D0", Offset = "0x72E31D0", VA = "0x1872E45D0")]
			internal void HMADHBNLPME()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct MFKMKILFKIM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public BCPENJPKFJJ roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			private HGAOKEEPFLP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			private NLOJBPBNEEF <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private TaskAwaiter<FFBHBDHOGKB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private ALADGKBEPJH <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			private TaskAwaiter<IPHHHIANCDI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x72E0440", Offset = "0x72DF040", VA = "0x1872E0440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private const string OAFBNDKBPNN = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private const char KFMGBJLKCGF = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private OJNIPBPGFNF MEDLPOMKNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private BDANNHMJMLM AJPEFMNKCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private LKJANOHFCKM HBDBBINAAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private CancellationTokenSource HGGNOAGNIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private PINBABNPMHD OELIJILGNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private BrowserModel HPCFHMDKJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private DialogListModel CHNOLLKAAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int PDOJNOEFNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int DPCCEJBDFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int EAGLKPCKNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private bool HGKPHBCMICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private DateTime? MMFLAHAPGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private bool CLCGOGOPBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private long EPGJLNEAJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private string DGJAAFKDAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private string ICDFHDIHFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private string KLODGKCHKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private bool CGMABEPOBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private string CKIKBMJEHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool BJHGBJNJEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private bool ANKHGEHNINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private string LILGEEHMLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private bool CMEBDCGNKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private bool OLPHOHCIPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x152")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private bool ENKGAIPBMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x153")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private bool KOJFLKEDHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private bool KOEDNCDNCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x155")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool FDHNLMBKPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x156")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool DELENICJCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x157")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private bool LPPOHIAIAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool FEGAGPBDBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private bool CKBIKDMIAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private List<IDataItem> DOGAEHACBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private DataItem<long> FAFLCLANCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private DataItem<string> KPBEBLKLMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private DataItem<string> BGCDDCEOHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private DataItem<string> PJFHGFKBMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private DataItem<bool> BJBJKNJJGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private DataItem<string> LHMLMBIINEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private DataItem<bool> OPDDEONJLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private DataItem<bool> DAPMNEFFPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private DataItem<string> MDMOLELKEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private DataItem<bool> MOCAPEPPJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private DataItem<bool> AEKDJGMDLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private DataItem<bool> NDNACMKLBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private DataItem<bool> LBPNDGEEFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private DataItem<bool> OIDEEIHCPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private DataItem<bool> IKFILNIMHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private DataItem<bool> PGEAFAHEEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private DataItem<bool> DFLJMCJEBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private DataItem<bool> COPJEIMIPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private DataItem<bool> FOGFCDMBEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private DataItemAction DAIEAKBOHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private DataItemAction OPCBBADOKMP;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long JMAKOHJDMGC
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA36C20", Offset = "0xA35820", VA = "0x180A36C20")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x72EB7C0", Offset = "0x72EA3C0", VA = "0x1872EB7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string IIKKCFCOACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9C9D70", Offset = "0x9C8970", VA = "0x1809C9D70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x72EB6C0", Offset = "0x72EA2C0", VA = "0x1872EB6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string HFGNBPBKNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9C0D70", Offset = "0x9BF970", VA = "0x1809C0D70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x72EB640", Offset = "0x72EA240", VA = "0x1872EB640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string KGPCGMMMMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9C0930", Offset = "0x9BF530", VA = "0x1809C0930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x72EB740", Offset = "0x72EA340", VA = "0x1872EB740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool HJPOPAEENEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x17E2240", Offset = "0x17E0E40", VA = "0x1817E2240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x72E76B0", Offset = "0x72E62B0", VA = "0x1872E76B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string CKDAIAPKDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9C0B50", Offset = "0x9BF750", VA = "0x1809C0B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x72EB5C0", Offset = "0x72EA1C0", VA = "0x1872EB5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool HHIAHCHAFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x15B6B90", Offset = "0x15B5790", VA = "0x1815B6B90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x72E7650", Offset = "0x72E6250", VA = "0x1872E7650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool BBGLALLFHKG
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xCF9B30", Offset = "0xCF8730", VA = "0x180CF9B30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x72E7BF0", Offset = "0x72E67F0", VA = "0x1872E7BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string EIBIIFGADLE
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x9BA060", Offset = "0x9B8C60", VA = "0x1809BA060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x72EB540", Offset = "0x72EA140", VA = "0x1872EB540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool HNHBOBPNAJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x9C0380", Offset = "0x9BEF80", VA = "0x1809C0380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x72E7160", Offset = "0x72E5D60", VA = "0x1872E7160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool BKPHIBFBCAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF10", Offset = "0x9BAB10", VA = "0x1809BBF10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x72E7590", Offset = "0x72E6190", VA = "0x1872E7590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool DAJDDGMIGGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x17EF580", Offset = "0x17EE180", VA = "0x1817EF580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x72E9680", Offset = "0x72E8280", VA = "0x1872E9680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool FLLFEMADJIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x72EA6D0", Offset = "0x72E92D0", VA = "0x1872EA6D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x72E7C50", Offset = "0x72E6850", VA = "0x1872E7C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool PGBIBGOBCJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1B70C20", Offset = "0x1B6F820", VA = "0x181B70C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x72E79F0", Offset = "0x72E65F0", VA = "0x1872E79F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool GEMAEFEJMNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x72E95C0", Offset = "0x72E81C0", VA = "0x1872E95C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x72E75F0", Offset = "0x72E61F0", VA = "0x1872E75F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool GHOJKMLENKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x72E7CB0", Offset = "0x72E68B0", VA = "0x1872E7CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x72E7930", Offset = "0x72E6530", VA = "0x1872E7930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool BCDKHFLNIJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x72E7050", Offset = "0x72E5C50", VA = "0x1872E7050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x72E7990", Offset = "0x72E6590", VA = "0x1872E7990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool EFEBJENCFND
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1177510", Offset = "0x1176110", VA = "0x181177510")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x72EA390", Offset = "0x72E8F90", VA = "0x1872EA390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool BBIHMKHNAFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1DB89B0", Offset = "0x1DB75B0", VA = "0x181DB89B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x72E7D70", Offset = "0x72E6970", VA = "0x1872E7D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool IICIBGLLINN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1DB9450", Offset = "0x1DB8050", VA = "0x181DB9450", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1DB23E0", Offset = "0x1DB0FE0", VA = "0x181DB23E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected override List<IDataItem> JJFBPALMPOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x72EB440", Offset = "0x72EA040", VA = "0x1872EB440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected override bool EIDFACFKIMP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ILoadable> HCLIFCCKPOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x72EB380", Offset = "0x72E9F80", VA = "0x1872EB380", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x72EB480", Offset = "0x72EA080", VA = "0x1872EB480", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72E7060", Offset = "0x72E5C60", VA = "0x1872E7060", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x72EAC70", Offset = "0x72E9870", VA = "0x1872EAC70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x72EAAE0", Offset = "0x72E96E0", VA = "0x1872EAAE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x72EAB90", Offset = "0x72E9790", VA = "0x1872EAB90", Slot = "13")]
		public override void SetBindingData(int BKIPLAIOAJI, int NDMNLGHHJKE, int BIEEMEKMINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x72E7730", Offset = "0x72E6330", VA = "0x1872E7730")]
		private void FCGDAHGMJPF(IDataSource HFPNJKBAIBI, int NDMNLGHHJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x72E7CC0", Offset = "0x72E68C0", VA = "0x1872E7CC0")]
		[AsyncStateMachine(typeof(IGNOMCADLLJ))]
		private void HNAAOBMABBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x72EA6E0", Offset = "0x72E92E0", VA = "0x1872EA6E0")]
		private void OHFMAEMDLFH(JCOCCFMLIAE MPNJBLCNBBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x72E9A50", Offset = "0x72E8650", VA = "0x1872E9A50")]
		private void KOJNGMJIECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x72E71C0", Offset = "0x72E5DC0", VA = "0x1872E71C0")]
		private void CFGLDGGFJPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72E7710", Offset = "0x72E6310", VA = "0x1872E7710")]
		private void EOCIEMJNNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x72E90F0", Offset = "0x72E7CF0", VA = "0x1872E90F0")]
		[BindableAction(100, null)]
		private void JILFGHJBPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72E95D0", Offset = "0x72E81D0", VA = "0x1872E95D0")]
		[BindableAction(101, null)]
		[AsyncStateMachine(typeof(MDGLNPHACFD))]
		private void KHHBKAMONFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x72EA3F0", Offset = "0x72E8FF0", VA = "0x1872EA3F0")]
		[AsyncStateMachine(typeof(FGMHPKAFELB))]
		private void LNBICJILPGB(bool LBHBNIFOLPE, BCPENJPKFJJ MDPGCFDKEND, bool LCBACHLDPHD = false, bool GFLLGDKEAAJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x72E8FE0", Offset = "0x72E7BE0", VA = "0x1872E8FE0")]
		[AsyncStateMachine(typeof(MFKMKILFKIM))]
		private void JBNLEACDDLP(BCPENJPKFJJ MDPGCFDKEND, bool LBHBNIFOLPE, bool LCBACHLDPHD, bool GFLLGDKEAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x72EA500", Offset = "0x72E9100", VA = "0x1872EA500")]
		private void OBDJIGPANBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72E7A60", Offset = "0x72E6660", VA = "0x1872E7A60")]
		private void HDELBJMLNJG(string KLPIBPGJBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x72E7DF0", Offset = "0x72E69F0", VA = "0x1872E7DF0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x72E96E0", Offset = "0x72E82E0", VA = "0x1872E96E0")]
		private void KMEOEKFEAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x72EAD30", Offset = "0x72E9930", VA = "0x1872EAD30")]
		public RoomViewModel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA36C20", Offset = "0xA35820", VA = "0x180A36C20")]
		[CompilerGenerated]
		private long HDGOMDCIBMF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72E7DD0", Offset = "0x72E69D0", VA = "0x1872E7DD0")]
		[CompilerGenerated]
		private void IGNBNBHEGAN(long FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9C9D70", Offset = "0x9C8970", VA = "0x1809C9D70")]
		[CompilerGenerated]
		private string FFFEGIPDPEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x9C0D70", Offset = "0x9BF970", VA = "0x1809C0D70")]
		[CompilerGenerated]
		private string DGALFOMNGHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9C0930", Offset = "0x9BF530", VA = "0x1809C0930")]
		[CompilerGenerated]
		private string PGJEJDLBMFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x72E7A50", Offset = "0x72E6650", VA = "0x1872E7A50")]
		[CompilerGenerated]
		private void GOMNHBLBMDE(string FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x17E2240", Offset = "0x17E0E40", VA = "0x1817E2240")]
		[CompilerGenerated]
		private bool EGNLELJNFMF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x72E76B0", Offset = "0x72E62B0", VA = "0x1872E76B0")]
		[CompilerGenerated]
		private void DCJAADPELIF(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9C0B50", Offset = "0x9BF750", VA = "0x1809C0B50")]
		[CompilerGenerated]
		private string BFDKDILNKCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x72E7DE0", Offset = "0x72E69E0", VA = "0x1872E7DE0")]
		[CompilerGenerated]
		private void ILFJBBAHLJL(string FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x15B6B90", Offset = "0x15B5790", VA = "0x1815B6B90")]
		[CompilerGenerated]
		private bool LCJOCJDLLEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x72E7650", Offset = "0x72E6250", VA = "0x1872E7650")]
		[CompilerGenerated]
		private void CNAOFIPMPBN(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xCF9B30", Offset = "0xCF8730", VA = "0x180CF9B30")]
		[CompilerGenerated]
		private bool KMBNKKPCONC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x72E7BF0", Offset = "0x72E67F0", VA = "0x1872E7BF0")]
		[CompilerGenerated]
		private void HIMFOEJFKNN(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x9BA060", Offset = "0x9B8C60", VA = "0x1809BA060")]
		[CompilerGenerated]
		private string MEAMDNENIFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x72EA4F0", Offset = "0x72E90F0", VA = "0x1872EA4F0")]
		[CompilerGenerated]
		private void NKPIFLJEPBB(string FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x9C0380", Offset = "0x9BEF80", VA = "0x1809C0380")]
		[CompilerGenerated]
		private bool AFNAPADHMBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x72E7160", Offset = "0x72E5D60", VA = "0x1872E7160")]
		[CompilerGenerated]
		private void CBEKLPPPIFG(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9BBF10", Offset = "0x9BAB10", VA = "0x1809BBF10")]
		[CompilerGenerated]
		private bool KBEAFGLKMMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x72E7590", Offset = "0x72E6190", VA = "0x1872E7590")]
		[CompilerGenerated]
		private void CHIPDOHAEPP(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x17EF580", Offset = "0x17EE180", VA = "0x1817EF580")]
		[CompilerGenerated]
		private bool BIAFJKIEELH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x72E9680", Offset = "0x72E8280", VA = "0x1872E9680")]
		[CompilerGenerated]
		private void KKLBNAPLOLM(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x72EA6D0", Offset = "0x72E92D0", VA = "0x1872EA6D0")]
		[CompilerGenerated]
		private bool OCLPDBKEBBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x72E7C50", Offset = "0x72E6850", VA = "0x1872E7C50")]
		[CompilerGenerated]
		private void HMANNGMPDAG(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1B70C20", Offset = "0x1B6F820", VA = "0x181B70C20")]
		[CompilerGenerated]
		private bool GDFFMKFIMFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x72E79F0", Offset = "0x72E65F0", VA = "0x1872E79F0")]
		[CompilerGenerated]
		private void GLFHHDEFFEC(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x72E95C0", Offset = "0x72E81C0", VA = "0x1872E95C0")]
		[CompilerGenerated]
		private bool JJKDLJFOJGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x72E75F0", Offset = "0x72E61F0", VA = "0x1872E75F0")]
		[CompilerGenerated]
		private void CIHANONJMCI(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x72E7CB0", Offset = "0x72E68B0", VA = "0x1872E7CB0")]
		[CompilerGenerated]
		private bool HMDFMNBGLNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x72E7930", Offset = "0x72E6530", VA = "0x1872E7930")]
		[CompilerGenerated]
		private void FJFAIMJLFLP(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x72E7050", Offset = "0x72E5C50", VA = "0x1872E7050")]
		[CompilerGenerated]
		private bool APPFMNGHIAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x72E7990", Offset = "0x72E6590", VA = "0x1872E7990")]
		[CompilerGenerated]
		private void GKFCHGFJFME(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1177510", Offset = "0x1176110", VA = "0x181177510")]
		[CompilerGenerated]
		private bool LADGEFNJJEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x72EA390", Offset = "0x72E8F90", VA = "0x1872EA390")]
		[CompilerGenerated]
		private void LGHMLDMCKDF(bool FABNDDIHAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1DB89B0", Offset = "0x1DB75B0", VA = "0x181DB89B0")]
		[CompilerGenerated]
		private bool HPHPGAEJMKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x72E7D70", Offset = "0x72E6970", VA = "0x1872E7D70")]
		[CompilerGenerated]
		private void IBLODLNFKDH(bool FABNDDIHAPL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected override string MBBOOIBGILE
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x72E46E0", Offset = "0x72E32E0", VA = "0x1872E46E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x72E46D0", Offset = "0x72E32D0", VA = "0x1872E46D0")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected override string MBBOOIBGILE
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x72E4710", Offset = "0x72E3310", VA = "0x1872E4710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x72E46D0", Offset = "0x72E32D0", VA = "0x1872E46D0")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class CanvasScreenSizeRefitter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class BAEBEJELEPK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public CanvasScreenSizeRefitter <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public BAEBEJELEPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x72D2FB0", Offset = "0x72D1BB0", VA = "0x1872D2FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x72D30C0", Offset = "0x72D1CC0", VA = "0x1872D30C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private float minPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private float maxPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private float offsetFromNearClipPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private Camera ILPJPLPMCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Vector2 IGEOMHGFCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private float CMMEEBEAIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Coroutine HLNPEGJMPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private bool LAFPEHNLCHP;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private float EPAPEFBEPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x72D5290", Offset = "0x72D3E90", VA = "0x1872D5290")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private float PAJLNOLJFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x72D5120", Offset = "0x72D3D20", VA = "0x1872D5120")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private RectTransform PCJDIIGLEDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x72D51B0", Offset = "0x72D3DB0", VA = "0x1872D51B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x72D5320", Offset = "0x72D3F20", VA = "0x1872D5320")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x153F0B0", Offset = "0x153DCB0", VA = "0x18153F0B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
		public void SetLookCamera(Camera HIHJGAGNPGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1588E20", Offset = "0x1587A20", VA = "0x181588E20")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x72D5210", Offset = "0x72D3E10", VA = "0x1872D5210")]
		[IteratorStateMachine(typeof(BAEBEJELEPK))]
		private IEnumerator JHOADAIOCNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x72D4E60", Offset = "0x72D3A60", VA = "0x1872D4E60")]
		private void CHIFCMNLGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x72D53C0", Offset = "0x72D3FC0", VA = "0x1872D53C0")]
		public void PinToTopLeftOfScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x72D5720", Offset = "0x72D4320", VA = "0x1872D5720")]
		public CanvasScreenSizeRefitter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BCBDLEMKIKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public Dictionary<string, int> IAAHPHMHCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public Dictionary<string, float> JBACANIJFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public Dictionary<string, long> GKKPOKCPIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public Dictionary<string, string> AKOKNLBNEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public Dictionary<string, Guid> FGGIEHNONDA;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x72D3340", Offset = "0x72D1F40", VA = "0x1872D3340")]
	public bool ALBPNLCPFJD(string NKANGPLHEGE, [Out] string DFHBLNKJOIN, string MPDMBPEKKLJ = "")
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x72D3C60", Offset = "0x72D2860", VA = "0x1872D3C60")]
	public BDKGKPLHPOD.INEHONOFCNC HLJAHAGIGML(string NKANGPLHEGE, BDKGKPLHPOD.INEHONOFCNC AEOOLJFIGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x72D3110", Offset = "0x72D1D10", VA = "0x1872D3110")]
	public void AGIJJOPDCPP(string NKANGPLHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72D3EA0", Offset = "0x72D2AA0", VA = "0x1872D3EA0")]
	public void PPOPFIPDJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x72D3520", Offset = "0x72D2120", VA = "0x1872D3520")]
	public void CKMFKNAAJOB(BCBDLEMKIKA ELKOJLIKJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x72D3F80", Offset = "0x72D2B80", VA = "0x1872D3F80")]
	public BCBDLEMKIKA()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[Flags]
		internal enum PHBELIJOFOI
		{
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			OnStopTracking = 8
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal enum KBLADICJFKP
		{
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private struct DGNKMFHLLOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x72EC670", Offset = "0x72EB270", VA = "0x1872EC670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static NOLPMEOMMPP<BCBDLEMKIKA> MCFGOGHOKKE;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private const float DAMJEPBODGO = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private const string MOOECHEFMGB = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private PHBELIJOFOI logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private KBLADICJFKP logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private BCBDLEMKIKA KOAOENKJNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int KHHNJILBKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Dictionary<int, string> GDFDHLGCBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Dictionary<string, int> JDHCHLCEKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private List<int> FNBGLDECDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private List<int> JDLIHHLKPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private List<ImpressionTracker> HGBJMNEMOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private List<ImpressionTracker> ELGNODOLNCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private List<int> GLPILKLNOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private List<int> NGDCBBIDKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private Dictionary<int, int> JPEFJMJFGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private List<int> HBIOFBHIJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private Dictionary<int, string> KANEOAKCJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private Dictionary<string, string> FKDGLAFOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private List<BCBDLEMKIKA> HIPMHEOKHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private List<BCBDLEMKIKA> DLNGLADGFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private LKJANOHFCKM HBDBBINAAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private BrowserModel HPCFHMDKJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private Uri IJBLGEIPFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private bool MNGEGDKDHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private ImpressionTracker OBCCHOBFCNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private bool PAJKJFENIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private StringBuilder LMBNKDAJMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool IMBIGOKLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xA8F240", Offset = "0xA8DE40", VA = "0x180A8F240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA8EEC0", Offset = "0xA8DAC0", VA = "0x180A8EEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x72DB6C0", Offset = "0x72DA2C0", VA = "0x1872DB6C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x72DD570", Offset = "0x72DC170", VA = "0x1872DD570")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x72DD9E0", Offset = "0x72DC5E0", VA = "0x1872DD9E0")]
		public void SetDataToCollateFromChildrenOnLog(string NKANGPLHEGE, string NBKBMLNEBHK, bool BGPIPCBLIHP = false, string JNIDCGEJPPN = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x72DDB00", Offset = "0x72DC700", VA = "0x1872DDB00")]
		public void SetDataToRecordOnClickThrough(string NKANGPLHEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x72DCA30", Offset = "0x72DB630", VA = "0x1872DCA30")]
		public void LogImpression(bool NBNIPGNLIMD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x72DB5F0", Offset = "0x72DA1F0", VA = "0x1872DB5F0")]
		[AsyncStateMachine(typeof(DGNKMFHLLOK))]
		private void ACFEHIOFBDC(Task LLBBIGGFFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x72DE950", Offset = "0x72DD550", VA = "0x1872DE950")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x72DECF0", Offset = "0x72DD8F0", VA = "0x1872DECF0")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x72DECB0", Offset = "0x72DD8B0", VA = "0x1872DECB0")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x72DD770", Offset = "0x72DC370", VA = "0x1872DD770")]
		public void RecordClickThrough([Optional] string LGFDJLFDMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x72DE710", Offset = "0x72DD310", VA = "0x1872DE710")]
		public void SetString(string NKANGPLHEGE, string LLDJIJICLJF, bool NCJKDGNCMPO = false, bool AOIGLBBLPCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x72DDDC0", Offset = "0x72DC9C0", VA = "0x1872DDDC0")]
		public void SetGuid(string NKANGPLHEGE, Guid LLDJIJICLJF, bool NCJKDGNCMPO = false, bool AOIGLBBLPCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x72DE270", Offset = "0x72DCE70", VA = "0x1872DE270")]
		public void SetLong(string NKANGPLHEGE, long LLDJIJICLJF, bool NCJKDGNCMPO = false, bool AOIGLBBLPCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x72DDB70", Offset = "0x72DC770", VA = "0x1872DDB70")]
		public void SetFloat(string NKANGPLHEGE, float LLDJIJICLJF, bool NCJKDGNCMPO = false, bool AOIGLBBLPCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x72DE4B0", Offset = "0x72DD0B0", VA = "0x1872DE4B0")]
		public void SetObject(string NKANGPLHEGE, object LLDJIJICLJF, bool NCJKDGNCMPO = false, bool AOIGLBBLPCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x72DE030", Offset = "0x72DCC30", VA = "0x1872DE030")]
		public void SetInt(string NKANGPLHEGE, int LLDJIJICLJF, bool NCJKDGNCMPO = false, bool AOIGLBBLPCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x72DF040", Offset = "0x72DDC40", VA = "0x1872DF040")]
		public bool TryGetValueAsString(string NKANGPLHEGE, [Out] string DFHBLNKJOIN, string MPDMBPEKKLJ = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x72DBBC0", Offset = "0x72DA7C0", VA = "0x1872DBBC0")]
		public void ClearData(string NKANGPLHEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x72DC740", Offset = "0x72DB340", VA = "0x1872DC740")]
		private int ICKMLMMLBON(string NKANGPLHEGE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x72DD4E0", Offset = "0x72DC0E0", VA = "0x1872DD4E0")]
		private string MABMHDBEAGB(int HGEMPDBGGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x72DB9A0", Offset = "0x72DA5A0", VA = "0x1872DB9A0")]
		private void BEHHPEAKJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x72DBE80", Offset = "0x72DAA80", VA = "0x1872DBE80")]
		private void EJPJODOFLNP(ImpressionTracker DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x72DC920", Offset = "0x72DB520", VA = "0x1872DC920")]
		private void JNPJDHFEPCP(ImpressionTracker DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x72DBA60", Offset = "0x72DA660", VA = "0x1872DBA60")]
		private void BMOPFLFHMKC(bool BCGLHGDCEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x72DBDD0", Offset = "0x72DA9D0", VA = "0x1872DBDD0")]
		private void DMOBPEOACAM(PageWrapper BPJHMDBCFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x72DD6E0", Offset = "0x72DC2E0", VA = "0x1872DD6E0")]
		private void PPOMHKPBIGK(bool EMMMMFLNNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x72DC030", Offset = "0x72DAC30", VA = "0x1872DC030")]
		private void FBEKIBNEPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x72DC480", Offset = "0x72DB080", VA = "0x1872DC480")]
		private void GEJCACAMJMA(string NKANGPLHEGE, ImpressionTracker DEDKLMDDBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x72DC0C0", Offset = "0x72DACC0", VA = "0x1872DC0C0")]
		private string GANOMMKMMGA(int KNPKCAOAHFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x72DC830", Offset = "0x72DB430", VA = "0x1872DC830")]
		private int IOMEEOFIAMG(BCBDLEMKIKA IFMENDFGFGN, BCBDLEMKIKA DPEOCFNLADP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x72DBE70", Offset = "0x72DAA70", VA = "0x1872DBE70")]
		private bool EDDPKLLLCFK(PHBELIJOFOI NAFOGBBHONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x72DF170", Offset = "0x72DDD70", VA = "0x1872DF170")]
		public ImpressionTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class NDEPMHMGKLI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
	public NDEPMHMGKLI()
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
