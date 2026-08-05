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
		[Cpp2IlInjected.Address(RVA = "0x27BD430", Offset = "0x27BC430", VA = "0x1827BD430")]
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
			[Cpp2IlInjected.Address(RVA = "0x27BEAB0", Offset = "0x27BDAB0", VA = "0x1827BEAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected virtual object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x35CFF0", Offset = "0x35BFF0", VA = "0x18035CFF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x354B80", Offset = "0x353B80", VA = "0x180354B80", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HasValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x27BEB20", Offset = "0x27BDB20", VA = "0x1827BEB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int Revision
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x445980", Offset = "0x444980", VA = "0x180445980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x27BDC70", Offset = "0x27BCC70", VA = "0x1827BDC70")]
		public static void InitializeNetworkBacking(ISynchronizedFieldNetworkBacking synchronizedFieldNetworkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27BE7B0", Offset = "0x27BD7B0", VA = "0x1827BE7B0")]
		protected SynchronizedField(INetworkedPlayer player, ISynchronizedFieldContext context, string key, SetterPermissionMode permissionMode, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x27BD730", Offset = "0x27BC730", VA = "0x1827BD730", Slot = "1")]
		~SynchronizedField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x27BD540", Offset = "0x27BC540", VA = "0x1827BD540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27BDD80", Offset = "0x27BCD80", VA = "0x1827BDD80")]
		protected void Initialize(bool enforceInitialValue, object initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27BE480", Offset = "0x27BD480", VA = "0x1827BE480")]
		protected void Set(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x27BD480", Offset = "0x27BC480", VA = "0x1827BD480")]
		private void AddCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x27BE3C0", Offset = "0x27BD3C0", VA = "0x1827BE3C0")]
		private void RemoveCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27BDB40", Offset = "0x27BCB40", VA = "0x1827BDB40")]
		public bool HasPrimaryPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27BD9F0", Offset = "0x27BC9F0", VA = "0x1827BD9F0")]
		public bool HasPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x27BD8B0", Offset = "0x27BC8B0", VA = "0x1827BD8B0")]
		private bool HasPermissionToEnforceInitialValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x27BE1C0", Offset = "0x27BD1C0", VA = "0x1827BE1C0")]
		private void OnPhotonPropertyChanged(object newValue, int setterId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x27BE2D0", Offset = "0x27BD2D0", VA = "0x1827BE2D0")]
		private void OnValueChanged(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x27BD830", Offset = "0x27BC830", VA = "0x1827BD830")]
		protected static string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x27BD7A0", Offset = "0x27BC7A0", VA = "0x1827BD7A0")]
		protected static string FormatRoomDataPhotonObjectKey(ISynchronizedFieldContext context, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x27BE070", Offset = "0x27BD070", VA = "0x1827BE070")]
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
		[Cpp2IlInjected.Address(RVA = "0x118DB00", Offset = "0x118CB00", VA = "0x18118DB00")]
		public void SetLocalPlayerValue<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x23ADEA0", Offset = "0x23ACEA0", VA = "0x1823ADEA0", Slot = "11")]
		public void SetPlayerValue(INetworkedPlayer player, string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x23ACFB0", Offset = "0x23ABFB0", VA = "0x1823ACFB0", Slot = "9")]
		public object GetPlayerValue(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x23ADF90", Offset = "0x23ACF90", VA = "0x1823ADF90", Slot = "10")]
		public void SetRoomValue(string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x23AD0A0", Offset = "0x23AC0A0", VA = "0x1823AD0A0", Slot = "8")]
		public object GetRoomValue(string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x23AC370", Offset = "0x23AB370", VA = "0x1823AC370", Slot = "12")]
		public void AddCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x23ADAB0", Offset = "0x23ACAB0", VA = "0x1823ADAB0", Slot = "13")]
		public void RemoveCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x23AE0F0", Offset = "0x23AD0F0", VA = "0x1823AE0F0")]
		private void UnregisterAllRoomPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x23AE0A0", Offset = "0x23AD0A0", VA = "0x1823AE0A0")]
		private void UnregisterAllPlayerPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x23AE140", Offset = "0x23AD140", VA = "0x1823AE140")]
		private void UnregisterPlayerPropertyCallbacks(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x23AD960", Offset = "0x23AC960", VA = "0x1823AD960")]
		protected void ProcessPhotonPlayerDisconnected(INetworkedPlayer otherPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x23AD860", Offset = "0x23AC860", VA = "0x1823AD860")]
		protected void ProcessLocalPlayerLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x23ADA80", Offset = "0x23ACA80", VA = "0x1823ADA80")]
		protected void ProcessRoomPropertyUpdates(TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x23AD8D0", Offset = "0x23AC8D0", VA = "0x1823AD8D0")]
		protected void ProcessMasterClientSwitched(INetworkedPlayer newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x23AD9E0", Offset = "0x23AC9E0", VA = "0x1823AD9E0")]
		protected void ProcessPlayerPropertyUpdates(INetworkedPlayer player, TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x23AD440", Offset = "0x23AC440", VA = "0x1823AD440")]
		private void InvokeCallbacksForProperties(TProps propertiesThatChanged, Dictionary<string, Action<object, int>> callbackMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x23AC690", Offset = "0x23AB690", VA = "0x1823AC690")]
		private void AddToCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x23ADBD0", Offset = "0x23ACBD0", VA = "0x1823ADBD0")]
		private void RemoveFromCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x23ADDB0", Offset = "0x23ACDB0", VA = "0x1823ADDB0")]
		public void SendPendingRoomUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract void SendPendingRoomUpdatesInternal(TProps pendingRoomPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x23ADCE0", Offset = "0x23ACCE0", VA = "0x1823ADCE0")]
		public void SendPendingPlayerUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract void SendPendingPlayerUpdatesInternal(TProps pendingPlayerPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x23AC470", Offset = "0x23AB470", VA = "0x1823AC470")]
		private void AddSetterInfoToPendingUpdates(TProps pendingUpdates, List<string> pendingUpdateOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x23AD1B0", Offset = "0x23AC1B0", VA = "0x1823AD1B0")]
		private void GetSetterInfoFromPropertyUpdate(TProps propertiesThatChanged, out int setterId, out string[] propertySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x23AC310", Offset = "0x23AB310", VA = "0x1823AC310")]
		public void AbandonPendingRoomPropertyUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x23ACB00", Offset = "0x23ABB00", VA = "0x1823ACB00")]
		public void ClearAllRoomPropertiesForPlayer(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x23AC790", Offset = "0x23AB790", VA = "0x1823AC790")]
		public void ClearAllRoomPropertiesForMissingPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract HashSet<string> GetPlayerIdsInRoom();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x23ACBA0", Offset = "0x23ABBA0", VA = "0x1823ACBA0")]
		private void ClearAllRoomPropertiesForPrefix(string prefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x23ACF30", Offset = "0x23ABF30", VA = "0x1823ACF30")]
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
		[Cpp2IlInjected.Address(RVA = "0x35F0A0", Offset = "0x35E0A0", VA = "0x18035F0A0", Slot = "27")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x23ACE40", Offset = "0x23ABE40", VA = "0x1823ACE40", Slot = "28")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x35F0A0", Offset = "0x35E0A0", VA = "0x18035F0A0", Slot = "29")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x23AE1A0", Offset = "0x23AD1A0", VA = "0x1823AE1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1301F30", Offset = "0x1300F30", VA = "0x181301F30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1302460", Offset = "0x1301460", VA = "0x181302460", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1301ED0", Offset = "0x1300ED0", VA = "0x181301ED0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1302300", Offset = "0x1301300", VA = "0x181302300", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1301D90", Offset = "0x1300D90", VA = "0x181301D90")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x20C1E70", Offset = "0x20C0E70", VA = "0x1820C1E70")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2396D20", Offset = "0x2395D20", VA = "0x182396D20")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD4AF0", Offset = "0xBD3AF0", VA = "0x180BD4AF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x239BE80", Offset = "0x239AE80", VA = "0x18239BE80", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x239B310", Offset = "0x239A310", VA = "0x18239B310", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x239BEA0", Offset = "0x239AEA0", VA = "0x18239BEA0", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1301ED0", Offset = "0x1300ED0", VA = "0x181301ED0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x239B960", Offset = "0x239A960", VA = "0x18239B960", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x239A4C0", Offset = "0x23994C0", VA = "0x18239A4C0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1301110", Offset = "0x1300110", VA = "0x181301110")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2398730", Offset = "0x2397730", VA = "0x182398730")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x23998D0", Offset = "0x23988D0", VA = "0x1823998D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E9640", Offset = "0x4E8640", VA = "0x1804E9640", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1C48930", Offset = "0x1C47930", VA = "0x181C48930", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x592370", Offset = "0x591370", VA = "0x180592370", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8254F0", Offset = "0x8244F0", VA = "0x1808254F0", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x53DAE0", Offset = "0x53CAE0", VA = "0x18053DAE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x23A2450", Offset = "0x23A1450", VA = "0x1823A2450", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1301ED0", Offset = "0x1300ED0", VA = "0x181301ED0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23A16C0", Offset = "0x23A06C0", VA = "0x1823A16C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x239FBE0", Offset = "0x239EBE0", VA = "0x18239FBE0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x20C1E70", Offset = "0x20C0E70", VA = "0x1820C1E70")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2398700", Offset = "0x2397700", VA = "0x182398700")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x239BEB0", Offset = "0x239AEB0", VA = "0x18239BEB0")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x239C040", Offset = "0x239B040", VA = "0x18239C040")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x239CAA0", Offset = "0x239BAA0", VA = "0x18239CAA0")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x239CC50", Offset = "0x239BC50", VA = "0x18239CC50")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x239ED50", Offset = "0x239DD50", VA = "0x18239ED50")]
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
			[Cpp2IlInjected.Address(RVA = "0x23A6110", Offset = "0x23A5110", VA = "0x1823A6110", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x23A6D00", Offset = "0x23A5D00", VA = "0x1823A6D00", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x23A6130", Offset = "0x23A5130", VA = "0x1823A6130", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x23A6D20", Offset = "0x23A5D20", VA = "0x1823A6D20", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB77EB0", Offset = "0xB76EB0", VA = "0x180B77EB0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB781C0", Offset = "0xB771C0", VA = "0x180B781C0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8BCF50", Offset = "0x8BBF50", VA = "0x1808BCF50", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x23A6D40", Offset = "0x23A5D40", VA = "0x1823A6D40", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1301ED0", Offset = "0x1300ED0", VA = "0x181301ED0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x23A6150", Offset = "0x23A5150", VA = "0x1823A6150", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x23A5A50", Offset = "0x23A4A50", VA = "0x1823A5A50")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1301150", Offset = "0x1300150", VA = "0x181301150")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x23A2470", Offset = "0x23A1470", VA = "0x1823A2470")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x23A24C0", Offset = "0x23A14C0", VA = "0x1823A24C0")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x23A2540", Offset = "0x23A1540", VA = "0x1823A2540")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x23A2700", Offset = "0x23A1700", VA = "0x1823A2700")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x23A2CA0", Offset = "0x23A1CA0", VA = "0x1823A2CA0")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x23A2E90", Offset = "0x23A1E90", VA = "0x1823A2E90")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x23A32B0", Offset = "0x23A22B0", VA = "0x1823A32B0")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x23A39C0", Offset = "0x23A29C0", VA = "0x1823A39C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B55E0", Offset = "0x4B45E0", VA = "0x1804B55E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x375B00", Offset = "0x374B00", VA = "0x180375B00", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7F7720", Offset = "0x7F6720", VA = "0x1807F7720", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7F7840", Offset = "0x7F6840", VA = "0x1807F7840", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x53DAE0", Offset = "0x53CAE0", VA = "0x18053DAE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x23A2450", Offset = "0x23A1450", VA = "0x1823A2450", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x51BB00", Offset = "0x51AB00", VA = "0x18051BB00", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x51BB10", Offset = "0x51AB10", VA = "0x18051BB10", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected virtual T5 typedCachedValue5
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x959120", Offset = "0x958120", VA = "0x180959120", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return (T5)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x959140", Offset = "0x958140", VA = "0x180959140", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1301ED0", Offset = "0x1300ED0", VA = "0x181301ED0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x23ABE30", Offset = "0x23AAE30", VA = "0x1823ABE30", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x23AB300", Offset = "0x23AA300", VA = "0x1823AB300")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, T5 defaultValue5, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x20C1E70", Offset = "0x20C0E70", VA = "0x1820C1E70")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2398700", Offset = "0x2397700", VA = "0x182398700")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x239BEB0", Offset = "0x239AEB0", VA = "0x18239BEB0")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x23A2510", Offset = "0x23A1510", VA = "0x1823A2510")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1466590", Offset = "0x1465590", VA = "0x181466590")]
		public T5 Get5()
		{
			return (T5)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x23A6E90", Offset = "0x23A5E90", VA = "0x1823A6E90")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x23A7240", Offset = "0x23A6240", VA = "0x1823A7240")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x23A7800", Offset = "0x23A6800", VA = "0x1823A7800")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x23A7D60", Offset = "0x23A6D60", VA = "0x1823A7D60")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x23A8000", Offset = "0x23A7000", VA = "0x1823A8000")]
		public void Set5(T5 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x23A9020", Offset = "0x23A8020", VA = "0x1823A9020")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3, T4 newValue4, T5 newValue5)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SynchronizedField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xF8F510", Offset = "0xF8E510", VA = "0x180F8F510")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xF8DE20", Offset = "0xF8CE20", VA = "0x180F8DE20")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xF8D5D0", Offset = "0xF8C5D0", VA = "0x180F8D5D0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, bool enforceInitialValue, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SynchronizedField<T1, T2> : SynchronizedFieldBase<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xF8FB90", Offset = "0xF8EB90", VA = "0x180F8FB90")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xF8F9A0", Offset = "0xF8E9A0", VA = "0x180F8F9A0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SynchronizedField<T1, T2, T3> : SynchronizedFieldBase<T1, T2, T3>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xF90BF0", Offset = "0xF8FBF0", VA = "0x180F90BF0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SynchronizedField<T1, T2, T3, T4> : SynchronizedFieldBase<T1, T2, T3, T4>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xF919C0", Offset = "0xF909C0", VA = "0x180F919C0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xF91530", Offset = "0xF90530", VA = "0x180F91530")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class SynchronizedField<T1, T2, T3, T4, T5> : SynchronizedFieldBase<T1, T2, T3, T4, T5>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xF92780", Offset = "0xF91780", VA = "0x180F92780")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xF921C0", Offset = "0xF911C0", VA = "0x180F921C0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SynchronizedPlayerField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xF92B20", Offset = "0xF91B20", VA = "0x180F92B20")]
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
