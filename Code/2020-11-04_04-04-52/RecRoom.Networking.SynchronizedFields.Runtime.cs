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
		[Cpp2IlInjected.Address(RVA = "0x2D6F1E0", Offset = "0x2D6E5E0", VA = "0x182D6F1E0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E750", Offset = "0x2D6DB50", VA = "0x182D6E750")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2D6EEF0", Offset = "0x2D6E2F0", VA = "0x182D6EEF0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T defaultValue, SetterPermissionMode permissionMode, bool enforceInitialValue, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class SynchronizedField<T1, T2> : SynchronizedFieldBase<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1507830", Offset = "0x1506C30", VA = "0x181507830")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1507620", Offset = "0x1506A20", VA = "0x181507620")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class SynchronizedField<T1, T2, T3> : SynchronizedFieldBase<T1, T2, T3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x15088B0", Offset = "0x1507CB0", VA = "0x1815088B0")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SynchronizedField<T1, T2, T3, T4> : SynchronizedFieldBase<T1, T2, T3, T4>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x15090D0", Offset = "0x15084D0", VA = "0x1815090D0")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1508D20", Offset = "0x1508120", VA = "0x181508D20")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SynchronizedField<T1, T2, T3, T4, T5> : SynchronizedFieldBase<T1, T2, T3, T4, T5>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x150A570", Offset = "0x1509970", VA = "0x18150A570")]
		public SynchronizedField(ISynchronizedFieldContext context, INetworkedPlayer player, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x150A320", Offset = "0x1509720", VA = "0x18150A320")]
		public SynchronizedField(ISynchronizedFieldContext context, string key, T1 defaultVal1, T2 defaultVal2, T3 defaultVal3, T4 defaultVal4, T5 defaultVal5, SetterPermissionMode permissionMode, [Optional] Action callback, [Optional] ISynchronizedFieldNetworkBacking networkBacking)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SynchronizedPlayerField<T> : SynchronizedFieldBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x150AB60", Offset = "0x1509F60", VA = "0x18150AB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C5DC0", Offset = "0x3C51C0", VA = "0x1803C5DC0")]
		public ContextSynchronizedFieldFactory(ISynchronizedFieldNetworkBacking networkBacking, ISynchronizedFieldContext syncFieldContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1E86D00", Offset = "0x1E86100", VA = "0x181E86D00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30CBE10", Offset = "0x30CB210", VA = "0x1830CBE10")]
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

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void SendPendingRoomUpdates();
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
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x30CD4C0", Offset = "0x30CC8C0", VA = "0x1830CD4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected virtual object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3CE5E0", Offset = "0x3CD9E0", VA = "0x1803CE5E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x659A10", Offset = "0x658E10", VA = "0x180659A10", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x30CD530", Offset = "0x30CC930", VA = "0x1830CD530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int Revision
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x48D7C0", Offset = "0x48CBC0", VA = "0x18048D7C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x657BE0", Offset = "0x656FE0", VA = "0x180657BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x30CC650", Offset = "0x30CBA50", VA = "0x1830CC650")]
		public static void InitializeNetworkBacking(ISynchronizedFieldNetworkBacking synchronizedFieldNetworkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool EqualsDefaultValue();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x30CD1B0", Offset = "0x30CC5B0", VA = "0x1830CD1B0")]
		protected SynchronizedField(INetworkedPlayer player, ISynchronizedFieldContext context, string key, SetterPermissionMode permissionMode, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x30CC110", Offset = "0x30CB510", VA = "0x1830CC110", Slot = "1")]
		~SynchronizedField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x30CBF20", Offset = "0x30CB320", VA = "0x1830CBF20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x30CC760", Offset = "0x30CBB60", VA = "0x1830CC760")]
		protected void Initialize(bool enforceInitialValue, object initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x30CCE60", Offset = "0x30CC260", VA = "0x1830CCE60")]
		protected void Set(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x30CBE60", Offset = "0x30CB260", VA = "0x1830CBE60")]
		private void AddCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x30CCDA0", Offset = "0x30CC1A0", VA = "0x1830CCDA0")]
		private void RemoveCallback()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x30CC520", Offset = "0x30CB920", VA = "0x1830CC520")]
		public bool HasPrimaryPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x30CC3E0", Offset = "0x30CB7E0", VA = "0x1830CC3E0")]
		public bool HasPermissionToSet()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x30CC2A0", Offset = "0x30CB6A0", VA = "0x1830CC2A0")]
		private bool HasPermissionToEnforceInitialValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x30CCBA0", Offset = "0x30CBFA0", VA = "0x1830CCBA0")]
		private void OnPhotonPropertyChanged(object newValue, int setterId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x30CCCB0", Offset = "0x30CC0B0", VA = "0x1830CCCB0")]
		private void OnValueChanged(object newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x30CC220", Offset = "0x30CB620", VA = "0x1830CC220")]
		protected static string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x30CC1A0", Offset = "0x30CB5A0", VA = "0x1830CC1A0")]
		protected static string FormatRoomDataPhotonObjectKey(ISynchronizedFieldContext context, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x30CCA50", Offset = "0x30CBE50", VA = "0x1830CCA50")]
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

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract TProps RoomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public abstract bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3FFCB0", Offset = "0x3FF0B0", VA = "0x1803FFCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x15A1940", Offset = "0x15A0D40", VA = "0x1815A1940")]
		public void SetLocalPlayerValue<T>(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E240", Offset = "0x2D6D640", VA = "0x182D6E240", Slot = "11")]
		public void SetPlayerValue(INetworkedPlayer player, string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D370", Offset = "0x2D6C770", VA = "0x182D6D370", Slot = "9")]
		public object GetPlayerValue(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E320", Offset = "0x2D6D720", VA = "0x182D6E320", Slot = "10")]
		public void SetRoomValue(string key, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D460", Offset = "0x2D6C860", VA = "0x182D6D460", Slot = "8")]
		public object GetRoomValue(string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C780", Offset = "0x2D6BB80", VA = "0x182D6C780", Slot = "12")]
		public void AddCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DE60", Offset = "0x2D6D260", VA = "0x182D6DE60", Slot = "13")]
		public void RemoveCallback(INetworkedPlayer photonPlayer, string key, Action<object, int> onPhotonPropertyChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E480", Offset = "0x2D6D880", VA = "0x182D6E480")]
		private void UnregisterAllRoomPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E430", Offset = "0x2D6D830", VA = "0x182D6E430")]
		private void UnregisterAllPlayerPropertyCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E4D0", Offset = "0x2D6D8D0", VA = "0x182D6E4D0")]
		private void UnregisterPlayerPropertyCallbacks(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DD10", Offset = "0x2D6D110", VA = "0x182D6DD10")]
		protected void ProcessPhotonPlayerDisconnected(INetworkedPlayer otherPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DC10", Offset = "0x2D6D010", VA = "0x182D6DC10")]
		protected void ProcessLocalPlayerLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DE30", Offset = "0x2D6D230", VA = "0x182D6DE30")]
		protected void ProcessRoomPropertyUpdates(TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DC80", Offset = "0x2D6D080", VA = "0x182D6DC80")]
		protected void ProcessMasterClientSwitched(INetworkedPlayer newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DD90", Offset = "0x2D6D190", VA = "0x182D6DD90")]
		protected void ProcessPlayerPropertyUpdates(INetworkedPlayer player, TProps propertiesThatChanged)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D7F0", Offset = "0x2D6CBF0", VA = "0x182D6D7F0")]
		private void InvokeCallbacksForProperties(TProps propertiesThatChanged, Dictionary<string, Action<object, int>> callbackMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CA70", Offset = "0x2D6BE70", VA = "0x182D6CA70")]
		private void AddToCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DF80", Offset = "0x2D6D380", VA = "0x182D6DF80")]
		private void RemoveFromCallbackMap(Dictionary<string, Action<object, int>> callbackMap, string key, Action<object, int> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E150", Offset = "0x2D6D550", VA = "0x182D6E150", Slot = "16")]
		public void SendPendingRoomUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract void SendPendingRoomUpdatesInternal(TProps pendingRoomPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E080", Offset = "0x2D6D480", VA = "0x182D6E080")]
		public void SendPendingPlayerUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract void SendPendingPlayerUpdatesInternal(TProps pendingPlayerPropertyUpdates);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C880", Offset = "0x2D6BC80", VA = "0x182D6C880")]
		private void AddSetterInfoToPendingUpdates(TProps pendingUpdates, List<string> pendingUpdateOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D570", Offset = "0x2D6C970", VA = "0x182D6D570")]
		private void GetSetterInfoFromPropertyUpdate(TProps propertiesThatChanged, out int setterId, out string[] propertySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C720", Offset = "0x2D6BB20", VA = "0x182D6C720")]
		public void AbandonPendingRoomPropertyUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CEE0", Offset = "0x2D6C2E0", VA = "0x182D6CEE0")]
		public void ClearAllRoomPropertiesForPlayer(INetworkedPlayer player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CB60", Offset = "0x2D6BF60", VA = "0x182D6CB60")]
		public void ClearAllRoomPropertiesForMissingPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract HashSet<string> GetPlayerIdsInRoom();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CF70", Offset = "0x2D6C370", VA = "0x182D6CF70")]
		private void ClearAllRoomPropertiesForPrefix(string prefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D2F0", Offset = "0x2D6C6F0", VA = "0x182D6D2F0")]
		protected string FormatRoomDataPlayerKey(INetworkedPlayer player, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract object ToSerializableObject<T>(T value);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract T FromSerializableObject<T>(object value);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3AF860", Offset = "0x3AEC60", VA = "0x1803AF860", Slot = "28")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D200", Offset = "0x2D6C600", VA = "0x182D6D200", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3AF860", Offset = "0x3AEC60", VA = "0x1803AF860", Slot = "29")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E530", Offset = "0x2D6D930", VA = "0x182D6E530")]
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

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x116C580", Offset = "0x116B980", VA = "0x18116C580", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x116BFA0", Offset = "0x116B3A0", VA = "0x18116BFA0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2D5DC30", Offset = "0x2D5D030", VA = "0x182D5DC30", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2E08EB0", Offset = "0x2E082B0", VA = "0x182E08EB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2E05A90", Offset = "0x2E04E90", VA = "0x182E05A90", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2E080B0", Offset = "0x2E074B0", VA = "0x182E080B0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x187FAA0", Offset = "0x187EEA0", VA = "0x18187FAA0")]
		public T1 Get()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2E07220", Offset = "0x2E06620", VA = "0x182E07220")]
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

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2E0FCB0", Offset = "0x2E0F0B0", VA = "0x182E0FCB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2E10E60", Offset = "0x2E10260", VA = "0x182E10E60", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA19DA0", Offset = "0xA191A0", VA = "0x180A19DA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x12ECF20", Offset = "0x12EC320", VA = "0x1812ECF20", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2D5DC30", Offset = "0x2D5D030", VA = "0x182D5DC30", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2E10760", Offset = "0x2E0FB60", VA = "0x182E10760", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2E096A0", Offset = "0x2E08AA0", VA = "0x182E096A0", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2E0F0B0", Offset = "0x2E0E4B0", VA = "0x182E0F0B0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x187FAA0", Offset = "0x187EEA0", VA = "0x18187FAA0")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2E0ABB0", Offset = "0x2E09FB0", VA = "0x182E0ABB0")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B2C0", Offset = "0x2D5A6C0", VA = "0x182D5B2C0")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B130", Offset = "0x2E0A530", VA = "0x182E0B130")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BAE0", Offset = "0x2E0AEE0", VA = "0x182E0BAE0")]
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

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2E15140", Offset = "0x2E14540", VA = "0x182E15140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1214BE0", Offset = "0x1213FE0", VA = "0x181214BE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xDEDAE0", Offset = "0xDECEE0", VA = "0x180DEDAE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xF16F60", Offset = "0xF16360", VA = "0x180F16F60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2E15160", Offset = "0x2E14560", VA = "0x182E15160", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2E15B80", Offset = "0x2E14F80", VA = "0x182E15B80", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2D5DC30", Offset = "0x2D5D030", VA = "0x182D5DC30", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2E152F0", Offset = "0x2E146F0", VA = "0x182E152F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2E11120", Offset = "0x2E10520", VA = "0x182E11120", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2E141D0", Offset = "0x2E135D0", VA = "0x182E141D0")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FB00", Offset = "0x2D5EF00", VA = "0x182D5FB00")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2E11D60", Offset = "0x2E11160", VA = "0x182E11D60")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AB70", Offset = "0x2E09F70", VA = "0x182E0AB70")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2E12120", Offset = "0x2E11520", VA = "0x182E12120")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B360", Offset = "0x2D5A760", VA = "0x182D5B360")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2E12720", Offset = "0x2E11B20", VA = "0x182E12720")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2E128A0", Offset = "0x2E11CA0", VA = "0x182E128A0")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2D65120", Offset = "0x2D64520", VA = "0x182D65120", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2D66110", Offset = "0x2D65510", VA = "0x182D66110", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2D65160", Offset = "0x2D64560", VA = "0x182D65160", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2D66150", Offset = "0x2D65550", VA = "0x182D66150", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1228A20", Offset = "0x1227E20", VA = "0x181228A20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1227250", Offset = "0x1226650", VA = "0x181227250", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2D651A0", Offset = "0x2D645A0", VA = "0x182D651A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2D66190", Offset = "0x2D65590", VA = "0x182D66190", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2D5DC30", Offset = "0x2D5D030", VA = "0x182D5DC30", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2D651B0", Offset = "0x2D645B0", VA = "0x182D651B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2D5EAB0", Offset = "0x2D5DEB0", VA = "0x182D5EAB0", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2D64380", Offset = "0x2D63780", VA = "0x182D64380")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FB00", Offset = "0x2D5EF00", VA = "0x182D5FB00")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FF00", Offset = "0x2D5F300", VA = "0x182D5FF00")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FB40", Offset = "0x2D5EF40", VA = "0x182D5FB40")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2D60790", Offset = "0x2D5FB90", VA = "0x182D60790")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FBD0", Offset = "0x2D5EFD0", VA = "0x182D5FBD0")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2D60AA0", Offset = "0x2D5FEA0", VA = "0x182D60AA0")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FC90", Offset = "0x2D5F090", VA = "0x182D5FC90")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2D610A0", Offset = "0x2D604A0", VA = "0x182D610A0")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D61DE0", Offset = "0x2D611E0", VA = "0x182D61DE0")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected virtual T1 typedCachedValue1
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x755960", Offset = "0x754D60", VA = "0x180755960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x74B6C0", Offset = "0x74AAC0", VA = "0x18074B6C0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected virtual T2 typedCachedValue2
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x755480", Offset = "0x754880", VA = "0x180755480", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x746AD0", Offset = "0x745ED0", VA = "0x180746AD0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected virtual T3 typedCachedValue3
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA826D0", Offset = "0xA81AD0", VA = "0x180A826D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (T3)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1D94EE0", Offset = "0x1D942E0", VA = "0x181D94EE0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected virtual T4 typedCachedValue4
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xC0B830", Offset = "0xC0AC30", VA = "0x180C0B830", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (T4)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC0B840", Offset = "0xC0AC40", VA = "0x180C0B840", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected virtual T5 typedCachedValue5
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2D65190", Offset = "0x2D64590", VA = "0x182D65190", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (T5)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2D66180", Offset = "0x2D65580", VA = "0x182D66180", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected override object cachedValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2D5DC30", Offset = "0x2D5D030", VA = "0x182D5DC30", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D6C260", Offset = "0x2D6B660", VA = "0x182D6C260", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D66780", Offset = "0x2D65B80", VA = "0x182D66780", Slot = "7")]
		protected override bool EqualsDefaultValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D6B010", Offset = "0x2D6A410", VA = "0x182D6B010")]
		protected SynchronizedFieldBase(INetworkedPlayer player, ISynchronizedFieldContext context, string key, T1 defaultValue1, T2 defaultValue2, T3 defaultValue3, T4 defaultValue4, T5 defaultValue5, SetterPermissionMode permissionMode, bool enforceInitialValue, Action callback, ISynchronizedFieldNetworkBacking networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x187FAA0", Offset = "0x187EEA0", VA = "0x18187FAA0")]
		public T1 Get1()
		{
			return (T1)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D673A0", Offset = "0x2D667A0", VA = "0x182D673A0")]
		public void Set1(T1 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B2C0", Offset = "0x2D5A6C0", VA = "0x182D5B2C0")]
		public T2 Get2()
		{
			return (T2)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D67750", Offset = "0x2D66B50", VA = "0x182D67750")]
		public void Set2(T2 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B330", Offset = "0x2D5A730", VA = "0x182D5B330")]
		public T3 Get3()
		{
			return (T3)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D67D10", Offset = "0x2D67110", VA = "0x182D67D10")]
		public void Set3(T3 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FC20", Offset = "0x2D5F020", VA = "0x182D5FC20")]
		public T4 Get4()
		{
			return (T4)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D68270", Offset = "0x2D67670", VA = "0x182D68270")]
		public void Set4(T4 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D67280", Offset = "0x2D66680", VA = "0x182D67280")]
		public T5 Get5()
		{
			return (T5)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D68510", Offset = "0x2D67910", VA = "0x182D68510")]
		public void Set5(T5 newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D69500", Offset = "0x2D68900", VA = "0x182D69500")]
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
