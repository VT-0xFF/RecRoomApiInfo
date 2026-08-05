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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BSEYNCLTXZE
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
		private NetworkManager LTCVTTUQQAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool OBZXKYXPGEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, IPVPWOIISBV> HZHJIAWQOER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMHXHVBCZNI TDAHOSHZJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch FAHRNBBLQYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] WRBOFSXPIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType NAAWVNOUTOO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int QPTNRYISFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7687430", Offset = "0x7686630", VA = "0x187687430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x76873E0", Offset = "0x76865E0", VA = "0x1876873E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7686760", Offset = "0x7685960", VA = "0x187686760")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7686740", Offset = "0x7685940", VA = "0x187686740")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7686480", Offset = "0x7685680", VA = "0x187686480")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76870F0", Offset = "0x76862F0", VA = "0x1876870F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7686870", Offset = "0x7685A70", VA = "0x187686870", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7686630", Offset = "0x7685830", VA = "0x187686630", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7686B40", Offset = "0x7685D40", VA = "0x187686B40", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7686ED0", Offset = "0x76860D0", VA = "0x187686ED0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7685EF0", Offset = "0x76850F0", VA = "0x187685EF0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7685E00", Offset = "0x7685000", VA = "0x187685E00", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7686050", Offset = "0x7685250", VA = "0x187686050", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7686AD0", Offset = "0x7685CD0", VA = "0x187686AD0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7686120", Offset = "0x7685320", VA = "0x187686120", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7686670", Offset = "0x7685870", VA = "0x187686670")]
		private DeliveryMethod QENQUSOYZWL(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7686570", Offset = "0x7685770", VA = "0x187686570", Slot = "16")]
		private void PXVCQCUPECQ(IPVPWOIISBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7685D30", Offset = "0x7684F30", VA = "0x187685D30", Slot = "17")]
		private void CUXVKNRPXTU(IPVPWOIISBV a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "18")]
		private void MWDTYUNGHMF(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7687110", Offset = "0x7686310", VA = "0x187687110", Slot = "19")]
		private void YZXQCXUJHDY(IPVPWOIISBV a, ZPMJQCJYVLK b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76863B0", Offset = "0x76855B0", VA = "0x1876863B0")]
		private void MPDZGAABDQF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "20")]
		private void JXJJILGUNYQ(IPEndPoint a, ZPMJQCJYVLK b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "21")]
		private void ZEDUUTLPPUU(IPVPWOIISBV a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7686350", Offset = "0x7685550", VA = "0x187686350", Slot = "22")]
		private void KZUQPDKSQDY(GIYNCBDFWQV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7686000", Offset = "0x7685200", VA = "0x187686000")]
		private ulong FPJVJLCUYAJ(IPVPWOIISBV a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7686030", Offset = "0x7685230", VA = "0x187686030")]
		private ulong FPJVJLCUYAJ(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7686330", Offset = "0x7685530", VA = "0x187686330")]
		private static int JCONTQNHALA(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7687310", Offset = "0x7686510", VA = "0x187687310")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76860F0", Offset = "0x76852F0", VA = "0x1876860F0")]
		[CompilerGenerated]
		private void HGWMODGQMLI(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76860F0", Offset = "0x76852F0", VA = "0x1876860F0")]
		[CompilerGenerated]
		private void HEYHSRXVKMD(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class TMOUEFZOAYA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly IPVPWOIISBV VBDTLSLNRSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<DUTKSUWQYTV> HJDEKMKVSQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int UBTCDZIBDQI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TIDOETFLOPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x768C8D0", Offset = "0x768BAD0", VA = "0x18768C8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x768C920", Offset = "0x768BB20", VA = "0x18768C920")]
		protected TMOUEFZOAYA(IPVPWOIISBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x768C870", Offset = "0x768BA70", VA = "0x18768C870")]
		public void NNSDXXFXEXX(DUTKSUWQYTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x768C7F0", Offset = "0x768B9F0", VA = "0x18768C7F0")]
		protected void JKPGSEHRUTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x768C7B0", Offset = "0x768B9B0", VA = "0x18768C7B0")]
		public bool HRGGYONTSTK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool TZJVVCBUOOU();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool KGAGQCBAXDD(DUTKSUWQYTV a);
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
	public class GIYNCBDFWQV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly IMHXHVBCZNI HOWIXQCQNFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int LGIWOIUJSSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal RCOSVVUOYGQ CLENVLRRUDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint IKIJWYHPPQL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult FXBUWGBYQBL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x13CE310", Offset = "0x13CD510", VA = "0x1813CE310")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x13CE320", Offset = "0x13CD520", VA = "0x1813CE320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7678FE0", Offset = "0x76781E0", VA = "0x187678FE0")]
		internal void VJVSGZNQATM(RCOSVVUOYGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7678FB0", Offset = "0x76781B0", VA = "0x187678FB0")]
		private bool NQUJDPKDDGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7679040", Offset = "0x7678240", VA = "0x187679040")]
		internal GIYNCBDFWQV(IPEndPoint a, RCOSVVUOYGQ b, IMHXHVBCZNI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7678F50", Offset = "0x7678150", VA = "0x187678F50")]
		public IPVPWOIISBV Accept()
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
		public ZPMJQCJYVLK AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface BSEYNCLTXZE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WHFBIUHNMKI(IPVPWOIISBV a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OIJBBWEFEDI(IPVPWOIISBV a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DJASEXVGCDL(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HLFTOHYBHBU(IPVPWOIISBV a, ZPMJQCJYVLK b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LQWZCDQBTEQ(IPEndPoint a, ZPMJQCJYVLK b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QTSQRVVXLTG(IPVPWOIISBV a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VXNFYEYAAJE(GIYNCBDFWQV a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ICHJNNHAPWR
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KRVJEJFXEFS(IPVPWOIISBV a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KEYEYRGJWPT
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JNYCHHXJVYK(MRHYJPNMRHA a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface LJTEQGRFNZF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OWALVHSWVHL(IPVPWOIISBV a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class RCOSVVUOYGQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int JEBMCCRASJG = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long FLVOVTCPQHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte JETOMRHBPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] QTDNNHMZXEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly RGTCMRPSEUI KHVUALCSJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int OPBAVOOHLFX;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7689EF0", Offset = "0x76890F0", VA = "0x187689EF0")]
		private RCOSVVUOYGQ(long a, byte b, int c, byte[] d, RGTCMRPSEUI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7689CD0", Offset = "0x7688ED0", VA = "0x187689CD0")]
		public static int VAOOGCKQBJT(DUTKSUWQYTV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7689D00", Offset = "0x7688F00", VA = "0x187689D00")]
		public static RCOSVVUOYGQ YKICYXLZAMM(DUTKSUWQYTV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7689AF0", Offset = "0x7688CF0", VA = "0x187689AF0")]
		public static DUTKSUWQYTV BVHQUGHWWAO(VESMYXPXZQE a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class VOHVGUHOGWH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long FLVOVTCPQHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte JETOMRHBPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int OPBAVOOHLFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool WBIWZJHATRM;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x768E460", Offset = "0x768D660", VA = "0x18768E460")]
		private VOHVGUHOGWH(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x768E360", Offset = "0x768D560", VA = "0x18768E360")]
		public static VOHVGUHOGWH YKICYXLZAMM(DUTKSUWQYTV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x768E170", Offset = "0x768D370", VA = "0x18768E170")]
		public static DUTKSUWQYTV BVHQUGHWWAO(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x768E260", Offset = "0x768D460", VA = "0x18768E260")]
		public static DUTKSUWQYTV TRDDLOVTQNW(IPVPWOIISBV a)
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
	public interface FALBCVINSAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WHNWYQEFTCR(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ASUCBOOFORB(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class ZSPNLUOLMHX
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
		private class JNDTOYJCQCR
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint CNTXWPLCUTX
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string QUPIPULDKDL
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public JNDTOYJCQCR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class CGKNIKOYCWP
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint CNTXWPLCUTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint GZZOMXDZXHR
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string QUPIPULDKDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public CGKNIKOYCWP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class GHADWCZGUSF
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string QUPIPULDKDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool QARTCDCHZQH
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xC56780", Offset = "0xC55980", VA = "0x180C56780")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xABAEE0", Offset = "0xABA0E0", VA = "0x180ABAEE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public GHADWCZGUSF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly IMHXHVBCZNI GAQMMYMPZMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> GAVNDCJKETN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> XOIDRNBELFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly RGTCMRPSEUI YXJJSLYEDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly VESMYXPXZQE WPTGPLNTCVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly JLPVZMGYCTP HQPXOVJEOIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FALBCVINSAG PGYMVMXDTTG;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int DYNTIQDUFED = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool YJJEKXPIAAA;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x768ECA0", Offset = "0x768DEA0", VA = "0x18768ECA0")]
		internal ZSPNLUOLMHX(IMHXHVBCZNI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x768EB20", Offset = "0x768DD20", VA = "0x18768EB20")]
		internal void WJLYEKBWZIE(IPEndPoint a, DUTKSUWQYTV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FB50", Offset = "0x3C5ED50", VA = "0x183C5FB50")]
		private void TOQDSZVOJWS<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x768E9A0", Offset = "0x768DBA0", VA = "0x18768E9A0")]
		private void WHNWYQEFTCR(JNDTOYJCQCR a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x768E6B0", Offset = "0x768D8B0", VA = "0x18768E6B0")]
		private void CLRXXKSEUIH(CGKNIKOYCWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x768E810", Offset = "0x768DA10", VA = "0x18768E810")]
		private void GWQRVZEMYEU(GHADWCZGUSF a, IPEndPoint b)
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
	public static class DSPLMSZBUZO
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] ONPVGPSVCBD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int JLBYBYNRLXB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int FKBOVOGYMVU;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7685930", Offset = "0x7684B30", VA = "0x187685930")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7685930", Offset = "0x7684B30", VA = "0x187685930")]
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
	public interface ODCRZFTWGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DPIBRLZASWK(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class MDXRRCZZTNQ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static ODCRZFTWGAG URRJTBSVKII;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object KQOUAZRTVFG;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7687600", Offset = "0x7686800", VA = "0x187687600")]
		private static void FIGHINVGDBZ(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76875A0", Offset = "0x76867A0", VA = "0x1876875A0")]
		internal static void DPDAIWAVEVJ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7687890", Offset = "0x7686A90", VA = "0x187687890")]
		internal static void NZVPMKYAGMN(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7687830", Offset = "0x7686A30", VA = "0x187687830")]
		internal static void KNCPPSRZLHZ(string a, params object[] args)
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
	public sealed class ZPMJQCJYVLK : RGTCMRPSEUI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DUTKSUWQYTV YUXKTJFBMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly IMHXHVBCZNI LXGXEDSAGYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly PWVTAYIVISZ OLQVPQRFQVM;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x768E660", Offset = "0x768D860", VA = "0x18768E660")]
		internal ZPMJQCJYVLK(IMHXHVBCZNI a, PWVTAYIVISZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x768E5C0", Offset = "0x768D7C0", VA = "0x18768E5C0")]
		internal void UPPGLDSBJWZ(DUTKSUWQYTV a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x768E540", Offset = "0x768D740", VA = "0x18768E540")]
		internal void LUENGRDJCZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x768E630", Offset = "0x768D830", VA = "0x18768E630")]
		public void ZPVTLHNDSUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class PWVTAYIVISZ
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
		public PWVTAYIVISZ TOHBEKNYDVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType OZSVPNIKROE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IPVPWOIISBV VBDTLSLNRSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint IKIJWYHPPQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object XUQIRRLRIPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int TZBEXLPFKQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError RMCGKMEPSTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason AJFHJRHSKKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GIYNCBDFWQV GIYNCBDFWQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod QWWJZIEXMXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte CTNBOAGWPRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly ZPMJQCJYVLK AYWKDKPPNCP;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76898A0", Offset = "0x7688AA0", VA = "0x1876898A0")]
		public PWVTAYIVISZ(IMHXHVBCZNI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class IMHXHVBCZNI : IEnumerable<IPVPWOIISBV>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class RDXUOVTAKPV : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7689F60", Offset = "0x7689160", VA = "0x187689F60", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7689FD0", Offset = "0x76891D0", VA = "0x187689FD0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RDXUOVTAKPV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<IPVPWOIISBV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly IPVPWOIISBV _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private IPVPWOIISBV _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public IPVPWOIISBV Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xCCFB50", Offset = "0xCCED50", VA = "0x180CCFB50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xCCFB50", Offset = "0xCCED50", VA = "0x180CCFB50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1B0BD70", Offset = "0x1B0AF70", VA = "0x181B0BD70")]
			public NetPeerEnumerator(IPVPWOIISBV p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7689810", Offset = "0x7688A10", VA = "0x187689810", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7689860", Offset = "0x7688A60", VA = "0x187689860", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread MNJVEAELVDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool TUEILIXILSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool NVXKJHAPDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TQVMTACCLUL IOGBAEIOFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent KKAGCBXMHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<PWVTAYIVISZ> XBTUWMCFSAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<PWVTAYIVISZ> EOVUZQJJKSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private PWVTAYIVISZ ZXCHTYFGOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly BSEYNCLTXZE DQRDDPHXTTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly ICHJNNHAPWR FOQGHFCKPFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly KEYEYRGJWPT UHQZCKMLJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly LJTEQGRFNZF JLIUYCHYEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, IPVPWOIISBV> TFOGBIASFTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, GIYNCBDFWQV> QABNIRYYDYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, KPIRALGZHDN> JGTBJXLMSMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim SCTSJLFZRIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IPVPWOIISBV VKOPSJLKIYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int HIRSCOTBDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<IPVPWOIISBV> MSVGSMLKFWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private IPVPWOIISBV[] CTECPGIPSET;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly FRPZTXITYZK SKWRSCWWYAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int ZYQRFENFNYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> TPIUIWFKIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte MPDPISKUJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object ELFYGNNCCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool XMESEOZRXMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool MXVHENHMRWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int SJAEIBRTPHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int INWAWHDTYXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int VTBRCLPCMZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int YKWVJOQNZXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool IASQXCFNONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool YDARJRWARWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int GODFMDDSMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int PHVECWVHIIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int MEXSJIWJPUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool YJJEKXPIAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool REWPUEHMYRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool CQICCBZKKZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool PUZMVCKMDIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int LQZPATTKPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int CSZDHIYXULA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool RCWLLFAKUME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly SZUDVKYDRZO DDNTXYYJNWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool JFERYMZCHWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly ZSPNLUOLMHX ZSPNLUOLMHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool MEJESYKBVYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode CSNZQVUTBPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int ICYZVNHRVZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool AMZPMCCJCHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool QHFDMTPFMUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool NHQWZCJOSNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool YUWHKHTBOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private DUTKSUWQYTV CKISHMIDSAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int IYOLBXWXIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object AFSPYDJDZMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DUTKSUWQYTV CDEKGXJBPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int QLGXDWBQQPH;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int RUVVMDWFQGP = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int GDQGZEBARRG = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private FAGPEHPVQRE OKDFHSHSHUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private FAGPEHPVQRE OKNTCFVNARP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread VOJZYXVSYCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread VOUNTLJNQZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint LHPDVEJRXHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint LHZRPRXMQEG;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] KEWDDAVTUMA;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] LSFQCINDDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> FIKWLJFCEGN;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress SDNDKAJHWPI;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool LADOLEZMZDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int EZWTRMDPDSO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FMMMDWSNOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xC09270", Offset = "0xC08470", VA = "0x180C09270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xC06D70", Offset = "0xC05F70", VA = "0x180C06D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int VHOKRZHFKGU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A150", Offset = "0x1F89350", VA = "0x181F8A150")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x20C43F0", Offset = "0x20C35F0", VA = "0x1820C43F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte DUMVTVDKHHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB944C0", Offset = "0xB936C0", VA = "0x180B944C0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int OGARLYYLFVF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7679AD0", Offset = "0x7678CD0", VA = "0x187679AD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short KXVMBTBQFAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7680190", Offset = "0x767F390", VA = "0x187680190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IPVPWOIISBV.OnUpdatedMtuDelegate QLHBWZPCNZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x767BCD0", Offset = "0x767AED0", VA = "0x18767BCD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x767FBC0", Offset = "0x767EDC0", VA = "0x18767FBC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x76806B0", Offset = "0x767F8B0", VA = "0x1876806B0")]
		public void VRCISVCMSXY(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x767D170", Offset = "0x767C370", VA = "0x18767D170")]
		public void NEDQRWCXOTV(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7680B30", Offset = "0x767FD30", VA = "0x187680B30")]
		private bool WOUITGMRBIL(IPEndPoint a, [Out] IPVPWOIISBV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x767B850", Offset = "0x767AA50", VA = "0x18767B850")]
		private void IRXHQPIFGNF(IPVPWOIISBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x767EE00", Offset = "0x767E000", VA = "0x18767EE00")]
		private void OYGBIIVVBDG(IPVPWOIISBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7679CA0", Offset = "0x7678EA0", VA = "0x187679CA0")]
		private void AYVSDNFQBKZ(IPVPWOIISBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7681280", Offset = "0x7680480", VA = "0x187681280")]
		public IMHXHVBCZNI(BSEYNCLTXZE a, [Optional] FRPZTXITYZK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x767C0D0", Offset = "0x767B2D0", VA = "0x18767C0D0")]
		internal void KPHTOCAEBSZ(IPVPWOIISBV a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x767EE60", Offset = "0x767E060", VA = "0x18767EE60")]
		internal void PNLIUDKCAJP(IPVPWOIISBV a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x767EEB0", Offset = "0x767E0B0", VA = "0x18767EEB0")]
		internal void RKGQWVKBTGN(IPVPWOIISBV a, DisconnectReason b, SocketError c, DUTKSUWQYTV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7680290", Offset = "0x767F490", VA = "0x187680290")]
		private void VPYULYAUZWW(IPVPWOIISBV a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, DUTKSUWQYTV h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x767D730", Offset = "0x767C930", VA = "0x18767D730")]
		private void NLCDEEEMMKM(PWVTAYIVISZ.EType a, [Optional] IPVPWOIISBV b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] GIYNCBDFWQV g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] DUTKSUWQYTV j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x767AC00", Offset = "0x7679E00", VA = "0x18767AC00")]
		private void GIEGHVJPIUL(PWVTAYIVISZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x767D2C0", Offset = "0x767C4C0", VA = "0x18767D2C0")]
		internal void NFCGWGOWJWT(PWVTAYIVISZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x767D3D0", Offset = "0x767C5D0", VA = "0x18767D3D0")]
		private void NFKHLQSTWGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x767A750", Offset = "0x7679950", VA = "0x18767A750")]
		private void FFXOLEPKBET(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x767CB40", Offset = "0x767BD40", VA = "0x18767CB40")]
		internal IPVPWOIISBV NCYOOROTYUY(GIYNCBDFWQV a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x767EF50", Offset = "0x767E150", VA = "0x18767EF50")]
		private int SPFWVTBMEEQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7680BD0", Offset = "0x767FDD0", VA = "0x187680BD0")]
		private void XYYPQQRUJRU(IPEndPoint a, IPVPWOIISBV b, RCOSVVUOYGQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x767DB00", Offset = "0x767CD00", VA = "0x18767DB00")]
		private void NUVPYQLERRJ(DUTKSUWQYTV a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x767B580", Offset = "0x767A780", VA = "0x18767B580")]
		internal void IISKPIXNAUP(DUTKSUWQYTV a, DeliveryMethod b, byte c, int d, IPVPWOIISBV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x767F7E0", Offset = "0x767E9E0", VA = "0x18767F7E0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x767EFD0", Offset = "0x767E1D0", VA = "0x18767EFD0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x767F760", Offset = "0x767E960", VA = "0x18767F760")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7679AF0", Offset = "0x7678CF0", VA = "0x187679AF0")]
		public void AVOALJSMAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x767A670", Offset = "0x7679870", VA = "0x18767A670")]
		public IPVPWOIISBV Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x767A1C0", Offset = "0x76793C0", VA = "0x18767A1C0")]
		public IPVPWOIISBV Connect(string address, int port, VESMYXPXZQE connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x767A2A0", Offset = "0x76794A0", VA = "0x18767A2A0")]
		public IPVPWOIISBV Connect(IPEndPoint target, VESMYXPXZQE connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x767FBB0", Offset = "0x767EDB0", VA = "0x18767FBB0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x767F850", Offset = "0x767EA50", VA = "0x18767F850")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x767AA80", Offset = "0x7679C80", VA = "0x18767AA80")]
		public void GEDGFIIDLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x767AB30", Offset = "0x7679D30", VA = "0x18767AB30")]
		public void GEDGFIIDLAB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7680670", Offset = "0x767F870", VA = "0x187680670")]
		public void VPYULYAUZWW(IPVPWOIISBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7680250", Offset = "0x767F450", VA = "0x187680250")]
		public void VPYULYAUZWW(IPVPWOIISBV a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x767BD80", Offset = "0x767AF80", VA = "0x18767BD80", Slot = "4")]
		private IEnumerator<IPVPWOIISBV> KGXVCSEFBRT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x767C120", Offset = "0x767B320", VA = "0x18767C120", Slot = "5")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x767B4A0", Offset = "0x767A6A0", VA = "0x18767B4A0")]
		private DUTKSUWQYTV HRGPLONCRZB(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x767B3C0", Offset = "0x767A5C0", VA = "0x18767B3C0")]
		private DUTKSUWQYTV HRGPLONCRZB(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7679F60", Offset = "0x7679160", VA = "0x187679F60")]
		internal DUTKSUWQYTV AZBAYQKMCKK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x76808D0", Offset = "0x767FAD0", VA = "0x1876808D0")]
		internal void WKOYMXCPTRR(DUTKSUWQYTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76811C0", Offset = "0x76803C0", VA = "0x1876811C0")]
		static IMHXHVBCZNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC09270", Offset = "0xC08470", VA = "0x180C09270")]
		private bool CGRHZRHJHOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x767BB70", Offset = "0x767AD70", VA = "0x18767BB70")]
		private void IWNUWYZARQI(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7681070", Offset = "0x7680270", VA = "0x187681070")]
		private void ZGHVTEOCRKP(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x767FC70", Offset = "0x767EE70", VA = "0x18767FC70")]
		private bool TWFQSCEMOPH(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x767A1A0", Offset = "0x76793A0", VA = "0x18767A1A0")]
		private void BBBZTCUTFTM(TQVMTACCLUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x767BE10", Offset = "0x767B010", VA = "0x18767BE10")]
		private void KOWMLXJYFNZ(FAGPEHPVQRE a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x767FE10", Offset = "0x767F010", VA = "0x18767FE10")]
		private void UJWXXJAFTER(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x767EFF0", Offset = "0x767E1F0", VA = "0x18767EFF0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x767EEF0", Offset = "0x767E0F0", VA = "0x18767EEF0")]
		internal int SKSTLGOYDVY(DUTKSUWQYTV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x767CB00", Offset = "0x767BD00", VA = "0x18767CB00")]
		internal int MLBLJOFWCMM(DUTKSUWQYTV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x767C330", Offset = "0x767B530", VA = "0x18767C330")]
		internal int MLBLJOFWCMM(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x767C1B0", Offset = "0x767B3B0", VA = "0x18767C1B0")]
		internal void LUEVLMMRYMZ(bool a)
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
	internal sealed class DUTKSUWQYTV
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int ECIKVKBKQQI;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] IGWYVALHYXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] ZXKOPLNMUWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int BJUTHCORHUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object XUQIRRLRIPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DUTKSUWQYTV TOHBEKNYDVH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty TQTXFWEVEHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7677E80", Offset = "0x7677080", VA = "0x187677E80")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7677F40", Offset = "0x7677140", VA = "0x187677F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte JETOMRHBPON
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7677E20", Offset = "0x7677020", VA = "0x187677E20")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x76780E0", Offset = "0x76772E0", VA = "0x1876780E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort WKXVBSWDGTT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7677F80", Offset = "0x7677180", VA = "0x187677F80")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7677FA0", Offset = "0x76771A0", VA = "0x187677FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool LLMFJFURGRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7678160", Offset = "0x7677360", VA = "0x187678160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte MZKVYEGGAGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x76782B0", Offset = "0x76774B0", VA = "0x1876782B0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7677E50", Offset = "0x7677050", VA = "0x187677E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort MBCQIGCFXAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7677EB0", Offset = "0x76770B0", VA = "0x187677EB0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7677F00", Offset = "0x7677100", VA = "0x187677F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort QNRBRKTUSNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x76782E0", Offset = "0x76774E0", VA = "0x1876782E0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7678120", Offset = "0x7677320", VA = "0x187678120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort JXRKVJFKEPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7678290", Offset = "0x7677490", VA = "0x187678290")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7677DE0", Offset = "0x7676FE0", VA = "0x187677DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7678300", Offset = "0x7677500", VA = "0x187678300")]
		static DUTKSUWQYTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7677ED0", Offset = "0x76770D0", VA = "0x187677ED0")]
		public void ISIMRMCLTHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76785B0", Offset = "0x76777B0", VA = "0x1876785B0")]
		public DUTKSUWQYTV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7678620", Offset = "0x7677820", VA = "0x187678620")]
		public DUTKSUWQYTV(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7678070", Offset = "0x7677270", VA = "0x187678070")]
		public static int QRTHWIQYFEY(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7677FE0", Offset = "0x76771E0", VA = "0x187677FE0")]
		public int QRTHWIQYFEY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7678190", Offset = "0x7677390", VA = "0x187678190")]
		public bool XMPKVZJIXTH()
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
	public class IPVPWOIISBV
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class BGKTDXWEPDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public DUTKSUWQYTV[] LXICFOKFBWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int UGCFASQWBOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int TFUTPSZIHWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte MZKVYEGGAGW;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public BGKTDXWEPDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int YVHVOQCIQAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int EVTCQQSKTQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int GOGGDZQSEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double VCADOZFOSOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int JEUOFYWHEZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int CADBDNBBCCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int HMIRXKCDVCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch DXETBKNRDSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int PNBYXLFOTIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long VFUBTGIZPRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object KOGEJDURBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal IPVPWOIISBV PFBBEGTSUNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal IPVPWOIISBV AJLYXWCELPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<DUTKSUWQYTV> GBQJZEHTWZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<TMOUEFZOAYA> KTIDRRLUARP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly TMOUEFZOAYA[] HWQWJTSJJPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int DUQJZDBJEDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int XIDQAPZMMPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool GIYSDHBVQUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int ADZQUAYBKNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int QJSJNOWJCEL;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int SQYJULUYBQD = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int GUOCFCGSIQU = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object NHVACOMHHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int VMRYIZGHAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, BGKTDXWEPDH> CBNMCKVCPDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> QHIQRXYWUOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly DUTKSUWQYTV ILLUWLPDKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int QZRJRIYWIOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int WUUBTURYIYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint FSMVHDASILU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int CFGNZJLYOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int POIIEKJHWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long ZZJWQKXRBDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte MOHVCOTXOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState MQWDDQKRKCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DUTKSUWQYTV JMRRPNUOYMT;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int CSDRBWKELIN = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int LZKQJKNLASY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly DUTKSUWQYTV ATGNEDFOWIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly DUTKSUWQYTV KBHRGSARGBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly DUTKSUWQYTV PJKVYENEPQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly DUTKSUWQYTV EYQRXAVTMDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality LUGXWUXQIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly IMHXHVBCZNI IMHXHVBCZNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int LYEFCWKIZSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object LDWITMFIVTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly SZUDVKYDRZO DDNTXYYJNWH;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte BXRHMFMFKWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAE3620", Offset = "0xAE2820", VA = "0x180AE3620")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7684380", Offset = "0x7683580", VA = "0x187684380")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint OVPYUTCDKBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xC00A50", Offset = "0xBFFC50", VA = "0x180C00A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState BXLPDDWPAKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x124B710", Offset = "0x124A910", VA = "0x18124B710")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long SVRHNUAKJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1920", Offset = "0xAC0B20", VA = "0x180AC1920")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int YTETIJTGXPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F8A150", Offset = "0x1F89350", VA = "0x181F8A150")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x20C43F0", Offset = "0x20C35F0", VA = "0x1820C43F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int AOGMTTOFZKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7681CF0", Offset = "0x7680EF0", VA = "0x187681CF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int EMFJYPSQELH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAD45E0", Offset = "0xAD37E0", VA = "0x180AD45E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double CCCVZAOYBRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x28427E0", Offset = "0x28419E0", VA = "0x1828427E0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate QLHBWZPCNZG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7681DA0", Offset = "0x7680FA0", VA = "0x187681DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x76840A0", Offset = "0x76832A0", VA = "0x1876840A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x76851C0", Offset = "0x76843C0", VA = "0x1876851C0")]
		internal IPVPWOIISBV(IMHXHVBCZNI a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7683190", Offset = "0x7682390", VA = "0x187683190")]
		internal void NHBEYHREAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7681CC0", Offset = "0x7680EC0", VA = "0x187681CC0")]
		internal void EEPGHGWGBHA(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7681E50", Offset = "0x7681050", VA = "0x187681E50")]
		internal void JLFBDZIAOEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7684B00", Offset = "0x7683D00", VA = "0x187684B00")]
		private void XKOTXZSKZGY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7685120", Offset = "0x7684320", VA = "0x187685120")]
		private void YCJWNIUDLWY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7682F60", Offset = "0x7682160", VA = "0x187682F60")]
		public int MZMDCNIAULM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7683070", Offset = "0x7682270", VA = "0x187683070")]
		public int MZMDCNIAULM(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7681840", Offset = "0x7680A40", VA = "0x187681840")]
		private TMOUEFZOAYA AHDCLNMYMGH(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x76855C0", Offset = "0x76847C0", VA = "0x1876855C0")]
		internal IPVPWOIISBV(IMHXHVBCZNI a, IPEndPoint b, int c, byte d, VESMYXPXZQE e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7685750", Offset = "0x7684950", VA = "0x187685750")]
		internal IPVPWOIISBV(IMHXHVBCZNI a, GIYNCBDFWQV b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7683750", Offset = "0x7682950", VA = "0x187683750")]
		internal void Reject(RCOSVVUOYGQ requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x76831B0", Offset = "0x76823B0", VA = "0x1876831B0")]
		internal bool OPRVAVMAMKF(VOHVGUHOGWH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7684150", Offset = "0x7683350", VA = "0x187684150")]
		public void TOQDSZVOJWS(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x76837A0", Offset = "0x76829A0", VA = "0x1876837A0")]
		private void SJAOWFHBCNN(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7681C70", Offset = "0x7680E70", VA = "0x187681C70")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7681D00", Offset = "0x7680F00", VA = "0x187681D00")]
		internal DisconnectResult HWDOCNSXXQD(DUTKSUWQYTV a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7685160", Offset = "0x7684360", VA = "0x187685160")]
		internal void YMIJUCBMLPW(TMOUEFZOAYA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7683D90", Offset = "0x7682F90", VA = "0x187683D90")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x76819D0", Offset = "0x7680BD0", VA = "0x1876819D0")]
		private void BSOAVKMZZTT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7682580", Offset = "0x7681780", VA = "0x187682580")]
		internal void KVMGPVBPBZD(DeliveryMethod a, DUTKSUWQYTV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7683230", Offset = "0x7682430", VA = "0x187683230")]
		private void PNBSBNGIAHF(DUTKSUWQYTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7684D90", Offset = "0x7683F90", VA = "0x187684D90")]
		private void YAHXWIBQZOP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7684BD0", Offset = "0x7683DD0", VA = "0x187684BD0")]
		internal ConnectRequestResult XYYPQQRUJRU(RCOSVVUOYGQ a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7681EE0", Offset = "0x76810E0", VA = "0x187681EE0")]
		internal void KGAGQCBAXDD(DUTKSUWQYTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7682E10", Offset = "0x7682010", VA = "0x187682E10")]
		private void MYOTUEUJYEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7684180", Offset = "0x7683380", VA = "0x187684180")]
		internal void UGIQLYYIYOJ(DUTKSUWQYTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7684430", Offset = "0x7683630", VA = "0x187684430")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7681A10", Offset = "0x7680C10", VA = "0x187681A10")]
		internal void CVJJGTVVWXB(DUTKSUWQYTV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class SZUDVKYDRZO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long OGIYDFHFQKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long ERCAKLZQANX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long VPLKDNNARJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long CQWDPVIPMVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long URXCGVRXQFA;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long WPYGDPGHSOR;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long PBZUGYAQZJG;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long JUFKFPAHBTZ;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long YCSLQTDGWZE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long RICESBRUMBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long YTBTLRMNIVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long COXLQJMURLI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long GSRBTQIGHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x768C410", Offset = "0x768B610", VA = "0x18768C410")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long UZTEKTAMAOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x768C020", Offset = "0x768B220", VA = "0x18768C020")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long NJBUVFNFBUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x768C320", Offset = "0x768B520", VA = "0x18768C320")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long MBKTKVWNODS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x768C250", Offset = "0x768B450", VA = "0x18768C250")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long KZNSWRPAWET
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x768C2B0", Offset = "0x768B4B0", VA = "0x18768C2B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long LKGVBMFXFCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x768C1E0", Offset = "0x768B3E0", VA = "0x18768C1E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long ZTICDKZFJJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x768C1A0", Offset = "0x768B3A0", VA = "0x18768C1A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long ZVUEJAKQPNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x768C100", Offset = "0x768B300", VA = "0x18768C100")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality MRGYGJBWUXR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x119B890", Offset = "0x119AA90", VA = "0x18119B890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double CLKCMYBNGOU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x768C750", Offset = "0x768B950", VA = "0x18768C750")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x768C330", Offset = "0x768B530", VA = "0x18768C330")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x768C030", Offset = "0x768B230", VA = "0x18768C030")]
		public void BRRACFEMIVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x768C260", Offset = "0x768B460", VA = "0x18768C260")]
		public void OBTJHDEGQAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x768C1F0", Offset = "0x768B3F0", VA = "0x18768C1F0")]
		public void MEHOLQZHENW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x768C2C0", Offset = "0x768B4C0", VA = "0x18768C2C0")]
		public void RAIPBIPWWPL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x768C140", Offset = "0x768B340", VA = "0x18768C140")]
		public void FVXPRKEXJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x768C090", Offset = "0x768B290", VA = "0x18768C090")]
		public void BYQNKVXYSUE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x768C420", Offset = "0x768B620", VA = "0x18768C420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x768C370", Offset = "0x768B570", VA = "0x18768C370")]
		public void TGJGGIWQJVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public SZUDVKYDRZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class NXDAAUGSMRG
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> YRHVLYDGQXD;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7688F00", Offset = "0x7688100", VA = "0x187688F00")]
		public static IPEndPoint AUJCKYXQEPF(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7689170", Offset = "0x7688370", VA = "0x187689170")]
		public static IPAddress WAJMNFEEUSU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7689330", Offset = "0x7688530", VA = "0x187689330")]
		public static IPAddress WAJMNFEEUSU(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7689140", Offset = "0x7688340", VA = "0x187689140")]
		internal static int KHFCFHWZASQ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x38EF420", Offset = "0x38EE620", VA = "0x1838EF420")]
		internal static T[] RHKNSILUUUJ<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class RQCJVQUJPDT : TMOUEFZOAYA
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private DUTKSUWQYTV _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7689A80", Offset = "0x7688C80", VA = "0x187689A80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x76899F0", Offset = "0x7688BF0", VA = "0x1876899F0")]
			public void MPSAKZMSCGK(DUTKSUWQYTV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7689A10", Offset = "0x7688C10", VA = "0x187689A10")]
			public bool PDFGVRRELRJ(long a, IPVPWOIISBV b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x76899A0", Offset = "0x7688BA0", VA = "0x1876899A0")]
			public bool Clear(IPVPWOIISBV peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly DUTKSUWQYTV JAJFJMBUHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] NYYCCDWCDLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly DUTKSUWQYTV[] TNYRIEULQQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] SRMWDMWKOUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int DGTJUYNCSQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int KBUGSUSCDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int OFEGKIESKWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int PVIHQKBBVXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool ORNQPHFJLVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod NJUFSKPQFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool SYWAJNXCRAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int GLMIUGRZBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte PCFYNCPIPQA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int KPWNOZPYRQT
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x768B740", Offset = "0x768A940", VA = "0x18768B740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x768B750", Offset = "0x768A950", VA = "0x18768B750")]
		public RQCJVQUJPDT(IPVPWOIISBV a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x768AEF0", Offset = "0x768A0F0", VA = "0x18768AEF0")]
		private void QYEMJQUTIZU(DUTKSUWQYTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x768B270", Offset = "0x768A470", VA = "0x18768B270", Slot = "4")]
		protected override bool TZJVVCBUOOU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x768A8F0", Offset = "0x7689AF0", VA = "0x18768A8F0", Slot = "5")]
		public override bool KGAGQCBAXDD(DUTKSUWQYTV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class VKOMGDWWGCS : TMOUEFZOAYA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int WOWSPOBFRSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort KBUGSUSCDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool KOFNOBLQVBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private DUTKSUWQYTV IJIGLDEESZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly DUTKSUWQYTV ZSWWVJFGTLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool JXDMYLEAOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte PCFYNCPIPQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long OZPKCXOAJSK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x768E0B0", Offset = "0x768D2B0", VA = "0x18768E0B0")]
		public VKOMGDWWGCS(IPVPWOIISBV a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x768DBF0", Offset = "0x768CDF0", VA = "0x18768DBF0", Slot = "4")]
		protected override bool TZJVVCBUOOU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x768D970", Offset = "0x768CB70", VA = "0x18768D970", Slot = "5")]
		public override bool KGAGQCBAXDD(DUTKSUWQYTV a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class NWFNMFXXVGH
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
		[Cpp2IlInjected.Address(RVA = "0x7677730", Offset = "0x7676930", VA = "0x187677730")]
		private static void HMNZNQXLWOA(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7688DE0", Offset = "0x7687FE0", VA = "0x187688DE0")]
		private static void HMNZNQXLWOA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7688DA0", Offset = "0x7687FA0", VA = "0x187688DA0")]
		public static void HMNZNQXLWOA(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7688EE0", Offset = "0x76880E0", VA = "0x187688EE0")]
		public static void IDNNQGWISJR(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7688E50", Offset = "0x7688050", VA = "0x187688E50")]
		public static void IDNNQGWISJR(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7688DA0", Offset = "0x7687FA0", VA = "0x187688DA0")]
		public static void IDNNQGWISJR(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7688DA0", Offset = "0x7687FA0", VA = "0x187688DA0")]
		public static void IDNNQGWISJR(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7688DE0", Offset = "0x7687FE0", VA = "0x187688DE0")]
		public static void IDNNQGWISJR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7688DE0", Offset = "0x7687FE0", VA = "0x187688DE0")]
		public static void IDNNQGWISJR(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7688ED0", Offset = "0x76880D0", VA = "0x187688ED0")]
		public static void IDNNQGWISJR(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7688ED0", Offset = "0x76880D0", VA = "0x187688ED0")]
		public static void IDNNQGWISJR(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class RGTCMRPSEUI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] BQJWQKVWLBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int BOOIMPSGWFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int CYLWRUHBTFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int OVAHWCODANM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] ZXKOPLNMUWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int FASKVFTOQCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int JZRGWMJIHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x768A0D0", Offset = "0x76892D0", VA = "0x18768A0D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool SBWCDIBNYIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x27AD690", Offset = "0x27AC890", VA = "0x1827AD690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int ODNEQDICXTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x768A480", Offset = "0x7689680", VA = "0x18768A480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x768A500", Offset = "0x7689700", VA = "0x18768A500")]
		public void UPPGLDSBJWZ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public RGTCMRPSEUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x768A890", Offset = "0x7689A90", VA = "0x18768A890")]
		public RGTCMRPSEUI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x768A190", Offset = "0x7689390", VA = "0x18768A190")]
		public IPEndPoint IFOJHOJNZRQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x768A110", Offset = "0x7689310", VA = "0x18768A110")]
		public byte GGPPCRVXAIK()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x768A110", Offset = "0x7689310", VA = "0x18768A110")]
		public sbyte RTPRUGOMZTZ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x39EC280", Offset = "0x39EB480", VA = "0x1839EC280")]
		public a[] IRLDOPBFMVL<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x768A000", Offset = "0x7689200", VA = "0x18768A000")]
		public bool[] ACTISEYLUZT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x768A600", Offset = "0x7689800", VA = "0x18768A600")]
		public ushort[] YKANMWXLECQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x768A850", Offset = "0x7689A50", VA = "0x18768A850")]
		public short[] ZBSAUPLIAPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x768A580", Offset = "0x7689780", VA = "0x18768A580")]
		public int[] WUQUEMGDDSK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x768A220", Offset = "0x7689420", VA = "0x18768A220")]
		public uint[] ISSPIYQCLVX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x768A540", Offset = "0x7689740", VA = "0x18768A540")]
		public float[] WEEAFWOQHWL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x768A490", Offset = "0x7689690", VA = "0x18768A490")]
		public double[] RMFIWSPFERE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x768A3D0", Offset = "0x76895D0", VA = "0x18768A3D0")]
		public long[] KUFHACDXQFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x768A410", Offset = "0x7689610", VA = "0x18768A410")]
		public ulong[] LFGMFZCCACW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x768A300", Offset = "0x7689500", VA = "0x18768A300")]
		public string[] KPNAXZCFJLA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x768A5C0", Offset = "0x76897C0", VA = "0x18768A5C0")]
		public bool WWYFJITNLRK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x768A2D0", Offset = "0x76894D0", VA = "0x18768A2D0")]
		public char KJNVTXASRIA()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x768A2D0", Offset = "0x76894D0", VA = "0x18768A2D0")]
		public ushort TBTPLDKIOTZ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x768A2D0", Offset = "0x76894D0", VA = "0x18768A2D0")]
		public short SGVQPONCKTE()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x768A0E0", Offset = "0x76892E0", VA = "0x18768A0E0")]
		public long FWUWSCKVRBA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x768A0E0", Offset = "0x76892E0", VA = "0x18768A0E0")]
		public ulong SETOJPRYPCR()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x768A040", Offset = "0x7689240", VA = "0x18768A040")]
		public int AUGMCDUFTTX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x768A040", Offset = "0x7689240", VA = "0x18768A040")]
		public uint QCPBKJBOWAA()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x768A4D0", Offset = "0x76896D0", VA = "0x18768A4D0")]
		public float RSEDQLSTBWK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x768A450", Offset = "0x7689650", VA = "0x18768A450")]
		public double LRQEBUEJEEF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x768A640", Offset = "0x7689840", VA = "0x18768A640")]
		public string YMVZHZVKHSR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x768A260", Offset = "0x7689460", VA = "0x18768A260")]
		public ArraySegment<byte> KAVDHSMOMGQ(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x768A150", Offset = "0x7689350", VA = "0x18768A150")]
		public sbyte[] GIDGUDVDYZK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x768A090", Offset = "0x7689290", VA = "0x18768A090")]
		public byte[] DQMWIABKSXF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x768A070", Offset = "0x7689270", VA = "0x18768A070")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class VESMYXPXZQE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] BQJWQKVWLBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int BOOIMPSGWFU;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int BLMGDPIUQGF = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool UJGBGLTPASK;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding BKLPOQYHCSW;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int GKXMVYECECP = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] OUIKPBOOWLY;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] KHVUALCSJMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int EMFZFZKJVBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x768D8F0", Offset = "0x768CAF0", VA = "0x18768D8F0")]
		public VESMYXPXZQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x768D850", Offset = "0x768CA50", VA = "0x18768D850")]
		public VESMYXPXZQE(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x768CC10", Offset = "0x768BE10", VA = "0x18768CC10")]
		public static VESMYXPXZQE KLTANLKNPMZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x768D0D0", Offset = "0x768C2D0", VA = "0x18768D0D0")]
		public void MKYFOGJMFDF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2825850", Offset = "0x2824A50", VA = "0x182825850")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x768D270", Offset = "0x768C470", VA = "0x18768D270")]
		public void UGCHQOWSIIF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x768D3D0", Offset = "0x768C5D0", VA = "0x18768D3D0")]
		public void UGCHQOWSIIF(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x768D310", Offset = "0x768C510", VA = "0x18768D310")]
		public void UGCHQOWSIIF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x768D310", Offset = "0x768C510", VA = "0x18768D310")]
		public void UGCHQOWSIIF(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x768D170", Offset = "0x768C370", VA = "0x18768D170")]
		public void UGCHQOWSIIF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x768D170", Offset = "0x768C370", VA = "0x18768D170")]
		public void UGCHQOWSIIF(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x768D360", Offset = "0x768C560", VA = "0x18768D360")]
		public void UGCHQOWSIIF(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x768D360", Offset = "0x768C560", VA = "0x18768D360")]
		public void UGCHQOWSIIF(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x768D360", Offset = "0x768C560", VA = "0x18768D360")]
		public void UGCHQOWSIIF(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x768D430", Offset = "0x768C630", VA = "0x18768D430")]
		public void UGCHQOWSIIF(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x768D430", Offset = "0x768C630", VA = "0x18768D430")]
		public void UGCHQOWSIIF(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x768D200", Offset = "0x768C400", VA = "0x18768D200")]
		public void UGCHQOWSIIF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x768CB30", Offset = "0x768BD30", VA = "0x18768CB30")]
		public void KHRNBQLNNER(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x768CB30", Offset = "0x768BD30", VA = "0x18768CB30")]
		public void TRRLSUFDSXK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x768D490", Offset = "0x768C690", VA = "0x18768D490")]
		public void UGCHQOWSIIF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x768CF10", Offset = "0x768C110", VA = "0x18768CF10")]
		public void LUKOICCQKEW(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x768CE30", Offset = "0x768C030", VA = "0x18768CE30")]
		public void LUKOICCQKEW(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x768CD50", Offset = "0x768BF50", VA = "0x18768CD50")]
		public void LUKOICCQKEW(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x768CD50", Offset = "0x768BF50", VA = "0x18768CD50")]
		public void LUKOICCQKEW(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x768CD50", Offset = "0x768BF50", VA = "0x18768CD50")]
		public void LUKOICCQKEW(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x768CE30", Offset = "0x768C030", VA = "0x18768CE30")]
		public void LUKOICCQKEW(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x768CE30", Offset = "0x768C030", VA = "0x18768CE30")]
		public void LUKOICCQKEW(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x768CFF0", Offset = "0x768C1F0", VA = "0x18768CFF0")]
		public void LUKOICCQKEW(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x768CFF0", Offset = "0x768C1F0", VA = "0x18768CFF0")]
		public void LUKOICCQKEW(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x768CB30", Offset = "0x768BD30", VA = "0x18768CB30")]
		public void LUKOICCQKEW(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x768CC80", Offset = "0x768BE80", VA = "0x18768CC80")]
		public void LUKOICCQKEW(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x768D700", Offset = "0x768C900", VA = "0x18768D700")]
		public void UGCHQOWSIIF(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x768D420", Offset = "0x768C620", VA = "0x18768D420")]
		public void UGCHQOWSIIF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x768D4F0", Offset = "0x768C6F0", VA = "0x18768D4F0")]
		public void UGCHQOWSIIF(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class JLPVZMGYCTP
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class ITGZOGHMAQJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong LYEFCWKIZSJ;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5007CC0", Offset = "0x5006EC0", VA = "0x185007CC0")]
			static ITGZOGHMAQJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(RGTCMRPSEUI reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class UZCDUZLUFIO<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public JLPVZMGYCTP LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a VYANFTOMJHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> RKYYYTVDABQ;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public UZCDUZLUFIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x627FDB0", Offset = "0x627EFB0", VA = "0x18627FDB0")]
			internal void IQJPSJXSZMB(RGTCMRPSEUI a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class RMREXCDUMCK<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public JLPVZMGYCTP LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a VYANFTOMJHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> RKYYYTVDABQ;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RMREXCDUMCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x5D04880", Offset = "0x5D03A80", VA = "0x185D04880")]
			internal void IQJPSJXSZMB(RGTCMRPSEUI a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly WQPRLZTGPTJ KATSSJQMDAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> FGDSZDLOSRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly VESMYXPXZQE RLFECZIJMNJ;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7685AE0", Offset = "0x7684CE0", VA = "0x187685AE0")]
		public JLPVZMGYCTP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x37C7830", Offset = "0x37C6A30", VA = "0x1837C7830", Slot = "4")]
		protected virtual ulong SILQMTLYHIM<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7685940", Offset = "0x7684B40", VA = "0x187685940", Slot = "5")]
		protected virtual SubscribeDelegate NQHUNSEUJQD(RGTCMRPSEUI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x37C77B0", Offset = "0x37C69B0", VA = "0x1837C77B0", Slot = "6")]
		protected virtual void NJYXICFAXQP<b>(VESMYXPXZQE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7685A10", Offset = "0x7684C10", VA = "0x187685A10")]
		public void VWLCIXIXWNC(RGTCMRPSEUI a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x37C7720", Offset = "0x37C6920", VA = "0x1837C7720")]
		public void JXZWHOAGRCT<j>(VESMYXPXZQE a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7685A90", Offset = "0x7684C90", VA = "0x187685A90")]
		public void YNEFRAIHHWI(RGTCMRPSEUI a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x37C75A0", Offset = "0x37C67A0", VA = "0x1837C75A0")]
		public void JRJXXXCEXLH<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x37C75A0", Offset = "0x37C67A0", VA = "0x1837C75A0")]
		public void JRJXXXCEXLH<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7685930", Offset = "0x7684B30", VA = "0x187685930")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7689940", Offset = "0x7688B40", VA = "0x187689940")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class WQPRLZTGPTJ
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
		private abstract class TQJUPFYDWTD<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType OZSVPNIKROE;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6085F80", Offset = "0x6085180", VA = "0x186085F80", Slot = "4")]
			public virtual void MPSAKZMSCGK(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void DZOEGFZXYQY(a a, RGTCMRPSEUI b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void JXZWHOAGRCT(a a, VESMYXPXZQE b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void WLSSYDPNIHP(a a, RGTCMRPSEUI b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void RRISBXJMMVO(a a, VESMYXPXZQE b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void QQYLQZTGENG(a a, RGTCMRPSEUI b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void JTUVJMRDHBF(a a, VESMYXPXZQE b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			protected TQJUPFYDWTD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class BNXROQNFLXG<a, b> : TQJUPFYDWTD<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> SCALJXWATWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> MHSBPLIKHPV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> YYQYGASVFMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> TBSCWXZIKNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> EPXWNHQRTHR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> PWASSCXOHJJ;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x712A250", Offset = "0x7129450", VA = "0x18712A250", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x712A250", Offset = "0x7129450", VA = "0x18712A250", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x71293B0", Offset = "0x71285B0", VA = "0x1871293B0", Slot = "9")]
			public override void QQYLQZTGENG(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x71293B0", Offset = "0x71285B0", VA = "0x1871293B0", Slot = "10")]
			public override void JTUVJMRDHBF(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7129FA0", Offset = "0x71291A0", VA = "0x187129FA0")]
			protected b[] NDOHQUWTKYV(a a, RGTCMRPSEUI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7129240", Offset = "0x7128440", VA = "0x187129240")]
			protected b[] GRYFMFTZTCI(a a, VESMYXPXZQE b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7129480", Offset = "0x7128680", VA = "0x187129480", Slot = "4")]
			public override void MPSAKZMSCGK(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x712A320", Offset = "0x7129520", VA = "0x18712A320")]
			protected BNXROQNFLXG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class ITUPSQEGMHV<a, b> : BNXROQNFLXG<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void MLRHJPBYTKI(RGTCMRPSEUI a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void MRKWGFPBEOP(VESMYXPXZQE a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x5007DE0", Offset = "0x5006FE0", VA = "0x185007DE0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x5008250", Offset = "0x5007450", VA = "0x185008250", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x5008750", Offset = "0x5007950", VA = "0x185008750", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5008410", Offset = "0x5007610", VA = "0x185008410", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x50087F0", Offset = "0x50079F0", VA = "0x1850087F0")]
			protected ITUPSQEGMHV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class MQSMUANJWAO<a> : BNXROQNFLXG<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x4081100", Offset = "0x4080300", VA = "0x184081100", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4081260", Offset = "0x4080460", VA = "0x184081260", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x58A8B60", Offset = "0x58A7D60", VA = "0x1858A8B60", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x40812A0", Offset = "0x40804A0", VA = "0x1840812A0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public MQSMUANJWAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class DJTDPIWGARR<a> : BNXROQNFLXG<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x4081100", Offset = "0x4080300", VA = "0x184081100", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x4081260", Offset = "0x4080460", VA = "0x184081260", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x40813F0", Offset = "0x40805F0", VA = "0x1840813F0", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x40812A0", Offset = "0x40804A0", VA = "0x1840812A0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public DJTDPIWGARR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class FZZUNHFZNUB<a> : BNXROQNFLXG<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4D6ACE0", Offset = "0x4D69EE0", VA = "0x184D6ACE0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4D6AE60", Offset = "0x4D6A060", VA = "0x184D6AE60", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B210", Offset = "0x4D6A410", VA = "0x184D6B210", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4D6AFB0", Offset = "0x4D6A1B0", VA = "0x184D6AFB0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public FZZUNHFZNUB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class AYGSIJOICGQ<a> : BNXROQNFLXG<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4D6ACE0", Offset = "0x4D69EE0", VA = "0x184D6ACE0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x4D6AE60", Offset = "0x4D6A060", VA = "0x184D6AE60", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x559B860", Offset = "0x559AA60", VA = "0x18559B860", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4D6AFB0", Offset = "0x4D6A1B0", VA = "0x184D6AFB0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public AYGSIJOICGQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class NXWHPKAVXCJ<a> : BNXROQNFLXG<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3F04C10", Offset = "0x3F03E10", VA = "0x183F04C10", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3F04D80", Offset = "0x3F03F80", VA = "0x183F04D80", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5976890", Offset = "0x5975A90", VA = "0x185976890", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3F04ED0", Offset = "0x3F040D0", VA = "0x183F04ED0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public NXWHPKAVXCJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class ZZZTAWZWNUS<a> : BNXROQNFLXG<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3F04C10", Offset = "0x3F03E10", VA = "0x183F04C10", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3F04D80", Offset = "0x3F03F80", VA = "0x183F04D80", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x3F05020", Offset = "0x3F04220", VA = "0x183F05020", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3F04ED0", Offset = "0x3F040D0", VA = "0x183F04ED0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public ZZZTAWZWNUS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class CZIECMLWTJP<a> : BNXROQNFLXG<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x3DC3EC0", Offset = "0x3DC30C0", VA = "0x183DC3EC0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4040", Offset = "0x3DC3240", VA = "0x183DC4040", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3DC43F0", Offset = "0x3DC35F0", VA = "0x183DC43F0", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4190", Offset = "0x3DC3390", VA = "0x183DC4190", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public CZIECMLWTJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class QNLFMOGENTG<a> : BNXROQNFLXG<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3DC3EC0", Offset = "0x3DC30C0", VA = "0x183DC3EC0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4040", Offset = "0x3DC3240", VA = "0x183DC4040", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5CB61D0", Offset = "0x5CB53D0", VA = "0x185CB61D0", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4190", Offset = "0x3DC3390", VA = "0x183DC4190", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public QNLFMOGENTG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class VQMNEVPWWIF<a> : BNXROQNFLXG<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x639BFE0", Offset = "0x639B1E0", VA = "0x18639BFE0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x639C140", Offset = "0x639B340", VA = "0x18639C140", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x639C180", Offset = "0x639B380", VA = "0x18639C180", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x40812A0", Offset = "0x40804A0", VA = "0x1840812A0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public VQMNEVPWWIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class GIEKOUDCNDA<a> : BNXROQNFLXG<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4EB7F20", Offset = "0x4EB7120", VA = "0x184EB7F20", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x4EB8090", Offset = "0x4EB7290", VA = "0x184EB8090", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x4EB81E0", Offset = "0x4EB73E0", VA = "0x184EB81E0", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3F04ED0", Offset = "0x3F040D0", VA = "0x183F04ED0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public GIEKOUDCNDA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class JCCNBNNMKDV<a> : BNXROQNFLXG<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x50DC980", Offset = "0x50DBB80", VA = "0x1850DC980", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x50DCC10", Offset = "0x50DBE10", VA = "0x1850DCC10", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x50DCD60", Offset = "0x50DBF60", VA = "0x1850DCD60", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4190", Offset = "0x3DC3390", VA = "0x183DC4190", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC3660", VA = "0x183DC4460")]
			public JCCNBNNMKDV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class VBKHVGXNXNB<a> : ITUPSQEGMHV<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x638CB30", Offset = "0x638BD30", VA = "0x18638CB30", Slot = "12")]
			protected override void MRKWGFPBEOP(VESMYXPXZQE a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x638CB00", Offset = "0x638BD00", VA = "0x18638CB00", Slot = "11")]
			protected override void MLRHJPBYTKI(RGTCMRPSEUI a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x626F740", Offset = "0x626E940", VA = "0x18626F740")]
			public VBKHVGXNXNB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class UJEXRHTKNLJ<a> : ITUPSQEGMHV<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x626F710", Offset = "0x626E910", VA = "0x18626F710", Slot = "12")]
			protected override void MRKWGFPBEOP(VESMYXPXZQE a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x626F6D0", Offset = "0x626E8D0", VA = "0x18626F6D0", Slot = "11")]
			protected override void MLRHJPBYTKI(RGTCMRPSEUI a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x626F740", Offset = "0x626E940", VA = "0x18626F740")]
			public UJEXRHTKNLJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class AKANEKRHPPM<a> : BNXROQNFLXG<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int PVIKZSIZKLP;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x558F560", Offset = "0x558E760", VA = "0x18558F560")]
			public AKANEKRHPPM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x558F0C0", Offset = "0x558E2C0", VA = "0x18558F0C0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x558F120", Offset = "0x558E320", VA = "0x18558F120", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x558F3E0", Offset = "0x558E5E0", VA = "0x18558F3E0", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x558F390", Offset = "0x558E590", VA = "0x18558F390", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class OCODHYAOJXC<a> : TQJUPFYDWTD<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo TQTXFWEVEHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type KTGQJIVTPBX;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5A83580", Offset = "0x5A82780", VA = "0x185A83580")]
			public OCODHYAOJXC(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5A83250", Offset = "0x5A82450", VA = "0x185A83250", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5A83460", Offset = "0x5A82660", VA = "0x185A83460", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x5A834D0", Offset = "0x5A826D0", VA = "0x185A834D0", Slot = "7")]
			public override void WLSSYDPNIHP(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x5A834D0", Offset = "0x5A826D0", VA = "0x185A834D0", Slot = "8")]
			public override void RRISBXJMMVO(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x5A832F0", Offset = "0x5A824F0", VA = "0x185A832F0", Slot = "9")]
			public override void QQYLQZTGENG(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x5A832F0", Offset = "0x5A824F0", VA = "0x185A832F0", Slot = "10")]
			public override void JTUVJMRDHBF(a a, VESMYXPXZQE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class DSEPVQZVNKB<a> : OCODHYAOJXC<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x409D020", Offset = "0x409C220", VA = "0x18409D020")]
			public DSEPVQZVNKB(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x409CDD0", Offset = "0x409BFD0", VA = "0x18409CDD0", Slot = "5")]
			public override void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x409CF90", Offset = "0x409C190", VA = "0x18409CF90", Slot = "6")]
			public override void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class BWRLVHUFEZJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static BWRLVHUFEZJ<a> DZRVHNEPLID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly TQJUPFYDWTD<a>[] DYRCZQJRIFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int VKOINHWVRXB;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x712DC20", Offset = "0x712CE20", VA = "0x18712DC20")]
			public BWRLVHUFEZJ(List<TQJUPFYDWTD<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x712D910", Offset = "0x712CB10", VA = "0x18712D910")]
			public void JXZWHOAGRCT(a a, VESMYXPXZQE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x712D860", Offset = "0x712CA60", VA = "0x18712D860")]
			public void DZOEGFZXYQY(a a, RGTCMRPSEUI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class WXIYLXFEYKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract TQJUPFYDWTD<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private VESMYXPXZQE WZDUNFXMTUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int OYEAQMEOKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, WXIYLXFEYKL> VLSNZIAEMPU;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x768E4B0", Offset = "0x768D6B0", VA = "0x18768E4B0")]
		public WQPRLZTGPTJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C38E80", Offset = "0x3C38080", VA = "0x183C38E80")]
		private BWRLVHUFEZJ<d> MSWNVJAHDBC<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C37FF0", Offset = "0x3C371F0", VA = "0x183C37FF0")]
		public void JUFURAKXVZP<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C37EB0", Offset = "0x3C370B0", VA = "0x183C37EB0")]
		public bool Deserialize<T>(RGTCMRPSEUI reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C37F30", Offset = "0x3C37130", VA = "0x183C37F30")]
		public void JNXWDCMOQDE<f>(VESMYXPXZQE a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class MRHYJPNMRHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime OKTSZARJZKZ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] OXNQNLXDIRN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator CFCKWCHAEVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7687990", Offset = "0x7686B90", VA = "0x187687990")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int HMYUXGJHGGV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x7687DB0", Offset = "0x7686FB0", VA = "0x187687DB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x76879C0", Offset = "0x7686BC0", VA = "0x1876879C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode XKAEYZHICIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x7687FA0", Offset = "0x76871A0", VA = "0x187687FA0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x76883B0", Offset = "0x76875B0", VA = "0x1876883B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int VNUJNMCNWUM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7688960", Offset = "0x7687B60", VA = "0x187688960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint LQUVBTGMUYU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7688350", Offset = "0x7687550", VA = "0x187688350")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? AKUYXWEIJKW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7687A00", Offset = "0x7686C00", VA = "0x187687A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? CLMBVFTCJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7688930", Offset = "0x7687B30", VA = "0x187688930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? CTQUKKIWUGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x7687AF0", Offset = "0x7686CF0", VA = "0x187687AF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x7687FD0", Offset = "0x76871D0", VA = "0x187687FD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? NHFLKVRBHHS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xB2F4C0", Offset = "0xB2E6C0", VA = "0x180B2F4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xD118C0", Offset = "0xD10AC0", VA = "0x180D118C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7688A90", Offset = "0x7687C90", VA = "0x187688A90")]
		public MRHYJPNMRHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x76889F0", Offset = "0x7687BF0", VA = "0x1876889F0")]
		internal MRHYJPNMRHA(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7688190", Offset = "0x7687390", VA = "0x187688190")]
		public static MRHYJPNMRHA UXKUYIVXCQU(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x76885B0", Offset = "0x76877B0", VA = "0x1876885B0")]
		internal void YPIFGROYTFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7687DE0", Offset = "0x7686FE0", VA = "0x187687DE0")]
		private void NNMUQEXABYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7687B80", Offset = "0x7686D80", VA = "0x187687B80")]
		private DateTime? KIDYOOGTNXN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x76883F0", Offset = "0x76875F0", VA = "0x1876883F0")]
		private void YAKMYPICJLZ(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x76882A0", Offset = "0x76874A0", VA = "0x1876882A0")]
		private ulong WDMIFYDBINN(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7687A30", Offset = "0x7686C30", VA = "0x187687A30")]
		private void IMUIRJCJYZB(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7687B20", Offset = "0x7686D20", VA = "0x187687B20")]
		private uint KFDHUKRLKME(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7546700", Offset = "0x7545900", VA = "0x187546700")]
		private static uint KLJGWNJCJZR(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7687D50", Offset = "0x7686F50", VA = "0x187687D50")]
		private static ulong KLJGWNJCJZR(ulong a)
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
	internal sealed class KPIRALGZHDN
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int KOTRIJSZMJK = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int FCAOPLVQIPH = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int SYJKSGIVEHU = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint MQPXOEKWGXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int VWWUNGORBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int YOVOYIPVJOU;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool IEHOXKBOVCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7685C30", Offset = "0x7684E30", VA = "0x187685C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7685C40", Offset = "0x7684E40", VA = "0x187685C40")]
		public bool TOQDSZVOJWS(FAGPEHPVQRE a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class FVGCTHBRKYT : FAGPEHPVQRE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket KGDTMVVUQGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly IMHXHVBCZNI HJREZNJCDRY;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short KXVMBTBQFAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x7678D90", Offset = "0x7677F90", VA = "0x187678D90", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int OCBJFRPFZZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7678D30", Offset = "0x7677F30", VA = "0x187678D30", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint GGXKHOICCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x7678D10", Offset = "0x7677F10", VA = "0x187678D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily UUTHGJPGHFG
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x3042840", Offset = "0x3041A40", VA = "0x183042840", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7678EA0", Offset = "0x76780A0", VA = "0x187678EA0")]
		public FVGCTHBRKYT(AddressFamily a, IMHXHVBCZNI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7678730", Offset = "0x7677930", VA = "0x187678730", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7678D50", Offset = "0x7677F50", VA = "0x187678D50", Slot = "9")]
		public int ITIISDLBBWP(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7678DB0", Offset = "0x7677FB0", VA = "0x187678DB0", Slot = "10")]
		public int YFHVJJCQSZP(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7678CF0", Offset = "0x7677EF0", VA = "0x187678CF0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface FAGPEHPVQRE
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short KXVMBTBQFAE
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int OCBJFRPFZZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint GGXKHOICCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily UUTHGJPGHFG
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
		int ITIISDLBBWP(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int YFHVJJCQSZP(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x7689530", Offset = "0x7688730", VA = "0x187689530")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x76895D0", Offset = "0x76887D0", VA = "0x1876895D0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x13CE310", Offset = "0x13CD510", VA = "0x1813CE310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7689440", Offset = "0x7688640", VA = "0x187689440", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7689480", Offset = "0x7688680", VA = "0x187689480", Slot = "0")]
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
	public class TQVMTACCLUL
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string GUVVVWPNHLB = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int TTFYSPQYHAN = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int TBZAXCYJVTR = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int TEWQVOSTTBF = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> ONSUUSESATY;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback BDQELPSEALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int FAPLZYLGOND;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		internal void SIGNVRQFCXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		internal void VPJHNONIRZX(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class FRPZTXITYZK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int OGARLYYLFVF;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
		protected FRPZTXITYZK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ZSZAOURQVNU(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void JPMXPVRQTEZ(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class GWEDVTCSIYU : FRPZTXITYZK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] GNIQKUTBWSX;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator KPMHUHXHVWJ;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2924A70", Offset = "0x2923C70", VA = "0x182924A70")]
		public GWEDVTCSIYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x76793B0", Offset = "0x76785B0", VA = "0x1876793B0")]
		public void KDNMNXCKUVE(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7679560", Offset = "0x7678760", VA = "0x187679560")]
		public void NVFHNPTOJNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7679640", Offset = "0x7678840", VA = "0x187679640", Slot = "4")]
		public override void ZSZAOURQVNU(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x76790B0", Offset = "0x76782B0", VA = "0x1876790B0", Slot = "5")]
		public override void JPMXPVRQTEZ(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class CYCTOMSUQEH
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr EXWIVAKGKCJ;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x768F450", Offset = "0x768E650", VA = "0x18768F450")]
			[BurstDiscard]
			private static void SJMJWHMCWZD(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x768F2D0", Offset = "0x768E4D0", VA = "0x18768F2D0")]
			private static IntPtr NGUJNXDQPEN()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x768F090", Offset = "0x768E290", VA = "0x18768F090")]
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
		[Cpp2IlInjected.Address(RVA = "0x768BEC0", Offset = "0x768B0C0", VA = "0x18768BEC0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x768BFF0", Offset = "0x768B1F0", VA = "0x18768BFF0")]
		private uint UZKLUNRYLQG(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7677AC0", Offset = "0x7676CC0", VA = "0x187677AC0")]
		private void IEFKPDZAOSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x76778B0", Offset = "0x7676AB0", VA = "0x1876778B0")]
		private void FLWQDBBPRFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7677820", Offset = "0x7676A20", VA = "0x187677820")]
		private void EIZSPGSRJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7677B70", Offset = "0x7676D70", VA = "0x187677B70")]
		private void QKKQYPXPWLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x768BE60", Offset = "0x768B060", VA = "0x18768BE60")]
		private void KBTCLVDOAUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x768B910", Offset = "0x768AB10", VA = "0x18768B910")]
		private unsafe void AVJMXLBUTCQ(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x768BDA0", Offset = "0x768AFA0", VA = "0x18768BDA0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void JVAIZZHTHJX([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x768BDB0", Offset = "0x768AFB0", VA = "0x18768BDB0")]
		public static void JVAIZZHTHJX(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x768BF40", Offset = "0x768B140", VA = "0x18768BF40")]
		public static void SDARUGTKMEV(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x768BD30", Offset = "0x768AF30", VA = "0x18768BD30")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void JMMROSUSGXW([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x768F6A0", Offset = "0x768E8A0", VA = "0x18768F6A0")]
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
