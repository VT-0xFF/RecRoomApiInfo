using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.Networking.SynchronizedFields;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class MockNetwork : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int CurrentPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int ServerTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly Dictionary<object, object> roomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private HashSet<MockNetworkPlayer> allPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MockNetworkPlayer masterPlayer;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IReadOnlyCollection<MockNetworkPlayer> AllPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5E0", Offset = "0x3DCBE0", VA = "0x1803DE5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MockNetworkPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x3EBAE0", Offset = "0x3EA0E0", VA = "0x1803EBAE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA10", Offset = "0x3DD010", VA = "0x1803DEA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MockNetworkPlayer MasterPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3DFAF0", Offset = "0x3DE0F0", VA = "0x1803DFAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x336AA90", Offset = "0x3369090", VA = "0x18336AA90")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<INetworkedPlayer> OnPhotonPlayerDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x336A8B0", Offset = "0x3368EB0", VA = "0x18336A8B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x336A9F0", Offset = "0x3368FF0", VA = "0x18336A9F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<INetworkedPlayer> OnMasterClientSwitched
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x336A810", Offset = "0x3368E10", VA = "0x18336A810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x336A950", Offset = "0x3368F50", VA = "0x18336A950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x336A4A0", Offset = "0x3368AA0", VA = "0x18336A4A0")]
		public IEnumerable<MockNetworkPlayer> OtherPlayers(INetworkedPlayer localPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x336A550", Offset = "0x3368B50", VA = "0x18336A550")]
		public MockNetworkPlayer RegisterPlayer(bool isLocal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x336A370", Offset = "0x3368970", VA = "0x18336A370", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x336A780", Offset = "0x3368D80", VA = "0x18336A780")]
		public MockNetwork()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MockNetworkPlayer : INetworkedPlayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int currentViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MockNetwork mockNetwork;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly MockSynchronizedFieldNetworkBacking SynchronizedFieldNetworkBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Dictionary<object, object> playerCustomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly Dictionary<int, MockPhotonView> MockPhotonViews;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x442480", Offset = "0x440A80", VA = "0x180442480", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IsLocal
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x336A330", Offset = "0x3368930", VA = "0x18336A330", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsMaster
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x336A350", Offset = "0x3368950", VA = "0x18336A350", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IDictionary<object, object> CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3DFAF0", Offset = "0x3DE0F0", VA = "0x1803DFAF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3F55C0", Offset = "0x3F3BC0", VA = "0x1803F55C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		internal MockNetwork MockNetwork
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x336A260", Offset = "0x3368860", VA = "0x18336A260")]
		public MockNetworkPlayer(int id, MockNetwork mockNetwork)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x336A200", Offset = "0x3368800", VA = "0x18336A200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x336A050", Offset = "0x3368650", VA = "0x18336A050")]
		public MockPhotonView RegisterMockPhotonView(int id, params object[] targets)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MockPhotonView : ISynchronizedFieldContext, IRPCSender
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum TargetHelpers
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			Others,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			MasterClient
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class <PlayersToTargetViews>d__13 : IEnumerable<MockPhotonView>, IEnumerable, IEnumerator<MockPhotonView>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private MockPhotonView <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerable<MockNetworkPlayer> players;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IEnumerable<MockNetworkPlayer> <>3__players;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private int targetViewId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int <>3__targetViewId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private IEnumerator<MockNetworkPlayer> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			MockPhotonView IEnumerator<MockPhotonView>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B66F0", Offset = "0x8B4CF0", VA = "0x1808B66F0")]
			[DebuggerHidden]
			public <PlayersToTargetViews>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x336CBA0", Offset = "0x336B1A0", VA = "0x18336CBA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x336C900", Offset = "0x336AF00", VA = "0x18336C900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x336CC50", Offset = "0x336B250", VA = "0x18336CC50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x336CB50", Offset = "0x336B150", VA = "0x18336CB50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x336CAB0", Offset = "0x336B0B0", VA = "0x18336CAB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MockPhotonView> IEnumerable<MockPhotonView>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x336CAB0", Offset = "0x336B0B0", VA = "0x18336CAB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly int ViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MockNetworkPlayer OwnerPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly HashSet<object> targetObjects;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MockNetworkPlayer AuthorityPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5E0", Offset = "0x3DCBE0", VA = "0x1803DE5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x418760", Offset = "0x416D60", VA = "0x180418760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x336BB10", Offset = "0x336A110", VA = "0x18336BB10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3DF080", Offset = "0x3DD680", VA = "0x1803DF080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3E91B0", Offset = "0x3E77B0", VA = "0x1803E91B0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x336B9D0", Offset = "0x3369FD0", VA = "0x18336B9D0")]
		public MockPhotonView(int viewId, MockNetworkPlayer ownerPlayer, params object[] targetObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x336AB70", Offset = "0x3369170", VA = "0x18336AB70")]
		public bool AddTargetObject(object newTargetObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x336B970", Offset = "0x3369F70", VA = "0x18336B970")]
		private void ValidateArguments(Delegate method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x336AC50", Offset = "0x3369250", VA = "0x18336AC50")]
		private RPCInfo CreateRPCInfo()
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x336ACA0", Offset = "0x33692A0", VA = "0x18336ACA0")]
		private static bool MethodsMatch(MethodInfo a, MethodInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x336AE90", Offset = "0x3369490", VA = "0x18336AE90")]
		[IteratorStateMachine(typeof(<PlayersToTargetViews>d__13))]
		private static IEnumerable<MockPhotonView> PlayersToTargetViews(IEnumerable<MockNetworkPlayer> players, int targetViewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x336AF10", Offset = "0x3369510", VA = "0x18336AF10")]
		private void SendRpc(Delegate method, TargetHelpers recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x336B120", Offset = "0x3369720", VA = "0x18336B120")]
		private void SendRpc(Delegate method, IEnumerable<MockPhotonView> recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x336B910", Offset = "0x3369F10", VA = "0x18336B910")]
		private bool ShouldSendToOthers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D6860", Offset = "0x3D4E60", VA = "0x1803D6860", Slot = "7")]
		public void RegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D6860", Offset = "0x3D4E60", VA = "0x1803D6860", Slot = "8")]
		public void UnRegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D6860", Offset = "0x3D4E60", VA = "0x1803D6860", Slot = "9")]
		public void RegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6860", Offset = "0x3D4E60", VA = "0x1803D6860", Slot = "10")]
		public void UnRegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x14FE570", Offset = "0x14FCB70", VA = "0x1814FE570", Slot = "11")]
		public void RpcAll<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x14FEA80", Offset = "0x14FD080", VA = "0x1814FEA80", Slot = "12")]
		public void RpcOthers<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x14FE960", Offset = "0x14FCF60", VA = "0x1814FE960", Slot = "13")]
		public void RpcMaster<T1>(RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x14FE8C0", Offset = "0x14FCEC0", VA = "0x1814FE8C0", Slot = "14")]
		public void RpcAuthority<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14FE430", Offset = "0x14FCA30", VA = "0x1814FE430", Slot = "15")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x336AC00", Offset = "0x3369200", VA = "0x18336AC00", Slot = "16")]
		public void ClearBufferedRPCs()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MockSynchronizedFieldNetworkBacking : SynchronizedFieldNetworkBackingBase<Dictionary<object, object>>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MockNetwork mockNetwork;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MockNetworkPlayer networkPlayer;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static int staticId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override Dictionary<object, object> RoomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x336C8E0", Offset = "0x336AEE0", VA = "0x18336C8E0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3D3080", Offset = "0x3D1680", VA = "0x1803D3080", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3F55E0", Offset = "0x3F3BE0", VA = "0x1803F55E0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x336C850", Offset = "0x336AE50", VA = "0x18336C850", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x336C810", Offset = "0x336AE10", VA = "0x18336C810", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x336C590", Offset = "0x336AB90", VA = "0x18336C590")]
		public MockSynchronizedFieldNetworkBacking(MockNetwork mockNetwork, [Optional] MockNetworkPlayer networkPlayer, [Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x336BCD0", Offset = "0x336A2D0", VA = "0x18336BCD0", Slot = "1")]
		~MockSynchronizedFieldNetworkBacking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x336C550", Offset = "0x336AB50", VA = "0x18336C550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x336C0B0", Offset = "0x336A6B0", VA = "0x18336C0B0", Slot = "23")]
		protected override void SendPendingRoomUpdatesInternal(Dictionary<object, object> pendingRoomPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x336BEC0", Offset = "0x336A4C0", VA = "0x18336BEC0", Slot = "24")]
		protected override void SendPendingPlayerUpdatesInternal(Dictionary<object, object> pendingPlayerPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x336BD90", Offset = "0x336A390", VA = "0x18336BD90", Slot = "25")]
		protected override HashSet<string> GetPlayerIdsInRoom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x18E0FE0", Offset = "0x18DF5E0", VA = "0x1818E0FE0", Slot = "26")]
		public override object ToSerializableObject<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x16FF8C0", Offset = "0x16FDEC0", VA = "0x1816FF8C0", Slot = "27")]
		public override T FromSerializableObject<T>(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x336BB20", Offset = "0x336A120", VA = "0x18336BB20", Slot = "29")]
		protected override void DisposeInternal()
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
