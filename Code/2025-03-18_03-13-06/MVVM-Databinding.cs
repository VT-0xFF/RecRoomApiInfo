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
		[SerializeField]
		[ConditionalVisibility("DataRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
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
			[Cpp2IlInjected.Address(RVA = "0x68E3240", Offset = "0x68E2440", VA = "0x1868E3240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x68E2D70", Offset = "0x68E1F70", VA = "0x1868E2D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x68E2E00", Offset = "0x68E2000", VA = "0x1868E2E00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x68E2F40", Offset = "0x68E2140", VA = "0x1868E2F40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x68E32D0", Offset = "0x68E24D0", VA = "0x1868E32D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x68E2E50", Offset = "0x68E2050", VA = "0x1868E2E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x68E3250", Offset = "0x68E2450", VA = "0x1868E3250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x68E31F0", Offset = "0x68E23F0", VA = "0x1868E31F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960870", VA = "0x180961670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x961650", Offset = "0x960850", VA = "0x180961650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected virtual DataPermissions PermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "12")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "13")]
		public virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68E20D0", Offset = "0x68E12D0", VA = "0x1868E20D0", Slot = "14")]
		public virtual void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68E21C0", Offset = "0x68E13C0", VA = "0x1868E21C0", Slot = "15")]
		public virtual void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68E2BF0", Offset = "0x68E1DF0", VA = "0x1868E2BF0", Slot = "16")]
		public virtual void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68E2320", Offset = "0x68E1520", VA = "0x1868E2320")]
		protected void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68E2BF0", Offset = "0x68E1DF0", VA = "0x1868E2BF0")]
		protected void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract void OnDataItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x68E2400", Offset = "0x68E1600", VA = "0x1868E2400")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68E2730", Offset = "0x68E1930", VA = "0x1868E2730")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68E2490", Offset = "0x68E1690", VA = "0x1868E2490")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68E2BA0", Offset = "0x68E1DA0", VA = "0x1868E2BA0", Slot = "18")]
		protected virtual void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68E2220", Offset = "0x68E1420", VA = "0x1868E2220", Slot = "19")]
		protected virtual string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68E2250", Offset = "0x68E1450", VA = "0x1868E2250")]
		protected string GetUnavailableItemMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68E21E0", Offset = "0x68E13E0", VA = "0x1868E21E0")]
		protected string GetInvalidPermissionsMessage(string itemName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68E22C0", Offset = "0x68E14C0", VA = "0x1868E22C0")]
		protected void LogDataUpdateError(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		private void Editor_SetComment(string commentStr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		protected void Editor_UpdateBinderName(string itemName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68E2CD0", Offset = "0x68E1ED0", VA = "0x1868E2CD0")]
		protected BaseBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class BaseBinder<T> : BaseBinder
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x58DAAA0", Offset = "0x58D9CA0", VA = "0x1858DAAA0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x58DB530", Offset = "0x58DA730", VA = "0x1858DB530")]
		protected void TrySetDataValue(T dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x58DB260", Offset = "0x58DA460", VA = "0x1858DB260", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x58DA710", Offset = "0x58D9910", VA = "0x1858DA710", Slot = "19")]
		protected override string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x58DB9E0", Offset = "0x58DABE0", VA = "0x1858DB9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E4A50", Offset = "0x68E3C50", VA = "0x1868E4A50", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68E4CB0", Offset = "0x68E3EB0", VA = "0x1868E4CB0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68E4B40", Offset = "0x68E3D40", VA = "0x1868E4B40")]
		protected void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68E4D90", Offset = "0x68E3F90", VA = "0x1868E4D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E4DD0", Offset = "0x68E3FD0", VA = "0x1868E4DD0", Slot = "20")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68E4E70", Offset = "0x68E4070", VA = "0x1868E4E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E5060", Offset = "0x68E4260", VA = "0x1868E5060", Slot = "20")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68E5110", Offset = "0x68E4310", VA = "0x1868E5110")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E7150", Offset = "0x68E6350", VA = "0x1868E7150", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68E7280", Offset = "0x68E6480", VA = "0x1868E7280")]
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
		[Cpp2IlInjected.Address(RVA = "0x68EC960", Offset = "0x68EBB60", VA = "0x1868EC960", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68ECA90", Offset = "0x68EBC90", VA = "0x1868ECA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x68ED1D0", Offset = "0x68EC3D0", VA = "0x1868ED1D0", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68ECE40", Offset = "0x68EC040", VA = "0x1868ECE40", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68ED180", Offset = "0x68EC380", VA = "0x1868ED180")]
		private void SetFormattedData(string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68ED3F0", Offset = "0x68EC5F0", VA = "0x1868ED3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68ED540", Offset = "0x68EC740", VA = "0x1868ED540", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68ED660", Offset = "0x68EC860", VA = "0x1868ED660")]
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
		[Cpp2IlInjected.Address(RVA = "0x68ED6E0", Offset = "0x68EC8E0", VA = "0x1868ED6E0", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68ED7E0", Offset = "0x68EC9E0", VA = "0x1868ED7E0", Slot = "20")]
		protected override void OnDataUpdated(float dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68EDA30", Offset = "0x68ECC30", VA = "0x1868EDA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x68EDC10", Offset = "0x68ECE10", VA = "0x1868EDC10", Slot = "20")]
		protected override void OnDataUpdated(Sprite dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68EDD50", Offset = "0x68ECF50", VA = "0x1868EDD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x68EDD90", Offset = "0x68ECF90", VA = "0x1868EDD90", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68EDE30", Offset = "0x68ED030", VA = "0x1868EDE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x68EDE70", Offset = "0x68ED070", VA = "0x1868EDE70", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68EDF10", Offset = "0x68ED110", VA = "0x1868EDF10")]
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
			[Cpp2IlInjected.Address(RVA = "0x68EE620", Offset = "0x68ED820", VA = "0x1868EE620", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68EE180", Offset = "0x68ED380", VA = "0x1868EE180", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68EE4E0", Offset = "0x68ED6E0", VA = "0x1868EE4E0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68EE290", Offset = "0x68ED490", VA = "0x1868EE290", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x68EE380", Offset = "0x68ED580", VA = "0x1868EE380")]
		private void OnTextEdited(string textData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68EE5E0", Offset = "0x68ED7E0", VA = "0x1868EE5E0")]
		public TextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class TextureBinder : BaseBinder<Texture>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private RawImage target;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68EE630", Offset = "0x68ED830", VA = "0x1868EE630", Slot = "20")]
		protected override void OnDataUpdated(Texture dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68EE6C0", Offset = "0x68ED8C0", VA = "0x1868EE6C0")]
		public TextureBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class VisibilityBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[Tooltip("If invert is false, target will show when value is true.\nIf invert is true, target will show when value is false.")]
		private bool invertVisibility;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68F5B10", Offset = "0x68F4D10", VA = "0x1868F5B10", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68F5BB0", Offset = "0x68F4DB0", VA = "0x1868F5BB0")]
		public VisibilityBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class BaseDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected Dictionary<int, IDataItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x96EC20", Offset = "0x96DE20", VA = "0x18096EC20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xC59600", Offset = "0xC58800", VA = "0x180C59600", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68E3740", Offset = "0x68E2940", VA = "0x1868E3740", Slot = "19")]
		public virtual void Initialize(string sourceName, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68E36E0", Offset = "0x68E28E0", VA = "0x1868E36E0", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "9")]
		public DataRecord GenerateRecord(string recordDirPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68E3930", Offset = "0x68E2B30", VA = "0x1868E3930", Slot = "20")]
		public virtual void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68E3390", Offset = "0x68E2590", VA = "0x1868E3390", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68E37E0", Offset = "0x68E29E0", VA = "0x1868E37E0", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68E3A10", Offset = "0x68E2C10", VA = "0x1868E3A10", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68E4030", Offset = "0x68E3230", VA = "0x1868E4030", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x320E950", Offset = "0x320DB50", VA = "0x18320E950", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x320F3F0", Offset = "0x320E5F0", VA = "0x18320F3F0", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x320DB90", Offset = "0x320CD90", VA = "0x18320DB90", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x320EDE0", Offset = "0x320DFE0", VA = "0x18320EDE0", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T itemValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "21")]
		protected virtual void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68E38C0", Offset = "0x68E2AC0", VA = "0x1868E38C0")]
		public static string ResolveNameWithRuntimeId(string sourceName, int runtimeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68E40D0", Offset = "0x68E32D0", VA = "0x1868E40D0")]
		protected BaseDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DataBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeReference]
		private List<IBinder> binders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool bindingDone;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68E7940", Offset = "0x68E6B40", VA = "0x1868E7940")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68E7B60", Offset = "0x68E6D60", VA = "0x1868E7B60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68E77A0", Offset = "0x68E69A0", VA = "0x1868E77A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68E7600", Offset = "0x68E6800", VA = "0x1868E7600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68E7550", Offset = "0x68E6750", VA = "0x1868E7550")]
		public void AddBinder(IBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68E7AF0", Offset = "0x68E6CF0", VA = "0x1868E7AF0")]
		public void ReplaceBinderAtIndex(IBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public DataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum DataPermissions : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		ReadOnly,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		ReadWrite
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IDataItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Initialize(int id, string name, DataPermissions permissions, string comment = "");

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RaiseValueChanged();

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SyncItemWithSource();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class DataItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		protected int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "4")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public virtual DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(DataPermissions);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xB96CB0", Offset = "0xB95EB0", VA = "0x180B96CB0", Slot = "18")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68E8FC0", Offset = "0x68E81C0", VA = "0x1868E8FC0", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x68E80A0", Offset = "0x68E72A0", VA = "0x1868E80A0", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract void SyncItemWithSource();

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x68E9020", Offset = "0x68E8220", VA = "0x1868E9020")]
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
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected DataItemGetter<T> valueGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected DataItemSetter<T> valueSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private UnityEvent<T> setUnderlyingValue;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x63F9750", Offset = "0x63F8950", VA = "0x1863F9750", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x63F99E0", Offset = "0x63F8BE0", VA = "0x1863F99E0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x63FA550", Offset = "0x63F9750", VA = "0x1863FA550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "20")]
		public override void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63F77E0", Offset = "0x63F69E0", VA = "0x1863F77E0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63F9080", Offset = "0x63F8280", VA = "0x1863F9080", Slot = "22")]
		public override void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63F8F60", Offset = "0x63F8160", VA = "0x1863F8F60")]
		public void SetGetterAndSetter(DataItemGetter<T> getter, DataItemSetter<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x63F67F0", Offset = "0x63F59F0", VA = "0x1863F67F0")]
		private void OnSetValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63F94A0", Offset = "0x63F86A0", VA = "0x1863F94A0")]
		public DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class DataItemInt : DataItem<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68E8060", Offset = "0x68E7260", VA = "0x1868E8060")]
		public DataItemInt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DataItemLong : DataItem<long>
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x68E81D0", Offset = "0x68E73D0", VA = "0x1868E81D0")]
		public DataItemLong()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class DataItemFloat : DataItem<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x68E8020", Offset = "0x68E7220", VA = "0x1868E8020")]
		public DataItemFloat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DataItemBool : DataItem<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x68E7FA0", Offset = "0x68E71A0", VA = "0x1868E7FA0")]
		public DataItemBool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DataItemString : DataItem<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x68E8290", Offset = "0x68E7490", VA = "0x1868E8290")]
		public DataItemString()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DataItemColor : DataItem<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x68E7FE0", Offset = "0x68E71E0", VA = "0x1868E7FE0")]
		public DataItemColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class DataItemMaterial : DataItem<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x68E8210", Offset = "0x68E7410", VA = "0x1868E8210")]
		public DataItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class DataItemSprite : DataItem<Sprite>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68E8250", Offset = "0x68E7450", VA = "0x1868E8250")]
		public DataItemSprite()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DataItemTexture : DataItem<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x68E82D0", Offset = "0x68E74D0", VA = "0x1868E82D0")]
		public DataItemTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class DataItemVector2 : DataItem<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x68E8F00", Offset = "0x68E8100", VA = "0x1868E8F00")]
		public DataItemVector2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DataItemVector3 : DataItem<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68E8F40", Offset = "0x68E8140", VA = "0x1868E8F40")]
		public DataItemVector3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DataItemVector4 : DataItem<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x68E8F80", Offset = "0x68E8180", VA = "0x1868E8F80")]
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
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x68E80C0", Offset = "0x68E72C0", VA = "0x1868E80C0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68E80A0", Offset = "0x68E72A0", VA = "0x1868E80A0")]
		private void RaiseListChanged(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68E8190", Offset = "0x68E7390", VA = "0x1868E8190")]
		public DataItemList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DataItemAction : DataItem<Action>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Action dataAction;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x68E7D30", Offset = "0x68E6F30", VA = "0x1868E7D30", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68E7EC0", Offset = "0x68E70C0", VA = "0x1868E7EC0")]
		public void SetAction(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620")]
		private Action GetAction()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68E7F60", Offset = "0x68E7160", VA = "0x1868E7F60")]
		public DataItemAction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private string listName;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> ListUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x68E9800", Offset = "0x68E8A00", VA = "0x1868E9800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x68E98B0", Offset = "0x68E8AB0", VA = "0x1868E98B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x68E9790", Offset = "0x68E8990", VA = "0x1868E9790")]
		public DataList(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68E9770", Offset = "0x68E8970", VA = "0x1868E9770")]
		protected void OnListUpdated()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DataList<T> : DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private List<T> dataList;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x58ACD30", Offset = "0x58ABF30", VA = "0x1858ACD30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T this[int key]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x63FB550", Offset = "0x63FA750", VA = "0x1863FB550")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x63FB610", Offset = "0x63FA810", VA = "0x1863FB610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x63FB4A0", Offset = "0x63FA6A0", VA = "0x1863FB4A0")]
		public DataList(string listName, int capacity = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x63FA7D0", Offset = "0x63F99D0", VA = "0x1863FA7D0")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x63FA770", Offset = "0x63F9970", VA = "0x1863FA770")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x63FA8A0", Offset = "0x63F9AA0", VA = "0x1863FA8A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x63FB0E0", Offset = "0x63FA2E0", VA = "0x1863FB0E0")]
		public void Set(List<T> list)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[DisallowMultipleComponent]
	public class DataListItemBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private List<BaseLocalViewModel> localViewModelList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int pendingLoadableCount;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<DataListItemBinder, int> ItemLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x68E94B0", Offset = "0x68E86B0", VA = "0x1868E94B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x68E9610", Offset = "0x68E8810", VA = "0x1868E9610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<DataListItemBinder, int> ItemUnloaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x68E9560", Offset = "0x68E8760", VA = "0x1868E9560")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x68E96C0", Offset = "0x68E88C0", VA = "0x1868E96C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68E9260", Offset = "0x68E8460", VA = "0x1868E9260")]
		public void SetData(int sourceId, int listId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x68E9080", Offset = "0x68E8280", VA = "0x1868E9080")]
		public void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x68E9190", Offset = "0x68E8390", VA = "0x1868E9190")]
		private void OnItemLoaded(ILoadable item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x15A6470", Offset = "0x15A5670", VA = "0x1815A6470")]
		public DataListItemBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DataRecordItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Permissions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x68E9960", Offset = "0x68E8B60", VA = "0x1868E9960")]
		public DataRecordItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class DataRecord : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int SourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public bool ExtraDataRequiredAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private List<DataRecordItem> dataItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private Dictionary<int, DataRecordItem> itemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private Dictionary<string, int> itemNameToIdMap;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x68EAE40", Offset = "0x68EA040", VA = "0x1868EAE40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x68E9F70", Offset = "0x68E9170", VA = "0x1868E9F70")]
		internal void PopulateRecord(int sourceId, string sourceName, string sourceType, bool idModifiedAtRuntime, List<IDataItem> itemList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x68E9A50", Offset = "0x68E8C50", VA = "0x1868E9A50")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x68E9DE0", Offset = "0x68E8FE0", VA = "0x1868E9DE0")]
		public void PopulateItemNameList(List<string> itemNames, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x68E9C30", Offset = "0x68E8E30", VA = "0x1868E9C30")]
		public void PopulateItemNameListForType(List<string> itemNames, string typeString, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x68EA7B0", Offset = "0x68E99B0", VA = "0x1868EA7B0")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x68EA920", Offset = "0x68E9B20", VA = "0x1868EA920")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x68EAAA0", Offset = "0x68E9CA0", VA = "0x1868EAAA0")]
		public bool TryGetPermissionsForId(int id, [Out] DataPermissions permissions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x68EA630", Offset = "0x68E9830", VA = "0x1868EA630")]
		public bool TryGetCommentForId(int id, [Out] string comment)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x68EAC40", Offset = "0x68E9E40", VA = "0x1868EAC40")]
		public bool TryGetTypeForId(int id, [Out] string typeString)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x68E9A10", Offset = "0x68E8C10", VA = "0x1868E9A10")]
		public bool ArePermissionsCompatible(int itemId, DataPermissions permissionLevel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x68EADC0", Offset = "0x68E9FC0", VA = "0x1868EADC0")]
		public DataRecord()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class DataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int fullSourceId;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x68E3240", Offset = "0x68E2440", VA = "0x1868E3240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x68EB9D0", Offset = "0x68EABD0", VA = "0x1868EB9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x68EBB10", Offset = "0x68EAD10", VA = "0x1868EBB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x68EBDE0", Offset = "0x68EAFE0", VA = "0x1868EBDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x68EBA20", Offset = "0x68EAC20", VA = "0x1868EBA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x68EBBE0", Offset = "0x68EADE0", VA = "0x1868EBBE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x68EBCC0", Offset = "0x68EAEC0", VA = "0x1868EBCC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAF8030", Offset = "0xAF7230", VA = "0x180AF8030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAF7690", Offset = "0xAF6890", VA = "0x180AF7690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x68EB930", Offset = "0x68EAB30", VA = "0x1868EB930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x68EBD40", Offset = "0x68EAF40", VA = "0x1868EBD40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x68EB040", Offset = "0x68EA240", VA = "0x1868EB040")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x68EAE80", Offset = "0x68EA080", VA = "0x1868EAE80")]
		public void Subscribe(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x68EB7D0", Offset = "0x68EA9D0", VA = "0x1868EB7D0")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x68EAF70", Offset = "0x68EA170", VA = "0x1868EAF70")]
		public bool TryGetBindingInfo([Out] int sourceId, [Out] int itemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x32D5870", Offset = "0x32D4A70", VA = "0x1832D5870")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x32D5BD0", Offset = "0x32D4DD0", VA = "0x1832D5BD0")]
		public bool TrySetData<T>(T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xDBFB30", Offset = "0xDBED30", VA = "0x180DBFB30", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68EAFD0", Offset = "0x68EA1D0", VA = "0x1868EAFD0")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x68EB280", Offset = "0x68EA480", VA = "0x1868EB280")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x68EB3A0", Offset = "0x68EA5A0", VA = "0x1868EB3A0")]
		private bool TryResolveDataSourceInstance()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68EB8B0", Offset = "0x68EAAB0", VA = "0x1868EB8B0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int DataItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public DataItemUpdate OnUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public PendingSubscription()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static DataSourceManager _instance;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static Dictionary<int, IDataSource> dataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Dictionary<int, List<PendingSubscription>> pendingSubscriptons;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static DataSourceManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x68EC8C0", Offset = "0x68EBAC0", VA = "0x1868EC8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68EBEB0", Offset = "0x68EB0B0", VA = "0x1868EBEB0")]
		public static void RegisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68EC5B0", Offset = "0x68EB7B0", VA = "0x1868EC5B0")]
		public static void UnregisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x68EC290", Offset = "0x68EB490", VA = "0x1868EC290")]
		public static void SubscribeToItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68EC6D0", Offset = "0x68EB8D0", VA = "0x1868EC6D0")]
		public static void UnsubscribeFromItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x68EC520", Offset = "0x68EB720", VA = "0x1868EC520")]
		public static bool TryGetDataSource(int sourceId, [Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x68EC220", Offset = "0x68EB420", VA = "0x1868EC220")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize(string name, bool idModifiedAtRuntime);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CleanUp();

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetDataRecord(DataRecord record);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AddItem(IDataItem item);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnItemChangedInSource(int id);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SubscribeToItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UnsubscribeFromItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TryGetItem<T>(int id, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TrySetItem<T>(int id, T item);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TryGetItemAtIndex<T>(int id, int index, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
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
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			EnableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			DisableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Never
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public ConditionalEnableType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
			[CompilerGenerated]
			get
			{
				return default(ConditionalEnableType);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xB96CB0", Offset = "0xB95EB0", VA = "0x180B96CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68E72C0", Offset = "0x68E64C0", VA = "0x1868E72C0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Info,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string ComparisonPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xB96CB0", Offset = "0xB95EB0", VA = "0x180B96CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xC156D0", Offset = "0xC148D0", VA = "0x180C156D0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xDB4A90", Offset = "0xDB3C90", VA = "0x180DB4A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080")]
			[CompilerGenerated]
			get
			{
				return default(MessageType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x96C070", Offset = "0x96B270", VA = "0x18096C070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xB73CD0", Offset = "0xB72ED0", VA = "0x180B73CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x1212D80", Offset = "0x1211F80", VA = "0x181212D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68E7370", Offset = "0x68E6570", VA = "0x1868E7370")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, MessageType messageType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x68E7310", Offset = "0x68E6510", VA = "0x1868E7310")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, int targetEnumValue, MessageType messageType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum ConditionComparisonType
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Enum
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum ConditionResultType
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		ShowIfEquals,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		ShowIfNotEquals,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Never
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalVisibilityAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x96C060", Offset = "0x96B260", VA = "0x18096C060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x96C070", Offset = "0x96B270", VA = "0x18096C070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xB73CD0", Offset = "0xB72ED0", VA = "0x180B73CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x1212D80", Offset = "0x1211F80", VA = "0x181212D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x68E7430", Offset = "0x68E6630", VA = "0x1868E7430")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x68E73D0", Offset = "0x68E65D0", VA = "0x1868E73D0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string SelectedOptionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x68EC910", Offset = "0x68EBB10", VA = "0x1868EC910")]
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
			[Cpp2IlInjected.Token(Token = "0x6000129")]
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
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68E48E0", Offset = "0x68E3AE0", VA = "0x1868E48E0")]
		public BindableActionAttribute(int dataItemId, string comment = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class BindableDataAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string Comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public DataPermissions Permissions;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x68E4970", Offset = "0x68E3B70", VA = "0x1868E4970")]
		public BindableDataAttribute(int dataItemId, string comment = "", DataPermissions permissions = DataPermissions.ReadWrite)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ViewModelAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x68E4120", Offset = "0x68E3320", VA = "0x1868E4120")]
		public BaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class BaseLocalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		protected int indexInList;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected virtual DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x68E41A0", Offset = "0x68E33A0", VA = "0x1868E41A0", Slot = "14")]
		public virtual void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68E4170", Offset = "0x68E3370", VA = "0x1868E4170", Slot = "15")]
		public virtual void ClearBindingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x68E4280", Offset = "0x68E3480", VA = "0x1868E4280")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x68E4330", Offset = "0x68E3530", VA = "0x1868E4330")]
		private void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x68E43E0", Offset = "0x68E35E0", VA = "0x1868E43E0")]
		protected BaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public abstract class BaseViewModel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[HideInInspector]
		[SerializeReference]
		private List<IDataItem> dataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[HideInInspector]
		[SerializeField]
		private DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ViewModelDataSource dataSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private string recordDir;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected virtual string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x68E48A0", Offset = "0x68E3AA0", VA = "0x1868E48A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x68E4440", Offset = "0x68E3640", VA = "0x1868E4440", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x68E46A0", Offset = "0x68E38A0", VA = "0x1868E46A0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x68E44B0", Offset = "0x68E36B0", VA = "0x1868E44B0", Slot = "10")]
		public virtual void InitializeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "11")]
		protected virtual void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x68E4720", Offset = "0x68E3920", VA = "0x1868E4720")]
		protected void OnPropertyChanged([CallerMemberName] string name = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		[ContextMenu("Update Record")]
		public void UpdateRecord()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "12")]
		protected virtual void RegisterCustomDataTypes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x68E4120", Offset = "0x68E3320", VA = "0x1868E4120")]
		protected BaseViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class DataItemTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static Dictionary<Type, Type> dataItemTypeCache;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x68E89A0", Offset = "0x68E7BA0", VA = "0x1868E89A0")]
		public static void RegisterDataItemType(Type underlyingDataType, Type dataItemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x68E8BE0", Offset = "0x68E7DE0", VA = "0x1868E8BE0")]
		public static bool TryGetDataItemType(Type underlyingDataType, [Out] Type dataItemType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x68E8310", Offset = "0x68E7510", VA = "0x1868E8310")]
		private static void EnsureCacheInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x68E83D0", Offset = "0x68E75D0", VA = "0x1868E83D0")]
		private static void RegisterBuiltInTypes()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class ViewModelDataSource : BaseDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Dictionary<string, int> itemNameToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private BaseViewModel viewModel;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x68F4FB0", Offset = "0x68F41B0", VA = "0x1868F4FB0")]
		internal void InitializeFromViewModel(BaseViewModel viewModel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x68F50A0", Offset = "0x68F42A0", VA = "0x1868F50A0")]
		public void LoadDataItems(List<IDataItem> dataItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x68F5610", Offset = "0x68F4810", VA = "0x1868F5610")]
		public void OnPropertyChanged(string propertyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x68F55B0", Offset = "0x68F47B0", VA = "0x1868F55B0", Slot = "21")]
		protected override void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x68E40D0", Offset = "0x68E32D0", VA = "0x1868E40D0")]
		public ViewModelDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class ViewModelTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static Dictionary<string, Type> viewModelTypeCache;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x68F5840", Offset = "0x68F4A40", VA = "0x1868F5840")]
		public static void RegisterViewModelType(string viewModelTypeString, Type viewModelType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x68F5A80", Offset = "0x68F4C80", VA = "0x1868F5A80")]
		public static bool TryGetViewModelType(string typeName, [Out] Type viewModelType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x68F5790", Offset = "0x68F4990", VA = "0x1868F5790")]
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
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[ConditionalVisibility("ThemeTemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ThemeStyle styleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private bool subscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x590BFC0", Offset = "0x590B1C0", VA = "0x18590BFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x590AB80", Offset = "0x5909D80", VA = "0x18590AB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x590BCF0", Offset = "0x590AEF0", VA = "0x18590BCF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x590A850", Offset = "0x5909A50", VA = "0x18590A850", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x590B1B0", Offset = "0x590A3B0", VA = "0x18590B1B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x590C210", Offset = "0x590B410", VA = "0x18590C210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected bool IsBindingValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x590ACA0", Offset = "0x5909EA0", VA = "0x18590ACA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x590AE30", Offset = "0x590A030", VA = "0x18590AE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected abstract ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x59080F0", Offset = "0x59072F0", VA = "0x1859080F0", Slot = "7")]
		public void Bind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x590A290", Offset = "0x5909490", VA = "0x18590A290", Slot = "8")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5908F20", Offset = "0x5908120", VA = "0x185908F20", Slot = "10")]
		public void OverrideActiveStyle(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5908660", Offset = "0x5907860", VA = "0x185908660", Slot = "9")]
		public void OnThemeItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x59090D0", Offset = "0x59082D0", VA = "0x1859090D0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x590A4D0", Offset = "0x59096D0", VA = "0x18590A4D0")]
		protected BaseThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class ColorThemeBinder : BaseThemeBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x68E4EB0", Offset = "0x68E40B0", VA = "0x1868E4EB0", Slot = "12")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x68E4FE0", Offset = "0x68E41E0", VA = "0x1868E4FE0")]
		public ColorThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ColorTokenThemeBinder : BaseThemeBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xC54020", Offset = "0xC53220", VA = "0x180C54020", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x68E6860", Offset = "0x68E5A60", VA = "0x1868E6860", Slot = "12")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x68E69C0", Offset = "0x68E5BC0", VA = "0x1868E69C0")]
		public ColorTokenThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class FontSettingsBinder : BaseThemeBinder<ThemeFontSettings>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xC91810", Offset = "0xC90A10", VA = "0x180C91810", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x68ECB10", Offset = "0x68EBD10", VA = "0x1868ECB10", Slot = "12")]
		protected override void OnDataUpdated(ThemeFontSettings dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x68ECC60", Offset = "0x68EBE60", VA = "0x1868ECC60")]
		public FontSettingsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class FontSizeThemeBinder : BaseThemeBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAC58F0", Offset = "0xAC4AF0", VA = "0x180AC58F0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x68ECCE0", Offset = "0x68EBEE0", VA = "0x1868ECCE0", Slot = "12")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x68ECE00", Offset = "0x68EC000", VA = "0x1868ECE00")]
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
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Bind();

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnThemeItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OverrideActiveStyle(ThemeStyle newStyle);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class MaterialThemeBinder : BaseThemeBinder<Material>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAAF9C0", Offset = "0xAAEBC0", VA = "0x180AAF9C0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x68EDA70", Offset = "0x68ECC70", VA = "0x1868EDA70", Slot = "12")]
		protected override void OnDataUpdated(Material dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x68EDB90", Offset = "0x68ECD90", VA = "0x1868EDB90")]
		public MaterialThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class TextureThemeBinder : BaseThemeBinder<Texture>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private List<RawImage> targets;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xAC1520", Offset = "0xAC0720", VA = "0x180AC1520", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x68EE700", Offset = "0x68ED900", VA = "0x1868EE700", Slot = "12")]
		protected override void OnDataUpdated(Texture dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x68EE810", Offset = "0x68EDA10", VA = "0x1868EE810")]
		public TextureThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class TMPGradientThemeBinder : BaseThemeBinder<TMP_ColorGradient>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xCA7870", Offset = "0xCA6A70", VA = "0x180CA7870", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x68EDFA0", Offset = "0x68ED1A0", VA = "0x1868EDFA0", Slot = "12")]
		protected override void OnDataUpdated(TMP_ColorGradient dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x68EE100", Offset = "0x68ED300", VA = "0x1868EE100")]
		public TMPGradientThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class VisibilityThemeBinder : BaseThemeBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private GameObject target;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xC95470", Offset = "0xC94670", VA = "0x180C95470", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x68F5BF0", Offset = "0x68F4DF0", VA = "0x1868F5BF0", Slot = "12")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x68F5C90", Offset = "0x68F4E90", VA = "0x1868F5C90")]
		public VisibilityThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum ThemeAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[InspectorName("0%")]
		Zero = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[InspectorName("5%")]
		Five = 5,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[InspectorName("10%")]
		Ten = 10,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[InspectorName("15%")]
		Fifteen = 15,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[InspectorName("20%")]
		Twenty = 20,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[InspectorName("25%")]
		TwentyFive = 25,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[InspectorName("30%")]
		Thirty = 30,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[InspectorName("40%")]
		Forty = 40,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[InspectorName("50%")]
		Fifty = 50,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[InspectorName("60%")]
		Sixty = 60,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[InspectorName("70%")]
		Seventy = 70,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[InspectorName("80%")]
		Eighty = 80,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[InspectorName("90%")]
		Ninety = 90,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[InspectorName("100%")]
		OneHundred = 100
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class ColorToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private ThemeAlpha Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Color? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private ThemeAlpha prevOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x68E6DF0", Offset = "0x68E5FF0", VA = "0x1868E6DF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x68E6B60", Offset = "0x68E5D60", VA = "0x1868E6B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x68E6F30", Offset = "0x68E6130", VA = "0x1868E6F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x68E7090", Offset = "0x68E6290", VA = "0x1868E7090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x68E6B10", Offset = "0x68E5D10", VA = "0x1868E6B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x68E6A40", Offset = "0x68E5C40", VA = "0x1868E6A40")]
		private void UpdateColor(Color newColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x68E6AF0", Offset = "0x68E5CF0", VA = "0x1868E6AF0")]
		public ColorToken()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ColorTokenDefinition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Color Color;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x68E5150", Offset = "0x68E4350", VA = "0x1868E5150")]
		public ColorTokenDefinition(int id, string name, Color color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CreateAssetMenu(fileName = "ColorTokenGroup", menuName = "MVVM/Theming/Color Token Group")]
	public class ColorTokenGroup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private List<ColorTokenDefinition> colorDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[SerializeField]
		private List<ColorTokenReference> colorTokenReferences;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x68E6160", Offset = "0x68E5360", VA = "0x1868E6160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x68E5200", Offset = "0x68E4400", VA = "0x1868E5200")]
		public List<string> GetColorTokenNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x68E57E0", Offset = "0x68E49E0", VA = "0x1868E57E0")]
		public bool TryGetColorTokenByName(string name, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x68E5520", Offset = "0x68E4720", VA = "0x1868E5520")]
		public bool TryGetColorTokenById(int id, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x68E5DC0", Offset = "0x68E4FC0", VA = "0x1868E5DC0")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x68E5AE0", Offset = "0x68E4CE0", VA = "0x1868E5AE0")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		public void Editor_UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x68E6090", Offset = "0x68E5290", VA = "0x1868E6090")]
		public ColorTokenGroup()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ColorTokenReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public ColorTokenDefinition ColorTokenDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x68E6270", Offset = "0x68E5470", VA = "0x1868E6270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x68E63E0", Offset = "0x68E55E0", VA = "0x1868E63E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x68E6650", Offset = "0x68E5850", VA = "0x1868E6650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x68E67B0", Offset = "0x68E59B0", VA = "0x1868E67B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x68E6220", Offset = "0x68E5420", VA = "0x1868E6220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x68E61C0", Offset = "0x68E53C0", VA = "0x1868E61C0")]
		public ColorTokenReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CreateAssetMenu(fileName = "Theme", menuName = "MVVM/Theming/Theme")]
	public class Theme : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<ThemeStyle> ThemeStyleList;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x68F4E40", Offset = "0x68F4040", VA = "0x1868F4E40")]
		public void Editor_LoadTheme()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
		public Theme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ThemeBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeReference]
		private List<IThemeBinder> binders;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x68EEB00", Offset = "0x68EDD00", VA = "0x1868EEB00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x68EECA0", Offset = "0x68EDEA0", VA = "0x1868EECA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x68EE890", Offset = "0x68EDA90", VA = "0x1868EE890")]
		public void AddBinder(IThemeBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x68EF060", Offset = "0x68EE260", VA = "0x1868EF060")]
		public void ReplaceBinderAtIndex(IThemeBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x68EE940", Offset = "0x68EDB40", VA = "0x1868EE940")]
		public void ApplyStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x68EEE40", Offset = "0x68EE040", VA = "0x1868EEE40")]
		public void RemoveStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public ThemeBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class ThemeDataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		protected ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ThemeStyleApplier applier;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public ThemeStyleTemplate ThemeTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x68F0330", Offset = "0x68EF530", VA = "0x1868F0330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x68F0180", Offset = "0x68EF380", VA = "0x1868F0180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x68F0250", Offset = "0x68EF450", VA = "0x1868F0250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x68F03E0", Offset = "0x68EF5E0", VA = "0x1868F03E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x68F01D0", Offset = "0x68EF3D0", VA = "0x1868F01D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x68F00E0", Offset = "0x68EF2E0", VA = "0x1868F00E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x68F0340", Offset = "0x68EF540", VA = "0x1868F0340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x68EFA60", Offset = "0x68EEC60", VA = "0x1868EFA60")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x68EF230", Offset = "0x68EE430", VA = "0x1868EF230")]
		public void Subscribe(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x68EFD50", Offset = "0x68EEF50", VA = "0x1868EFD50")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x37EEE00", Offset = "0x37EE000", VA = "0x1837EEE00")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xDC0440", Offset = "0xDBF640", VA = "0x180DC0440", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x68EF900", Offset = "0x68EEB00", VA = "0x1868EF900")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x68EFA00", Offset = "0x68EEC00", VA = "0x1868EFA00")]
		private bool TryGetStyle(ThemeStyleApplier applier, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x964EE0", Offset = "0x9640E0", VA = "0x180964EE0")]
		public void SetDataType(Type dataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x68EF0D0", Offset = "0x68EE2D0", VA = "0x1868EF0D0")]
		public void ApplyStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x68EF180", Offset = "0x68EE380", VA = "0x1868EF180")]
		public void RemoveStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x68F0060", Offset = "0x68EF260", VA = "0x1868F0060")]
		public ThemeDataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class ThemeDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Dictionary<int, ThemeItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private ThemeVariant activeVariant;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x13E2FD0", Offset = "0x13E21D0", VA = "0x1813E2FD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x68F04B0", Offset = "0x68EF6B0", VA = "0x1868F04B0", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x68F0C90", Offset = "0x68EFE90", VA = "0x1868F0C90")]
		public bool TryGetThemeItem(int id, [Out] ThemeItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "9")]
		public DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x68F0740", Offset = "0x68EF940", VA = "0x1868F0740", Slot = "7")]
		public void Initialize(string name, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x68F06E0", Offset = "0x68EF8E0", VA = "0x1868F06E0", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x68F0960", Offset = "0x68EFB60", VA = "0x1868F0960")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "10")]
		public void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x68F0800", Offset = "0x68EFA00", VA = "0x1868F0800", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x68F0B10", Offset = "0x68EFD10", VA = "0x1868F0B10", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x68F0D00", Offset = "0x68EFF00", VA = "0x1868F0D00", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x37EF580", Offset = "0x37EE780", VA = "0x1837EF580", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x37EF130", Offset = "0x37EE330", VA = "0x1837EF130", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x68F0DA0", Offset = "0x68EFFA0", VA = "0x1868F0DA0")]
		public ThemeDataSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class ThemeFontSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public TMP_FontAsset FontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool AutosizeFont;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfNotEquals)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MinSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MaxSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FontStyles FontStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public float LineHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public float CharacterSpacing;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x68F0EB0", Offset = "0x68F00B0", VA = "0x1868F0EB0")]
		public ThemeFontSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class ThemeItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private ThemeVariant variant;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x68F1270", Offset = "0x68F0470", VA = "0x1868F1270", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "7")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<int> ValueChangedWithId
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x68F11C0", Offset = "0x68F03C0", VA = "0x1868F11C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x68F12C0", Offset = "0x68F04C0", VA = "0x1868F12C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "11")]
		public void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "12")]
		public void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x68F0ED0", Offset = "0x68F00D0", VA = "0x1868F0ED0", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x68F0F10", Offset = "0x68F0110", VA = "0x1868F0F10", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "13")]
		public void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "15")]
		public void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x68F0F50", Offset = "0x68F0150", VA = "0x1868F0F50")]
		public void SetThemeItemValue(ThemeStyleValue styleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x68F10E0", Offset = "0x68F02E0", VA = "0x1868F10E0")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x37EFF80", Offset = "0x37EF180", VA = "0x1837EFF80")]
		public bool TryGetItem<T>([Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x68F1140", Offset = "0x68F0340", VA = "0x1868F1140")]
		public ThemeItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ThemeManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly string themingSourcePrefix;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private static ThemeManager instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		private List<Theme> defaultThemeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Dictionary<int, ThemeDataSource> themeDataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public static bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x68F2070", Offset = "0x68F1270", VA = "0x1868F2070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public static ThemeManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x68F2020", Offset = "0x68F1220", VA = "0x1868F2020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public ThemeVariant ActiveVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x96C070", Offset = "0x96B270", VA = "0x18096C070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event Action ThemeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x68F1F30", Offset = "0x68F1130", VA = "0x1868F1F30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x68F20F0", Offset = "0x68F12F0", VA = "0x1868F20F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x68F1520", Offset = "0x68F0720", VA = "0x1868F1520")]
		public static int GetThemeSourceId(string recordName)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x68F1370", Offset = "0x68F0570", VA = "0x1868F1370")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68F1CE0", Offset = "0x68F0EE0", VA = "0x1868F1CE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68F1AE0", Offset = "0x68F0CE0", VA = "0x1868F1AE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x68F1630", Offset = "0x68F0830", VA = "0x1868F1630")]
		public void LoadTheme(Theme theme)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x68F13E0", Offset = "0x68F05E0", VA = "0x1868F13E0")]
		public void ChangeThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x68F15A0", Offset = "0x68F07A0", VA = "0x1868F15A0")]
		public bool IsStyleLoaded(ThemeStyle themeStyle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x68F1EA0", Offset = "0x68F10A0", VA = "0x1868F1EA0")]
		public ThemeManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum ThemeVariant
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Dark,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		HighContrast
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface IThemeValue
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetVariant(ThemeVariant variant);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public abstract class ThemeValue : IThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[HideInInspector]
		[SerializeField]
		protected bool excludedFromVariants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[SerializeField]
		protected bool referenceStyleValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected ThemeStyle themeStyleReference;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected ThemeVariant activeVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected bool ShowVariantValues
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x68F4E20", Offset = "0x68F4020", VA = "0x1868F4E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool ShowSingleValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x68F4E00", Offset = "0x68F4000", VA = "0x1868F4E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x964F10", Offset = "0x964110", VA = "0x180964F10", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x964F50", Offset = "0x964150", VA = "0x180964F50", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x68F4D60", Offset = "0x68F3F60", VA = "0x1868F4D60", Slot = "8")]
		public void SetVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x68F4D80", Offset = "0x68F3F80", VA = "0x1868F4D80")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class ThemeValue<T> : ThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T dark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T highContrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[ConditionalVisibility("ShowSingleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private ThemeValue<T> cachedReferenceValue;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x544E150", Offset = "0x544D350", VA = "0x18544E150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x5450020", Offset = "0x544F220", VA = "0x185450020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x5453B20", Offset = "0x5452D20", VA = "0x185453B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x5452BC0", Offset = "0x5451DC0", VA = "0x185452BC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x544D000", Offset = "0x544C200", VA = "0x18544D000", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x544B780", Offset = "0x544A980", VA = "0x18544B780")]
		private bool HasCircularDependency(ThemeValue<T> themeValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x544CEC0", Offset = "0x544C0C0", VA = "0x18544CEC0")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ColorThemeValue : ThemeValue<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x68E5020", Offset = "0x68E4220", VA = "0x1868E5020")]
		public ColorThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class GradientThemeValue : ThemeValue<Gradient>
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x68ED500", Offset = "0x68EC700", VA = "0x1868ED500")]
		public GradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class MaterialThemeValue : ThemeValue<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x68EDBD0", Offset = "0x68ECDD0", VA = "0x1868EDBD0")]
		public MaterialThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class TextureThemeValue : ThemeValue<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x68EE850", Offset = "0x68EDA50", VA = "0x1868EE850")]
		public TextureThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class IntThemeValue : ThemeValue<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x68ED6A0", Offset = "0x68EC8A0", VA = "0x1868ED6A0")]
		public IntThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class FloatThemeValue : ThemeValue<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x68ECAD0", Offset = "0x68EBCD0", VA = "0x1868ECAD0")]
		public FloatThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class Vector4ThemeValue : ThemeValue<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x68F4F70", Offset = "0x68F4170", VA = "0x1868F4F70")]
		public Vector4ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class TMPGradientThemeValue : ThemeValue<TMP_ColorGradient>
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x68EE140", Offset = "0x68ED340", VA = "0x1868EE140")]
		public TMPGradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class FontSettingsThemeValue : ThemeValue<ThemeFontSettings>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x68ECCA0", Offset = "0x68EBEA0", VA = "0x1868ECCA0")]
		public FontSettingsThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class BoolThemeValue : ThemeValue<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x68E4A10", Offset = "0x68E3C10", VA = "0x1868E4A10")]
		public BoolThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ColorTokenValue : ThemeValue<ColorToken>
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x68E6A00", Offset = "0x68E5C00", VA = "0x1868E6A00")]
		public ColorTokenValue()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ThemeStyleValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeItemType itemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeReference]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool ThemeRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x68F4B60", Offset = "0x68F3D60", VA = "0x1868F4B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x68F49A0", Offset = "0x68F3BA0", VA = "0x1868F49A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x68F4A20", Offset = "0x68F3C20", VA = "0x1868F4A20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x68F4BB0", Offset = "0x68F3DB0", VA = "0x1868F4BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public IThemeValue ThemeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x964EE0", Offset = "0x9640E0", VA = "0x180964EE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x68F4550", Offset = "0x68F3750", VA = "0x1868F4550")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x68F4640", Offset = "0x68F3840", VA = "0x1868F4640")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x68F4660", Offset = "0x68F3860", VA = "0x1868F4660")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x68F44D0", Offset = "0x68F36D0", VA = "0x1868F44D0")]
		public void Editor_SetTemplate(ThemeStyleTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
		public bool Editor_OnValidate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		public void UpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xF0B460", Offset = "0xF0A660", VA = "0x180F0B460")]
		public void ResetAndUpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x68F4940", Offset = "0x68F3B40", VA = "0x1868F4940")]
		public ThemeStyleValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CreateAssetMenu(fileName = "ThemeStyle", menuName = "MVVM/Theming/Theme Style")]
	public class ThemeStyle : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private string styleName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private List<ThemeStyleValue> themeStyleValues;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public string StyleName
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public ThemeStyleTemplate Template
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public List<ThemeStyleValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x68F4CB0", Offset = "0x68F3EB0", VA = "0x1868F4CB0")]
		public ThemeStyle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ThemeStylePicker
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private const string noStylesMatchingTemplateAvailableMessage = "<No styles of template {0} found>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[ConditionalVisibility("TemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("StyleNameOptions", "SelectedItemName")]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private Dictionary<string, ThemeStyle> cachedStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<string> styleNameOptions;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		protected bool TemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x68F36D0", Offset = "0x68F28D0", VA = "0x1868F36D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public List<string> StyleNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x68F34D0", Offset = "0x68F26D0", VA = "0x1868F34D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x68F3720", Offset = "0x68F2920", VA = "0x1868F3720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x68F3360", Offset = "0x68F2560", VA = "0x1868F3360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x68F3890", Offset = "0x68F2A90", VA = "0x1868F3890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public ThemeStyle Style
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public bool Editor_Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9BE6E0", Offset = "0x9BD8E0", VA = "0x1809BE6E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		internal event Action<ThemeStylePicker> ThemeStyleChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x68F32B0", Offset = "0x68F24B0", VA = "0x1868F32B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x68F37E0", Offset = "0x68F29E0", VA = "0x1868F37E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x68F3190", Offset = "0x68F2390", VA = "0x1868F3190")]
		internal void Editor_OnValidate(string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		private void Editor_PopulateStyleNameOptions([Optional] string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x68F3220", Offset = "0x68F2420", VA = "0x1868F3220")]
		public ThemeStylePicker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ThemeStyleApplier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private List<ThemeStylePicker> themeStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private HashSet<ThemeStyle> styleOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private IReadOnlyList<ThemeBinder> runtimeBinders;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ThemeStyle> StyleOverrideApplied
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x68F2ED0", Offset = "0x68F20D0", VA = "0x1868F2ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x68F3030", Offset = "0x68F2230", VA = "0x1868F3030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ThemeStyle> StyleOverrideRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x68F2F80", Offset = "0x68F2180", VA = "0x1868F2F80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x68F30E0", Offset = "0x68F22E0", VA = "0x1868F30E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x68F29A0", Offset = "0x68F1BA0", VA = "0x1868F29A0")]
		public bool TryFindStyleForItem(ThemeStyleTemplate template, int itemId, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x68F21E0", Offset = "0x68F13E0", VA = "0x1868F21E0")]
		public void ApplyRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x68F2750", Offset = "0x68F1950", VA = "0x1868F2750")]
		public void RemoveRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x68F2E40", Offset = "0x68F2040", VA = "0x1868F2E40")]
		public ThemeStyleApplier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum ThemeItemType
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Gradient,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Material,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Vector4,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		TMPGradient,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		FontSettings,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
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
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
			public int Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public ThemeItemType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public bool ExcludeFromVariants;

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x68F4D00", Offset = "0x68F3F00", VA = "0x1868F4D00")]
			public ThemeTemplateItem()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private List<ThemeTemplateItem> templateItems;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public List<ThemeTemplateItem> TemplateItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x68F4490", Offset = "0x68F3690", VA = "0x1868F4490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x68F3960", Offset = "0x68F2B60", VA = "0x1868F3960")]
		public static ThemeItemType GetThemeItemType(Type targetType)
		{
			return default(ThemeItemType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x68F4000", Offset = "0x68F3200", VA = "0x1868F4000")]
		public void PopulateItemNameList(List<string> itemNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x68F3D50", Offset = "0x68F2F50", VA = "0x1868F3D50")]
		public void PopulateItemNameListForType(List<string> itemNames, ThemeItemType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x68F3EA0", Offset = "0x68F30A0", VA = "0x1868F3EA0")]
		public void PopulateItemNameListForType(List<string> itemNames, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x68F42F0", Offset = "0x68F34F0", VA = "0x1868F42F0")]
		public bool TryGetInfoForName(string name, [Out] int id, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x68F4130", Offset = "0x68F3330", VA = "0x1868F4130")]
		public bool TryGetInfoForId(int id, [Out] string name, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
		public ThemeStyleTemplate()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x68E7480", Offset = "0x68E6680", VA = "0x1868E7480")]
	public static string MGINLAJGEKK(byte[] FNCICDDLDOH, byte[] IHHFFMKKHIE)
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
