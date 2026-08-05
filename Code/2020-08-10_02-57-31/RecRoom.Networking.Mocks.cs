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
				[Cpp2IlInjected.Address(RVA = "0x3E41F0", Offset = "0x3E27F0", VA = "0x1803E41F0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool IsLocal
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x2F3EAB0", Offset = "0x2F3D0B0", VA = "0x182F3EAB0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IsMaster
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x2F3EAD0", Offset = "0x2F3D0D0", VA = "0x182F3EAD0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public IDictionary<object, object> CustomProperties
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x3A1830", Offset = "0x39FE30", VA = "0x1803A1830", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			internal MockNetwork MockNetwork
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x39A6F0", Offset = "0x398CF0", VA = "0x18039A6F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2F3E9E0", Offset = "0x2F3CFE0", VA = "0x182F3E9E0")]
			public MockNetworkPlayer(int id, MockNetwork mockNetwork)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2F3E830", Offset = "0x2F3CE30", VA = "0x182F3E830")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A18B0", Offset = "0x39FEB0", VA = "0x1803A18B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MockNetworkPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x3C1840", Offset = "0x3BFE40", VA = "0x1803C1840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3E4210", Offset = "0x3E2810", VA = "0x1803E4210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MockNetworkPlayer MasterPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3A1830", Offset = "0x39FE30", VA = "0x1803A1830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2F3F190", Offset = "0x2F3D790", VA = "0x182F3F190")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<INetworkedPlayer> OnPhotonPlayerDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2F3EFB0", Offset = "0x2F3D5B0", VA = "0x182F3EFB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2F3F0F0", Offset = "0x2F3D6F0", VA = "0x182F3F0F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<INetworkedPlayer> OnMasterClientSwitched
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2F3EF10", Offset = "0x2F3D510", VA = "0x182F3EF10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2F3F050", Offset = "0x2F3D650", VA = "0x182F3F050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2F3EC20", Offset = "0x2F3D220", VA = "0x182F3EC20")]
		public IEnumerable<MockNetworkPlayer> OtherPlayers(INetworkedPlayer localPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2F3ECD0", Offset = "0x2F3D2D0", VA = "0x182F3ECD0")]
		public MockNetworkPlayer RegisterPlayer(bool isLocal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2F3EAF0", Offset = "0x2F3D0F0", VA = "0x182F3EAF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2F3EE80", Offset = "0x2F3D480", VA = "0x182F3EE80")]
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
				[Cpp2IlInjected.Address(RVA = "0x39A6F0", Offset = "0x398CF0", VA = "0x18039A6F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x39A6F0", Offset = "0x398CF0", VA = "0x18039A6F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9F8F50", Offset = "0x9F7550", VA = "0x1809F8F50")]
			[DebuggerHidden]
			public <PlayersToTargetViews>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2F41080", Offset = "0x2F3F680", VA = "0x182F41080", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2F40DE0", Offset = "0x2F3F3E0", VA = "0x182F40DE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2F41130", Offset = "0x2F3F730", VA = "0x182F41130")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2F41030", Offset = "0x2F3F630", VA = "0x182F41030", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2F40F90", Offset = "0x2F3F590", VA = "0x182F40F90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MockPhotonView> IEnumerable<MockPhotonView>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2F40F90", Offset = "0x2F3F590", VA = "0x182F40F90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A18B0", Offset = "0x39FEB0", VA = "0x1803A18B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3E4090", Offset = "0x3E2690", VA = "0x1803E4090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2F40200", Offset = "0x2F3E800", VA = "0x182F40200", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x39EE10", Offset = "0x39D410", VA = "0x18039EE10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3E1260", Offset = "0x3DF860", VA = "0x1803E1260", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2F400C0", Offset = "0x2F3E6C0", VA = "0x182F400C0")]
		public MockPhotonView(int viewId, MockNetwork.MockNetworkPlayer ownerPlayer, params object[] targetObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2F3F1F0", Offset = "0x2F3D7F0", VA = "0x182F3F1F0")]
		public bool AddTargetObject(object newTargetObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2F40060", Offset = "0x2F3E660", VA = "0x182F40060")]
		private void ValidateArguments(Delegate method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2F3F2D0", Offset = "0x2F3D8D0", VA = "0x182F3F2D0")]
		private RPCInfo CreateRPCInfo()
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2F3F320", Offset = "0x2F3D920", VA = "0x182F3F320")]
		private static bool MethodsMatch(MethodInfo a, MethodInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2F3F510", Offset = "0x2F3DB10", VA = "0x182F3F510")]
		[IteratorStateMachine(typeof(<PlayersToTargetViews>d__13))]
		private static IEnumerable<MockPhotonView> PlayersToTargetViews(IEnumerable<MockNetwork.MockNetworkPlayer> players, int targetViewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2F3F590", Offset = "0x2F3DB90", VA = "0x182F3F590")]
		private void SendRpc(Delegate method, TargetHelpers recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2F3F7A0", Offset = "0x2F3DDA0", VA = "0x182F3F7A0")]
		private void SendRpc(Delegate method, IEnumerable<MockPhotonView> recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FF90", Offset = "0x2F3E590", VA = "0x182F3FF90")]
		private bool ShouldSendToOthers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39A750", Offset = "0x398D50", VA = "0x18039A750", Slot = "7")]
		public void RegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39A750", Offset = "0x398D50", VA = "0x18039A750", Slot = "8")]
		public void UnRegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39A750", Offset = "0x398D50", VA = "0x18039A750", Slot = "9")]
		public void RegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x39A750", Offset = "0x398D50", VA = "0x18039A750", Slot = "10")]
		public void UnRegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xE91590", Offset = "0xE8FB90", VA = "0x180E91590", Slot = "11")]
		public void RpcAll<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE91AA0", Offset = "0xE900A0", VA = "0x180E91AA0", Slot = "12")]
		public void RpcOthers<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xE91980", Offset = "0xE8FF80", VA = "0x180E91980", Slot = "13")]
		public void RpcMaster<T1>(RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE918E0", Offset = "0xE8FEE0", VA = "0x180E918E0", Slot = "14")]
		public void RpcAuthority<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE91450", Offset = "0xE8FA50", VA = "0x180E91450", Slot = "15")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2F3F280", Offset = "0x2F3D880", VA = "0x182F3F280", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F40DC0", Offset = "0x2F3F3C0", VA = "0x182F40DC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x458420", Offset = "0x456A20", VA = "0x180458420", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x2F40DA0", Offset = "0x2F3F3A0", VA = "0x182F40DA0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2F40D70", Offset = "0x2F3F370", VA = "0x182F40D70", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2F40D30", Offset = "0x2F3F330", VA = "0x182F40D30", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2F40B50", Offset = "0x2F3F150", VA = "0x182F40B50")]
		public MockSynchronizedFieldNetworkBacking(MockNetwork mockNetwork)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2F403C0", Offset = "0x2F3E9C0", VA = "0x182F403C0", Slot = "1")]
		~MockSynchronizedFieldNetworkBacking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2F40B10", Offset = "0x2F3F110", VA = "0x182F40B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2F407A0", Offset = "0x2F3EDA0", VA = "0x182F407A0", Slot = "22")]
		protected override void SendPendingRoomUpdatesInternal(Dictionary<object, object> pendingRoomPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2F405B0", Offset = "0x2F3EBB0", VA = "0x182F405B0", Slot = "23")]
		protected override void SendPendingPlayerUpdatesInternal(Dictionary<object, object> pendingPlayerPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2F40480", Offset = "0x2F3EA80", VA = "0x182F40480", Slot = "24")]
		protected override HashSet<string> GetPlayerIdsInRoom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x127EBD0", Offset = "0x127D1D0", VA = "0x18127EBD0", Slot = "25")]
		public override object ToSerializableObject<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x10DDD40", Offset = "0x10DC340", VA = "0x1810DDD40", Slot = "26")]
		public override T FromSerializableObject<T>(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2F40210", Offset = "0x2F3E810", VA = "0x182F40210", Slot = "28")]
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
