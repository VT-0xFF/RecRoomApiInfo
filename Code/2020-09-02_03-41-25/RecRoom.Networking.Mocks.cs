using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class MockNetworkPlayer : INetworkedPlayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private int currentViewId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly int id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private readonly MockNetwork mockNetwork;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly MockSynchronizedFieldNetworkBacking SynchronizedFieldNetworkBacking;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private readonly Dictionary<object, object> playerCustomProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			internal readonly Dictionary<int, MockPhotonView> MockPhotonViews;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public int ID
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x4E4440", Offset = "0x4E3040", VA = "0x1804E4440", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool IsLocal
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0xD9FD30", Offset = "0xD9E930", VA = "0x180D9FD30", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IsMaster
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD9FD50", Offset = "0xD9E950", VA = "0x180D9FD50", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public IDictionary<object, object> CustomProperties
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x39A230", Offset = "0x398E30", VA = "0x18039A230", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			internal MockNetwork MockNetwork
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x39A240", Offset = "0x398E40", VA = "0x18039A240")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD9FC60", Offset = "0xD9E860", VA = "0x180D9FC60")]
			public MockNetworkPlayer(int id, MockNetwork mockNetwork)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD9FAB0", Offset = "0xD9E6B0", VA = "0x180D9FAB0")]
			public MockPhotonView RegisterMockPhotonView(int id, params object[] targets)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int CurrentPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int ServerTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal readonly Dictionary<object, object> roomProperties;

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
			[Cpp2IlInjected.Address(RVA = "0x39A220", Offset = "0x398E20", VA = "0x18039A220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MockNetworkPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x39A250", Offset = "0x398E50", VA = "0x18039A250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x39A290", Offset = "0x398E90", VA = "0x18039A290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MockNetworkPlayer MasterPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x39A230", Offset = "0x398E30", VA = "0x18039A230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDA0410", Offset = "0xD9F010", VA = "0x180DA0410")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<INetworkedPlayer> OnPhotonPlayerDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xDA0230", Offset = "0xD9EE30", VA = "0x180DA0230")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDA0370", Offset = "0xD9EF70", VA = "0x180DA0370")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<INetworkedPlayer> OnMasterClientSwitched
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xDA0190", Offset = "0xD9ED90", VA = "0x180DA0190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xDA02D0", Offset = "0xD9EED0", VA = "0x180DA02D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD9FEA0", Offset = "0xD9EAA0", VA = "0x180D9FEA0")]
		public IEnumerable<MockNetworkPlayer> OtherPlayers(INetworkedPlayer localPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD9FF50", Offset = "0xD9EB50", VA = "0x180D9FF50")]
		public MockNetworkPlayer RegisterPlayer(bool isLocal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD9FD70", Offset = "0xD9E970", VA = "0x180D9FD70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDA0100", Offset = "0xD9ED00", VA = "0x180DA0100")]
		public MockNetwork()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MockPhotonView : ISynchronizedFieldContext, IRPCSender
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum TargetHelpers
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Others,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			MasterClient
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class <PlayersToTargetViews>d__13 : IEnumerable<MockPhotonView>, IEnumerable, IEnumerator<MockPhotonView>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private MockPhotonView <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private IEnumerable<MockNetwork.MockNetworkPlayer> players;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IEnumerable<MockNetwork.MockNetworkPlayer> <>3__players;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int targetViewId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public int <>3__targetViewId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerator<MockNetwork.MockNetworkPlayer> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			MockPhotonView IEnumerator<MockPhotonView>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x39A240", Offset = "0x398E40", VA = "0x18039A240", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x39A240", Offset = "0x398E40", VA = "0x18039A240", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x606160", Offset = "0x604D60", VA = "0x180606160")]
			[DebuggerHidden]
			public <PlayersToTargetViews>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xDA2300", Offset = "0xDA0F00", VA = "0x180DA2300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xDA2060", Offset = "0xDA0C60", VA = "0x180DA2060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xDA23B0", Offset = "0xDA0FB0", VA = "0x180DA23B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xDA22B0", Offset = "0xDA0EB0", VA = "0x180DA22B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xDA2210", Offset = "0xDA0E10", VA = "0x180DA2210", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MockPhotonView> IEnumerable<MockPhotonView>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xDA2210", Offset = "0xDA0E10", VA = "0x180DA2210", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly int ViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly MockNetwork.MockNetworkPlayer OwnerPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<object> targetObjects;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MockNetwork.MockNetworkPlayer AuthorityPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x39A220", Offset = "0x398E20", VA = "0x18039A220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x39A260", Offset = "0x398E60", VA = "0x18039A260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xDA1480", Offset = "0xDA0080", VA = "0x180DA1480", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3EC970", Offset = "0x3EB570", VA = "0x1803EC970", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x39AC50", Offset = "0x399850", VA = "0x18039AC50", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDA1340", Offset = "0xD9FF40", VA = "0x180DA1340")]
		public MockPhotonView(int viewId, MockNetwork.MockNetworkPlayer ownerPlayer, params object[] targetObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xDA0470", Offset = "0xD9F070", VA = "0x180DA0470")]
		public bool AddTargetObject(object newTargetObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDA12E0", Offset = "0xD9FEE0", VA = "0x180DA12E0")]
		private void ValidateArguments(Delegate method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xDA0550", Offset = "0xD9F150", VA = "0x180DA0550")]
		private RPCInfo CreateRPCInfo()
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDA05A0", Offset = "0xD9F1A0", VA = "0x180DA05A0")]
		private static bool MethodsMatch(MethodInfo a, MethodInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xDA0790", Offset = "0xD9F390", VA = "0x180DA0790")]
		[IteratorStateMachine(typeof(<PlayersToTargetViews>d__13))]
		private static IEnumerable<MockPhotonView> PlayersToTargetViews(IEnumerable<MockNetwork.MockNetworkPlayer> players, int targetViewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDA0810", Offset = "0xD9F410", VA = "0x180DA0810")]
		private void SendRpc(Delegate method, TargetHelpers recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDA0A20", Offset = "0xD9F620", VA = "0x180DA0A20")]
		private void SendRpc(Delegate method, IEnumerable<MockPhotonView> recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xDA1210", Offset = "0xD9FE10", VA = "0x180DA1210")]
		private bool ShouldSendToOthers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F60", Offset = "0x3A1B60", VA = "0x1803A2F60", Slot = "7")]
		public void RegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F60", Offset = "0x3A1B60", VA = "0x1803A2F60", Slot = "8")]
		public void UnRegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F60", Offset = "0x3A1B60", VA = "0x1803A2F60", Slot = "9")]
		public void RegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F60", Offset = "0x3A1B60", VA = "0x1803A2F60", Slot = "10")]
		public void UnRegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8DA0", Offset = "0x1DA79A0", VA = "0x181DA8DA0", Slot = "11")]
		public void RpcAll<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA92B0", Offset = "0x1DA7EB0", VA = "0x181DA92B0", Slot = "12")]
		public void RpcOthers<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9190", Offset = "0x1DA7D90", VA = "0x181DA9190", Slot = "13")]
		public void RpcMaster<T1>(RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1DA90F0", Offset = "0x1DA7CF0", VA = "0x181DA90F0", Slot = "14")]
		public void RpcAuthority<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8C60", Offset = "0x1DA7860", VA = "0x181DA8C60", Slot = "15")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDA0500", Offset = "0xD9F100", VA = "0x180DA0500", Slot = "16")]
		public void ClearBufferedRPCs()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MockSynchronizedFieldNetworkBacking : SynchronizedFieldNetworkBackingBase<Dictionary<object, object>>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly MockNetwork mockNetwork;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static int staticId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Dictionary<object, object> RoomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xDA2040", Offset = "0xDA0C40", VA = "0x180DA2040", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4C3900", Offset = "0x4C2500", VA = "0x1804C3900", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xDA2020", Offset = "0xDA0C20", VA = "0x180DA2020", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xDA1FF0", Offset = "0xDA0BF0", VA = "0x180DA1FF0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xDA1FB0", Offset = "0xDA0BB0", VA = "0x180DA1FB0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xDA1DD0", Offset = "0xDA09D0", VA = "0x180DA1DD0")]
		public MockSynchronizedFieldNetworkBacking(MockNetwork mockNetwork)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDA1640", Offset = "0xDA0240", VA = "0x180DA1640", Slot = "1")]
		~MockSynchronizedFieldNetworkBacking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xDA1D90", Offset = "0xDA0990", VA = "0x180DA1D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xDA1A20", Offset = "0xDA0620", VA = "0x180DA1A20", Slot = "22")]
		protected override void SendPendingRoomUpdatesInternal(Dictionary<object, object> pendingRoomPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDA1830", Offset = "0xDA0430", VA = "0x180DA1830", Slot = "23")]
		protected override void SendPendingPlayerUpdatesInternal(Dictionary<object, object> pendingPlayerPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDA1700", Offset = "0xDA0300", VA = "0x180DA1700", Slot = "24")]
		protected override HashSet<string> GetPlayerIdsInRoom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1F96100", Offset = "0x1F94D00", VA = "0x181F96100", Slot = "25")]
		public override object ToSerializableObject<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1B0AF00", Offset = "0x1B09B00", VA = "0x181B0AF00", Slot = "26")]
		public override T FromSerializableObject<T>(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDA1490", Offset = "0xDA0090", VA = "0x180DA1490", Slot = "28")]
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
