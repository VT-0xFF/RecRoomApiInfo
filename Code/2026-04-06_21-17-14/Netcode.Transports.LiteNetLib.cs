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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, ZEHDPEFZGEA
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
		private NetworkManager GAXONCHIUGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool DBCQZITKGJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, DLJCDSQXRUR> ZURBLRQURMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private KXSRENACLRK DNXVSLOTKZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch PPQSFAERCMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] THHISQANWOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType KDMFTBKPOFC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ZYOEMWMZJUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8BBAC60", Offset = "0x8BB9C60", VA = "0x188BBAC60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8BBAC10", Offset = "0x8BB9C10", VA = "0x188BBAC10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9F80", Offset = "0x8BB8F80", VA = "0x188BB9F80")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9F60", Offset = "0x8BB8F60", VA = "0x188BB9F60")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9C10", Offset = "0x8BB8C10", VA = "0x188BB9C10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA990", Offset = "0x8BB9990", VA = "0x188BBA990")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA090", Offset = "0x8BB9090", VA = "0x188BBA090", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9D00", Offset = "0x8BB8D00", VA = "0x188BB9D00", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA360", Offset = "0x8BB9360", VA = "0x188BBA360", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA6A0", Offset = "0x8BB96A0", VA = "0x188BBA6A0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB96D0", Offset = "0x8BB86D0", VA = "0x188BB96D0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BB95E0", Offset = "0x8BB85E0", VA = "0x188BB95E0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9840", Offset = "0x8BB8840", VA = "0x188BB9840", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA2F0", Offset = "0x8BB92F0", VA = "0x188BBA2F0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BB98E0", Offset = "0x8BB88E0", VA = "0x188BB98E0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAA70", Offset = "0x8BB9A70", VA = "0x188BBAA70")]
		private DeliveryMethod WJESBSIDVQR(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA9B0", Offset = "0x8BB99B0", VA = "0x188BBA9B0", Slot = "16")]
		private void VGIXCDPVKTA(DLJCDSQXRUR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA8C0", Offset = "0x8BB98C0", VA = "0x188BBA8C0", Slot = "17")]
		private void URQQILSJREE(DLJCDSQXRUR a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "18")]
		private void ACGAWLVNMDF(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9D60", Offset = "0x8BB8D60", VA = "0x188BB9D60", Slot = "19")]
		private void QVPPHCPVXJC(DLJCDSQXRUR a, XCLGIRRNJWG b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9B40", Offset = "0x8BB8B40", VA = "0x188BB9B40")]
		private void MMTPRAHGNNZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "20")]
		private void WTDJDGQBMLQ(IPEndPoint a, XCLGIRRNJWG b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "21")]
		private void YFACNNLBPVU(DLJCDSQXRUR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB97E0", Offset = "0x8BB87E0", VA = "0x188BB97E0", Slot = "22")]
		private void FKJVTUWKFGE(KGTQTFBFLVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9B10", Offset = "0x8BB8B10", VA = "0x188BB9B10")]
		private ulong JQINQFQQFMD(DLJCDSQXRUR a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9AF0", Offset = "0x8BB8AF0", VA = "0x188BB9AF0")]
		private ulong JQINQFQQFMD(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9D40", Offset = "0x8BB8D40", VA = "0x188BB9D40")]
		private static int QDQQLZDSQTS(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAB40", Offset = "0x8BB9B40", VA = "0x188BBAB40")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BB95B0", Offset = "0x8BB85B0", VA = "0x188BB95B0")]
		[CompilerGenerated]
		private void CITIMCZBAIA(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BB95B0", Offset = "0x8BB85B0", VA = "0x188BB95B0")]
		[CompilerGenerated]
		private void FILIRYKRSIJ(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class GEEVZBNTUVA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly DLJCDSQXRUR RUNDJSAKNRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<QLHJIEDDFJH> SKMMYDOLZZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int QUSUVDAFSXE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TZQUTQPTTPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFC20", Offset = "0x8BAEC20", VA = "0x188BAFC20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD90", Offset = "0x8BAED90", VA = "0x188BAFD90")]
		protected GEEVZBNTUVA(DLJCDSQXRUR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFC70", Offset = "0x8BAEC70", VA = "0x188BAFC70")]
		public void CNDKDJJMLAX(QLHJIEDDFJH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD10", Offset = "0x8BAED10", VA = "0x188BAFD10")]
		protected void SCQPRQKJGBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFCD0", Offset = "0x8BAECD0", VA = "0x188BAFCD0")]
		public bool FTNKIEWNWUW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool THAPDNFGGTI();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool IPVCIFINUZN(QLHJIEDDFJH a);
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
	public class KGTQTFBFLVB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly KXSRENACLRK FPOWFDPPVIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int CUNBVMXXAPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal XGWMJFDLRJU UYUEYDMXNDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint VTIESSGHUCR;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult EQMIYNLIKMX
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x162DF80", Offset = "0x162CF80", VA = "0x18162DF80")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x162DF90", Offset = "0x162CF90", VA = "0x18162DF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0D10", Offset = "0x8BAFD10", VA = "0x188BB0D10")]
		internal void RIEHGIYTULC(XGWMJFDLRJU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0CE0", Offset = "0x8BAFCE0", VA = "0x188BB0CE0")]
		private bool DJCUVHGSKZA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0D70", Offset = "0x8BAFD70", VA = "0x188BB0D70")]
		internal KGTQTFBFLVB(IPEndPoint a, XGWMJFDLRJU b, KXSRENACLRK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0C80", Offset = "0x8BAFC80", VA = "0x188BB0C80")]
		public DLJCDSQXRUR Accept()
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
		public XCLGIRRNJWG AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ZEHDPEFZGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WOJBAFBYHYO(DLJCDSQXRUR a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BJPHJDHCDYY(DLJCDSQXRUR a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UYQDSEIFDDN(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YUDIYVDCLAI(DLJCDSQXRUR a, XCLGIRRNJWG b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JVVCWCNVZOC(IPEndPoint a, XCLGIRRNJWG b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FDUDPWLWRHE(DLJCDSQXRUR a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WEXCWQRUGOM(KGTQTFBFLVB a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface EEHXWTUTIRN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UCIQTBWJIOG(DLJCDSQXRUR a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KMXFPDLXFRB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XVESHULSFRG(VZEAPHVKDOE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface RLIRCGSKHAV
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MARGZODARUP(DLJCDSQXRUR a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class XGWMJFDLRJU
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DIVGIBRFNRQ = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long GHDDKAKSKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte VXCFRLGLOWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] SWXLIBSBLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly CHUYDYMDEGW YTUTJGBWUDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int XYDWNJCIXWL;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0670", Offset = "0x8BBF670", VA = "0x188BC0670")]
		private XGWMJFDLRJU(long a, byte b, int c, byte[] d, CHUYDYMDEGW e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0640", Offset = "0x8BBF640", VA = "0x188BC0640")]
		public static int TFLGSBALTID(QLHJIEDDFJH a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0450", Offset = "0x8BBF450", VA = "0x188BC0450")]
		public static XGWMJFDLRJU IYAXPCNKIMC(QLHJIEDDFJH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0270", Offset = "0x8BBF270", VA = "0x188BC0270")]
		public static QLHJIEDDFJH ACPSRNZILCE(PSDTXBWHJBY a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class KAMQLVLLGGZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long GHDDKAKSKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte VXCFRLGLOWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int XYDWNJCIXWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool YNJEUUYCYPC;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0C30", Offset = "0x8BAFC30", VA = "0x188BB0C30")]
		private KAMQLVLLGGZ(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0A30", Offset = "0x8BAFA30", VA = "0x188BB0A30")]
		public static KAMQLVLLGGZ IYAXPCNKIMC(QLHJIEDDFJH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0940", Offset = "0x8BAF940", VA = "0x188BB0940")]
		public static QLHJIEDDFJH ACPSRNZILCE(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0B30", Offset = "0x8BAFB30", VA = "0x188BB0B30")]
		public static QLHJIEDDFJH ZSMLBWTUDBY(DLJCDSQXRUR a)
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
	public interface SXXTHRLWQRS
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VCXKGRWSINV(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RKHFPXFSUUV(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class XNHRWYLJCMX
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
		private class WVOYLFYUIKT
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint CUBQKUYMTOL
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string HDGNTGGJEXN
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WVOYLFYUIKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class EYPXYHCQOCZ
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint CUBQKUYMTOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint XBUCOZVYVXD
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string HDGNTGGJEXN
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public EYPXYHCQOCZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class BDIHLMKRRLF
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string HDGNTGGJEXN
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool ZXEBLKDTPSR
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xCFDEE0", Offset = "0xCFCEE0", VA = "0x180CFDEE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public BDIHLMKRRLF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly KXSRENACLRK KCRPPOXMXVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> UHBDAYOSUYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> XVDJJYWCTXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly CHUYDYMDEGW TFUFYOUPQCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly PSDTXBWHJBY XWMGJOGKYCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly GPSPEJPARVJ CTILGEDJGRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private SXXTHRLWQRS NJHTHNFNNYG;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int QXCSZNJTSFD = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool YCDYRXNJUYO;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0CD0", Offset = "0x8BBFCD0", VA = "0x188BC0CD0")]
		internal XNHRWYLJCMX(KXSRENACLRK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0840", Offset = "0x8BBF840", VA = "0x188BC0840")]
		internal void GHRIJMFCXJE(IPEndPoint a, QLHJIEDDFJH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4107530", Offset = "0x4106530", VA = "0x184107530")]
		private void XUCKBZLJPRG<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0B50", Offset = "0x8BBFB50", VA = "0x188BC0B50")]
		private void VCXKGRWSINV(WVOYLFYUIKT a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC06E0", Offset = "0x8BBF6E0", VA = "0x188BC06E0")]
		private void GGUQZSKGMVL(EYPXYHCQOCZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC09C0", Offset = "0x8BBF9C0", VA = "0x188BC09C0")]
		private void NOPLHTZHAXU(BDIHLMKRRLF a, IPEndPoint b)
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
	public static class ZOKTYVMYYKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] YHTDLLYYIGP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int DCFOOWXWKWV;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int WOGXJLDLXPO;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0110", Offset = "0x8BAF110", VA = "0x188BB0110")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0110", Offset = "0x8BAF110", VA = "0x188BB0110")]
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
	public interface OLUZYQAYLIQ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZTQYIETJUYE(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class FOYWWNAUUHW
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static OLUZYQAYLIQ MRSTRKQVRSS;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object MCFATAIOBQO;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF940", Offset = "0x8BAE940", VA = "0x188BAF940")]
		private static void SYRLKMTQMYF(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF8E0", Offset = "0x8BAE8E0", VA = "0x188BAF8E0")]
		internal static void QOIHBWFYONT(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF820", Offset = "0x8BAE820", VA = "0x188BAF820")]
		internal static void NKIBIMWBVBF(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF880", Offset = "0x8BAE880", VA = "0x188BAF880")]
		internal static void PCONCNGBLWJ(string a, params object[] args)
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
	public sealed class XCLGIRRNJWG : CHUYDYMDEGW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private QLHJIEDDFJH TPDSSUKWFVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly KXSRENACLRK HXYQVKRYKXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NMPMQNBVBOD HBFVJSYHUWE;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0220", Offset = "0x8BBF220", VA = "0x188BC0220")]
		internal XCLGIRRNJWG(KXSRENACLRK a, NMPMQNBVBOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0100", Offset = "0x8BBF100", VA = "0x188BC0100")]
		internal void CPIGZZQGZGL(QLHJIEDDFJH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0170", Offset = "0x8BBF170", VA = "0x188BC0170")]
		internal void OIYLRAARSZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8BC01F0", Offset = "0x8BBF1F0", VA = "0x188BC01F0")]
		public void VCGQNVKGPEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class NMPMQNBVBOD
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
		public NMPMQNBVBOD HLCUVHZCBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType AHRPWOVSMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DLJCDSQXRUR RUNDJSAKNRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint VTIESSGHUCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object PHAZHMCUVMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int WAEPZIYTSXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError EFSVDYZSOTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason EHOLLQKJQQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KGTQTFBFLVB KGTQTFBFLVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod ILHFCKLPBCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte SASNISDPLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly XCLGIRRNJWG OPXJJDJCYQR;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8BBADE0", Offset = "0x8BB9DE0", VA = "0x188BBADE0")]
		public NMPMQNBVBOD(KXSRENACLRK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KXSRENACLRK : IEnumerable<DLJCDSQXRUR>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class DNVOZCHFGOF : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8BAEFB0", Offset = "0x8BADFB0", VA = "0x188BAEFB0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF020", Offset = "0x8BAE020", VA = "0x188BAF020", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public DNVOZCHFGOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<DLJCDSQXRUR>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly DLJCDSQXRUR _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private DLJCDSQXRUR _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public DLJCDSQXRUR Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D7EB10", Offset = "0x1D7DB10", VA = "0x181D7EB10")]
			public NetPeerEnumerator(DLJCDSQXRUR p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB250", Offset = "0x8BBA250", VA = "0x188BBB250", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB2A0", Offset = "0x8BBA2A0", VA = "0x188BBB2A0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread ZKVHDSPZFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool FYEXBDKZVXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool UMFTHBHSXVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private UXRYZPMLTSR KFFPQFPMUOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent KBPXQYLFPNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<NMPMQNBVBOD> IOFLLHRILVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<NMPMQNBVBOD> GAUOCCVILWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NMPMQNBVBOD XNOCEDQUOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly ZEHDPEFZGEA LOLMMFWYZRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly EEHXWTUTIRN EQLYOYBZNUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly KMXFPDLXFRB CVJBCXNSVSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly RLIRCGSKHAV NAXFOOUHTUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, DLJCDSQXRUR> WBETYFGMILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, KGTQTFBFLVB> YHAJLZUHXVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, ZSNOZOLCHWF> EUDIRJKUSHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim QJXNOZGUZQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private DLJCDSQXRUR NVJTHLRNXLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int JTHVDVKWARM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<DLJCDSQXRUR> RLQWAHAXODS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private DLJCDSQXRUR[] WKWUPTJCAYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly JLMOQSOLKHA EWYCHHRTDXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int YKBLCCLCGQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> VDJPKFZGGPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte OOUJFQLZOZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object SVHFTUNSNQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool IPIGNYWOATH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool PVMRKHOPCQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int WFMLJMKBVEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int PMTQGWWDEWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int ABQOONECHIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int PGEFYEENLBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool ZHFLIOUTVYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool KZYDQOCNDDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int VOPYCKKNWPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int FHDEEQRZJXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int ZIGEMXWMVMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool YCDYRXNJUYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool TKCTGLYDNQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool OWZUVAFCNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool EZUOCCDMOMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int FNGSONMITVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int WSNBEMQUKQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool NOONDGGURSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly ETKWJVLUZCW NTPUZQNXAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool WDVALYUJMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly XNHRWYLJCMX XNHRWYLJCMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool NQBJNQAJXSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode KJLGXXDOXQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int ZTPGZDJUQIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool GQDMLNHYFRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool UYPAEFMSXXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool VQJEGCFAHVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool LCMYNNMLNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private QLHJIEDDFJH LBTJXDSFODR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int OTSALTDCUKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object ZHDKNKGWAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private QLHJIEDDFJH MYTMGQSZFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int CGGXHXGIHWL;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int KSXOUQWRZUR = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int WLKWYNMZUTM = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RHABTQGJSIM FGOYSHHKQYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private RHABTQGJSIM FGEKXTTPYBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread NGZOWDCIMFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread NGPBBPONTJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint ZGCZMYOSEZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint ZFSLSLAXMCQ;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] YXIOYFKWQSK;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] OAANAXTLBXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> UMMQFFGALST;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress OUESOFVACLO;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool MSGLCWYUSBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int GTGTLKWKCPG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool LSLWRJGGCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE6A420", Offset = "0xE69420", VA = "0x180E6A420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE68AD0", Offset = "0xE67AD0", VA = "0x180E68AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int EMDGEQXBHCO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2233FE0", Offset = "0x2232FE0", VA = "0x182233FE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23434A0", Offset = "0x23424A0", VA = "0x1823434A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte ZCWESIGVEOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDF18E0", Offset = "0xDF08E0", VA = "0x180DF18E0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int XQSJNMABVAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4D30", Offset = "0x8BB3D30", VA = "0x188BB4D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short KWJUJHDWVEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5190", Offset = "0x8BB4190", VA = "0x188BB5190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DLJCDSQXRUR.OnUpdatedMtuDelegate HBQGIULJIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1970", Offset = "0x8BB0970", VA = "0x188BB1970")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4C80", Offset = "0x8BB3C80", VA = "0x188BB4C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7E70", Offset = "0x8BB6E70", VA = "0x188BB7E70")]
		public void VHMLWXTJNOI(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5DC0", Offset = "0x8BB4DC0", VA = "0x188BB5DC0")]
		public void SKTKDCPDGVP(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3F80", Offset = "0x8BB2F80", VA = "0x188BB3F80")]
		private bool LOSMLXCHOGZ(IPEndPoint a, [Out] DLJCDSQXRUR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5620", Offset = "0x8BB4620", VA = "0x188BB5620")]
		private void RMIVSXGWTVT(DLJCDSQXRUR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7DC0", Offset = "0x8BB6DC0", VA = "0x188BB7DC0")]
		private void UDPJGAGOYCG(DLJCDSQXRUR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8C70", Offset = "0x8BB7C70", VA = "0x188BB8C70")]
		private void ZNMHVDQOFYD(DLJCDSQXRUR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8FF0", Offset = "0x8BB7FF0", VA = "0x188BB8FF0")]
		public KXSRENACLRK(ZEHDPEFZGEA a, [Optional] JLMOQSOLKHA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2330", Offset = "0x8BB1330", VA = "0x188BB2330")]
		internal void ETPXVMMCODB(DLJCDSQXRUR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7E20", Offset = "0x8BB6E20", VA = "0x188BB7E20")]
		internal void ULHIWNJNRQL(DLJCDSQXRUR a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3DE0", Offset = "0x8BB2DE0", VA = "0x188BB3DE0")]
		internal void KLMVJVFQLZB(DLJCDSQXRUR a, DisconnectReason b, SocketError c, QLHJIEDDFJH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BB87F0", Offset = "0x8BB77F0", VA = "0x188BB87F0")]
		private void XPMYDMITLLS(DLJCDSQXRUR a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, QLHJIEDDFJH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5250", Offset = "0x8BB4250", VA = "0x188BB5250")]
		private void RHCOBCFSNRY(NMPMQNBVBOD.EType a, [Optional] DLJCDSQXRUR b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] KGTQTFBFLVB g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] QLHJIEDDFJH j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5F10", Offset = "0x8BB4F10", VA = "0x188BB5F10")]
		private void SNLMSFIZDBD(NMPMQNBVBOD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5080", Offset = "0x8BB4080", VA = "0x188BB5080")]
		internal void QYCTRWEAFOZ(NMPMQNBVBOD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1A20", Offset = "0x8BB0A20", VA = "0x188BB1A20")]
		private void BXMDHWLHWDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4D50", Offset = "0x8BB3D50", VA = "0x188BB4D50")]
		private void QLLVUJGMFQR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB44C0", Offset = "0x8BB34C0", VA = "0x188BB44C0")]
		internal DLJCDSQXRUR PCVAFOHGGBQ(KGTQTFBFLVB a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3A90", Offset = "0x8BB2A90", VA = "0x188BB3A90")]
		private int IGWQDOVHDYW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4020", Offset = "0x8BB3020", VA = "0x188BB4020")]
		private void MJYTMRSNAEY(IPEndPoint a, DLJCDSQXRUR b, XGWMJFDLRJU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BB23E0", Offset = "0x8BB13E0", VA = "0x188BB23E0")]
		private void FWADQZQYLMR(QLHJIEDDFJH a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5950", Offset = "0x8BB4950", VA = "0x188BB5950")]
		internal void RNHQHCGPSPX(QLHJIEDDFJH a, DeliveryMethod b, byte c, int d, DLJCDSQXRUR e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6E40", Offset = "0x8BB5E40", VA = "0x188BB6E40")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6E50", Offset = "0x8BB5E50", VA = "0x188BB6E50")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6E70", Offset = "0x8BB5E70", VA = "0x188BB6E70")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8090", Offset = "0x8BB7090", VA = "0x188BB8090")]
		public void VUFHISZFDUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2230", Offset = "0x8BB1230", VA = "0x188BB2230")]
		public DLJCDSQXRUR Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1D80", Offset = "0x8BB0D80", VA = "0x188BB1D80")]
		public DLJCDSQXRUR Connect(string address, int port, PSDTXBWHJBY connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1E60", Offset = "0x8BB0E60", VA = "0x188BB1E60")]
		public DLJCDSQXRUR Connect(IPEndPoint target, PSDTXBWHJBY connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7250", Offset = "0x8BB6250", VA = "0x188BB7250")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6EF0", Offset = "0x8BB5EF0", VA = "0x188BB6EF0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7D10", Offset = "0x8BB6D10", VA = "0x188BB7D10")]
		public void UDFAQBRCVTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7C40", Offset = "0x8BB6C40", VA = "0x188BB7C40")]
		public void UDFAQBRCVTB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB87B0", Offset = "0x8BB77B0", VA = "0x188BB87B0")]
		public void XPMYDMITLLS(DLJCDSQXRUR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8770", Offset = "0x8BB7770", VA = "0x188BB8770")]
		public void XPMYDMITLLS(DLJCDSQXRUR a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3B10", Offset = "0x8BB2B10", VA = "0x188BB3B10", Slot = "4")]
		private IEnumerator<DLJCDSQXRUR> JIHLVICLYTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8BE0", Offset = "0x8BB7BE0", VA = "0x188BB8BE0", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7A70", Offset = "0x8BB6A70", VA = "0x188BB7A70")]
		private QLHJIEDDFJH UARZCITUFEV(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7B60", Offset = "0x8BB6B60", VA = "0x188BB7B60")]
		private QLHJIEDDFJH UARZCITUFEV(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3BA0", Offset = "0x8BB2BA0", VA = "0x188BB3BA0")]
		internal QLHJIEDDFJH JSGDDAGXVHW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8500", Offset = "0x8BB7500", VA = "0x188BB8500")]
		internal void WYAILBJUAWF(QLHJIEDDFJH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8F30", Offset = "0x8BB7F30", VA = "0x188BB8F30")]
		static KXSRENACLRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE6A420", Offset = "0xE69420", VA = "0x180E6A420")]
		private bool KAZRFVIYBRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3E20", Offset = "0x8BB2E20", VA = "0x188BB3E20")]
		private void LLTISUYFOLM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1820", Offset = "0x8BB0820", VA = "0x188BB1820")]
		private void AZASWSKIYZP(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5C20", Offset = "0x8BB4C20", VA = "0x188BB5C20")]
		private bool SBIZXSDCBKD(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2310", Offset = "0x8BB1310", VA = "0x188BB2310")]
		private void EASOSIVPDPC(UXRYZPMLTSR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8240", Offset = "0x8BB7240", VA = "0x188BB8240")]
		private void WHSHNUKUYEV(RHABTQGJSIM a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3700", Offset = "0x8BB2700", VA = "0x188BB3700")]
		private void GMYUJYGFOCL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB66D0", Offset = "0x8BB56D0", VA = "0x188BB66D0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2380", Offset = "0x8BB1380", VA = "0x188BB2380")]
		internal int EVDGQEUZJXS(QLHJIEDDFJH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7260", Offset = "0x8BB6260", VA = "0x188BB7260")]
		internal int TMGYKHURHSC(QLHJIEDDFJH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BB72A0", Offset = "0x8BB62A0", VA = "0x188BB72A0")]
		internal int TMGYKHURHSC(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4B00", Offset = "0x8BB3B00", VA = "0x188BB4B00")]
		internal void PDTLUQBRTDR(bool a)
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
	internal sealed class QLHJIEDDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int DKFMZTZJIDE;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] UZONRBFMJMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] XIFLZTNIIEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int PLCZIGQXJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object PHAZHMCUVMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public QLHJIEDDFJH HLCUVHZCBGD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty MDSBKMJCRCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC6D0", Offset = "0x8BBB6D0", VA = "0x188BBC6D0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC530", Offset = "0x8BBB530", VA = "0x188BBC530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte VXCFRLGLOWL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC4C0", Offset = "0x8BBB4C0", VA = "0x188BBC4C0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC790", Offset = "0x8BBB790", VA = "0x188BBC790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort HIXGVRXKFNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC7D0", Offset = "0x8BBB7D0", VA = "0x188BBC7D0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC4F0", Offset = "0x8BBB4F0", VA = "0x188BBC4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool XQRNUCOZGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC440", Offset = "0x8BBB440", VA = "0x188BBC440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte OAVJJIZKRAY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC490", Offset = "0x8BBB490", VA = "0x188BBC490")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC3D0", Offset = "0x8BBB3D0", VA = "0x188BBC3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort IXVBCTIXBCT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC470", Offset = "0x8BBB470", VA = "0x188BBC470")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC690", Offset = "0x8BBB690", VA = "0x188BBC690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort RQOWHAIIBPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC570", Offset = "0x8BBB570", VA = "0x188BBC570")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC700", Offset = "0x8BBB700", VA = "0x188BBC700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort DTIRUODMGFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC740", Offset = "0x8BBB740", VA = "0x188BBC740")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC400", Offset = "0x8BBB400", VA = "0x188BBC400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC7F0", Offset = "0x8BBB7F0", VA = "0x188BBC7F0")]
		static QLHJIEDDFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC760", Offset = "0x8BBB760", VA = "0x188BBC760")]
		public void YADMJKUCUDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCAC0", Offset = "0x8BBBAC0", VA = "0x188BBCAC0")]
		public QLHJIEDDFJH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB30", Offset = "0x8BBBB30", VA = "0x188BBCB30")]
		public QLHJIEDDFJH(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC620", Offset = "0x8BBB620", VA = "0x188BBC620")]
		public static int RGSZAXFSVQO(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC590", Offset = "0x8BBB590", VA = "0x188BBC590")]
		public int RGSZAXFSVQO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC2D0", Offset = "0x8BBB2D0", VA = "0x188BBC2D0")]
		public bool BTJBWLGOFGP()
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
	public class DLJCDSQXRUR
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class KDSOVSGJIRF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public QLHJIEDDFJH[] UIZCFBQIYAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int CIMNSAOVBHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int KEXJOWFXNAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte OAVJJIZKRAY;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KDSOVSGJIRF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int CQVMQHNDSNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int SHLZITOKZYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int BGZRDNKHDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double WPCCWGYUDTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int WEEPVJZMBSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int QALLNTRFYVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int UHEEWYTYBQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch AYQOCLIPYRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int LVSILZMKULG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long JFDFLQSQWXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object LOHZSTCHKTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal DLJCDSQXRUR EXIEMXTKTPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal DLJCDSQXRUR SKXLWRUTXIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<QLHJIEDDFJH> OBGRYIQLUVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<GEEVZBNTUVA> KJXLBYDLRVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly GEEVZBNTUVA[] QEKUEPZVSFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int QZYMCCSFRKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int TBBUFBYWGQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool AYANOZXROEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int TLRVWXHVQWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int ZNFLXKYZETX;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int SJJUVSTSDIN = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int RPZYIRKJZUO = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object ZLADSVFLJZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int VIYHGQPMPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, KDSOVSGJIRF> UHZKGMPLYWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> RYEDSOWJZEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly QLHJIEDDFJH IWIYXFNHKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int VXRUTBQLJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int OOPHVUCCOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint XSGAZEVOTLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int RFZMSORMESB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int QDFGGHCKUKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long ROHDKRWULHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte VEEPMZEGNDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState JXFYAKAKQYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private QLHJIEDDFJH MAPWKAGDIHX;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int DIZGJCLLFML = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int XTYYTRUZEVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly QLHJIEDDFJH DDMXJODWLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly QLHJIEDDFJH XVFRZKPUVFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly QLHJIEDDFJH OHRHSPJJUQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly QLHJIEDDFJH KHDZIRMGTMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality TNOAUPAOWQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly KXSRENACLRK KXSRENACLRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int OSRJHZIEHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object NKHMJEBDTCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly ETKWJVLUZCW NTPUZQNXAOF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte FGDZXBAOTIW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD22680", Offset = "0xD21680", VA = "0x180D22680")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB0C0", Offset = "0x8BAA0C0", VA = "0x188BAB0C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint GIBLQRJVHGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE61940", Offset = "0xE60940", VA = "0x180E61940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState POUTOVFBKPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x149C600", Offset = "0x149B600", VA = "0x18149C600")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long JIFFAKAKQAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCFA2A0", Offset = "0xCF92A0", VA = "0x180CFA2A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int IHMWHYCTQCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2233FE0", Offset = "0x2232FE0", VA = "0x182233FE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x23434A0", Offset = "0x23424A0", VA = "0x1823434A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int SUEEAXRWOGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAE80", Offset = "0x8BA9E80", VA = "0x188BAAE80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int KEWBOHPHITV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD12FF0", Offset = "0xD11FF0", VA = "0x180D12FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double QAPNKYSAPJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6AB0", Offset = "0x2AC5AB0", VA = "0x182AC6AB0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate HBQGIULJIHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB190", Offset = "0x8BAA190", VA = "0x188BAB190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BACF70", Offset = "0x8BABF70", VA = "0x188BACF70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEBB0", Offset = "0x8BADBB0", VA = "0x188BAEBB0")]
		internal DLJCDSQXRUR(KXSRENACLRK a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB170", Offset = "0x8BAA170", VA = "0x188BAB170")]
		internal void BOALZCCPDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BADBA0", Offset = "0x8BACBA0", VA = "0x188BADBA0")]
		internal void VAHBCQTNEWE(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB9E0", Offset = "0x8BAA9E0", VA = "0x188BAB9E0")]
		internal void GONFKWNTHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE730", Offset = "0x8BAD730", VA = "0x188BAE730")]
		private void YOHFEDHTFAS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB6C0", Offset = "0x8BAA6C0", VA = "0x188BAB6C0")]
		private void EJWCPMMRIDQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE90", Offset = "0x8BA9E90", VA = "0x188BAAE90")]
		public int ALTIBBOSMFG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAFA0", Offset = "0x8BA9FA0", VA = "0x188BAAFA0")]
		public int ALTIBBOSMFG(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BACDE0", Offset = "0x8BABDE0", VA = "0x188BACDE0")]
		private GEEVZBNTUVA NSLQDMOCRIZ(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEA20", Offset = "0x8BADA20", VA = "0x188BAEA20")]
		internal DLJCDSQXRUR(KXSRENACLRK a, IPEndPoint b, int c, byte d, PSDTXBWHJBY e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE840", Offset = "0x8BAD840", VA = "0x188BAE840")]
		internal DLJCDSQXRUR(KXSRENACLRK a, KGTQTFBFLVB b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD170", Offset = "0x8BAC170", VA = "0x188BAD170")]
		internal void Reject(XGWMJFDLRJU requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB960", Offset = "0x8BAA960", VA = "0x188BAB960")]
		internal bool GJGLIMETHXR(KAMQLVLLGGZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE700", Offset = "0x8BAD700", VA = "0x188BAE700")]
		public void XUCKBZLJPRG(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE110", Offset = "0x8BAD110", VA = "0x188BAE110")]
		private void VRYXARDWIYN(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB670", Offset = "0x8BAA670", VA = "0x188BAB670")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB5D0", Offset = "0x8BAA5D0", VA = "0x188BAB5D0")]
		internal DisconnectResult DXAXXMGRTPP(QLHJIEDDFJH a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC9B0", Offset = "0x8BAB9B0", VA = "0x188BAC9B0")]
		internal void JQAXECVTHVQ(GEEVZBNTUVA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD1C0", Offset = "0x8BAC1C0", VA = "0x188BAD1C0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE800", Offset = "0x8BAD800", VA = "0x188BAE800")]
		private void ZQEXJRDWPUH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BABA70", Offset = "0x8BAAA70", VA = "0x188BABA70")]
		internal void HFDQFWJOUIX(DeliveryMethod a, QLHJIEDDFJH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BADBD0", Offset = "0x8BACBD0", VA = "0x188BADBD0")]
		private void VNKHCJIJJCZ(QLHJIEDDFJH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB240", Offset = "0x8BAA240", VA = "0x188BAB240")]
		private void CRPULSUNPXT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BACC20", Offset = "0x8BABC20", VA = "0x188BACC20")]
		internal ConnectRequestResult MJYTMRSNAEY(XGWMJFDLRJU a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC310", Offset = "0x8BAB310", VA = "0x188BAC310")]
		internal void IPVCIFINUZN(QLHJIEDDFJH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD020", Offset = "0x8BAC020", VA = "0x188BAD020")]
		private void RJXDYEVEZLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BACA10", Offset = "0x8BABA10", VA = "0x188BACA10")]
		internal void LPOHJEIMILB(QLHJIEDDFJH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD4D0", Offset = "0x8BAC4D0", VA = "0x188BAD4D0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB700", Offset = "0x8BAA700", VA = "0x188BAB700")]
		internal void FVZHUEBQXKN(QLHJIEDDFJH a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class ETKWJVLUZCW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long IVPUQJOTJOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long UAHJHHUERDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long BMQYNBUKHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long HAXCEPGDZGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long JVFVQXYAJPG;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long WHCSQFMTFFN;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long LQJYUNHMLLE;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long WMTIDKTESCZ;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long YMNNZYYAYME;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long XAGLKLPAODZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long RNWANIFRVRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long XOYBUOTJUWM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long NINBPJVCIXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF2A0", Offset = "0x8BAE2A0", VA = "0x188BAF2A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long TQGCXGELPFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF7C0", Offset = "0x8BAE7C0", VA = "0x188BAF7C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long WCUZUQYZQLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF810", Offset = "0x8BAE810", VA = "0x188BAF810")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long OZNKTFZYLNU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF380", Offset = "0x8BAE380", VA = "0x188BAF380")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long SBAJLZUKVUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF390", Offset = "0x8BAE390", VA = "0x188BAF390")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long YSTQNCZXRSH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF0C0", Offset = "0x8BAE0C0", VA = "0x188BAF0C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long MKMRZHTREFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF7D0", Offset = "0x8BAE7D0", VA = "0x188BAF7D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long KVJKNYJCKNR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF260", Offset = "0x8BAE260", VA = "0x188BAF260")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality SKKHKRKSLJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1405290", Offset = "0x1404290", VA = "0x181405290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double GILZYAPNRVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8BAF0D0", Offset = "0x8BAE0D0", VA = "0x188BAF0D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF440", Offset = "0x8BAE440", VA = "0x188BAF440")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF200", Offset = "0x8BAE200", VA = "0x188BAF200")]
		public void DSJGFYLGTKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF2B0", Offset = "0x8BAE2B0", VA = "0x188BAF2B0")]
		public void KEABKKYKCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF050", Offset = "0x8BAE050", VA = "0x188BAF050")]
		public void AWKKARIGBRU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF130", Offset = "0x8BAE130", VA = "0x188BAF130")]
		public void CRLSNLNWQHJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF1A0", Offset = "0x8BAE1A0", VA = "0x188BAF1A0")]
		public void DHMYCFZAYXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF300", Offset = "0x8BAE300", VA = "0x188BAF300")]
		public void MWTBSAFWURU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF480", Offset = "0x8BAE480", VA = "0x188BAF480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF3A0", Offset = "0x8BAE3A0", VA = "0x188BAF3A0")]
		public void OKDASTGQHYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ETKWJVLUZCW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class ZOAGRKTNKDM
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> OYLBAVQXVRR;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1350", Offset = "0x8BC0350", VA = "0x188BC1350")]
		public static IPEndPoint XSWMAMKRYWB(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1150", Offset = "0x8BC0150", VA = "0x188BC1150")]
		public static IPAddress CFPMDQOWBZI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8BC10C0", Offset = "0x8BC00C0", VA = "0x188BC10C0")]
		public static IPAddress CFPMDQOWBZI(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1320", Offset = "0x8BC0320", VA = "0x188BC1320")]
		internal static int MOGZVAJWXUC(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4123560", Offset = "0x4122560", VA = "0x184123560")]
		internal static T[] VJAWCZNNZRB<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class UKJJPRGGPQL : GEEVZBNTUVA
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private QLHJIEDDFJH _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC260", Offset = "0x8BBB260", VA = "0x188BBC260", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC240", Offset = "0x8BBB240", VA = "0x188BBC240")]
			public void KWSQHQMQIDG(QLHJIEDDFJH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC1D0", Offset = "0x8BBB1D0", VA = "0x188BBC1D0")]
			public bool IGTUJUULTDP(long a, DLJCDSQXRUR b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC180", Offset = "0x8BBB180", VA = "0x188BBC180")]
			public bool Clear(DLJCDSQXRUR peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly QLHJIEDDFJH UAQDWJOZXHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] KVISSVGKDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly QLHJIEDDFJH[] HVZDGRKTRHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] ZDBBLKJVXFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int PWWQUKRZKIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int RWIGFSNLJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int NUNETYLEJSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int JMZOQLARTVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool MHTIVTKBMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod LJKAEWEKWGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool QKKWQLJVRTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int OWYCLETLCXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte WIPSWNPXPLM;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int KUJHWHDBXDT
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDAD0", Offset = "0x8BBCAD0", VA = "0x188BBDAD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE330", Offset = "0x8BBD330", VA = "0x188BBE330")]
		public UKJJPRGGPQL(DLJCDSQXRUR a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDAE0", Offset = "0x8BBCAE0", VA = "0x188BBDAE0")]
		private void NBGCJNZGJHC(QLHJIEDDFJH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDE60", Offset = "0x8BBCE60", VA = "0x188BBDE60", Slot = "4")]
		protected override bool THAPDNFGGTI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD4D0", Offset = "0x8BBC4D0", VA = "0x188BBD4D0", Slot = "5")]
		public override bool IPVCIFINUZN(QLHJIEDDFJH a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class WIEKQGSJCVW : GEEVZBNTUVA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int LSPWCNOSIZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort RWIGFSNLJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool CVTQVRZCEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private QLHJIEDDFJH FXNZASNFKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly QLHJIEDDFJH XRICTEKVJFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool YOTOEEADTYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte WIPSWNPXPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long WFYLEGBNVAU;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0040", Offset = "0x8BBF040", VA = "0x188BC0040")]
		public WIEKQGSJCVW(DLJCDSQXRUR a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFB80", Offset = "0x8BBEB80", VA = "0x188BBFB80", Slot = "4")]
		protected override bool THAPDNFGGTI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF900", Offset = "0x8BBE900", VA = "0x188BBF900", Slot = "5")]
		public override bool IPVCIFINUZN(QLHJIEDDFJH a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class CPMWRBWKNKV
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
		[Cpp2IlInjected.Address(RVA = "0x8BA9DC0", Offset = "0x8BA8DC0", VA = "0x188BA9DC0")]
		private static void JYAWRWUNPOK(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD20", Offset = "0x8BA9D20", VA = "0x188BAAD20")]
		private static void JYAWRWUNPOK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD90", Offset = "0x8BA9D90", VA = "0x188BAAD90")]
		public static void JYAWRWUNPOK(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE60", Offset = "0x8BA9E60", VA = "0x188BAAE60")]
		public static void WFFJHJZZYTT(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAADE0", Offset = "0x8BA9DE0", VA = "0x188BAADE0")]
		public static void WFFJHJZZYTT(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD90", Offset = "0x8BA9D90", VA = "0x188BAAD90")]
		public static void WFFJHJZZYTT(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD90", Offset = "0x8BA9D90", VA = "0x188BAAD90")]
		public static void WFFJHJZZYTT(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD20", Offset = "0x8BA9D20", VA = "0x188BAAD20")]
		public static void WFFJHJZZYTT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD20", Offset = "0x8BA9D20", VA = "0x188BAAD20")]
		public static void WFFJHJZZYTT(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAADD0", Offset = "0x8BA9DD0", VA = "0x188BAADD0")]
		public static void WFFJHJZZYTT(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8BAADD0", Offset = "0x8BA9DD0", VA = "0x188BAADD0")]
		public static void WFFJHJZZYTT(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class CHUYDYMDEGW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] QYIBHQWZMUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int PVRAQTAWGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int UPNEXXPMDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int VBNLSDTKNTO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] XIFLZTNIIEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DMXWOAKTCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int FSDEWPLJIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA3D0", Offset = "0x8BA93D0", VA = "0x188BAA3D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool WTSNHAWVFNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A24B70", Offset = "0x2A23B70", VA = "0x182A24B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int XVMSEMGCNBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA870", Offset = "0x8BA9870", VA = "0x188BAA870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA490", Offset = "0x8BA9490", VA = "0x188BAA490")]
		public void CPIGZZQGZGL(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public CHUYDYMDEGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAC30", Offset = "0x8BA9C30", VA = "0x188BAAC30")]
		public CHUYDYMDEGW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA4F0", Offset = "0x8BA94F0", VA = "0x188BAA4F0")]
		public IPEndPoint DNFLJRIFZMQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA580", Offset = "0x8BA9580", VA = "0x188BAA580")]
		public byte DXECOQPXXRS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA580", Offset = "0x8BA9580", VA = "0x188BAA580")]
		public sbyte JBZKIUECGDD()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x37E25D0", Offset = "0x37E15D0", VA = "0x1837E25D0")]
		public a[] CJYIQAULZXJ<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA410", Offset = "0x8BA9410", VA = "0x188BAA410")]
		public bool[] BWPQVORCEMX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA930", Offset = "0x8BA9930", VA = "0x188BAA930")]
		public ushort[] VNPCCTDQGOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA690", Offset = "0x8BA9690", VA = "0x188BAA690")]
		public short[] GZLVUYNPYTL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8BAABB0", Offset = "0x8BA9BB0", VA = "0x188BAABB0")]
		public int[] XJBIMZMBBLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA450", Offset = "0x8BA9450", VA = "0x188BAA450")]
		public uint[] BZUIVNIKLEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8BAABF0", Offset = "0x8BA9BF0", VA = "0x188BAABF0")]
		public float[] XVAMHWWNWXP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA830", Offset = "0x8BA9830", VA = "0x188BAA830")]
		public double[] SXWAIOFFPUI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA880", Offset = "0x8BA9880", VA = "0x188BAA880")]
		public long[] ULZUTQZVRCZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA7F0", Offset = "0x8BA97F0", VA = "0x188BAA7F0")]
		public ulong[] QYQQSNMQDCQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA5C0", Offset = "0x8BA95C0", VA = "0x188BAA5C0")]
		public string[] FQEMMPKPGKU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA780", Offset = "0x8BA9780", VA = "0x188BAA780")]
		public bool PEGZFEOFMHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA3A0", Offset = "0x8BA93A0", VA = "0x188BAA3A0")]
		public char RFTDIYKLLES()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA3A0", Offset = "0x8BA93A0", VA = "0x188BAA3A0")]
		public ushort AHCIQKWJYSB()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA3A0", Offset = "0x8BA93A0", VA = "0x188BAA3A0")]
		public short CWHLTWQRFAQ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA3E0", Offset = "0x8BA93E0", VA = "0x188BAA3E0")]
		public long PQUJDWAAURK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA3E0", Offset = "0x8BA93E0", VA = "0x188BAA3E0")]
		public ulong BMWIXAKSHHZ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA6D0", Offset = "0x8BA96D0", VA = "0x188BAA6D0")]
		public int HEGGQMNWZNN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA6D0", Offset = "0x8BA96D0", VA = "0x188BAA6D0")]
		public uint NSEXMMBLVRQ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAB80", Offset = "0x8BA9B80", VA = "0x188BAAB80")]
		public float WTAFFBTDVKI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA7C0", Offset = "0x8BA97C0", VA = "0x188BAA7C0")]
		public double QUIQTHYZGST()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA970", Offset = "0x8BA9970", VA = "0x188BAA970")]
		public string VVQXIZVIFOD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA8C0", Offset = "0x8BA98C0", VA = "0x188BAA8C0")]
		public ArraySegment<byte> UUJRWZLIOUS(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA740", Offset = "0x8BA9740", VA = "0x188BAA740")]
		public sbyte[] IMWPEKUWQRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA700", Offset = "0x8BA9700", VA = "0x188BAA700")]
		public byte[] IGRLDEOJLER()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA4D0", Offset = "0x8BA94D0", VA = "0x188BAA4D0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class PSDTXBWHJBY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] QYIBHQWZMUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int PVRAQTAWGGM;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int PUNUYYIGTPB = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool CLINKYAKHNS;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding OVESZGNMEAE;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int WGFCMXUVHVL = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] URPSXHZTWAQ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] YTUTJGBWUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int HEJIPADGNQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC0A0", Offset = "0x8BBB0A0", VA = "0x188BBC0A0")]
		public PSDTXBWHJBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC000", Offset = "0x8BBB000", VA = "0x188BBC000")]
		public PSDTXBWHJBY(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBF10", Offset = "0x8BBAF10", VA = "0x188BBBF10")]
		public static PSDTXBWHJBY WFCXPSQPTGD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBE70", Offset = "0x8BBAE70", VA = "0x188BBBE70")]
		public void RXSNNICWNPT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D510", Offset = "0x2A9C510", VA = "0x182A9D510")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB390", Offset = "0x8BBA390", VA = "0x188BBB390")]
		public void AEAYAFEFJPZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB430", Offset = "0x8BBA430", VA = "0x188BBB430")]
		public void AEAYAFEFJPZ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB2E0", Offset = "0x8BBA2E0", VA = "0x188BBB2E0")]
		public void AEAYAFEFJPZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB2E0", Offset = "0x8BBA2E0", VA = "0x188BBB2E0")]
		public void AEAYAFEFJPZ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB4F0", Offset = "0x8BBA4F0", VA = "0x188BBB4F0")]
		public void AEAYAFEFJPZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB4F0", Offset = "0x8BBA4F0", VA = "0x188BBB4F0")]
		public void AEAYAFEFJPZ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB580", Offset = "0x8BBA580", VA = "0x188BBB580")]
		public void AEAYAFEFJPZ(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB580", Offset = "0x8BBA580", VA = "0x188BBB580")]
		public void AEAYAFEFJPZ(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB580", Offset = "0x8BBA580", VA = "0x188BBB580")]
		public void AEAYAFEFJPZ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB800", Offset = "0x8BBA800", VA = "0x188BBB800")]
		public void AEAYAFEFJPZ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB800", Offset = "0x8BBA800", VA = "0x188BBB800")]
		public void AEAYAFEFJPZ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB480", Offset = "0x8BBA480", VA = "0x188BBB480")]
		public void AEAYAFEFJPZ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBD90", Offset = "0x8BBAD90", VA = "0x188BBBD90")]
		public void MYYXQOCPZQX(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBD90", Offset = "0x8BBAD90", VA = "0x188BBBD90")]
		public void TLAKBZIJQFU(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB330", Offset = "0x8BBA330", VA = "0x188BBB330")]
		public void AEAYAFEFJPZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBBE0", Offset = "0x8BBABE0", VA = "0x188BBBBE0")]
		public void MHVCEPFLRPO(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBB00", Offset = "0x8BBAB00", VA = "0x188BBBB00")]
		public void MHVCEPFLRPO(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBA20", Offset = "0x8BBAA20", VA = "0x188BBBA20")]
		public void MHVCEPFLRPO(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBA20", Offset = "0x8BBAA20", VA = "0x188BBBA20")]
		public void MHVCEPFLRPO(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBA20", Offset = "0x8BBAA20", VA = "0x188BBBA20")]
		public void MHVCEPFLRPO(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBB00", Offset = "0x8BBAB00", VA = "0x188BBBB00")]
		public void MHVCEPFLRPO(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBB00", Offset = "0x8BBAB00", VA = "0x188BBBB00")]
		public void MHVCEPFLRPO(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB940", Offset = "0x8BBA940", VA = "0x188BBB940")]
		public void MHVCEPFLRPO(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB940", Offset = "0x8BBA940", VA = "0x188BBB940")]
		public void MHVCEPFLRPO(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBD90", Offset = "0x8BBAD90", VA = "0x188BBBD90")]
		public void MHVCEPFLRPO(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBCC0", Offset = "0x8BBACC0", VA = "0x188BBBCC0")]
		public void MHVCEPFLRPO(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB860", Offset = "0x8BBA860", VA = "0x188BBB860")]
		public void AEAYAFEFJPZ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB930", Offset = "0x8BBA930", VA = "0x188BBB930")]
		public void AEAYAFEFJPZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB5F0", Offset = "0x8BBA5F0", VA = "0x188BBB5F0")]
		public void AEAYAFEFJPZ(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class GPSPEJPARVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class CYXBRPBCJWT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong OSRJHZIEHJN;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x508FA00", Offset = "0x508EA00", VA = "0x18508FA00")]
			static CYXBRPBCJWT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(CHUYDYMDEGW reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class XJWKYGPJFOI<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public GPSPEJPARVJ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a CPDYBAAMUWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> OAXWVPCGNEQ;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public XJWKYGPJFOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x50C1BF0", Offset = "0x50C0BF0", VA = "0x1850C1BF0")]
			internal void GOOCXQTBJIT(CHUYDYMDEGW a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class JBGOKVNLVAI<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public GPSPEJPARVJ NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a CPDYBAAMUWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> OAXWVPCGNEQ;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public JBGOKVNLVAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x66F00D0", Offset = "0x66EF0D0", VA = "0x1866F00D0")]
			internal void GOOCXQTBJIT(CHUYDYMDEGW a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly CMLYRETJEXP QGYJPPRNXWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> HBWYYTFKGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly PSDTXBWHJBY HZVWFTNAJUN;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFFC0", Offset = "0x8BAEFC0", VA = "0x188BAFFC0")]
		public GPSPEJPARVJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE74A0", Offset = "0x3AE64A0", VA = "0x183AE74A0", Slot = "4")]
		protected virtual ulong KYYXNYCBDKW<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFE20", Offset = "0x8BAEE20", VA = "0x188BAFE20", Slot = "5")]
		protected virtual SubscribeDelegate NSGVHMWOSIF(CHUYDYMDEGW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7420", Offset = "0x3AE6420", VA = "0x183AE7420", Slot = "6")]
		protected virtual void JSQZCVTREGR<b>(PSDTXBWHJBY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF40", Offset = "0x8BAEF40", VA = "0x188BAFF40")]
		public void ZFFBBCDKJMK(CHUYDYMDEGW a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7520", Offset = "0x3AE6520", VA = "0x183AE7520")]
		public void NTXNIJJJHYF<j>(PSDTXBWHJBY a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFEF0", Offset = "0x8BAEEF0", VA = "0x188BAFEF0")]
		public void XAVBOLBVVZY(CHUYDYMDEGW a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7730", Offset = "0x3AE6730", VA = "0x183AE7730")]
		public void PHWTNJKWQVR<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7730", Offset = "0x3AE6730", VA = "0x183AE7730")]
		public void PHWTNJKWQVR<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0110", Offset = "0x8BAF110", VA = "0x188BB0110")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC120", Offset = "0x8BBB120", VA = "0x188BBC120")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class CMLYRETJEXP
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
		private abstract class SWCLNYMNGST<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType AHRPWOVSMCK;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x7ACBB70", Offset = "0x7ACAB70", VA = "0x187ACBB70", Slot = "4")]
			public virtual void KWSQHQMQIDG(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void IOACUTWBTGW(a a, CHUYDYMDEGW b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void NTXNIJJJHYF(a a, PSDTXBWHJBY b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void TURSFKTXYAH(a a, CHUYDYMDEGW b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void DDBHMSDJDMW(a a, PSDTXBWHJBY b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void HJUEEVJVJNE(a a, CHUYDYMDEGW b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void QUSBMWRKLIZ(a a, PSDTXBWHJBY b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			protected SWCLNYMNGST()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class YYDDRCRIPFU<a, b> : SWCLNYMNGST<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> FECMQVSDLUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> VPLRSBWTNMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> QGFLZNSXORW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> VRWOOQFIPIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> UVNVJMYLVHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> XIOEECVKLIB;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5133630", Offset = "0x5132630", VA = "0x185133630", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5133630", Offset = "0x5132630", VA = "0x185133630", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5133B30", Offset = "0x5132B30", VA = "0x185133B30", Slot = "9")]
			public override void HJUEEVJVJNE(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5133B30", Offset = "0x5132B30", VA = "0x185133B30", Slot = "10")]
			public override void QUSBMWRKLIZ(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5133700", Offset = "0x5132700", VA = "0x185133700")]
			protected b[] DUOHDIGAJLJ(a a, CHUYDYMDEGW b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x51339C0", Offset = "0x51329C0", VA = "0x1851339C0")]
			protected b[] GJBEQORSUYG(a a, PSDTXBWHJBY b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5133C00", Offset = "0x5132C00", VA = "0x185133C00", Slot = "4")]
			public override void KWSQHQMQIDG(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5134740", Offset = "0x5133740", VA = "0x185134740")]
			protected YYDDRCRIPFU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class SDXSMYWUHCZ<a, b> : YYDDRCRIPFU<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void QAJIXBPEEIO(CHUYDYMDEGW a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void YPVJSWGIDCB(PSDTXBWHJBY a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x7AB75B0", Offset = "0x7AB65B0", VA = "0x187AB75B0", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7680", Offset = "0x7AB6680", VA = "0x187AB7680", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7AB78D0", Offset = "0x7AB68D0", VA = "0x187AB78D0", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7160", Offset = "0x7AB6160", VA = "0x187AB7160", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7B90", Offset = "0x7AB6B90", VA = "0x187AB7B90")]
			protected SDXSMYWUHCZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class UUKXCNBNEUA<a> : YYDDRCRIPFU<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7F00B00", Offset = "0x7EFFB00", VA = "0x187F00B00", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7F00C70", Offset = "0x7EFFC70", VA = "0x187F00C70", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7F20A00", Offset = "0x7F1FA00", VA = "0x187F20A00", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6979910", Offset = "0x6978910", VA = "0x186979910", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public UUKXCNBNEUA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class UASGXUIYSVP<a> : YYDDRCRIPFU<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x7F00B00", Offset = "0x7EFFB00", VA = "0x187F00B00", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7F00C70", Offset = "0x7EFFC70", VA = "0x187F00C70", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7F00EB0", Offset = "0x7EFFEB0", VA = "0x187F00EB0", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x6979910", Offset = "0x6978910", VA = "0x186979910", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public UASGXUIYSVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class NRNGPPFEGWD<a> : YYDDRCRIPFU<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4F21290", Offset = "0x4F20290", VA = "0x184F21290", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4F213F0", Offset = "0x4F203F0", VA = "0x184F213F0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x72987F0", Offset = "0x72977F0", VA = "0x1872987F0", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4F21010", Offset = "0x4F20010", VA = "0x184F21010", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public NRNGPPFEGWD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class BUEIMKULXYG<a> : YYDDRCRIPFU<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4F21290", Offset = "0x4F20290", VA = "0x184F21290", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x4F213F0", Offset = "0x4F203F0", VA = "0x184F213F0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4F21430", Offset = "0x4F20430", VA = "0x184F21430", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4F21010", Offset = "0x4F20010", VA = "0x184F21010", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public BUEIMKULXYG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class GTDMVKJBSST<a> : YYDDRCRIPFU<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x645F490", Offset = "0x645E490", VA = "0x18645F490", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x645F5F0", Offset = "0x645E5F0", VA = "0x18645F5F0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x645F630", Offset = "0x645E630", VA = "0x18645F630", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x645F330", Offset = "0x645E330", VA = "0x18645F330", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public GTDMVKJBSST()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class QGLYMLTJBSQ<a> : YYDDRCRIPFU<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x645F490", Offset = "0x645E490", VA = "0x18645F490", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x645F5F0", Offset = "0x645E5F0", VA = "0x18645F5F0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7787C60", Offset = "0x7786C60", VA = "0x187787C60", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x645F330", Offset = "0x645E330", VA = "0x18645F330", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public QGLYMLTJBSQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class TBPQHYAPLBN<a> : YYDDRCRIPFU<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0A70", Offset = "0x7ABFA70", VA = "0x187AC0A70", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0BE0", Offset = "0x7ABFBE0", VA = "0x187AC0BE0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x7C47390", Offset = "0x7C46390", VA = "0x187C47390", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0A30", Offset = "0x7ABFA30", VA = "0x187AC0A30", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public TBPQHYAPLBN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class SNHFPUCHEHA<a> : YYDDRCRIPFU<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0A70", Offset = "0x7ABFA70", VA = "0x187AC0A70", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0BE0", Offset = "0x7ABFBE0", VA = "0x187AC0BE0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0E30", Offset = "0x7ABFE30", VA = "0x187AC0E30", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0A30", Offset = "0x7ABFA30", VA = "0x187AC0A30", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public SNHFPUCHEHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class LWOJMQQAENJ<a> : YYDDRCRIPFU<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x6979950", Offset = "0x6978950", VA = "0x186979950", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x6979BD0", Offset = "0x6978BD0", VA = "0x186979BD0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6979D10", Offset = "0x6978D10", VA = "0x186979D10", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x6979910", Offset = "0x6978910", VA = "0x186979910", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public LWOJMQQAENJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class IXIBTBWOLUI<a> : YYDDRCRIPFU<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x66249F0", Offset = "0x66239F0", VA = "0x1866249F0", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x6624B50", Offset = "0x6623B50", VA = "0x186624B50", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x6624B90", Offset = "0x6623B90", VA = "0x186624B90", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x645F330", Offset = "0x645E330", VA = "0x18645F330", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public IXIBTBWOLUI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class TXSGKUBPKVH<a> : YYDDRCRIPFU<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F660", Offset = "0x7C5E660", VA = "0x187C5F660", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F8E0", Offset = "0x7C5E8E0", VA = "0x187C5F8E0", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F920", Offset = "0x7C5E920", VA = "0x187C5F920", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0A30", Offset = "0x7ABFA30", VA = "0x187AC0A30", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x4F21580", Offset = "0x4F20580", VA = "0x184F21580")]
			public TXSGKUBPKVH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class KMNMRGOLZRD<a> : SDXSMYWUHCZ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6864580", Offset = "0x6863580", VA = "0x186864580", Slot = "12")]
			protected override void YPVJSWGIDCB(PSDTXBWHJBY a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6864550", Offset = "0x6863550", VA = "0x186864550", Slot = "11")]
			protected override void QAJIXBPEEIO(CHUYDYMDEGW a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x68645B0", Offset = "0x68635B0", VA = "0x1868645B0")]
			public KMNMRGOLZRD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class QWBDJATSEDL<a> : SDXSMYWUHCZ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x77EDC50", Offset = "0x77ECC50", VA = "0x1877EDC50", Slot = "12")]
			protected override void YPVJSWGIDCB(PSDTXBWHJBY a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x77EDC10", Offset = "0x77ECC10", VA = "0x1877EDC10", Slot = "11")]
			protected override void QAJIXBPEEIO(CHUYDYMDEGW a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x68645B0", Offset = "0x68635B0", VA = "0x1868645B0")]
			public QWBDJATSEDL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class VWTMCVNRAPS<a> : YYDDRCRIPFU<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int GVQWIMSKGRB;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x802CD40", Offset = "0x802BD40", VA = "0x18802CD40")]
			public VWTMCVNRAPS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x802CA00", Offset = "0x802BA00", VA = "0x18802CA00", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x802CB70", Offset = "0x802BB70", VA = "0x18802CB70", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x802CCE0", Offset = "0x802BCE0", VA = "0x18802CCE0", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x802C780", Offset = "0x802B780", VA = "0x18802C780", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class XQIHCTARNWO<a> : SWCLNYMNGST<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo MDSBKMJCRCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type BCODOJKRTLR;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x50C6480", Offset = "0x50C5480", VA = "0x1850C6480")]
			public XQIHCTARNWO(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x50C6110", Offset = "0x50C5110", VA = "0x1850C6110", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x50C6400", Offset = "0x50C5400", VA = "0x1850C6400", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x50C6070", Offset = "0x50C5070", VA = "0x1850C6070", Slot = "7")]
			public override void TURSFKTXYAH(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x50C6070", Offset = "0x50C5070", VA = "0x1850C6070", Slot = "8")]
			public override void DDBHMSDJDMW(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x50C60C0", Offset = "0x50C50C0", VA = "0x1850C60C0", Slot = "9")]
			public override void HJUEEVJVJNE(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x50C60C0", Offset = "0x50C50C0", VA = "0x1850C60C0", Slot = "10")]
			public override void QUSBMWRKLIZ(a a, PSDTXBWHJBY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class OEBIPBCOPXN<a> : XQIHCTARNWO<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x73E7930", Offset = "0x73E6930", VA = "0x1873E7930")]
			public OEBIPBCOPXN(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x73E76F0", Offset = "0x73E66F0", VA = "0x1873E76F0", Slot = "5")]
			public override void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x73E7790", Offset = "0x73E6790", VA = "0x1873E7790", Slot = "6")]
			public override void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class VGOPJEGOWJP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static VGOPJEGOWJP<a> CIARLSLMHCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly SWCLNYMNGST<a>[] FGUTMKYTUWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int CYQXJOTRVSF;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x801E560", Offset = "0x801D560", VA = "0x18801E560")]
			public VGOPJEGOWJP(List<SWCLNYMNGST<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x801E4B0", Offset = "0x801D4B0", VA = "0x18801E4B0")]
			public void NTXNIJJJHYF(a a, PSDTXBWHJBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x801E250", Offset = "0x801D250", VA = "0x18801E250")]
			public void IOACUTWBTGW(a a, CHUYDYMDEGW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class JGSGQKZNBRX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract SWCLNYMNGST<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PSDTXBWHJBY YYESHBFXSOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int RYXTODSOMUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, JGSGQKZNBRX> XMRCHEKQQAU;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAC90", Offset = "0x8BA9C90", VA = "0x188BAAC90")]
		public CMLYRETJEXP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x37E49B0", Offset = "0x37E39B0", VA = "0x1837E49B0")]
		private VGOPJEGOWJP<d> FXFXBAJMFBA<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x37E5780", Offset = "0x37E4780", VA = "0x1837E5780")]
		public void OTSRDIPIITJ<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x37E3B00", Offset = "0x37E2B00", VA = "0x1837E3B00")]
		public bool Deserialize<T>(CHUYDYMDEGW reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x37E3A80", Offset = "0x37E2A80", VA = "0x1837E3A80")]
		public void BIDIANLANQI<f>(PSDTXBWHJBY a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class VZEAPHVKDOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime YBRBOTVLRJR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] MONUJJNAUAV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator YFTZRUOBXPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE7B0", Offset = "0x8BBD7B0", VA = "0x188BBE7B0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int ONLOMXZJQLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE780", Offset = "0x8BBD780", VA = "0x188BBE780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEAF0", Offset = "0x8BBDAF0", VA = "0x188BBEAF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode PMVUTXWAKMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEC10", Offset = "0x8BBDC10", VA = "0x188BBEC10")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF3A0", Offset = "0x8BBE3A0", VA = "0x188BBF3A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int PMNFLMXBMGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE840", Offset = "0x8BBD840", VA = "0x188BBE840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint BWZZWOKGCBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE7E0", Offset = "0x8BBD7E0", VA = "0x188BBE7E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? NRKNBOQAUZO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEE30", Offset = "0x8BBDE30", VA = "0x188BBEE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? TSFNCYYTVBT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEE00", Offset = "0x8BBDE00", VA = "0x188BBEE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? HOAVVAPKIYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEBE0", Offset = "0x8BBDBE0", VA = "0x188BBEBE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEC40", Offset = "0x8BBDC40", VA = "0x188BBEC40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? FURJXAOBKIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF713E0", Offset = "0xF703E0", VA = "0x180F713E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF550", Offset = "0x8BBE550", VA = "0x188BBF550")]
		public VZEAPHVKDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF860", Offset = "0x8BBE860", VA = "0x188BBF860")]
		internal VZEAPHVKDOE(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF3E0", Offset = "0x8BBE3E0", VA = "0x188BBF3E0")]
		public static VZEAPHVKDOE YRFVHTPZFGO(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEE60", Offset = "0x8BBDE60", VA = "0x188BBEE60")]
		internal void WLGBKHWSEWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE930", Offset = "0x8BBD930", VA = "0x188BBE930")]
		private void HMOTEJRISSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE550", Offset = "0x8BBD550", VA = "0x188BBE550")]
		private DateTime? AJDOONMSJPL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF1E0", Offset = "0x8BBE1E0", VA = "0x188BBF1E0")]
		private void XJDSBGGEKNH(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEB30", Offset = "0x8BBDB30", VA = "0x188BBEB30")]
		private ulong IHOICUXMPOF(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE870", Offset = "0x8BBD870", VA = "0x188BBE870")]
		private void GZQTQMWFIIB(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE720", Offset = "0x8BBD720", VA = "0x188BBE720")]
		private uint CCDBQLAGRCG(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8A75750", Offset = "0x8A74750", VA = "0x188A75750")]
		private static uint ADFWQUCYUZD(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE4F0", Offset = "0x8BBD4F0", VA = "0x188BBE4F0")]
		private static ulong ADFWQUCYUZD(ulong a)
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
	internal sealed class ZSNOZOLCHWF
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int TYDCQPZADLY = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int GQSFCDZEOVJ = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int YAUQDTJMWXO = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint PZSFMKFNGSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int LKIJOUKYBWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int MCWQACNICBI;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool SKCKUJPYDDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1700", Offset = "0x8BC0700", VA = "0x188BC1700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1710", Offset = "0x8BC0710", VA = "0x188BC1710")]
		public bool XUCKBZLJPRG(RHABTQGJSIM a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class JTMXFHVHAHP : RHABTQGJSIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket OHQLZOLKPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly KXSRENACLRK NIPGWLYENFK;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short KWJUJHDWVEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0850", Offset = "0x8BAF850", VA = "0x188BB0850", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int HKRYOFLMIYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0870", Offset = "0x8BAF870", VA = "0x188BB0870", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint CMUFGCCRSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0700", Offset = "0x8BAF700", VA = "0x188BB0700", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily WYUYNRMSNOC
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32BA160", Offset = "0x32B9160", VA = "0x1832BA160", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0890", Offset = "0x8BAF890", VA = "0x188BB0890")]
		public JTMXFHVHAHP(AddressFamily a, KXSRENACLRK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0120", Offset = "0x8BAF120", VA = "0x188BB0120", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0720", Offset = "0x8BAF720", VA = "0x188BB0720", Slot = "9")]
		public int KFJFYLWYWFD(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0760", Offset = "0x8BAF760", VA = "0x188BB0760", Slot = "10")]
		public int PTBOQRPBEQT(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB06E0", Offset = "0x8BAF6E0", VA = "0x188BB06E0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface RHABTQGJSIM
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short KWJUJHDWVEK
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int HKRYOFLMIYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint CMUFGCCRSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily WYUYNRMSNOC
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
		int KFJFYLWYWFD(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int PTBOQRPBEQT(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x8BBAF70", Offset = "0x8BB9F70", VA = "0x188BBAF70")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB010", Offset = "0x8BBA010", VA = "0x188BBB010")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x162DF80", Offset = "0x162CF80", VA = "0x18162DF80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAE80", Offset = "0x8BB9E80", VA = "0x188BBAE80", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAEC0", Offset = "0x8BB9EC0", VA = "0x188BBAEC0", Slot = "0")]
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
	public class UXRYZPMLTSR
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string XOKTIJJFAAV = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int ERWWCFPYKOP = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int VBZTNKEVRPP = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int FDBPGNSUCCV = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> UTXTLDKQCEQ;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback JQCKXNAZSZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int AZKYXCMLXTV;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		internal void EZMZDKGOQMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		internal void GTCXOQPAFUP(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class JLMOQSOLKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int XQSJNMABVAJ;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
		protected JLMOQSOLKHA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void XTBGGMWCQUI(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void GVDBOFPQQDZ(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class KHDOKQWLOVM : JLMOQSOLKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] QMCRYWZIPRP;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator FHIYUORIZQX;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2B10", Offset = "0x2BA1B10", VA = "0x182BA2B10")]
		public KHDOKQWLOVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0DE0", Offset = "0x8BAFDE0", VA = "0x188BB0DE0")]
		public void CUGFXBZJWXO(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1290", Offset = "0x8BB0290", VA = "0x188BB1290")]
		public void NLJJXYYUVLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1370", Offset = "0x8BB0370", VA = "0x188BB1370", Slot = "4")]
		public override void XTBGGMWCQUI(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0F90", Offset = "0x8BAFF90", VA = "0x188BB0F90", Slot = "5")]
		public override void GVDBOFPQQDZ(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class PMUKWUJJDPP
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr OYVNOJMATZB;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1C90", Offset = "0x8BC0C90", VA = "0x188BC1C90")]
			[BurstDiscard]
			private static void VQLJAOSQKFB(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8BC1B10", Offset = "0x8BC0B10", VA = "0x188BC1B10")]
			private static IntPtr NDKIKLNRHSP()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8BC18C0", Offset = "0x8BC08C0", VA = "0x188BC18C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BBD270", Offset = "0x8BBC270", VA = "0x188BBD270")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD180", Offset = "0x8BBC180", VA = "0x188BBD180")]
		private uint NVOAGSHUIUQ(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA050", Offset = "0x8BA9050", VA = "0x188BAA050")]
		private void LAUPFXXIYLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA190", Offset = "0x8BA9190", VA = "0x188BAA190")]
		private void OTBKPBHDWFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA100", Offset = "0x8BA9100", VA = "0x188BAA100")]
		private void NHAGRIWEAHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9F50", Offset = "0x8BA8F50", VA = "0x188BA9F50")]
		private void JPYEVSLVNHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD2F0", Offset = "0x8BBC2F0", VA = "0x188BBD2F0")]
		private void SSIHYUTNIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC40", Offset = "0x8BBBC40", VA = "0x188BBCC40")]
		private unsafe void BPHVOESJKTA(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD260", Offset = "0x8BBC260", VA = "0x188BBD260")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void NWJLQEYOIXB([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD1B0", Offset = "0x8BBC1B0", VA = "0x188BBD1B0")]
		public static void NWJLQEYOIXB(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD060", Offset = "0x8BBC060", VA = "0x188BBD060")]
		public static void COBGGHAAJXR(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD110", Offset = "0x8BBC110", VA = "0x188BBD110")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void ESESZSEFQZM([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1E20", Offset = "0x8BC0E20", VA = "0x188BC1E20")]
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
