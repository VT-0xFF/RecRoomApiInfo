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
			public int ActorNumber
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x43E330", Offset = "0x43D330", VA = "0x18043E330", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool IsLocal
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x12E5B60", Offset = "0x12E4B60", VA = "0x1812E5B60", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IsMaster
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x12E5B80", Offset = "0x12E4B80", VA = "0x1812E5B80", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public IDictionary<object, object> CustomProperties
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x3C7180", Offset = "0x3C6180", VA = "0x1803C7180", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			internal MockNetwork MockNetwork
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A90", Offset = "0x12E4A90", VA = "0x1812E5A90")]
			public MockNetworkPlayer(int id, MockNetwork mockNetwork)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A30", Offset = "0x12E4A30", VA = "0x1812E5A30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x12E5880", Offset = "0x12E4880", VA = "0x1812E5880")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C7110", Offset = "0x3C6110", VA = "0x1803C7110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MockNetworkPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x3C7140", Offset = "0x3C6140", VA = "0x1803C7140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3C7120", Offset = "0x3C6120", VA = "0x1803C7120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MockNetworkPlayer MasterPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3C7180", Offset = "0x3C6180", VA = "0x1803C7180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x12E62C0", Offset = "0x12E52C0", VA = "0x1812E62C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<INetworkedPlayer> OnPhotonPlayerDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x12E60E0", Offset = "0x12E50E0", VA = "0x1812E60E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x12E6220", Offset = "0x12E5220", VA = "0x1812E6220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<INetworkedPlayer> OnMasterClientSwitched
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x12E6040", Offset = "0x12E5040", VA = "0x1812E6040")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x12E6180", Offset = "0x12E5180", VA = "0x1812E6180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x12E5CD0", Offset = "0x12E4CD0", VA = "0x1812E5CD0")]
		public IEnumerable<MockNetworkPlayer> OtherPlayers(INetworkedPlayer localPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x12E5D80", Offset = "0x12E4D80", VA = "0x1812E5D80")]
		public MockNetworkPlayer RegisterPlayer(bool isLocal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12E5BA0", Offset = "0x12E4BA0", VA = "0x1812E5BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12E5FB0", Offset = "0x12E4FB0", VA = "0x1812E5FB0")]
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
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x99DB30", Offset = "0x99CB30", VA = "0x18099DB30")]
			[DebuggerHidden]
			public <PlayersToTargetViews>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x12E83C0", Offset = "0x12E73C0", VA = "0x1812E83C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12E8120", Offset = "0x12E7120", VA = "0x1812E8120", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x12E8470", Offset = "0x12E7470", VA = "0x1812E8470")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x12E8370", Offset = "0x12E7370", VA = "0x1812E8370", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x12E82D0", Offset = "0x12E72D0", VA = "0x1812E82D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MockPhotonView> IEnumerable<MockPhotonView>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x12E82D0", Offset = "0x12E72D0", VA = "0x1812E82D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3C7110", Offset = "0x3C6110", VA = "0x1803C7110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C7100", Offset = "0x3C6100", VA = "0x1803C7100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x12E7340", Offset = "0x12E6340", VA = "0x1812E7340", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3E5570", Offset = "0x3E4570", VA = "0x1803E5570", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3CDE00", Offset = "0x3CCE00", VA = "0x1803CDE00", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x12E7200", Offset = "0x12E6200", VA = "0x1812E7200")]
		public MockPhotonView(int viewId, MockNetwork.MockNetworkPlayer ownerPlayer, params object[] targetObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x12E63A0", Offset = "0x12E53A0", VA = "0x1812E63A0")]
		public bool AddTargetObject(object newTargetObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x12E71A0", Offset = "0x12E61A0", VA = "0x1812E71A0")]
		private void ValidateArguments(Delegate method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x12E6480", Offset = "0x12E5480", VA = "0x1812E6480")]
		private RPCInfo CreateRPCInfo()
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x12E64D0", Offset = "0x12E54D0", VA = "0x1812E64D0")]
		private static bool MethodsMatch(MethodInfo a, MethodInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x12E66C0", Offset = "0x12E56C0", VA = "0x1812E66C0")]
		[IteratorStateMachine(typeof(<PlayersToTargetViews>d__13))]
		private static IEnumerable<MockPhotonView> PlayersToTargetViews(IEnumerable<MockNetwork.MockNetworkPlayer> players, int targetViewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x12E6740", Offset = "0x12E5740", VA = "0x1812E6740")]
		private void SendRpc(Delegate method, TargetHelpers recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x12E6950", Offset = "0x12E5950", VA = "0x1812E6950")]
		private void SendRpc(Delegate method, IEnumerable<MockPhotonView> recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x12E7140", Offset = "0x12E6140", VA = "0x1812E7140")]
		private bool ShouldSendToOthers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "7")]
		public void RegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "8")]
		public void UnRegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "9")]
		public void RegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "10")]
		public void UnRegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x22E5A50", Offset = "0x22E4A50", VA = "0x1822E5A50", Slot = "11")]
		public void RpcAll<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x22E5F60", Offset = "0x22E4F60", VA = "0x1822E5F60", Slot = "12")]
		public void RpcOthers<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x22E5E40", Offset = "0x22E4E40", VA = "0x1822E5E40", Slot = "13")]
		public void RpcMaster<T1>(RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x22E5DA0", Offset = "0x22E4DA0", VA = "0x1822E5DA0", Slot = "14")]
		public void RpcAuthority<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x22E5910", Offset = "0x22E4910", VA = "0x1822E5910", Slot = "15")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x12E6430", Offset = "0x12E5430", VA = "0x1812E6430", Slot = "16")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MockNetwork.MockNetworkPlayer networkPlayer;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static int staticId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Dictionary<object, object> RoomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x12E8100", Offset = "0x12E7100", VA = "0x1812E8100", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x540DA0", Offset = "0x53FDA0", VA = "0x180540DA0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C9240", Offset = "0x3C8240", VA = "0x1803C9240", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x12E8080", Offset = "0x12E7080", VA = "0x1812E8080", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x12E8040", Offset = "0x12E7040", VA = "0x1812E8040", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x12E7DC0", Offset = "0x12E6DC0", VA = "0x1812E7DC0")]
		public MockSynchronizedFieldNetworkBacking(MockNetwork mockNetwork, [Optional] MockNetwork.MockNetworkPlayer networkPlayer, [Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x12E7500", Offset = "0x12E6500", VA = "0x1812E7500", Slot = "1")]
		~MockSynchronizedFieldNetworkBacking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x12E7D80", Offset = "0x12E6D80", VA = "0x1812E7D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x12E78E0", Offset = "0x12E68E0", VA = "0x1812E78E0", Slot = "23")]
		protected override void SendPendingRoomUpdatesInternal(Dictionary<object, object> pendingRoomPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x12E76F0", Offset = "0x12E66F0", VA = "0x1812E76F0", Slot = "24")]
		protected override void SendPendingPlayerUpdatesInternal(Dictionary<object, object> pendingPlayerPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x12E75C0", Offset = "0x12E65C0", VA = "0x1812E75C0", Slot = "25")]
		protected override HashSet<string> GetPlayerIdsInRoom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x23E65B0", Offset = "0x23E55B0", VA = "0x1823E65B0", Slot = "26")]
		public override object ToSerializableObject<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x20A56E0", Offset = "0x20A46E0", VA = "0x1820A56E0", Slot = "27")]
		public override T FromSerializableObject<T>(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x12E7350", Offset = "0x12E6350", VA = "0x1812E7350", Slot = "29")]
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
