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
			[Cpp2IlInjected.Address(RVA = "0x6F588E0", Offset = "0x6F572E0", VA = "0x186F588E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6F58410", Offset = "0x6F56E10", VA = "0x186F58410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6F584A0", Offset = "0x6F56EA0", VA = "0x186F584A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6F585E0", Offset = "0x6F56FE0", VA = "0x186F585E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6F58970", Offset = "0x6F57370", VA = "0x186F58970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6F584F0", Offset = "0x6F56EF0", VA = "0x186F584F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6F588F0", Offset = "0x6F572F0", VA = "0x186F588F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F58890", Offset = "0x6F57290", VA = "0x186F58890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected virtual DataPermissions PermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "12")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "13")]
		public virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F57770", Offset = "0x6F56170", VA = "0x186F57770", Slot = "14")]
		public virtual void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F57860", Offset = "0x6F56260", VA = "0x186F57860", Slot = "15")]
		public virtual void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F58290", Offset = "0x6F56C90", VA = "0x186F58290", Slot = "16")]
		public virtual void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F579C0", Offset = "0x6F563C0", VA = "0x186F579C0")]
		protected void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F58290", Offset = "0x6F56C90", VA = "0x186F58290")]
		protected void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract void OnDataItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F57AA0", Offset = "0x6F564A0", VA = "0x186F57AA0")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F57DD0", Offset = "0x6F567D0", VA = "0x186F57DD0")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F57B30", Offset = "0x6F56530", VA = "0x186F57B30")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F58240", Offset = "0x6F56C40", VA = "0x186F58240", Slot = "18")]
		protected virtual void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F578C0", Offset = "0x6F562C0", VA = "0x186F578C0", Slot = "19")]
		protected virtual string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F578F0", Offset = "0x6F562F0", VA = "0x186F578F0")]
		protected string GetUnavailableItemMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F57880", Offset = "0x6F56280", VA = "0x186F57880")]
		protected string GetInvalidPermissionsMessage(string itemName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F57960", Offset = "0x6F56360", VA = "0x186F57960")]
		protected void LogDataUpdateError(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void Editor_SetComment(string commentStr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		protected void Editor_UpdateBinderName(string itemName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F58370", Offset = "0x6F56D70", VA = "0x186F58370")]
		protected BaseBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class BaseBinder<T> : BaseBinder
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6209380", Offset = "0x6207D80", VA = "0x186209380", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6209EF0", Offset = "0x62088F0", VA = "0x186209EF0")]
		protected void TrySetDataValue(T dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6209C20", Offset = "0x6208620", VA = "0x186209C20", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6208E50", Offset = "0x6207850", VA = "0x186208E50", Slot = "19")]
		protected override string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x620A4A0", Offset = "0x6208EA0", VA = "0x18620A4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F5A140", Offset = "0x6F58B40", VA = "0x186F5A140", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A3A0", Offset = "0x6F58DA0", VA = "0x186F5A3A0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A230", Offset = "0x6F58C30", VA = "0x186F5A230")]
		protected void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A480", Offset = "0x6F58E80", VA = "0x186F5A480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F5A4C0", Offset = "0x6F58EC0", VA = "0x186F5A4C0", Slot = "20")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A560", Offset = "0x6F58F60", VA = "0x186F5A560")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F5A750", Offset = "0x6F59150", VA = "0x186F5A750", Slot = "20")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A800", Offset = "0x6F59200", VA = "0x186F5A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F5C8A0", Offset = "0x6F5B2A0", VA = "0x186F5C8A0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C9D0", Offset = "0x6F5B3D0", VA = "0x186F5C9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F62110", Offset = "0x6F60B10", VA = "0x186F62110", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F62240", Offset = "0x6F60C40", VA = "0x186F62240")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F62B80", Offset = "0x6F61580", VA = "0x186F62B80", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F625F0", Offset = "0x6F60FF0", VA = "0x186F625F0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F62A80", Offset = "0x6F61480", VA = "0x186F62A80")]
		private void SetFormattedData(string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F62E10", Offset = "0x6F61810", VA = "0x186F62E10")]
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
	public class ImageBinder : BaseBinder<Sprite>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F63030", Offset = "0x6F61A30", VA = "0x186F63030", Slot = "20")]
		protected override void OnDataUpdated(Sprite dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6F630C0", Offset = "0x6F61AC0", VA = "0x186F630C0")]
		public ImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IndentBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private RectTransform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private float indentSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private float? defaultIndent;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F63100", Offset = "0x6F61B00", VA = "0x186F63100", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F63220", Offset = "0x6F61C20", VA = "0x186F63220")]
		public IndentBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LayoutElementSizeBinder : BaseBinder<float>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum LayoutElementSizeTarget
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			MinWidth,
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			MinHeight,
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			PreferredWidth,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			PreferredHeight,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			FlexWidth,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			FlexHeight
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F632A0", Offset = "0x6F61CA0", VA = "0x186F632A0", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F633A0", Offset = "0x6F61DA0", VA = "0x186F633A0", Slot = "20")]
		protected override void OnDataUpdated(float dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6F635F0", Offset = "0x6F61FF0", VA = "0x186F635F0")]
		public LayoutElementSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ScrollRectEnabledBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private bool invertState;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F637D0", Offset = "0x6F621D0", VA = "0x186F637D0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F63870", Offset = "0x6F62270", VA = "0x186F63870")]
		public ScrollRectEnabledBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class SpriteBinder : BaseBinder<Sprite>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private bool invisibleIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool deactivateIfNull;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F638B0", Offset = "0x6F622B0", VA = "0x186F638B0", Slot = "20")]
		protected override void OnDataUpdated(Sprite dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F639F0", Offset = "0x6F623F0", VA = "0x186F639F0")]
		public SpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SpriteSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Sprite trueSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private Sprite falseSprite;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F63A30", Offset = "0x6F62430", VA = "0x186F63A30", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F63AD0", Offset = "0x6F624D0", VA = "0x186F63AD0")]
		public SpriteSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class StringSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private string trueString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private string falseString;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F63B10", Offset = "0x6F62510", VA = "0x186F63B10", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F63BB0", Offset = "0x6F625B0", VA = "0x186F63BB0")]
		public StringSwapBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class TextBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfEquals, 0)]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfNotEquals, 0)]
		[SerializeField]
		private TMP_InputField textInput;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override DataPermissions PermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x21EF300", Offset = "0x21EDD00", VA = "0x1821EF300", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E20", Offset = "0x6F62820", VA = "0x186F63E20", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F64180", Offset = "0x6F62B80", VA = "0x186F64180", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F63F30", Offset = "0x6F62930", VA = "0x186F63F30", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F64020", Offset = "0x6F62A20", VA = "0x186F64020")]
		private void OnTextEdited(string textData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F64280", Offset = "0x6F62C80", VA = "0x186F64280")]
		public TextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class TextureBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private RawImage target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private bool invisibleIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private bool deactivateIfNull;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F64580", Offset = "0x6F62F80", VA = "0x186F64580", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6F642C0", Offset = "0x6F62CC0", VA = "0x186F642C0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x620A4A0", Offset = "0x6208EA0", VA = "0x18620A4A0")]
		public TextureBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class VisibilityBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private GameObject targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[Tooltip("If invert is false, target will show when value is true.\nIf invert is true, target will show when value is false.")]
		private bool invertVisibility;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BC50", Offset = "0x6F6A650", VA = "0x186F6BC50", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BCF0", Offset = "0x6F6A6F0", VA = "0x186F6BCF0")]
		public VisibilityBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class BaseDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected Dictionary<int, IDataItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7C0", Offset = "0xA091C0", VA = "0x180A0A7C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xE06CF0", Offset = "0xE056F0", VA = "0x180E06CF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F58DE0", Offset = "0x6F577E0", VA = "0x186F58DE0", Slot = "19")]
		public virtual void Initialize(string sourceName, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F58D80", Offset = "0x6F57780", VA = "0x186F58D80", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "9")]
		public DataRecord GenerateRecord(string recordDirPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F58FD0", Offset = "0x6F579D0", VA = "0x186F58FD0", Slot = "20")]
		public virtual void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6F58A30", Offset = "0x6F57430", VA = "0x186F58A30", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6F58E80", Offset = "0x6F57880", VA = "0x186F58E80", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6F590B0", Offset = "0x6F57AB0", VA = "0x186F590B0", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F59720", Offset = "0x6F58120", VA = "0x186F59720", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x37F9200", Offset = "0x37F7C00", VA = "0x1837F9200", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x37F9D60", Offset = "0x37F8760", VA = "0x1837F9D60", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x37F8490", Offset = "0x37F6E90", VA = "0x1837F8490", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x37F9770", Offset = "0x37F8170", VA = "0x1837F9770", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T itemValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "21")]
		protected virtual void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F58F60", Offset = "0x6F57960", VA = "0x186F58F60")]
		public static string ResolveNameWithRuntimeId(string sourceName, int runtimeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F597C0", Offset = "0x6F581C0", VA = "0x186F597C0")]
		protected BaseDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DataBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeReference]
		private List<IBinder> binders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool bindingDone;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D020", Offset = "0x6F5BA20", VA = "0x186F5D020")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D240", Offset = "0x6F5BC40", VA = "0x186F5D240")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CE80", Offset = "0x6F5B880", VA = "0x186F5CE80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CCE0", Offset = "0x6F5B6E0", VA = "0x186F5CCE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CBD0", Offset = "0x6F5B5D0", VA = "0x186F5CBD0")]
		public void AddBinder(IBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D1D0", Offset = "0x6F5BBD0", VA = "0x186F5D1D0")]
		public void ReplaceBinderAtIndex(IBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public DataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum DataPermissions : uint
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		ReadOnly,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		ReadWrite
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface IDataItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Initialize(int id, string name, DataPermissions permissions, string comment = "");

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RaiseValueChanged();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SyncItemWithSource();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class DataItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		protected int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110", Slot = "4")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public virtual DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(DataPermissions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560", Slot = "18")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E6A0", Offset = "0x6F5D0A0", VA = "0x186F5E6A0", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D780", Offset = "0x6F5C180", VA = "0x186F5D780", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract void SyncItemWithSource();

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E700", Offset = "0x6F5D100", VA = "0x186F5E700")]
		protected DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate T DataItemGetter<T>();
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void DataItemSetter<T>(T val);
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DataItem<T> : DataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		protected DataItemGetter<T> valueGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		protected DataItemSetter<T> valueSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private UnityEvent<T> setUnderlyingValue;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4266590", Offset = "0x4264F90", VA = "0x184266590", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x4266810", Offset = "0x4265210", VA = "0x184266810")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x42671C0", Offset = "0x4265BC0", VA = "0x1842671C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
		public override void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x42645B0", Offset = "0x4262FB0", VA = "0x1842645B0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4265F90", Offset = "0x4264990", VA = "0x184265F90", Slot = "22")]
		public override void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4265E70", Offset = "0x4264870", VA = "0x184265E70")]
		public void SetGetterAndSetter(DataItemGetter<T> getter, DataItemSetter<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4263740", Offset = "0x4262140", VA = "0x184263740")]
		private void OnSetValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4266280", Offset = "0x4264C80", VA = "0x184266280")]
		public DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class DataItemInt : DataItem<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D740", Offset = "0x6F5C140", VA = "0x186F5D740")]
		public DataItemInt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DataItemLong : DataItem<long>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D8B0", Offset = "0x6F5C2B0", VA = "0x186F5D8B0")]
		public DataItemLong()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DataItemFloat : DataItem<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D700", Offset = "0x6F5C100", VA = "0x186F5D700")]
		public DataItemFloat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DataItemBool : DataItem<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D680", Offset = "0x6F5C080", VA = "0x186F5D680")]
		public DataItemBool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class DataItemString : DataItem<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D970", Offset = "0x6F5C370", VA = "0x186F5D970")]
		public DataItemString()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class DataItemColor : DataItem<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D6C0", Offset = "0x6F5C0C0", VA = "0x186F5D6C0")]
		public DataItemColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DataItemMaterial : DataItem<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D8F0", Offset = "0x6F5C2F0", VA = "0x186F5D8F0")]
		public DataItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class DataItemSprite : DataItem<Sprite>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D930", Offset = "0x6F5C330", VA = "0x186F5D930")]
		public DataItemSprite()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DataItemTexture : DataItem<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D9B0", Offset = "0x6F5C3B0", VA = "0x186F5D9B0")]
		public DataItemTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DataItemVector2 : DataItem<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E5E0", Offset = "0x6F5CFE0", VA = "0x186F5E5E0")]
		public DataItemVector2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DataItemVector3 : DataItem<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E620", Offset = "0x6F5D020", VA = "0x186F5E620")]
		public DataItemVector3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DataItemVector4 : DataItem<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E660", Offset = "0x6F5D060", VA = "0x186F5E660")]
		public DataItemVector4()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class DataItemList : DataItem<DataList>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D7A0", Offset = "0x6F5C1A0", VA = "0x186F5D7A0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D780", Offset = "0x6F5C180", VA = "0x186F5D780")]
		private void RaiseListChanged(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D870", Offset = "0x6F5C270", VA = "0x186F5D870")]
		public DataItemList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DataItemAction : DataItem<Action>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private Action dataAction;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D410", Offset = "0x6F5BE10", VA = "0x186F5D410", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D5A0", Offset = "0x6F5BFA0", VA = "0x186F5D5A0")]
		public void SetAction(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		private Action GetAction()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D640", Offset = "0x6F5C040", VA = "0x186F5D640")]
		public DataItemAction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private string listName;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> ListUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EEE0", Offset = "0x6F5D8E0", VA = "0x186F5EEE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EF90", Offset = "0x6F5D990", VA = "0x186F5EF90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EE70", Offset = "0x6F5D870", VA = "0x186F5EE70")]
		public DataList(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EE50", Offset = "0x6F5D850", VA = "0x186F5EE50")]
		protected void OnListUpdated()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DataList<T> : DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private List<T> dataList;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<T> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x42683E0", Offset = "0x4266DE0", VA = "0x1842683E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T this[int key]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4268460", Offset = "0x4266E60", VA = "0x184268460")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x4268500", Offset = "0x4266F00", VA = "0x184268500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4268340", Offset = "0x4266D40", VA = "0x184268340")]
		public DataList(string listName, int capacity = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4267520", Offset = "0x4265F20", VA = "0x184267520")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x42674A0", Offset = "0x4265EA0", VA = "0x1842674A0")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4267580", Offset = "0x4265F80", VA = "0x184267580")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4267A30", Offset = "0x4266430", VA = "0x184267A30")]
		public void Set(IReadOnlyList<T> list)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[DisallowMultipleComponent]
	public class DataListItemBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private List<BaseLocalViewModel> localViewModelList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int pendingLoadableCount;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<DataListItemBinder, int> ItemLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EB90", Offset = "0x6F5D590", VA = "0x186F5EB90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6F5ECF0", Offset = "0x6F5D6F0", VA = "0x186F5ECF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<DataListItemBinder, int> ItemUnloaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EC40", Offset = "0x6F5D640", VA = "0x186F5EC40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EDA0", Offset = "0x6F5D7A0", VA = "0x186F5EDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E940", Offset = "0x6F5D340", VA = "0x186F5E940")]
		public void SetData(int sourceId, int listId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E760", Offset = "0x6F5D160", VA = "0x186F5E760")]
		public void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E870", Offset = "0x6F5D270", VA = "0x186F5E870")]
		private void OnItemLoaded(ILoadable item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x18FC600", Offset = "0x18FB000", VA = "0x1818FC600")]
		public DataListItemBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class DataRecordItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Permissions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F040", Offset = "0x6F5DA40", VA = "0x186F5F040")]
		public DataRecordItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class DataRecord : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int SourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public bool ExtraDataRequiredAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private List<DataRecordItem> dataItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Dictionary<int, DataRecordItem> itemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Dictionary<string, int> itemNameToIdMap;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6F605A0", Offset = "0x6F5EFA0", VA = "0x186F605A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F650", Offset = "0x6F5E050", VA = "0x186F5F650")]
		internal void PopulateRecord(int sourceId, string sourceName, string sourceType, bool idModifiedAtRuntime, List<IDataItem> itemList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F130", Offset = "0x6F5DB30", VA = "0x186F5F130")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F4C0", Offset = "0x6F5DEC0", VA = "0x186F5F4C0")]
		public void PopulateItemNameList(List<string> itemNames, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F310", Offset = "0x6F5DD10", VA = "0x186F5F310")]
		public void PopulateItemNameListForType(List<string> itemNames, string typeString, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FF10", Offset = "0x6F5E910", VA = "0x186F5FF10")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F60080", Offset = "0x6F5EA80", VA = "0x186F60080")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F60200", Offset = "0x6F5EC00", VA = "0x186F60200")]
		public bool TryGetPermissionsForId(int id, [Out] DataPermissions permissions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FD90", Offset = "0x6F5E790", VA = "0x186F5FD90")]
		public bool TryGetCommentForId(int id, [Out] string comment)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F603A0", Offset = "0x6F5EDA0", VA = "0x186F603A0")]
		public bool TryGetTypeForId(int id, [Out] string typeString)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F0F0", Offset = "0x6F5DAF0", VA = "0x186F5F0F0")]
		public bool ArePermissionsCompatible(int itemId, DataPermissions permissionLevel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F60520", Offset = "0x6F5EF20", VA = "0x186F60520")]
		public DataRecord()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class DataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int fullSourceId;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6F588E0", Offset = "0x6F572E0", VA = "0x186F588E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6F61130", Offset = "0x6F5FB30", VA = "0x186F61130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6F61270", Offset = "0x6F5FC70", VA = "0x186F61270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6F61540", Offset = "0x6F5FF40", VA = "0x186F61540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6F61180", Offset = "0x6F5FB80", VA = "0x186F61180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6F61340", Offset = "0x6F5FD40", VA = "0x186F61340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6F61420", Offset = "0x6F5FE20", VA = "0x186F61420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xC99F10", Offset = "0xC98910", VA = "0x180C99F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xC99570", Offset = "0xC97F70", VA = "0x180C99570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6F61090", Offset = "0x6F5FA90", VA = "0x186F61090")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6F614A0", Offset = "0x6F5FEA0", VA = "0x186F614A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F607A0", Offset = "0x6F5F1A0", VA = "0x186F607A0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F605E0", Offset = "0x6F5EFE0", VA = "0x186F605E0")]
		public void Subscribe(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F60F30", Offset = "0x6F5F930", VA = "0x186F60F30")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F606D0", Offset = "0x6F5F0D0", VA = "0x186F606D0")]
		public bool TryGetBindingInfo([Out] int sourceId, [Out] int itemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x38E07E0", Offset = "0x38DF1E0", VA = "0x1838E07E0")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x38E0A20", Offset = "0x38DF420", VA = "0x1838E0A20")]
		public bool TrySetData<T>(T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xF70B20", Offset = "0xF6F520", VA = "0x180F70B20", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F60730", Offset = "0x6F5F130", VA = "0x186F60730")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F609E0", Offset = "0x6F5F3E0", VA = "0x186F609E0")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F60B00", Offset = "0x6F5F500", VA = "0x186F60B00")]
		private bool TryResolveDataSourceInstance()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F61010", Offset = "0x6F5FA10", VA = "0x186F61010")]
		public DataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class DataSourceManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private class PendingSubscription
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int DataItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public DataItemUpdate OnUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public PendingSubscription()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static DataSourceManager _instance;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static Dictionary<int, IDataSource> dataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<int, List<PendingSubscription>> pendingSubscriptons;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static DataSourceManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6F62070", Offset = "0x6F60A70", VA = "0x186F62070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F61610", Offset = "0x6F60010", VA = "0x186F61610")]
		public static void RegisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F61D60", Offset = "0x6F60760", VA = "0x186F61D60")]
		public static void UnregisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F619F0", Offset = "0x6F603F0", VA = "0x186F619F0")]
		public static void SubscribeToItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F61E80", Offset = "0x6F60880", VA = "0x186F61E80")]
		public static void UnsubscribeFromItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F61CD0", Offset = "0x6F606D0", VA = "0x186F61CD0")]
		public static bool TryGetDataSource(int sourceId, [Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F61980", Offset = "0x6F60380", VA = "0x186F61980")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public DataSourceManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void DataItemUpdate(IDataSource source, int id);
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface IDataSource
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize(string name, bool idModifiedAtRuntime);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CleanUp();

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetDataRecord(DataRecord record);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AddItem(IDataItem item);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnItemChangedInSource(int id);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SubscribeToItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UnsubscribeFromItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TryGetItem<T>(int id, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TrySetItem<T>(int id, T item);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TryGetItemAtIndex<T>(int id, int index, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool TrySetItemAtIndex<T>(int id, int index, T item);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalEnableAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public enum ConditionalEnableType
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			EnableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			DisableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Never
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ConditionalEnableType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
			[CompilerGenerated]
			get
			{
				return default(ConditionalEnableType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CA10", Offset = "0x6F5B410", VA = "0x186F5CA10")]
		public ConditionalEnableAttribute(string conditionPropertyName, ConditionalEnableType conditionType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class ConditionalShowAsMessageAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public enum MessageType
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			Info,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string ComparisonPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB80", Offset = "0xA6D580", VA = "0x180A6EB80")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xF69880", Offset = "0xF68280", VA = "0x180F69880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
			[CompilerGenerated]
			get
			{
				return default(MessageType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA155E0", Offset = "0xA13FE0", VA = "0x180A155E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A900", Offset = "0xA59300", VA = "0x180A5A900")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x150B200", Offset = "0x1509C00", VA = "0x18150B200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CAC0", Offset = "0x6F5B4C0", VA = "0x186F5CAC0")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, MessageType messageType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CA60", Offset = "0x6F5B460", VA = "0x186F5CA60")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, int targetEnumValue, MessageType messageType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public enum ConditionComparisonType
	{
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Enum
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum ConditionResultType
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		ShowIfEquals,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		ShowIfNotEquals,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Never
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalVisibilityAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA16630", Offset = "0xA15030", VA = "0x180A16630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA155E0", Offset = "0xA13FE0", VA = "0x180A155E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA5A900", Offset = "0xA59300", VA = "0x180A5A900")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x150B200", Offset = "0x1509C00", VA = "0x18150B200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CB80", Offset = "0x6F5B580", VA = "0x186F5CB80")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CB20", Offset = "0x6F5B520", VA = "0x186F5CB20")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType, int targetEnumValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class DropdownSelectionAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string OptionsSourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string SelectedOptionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6F620C0", Offset = "0x6F60AC0", VA = "0x186F620C0")]
		public DropdownSelectionAttribute(string optionsSourcePropertyName, string selectedOptionPropertyName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface ILoadable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<ILoadable> Loaded;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class BindableActionAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6F59FD0", Offset = "0x6F589D0", VA = "0x186F59FD0")]
		public BindableActionAttribute(int dataItemId, string comment = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class BindableDataAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public string Comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public DataPermissions Permissions;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A060", Offset = "0x6F58A60", VA = "0x186F5A060")]
		public BindableDataAttribute(int dataItemId, string comment = "", DataPermissions permissions = DataPermissions.ReadWrite)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ViewModelAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public ViewModelAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class BaseGlobalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6F59810", Offset = "0x6F58210", VA = "0x186F59810")]
		public BaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class BaseLocalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		protected int indexInList;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected virtual DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6F59890", Offset = "0x6F58290", VA = "0x186F59890", Slot = "14")]
		public virtual void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6F59860", Offset = "0x6F58260", VA = "0x186F59860", Slot = "15")]
		public virtual void ClearBindingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6F59970", Offset = "0x6F58370", VA = "0x186F59970")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6F59A20", Offset = "0x6F58420", VA = "0x186F59A20")]
		private void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6F59AD0", Offset = "0x6F584D0", VA = "0x186F59AD0")]
		protected BaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class BaseViewModel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[HideInInspector]
		[SerializeReference]
		private List<IDataItem> dataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[HideInInspector]
		[SerializeField]
		private DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ViewModelDataSource dataSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private string recordDir;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x6F59F90", Offset = "0x6F58990", VA = "0x186F59F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected virtual List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected virtual bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6F59B30", Offset = "0x6F58530", VA = "0x186F59B30", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6F59D90", Offset = "0x6F58790", VA = "0x186F59D90", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6F59BA0", Offset = "0x6F585A0", VA = "0x186F59BA0", Slot = "10")]
		public virtual void InitializeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "11")]
		protected virtual void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6F59E10", Offset = "0x6F58810", VA = "0x186F59E10")]
		protected void OnPropertyChanged([CallerMemberName] string name = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		[ContextMenu("Update Record")]
		public void UpdateRecord()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "12")]
		protected virtual void RegisterCustomDataTypes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6F59810", Offset = "0x6F58210", VA = "0x186F59810")]
		protected BaseViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class DataItemTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static Dictionary<Type, Type> dataItemTypeCache;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E080", Offset = "0x6F5CA80", VA = "0x186F5E080")]
		public static void RegisterDataItemType(Type underlyingDataType, Type dataItemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E2C0", Offset = "0x6F5CCC0", VA = "0x186F5E2C0")]
		public static bool TryGetDataItemType(Type underlyingDataType, [Out] Type dataItemType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D9F0", Offset = "0x6F5C3F0", VA = "0x186F5D9F0")]
		private static void EnsureCacheInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DAB0", Offset = "0x6F5C4B0", VA = "0x186F5DAB0")]
		private static void RegisterBuiltInTypes()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class ViewModelDataSource : BaseDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Dictionary<string, int> itemNameToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private BaseViewModel viewModel;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B0F0", Offset = "0x6F69AF0", VA = "0x186F6B0F0")]
		internal void InitializeFromViewModel(BaseViewModel viewModel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B1E0", Offset = "0x6F69BE0", VA = "0x186F6B1E0")]
		public void LoadDataItems(List<IDataItem> dataItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B750", Offset = "0x6F6A150", VA = "0x186F6B750")]
		public void OnPropertyChanged(string propertyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B6F0", Offset = "0x6F6A0F0", VA = "0x186F6B6F0", Slot = "21")]
		protected override void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F597C0", Offset = "0x6F581C0", VA = "0x186F597C0")]
		public ViewModelDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class ViewModelTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static Dictionary<string, Type> viewModelTypeCache;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B980", Offset = "0x6F6A380", VA = "0x186F6B980")]
		public static void RegisterViewModelType(string viewModelTypeString, Type viewModelType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BBC0", Offset = "0x6F6A5C0", VA = "0x186F6BBC0")]
		public static bool TryGetViewModelType(string typeName, [Out] Type viewModelType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B8D0", Offset = "0x6F6A2D0", VA = "0x186F6B8D0")]
		private static void EnsureCacheInitialized()
		{
		}
	}
}
namespace MVVMDatabinding.Theming
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class BaseThemeBinder<T> : IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[ConditionalVisibility("ThemeTemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private ThemeStyle styleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool subscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x62F5AC0", Offset = "0x62F44C0", VA = "0x1862F5AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x62F4840", Offset = "0x62F3240", VA = "0x1862F4840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x62F57F0", Offset = "0x62F41F0", VA = "0x1862F57F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x62F4510", Offset = "0x62F2F10", VA = "0x1862F4510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x62F4DA0", Offset = "0x62F37A0", VA = "0x1862F4DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x62F5D00", Offset = "0x62F4700", VA = "0x1862F5D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected bool IsBindingValid
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x62F4960", Offset = "0x62F3360", VA = "0x1862F4960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x62F4AA0", Offset = "0x62F34A0", VA = "0x1862F4AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected abstract ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x62F2010", Offset = "0x62F0A10", VA = "0x1862F2010", Slot = "7")]
		public void Bind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x62F3F70", Offset = "0x62F2970", VA = "0x1862F3F70", Slot = "8")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x62F2D10", Offset = "0x62F1710", VA = "0x1862F2D10", Slot = "10")]
		public void OverrideActiveStyle(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x62F2550", Offset = "0x62F0F50", VA = "0x1862F2550", Slot = "9")]
		public void OnThemeItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x62F2E80", Offset = "0x62F1880", VA = "0x1862F2E80")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x62F4190", Offset = "0x62F2B90", VA = "0x1862F4190")]
		protected BaseThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class ColorThemeBinder : BaseThemeBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA62010", Offset = "0xA60A10", VA = "0x180A62010", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A5A0", Offset = "0x6F58FA0", VA = "0x186F5A5A0", Slot = "12")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A6D0", Offset = "0x6F590D0", VA = "0x186F5A6D0")]
		public ColorThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class ColorTokenThemeBinder : BaseThemeBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xDFE1D0", Offset = "0xDFCBD0", VA = "0x180DFE1D0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BFB0", Offset = "0x6F5A9B0", VA = "0x186F5BFB0", Slot = "12")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C110", Offset = "0x6F5AB10", VA = "0x186F5C110")]
		public ColorTokenThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class FontSettingsBinder : BaseThemeBinder<ThemeFontSettings>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xE22220", Offset = "0xE20C20", VA = "0x180E22220", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F622C0", Offset = "0x6F60CC0", VA = "0x186F622C0", Slot = "12")]
		protected override void OnDataUpdated(ThemeFontSettings dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F62410", Offset = "0x6F60E10", VA = "0x186F62410")]
		public FontSettingsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class FontSizeThemeBinder : BaseThemeBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xC74DD0", Offset = "0xC737D0", VA = "0x180C74DD0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F62490", Offset = "0x6F60E90", VA = "0x186F62490", Slot = "12")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F625B0", Offset = "0x6F60FB0", VA = "0x186F625B0")]
		public FontSizeThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public interface IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Bind();

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnThemeItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OverrideActiveStyle(ThemeStyle newStyle);
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class MaterialThemeBinder : BaseThemeBinder<Material>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xC51020", Offset = "0xC4FA20", VA = "0x180C51020", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F63630", Offset = "0x6F62030", VA = "0x186F63630", Slot = "12")]
		protected override void OnDataUpdated(Material dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F63750", Offset = "0x6F62150", VA = "0x186F63750")]
		public MaterialThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class TextureThemeBinder : BaseThemeBinder<Texture>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private List<RawImage> targets;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAC8220", Offset = "0xAC6C20", VA = "0x180AC8220", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F64720", Offset = "0x6F63120", VA = "0x186F64720", Slot = "12")]
		protected override void OnDataUpdated(Texture dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F64830", Offset = "0x6F63230", VA = "0x186F64830")]
		public TextureThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class TMPGradientThemeBinder : BaseThemeBinder<TMP_ColorGradient>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xE18AD0", Offset = "0xE174D0", VA = "0x180E18AD0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F63C40", Offset = "0x6F62640", VA = "0x186F63C40", Slot = "12")]
		protected override void OnDataUpdated(TMP_ColorGradient dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F63DA0", Offset = "0x6F627A0", VA = "0x186F63DA0")]
		public TMPGradientThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class VisibilityThemeBinder : BaseThemeBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private GameObject target;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xE1E4C0", Offset = "0xE1CEC0", VA = "0x180E1E4C0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BD30", Offset = "0x6F6A730", VA = "0x186F6BD30", Slot = "12")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BDD0", Offset = "0x6F6A7D0", VA = "0x186F6BDD0")]
		public VisibilityThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum ThemeAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[InspectorName("0%")]
		Zero = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[InspectorName("5%")]
		Five = 5,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[InspectorName("10%")]
		Ten = 10,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[InspectorName("15%")]
		Fifteen = 15,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[InspectorName("20%")]
		Twenty = 20,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[InspectorName("25%")]
		TwentyFive = 25,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[InspectorName("30%")]
		Thirty = 30,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[InspectorName("40%")]
		Forty = 40,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[InspectorName("50%")]
		Fifty = 50,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[InspectorName("60%")]
		Sixty = 60,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[InspectorName("70%")]
		Seventy = 70,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[InspectorName("80%")]
		Eighty = 80,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[InspectorName("90%")]
		Ninety = 90,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[InspectorName("100%")]
		OneHundred = 100
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ColorToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		private ThemeAlpha Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Color? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private ThemeAlpha prevOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6F5C540", Offset = "0x6F5AF40", VA = "0x186F5C540")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x6F5C2B0", Offset = "0x6F5ACB0", VA = "0x186F5C2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x6F5C680", Offset = "0x6F5B080", VA = "0x186F5C680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6F5C7E0", Offset = "0x6F5B1E0", VA = "0x186F5C7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x6F5C260", Offset = "0x6F5AC60", VA = "0x186F5C260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C190", Offset = "0x6F5AB90", VA = "0x186F5C190")]
		private void UpdateColor(Color newColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C240", Offset = "0x6F5AC40", VA = "0x186F5C240")]
		public ColorToken()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ColorTokenDefinition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Color Color;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A840", Offset = "0x6F59240", VA = "0x186F5A840")]
		public ColorTokenDefinition(int id, string name, Color color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CreateAssetMenu(fileName = "ColorTokenGroup", menuName = "MVVM/Theming/Color Token Group")]
	public class ColorTokenGroup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private List<ColorTokenDefinition> colorDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private List<ColorTokenReference> colorTokenReferences;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B8B0", Offset = "0x6F5A2B0", VA = "0x186F5B8B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A8F0", Offset = "0x6F592F0", VA = "0x186F5A8F0")]
		public List<string> GetColorTokenNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AF30", Offset = "0x6F59930", VA = "0x186F5AF30")]
		public bool TryGetColorTokenByName(string name, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AC70", Offset = "0x6F59670", VA = "0x186F5AC70")]
		public bool TryGetColorTokenById(int id, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B510", Offset = "0x6F59F10", VA = "0x186F5B510")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B230", Offset = "0x6F59C30", VA = "0x186F5B230")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public void Editor_UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B7E0", Offset = "0x6F5A1E0", VA = "0x186F5B7E0")]
		public ColorTokenGroup()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ColorTokenReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public ColorTokenDefinition ColorTokenDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B9C0", Offset = "0x6F5A3C0", VA = "0x186F5B9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6F5BB30", Offset = "0x6F5A530", VA = "0x186F5BB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6F5BDA0", Offset = "0x6F5A7A0", VA = "0x186F5BDA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6F5BF00", Offset = "0x6F5A900", VA = "0x186F5BF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B970", Offset = "0x6F5A370", VA = "0x186F5B970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B910", Offset = "0x6F5A310", VA = "0x186F5B910")]
		public ColorTokenReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CreateAssetMenu(fileName = "Theme", menuName = "MVVM/Theming/Theme")]
	public class Theme : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public List<ThemeStyle> ThemeStyleList;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AF80", Offset = "0x6F69980", VA = "0x186F6AF80")]
		public void Editor_LoadTheme()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public Theme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class ThemeBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeReference]
		private List<IThemeBinder> binders;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6F64B80", Offset = "0x6F63580", VA = "0x186F64B80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F64D20", Offset = "0x6F63720", VA = "0x186F64D20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F648B0", Offset = "0x6F632B0", VA = "0x186F648B0")]
		public void AddBinder(IThemeBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F650E0", Offset = "0x6F63AE0", VA = "0x186F650E0")]
		public void ReplaceBinderAtIndex(IThemeBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F649C0", Offset = "0x6F633C0", VA = "0x186F649C0")]
		public void ApplyStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F64EC0", Offset = "0x6F638C0", VA = "0x186F64EC0")]
		public void RemoveStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public ThemeBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class ThemeDataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		protected ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ThemeStyleApplier applier;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ThemeStyleTemplate ThemeTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x6F663B0", Offset = "0x6F64DB0", VA = "0x186F663B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x6F66200", Offset = "0x6F64C00", VA = "0x186F66200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6F662D0", Offset = "0x6F64CD0", VA = "0x186F662D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x6F66460", Offset = "0x6F64E60", VA = "0x186F66460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x6F66250", Offset = "0x6F64C50", VA = "0x186F66250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x6F66160", Offset = "0x6F64B60", VA = "0x186F66160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x6F663C0", Offset = "0x6F64DC0", VA = "0x186F663C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F65AE0", Offset = "0x6F644E0", VA = "0x186F65AE0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F652B0", Offset = "0x6F63CB0", VA = "0x186F652B0")]
		public void Subscribe(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F65DD0", Offset = "0x6F647D0", VA = "0x186F65DD0")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4590", Offset = "0x3DF2F90", VA = "0x183DF4590")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xF71520", Offset = "0xF6FF20", VA = "0x180F71520", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F65980", Offset = "0x6F64380", VA = "0x186F65980")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F65A80", Offset = "0x6F64480", VA = "0x186F65A80")]
		private bool TryGetStyle(ThemeStyleApplier applier, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
		public void SetDataType(Type dataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F65150", Offset = "0x6F63B50", VA = "0x186F65150")]
		public void ApplyStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F65200", Offset = "0x6F63C00", VA = "0x186F65200")]
		public void RemoveStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F660E0", Offset = "0x6F64AE0", VA = "0x186F660E0")]
		public ThemeDataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class ThemeDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Dictionary<int, ThemeItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private ThemeVariant activeVariant;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x16C8FE0", Offset = "0x16C79E0", VA = "0x1816C8FE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F66530", Offset = "0x6F64F30", VA = "0x186F66530", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F66D70", Offset = "0x6F65770", VA = "0x186F66D70")]
		public bool TryGetThemeItem(int id, [Out] ThemeItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "9")]
		public DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F667C0", Offset = "0x6F651C0", VA = "0x186F667C0", Slot = "7")]
		public void Initialize(string name, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F66760", Offset = "0x6F65160", VA = "0x186F66760", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F669E0", Offset = "0x6F653E0", VA = "0x186F669E0")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "10")]
		public void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F66880", Offset = "0x6F65280", VA = "0x186F66880", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F66B90", Offset = "0x6F65590", VA = "0x186F66B90", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F66DE0", Offset = "0x6F657E0", VA = "0x186F66DE0", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4D10", Offset = "0x3DF3710", VA = "0x183DF4D10", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3DF48C0", Offset = "0x3DF32C0", VA = "0x183DF48C0", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F66E80", Offset = "0x6F65880", VA = "0x186F66E80")]
		public ThemeDataSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ThemeFontSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public TMP_FontAsset FontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public bool AutosizeFont;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfNotEquals)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MinSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MaxSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public FontStyles FontStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float LineHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float CharacterSpacing;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F90", Offset = "0x6F65990", VA = "0x186F66F90")]
		public ThemeFontSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ThemeItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private ThemeVariant variant;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6F67350", Offset = "0x6F65D50", VA = "0x186F67350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "7")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<int> ValueChangedWithId
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6F672A0", Offset = "0x6F65CA0", VA = "0x186F672A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F673A0", Offset = "0x6F65DA0", VA = "0x186F673A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "11")]
		public void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "12")]
		public void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F66FB0", Offset = "0x6F659B0", VA = "0x186F66FB0", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F66FF0", Offset = "0x6F659F0", VA = "0x186F66FF0", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "13")]
		public void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "15")]
		public void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F67030", Offset = "0x6F65A30", VA = "0x186F67030")]
		public void SetThemeItemValue(ThemeStyleValue styleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F671C0", Offset = "0x6F65BC0", VA = "0x186F671C0")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5760", Offset = "0x3DF4160", VA = "0x183DF5760")]
		public bool TryGetItem<T>([Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F67220", Offset = "0x6F65C20", VA = "0x186F67220")]
		public ThemeItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ThemeManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private static readonly string themingSourcePrefix;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static ThemeManager instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		private List<Theme> defaultThemeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private Dictionary<int, ThemeDataSource> themeDataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public static bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6F68150", Offset = "0x6F66B50", VA = "0x186F68150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static ThemeManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x6F68100", Offset = "0x6F66B00", VA = "0x186F68100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public ThemeVariant ActiveVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xA155E0", Offset = "0xA13FE0", VA = "0x180A155E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event Action ThemeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x6F68010", Offset = "0x6F66A10", VA = "0x186F68010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x6F681D0", Offset = "0x6F66BD0", VA = "0x186F681D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F67600", Offset = "0x6F66000", VA = "0x186F67600")]
		public static int GetThemeSourceId(string recordName)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F67450", Offset = "0x6F65E50", VA = "0x186F67450")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F67DC0", Offset = "0x6F667C0", VA = "0x186F67DC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F67BC0", Offset = "0x6F665C0", VA = "0x186F67BC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F67710", Offset = "0x6F66110", VA = "0x186F67710")]
		public void LoadTheme(Theme theme)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F674C0", Offset = "0x6F65EC0", VA = "0x186F674C0")]
		public void ChangeThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F67680", Offset = "0x6F66080", VA = "0x186F67680")]
		public bool IsStyleLoaded(ThemeStyle themeStyle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F67F80", Offset = "0x6F66980", VA = "0x186F67F80")]
		public ThemeManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum ThemeVariant
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Dark,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		HighContrast
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface IThemeValue
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetVariant(ThemeVariant variant);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class ThemeValue : IThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[HideInInspector]
		[SerializeField]
		protected bool excludedFromVariants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeField]
		protected bool referenceStyleValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected ThemeStyle themeStyleReference;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected ThemeVariant activeVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool ShowVariantValues
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x6F6AF60", Offset = "0x6F69960", VA = "0x186F6AF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool ShowSingleValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x6F6AF40", Offset = "0x6F69940", VA = "0x186F6AF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AEA0", Offset = "0x6F698A0", VA = "0x186F6AEA0", Slot = "8")]
		public void SetVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AEC0", Offset = "0x6F698C0", VA = "0x186F6AEC0")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class ThemeValue<T> : ThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T dark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T highContrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[ConditionalVisibility("ShowSingleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private ThemeValue<T> cachedReferenceValue;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x5AC41B0", Offset = "0x5AC2BB0", VA = "0x185AC41B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x5AC61E0", Offset = "0x5AC4BE0", VA = "0x185AC61E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x5AC9E00", Offset = "0x5AC8800", VA = "0x185AC9E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x5AC8ED0", Offset = "0x5AC78D0", VA = "0x185AC8ED0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x5AC2D10", Offset = "0x5AC1710", VA = "0x185AC2D10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5AC12F0", Offset = "0x5ABFCF0", VA = "0x185AC12F0")]
		private bool HasCircularDependency(ThemeValue<T> themeValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2BD0", Offset = "0x5AC15D0", VA = "0x185AC2BD0")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ColorThemeValue : ThemeValue<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A710", Offset = "0x6F59110", VA = "0x186F5A710")]
		public ColorThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class GradientThemeValue : ThemeValue<Gradient>
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6F62F20", Offset = "0x6F61920", VA = "0x186F62F20")]
		public GradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class MaterialThemeValue : ThemeValue<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6F63790", Offset = "0x6F62190", VA = "0x186F63790")]
		public MaterialThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class TextureThemeValue : ThemeValue<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6F64870", Offset = "0x6F63270", VA = "0x186F64870")]
		public TextureThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class IntThemeValue : ThemeValue<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6F63260", Offset = "0x6F61C60", VA = "0x186F63260")]
		public IntThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class FloatThemeValue : ThemeValue<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6F62280", Offset = "0x6F60C80", VA = "0x186F62280")]
		public FloatThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class Vector4ThemeValue : ThemeValue<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B0B0", Offset = "0x6F69AB0", VA = "0x186F6B0B0")]
		public Vector4ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class TMPGradientThemeValue : ThemeValue<TMP_ColorGradient>
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6F63DE0", Offset = "0x6F627E0", VA = "0x186F63DE0")]
		public TMPGradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class FontSettingsThemeValue : ThemeValue<ThemeFontSettings>
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6F62450", Offset = "0x6F60E50", VA = "0x186F62450")]
		public FontSettingsThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class BoolThemeValue : ThemeValue<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A100", Offset = "0x6F58B00", VA = "0x186F5A100")]
		public BoolThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class ColorTokenValue : ThemeValue<ColorToken>
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C150", Offset = "0x6F5AB50", VA = "0x186F5C150")]
		public ColorTokenValue()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ThemeStyleValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeItemType itemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeReference]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool ThemeRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x6F6ACA0", Offset = "0x6F696A0", VA = "0x186F6ACA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x6F6AAE0", Offset = "0x6F694E0", VA = "0x186F6AAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x6F6AB60", Offset = "0x6F69560", VA = "0x186F6AB60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x6F6ACF0", Offset = "0x6F696F0", VA = "0x186F6ACF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public IThemeValue ThemeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A690", Offset = "0x6F69090", VA = "0x186F6A690")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A780", Offset = "0x6F69180", VA = "0x186F6A780")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A7A0", Offset = "0x6F691A0", VA = "0x186F6A7A0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A610", Offset = "0x6F69010", VA = "0x186F6A610")]
		public void Editor_SetTemplate(ThemeStyleTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
		public bool Editor_OnValidate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public void UpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1109190", Offset = "0x1107B90", VA = "0x181109190")]
		public void ResetAndUpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AA80", Offset = "0x6F69480", VA = "0x186F6AA80")]
		public ThemeStyleValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CreateAssetMenu(fileName = "ThemeStyle", menuName = "MVVM/Theming/Theme Style")]
	public class ThemeStyle : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private string styleName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		private List<ThemeStyleValue> themeStyleValues;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public string StyleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ThemeStyleTemplate Template
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public List<ThemeStyleValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6F6ADF0", Offset = "0x6F697F0", VA = "0x186F6ADF0")]
		public ThemeStyle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class ThemeStylePicker
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private const string noStylesMatchingTemplateAvailableMessage = "<No styles of template {0} found>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[ConditionalVisibility("TemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("StyleNameOptions", "SelectedItemName")]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Dictionary<string, ThemeStyle> cachedStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private List<string> styleNameOptions;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected bool TemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x6F697A0", Offset = "0x6F681A0", VA = "0x186F697A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public List<string> StyleNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x6F695A0", Offset = "0x6F67FA0", VA = "0x186F695A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x6F697F0", Offset = "0x6F681F0", VA = "0x186F697F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x6F69430", Offset = "0x6F67E30", VA = "0x186F69430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x6F69960", Offset = "0x6F68360", VA = "0x186F69960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public ThemeStyle Style
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public bool Editor_Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xBCF0D0", Offset = "0xBCDAD0", VA = "0x180BCF0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		internal event Action<ThemeStylePicker> ThemeStyleChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x6F69380", Offset = "0x6F67D80", VA = "0x186F69380")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x6F698B0", Offset = "0x6F682B0", VA = "0x186F698B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6F69260", Offset = "0x6F67C60", VA = "0x186F69260")]
		internal void Editor_OnValidate(string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void Editor_PopulateStyleNameOptions([Optional] string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6F692F0", Offset = "0x6F67CF0", VA = "0x186F692F0")]
		public ThemeStylePicker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class ThemeStyleApplier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private List<ThemeStylePicker> themeStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private HashSet<ThemeStyle> styleOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private IReadOnlyList<ThemeBinder> runtimeBinders;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ThemeStyle> StyleOverrideApplied
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x6F68FA0", Offset = "0x6F679A0", VA = "0x186F68FA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x6F69100", Offset = "0x6F67B00", VA = "0x186F69100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ThemeStyle> StyleOverrideRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x6F69050", Offset = "0x6F67A50", VA = "0x186F69050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x6F691B0", Offset = "0x6F67BB0", VA = "0x186F691B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6F68A70", Offset = "0x6F67470", VA = "0x186F68A70")]
		public bool TryFindStyleForItem(ThemeStyleTemplate template, int itemId, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6F682C0", Offset = "0x6F66CC0", VA = "0x186F682C0")]
		public void ApplyRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F68820", Offset = "0x6F67220", VA = "0x186F68820")]
		public void RemoveRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F68F10", Offset = "0x6F67910", VA = "0x186F68F10")]
		public ThemeStyleApplier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public enum ThemeItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Gradient,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Material,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Vector4,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		TMPGradient,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		FontSettings,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		ColorToken
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CreateAssetMenu(fileName = "ThemeStyleTemplate", menuName = "MVVM/Theming/Theme Style Template")]
	public class ThemeStyleTemplate : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public class ThemeTemplateItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
			public int Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public ThemeItemType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public bool ExcludeFromVariants;

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x6F6AE40", Offset = "0x6F69840", VA = "0x186F6AE40")]
			public ThemeTemplateItem()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private List<ThemeTemplateItem> templateItems;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public List<ThemeTemplateItem> TemplateItems
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x6F6A5D0", Offset = "0x6F68FD0", VA = "0x186F6A5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F69A30", Offset = "0x6F68430", VA = "0x186F69A30")]
		public static ThemeItemType GetThemeItemType(Type targetType)
		{
			return default(ThemeItemType);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A0D0", Offset = "0x6F68AD0", VA = "0x186F6A0D0")]
		public void PopulateItemNameList(List<string> itemNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6F69E20", Offset = "0x6F68820", VA = "0x186F69E20")]
		public void PopulateItemNameListForType(List<string> itemNames, ThemeItemType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6F69F70", Offset = "0x6F68970", VA = "0x186F69F70")]
		public void PopulateItemNameListForType(List<string> itemNames, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A430", Offset = "0x6F68E30", VA = "0x186F6A430")]
		public bool TryGetInfoForName(string name, [Out] int id, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A270", Offset = "0x6F68C70", VA = "0x186F6A270")]
		public bool TryGetInfoForId(int id, [Out] string name, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public ThemeStyleTemplate()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IBFGABBDLJO
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IBFGABBDLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F62F60", Offset = "0x6F61960", VA = "0x186F62F60")]
	public static string IAIGFDJOPGA(byte[] LIJGJDKILNK, byte[] AIDBPMAAHBO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
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
