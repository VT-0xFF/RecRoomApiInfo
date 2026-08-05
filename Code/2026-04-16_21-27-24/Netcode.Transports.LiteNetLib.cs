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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A3B960", Offset = "0x8A3A760", VA = "0x188A3B960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A3B910", Offset = "0x8A3A710", VA = "0x188A3B910", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ADF0", Offset = "0x8A39BF0", VA = "0x188A3ADF0")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ADD0", Offset = "0x8A39BD0", VA = "0x188A3ADD0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ABD0", Offset = "0x8A399D0", VA = "0x188A3ABD0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B7F0", Offset = "0x8A3A5F0", VA = "0x188A3B7F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AFC0", Offset = "0x8A39DC0", VA = "0x188A3AFC0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ACC0", Offset = "0x8A39AC0", VA = "0x188A3ACC0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B290", Offset = "0x8A3A090", VA = "0x188A3B290", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B5D0", Offset = "0x8A3A3D0", VA = "0x188A3B5D0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A5A0", Offset = "0x8A393A0", VA = "0x188A3A5A0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A4B0", Offset = "0x8A392B0", VA = "0x188A3A4B0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A8B0", Offset = "0x8A396B0", VA = "0x188A3A8B0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B220", Offset = "0x8A3A020", VA = "0x188A3B220", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A950", Offset = "0x8A39750", VA = "0x188A3A950", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A6B0", Offset = "0x8A394B0", VA = "0x188A3A6B0")]
		private DeliveryMethod ESUAQCMZHAW(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AF00", Offset = "0x8A39D00", VA = "0x188A3AF00", Slot = "16")]
		private void SPIZKOXNGAZ(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A7E0", Offset = "0x8A395E0", VA = "0x188A3A7E0", Slot = "17")]
		private void GHFBARKSRAJ(VUZQRMISFIM a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "18")]
		private void GNKBERBXKUW(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A2B0", Offset = "0x8A390B0", VA = "0x188A3A2B0", Slot = "19")]
		private void DQASMSNBLHL(VUZQRMISFIM a, BIGNNKRLLHV b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AD00", Offset = "0x8A39B00", VA = "0x188A3AD00")]
		private void RWGUFIITMCS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "20")]
		private void QLUBOPUPBZT(IPEndPoint a, BIGNNKRLLHV b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "21")]
		private void OUYNXZHXUCX(VUZQRMISFIM a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A780", Offset = "0x8A39580", VA = "0x188A3A780", Slot = "22")]
		private void GDHMFWFJZVF(TETONNBIJLQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AB60", Offset = "0x8A39960", VA = "0x188A3AB60")]
		private ulong JDQMFNXEQSU(VUZQRMISFIM a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AB90", Offset = "0x8A39990", VA = "0x188A3AB90")]
		private ulong JDQMFNXEQSU(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ABB0", Offset = "0x8A399B0", VA = "0x188A3ABB0")]
		private static int LUIIAMFKJOV(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B840", Offset = "0x8A3A640", VA = "0x188A3B840")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B810", Offset = "0x8A3A610", VA = "0x188A3B810")]
		[CompilerGenerated]
		private void VWYHDMQHEXF(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B810", Offset = "0x8A3A610", VA = "0x188A3B810")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A374C0", Offset = "0x8A362C0", VA = "0x188A374C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A37510", Offset = "0x8A36310", VA = "0x188A37510")]
		protected CVKNVEXMLZR(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A373A0", Offset = "0x8A361A0", VA = "0x188A373A0")]
		public void ARNVTZIQIOY(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A37400", Offset = "0x8A36200", VA = "0x188A37400")]
		protected void CRMWNBTIIGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A37480", Offset = "0x8A36280", VA = "0x188A37480")]
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
			[Cpp2IlInjected.Address(RVA = "0x162E100", Offset = "0x162CF00", VA = "0x18162E100")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x162E110", Offset = "0x162CF10", VA = "0x18162E110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E780", Offset = "0x8A3D580", VA = "0x188A3E780")]
		internal void RTKFNRJQUHT(ZWBISDEFWSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E750", Offset = "0x8A3D550", VA = "0x188A3E750")]
		private bool OWLFYHYOPOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E7E0", Offset = "0x8A3D5E0", VA = "0x188A3E7E0")]
		internal TETONNBIJLQ(IPEndPoint a, ZWBISDEFWSX b, WBICUZCDOVB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E6F0", Offset = "0x8A3D4F0", VA = "0x188A3E6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4D210", Offset = "0x8A4C010", VA = "0x188A4D210")]
		private ZWBISDEFWSX(long a, byte b, int c, byte[] d, FSVCPCYGMGD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CFF0", Offset = "0x8A4BDF0", VA = "0x188A4CFF0")]
		public static int CDQVRISPGSO(EAORRUZIRGE a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D020", Offset = "0x8A4BE20", VA = "0x188A4D020")]
		public static ZWBISDEFWSX TSEVGFICECN(EAORRUZIRGE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CE10", Offset = "0x8A4BC10", VA = "0x188A4CE10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A3DCC0", Offset = "0x8A3CAC0", VA = "0x188A3DCC0")]
		private SMJIVQQAFZM(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DBC0", Offset = "0x8A3C9C0", VA = "0x188A3DBC0")]
		public static SMJIVQQAFZM TSEVGFICECN(EAORRUZIRGE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D9D0", Offset = "0x8A3C7D0", VA = "0x188A3D9D0")]
		public static EAORRUZIRGE BXQRNXFEQQD(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DAC0", Offset = "0x8A3C8C0", VA = "0x188A3DAC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool JSZGJZGUYNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF90", Offset = "0xCEED90", VA = "0x180CEFF90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A3E300", Offset = "0x8A3D100", VA = "0x188A3E300")]
		internal SOJPTMHZMIQ(WBICUZCDOVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DE70", Offset = "0x8A3CC70", VA = "0x188A3DE70")]
		internal void EELOKAXWQGJ(IPEndPoint a, EAORRUZIRGE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE4A0", Offset = "0x3EFD2A0", VA = "0x183EFE4A0")]
		private void CVDJBAKMHPZ<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DFF0", Offset = "0x8A3CDF0", VA = "0x188A3DFF0")]
		private void EWQOQSWBKMA(SJNHOFGYNRE a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DD10", Offset = "0x8A3CB10", VA = "0x188A3DD10")]
		private void BHUFBKHRYGQ(PDAZZKHXFJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E170", Offset = "0x8A3CF70", VA = "0x188A3E170")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A3A210", Offset = "0x8A39010", VA = "0x188A3A210")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A210", Offset = "0x8A39010", VA = "0x188A3A210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4BC90", Offset = "0x8A4AA90", VA = "0x188A4BC90")]
		private static void WUTPLUWENXM(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BC30", Offset = "0x8A4AA30", VA = "0x188A4BC30")]
		internal static void QLISYGJXFAK(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BEC0", Offset = "0x8A4ACC0", VA = "0x188A4BEC0")]
		internal static void XZWMJCKNSSI(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BBD0", Offset = "0x8A4A9D0", VA = "0x188A4BBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A36330", Offset = "0x8A35130", VA = "0x188A36330")]
		internal BIGNNKRLLHV(WBICUZCDOVB a, FXITFCCALDK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A36290", Offset = "0x8A35090", VA = "0x188A36290")]
		internal void GZJEIXBXHIW(EAORRUZIRGE a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A36210", Offset = "0x8A35010", VA = "0x188A36210")]
		internal void FHWACZURLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A36300", Offset = "0x8A35100", VA = "0x188A36300")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A39C10", Offset = "0x8A38A10", VA = "0x188A39C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A3D0C0", Offset = "0x8A3BEC0", VA = "0x188A3D0C0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D130", Offset = "0x8A3BF30", VA = "0x188A3D130", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
				[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D70380", Offset = "0x1D6F180", VA = "0x181D70380")]
			public NetPeerEnumerator(VUZQRMISFIM p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C680", Offset = "0x8A3B480", VA = "0x188A3C680", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C6D0", Offset = "0x8A3B4D0", VA = "0x188A3C6D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xE59EF0", Offset = "0xE58CF0", VA = "0x180E59EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE599A0", Offset = "0xE587A0", VA = "0x180E599A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int ENQVWKMMVVR
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2225940", Offset = "0x2224740", VA = "0x182225940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2334520", Offset = "0x2333320", VA = "0x182334520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte DKNICLBZBNS
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDE4D70", Offset = "0xDE3B70", VA = "0x180DE4D70")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int FRIBXCKLHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8A451F0", Offset = "0x8A43FF0", VA = "0x188A451F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short GFRPGAUDJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A45ED0", Offset = "0x8A44CD0", VA = "0x188A45ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event VUZQRMISFIM.OnUpdatedMtuDelegate EVZQYFVVUGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8A44150", Offset = "0x8A42F50", VA = "0x188A44150")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A45DA0", Offset = "0x8A44BA0", VA = "0x188A45DA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A45F90", Offset = "0x8A44D90", VA = "0x188A45F90")]
		public void NYYMTKPVOFP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A4ABE0", Offset = "0x8A499E0", VA = "0x188A4ABE0")]
		public void ZSODPHGIGKI(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A43640", Offset = "0x8A42440", VA = "0x188A43640")]
		private bool ADAZEBAYTNQ(IPEndPoint a, [Out] VUZQRMISFIM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A47ED0", Offset = "0x8A46CD0", VA = "0x188A47ED0")]
		private void UPWZLULFWFS(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A44790", Offset = "0x8A43590", VA = "0x188A44790")]
		private void DMOBMRQZWFL(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A43E90", Offset = "0x8A42C90", VA = "0x188A43E90")]
		private void BECYOCPNVWA(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A4ADF0", Offset = "0x8A49BF0", VA = "0x188A4ADF0")]
		public WBICUZCDOVB(FGGAIVFISZL a, [Optional] CVWDQNVCUZB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A45D50", Offset = "0x8A44B50", VA = "0x188A45D50")]
		internal void KAIRSEQRTUI(VUZQRMISFIM a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A459A0", Offset = "0x8A447A0", VA = "0x188A459A0")]
		internal void IWAXVUDIRIE(VUZQRMISFIM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A47E90", Offset = "0x8A46C90", VA = "0x188A47E90")]
		internal void UNGXEZXKJHA(VUZQRMISFIM a, DisconnectReason b, SocketError c, EAORRUZIRGE d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A483D0", Offset = "0x8A471D0", VA = "0x188A483D0")]
		private void WRGBUTDVWJV(VUZQRMISFIM a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, EAORRUZIRGE h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8A436E0", Offset = "0x8A424E0", VA = "0x188A436E0")]
		private void AEHIHHPZHKL(FXITFCCALDK.EType a, [Optional] VUZQRMISFIM b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] TETONNBIJLQ g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] EAORRUZIRGE j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A447F0", Offset = "0x8A435F0", VA = "0x188A447F0")]
		private void EZIWBHLKQDE(FXITFCCALDK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A467A0", Offset = "0x8A455A0", VA = "0x188A467A0")]
		internal void RUKSXCFAYVM(FXITFCCALDK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A459F0", Offset = "0x8A447F0", VA = "0x188A459F0")]
		private void IZROUBYXIAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A45210", Offset = "0x8A44010", VA = "0x188A45210")]
		private void GFYRTLRGUZI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A46A60", Offset = "0x8A45860", VA = "0x188A46A60")]
		internal VUZQRMISFIM SNYZPBGLHOB(TETONNBIJLQ a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A43B40", Offset = "0x8A42940", VA = "0x188A43B40")]
		private int ARPXOEMNKDB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8A46300", Offset = "0x8A45100", VA = "0x188A46300")]
		private void RJEGBUOCDFP(IPEndPoint a, VUZQRMISFIM b, ZWBISDEFWSX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8A494D0", Offset = "0x8A482D0", VA = "0x188A494D0")]
		private void YETTICUJUTW(EAORRUZIRGE a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8A43BC0", Offset = "0x8A429C0", VA = "0x188A43BC0")]
		internal void AWTRUJYFXAW(EAORRUZIRGE a, DeliveryMethod b, byte c, int d, VUZQRMISFIM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8A47140", Offset = "0x8A45F40", VA = "0x188A47140")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A47120", Offset = "0x8A45F20", VA = "0x188A47120")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A470A0", Offset = "0x8A45EA0", VA = "0x188A470A0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A468B0", Offset = "0x8A456B0", VA = "0x188A468B0")]
		public void SHOBBYAMXSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A44200", Offset = "0x8A43000", VA = "0x188A44200")]
		public VUZQRMISFIM Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A446B0", Offset = "0x8A434B0", VA = "0x188A446B0")]
		public VUZQRMISFIM Connect(string address, int port, ZFXMZLDFTIP connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A442E0", Offset = "0x8A430E0", VA = "0x188A442E0")]
		public VUZQRMISFIM Connect(IPEndPoint target, ZFXMZLDFTIP connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A478C0", Offset = "0x8A466C0", VA = "0x188A478C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A478D0", Offset = "0x8A466D0", VA = "0x188A478D0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A490A0", Offset = "0x8A47EA0", VA = "0x188A490A0")]
		public void XRJHIGRSEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A48FD0", Offset = "0x8A47DD0", VA = "0x188A48FD0")]
		public void XRJHIGRSEEC(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A48390", Offset = "0x8A47190", VA = "0x188A48390")]
		public void WRGBUTDVWJV(VUZQRMISFIM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A48350", Offset = "0x8A47150", VA = "0x188A48350")]
		public void WRGBUTDVWJV(VUZQRMISFIM a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A43AB0", Offset = "0x8A428B0", VA = "0x188A43AB0", Slot = "4")]
		private IEnumerator<VUZQRMISFIM> AMFEGJTFFZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A47E00", Offset = "0x8A46C00", VA = "0x188A47E00", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A47D10", Offset = "0x8A46B10", VA = "0x188A47D10")]
		private EAORRUZIRGE TFGIPALMLXO(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A47C30", Offset = "0x8A46A30", VA = "0x188A47C30")]
		private EAORRUZIRGE TFGIPALMLXO(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A44FB0", Offset = "0x8A43DB0", VA = "0x188A44FB0")]
		internal EAORRUZIRGE FJVBRELXGND(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A7F0", Offset = "0x8A495F0", VA = "0x188A4A7F0")]
		internal void YWLOZDMDQVO(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A4AD30", Offset = "0x8A49B30", VA = "0x188A4AD30")]
		static WBICUZCDOVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE59EF0", Offset = "0xE58CF0", VA = "0x180E59EF0")]
		private bool DMZBRHFJFQP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A481F0", Offset = "0x8A46FF0", VA = "0x188A481F0")]
		private void WOWIXSLKSYN(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A461B0", Offset = "0x8A44FB0", VA = "0x188A461B0")]
		private void PSSOSHFRJJU(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A45800", Offset = "0x8A44600", VA = "0x188A45800")]
		private bool IIFALEJJFCQ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A45EB0", Offset = "0x8A44CB0", VA = "0x188A45EB0")]
		private void MPQABXBUEZN(FWAGDTULAQU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A45540", Offset = "0x8A44340", VA = "0x188A45540")]
		private void HBPSRZHOPUI(XFOIVFWBRJD a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A49150", Offset = "0x8A47F50", VA = "0x188A49150")]
		private void YADUYWMFJOU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A47150", Offset = "0x8A45F50", VA = "0x188A47150")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A45E50", Offset = "0x8A44C50", VA = "0x188A45E50")]
		internal int LEOSWWHVYEZ(EAORRUZIRGE a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A48F90", Offset = "0x8A47D90", VA = "0x188A48F90")]
		internal int XPOBEWMRDZN(EAORRUZIRGE a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A487C0", Offset = "0x8A475C0", VA = "0x188A487C0")]
		internal int XPOBEWMRDZN(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A4AA60", Offset = "0x8A49860", VA = "0x188A4AA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A375E0", Offset = "0x8A363E0", VA = "0x188A375E0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A375A0", Offset = "0x8A363A0", VA = "0x188A375A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte FAJZSSDMYNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A37A00", Offset = "0x8A36800", VA = "0x188A37A00")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A37670", Offset = "0x8A36470", VA = "0x188A37670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort GILZQNQNKLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A378E0", Offset = "0x8A366E0", VA = "0x188A378E0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A37610", Offset = "0x8A36410", VA = "0x188A37610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CFVQMPTYWPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A377E0", Offset = "0x8A365E0", VA = "0x188A377E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte XFZYSALOPDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A376B0", Offset = "0x8A364B0", VA = "0x188A376B0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8A37A90", Offset = "0x8A36890", VA = "0x188A37A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort LKNWCMDPKIU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A37A30", Offset = "0x8A36830", VA = "0x188A37A30")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A37830", Offset = "0x8A36630", VA = "0x188A37830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort JISOHTHSEMQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A37810", Offset = "0x8A36610", VA = "0x188A37810")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8A37870", Offset = "0x8A36670", VA = "0x188A37870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort BUALKKLBZKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A37650", Offset = "0x8A36450", VA = "0x188A37650")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A37A50", Offset = "0x8A36850", VA = "0x188A37A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A37AC0", Offset = "0x8A368C0", VA = "0x188A37AC0")]
		static EAORRUZIRGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A378B0", Offset = "0x8A366B0", VA = "0x188A378B0")]
		public void OCBJGCDLFAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A37EA0", Offset = "0x8A36CA0", VA = "0x188A37EA0")]
		public EAORRUZIRGE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A37D90", Offset = "0x8A36B90", VA = "0x188A37D90")]
		public EAORRUZIRGE(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A37900", Offset = "0x8A36700", VA = "0x188A37900")]
		public static int SMOCHREBFRN(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A37970", Offset = "0x8A36770", VA = "0x188A37970")]
		public int SMOCHREBFRN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A376E0", Offset = "0x8A364E0", VA = "0x188A376E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12D20", Offset = "0xD11B20", VA = "0x180D12D20")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F800", Offset = "0x8A3E600", VA = "0x188A3F800")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint BILBARVTJTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE51A20", Offset = "0xE50820", VA = "0x180E51A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState CIYQRLHCDJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x148D0D0", Offset = "0x148BED0", VA = "0x18148D0D0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long JDEQLDYBZNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCEA140", Offset = "0xCE8F40", VA = "0x180CEA140")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int YTAZWSECCWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2225940", Offset = "0x2224740", VA = "0x182225940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2334520", Offset = "0x2333320", VA = "0x182334520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int GZYKIYSBARL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A427B0", Offset = "0x8A415B0", VA = "0x188A427B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int TRXPSUTFRUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD03CD0", Offset = "0xD02AD0", VA = "0x180D03CD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double WTDELSLSPHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2ABBD00", Offset = "0x2ABAB00", VA = "0x182ABBD00")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate EVZQYFVVUGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F720", Offset = "0x8A3E520", VA = "0x188A3F720")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A3FFB0", Offset = "0x8A3EDB0", VA = "0x188A3FFB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A42ED0", Offset = "0x8A41CD0", VA = "0x188A42ED0")]
		internal VUZQRMISFIM(WBICUZCDOVB a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8A419F0", Offset = "0x8A407F0", VA = "0x188A419F0")]
		internal void TKJSXRKQBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A40060", Offset = "0x8A3EE60", VA = "0x188A40060")]
		internal void LGTAFZEMOCD(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FB90", Offset = "0x8A3E990", VA = "0x188A3FB90")]
		internal void GFYWMEYTQBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A40530", Offset = "0x8A3F330", VA = "0x188A40530")]
		private void RKRIQOGJCVH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A40330", Offset = "0x8A3F130", VA = "0x188A40330")]
		private void QMQNEHNWRYT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FA80", Offset = "0x8A3E880", VA = "0x188A3FA80")]
		public int FFHGDJBLHIT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F960", Offset = "0x8A3E760", VA = "0x188A3F960")]
		public int FFHGDJBLHIT(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A42620", Offset = "0x8A41420", VA = "0x188A42620")]
		private CVKNVEXMLZR VIVNLRWIAMI(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A434B0", Offset = "0x8A422B0", VA = "0x188A434B0")]
		internal VUZQRMISFIM(WBICUZCDOVB a, IPEndPoint b, int c, byte d, ZFXMZLDFTIP e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A432D0", Offset = "0x8A420D0", VA = "0x188A432D0")]
		internal VUZQRMISFIM(WBICUZCDOVB a, TETONNBIJLQ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A40CA0", Offset = "0x8A3FAA0", VA = "0x188A40CA0")]
		internal void Reject(ZWBISDEFWSX requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A427C0", Offset = "0x8A415C0", VA = "0x188A427C0")]
		internal bool XZDYDAOYHVO(SMJIVQQAFZM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F7D0", Offset = "0x8A3E5D0", VA = "0x188A3F7D0")]
		public void CVDJBAKMHPZ(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A428E0", Offset = "0x8A416E0", VA = "0x188A428E0")]
		private void ZDJMPQJYUVI(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F8B0", Offset = "0x8A3E6B0", VA = "0x188A3F8B0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A42840", Offset = "0x8A41640", VA = "0x188A42840")]
		internal DisconnectResult YSACENXALGQ(EAORRUZIRGE a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F900", Offset = "0x8A3E700", VA = "0x188A3F900")]
		internal void EHVOGYFXYZB(CVKNVEXMLZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A416E0", Offset = "0x8A404E0", VA = "0x188A416E0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A402F0", Offset = "0x8A3F0F0", VA = "0x188A402F0")]
		private void PDWZTMNDRTI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A40E40", Offset = "0x8A3FC40", VA = "0x188A40E40")]
		internal void SMSAUTGSHNA(DeliveryMethod a, EAORRUZIRGE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A420E0", Offset = "0x8A40EE0", VA = "0x188A420E0")]
		private void VCGRJQECOUG(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FC20", Offset = "0x8A3EA20", VA = "0x188A3FC20")]
		private void IAMEFXUREQK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A40370", Offset = "0x8A3F170", VA = "0x188A40370")]
		internal ConnectRequestResult RJEGBUOCDFP(ZWBISDEFWSX a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A40600", Offset = "0x8A3F400", VA = "0x188A40600")]
		internal void RRKQMCZAHYS(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A40CF0", Offset = "0x8A3FAF0", VA = "0x188A40CF0")]
		private void SCXHQHAOAVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F510", Offset = "0x8A3E310", VA = "0x188A3F510")]
		internal void AXPUDNEINKI(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A41A10", Offset = "0x8A40810", VA = "0x188A41A10")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A40090", Offset = "0x8A3EE90", VA = "0x188A40090")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A3BBB0", Offset = "0x8A3A9B0", VA = "0x188A3BBB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long TCGFUKIRCFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A3BCE0", Offset = "0x8A3AAE0", VA = "0x188A3BCE0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long KMQQJHMOCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A3BDB0", Offset = "0x8A3ABB0", VA = "0x188A3BDB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long CTUZGJQPOXF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A3BBA0", Offset = "0x8A3A9A0", VA = "0x188A3BBA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long WJCDBLCSEIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C2A0", Offset = "0x8A3B0A0", VA = "0x188A3C2A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long TXZKODYFAGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8A3BC90", Offset = "0x8A3AA90", VA = "0x188A3BC90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long PCLFPBKILMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A3BEA0", Offset = "0x8A3ACA0", VA = "0x188A3BEA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long SBREKYNURCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8A3BCA0", Offset = "0x8A3AAA0", VA = "0x188A3BCA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality LATAATFNPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x13F50C0", Offset = "0x13F3EC0", VA = "0x1813F50C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double XNDZPBLINST
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A3BAE0", Offset = "0x8A3A8E0", VA = "0x188A3BAE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BE60", Offset = "0x8A3AC60", VA = "0x188A3BE60")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BB40", Offset = "0x8A3A940", VA = "0x188A3BB40")]
		public void AVAZGJYPLUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BD60", Offset = "0x8A3AB60", VA = "0x188A3BD60")]
		public void QRYMMUJJWWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BBC0", Offset = "0x8A3A9C0", VA = "0x188A3BBC0")]
		public void IFDYRMBGINL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BCF0", Offset = "0x8A3AAF0", VA = "0x188A3BCF0")]
		public void PKHINFTJFNW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BC30", Offset = "0x8A3AA30", VA = "0x188A3BC30")]
		public void MLGTEJBGNOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C220", Offset = "0x8A3B020", VA = "0x188A3C220")]
		public void VWTDSMWTKWL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BEE0", Offset = "0x8A3ACE0", VA = "0x188A3BEE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BDC0", Offset = "0x8A3ABC0", VA = "0x188A3BDC0")]
		public void RPJDHDPUKUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A39F10", Offset = "0x8A38D10", VA = "0x188A39F10")]
		public static IPEndPoint QUUVUPMVCBM(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A39CB0", Offset = "0x8A38AB0", VA = "0x188A39CB0")]
		public static IPAddress IUMEEJPZRRP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8A39E80", Offset = "0x8A38C80", VA = "0x188A39E80")]
		public static IPAddress IUMEEJPZRRP(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A150", Offset = "0x8A38F50", VA = "0x188A3A150")]
		internal static int SOFJCXNCLDL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4940", Offset = "0x3AD3740", VA = "0x183AD4940")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A3C850", Offset = "0x8A3B650", VA = "0x188A3C850", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C7C0", Offset = "0x8A3B5C0", VA = "0x188A3C7C0")]
			public void RKCBVVMJUOD(EAORRUZIRGE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C7E0", Offset = "0x8A3B5E0", VA = "0x188A3C7E0")]
			public bool TEKTPBKGLXO(long a, VUZQRMISFIM b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C770", Offset = "0x8A3B570", VA = "0x188A3C770")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A371D0", Offset = "0x8A35FD0", VA = "0x188A371D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8A371E0", Offset = "0x8A35FE0", VA = "0x188A371E0")]
		public COLBXGPJRCG(VUZQRMISFIM a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8A36380", Offset = "0x8A35180", VA = "0x188A36380")]
		private void DQPNQJUFOPV(EAORRUZIRGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8A36700", Offset = "0x8A35500", VA = "0x188A36700", Slot = "4")]
		protected override bool IFFCWNVJWRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8A36BD0", Offset = "0x8A359D0", VA = "0x188A36BD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A3D000", Offset = "0x8A3BE00", VA = "0x188A3D000")]
		public QAPZICFGRTJ(VUZQRMISFIM a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C8C0", Offset = "0x8A3B6C0", VA = "0x188A3C8C0", Slot = "4")]
		protected override bool IFFCWNVJWRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CD80", Offset = "0x8A3BB80", VA = "0x188A3CD80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A35860", Offset = "0x8A34660", VA = "0x188A35860")]
		private static void KQBQCVWTNVB(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D180", Offset = "0x8A3BF80", VA = "0x188A3D180")]
		private static void KQBQCVWTNVB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D280", Offset = "0x8A3C080", VA = "0x188A3D280")]
		public static void KQBQCVWTNVB(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D160", Offset = "0x8A3BF60", VA = "0x188A3D160")]
		public static void GXRVNCFILNA(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D1F0", Offset = "0x8A3BFF0", VA = "0x188A3D1F0")]
		public static void GXRVNCFILNA(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D280", Offset = "0x8A3C080", VA = "0x188A3D280")]
		public static void GXRVNCFILNA(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D280", Offset = "0x8A3C080", VA = "0x188A3D280")]
		public static void GXRVNCFILNA(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D180", Offset = "0x8A3BF80", VA = "0x188A3D180")]
		public static void GXRVNCFILNA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D180", Offset = "0x8A3BF80", VA = "0x188A3D180")]
		public static void GXRVNCFILNA(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D270", Offset = "0x8A3C070", VA = "0x188A3D270")]
		public static void GXRVNCFILNA(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D270", Offset = "0x8A3C070", VA = "0x188A3D270")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OPKHXJWZEEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int OYZVFPVBVFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A398F0", Offset = "0x8A386F0", VA = "0x188A398F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CGVUTGXWAAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B5B0", Offset = "0x2A1A3B0", VA = "0x182A1B5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int EDQULJPNWSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8A39B20", Offset = "0x8A38920", VA = "0x188A39B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8A39560", Offset = "0x8A38360", VA = "0x188A39560")]
		public void GZJEIXBXHIW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FSVCPCYGMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8A39BB0", Offset = "0x8A389B0", VA = "0x188A39BB0")]
		public FSVCPCYGMGD(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8A39820", Offset = "0x8A38620", VA = "0x188A39820")]
		public IPEndPoint JIZWHGQVBPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8A39900", Offset = "0x8A38700", VA = "0x188A39900")]
		public byte JRLEKQIXLAF()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A39900", Offset = "0x8A38700", VA = "0x188A39900")]
		public sbyte NNAQBWAXLDQ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6F50", Offset = "0x3AA5D50", VA = "0x183AA6F50")]
		public a[] THFJAFUCQOU<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A393F0", Offset = "0x8A381F0", VA = "0x188A393F0")]
		public bool[] AKWTQYHUUME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8A39980", Offset = "0x8A38780", VA = "0x188A39980")]
		public ushort[] QTTDKRSIAMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A39AE0", Offset = "0x8A388E0", VA = "0x188A39AE0")]
		public short[] WZNNFUOKPBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8A397E0", Offset = "0x8A385E0", VA = "0x188A397E0")]
		public int[] ISKGUIOIOYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8A39B70", Offset = "0x8A38970", VA = "0x188A39B70")]
		public uint[] ZGTDGMPBSWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A39430", Offset = "0x8A38230", VA = "0x188A39430")]
		public float[] BFGLHRCKNGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8A398B0", Offset = "0x8A386B0", VA = "0x188A398B0")]
		public double[] JNJIXPPBKXZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A399F0", Offset = "0x8A387F0", VA = "0x188A399F0")]
		public long[] SHWTKKCEQWK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A39A30", Offset = "0x8A38830", VA = "0x188A39A30")]
		public ulong[] TPMLVQFZGYZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8A39320", Offset = "0x8A38120", VA = "0x188A39320")]
		public string[] AJLDJJAFOXR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A39B30", Offset = "0x8A38930", VA = "0x188A39B30")]
		public bool YSPTQUMSMXJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8A39500", Offset = "0x8A38300", VA = "0x188A39500")]
		public char MVGGPIYGHKD()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8A39500", Offset = "0x8A38300", VA = "0x188A39500")]
		public ushort TTICGPGHIKA()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8A39500", Offset = "0x8A38300", VA = "0x188A39500")]
		public short DISYCMGZLMP()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A397B0", Offset = "0x8A385B0", VA = "0x188A397B0")]
		public long NEBMHJJYLEB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8A397B0", Offset = "0x8A385B0", VA = "0x188A397B0")]
		public ulong IIABNXYZSFS()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8A399C0", Offset = "0x8A387C0", VA = "0x188A399C0")]
		public int TJALRFIUNJW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8A399C0", Offset = "0x8A387C0", VA = "0x188A399C0")]
		public uint RPKCVSQDTFN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8A39A70", Offset = "0x8A38870", VA = "0x188A39A70")]
		public float TSTRHRCZTET()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8A39530", Offset = "0x8A38330", VA = "0x188A39530")]
		public double DUJEZWDTTKO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8A395A0", Offset = "0x8A383A0", VA = "0x188A395A0")]
		public string HCRODWCQXOW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8A39470", Offset = "0x8A38270", VA = "0x188A39470")]
		public ArraySegment<byte> BFNZUXONBAL(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A39940", Offset = "0x8A38740", VA = "0x188A39940")]
		public sbyte[] NJXQPCWSPNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8A39AA0", Offset = "0x8A388A0", VA = "0x188A39AA0")]
		public byte[] WGHSVZDXJZY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A394E0", Offset = "0x8A382E0", VA = "0x188A394E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CCF0", Offset = "0x8A4BAF0", VA = "0x188A4CCF0")]
		public ZFXMZLDFTIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CD70", Offset = "0x8A4BB70", VA = "0x188A4CD70")]
		public ZFXMZLDFTIP(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CC00", Offset = "0x8A4BA00", VA = "0x188A4CC00")]
		public static ZFXMZLDFTIP TUZBEOPRIPO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C500", Offset = "0x8A4B300", VA = "0x188A4C500")]
		public void JQTEZLWDCLY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A93D70", Offset = "0x2A92B70", VA = "0x182A93D70")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C820", Offset = "0x8A4B620", VA = "0x188A4C820")]
		public void NLAXRAVZBOC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CBB0", Offset = "0x8A4B9B0", VA = "0x188A4CBB0")]
		public void NLAXRAVZBOC(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C670", Offset = "0x8A4B470", VA = "0x188A4C670")]
		public void NLAXRAVZBOC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C670", Offset = "0x8A4B470", VA = "0x188A4C670")]
		public void NLAXRAVZBOC(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C790", Offset = "0x8A4B590", VA = "0x188A4C790")]
		public void NLAXRAVZBOC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C790", Offset = "0x8A4B590", VA = "0x188A4C790")]
		public void NLAXRAVZBOC(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C5A0", Offset = "0x8A4B3A0", VA = "0x188A4C5A0")]
		public void NLAXRAVZBOC(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C5A0", Offset = "0x8A4B3A0", VA = "0x188A4C5A0")]
		public void NLAXRAVZBOC(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C5A0", Offset = "0x8A4B3A0", VA = "0x188A4C5A0")]
		public void NLAXRAVZBOC(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C610", Offset = "0x8A4B410", VA = "0x188A4C610")]
		public void NLAXRAVZBOC(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C610", Offset = "0x8A4B410", VA = "0x188A4C610")]
		public void NLAXRAVZBOC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CB40", Offset = "0x8A4B940", VA = "0x188A4CB40")]
		public void NLAXRAVZBOC(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C420", Offset = "0x8A4B220", VA = "0x188A4C420")]
		public void IMPNXTOPVGG(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C420", Offset = "0x8A4B220", VA = "0x188A4C420")]
		public void KSARLMDUPRX(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C8C0", Offset = "0x8A4B6C0", VA = "0x188A4C8C0")]
		public void NLAXRAVZBOC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C340", Offset = "0x8A4B140", VA = "0x188A4C340")]
		public void CHDUGUWZUWX(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BFD0", Offset = "0x8A4ADD0", VA = "0x188A4BFD0")]
		public void CHDUGUWZUWX(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C180", Offset = "0x8A4AF80", VA = "0x188A4C180")]
		public void CHDUGUWZUWX(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C180", Offset = "0x8A4AF80", VA = "0x188A4C180")]
		public void CHDUGUWZUWX(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C180", Offset = "0x8A4AF80", VA = "0x188A4C180")]
		public void CHDUGUWZUWX(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BFD0", Offset = "0x8A4ADD0", VA = "0x188A4BFD0")]
		public void CHDUGUWZUWX(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BFD0", Offset = "0x8A4ADD0", VA = "0x188A4BFD0")]
		public void CHDUGUWZUWX(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C260", Offset = "0x8A4B060", VA = "0x188A4C260")]
		public void CHDUGUWZUWX(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C260", Offset = "0x8A4B060", VA = "0x188A4C260")]
		public void CHDUGUWZUWX(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C420", Offset = "0x8A4B220", VA = "0x188A4C420")]
		public void CHDUGUWZUWX(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C0B0", Offset = "0x8A4AEB0", VA = "0x188A4C0B0")]
		public void CHDUGUWZUWX(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C6C0", Offset = "0x8A4B4C0", VA = "0x188A4C6C0")]
		public void NLAXRAVZBOC(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C920", Offset = "0x8A4B720", VA = "0x188A4C920")]
		public void NLAXRAVZBOC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C930", Offset = "0x8A4B730", VA = "0x188A4C930")]
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
			[Cpp2IlInjected.Address(RVA = "0x78B17F0", Offset = "0x78B05F0", VA = "0x1878B17F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public HFLYGUVSTXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x646A860", Offset = "0x6469660", VA = "0x18646A860")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GMUTXYOLAWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6387B40", Offset = "0x6386940", VA = "0x186387B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A35FE0", Offset = "0x8A34DE0", VA = "0x188A35FE0")]
		public AMJWKGCFUSU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3363C20", Offset = "0x3362A20", VA = "0x183363C20", Slot = "4")]
		protected virtual ulong BJXMFTMPPLJ<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A35F10", Offset = "0x8A34D10", VA = "0x188A35F10", Slot = "5")]
		protected virtual SubscribeDelegate SWLFVCKPFNW(FSVCPCYGMGD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3363CA0", Offset = "0x3362AA0", VA = "0x183363CA0", Slot = "6")]
		protected virtual void GPNIAZKWNMU<b>(ZFXMZLDFTIP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8A35E90", Offset = "0x8A34C90", VA = "0x188A35E90")]
		public void HLBRNRQCUVP(FSVCPCYGMGD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3363D20", Offset = "0x3362B20", VA = "0x183363D20")]
		public void JMVJVIOJCPK<j>(ZFXMZLDFTIP a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8A35E40", Offset = "0x8A34C40", VA = "0x188A35E40")]
		public void EUQQKLINQEV(FSVCPCYGMGD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3363F30", Offset = "0x3362D30", VA = "0x183363F30")]
		public void YWXCODOBFKS<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3363F30", Offset = "0x3362D30", VA = "0x183363F30")]
		public void YWXCODOBFKS<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A210", Offset = "0x8A39010", VA = "0x188A3A210")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C710", Offset = "0x8A3B510", VA = "0x188A3C710")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FD9BD0", Offset = "0x4FD89D0", VA = "0x184FD9BD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x532F790", Offset = "0x532E590", VA = "0x18532F790", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x532F790", Offset = "0x532E590", VA = "0x18532F790", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x532F6C0", Offset = "0x532E4C0", VA = "0x18532F6C0", Slot = "9")]
			public override void EYZPXMFHJON(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x532F6C0", Offset = "0x532E4C0", VA = "0x18532F6C0", Slot = "10")]
			public override void XXJQLSGAGTC(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x532F860", Offset = "0x532E660", VA = "0x18532F860")]
			protected b[] QHGWXFTRUOC(a a, FSVCPCYGMGD b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x532F550", Offset = "0x532E350", VA = "0x18532F550")]
			protected b[] ABSQLICJPXL(a a, ZFXMZLDFTIP b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5330070", Offset = "0x532EE70", VA = "0x185330070", Slot = "4")]
			public override void RKCBVVMJUOD(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x53305E0", Offset = "0x532F3E0", VA = "0x1853305E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x68C5900", Offset = "0x68C4700", VA = "0x1868C5900", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x68C5130", Offset = "0x68C3F30", VA = "0x1868C5130", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x68C5370", Offset = "0x68C4170", VA = "0x1868C5370", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x68C56A0", Offset = "0x68C44A0", VA = "0x1868C56A0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x68C5B00", Offset = "0x68C4900", VA = "0x1868C5B00")]
			protected LTJMMOMEVPQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class AWNPAFHNRMN<a> : DLFZLGLDGKB<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6ED0050", Offset = "0x6ECEE50", VA = "0x186ED0050", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x6ECFC70", Offset = "0x6ECEA70", VA = "0x186ECFC70", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7200160", Offset = "0x71FEF60", VA = "0x187200160", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6ECFF00", Offset = "0x6ECED00", VA = "0x186ECFF00", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public AWNPAFHNRMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class MADWRXTLHTU<a> : DLFZLGLDGKB<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED0050", Offset = "0x6ECEE50", VA = "0x186ED0050", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x6ECFC70", Offset = "0x6ECEA70", VA = "0x186ECFC70", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6ECFDB0", Offset = "0x6ECEBB0", VA = "0x186ECFDB0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x6ECFF00", Offset = "0x6ECED00", VA = "0x186ECFF00", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public MADWRXTLHTU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class XMNHIZFTMCG<a> : DLFZLGLDGKB<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5082200", Offset = "0x5081000", VA = "0x185082200", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5081D10", Offset = "0x5080B10", VA = "0x185081D10", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5081E50", Offset = "0x5080C50", VA = "0x185081E50", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x50820A0", Offset = "0x5080EA0", VA = "0x1850820A0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public XMNHIZFTMCG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class NQGUMBYVITH<a> : DLFZLGLDGKB<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x5082200", Offset = "0x5081000", VA = "0x185082200", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5081D10", Offset = "0x5080B10", VA = "0x185081D10", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x710EA20", Offset = "0x710D820", VA = "0x18710EA20", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x50820A0", Offset = "0x5080EA0", VA = "0x1850820A0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public NQGUMBYVITH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class WRKKIPAYMSE<a> : DLFZLGLDGKB<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9C20", Offset = "0x6EF8A20", VA = "0x186EF9C20", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9850", Offset = "0x6EF8650", VA = "0x186EF9850", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x85B44E0", Offset = "0x85B32E0", VA = "0x1885B44E0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9BE0", Offset = "0x6EF89E0", VA = "0x186EF9BE0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public WRKKIPAYMSE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class MYOHBILWIEB<a> : DLFZLGLDGKB<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9C20", Offset = "0x6EF8A20", VA = "0x186EF9C20", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9850", Offset = "0x6EF8650", VA = "0x186EF9850", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9990", Offset = "0x6EF8790", VA = "0x186EF9990", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9BE0", Offset = "0x6EF89E0", VA = "0x186EF9BE0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public MYOHBILWIEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class ZSOCGZNBMAU<a> : DLFZLGLDGKB<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x51226D0", Offset = "0x51214D0", VA = "0x1851226D0", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x51222E0", Offset = "0x51210E0", VA = "0x1851222E0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5122420", Offset = "0x5121220", VA = "0x185122420", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5122570", Offset = "0x5121370", VA = "0x185122570", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public ZSOCGZNBMAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class PYRNMEMVLVF<a> : DLFZLGLDGKB<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x51226D0", Offset = "0x51214D0", VA = "0x1851226D0", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x51222E0", Offset = "0x51210E0", VA = "0x1851222E0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x73B7B00", Offset = "0x73B6900", VA = "0x1873B7B00", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5122570", Offset = "0x5121370", VA = "0x185122570", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public PYRNMEMVLVF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class UOGUGVLKAYS<a> : DLFZLGLDGKB<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x7CDA850", Offset = "0x7CD9650", VA = "0x187CDA850", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x7CDA4B0", Offset = "0x7CD92B0", VA = "0x187CDA4B0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x7CDA5F0", Offset = "0x7CD93F0", VA = "0x187CDA5F0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x6ECFF00", Offset = "0x6ECED00", VA = "0x186ECFF00", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public UOGUGVLKAYS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class RJDBLHUJLDZ<a> : DLFZLGLDGKB<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x762F910", Offset = "0x762E710", VA = "0x18762F910", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x762F670", Offset = "0x762E470", VA = "0x18762F670", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x762F7B0", Offset = "0x762E5B0", VA = "0x18762F7B0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9BE0", Offset = "0x6EF89E0", VA = "0x186EF9BE0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public RJDBLHUJLDZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class GVSKIYTENDY<a> : DLFZLGLDGKB<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6391370", Offset = "0x6390170", VA = "0x186391370", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x63911E0", Offset = "0x638FFE0", VA = "0x1863911E0", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6391320", Offset = "0x6390120", VA = "0x186391320", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x5122570", Offset = "0x5121370", VA = "0x185122570", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x5082270", Offset = "0x5081070", VA = "0x185082270")]
			public GVSKIYTENDY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class RTUWWXJDWXM<a> : LTJMMOMEVPQ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x76519F0", Offset = "0x76507F0", VA = "0x1876519F0", Slot = "12")]
			protected override void ADVANRIXKBU(ZFXMZLDFTIP a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x7651A20", Offset = "0x7650820", VA = "0x187651A20", Slot = "11")]
			protected override void FYCHKNMVXNZ(FSVCPCYGMGD a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x63850D0", Offset = "0x6383ED0", VA = "0x1863850D0")]
			public RTUWWXJDWXM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class GKTDHGXCAJI<a> : LTJMMOMEVPQ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6385060", Offset = "0x6383E60", VA = "0x186385060", Slot = "12")]
			protected override void ADVANRIXKBU(ZFXMZLDFTIP a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6385090", Offset = "0x6383E90", VA = "0x186385090", Slot = "11")]
			protected override void FYCHKNMVXNZ(FSVCPCYGMGD a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x63850D0", Offset = "0x6383ED0", VA = "0x1863850D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5124260", Offset = "0x5123060", VA = "0x185124260")]
			public ZUZGWWCDTPR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x51240A0", Offset = "0x5122EA0", VA = "0x1851240A0", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5123D90", Offset = "0x5122B90", VA = "0x185123D90", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5123EF0", Offset = "0x5122CF0", VA = "0x185123EF0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5123F50", Offset = "0x5122D50", VA = "0x185123F50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5330B30", Offset = "0x532F930", VA = "0x185330B30")]
			public DOFVUBPQMPH(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5330A30", Offset = "0x532F830", VA = "0x185330A30", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5330720", Offset = "0x532F520", VA = "0x185330720", Slot = "6")]
			public override void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x53308C0", Offset = "0x532F6C0", VA = "0x1853308C0", Slot = "7")]
			public override void KLOBYTEQQMK(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x53308C0", Offset = "0x532F6C0", VA = "0x1853308C0", Slot = "8")]
			public override void WAAFAVDTHYJ(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x53306D0", Offset = "0x532F4D0", VA = "0x1853306D0", Slot = "9")]
			public override void EYZPXMFHJON(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x53306D0", Offset = "0x532F4D0", VA = "0x1853306D0", Slot = "10")]
			public override void XXJQLSGAGTC(a a, ZFXMZLDFTIP b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class XBUUTRRPFSW<a> : DOFVUBPQMPH<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x507CFA0", Offset = "0x507BDA0", VA = "0x18507CFA0")]
			public XBUUTRRPFSW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x507CDC0", Offset = "0x507BBC0", VA = "0x18507CDC0", Slot = "5")]
			public override void YHIVLMQLZBD(a a, FSVCPCYGMGD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x507CD40", Offset = "0x507BB40", VA = "0x18507CD40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EC0660", Offset = "0x7EBF460", VA = "0x187EC0660")]
			public VWPRMSTCHZG(List<CAMIHLBKUAI<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x7EC0130", Offset = "0x7EBEF30", VA = "0x187EC0130")]
			public void JMVJVIOJCPK(a a, ZFXMZLDFTIP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x7EC0520", Offset = "0x7EBF320", VA = "0x187EC0520")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A3A220", Offset = "0x8A39020", VA = "0x188A3A220")]
		public JUGDIVIKDSA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3B477E0", Offset = "0x3B465E0", VA = "0x183B477E0")]
		private VWPRMSTCHZG<d> CHPJPBQKQQN<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3B46970", Offset = "0x3B45770", VA = "0x183B46970")]
		public void CBYRPQCEVDS<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3B48570", Offset = "0x3B47370", VA = "0x183B48570")]
		public bool Deserialize<T>(FSVCPCYGMGD reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3B485F0", Offset = "0x3B473F0", VA = "0x183B485F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A383A0", Offset = "0x8A371A0", VA = "0x188A383A0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int IRBBPXNSSTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8A385E0", Offset = "0x8A373E0", VA = "0x188A385E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8A38360", Offset = "0x8A37160", VA = "0x188A38360")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode FZKHSZNZYHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A385B0", Offset = "0x8A373B0", VA = "0x188A385B0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A38320", Offset = "0x8A37120", VA = "0x188A38320")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int EFGDDRKTMZB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A383D0", Offset = "0x8A371D0", VA = "0x188A383D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint EATXXZKDDGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A384C0", Offset = "0x8A372C0", VA = "0x188A384C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? EUHYYECYCJX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A38AA0", Offset = "0x8A378A0", VA = "0x188A38AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? XZBEAVWDYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A38580", Offset = "0x8A37380", VA = "0x188A38580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? GNAUWLFNVRV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A38130", Offset = "0x8A36F30", VA = "0x188A38130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A37F10", Offset = "0x8A36D10", VA = "0x188A37F10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? FYXUPZYCOIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF62020", Offset = "0xF60E20", VA = "0x180F62020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A38F70", Offset = "0x8A37D70", VA = "0x188A38F70")]
		public EGLGBBSOEQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A39280", Offset = "0x8A38080", VA = "0x188A39280")]
		internal EGLGBBSOEQF(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A38990", Offset = "0x8A37790", VA = "0x188A38990")]
		public static EGLGBBSOEQF VLUOIMCGMKV(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A38610", Offset = "0x8A37410", VA = "0x188A38610")]
		internal void UNUBECKRVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A38B80", Offset = "0x8A37980", VA = "0x188A38B80")]
		private void XHRFXTSCTNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A38D40", Offset = "0x8A37B40", VA = "0x188A38D40")]
		private DateTime? ZIWUCDPBXPK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A38160", Offset = "0x8A36F60", VA = "0x188A38160")]
		private void DTYQMUDAYMQ(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A38AD0", Offset = "0x8A378D0", VA = "0x188A38AD0")]
		private ulong WUNTJUZVCVC(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A38400", Offset = "0x8A37200", VA = "0x188A38400")]
		private void MLPENAANLLW(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8A38520", Offset = "0x8A37320", VA = "0x188A38520")]
		private uint RQHSNCBNNPJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8900F00", Offset = "0x88FFD00", VA = "0x188900F00")]
		private static uint CODZJYFWGPU(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A380D0", Offset = "0x8A36ED0", VA = "0x188A380D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A3E940", Offset = "0x8A3D740", VA = "0x188A3E940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E850", Offset = "0x8A3D650", VA = "0x188A3E850")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A4B9F0", Offset = "0x8A4A7F0", VA = "0x188A4B9F0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int NVCJKQMPNAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B9D0", Offset = "0x8A4A7D0", VA = "0x188A4B9D0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint CRBFQXAZSKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BB00", Offset = "0x8A4A900", VA = "0x188A4BB00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily HCZPRAFNNEL
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32BF530", Offset = "0x32BE330", VA = "0x1832BF530", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BB20", Offset = "0x8A4A920", VA = "0x188A4BB20")]
		public WBTNGVEALHW(AddressFamily a, WBICUZCDOVB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8A4B3F0", Offset = "0x8A4A1F0", VA = "0x188A4B3F0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8A4B3B0", Offset = "0x8A4A1B0", VA = "0x188A4B3B0", Slot = "9")]
		public int BUZWZPOZFYK(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4BA10", Offset = "0x8A4A810", VA = "0x188A4BA10", Slot = "10")]
		public int QRKCXJZUFES(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4B9B0", Offset = "0x8A4A7B0", VA = "0x188A4B9B0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A3C3A0", Offset = "0x8A3B1A0", VA = "0x188A3C3A0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C440", Offset = "0x8A3B240", VA = "0x188A3C440")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x162E100", Offset = "0x162CF00", VA = "0x18162E100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C2B0", Offset = "0x8A3B0B0", VA = "0x188A3C2B0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C2F0", Offset = "0x8A3B0F0", VA = "0x188A3C2F0", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		internal void XHRARGJGBZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		internal void FVVWLSRSCYS(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9F780", Offset = "0x2B9E580", VA = "0x182B9F780")]
		public UFMXQCEOCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EF20", Offset = "0x8A3DD20", VA = "0x188A3EF20")]
		public void JAUHEDGOQYP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F3D0", Offset = "0x8A3E1D0", VA = "0x188A3F3D0")]
		public void ZZQJISXPGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EAD0", Offset = "0x8A3D8D0", VA = "0x188A3EAD0", Slot = "4")]
		public override void GYIGBVPGHWL(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F0D0", Offset = "0x8A3DED0", VA = "0x188A3F0D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A4D650", Offset = "0x8A4C450", VA = "0x188A4D650")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D280", Offset = "0x8A4C080", VA = "0x188A4D280")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D400", Offset = "0x8A4C200", VA = "0x188A4D400")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A3D7C0", Offset = "0x8A3C5C0", VA = "0x188A3D7C0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D790", Offset = "0x8A3C590", VA = "0x188A3D790")]
		private uint NHNPRZLFCKX(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8A35B60", Offset = "0x8A34960", VA = "0x188A35B60")]
		private void JWEFUICWQPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8A35950", Offset = "0x8A34750", VA = "0x188A35950")]
		private void BFLWDCHVHIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8A35C10", Offset = "0x8A34A10", VA = "0x188A35C10")]
		private void TKFAYOYRYPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8A35CA0", Offset = "0x8A34AA0", VA = "0x188A35CA0")]
		private void ZGCNNOBEPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D900", Offset = "0x8A3C700", VA = "0x188A3D900")]
		private void WRGBSNVCVWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D2C0", Offset = "0x8A3C0C0", VA = "0x188A3D2C0")]
		private unsafe void CSLLRKCBWFJ(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D8F0", Offset = "0x8A3C6F0", VA = "0x188A3D8F0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void WGDJHHJZSKS([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D840", Offset = "0x8A3C640", VA = "0x188A3D840")]
		public static void WGDJHHJZSKS(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D6E0", Offset = "0x8A3C4E0", VA = "0x188A3D6E0")]
		public static void HBITHEDXPUC(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D960", Offset = "0x8A3C760", VA = "0x188A3D960")]
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
	[Cpp2IlInjected.Address(RVA = "0x8A4D8A0", Offset = "0x8A4C6A0", VA = "0x188A4D8A0")]
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
