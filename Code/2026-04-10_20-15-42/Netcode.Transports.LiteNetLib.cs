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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, FEVINBEOZCO
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
		private NetworkManager HHXAXJCDZVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool QFQLURNABIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, OCQTFLRKKPN> YYCBZUPJGWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GOANXSKKOIS AOYPEUREHCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch FYJKLCZCPXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] EQTZTZCMXLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType TOUODEQHUNQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int BRZQENMNMVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA630", Offset = "0x8BF9630", VA = "0x188BFA630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA5E0", Offset = "0x8BF95E0", VA = "0x188BFA5E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9AE0", Offset = "0x8BF8AE0", VA = "0x188BF9AE0")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9AC0", Offset = "0x8BF8AC0", VA = "0x188BF9AC0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9920", Offset = "0x8BF8920", VA = "0x188BF9920")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA420", Offset = "0x8BF9420", VA = "0x188BFA420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9BF0", Offset = "0x8BF8BF0", VA = "0x188BF9BF0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9A30", Offset = "0x8BF8A30", VA = "0x188BF9A30", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9EC0", Offset = "0x8BF8EC0", VA = "0x188BF9EC0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA200", Offset = "0x8BF9200", VA = "0x188BFA200", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9140", Offset = "0x8BF8140", VA = "0x188BF9140", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9050", Offset = "0x8BF8050", VA = "0x188BF9050", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9550", Offset = "0x8BF8550", VA = "0x188BF9550", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9E50", Offset = "0x8BF8E50", VA = "0x188BF9E50", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BF96B0", Offset = "0x8BF86B0", VA = "0x188BF96B0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA440", Offset = "0x8BF9440", VA = "0x188BFA440")]
		private DeliveryMethod ZBIGXIELOYX(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BF95F0", Offset = "0x8BF85F0", VA = "0x188BF95F0", Slot = "16")]
		private void HTTUHBIAVOI(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8F80", Offset = "0x8BF7F80", VA = "0x188BF8F80", Slot = "17")]
		private void CTUFYUEMEJI(OCQTFLRKKPN a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "18")]
		private void DBHBQZWGNVX(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9350", Offset = "0x8BF8350", VA = "0x188BF9350", Slot = "19")]
		private void FPVHCMHIPZI(OCQTFLRKKPN a, OQXRLZMXBEE b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9280", Offset = "0x8BF8280", VA = "0x188BF9280")]
		private void FNAJUKCBPHL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "20")]
		private void IIQBTLXWPCI(IPEndPoint a, OQXRLZMXBEE b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "21")]
		private void QNNZWEUKELG(OCQTFLRKKPN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF98C0", Offset = "0x8BF88C0", VA = "0x188BF98C0", Slot = "22")]
		private void KWFNPOYLOFQ(FULTMNFEJJL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9A90", Offset = "0x8BF8A90", VA = "0x188BF9A90")]
		private ulong QPEOZRHLDNH(OCQTFLRKKPN a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9A70", Offset = "0x8BF8A70", VA = "0x188BF9A70")]
		private ulong QPEOZRHLDNH(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9A10", Offset = "0x8BF8A10", VA = "0x188BF9A10")]
		private static int PCNSXNCFEAC(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA510", Offset = "0x8BF9510", VA = "0x188BFA510")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9250", Offset = "0x8BF8250", VA = "0x188BF9250")]
		[CompilerGenerated]
		private void FCPSOWYINXY(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9250", Offset = "0x8BF8250", VA = "0x188BF9250")]
		[CompilerGenerated]
		private void XEBTIOVSUEX(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class MZKDLBKFQPW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly OCQTFLRKKPN KJLGHLNGRMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<CYUJJFYJAMH> YXIRMMWHVEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int OJRCKKYTDCY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int BVBEQALPEKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA8D0", Offset = "0x8BF98D0", VA = "0x188BFA8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA920", Offset = "0x8BF9920", VA = "0x188BFA920")]
		protected MZKDLBKFQPW(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA870", Offset = "0x8BF9870", VA = "0x188BFA870")]
		public void UBIZAIIRWHD(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA7F0", Offset = "0x8BF97F0", VA = "0x188BFA7F0")]
		protected void TBKRAEODFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA7B0", Offset = "0x8BF97B0", VA = "0x188BFA7B0")]
		public bool LYYDWJARKYU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool ETQCRWXQJRG();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool ENPPMPFUXFL(CYUJJFYJAMH a);
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
	public class FULTMNFEJJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GOANXSKKOIS HNPHYVSYKJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int IQQONDGBWTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal EEIAXPLQIVG TVBHWITSACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint CBVQJCVSIPV;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult HGFNJPDQARP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x163D350", Offset = "0x163C350", VA = "0x18163D350")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x163D360", Offset = "0x163C360", VA = "0x18163D360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0D40", Offset = "0x8BEFD40", VA = "0x188BF0D40")]
		internal void SXYTOUDPSTY(EEIAXPLQIVG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0D10", Offset = "0x8BEFD10", VA = "0x188BF0D10")]
		private bool RJMSHEJSAVS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0DA0", Offset = "0x8BEFDA0", VA = "0x188BF0DA0")]
		internal FULTMNFEJJL(IPEndPoint a, EEIAXPLQIVG b, GOANXSKKOIS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0CB0", Offset = "0x8BEFCB0", VA = "0x188BF0CB0")]
		public OCQTFLRKKPN Accept()
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
		public OQXRLZMXBEE AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface FEVINBEOZCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OAISNNWGLUU(OCQTFLRKKPN a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YECESKYQVCK(OCQTFLRKKPN a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RWPQDCRQGSR(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CWTWSMZYAJU(OCQTFLRKKPN a, OQXRLZMXBEE b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EHSIJJUXUDS(IPEndPoint a, OQXRLZMXBEE b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SGBNGOPMYBK(OCQTFLRKKPN a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JSBZZWXXGZI(FULTMNFEJJL a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ZNIZSCWTDIR
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DIBIJWPROCU(OCQTFLRKKPN a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KGOSNJMXZIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MUUTDPLISIK(FRXFAFKMYKS a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface LBWZNQVZNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OJXGTEGUUIR(OCQTFLRKKPN a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class EEIAXPLQIVG
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int WINUPGHXRYQ = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long YMCZZFJCKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte FDGKRNYVTFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] XCITPQMSAQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly VSOHZOVUZLK HBLTVDNEEXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int AITXGKQOYSF;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE650", Offset = "0x8BED650", VA = "0x188BEE650")]
		private EEIAXPLQIVG(long a, byte b, int c, byte[] d, VSOHZOVUZLK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE440", Offset = "0x8BED440", VA = "0x188BEE440")]
		public static int QNUBXTLZXGF(CYUJJFYJAMH a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE250", Offset = "0x8BED250", VA = "0x188BEE250")]
		public static EEIAXPLQIVG CGLMLKKSOFO(CYUJJFYJAMH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE470", Offset = "0x8BED470", VA = "0x188BEE470")]
		public static CYUJJFYJAMH UWQIXUHMKTE(YMUYYZRTLWM a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class LHLSOUSYCDZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long YMCZZFJCKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte FDGKRNYVTFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int AITXGKQOYSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool SCDXPYZZWRU;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8F30", Offset = "0x8BF7F30", VA = "0x188BF8F30")]
		private LHLSOUSYCDZ(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8C40", Offset = "0x8BF7C40", VA = "0x188BF8C40")]
		public static LHLSOUSYCDZ CGLMLKKSOFO(CYUJJFYJAMH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8E40", Offset = "0x8BF7E40", VA = "0x188BF8E40")]
		public static CYUJJFYJAMH UWQIXUHMKTE(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8D40", Offset = "0x8BF7D40", VA = "0x188BF8D40")]
		public static CYUJJFYJAMH MSVFCJNFZQQ(OCQTFLRKKPN a)
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
	public interface YZVSMBYOIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SNVVUWGPTLL(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DMIBHLQULJJ(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class EEXLWYVHYOF
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
		private class PYTAQRNLWLD
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint NFGUSWCYRJT
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string ZUWNXREQBJH
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public PYTAQRNLWLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class NALHHLHTHZZ
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint NFGUSWCYRJT
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint VXQRFPKAQDZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string ZUWNXREQBJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public NALHHLHTHZZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class PHADOLBFNDD
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string ZUWNXREQBJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool ZRASMFHJEIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xD18620", Offset = "0xD17620", VA = "0x180D18620")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public PHADOLBFNDD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly GOANXSKKOIS OBKGUPVHMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> VGICKUIJCTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> AACXINZPHTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly VSOHZOVUZLK CQBVHELJQLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly YMUYYZRTLWM PZRHCHDVQXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly UJRNQXRYGIR VFCJTWABDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private YZVSMBYOIMC IUSXEEZPUKY;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int DZFDTDZJDWT = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool JMKFJNCGCME;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BEECB0", Offset = "0x8BEDCB0", VA = "0x188BEECB0")]
		internal EEXLWYVHYOF(GOANXSKKOIS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE6C0", Offset = "0x8BED6C0", VA = "0x188BEE6C0")]
		internal void BJPPHEBTOUU(IPEndPoint a, CYUJJFYJAMH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x394D130", Offset = "0x394C130", VA = "0x18394D130")]
		private void UBSUEOKZGUG<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE9D0", Offset = "0x8BED9D0", VA = "0x188BEE9D0")]
		private void SNVVUWGPTLL(PYTAQRNLWLD a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEB50", Offset = "0x8BEDB50", VA = "0x188BEEB50")]
		private void SSKYYSBTWWX(NALHHLHTHZZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE840", Offset = "0x8BED840", VA = "0x188BEE840")]
		private void RGSHFMHSAGU(PHADOLBFNDD a, IPEndPoint b)
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
	public static class ZVJCXQMWIJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] JWOCGHXMITL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int LMJZSNZNXQT;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int USDRLWWMCXU;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8C30", Offset = "0x8BF7C30", VA = "0x188BF8C30")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8C30", Offset = "0x8BF7C30", VA = "0x188BF8C30")]
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
	public interface KSUBPAMOKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YRVGNAYEXVE(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BGWZSXRGTTI
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static KSUBPAMOKHE MPVCMIXWMGI;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object CFSHMDSWVFK;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BED5A0", Offset = "0x8BEC5A0", VA = "0x188BED5A0")]
		private static void NJGPZYTRUUD(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BED4E0", Offset = "0x8BEC4E0", VA = "0x188BED4E0")]
		internal static void IZOOQSZXUAH(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8BED7D0", Offset = "0x8BEC7D0", VA = "0x188BED7D0")]
		internal static void RRFVMZDVWAZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BED540", Offset = "0x8BEC540", VA = "0x188BED540")]
		internal static void LYMPIYPTRHV(string a, params object[] args)
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
	public sealed class OQXRLZMXBEE : VSOHZOVUZLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private CYUJJFYJAMH AVNSJRIRILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly GOANXSKKOIS QEZLXCKUQTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly WJQSCCGWVLX BENZINNIXOC;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFBA0", Offset = "0x8BFEBA0", VA = "0x188BFFBA0")]
		internal OQXRLZMXBEE(GOANXSKKOIS a, WJQSCCGWVLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFB30", Offset = "0x8BFEB30", VA = "0x188BFFB30")]
		internal void PQIIPNZHDCN(CYUJJFYJAMH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFA80", Offset = "0x8BFEA80", VA = "0x188BFFA80")]
		internal void BGOSPSYHFWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFB00", Offset = "0x8BFEB00", VA = "0x188BFFB00")]
		public void EDYPTFHYHYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class WJQSCCGWVLX
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
		public WJQSCCGWVLX WOQMWIAUPTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType XYUHIEMAMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OCQTFLRKKPN KJLGHLNGRMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint CBVQJCVSIPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object NHJAPDMHDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int CLPVVLCEFUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError NEXXUXJXLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason FWGOVMQTSKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FULTMNFEJJL FULTMNFEJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod IWYLWEIYHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte CEBKVAVUUUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly OQXRLZMXBEE VBGJFVTAZLZ;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8C03380", Offset = "0x8C02380", VA = "0x188C03380")]
		public WJQSCCGWVLX(GOANXSKKOIS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class GOANXSKKOIS : IEnumerable<OCQTFLRKKPN>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class WUNIYUVOITR : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8C03420", Offset = "0x8C02420", VA = "0x188C03420", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8C03490", Offset = "0x8C02490", VA = "0x188C03490", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public WUNIYUVOITR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<OCQTFLRKKPN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly OCQTFLRKKPN _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private OCQTFLRKKPN _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public OCQTFLRKKPN Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D94330", Offset = "0x1D93330", VA = "0x181D94330")]
			public NetPeerEnumerator(OCQTFLRKKPN p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB7C0", Offset = "0x8BFA7C0", VA = "0x188BFB7C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB810", Offset = "0x8BFA810", VA = "0x188BFB810", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread KVQPMMPRXKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool ZWZHFFRLEBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool BZDPYWBCTQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private XYZFMNSORLZ LDGMLEMXHZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent CHKDDECKAFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<WJQSCCGWVLX> UJNLFDFNUHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<WJQSCCGWVLX> WEFCJXIGMXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private WJQSCCGWVLX RJOJEKJIERG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly FEVINBEOZCO CNLVYIRKUQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly ZNIZSCWTDIR QORTOBVUZNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly KGOSNJMXZIJ NINTDMTDBZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly LBWZNQVZNMD OBNVWOXCVIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, OCQTFLRKKPN> XKFEKKAONHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, FULTMNFEJJL> AZHFYLSYWGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, OPFRVABDNLZ> KWBZWGPDQZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim FWXTNMJRAPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private OCQTFLRKKPN VXGPXQCFLZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int ZHQVIEAJRUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<OCQTFLRKKPN> HXKRSWAIXVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private OCQTFLRKKPN[] TXEWKBIXNXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly KPIREJNTFAE NZXTFQEXDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int DSTYDLQUAVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> TOAZTOSMJTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte BZFJFTWTTTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object BRQMORLTAIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool YQCAOMIBRWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool SQRLNXQNGMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int TFRNDHFJJUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int WYIRJJKMBZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int HWPLMZSQYDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int PEIFGUGSHIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool ZZWEBKPDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool XPXKJQZMNTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int OPQCMHNXCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int GJPEHZKOOTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int RNJTSURDNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool JMKFJNCGCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool LQHHDWMKLWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool YDLIRYGAGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool HXSOMLTOEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int QKTCMLEQOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int UDIOCJCMUUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool YPBEMVHCZEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly THENRQPHNHO YZYDWFFJVTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool RCVSXAWCQXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly EEXLWYVHYOF EEXLWYVHYOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool SDOFKRJIHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode PLTJBWFZZDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int HRGWBIJXTAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool MLXTLHELLOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool QZIARRCMXPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool IZCJGOQCLWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool ZGDUIBCYWKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private CYUJJFYJAMH OXFVCINDZDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int BQWBVCNCVHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object XVMZMYWMKMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private CYUJJFYJAMH TDTHCSZAKXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int UDQBHRRHKOV;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int MLQSTVDZOXB = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int XUKCJXDECHK = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private VUAUYYXFOFY GMWWGDYWMTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private VUAUYYXFOFY GNHKARMRFPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread RDLJAMHYVJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread RDVWUZVTOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint NMOZYMTPXRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint NMZNTAHKQOG;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] EKDNIFQIOWI;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] AWVCHWEMHNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> ACDAZLQCBVH;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress MRJLMUTXKEK;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool SFWMZWPPVJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int OPNOAEJFGNI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool CMNFCXYLTOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE7EB50", Offset = "0xE7DB50", VA = "0x180E7EB50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE7D730", Offset = "0xE7C730", VA = "0x180E7D730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int UVQUBDZJAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2249100", Offset = "0x2248100", VA = "0x182249100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2358890", Offset = "0x2357890", VA = "0x182358890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte GPZIAPKYVTF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE073F0", Offset = "0xE063F0", VA = "0x180E073F0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int QVHRJCTSBOH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4550", Offset = "0x8BF3550", VA = "0x188BF4550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short MBUDKUCDGHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0E10", Offset = "0x8BEFE10", VA = "0x188BF0E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OCQTFLRKKPN.OnUpdatedMtuDelegate QHPAZVRQBWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BF12A0", Offset = "0x8BF02A0", VA = "0x188BF12A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5740", Offset = "0x8BF4740", VA = "0x188BF5740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5B10", Offset = "0x8BF4B10", VA = "0x188BF5B10")]
		public void SSGUIUUMOFY(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3F00", Offset = "0x8BF2F00", VA = "0x188BF3F00")]
		public void KTEMDKPMFNJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4EE0", Offset = "0x8BF3EE0", VA = "0x188BF4EE0")]
		private bool PTBBCJTQCHN(IPEndPoint a, [Out] OCQTFLRKKPN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4570", Offset = "0x8BF3570", VA = "0x188BF4570")]
		private void OONQCQVWKPF(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BF84C0", Offset = "0x8BF74C0", VA = "0x188BF84C0")]
		private void ZWTXJPCYBBO(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BF57F0", Offset = "0x8BF47F0", VA = "0x188BF57F0")]
		private void RNPVRDDBVVH(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BF85E0", Offset = "0x8BF75E0", VA = "0x188BF85E0")]
		public GOANXSKKOIS(FEVINBEOZCO a, [Optional] KPIREJNTFAE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BF68C0", Offset = "0x8BF58C0", VA = "0x188BF68C0")]
		internal void TKDPVTPQHKF(OCQTFLRKKPN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BF11A0", Offset = "0x8BF01A0", VA = "0x188BF11A0")]
		internal void ARZJRDGRVJP(OCQTFLRKKPN a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BF41D0", Offset = "0x8BF31D0", VA = "0x188BF41D0")]
		internal void MQFMOXRPJDH(OCQTFLRKKPN a, DisconnectReason b, SocketError c, CYUJJFYJAMH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BF78C0", Offset = "0x8BF68C0", VA = "0x188BF78C0")]
		private void WPJIYGSUTVM(OCQTFLRKKPN a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, CYUJJFYJAMH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6DB0", Offset = "0x8BF5DB0", VA = "0x188BF6DB0")]
		private void UORGUOEZNYQ(WJQSCCGWVLX.EType a, [Optional] OCQTFLRKKPN b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] FULTMNFEJJL g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] CYUJJFYJAMH j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4F80", Offset = "0x8BF3F80", VA = "0x188BF4F80")]
		private void QJJMLZSISLR(WJQSCCGWVLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2DB0", Offset = "0x8BF1DB0", VA = "0x188BF2DB0")]
		internal void DTTNPBNELZB(WJQSCCGWVLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8160", Offset = "0x8BF7160", VA = "0x188BF8160")]
		private void YECIANEKJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF30F0", Offset = "0x8BF20F0", VA = "0x188BF30F0")]
		private void INTRBRWFSDF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF48A0", Offset = "0x8BF38A0", VA = "0x188BF48A0")]
		internal OCQTFLRKKPN PACNMMCQKJK(FULTMNFEJJL a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BF44D0", Offset = "0x8BF34D0", VA = "0x188BF44D0")]
		private int NHNHBTKJHVW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6910", Offset = "0x8BF5910", VA = "0x188BF6910")]
		private void ULYSYQEWQEO(IPEndPoint a, OCQTFLRKKPN b, EEIAXPLQIVG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1A90", Offset = "0x8BF0A90", VA = "0x188BF1A90")]
		private void DRYAHFQOHPJ(CYUJJFYJAMH a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0ED0", Offset = "0x8BEFED0", VA = "0x188BF0ED0")]
		internal void AISQPDKAXLZ(CYUJJFYJAMH a, DeliveryMethod b, byte c, int d, OCQTFLRKKPN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6520", Offset = "0x8BF5520", VA = "0x188BF6520")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6530", Offset = "0x8BF5530", VA = "0x188BF6530")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BF64A0", Offset = "0x8BF54A0", VA = "0x188BF64A0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BF18E0", Offset = "0x8BF08E0", VA = "0x188BF18E0")]
		public void DFNWFVVOIEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1350", Offset = "0x8BF0350", VA = "0x188BF1350")]
		public OCQTFLRKKPN Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1430", Offset = "0x8BF0430", VA = "0x188BF1430")]
		public OCQTFLRKKPN Connect(string address, int port, YMUYYZRTLWM connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1510", Offset = "0x8BF0510", VA = "0x188BF1510")]
		public OCQTFLRKKPN Connect(IPEndPoint target, YMUYYZRTLWM connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6550", Offset = "0x8BF5550", VA = "0x188BF6550")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6560", Offset = "0x8BF5560", VA = "0x188BF6560")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4120", Offset = "0x8BF3120", VA = "0x188BF4120")]
		public void KUAENCXCTFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4050", Offset = "0x8BF3050", VA = "0x188BF4050")]
		public void KUAENCXCTFT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7840", Offset = "0x8BF6840", VA = "0x188BF7840")]
		public void WPJIYGSUTVM(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7880", Offset = "0x8BF6880", VA = "0x188BF7880")]
		public void WPJIYGSUTVM(OCQTFLRKKPN a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BF11F0", Offset = "0x8BF01F0", VA = "0x188BF11F0", Slot = "4")]
		private IEnumerator<OCQTFLRKKPN> AVEGICOYTWF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3060", Offset = "0x8BF2060", VA = "0x188BF3060", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BF72E0", Offset = "0x8BF62E0", VA = "0x188BF72E0")]
		private CYUJJFYJAMH WESZGSNGUGX(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BF73D0", Offset = "0x8BF63D0", VA = "0x188BF73D0")]
		private CYUJJFYJAMH WESZGSNGUGX(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7F20", Offset = "0x8BF6F20", VA = "0x188BF7F20")]
		internal CYUJJFYJAMH XWGUBPRMQVA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7CB0", Offset = "0x8BF6CB0", VA = "0x188BF7CB0")]
		internal void XKGTVUAQUVJ(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8520", Offset = "0x8BF7520", VA = "0x188BF8520")]
		static GOANXSKKOIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE7EB50", Offset = "0xE7DB50", VA = "0x180E7EB50")]
		private bool CZNZYGZCSPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7180", Offset = "0x8BF6180", VA = "0x188BF7180")]
		private void VVRDJMWMWWM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF35A0", Offset = "0x8BF25A0", VA = "0x188BF35A0")]
		private void JHLLBKYTTWL(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2EC0", Offset = "0x8BF1EC0", VA = "0x188BF2EC0")]
		private bool GEYQRICKIUR(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1280", Offset = "0x8BF0280", VA = "0x188BF1280")]
		private void BLGTBTEQEPU(XYZFMNSORLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4210", Offset = "0x8BF3210", VA = "0x188BF4210")]
		private void MXHIJGTRYPN(VUAUYYXFOFY a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF74B0", Offset = "0x8BF64B0", VA = "0x188BF74B0")]
		private void WLSKFIOGGAB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5D30", Offset = "0x8BF4D30", VA = "0x188BF5D30")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5AB0", Offset = "0x8BF4AB0", VA = "0x188BF5AB0")]
		internal int ROIKABCFZPI(CYUJJFYJAMH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BF36F0", Offset = "0x8BF26F0", VA = "0x188BF36F0")]
		internal int JUJEVSALHPO(CYUJJFYJAMH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3730", Offset = "0x8BF2730", VA = "0x188BF3730")]
		internal int JUJEVSALHPO(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3420", Offset = "0x8BF2420", VA = "0x188BF3420")]
		internal void IZIBNEMWSZT(bool a)
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
	internal sealed class CYUJJFYJAMH
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int BBLNNJANDYQ;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] HDUQOWTEWYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] MEOWWMOYJYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int GRKCQGJVSOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object NHJAPDMHDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public CYUJJFYJAMH WOQMWIAUPTH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty IFWWVKYBDVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDDD0", Offset = "0x8BECDD0", VA = "0x188BEDDD0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BED930", Offset = "0x8BEC930", VA = "0x188BED930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte FDGKRNYVTFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDBF0", Offset = "0x8BECBF0", VA = "0x188BEDBF0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDB90", Offset = "0x8BECB90", VA = "0x188BEDB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort GOKTHNKTCUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDC50", Offset = "0x8BECC50", VA = "0x188BEDC50")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDD90", Offset = "0x8BECD90", VA = "0x188BEDD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KOQLWLSRTCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BED9B0", Offset = "0x8BEC9B0", VA = "0x188BED9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte WYEXHECRDZI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8BED8E0", Offset = "0x8BEC8E0", VA = "0x188BED8E0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDC20", Offset = "0x8BECC20", VA = "0x188BEDC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort UKGEKTZAIJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDBD0", Offset = "0x8BECBD0", VA = "0x188BEDBD0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8BED9E0", Offset = "0x8BEC9E0", VA = "0x188BED9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort YQYKFSMHSPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8BED910", Offset = "0x8BEC910", VA = "0x188BED910")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDB50", Offset = "0x8BECB50", VA = "0x188BEDB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort EJMTTFVWBWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8BEDD70", Offset = "0x8BECD70", VA = "0x188BEDD70")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BED970", Offset = "0x8BEC970", VA = "0x188BED970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDE00", Offset = "0x8BECE00", VA = "0x188BEDE00")]
		static CYUJJFYJAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDB20", Offset = "0x8BECB20", VA = "0x188BEDB20")]
		public void MPNPMSRWUYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE0D0", Offset = "0x8BED0D0", VA = "0x188BEE0D0")]
		public CYUJJFYJAMH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BEE140", Offset = "0x8BED140", VA = "0x188BEE140")]
		public CYUJJFYJAMH(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDC70", Offset = "0x8BECC70", VA = "0x188BEDC70")]
		public static int RXVTEMZPECM(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDCE0", Offset = "0x8BECCE0", VA = "0x188BEDCE0")]
		public int RXVTEMZPECM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDA20", Offset = "0x8BECA20", VA = "0x188BEDA20")]
		public bool LNTMPLQJGUV()
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
	public class OCQTFLRKKPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class FUAGTJYUAYF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public CYUJJFYJAMH[] JNRFHDJVOAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int IIRNGKLEWFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int TJGDBMIFGML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte WYEXHECRDZI;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FUAGTJYUAYF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int GPINWIPAUIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int PUGPAETLRXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int LDYMFZWORPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double BSELMJLYYRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int BZNRCFXVCVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int PGXWNLIBQWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int XQCJHJHBNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch EWYRZRLYPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int PFEQRUPHYBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long DXDUBKEBCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object UBNKZGHKNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal OCQTFLRKKPN GMSSQISIQIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal OCQTFLRKKPN OGCEJUNPKAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<CYUJJFYJAMH> ODCRUCQYOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<MZKDLBKFQPW> CBAJXSEJOTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly MZKDLBKFQPW[] YPDVVFOJMTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int JYOGXJLTFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int DDEUKBGXIWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool TCAEQVSTKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int KGWRLNMDGRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int VGKQJDKWCNF;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int JFFHDEJCSVB = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int WOJKSCGXMKU = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object FCDDESJSBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int YCRMCBKWHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, FUAGTJYUAYF> MLWEJFWJCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> LENQPSTMACY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly CYUJJFYJAMH XGDKTKRRDUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int UIYHRCOWQZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int ALRMLWNKLZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint TJSNEIBSMUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int NYVTMAIYJIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int DMWWEFLDTKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long NGOTOCRTGSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte NQHZGRNPVGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState NCAETGIVPRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private CYUJJFYJAMH CTIPDZYTUYX;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int CRCHJVZEQMF = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int FBHIIINNAEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly CYUJJFYJAMH JMGGBAYVCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly CYUJJFYJAMH POJYQUPRUKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly CYUJJFYJAMH AFIVMHJWLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly CYUJJFYJAMH BMVLVOXOJQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality BENECNYCSPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly GOANXSKKOIS GOANXSKKOIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int JQCTFOCWOYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object XJBEZQBRMSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly THENRQPHNHO YZYDWFFJVTR;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte IPPOJGGWCTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD37680", Offset = "0xD36680", VA = "0x180D37680")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BFC160", Offset = "0x8BFB160", VA = "0x188BFC160")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint YIHNLWXFZYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE76A50", Offset = "0xE75A50", VA = "0x180E76A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState WPXQOVCXGZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x14B2310", Offset = "0x14B1310", VA = "0x1814B2310")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long CIIATORKXPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD0DBB0", Offset = "0xD0CBB0", VA = "0x180D0DBB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int CMWYGMPHNGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2249100", Offset = "0x2248100", VA = "0x182249100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2358890", Offset = "0x2357890", VA = "0x182358890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int AEPNNXYTLUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE310", Offset = "0x8BFD310", VA = "0x188BFE310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int PVONBMMDATT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD27F80", Offset = "0xD26F80", VA = "0x180D27F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double YUTRINPMXGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2ADECE0", Offset = "0x2ADDCE0", VA = "0x182ADECE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate QHPAZVRQBWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BFC060", Offset = "0x8BFB060", VA = "0x188BFC060")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE320", Offset = "0x8BFD320", VA = "0x188BFE320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF210", Offset = "0x8BFE210", VA = "0x188BFF210")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE4E0", Offset = "0x8BFD4E0", VA = "0x188BFE4E0")]
		internal void RPEVXJECHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF1E0", Offset = "0x8BFE1E0", VA = "0x188BFF1E0")]
		internal void WNEBNTZMCMW(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD3E0", Offset = "0x8BFC3E0", VA = "0x188BFD3E0")]
		internal void GMYDFJAZERX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE3D0", Offset = "0x8BFD3D0", VA = "0x188BFE3D0")]
		private void RKREQNMKRQA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE4A0", Offset = "0x8BFD4A0", VA = "0x188BFE4A0")]
		private void RKRKYLFLMSI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBA80", Offset = "0x8BFAA80", VA = "0x188BFBA80")]
		public int CPAHDYGIBBY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBB90", Offset = "0x8BFAB90", VA = "0x188BFBB90")]
		public int CPAHDYGIBBY(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB850", Offset = "0x8BFA850", VA = "0x188BFB850")]
		private MZKDLBKFQPW ALHJSUTODAL(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF7F0", Offset = "0x8BFE7F0", VA = "0x188BFF7F0")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, IPEndPoint b, int c, byte d, YMUYYZRTLWM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF610", Offset = "0x8BFE610", VA = "0x188BFF610")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, FULTMNFEJJL b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE500", Offset = "0x8BFD500", VA = "0x188BFE500")]
		internal void Reject(EEIAXPLQIVG requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE550", Offset = "0x8BFD550", VA = "0x188BFE550")]
		internal bool SCEQTRNWUXP(LHLSOUSYCDZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE920", Offset = "0x8BFD920", VA = "0x188BFE920")]
		public void UBSUEOKZGUG(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC8B0", Offset = "0x8BFB8B0", VA = "0x188BFC8B0")]
		private void FFHEPJOZIKX(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC110", Offset = "0x8BFB110", VA = "0x188BFC110")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB9E0", Offset = "0x8BFA9E0", VA = "0x188BFB9E0")]
		internal DisconnectResult CHWVAVKYABJ(CYUJJFYJAMH a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD470", Offset = "0x8BFC470", VA = "0x188BFD470")]
		internal void HVPULIRNCZC(MZKDLBKFQPW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE5D0", Offset = "0x8BFD5D0", VA = "0x188BFE5D0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE8E0", Offset = "0x8BFD8E0", VA = "0x188BFE8E0")]
		private void TQYAZDOELDP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD4D0", Offset = "0x8BFC4D0", VA = "0x188BFD4D0")]
		internal void LBDELCVZUWB(DeliveryMethod a, CYUJJFYJAMH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCEA0", Offset = "0x8BFBEA0", VA = "0x188BFCEA0")]
		private void FQPPIRXRTNB(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BFDD70", Offset = "0x8BFCD70", VA = "0x188BFDD70")]
		private void NLRIEEJPOIT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE950", Offset = "0x8BFD950", VA = "0x188BFE950")]
		internal ConnectRequestResult ULYSYQEWQEO(EEIAXPLQIVG a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC210", Offset = "0x8BFB210", VA = "0x188BFC210")]
		internal void ENPPMPFUXFL(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBF10", Offset = "0x8BFAF10", VA = "0x188BFBF10")]
		private void CWJATSQXGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE100", Offset = "0x8BFD100", VA = "0x188BFE100")]
		internal void OCTLINGEQTD(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BFEB10", Offset = "0x8BFDB10", VA = "0x188BFEB10")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBCB0", Offset = "0x8BFACB0", VA = "0x188BFBCB0")]
		internal void CUGDAXCRPVN(CYUJJFYJAMH a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class THENRQPHNHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long JTBNSAOHNXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long YOQHHOHWUYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long ZEHXVZHRNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long UKEZXPWEGST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long FOQXSHVPCPI;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long IHGCSJOALAV;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long CJXMZKVXGEA;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long IICVLRODWGL;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long XBZXQHYEYJA;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long KTLISVQLAVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long MLMIXVTRPYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long YBKCXKTYTPU;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long JFCJMZRKZOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8C01040", Offset = "0x8C00040", VA = "0x188C01040")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long FKKJLNQQCFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8C01030", Offset = "0x8C00030", VA = "0x188C01030")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long SQIEECQQMVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8C01160", Offset = "0x8C00160", VA = "0x188C01160")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long KNGHKAYILGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8C01510", Offset = "0x8C00510", VA = "0x188C01510")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long UDTISHDKIQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8C00F00", Offset = "0x8BFFF00", VA = "0x188C00F00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long DJPLLIPFGIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8C01050", Offset = "0x8C00050", VA = "0x188C01050")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long POSMUPVXQEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8C01580", Offset = "0x8C00580", VA = "0x188C01580")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long VHQFQIKEBTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8C015C0", Offset = "0x8C005C0", VA = "0x188C015C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality GWWUJKNKCMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x141A3C0", Offset = "0x14193C0", VA = "0x18141A3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double CMJSHUKWSHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8C00EA0", Offset = "0x8BFFEA0", VA = "0x188C00EA0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C01120", Offset = "0x8C00120", VA = "0x188C01120")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8C014B0", Offset = "0x8C004B0", VA = "0x188C014B0")]
		public void UHVFBCGTZDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C01060", Offset = "0x8C00060", VA = "0x188C01060")]
		public void OHTUPUBNMLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C00E30", Offset = "0x8BFFE30", VA = "0x188C00E30")]
		public void AAZJYVQYCWY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C010B0", Offset = "0x8C000B0", VA = "0x188C010B0")]
		public void QWVFJZRCYQF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C01520", Offset = "0x8C00520", VA = "0x188C01520")]
		public void XHQQPSKTYOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8C00F10", Offset = "0x8BFFF10", VA = "0x188C00F10")]
		public void FZRQVMVLUJO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8C01170", Offset = "0x8C00170", VA = "0x188C01170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8C00F90", Offset = "0x8BFFF90", VA = "0x188C00F90")]
		public void GNPRLKREERE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public THENRQPHNHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class XTOMARFUGXW
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> RUPQYDLNSXX;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8C034F0", Offset = "0x8C024F0", VA = "0x188C034F0")]
		public static IPEndPoint RVNHWWUSBDN(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8C03730", Offset = "0x8C02730", VA = "0x188C03730")]
		public static IPAddress YJCSEMUJHHC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8C03900", Offset = "0x8C02900", VA = "0x188C03900")]
		public static IPAddress YJCSEMUJHHC(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8C034C0", Offset = "0x8C024C0", VA = "0x188C034C0")]
		internal static int FCNLREWYGZO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4143640", Offset = "0x4142640", VA = "0x184143640")]
		internal static T[] QECRDCFVWSB<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class WFKFWLWBQYZ : MZKDLBKFQPW
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private CYUJJFYJAMH _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8C00530", Offset = "0x8BFF530", VA = "0x188C00530", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8C005A0", Offset = "0x8BFF5A0", VA = "0x188C005A0")]
			public void WNCQWZWPKZY(CYUJJFYJAMH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8C004C0", Offset = "0x8BFF4C0", VA = "0x188C004C0")]
			public bool THQXHICLCVJ(long a, OCQTFLRKKPN b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8C00470", Offset = "0x8BFF470", VA = "0x188C00470")]
			public bool Clear(OCQTFLRKKPN peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly CYUJJFYJAMH NKGRPJTVMYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] LHEAUSRFVOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly CYUJJFYJAMH[] VSMAMHDIYSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] VTEJTRGKFRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int QHVQWDGOEZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int EIXYGYNLSPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int DIRRAOIORAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int SQYTZCJFOSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool BPCJNLSZRYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod VHYHCEUFYQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool QSJEYNQVVWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int GFOKIHWAAHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte PJJRKHCGOEI;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int SHCAQSKNQDF
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8C02360", Offset = "0x8C01360", VA = "0x188C02360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8C031C0", Offset = "0x8C021C0", VA = "0x188C031C0")]
		public WFKFWLWBQYZ(OCQTFLRKKPN a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8C02370", Offset = "0x8C01370", VA = "0x188C02370")]
		private void AZSJCPXNYQC(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8C02CF0", Offset = "0x8C01CF0", VA = "0x188C02CF0", Slot = "4")]
		protected override bool ETQCRWXQJRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8C026F0", Offset = "0x8C016F0", VA = "0x188C026F0", Slot = "5")]
		public override bool ENPPMPFUXFL(CYUJJFYJAMH a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class FHBYOFDWPLY : MZKDLBKFQPW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int JBIONRXDMLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort EIXYGYNLSPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool FBURNPHUAHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CYUJJFYJAMH JSSEKCGYSOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly CYUJJFYJAMH RWLQINZUKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool GBUBKIMMWFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte PJJRKHCGOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long ALIXKVKUJNA;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF7E0", Offset = "0x8BEE7E0", VA = "0x188BEF7E0")]
		public FHBYOFDWPLY(OCQTFLRKKPN a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF320", Offset = "0x8BEE320", VA = "0x188BEF320", Slot = "4")]
		protected override bool ETQCRWXQJRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF0A0", Offset = "0x8BEE0A0", VA = "0x188BEF0A0", Slot = "5")]
		public override bool ENPPMPFUXFL(CYUJJFYJAMH a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class SUZELTEIRKD
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
		[Cpp2IlInjected.Address(RVA = "0x8BED350", Offset = "0x8BEC350", VA = "0x188BED350")]
		private static void WPWXNOFAEYI(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8C00CD0", Offset = "0x8BFFCD0", VA = "0x188C00CD0")]
		private static void WPWXNOFAEYI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8C00DF0", Offset = "0x8BFFDF0", VA = "0x188C00DF0")]
		public static void WPWXNOFAEYI(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8C00D50", Offset = "0x8BFFD50", VA = "0x188C00D50")]
		public static void SHZWPQEXDJR(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8C00D70", Offset = "0x8BFFD70", VA = "0x188C00D70")]
		public static void SHZWPQEXDJR(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8C00DF0", Offset = "0x8BFFDF0", VA = "0x188C00DF0")]
		public static void SHZWPQEXDJR(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8C00DF0", Offset = "0x8BFFDF0", VA = "0x188C00DF0")]
		public static void SHZWPQEXDJR(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8C00CD0", Offset = "0x8BFFCD0", VA = "0x188C00CD0")]
		public static void SHZWPQEXDJR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8C00CD0", Offset = "0x8BFFCD0", VA = "0x188C00CD0")]
		public static void SHZWPQEXDJR(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8C00D40", Offset = "0x8BFFD40", VA = "0x188C00D40")]
		public static void SHZWPQEXDJR(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8C00D40", Offset = "0x8BFFD40", VA = "0x188C00D40")]
		public static void SHZWPQEXDJR(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class VSOHZOVUZLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] NCLGWVOFYWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int HUTEZHGCZQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int UZGIMKMOMVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int ZIALZIVLBOK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] MEOWWMOYJYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DKVZRBHFTOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int ZTVLDQSLGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8C01BB0", Offset = "0x8C00BB0", VA = "0x188C01BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GYQALBISFUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A4F0", Offset = "0x2A394F0", VA = "0x182A3A4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int OAPUUWRXKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8C01B70", Offset = "0x8C00B70", VA = "0x188C01B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8C01D80", Offset = "0x8C00D80", VA = "0x188C01D80")]
		public void PQIIPNZHDCN(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public VSOHZOVUZLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8C02300", Offset = "0x8C01300", VA = "0x188C02300")]
		public VSOHZOVUZLK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8C02230", Offset = "0x8C01230", VA = "0x188C02230")]
		public IPEndPoint YNNGYCFOEES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8C02050", Offset = "0x8C01050", VA = "0x188C02050")]
		public byte UQIAHDOMCWS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8C02050", Offset = "0x8C01050", VA = "0x188C02050")]
		public sbyte THBZLGHERYD()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x40DC7D0", Offset = "0x40DB7D0", VA = "0x1840DC7D0")]
		public a[] HBZHQVGUJBT<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8C01BC0", Offset = "0x8C00BC0", VA = "0x188C01BC0")]
		public bool[] JWXQXHOYBGZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C01C00", Offset = "0x8C00C00", VA = "0x188C01C00")]
		public ushort[] KDWGWPYMEYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8C02010", Offset = "0x8C01010", VA = "0x188C02010")]
		public short[] QLTQWOJBBID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8C022C0", Offset = "0x8C012C0", VA = "0x188C022C0")]
		public int[] ZWGMCNDDGPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8C021F0", Offset = "0x8C011F0", VA = "0x188C021F0")]
		public uint[] YEBGEDVUPQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C020D0", Offset = "0x8C010D0", VA = "0x188C020D0")]
		public float[] UNWJZUPLWVF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8C01DC0", Offset = "0x8C00DC0", VA = "0x188C01DC0")]
		public double[] PTDTJDXINYG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8C01AF0", Offset = "0x8C00AF0", VA = "0x188C01AF0")]
		public long[] EOBPLXYEZNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C01B30", Offset = "0x8C00B30", VA = "0x188C01B30")]
		public ulong[] GHIJOTALFZA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8C01C70", Offset = "0x8C00C70", VA = "0x188C01C70")]
		public string[] LFXLWXHZAIW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8C01D40", Offset = "0x8C00D40", VA = "0x188C01D40")]
		public bool LMYOCXVGACQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8C01AA0", Offset = "0x8C00AA0", VA = "0x188C01AA0")]
		public char BJAUHHNKYPS()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8C01AA0", Offset = "0x8C00AA0", VA = "0x188C01AA0")]
		public ushort IROSXOZYRTJ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8C01AA0", Offset = "0x8C00AA0", VA = "0x188C01AA0")]
		public short QYXXDIYAIGK()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8C02110", Offset = "0x8C01110", VA = "0x188C02110")]
		public long VACXPISJHOK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8C02110", Offset = "0x8C01110", VA = "0x188C02110")]
		public ulong XYIFTFCYFHL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8C01B80", Offset = "0x8C00B80", VA = "0x188C01B80")]
		public int XFGLJJICOSJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8C01B80", Offset = "0x8C00B80", VA = "0x188C01B80")]
		public uint IALCTCPREME()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8C01A70", Offset = "0x8C00A70", VA = "0x188C01A70")]
		public float BICZAKOTTES()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8C01C40", Offset = "0x8C00C40", VA = "0x188C01C40")]
		public double KLYPMKLFQSF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8C01E00", Offset = "0x8C00E00", VA = "0x188C01E00")]
		public string QGOSMAICKCR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8C02180", Offset = "0x8C01180", VA = "0x188C02180")]
		public ArraySegment<byte> WFELUJTQFYM(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8C02140", Offset = "0x8C01140", VA = "0x188C02140")]
		public sbyte[] VDFRNFBMHGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8C02090", Offset = "0x8C01090", VA = "0x188C02090")]
		public byte[] UFZGNDFQTPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8C01AD0", Offset = "0x8C00AD0", VA = "0x188C01AD0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class YMUYYZRTLWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] NCLGWVOFYWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int HUTEZHGCZQO;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int XOBNPJLDOXX = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool KOWGBVXMDPA;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding NIXGXJWVOJM;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int FZQIEZZIDFZ = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] DUICDIINGKW;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] HBLTVDNEEXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8C047E0", Offset = "0x8C037E0", VA = "0x188C047E0")]
		public YMUYYZRTLWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8C04740", Offset = "0x8C03740", VA = "0x188C04740")]
		public YMUYYZRTLWM(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8C04080", Offset = "0x8C03080", VA = "0x188C04080")]
		public static YMUYYZRTLWM HQKDKSPPNUV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8C041D0", Offset = "0x8C031D0", VA = "0x188C041D0")]
		public void QEONIRHQLDZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2E90", Offset = "0x2AB1E90", VA = "0x182AB2E90")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8C03CB0", Offset = "0x8C02CB0", VA = "0x188C03CB0")]
		public void FFTUNRFWXCB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8C03F00", Offset = "0x8C02F00", VA = "0x188C03F00")]
		public void FFTUNRFWXCB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8C03D50", Offset = "0x8C02D50", VA = "0x188C03D50")]
		public void FFTUNRFWXCB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8C03D50", Offset = "0x8C02D50", VA = "0x188C03D50")]
		public void FFTUNRFWXCB(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8C03E10", Offset = "0x8C02E10", VA = "0x188C03E10")]
		public void FFTUNRFWXCB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8C03E10", Offset = "0x8C02E10", VA = "0x188C03E10")]
		public void FFTUNRFWXCB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8C03C40", Offset = "0x8C02C40", VA = "0x188C03C40")]
		public void FFTUNRFWXCB(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8C03C40", Offset = "0x8C02C40", VA = "0x188C03C40")]
		public void FFTUNRFWXCB(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8C03C40", Offset = "0x8C02C40", VA = "0x188C03C40")]
		public void FFTUNRFWXCB(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8C03EA0", Offset = "0x8C02EA0", VA = "0x188C03EA0")]
		public void FFTUNRFWXCB(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8C03EA0", Offset = "0x8C02EA0", VA = "0x188C03EA0")]
		public void FFTUNRFWXCB(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8C03DA0", Offset = "0x8C02DA0", VA = "0x188C03DA0")]
		public void FFTUNRFWXCB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8C040F0", Offset = "0x8C030F0", VA = "0x188C040F0")]
		public void MRLSCCDQWIR(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8C040F0", Offset = "0x8C030F0", VA = "0x188C040F0")]
		public void VFREJXATEJK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8C04020", Offset = "0x8C03020", VA = "0x188C04020")]
		public void FFTUNRFWXCB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8C045E0", Offset = "0x8C035E0", VA = "0x188C045E0")]
		public void RJIYCXXWJNE(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8C04430", Offset = "0x8C03430", VA = "0x188C04430")]
		public void RJIYCXXWJNE(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8C04270", Offset = "0x8C03270", VA = "0x188C04270")]
		public void RJIYCXXWJNE(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8C04270", Offset = "0x8C03270", VA = "0x188C04270")]
		public void RJIYCXXWJNE(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8C04270", Offset = "0x8C03270", VA = "0x188C04270")]
		public void RJIYCXXWJNE(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8C04430", Offset = "0x8C03430", VA = "0x188C04430")]
		public void RJIYCXXWJNE(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8C04430", Offset = "0x8C03430", VA = "0x188C04430")]
		public void RJIYCXXWJNE(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8C04350", Offset = "0x8C03350", VA = "0x188C04350")]
		public void RJIYCXXWJNE(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8C04350", Offset = "0x8C03350", VA = "0x188C04350")]
		public void RJIYCXXWJNE(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8C040F0", Offset = "0x8C030F0", VA = "0x188C040F0")]
		public void RJIYCXXWJNE(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8C04510", Offset = "0x8C03510", VA = "0x188C04510")]
		public void RJIYCXXWJNE(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8C03F50", Offset = "0x8C02F50", VA = "0x188C03F50")]
		public void FFTUNRFWXCB(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8C03C30", Offset = "0x8C02C30", VA = "0x188C03C30")]
		public void FFTUNRFWXCB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8C03A20", Offset = "0x8C02A20", VA = "0x188C03A20")]
		public void FFTUNRFWXCB(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class UJRNQXRYGIR
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class OBMBUEPLJDD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong JQCTFOCWOYF;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x73C9040", Offset = "0x73C8040", VA = "0x1873C9040")]
			static OBMBUEPLJDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(VSOHZOVUZLK reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class INBVDQUOBSO<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public UJRNQXRYGIR DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a UZANWKKXSMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> AAKJBTABFJI;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public INBVDQUOBSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x66861C0", Offset = "0x66851C0", VA = "0x1866861C0")]
			internal void CLDWEDWEDWB(VSOHZOVUZLK a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class BQFULXHEJJU<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public UJRNQXRYGIR DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a UZANWKKXSMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> AAKJBTABFJI;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BQFULXHEJJU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3EC0", Offset = "0x4FC2EC0", VA = "0x184FC3EC0")]
			internal void CLDWEDWEDWB(VSOHZOVUZLK a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GOTNJHNBWPZ PUKCHAGKXJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> MMWDYYYCRJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly YMUYYZRTLWM TQPBXUNEJBR;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8C01920", Offset = "0x8C00920", VA = "0x188C01920")]
		public UJRNQXRYGIR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x40A4750", Offset = "0x40A3750", VA = "0x1840A4750", Slot = "4")]
		protected virtual ulong ADRSLHKBOPW<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8C01850", Offset = "0x8C00850", VA = "0x188C01850", Slot = "5")]
		protected virtual SubscribeDelegate WJIWHOATRNF(VSOHZOVUZLK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x40A47D0", Offset = "0x40A37D0", VA = "0x1840A47D0", Slot = "6")]
		protected virtual void BXJSBLSQHOX<b>(YMUYYZRTLWM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8C017D0", Offset = "0x8C007D0", VA = "0x188C017D0")]
		public void RDUXMLZQZAU(VSOHZOVUZLK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x40A4B50", Offset = "0x40A3B50", VA = "0x1840A4B50")]
		public void SQIRBZBNMTZ<j>(YMUYYZRTLWM a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8C01780", Offset = "0x8C00780", VA = "0x188C01780")]
		public void AMLNAAAGJTK(VSOHZOVUZLK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x40A49D0", Offset = "0x40A39D0", VA = "0x1840A49D0")]
		public void DXPECKOEYCZ<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x40A49D0", Offset = "0x40A39D0", VA = "0x1840A49D0")]
		public void DXPECKOEYCZ<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8C30", Offset = "0x8BF7C30", VA = "0x188BF8C30")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8C00410", Offset = "0x8BFF410", VA = "0x188C00410")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class GOTNJHNBWPZ
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
		private abstract class DUMYYWEGFOV<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType XYUHIEMAMOM;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5453870", Offset = "0x5452870", VA = "0x185453870", Slot = "4")]
			public virtual void WNCQWZWPKZY(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void LYKZYHORDOU(a a, VSOHZOVUZLK b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void SQIRBZBNMTZ(a a, YMUYYZRTLWM b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void BLYRCTESPYN(a a, VSOHZOVUZLK b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void MNPXBCKTGYM(a a, YMUYYZRTLWM b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void FLOXBPKQHYQ(a a, VSOHZOVUZLK b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void BKACKDXHLRJ(a a, YMUYYZRTLWM b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			protected DUMYYWEGFOV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class OZHLFTJLQJS<a, b> : DUMYYWEGFOV<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> EWVMLGUYDTV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> JASAWTDEKNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> FJDUZKMEKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> PSEZJSDFHEW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> JFHMRMAWUJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> CUZGWEDHYSH;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x73F9AA0", Offset = "0x73F8AA0", VA = "0x1873F9AA0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x73F9AA0", Offset = "0x73F8AA0", VA = "0x1873F9AA0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x73F99D0", Offset = "0x73F89D0", VA = "0x1873F99D0", Slot = "9")]
			public override void FLOXBPKQHYQ(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x73F99D0", Offset = "0x73F89D0", VA = "0x1873F99D0", Slot = "10")]
			public override void BKACKDXHLRJ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x73F9CE0", Offset = "0x73F8CE0", VA = "0x1873F9CE0")]
			protected b[] SSFRGOFLYDD(a a, VSOHZOVUZLK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x73F9B70", Offset = "0x73F8B70", VA = "0x1873F9B70")]
			protected b[] NUENPNNMTUA(a a, YMUYYZRTLWM b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x73F9FA0", Offset = "0x73F8FA0", VA = "0x1873F9FA0", Slot = "4")]
			public override void WNCQWZWPKZY(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x73FAAE0", Offset = "0x73F9AE0", VA = "0x1873FAAE0")]
			protected OZHLFTJLQJS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class HTDKUIFRPZZ<a, b> : OZHLFTJLQJS<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void LXDSYVBGNGM(VSOHZOVUZLK a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void LKTAQKPMJSP(YMUYYZRTLWM a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x654E900", Offset = "0x654D900", VA = "0x18654E900", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x654EDB0", Offset = "0x654DDB0", VA = "0x18654EDB0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x654E750", Offset = "0x654D750", VA = "0x18654E750", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x654EB10", Offset = "0x654DB10", VA = "0x18654EB10", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x654F000", Offset = "0x654E000", VA = "0x18654F000")]
			protected HTDKUIFRPZZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class TZVQQZPPRKC<a> : OZHLFTJLQJS<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x544F160", Offset = "0x544E160", VA = "0x18544F160", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x544F400", Offset = "0x544E400", VA = "0x18544F400", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7BF2280", Offset = "0x7BF1280", VA = "0x187BF2280", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x544F1B0", Offset = "0x544E1B0", VA = "0x18544F1B0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public TZVQQZPPRKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class DSJNUBORLRR<a> : OZHLFTJLQJS<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x544F160", Offset = "0x544E160", VA = "0x18544F160", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x544F400", Offset = "0x544E400", VA = "0x18544F400", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x544EEF0", Offset = "0x544DEF0", VA = "0x18544EEF0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x544F1B0", Offset = "0x544E1B0", VA = "0x18544F1B0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public DSJNUBORLRR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class SRTNHKMNLQV<a> : OZHLFTJLQJS<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x72E6140", Offset = "0x72E5140", VA = "0x1872E6140", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x72E6520", Offset = "0x72E5520", VA = "0x1872E6520", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x7A81980", Offset = "0x7A80980", VA = "0x187A81980", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x72E63D0", Offset = "0x72E53D0", VA = "0x1872E63D0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public SRTNHKMNLQV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class AAHMBTJRIRG<a> : OZHLFTJLQJS<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x72E6140", Offset = "0x72E5140", VA = "0x1872E6140", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x72E6520", Offset = "0x72E5520", VA = "0x1872E6520", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x72E60F0", Offset = "0x72E50F0", VA = "0x1872E60F0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x72E63D0", Offset = "0x72E53D0", VA = "0x1872E63D0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public AAHMBTJRIRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class DSHGHMTMMJT<a> : OZHLFTJLQJS<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x544EAA0", Offset = "0x544DAA0", VA = "0x18544EAA0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x544ED60", Offset = "0x544DD60", VA = "0x18544ED60", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x544E950", Offset = "0x544D950", VA = "0x18544E950", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x544ED20", Offset = "0x544DD20", VA = "0x18544ED20", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public DSHGHMTMMJT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class DTXWZSRVTAW<a> : OZHLFTJLQJS<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x544EAA0", Offset = "0x544DAA0", VA = "0x18544EAA0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x544ED60", Offset = "0x544DD60", VA = "0x18544ED60", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x5453630", Offset = "0x5452630", VA = "0x185453630", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x544ED20", Offset = "0x544DD20", VA = "0x18544ED20", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public DTXWZSRVTAW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class MTROMMVRZKR<a> : OZHLFTJLQJS<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x654B570", Offset = "0x654A570", VA = "0x18654B570", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x654B710", Offset = "0x654A710", VA = "0x18654B710", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x703B6A0", Offset = "0x703A6A0", VA = "0x18703B6A0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x654B5C0", Offset = "0x654A5C0", VA = "0x18654B5C0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public MTROMMVRZKR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class HIBGCMANYWI<a> : OZHLFTJLQJS<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x654B570", Offset = "0x654A570", VA = "0x18654B570", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x654B710", Offset = "0x654A710", VA = "0x18654B710", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x654B300", Offset = "0x654A300", VA = "0x18654B300", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x654B5C0", Offset = "0x654A5C0", VA = "0x18654B5C0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public HIBGCMANYWI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class TKHGXGYKFVL<a> : OZHLFTJLQJS<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x7BE2860", Offset = "0x7BE1860", VA = "0x187BE2860", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x7BE28B0", Offset = "0x7BE18B0", VA = "0x187BE28B0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x7BE25F0", Offset = "0x7BE15F0", VA = "0x187BE25F0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x544F1B0", Offset = "0x544E1B0", VA = "0x18544F1B0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public TKHGXGYKFVL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class NOWVTPOJXTE<a> : OZHLFTJLQJS<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x727D030", Offset = "0x727C030", VA = "0x18727D030", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x727D080", Offset = "0x727C080", VA = "0x18727D080", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x727CEC0", Offset = "0x727BEC0", VA = "0x18727CEC0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x544ED20", Offset = "0x544DD20", VA = "0x18544ED20", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public NOWVTPOJXTE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class QMEIHHVTEAH<a> : OZHLFTJLQJS<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x777CC60", Offset = "0x777BC60", VA = "0x18777CC60", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x777CEE0", Offset = "0x777BEE0", VA = "0x18777CEE0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x777CB10", Offset = "0x777BB10", VA = "0x18777CB10", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x654B5C0", Offset = "0x654A5C0", VA = "0x18654B5C0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x544EEB0", Offset = "0x544DEB0", VA = "0x18544EEB0")]
			public QMEIHHVTEAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class ECJUJADZAED<a> : HTDKUIFRPZZ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE790", Offset = "0x5BCD790", VA = "0x185BCE790", Slot = "12")]
			protected override void LKTAQKPMJSP(YMUYYZRTLWM a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE7C0", Offset = "0x5BCD7C0", VA = "0x185BCE7C0", Slot = "11")]
			protected override void LXDSYVBGNGM(VSOHZOVUZLK a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE7F0", Offset = "0x5BCD7F0", VA = "0x185BCE7F0")]
			public ECJUJADZAED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class FOSXNUHLVJR<a> : HTDKUIFRPZZ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x634D330", Offset = "0x634C330", VA = "0x18634D330", Slot = "12")]
			protected override void LKTAQKPMJSP(YMUYYZRTLWM a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x634D360", Offset = "0x634C360", VA = "0x18634D360", Slot = "11")]
			protected override void LXDSYVBGNGM(VSOHZOVUZLK a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE7F0", Offset = "0x5BCD7F0", VA = "0x185BCE7F0")]
			public FOSXNUHLVJR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class ZTDXMOMZFLQ<a> : OZHLFTJLQJS<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int FEGCYIMSBVT;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x519D000", Offset = "0x519C000", VA = "0x18519D000")]
			public ZTDXMOMZFLQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x519CB70", Offset = "0x519BB70", VA = "0x18519CB70", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x519CF60", Offset = "0x519BF60", VA = "0x18519CF60", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x519C9F0", Offset = "0x519B9F0", VA = "0x18519C9F0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x519CE00", Offset = "0x519BE00", VA = "0x18519CE00", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class WZPRMGXPCNW<a> : DUMYYWEGFOV<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo IFWWVKYBDVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type SIHAFIFIULD;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x877D7F0", Offset = "0x877C7F0", VA = "0x18877D7F0")]
			public WZPRMGXPCNW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x877D420", Offset = "0x877C420", VA = "0x18877D420", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x877D710", Offset = "0x877C710", VA = "0x18877D710", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x877D3D0", Offset = "0x877C3D0", VA = "0x18877D3D0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x877D3D0", Offset = "0x877C3D0", VA = "0x18877D3D0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x877D380", Offset = "0x877C380", VA = "0x18877D380", Slot = "9")]
			public override void FLOXBPKQHYQ(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x877D380", Offset = "0x877C380", VA = "0x18877D380", Slot = "10")]
			public override void BKACKDXHLRJ(a a, YMUYYZRTLWM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class OFKBMBINTMZ<a> : WZPRMGXPCNW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x73D20C0", Offset = "0x73D10C0", VA = "0x1873D20C0")]
			public OFKBMBINTMZ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x73D1E80", Offset = "0x73D0E80", VA = "0x1873D1E80", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x73D1F20", Offset = "0x73D0F20", VA = "0x1873D1F20", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class BCWIUDDHMPJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static BCWIUDDHMPJ<a> UXEDIFVFAQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly DUMYYWEGFOV<a>[] LOVKGAFNTRI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int WZGCGNAZAXJ;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4F52250", Offset = "0x4F51250", VA = "0x184F52250")]
			public BCWIUDDHMPJ(List<DUMYYWEGFOV<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4F51F50", Offset = "0x4F50F50", VA = "0x184F51F50")]
			public void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4F51EA0", Offset = "0x4F50EA0", VA = "0x184F51EA0")]
			public void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class IRUKJLBGIWH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract DUMYYWEGFOV<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private YMUYYZRTLWM STLQPMLNDOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int TPXGRQWQUZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, IRUKJLBGIWH> EAMJUHEOJOG;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8BA0", Offset = "0x8BF7BA0", VA = "0x188BF8BA0")]
		public GOTNJHNBWPZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF10B0", Offset = "0x3AF00B0", VA = "0x183AF10B0")]
		private BCWIUDDHMPJ<d> ZEGWPMQXANC<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0240", Offset = "0x3AEF240", VA = "0x183AF0240")]
		public void SIFQFAPRLAF<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0100", Offset = "0x3AEF100", VA = "0x183AF0100")]
		public bool Deserialize<T>(VSOHZOVUZLK reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0180", Offset = "0x3AEF180", VA = "0x183AF0180")]
		public void GHRXOLGFAHI<f>(YMUYYZRTLWM a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class FRXFAFKMYKS
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime CQGWRFPPIUV;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] REOQFNKXPEP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator YLGOXZWKFNR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8BF07B0", Offset = "0x8BEF7B0", VA = "0x188BF07B0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int ZLNBWHWGZYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BF07E0", Offset = "0x8BEF7E0", VA = "0x188BF07E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8BEF8A0", Offset = "0x8BEE8A0", VA = "0x188BEF8A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode VCPJRYGHJXB
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0230", Offset = "0x8BEF230", VA = "0x188BF0230")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BEFD80", Offset = "0x8BEED80", VA = "0x188BEFD80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int YKSHZYUQXJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0810", Offset = "0x8BEF810", VA = "0x188BF0810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint BNKOVPJRQEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0560", Offset = "0x8BEF560", VA = "0x188BF0560")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? FOEVBPSURLY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0530", Offset = "0x8BEF530", VA = "0x188BF0530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? MNCHTIJXFTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0780", Offset = "0x8BEF780", VA = "0x188BF0780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? HFAKIKNJXCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BEFF80", Offset = "0x8BEEF80", VA = "0x188BEFF80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BF0370", Offset = "0x8BEF370", VA = "0x188BF0370")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ZHPPITTELOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF87E50", Offset = "0xF86E50", VA = "0x180F87E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BF09A0", Offset = "0x8BEF9A0", VA = "0x188BF09A0")]
		public FRXFAFKMYKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0900", Offset = "0x8BEF900", VA = "0x188BF0900")]
		internal FRXFAFKMYKS(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0260", Offset = "0x8BEF260", VA = "0x188BF0260")]
		public static FRXFAFKMYKS RCSFIPQMQMQ(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFA00", Offset = "0x8BEEA00", VA = "0x188BEFA00")]
		internal void DRLSFSGCJYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFDC0", Offset = "0x8BEEDC0", VA = "0x188BEFDC0")]
		private void GXABVMOEHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0060", Offset = "0x8BEF060", VA = "0x188BF0060")]
		private DateTime? NQQHBMTFXQP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BF05C0", Offset = "0x8BEF5C0", VA = "0x188BF05C0")]
		private void VKYDOYCWEMP(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFFB0", Offset = "0x8BEEFB0", VA = "0x188BEFFB0")]
		private ulong KEHHSVZUUJB(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF8E0", Offset = "0x8BEE8E0", VA = "0x188BEF8E0")]
		private void DIIOJYRWUDR(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0840", Offset = "0x8BEF840", VA = "0x188BF0840")]
		private uint ZBPANHDGEMY(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8390", Offset = "0x8AB7390", VA = "0x188AB8390")]
		private static uint DLJLCNNSMLN(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF9A0", Offset = "0x8BEE9A0", VA = "0x188BEF9A0")]
		private static ulong DLJLCNNSMLN(ulong a)
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
	internal sealed class OPFRVABDNLZ
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int EKOIPIDWIQQ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int CGJBSKWXGUZ = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int ENUYKUUMKLI = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint HOMVCQEKQUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int ZQHOTVYAOLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int GDWXKQLADDO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool JAVWSDXPSOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x8BFF980", Offset = "0x8BFE980", VA = "0x188BFF980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF990", Offset = "0x8BFE990", VA = "0x188BFF990")]
		public bool UBSUEOKZGUG(VUAUYYXFOFY a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class PHJRDRCBAPJ : VUAUYYXFOFY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket ODSTMTZANSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly GOANXSKKOIS TZFZWFNWVZM;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short MBUDKUCDGHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x8BFFBF0", Offset = "0x8BFEBF0", VA = "0x188BFFBF0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int KKIPXQEPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8C00340", Offset = "0x8BFF340", VA = "0x188C00340", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint OSRBBYBPLSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8C002E0", Offset = "0x8BFF2E0", VA = "0x188C002E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily NHIOGIELQKU
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32C9110", Offset = "0x32C8110", VA = "0x1832C9110", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8C00360", Offset = "0x8BFF360", VA = "0x188C00360")]
		public PHJRDRCBAPJ(AddressFamily a, GOANXSKKOIS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFC10", Offset = "0x8BFEC10", VA = "0x188BFFC10", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8C00300", Offset = "0x8BFF300", VA = "0x188C00300", Slot = "9")]
		public int QXEJMNZAIML(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8C001F0", Offset = "0x8BFF1F0", VA = "0x188C001F0", Slot = "10")]
		public int JNDRQJDDSMV(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8C001D0", Offset = "0x8BFF1D0", VA = "0x188C001D0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface VUAUYYXFOFY
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short MBUDKUCDGHW
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int KKIPXQEPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint OSRBBYBPLSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily NHIOGIELQKU
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
		int QXEJMNZAIML(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int JNDRQJDDSMV(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x8BFB4E0", Offset = "0x8BFA4E0", VA = "0x188BFB4E0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB580", Offset = "0x8BFA580", VA = "0x188BFB580")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x163D350", Offset = "0x163C350", VA = "0x18163D350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB3F0", Offset = "0x8BFA3F0", VA = "0x188BFB3F0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB430", Offset = "0x8BFA430", VA = "0x188BFB430", Slot = "0")]
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
	public class XYZFMNSORLZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string VKPDZWSDVNB = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int JQGGVOGITER = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int HZNCJDLFKLZ = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int VQIZWPHGNIT = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> CTOQZPQZGZQ;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback TYGDGXRVVGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int SJLWTRNMCNX;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		internal void CMVXBYHCAXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		internal void HQHVHDPLAYR(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class KPIREJNTFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int QVHRJCTSBOH;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
		protected KPIREJNTFAE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FYMCQBNTUIO(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void TPIFIKAHQRP(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class NEVABRDQBVS : KPIREJNTFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] YVOBJQTFQPB;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator VFLBSXNIZRP;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3850", Offset = "0x2BB2850", VA = "0x182BB3850")]
		public NEVABRDQBVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB1E0", Offset = "0x8BFA1E0", VA = "0x188BFB1E0")]
		public void TVHLCXEIYGW(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAE00", Offset = "0x8BF9E00", VA = "0x188BFAE00")]
		public void PRWYBJNXAZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA9B0", Offset = "0x8BF99B0", VA = "0x188BFA9B0", Slot = "4")]
		public override void FYMCQBNTUIO(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAEE0", Offset = "0x8BF9EE0", VA = "0x188BFAEE0", Slot = "5")]
		public override void TPIFIKAHQRP(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class WBTTSEJPMZZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr NZKQIURKCYJ;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8C04C90", Offset = "0x8C03C90", VA = "0x188C04C90")]
			[BurstDiscard]
			private static void QGYXNOMWBVT(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8C04E20", Offset = "0x8C03E20", VA = "0x188C04E20")]
			private static IntPtr RVXPUZINCSJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8C04A40", Offset = "0x8C03A40", VA = "0x188C04A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C00B80", Offset = "0x8BFFB80", VA = "0x188C00B80")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8C009E0", Offset = "0x8BFF9E0", VA = "0x188C009E0")]
		private uint HKRQCHBIJXM(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8BED2A0", Offset = "0x8BEC2A0", VA = "0x188BED2A0")]
		private void UIFPEAZUUHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BECF00", Offset = "0x8BEBF00", VA = "0x188BECF00")]
		private void LULCZTTYNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8BED210", Offset = "0x8BEC210", VA = "0x188BED210")]
		private void RRWVWPLRHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8BED110", Offset = "0x8BEC110", VA = "0x188BED110")]
		private void OIIWUHDEKSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8C00C00", Offset = "0x8BFFC00", VA = "0x188C00C00")]
		private void SHXSGEOQYYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8C005C0", Offset = "0x8BFF5C0", VA = "0x188C005C0")]
		private unsafe void DMWXXUPTLLK(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8C00AC0", Offset = "0x8BFFAC0", VA = "0x188C00AC0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void JHREKJDNKSF([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8C00A10", Offset = "0x8BFFA10", VA = "0x188C00A10")]
		public static void JHREKJDNKSF(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8C00AD0", Offset = "0x8BFFAD0", VA = "0x188C00AD0")]
		public static void RQBALYEEJHH(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8C00C60", Offset = "0x8BFFC60", VA = "0x188C00C60")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void XIFOASSZLPG([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8C04A00", Offset = "0x8C03A00", VA = "0x188C04A00")]
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
