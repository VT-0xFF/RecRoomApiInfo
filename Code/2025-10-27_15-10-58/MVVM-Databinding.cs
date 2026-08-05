using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
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
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MZHUOFNWOZJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78EE310", Offset = "0x78ED310", VA = "0x1878EE310")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
	public MZHUOFNWOZJ()
	{
	}
}
namespace MVVMDatabinding
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public abstract class BaseBinder : IBinder
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected const string boundItemUnavailableMessage = "<Data Item {0} is unavailable to bind to>";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected const string badPermsMessage = "<Data Item {0} cannot be written to>";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected const string permissionAndCommentMessageFormat = "{0}\n{1}";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string binderNameFormat = "{0}{1} ({2})";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[ConditionalVisibility("DataRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[ConditionalShowAsMessage("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals, ConditionalShowAsMessageAttribute.MessageType.Info)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected bool isListItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected int listItemIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int fullSourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool loggedDataUpdateError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x78E3AC0", Offset = "0x78E2AC0", VA = "0x1878E3AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x78E35F0", Offset = "0x78E25F0", VA = "0x1878E35F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x78E3680", Offset = "0x78E2680", VA = "0x1878E3680", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x78E37C0", Offset = "0x78E27C0", VA = "0x1878E37C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x78E3B50", Offset = "0x78E2B50", VA = "0x1878E3B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x78E36D0", Offset = "0x78E26D0", VA = "0x1878E36D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x78E3AD0", Offset = "0x78E2AD0", VA = "0x1878E3AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x78E3A70", Offset = "0x78E2A70", VA = "0x1878E3A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xACEBE0", Offset = "0xACDBE0", VA = "0x180ACEBE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xACEE80", Offset = "0xACDE80", VA = "0x180ACEE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected virtual DataPermissions PermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "12")]
		public virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "13")]
		public virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78E2980", Offset = "0x78E1980", VA = "0x1878E2980", Slot = "14")]
		public virtual void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A60", Offset = "0x78E1A60", VA = "0x1878E2A60", Slot = "15")]
		public virtual void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78E3490", Offset = "0x78E2490", VA = "0x1878E3490", Slot = "16")]
		public virtual void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78E2BB0", Offset = "0x78E1BB0", VA = "0x1878E2BB0")]
		protected void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78E3490", Offset = "0x78E2490", VA = "0x1878E3490")]
		protected void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract void OnDataItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78E2C80", Offset = "0x78E1C80", VA = "0x1878E2C80")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78E2FE0", Offset = "0x78E1FE0", VA = "0x1878E2FE0")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78E2D10", Offset = "0x78E1D10", VA = "0x1878E2D10")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78E3440", Offset = "0x78E2440", VA = "0x1878E3440", Slot = "18")]
		protected virtual void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78E2AC0", Offset = "0x78E1AC0", VA = "0x1878E2AC0", Slot = "19")]
		protected virtual string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78E2AF0", Offset = "0x78E1AF0", VA = "0x1878E2AF0")]
		protected string GetUnavailableItemMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A80", Offset = "0x78E1A80", VA = "0x1878E2A80")]
		protected string GetInvalidPermissionsMessage(string itemName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78E2B50", Offset = "0x78E1B50", VA = "0x1878E2B50")]
		protected void LogDataUpdateError(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private void Editor_SetComment(string commentStr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		protected void Editor_UpdateBinderName(string itemName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78E3560", Offset = "0x78E2560", VA = "0x1878E3560")]
		protected BaseBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class BaseBinder<T> : BaseBinder
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4085850", Offset = "0x4084850", VA = "0x184085850", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4085F10", Offset = "0x4084F10", VA = "0x184085F10")]
		protected void TrySetDataValue(T dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4085BB0", Offset = "0x4084BB0", VA = "0x184085BB0", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x40850A0", Offset = "0x40840A0", VA = "0x1840850A0", Slot = "19")]
		protected override string GetTypedAvailabilityMessage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x40864A0", Offset = "0x40854A0", VA = "0x1840864A0")]
		protected BaseBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ButtonActionBinder : BaseBinder<Action>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[ConditionalVisibility("DataRecordValid", ConditionResultType.ShowIfEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78E5310", Offset = "0x78E4310", VA = "0x1878E5310", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78E5570", Offset = "0x78E4570", VA = "0x1878E5570", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78E5400", Offset = "0x78E4400", VA = "0x1878E5400")]
		protected void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78E5650", Offset = "0x78E4650", VA = "0x1878E5650")]
		public ButtonActionBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ColorBinder : BaseBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Graphic target;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78E5690", Offset = "0x78E4690", VA = "0x1878E5690", Slot = "20")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x78E5730", Offset = "0x78E4730", VA = "0x1878E5730")]
		public ColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ColorTokenBinder : BaseBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Graphic target;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78E5920", Offset = "0x78E4920", VA = "0x1878E5920", Slot = "20")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78E59D0", Offset = "0x78E49D0", VA = "0x1878E59D0")]
		public ColorTokenBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ComponentEnabledStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private List<Behaviour> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool invertState;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78E7A50", Offset = "0x78E6A50", VA = "0x1878E7A50", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78E7B80", Offset = "0x78E6B80", VA = "0x1878E7B80")]
		public ComponentEnabledStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EnabledStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private List<GameObject> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private bool invertState;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78ED120", Offset = "0x78EC120", VA = "0x1878ED120", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78ED250", Offset = "0x78EC250", VA = "0x1878ED250")]
		public EnabledStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class FormattedTextBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private string formattedString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private string formattingToReplace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private string dataFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private TMP_Text target;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78ED970", Offset = "0x78EC970", VA = "0x1878ED970", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x78ED600", Offset = "0x78EC600", VA = "0x1878ED600", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78ED870", Offset = "0x78EC870", VA = "0x1878ED870")]
		private void SetFormattedData(string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78EDBE0", Offset = "0x78ECBE0", VA = "0x1878EDBE0")]
		public FormattedTextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum BindDirection
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		OneWay,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		OneWayToSource,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		TwoWay
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IBinder
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnDisable();

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Bind(GameObject bindingObject);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnDataItemUpdate(IDataSource dataSource, int itemId);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ImageBinder : BaseBinder<Sprite>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x78EDD10", Offset = "0x78ECD10", VA = "0x1878EDD10", Slot = "20")]
		protected override void OnDataUpdated(Sprite dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78EDDA0", Offset = "0x78ECDA0", VA = "0x1878EDDA0")]
		public ImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class IndentBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private RectTransform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float indentSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float? defaultIndent;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x78EDDE0", Offset = "0x78ECDE0", VA = "0x1878EDDE0", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x78EDF00", Offset = "0x78ECF00", VA = "0x1878EDF00")]
		public IndentBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class LayoutElementSizeBinder : BaseBinder<float>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum LayoutElementSizeTarget
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			MinWidth,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			MinHeight,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			PreferredWidth,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			PreferredHeight,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			FlexWidth,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			FlexHeight
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x78EDF80", Offset = "0x78ECF80", VA = "0x1878EDF80", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x78EE080", Offset = "0x78ED080", VA = "0x1878EE080", Slot = "20")]
		protected override void OnDataUpdated(float dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x78EE2D0", Offset = "0x78ED2D0", VA = "0x1878EE2D0")]
		public LayoutElementSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ScrollRectEnabledBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private bool invertState;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78EE590", Offset = "0x78ED590", VA = "0x1878EE590", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x78EE630", Offset = "0x78ED630", VA = "0x1878EE630")]
		public ScrollRectEnabledBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SpriteBinder : BaseBinder<Sprite>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private bool invisibleIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private bool deactivateIfNull;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x78EE670", Offset = "0x78ED670", VA = "0x1878EE670", Slot = "20")]
		protected override void OnDataUpdated(Sprite dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x78EE7B0", Offset = "0x78ED7B0", VA = "0x1878EE7B0")]
		public SpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class SpriteRendererBinder : BaseBinder<Sprite>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private SpriteRenderer target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private bool invisibleIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private bool deactivateIfNull;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78EE7F0", Offset = "0x78ED7F0", VA = "0x1878EE7F0", Slot = "20")]
		protected override void OnDataUpdated(Sprite dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x78EE930", Offset = "0x78ED930", VA = "0x1878EE930")]
		public SpriteRendererBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SpriteSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private Sprite trueSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Sprite falseSprite;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x78EE970", Offset = "0x78ED970", VA = "0x1878EE970", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x78EEA10", Offset = "0x78EDA10", VA = "0x1878EEA10")]
		public SpriteSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class StringSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private string trueString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private string falseString;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x78EEA50", Offset = "0x78EDA50", VA = "0x1878EEA50", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x78EEAF0", Offset = "0x78EDAF0", VA = "0x1878EEAF0")]
		public StringSwapBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class TextBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfEquals, 0)]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfNotEquals, 0)]
		[SerializeField]
		private TMP_InputField textInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[ConditionalVisibility("bindDirection", ConditionResultType.ShowIfNotEquals, 0)]
		[SerializeField]
		private TMP_Text characterCountText;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override DataPermissions PermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x24EBBC0", Offset = "0x24EABC0", VA = "0x1824EBBC0", Slot = "11")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x78EED50", Offset = "0x78EDD50", VA = "0x1878EED50", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x78EF4A0", Offset = "0x78EE4A0", VA = "0x1878EF4A0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x78EF280", Offset = "0x78EE280", VA = "0x1878EF280", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x78EEE50", Offset = "0x78EDE50", VA = "0x1878EEE50", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x78EF120", Offset = "0x78EE120", VA = "0x1878EF120")]
		private void OnTextEdited(string textData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x40864A0", Offset = "0x40854A0", VA = "0x1840864A0")]
		public TextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class TextureBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private RawImage target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private bool invisibleIfNull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private bool deactivateIfNull;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x78EF860", Offset = "0x78EE860", VA = "0x1878EF860", Slot = "18")]
		protected override void TryRetrieveTypedItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x78EF5A0", Offset = "0x78EE5A0", VA = "0x1878EF5A0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x40864A0", Offset = "0x40854A0", VA = "0x1840864A0")]
		public TextureBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class VisibilityBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private GameObject targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		[Tooltip("If invert is false, target will show when value is true.\nIf invert is true, target will show when value is false.")]
		private bool invertVisibility;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x78F6DB0", Offset = "0x78F5DB0", VA = "0x1878F6DB0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x78F6E50", Offset = "0x78F5E50", VA = "0x1878F6E50")]
		public VisibilityBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class BaseDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected Dictionary<int, IDataItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int nameHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xACFF50", Offset = "0xACEF50", VA = "0x180ACFF50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xFEA550", Offset = "0xFE9550", VA = "0x180FEA550", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x78E3FC0", Offset = "0x78E2FC0", VA = "0x1878E3FC0", Slot = "19")]
		public virtual void Initialize(string sourceName, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x78E3F40", Offset = "0x78E2F40", VA = "0x1878E3F40", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "9")]
		public DataRecord GenerateRecord(string recordDirPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x78E41C0", Offset = "0x78E31C0", VA = "0x1878E41C0", Slot = "20")]
		public virtual void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x78E3C10", Offset = "0x78E2C10", VA = "0x1878E3C10", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x78E4080", Offset = "0x78E3080", VA = "0x1878E4080", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x78E42A0", Offset = "0x78E32A0", VA = "0x1878E42A0", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x78E4900", Offset = "0x78E3900", VA = "0x1878E4900", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x36A8480", Offset = "0x36A7480", VA = "0x1836A8480", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x36A91F0", Offset = "0x36A81F0", VA = "0x1836A91F0", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x36A7780", Offset = "0x36A6780", VA = "0x1836A7780", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x36A88D0", Offset = "0x36A78D0", VA = "0x1836A88D0", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T itemValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "21")]
		protected virtual void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x78E4160", Offset = "0x78E3160", VA = "0x1878E4160")]
		public static string ResolveNameWithRuntimeId(string sourceName, int runtimeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78E49A0", Offset = "0x78E39A0", VA = "0x1878E49A0")]
		protected BaseDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class DataBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeReference]
		private List<IBinder> binders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool bindingDone;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x78E81C0", Offset = "0x78E71C0", VA = "0x1878E81C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78E83E0", Offset = "0x78E73E0", VA = "0x1878E83E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x78E8020", Offset = "0x78E7020", VA = "0x1878E8020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x78E7E80", Offset = "0x78E6E80", VA = "0x1878E7E80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x78E7D80", Offset = "0x78E6D80", VA = "0x1878E7D80")]
		public void AddBinder(IBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78E8370", Offset = "0x78E7370", VA = "0x1878E8370")]
		public void ReplaceBinderAtIndex(IBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public DataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum DataPermissions : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ReadOnly,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ReadWrite
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface IDataItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Initialize(int id, string name, DataPermissions permissions, string comment = "");

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RaiseValueChanged();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SyncItemWithSource();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class DataItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		protected int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110", Slot = "4")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xADCB20", Offset = "0xADBB20", VA = "0x180ADCB20")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public virtual DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(DataPermissions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000", Slot = "18")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x78E97B0", Offset = "0x78E87B0", VA = "0x1878E97B0", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x78E8920", Offset = "0x78E7920", VA = "0x1878E8920", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EditorCleanup();

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract void SyncItemWithSource();

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x78E9810", Offset = "0x78E8810", VA = "0x1878E9810")]
		protected DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate T DataItemGetter<T>();
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void DataItemSetter<T>(T val);
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DataItem<T> : DataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected DataItemGetter<T> valueGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected DataItemSetter<T> valueSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private UnityEvent<T> setUnderlyingValue;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4452410", Offset = "0x4451410", VA = "0x184452410", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x44526C0", Offset = "0x44516C0", VA = "0x1844526C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x44533F0", Offset = "0x44523F0", VA = "0x1844533F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "20")]
		public override void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x444F5A0", Offset = "0x444E5A0", VA = "0x18444F5A0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x44515B0", Offset = "0x44505B0", VA = "0x1844515B0", Slot = "22")]
		public override void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4451320", Offset = "0x4450320", VA = "0x184451320")]
		public void SetGetterAndSetter(DataItemGetter<T> getter, DataItemSetter<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x444E210", Offset = "0x444D210", VA = "0x18444E210")]
		private void OnSetValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4452400", Offset = "0x4451400", VA = "0x184452400")]
		public DataItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DataItemInt : DataItem<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78E88E0", Offset = "0x78E78E0", VA = "0x1878E88E0")]
		public DataItemInt()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class DataItemLong : DataItem<long>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x78E8A50", Offset = "0x78E7A50", VA = "0x1878E8A50")]
		public DataItemLong()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class DataItemFloat : DataItem<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x78E88A0", Offset = "0x78E78A0", VA = "0x1878E88A0")]
		public DataItemFloat()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DataItemBool : DataItem<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x78E8820", Offset = "0x78E7820", VA = "0x1878E8820")]
		public DataItemBool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class DataItemString : DataItem<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x78E8B10", Offset = "0x78E7B10", VA = "0x1878E8B10")]
		public DataItemString()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DataItemColor : DataItem<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x78E8860", Offset = "0x78E7860", VA = "0x1878E8860")]
		public DataItemColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DataItemMaterial : DataItem<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x78E8A90", Offset = "0x78E7A90", VA = "0x1878E8A90")]
		public DataItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class DataItemSprite : DataItem<Sprite>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78E8AD0", Offset = "0x78E7AD0", VA = "0x1878E8AD0")]
		public DataItemSprite()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DataItemTexture : DataItem<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78E8B50", Offset = "0x78E7B50", VA = "0x1878E8B50")]
		public DataItemTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class DataItemVector2 : DataItem<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x78E96F0", Offset = "0x78E86F0", VA = "0x1878E96F0")]
		public DataItemVector2()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DataItemVector3 : DataItem<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78E9730", Offset = "0x78E8730", VA = "0x1878E9730")]
		public DataItemVector3()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class DataItemVector4 : DataItem<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78E9770", Offset = "0x78E8770", VA = "0x1878E9770")]
		public DataItemVector4()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DataItemList : DataItem<DataList>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "19")]
		public override void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x78E8940", Offset = "0x78E7940", VA = "0x1878E8940", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x78E8920", Offset = "0x78E7920", VA = "0x1878E8920")]
		private void RaiseListChanged(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x78E8A10", Offset = "0x78E7A10", VA = "0x1878E8A10")]
		public DataItemList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class DataItemAction : DataItem<Action>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Action dataAction;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "17")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x78E85B0", Offset = "0x78E75B0", VA = "0x1878E85B0", Slot = "21")]
		public override void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x78E8750", Offset = "0x78E7750", VA = "0x1878E8750")]
		public void SetAction(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xACEE70", Offset = "0xACDE70", VA = "0x180ACEE70")]
		private Action GetAction()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x78E87E0", Offset = "0x78E77E0", VA = "0x1878E87E0")]
		public DataItemAction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private string listName;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> ListUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x78E9FC0", Offset = "0x78E8FC0", VA = "0x1878E9FC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x78EA070", Offset = "0x78E9070", VA = "0x1878EA070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x78E9F60", Offset = "0x78E8F60", VA = "0x1878E9F60")]
		public DataList(string listName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x78E9F40", Offset = "0x78E8F40", VA = "0x1878E9F40")]
		protected void OnListUpdated()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class DataList<T> : DataList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private List<T> dataList;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<T> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x15A17E0", Offset = "0x15A07E0", VA = "0x1815A17E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T this[int key]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x4455740", Offset = "0x4454740", VA = "0x184455740")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x44557D0", Offset = "0x44547D0", VA = "0x1844557D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4455490", Offset = "0x4454490", VA = "0x184455490")]
		public DataList(string listName, int capacity = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4453AB0", Offset = "0x4452AB0", VA = "0x184453AB0")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4453730", Offset = "0x4452730", VA = "0x184453730")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4453BD0", Offset = "0x4452BD0", VA = "0x184453BD0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4454260", Offset = "0x4453260", VA = "0x184454260")]
		public void Set(IReadOnlyList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4453C00", Offset = "0x4452C00", VA = "0x184453C00")]
		public int IndexOf(T item)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[DisallowMultipleComponent]
	public class DataListItemBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private List<BaseLocalViewModel> localViewModelList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int pendingLoadableCount;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<DataListItemBinder, int> ItemLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x78E9C80", Offset = "0x78E8C80", VA = "0x1878E9C80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x78E9DE0", Offset = "0x78E8DE0", VA = "0x1878E9DE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<DataListItemBinder, int> ItemUnloaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x78E9D30", Offset = "0x78E8D30", VA = "0x1878E9D30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x78E9E90", Offset = "0x78E8E90", VA = "0x1878E9E90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x78E9A40", Offset = "0x78E8A40", VA = "0x1878E9A40")]
		public void SetData(int sourceId, int listId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x78E9860", Offset = "0x78E8860", VA = "0x1878E9860")]
		public void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78E9970", Offset = "0x78E8970", VA = "0x1878E9970")]
		private void OnItemLoaded(ILoadable item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1B78F70", Offset = "0x1B77F70", VA = "0x181B78F70")]
		public DataListItemBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class DataRecordItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Permissions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x78EA120", Offset = "0x78E9120", VA = "0x1878EA120")]
		public DataRecordItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class DataRecord : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int SourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public string SourceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public bool ExtraDataRequiredAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private List<DataRecordItem> dataItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private Dictionary<int, DataRecordItem> itemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Dictionary<string, int> itemNameToIdMap;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x78EB5D0", Offset = "0x78EA5D0", VA = "0x1878EB5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x78EA710", Offset = "0x78E9710", VA = "0x1878EA710")]
		internal void PopulateRecord(int sourceId, string sourceName, string sourceType, bool idModifiedAtRuntime, List<IDataItem> itemList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x78EA200", Offset = "0x78E9200", VA = "0x1878EA200")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x78EA580", Offset = "0x78E9580", VA = "0x1878EA580")]
		public void PopulateItemNameList(List<string> itemNames, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x78EA3D0", Offset = "0x78E93D0", VA = "0x1878EA3D0")]
		public void PopulateItemNameListForType(List<string> itemNames, string typeString, DataPermissions perms = DataPermissions.ReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x78EAF90", Offset = "0x78E9F90", VA = "0x1878EAF90")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x78EB100", Offset = "0x78EA100", VA = "0x1878EB100")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x78EB270", Offset = "0x78EA270", VA = "0x1878EB270")]
		public bool TryGetPermissionsForId(int id, [Out] DataPermissions permissions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x78EAE10", Offset = "0x78E9E10", VA = "0x1878EAE10")]
		public bool TryGetCommentForId(int id, [Out] string comment)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x78EB400", Offset = "0x78EA400", VA = "0x1878EB400")]
		public bool TryGetTypeForId(int id, [Out] string typeString)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x78EA1C0", Offset = "0x78E91C0", VA = "0x1878EA1C0")]
		public bool ArePermissionsCompatible(int itemId, DataPermissions permissionLevel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x78EB570", Offset = "0x78EA570", VA = "0x1878EB570")]
		public DataRecord()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class DataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		protected DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[ConditionalVisibility("editor_RecordRequiresExtraData", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected GameObject dataSourceInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private GameObject bindingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int fullSourceId;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x78E3AC0", Offset = "0x78E2AC0", VA = "0x1878E3AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x78EC110", Offset = "0x78EB110", VA = "0x1878EC110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x78EC250", Offset = "0x78EB250", VA = "0x1878EC250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x78EC520", Offset = "0x78EB520", VA = "0x1878EC520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x78EC160", Offset = "0x78EB160", VA = "0x1878EC160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected int SourceId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x78EC320", Offset = "0x78EB320", VA = "0x1878EC320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private bool editor_RecordRequiresExtraData
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x78EC400", Offset = "0x78EB400", VA = "0x1878EC400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x16E9020", Offset = "0x16E8020", VA = "0x1816E9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x16E9030", Offset = "0x16E8030", VA = "0x1816E9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x78EC070", Offset = "0x78EB070", VA = "0x1878EC070")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x78EC480", Offset = "0x78EB480", VA = "0x1878EC480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x78EB7C0", Offset = "0x78EA7C0", VA = "0x1878EB7C0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x78EB610", Offset = "0x78EA610", VA = "0x1878EB610")]
		public void Subscribe(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x78EBF30", Offset = "0x78EAF30", VA = "0x1878EBF30")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x78EB6F0", Offset = "0x78EA6F0", VA = "0x1878EB6F0")]
		public bool TryGetBindingInfo([Out] int sourceId, [Out] int itemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x384F8E0", Offset = "0x384E8E0", VA = "0x18384F8E0")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x384FF10", Offset = "0x384EF10", VA = "0x18384FF10")]
		public bool TrySetData<T>(T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1165260", Offset = "0x1164260", VA = "0x181165260", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x78EB750", Offset = "0x78EA750", VA = "0x1878EB750")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x78EB9F0", Offset = "0x78EA9F0", VA = "0x1878EB9F0")]
		private bool TryResolveDataSourceId([Out] int sourceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x78EBB10", Offset = "0x78EAB10", VA = "0x1878EBB10")]
		private bool TryResolveDataSourceInstance()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x78EC000", Offset = "0x78EB000", VA = "0x1878EC000")]
		public DataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class DataSourceManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class PendingSubscription
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int DataItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public DataItemUpdate OnUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public PendingSubscription()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static DataSourceManager _instance;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static Dictionary<int, IDataSource> dataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static Dictionary<int, List<PendingSubscription>> pendingSubscriptons;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static DataSourceManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x78ED080", Offset = "0x78EC080", VA = "0x1878ED080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x78EC5F0", Offset = "0x78EB5F0", VA = "0x1878EC5F0")]
		public static void RegisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x78ECD50", Offset = "0x78EBD50", VA = "0x1878ECD50")]
		public static void UnregisterDataSource(IDataSource dataSource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x78EC9E0", Offset = "0x78EB9E0", VA = "0x1878EC9E0")]
		public static void SubscribeToItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x78ECE80", Offset = "0x78EBE80", VA = "0x1878ECE80")]
		public static void UnsubscribeFromItem(int sourceId, int itemId, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x78ECCC0", Offset = "0x78EBCC0", VA = "0x1878ECCC0")]
		public static bool TryGetDataSource(int sourceId, [Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x78EC970", Offset = "0x78EB970", VA = "0x1878EC970")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public DataSourceManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void DataItemUpdate(IDataSource source, int id);
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface IDataSource
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize(string name, bool idModifiedAtRuntime);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CleanUp();

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetDataRecord(DataRecord record);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AddItem(IDataItem item);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnItemChangedInSource(int id);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SubscribeToItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UnsubscribeFromItem(int id, DataItemUpdate onUpdate);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TryGetItem<T>(int id, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TrySetItem<T>(int id, T item);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TryGetItemAtIndex<T>(int id, int index, [Out] T item);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool TrySetItemAtIndex<T>(int id, int index, T item);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalEnableAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum ConditionalEnableType
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			EnableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			DisableIfTrue,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Never
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ConditionalEnableType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionalEnableType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x78E7BC0", Offset = "0x78E6BC0", VA = "0x1878E7BC0")]
		public ConditionalEnableAttribute(string conditionPropertyName, ConditionalEnableType conditionType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class ConditionalShowAsMessageAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum MessageType
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			Info,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			Warning,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string ComparisonPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5930", VA = "0x180AF6930")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xFC12A0", Offset = "0xFC02A0", VA = "0x180FC12A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0")]
			[CompilerGenerated]
			get
			{
				return default(MessageType);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DE0", Offset = "0xACFDE0", VA = "0x180AD0DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC8C1E0", Offset = "0xC8B1E0", VA = "0x180C8C1E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x1E633A0", Offset = "0x1E623A0", VA = "0x181E633A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x78E7C70", Offset = "0x78E6C70", VA = "0x1878E7C70")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, MessageType messageType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x78E7C10", Offset = "0x78E6C10", VA = "0x1878E7C10")]
		public ConditionalShowAsMessageAttribute(string condition, ConditionResultType resultType, int targetEnumValue, MessageType messageType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum ConditionComparisonType
	{
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Enum
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ConditionResultType
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		ShowIfEquals,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		ShowIfNotEquals,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Never
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ConditionalVisibilityAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public ConditionComparisonType ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionComparisonType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAD13D0", Offset = "0xAD03D0", VA = "0x180AD13D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string ConditionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xACFB10", Offset = "0xACEB10", VA = "0x180ACFB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public ConditionResultType Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0")]
			[CompilerGenerated]
			get
			{
				return default(ConditionResultType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DE0", Offset = "0xACFDE0", VA = "0x180AD0DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TargetIntValue
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xC8C1E0", Offset = "0xC8B1E0", VA = "0x180C8C1E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1E633A0", Offset = "0x1E623A0", VA = "0x181E633A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x78E7D30", Offset = "0x78E6D30", VA = "0x1878E7D30")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x78E7CD0", Offset = "0x78E6CD0", VA = "0x1878E7CD0")]
		public ConditionalVisibilityAttribute(string conditionPropertyName, ConditionResultType conditionType, int targetEnumValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class DropdownSelectionAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string OptionsSourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string SelectedOptionPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xACFB10", Offset = "0xACEB10", VA = "0x180ACFB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x78ED0D0", Offset = "0x78EC0D0", VA = "0x1878ED0D0")]
		public DropdownSelectionAttribute(string optionsSourcePropertyName, string selectedOptionPropertyName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface ILoadable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<ILoadable> Loaded;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class BindableActionAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string Comment;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x78E51E0", Offset = "0x78E41E0", VA = "0x1878E51E0")]
		public BindableActionAttribute(int dataItemId, string comment = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class BindableDataAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int DataItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string Comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DataPermissions Permissions;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x78E5250", Offset = "0x78E4250", VA = "0x1878E5250")]
		public BindableDataAttribute(int dataItemId, string comment = "", DataPermissions permissions = DataPermissions.ReadWrite)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ViewModelAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public ViewModelAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class BaseGlobalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x78E49E0", Offset = "0x78E39E0", VA = "0x1878E49E0")]
		public BaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class BaseLocalViewModel : BaseViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		protected int indexInList;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected virtual DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x78E4A60", Offset = "0x78E3A60", VA = "0x1878E4A60", Slot = "14")]
		public virtual void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x78E4A30", Offset = "0x78E3A30", VA = "0x1878E4A30", Slot = "15")]
		public virtual void ClearBindingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x78E4B40", Offset = "0x78E3B40", VA = "0x1878E4B40")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x78E4BF0", Offset = "0x78E3BF0", VA = "0x1878E4BF0")]
		private void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x78E4CA0", Offset = "0x78E3CA0", VA = "0x1878E4CA0")]
		protected BaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class BaseViewModel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[HideInInspector]
		[SerializeReference]
		private List<IDataItem> dataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[HideInInspector]
		[SerializeField]
		private DataRecord dataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ViewModelDataSource dataSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private string recordDir;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x78E51A0", Offset = "0x78E41A0", VA = "0x1878E51A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected virtual List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual bool IsGlobalSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected virtual bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x78E4D00", Offset = "0x78E3D00", VA = "0x1878E4D00", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x78E4F70", Offset = "0x78E3F70", VA = "0x1878E4F70", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x78E4D70", Offset = "0x78E3D70", VA = "0x1878E4D70", Slot = "10")]
		public virtual void InitializeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "11")]
		protected virtual void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x78E5020", Offset = "0x78E4020", VA = "0x1878E5020")]
		protected void OnPropertyChanged([Optional][CallerMemberName] string propertyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x36A98D0", Offset = "0x36A88D0", VA = "0x1836A98D0")]
		protected void SetPropertyIfChanged<TValue>(TValue field, TValue newValue, [Optional] IEqualityComparer<TValue> equalityComparer, [Optional][CallerMemberName] string propertyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		[ContextMenu("Update Record")]
		public void UpdateRecord()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "12")]
		protected virtual void RegisterCustomDataTypes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x78E49E0", Offset = "0x78E39E0", VA = "0x1878E49E0")]
		protected BaseViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class DataItemTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static Dictionary<Type, Type> dataItemTypeCache;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x78E9210", Offset = "0x78E8210", VA = "0x1878E9210")]
		public static void RegisterDataItemType(Type underlyingDataType, Type dataItemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x78E9440", Offset = "0x78E8440", VA = "0x1878E9440")]
		public static bool TryGetDataItemType(Type underlyingDataType, [Out] Type dataItemType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x78E8B90", Offset = "0x78E7B90", VA = "0x1878E8B90")]
		private static void EnsureCacheInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x78E8C40", Offset = "0x78E7C40", VA = "0x1878E8C40")]
		private static void RegisterBuiltInTypes()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class ViewModelDataSource : BaseDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private Dictionary<string, int> itemNameToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private BaseViewModel viewModel;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x78F6250", Offset = "0x78F5250", VA = "0x1878F6250")]
		internal void InitializeFromViewModel(BaseViewModel viewModel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x78F6370", Offset = "0x78F5370", VA = "0x1878F6370")]
		public void LoadDataItems(List<IDataItem> dataItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x78F68C0", Offset = "0x78F58C0", VA = "0x1878F68C0")]
		public void OnPropertyChanged(string propertyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x78F6860", Offset = "0x78F5860", VA = "0x1878F6860", Slot = "21")]
		protected override void OnDataItemCreatedAtRuntime(IDataItem dataItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x78E49A0", Offset = "0x78E39A0", VA = "0x1878E49A0")]
		public ViewModelDataSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class ViewModelTypeCache
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static Dictionary<string, Type> viewModelTypeCache;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x78F6AF0", Offset = "0x78F5AF0", VA = "0x1878F6AF0")]
		public static void RegisterViewModelType(string viewModelTypeString, Type viewModelType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x78F6D20", Offset = "0x78F5D20", VA = "0x1878F6D20")]
		public static bool TryGetViewModelType(string typeName, [Out] Type viewModelType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x78F6A40", Offset = "0x78F5A40", VA = "0x1878F6A40")]
		private static void EnsureCacheInitialized()
		{
		}
	}
}
namespace MVVMDatabinding.Theming
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public abstract class BaseThemeBinder<T> : IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private const string noDataItemsOfTypeAvailableMessage = "<No items of type {0} to bind to>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[ConditionalVisibility("ThemeTemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private ThemeStyle styleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		protected string binderTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private bool subscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x41293E0", Offset = "0x41283E0", VA = "0x1841293E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private string BinderTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4127B10", Offset = "0x4126B10", VA = "0x184127B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4129060", Offset = "0x4128060", VA = "0x184129060", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x41276D0", Offset = "0x41266D0", VA = "0x1841276D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4128500", Offset = "0x4127500", VA = "0x184128500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x41295F0", Offset = "0x41285F0", VA = "0x1841295F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected bool IsBindingValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4127EB0", Offset = "0x4126EB0", VA = "0x184127EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4128180", Offset = "0x4127180", VA = "0x184128180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected abstract ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4123F80", Offset = "0x4122F80", VA = "0x184123F80", Slot = "7")]
		public void Bind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4127250", Offset = "0x4126250", VA = "0x184127250", Slot = "8")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x41256D0", Offset = "0x41246D0", VA = "0x1841256D0", Slot = "10")]
		public void OverrideActiveStyle(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x41245B0", Offset = "0x41235B0", VA = "0x1841245B0", Slot = "9")]
		public void OnThemeItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OnDataUpdated(T dataValue);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x41259D0", Offset = "0x41249D0", VA = "0x1841259D0")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4127570", Offset = "0x4126570", VA = "0x184127570")]
		protected BaseThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class ColorThemeBinder : BaseThemeBinder<Color>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x78E5770", Offset = "0x78E4770", VA = "0x1878E5770", Slot = "12")]
		protected override void OnDataUpdated(Color dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x78E58A0", Offset = "0x78E48A0", VA = "0x1878E58A0")]
		public ColorThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ColorTokenThemeBinder : BaseThemeBinder<ColorToken>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xFF23D0", Offset = "0xFF13D0", VA = "0x180FF23D0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x78E7150", Offset = "0x78E6150", VA = "0x1878E7150", Slot = "12")]
		protected override void OnDataUpdated(ColorToken dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x78E72B0", Offset = "0x78E62B0", VA = "0x1878E72B0")]
		public ColorTokenThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class FontSettingsBinder : BaseThemeBinder<ThemeFontSettings>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private TMP_Text text;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xFDEBB0", Offset = "0xFDDBB0", VA = "0x180FDEBB0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x78ED2D0", Offset = "0x78EC2D0", VA = "0x1878ED2D0", Slot = "12")]
		protected override void OnDataUpdated(ThemeFontSettings dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x78ED420", Offset = "0x78EC420", VA = "0x1878ED420")]
		public FontSettingsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class FontSizeThemeBinder : BaseThemeBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xE2AC50", Offset = "0xE29C50", VA = "0x180E2AC50", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x78ED4A0", Offset = "0x78EC4A0", VA = "0x1878ED4A0", Slot = "12")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x78ED5C0", Offset = "0x78EC5C0", VA = "0x1878ED5C0")]
		public FontSizeThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface IThemeBinder
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool ThemeTemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		ThemeStyle ActiveStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Bind();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Unbind();

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnThemeItemUpdate(IDataSource dataSource, int itemId);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OverrideActiveStyle(ThemeStyle newStyle);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class MaterialThemeBinder : BaseThemeBinder<Material>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF70A0", VA = "0x180DF80A0", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x78EE3F0", Offset = "0x78ED3F0", VA = "0x1878EE3F0", Slot = "12")]
		protected override void OnDataUpdated(Material dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x78EE510", Offset = "0x78ED510", VA = "0x1878EE510")]
		public MaterialThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class TextureThemeBinder : BaseThemeBinder<Texture>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private List<RawImage> targets;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xC6B960", Offset = "0xC6A960", VA = "0x180C6B960", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x78EF9F0", Offset = "0x78EE9F0", VA = "0x1878EF9F0", Slot = "12")]
		protected override void OnDataUpdated(Texture dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x78EFB00", Offset = "0x78EEB00", VA = "0x1878EFB00")]
		public TextureThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class TMPGradientThemeBinder : BaseThemeBinder<TMP_ColorGradient>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private List<TMP_Text> targets;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xFDC590", Offset = "0xFDB590", VA = "0x180FDC590", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x78EEB70", Offset = "0x78EDB70", VA = "0x1878EEB70", Slot = "12")]
		protected override void OnDataUpdated(TMP_ColorGradient dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x78EECD0", Offset = "0x78EDCD0", VA = "0x1878EECD0")]
		public TMPGradientThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class VisibilityThemeBinder : BaseThemeBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[SerializeField]
		private GameObject target;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected override ThemeItemType ThemeItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xFDCA50", Offset = "0xFDBA50", VA = "0x180FDCA50", Slot = "11")]
			get
			{
				return default(ThemeItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x78F6E90", Offset = "0x78F5E90", VA = "0x1878F6E90", Slot = "12")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x78F6F30", Offset = "0x78F5F30", VA = "0x1878F6F30")]
		public VisibilityThemeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum ThemeAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[InspectorName("0%")]
		Zero = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[InspectorName("5%")]
		Five = 5,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[InspectorName("10%")]
		Ten = 10,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[InspectorName("15%")]
		Fifteen = 15,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[InspectorName("20%")]
		Twenty = 20,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[InspectorName("25%")]
		TwentyFive = 25,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[InspectorName("30%")]
		Thirty = 30,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[InspectorName("40%")]
		Forty = 40,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[InspectorName("50%")]
		Fifty = 50,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[InspectorName("60%")]
		Sixty = 60,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[InspectorName("70%")]
		Seventy = 70,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[InspectorName("80%")]
		Eighty = 80,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[InspectorName("90%")]
		Ninety = 90,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[InspectorName("100%")]
		OneHundred = 100
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ColorToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private ThemeAlpha Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Color? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private ThemeAlpha prevOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x78E76D0", Offset = "0x78E66D0", VA = "0x1878E76D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x78E7450", Offset = "0x78E6450", VA = "0x1878E7450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x78E7830", Offset = "0x78E6830", VA = "0x1878E7830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x78E7990", Offset = "0x78E6990", VA = "0x1878E7990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x78E7400", Offset = "0x78E6400", VA = "0x1878E7400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x78E7330", Offset = "0x78E6330", VA = "0x1878E7330")]
		private void UpdateColor(Color newColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x78E73E0", Offset = "0x78E63E0", VA = "0x1878E73E0")]
		public ColorToken()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class ColorTokenDefinition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Color Color;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x78E5A10", Offset = "0x78E4A10", VA = "0x1878E5A10")]
		public ColorTokenDefinition(int id, string name, Color color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CreateAssetMenu(fileName = "ColorTokenGroup", menuName = "MVVM/Theming/Color Token Group")]
	public class ColorTokenGroup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private List<ColorTokenDefinition> colorDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private List<ColorTokenReference> colorTokenReferences;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x78E6A70", Offset = "0x78E5A70", VA = "0x1878E6A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x78E5AA0", Offset = "0x78E4AA0", VA = "0x1878E5AA0")]
		public List<string> GetColorTokenNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x78E6100", Offset = "0x78E5100", VA = "0x1878E6100")]
		public bool TryGetColorTokenByName(string name, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x78E5E40", Offset = "0x78E4E40", VA = "0x1878E5E40")]
		public bool TryGetColorTokenById(int id, [Out] ColorTokenDefinition colorDefinition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x78E66E0", Offset = "0x78E56E0", VA = "0x1878E66E0")]
		public bool TryGetNameForId(int id, [Out] string name)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x78E6400", Offset = "0x78E5400", VA = "0x1878E6400")]
		public bool TryGetIdForName(string name, [Out] int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public void Editor_UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x78E69B0", Offset = "0x78E59B0", VA = "0x1878E69B0")]
		public ColorTokenGroup()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class ColorTokenReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		public int Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private ColorTokenGroup ColorGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[ConditionalVisibility("ColorRecordValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ColorTokenNames", "SelectedColorTokenName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public ColorTokenDefinition ColorTokenDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x78E6B70", Offset = "0x78E5B70", VA = "0x1878E6B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private List<string> ColorTokenNames
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x78E6CD0", Offset = "0x78E5CD0", VA = "0x1878E6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private string SelectedColorTokenName
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x78E6F40", Offset = "0x78E5F40", VA = "0x1878E6F40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x78E70A0", Offset = "0x78E60A0", VA = "0x1878E70A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private bool ColorRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x78E6B20", Offset = "0x78E5B20", VA = "0x1878E6B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x78E6AD0", Offset = "0x78E5AD0", VA = "0x1878E6AD0")]
		public ColorTokenReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CreateAssetMenu(fileName = "Theme", menuName = "MVVM/Theming/Theme")]
	public class Theme : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public List<ThemeStyle> ThemeStyleList;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x78F60E0", Offset = "0x78F50E0", VA = "0x1878F60E0")]
		public void Editor_LoadTheme()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xE15560", Offset = "0xE14560", VA = "0x180E15560")]
		public Theme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ThemeBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeReference]
		private List<IThemeBinder> binders;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x78EFE40", Offset = "0x78EEE40", VA = "0x1878EFE40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x78EFFE0", Offset = "0x78EEFE0", VA = "0x1878EFFE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x78EFB80", Offset = "0x78EEB80", VA = "0x1878EFB80")]
		public void AddBinder(IThemeBinder binder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x78F03A0", Offset = "0x78EF3A0", VA = "0x1878F03A0")]
		public void ReplaceBinderAtIndex(IThemeBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x78EFC80", Offset = "0x78EEC80", VA = "0x1878EFC80")]
		public void ApplyStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x78F0180", Offset = "0x78EF180", VA = "0x1878F0180")]
		public void RemoveStyleOverride(ThemeStyle targetStyle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public ThemeBinder()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ThemeDataResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		protected ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		protected int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[ConditionalVisibility("editor_IsCommentEmpty", ConditionResultType.ShowIfNotEquals)]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private Type targetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private ThemeStyleApplier applier;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public ThemeStyleTemplate ThemeTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private bool editor_IsCommentEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x78F15E0", Offset = "0x78F05E0", VA = "0x1878F15E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool DataRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x78F1440", Offset = "0x78F0440", VA = "0x1878F1440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x78F1510", Offset = "0x78F0510", VA = "0x1878F1510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x78F1690", Offset = "0x78F0690", VA = "0x1878F1690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x78F1490", Offset = "0x78F0490", VA = "0x1878F1490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action DataUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x78F13A0", Offset = "0x78F03A0", VA = "0x1878F13A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x78F15F0", Offset = "0x78F05F0", VA = "0x1878F15F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x78F0D80", Offset = "0x78EFD80", VA = "0x1878F0D80")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x78F0570", Offset = "0x78EF570", VA = "0x1878F0570")]
		public void Subscribe(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x78F1050", Offset = "0x78F0050", VA = "0x1878F1050")]
		public void Unsubscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DED660", Offset = "0x3DEC660", VA = "0x183DED660")]
		public bool TryGetData<T>([Out] T data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1164EE0", Offset = "0x1163EE0", VA = "0x181164EE0", Slot = "4")]
		public virtual void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x78F0C20", Offset = "0x78EFC20", VA = "0x1878F0C20")]
		protected bool TryGetDataSource([Out] IDataSource dataSource)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x78F0D20", Offset = "0x78EFD20", VA = "0x1878F0D20")]
		private bool TryGetStyle(ThemeStyleApplier applier, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xACFF40", Offset = "0xACEF40", VA = "0x180ACFF40")]
		public void SetDataType(Type dataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x78F0410", Offset = "0x78EF410", VA = "0x1878F0410")]
		public void ApplyStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x78F04C0", Offset = "0x78EF4C0", VA = "0x1878F04C0")]
		public void RemoveStyleOverride(ThemeStyle targetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x78F1340", Offset = "0x78F0340", VA = "0x1878F1340")]
		public ThemeDataResolver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ThemeDataSource : IDataSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private Dictionary<int, List<DataItemUpdate>> subscriberLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private Dictionary<int, ThemeItem> dataItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool idModifiedAtRuntime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private ThemeVariant activeVariant;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool IdModifiedAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1B95AF0", Offset = "0x1B94AF0", VA = "0x181B95AF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x78F1760", Offset = "0x78F0760", VA = "0x1878F1760", Slot = "11")]
		public void AddItem(IDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x78F1FC0", Offset = "0x78F0FC0", VA = "0x1878F1FC0")]
		public bool TryGetThemeItem(int id, [Out] ThemeItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "9")]
		public DataRecord GenerateRecord(string recordPath, List<IDataItem> dataItems, string sourceType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x78F1A00", Offset = "0x78F0A00", VA = "0x1878F1A00", Slot = "7")]
		public void Initialize(string name, bool idModifiedAtRuntime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x78F1980", Offset = "0x78F0980", VA = "0x1878F1980", Slot = "8")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x78F1C40", Offset = "0x78F0C40", VA = "0x1878F1C40")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "10")]
		public void SetDataRecord(DataRecord record)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x78F1AE0", Offset = "0x78F0AE0", VA = "0x1878F1AE0", Slot = "12")]
		public void OnItemChangedInSource(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x78F1DF0", Offset = "0x78F0DF0", VA = "0x1878F1DF0", Slot = "13")]
		public void SubscribeToItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x78F2030", Offset = "0x78F1030", VA = "0x1878F2030", Slot = "14")]
		public void UnsubscribeFromItem(int id, DataItemUpdate onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE6A0", Offset = "0x3DED6A0", VA = "0x183DEE6A0", Slot = "15")]
		public bool TryGetItem<T>(int id, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "16")]
		public bool TrySetItem<T>(int id, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDB00", Offset = "0x3DECB00", VA = "0x183DEDB00", Slot = "17")]
		public bool TryGetItemAtIndex<T>(int id, int index, [Out] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "18")]
		public bool TrySetItemAtIndex<T>(int id, int index, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x78F20D0", Offset = "0x78F10D0", VA = "0x1878F20D0")]
		public ThemeDataSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class ThemeFontSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TMP_FontAsset FontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public bool AutosizeFont;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfNotEquals)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MinSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[ConditionalVisibility("AutosizeFont", ConditionResultType.ShowIfEquals)]
		public int MaxSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public FontStyles FontStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public float LineHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public float CharacterSpacing;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x78F21C0", Offset = "0x78F11C0", VA = "0x1878F21C0")]
		public ThemeFontSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ThemeItem : IDataItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ThemeVariant variant;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xADCB20", Offset = "0xADBB20", VA = "0x180ADCB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x78F2560", Offset = "0x78F1560", VA = "0x1878F2560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public DataPermissions Permissions
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "7")]
			get
			{
				return default(DataPermissions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string Comment
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xACFB10", Offset = "0xACEB10", VA = "0x180ACFB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<int> ValueChangedWithId
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x78F24B0", Offset = "0x78F14B0", VA = "0x1878F24B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x78F25B0", Offset = "0x78F15B0", VA = "0x1878F25B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "11")]
		public void EditorInit(UnityEngine.Object dataSourceOwner, PropertyInfo propertyInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "12")]
		public void EditorCleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x78F21E0", Offset = "0x78F11E0", VA = "0x1878F21E0", Slot = "9")]
		public void Initialize(int id, string name, DataPermissions permissions, string comment = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x78F2220", Offset = "0x78F1220", VA = "0x1878F2220", Slot = "14")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "13")]
		public void RuntimeInit(UnityEngine.Object dataSourceOwner, bool fullInit = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "15")]
		public void SyncItemWithSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x78F2260", Offset = "0x78F1260", VA = "0x1878F2260")]
		public void SetThemeItemValue(ThemeStyleValue styleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x78F23E0", Offset = "0x78F13E0", VA = "0x1878F23E0")]
		public void SetThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF790", Offset = "0x3DEE790", VA = "0x183DEF790")]
		public bool TryGetItem<T>([Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x78F2440", Offset = "0x78F1440", VA = "0x1878F2440")]
		public ThemeItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ThemeManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private static readonly string themingSourcePrefix;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static ThemeManager instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private List<Theme> defaultThemeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<int, ThemeDataSource> themeDataSourceLookup;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public static bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x78F3390", Offset = "0x78F2390", VA = "0x1878F3390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static ThemeManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x78F3340", Offset = "0x78F2340", VA = "0x1878F3340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public ThemeVariant ActiveVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xACFF50", Offset = "0xACEF50", VA = "0x180ACFF50")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xACFF80", Offset = "0xACEF80", VA = "0x180ACFF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event Action ThemeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x78F3240", Offset = "0x78F2240", VA = "0x1878F3240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x78F3410", Offset = "0x78F2410", VA = "0x1878F3410")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x78F2810", Offset = "0x78F1810", VA = "0x1878F2810")]
		public static int GetThemeSourceId(string recordName)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x78F2660", Offset = "0x78F1660", VA = "0x1878F2660")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x78F2FF0", Offset = "0x78F1FF0", VA = "0x1878F2FF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x78F2DD0", Offset = "0x78F1DD0", VA = "0x1878F2DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x78F2920", Offset = "0x78F1920", VA = "0x1878F2920")]
		public void LoadTheme(Theme theme)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x78F26D0", Offset = "0x78F16D0", VA = "0x1878F26D0")]
		public void ChangeThemeVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x78F2890", Offset = "0x78F1890", VA = "0x1878F2890")]
		public bool IsStyleLoaded(ThemeStyle themeStyle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x78F31C0", Offset = "0x78F21C0", VA = "0x1878F31C0")]
		public ThemeManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum ThemeVariant
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Dark,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		HighContrast
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface IThemeValue
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetVariant(ThemeVariant variant);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ThemeValue : IThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[HideInInspector]
		[SerializeField]
		protected bool excludedFromVariants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		protected bool referenceStyleValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		protected ThemeStyle themeStyleReference;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected ThemeVariant activeVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
			[CompilerGenerated]
			get
			{
				return default(ThemeVariant);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xADCB20", Offset = "0xADBB20", VA = "0x180ADCB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public abstract Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool ShowVariantValues
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1F5EB40", Offset = "0x1F5DB40", VA = "0x181F5EB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool ShowSingleValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x78F60C0", Offset = "0x78F50C0", VA = "0x1878F60C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool ExcludedFromVariants
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xAD8BC0", Offset = "0xAD7BC0", VA = "0x180AD8BC0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xAD8BB0", Offset = "0xAD7BB0", VA = "0x180AD8BB0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x78F6030", Offset = "0x78F5030", VA = "0x1878F6030", Slot = "8")]
		public void SetVariant(ThemeVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x78F6050", Offset = "0x78F5050", VA = "0x1878F6050")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class ThemeValue<T> : ThemeValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T light;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T dark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[ConditionalVisibility("ShowVariantValues", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T highContrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[ConditionalVisibility("ShowSingleValue", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[ConditionalVisibility("referenceStyleValue", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private ThemeValue<T> cachedReferenceValue;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x644AE10", Offset = "0x6449E10", VA = "0x18644AE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x644D500", Offset = "0x644C500", VA = "0x18644D500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x6451CB0", Offset = "0x6450CB0", VA = "0x186451CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x64509B0", Offset = "0x644F9B0", VA = "0x1864509B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x4242D60", Offset = "0x4241D60", VA = "0x184242D60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6447C70", Offset = "0x6446C70", VA = "0x186447C70")]
		private bool HasCircularDependency(ThemeValue<T> themeValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x64499C0", Offset = "0x64489C0", VA = "0x1864499C0")]
		protected ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ColorThemeValue : ThemeValue<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x78E58E0", Offset = "0x78E48E0", VA = "0x1878E58E0")]
		public ColorThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class GradientThemeValue : ThemeValue<Gradient>
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x78EDCD0", Offset = "0x78ECCD0", VA = "0x1878EDCD0")]
		public GradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class MaterialThemeValue : ThemeValue<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x78EE550", Offset = "0x78ED550", VA = "0x1878EE550")]
		public MaterialThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TextureThemeValue : ThemeValue<Texture>
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x78EFB40", Offset = "0x78EEB40", VA = "0x1878EFB40")]
		public TextureThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class IntThemeValue : ThemeValue<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x78EDF40", Offset = "0x78ECF40", VA = "0x1878EDF40")]
		public IntThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class FloatThemeValue : ThemeValue<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x78ED290", Offset = "0x78EC290", VA = "0x1878ED290")]
		public FloatThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class Vector4ThemeValue : ThemeValue<Vector4>
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x78F6210", Offset = "0x78F5210", VA = "0x1878F6210")]
		public Vector4ThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class TMPGradientThemeValue : ThemeValue<TMP_ColorGradient>
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x78EED10", Offset = "0x78EDD10", VA = "0x1878EED10")]
		public TMPGradientThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class FontSettingsThemeValue : ThemeValue<ThemeFontSettings>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x78ED460", Offset = "0x78EC460", VA = "0x1878ED460")]
		public FontSettingsThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class BoolThemeValue : ThemeValue<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x78E52D0", Offset = "0x78E42D0", VA = "0x1878E52D0")]
		public BoolThemeValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class ColorTokenValue : ThemeValue<ColorToken>
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x78E72F0", Offset = "0x78E62F0", VA = "0x1878E72F0")]
		public ColorTokenValue()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class ThemeStyleValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		private ThemeStyleTemplate themeTemplate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[DropdownSelection("ItemNameOptions", "SelectedItemName")]
		[SerializeField]
		private int itemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[ConditionalVisibility(null, ConditionResultType.Never)]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
		[SerializeField]
		private ThemeItemType itemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeReference]
		private IThemeValue themeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private List<string> availableItemNames;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool ThemeRecordValid
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x78F5E60", Offset = "0x78F4E60", VA = "0x1878F5E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected List<string> ItemNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x78F5CA0", Offset = "0x78F4CA0", VA = "0x1878F5CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x78F5D20", Offset = "0x78F4D20", VA = "0x1878F5D20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x78F5EB0", Offset = "0x78F4EB0", VA = "0x1878F5EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public IThemeValue ThemeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public UnityEvent ValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xACFF40", Offset = "0xACEF40", VA = "0x180ACFF40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x78F5880", Offset = "0x78F4880", VA = "0x1878F5880")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x78F5970", Offset = "0x78F4970", VA = "0x1878F5970")]
		public void RaiseValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x78F5990", Offset = "0x78F4990", VA = "0x1878F5990")]
		private void TryPopulateItemNames()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x78F5800", Offset = "0x78F4800", VA = "0x1878F5800")]
		public void Editor_SetTemplate(ThemeStyleTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		public bool Editor_OnValidate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public void UpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7573B50", Offset = "0x7572B50", VA = "0x187573B50")]
		public void ResetAndUpdateThemeValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x78F5C60", Offset = "0x78F4C60", VA = "0x1878F5C60")]
		public ThemeStyleValue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CreateAssetMenu(fileName = "ThemeStyle", menuName = "MVVM/Theming/Theme Style")]
	public class ThemeStyle : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private string styleName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private List<ThemeStyleValue> themeStyleValues;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public string StyleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ThemeStyleTemplate Template
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public List<ThemeStyleValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x78F5FB0", Offset = "0x78F4FB0", VA = "0x1878F5FB0")]
		public ThemeStyle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ThemeStylePicker
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private const string noStylesMatchingTemplateAvailableMessage = "<No styles of template {0} found>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private ThemeStyleTemplate template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[ConditionalVisibility("TemplateValid", ConditionResultType.ShowIfEquals)]
		[DropdownSelection("StyleNameOptions", "SelectedItemName")]
		[SerializeField]
		private ThemeStyle themeStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<string, ThemeStyle> cachedStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private List<string> styleNameOptions;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected bool TemplateValid
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x78F49C0", Offset = "0x78F39C0", VA = "0x1878F49C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public List<string> StyleNameOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x78F47C0", Offset = "0x78F37C0", VA = "0x1878F47C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		private string editor_notAvailableMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x78F4A10", Offset = "0x78F3A10", VA = "0x1878F4A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected string SelectedItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x78F4660", Offset = "0x78F3660", VA = "0x1878F4660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x78F4B80", Offset = "0x78F3B80", VA = "0x1878F4B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public ThemeStyle Style
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public bool Editor_Subscribed
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xC93980", Offset = "0xC92980", VA = "0x180C93980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		internal event Action<ThemeStylePicker> ThemeStyleChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x78F45B0", Offset = "0x78F35B0", VA = "0x1878F45B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x78F4AD0", Offset = "0x78F3AD0", VA = "0x1878F4AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x78F44B0", Offset = "0x78F34B0", VA = "0x1878F44B0")]
		internal void Editor_OnValidate(string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private void Editor_PopulateStyleNameOptions([Optional] string[] themeStyleGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x78F4530", Offset = "0x78F3530", VA = "0x1878F4530")]
		public ThemeStylePicker()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ThemeStyleApplier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private List<ThemeStylePicker> themeStyles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private HashSet<ThemeStyle> styleOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IReadOnlyList<ThemeBinder> runtimeBinders;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ThemeStyle> StyleOverrideApplied
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x78F41F0", Offset = "0x78F31F0", VA = "0x1878F41F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x78F4350", Offset = "0x78F3350", VA = "0x1878F4350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ThemeStyle> StyleOverrideRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x78F42A0", Offset = "0x78F32A0", VA = "0x1878F42A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x78F4400", Offset = "0x78F3400", VA = "0x1878F4400")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x78F3CD0", Offset = "0x78F2CD0", VA = "0x1878F3CD0")]
		public bool TryFindStyleForItem(ThemeStyleTemplate template, int itemId, [Out] ThemeStyle style)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x78F3510", Offset = "0x78F2510", VA = "0x1878F3510")]
		public void ApplyRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x78F3A80", Offset = "0x78F2A80", VA = "0x1878F3A80")]
		public void RemoveRuntimeStyleOverride(ThemeStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x78F4170", Offset = "0x78F3170", VA = "0x1878F4170")]
		public ThemeStyleApplier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum ThemeItemType
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Gradient,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Material,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Vector4,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		TMPGradient,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		FontSettings,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		ColorToken
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CreateAssetMenu(fileName = "ThemeStyleTemplate", menuName = "MVVM/Theming/Theme Style Template")]
	public class ThemeStyleTemplate : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public class ThemeTemplateItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			[ConditionalEnable(null, ConditionalEnableAttribute.ConditionalEnableType.Never)]
			public int Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public ThemeItemType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public bool ExcludeFromVariants;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x78F5FF0", Offset = "0x78F4FF0", VA = "0x1878F5FF0")]
			public ThemeTemplateItem()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private List<ThemeTemplateItem> templateItems;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public List<ThemeTemplateItem> TemplateItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x78F57C0", Offset = "0x78F47C0", VA = "0x1878F57C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x78F4C50", Offset = "0x78F3C50", VA = "0x1878F4C50")]
		public static ThemeItemType GetThemeItemType(Type targetType)
		{
			return default(ThemeItemType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x78F52D0", Offset = "0x78F42D0", VA = "0x1878F52D0")]
		public void PopulateItemNameList(List<string> itemNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x78F5020", Offset = "0x78F4020", VA = "0x1878F5020")]
		public void PopulateItemNameListForType(List<string> itemNames, ThemeItemType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x78F5170", Offset = "0x78F4170", VA = "0x1878F5170")]
		public void PopulateItemNameListForType(List<string> itemNames, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x78F5620", Offset = "0x78F4620", VA = "0x1878F5620")]
		public bool TryGetInfoForName(string name, [Out] int id, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x78F5460", Offset = "0x78F4460", VA = "0x1878F5460")]
		public bool TryGetInfoForId(int id, [Out] string name, [Out] ThemeItemType itemType, [Out] bool excludeFromVariants)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE15560", Offset = "0xE14560", VA = "0x180E15560")]
		public ThemeStyleTemplate()
		{
		}
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
