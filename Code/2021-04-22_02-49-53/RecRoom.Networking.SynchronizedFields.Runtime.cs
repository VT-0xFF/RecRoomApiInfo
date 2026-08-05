using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Networking.DataTypes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class SynchronizedField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1822880", Offset = "0x1821880", VA = "0x181822880")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1821DF0", Offset = "0x1820DF0", VA = "0x181821DF0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1822590", Offset = "0x1821590", VA = "0x181822590")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, bool enforceInitialValue, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class SynchronizedField<T1, T2> : SynchronizedFieldBase<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x18264F0", Offset = "0x18254F0", VA = "0x1818264F0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x18262E0", Offset = "0x18252E0", VA = "0x1818262E0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1826BE0", Offset = "0x1825BE0", VA = "0x181826BE0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, bool enforceInitialValue, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class SynchronizedField<T1, T2, T3> : SynchronizedFieldBase<T1, T2, T3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x18295A0", Offset = "0x18285A0", VA = "0x1818295A0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1828A60", Offset = "0x1827A60", VA = "0x181828A60")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1828DD0", Offset = "0x1827DD0", VA = "0x181828DD0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, SetterPermissionMode permissionMode, bool enforceInitialValue, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SynchronizedField<T1, T2, T3, T4> : SynchronizedFieldBase<T1, T2, T3, T4>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x182A340", Offset = "0x1829340", VA = "0x18182A340")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1829F90", Offset = "0x1828F90", VA = "0x181829F90")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SynchronizedField<T1, T2, T3, T4, T5> : SynchronizedFieldBase<T1, T2, T3, T4, T5>
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x182B7E0", Offset = "0x182A7E0", VA = "0x18182B7E0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x182B590", Offset = "0x182A590", VA = "0x18182B590")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SynchronizedPlayerField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x182BDD0", Offset = "0x182ADD0", VA = "0x18182BDD0")]
		public SynchronizedPlayerField(INetworkedPlayer player, string key, T defaultValue, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IContextSynchronizedFieldFactory
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SynchronizedField<T1> ForContext<T1>(string key, T1 defaultValue1, SetterPermissionMode permissionMode, [Optional] Action callback);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ContextSynchronizedFieldFactory : IContextSynchronizedFieldFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly ISynchronizedFieldNetworkBacking networkBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly ISynchronizedFieldContext context;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4E8460", Offset = "0x4E7460", VA = "0x1804E8460")]
		public ContextSynchronizedFieldFactory(ISynchronizedFieldNetworkBacking networkBacking, ISynchronizedFieldContext syncFieldContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x18D7050", Offset = "0x18D6050", VA = "0x1818D7050", Slot = "4")]
		public SynchronizedField<T1> ForContext<T1>(string key, T1 defaultValue1, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ISynchronizedFieldContext
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RegisterOnDestroyingListener(Action onDestroyingCallback);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UnRegisterOnDestroyingListener(Action onDestroyingCallback);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RegisterOnDestroyedListener(Action onDestroyedCallback);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UnRegisterOnDestroyedListener(Action onDestroyedCallback);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ISynchronizedFieldContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x351E8E0", Offset = "0x351D8E0", VA = "0x18351E8E0")]
		public static bool IsNullOrDestroyed(this ISynchronizedFieldContext context)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface ISynchronizedFieldNetworkBacking : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object GetRoomValue(string key);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object GetPlayerValue(INetworkedPlayer photonPlayer, string key);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetRoomValue(string key, object newValue);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetPlayerValue(INetworkedPlayer photonPlayer, string key, object newValue);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AddCallback([CanBeNull] INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RemoveCallback([CanBeNull] INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		T FromSerializableObject<T>(object value);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		object ToSerializableObject<T>(T defaultValue);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void SendPendingRoomUpdates();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum SetterPermissionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		AUTHORITY,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		MASTER,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		ANYONE,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		MASTER_OR_AUTHORITY
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class SynchronizedField : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static Stack<ISynchronizedFieldNetworkBacking> networkBackings;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static bool RemoveDefaultEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly INetworkedPlayer player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly ISynchronizedFieldContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly string key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected readonly SetterPermissionMode permissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected readonly Action callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected ISynchronizedFieldNetworkBacking NetworkBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool lastSetLocally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool suppressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly string callbackProfilingLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool alreadyDisposed;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static ISynchronizedFieldNetworkBacking GlobalNetworkBacking
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x351FF70", Offset = "0x351EF70", VA = "0x18351FF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected virtual object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x4083F0", Offset = "0x4073F0", VA = "0x1804083F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x54EF00", Offset = "0x54DF00", VA = "0x18054EF00", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x351FFE0", Offset = "0x351EFE0", VA = "0x18351FFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int Revision
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4267D0", Offset = "0x4257D0", VA = "0x1804267D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4250F0", Offset = "0x4240F0", VA = "0x1804250F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x40E370", Offset = "0x40D370", VA = "0x18040E370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x351F100", Offset = "0x351E100", VA = "0x18351F100")]
		public static void InitializeNetworkBacking(ISynchronizedFieldNetworkBacking synchronizedFieldNetworkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool EqualsDefaultValue();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x351FC60", Offset = "0x351EC60", VA = "0x18351FC60")]
		protected SynchronizedField(INetworkedPlayer player, ISynchronizedFieldContext context, string key, SetterPermissionMode permissionMode, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x351EBE0", Offset = "0x351DBE0", VA = "0x18351EBE0", Slot = "1")]
		~SynchronizedField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x351E9F0", Offset = "0x351D9F0", VA = "0x18351E9F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x351F210", Offset = "0x351E210", VA = "0x18351F210")]
		protected void Initialize(bool enforceInitialValue, object initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x351F910", Offset = "0x351E910", VA = "0x18351F910")]
		protected void Set(object newValue, bool checkPermission = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x351E930", Offset = "0x351D930", VA = "0x18351E930")]
		private void AddCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x351F850", Offset = "0x351E850", VA = "0x18351F850")]
		private void RemoveCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x351EFD0", Offset = "0x351DFD0", VA = "0x18351EFD0")]
		public bool HasPrimaryPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x351EE90", Offset = "0x351DE90", VA = "0x18351EE90")]
		public bool HasPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x351ED50", Offset = "0x351DD50", VA = "0x18351ED50")]
		private bool HasPermissionToEnforceInitialValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x351F650", Offset = "0x351E650", VA = "0x18351F650")]
		private void OnPhotonPropertyChanged(object newValue, int setterId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x351F760", Offset = "0x351E760", VA = "0x18351F760")]
		private void OnValueChanged(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x351ECD0", Offset = "0x351DCD0", VA = "0x18351ECD0")]
		protected static string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x351EC50", Offset = "0x351DC50", VA = "0x18351EC50")]
		protected static string FormatRoomDataPhotonObjectKey(ISynchronizedFieldContext context, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x351F500", Offset = "0x351E500", VA = "0x18351F500")]
		public static bool ObjectsAreEqual(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class SynchronizedFieldNetworkBackingBase<TProps> : ISynchronizedFieldNetworkBacking, IDisposable where TProps : class, IDictionary<object, object>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string SETTER_INFO_KEY = "S";

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const int MAX_UPDATES_PER_FLUSH = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly TProps pendingRoomPropertyUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly List<string> pendingRoomPropertyUpdatesOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly TProps pendingPlayerPropertyUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<string> pendingPlayerPropertyUpdatesOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		protected readonly Dictionary<string, Action<object, int>> RoomPropertyCallbackMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		protected readonly Dictionary<INetworkedPlayer, Dictionary<string, Action<object, int>>> PlayerPropertyCallbackMaps;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract TProps RoomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public abstract bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3E1600", Offset = "0x3E0600", VA = "0x1803E1600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x14E9910", Offset = "0x14E8910", VA = "0x1814E9910")]
		public void SetLocalPlayerValue<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x30E9A80", Offset = "0x30E8A80", VA = "0x1830E9A80", Slot = "11")]
		public void SetPlayerValue(INetworkedPlayer player, string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x30E8BF0", Offset = "0x30E7BF0", VA = "0x1830E8BF0", Slot = "9")]
		public object GetPlayerValue(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x30E9B60", Offset = "0x30E8B60", VA = "0x1830E9B60", Slot = "10")]
		public void SetRoomValue(string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x30E8CE0", Offset = "0x30E7CE0", VA = "0x1830E8CE0", Slot = "8")]
		public object GetRoomValue(string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x30E8060", Offset = "0x30E7060", VA = "0x1830E8060", Slot = "12")]
		public void AddCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x30E96A0", Offset = "0x30E86A0", VA = "0x1830E96A0", Slot = "13")]
		public void RemoveCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x30E9CC0", Offset = "0x30E8CC0", VA = "0x1830E9CC0")]
		private void UnregisterAllRoomPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x30E9C70", Offset = "0x30E8C70", VA = "0x1830E9C70")]
		private void UnregisterAllPlayerPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x30E9D10", Offset = "0x30E8D10", VA = "0x1830E9D10")]
		private void UnregisterPlayerPropertyCallbacks(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x30E9550", Offset = "0x30E8550", VA = "0x1830E9550")]
		protected void ProcessPhotonPlayerDisconnected(INetworkedPlayer otherPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x30E9450", Offset = "0x30E8450", VA = "0x1830E9450")]
		protected void ProcessLocalPlayerLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x30E9670", Offset = "0x30E8670", VA = "0x1830E9670")]
		protected void ProcessRoomPropertyUpdates(TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x30E94C0", Offset = "0x30E84C0", VA = "0x1830E94C0")]
		protected void ProcessMasterClientSwitched(INetworkedPlayer newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x30E95D0", Offset = "0x30E85D0", VA = "0x1830E95D0")]
		protected void ProcessPlayerPropertyUpdates(INetworkedPlayer player, TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x30E9070", Offset = "0x30E8070", VA = "0x1830E9070")]
		private void InvokeCallbacksForProperties(TProps propertiesThatChanged, Dictionary<string, Action<object, int>> callbackMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x30E8350", Offset = "0x30E7350", VA = "0x1830E8350")]
		private void AddToCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x30E97C0", Offset = "0x30E87C0", VA = "0x1830E97C0")]
		private void RemoveFromCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x30E9990", Offset = "0x30E8990", VA = "0x1830E9990", Slot = "16")]
		public void SendPendingRoomUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract void SendPendingRoomUpdatesInternal(TProps pendingRoomPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x30E98C0", Offset = "0x30E88C0", VA = "0x1830E98C0")]
		public void SendPendingPlayerUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract void SendPendingPlayerUpdatesInternal(TProps pendingPlayerPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30E8160", Offset = "0x30E7160", VA = "0x1830E8160")]
		private void AddSetterInfoToPendingUpdates(TProps pendingUpdates, List<string> pendingUpdateOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x30E8DF0", Offset = "0x30E7DF0", VA = "0x1830E8DF0")]
		private void GetSetterInfoFromPropertyUpdate(TProps propertiesThatChanged, out int setterId, out string[] propertySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x30E8000", Offset = "0x30E7000", VA = "0x1830E8000")]
		public void AbandonPendingRoomPropertyUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x30E8780", Offset = "0x30E7780", VA = "0x1830E8780")]
		public void ClearAllRoomPropertiesForPlayer(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x30E8440", Offset = "0x30E7440", VA = "0x1830E8440")]
		public void ClearAllRoomPropertiesForMissingPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract HashSet<string> GetPlayerIdsInRoom();

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x30E8810", Offset = "0x30E7810", VA = "0x1830E8810")]
		private void ClearAllRoomPropertiesForPrefix(string prefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x30E8B70", Offset = "0x30E7B70", VA = "0x1830E8B70")]
		protected string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract object ToSerializableObject<T>(T value);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract T FromSerializableObject<T>(object value);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3D8940", Offset = "0x3D7940", VA = "0x1803D8940", Slot = "28")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x30E8A80", Offset = "0x30E7A80", VA = "0x1830E8A80", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3D8940", Offset = "0x3D7940", VA = "0x1803D8940", Slot = "29")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x30E9D70", Offset = "0x30E8D70", VA = "0x1830E9D70")]
		protected SynchronizedFieldNetworkBackingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class SynchronizedFieldBase<T1> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private T1 defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3117BC0", Offset = "0x3116BC0", VA = "0x183117BC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3118380", Offset = "0x3117380", VA = "0x183118380", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x30D8F80", Offset = "0x30D7F80", VA = "0x1830D8F80", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3117E40", Offset = "0x3116E40", VA = "0x183117E40", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3114A20", Offset = "0x3113A20", VA = "0x183114A20", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3117040", Offset = "0x3116040", VA = "0x183117040")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x16ECF00", Offset = "0x16EBF00", VA = "0x1816ECF00")]
		public T1 Get()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x31161B0", Offset = "0x31151B0", VA = "0x1831161B0")]
		public void Set(T1 newValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class SynchronizedFieldBase<T1, T2> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private T2 defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x311FB30", Offset = "0x311EB30", VA = "0x18311FB30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3120F00", Offset = "0x311FF00", VA = "0x183120F00", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x30D8FA0", Offset = "0x30D7FA0", VA = "0x1830D8FA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x30D9E70", Offset = "0x30D8E70", VA = "0x1830D9E70", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x30D8F80", Offset = "0x30D7F80", VA = "0x1830D8F80", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x31206E0", Offset = "0x311F6E0", VA = "0x1831206E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3118740", Offset = "0x3117740", VA = "0x183118740", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x311ED30", Offset = "0x311DD30", VA = "0x18311ED30")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x16ECF00", Offset = "0x16EBF00", VA = "0x1816ECF00")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3119FB0", Offset = "0x3118FB0", VA = "0x183119FB0")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x30D4400", Offset = "0x30D3400", VA = "0x1830D4400")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x311A650", Offset = "0x3119650", VA = "0x18311A650")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x311B000", Offset = "0x311A000", VA = "0x18311B000")]
		public void Set(T1 newValue1, T2 newValue2)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class SynchronizedFieldBase<T1, T2, T3> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private T3 defaultValue3;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x544870", Offset = "0x543870", VA = "0x180544870", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xECBAD0", Offset = "0xECAAD0", VA = "0x180ECBAD0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x680130", Offset = "0x67F130", VA = "0x180680130", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6803A0", Offset = "0x67F3A0", VA = "0x1806803A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9DD4E0", Offset = "0x9DC4E0", VA = "0x1809DD4E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x31229F0", Offset = "0x31219F0", VA = "0x1831229F0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x30D8F80", Offset = "0x30D7F80", VA = "0x1830D8F80", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3122610", Offset = "0x3121610", VA = "0x183122610", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3120F20", Offset = "0x311FF20", VA = "0x183120F20", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x31220D0", Offset = "0x31210D0", VA = "0x1831220D0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x30DB3C0", Offset = "0x30DA3C0", VA = "0x1830DB3C0")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3121430", Offset = "0x3120430", VA = "0x183121430")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3119F00", Offset = "0x3118F00", VA = "0x183119F00")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3121580", Offset = "0x3120580", VA = "0x183121580")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x30D4460", Offset = "0x30D3460", VA = "0x1830D4460")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3121770", Offset = "0x3120770", VA = "0x183121770")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3121840", Offset = "0x3120840", VA = "0x183121840")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class SynchronizedFieldBase<T1, T2, T3, T4> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private T3 defaultValue3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private T4 defaultValue4;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x30E0A20", Offset = "0x30DFA20", VA = "0x1830E0A20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x30E1A00", Offset = "0x30E0A00", VA = "0x1830E1A00", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x30E0A60", Offset = "0x30DFA60", VA = "0x1830E0A60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x30E1A40", Offset = "0x30E0A40", VA = "0x1830E1A40", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xEDFF20", Offset = "0xEDEF20", VA = "0x180EDFF20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xEDE760", Offset = "0xEDD760", VA = "0x180EDE760", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x30E0A90", Offset = "0x30DFA90", VA = "0x1830E0A90", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x30E1A70", Offset = "0x30E0A70", VA = "0x1830E1A70", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x30D8F80", Offset = "0x30D7F80", VA = "0x1830D8F80", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x30E0AA0", Offset = "0x30DFAA0", VA = "0x1830E0AA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x30DA370", Offset = "0x30D9370", VA = "0x1830DA370", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x30DFC80", Offset = "0x30DEC80", VA = "0x1830DFC80")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x30DB3C0", Offset = "0x30DA3C0", VA = "0x1830DB3C0")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x30DB7C0", Offset = "0x30DA7C0", VA = "0x1830DB7C0")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x30DB400", Offset = "0x30DA400", VA = "0x1830DB400")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x30DC050", Offset = "0x30DB050", VA = "0x1830DC050")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x30DB490", Offset = "0x30DA490", VA = "0x1830DB490")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x30DC360", Offset = "0x30DB360", VA = "0x1830DC360")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x30DB550", Offset = "0x30DA550", VA = "0x1830DB550")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x30DC960", Offset = "0x30DB960", VA = "0x1830DC960")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x30DD6B0", Offset = "0x30DC6B0", VA = "0x1830DD6B0")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3, T4 newValue4)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class SynchronizedFieldBase<T1, T2, T3, T4, T5> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T3 defaultValue3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T4 defaultValue4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T5 defaultValue5;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3FC820", Offset = "0x3FB820", VA = "0x1803FC820", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3F20F0", Offset = "0x3F10F0", VA = "0x1803F20F0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3FC1C0", Offset = "0x3FB1C0", VA = "0x1803FC1C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3ED110", Offset = "0x3EC110", VA = "0x1803ED110", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8F9200", Offset = "0x8F8200", VA = "0x1808F9200", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1C85710", Offset = "0x1C84710", VA = "0x181C85710", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F8D60", Offset = "0x7F7D60", VA = "0x1807F8D60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB1C3D0", Offset = "0xB1B3D0", VA = "0x180B1C3D0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual T5 typedCachedValue5
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7F8D40", Offset = "0x7F7D40", VA = "0x1807F8D40", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (T5)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB5BFE0", Offset = "0xB5AFE0", VA = "0x180B5BFE0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x30D8F80", Offset = "0x30D7F80", VA = "0x1830D8F80", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x30E7B40", Offset = "0x30E6B40", VA = "0x1830E7B40", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x30E2060", Offset = "0x30E1060", VA = "0x1830E2060", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x30E68F0", Offset = "0x30E58F0", VA = "0x1830E68F0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, T5 defaultValue5, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x16ECF00", Offset = "0x16EBF00", VA = "0x1816ECF00")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x30E2C80", Offset = "0x30E1C80", VA = "0x1830E2C80")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x30D4400", Offset = "0x30D3400", VA = "0x1830D4400")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x30E3030", Offset = "0x30E2030", VA = "0x1830E3030")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x30D4430", Offset = "0x30D3430", VA = "0x1830D4430")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x30E35F0", Offset = "0x30E25F0", VA = "0x1830E35F0")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x30DB4E0", Offset = "0x30DA4E0", VA = "0x1830DB4E0")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x30E3B50", Offset = "0x30E2B50", VA = "0x1830E3B50")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x30E2B60", Offset = "0x30E1B60", VA = "0x1830E2B60")]
		public T5 Get5()
		{
			return (T5)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x30E3DF0", Offset = "0x30E2DF0", VA = "0x1830E3DF0")]
		public void Set5(T5 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x30E4DE0", Offset = "0x30E3DE0", VA = "0x1830E4DE0")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3, T4 newValue4, T5 newValue5)
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
