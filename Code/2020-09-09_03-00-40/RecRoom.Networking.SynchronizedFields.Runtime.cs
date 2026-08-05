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
		[Cpp2IlInjected.Address(RVA = "0x2330860", Offset = "0x232F460", VA = "0x182330860")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x232FCC0", Offset = "0x232E8C0", VA = "0x18232FCC0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2330570", Offset = "0x232F170", VA = "0x182330570")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, bool enforceInitialValue, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class SynchronizedField<T1, T2> : SynchronizedFieldBase<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2333190", Offset = "0x2331D90", VA = "0x182333190")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x23339B0", Offset = "0x23325B0", VA = "0x1823339B0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class SynchronizedField<T1, T2, T3> : SynchronizedFieldBase<T1, T2, T3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23346C0", Offset = "0x23332C0", VA = "0x1823346C0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SynchronizedField<T1, T2, T3, T4> : SynchronizedFieldBase<T1, T2, T3, T4>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2335320", Offset = "0x2333F20", VA = "0x182335320")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2334F70", Offset = "0x2333B70", VA = "0x182334F70")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SynchronizedField<T1, T2, T3, T4, T5> : SynchronizedFieldBase<T1, T2, T3, T4, T5>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x23367C0", Offset = "0x23353C0", VA = "0x1823367C0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2336570", Offset = "0x2335170", VA = "0x182336570")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SynchronizedPlayerField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2336DB0", Offset = "0x23359B0", VA = "0x182336DB0")]
		public SynchronizedPlayerField(INetworkedPlayer player, string key, T defaultValue, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IContextSynchronizedFieldFactory
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
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

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x39E9C0", Offset = "0x39D5C0", VA = "0x18039E9C0")]
		public ContextSynchronizedFieldFactory(ISynchronizedFieldNetworkBacking networkBacking, ISynchronizedFieldContext syncFieldContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x21E7DC0", Offset = "0x21E69C0", VA = "0x1821E7DC0", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RegisterOnDestroyingListener(Action onDestroyingCallback);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UnRegisterOnDestroyingListener(Action onDestroyingCallback);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RegisterOnDestroyedListener(Action onDestroyedCallback);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UnRegisterOnDestroyedListener(Action onDestroyedCallback);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ISynchronizedFieldContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDD6580", Offset = "0xDD5180", VA = "0x180DD6580")]
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
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object GetRoomValue(string key);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object GetPlayerValue(INetworkedPlayer photonPlayer, string key);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetRoomValue(string key, object newValue);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetPlayerValue(INetworkedPlayer photonPlayer, string key, object newValue);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AddCallback([CanBeNull] INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RemoveCallback([CanBeNull] INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "10")]
		T FromSerializableObject<T>(object value);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		object ToSerializableObject<T>(T defaultValue);
	}
	[StructLayout((LayoutKind)3, Size = 4)]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly INetworkedPlayer player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly ISynchronizedFieldContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly string key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly SetterPermissionMode permissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected readonly Action callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected ISynchronizedFieldNetworkBacking NetworkBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool lastSetLocally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool suppressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly string callbackProfilingLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool alreadyDisposed;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static ISynchronizedFieldNetworkBacking GlobalNetworkBacking
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDD7C00", Offset = "0xDD6800", VA = "0x180DD7C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected virtual object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x43D280", Offset = "0x43BE80", VA = "0x18043D280", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x43D290", Offset = "0x43BE90", VA = "0x18043D290", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xDD7C70", Offset = "0xDD6870", VA = "0x180DD7C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int Revision
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x4AEC20", Offset = "0x4AD820", VA = "0x1804AEC20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4AF0D0", Offset = "0x4ADCD0", VA = "0x1804AF0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDD6DC0", Offset = "0xDD59C0", VA = "0x180DD6DC0")]
		public static void InitializeNetworkBacking(ISynchronizedFieldNetworkBacking synchronizedFieldNetworkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool EqualsDefaultValue();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDD78F0", Offset = "0xDD64F0", VA = "0x180DD78F0")]
		protected SynchronizedField(INetworkedPlayer player, ISynchronizedFieldContext context, string key, SetterPermissionMode permissionMode, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDD6880", Offset = "0xDD5480", VA = "0x180DD6880", Slot = "1")]
		~SynchronizedField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xDD6690", Offset = "0xDD5290", VA = "0x180DD6690", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDD6ED0", Offset = "0xDD5AD0", VA = "0x180DD6ED0")]
		protected void Initialize(bool enforceInitialValue, object initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xDD75D0", Offset = "0xDD61D0", VA = "0x180DD75D0")]
		protected void Set(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xDD65D0", Offset = "0xDD51D0", VA = "0x180DD65D0")]
		private void AddCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xDD7510", Offset = "0xDD6110", VA = "0x180DD7510")]
		private void RemoveCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xDD6C90", Offset = "0xDD5890", VA = "0x180DD6C90")]
		public bool HasPrimaryPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDD6B50", Offset = "0xDD5750", VA = "0x180DD6B50")]
		public bool HasPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xDD6A10", Offset = "0xDD5610", VA = "0x180DD6A10")]
		private bool HasPermissionToEnforceInitialValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xDD7310", Offset = "0xDD5F10", VA = "0x180DD7310")]
		private void OnPhotonPropertyChanged(object newValue, int setterId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xDD7420", Offset = "0xDD6020", VA = "0x180DD7420")]
		private void OnValueChanged(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDD6990", Offset = "0xDD5590", VA = "0x180DD6990")]
		protected static string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xDD6910", Offset = "0xDD5510", VA = "0x180DD6910")]
		protected static string FormatRoomDataPhotonObjectKey(ISynchronizedFieldContext context, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDD71C0", Offset = "0xDD5DC0", VA = "0x180DD71C0")]
		public static bool ObjectsAreEqual(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class SynchronizedFieldNetworkBackingBase<TProps> : ISynchronizedFieldNetworkBacking, IDisposable where TProps : class, IDictionary<object, object>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private const string SETTER_INFO_KEY = "S";

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int MAX_UPDATES_PER_FLUSH = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly TProps pendingRoomPropertyUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly List<string> pendingRoomPropertyUpdatesOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly TProps pendingPlayerPropertyUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly List<string> pendingPlayerPropertyUpdatesOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		protected readonly Dictionary<string, Action<object, int>> RoomPropertyCallbackMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		protected readonly Dictionary<INetworkedPlayer, Dictionary<string, Action<object, int>>> PlayerPropertyCallbackMaps;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract TProps RoomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public abstract bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x481D80", Offset = "0x480980", VA = "0x180481D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1B76840", Offset = "0x1B75440", VA = "0x181B76840")]
		public void SetLocalPlayerValue<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x232F7B0", Offset = "0x232E3B0", VA = "0x18232F7B0", Slot = "11")]
		public void SetPlayerValue(INetworkedPlayer player, string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x232E8E0", Offset = "0x232D4E0", VA = "0x18232E8E0", Slot = "9")]
		public object GetPlayerValue(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x232F890", Offset = "0x232E490", VA = "0x18232F890", Slot = "10")]
		public void SetRoomValue(string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x232E9D0", Offset = "0x232D5D0", VA = "0x18232E9D0", Slot = "8")]
		public object GetRoomValue(string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x232DCF0", Offset = "0x232C8F0", VA = "0x18232DCF0", Slot = "12")]
		public void AddCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x232F3D0", Offset = "0x232DFD0", VA = "0x18232F3D0", Slot = "13")]
		public void RemoveCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x232F9F0", Offset = "0x232E5F0", VA = "0x18232F9F0")]
		private void UnregisterAllRoomPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x232F9A0", Offset = "0x232E5A0", VA = "0x18232F9A0")]
		private void UnregisterAllPlayerPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x232FA40", Offset = "0x232E640", VA = "0x18232FA40")]
		private void UnregisterPlayerPropertyCallbacks(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x232F280", Offset = "0x232DE80", VA = "0x18232F280")]
		protected void ProcessPhotonPlayerDisconnected(INetworkedPlayer otherPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x232F180", Offset = "0x232DD80", VA = "0x18232F180")]
		protected void ProcessLocalPlayerLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x232F3A0", Offset = "0x232DFA0", VA = "0x18232F3A0")]
		protected void ProcessRoomPropertyUpdates(TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x232F1F0", Offset = "0x232DDF0", VA = "0x18232F1F0")]
		protected void ProcessMasterClientSwitched(INetworkedPlayer newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x232F300", Offset = "0x232DF00", VA = "0x18232F300")]
		protected void ProcessPlayerPropertyUpdates(INetworkedPlayer player, TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x232ED60", Offset = "0x232D960", VA = "0x18232ED60")]
		private void InvokeCallbacksForProperties(TProps propertiesThatChanged, Dictionary<string, Action<object, int>> callbackMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x232DFE0", Offset = "0x232CBE0", VA = "0x18232DFE0")]
		private void AddToCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x232F4F0", Offset = "0x232E0F0", VA = "0x18232F4F0")]
		private void RemoveFromCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x232F6C0", Offset = "0x232E2C0", VA = "0x18232F6C0")]
		public void SendPendingRoomUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract void SendPendingRoomUpdatesInternal(TProps pendingRoomPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x232F5F0", Offset = "0x232E1F0", VA = "0x18232F5F0")]
		public void SendPendingPlayerUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract void SendPendingPlayerUpdatesInternal(TProps pendingPlayerPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x232DDF0", Offset = "0x232C9F0", VA = "0x18232DDF0")]
		private void AddSetterInfoToPendingUpdates(TProps pendingUpdates, List<string> pendingUpdateOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x232EAE0", Offset = "0x232D6E0", VA = "0x18232EAE0")]
		private void GetSetterInfoFromPropertyUpdate(TProps propertiesThatChanged, out int setterId, out string[] propertySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x232DC90", Offset = "0x232C890", VA = "0x18232DC90")]
		public void AbandonPendingRoomPropertyUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x232E450", Offset = "0x232D050", VA = "0x18232E450")]
		public void ClearAllRoomPropertiesForPlayer(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x232E0D0", Offset = "0x232CCD0", VA = "0x18232E0D0")]
		public void ClearAllRoomPropertiesForMissingPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract HashSet<string> GetPlayerIdsInRoom();

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x232E4E0", Offset = "0x232D0E0", VA = "0x18232E4E0")]
		private void ClearAllRoomPropertiesForPrefix(string prefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x232E860", Offset = "0x232D460", VA = "0x18232E860")]
		protected string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		public abstract object ToSerializableObject<T>(T value);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract T FromSerializableObject<T>(object value);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "27")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x232E770", Offset = "0x232D370", VA = "0x18232E770", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "28")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x232FAA0", Offset = "0x232E6A0", VA = "0x18232FAA0")]
		protected SynchronizedFieldNetworkBackingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class SynchronizedFieldBase<T1> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private T1 defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x18C0080", Offset = "0x18BEC80", VA = "0x1818C0080", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x18BF9D0", Offset = "0x18BE5D0", VA = "0x1818BF9D0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2326EB0", Offset = "0x2325AB0", VA = "0x182326EB0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2F77000", Offset = "0x2F75C00", VA = "0x182F77000", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2F76B60", Offset = "0x2F75760", VA = "0x182F76B60", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2F76ED0", Offset = "0x2F75AD0", VA = "0x182F76ED0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E856C0", Offset = "0x1E842C0", VA = "0x181E856C0")]
		public T1 Get()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BD10", Offset = "0x2D3A910", VA = "0x182D3BD10")]
		public void Set(T1 newValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class SynchronizedFieldBase<T1, T2> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private T2 defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1535690", Offset = "0x1534290", VA = "0x181535690", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2D45190", Offset = "0x2D43D90", VA = "0x182D45190", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x10402D0", Offset = "0x103EED0", VA = "0x1810402D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x18CD610", Offset = "0x18CC210", VA = "0x1818CD610", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2326EB0", Offset = "0x2325AB0", VA = "0x182326EB0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2D44A90", Offset = "0x2D43690", VA = "0x182D44A90", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D9E0", Offset = "0x2D3C5E0", VA = "0x182D3D9E0", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2D433F0", Offset = "0x2D41FF0", VA = "0x182D433F0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AB20", Offset = "0x2D39720", VA = "0x182D3AB20")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2D3EEF0", Offset = "0x2D3DAF0", VA = "0x182D3EEF0")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2D3EEB0", Offset = "0x2D3DAB0", VA = "0x182D3EEB0")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F470", Offset = "0x2D3E070", VA = "0x182D3F470")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2D41750", Offset = "0x2D40350", VA = "0x182D41750")]
		public void Set(T1 newValue1, T2 newValue2)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class SynchronizedFieldBase<T1, T2, T3> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private T3 defaultValue3;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4F0BC0", Offset = "0x4EF7C0", VA = "0x1804F0BC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4F1250", Offset = "0x4EFE50", VA = "0x1804F1250", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4F0DA0", Offset = "0x4EF9A0", VA = "0x1804F0DA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x65CAC0", Offset = "0x65B6C0", VA = "0x18065CAC0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6876B0", Offset = "0x6862B0", VA = "0x1806876B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6876F0", Offset = "0x6862F0", VA = "0x1806876F0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2326EB0", Offset = "0x2325AB0", VA = "0x182326EB0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2D4BE40", Offset = "0x2D4AA40", VA = "0x182D4BE40", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2D46570", Offset = "0x2D45170", VA = "0x182D46570", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A690", Offset = "0x2D49290", VA = "0x182D4A690")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E856C0", Offset = "0x1E842C0", VA = "0x181E856C0")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2D468B0", Offset = "0x2D454B0", VA = "0x182D468B0")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2324160", Offset = "0x2322D60", VA = "0x182324160")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2D473A0", Offset = "0x2D45FA0", VA = "0x182D473A0")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D47550", Offset = "0x2D46150", VA = "0x182D47550")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2D49590", Offset = "0x2D48190", VA = "0x182D49590")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class SynchronizedFieldBase<T1, T2, T3, T4> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private T3 defaultValue3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private T4 defaultValue4;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1A3B280", Offset = "0x1A39E80", VA = "0x181A3B280", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1A37060", Offset = "0x1A35C60", VA = "0x181A37060", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FDC0", Offset = "0x2D4E9C0", VA = "0x182D4FDC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2D50540", Offset = "0x2D4F140", VA = "0x182D50540", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x13D7900", Offset = "0x13D6500", VA = "0x1813D7900", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x13D6B20", Offset = "0x13D5720", VA = "0x1813D6B20", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x106F960", Offset = "0x106E560", VA = "0x18106F960", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2D50570", Offset = "0x2D4F170", VA = "0x182D50570", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2326EB0", Offset = "0x2325AB0", VA = "0x182326EB0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FDF0", Offset = "0x2D4E9F0", VA = "0x182D4FDF0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CE50", Offset = "0x2D4BA50", VA = "0x182D4CE50", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F660", Offset = "0x2D4E260", VA = "0x182D4F660")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2D3ABA0", Offset = "0x2D397A0", VA = "0x182D3ABA0")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D610", Offset = "0x2D4C210", VA = "0x182D4D610")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D4F0", Offset = "0x2D4C0F0", VA = "0x182D4D4F0")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2D4DAE0", Offset = "0x2D4C6E0", VA = "0x182D4DAE0")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D580", Offset = "0x2D4C180", VA = "0x182D4D580")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2D4DD30", Offset = "0x2D4C930", VA = "0x182D4DD30")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D5D0", Offset = "0x2D4C1D0", VA = "0x182D4D5D0")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E030", Offset = "0x2D4CC30", VA = "0x182D4E030")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E220", Offset = "0x2D4CE20", VA = "0x182D4E220")]
		public void Set(T1 newValue1, T2 newValue2, T3 newValue3, T4 newValue4)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class SynchronizedFieldBase<T1, T2, T3, T4, T5> : SynchronizedField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private T1 defaultValue1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private T2 defaultValue2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private T3 defaultValue3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T4 defaultValue4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T5 defaultValue5;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5F7160", Offset = "0x5F5D60", VA = "0x1805F7160", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5F7170", Offset = "0x5F5D70", VA = "0x1805F7170", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x629B00", Offset = "0x628700", VA = "0x180629B00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x629B20", Offset = "0x628720", VA = "0x180629B20", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6876B0", Offset = "0x6862B0", VA = "0x1806876B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6876F0", Offset = "0x6862F0", VA = "0x1806876F0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6876A0", Offset = "0x6862A0", VA = "0x1806876A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6876E0", Offset = "0x6862E0", VA = "0x1806876E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected virtual T5 typedCachedValue5
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2326ED0", Offset = "0x2325AD0", VA = "0x182326ED0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (T5)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x23276A0", Offset = "0x23262A0", VA = "0x1823276A0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2326EB0", Offset = "0x2325AB0", VA = "0x182326EB0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x232D7D0", Offset = "0x232C3D0", VA = "0x18232D7D0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2327C70", Offset = "0x2326870", VA = "0x182327C70", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x232C580", Offset = "0x232B180", VA = "0x18232C580")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, T5 defaultValue5, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1E856C0", Offset = "0x1E842C0", VA = "0x181E856C0")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2328910", Offset = "0x2327510", VA = "0x182328910")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2324160", Offset = "0x2322D60", VA = "0x182324160")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2328CC0", Offset = "0x23278C0", VA = "0x182328CC0")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2329280", Offset = "0x2327E80", VA = "0x182329280")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x23241C0", Offset = "0x2322DC0", VA = "0x1823241C0")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x23297E0", Offset = "0x23283E0", VA = "0x1823297E0")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x23287F0", Offset = "0x23273F0", VA = "0x1823287F0")]
		public T5 Get5()
		{
			return (T5)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2329A80", Offset = "0x2328680", VA = "0x182329A80")]
		public void Set5(T5 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x232AA70", Offset = "0x2329670", VA = "0x18232AA70")]
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
