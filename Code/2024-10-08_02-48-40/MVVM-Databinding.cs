using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using MVVMDatabinding.Theming;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace MVVMDatabinding
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum DataSourceIdResolutionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		ManuallySetInstance,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		GetComponentInParent
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class BaseBinder : IBinder
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private DataSourceIdResolutionType resolutionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[ConditionalVisibility("editor_SourceInstanceNeedsSet", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[ConditionalVisibility("DataRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ConditionalShowAsMessage("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals, ConditionalShowAsMessageAttribute.MessageType.Info)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected bool isListItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected int listItemIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int fullSourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x604D020", Offset = "0x604C220", VA = "0x18604D020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x604CC30", Offset = "0x604BE30", VA = "0x18604CC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x604CCC0", Offset = "0x604BEC0", VA = "0x18604CCC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x604CE00", Offset = "0x604C000", VA = "0x18604CE00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x604D140", Offset = "0x604C340", VA = "0x18604D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x604CD10", Offset = "0x604BF10", VA = "0x18604CD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x604D030", Offset = "0x604C230", VA = "0x18604D030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private bool editor_SourceInstanceNeedsSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x604D0B0", Offset = "0x604C2B0", VA = "0x18604D0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x604CFD0", Offset = "0x604C1D0", VA = "0x18604CFD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8942B0", Offset = "0x8934B0", VA = "0x1808942B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8941C0", Offset = "0x8933C0", VA = "0x1808941C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "11")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "12")]
		public virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x604C0D0", Offset = "0x604B2D0", VA = "0x18604C0D0", Slot = "13")]
		public virtual void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x604C1C0", Offset = "0x604B3C0", VA = "0x18604C1C0", Slot = "14")]
		public virtual void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x604CAB0", Offset = "0x604BCB0", VA = "0x18604CAB0", Slot = "15")]
		public virtual void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x604C210", Offset = "0x604B410", VA = "0x18604C210")]
		protected void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x604CAB0", Offset = "0x604BCB0", VA = "0x18604CAB0")]
		protected void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract void OnDataItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x604C2F0", Offset = "0x604B4F0", VA = "0x18604C2F0")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x604C5D0", Offset = "0x604B7D0", VA = "0x18604C5D0")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x604C380", Offset = "0x604B580", VA = "0x18604C380")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x604CA80", Offset = "0x604BC80", VA = "0x18604CA80", Slot = "17")]
		protected virtual void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x604C1E0", Offset = "0x604B3E0", VA = "0x18604C1E0", Slot = "18")]
		protected virtual string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x604CB90", Offset = "0x604BD90", VA = "0x18604CB90")]
		protected BaseBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public abstract class BaseBinder<T> : BaseBinder
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53DEFF0", Offset = "0x53DE1F0", VA = "0x1853DEFF0", Slot = "16")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53DF330", Offset = "0x53DE530", VA = "0x1853DF330")]
		protected void TrySetDataValue(T dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x53DF1B0", Offset = "0x53DE3B0", VA = "0x1853DF1B0", Slot = "17")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x53DEC00", Offset = "0x53DDE00", VA = "0x1853DEC00", Slot = "18")]
		protected override string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x53DF660", Offset = "0x53DE860", VA = "0x1853DF660")]
		protected BaseBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ButtonActionBinder : BaseBinder<Action>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ConditionalVisibility("DataRecordValid", ConditionResultType.ShowIfEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x604E180", Offset = "0x604D380", VA = "0x18604E180", Slot = "13")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x604E3E0", Offset = "0x604D5E0", VA = "0x18604E3E0", Slot = "15")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "19")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x604E270", Offset = "0x604D470", VA = "0x18604E270")]
		protected void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x604E4C0", Offset = "0x604D6C0", VA = "0x18604E4C0")]
		public ButtonActionBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ColorBinder : BaseBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Graphic target;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x604E500", Offset = "0x604D700", VA = "0x18604E500", Slot = "19")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x604E5A0", Offset = "0x604D7A0", VA = "0x18604E5A0")]
		public ColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ColorTokenBinder : BaseBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private Graphic target;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x604E790", Offset = "0x604D990", VA = "0x18604E790", Slot = "19")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x604E840", Offset = "0x604DA40", VA = "0x18604E840")]
		public ColorTokenBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum BindDirection
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		OneWay,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		OneWayToSource,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TwoWay
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface IBinder
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnDisable();

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Bind(GameObject bindingObject);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnDataItemUpdate(IDataSource dataSource, int itemId);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SpriteSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Sprite trueSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Sprite falseSprite;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6055750", Offset = "0x6054950", VA = "0x186055750", Slot = "19")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60557F0", Offset = "0x60549F0", VA = "0x1860557F0")]
		public SpriteSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class StringSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private string trueString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private string falseString;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6055830", Offset = "0x6054A30", VA = "0x186055830", Slot = "19")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60558D0", Offset = "0x6054AD0", VA = "0x1860558D0")]
		public StringSwapBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TextBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfEquals, 0)]
		[SerializeField]
		private TextMeshProUGUI text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfNotEquals, 0)]
		[SerializeField]
		private TMP_InputField textInput;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6055B40", Offset = "0x6054D40", VA = "0x186055B40", Slot = "13")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6055EA0", Offset = "0x60550A0", VA = "0x186055EA0", Slot = "15")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6055C50", Offset = "0x6054E50", VA = "0x186055C50", Slot = "19")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6055D40", Offset = "0x6054F40", VA = "0x186055D40")]
		private void OnTextEdited(string textData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6055FA0", Offset = "0x60551A0", VA = "0x186055FA0")]
		public TextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class TextureBinder : BaseBinder<Texture>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private RawImage target;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6055FE0", Offset = "0x60551E0", VA = "0x186055FE0", Slot = "19")]
		protected override void OnDataUpdated(Texture dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6056070", Offset = "0x6055270", VA = "0x186056070")]
		public TextureBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VisibilityBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private GameObject targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private bool invertVisibility;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x605CF00", Offset = "0x605C100", VA = "0x18605CF00", Slot = "19")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x605CFA0", Offset = "0x605C1A0", VA = "0x18605CFA0")]
		public VisibilityBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class BaseDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected Dictionary<int, IDataItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xFB4EE0", Offset = "0xFB40E0", VA = "0x180FB4EE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x604D5D0", Offset = "0x604C7D0", VA = "0x18604D5D0", Slot = "19")]
		public virtual void Initialize(string sourceName, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x604D570", Offset = "0x604C770", VA = "0x18604D570", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "9")]
		public void GenerateRecord(string recordDirPath, List<IDataItem> dataItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x604D6E0", Offset = "0x604C8E0", VA = "0x18604D6E0", Slot = "20")]
		public virtual void LoadDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x604D220", Offset = "0x604C420", VA = "0x18604D220", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x604D820", Offset = "0x604CA20", VA = "0x18604D820", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x604D9F0", Offset = "0x604CBF0", VA = "0x18604D9F0", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x604DBC0", Offset = "0x604CDC0", VA = "0x18604DBC0", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5E20", Offset = "0x2BB5020", VA = "0x182BB5E20", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6470", Offset = "0x2BB5670", VA = "0x182BB6470", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5C60", Offset = "0x2BB4E60", VA = "0x182BB5C60", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB62C0", Offset = "0x2BB54C0", VA = "0x182BB62C0", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T itemValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x604D980", Offset = "0x604CB80", VA = "0x18604D980")]
		public static string ResolveNameWithRuntimeId(string sourceName, int runtimeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x604DC60", Offset = "0x604CE60", VA = "0x18604DC60")]
		protected BaseDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class DataBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeReference]
		private List<IBinder> binders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool bindingDone;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6050E30", Offset = "0x6050030", VA = "0x186050E30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6051050", Offset = "0x6050250", VA = "0x186051050")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6050C90", Offset = "0x604FE90", VA = "0x186050C90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6050AF0", Offset = "0x604FCF0", VA = "0x186050AF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6050A40", Offset = "0x604FC40", VA = "0x186050A40")]
		public void AddBinder(IBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6050FE0", Offset = "0x60501E0", VA = "0x186050FE0")]
		public void ReplaceBinderAtIndex(IBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public DataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IDataItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Initialize(int id, string name, string comment = "");

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RuntimeInit(UnityEngine.Object dataSourceOwner);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RaiseValueChanged();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SyncItemWithSource();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class DataItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		protected int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0", Slot = "4")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89F8C0", Offset = "0x89EAC0", VA = "0x18089F8C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6052310", Offset = "0x6051510", VA = "0x186052310", Slot = "8")]
		public void Initialize(int id, string name, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6052350", Offset = "0x6051550", VA = "0x186052350", Slot = "12")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		public abstract void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract void RuntimeInit(UnityEngine.Object dataSourceOwner);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract void SyncItemWithSource();

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6052370", Offset = "0x6051570", VA = "0x186052370")]
		protected DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate T DataItemGetter<T>();
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void DataItemSetter<T>(T val);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class DataItem<T> : DataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected DataItemGetter<T> valueGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		protected DataItemSetter<T> valueSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private UnityEvent<T> getAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private UnityEvent<T> setUnderlyingValue;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5B56C00", Offset = "0x5B55E00", VA = "0x185B56C00", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4905DC0", Offset = "0x4904FC0", VA = "0x184905DC0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5B571C0", Offset = "0x5B563C0", VA = "0x185B571C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "15")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5B55710", Offset = "0x5B54910", VA = "0x185B55710", Slot = "16")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5B56490", Offset = "0x5B55690", VA = "0x185B56490", Slot = "17")]
		public override void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5B55430", Offset = "0x5B54630", VA = "0x185B55430")]
		private void OnSetValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5B568F0", Offset = "0x5B55AF0", VA = "0x185B568F0")]
		protected DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DataItemInt : DataItem<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60514B0", Offset = "0x60506B0", VA = "0x1860514B0")]
		public DataItemInt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class DataItemLong : DataItem<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6051680", Offset = "0x6050880", VA = "0x186051680")]
		public DataItemLong()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DataItemFloat : DataItem<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6051470", Offset = "0x6050670", VA = "0x186051470")]
		public DataItemFloat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DataItemBool : DataItem<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60513F0", Offset = "0x60505F0", VA = "0x1860513F0")]
		public DataItemBool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class DataItemString : DataItem<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6051740", Offset = "0x6050940", VA = "0x186051740")]
		public DataItemString()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class DataItemColor : DataItem<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6051430", Offset = "0x6050630", VA = "0x186051430")]
		public DataItemColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class DataItemMaterial : DataItem<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60516C0", Offset = "0x60508C0", VA = "0x1860516C0")]
		public DataItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class DataItemSprite : DataItem<Sprite>
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6051700", Offset = "0x6050900", VA = "0x186051700")]
		public DataItemSprite()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DataItemTexture : DataItem<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6051780", Offset = "0x6050980", VA = "0x186051780")]
		public DataItemTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class DataItemVector2 : DataItem<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6052250", Offset = "0x6051450", VA = "0x186052250")]
		public DataItemVector2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DataItemVector3 : DataItem<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6052290", Offset = "0x6051490", VA = "0x186052290")]
		public DataItemVector3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DataItemVector4 : DataItem<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60522D0", Offset = "0x60514D0", VA = "0x1860522D0")]
		public DataItemVector4()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DataItemList : DataItem<DataList>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "15")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60514F0", Offset = "0x60506F0", VA = "0x1860514F0", Slot = "16")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6051640", Offset = "0x6050840", VA = "0x186051640")]
		public DataItemList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class DataItemAction : DataItem<Action>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Action dataAction;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6051220", Offset = "0x6050420", VA = "0x186051220", Slot = "16")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x894310", Offset = "0x893510", VA = "0x180894310")]
		private Action GetAction()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x60513B0", Offset = "0x60505B0", VA = "0x1860513B0")]
		public DataItemAction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class DataList
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ListUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6052630", Offset = "0x6051830", VA = "0x186052630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x60526D0", Offset = "0x60518D0", VA = "0x1860526D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xBD4A20", Offset = "0xBD3C20", VA = "0x180BD4A20")]
		protected void OnListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		protected DataList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DataList<T> : DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private List<T> dataList;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3FC5E20", Offset = "0x3FC5020", VA = "0x183FC5E20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T this[int key]
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3E747D0", Offset = "0x3E739D0", VA = "0x183E747D0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5B57720", Offset = "0x5B56920", VA = "0x185B57720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5B57670", Offset = "0x5B56870", VA = "0x185B57670")]
		public DataList(int capacity = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5B575B0", Offset = "0x5B567B0", VA = "0x185B575B0")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5B57550", Offset = "0x5B56750", VA = "0x185B57550")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5B57610", Offset = "0x5B56810", VA = "0x185B57610")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[DisallowMultipleComponent]
	public class DataListItemBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private List<BaseLocalViewModel> localViewModelList;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x60524E0", Offset = "0x60516E0", VA = "0x1860524E0")]
		public void SetData(int sourceId, int listId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60523D0", Offset = "0x60515D0", VA = "0x1860523D0")]
		public void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public DataListItemBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DataRecordItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6052770", Offset = "0x6051970", VA = "0x186052770")]
		public DataRecordItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DataRecord : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int SourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public bool ExtraDataRequiredAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private List<DataRecordItem> dataItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<int, DataRecordItem> itemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<string, int> itemNameToIdMap;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6053700", Offset = "0x6052900", VA = "0x186053700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6052C80", Offset = "0x6051E80", VA = "0x186052C80")]
		internal void PopulateRecord(int sourceId, string sourceName, bool idModifiedAtRuntime, List<IDataItem> itemList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6052800", Offset = "0x6051A00", VA = "0x186052800")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6052B50", Offset = "0x6051D50", VA = "0x186052B50")]
		public void PopulateItemNameList(List<string> itemNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60529E0", Offset = "0x6051BE0", VA = "0x1860529E0")]
		public void PopulateItemNameListForType(List<string> itemNames, string typeString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6053390", Offset = "0x6052590", VA = "0x186053390")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6053500", Offset = "0x6052700", VA = "0x186053500")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6053210", Offset = "0x6052410", VA = "0x186053210")]
		public bool TryGetCommentForId(int id, [Out] string comment)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6053680", Offset = "0x6052880", VA = "0x186053680")]
		public DataRecord()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected DataSourceIdResolutionType resolutionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[ConditionalVisibility("editor_SourceInstanceNeedsSet", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int fullSourceId;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x604D020", Offset = "0x604C220", VA = "0x18604D020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6054230", Offset = "0x6053430", VA = "0x186054230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6054370", Offset = "0x6053570", VA = "0x186054370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6054640", Offset = "0x6053840", VA = "0x186054640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6054280", Offset = "0x6053480", VA = "0x186054280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6054440", Offset = "0x6053640", VA = "0x186054440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6054490", Offset = "0x6053690", VA = "0x186054490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private bool editor_SourceInstanceNeedsSet
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6054510", Offset = "0x6053710", VA = "0x186054510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6054190", Offset = "0x6053390", VA = "0x186054190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x60545A0", Offset = "0x60537A0", VA = "0x1860545A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6053940", Offset = "0x6052B40", VA = "0x186053940")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6053740", Offset = "0x6052940", VA = "0x186053740")]
		public void Subscribe(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6054030", Offset = "0x6053230", VA = "0x186054030")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6053830", Offset = "0x6052A30", VA = "0x186053830")]
		public bool TryGetBindingInfo([Out] int sourceId, [Out] int itemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C702B0", Offset = "0x2C6F4B0", VA = "0x182C702B0")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C703C0", Offset = "0x2C6F5C0", VA = "0x182C703C0")]
		public bool TrySetData<T>(T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9FD660", Offset = "0x9FC860", VA = "0x1809FD660", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x60538B0", Offset = "0x6052AB0", VA = "0x1860538B0")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6053B80", Offset = "0x6052D80", VA = "0x186053B80")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6054110", Offset = "0x6053310", VA = "0x186054110")]
		public DataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DataSourceManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private class PendingSubscription
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int DataItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public DataItemUpdate OnUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public PendingSubscription()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static DataSourceManager _instance;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static Dictionary<int, IDataSource> dataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static Dictionary<int, List<PendingSubscription>> pendingSubscriptons;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static DataSourceManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6055120", Offset = "0x6054320", VA = "0x186055120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6054710", Offset = "0x6053910", VA = "0x186054710")]
		public static void RegisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6054E10", Offset = "0x6054010", VA = "0x186054E10")]
		public static void UnregisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6054AF0", Offset = "0x6053CF0", VA = "0x186054AF0")]
		public static void SubscribeToItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6054F30", Offset = "0x6054130", VA = "0x186054F30")]
		public static void UnsubscribeFromItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6054D80", Offset = "0x6053F80", VA = "0x186054D80")]
		public static bool TryGetDataSource(int sourceId, [Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6054A80", Offset = "0x6053C80", VA = "0x186054A80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public DataSourceManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void DataItemUpdate(IDataSource source, int id);
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface IDataSource
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize(string name, bool idModifiedAtRuntime);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CleanUp();

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GenerateRecord(string recordPath, List<IDataItem> dataItems);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LoadDataRecord(DataRecord record);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AddItem(IDataItem item);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnItemChangedInSource(int id);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SubscribeToItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UnsubscribeFromItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TryGetItem<T>(int id, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TrySetItem<T>(int id, T item);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TryGetItemAtIndex<T>(int id, int index, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool TrySetItemAtIndex<T>(int id, int index, T item);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalEnableAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum ConditionalEnableType
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			EnableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			DisableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			Never
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ConditionalEnableType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
			[CompilerGenerated]
			get
			{
				return default(ConditionalEnableType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA22AE0", Offset = "0xA21CE0", VA = "0x180A22AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6050880", Offset = "0x604FA80", VA = "0x186050880")]
		public ConditionalEnableAttribute(string conditionPropertyName, ConditionalEnableType conditionType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ConditionalShowAsMessageAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum MessageType
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Info,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string ComparisonPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA22AE0", Offset = "0xA21CE0", VA = "0x180A22AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8D5A10", Offset = "0x8D4C10", VA = "0x1808D5A10")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8D5600", Offset = "0x8D4800", VA = "0x1808D5600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0")]
			[CompilerGenerated]
			get
			{
				return default(MessageType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x897BC0", Offset = "0x896DC0", VA = "0x180897BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xBCA8D0", Offset = "0xBC9AD0", VA = "0x180BCA8D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xE1D500", Offset = "0xE1C700", VA = "0x180E1D500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6050930", Offset = "0x604FB30", VA = "0x186050930")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, MessageType messageType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60508D0", Offset = "0x604FAD0", VA = "0x1860508D0")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, int targetEnumValue, MessageType messageType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public enum ConditionComparisonType
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Enum
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public enum ConditionResultType
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		ShowIfEquals,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		ShowIfNotEquals,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Never
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalVisibilityAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x89A5C0", Offset = "0x8997C0", VA = "0x18089A5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x897BC0", Offset = "0x896DC0", VA = "0x180897BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xBCA8D0", Offset = "0xBC9AD0", VA = "0x180BCA8D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xE1D500", Offset = "0xE1C700", VA = "0x180E1D500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60509F0", Offset = "0x604FBF0", VA = "0x1860509F0")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6050990", Offset = "0x604FB90", VA = "0x186050990")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType, int targetEnumValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class DropdownSelectionAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string OptionsSourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string SelectedOptionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6055170", Offset = "0x6054370", VA = "0x186055170")]
		public DropdownSelectionAttribute(string optionsSourcePropertyName, string selectedOptionPropertyName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class BindableActionAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x604E020", Offset = "0x604D220", VA = "0x18604E020")]
		public BindableActionAttribute(int dataItemId, string comment = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class BindableDataAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x604E0B0", Offset = "0x604D2B0", VA = "0x18604E0B0")]
		public BindableDataAttribute(int dataItemId, string comment = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class BaseGlobalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x604DCB0", Offset = "0x604CEB0", VA = "0x18604DCB0")]
		public BaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class BaseLocalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "8")]
		public virtual void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "9")]
		public virtual void ClearBindingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x604DCB0", Offset = "0x604CEB0", VA = "0x18604DCB0")]
		protected BaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class BaseViewModel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[HideInInspector]
		[SerializeReference]
		private List<IDataItem> dataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private ViewModelDataSource dataSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private string recordDir;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected virtual string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x604DFE0", Offset = "0x604D1E0", VA = "0x18604DFE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public virtual bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x604DD00", Offset = "0x604CF00", VA = "0x18604DD00", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x604DD70", Offset = "0x604CF70", VA = "0x18604DD70")]
		public void InitializeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x604DF10", Offset = "0x604D110", VA = "0x18604DF10")]
		protected void OnPropertyChanged([CallerMemberName] string name = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		[ContextMenu("Update Record")]
		public void UpdateRecord()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "7")]
		protected virtual void RegisterCustomDataTypes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x604DCB0", Offset = "0x604CEB0", VA = "0x18604DCB0")]
		protected BaseViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class DataItemTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static Dictionary<Type, Type> dataItemTypeCache;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6051E50", Offset = "0x6051050", VA = "0x186051E50")]
		public static void RegisterDataItemType(Type underlyingDataType, Type dataItemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6052080", Offset = "0x6051280", VA = "0x186052080")]
		public static bool TryGetDataItemType(Type underlyingDataType, [Out] Type dataItemType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x60517C0", Offset = "0x60509C0", VA = "0x1860517C0")]
		private static void EnsureCacheInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6051880", Offset = "0x6050A80", VA = "0x186051880")]
		private static void RegisterBuiltInTypes()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class ViewModelDataSource : BaseDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private Dictionary<string, int> itemNameToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private BaseViewModel viewModel;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x605C660", Offset = "0x605B860", VA = "0x18605C660")]
		internal void InitializeFromViewModel(BaseViewModel viewModel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x605C750", Offset = "0x605B950", VA = "0x18605C750")]
		public void LoadDataItems(List<IDataItem> dataItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x605CAD0", Offset = "0x605BCD0", VA = "0x18605CAD0")]
		public void OnPropertyChanged(string propertyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x604DC60", Offset = "0x604CE60", VA = "0x18604DC60")]
		public ViewModelDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class ViewModelTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static Dictionary<string, Type> viewModelTypeCache;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x605CC40", Offset = "0x605BE40", VA = "0x18605CC40")]
		public static void RegisterViewModelType(string viewModelTypeString, Type viewModelType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x605CE70", Offset = "0x605C070", VA = "0x18605CE70")]
		public static bool TryGetViewModelType(string typeName, [Out] Type viewModelType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x605CB90", Offset = "0x605BD90", VA = "0x18605CB90")]
		private static void EnsureCacheInitialized()
		{
		}
	}
}
namespace MVVMDatabinding.Theming
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class BaseThemeBinder<T> : IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[ConditionalVisibility("ThemeTemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private ThemeStyle styleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool subscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x54E5640", Offset = "0x54E4840", VA = "0x1854E5640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x54E4680", Offset = "0x54E3880", VA = "0x1854E4680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x54E5460", Offset = "0x54E4660", VA = "0x1854E5460", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x54E4350", Offset = "0x54E3550", VA = "0x1854E4350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x54E4B40", Offset = "0x54E3D40", VA = "0x1854E4B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x54E5890", Offset = "0x54E4A90", VA = "0x1854E5890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected bool IsBindingValid
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x54E4710", Offset = "0x54E3910", VA = "0x1854E4710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x54E48A0", Offset = "0x54E3AA0", VA = "0x1854E48A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected abstract ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54E22A0", Offset = "0x54E14A0", VA = "0x1854E22A0", Slot = "7")]
		public void Bind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x54E3E90", Offset = "0x54E3090", VA = "0x1854E3E90", Slot = "8")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x54E2F20", Offset = "0x54E2120", VA = "0x1854E2F20", Slot = "10")]
		public void OverrideActiveStyle(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x54E2810", Offset = "0x54E1A10", VA = "0x1854E2810", Slot = "9")]
		public void OnThemeItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x54E30D0", Offset = "0x54E22D0", VA = "0x1854E30D0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x54E40D0", Offset = "0x54E32D0", VA = "0x1854E40D0")]
		protected BaseThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class ColorThemeBinder : BaseThemeBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921700", VA = "0x180922500", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x604E5E0", Offset = "0x604D7E0", VA = "0x18604E5E0", Slot = "12")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x604E710", Offset = "0x604D910", VA = "0x18604E710")]
		public ColorThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class ColorTokenThemeBinder : BaseThemeBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xBCBBC0", Offset = "0xBCADC0", VA = "0x180BCBBC0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x604FF90", Offset = "0x604F190", VA = "0x18604FF90", Slot = "12")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x60500F0", Offset = "0x604F2F0", VA = "0x1860500F0")]
		public ColorTokenThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class FontSettingsBinder : BaseThemeBinder<ThemeFontSettings>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x9E3DD0", Offset = "0x9E2FD0", VA = "0x1809E3DD0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6055200", Offset = "0x6054400", VA = "0x186055200", Slot = "12")]
		protected override void OnDataUpdated(ThemeFontSettings dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6055350", Offset = "0x6054550", VA = "0x186055350")]
		public FontSettingsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class FontSizeThemeBinder : BaseThemeBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xD3E110", Offset = "0xD3D310", VA = "0x180D3E110", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60553D0", Offset = "0x60545D0", VA = "0x1860553D0", Slot = "12")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x60554F0", Offset = "0x60546F0", VA = "0x1860554F0")]
		public FontSizeThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Bind();

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnThemeItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OverrideActiveStyle(ThemeStyle newStyle);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class MaterialThemeBinder : BaseThemeBinder<Material>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x9FADB0", Offset = "0x9F9FB0", VA = "0x1809FADB0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x60555B0", Offset = "0x60547B0", VA = "0x1860555B0", Slot = "12")]
		protected override void OnDataUpdated(Material dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x60556D0", Offset = "0x60548D0", VA = "0x1860556D0")]
		public MaterialThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class TextureThemeBinder : BaseThemeBinder<Texture>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private List<RawImage> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xB6DF20", Offset = "0xB6D120", VA = "0x180B6DF20", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x60560B0", Offset = "0x60552B0", VA = "0x1860560B0", Slot = "12")]
		protected override void OnDataUpdated(Texture dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x60561C0", Offset = "0x60553C0", VA = "0x1860561C0")]
		public TextureThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class TMPGradientThemeBinder : BaseThemeBinder<TMP_ColorGradient>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x152F3A0", Offset = "0x152E5A0", VA = "0x18152F3A0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6055960", Offset = "0x6054B60", VA = "0x186055960", Slot = "12")]
		protected override void OnDataUpdated(TMP_ColorGradient dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6055AC0", Offset = "0x6054CC0", VA = "0x186055AC0")]
		public TMPGradientThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class VisibilityThemeBinder : BaseThemeBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private GameObject target;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xB438A0", Offset = "0xB42AA0", VA = "0x180B438A0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x605CFE0", Offset = "0x605C1E0", VA = "0x18605CFE0", Slot = "12")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x605D080", Offset = "0x605C280", VA = "0x18605D080")]
		public VisibilityThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum ThemeAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[InspectorName("0%")]
		Zero = 0,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[InspectorName("5%")]
		Five = 5,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[InspectorName("10%")]
		Ten = 10,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[InspectorName("15%")]
		Fifteen = 15,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[InspectorName("20%")]
		Twenty = 20,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[InspectorName("25%")]
		TwentyFive = 25,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[InspectorName("30%")]
		Thirty = 30,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[InspectorName("40%")]
		Forty = 40,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[InspectorName("50%")]
		Fifty = 50,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[InspectorName("60%")]
		Sixty = 60,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[InspectorName("70%")]
		Seventy = 70,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[InspectorName("80%")]
		Eighty = 80,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[InspectorName("90%")]
		Ninety = 90,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[InspectorName("100%")]
		OneHundred = 100
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ColorToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private ThemeAlpha Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Color? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ThemeAlpha prevOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x6050520", Offset = "0x604F720", VA = "0x186050520")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x6050290", Offset = "0x604F490", VA = "0x186050290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x6050660", Offset = "0x604F860", VA = "0x186050660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x60507C0", Offset = "0x604F9C0", VA = "0x1860507C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x6050240", Offset = "0x604F440", VA = "0x186050240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6050170", Offset = "0x604F370", VA = "0x186050170")]
		private void UpdateColor(Color newColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6050220", Offset = "0x604F420", VA = "0x186050220")]
		public ColorToken()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class ColorTokenDefinition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Color Color;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x604E880", Offset = "0x604DA80", VA = "0x18604E880")]
		public ColorTokenDefinition(int id, string name, Color color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CreateAssetMenu(fileName = "ColorTokenGroup", menuName = "MVVM/Theming/Color Token Group")]
	public class ColorTokenGroup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private List<ColorTokenDefinition> colorDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private List<ColorTokenReference> colorTokenReferences;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x604F890", Offset = "0x604EA90", VA = "0x18604F890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x604E930", Offset = "0x604DB30", VA = "0x18604E930")]
		public List<string> GetColorTokenNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x604EF10", Offset = "0x604E110", VA = "0x18604EF10")]
		public bool TryGetColorTokenByName(string name, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x604EC50", Offset = "0x604DE50", VA = "0x18604EC50")]
		public bool TryGetColorTokenById(int id, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x604F4F0", Offset = "0x604E6F0", VA = "0x18604F4F0")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x604F210", Offset = "0x604E410", VA = "0x18604F210")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public void Editor_UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x604F7C0", Offset = "0x604E9C0", VA = "0x18604F7C0")]
		public ColorTokenGroup()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class ColorTokenReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public ColorTokenDefinition ColorTokenDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x604F9A0", Offset = "0x604EBA0", VA = "0x18604F9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x604FB10", Offset = "0x604ED10", VA = "0x18604FB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x604FD80", Offset = "0x604EF80", VA = "0x18604FD80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x604FEE0", Offset = "0x604F0E0", VA = "0x18604FEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x604F950", Offset = "0x604EB50", VA = "0x18604F950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x604F8F0", Offset = "0x604EAF0", VA = "0x18604F8F0")]
		public ColorTokenReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CreateAssetMenu(fileName = "Theme", menuName = "MVVM/Theming/Theme")]
	public class Theme : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public List<ThemeStyle> ThemeStyleList;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x605C4F0", Offset = "0x605B6F0", VA = "0x18605C4F0")]
		public void Editor_LoadTheme()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A330", Offset = "0xA09530", VA = "0x180A0A330")]
		public Theme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ThemeBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeReference]
		private List<IThemeBinder> binders;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x60564B0", Offset = "0x60556B0", VA = "0x1860564B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6056650", Offset = "0x6055850", VA = "0x186056650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6056240", Offset = "0x6055440", VA = "0x186056240")]
		public void AddBinder(IThemeBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6056A10", Offset = "0x6055C10", VA = "0x186056A10")]
		public void ReplaceBinderAtIndex(IThemeBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x60562F0", Offset = "0x60554F0", VA = "0x1860562F0")]
		public void ApplyStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x60567F0", Offset = "0x60559F0", VA = "0x1860567F0")]
		public void RemoveStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public ThemeBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ThemeDataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		protected ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private ThemeStyleApplier applier;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ThemeStyleTemplate ThemeTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x6057AC0", Offset = "0x6056CC0", VA = "0x186057AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x6057910", Offset = "0x6056B10", VA = "0x186057910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x60579E0", Offset = "0x6056BE0", VA = "0x1860579E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x6057B70", Offset = "0x6056D70", VA = "0x186057B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x6057960", Offset = "0x6056B60", VA = "0x186057960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x6057870", Offset = "0x6056A70", VA = "0x186057870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x6057AD0", Offset = "0x6056CD0", VA = "0x186057AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x60571F0", Offset = "0x60563F0", VA = "0x1860571F0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6056BE0", Offset = "0x6055DE0", VA = "0x186056BE0")]
		public void Subscribe(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x60574E0", Offset = "0x60566E0", VA = "0x1860574E0")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x313DE90", Offset = "0x313D090", VA = "0x18313DE90")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9FD660", Offset = "0x9FC860", VA = "0x1809FD660", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6057090", Offset = "0x6056290", VA = "0x186057090")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6057190", Offset = "0x6056390", VA = "0x186057190")]
		private bool TryGetStyle(ThemeStyleApplier applier, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8941E0", Offset = "0x8933E0", VA = "0x1808941E0")]
		public void SetDataType(Type dataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6056A80", Offset = "0x6055C80", VA = "0x186056A80")]
		public void ApplyStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6056B30", Offset = "0x6055D30", VA = "0x186056B30")]
		public void RemoveStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x60577F0", Offset = "0x60569F0", VA = "0x1860577F0")]
		public ThemeDataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class ThemeDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Dictionary<int, ThemeItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private ThemeVariant activeVariant;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xFB4EE0", Offset = "0xFB40E0", VA = "0x180FB4EE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6057C40", Offset = "0x6056E40", VA = "0x186057C40", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6058420", Offset = "0x6057620", VA = "0x186058420")]
		public bool TryGetThemeItem(int id, [Out] ThemeItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "9")]
		public void GenerateRecord(string recordPath, List<IDataItem> dataItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6057ED0", Offset = "0x60570D0", VA = "0x186057ED0", Slot = "7")]
		public void Initialize(string name, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6057E70", Offset = "0x6057070", VA = "0x186057E70", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x60580F0", Offset = "0x60572F0", VA = "0x1860580F0")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "10")]
		public void LoadDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6057F90", Offset = "0x6057190", VA = "0x186057F90", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x60582A0", Offset = "0x60574A0", VA = "0x1860582A0", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6058490", Offset = "0x6057690", VA = "0x186058490", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x313E1D0", Offset = "0x313D3D0", VA = "0x18313E1D0", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x313E1C0", Offset = "0x313D3C0", VA = "0x18313E1C0", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6058530", Offset = "0x6057730", VA = "0x186058530")]
		public ThemeDataSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ThemeFontSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TMP_FontAsset FontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool AutosizeFont;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfNotEquals)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MinSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MaxSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public FontStyles FontStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float LineHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float CharacterSpacing;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6058640", Offset = "0x6057840", VA = "0x186058640")]
		public ThemeFontSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class ThemeItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private ThemeVariant variant;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x60589C0", Offset = "0x6057BC0", VA = "0x1860589C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x89F8C0", Offset = "0x89EAC0", VA = "0x18089F8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<int> ValueChangedWithId
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6058910", Offset = "0x6057B10", VA = "0x186058910")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6058A10", Offset = "0x6057C10", VA = "0x186058A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "10")]
		public void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6052310", Offset = "0x6051510", VA = "0x186052310", Slot = "8")]
		public void Initialize(int id, string name, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6058660", Offset = "0x6057860", VA = "0x186058660", Slot = "12")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "11")]
		public void RuntimeInit(UnityEngine.Object dataSourceOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "13")]
		public void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x60586A0", Offset = "0x60578A0", VA = "0x1860586A0")]
		public void SetThemeItemValue(ThemeStyleValue styleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6058830", Offset = "0x6057A30", VA = "0x186058830")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x313E490", Offset = "0x313D690", VA = "0x18313E490")]
		public bool TryGetItem<T>([Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6058890", Offset = "0x6057A90", VA = "0x186058890")]
		public ThemeItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ThemeManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static readonly string themingSourcePrefix;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static ThemeManager instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private List<Theme> defaultThemeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<int, ThemeDataSource> themeDataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public static bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6059730", Offset = "0x6058930", VA = "0x186059730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public static ThemeManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x60596E0", Offset = "0x60588E0", VA = "0x1860596E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public ThemeVariant ActiveVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x897BC0", Offset = "0x896DC0", VA = "0x180897BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event Action ThemeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x60595F0", Offset = "0x60587F0", VA = "0x1860595F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x60597B0", Offset = "0x60589B0", VA = "0x1860597B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6058C70", Offset = "0x6057E70", VA = "0x186058C70")]
		public static int GetThemeSourceId(string recordName)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6058AC0", Offset = "0x6057CC0", VA = "0x186058AC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x60593A0", Offset = "0x60585A0", VA = "0x1860593A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x60591A0", Offset = "0x60583A0", VA = "0x1860591A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6058CF0", Offset = "0x6057EF0", VA = "0x186058CF0")]
		public void LoadTheme(Theme theme)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6058B30", Offset = "0x6057D30", VA = "0x186058B30")]
		public void ChangeThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6059560", Offset = "0x6058760", VA = "0x186059560")]
		public ThemeManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public enum ThemeVariant
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Dark,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		HighContrast
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface IThemeValue
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetVariant(ThemeVariant variant);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public abstract class ThemeValue : IThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[HideInInspector]
		[SerializeField]
		protected bool excludedFromVariants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		protected bool referenceStyleValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected ThemeStyle themeStyleReference;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected ThemeVariant activeVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		protected bool ShowVariantValues
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x605C4D0", Offset = "0x605B6D0", VA = "0x18605C4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		protected bool ShowSingleValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x605C4B0", Offset = "0x605B6B0", VA = "0x18605C4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8944D0", Offset = "0x8936D0", VA = "0x1808944D0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8944E0", Offset = "0x8936E0", VA = "0x1808944E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x605C410", Offset = "0x605B610", VA = "0x18605C410", Slot = "8")]
		public void SetVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x605C430", Offset = "0x605B630", VA = "0x18605C430")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ThemeValue<T> : ThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T dark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T highContrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ConditionalVisibility("ShowSingleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private ThemeValue<T> cachedReferenceValue;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x4DC1240", Offset = "0x4DC0440", VA = "0x184DC1240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x4DC1DA0", Offset = "0x4DC0FA0", VA = "0x184DC1DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x4DC2EC0", Offset = "0x4DC20C0", VA = "0x184DC2EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x4DC2430", Offset = "0x4DC1630", VA = "0x184DC2430")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x4DC0E90", Offset = "0x4DC0090", VA = "0x184DC0E90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4DC0710", Offset = "0x4DBF910", VA = "0x184DC0710")]
		private bool HasCircularDependency(ThemeValue<T> themeValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4DC0E00", Offset = "0x4DC0000", VA = "0x184DC0E00")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class ColorThemeValue : ThemeValue<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x604E750", Offset = "0x604D950", VA = "0x18604E750")]
		public ColorThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class GradientThemeValue : ThemeValue<Gradient>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6055530", Offset = "0x6054730", VA = "0x186055530")]
		public GradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class MaterialThemeValue : ThemeValue<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6055710", Offset = "0x6054910", VA = "0x186055710")]
		public MaterialThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class TextureThemeValue : ThemeValue<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6056200", Offset = "0x6055400", VA = "0x186056200")]
		public TextureThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class IntThemeValue : ThemeValue<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6055570", Offset = "0x6054770", VA = "0x186055570")]
		public IntThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class FloatThemeValue : ThemeValue<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x60551C0", Offset = "0x60543C0", VA = "0x1860551C0")]
		public FloatThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class Vector4ThemeValue : ThemeValue<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x605C620", Offset = "0x605B820", VA = "0x18605C620")]
		public Vector4ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class TMPGradientThemeValue : ThemeValue<TMP_ColorGradient>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6055B00", Offset = "0x6054D00", VA = "0x186055B00")]
		public TMPGradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class FontSettingsThemeValue : ThemeValue<ThemeFontSettings>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6055390", Offset = "0x6054590", VA = "0x186055390")]
		public FontSettingsThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class BoolThemeValue : ThemeValue<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x604E140", Offset = "0x604D340", VA = "0x18604E140")]
		public BoolThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ColorTokenValue : ThemeValue<ColorToken>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6050130", Offset = "0x604F330", VA = "0x186050130")]
		public ColorTokenValue()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ThemeStyleValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeItemType itemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeReference]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool ThemeRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x605C210", Offset = "0x605B410", VA = "0x18605C210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x605C050", Offset = "0x605B250", VA = "0x18605C050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x605C0D0", Offset = "0x605B2D0", VA = "0x18605C0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x605C260", Offset = "0x605B460", VA = "0x18605C260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IThemeValue ThemeValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8941E0", Offset = "0x8933E0", VA = "0x1808941E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x605BC00", Offset = "0x605AE00", VA = "0x18605BC00")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x605BCF0", Offset = "0x605AEF0", VA = "0x18605BCF0")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x605BD10", Offset = "0x605AF10", VA = "0x18605BD10")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x605BB80", Offset = "0x605AD80", VA = "0x18605BB80")]
		public void Editor_SetTemplate(ThemeStyleTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
		public bool Editor_OnValidate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public void UpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xB3C1B0", Offset = "0xB3B3B0", VA = "0x180B3C1B0")]
		public void ResetAndUpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x605BFF0", Offset = "0x605B1F0", VA = "0x18605BFF0")]
		public ThemeStyleValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CreateAssetMenu(fileName = "ThemeStyle", menuName = "MVVM/Theming/Theme Style")]
	public class ThemeStyle : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private string styleName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private List<ThemeStyleValue> themeStyleValues;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string StyleName
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public ThemeStyleTemplate Template
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public List<ThemeStyleValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x605C360", Offset = "0x605B560", VA = "0x18605C360")]
		public ThemeStyle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class ThemeStylePicker
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private const string noStylesMatchingTemplateAvailableMessage = "<No styles of template {0} found>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[ConditionalVisibility("TemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("StyleNameOptions", "SelectedItemName")]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private Dictionary<string, ThemeStyle> cachedStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<string> styleNameOptions;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected bool TemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x605AD80", Offset = "0x6059F80", VA = "0x18605AD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public List<string> StyleNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x605AB80", Offset = "0x6059D80", VA = "0x18605AB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x605ADD0", Offset = "0x6059FD0", VA = "0x18605ADD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x605AA10", Offset = "0x6059C10", VA = "0x18605AA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x605AF40", Offset = "0x605A140", VA = "0x18605AF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public ThemeStyle Style
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool Editor_Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x959A80", Offset = "0x958C80", VA = "0x180959A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		internal event Action<ThemeStylePicker> ThemeStyleChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x605A960", Offset = "0x6059B60", VA = "0x18605A960")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x605AE90", Offset = "0x605A090", VA = "0x18605AE90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x605A840", Offset = "0x6059A40", VA = "0x18605A840")]
		internal void Editor_OnValidate(string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		private void Editor_PopulateStyleNameOptions([Optional] string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x605A8D0", Offset = "0x6059AD0", VA = "0x18605A8D0")]
		public ThemeStylePicker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ThemeStyleApplier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeField]
		private List<ThemeStylePicker> themeStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private HashSet<ThemeStyle> styleOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IReadOnlyList<ThemeBinder> runtimeBinders;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ThemeStyle> StyleOverrideApplied
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x605A580", Offset = "0x6059780", VA = "0x18605A580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x605A6E0", Offset = "0x60598E0", VA = "0x18605A6E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ThemeStyle> StyleOverrideRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x605A630", Offset = "0x6059830", VA = "0x18605A630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x605A790", Offset = "0x6059990", VA = "0x18605A790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x605A050", Offset = "0x6059250", VA = "0x18605A050")]
		public bool TryFindStyleForItem(ThemeStyleTemplate template, int itemId, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x60598A0", Offset = "0x6058AA0", VA = "0x1860598A0")]
		public void ApplyRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6059E00", Offset = "0x6059000", VA = "0x186059E00")]
		public void RemoveRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x605A4F0", Offset = "0x60596F0", VA = "0x18605A4F0")]
		public ThemeStyleApplier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum ThemeItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Gradient,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Material,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Vector4,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		TMPGradient,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FontSettings,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ColorToken
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CreateAssetMenu(fileName = "ThemeStyleTemplate", menuName = "MVVM/Theming/Theme Style Template")]
	public class ThemeStyleTemplate : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public class ThemeTemplateItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
			public int Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public ThemeItemType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public bool ExcludeFromVariants;

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x605C3B0", Offset = "0x605B5B0", VA = "0x18605C3B0")]
			public ThemeTemplateItem()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		private List<ThemeTemplateItem> templateItems;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public List<ThemeTemplateItem> TemplateItems
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x605BB40", Offset = "0x605AD40", VA = "0x18605BB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x605B010", Offset = "0x605A210", VA = "0x18605B010")]
		public static ThemeItemType GetThemeItemType(Type targetType)
		{
			return default(ThemeItemType);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x605B6B0", Offset = "0x605A8B0", VA = "0x18605B6B0")]
		public void PopulateItemNameList(List<string> itemNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x605B400", Offset = "0x605A600", VA = "0x18605B400")]
		public void PopulateItemNameListForType(List<string> itemNames, ThemeItemType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x605B550", Offset = "0x605A750", VA = "0x18605B550")]
		public void PopulateItemNameListForType(List<string> itemNames, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x605B9A0", Offset = "0x605ABA0", VA = "0x18605B9A0")]
		public bool TryGetInfoForName(string name, [Out] int id, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x605B7E0", Offset = "0x605A9E0", VA = "0x18605B7E0")]
		public bool TryGetInfoForId(int id, [Out] string name, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA0A330", Offset = "0xA09530", VA = "0x180A0A330")]
		public ThemeStyleTemplate()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AMHLBKDNBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public AMHLBKDNBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x604C000", Offset = "0x604B200", VA = "0x18604C000")]
	public static string GAMEICHIOMK(byte[] PFDCIDAHIKG, byte[] JOBDJKNFOIH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
