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
	public interface ISynchronizedFieldContext
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RegisterOnDestroyingListener(Action onDestroyingCallback);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UnRegisterOnDestroyingListener(Action onDestroyingCallback);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RegisterOnDestroyedListener(Action onDestroyedCallback);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UnRegisterOnDestroyedListener(Action onDestroyedCallback);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ISynchronizedFieldContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27B87A0", Offset = "0x27B77A0", VA = "0x1827B87A0")]
		public static bool IsNullOrDestroyed(this ISynchronizedFieldContext context)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface ISynchronizedFieldNetworkBacking : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object GetRoomValue(string key);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object GetPlayerValue(INetworkedPlayer photonPlayer, string key);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetRoomValue(string key, object newValue);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetPlayerValue(INetworkedPlayer photonPlayer, string key, object newValue);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AddCallback([CanBeNull] INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RemoveCallback([CanBeNull] INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		T FromSerializableObject<T>(object value);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		object ToSerializableObject<T>(T defaultValue);
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum SetterPermissionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		AUTHORITY,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		MASTER,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		ANYONE,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		MASTER_OR_AUTHORITY
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class SynchronizedField : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static Stack<ISynchronizedFieldNetworkBacking> networkBackings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected readonly INetworkedPlayer player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly ISynchronizedFieldContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly string key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly SetterPermissionMode permissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly Action callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected ISynchronizedFieldNetworkBacking NetworkBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private bool lastSetLocally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool suppressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly string callbackProfilingLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int revision;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool alreadyDisposed;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected static ISynchronizedFieldNetworkBacking GlobalNetworkBacking
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x27B9E20", Offset = "0x27B8E20", VA = "0x1827B9E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected virtual object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x363630", Offset = "0x362630", VA = "0x180363630", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x364180", Offset = "0x363180", VA = "0x180364180", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HasValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x27B9E90", Offset = "0x27B8E90", VA = "0x1827B9E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int Revision
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4518F0", Offset = "0x4508F0", VA = "0x1804518F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x27B8FE0", Offset = "0x27B7FE0", VA = "0x1827B8FE0")]
		public static void InitializeNetworkBacking(ISynchronizedFieldNetworkBacking synchronizedFieldNetworkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27B9B20", Offset = "0x27B8B20", VA = "0x1827B9B20")]
		protected SynchronizedField(INetworkedPlayer player, ISynchronizedFieldContext context, string key, SetterPermissionMode permissionMode, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x27B8AA0", Offset = "0x27B7AA0", VA = "0x1827B8AA0", Slot = "1")]
		~SynchronizedField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x27B88B0", Offset = "0x27B78B0", VA = "0x1827B88B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27B90F0", Offset = "0x27B80F0", VA = "0x1827B90F0")]
		protected void Initialize(bool enforceInitialValue, object initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27B97F0", Offset = "0x27B87F0", VA = "0x1827B97F0")]
		protected void Set(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x27B87F0", Offset = "0x27B77F0", VA = "0x1827B87F0")]
		private void AddCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x27B9730", Offset = "0x27B8730", VA = "0x1827B9730")]
		private void RemoveCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27B8EB0", Offset = "0x27B7EB0", VA = "0x1827B8EB0")]
		public bool HasPrimaryPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27B8D60", Offset = "0x27B7D60", VA = "0x1827B8D60")]
		public bool HasPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x27B8C20", Offset = "0x27B7C20", VA = "0x1827B8C20")]
		private bool HasPermissionToEnforceInitialValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x27B9530", Offset = "0x27B8530", VA = "0x1827B9530")]
		private void OnPhotonPropertyChanged(object newValue, int setterId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x27B9640", Offset = "0x27B8640", VA = "0x1827B9640")]
		private void OnValueChanged(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x27B8BA0", Offset = "0x27B7BA0", VA = "0x1827B8BA0")]
		protected static string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x27B8B10", Offset = "0x27B7B10", VA = "0x1827B8B10")]
		protected static string FormatRoomDataPhotonObjectKey(ISynchronizedFieldContext context, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x27B93E0", Offset = "0x27B83E0", VA = "0x1827B93E0")]
		protected static bool ObjectsAreEqual(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class SynchronizedFieldNetworkBackingBase<TProps> : ISynchronizedFieldNetworkBacking, IDisposable where TProps : class, IDictionary<object, object>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string SETTER_INFO_KEY = "S";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const int MAX_UPDATES_PER_FLUSH = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly TProps pendingRoomPropertyUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<string> pendingRoomPropertyUpdatesOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly TProps pendingPlayerPropertyUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly List<string> pendingPlayerPropertyUpdatesOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected readonly Dictionary<string, Action<object, int>> RoomPropertyCallbackMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		protected readonly Dictionary<INetworkedPlayer, Dictionary<string, Action<object, int>>> PlayerPropertyCallbackMaps;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract TProps RoomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public abstract bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x102E6B0", Offset = "0x102D6B0", VA = "0x18102E6B0")]
		public void SetLocalPlayerValue<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2346EB0", Offset = "0x2345EB0", VA = "0x182346EB0", Slot = "11")]
		public void SetPlayerValue(INetworkedPlayer player, string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2345FC0", Offset = "0x2344FC0", VA = "0x182345FC0", Slot = "9")]
		public object GetPlayerValue(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2346FA0", Offset = "0x2345FA0", VA = "0x182346FA0", Slot = "10")]
		public void SetRoomValue(string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x23460B0", Offset = "0x23450B0", VA = "0x1823460B0", Slot = "8")]
		public object GetRoomValue(string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2345380", Offset = "0x2344380", VA = "0x182345380", Slot = "12")]
		public void AddCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2346AC0", Offset = "0x2345AC0", VA = "0x182346AC0", Slot = "13")]
		public void RemoveCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2347100", Offset = "0x2346100", VA = "0x182347100")]
		private void UnregisterAllRoomPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x23470B0", Offset = "0x23460B0", VA = "0x1823470B0")]
		private void UnregisterAllPlayerPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2347150", Offset = "0x2346150", VA = "0x182347150")]
		private void UnregisterPlayerPropertyCallbacks(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2346970", Offset = "0x2345970", VA = "0x182346970")]
		protected void ProcessPhotonPlayerDisconnected(INetworkedPlayer otherPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2346870", Offset = "0x2345870", VA = "0x182346870")]
		protected void ProcessLocalPlayerLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2346A90", Offset = "0x2345A90", VA = "0x182346A90")]
		protected void ProcessRoomPropertyUpdates(TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x23468E0", Offset = "0x23458E0", VA = "0x1823468E0")]
		protected void ProcessMasterClientSwitched(INetworkedPlayer newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x23469F0", Offset = "0x23459F0", VA = "0x1823469F0")]
		protected void ProcessPlayerPropertyUpdates(INetworkedPlayer player, TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2346450", Offset = "0x2345450", VA = "0x182346450")]
		private void InvokeCallbacksForProperties(TProps propertiesThatChanged, Dictionary<string, Action<object, int>> callbackMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x23456A0", Offset = "0x23446A0", VA = "0x1823456A0")]
		private void AddToCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2346BE0", Offset = "0x2345BE0", VA = "0x182346BE0")]
		private void RemoveFromCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2346DC0", Offset = "0x2345DC0", VA = "0x182346DC0")]
		public void SendPendingRoomUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract void SendPendingRoomUpdatesInternal(TProps pendingRoomPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2346CF0", Offset = "0x2345CF0", VA = "0x182346CF0")]
		public void SendPendingPlayerUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract void SendPendingPlayerUpdatesInternal(TProps pendingPlayerPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2345480", Offset = "0x2344480", VA = "0x182345480")]
		private void AddSetterInfoToPendingUpdates(TProps pendingUpdates, List<string> pendingUpdateOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x23461C0", Offset = "0x23451C0", VA = "0x1823461C0")]
		private void GetSetterInfoFromPropertyUpdate(TProps propertiesThatChanged, out int setterId, out string[] propertySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2345320", Offset = "0x2344320", VA = "0x182345320")]
		public void AbandonPendingRoomPropertyUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2345B10", Offset = "0x2344B10", VA = "0x182345B10")]
		public void ClearAllRoomPropertiesForPlayer(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x23457A0", Offset = "0x23447A0", VA = "0x1823457A0")]
		public void ClearAllRoomPropertiesForMissingPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract HashSet<string> GetPlayerIdsInRoom();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2345BB0", Offset = "0x2344BB0", VA = "0x182345BB0")]
		private void ClearAllRoomPropertiesForPrefix(string prefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2345F40", Offset = "0x2344F40", VA = "0x182345F40")]
		protected string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		public abstract object ToSerializableObject<T>(T value);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract T FromSerializableObject<T>(object value);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x34A7A0", Offset = "0x3497A0", VA = "0x18034A7A0", Slot = "27")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2345E50", Offset = "0x2344E50", VA = "0x182345E50", Slot = "28")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x34A7A0", Offset = "0x3497A0", VA = "0x18034A7A0", Slot = "29")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x23471B0", Offset = "0x23461B0", VA = "0x1823471B0")]
		protected SynchronizedFieldNetworkBackingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class SynchronizedFieldBase<T> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected virtual T typedCachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x11A3750", Offset = "0x11A2750", VA = "0x1811A3750", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x11A3C80", Offset = "0x11A2C80", VA = "0x1811A3C80", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x11A36F0", Offset = "0x11A26F0", VA = "0x1811A36F0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x11A3B20", Offset = "0x11A2B20", VA = "0x1811A3B20", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x11A35B0", Offset = "0x11A25B0", VA = "0x1811A35B0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2042990", Offset = "0x2041990", VA = "0x182042990")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x232FD20", Offset = "0x232ED20", VA = "0x18232FD20")]
		public void Set(T newValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class SynchronizedFieldBase<T1, T2> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private T2 defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA753B0", Offset = "0xA743B0", VA = "0x180A753B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2334E80", Offset = "0x2333E80", VA = "0x182334E80", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2334310", Offset = "0x2333310", VA = "0x182334310", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2334EA0", Offset = "0x2333EA0", VA = "0x182334EA0", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x11A36F0", Offset = "0x11A26F0", VA = "0x1811A36F0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2334960", Offset = "0x2333960", VA = "0x182334960", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x23334C0", Offset = "0x23324C0", VA = "0x1823334C0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x11A2930", Offset = "0x11A1930", VA = "0x1811A2930")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2331730", Offset = "0x2330730", VA = "0x182331730")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x23328D0", Offset = "0x23318D0", VA = "0x1823328D0")]
		public void Set(T1 newValue1, T2 newValue2)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class SynchronizedFieldBase<T1, T2, T3> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private T3 defaultValue3;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3884B0", Offset = "0x3874B0", VA = "0x1803884B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1B46640", Offset = "0x1B45640", VA = "0x181B46640", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x431A90", Offset = "0x430A90", VA = "0x180431A90", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6C5AB0", Offset = "0x6C4AB0", VA = "0x1806C5AB0", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3DCB10", Offset = "0x3DBB10", VA = "0x1803DCB10", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x233B450", Offset = "0x233A450", VA = "0x18233B450", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x11A36F0", Offset = "0x11A26F0", VA = "0x1811A36F0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x233A6C0", Offset = "0x23396C0", VA = "0x18233A6C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2338BE0", Offset = "0x2337BE0", VA = "0x182338BE0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2042990", Offset = "0x2041990", VA = "0x182042990")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2331700", Offset = "0x2330700", VA = "0x182331700")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2334EB0", Offset = "0x2333EB0", VA = "0x182334EB0")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2335040", Offset = "0x2334040", VA = "0x182335040")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2335AA0", Offset = "0x2334AA0", VA = "0x182335AA0")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2335C50", Offset = "0x2334C50", VA = "0x182335C50")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2337D50", Offset = "0x2336D50", VA = "0x182337D50")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class SynchronizedFieldBase<T1, T2, T3, T4> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private T3 defaultValue3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private T4 defaultValue4;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x233F110", Offset = "0x233E110", VA = "0x18233F110", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x233FD00", Offset = "0x233ED00", VA = "0x18233FD00", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x233F130", Offset = "0x233E130", VA = "0x18233F130", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x233FD20", Offset = "0x233ED20", VA = "0x18233FD20", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA186C0", Offset = "0xA176C0", VA = "0x180A186C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA189D0", Offset = "0xA179D0", VA = "0x180A189D0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x743470", Offset = "0x742470", VA = "0x180743470", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x233FD40", Offset = "0x233ED40", VA = "0x18233FD40", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x11A36F0", Offset = "0x11A26F0", VA = "0x1811A36F0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x233F150", Offset = "0x233E150", VA = "0x18233F150", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x233EA50", Offset = "0x233DA50", VA = "0x18233EA50")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x11A2970", Offset = "0x11A1970", VA = "0x1811A2970")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x233B470", Offset = "0x233A470", VA = "0x18233B470")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x233B4C0", Offset = "0x233A4C0", VA = "0x18233B4C0")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x233B540", Offset = "0x233A540", VA = "0x18233B540")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x233B700", Offset = "0x233A700", VA = "0x18233B700")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x233BCA0", Offset = "0x233ACA0", VA = "0x18233BCA0")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x233BE90", Offset = "0x233AE90", VA = "0x18233BE90")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x233C2B0", Offset = "0x233B2B0", VA = "0x18233C2B0")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x233C9C0", Offset = "0x233B9C0", VA = "0x18233C9C0")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3, T4 newValue4)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class SynchronizedFieldBase<T1, T2, T3, T4, T5> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private T3 defaultValue3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private T4 defaultValue4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private T5 defaultValue5;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x354000", Offset = "0x353000", VA = "0x180354000", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3A8780", Offset = "0x3A7780", VA = "0x1803A8780", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x697C60", Offset = "0x696C60", VA = "0x180697C60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x697D80", Offset = "0x696D80", VA = "0x180697D80", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3DCB10", Offset = "0x3DBB10", VA = "0x1803DCB10", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x233B450", Offset = "0x233A450", VA = "0x18233B450", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3BAAB0", Offset = "0x3B9AB0", VA = "0x1803BAAB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3BAAC0", Offset = "0x3B9AC0", VA = "0x1803BAAC0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected virtual T5 typedCachedValue5
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7F9840", Offset = "0x7F8840", VA = "0x1807F9840", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return (T5)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7F9860", Offset = "0x7F8860", VA = "0x1807F9860", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x11A36F0", Offset = "0x11A26F0", VA = "0x1811A36F0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2344E30", Offset = "0x2343E30", VA = "0x182344E30", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2344300", Offset = "0x2343300", VA = "0x182344300")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, T5 defaultValue5, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2042990", Offset = "0x2041990", VA = "0x182042990")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2331700", Offset = "0x2330700", VA = "0x182331700")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2334EB0", Offset = "0x2333EB0", VA = "0x182334EB0")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x233B510", Offset = "0x233A510", VA = "0x18233B510")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x13081E0", Offset = "0x13071E0", VA = "0x1813081E0")]
		public T5 Get5()
		{
			return (T5)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x233FE90", Offset = "0x233EE90", VA = "0x18233FE90")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2340240", Offset = "0x233F240", VA = "0x182340240")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2340800", Offset = "0x233F800", VA = "0x182340800")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2340D60", Offset = "0x233FD60", VA = "0x182340D60")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2341000", Offset = "0x2340000", VA = "0x182341000")]
		public void Set5(T5 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2342020", Offset = "0x2341020", VA = "0x182342020")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3, T4 newValue4, T5 newValue5)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SynchronizedField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xE2FFF0", Offset = "0xE2EFF0", VA = "0x180E2FFF0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xE2E900", Offset = "0xE2D900", VA = "0x180E2E900")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xE2E0B0", Offset = "0xE2D0B0", VA = "0x180E2E0B0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, bool enforceInitialValue, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SynchronizedField<T1, T2> : SynchronizedFieldBase<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xE30670", Offset = "0xE2F670", VA = "0x180E30670")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xE30480", Offset = "0xE2F480", VA = "0x180E30480")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SynchronizedField<T1, T2, T3> : SynchronizedFieldBase<T1, T2, T3>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xE316D0", Offset = "0xE306D0", VA = "0x180E316D0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SynchronizedField<T1, T2, T3, T4> : SynchronizedFieldBase<T1, T2, T3, T4>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xE324A0", Offset = "0xE314A0", VA = "0x180E324A0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xE32010", Offset = "0xE31010", VA = "0x180E32010")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class SynchronizedField<T1, T2, T3, T4, T5> : SynchronizedFieldBase<T1, T2, T3, T4, T5>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xE33260", Offset = "0xE32260", VA = "0x180E33260")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xE32CA0", Offset = "0xE31CA0", VA = "0x180E32CA0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SynchronizedPlayerField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xE33600", Offset = "0xE32600", VA = "0x180E33600")]
		public SynchronizedPlayerField(INetworkedPlayer player, string key, T defaultValue, [Optional] Action callback)
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
