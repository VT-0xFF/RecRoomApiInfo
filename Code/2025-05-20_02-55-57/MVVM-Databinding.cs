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
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public abstract class BaseBinder : IBinder
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const string boundItemUnavailableMessage = "<Data Item {0} is unavailable to bind to>";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const string badPermsMessage = "<Data Item {0} cannot be written to>";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const string permissionAndCommentMessageFormat = "{0}\n{1}";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string binderNameFormat = "{0}{1} ({2})";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[ConditionalVisibility("DataRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ConditionalShowAsMessage("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals, ConditionalShowAsMessageAttribute.MessageType.Info)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected bool isListItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected int listItemIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int fullSourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool loggedDataUpdateError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6EE1BA0", Offset = "0x6EE0DA0", VA = "0x186EE1BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6EE16D0", Offset = "0x6EE08D0", VA = "0x186EE16D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6EE1760", Offset = "0x6EE0960", VA = "0x186EE1760", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6EE18A0", Offset = "0x6EE0AA0", VA = "0x186EE18A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6EE1C30", Offset = "0x6EE0E30", VA = "0x186EE1C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6EE17B0", Offset = "0x6EE09B0", VA = "0x186EE17B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6EE1BB0", Offset = "0x6EE0DB0", VA = "0x186EE1BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6EE1B50", Offset = "0x6EE0D50", VA = "0x186EE1B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected virtual DataPermissions PermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "12")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "13")]
		public virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0A40", Offset = "0x6EDFC40", VA = "0x186EE0A40", Slot = "14")]
		public virtual void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0B30", Offset = "0x6EDFD30", VA = "0x186EE0B30", Slot = "15")]
		public virtual void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1550", Offset = "0x6EE0750", VA = "0x186EE1550", Slot = "16")]
		public virtual void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0C90", Offset = "0x6EDFE90", VA = "0x186EE0C90")]
		protected void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1550", Offset = "0x6EE0750", VA = "0x186EE1550")]
		protected void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract void OnDataItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0D70", Offset = "0x6EDFF70", VA = "0x186EE0D70")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EE10A0", Offset = "0x6EE02A0", VA = "0x186EE10A0")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0E00", Offset = "0x6EE0000", VA = "0x186EE0E00")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1500", Offset = "0x6EE0700", VA = "0x186EE1500", Slot = "18")]
		protected virtual void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0B90", Offset = "0x6EDFD90", VA = "0x186EE0B90", Slot = "19")]
		protected virtual string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0BC0", Offset = "0x6EDFDC0", VA = "0x186EE0BC0")]
		protected string GetUnavailableItemMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0B50", Offset = "0x6EDFD50", VA = "0x186EE0B50")]
		protected string GetInvalidPermissionsMessage(string itemName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0C30", Offset = "0x6EDFE30", VA = "0x186EE0C30")]
		protected void LogDataUpdateError(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private void Editor_SetComment(string commentStr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		protected void Editor_UpdateBinderName(string itemName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1630", Offset = "0x6EE0830", VA = "0x186EE1630")]
		protected BaseBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class BaseBinder<T> : BaseBinder
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6163D10", Offset = "0x6162F10", VA = "0x186163D10", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61647A0", Offset = "0x61639A0", VA = "0x1861647A0")]
		protected void TrySetDataValue(T dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61644D0", Offset = "0x61636D0", VA = "0x1861644D0", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6163980", Offset = "0x6162B80", VA = "0x186163980", Slot = "19")]
		protected override string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6164C50", Offset = "0x6163E50", VA = "0x186164C50")]
		protected BaseBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
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

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EE33B0", Offset = "0x6EE25B0", VA = "0x186EE33B0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3610", Offset = "0x6EE2810", VA = "0x186EE3610", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EE34A0", Offset = "0x6EE26A0", VA = "0x186EE34A0")]
		protected void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE36F0", Offset = "0x6EE28F0", VA = "0x186EE36F0")]
		public ButtonActionBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ColorBinder : BaseBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Graphic target;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3730", Offset = "0x6EE2930", VA = "0x186EE3730", Slot = "20")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE37D0", Offset = "0x6EE29D0", VA = "0x186EE37D0")]
		public ColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ColorTokenBinder : BaseBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private Graphic target;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE39C0", Offset = "0x6EE2BC0", VA = "0x186EE39C0", Slot = "20")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3A70", Offset = "0x6EE2C70", VA = "0x186EE3A70")]
		public ColorTokenBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ComponentEnabledStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private List<Behaviour> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private bool invertState;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5AB0", Offset = "0x6EE4CB0", VA = "0x186EE5AB0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5BE0", Offset = "0x6EE4DE0", VA = "0x186EE5BE0")]
		public ComponentEnabledStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class EnabledStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private List<GameObject> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool invertState;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB1D0", Offset = "0x6EEA3D0", VA = "0x186EEB1D0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB300", Offset = "0x6EEA500", VA = "0x186EEB300")]
		public EnabledStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class FormattedTextBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private string formattedString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private string formattingToReplace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private string dataFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private TMP_Text target;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBC30", Offset = "0x6EEAE30", VA = "0x186EEBC30", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB6B0", Offset = "0x6EEA8B0", VA = "0x186EEB6B0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBB30", Offset = "0x6EEAD30", VA = "0x186EEBB30")]
		private void SetFormattedData(string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBEC0", Offset = "0x6EEB0C0", VA = "0x186EEBEC0")]
		public FormattedTextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum BindDirection
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		OneWay,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		OneWayToSource,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		TwoWay
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IBinder
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnDisable();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Bind(GameObject bindingObject);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnDataItemUpdate(IDataSource dataSource, int itemId);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class IndentBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private RectTransform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private float indentSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float? defaultIndent;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC0E0", Offset = "0x6EEB2E0", VA = "0x186EEC0E0", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC200", Offset = "0x6EEB400", VA = "0x186EEC200")]
		public IndentBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class LayoutElementSizeBinder : BaseBinder<float>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum LayoutElementSizeTarget
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			MinWidth,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			MinHeight,
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			PreferredWidth,
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			PreferredHeight,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			FlexWidth,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			FlexHeight
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC280", Offset = "0x6EEB480", VA = "0x186EEC280", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC380", Offset = "0x6EEB580", VA = "0x186EEC380", Slot = "20")]
		protected override void OnDataUpdated(float dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC5D0", Offset = "0x6EEB7D0", VA = "0x186EEC5D0")]
		public LayoutElementSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SpriteBinder : BaseBinder<Sprite>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private bool invisibleIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private bool deactivateIfNull;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC7B0", Offset = "0x6EEB9B0", VA = "0x186EEC7B0", Slot = "20")]
		protected override void OnDataUpdated(Sprite dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC8F0", Offset = "0x6EEBAF0", VA = "0x186EEC8F0")]
		public SpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SpriteSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private Sprite trueSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private Sprite falseSprite;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC930", Offset = "0x6EEBB30", VA = "0x186EEC930", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC9D0", Offset = "0x6EEBBD0", VA = "0x186EEC9D0")]
		public SpriteSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class StringSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private string trueString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private string falseString;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6EECA10", Offset = "0x6EEBC10", VA = "0x186EECA10", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6EECAB0", Offset = "0x6EEBCB0", VA = "0x186EECAB0")]
		public StringSwapBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TextBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfEquals, 0)]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfNotEquals, 0)]
		[SerializeField]
		private TMP_InputField textInput;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override DataPermissions PermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2088F90", Offset = "0x2088190", VA = "0x182088F90", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EECD20", Offset = "0x6EEBF20", VA = "0x186EECD20", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EED080", Offset = "0x6EEC280", VA = "0x186EED080", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EECE30", Offset = "0x6EEC030", VA = "0x186EECE30", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EECF20", Offset = "0x6EEC120", VA = "0x186EECF20")]
		private void OnTextEdited(string textData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EED180", Offset = "0x6EEC380", VA = "0x186EED180")]
		public TextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class TextureBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private RawImage target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private bool invisibleIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private bool deactivateIfNull;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EED480", Offset = "0x6EEC680", VA = "0x186EED480", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EED1C0", Offset = "0x6EEC3C0", VA = "0x186EED1C0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6164C50", Offset = "0x6163E50", VA = "0x186164C50")]
		public TextureBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class VisibilityBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private GameObject targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Tooltip("If invert is false, target will show when value is true.\nIf invert is true, target will show when value is false.")]
		private bool invertVisibility;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4A20", Offset = "0x6EF3C20", VA = "0x186EF4A20", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4AC0", Offset = "0x6EF3CC0", VA = "0x186EF4AC0")]
		public VisibilityBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class BaseDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected Dictionary<int, IDataItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD724A0", Offset = "0xD716A0", VA = "0x180D724A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6EE20A0", Offset = "0x6EE12A0", VA = "0x186EE20A0", Slot = "19")]
		public virtual void Initialize(string sourceName, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2040", Offset = "0x6EE1240", VA = "0x186EE2040", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "9")]
		public DataRecord GenerateRecord(string recordDirPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2290", Offset = "0x6EE1490", VA = "0x186EE2290", Slot = "20")]
		public virtual void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1CF0", Offset = "0x6EE0EF0", VA = "0x186EE1CF0", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2140", Offset = "0x6EE1340", VA = "0x186EE2140", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2370", Offset = "0x6EE1570", VA = "0x186EE2370", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2990", Offset = "0x6EE1B90", VA = "0x186EE2990", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x35BE8E0", Offset = "0x35BDAE0", VA = "0x1835BE8E0", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x35BF3B0", Offset = "0x35BE5B0", VA = "0x1835BF3B0", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x35BDAD0", Offset = "0x35BCCD0", VA = "0x1835BDAD0", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x35BED80", Offset = "0x35BDF80", VA = "0x1835BED80", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T itemValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "21")]
		protected virtual void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2220", Offset = "0x6EE1420", VA = "0x186EE2220")]
		public static string ResolveNameWithRuntimeId(string sourceName, int runtimeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2A30", Offset = "0x6EE1C30", VA = "0x186EE2A30")]
		protected BaseDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DataBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeReference]
		private List<IBinder> binders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool bindingDone;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6EE61D0", Offset = "0x6EE53D0", VA = "0x186EE61D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6EE63F0", Offset = "0x6EE55F0", VA = "0x186EE63F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6030", Offset = "0x6EE5230", VA = "0x186EE6030")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5E90", Offset = "0x6EE5090", VA = "0x186EE5E90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5DE0", Offset = "0x6EE4FE0", VA = "0x186EE5DE0")]
		public void AddBinder(IBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6380", Offset = "0x6EE5580", VA = "0x186EE6380")]
		public void ReplaceBinderAtIndex(IBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public DataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum DataPermissions : uint
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		ReadOnly,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		ReadWrite
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IDataItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Initialize(int id, string name, DataPermissions permissions, string comment = "");

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RaiseValueChanged();

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SyncItemWithSource();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class DataItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		protected int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "4")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public virtual DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(DataPermissions);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20", Slot = "18")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7840", Offset = "0x6EE6A40", VA = "0x186EE7840", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6930", Offset = "0x6EE5B30", VA = "0x186EE6930", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract void SyncItemWithSource();

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE78A0", Offset = "0x6EE6AA0", VA = "0x186EE78A0")]
		protected DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate T DataItemGetter<T>();
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void DataItemSetter<T>(T val);
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class DataItem<T> : DataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected DataItemGetter<T> valueGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected DataItemSetter<T> valueSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private UnityEvent<T> setUnderlyingValue;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6A95520", Offset = "0x6A94720", VA = "0x186A95520", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6A95790", Offset = "0x6A94990", VA = "0x186A95790")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6A963C0", Offset = "0x6A955C0", VA = "0x186A963C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "20")]
		public override void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A935A0", Offset = "0x6A927A0", VA = "0x186A935A0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A94E80", Offset = "0x6A94080", VA = "0x186A94E80", Slot = "22")]
		public override void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A94D20", Offset = "0x6A93F20", VA = "0x186A94D20")]
		public void SetGetterAndSetter(DataItemGetter<T> getter, DataItemSetter<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A92890", Offset = "0x6A91A90", VA = "0x186A92890")]
		private void OnSetValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A952D0", Offset = "0x6A944D0", VA = "0x186A952D0")]
		public DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class DataItemInt : DataItem<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE68F0", Offset = "0x6EE5AF0", VA = "0x186EE68F0")]
		public DataItemInt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DataItemLong : DataItem<long>
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6A60", Offset = "0x6EE5C60", VA = "0x186EE6A60")]
		public DataItemLong()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class DataItemFloat : DataItem<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE68B0", Offset = "0x6EE5AB0", VA = "0x186EE68B0")]
		public DataItemFloat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DataItemBool : DataItem<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6830", Offset = "0x6EE5A30", VA = "0x186EE6830")]
		public DataItemBool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DataItemString : DataItem<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6B20", Offset = "0x6EE5D20", VA = "0x186EE6B20")]
		public DataItemString()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DataItemColor : DataItem<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6870", Offset = "0x6EE5A70", VA = "0x186EE6870")]
		public DataItemColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class DataItemMaterial : DataItem<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6AA0", Offset = "0x6EE5CA0", VA = "0x186EE6AA0")]
		public DataItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class DataItemSprite : DataItem<Sprite>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6AE0", Offset = "0x6EE5CE0", VA = "0x186EE6AE0")]
		public DataItemSprite()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DataItemTexture : DataItem<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6B60", Offset = "0x6EE5D60", VA = "0x186EE6B60")]
		public DataItemTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class DataItemVector2 : DataItem<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7780", Offset = "0x6EE6980", VA = "0x186EE7780")]
		public DataItemVector2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DataItemVector3 : DataItem<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE77C0", Offset = "0x6EE69C0", VA = "0x186EE77C0")]
		public DataItemVector3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DataItemVector4 : DataItem<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7800", Offset = "0x6EE6A00", VA = "0x186EE7800")]
		public DataItemVector4()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DataItemList : DataItem<DataList>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6950", Offset = "0x6EE5B50", VA = "0x186EE6950", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6930", Offset = "0x6EE5B30", VA = "0x186EE6930")]
		private void RaiseListChanged(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6A20", Offset = "0x6EE5C20", VA = "0x186EE6A20")]
		public DataItemList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DataItemAction : DataItem<Action>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Action dataAction;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE65C0", Offset = "0x6EE57C0", VA = "0x186EE65C0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6750", Offset = "0x6EE5950", VA = "0x186EE6750")]
		public void SetAction(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		private Action GetAction()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE67F0", Offset = "0x6EE59F0", VA = "0x186EE67F0")]
		public DataItemAction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private string listName;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> ListUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8080", Offset = "0x6EE7280", VA = "0x186EE8080")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8130", Offset = "0x6EE7330", VA = "0x186EE8130")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8010", Offset = "0x6EE7210", VA = "0x186EE8010")]
		public DataList(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7FF0", Offset = "0x6EE71F0", VA = "0x186EE7FF0")]
		protected void OnListUpdated()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DataList<T> : DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private List<T> dataList;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x4A27E70", Offset = "0x4A27070", VA = "0x184A27E70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T this[int key]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C6A80", Offset = "0x52C5C80", VA = "0x1852C6A80")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6A98520", Offset = "0x6A97720", VA = "0x186A98520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A98390", Offset = "0x6A97590", VA = "0x186A98390")]
		public DataList(string listName, int capacity = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A97380", Offset = "0x6A96580", VA = "0x186A97380")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A97320", Offset = "0x6A96520", VA = "0x186A97320")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A97450", Offset = "0x6A96650", VA = "0x186A97450")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A974B0", Offset = "0x6A966B0", VA = "0x186A974B0")]
		public void Set(IReadOnlyList<T> list)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[DisallowMultipleComponent]
	public class DataListItemBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private List<BaseLocalViewModel> localViewModelList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int pendingLoadableCount;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<DataListItemBinder, int> ItemLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7D30", Offset = "0x6EE6F30", VA = "0x186EE7D30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7E90", Offset = "0x6EE7090", VA = "0x186EE7E90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<DataListItemBinder, int> ItemUnloaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7DE0", Offset = "0x6EE6FE0", VA = "0x186EE7DE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7F40", Offset = "0x6EE7140", VA = "0x186EE7F40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7AE0", Offset = "0x6EE6CE0", VA = "0x186EE7AE0")]
		public void SetData(int sourceId, int listId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7900", Offset = "0x6EE6B00", VA = "0x186EE7900")]
		public void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7A10", Offset = "0x6EE6C10", VA = "0x186EE7A10")]
		private void OnItemLoaded(ILoadable item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x179A700", Offset = "0x1799900", VA = "0x18179A700")]
		public DataListItemBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DataRecordItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Permissions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE81E0", Offset = "0x6EE73E0", VA = "0x186EE81E0")]
		public DataRecordItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class DataRecord : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int SourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public bool ExtraDataRequiredAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private List<DataRecordItem> dataItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Dictionary<int, DataRecordItem> itemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Dictionary<string, int> itemNameToIdMap;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6EE96C0", Offset = "0x6EE88C0", VA = "0x186EE96C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE87F0", Offset = "0x6EE79F0", VA = "0x186EE87F0")]
		internal void PopulateRecord(int sourceId, string sourceName, string sourceType, bool idModifiedAtRuntime, List<IDataItem> itemList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE82D0", Offset = "0x6EE74D0", VA = "0x186EE82D0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8660", Offset = "0x6EE7860", VA = "0x186EE8660")]
		public void PopulateItemNameList(List<string> itemNames, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE84B0", Offset = "0x6EE76B0", VA = "0x186EE84B0")]
		public void PopulateItemNameListForType(List<string> itemNames, string typeString, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9030", Offset = "0x6EE8230", VA = "0x186EE9030")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE91A0", Offset = "0x6EE83A0", VA = "0x186EE91A0")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9320", Offset = "0x6EE8520", VA = "0x186EE9320")]
		public bool TryGetPermissionsForId(int id, [Out] DataPermissions permissions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8EB0", Offset = "0x6EE80B0", VA = "0x186EE8EB0")]
		public bool TryGetCommentForId(int id, [Out] string comment)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE94C0", Offset = "0x6EE86C0", VA = "0x186EE94C0")]
		public bool TryGetTypeForId(int id, [Out] string typeString)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8290", Offset = "0x6EE7490", VA = "0x186EE8290")]
		public bool ArePermissionsCompatible(int itemId, DataPermissions permissionLevel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9640", Offset = "0x6EE8840", VA = "0x186EE9640")]
		public DataRecord()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class DataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int fullSourceId;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6EE1BA0", Offset = "0x6EE0DA0", VA = "0x186EE1BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA240", Offset = "0x6EE9440", VA = "0x186EEA240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA380", Offset = "0x6EE9580", VA = "0x186EEA380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA650", Offset = "0x6EE9850", VA = "0x186EEA650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA290", Offset = "0x6EE9490", VA = "0x186EEA290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA450", Offset = "0x6EE9650", VA = "0x186EEA450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA530", Offset = "0x6EE9730", VA = "0x186EEA530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC129A0", Offset = "0xC11BA0", VA = "0x180C129A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xC11FD0", Offset = "0xC111D0", VA = "0x180C11FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA1A0", Offset = "0x6EE93A0", VA = "0x186EEA1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA5B0", Offset = "0x6EE97B0", VA = "0x186EEA5B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE98C0", Offset = "0x6EE8AC0", VA = "0x186EE98C0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9700", Offset = "0x6EE8900", VA = "0x186EE9700")]
		public void Subscribe(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA040", Offset = "0x6EE9240", VA = "0x186EEA040")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE97F0", Offset = "0x6EE89F0", VA = "0x186EE97F0")]
		public bool TryGetBindingInfo([Out] int sourceId, [Out] int itemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x36784B0", Offset = "0x36776B0", VA = "0x1836784B0")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3678810", Offset = "0x3677A10", VA = "0x183678810")]
		public bool TrySetData<T>(T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xF1DBA0", Offset = "0xF1CDA0", VA = "0x180F1DBA0", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9850", Offset = "0x6EE8A50", VA = "0x186EE9850")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9B00", Offset = "0x6EE8D00", VA = "0x186EE9B00")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9C20", Offset = "0x6EE8E20", VA = "0x186EE9C20")]
		private bool TryResolveDataSourceInstance()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA120", Offset = "0x6EE9320", VA = "0x186EEA120")]
		public DataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class DataSourceManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class PendingSubscription
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public int DataItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public DataItemUpdate OnUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public PendingSubscription()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static DataSourceManager _instance;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<int, IDataSource> dataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static Dictionary<int, List<PendingSubscription>> pendingSubscriptons;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static DataSourceManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6EEB130", Offset = "0x6EEA330", VA = "0x186EEB130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA720", Offset = "0x6EE9920", VA = "0x186EEA720")]
		public static void RegisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAE20", Offset = "0x6EEA020", VA = "0x186EEAE20")]
		public static void UnregisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAB00", Offset = "0x6EE9D00", VA = "0x186EEAB00")]
		public static void SubscribeToItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAF40", Offset = "0x6EEA140", VA = "0x186EEAF40")]
		public static void UnsubscribeFromItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAD90", Offset = "0x6EE9F90", VA = "0x186EEAD90")]
		public static bool TryGetDataSource(int sourceId, [Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAA90", Offset = "0x6EE9C90", VA = "0x186EEAA90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public DataSourceManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void DataItemUpdate(IDataSource source, int id);
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface IDataSource
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize(string name, bool idModifiedAtRuntime);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CleanUp();

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetDataRecord(DataRecord record);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AddItem(IDataItem item);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnItemChangedInSource(int id);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SubscribeToItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UnsubscribeFromItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TryGetItem<T>(int id, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TrySetItem<T>(int id, T item);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TryGetItemAtIndex<T>(int id, int index, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool TrySetItemAtIndex<T>(int id, int index, T item);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalEnableAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum ConditionalEnableType
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			EnableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			DisableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Never
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public ConditionalEnableType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
			[CompilerGenerated]
			get
			{
				return default(ConditionalEnableType);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5C20", Offset = "0x6EE4E20", VA = "0x186EE5C20")]
		public ConditionalEnableAttribute(string conditionPropertyName, ConditionalEnableType conditionType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class ConditionalShowAsMessageAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public enum MessageType
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			Info,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string ComparisonPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			[CompilerGenerated]
			get
			{
				return default(MessageType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x13D2D70", Offset = "0x13D1F70", VA = "0x1813D2D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5CD0", Offset = "0x6EE4ED0", VA = "0x186EE5CD0")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, MessageType messageType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5C70", Offset = "0x6EE4E70", VA = "0x186EE5C70")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, int targetEnumValue, MessageType messageType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum ConditionComparisonType
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Enum
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum ConditionResultType
	{
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		ShowIfEquals,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		ShowIfNotEquals,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Never
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalVisibilityAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x13D2D70", Offset = "0x13D1F70", VA = "0x1813D2D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5D90", Offset = "0x6EE4F90", VA = "0x186EE5D90")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5D30", Offset = "0x6EE4F30", VA = "0x186EE5D30")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType, int targetEnumValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class DropdownSelectionAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string OptionsSourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string SelectedOptionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB180", Offset = "0x6EEA380", VA = "0x186EEB180")]
		public DropdownSelectionAttribute(string optionsSourcePropertyName, string selectedOptionPropertyName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface ILoadable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<ILoadable> Loaded;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class BindableActionAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3240", Offset = "0x6EE2440", VA = "0x186EE3240")]
		public BindableActionAttribute(int dataItemId, string comment = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class BindableDataAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string Comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DataPermissions Permissions;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE32D0", Offset = "0x6EE24D0", VA = "0x186EE32D0")]
		public BindableDataAttribute(int dataItemId, string comment = "", DataPermissions permissions = DataPermissions.ReadWrite)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ViewModelAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public ViewModelAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class BaseGlobalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2A80", Offset = "0x6EE1C80", VA = "0x186EE2A80")]
		public BaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class BaseLocalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected int indexInList;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected virtual DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2B00", Offset = "0x6EE1D00", VA = "0x186EE2B00", Slot = "14")]
		public virtual void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2AD0", Offset = "0x6EE1CD0", VA = "0x186EE2AD0", Slot = "15")]
		public virtual void ClearBindingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2BE0", Offset = "0x6EE1DE0", VA = "0x186EE2BE0")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2C90", Offset = "0x6EE1E90", VA = "0x186EE2C90")]
		private void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2D40", Offset = "0x6EE1F40", VA = "0x186EE2D40")]
		protected BaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public abstract class BaseViewModel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[HideInInspector]
		[SerializeReference]
		private List<IDataItem> dataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[HideInInspector]
		[SerializeField]
		private DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ViewModelDataSource dataSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private string recordDir;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected virtual string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3200", Offset = "0x6EE2400", VA = "0x186EE3200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2DA0", Offset = "0x6EE1FA0", VA = "0x186EE2DA0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3000", Offset = "0x6EE2200", VA = "0x186EE3000", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2E10", Offset = "0x6EE2010", VA = "0x186EE2E10", Slot = "10")]
		public virtual void InitializeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "11")]
		protected virtual void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3080", Offset = "0x6EE2280", VA = "0x186EE3080")]
		protected void OnPropertyChanged([CallerMemberName] string name = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		[ContextMenu("Update Record")]
		public void UpdateRecord()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "12")]
		protected virtual void RegisterCustomDataTypes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2A80", Offset = "0x6EE1C80", VA = "0x186EE2A80")]
		protected BaseViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class DataItemTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static Dictionary<Type, Type> dataItemTypeCache;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7230", Offset = "0x6EE6430", VA = "0x186EE7230")]
		public static void RegisterDataItemType(Type underlyingDataType, Type dataItemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7460", Offset = "0x6EE6660", VA = "0x186EE7460")]
		public static bool TryGetDataItemType(Type underlyingDataType, [Out] Type dataItemType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6BA0", Offset = "0x6EE5DA0", VA = "0x186EE6BA0")]
		private static void EnsureCacheInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6C60", Offset = "0x6EE5E60", VA = "0x186EE6C60")]
		private static void RegisterBuiltInTypes()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class ViewModelDataSource : BaseDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<string, int> itemNameToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private BaseViewModel viewModel;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3ED0", Offset = "0x6EF30D0", VA = "0x186EF3ED0")]
		internal void InitializeFromViewModel(BaseViewModel viewModel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3FC0", Offset = "0x6EF31C0", VA = "0x186EF3FC0")]
		public void LoadDataItems(List<IDataItem> dataItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4530", Offset = "0x6EF3730", VA = "0x186EF4530")]
		public void OnPropertyChanged(string propertyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6EF44D0", Offset = "0x6EF36D0", VA = "0x186EF44D0", Slot = "21")]
		protected override void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2A30", Offset = "0x6EE1C30", VA = "0x186EE2A30")]
		public ViewModelDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class ViewModelTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static Dictionary<string, Type> viewModelTypeCache;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4760", Offset = "0x6EF3960", VA = "0x186EF4760")]
		public static void RegisterViewModelType(string viewModelTypeString, Type viewModelType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4990", Offset = "0x6EF3B90", VA = "0x186EF4990")]
		public static bool TryGetViewModelType(string typeName, [Out] Type viewModelType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF46B0", Offset = "0x6EF38B0", VA = "0x186EF46B0")]
		private static void EnsureCacheInitialized()
		{
		}
	}
}
namespace MVVMDatabinding.Theming
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class BaseThemeBinder<T> : IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[ConditionalVisibility("ThemeTemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private ThemeStyle styleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private bool subscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x626CEF0", Offset = "0x626C0F0", VA = "0x18626CEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x626BAB0", Offset = "0x626ACB0", VA = "0x18626BAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x626CC20", Offset = "0x626BE20", VA = "0x18626CC20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x626B780", Offset = "0x626A980", VA = "0x18626B780", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x626C0E0", Offset = "0x626B2E0", VA = "0x18626C0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x626D140", Offset = "0x626C340", VA = "0x18626D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected bool IsBindingValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x626BBD0", Offset = "0x626ADD0", VA = "0x18626BBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x626BD60", Offset = "0x626AF60", VA = "0x18626BD60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected abstract ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6269020", Offset = "0x6268220", VA = "0x186269020", Slot = "7")]
		public void Bind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x626B1C0", Offset = "0x626A3C0", VA = "0x18626B1C0", Slot = "8")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6269E50", Offset = "0x6269050", VA = "0x186269E50", Slot = "10")]
		public void OverrideActiveStyle(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6269590", Offset = "0x6268790", VA = "0x186269590", Slot = "9")]
		public void OnThemeItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x626A000", Offset = "0x6269200", VA = "0x18626A000")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x626B400", Offset = "0x626A600", VA = "0x18626B400")]
		protected BaseThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class ColorThemeBinder : BaseThemeBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3810", Offset = "0x6EE2A10", VA = "0x186EE3810", Slot = "12")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3940", Offset = "0x6EE2B40", VA = "0x186EE3940")]
		public ColorThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ColorTokenThemeBinder : BaseThemeBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xD76DF0", Offset = "0xD75FF0", VA = "0x180D76DF0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6EE51C0", Offset = "0x6EE43C0", VA = "0x186EE51C0", Slot = "12")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5320", Offset = "0x6EE4520", VA = "0x186EE5320")]
		public ColorTokenThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class FontSettingsBinder : BaseThemeBinder<ThemeFontSettings>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDA7A10", Offset = "0xDA6C10", VA = "0x180DA7A10", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB380", Offset = "0x6EEA580", VA = "0x186EEB380", Slot = "12")]
		protected override void OnDataUpdated(ThemeFontSettings dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB4D0", Offset = "0x6EEA6D0", VA = "0x186EEB4D0")]
		public FontSettingsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class FontSizeThemeBinder : BaseThemeBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xBF3BE0", Offset = "0xBF2DE0", VA = "0x180BF3BE0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB550", Offset = "0x6EEA750", VA = "0x186EEB550", Slot = "12")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB670", Offset = "0x6EEA870", VA = "0x186EEB670")]
		public FontSizeThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Bind();

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnThemeItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OverrideActiveStyle(ThemeStyle newStyle);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class MaterialThemeBinder : BaseThemeBinder<Material>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xBC9F20", Offset = "0xBC9120", VA = "0x180BC9F20", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC610", Offset = "0x6EEB810", VA = "0x186EEC610", Slot = "12")]
		protected override void OnDataUpdated(Material dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC730", Offset = "0x6EEB930", VA = "0x186EEC730")]
		public MaterialThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class TextureThemeBinder : BaseThemeBinder<Texture>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private List<RawImage> targets;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xBDBAC0", Offset = "0xBDACC0", VA = "0x180BDBAC0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6EED620", Offset = "0x6EEC820", VA = "0x186EED620", Slot = "12")]
		protected override void OnDataUpdated(Texture dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6EED730", Offset = "0x6EEC930", VA = "0x186EED730")]
		public TextureThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class TMPGradientThemeBinder : BaseThemeBinder<TMP_ColorGradient>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD9C860", Offset = "0xD9BA60", VA = "0x180D9C860", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6EECB40", Offset = "0x6EEBD40", VA = "0x186EECB40", Slot = "12")]
		protected override void OnDataUpdated(TMP_ColorGradient dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6EECCA0", Offset = "0x6EEBEA0", VA = "0x186EECCA0")]
		public TMPGradientThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class VisibilityThemeBinder : BaseThemeBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private GameObject target;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xDA58B0", Offset = "0xDA4AB0", VA = "0x180DA58B0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4B00", Offset = "0x6EF3D00", VA = "0x186EF4B00", Slot = "12")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4BA0", Offset = "0x6EF3DA0", VA = "0x186EF4BA0")]
		public VisibilityThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum ThemeAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[InspectorName("0%")]
		Zero = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[InspectorName("5%")]
		Five = 5,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[InspectorName("10%")]
		Ten = 10,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[InspectorName("15%")]
		Fifteen = 15,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[InspectorName("20%")]
		Twenty = 20,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[InspectorName("25%")]
		TwentyFive = 25,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[InspectorName("30%")]
		Thirty = 30,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[InspectorName("40%")]
		Forty = 40,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[InspectorName("50%")]
		Fifty = 50,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[InspectorName("60%")]
		Sixty = 60,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[InspectorName("70%")]
		Seventy = 70,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[InspectorName("80%")]
		Eighty = 80,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[InspectorName("90%")]
		Ninety = 90,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[InspectorName("100%")]
		OneHundred = 100
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class ColorToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		private ThemeAlpha Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private Color? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private ThemeAlpha prevOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5750", Offset = "0x6EE4950", VA = "0x186EE5750")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE54C0", Offset = "0x6EE46C0", VA = "0x186EE54C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5890", Offset = "0x6EE4A90", VA = "0x186EE5890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x6EE59F0", Offset = "0x6EE4BF0", VA = "0x186EE59F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5470", Offset = "0x6EE4670", VA = "0x186EE5470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6EE53A0", Offset = "0x6EE45A0", VA = "0x186EE53A0")]
		private void UpdateColor(Color newColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5450", Offset = "0x6EE4650", VA = "0x186EE5450")]
		public ColorToken()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ColorTokenDefinition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Color Color;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3AB0", Offset = "0x6EE2CB0", VA = "0x186EE3AB0")]
		public ColorTokenDefinition(int id, string name, Color color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CreateAssetMenu(fileName = "ColorTokenGroup", menuName = "MVVM/Theming/Color Token Group")]
	public class ColorTokenGroup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private List<ColorTokenDefinition> colorDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private List<ColorTokenReference> colorTokenReferences;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4AC0", Offset = "0x6EE3CC0", VA = "0x186EE4AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3B60", Offset = "0x6EE2D60", VA = "0x186EE3B60")]
		public List<string> GetColorTokenNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4140", Offset = "0x6EE3340", VA = "0x186EE4140")]
		public bool TryGetColorTokenByName(string name, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3E80", Offset = "0x6EE3080", VA = "0x186EE3E80")]
		public bool TryGetColorTokenById(int id, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4720", Offset = "0x6EE3920", VA = "0x186EE4720")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4440", Offset = "0x6EE3640", VA = "0x186EE4440")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public void Editor_UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE49F0", Offset = "0x6EE3BF0", VA = "0x186EE49F0")]
		public ColorTokenGroup()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ColorTokenReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public ColorTokenDefinition ColorTokenDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4BD0", Offset = "0x6EE3DD0", VA = "0x186EE4BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4D40", Offset = "0x6EE3F40", VA = "0x186EE4D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4FB0", Offset = "0x6EE41B0", VA = "0x186EE4FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5110", Offset = "0x6EE4310", VA = "0x186EE5110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4B80", Offset = "0x6EE3D80", VA = "0x186EE4B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4B20", Offset = "0x6EE3D20", VA = "0x186EE4B20")]
		public ColorTokenReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CreateAssetMenu(fileName = "Theme", menuName = "MVVM/Theming/Theme")]
	public class Theme : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public List<ThemeStyle> ThemeStyleList;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3D60", Offset = "0x6EF2F60", VA = "0x186EF3D60")]
		public void Editor_LoadTheme()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xBC3030", Offset = "0xBC2230", VA = "0x180BC3030")]
		public Theme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ThemeBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeReference]
		private List<IThemeBinder> binders;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDA20", Offset = "0x6EECC20", VA = "0x186EEDA20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDBC0", Offset = "0x6EECDC0", VA = "0x186EEDBC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6EED7B0", Offset = "0x6EEC9B0", VA = "0x186EED7B0")]
		public void AddBinder(IThemeBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDF80", Offset = "0x6EED180", VA = "0x186EEDF80")]
		public void ReplaceBinderAtIndex(IThemeBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6EED860", Offset = "0x6EECA60", VA = "0x186EED860")]
		public void ApplyStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDD60", Offset = "0x6EECF60", VA = "0x186EEDD60")]
		public void RemoveStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public ThemeBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class ThemeDataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		protected ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private ThemeStyleApplier applier;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public ThemeStyleTemplate ThemeTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF250", Offset = "0x6EEE450", VA = "0x186EEF250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF0A0", Offset = "0x6EEE2A0", VA = "0x186EEF0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF170", Offset = "0x6EEE370", VA = "0x186EEF170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF300", Offset = "0x6EEE500", VA = "0x186EEF300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF0F0", Offset = "0x6EEE2F0", VA = "0x186EEF0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF000", Offset = "0x6EEE200", VA = "0x186EEF000")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF260", Offset = "0x6EEE460", VA = "0x186EEF260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE980", Offset = "0x6EEDB80", VA = "0x186EEE980")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE150", Offset = "0x6EED350", VA = "0x186EEE150")]
		public void Subscribe(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEC70", Offset = "0x6EEDE70", VA = "0x186EEEC70")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C13AD0", Offset = "0x3C12CD0", VA = "0x183C13AD0")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xF1E4F0", Offset = "0xF1D6F0", VA = "0x180F1E4F0", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE820", Offset = "0x6EEDA20", VA = "0x186EEE820")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE920", Offset = "0x6EEDB20", VA = "0x186EEE920")]
		private bool TryGetStyle(ThemeStyleApplier applier, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		public void SetDataType(Type dataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDFF0", Offset = "0x6EED1F0", VA = "0x186EEDFF0")]
		public void ApplyStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE0A0", Offset = "0x6EED2A0", VA = "0x186EEE0A0")]
		public void RemoveStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEF80", Offset = "0x6EEE180", VA = "0x186EEEF80")]
		public ThemeDataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class ThemeDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Dictionary<int, ThemeItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private ThemeVariant activeVariant;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x15AC340", Offset = "0x15AB540", VA = "0x1815AC340", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF3D0", Offset = "0x6EEE5D0", VA = "0x186EEF3D0", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFBB0", Offset = "0x6EEEDB0", VA = "0x186EEFBB0")]
		public bool TryGetThemeItem(int id, [Out] ThemeItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "9")]
		public DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF660", Offset = "0x6EEE860", VA = "0x186EEF660", Slot = "7")]
		public void Initialize(string name, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF600", Offset = "0x6EEE800", VA = "0x186EEF600", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF880", Offset = "0x6EEEA80", VA = "0x186EEF880")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "10")]
		public void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF720", Offset = "0x6EEE920", VA = "0x186EEF720", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFA30", Offset = "0x6EEEC30", VA = "0x186EEFA30", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFC20", Offset = "0x6EEEE20", VA = "0x186EEFC20", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C14250", Offset = "0x3C13450", VA = "0x183C14250", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C13E00", Offset = "0x3C13000", VA = "0x183C13E00", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFCC0", Offset = "0x6EEEEC0", VA = "0x186EEFCC0")]
		public ThemeDataSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class ThemeFontSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public TMP_FontAsset FontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool AutosizeFont;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfNotEquals)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MinSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MaxSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FontStyles FontStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float LineHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public float CharacterSpacing;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFDD0", Offset = "0x6EEEFD0", VA = "0x186EEFDD0")]
		public ThemeFontSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class ThemeItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ThemeVariant variant;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6EF0190", Offset = "0x6EEF390", VA = "0x186EF0190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "7")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<int> ValueChangedWithId
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x6EF00E0", Offset = "0x6EEF2E0", VA = "0x186EF00E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6EF01E0", Offset = "0x6EEF3E0", VA = "0x186EF01E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "11")]
		public void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "12")]
		public void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFDF0", Offset = "0x6EEEFF0", VA = "0x186EEFDF0", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFE30", Offset = "0x6EEF030", VA = "0x186EEFE30", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "13")]
		public void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "15")]
		public void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFE70", Offset = "0x6EEF070", VA = "0x186EEFE70")]
		public void SetThemeItemValue(ThemeStyleValue styleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0000", Offset = "0x6EEF200", VA = "0x186EF0000")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C14C50", Offset = "0x3C13E50", VA = "0x183C14C50")]
		public bool TryGetItem<T>([Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0060", Offset = "0x6EEF260", VA = "0x186EF0060")]
		public ThemeItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ThemeManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static readonly string themingSourcePrefix;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private static ThemeManager instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[SerializeField]
		private List<Theme> defaultThemeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Dictionary<int, ThemeDataSource> themeDataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public static bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6EF0F90", Offset = "0x6EF0190", VA = "0x186EF0F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public static ThemeManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6EF0F40", Offset = "0x6EF0140", VA = "0x186EF0F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public ThemeVariant ActiveVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event Action ThemeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6EF0E50", Offset = "0x6EF0050", VA = "0x186EF0E50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6EF1010", Offset = "0x6EF0210", VA = "0x186EF1010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0440", Offset = "0x6EEF640", VA = "0x186EF0440")]
		public static int GetThemeSourceId(string recordName)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0290", Offset = "0x6EEF490", VA = "0x186EF0290")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0C00", Offset = "0x6EEFE00", VA = "0x186EF0C00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0A00", Offset = "0x6EEFC00", VA = "0x186EF0A00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0550", Offset = "0x6EEF750", VA = "0x186EF0550")]
		public void LoadTheme(Theme theme)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0300", Offset = "0x6EEF500", VA = "0x186EF0300")]
		public void ChangeThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EF04C0", Offset = "0x6EEF6C0", VA = "0x186EF04C0")]
		public bool IsStyleLoaded(ThemeStyle themeStyle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0DC0", Offset = "0x6EEFFC0", VA = "0x186EF0DC0")]
		public ThemeManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum ThemeVariant
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Dark,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		HighContrast
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface IThemeValue
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetVariant(ThemeVariant variant);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public abstract class ThemeValue : IThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[HideInInspector]
		[SerializeField]
		protected bool excludedFromVariants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		protected bool referenceStyleValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected ThemeStyle themeStyleReference;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected ThemeVariant activeVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected bool ShowVariantValues
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3D40", Offset = "0x6EF2F40", VA = "0x186EF3D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool ShowSingleValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3D20", Offset = "0x6EF2F20", VA = "0x186EF3D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3C80", Offset = "0x6EF2E80", VA = "0x186EF3C80", Slot = "8")]
		public void SetVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3CA0", Offset = "0x6EF2EA0", VA = "0x186EF3CA0")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class ThemeValue<T> : ThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T dark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T highContrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[ConditionalVisibility("ShowSingleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private ThemeValue<T> cachedReferenceValue;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x599FF00", Offset = "0x599F100", VA = "0x18599FF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x59A1E30", Offset = "0x59A1030", VA = "0x1859A1E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x59A5990", Offset = "0x59A4B90", VA = "0x1859A5990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x59A4A30", Offset = "0x59A3C30", VA = "0x1859A4A30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x599EDB0", Offset = "0x599DFB0", VA = "0x18599EDB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x599D530", Offset = "0x599C730", VA = "0x18599D530")]
		private bool HasCircularDependency(ThemeValue<T> themeValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599DE70", VA = "0x18599EC70")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ColorThemeValue : ThemeValue<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3980", Offset = "0x6EE2B80", VA = "0x186EE3980")]
		public ColorThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class GradientThemeValue : ThemeValue<Gradient>
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6EEBFD0", Offset = "0x6EEB1D0", VA = "0x186EEBFD0")]
		public GradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class MaterialThemeValue : ThemeValue<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC770", Offset = "0x6EEB970", VA = "0x186EEC770")]
		public MaterialThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class TextureThemeValue : ThemeValue<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6EED770", Offset = "0x6EEC970", VA = "0x186EED770")]
		public TextureThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class IntThemeValue : ThemeValue<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC240", Offset = "0x6EEB440", VA = "0x186EEC240")]
		public IntThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class FloatThemeValue : ThemeValue<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB340", Offset = "0x6EEA540", VA = "0x186EEB340")]
		public FloatThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class Vector4ThemeValue : ThemeValue<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3E90", Offset = "0x6EF3090", VA = "0x186EF3E90")]
		public Vector4ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TMPGradientThemeValue : ThemeValue<TMP_ColorGradient>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6EECCE0", Offset = "0x6EEBEE0", VA = "0x186EECCE0")]
		public TMPGradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class FontSettingsThemeValue : ThemeValue<ThemeFontSettings>
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6EEB510", Offset = "0x6EEA710", VA = "0x186EEB510")]
		public FontSettingsThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class BoolThemeValue : ThemeValue<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3370", Offset = "0x6EE2570", VA = "0x186EE3370")]
		public BoolThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ColorTokenValue : ThemeValue<ColorToken>
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5360", Offset = "0x6EE4560", VA = "0x186EE5360")]
		public ColorTokenValue()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ThemeStyleValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeItemType itemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeReference]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool ThemeRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3A80", Offset = "0x6EF2C80", VA = "0x186EF3A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF38C0", Offset = "0x6EF2AC0", VA = "0x186EF38C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3940", Offset = "0x6EF2B40", VA = "0x186EF3940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3AD0", Offset = "0x6EF2CD0", VA = "0x186EF3AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public IThemeValue ThemeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3470", Offset = "0x6EF2670", VA = "0x186EF3470")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3560", Offset = "0x6EF2760", VA = "0x186EF3560")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3580", Offset = "0x6EF2780", VA = "0x186EF3580")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6EF33F0", Offset = "0x6EF25F0", VA = "0x186EF33F0")]
		public void Editor_SetTemplate(ThemeStyleTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
		public bool Editor_OnValidate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public void UpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x10B44E0", Offset = "0x10B36E0", VA = "0x1810B44E0")]
		public void ResetAndUpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3860", Offset = "0x6EF2A60", VA = "0x186EF3860")]
		public ThemeStyleValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CreateAssetMenu(fileName = "ThemeStyle", menuName = "MVVM/Theming/Theme Style")]
	public class ThemeStyle : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private string styleName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private List<ThemeStyleValue> themeStyleValues;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public string StyleName
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public ThemeStyleTemplate Template
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public List<ThemeStyleValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3BD0", Offset = "0x6EF2DD0", VA = "0x186EF3BD0")]
		public ThemeStyle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ThemeStylePicker
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private const string noStylesMatchingTemplateAvailableMessage = "<No styles of template {0} found>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[ConditionalVisibility("TemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("StyleNameOptions", "SelectedItemName")]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private Dictionary<string, ThemeStyle> cachedStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<string> styleNameOptions;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		protected bool TemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6EF25F0", Offset = "0x6EF17F0", VA = "0x186EF25F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public List<string> StyleNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x6EF23F0", Offset = "0x6EF15F0", VA = "0x186EF23F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2640", Offset = "0x6EF1840", VA = "0x186EF2640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2280", Offset = "0x6EF1480", VA = "0x186EF2280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x6EF27B0", Offset = "0x6EF19B0", VA = "0x186EF27B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public ThemeStyle Style
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public bool Editor_Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xA54670", Offset = "0xA53870", VA = "0x180A54670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		internal event Action<ThemeStylePicker> ThemeStyleChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x6EF21D0", Offset = "0x6EF13D0", VA = "0x186EF21D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2700", Offset = "0x6EF1900", VA = "0x186EF2700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF20B0", Offset = "0x6EF12B0", VA = "0x186EF20B0")]
		internal void Editor_OnValidate(string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private void Editor_PopulateStyleNameOptions([Optional] string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2140", Offset = "0x6EF1340", VA = "0x186EF2140")]
		public ThemeStylePicker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ThemeStyleApplier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private List<ThemeStylePicker> themeStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private HashSet<ThemeStyle> styleOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private IReadOnlyList<ThemeBinder> runtimeBinders;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ThemeStyle> StyleOverrideApplied
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF1DF0", Offset = "0x6EF0FF0", VA = "0x186EF1DF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x6EF1F50", Offset = "0x6EF1150", VA = "0x186EF1F50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ThemeStyle> StyleOverrideRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF1EA0", Offset = "0x6EF10A0", VA = "0x186EF1EA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2000", Offset = "0x6EF1200", VA = "0x186EF2000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6EF18C0", Offset = "0x6EF0AC0", VA = "0x186EF18C0")]
		public bool TryFindStyleForItem(ThemeStyleTemplate template, int itemId, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1100", Offset = "0x6EF0300", VA = "0x186EF1100")]
		public void ApplyRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1670", Offset = "0x6EF0870", VA = "0x186EF1670")]
		public void RemoveRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1D60", Offset = "0x6EF0F60", VA = "0x186EF1D60")]
		public ThemeStyleApplier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum ThemeItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Gradient,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Material,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Vector4,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		TMPGradient,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		FontSettings,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		ColorToken
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CreateAssetMenu(fileName = "ThemeStyleTemplate", menuName = "MVVM/Theming/Theme Style Template")]
	public class ThemeStyleTemplate : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public class ThemeTemplateItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
			public int Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public ThemeItemType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public bool ExcludeFromVariants;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3C20", Offset = "0x6EF2E20", VA = "0x186EF3C20")]
			public ThemeTemplateItem()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private List<ThemeTemplateItem> templateItems;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public List<ThemeTemplateItem> TemplateItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x6EF33B0", Offset = "0x6EF25B0", VA = "0x186EF33B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2880", Offset = "0x6EF1A80", VA = "0x186EF2880")]
		public static ThemeItemType GetThemeItemType(Type targetType)
		{
			return default(ThemeItemType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2F20", Offset = "0x6EF2120", VA = "0x186EF2F20")]
		public void PopulateItemNameList(List<string> itemNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2C70", Offset = "0x6EF1E70", VA = "0x186EF2C70")]
		public void PopulateItemNameListForType(List<string> itemNames, ThemeItemType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2DC0", Offset = "0x6EF1FC0", VA = "0x186EF2DC0")]
		public void PopulateItemNameListForType(List<string> itemNames, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3210", Offset = "0x6EF2410", VA = "0x186EF3210")]
		public bool TryGetInfoForName(string name, [Out] int id, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3050", Offset = "0x6EF2250", VA = "0x186EF3050")]
		public bool TryGetInfoForId(int id, [Out] string name, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xBC3030", Offset = "0xBC2230", VA = "0x180BC3030")]
		public ThemeStyleTemplate()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class HKJKGJGAGLN
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKJKGJGAGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC010", Offset = "0x6EEB210", VA = "0x186EEC010")]
	public static string HBPFEGFMEGC(byte[] GOKBGOMFIIG, byte[] BEJBCBEBEAC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
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
