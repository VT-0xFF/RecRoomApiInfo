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
				[Cpp2IlInjected.Address(RVA = "0x431230", Offset = "0x42FE30", VA = "0x180431230", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool IsLocal
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x30D07A0", Offset = "0x30CF3A0", VA = "0x1830D07A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IsMaster
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x30D07C0", Offset = "0x30CF3C0", VA = "0x1830D07C0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public IDictionary<object, object> CustomProperties
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x3C9550", Offset = "0x3C8150", VA = "0x1803C9550", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			internal MockNetwork MockNetwork
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x3B28C0", Offset = "0x3B14C0", VA = "0x1803B28C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x30D06D0", Offset = "0x30CF2D0", VA = "0x1830D06D0")]
			public MockNetworkPlayer(int id, MockNetwork mockNetwork)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x30D0670", Offset = "0x30CF270", VA = "0x1830D0670", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x30D04C0", Offset = "0x30CF0C0", VA = "0x1830D04C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BAA20", Offset = "0x3B9620", VA = "0x1803BAA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MockNetworkPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x43A400", Offset = "0x439000", VA = "0x18043A400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x43A3F0", Offset = "0x438FF0", VA = "0x18043A3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MockNetworkPlayer MasterPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3C9550", Offset = "0x3C8150", VA = "0x1803C9550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x30D0F00", Offset = "0x30CFB00", VA = "0x1830D0F00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<INetworkedPlayer> OnPhotonPlayerDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x30D0D20", Offset = "0x30CF920", VA = "0x1830D0D20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x30D0E60", Offset = "0x30CFA60", VA = "0x1830D0E60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<INetworkedPlayer> OnMasterClientSwitched
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x30D0C80", Offset = "0x30CF880", VA = "0x1830D0C80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x30D0DC0", Offset = "0x30CF9C0", VA = "0x1830D0DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x30D0910", Offset = "0x30CF510", VA = "0x1830D0910")]
		public IEnumerable<MockNetworkPlayer> OtherPlayers(INetworkedPlayer localPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x30D09C0", Offset = "0x30CF5C0", VA = "0x1830D09C0")]
		public MockNetworkPlayer RegisterPlayer(bool isLocal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x30D07E0", Offset = "0x30CF3E0", VA = "0x1830D07E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x30D0BF0", Offset = "0x30CF7F0", VA = "0x1830D0BF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3B28C0", Offset = "0x3B14C0", VA = "0x1803B28C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3B28C0", Offset = "0x3B14C0", VA = "0x1803B28C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63AE10", Offset = "0x639A10", VA = "0x18063AE10")]
			[DebuggerHidden]
			public <PlayersToTargetViews>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x30D3000", Offset = "0x30D1C00", VA = "0x1830D3000", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x30D2D60", Offset = "0x30D1960", VA = "0x1830D2D60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x30D30B0", Offset = "0x30D1CB0", VA = "0x1830D30B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x30D2FB0", Offset = "0x30D1BB0", VA = "0x1830D2FB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x30D2F10", Offset = "0x30D1B10", VA = "0x1830D2F10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MockPhotonView> IEnumerable<MockPhotonView>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x30D2F10", Offset = "0x30D1B10", VA = "0x1830D2F10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BAA20", Offset = "0x3B9620", VA = "0x1803BAA20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x42AAA0", Offset = "0x4296A0", VA = "0x18042AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30D1F80", Offset = "0x30D0B80", VA = "0x1830D1F80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3B9C30", Offset = "0x3B8830", VA = "0x1803B9C30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3CF640", Offset = "0x3CE240", VA = "0x1803CF640", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x30D1E40", Offset = "0x30D0A40", VA = "0x1830D1E40")]
		public MockPhotonView(int viewId, MockNetwork.MockNetworkPlayer ownerPlayer, params object[] targetObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x30D0FE0", Offset = "0x30CFBE0", VA = "0x1830D0FE0")]
		public bool AddTargetObject(object newTargetObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x30D1DE0", Offset = "0x30D09E0", VA = "0x1830D1DE0")]
		private void ValidateArguments(Delegate method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x30D10C0", Offset = "0x30CFCC0", VA = "0x1830D10C0")]
		private RPCInfo CreateRPCInfo()
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x30D1110", Offset = "0x30CFD10", VA = "0x1830D1110")]
		private static bool MethodsMatch(MethodInfo a, MethodInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x30D1300", Offset = "0x30CFF00", VA = "0x1830D1300")]
		[IteratorStateMachine(typeof(<PlayersToTargetViews>d__13))]
		private static IEnumerable<MockPhotonView> PlayersToTargetViews(IEnumerable<MockNetwork.MockNetworkPlayer> players, int targetViewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x30D1380", Offset = "0x30CFF80", VA = "0x1830D1380")]
		private void SendRpc(Delegate method, TargetHelpers recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x30D1590", Offset = "0x30D0190", VA = "0x1830D1590")]
		private void SendRpc(Delegate method, IEnumerable<MockPhotonView> recipients, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30D1D80", Offset = "0x30D0980", VA = "0x1830D1D80")]
		private bool ShouldSendToOthers()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B2920", Offset = "0x3B1520", VA = "0x1803B2920", Slot = "7")]
		public void RegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B2920", Offset = "0x3B1520", VA = "0x1803B2920", Slot = "8")]
		public void UnRegisterOnDestroyingListener(Action onDestroyingCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B2920", Offset = "0x3B1520", VA = "0x1803B2920", Slot = "9")]
		public void RegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B2920", Offset = "0x3B1520", VA = "0x1803B2920", Slot = "10")]
		public void UnRegisterOnDestroyedListener(Action onDestroyedCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE3DF10", Offset = "0xE3CB10", VA = "0x180E3DF10", Slot = "11")]
		public void RpcAll<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xE3E420", Offset = "0xE3D020", VA = "0x180E3E420", Slot = "12")]
		public void RpcOthers<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE3E300", Offset = "0xE3CF00", VA = "0x180E3E300", Slot = "13")]
		public void RpcMaster<T1>(RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE3E260", Offset = "0xE3CE60", VA = "0x180E3E260", Slot = "14")]
		public void RpcAuthority<T1, T2>(RPCActions.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE3DDD0", Offset = "0xE3C9D0", VA = "0x180E3DDD0", Slot = "15")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, RPCActions.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x30D1070", Offset = "0x30CFC70", VA = "0x1830D1070", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0x30D2D40", Offset = "0x30D1940", VA = "0x1830D2D40", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int InvalidPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x839E80", Offset = "0x838A80", VA = "0x180839E80", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override INetworkedPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3B66F0", Offset = "0x3B52F0", VA = "0x1803B66F0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x30D2CC0", Offset = "0x30D18C0", VA = "0x1830D2CC0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool InRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x30D2C80", Offset = "0x30D1880", VA = "0x1830D2C80", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x30D2A00", Offset = "0x30D1600", VA = "0x1830D2A00")]
		public MockSynchronizedFieldNetworkBacking(MockNetwork mockNetwork, [Optional] MockNetwork.MockNetworkPlayer networkPlayer, [Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x30D2140", Offset = "0x30D0D40", VA = "0x1830D2140", Slot = "1")]
		~MockSynchronizedFieldNetworkBacking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x30D29C0", Offset = "0x30D15C0", VA = "0x1830D29C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x30D2520", Offset = "0x30D1120", VA = "0x1830D2520", Slot = "23")]
		protected override void SendPendingRoomUpdatesInternal(Dictionary<object, object> pendingRoomPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x30D2330", Offset = "0x30D0F30", VA = "0x1830D2330", Slot = "24")]
		protected override void SendPendingPlayerUpdatesInternal(Dictionary<object, object> pendingPlayerPropertyUpdates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x30D2200", Offset = "0x30D0E00", VA = "0x1830D2200", Slot = "25")]
		protected override HashSet<string> GetPlayerIdsInRoom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1643030", Offset = "0x1641C30", VA = "0x181643030", Slot = "26")]
		public override object ToSerializableObject<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x114C120", Offset = "0x114AD20", VA = "0x18114C120", Slot = "27")]
		public override T FromSerializableObject<T>(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x30D1F90", Offset = "0x30D0B90", VA = "0x1830D1F90", Slot = "29")]
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
