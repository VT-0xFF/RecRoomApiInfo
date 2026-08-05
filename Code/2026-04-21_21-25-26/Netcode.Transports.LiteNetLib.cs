using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using AOT;
using Cpp2IlInjected;
using LiteNetLib;
using LiteNetLib.Layers;
using LiteNetLib.Sockets;
using LiteNetLib.Utils;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, FGGAIVFISZL
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum HostType
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Client
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Tooltip("The port to listen on (if server) or connect to (if client)")]
		public ushort Port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("The address to connect to as client; ignored if server")]
		public string Address;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Tooltip("Interval between ping packets used for detecting latency and checking connection, in seconds")]
		public float PingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Tooltip("Maximum duration for a connection to survive without receiving packets, in seconds")]
		public float DisconnectTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Delay between connection attempts, in seconds")]
		public float ReconnectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Tooltip("Maximum connection attempts before client stops and reports a disconnection")]
		public int MaxConnectAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Tooltip("Size of default buffer for decoding incoming packets, in bytes")]
		public int MessageBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Tooltip("Simulated chance for a packet to be \"lost\", from 0 (no simulation) to 100 percent")]
		public int SimulatePacketLossChance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Tooltip("Simulated minimum additional latency for packets in milliseconds (0 for no simulation)")]
		public int SimulateMinLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Tooltip("Simulated maximum additional latency for packets in milliseconds (0 for no simulation")]
		public int SimulateMaxLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NetworkManager MIQOOVOMOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool UTESMGCCMIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, VUZQRMISFIM> WWCWHSATWSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private WBICUZCDOVB TSVIGOYBGUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch QWTRWRBPJJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] YSIVGFUSANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType ZZTFLWFYGJZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int DQHXFCPPLBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB300", Offset = "0x8BB9D00", VA = "0x188BBB300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB2B0", Offset = "0x8BB9CB0", VA = "0x188BBB2B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA790", Offset = "0x8BB9190", VA = "0x188BBA790")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA770", Offset = "0x8BB9170", VA = "0x188BBA770")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA570", Offset = "0x8BB8F70", VA = "0x188BBA570")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB190", Offset = "0x8BB9B90", VA = "0x188BBB190")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA960", Offset = "0x8BB9360", VA = "0x188BBA960", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA660", Offset = "0x8BB9060", VA = "0x188BBA660", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAC30", Offset = "0x8BB9630", VA = "0x188BBAC30", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAF70", Offset = "0x8BB9970", VA = "0x188BBAF70", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9F40", Offset = "0x8BB8940", VA = "0x188BB9F40", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9E50", Offset = "0x8BB8850", VA = "0x188BB9E50", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA250", Offset = "0x8BB8C50", VA = "0x188BBA250", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BBABC0", Offset = "0x8BB95C0", VA = "0x188BBABC0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA2F0", Offset = "0x8BB8CF0", VA = "0x188BBA2F0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA050", Offset = "0x8BB8A50", VA = "0x188BBA050")]
		private DeliveryMethod ESUAQCMZHAW(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA8A0", Offset = "0x8BB92A0", VA = "0x188BBA8A0", Slot = "16")]
		private void SPIZKOXNGAZ(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA180", Offset = "0x8BB8B80", VA = "0x188BBA180", Slot = "17")]
		private void GHFBARKSRAJ(VUZQRMISFIM a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "18")]
		private void GNKBERBXKUW(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9C50", Offset = "0x8BB8650", VA = "0x188BB9C50", Slot = "19")]
		private void DQASMSNBLHL(VUZQRMISFIM a, BIGNNKRLLHV b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA6A0", Offset = "0x8BB90A0", VA = "0x188BBA6A0")]
		private void RWGUFIITMCS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "20")]
		private void QLUBOPUPBZT(IPEndPoint a, BIGNNKRLLHV b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "21")]
		private void OUYNXZHXUCX(VUZQRMISFIM a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA120", Offset = "0x8BB8B20", VA = "0x188BBA120", Slot = "22")]
		private void GDHMFWFJZVF(TETONNBIJLQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA500", Offset = "0x8BB8F00", VA = "0x188BBA500")]
		private ulong JDQMFNXEQSU(VUZQRMISFIM a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA530", Offset = "0x8BB8F30", VA = "0x188BBA530")]
		private ulong JDQMFNXEQSU(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA550", Offset = "0x8BB8F50", VA = "0x188BBA550")]
		private static int LUIIAMFKJOV(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB1E0", Offset = "0x8BB9BE0", VA = "0x188BBB1E0")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB1B0", Offset = "0x8BB9BB0", VA = "0x188BBB1B0")]
		[CompilerGenerated]
		private void VWYHDMQHEXF(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB1B0", Offset = "0x8BB9BB0", VA = "0x188BBB1B0")]
		[CompilerGenerated]
		private void VNYFDNWCORU(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class CVKNVEXMLZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly VUZQRMISFIM LKOUPDJZSJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<EAORRUZIRGE> ENGEDOQPGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int TJFCIJXFCCF;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int WTEDGCAVFSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6E60", Offset = "0x8BB5860", VA = "0x188BB6E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6EB0", Offset = "0x8BB58B0", VA = "0x188BB6EB0")]
		protected CVKNVEXMLZR(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6D40", Offset = "0x8BB5740", VA = "0x188BB6D40")]
		public void ARNVTZIQIOY(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6DA0", Offset = "0x8BB57A0", VA = "0x188BB6DA0")]
		protected void CRMWNBTIIGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6E20", Offset = "0x8BB5820", VA = "0x188BB6E20")]
		public bool EKXFFGWONLJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool IFFCWNVJWRR();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool RRKQMCZAHYS(EAORRUZIRGE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal enum ConnectionRequestResult
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Accept,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Reject,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RejectForce
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class TETONNBIJLQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly WBICUZCDOVB HFWGXKXLDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int IEVMCVFCDQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal ZWBISDEFWSX NKYTORAQZGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint GOQPYFJWNTQ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult MNQYCISKHBS
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE140", Offset = "0x8BBCB40", VA = "0x188BBE140")]
		internal void RTKFNRJQUHT(ZWBISDEFWSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE110", Offset = "0x8BBCB10", VA = "0x188BBE110")]
		private bool OWLFYHYOPOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE1A0", Offset = "0x8BBCBA0", VA = "0x188BBE1A0")]
		internal TETONNBIJLQ(IPEndPoint a, ZWBISDEFWSX b, WBICUZCDOVB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE0B0", Offset = "0x8BBCAB0", VA = "0x188BBE0B0")]
		public VUZQRMISFIM Accept()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum UnconnectedMessageType
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		BasicMessage,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Broadcast
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DisconnectReason
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		ConnectionFailed,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Timeout,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		HostUnreachable,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		NetworkUnreachable,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		RemoteConnectionClose,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		DisconnectPeerCalled,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		ConnectionRejected,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		InvalidProtocol,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		UnknownHost,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Reconnect,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		PeerToPeerConnection,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		PeerNotFound
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct DisconnectInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public DisconnectReason Reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public SocketError SocketErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public BIGNNKRLLHV AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface FGGAIVFISZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BMWJWEOCQBF(VUZQRMISFIM a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JZRCZMETOLV(VUZQRMISFIM a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KUHXGOCLWVK(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ROCJYAMJXNZ(VUZQRMISFIM a, BIGNNKRLLHV b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LPMSOGEJTOX(IPEndPoint a, BIGNNKRLLHV b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QBCJUAAMTBT(VUZQRMISFIM a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void INDPBOXDUND(TETONNBIJLQ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface NESRHOMLTFS
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LEEVBVHWOIJ(VUZQRMISFIM a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PMLSADGXOHQ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DFHRTGHLTUB(EGLGBBSOEQF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface FSTFOKUGSDS
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BVHSOHHDDUQ(VUZQRMISFIM a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class ZWBISDEFWSX
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int JQCKOZZKGGR = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long ERKNEBYZOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte FAJZSSDMYNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] PVECFWOHSGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly FSVCPCYGMGD PXUWVBIVPWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int DNVHBYPPYLC;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCBF0", Offset = "0x8BCB5F0", VA = "0x188BCCBF0")]
		private ZWBISDEFWSX(long a, byte b, int c, byte[] d, FSVCPCYGMGD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC9D0", Offset = "0x8BCB3D0", VA = "0x188BCC9D0")]
		public static int CDQVRISPGSO(EAORRUZIRGE a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCA00", Offset = "0x8BCB400", VA = "0x188BCCA00")]
		public static ZWBISDEFWSX TSEVGFICECN(EAORRUZIRGE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC7F0", Offset = "0x8BCB1F0", VA = "0x188BCC7F0")]
		public static EAORRUZIRGE BXQRNXFEQQD(ZFXMZLDFTIP a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class SMJIVQQAFZM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long ERKNEBYZOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte FAJZSSDMYNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int DNVHBYPPYLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool NSBQGVYJKUL;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD660", Offset = "0x8BBC060", VA = "0x188BBD660")]
		private SMJIVQQAFZM(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD560", Offset = "0x8BBBF60", VA = "0x188BBD560")]
		public static SMJIVQQAFZM TSEVGFICECN(EAORRUZIRGE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD370", Offset = "0x8BBBD70", VA = "0x188BBD370")]
		public static EAORRUZIRGE BXQRNXFEQQD(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD460", Offset = "0x8BBBE60", VA = "0x188BBD460")]
		public static EAORRUZIRGE FAIEEQHEUBH(VUZQRMISFIM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum NatAddressType
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		External
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface PVWDPHUIGRT
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EWQOQSWBKMA(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BCNQFCLDCZQ(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class SOJPTMHZMIQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct RequestEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public IPEndPoint LocalEndPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public IPEndPoint RemoteEndPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string Token;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct SuccessEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public IPEndPoint TargetEndPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public NatAddressType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public string Token;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private class SJNHOFGYNRE
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint VKODFOMPKTO
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string JKGMCIRUCDI
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public SJNHOFGYNRE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class PDAZZKHXFJI
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint VKODFOMPKTO
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint YDEQUIDHPYC
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string JKGMCIRUCDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PDAZZKHXFJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class QFPDLXXOXBC
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string JKGMCIRUCDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool JSZGJZGUYNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public QFPDLXXOXBC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly WBICUZCDOVB VOHRARFSAPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> NOEEYVMZOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> VMNNSEZNQKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly FSVCPCYGMGD ONKAQXOQJRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly ZFXMZLDFTIP EUVOTITLEZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly AMJWKGCFUSU NVCVMPZSIBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PVWDPHUIGRT LZBEQEDGBYD;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int WRJODHPZJGG = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool EZZMEPJRMFT;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDCC0", Offset = "0x8BBC6C0", VA = "0x188BBDCC0")]
		internal SOJPTMHZMIQ(WBICUZCDOVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD810", Offset = "0x8BBC210", VA = "0x188BBD810")]
		internal void EELOKAXWQGJ(IPEndPoint a, EAORRUZIRGE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3F4DF60", Offset = "0x3F4C960", VA = "0x183F4DF60")]
		private void CVDJBAKMHPZ<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD990", Offset = "0x8BBC390", VA = "0x188BBD990")]
		private void EWQOQSWBKMA(SJNHOFGYNRE a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD6B0", Offset = "0x8BBC0B0", VA = "0x188BBD6B0")]
		private void BHUFBKHRYGQ(PDAZZKHXFJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDB20", Offset = "0x8BBC520", VA = "0x188BBDB20")]
		private void YEMBNUMXOWJ(QFPDLXXOXBC a, IPEndPoint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum DeliveryMethod : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Unreliable = 4,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ReliableUnordered = 0,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Sequenced = 1,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		ReliableOrdered = 2,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ReliableSequenced = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum ConnectionQuality : long
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Excellent,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Fair,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Poor
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class AOMUMNUADQV
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] OGOSRQAJUHQ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int JPHEAIIGHQM;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int CEIYYVDJXFL;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9BB0", Offset = "0x8BB85B0", VA = "0x188BB9BB0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9BB0", Offset = "0x8BB85B0", VA = "0x188BB9BB0")]
		public TooBigPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum NetLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Trace,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Info
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IUCFHFIUOUT
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FFZYHIRDFAP(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class WZCKGHLHOFZ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static IUCFHFIUOUT KFPDQSSEPJL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object KGEUECKTGYR;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB670", Offset = "0x8BCA070", VA = "0x188BCB670")]
		private static void WUTPLUWENXM(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB610", Offset = "0x8BCA010", VA = "0x188BCB610")]
		internal static void QLISYGJXFAK(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB8A0", Offset = "0x8BCA2A0", VA = "0x188BCB8A0")]
		internal static void XZWMJCKNSSI(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB5B0", Offset = "0x8BC9FB0", VA = "0x188BCB5B0")]
		internal static void HZBROMKWCFU(string a, params object[] args)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum IPv6Mode
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		SeparateSocket,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		DualMode
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class BIGNNKRLLHV : FSVCPCYGMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private EAORRUZIRGE OPHARUOTTXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly WBICUZCDOVB KPTIGNREHUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly FXITFCCALDK GFGHLYVQZDV;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5CD0", Offset = "0x8BB46D0", VA = "0x188BB5CD0")]
		internal BIGNNKRLLHV(WBICUZCDOVB a, FXITFCCALDK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5C30", Offset = "0x8BB4630", VA = "0x188BB5C30")]
		internal void GZJEIXBXHIW(EAORRUZIRGE a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5BB0", Offset = "0x8BB45B0", VA = "0x188BB5BB0")]
		internal void FHWACZURLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5CA0", Offset = "0x8BB46A0", VA = "0x188BB5CA0")]
		public void KBNUBLGMCKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class FXITFCCALDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public enum EType
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Connect,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Disconnect,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			Receive,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			ReceiveUnconnected,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			Error,
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			ConnectionLatencyUpdated,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			Broadcast,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			ConnectionRequest,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			MessageDelivered,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			PeerAddressChanged
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FXITFCCALDK AZIENLMDEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType YFKMMNNXMAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public VUZQRMISFIM LKOUPDJZSJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint GOQPYFJWNTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object TJXLEELGCPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int VIMTVVYYETX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError WUSYHMZSJFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason OCUFANSMEMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TETONNBIJLQ TETONNBIJLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod ILTBREUWQSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte HIOSEPWVFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly BIGNNKRLLHV HVKEGWEPYMS;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8BB95B0", Offset = "0x8BB7FB0", VA = "0x188BB95B0")]
		public FXITFCCALDK(WBICUZCDOVB a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class WBICUZCDOVB : IEnumerable<VUZQRMISFIM>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class QHRQWECIMTY : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCA60", Offset = "0x8BBB460", VA = "0x188BBCA60", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCAD0", Offset = "0x8BBB4D0", VA = "0x188BBCAD0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public QHRQWECIMTY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<VUZQRMISFIM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly VUZQRMISFIM _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private VUZQRMISFIM _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public VUZQRMISFIM Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xF5DD60", Offset = "0xF5C760", VA = "0x180F5DD60", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF5DD60", Offset = "0xF5C760", VA = "0x180F5DD60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DA8660", Offset = "0x1DA7060", VA = "0x181DA8660")]
			public NetPeerEnumerator(VUZQRMISFIM p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC020", Offset = "0x8BBAA20", VA = "0x188BBC020", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC070", Offset = "0x8BBAA70", VA = "0x188BBC070", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread OLVXMGENMQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool ZSAYLDOZSST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool LLRVBWBMISY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private FWAGDTULAQU IFOPLYLJVBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent FIKCDCTVIFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<FXITFCCALDK> CEUIVFFJDZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<FXITFCCALDK> OCJFUOQPZUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private FXITFCCALDK STBRMAWHYGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly FGGAIVFISZL XQBVUATZUNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly NESRHOMLTFS PGWDRPQOBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly PMLSADGXOHQ QMCELTVMKWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly FSTFOKUGSDS CCTPAUIRJZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, VUZQRMISFIM> PPOAQMYKSJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, TETONNBIJLQ> SZLPKBKYSPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, TKFHDCAGOUO> UDZFJYDZETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim MGDIAVNONHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private VUZQRMISFIM WCBNNUXXXEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int BIQXZXCNRMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<VUZQRMISFIM> ENLRVFIWOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private VUZQRMISFIM[] CQDLTRCDPVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CVWDQNVCUZB SXFTRKFKEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int VGKGRKTNRJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> DQZHFPSXXKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte IKSOGKVKVAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object STLTUHJBWON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool SGOMZIYQVVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool QDBXQCYUNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int NPHJTDTZKMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int IHUXFSTIBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int KXBFQGEQHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int VLOARSSVKTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool XCEUONYROYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool BGCKKSREEOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int ZQHGBBBKHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int DFAYXGNLMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int UYMAQQBNOVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool EZZMEPJRMFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool KZRZAOFMPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool XSNJBHRJSXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool BZYGGXGFXMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int RHSIUJELKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int SMGUDGBZLNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool FDHFBHMGQAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly MFIIXYHJYXR ZZCWREFHUFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool XTWYUCWIRCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly SOJPTMHZMIQ SOJPTMHZMIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool KDXEIHIHLXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode PGKEVUFLFIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int PYNLJMMJQEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool WXFCTFYJZQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool SYTJOKJVNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool BUVPXMLNWBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool CZKUDUDGQZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private EAORRUZIRGE GROOBTGLXFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int ANZXNEUQSRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object JPANWNIGQHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private EAORRUZIRGE HSOJLEIPXYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int YKLXIWTDPPM;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int PMDCVTOAMBY = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int MZBWRCIYSYX = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private XFOIVFWBRJD UXCYEPECISW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private XFOIVFWBRJD UWSKKBQHPWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread XQHWEOCSFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread XQSJZBQMXYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint NAWTMSNSAGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint NBHHHGBMTDL;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] ZWQNRJNTTNZ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] CJHOWUNKFKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> FQWBYZXJACI;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress PQZDLPZZMXN;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool RWPHGPPHJTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int HTETUWRUEJZ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool VEALUAIXSZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE760F0", Offset = "0xE74AF0", VA = "0x180E760F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE75BA0", Offset = "0xE745A0", VA = "0x180E75BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int ENQVWKMMVVR
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x225EFE0", Offset = "0x225D9E0", VA = "0x18225EFE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23771A0", Offset = "0x2375BA0", VA = "0x1823771A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte DKNICLBZBNS
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE298A0", Offset = "0xE282A0", VA = "0x180E298A0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int FRIBXCKLHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BC4BC0", Offset = "0x8BC35C0", VA = "0x188BC4BC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short GFRPGAUDJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8BC58A0", Offset = "0x8BC42A0", VA = "0x188BC58A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event VUZQRMISFIM.OnUpdatedMtuDelegate EVZQYFVVUGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3B10", Offset = "0x8BC2510", VA = "0x188BC3B10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BC5770", Offset = "0x8BC4170", VA = "0x188BC5770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5960", Offset = "0x8BC4360", VA = "0x188BC5960")]
		public void NYYMTKPVOFP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA5C0", Offset = "0x8BC8FC0", VA = "0x188BCA5C0")]
		public void ZSODPHGIGKI(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3000", Offset = "0x8BC1A00", VA = "0x188BC3000")]
		private bool ADAZEBAYTNQ(IPEndPoint a, [Out] VUZQRMISFIM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BC78A0", Offset = "0x8BC62A0", VA = "0x188BC78A0")]
		private void UPWZLULFWFS(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4150", Offset = "0x8BC2B50", VA = "0x188BC4150")]
		private void DMOBMRQZWFL(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3850", Offset = "0x8BC2250", VA = "0x188BC3850")]
		private void BECYOCPNVWA(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA7D0", Offset = "0x8BC91D0", VA = "0x188BCA7D0")]
		public WBICUZCDOVB(FGGAIVFISZL a, [Optional] CVWDQNVCUZB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5720", Offset = "0x8BC4120", VA = "0x188BC5720")]
		internal void KAIRSEQRTUI(VUZQRMISFIM a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5370", Offset = "0x8BC3D70", VA = "0x188BC5370")]
		internal void IWAXVUDIRIE(VUZQRMISFIM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7860", Offset = "0x8BC6260", VA = "0x188BC7860")]
		internal void UNGXEZXKJHA(VUZQRMISFIM a, DisconnectReason b, SocketError c, EAORRUZIRGE d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7DA0", Offset = "0x8BC67A0", VA = "0x188BC7DA0")]
		private void WRGBUTDVWJV(VUZQRMISFIM a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, EAORRUZIRGE h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC30A0", Offset = "0x8BC1AA0", VA = "0x188BC30A0")]
		private void AEHIHHPZHKL(FXITFCCALDK.EType a, [Optional] VUZQRMISFIM b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] TETONNBIJLQ g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] EAORRUZIRGE j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC41B0", Offset = "0x8BC2BB0", VA = "0x188BC41B0")]
		private void EZIWBHLKQDE(FXITFCCALDK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6170", Offset = "0x8BC4B70", VA = "0x188BC6170")]
		internal void RUKSXCFAYVM(FXITFCCALDK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC53C0", Offset = "0x8BC3DC0", VA = "0x188BC53C0")]
		private void IZROUBYXIAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4BE0", Offset = "0x8BC35E0", VA = "0x188BC4BE0")]
		private void GFYRTLRGUZI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6430", Offset = "0x8BC4E30", VA = "0x188BC6430")]
		internal VUZQRMISFIM SNYZPBGLHOB(TETONNBIJLQ a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3500", Offset = "0x8BC1F00", VA = "0x188BC3500")]
		private int ARPXOEMNKDB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5CD0", Offset = "0x8BC46D0", VA = "0x188BC5CD0")]
		private void RJEGBUOCDFP(IPEndPoint a, VUZQRMISFIM b, ZWBISDEFWSX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8EA0", Offset = "0x8BC78A0", VA = "0x188BC8EA0")]
		private void YETTICUJUTW(EAORRUZIRGE a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3580", Offset = "0x8BC1F80", VA = "0x188BC3580")]
		internal void AWTRUJYFXAW(EAORRUZIRGE a, DeliveryMethod b, byte c, int d, VUZQRMISFIM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6B10", Offset = "0x8BC5510", VA = "0x188BC6B10")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6AF0", Offset = "0x8BC54F0", VA = "0x188BC6AF0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6A70", Offset = "0x8BC5470", VA = "0x188BC6A70")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6280", Offset = "0x8BC4C80", VA = "0x188BC6280")]
		public void SHOBBYAMXSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3BC0", Offset = "0x8BC25C0", VA = "0x188BC3BC0")]
		public VUZQRMISFIM Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4070", Offset = "0x8BC2A70", VA = "0x188BC4070")]
		public VUZQRMISFIM Connect(string address, int port, ZFXMZLDFTIP connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3CA0", Offset = "0x8BC26A0", VA = "0x188BC3CA0")]
		public VUZQRMISFIM Connect(IPEndPoint target, ZFXMZLDFTIP connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7290", Offset = "0x8BC5C90", VA = "0x188BC7290")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC72A0", Offset = "0x8BC5CA0", VA = "0x188BC72A0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8A70", Offset = "0x8BC7470", VA = "0x188BC8A70")]
		public void XRJHIGRSEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC89A0", Offset = "0x8BC73A0", VA = "0x188BC89A0")]
		public void XRJHIGRSEEC(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7D60", Offset = "0x8BC6760", VA = "0x188BC7D60")]
		public void WRGBUTDVWJV(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7D20", Offset = "0x8BC6720", VA = "0x188BC7D20")]
		public void WRGBUTDVWJV(VUZQRMISFIM a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3470", Offset = "0x8BC1E70", VA = "0x188BC3470", Slot = "4")]
		private IEnumerator<VUZQRMISFIM> AMFEGJTFFZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BC77D0", Offset = "0x8BC61D0", VA = "0x188BC77D0", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BC76E0", Offset = "0x8BC60E0", VA = "0x188BC76E0")]
		private EAORRUZIRGE TFGIPALMLXO(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7600", Offset = "0x8BC6000", VA = "0x188BC7600")]
		private EAORRUZIRGE TFGIPALMLXO(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4980", Offset = "0x8BC3380", VA = "0x188BC4980")]
		internal EAORRUZIRGE FJVBRELXGND(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA1D0", Offset = "0x8BC8BD0", VA = "0x188BCA1D0")]
		internal void YWLOZDMDQVO(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA710", Offset = "0x8BC9110", VA = "0x188BCA710")]
		static WBICUZCDOVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE760F0", Offset = "0xE74AF0", VA = "0x180E760F0")]
		private bool DMZBRHFJFQP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7BC0", Offset = "0x8BC65C0", VA = "0x188BC7BC0")]
		private void WOWIXSLKSYN(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5B80", Offset = "0x8BC4580", VA = "0x188BC5B80")]
		private void PSSOSHFRJJU(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC51D0", Offset = "0x8BC3BD0", VA = "0x188BC51D0")]
		private bool IIFALEJJFCQ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5880", Offset = "0x8BC4280", VA = "0x188BC5880")]
		private void MPQABXBUEZN(FWAGDTULAQU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4F10", Offset = "0x8BC3910", VA = "0x188BC4F10")]
		private void HBPSRZHOPUI(XFOIVFWBRJD a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8B20", Offset = "0x8BC7520", VA = "0x188BC8B20")]
		private void YADUYWMFJOU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6B20", Offset = "0x8BC5520", VA = "0x188BC6B20")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5820", Offset = "0x8BC4220", VA = "0x188BC5820")]
		internal int LEOSWWHVYEZ(EAORRUZIRGE a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8960", Offset = "0x8BC7360", VA = "0x188BC8960")]
		internal int XPOBEWMRDZN(EAORRUZIRGE a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8190", Offset = "0x8BC6B90", VA = "0x188BC8190")]
		internal int XPOBEWMRDZN(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA440", Offset = "0x8BC8E40", VA = "0x188BCA440")]
		internal void ZANGYPHIVAK(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal enum PacketProperty : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Unreliable,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Channeled,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Ack,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Ping,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Pong,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		ConnectRequest,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		ConnectAccept,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		UnconnectedMessage,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		MtuCheck,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		MtuOk,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Merged,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ShutdownOk,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		PeerNotFound,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		InvalidProtocol,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		NatMessage,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Empty
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class EAORRUZIRGE
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int HEDIHGVIBYL;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] SOLASLJPESW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] LGWKHCPETFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int ZGMQWATVAWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object TJXLEELGCPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public EAORRUZIRGE AZIENLMDEDO;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty OPNSYIBLXMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6F80", Offset = "0x8BB5980", VA = "0x188BB6F80")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6F40", Offset = "0x8BB5940", VA = "0x188BB6F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte FAJZSSDMYNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BB73A0", Offset = "0x8BB5DA0", VA = "0x188BB73A0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7010", Offset = "0x8BB5A10", VA = "0x188BB7010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort GILZQNQNKLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7280", Offset = "0x8BB5C80", VA = "0x188BB7280")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6FB0", Offset = "0x8BB59B0", VA = "0x188BB6FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CFVQMPTYWPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7180", Offset = "0x8BB5B80", VA = "0x188BB7180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte XFZYSALOPDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7050", Offset = "0x8BB5A50", VA = "0x188BB7050")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7430", Offset = "0x8BB5E30", VA = "0x188BB7430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort LKNWCMDPKIU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8BB73D0", Offset = "0x8BB5DD0", VA = "0x188BB73D0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8BB71D0", Offset = "0x8BB5BD0", VA = "0x188BB71D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort JISOHTHSEMQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8BB71B0", Offset = "0x8BB5BB0", VA = "0x188BB71B0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7210", Offset = "0x8BB5C10", VA = "0x188BB7210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort BUALKKLBZKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6FF0", Offset = "0x8BB59F0", VA = "0x188BB6FF0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BB73F0", Offset = "0x8BB5DF0", VA = "0x188BB73F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7460", Offset = "0x8BB5E60", VA = "0x188BB7460")]
		static EAORRUZIRGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7250", Offset = "0x8BB5C50", VA = "0x188BB7250")]
		public void OCBJGCDLFAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7840", Offset = "0x8BB6240", VA = "0x188BB7840")]
		public EAORRUZIRGE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7730", Offset = "0x8BB6130", VA = "0x188BB7730")]
		public EAORRUZIRGE(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB72A0", Offset = "0x8BB5CA0", VA = "0x188BB72A0")]
		public static int SMOCHREBFRN(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7310", Offset = "0x8BB5D10", VA = "0x188BB7310")]
		public int SMOCHREBFRN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7080", Offset = "0x8BB5A80", VA = "0x188BB7080")]
		public bool KEPRZPVOYQA()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Flags]
	public enum ConnectionState : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Outgoing = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Connected = 4,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		ShutdownRequested = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Disconnected = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		EndPointChange = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Any = 0x2E
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal enum ConnectRequestResult
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		P2PLose,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Reconnection,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		NewConnection
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal enum DisconnectResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Reject,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Disconnect
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal enum ShutdownResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		WasConnected
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class VUZQRMISFIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class FXMRFILWHUW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public EAORRUZIRGE[] ZHRWJLYOJWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int WQJUPOWBUEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int BGLAJPTWMJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte XFZYSALOPDD;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FXMRFILWHUW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int TOVQCWZRTLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int BYTKKFKGYZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int TEUTEEHHPLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double DSBLQSVIUDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int DNBQZGLMZQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int ITJTSNDWNEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int EAEZMXWGGSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch BMRFJLPQJCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int ZLZHWRXEHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long AXTYPMMOGCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object MKPMGFELLVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal VUZQRMISFIM QAJPITEEUKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal VUZQRMISFIM CFAQWKSHZHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<EAORRUZIRGE> EACJTDNFKRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<CVKNVEXMLZR> CUJCBKPBTUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly CVKNVEXMLZR[] MOEXFGMEHPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int VNLPOOAKYTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int CKODTNHGBSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool UHGBZZZADIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int CLVVDURVZBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int NMQUCEFLTCE;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int ZIDWETUUWXO = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int GLNAVRCOIEX = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object CZECSHIIWVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int SYXPABJLROH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, FXMRFILWHUW> BRFVKUBEHZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> MNCLJSCJNZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly EAORRUZIRGE LXEQFEDQTHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int RYPATQAVOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int DWTMXXNWIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint ZNHHJOEMOOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int ODCKSBRYNXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int TTDSQAJJQFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long LUSAASONXIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte GXFDGGPSDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState HETZFBRLMGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private EAORRUZIRGE IAEZKFGIXLC;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int NPZSTUHTZJY = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int ZPTJHHAQEDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly EAORRUZIRGE WCUGSWLWFUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly EAORRUZIRGE WXMZGLEALRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly EAORRUZIRGE TKPISERRVYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly EAORRUZIRGE TQIFICSTZDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality QUPXKQRFJXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly WBICUZCDOVB WBICUZCDOVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int CRWLHSKOIBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object DNQXWBUMARF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly MFIIXYHJYXR ZZCWREFHUFM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte PIJIZKQCVWD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD3CDB0", Offset = "0xD3B7B0", VA = "0x180D3CDB0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF1C0", Offset = "0x8BBDBC0", VA = "0x188BBF1C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint BILBARVTJTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE8FB40", Offset = "0xE8E540", VA = "0x180E8FB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState CIYQRLHCDJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x14B5C50", Offset = "0x14B4650", VA = "0x1814B5C50")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long JDEQLDYBZNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD14140", Offset = "0xD12B40", VA = "0x180D14140")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int YTAZWSECCWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x225EFE0", Offset = "0x225D9E0", VA = "0x18225EFE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x23771A0", Offset = "0x2375BA0", VA = "0x1823771A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int GZYKIYSBARL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2170", Offset = "0x8BC0B70", VA = "0x188BC2170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int TRXPSUTFRUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double WTDELSLSPHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AF99E0", Offset = "0x2AF83E0", VA = "0x182AF99E0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate EVZQYFVVUGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF0E0", Offset = "0x8BBDAE0", VA = "0x188BBF0E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF970", Offset = "0x8BBE370", VA = "0x188BBF970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2890", Offset = "0x8BC1290", VA = "0x188BC2890")]
		internal VUZQRMISFIM(WBICUZCDOVB a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BC13B0", Offset = "0x8BBFDB0", VA = "0x188BC13B0")]
		internal void TKJSXRKQBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFA20", Offset = "0x8BBE420", VA = "0x188BBFA20")]
		internal void LGTAFZEMOCD(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF550", Offset = "0x8BBDF50", VA = "0x188BBF550")]
		internal void GFYWMEYTQBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFEF0", Offset = "0x8BBE8F0", VA = "0x188BBFEF0")]
		private void RKRIQOGJCVH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFCF0", Offset = "0x8BBE6F0", VA = "0x188BBFCF0")]
		private void QMQNEHNWRYT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF440", Offset = "0x8BBDE40", VA = "0x188BBF440")]
		public int FFHGDJBLHIT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF320", Offset = "0x8BBDD20", VA = "0x188BBF320")]
		public int FFHGDJBLHIT(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1FE0", Offset = "0x8BC09E0", VA = "0x188BC1FE0")]
		private CVKNVEXMLZR VIVNLRWIAMI(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2E70", Offset = "0x8BC1870", VA = "0x188BC2E70")]
		internal VUZQRMISFIM(WBICUZCDOVB a, IPEndPoint b, int c, byte d, ZFXMZLDFTIP e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2C90", Offset = "0x8BC1690", VA = "0x188BC2C90")]
		internal VUZQRMISFIM(WBICUZCDOVB a, TETONNBIJLQ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0660", Offset = "0x8BBF060", VA = "0x188BC0660")]
		internal void Reject(ZWBISDEFWSX requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2180", Offset = "0x8BC0B80", VA = "0x188BC2180")]
		internal bool XZDYDAOYHVO(SMJIVQQAFZM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF190", Offset = "0x8BBDB90", VA = "0x188BBF190")]
		public void CVDJBAKMHPZ(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BC22A0", Offset = "0x8BC0CA0", VA = "0x188BC22A0")]
		private void ZDJMPQJYUVI(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF270", Offset = "0x8BBDC70", VA = "0x188BBF270")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2200", Offset = "0x8BC0C00", VA = "0x188BC2200")]
		internal DisconnectResult YSACENXALGQ(EAORRUZIRGE a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF2C0", Offset = "0x8BBDCC0", VA = "0x188BBF2C0")]
		internal void EHVOGYFXYZB(CVKNVEXMLZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC10A0", Offset = "0x8BBFAA0", VA = "0x188BC10A0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFCB0", Offset = "0x8BBE6B0", VA = "0x188BBFCB0")]
		private void PDWZTMNDRTI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0800", Offset = "0x8BBF200", VA = "0x188BC0800")]
		internal void SMSAUTGSHNA(DeliveryMethod a, EAORRUZIRGE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1AA0", Offset = "0x8BC04A0", VA = "0x188BC1AA0")]
		private void VCGRJQECOUG(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF5E0", Offset = "0x8BBDFE0", VA = "0x188BBF5E0")]
		private void IAMEFXUREQK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFD30", Offset = "0x8BBE730", VA = "0x188BBFD30")]
		internal ConnectRequestResult RJEGBUOCDFP(ZWBISDEFWSX a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFFC0", Offset = "0x8BBE9C0", VA = "0x188BBFFC0")]
		internal void RRKQMCZAHYS(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC06B0", Offset = "0x8BBF0B0", VA = "0x188BC06B0")]
		private void SCXHQHAOAVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEED0", Offset = "0x8BBD8D0", VA = "0x188BBEED0")]
		internal void AXPUDNEINKI(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC13D0", Offset = "0x8BBFDD0", VA = "0x188BC13D0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFA50", Offset = "0x8BBE450", VA = "0x188BBFA50")]
		internal void OUOVGCVHFTG(EAORRUZIRGE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class MFIIXYHJYXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long XNDXMXYQKDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long NJMCYPPZONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long IGNDFXWLFYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long ZZRRLTCVMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long TBOZBTUEJYJ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long HBSYTQQXPRW;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long QHVJLTMCAKZ;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long HBTDNGJYTQG;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long IRLSENDTOHJ;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long BSPLEVZHEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long GRVHPBTGCDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long KTXEDOPDYVJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long SHNBUACFXRC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB550", Offset = "0x8BB9F50", VA = "0x188BBB550")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long TCGFUKIRCFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB680", Offset = "0x8BBA080", VA = "0x188BBB680")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long KMQQJHMOCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB750", Offset = "0x8BBA150", VA = "0x188BBB750")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long CTUZGJQPOXF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB540", Offset = "0x8BB9F40", VA = "0x188BBB540")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long WJCDBLCSEIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BBBC40", Offset = "0x8BBA640", VA = "0x188BBBC40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long TXZKODYFAGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB630", Offset = "0x8BBA030", VA = "0x188BBB630")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long PCLFPBKILMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB840", Offset = "0x8BBA240", VA = "0x188BBB840")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long SBREKYNURCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB640", Offset = "0x8BBA040", VA = "0x188BBB640")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality LATAATFNPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double XNDZPBLINST
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB480", Offset = "0x8BB9E80", VA = "0x188BBB480")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB800", Offset = "0x8BBA200", VA = "0x188BBB800")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB4E0", Offset = "0x8BB9EE0", VA = "0x188BBB4E0")]
		public void AVAZGJYPLUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB700", Offset = "0x8BBA100", VA = "0x188BBB700")]
		public void QRYMMUJJWWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB560", Offset = "0x8BB9F60", VA = "0x188BBB560")]
		public void IFDYRMBGINL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB690", Offset = "0x8BBA090", VA = "0x188BBB690")]
		public void PKHINFTJFNW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB5D0", Offset = "0x8BB9FD0", VA = "0x188BBB5D0")]
		public void MLGTEJBGNOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBBC0", Offset = "0x8BBA5C0", VA = "0x188BBBBC0")]
		public void VWTDSMWTKWL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB880", Offset = "0x8BBA280", VA = "0x188BBB880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB760", Offset = "0x8BBA160", VA = "0x188BBB760")]
		public void RPJDHDPUKUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public MFIIXYHJYXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class HZCODQCFKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> EEUFNFMWNAE;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8BB98B0", Offset = "0x8BB82B0", VA = "0x188BB98B0")]
		public static IPEndPoint QUUVUPMVCBM(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9650", Offset = "0x8BB8050", VA = "0x188BB9650")]
		public static IPAddress IUMEEJPZRRP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9820", Offset = "0x8BB8220", VA = "0x188BB9820")]
		public static IPAddress IUMEEJPZRRP(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9AF0", Offset = "0x8BB84F0", VA = "0x188BB9AF0")]
		internal static int SOFJCXNCLDL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B740", Offset = "0x3B1A140", VA = "0x183B1B740")]
		internal static T[] QKSZUAEHUTW<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class COLBXGPJRCG : CVKNVEXMLZR
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private EAORRUZIRGE _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC1F0", Offset = "0x8BBABF0", VA = "0x188BBC1F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC160", Offset = "0x8BBAB60", VA = "0x188BBC160")]
			public void RKCBVVMJUOD(EAORRUZIRGE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC180", Offset = "0x8BBAB80", VA = "0x188BBC180")]
			public bool TEKTPBKGLXO(long a, VUZQRMISFIM b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC110", Offset = "0x8BBAB10", VA = "0x188BBC110")]
			public bool Clear(VUZQRMISFIM peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly EAORRUZIRGE OJYDUUKBNDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] LPQUTOTCTFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly EAORRUZIRGE[] JYDFIVUNDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] JWYEIIWEWUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int IYATLZZRVDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int ZGUPZKHMGUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int FJQUSXGPAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int IVNHYARBOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool NGLZRRKDVQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod BUTGOPFJOYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool EMDTSTAXZNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int GSCBTXEJIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte LOUSXGFJLDN;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int JHWWCKEFHAM
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6B70", Offset = "0x8BB5570", VA = "0x188BB6B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6B80", Offset = "0x8BB5580", VA = "0x188BB6B80")]
		public COLBXGPJRCG(VUZQRMISFIM a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5D20", Offset = "0x8BB4720", VA = "0x188BB5D20")]
		private void DQPNQJUFOPV(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB60A0", Offset = "0x8BB4AA0", VA = "0x188BB60A0", Slot = "4")]
		protected override bool IFFCWNVJWRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6570", Offset = "0x8BB4F70", VA = "0x188BB6570", Slot = "5")]
		public override bool RRKQMCZAHYS(EAORRUZIRGE a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class QAPZICFGRTJ : CVKNVEXMLZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int IKUYKTKPFEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort ZGUPZKHMGUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool XVXLZRGBGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private EAORRUZIRGE RGDZDCSQECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly EAORRUZIRGE PRFCFSYQSFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool UPCRGWAFMHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte LOUSXGFJLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long VJENBCUDWIV;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC9A0", Offset = "0x8BBB3A0", VA = "0x188BBC9A0")]
		public QAPZICFGRTJ(VUZQRMISFIM a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC260", Offset = "0x8BBAC60", VA = "0x188BBC260", Slot = "4")]
		protected override bool IFFCWNVJWRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC720", Offset = "0x8BBB120", VA = "0x188BBC720", Slot = "5")]
		public override bool RRKQMCZAHYS(EAORRUZIRGE a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class RKCYURJJKMG
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct ConverterHelperDouble
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public ulong Along;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public double Adouble;
		}

		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct ConverterHelperFloat
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int Aint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public float Afloat;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5200", Offset = "0x8BB3C00", VA = "0x188BB5200")]
		private static void KQBQCVWTNVB(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB20", Offset = "0x8BBB520", VA = "0x188BBCB20")]
		private static void KQBQCVWTNVB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC20", Offset = "0x8BBB620", VA = "0x188BBCC20")]
		public static void KQBQCVWTNVB(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB00", Offset = "0x8BBB500", VA = "0x188BBCB00")]
		public static void GXRVNCFILNA(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB90", Offset = "0x8BBB590", VA = "0x188BBCB90")]
		public static void GXRVNCFILNA(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC20", Offset = "0x8BBB620", VA = "0x188BBCC20")]
		public static void GXRVNCFILNA(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC20", Offset = "0x8BBB620", VA = "0x188BBCC20")]
		public static void GXRVNCFILNA(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB20", Offset = "0x8BBB520", VA = "0x188BBCB20")]
		public static void GXRVNCFILNA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB20", Offset = "0x8BBB520", VA = "0x188BBCB20")]
		public static void GXRVNCFILNA(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC10", Offset = "0x8BBB610", VA = "0x188BBCC10")]
		public static void GXRVNCFILNA(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC10", Offset = "0x8BBB610", VA = "0x188BBCC10")]
		public static void GXRVNCFILNA(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class FSVCPCYGMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] VZKTTPGNGSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int DLVANCWECHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int AFPUJILLMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int ATNAWAPAWLP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] LGWKHCPETFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OPKHXJWZEEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int OYZVFPVBVFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8BB9290", Offset = "0x8BB7C90", VA = "0x188BB9290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CGVUTGXWAAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A59550", Offset = "0x2A57F50", VA = "0x182A59550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int EDQULJPNWSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8BB94C0", Offset = "0x8BB7EC0", VA = "0x188BB94C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8F00", Offset = "0x8BB7900", VA = "0x188BB8F00")]
		public void GZJEIXBXHIW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public FSVCPCYGMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9550", Offset = "0x8BB7F50", VA = "0x188BB9550")]
		public FSVCPCYGMGD(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8BB91C0", Offset = "0x8BB7BC0", VA = "0x188BB91C0")]
		public IPEndPoint JIZWHGQVBPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB92A0", Offset = "0x8BB7CA0", VA = "0x188BB92A0")]
		public byte JRLEKQIXLAF()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB92A0", Offset = "0x8BB7CA0", VA = "0x188BB92A0")]
		public sbyte NNAQBWAXLDQ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE480", Offset = "0x3AECE80", VA = "0x183AEE480")]
		public a[] THFJAFUCQOU<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8D90", Offset = "0x8BB7790", VA = "0x188BB8D90")]
		public bool[] AKWTQYHUUME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9320", Offset = "0x8BB7D20", VA = "0x188BB9320")]
		public ushort[] QTTDKRSIAMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9480", Offset = "0x8BB7E80", VA = "0x188BB9480")]
		public short[] WZNNFUOKPBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9180", Offset = "0x8BB7B80", VA = "0x188BB9180")]
		public int[] ISKGUIOIOYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9510", Offset = "0x8BB7F10", VA = "0x188BB9510")]
		public uint[] ZGTDGMPBSWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8DD0", Offset = "0x8BB77D0", VA = "0x188BB8DD0")]
		public float[] BFGLHRCKNGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9250", Offset = "0x8BB7C50", VA = "0x188BB9250")]
		public double[] JNJIXPPBKXZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9390", Offset = "0x8BB7D90", VA = "0x188BB9390")]
		public long[] SHWTKKCEQWK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8BB93D0", Offset = "0x8BB7DD0", VA = "0x188BB93D0")]
		public ulong[] TPMLVQFZGYZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8CC0", Offset = "0x8BB76C0", VA = "0x188BB8CC0")]
		public string[] AJLDJJAFOXR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8BB94D0", Offset = "0x8BB7ED0", VA = "0x188BB94D0")]
		public bool YSPTQUMSMXJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8EA0", Offset = "0x8BB78A0", VA = "0x188BB8EA0")]
		public char MVGGPIYGHKD()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8EA0", Offset = "0x8BB78A0", VA = "0x188BB8EA0")]
		public ushort TTICGPGHIKA()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8EA0", Offset = "0x8BB78A0", VA = "0x188BB8EA0")]
		public short DISYCMGZLMP()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9150", Offset = "0x8BB7B50", VA = "0x188BB9150")]
		public long NEBMHJJYLEB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9150", Offset = "0x8BB7B50", VA = "0x188BB9150")]
		public ulong IIABNXYZSFS()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9360", Offset = "0x8BB7D60", VA = "0x188BB9360")]
		public int TJALRFIUNJW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9360", Offset = "0x8BB7D60", VA = "0x188BB9360")]
		public uint RPKCVSQDTFN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9410", Offset = "0x8BB7E10", VA = "0x188BB9410")]
		public float TSTRHRCZTET()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8ED0", Offset = "0x8BB78D0", VA = "0x188BB8ED0")]
		public double DUJEZWDTTKO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8F40", Offset = "0x8BB7940", VA = "0x188BB8F40")]
		public string HCRODWCQXOW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8E10", Offset = "0x8BB7810", VA = "0x188BB8E10")]
		public ArraySegment<byte> BFNZUXONBAL(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8BB92E0", Offset = "0x8BB7CE0", VA = "0x188BB92E0")]
		public sbyte[] NJXQPCWSPNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9440", Offset = "0x8BB7E40", VA = "0x188BB9440")]
		public byte[] WGHSVZDXJZY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8E80", Offset = "0x8BB7880", VA = "0x188BB8E80")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class ZFXMZLDFTIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] VZKTTPGNGSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int DLVANCWECHP;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int LSZVFFSXUFU = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool JAGCQEXXDRL;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding OMZFONGZUST;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int FHAOYJGSWXO = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] XHIQTYCUKAZ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC6D0", Offset = "0x8BCB0D0", VA = "0x188BCC6D0")]
		public ZFXMZLDFTIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC750", Offset = "0x8BCB150", VA = "0x188BCC750")]
		public ZFXMZLDFTIP(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC5E0", Offset = "0x8BCAFE0", VA = "0x188BCC5E0")]
		public static ZFXMZLDFTIP TUZBEOPRIPO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBEE0", Offset = "0x8BCA8E0", VA = "0x188BCBEE0")]
		public void JQTEZLWDCLY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1A60", Offset = "0x2AD0460", VA = "0x182AD1A60")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC200", Offset = "0x8BCAC00", VA = "0x188BCC200")]
		public void NLAXRAVZBOC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC590", Offset = "0x8BCAF90", VA = "0x188BCC590")]
		public void NLAXRAVZBOC(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC050", Offset = "0x8BCAA50", VA = "0x188BCC050")]
		public void NLAXRAVZBOC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC050", Offset = "0x8BCAA50", VA = "0x188BCC050")]
		public void NLAXRAVZBOC(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC170", Offset = "0x8BCAB70", VA = "0x188BCC170")]
		public void NLAXRAVZBOC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC170", Offset = "0x8BCAB70", VA = "0x188BCC170")]
		public void NLAXRAVZBOC(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBF80", Offset = "0x8BCA980", VA = "0x188BCBF80")]
		public void NLAXRAVZBOC(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBF80", Offset = "0x8BCA980", VA = "0x188BCBF80")]
		public void NLAXRAVZBOC(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBF80", Offset = "0x8BCA980", VA = "0x188BCBF80")]
		public void NLAXRAVZBOC(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBFF0", Offset = "0x8BCA9F0", VA = "0x188BCBFF0")]
		public void NLAXRAVZBOC(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBFF0", Offset = "0x8BCA9F0", VA = "0x188BCBFF0")]
		public void NLAXRAVZBOC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC520", Offset = "0x8BCAF20", VA = "0x188BCC520")]
		public void NLAXRAVZBOC(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBE00", Offset = "0x8BCA800", VA = "0x188BCBE00")]
		public void IMPNXTOPVGG(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBE00", Offset = "0x8BCA800", VA = "0x188BCBE00")]
		public void KSARLMDUPRX(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC2A0", Offset = "0x8BCACA0", VA = "0x188BCC2A0")]
		public void NLAXRAVZBOC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBD20", Offset = "0x8BCA720", VA = "0x188BCBD20")]
		public void CHDUGUWZUWX(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB9B0", Offset = "0x8BCA3B0", VA = "0x188BCB9B0")]
		public void CHDUGUWZUWX(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBB60", Offset = "0x8BCA560", VA = "0x188BCBB60")]
		public void CHDUGUWZUWX(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBB60", Offset = "0x8BCA560", VA = "0x188BCBB60")]
		public void CHDUGUWZUWX(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBB60", Offset = "0x8BCA560", VA = "0x188BCBB60")]
		public void CHDUGUWZUWX(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB9B0", Offset = "0x8BCA3B0", VA = "0x188BCB9B0")]
		public void CHDUGUWZUWX(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB9B0", Offset = "0x8BCA3B0", VA = "0x188BCB9B0")]
		public void CHDUGUWZUWX(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBC40", Offset = "0x8BCA640", VA = "0x188BCBC40")]
		public void CHDUGUWZUWX(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBC40", Offset = "0x8BCA640", VA = "0x188BCBC40")]
		public void CHDUGUWZUWX(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBE00", Offset = "0x8BCA800", VA = "0x188BCBE00")]
		public void CHDUGUWZUWX(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBA90", Offset = "0x8BCA490", VA = "0x188BCBA90")]
		public void CHDUGUWZUWX(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC0A0", Offset = "0x8BCAAA0", VA = "0x188BCC0A0")]
		public void NLAXRAVZBOC(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC300", Offset = "0x8BCAD00", VA = "0x188BCC300")]
		public void NLAXRAVZBOC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC310", Offset = "0x8BCAD10", VA = "0x188BCC310")]
		public void NLAXRAVZBOC(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AMJWKGCFUSU
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class SMHFTSMFUZI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong CRWLHSKOIBS;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x79F7B80", Offset = "0x79F6580", VA = "0x1879F7B80")]
			static SMHFTSMFUZI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(FSVCPCYGMGD reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class HFLYGUVSTXD<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public AMJWKGCFUSU XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a ENSMMIJELMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> OPKVDAVXADD;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public HFLYGUVSTXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x6532040", Offset = "0x6530A40", VA = "0x186532040")]
			internal void KEUZWUYSMMK(FSVCPCYGMGD a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class GMUTXYOLAWN<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public AMJWKGCFUSU XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a ENSMMIJELMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> OPKVDAVXADD;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GMUTXYOLAWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6447C30", Offset = "0x6446630", VA = "0x186447C30")]
			internal void KEUZWUYSMMK(FSVCPCYGMGD a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly JUGDIVIKDSA RRDULMWMFCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> VIRSRWPHWHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly ZFXMZLDFTIP RNAURYTXSGO;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5980", Offset = "0x8BB4380", VA = "0x188BB5980")]
		public AMJWKGCFUSU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x33A5A20", Offset = "0x33A4420", VA = "0x1833A5A20", Slot = "4")]
		protected virtual ulong BJXMFTMPPLJ<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB58B0", Offset = "0x8BB42B0", VA = "0x188BB58B0", Slot = "5")]
		protected virtual SubscribeDelegate SWLFVCKPFNW(FSVCPCYGMGD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x33A5AA0", Offset = "0x33A44A0", VA = "0x1833A5AA0", Slot = "6")]
		protected virtual void GPNIAZKWNMU<b>(ZFXMZLDFTIP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5830", Offset = "0x8BB4230", VA = "0x188BB5830")]
		public void HLBRNRQCUVP(FSVCPCYGMGD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x33A5B20", Offset = "0x33A4520", VA = "0x1833A5B20")]
		public void JMVJVIOJCPK<j>(ZFXMZLDFTIP a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BB57E0", Offset = "0x8BB41E0", VA = "0x188BB57E0")]
		public void EUQQKLINQEV(FSVCPCYGMGD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x33A5D30", Offset = "0x33A4730", VA = "0x1833A5D30")]
		public void YWXCODOBFKS<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x33A5D30", Offset = "0x33A4730", VA = "0x1833A5D30")]
		public void YWXCODOBFKS<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9BB0", Offset = "0x8BB85B0", VA = "0x188BB9BB0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC0B0", Offset = "0x8BBAAB0", VA = "0x188BBC0B0")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class JUGDIVIKDSA
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private enum CallType
		{
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			Basic,
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			Array,
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			List
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private abstract class CAMIHLBKUAI<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType YFKMMNNXMAZ;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x502A5F0", Offset = "0x5028FF0", VA = "0x18502A5F0", Slot = "4")]
			public virtual void RKCBVVMJUOD(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void YHIVLMQLZBD(a a, FSVCPCYGMGD b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void JMVJVIOJCPK(a a, ZFXMZLDFTIP b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void KLOBYTEQQMK(a a, FSVCPCYGMGD b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void EYZPXMFHJON(a a, FSVCPCYGMGD b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void XXJQLSGAGTC(a a, ZFXMZLDFTIP b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			protected CAMIHLBKUAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class DLFZLGLDGKB<a, b> : CAMIHLBKUAI<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> ZPQLNCMOOHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> LDENGZPOFYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> OTHCDEMAQIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> XVOJMTMEFBT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> FVYZVCYGFXA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> YLWJFMBTEXI;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5393730", Offset = "0x5392130", VA = "0x185393730", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5393730", Offset = "0x5392130", VA = "0x185393730", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5393660", Offset = "0x5392060", VA = "0x185393660", Slot = "9")]
			public override void EYZPXMFHJON(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5393660", Offset = "0x5392060", VA = "0x185393660", Slot = "10")]
			public override void XXJQLSGAGTC(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5393800", Offset = "0x5392200", VA = "0x185393800")]
			protected b[] QHGWXFTRUOC(a a, FSVCPCYGMGD b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x53934F0", Offset = "0x5391EF0", VA = "0x1853934F0")]
			protected b[] ABSQLICJPXL(a a, ZFXMZLDFTIP b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5394060", Offset = "0x5392A60", VA = "0x185394060", Slot = "4")]
			public override void RKCBVVMJUOD(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5394600", Offset = "0x5393000", VA = "0x185394600")]
			protected DLFZLGLDGKB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class LTJMMOMEVPQ<a, b> : DLFZLGLDGKB<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void FYCHKNMVXNZ(FSVCPCYGMGD a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void ADVANRIXKBU(ZFXMZLDFTIP a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x69A6DE0", Offset = "0x69A57E0", VA = "0x1869A6DE0", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x69A65E0", Offset = "0x69A4FE0", VA = "0x1869A65E0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x69A6830", Offset = "0x69A5230", VA = "0x1869A6830", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x69A6B70", Offset = "0x69A5570", VA = "0x1869A6B70", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x69A6FF0", Offset = "0x69A59F0", VA = "0x1869A6FF0")]
			protected LTJMMOMEVPQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class AWNPAFHNRMN<a> : DLFZLGLDGKB<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6FDCA30", Offset = "0x6FDB430", VA = "0x186FDCA30", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x6FDC630", Offset = "0x6FDB030", VA = "0x186FDC630", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7324310", Offset = "0x7322D10", VA = "0x187324310", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6FDC8D0", Offset = "0x6FDB2D0", VA = "0x186FDC8D0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public AWNPAFHNRMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class MADWRXTLHTU<a> : DLFZLGLDGKB<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x6FDCA30", Offset = "0x6FDB430", VA = "0x186FDCA30", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x6FDC630", Offset = "0x6FDB030", VA = "0x186FDC630", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6FDC770", Offset = "0x6FDB170", VA = "0x186FDC770", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x6FDC8D0", Offset = "0x6FDB2D0", VA = "0x186FDC8D0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public MADWRXTLHTU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class XMNHIZFTMCG<a> : DLFZLGLDGKB<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x50D7840", Offset = "0x50D6240", VA = "0x1850D7840", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x50D7320", Offset = "0x50D5D20", VA = "0x1850D7320", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x50D7470", Offset = "0x50D5E70", VA = "0x1850D7470", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x50D76D0", Offset = "0x50D60D0", VA = "0x1850D76D0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public XMNHIZFTMCG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class NQGUMBYVITH<a> : DLFZLGLDGKB<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x50D7840", Offset = "0x50D6240", VA = "0x1850D7840", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x50D7320", Offset = "0x50D5D20", VA = "0x1850D7320", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x722CA60", Offset = "0x722B460", VA = "0x18722CA60", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x50D76D0", Offset = "0x50D60D0", VA = "0x1850D76D0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public NQGUMBYVITH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class WRKKIPAYMSE<a> : DLFZLGLDGKB<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x70070D0", Offset = "0x7005AD0", VA = "0x1870070D0", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x7006CE0", Offset = "0x70056E0", VA = "0x187006CE0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8731CF0", Offset = "0x87306F0", VA = "0x188731CF0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x7007090", Offset = "0x7005A90", VA = "0x187007090", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public WRKKIPAYMSE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class MYOHBILWIEB<a> : DLFZLGLDGKB<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x70070D0", Offset = "0x7005AD0", VA = "0x1870070D0", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x7006CE0", Offset = "0x70056E0", VA = "0x187006CE0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7006E30", Offset = "0x7005830", VA = "0x187006E30", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x7007090", Offset = "0x7005A90", VA = "0x187007090", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public MYOHBILWIEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class ZSOCGZNBMAU<a> : DLFZLGLDGKB<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x517CD50", Offset = "0x517B750", VA = "0x18517CD50", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x517C950", Offset = "0x517B350", VA = "0x18517C950", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x517CA90", Offset = "0x517B490", VA = "0x18517CA90", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x517CBF0", Offset = "0x517B5F0", VA = "0x18517CBF0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public ZSOCGZNBMAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class PYRNMEMVLVF<a> : DLFZLGLDGKB<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x517CD50", Offset = "0x517B750", VA = "0x18517CD50", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x517C950", Offset = "0x517B350", VA = "0x18517C950", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x74E2080", Offset = "0x74E0A80", VA = "0x1874E2080", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x517CBF0", Offset = "0x517B5F0", VA = "0x18517CBF0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public PYRNMEMVLVF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class UOGUGVLKAYS<a> : DLFZLGLDGKB<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x7E2AC00", Offset = "0x7E29600", VA = "0x187E2AC00", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x7E2A840", Offset = "0x7E29240", VA = "0x187E2A840", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x7E2A990", Offset = "0x7E29390", VA = "0x187E2A990", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x6FDC8D0", Offset = "0x6FDB2D0", VA = "0x186FDC8D0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public UOGUGVLKAYS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class RJDBLHUJLDZ<a> : DLFZLGLDGKB<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x7769860", Offset = "0x7768260", VA = "0x187769860", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x77695B0", Offset = "0x7767FB0", VA = "0x1877695B0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x77696F0", Offset = "0x77680F0", VA = "0x1877696F0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x7007090", Offset = "0x7005A90", VA = "0x187007090", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public RJDBLHUJLDZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class GVSKIYTENDY<a> : DLFZLGLDGKB<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6451A70", Offset = "0x6450470", VA = "0x186451A70", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x64518E0", Offset = "0x64502E0", VA = "0x1864518E0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6451A20", Offset = "0x6450420", VA = "0x186451A20", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x517CBF0", Offset = "0x517B5F0", VA = "0x18517CBF0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x50D78B0", Offset = "0x50D62B0", VA = "0x1850D78B0")]
			public GVSKIYTENDY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class RTUWWXJDWXM<a> : LTJMMOMEVPQ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x778C0E0", Offset = "0x778AAE0", VA = "0x18778C0E0", Slot = "12")]
			protected override void ADVANRIXKBU(ZFXMZLDFTIP a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x778C110", Offset = "0x778AB10", VA = "0x18778C110", Slot = "11")]
			protected override void FYCHKNMVXNZ(FSVCPCYGMGD a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x64450E0", Offset = "0x6443AE0", VA = "0x1864450E0")]
			public RTUWWXJDWXM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class GKTDHGXCAJI<a> : LTJMMOMEVPQ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6445070", Offset = "0x6443A70", VA = "0x186445070", Slot = "12")]
			protected override void ADVANRIXKBU(ZFXMZLDFTIP a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x64450A0", Offset = "0x6443AA0", VA = "0x1864450A0", Slot = "11")]
			protected override void FYCHKNMVXNZ(FSVCPCYGMGD a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x64450E0", Offset = "0x6443AE0", VA = "0x1864450E0")]
			public GKTDHGXCAJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class ZUZGWWCDTPR<a> : DLFZLGLDGKB<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int CCIUEMWLJDO;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x517E7F0", Offset = "0x517D1F0", VA = "0x18517E7F0")]
			public ZUZGWWCDTPR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x517E620", Offset = "0x517D020", VA = "0x18517E620", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x517E2F0", Offset = "0x517CCF0", VA = "0x18517E2F0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x517E460", Offset = "0x517CE60", VA = "0x18517E460", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x517E4C0", Offset = "0x517CEC0", VA = "0x18517E4C0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class DOFVUBPQMPH<a> : CAMIHLBKUAI<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo OPNSYIBLXMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type ISNJBATDYAU;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5394B60", Offset = "0x5393560", VA = "0x185394B60")]
			public DOFVUBPQMPH(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5394A60", Offset = "0x5393460", VA = "0x185394A60", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5394740", Offset = "0x5393140", VA = "0x185394740", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x53948E0", Offset = "0x53932E0", VA = "0x1853948E0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x53948E0", Offset = "0x53932E0", VA = "0x1853948E0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x53946F0", Offset = "0x53930F0", VA = "0x1853946F0", Slot = "9")]
			public override void EYZPXMFHJON(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x53946F0", Offset = "0x53930F0", VA = "0x1853946F0", Slot = "10")]
			public override void XXJQLSGAGTC(a a, ZFXMZLDFTIP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class XBUUTRRPFSW<a> : DOFVUBPQMPH<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x50D2420", Offset = "0x50D0E20", VA = "0x1850D2420")]
			public XBUUTRRPFSW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x50D2230", Offset = "0x50D0C30", VA = "0x1850D2230", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x50D21B0", Offset = "0x50D0BB0", VA = "0x1850D21B0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class VWPRMSTCHZG<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static VWPRMSTCHZG<a> GFQGJWBHKJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly CAMIHLBKUAI<a>[] LYVUSSNKTNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int VAFGATNXRAA;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x80128E0", Offset = "0x80112E0", VA = "0x1880128E0")]
			public VWPRMSTCHZG(List<CAMIHLBKUAI<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x8012380", Offset = "0x8010D80", VA = "0x188012380")]
			public void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x8012790", Offset = "0x8011190", VA = "0x188012790")]
			public void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class BHESPUUGEGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract CAMIHLBKUAI<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private ZFXMZLDFTIP NXHPZECHMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int AEUEHBRHCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, BHESPUUGEGG> BOFCYUBIYSX;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9BC0", Offset = "0x8BB85C0", VA = "0x188BB9BC0")]
		public JUGDIVIKDSA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D5A0", Offset = "0x3B8BFA0", VA = "0x183B8D5A0")]
		private VWPRMSTCHZG<d> CHPJPBQKQQN<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3B8C730", Offset = "0x3B8B130", VA = "0x183B8C730")]
		public void CBYRPQCEVDS<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E330", Offset = "0x3B8CD30", VA = "0x183B8E330")]
		public bool Deserialize<T>(FSVCPCYGMGD reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E3B0", Offset = "0x3B8CDB0", VA = "0x183B8E3B0")]
		public void NYKTBLQYXAJ<f>(ZFXMZLDFTIP a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class EGLGBBSOEQF
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime JMFGKYRZFRM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] HPONLMXSQDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator CIVIPZTBSFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7D40", Offset = "0x8BB6740", VA = "0x188BB7D40")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int IRBBPXNSSTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7F80", Offset = "0x8BB6980", VA = "0x188BB7F80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7D00", Offset = "0x8BB6700", VA = "0x188BB7D00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode FZKHSZNZYHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7F50", Offset = "0x8BB6950", VA = "0x188BB7F50")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7CC0", Offset = "0x8BB66C0", VA = "0x188BB7CC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int EFGDDRKTMZB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7D70", Offset = "0x8BB6770", VA = "0x188BB7D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint EATXXZKDDGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7E60", Offset = "0x8BB6860", VA = "0x188BB7E60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? EUHYYECYCJX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8440", Offset = "0x8BB6E40", VA = "0x188BB8440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? XZBEAVWDYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7F20", Offset = "0x8BB6920", VA = "0x188BB7F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? GNAUWLFNVRV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7AD0", Offset = "0x8BB64D0", VA = "0x188BB7AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BB78B0", Offset = "0x8BB62B0", VA = "0x188BB78B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? FYXUPZYCOIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8910", Offset = "0x8BB7310", VA = "0x188BB8910")]
		public EGLGBBSOEQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8C20", Offset = "0x8BB7620", VA = "0x188BB8C20")]
		internal EGLGBBSOEQF(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8330", Offset = "0x8BB6D30", VA = "0x188BB8330")]
		public static EGLGBBSOEQF VLUOIMCGMKV(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7FB0", Offset = "0x8BB69B0", VA = "0x188BB7FB0")]
		internal void UNUBECKRVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8520", Offset = "0x8BB6F20", VA = "0x188BB8520")]
		private void XHRFXTSCTNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB86E0", Offset = "0x8BB70E0", VA = "0x188BB86E0")]
		private DateTime? ZIWUCDPBXPK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7B00", Offset = "0x8BB6500", VA = "0x188BB7B00")]
		private void DTYQMUDAYMQ(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8470", Offset = "0x8BB6E70", VA = "0x188BB8470")]
		private ulong WUNTJUZVCVC(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7DA0", Offset = "0x8BB67A0", VA = "0x188BB7DA0")]
		private void MLPENAANLLW(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7EC0", Offset = "0x8BB68C0", VA = "0x188BB7EC0")]
		private uint RQHSNCBNNPJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8A80750", Offset = "0x8A7F150", VA = "0x188A80750")]
		private static uint CODZJYFWGPU(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7A70", Offset = "0x8BB6470", VA = "0x188BB7A70")]
		private static ulong CODZJYFWGPU(ulong a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum NtpLeapIndicator
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		NoWarning,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		LastMinuteHas61Seconds,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		LastMinuteHas59Seconds,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		AlarmCondition
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum NtpMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Client = 3,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Server
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal sealed class TKFHDCAGOUO
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int UENITNTPHEX = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int UPNNCTYKGRY = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int KNYDYZIJLLT = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint QXJIWLXUCQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int TPWXPDFCCMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int SJCPGMDTLVJ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool BTPFPZUPHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE300", Offset = "0x8BBCD00", VA = "0x188BBE300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE210", Offset = "0x8BBCC10", VA = "0x188BBE210")]
		public bool CVDJBAKMHPZ(XFOIVFWBRJD a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class WBTNGVEALHW : XFOIVFWBRJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket GRLKFHBFNVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly WBICUZCDOVB INVONXXGIPN;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short GFRPGAUDJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x8BCB3D0", Offset = "0x8BC9DD0", VA = "0x188BCB3D0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int NVCJKQMPNAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8BCB3B0", Offset = "0x8BC9DB0", VA = "0x188BCB3B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint CRBFQXAZSKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8BCB4E0", Offset = "0x8BC9EE0", VA = "0x188BCB4E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily HCZPRAFNNEL
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x3300B00", Offset = "0x32FF500", VA = "0x183300B00", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB500", Offset = "0x8BC9F00", VA = "0x188BCB500")]
		public WBTNGVEALHW(AddressFamily a, WBICUZCDOVB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCADD0", Offset = "0x8BC97D0", VA = "0x188BCADD0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCAD90", Offset = "0x8BC9790", VA = "0x188BCAD90", Slot = "9")]
		public int BUZWZPOZFYK(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB3F0", Offset = "0x8BC9DF0", VA = "0x188BCB3F0", Slot = "10")]
		public int QRKCXJZUFES(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB390", Offset = "0x8BC9D90", VA = "0x188BCB390", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface XFOIVFWBRJD
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short GFRPGAUDJID
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int NVCJKQMPNAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint CRBFQXAZSKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily HCZPRAFNNEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode);

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int BUZWZPOZFYK(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int QRKCXJZUFES(byte[] a, EndPoint b);

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Close();
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal readonly struct NativeAddr : IEquatable<NativeAddr>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly long _part1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly long _part2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly long _part3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly int _part4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly int _hash;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBD40", Offset = "0x8BBA740", VA = "0x188BBBD40")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBDE0", Offset = "0x8BBA7E0", VA = "0x188BBBDE0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBC50", Offset = "0x8BBA650", VA = "0x188BBBC50", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBC90", Offset = "0x8BBA690", VA = "0x188BBBC90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class NativeEndPoint : IPEndPoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public readonly byte[] NativeAddress;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class FWAGDTULAQU
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string MKCAPLATMSI = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int VETVCSTSMIA = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int AGAOKQHENXM = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int UDSTYCKTWQQ = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> FHXUGVWSHBD;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback TRJOHHBWKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int QMRCLTHLHKE;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		internal void XHRARGJGBZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		internal void FVVWLSRSCYS(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class CVWDQNVCUZB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int FRIBXCKLHPG;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
		protected CVWDQNVCUZB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GYIGBVPGHWL(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void JZYGLNMEUMK(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class UFMXQCEOCED : CVWDQNVCUZB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] APYHZOACXVC;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator JUXVEVQNDEC;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD7F0", Offset = "0x2BDC1F0", VA = "0x182BDD7F0")]
		public UFMXQCEOCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE8E0", Offset = "0x8BBD2E0", VA = "0x188BBE8E0")]
		public void JAUHEDGOQYP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8BBED90", Offset = "0x8BBD790", VA = "0x188BBED90")]
		public void ZZQJISXPGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE490", Offset = "0x8BBCE90", VA = "0x188BBE490", Slot = "4")]
		public override void GYIGBVPGHWL(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEA90", Offset = "0x8BBD490", VA = "0x188BBEA90", Slot = "5")]
		public override void JZYGLNMEUMK(IPEndPoint a, byte[] b, int c, int d)
		{
		}
	}
}
namespace LiteNetLib.Layers.Ciphers
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	internal struct RabbitCipher
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void Encrypt_000002A7$PostfixBurstDelegate([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int length);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		internal static class CVFKAWRKVMO
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8BCD030", Offset = "0x8BCBA30", VA = "0x188BCD030")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8BCCC60", Offset = "0x8BCB660", VA = "0x188BCCC60")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8BCCDE0", Offset = "0x8BCB7E0", VA = "0x188BCCDE0")]
			public unsafe static void Invoke([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int length)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private unsafe fixed uint key[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private unsafe fixed uint iv[2];

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private unsafe fixed uint X[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private unsafe fixed uint S[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private unsafe fixed uint C[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private unsafe fixed uint old_C[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private unsafe fixed uint A[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private uint carry;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private unsafe fixed uint g[8];

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD160", Offset = "0x8BBBB60", VA = "0x188BBD160")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD130", Offset = "0x8BBBB30", VA = "0x188BBD130")]
		private uint NHNPRZLFCKX(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5500", Offset = "0x8BB3F00", VA = "0x188BB5500")]
		private void JWEFUICWQPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB52F0", Offset = "0x8BB3CF0", VA = "0x188BB52F0")]
		private void BFLWDCHVHIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB55B0", Offset = "0x8BB3FB0", VA = "0x188BB55B0")]
		private void TKFAYOYRYPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5640", Offset = "0x8BB4040", VA = "0x188BB5640")]
		private void ZGCNNOBEPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD2A0", Offset = "0x8BBBCA0", VA = "0x188BBD2A0")]
		private void WRGBSNVCVWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC60", Offset = "0x8BBB660", VA = "0x188BBCC60")]
		private unsafe void CSLLRKCBWFJ(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD290", Offset = "0x8BBBC90", VA = "0x188BBD290")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void WGDJHHJZSKS([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD1E0", Offset = "0x8BBBBE0", VA = "0x188BBD1E0")]
		public static void WGDJHHJZSKS(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD080", Offset = "0x8BBBA80", VA = "0x188BBD080")]
		public static void HBITHEDXPUC(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD300", Offset = "0x8BBBD00", VA = "0x188BBD300")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void WXPSYFIVQDH([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8BCD280", Offset = "0x8BCBC80", VA = "0x188BCD280")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
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
