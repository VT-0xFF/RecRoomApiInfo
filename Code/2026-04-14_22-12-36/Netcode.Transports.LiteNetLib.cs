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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A5BFE0", Offset = "0x8A5ABE0", VA = "0x188A5BFE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A5BF90", Offset = "0x8A5AB90", VA = "0x188A5BF90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B490", Offset = "0x8A5A090", VA = "0x188A5B490")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B470", Offset = "0x8A5A070", VA = "0x188A5B470")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B2D0", Offset = "0x8A59ED0", VA = "0x188A5B2D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BDD0", Offset = "0x8A5A9D0", VA = "0x188A5BDD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B5A0", Offset = "0x8A5A1A0", VA = "0x188A5B5A0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B3E0", Offset = "0x8A59FE0", VA = "0x188A5B3E0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B870", Offset = "0x8A5A470", VA = "0x188A5B870", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BBB0", Offset = "0x8A5A7B0", VA = "0x188A5BBB0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AAF0", Offset = "0x8A596F0", VA = "0x188A5AAF0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AA00", Offset = "0x8A59600", VA = "0x188A5AA00", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AF00", Offset = "0x8A59B00", VA = "0x188A5AF00", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B800", Offset = "0x8A5A400", VA = "0x188A5B800", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B060", Offset = "0x8A59C60", VA = "0x188A5B060", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BDF0", Offset = "0x8A5A9F0", VA = "0x188A5BDF0")]
		private DeliveryMethod ZBIGXIELOYX(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AFA0", Offset = "0x8A59BA0", VA = "0x188A5AFA0", Slot = "16")]
		private void HTTUHBIAVOI(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A930", Offset = "0x8A59530", VA = "0x188A5A930", Slot = "17")]
		private void CTUFYUEMEJI(OCQTFLRKKPN a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "18")]
		private void DBHBQZWGNVX(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AD00", Offset = "0x8A59900", VA = "0x188A5AD00", Slot = "19")]
		private void FPVHCMHIPZI(OCQTFLRKKPN a, OQXRLZMXBEE b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AC30", Offset = "0x8A59830", VA = "0x188A5AC30")]
		private void FNAJUKCBPHL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "20")]
		private void IIQBTLXWPCI(IPEndPoint a, OQXRLZMXBEE b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "21")]
		private void QNNZWEUKELG(OCQTFLRKKPN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B270", Offset = "0x8A59E70", VA = "0x188A5B270", Slot = "22")]
		private void KWFNPOYLOFQ(FULTMNFEJJL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B440", Offset = "0x8A5A040", VA = "0x188A5B440")]
		private ulong QPEOZRHLDNH(OCQTFLRKKPN a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B420", Offset = "0x8A5A020", VA = "0x188A5B420")]
		private ulong QPEOZRHLDNH(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B3C0", Offset = "0x8A59FC0", VA = "0x188A5B3C0")]
		private static int PCNSXNCFEAC(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BEC0", Offset = "0x8A5AAC0", VA = "0x188A5BEC0")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AC00", Offset = "0x8A59800", VA = "0x188A5AC00")]
		[CompilerGenerated]
		private void FCPSOWYINXY(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AC00", Offset = "0x8A59800", VA = "0x188A5AC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A5C280", Offset = "0x8A5AE80", VA = "0x188A5C280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C2D0", Offset = "0x8A5AED0", VA = "0x188A5C2D0")]
		protected MZKDLBKFQPW(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C220", Offset = "0x8A5AE20", VA = "0x188A5C220")]
		public void UBIZAIIRWHD(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C1A0", Offset = "0x8A5ADA0", VA = "0x188A5C1A0")]
		protected void TBKRAEODFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C160", Offset = "0x8A5AD60", VA = "0x188A5C160")]
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
			[Cpp2IlInjected.Address(RVA = "0x16230F0", Offset = "0x1621CF0", VA = "0x1816230F0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1623100", Offset = "0x1621D00", VA = "0x181623100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A52710", Offset = "0x8A51310", VA = "0x188A52710")]
		internal void SXYTOUDPSTY(EEIAXPLQIVG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A526E0", Offset = "0x8A512E0", VA = "0x188A526E0")]
		private bool RJMSHEJSAVS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A52770", Offset = "0x8A51370", VA = "0x188A52770")]
		internal FULTMNFEJJL(IPEndPoint a, EEIAXPLQIVG b, GOANXSKKOIS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A52680", Offset = "0x8A51280", VA = "0x188A52680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A50020", Offset = "0x8A4EC20", VA = "0x188A50020")]
		private EEIAXPLQIVG(long a, byte b, int c, byte[] d, VSOHZOVUZLK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FE10", Offset = "0x8A4EA10", VA = "0x188A4FE10")]
		public static int QNUBXTLZXGF(CYUJJFYJAMH a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FC20", Offset = "0x8A4E820", VA = "0x188A4FC20")]
		public static EEIAXPLQIVG CGLMLKKSOFO(CYUJJFYJAMH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FE40", Offset = "0x8A4EA40", VA = "0x188A4FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A5A8E0", Offset = "0x8A594E0", VA = "0x188A5A8E0")]
		private LHLSOUSYCDZ(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A5F0", Offset = "0x8A591F0", VA = "0x188A5A5F0")]
		public static LHLSOUSYCDZ CGLMLKKSOFO(CYUJJFYJAMH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A7F0", Offset = "0x8A593F0", VA = "0x188A5A7F0")]
		public static CYUJJFYJAMH UWQIXUHMKTE(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A6F0", Offset = "0x8A592F0", VA = "0x188A5A6F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool ZRASMFHJEIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2A30", VA = "0x180EA3E30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFC070", VA = "0x180CFD470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A50680", Offset = "0x8A4F280", VA = "0x188A50680")]
		internal EEXLWYVHYOF(GOANXSKKOIS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8A50090", Offset = "0x8A4EC90", VA = "0x188A50090")]
		internal void BJPPHEBTOUU(IPEndPoint a, CYUJJFYJAMH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x392ED40", Offset = "0x392D940", VA = "0x18392ED40")]
		private void UBSUEOKZGUG<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A503A0", Offset = "0x8A4EFA0", VA = "0x188A503A0")]
		private void SNVVUWGPTLL(PYTAQRNLWLD a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A50520", Offset = "0x8A4F120", VA = "0x188A50520")]
		private void SSKYYSBTWWX(NALHHLHTHZZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A50210", Offset = "0x8A4EE10", VA = "0x188A50210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A5A5E0", Offset = "0x8A591E0", VA = "0x188A5A5E0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A5E0", Offset = "0x8A591E0", VA = "0x188A5A5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4EF70", Offset = "0x8A4DB70", VA = "0x188A4EF70")]
		private static void NJGPZYTRUUD(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EEB0", Offset = "0x8A4DAB0", VA = "0x188A4EEB0")]
		internal static void IZOOQSZXUAH(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F1A0", Offset = "0x8A4DDA0", VA = "0x188A4F1A0")]
		internal static void RRFVMZDVWAZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EF10", Offset = "0x8A4DB10", VA = "0x188A4EF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A61550", Offset = "0x8A60150", VA = "0x188A61550")]
		internal OQXRLZMXBEE(GOANXSKKOIS a, WJQSCCGWVLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A614E0", Offset = "0x8A600E0", VA = "0x188A614E0")]
		internal void PQIIPNZHDCN(CYUJJFYJAMH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A61430", Offset = "0x8A60030", VA = "0x188A61430")]
		internal void BGOSPSYHFWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A614B0", Offset = "0x8A600B0", VA = "0x188A614B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A64D30", Offset = "0x8A63930", VA = "0x188A64D30")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A64DD0", Offset = "0x8A639D0", VA = "0x188A64DD0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A64E40", Offset = "0x8A63A40", VA = "0x188A64E40", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25CD0", VA = "0x180F270D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25CD0", VA = "0x180F270D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D79B50", Offset = "0x1D78750", VA = "0x181D79B50")]
			public NetPeerEnumerator(OCQTFLRKKPN p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A5D170", Offset = "0x8A5BD70", VA = "0x188A5D170", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8A5D1C0", Offset = "0x8A5BDC0", VA = "0x188A5D1C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xE63420", Offset = "0xE62020", VA = "0x180E63420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE62010", Offset = "0xE60C10", VA = "0x180E62010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int UVQUBDZJAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x222E470", Offset = "0x222D070", VA = "0x18222E470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x233DA30", Offset = "0x233C630", VA = "0x18233DA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte GPZIAPKYVTF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDEBD20", Offset = "0xDEA920", VA = "0x180DEBD20")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int QVHRJCTSBOH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8A55F20", Offset = "0x8A54B20", VA = "0x188A55F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short MBUDKUCDGHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A527E0", Offset = "0x8A513E0", VA = "0x188A527E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OCQTFLRKKPN.OnUpdatedMtuDelegate QHPAZVRQBWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8A52C70", Offset = "0x8A51870", VA = "0x188A52C70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A57100", Offset = "0x8A55D00", VA = "0x188A57100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A574D0", Offset = "0x8A560D0", VA = "0x188A574D0")]
		public void SSGUIUUMOFY(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A558D0", Offset = "0x8A544D0", VA = "0x188A558D0")]
		public void KTEMDKPMFNJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A568A0", Offset = "0x8A554A0", VA = "0x188A568A0")]
		private bool PTBBCJTQCHN(IPEndPoint a, [Out] OCQTFLRKKPN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A55F40", Offset = "0x8A54B40", VA = "0x188A55F40")]
		private void OONQCQVWKPF(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A59E70", Offset = "0x8A58A70", VA = "0x188A59E70")]
		private void ZWTXJPCYBBO(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A571B0", Offset = "0x8A55DB0", VA = "0x188A571B0")]
		private void RNPVRDDBVVH(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A59F90", Offset = "0x8A58B90", VA = "0x188A59F90")]
		public GOANXSKKOIS(FEVINBEOZCO a, [Optional] KPIREJNTFAE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A58280", Offset = "0x8A56E80", VA = "0x188A58280")]
		internal void TKDPVTPQHKF(OCQTFLRKKPN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A52B70", Offset = "0x8A51770", VA = "0x188A52B70")]
		internal void ARZJRDGRVJP(OCQTFLRKKPN a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A55BA0", Offset = "0x8A547A0", VA = "0x188A55BA0")]
		internal void MQFMOXRPJDH(OCQTFLRKKPN a, DisconnectReason b, SocketError c, CYUJJFYJAMH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A59270", Offset = "0x8A57E70", VA = "0x188A59270")]
		private void WPJIYGSUTVM(OCQTFLRKKPN a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, CYUJJFYJAMH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8A58770", Offset = "0x8A57370", VA = "0x188A58770")]
		private void UORGUOEZNYQ(WJQSCCGWVLX.EType a, [Optional] OCQTFLRKKPN b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] FULTMNFEJJL g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] CYUJJFYJAMH j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A56940", Offset = "0x8A55540", VA = "0x188A56940")]
		private void QJJMLZSISLR(WJQSCCGWVLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A54780", Offset = "0x8A53380", VA = "0x188A54780")]
		internal void DTTNPBNELZB(WJQSCCGWVLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A59B10", Offset = "0x8A58710", VA = "0x188A59B10")]
		private void YECIANEKJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A54AC0", Offset = "0x8A536C0", VA = "0x188A54AC0")]
		private void INTRBRWFSDF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A56260", Offset = "0x8A54E60", VA = "0x188A56260")]
		internal OCQTFLRKKPN PACNMMCQKJK(FULTMNFEJJL a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A55EA0", Offset = "0x8A54AA0", VA = "0x188A55EA0")]
		private int NHNHBTKJHVW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8A582D0", Offset = "0x8A56ED0", VA = "0x188A582D0")]
		private void ULYSYQEWQEO(IPEndPoint a, OCQTFLRKKPN b, EEIAXPLQIVG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8A53460", Offset = "0x8A52060", VA = "0x188A53460")]
		private void DRYAHFQOHPJ(CYUJJFYJAMH a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8A528A0", Offset = "0x8A514A0", VA = "0x188A528A0")]
		internal void AISQPDKAXLZ(CYUJJFYJAMH a, DeliveryMethod b, byte c, int d, OCQTFLRKKPN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8A57EE0", Offset = "0x8A56AE0", VA = "0x188A57EE0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A57EF0", Offset = "0x8A56AF0", VA = "0x188A57EF0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A57E60", Offset = "0x8A56A60", VA = "0x188A57E60")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A532B0", Offset = "0x8A51EB0", VA = "0x188A532B0")]
		public void DFNWFVVOIEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A52D20", Offset = "0x8A51920", VA = "0x188A52D20")]
		public OCQTFLRKKPN Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A52E00", Offset = "0x8A51A00", VA = "0x188A52E00")]
		public OCQTFLRKKPN Connect(string address, int port, YMUYYZRTLWM connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A52EE0", Offset = "0x8A51AE0", VA = "0x188A52EE0")]
		public OCQTFLRKKPN Connect(IPEndPoint target, YMUYYZRTLWM connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A57F10", Offset = "0x8A56B10", VA = "0x188A57F10")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A57F20", Offset = "0x8A56B20", VA = "0x188A57F20")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A55AF0", Offset = "0x8A546F0", VA = "0x188A55AF0")]
		public void KUAENCXCTFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A55A20", Offset = "0x8A54620", VA = "0x188A55A20")]
		public void KUAENCXCTFT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A591F0", Offset = "0x8A57DF0", VA = "0x188A591F0")]
		public void WPJIYGSUTVM(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A59230", Offset = "0x8A57E30", VA = "0x188A59230")]
		public void WPJIYGSUTVM(OCQTFLRKKPN a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A52BC0", Offset = "0x8A517C0", VA = "0x188A52BC0", Slot = "4")]
		private IEnumerator<OCQTFLRKKPN> AVEGICOYTWF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A54A30", Offset = "0x8A53630", VA = "0x188A54A30", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A58CA0", Offset = "0x8A578A0", VA = "0x188A58CA0")]
		private CYUJJFYJAMH WESZGSNGUGX(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A58D90", Offset = "0x8A57990", VA = "0x188A58D90")]
		private CYUJJFYJAMH WESZGSNGUGX(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A598D0", Offset = "0x8A584D0", VA = "0x188A598D0")]
		internal CYUJJFYJAMH XWGUBPRMQVA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A59660", Offset = "0x8A58260", VA = "0x188A59660")]
		internal void XKGTVUAQUVJ(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A59ED0", Offset = "0x8A58AD0", VA = "0x188A59ED0")]
		static GOANXSKKOIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE63420", Offset = "0xE62020", VA = "0x180E63420")]
		private bool CZNZYGZCSPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A58B40", Offset = "0x8A57740", VA = "0x188A58B40")]
		private void VVRDJMWMWWM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A54F70", Offset = "0x8A53B70", VA = "0x188A54F70")]
		private void JHLLBKYTTWL(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A54890", Offset = "0x8A53490", VA = "0x188A54890")]
		private bool GEYQRICKIUR(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A52C50", Offset = "0x8A51850", VA = "0x188A52C50")]
		private void BLGTBTEQEPU(XYZFMNSORLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A55BE0", Offset = "0x8A547E0", VA = "0x188A55BE0")]
		private void MXHIJGTRYPN(VUAUYYXFOFY a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A58E70", Offset = "0x8A57A70", VA = "0x188A58E70")]
		private void WLSKFIOGGAB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A576F0", Offset = "0x8A562F0", VA = "0x188A576F0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A57470", Offset = "0x8A56070", VA = "0x188A57470")]
		internal int ROIKABCFZPI(CYUJJFYJAMH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A550C0", Offset = "0x8A53CC0", VA = "0x188A550C0")]
		internal int JUJEVSALHPO(CYUJJFYJAMH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A55100", Offset = "0x8A53D00", VA = "0x188A55100")]
		internal int JUJEVSALHPO(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A54DF0", Offset = "0x8A539F0", VA = "0x188A54DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A4F7A0", Offset = "0x8A4E3A0", VA = "0x188A4F7A0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F300", Offset = "0x8A4DF00", VA = "0x188A4F300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte FDGKRNYVTFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F5C0", Offset = "0x8A4E1C0", VA = "0x188A4F5C0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F560", Offset = "0x8A4E160", VA = "0x188A4F560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort GOKTHNKTCUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F620", Offset = "0x8A4E220", VA = "0x188A4F620")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F760", Offset = "0x8A4E360", VA = "0x188A4F760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KOQLWLSRTCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F380", Offset = "0x8A4DF80", VA = "0x188A4F380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte WYEXHECRDZI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F2B0", Offset = "0x8A4DEB0", VA = "0x188A4F2B0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F5F0", Offset = "0x8A4E1F0", VA = "0x188A4F5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort UKGEKTZAIJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F5A0", Offset = "0x8A4E1A0", VA = "0x188A4F5A0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F3B0", Offset = "0x8A4DFB0", VA = "0x188A4F3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort YQYKFSMHSPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F2E0", Offset = "0x8A4DEE0", VA = "0x188A4F2E0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F520", Offset = "0x8A4E120", VA = "0x188A4F520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort EJMTTFVWBWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F740", Offset = "0x8A4E340", VA = "0x188A4F740")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F340", Offset = "0x8A4DF40", VA = "0x188A4F340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F7D0", Offset = "0x8A4E3D0", VA = "0x188A4F7D0")]
		static CYUJJFYJAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F4F0", Offset = "0x8A4E0F0", VA = "0x188A4F4F0")]
		public void MPNPMSRWUYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FAA0", Offset = "0x8A4E6A0", VA = "0x188A4FAA0")]
		public CYUJJFYJAMH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FB10", Offset = "0x8A4E710", VA = "0x188A4FB10")]
		public CYUJJFYJAMH(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F640", Offset = "0x8A4E240", VA = "0x188A4F640")]
		public static int RXVTEMZPECM(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F6B0", Offset = "0x8A4E2B0", VA = "0x188A4F6B0")]
		public int RXVTEMZPECM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F3F0", Offset = "0x8A4DFF0", VA = "0x188A4F3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1C430", Offset = "0xD1B030", VA = "0x180D1C430")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A5DB10", Offset = "0x8A5C710", VA = "0x188A5DB10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint YIHNLWXFZYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE5B330", Offset = "0xE59F30", VA = "0x180E5B330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState WPXQOVCXGZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1495EA0", Offset = "0x1494AA0", VA = "0x181495EA0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long CIIATORKXPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCF2B20", Offset = "0xCF1720", VA = "0x180CF2B20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int CMWYGMPHNGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x222E470", Offset = "0x222D070", VA = "0x18222E470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x233DA30", Offset = "0x233C630", VA = "0x18233DA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int AEPNNXYTLUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FCC0", Offset = "0x8A5E8C0", VA = "0x188A5FCC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int PVONBMMDATT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B960", VA = "0x180D0CD60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double YUTRINPMXGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8C40", Offset = "0x2AC7840", VA = "0x182AC8C40")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate QHPAZVRQBWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A5DA10", Offset = "0x8A5C610", VA = "0x188A5DA10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FCD0", Offset = "0x8A5E8D0", VA = "0x188A5FCD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A60BC0", Offset = "0x8A5F7C0", VA = "0x188A60BC0")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FE90", Offset = "0x8A5EA90", VA = "0x188A5FE90")]
		internal void RPEVXJECHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A60B90", Offset = "0x8A5F790", VA = "0x188A60B90")]
		internal void WNEBNTZMCMW(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8A5ED90", Offset = "0x8A5D990", VA = "0x188A5ED90")]
		internal void GMYDFJAZERX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FD80", Offset = "0x8A5E980", VA = "0x188A5FD80")]
		private void RKREQNMKRQA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FE50", Offset = "0x8A5EA50", VA = "0x188A5FE50")]
		private void RKRKYLFLMSI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D430", Offset = "0x8A5C030", VA = "0x188A5D430")]
		public int CPAHDYGIBBY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D540", Offset = "0x8A5C140", VA = "0x188A5D540")]
		public int CPAHDYGIBBY(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D200", Offset = "0x8A5BE00", VA = "0x188A5D200")]
		private MZKDLBKFQPW ALHJSUTODAL(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A611A0", Offset = "0x8A5FDA0", VA = "0x188A611A0")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, IPEndPoint b, int c, byte d, YMUYYZRTLWM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A60FC0", Offset = "0x8A5FBC0", VA = "0x188A60FC0")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, FULTMNFEJJL b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FEB0", Offset = "0x8A5EAB0", VA = "0x188A5FEB0")]
		internal void Reject(EEIAXPLQIVG requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FF00", Offset = "0x8A5EB00", VA = "0x188A5FF00")]
		internal bool SCEQTRNWUXP(LHLSOUSYCDZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A602D0", Offset = "0x8A5EED0", VA = "0x188A602D0")]
		public void UBSUEOKZGUG(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E260", Offset = "0x8A5CE60", VA = "0x188A5E260")]
		private void FFHEPJOZIKX(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A5DAC0", Offset = "0x8A5C6C0", VA = "0x188A5DAC0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D390", Offset = "0x8A5BF90", VA = "0x188A5D390")]
		internal DisconnectResult CHWVAVKYABJ(CYUJJFYJAMH a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EE20", Offset = "0x8A5DA20", VA = "0x188A5EE20")]
		internal void HVPULIRNCZC(MZKDLBKFQPW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FF80", Offset = "0x8A5EB80", VA = "0x188A5FF80")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A60290", Offset = "0x8A5EE90", VA = "0x188A60290")]
		private void TQYAZDOELDP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EE80", Offset = "0x8A5DA80", VA = "0x188A5EE80")]
		internal void LBDELCVZUWB(DeliveryMethod a, CYUJJFYJAMH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E850", Offset = "0x8A5D450", VA = "0x188A5E850")]
		private void FQPPIRXRTNB(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F720", Offset = "0x8A5E320", VA = "0x188A5F720")]
		private void NLRIEEJPOIT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A60300", Offset = "0x8A5EF00", VA = "0x188A60300")]
		internal ConnectRequestResult ULYSYQEWQEO(EEIAXPLQIVG a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A5DBC0", Offset = "0x8A5C7C0", VA = "0x188A5DBC0")]
		internal void ENPPMPFUXFL(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D8C0", Offset = "0x8A5C4C0", VA = "0x188A5D8C0")]
		private void CWJATSQXGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FAB0", Offset = "0x8A5E6B0", VA = "0x188A5FAB0")]
		internal void OCTLINGEQTD(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A604C0", Offset = "0x8A5F0C0", VA = "0x188A604C0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D660", Offset = "0x8A5C260", VA = "0x188A5D660")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A629F0", Offset = "0x8A615F0", VA = "0x188A629F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long FKKJLNQQCFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A629E0", Offset = "0x8A615E0", VA = "0x188A629E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long SQIEECQQMVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A62B10", Offset = "0x8A61710", VA = "0x188A62B10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long KNGHKAYILGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A62EC0", Offset = "0x8A61AC0", VA = "0x188A62EC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long UDTISHDKIQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A628B0", Offset = "0x8A614B0", VA = "0x188A628B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long DJPLLIPFGIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8A62A00", Offset = "0x8A61600", VA = "0x188A62A00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long POSMUPVXQEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A62F30", Offset = "0x8A61B30", VA = "0x188A62F30")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long VHQFQIKEBTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8A62F70", Offset = "0x8A61B70", VA = "0x188A62F70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality GWWUJKNKCMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x13FE0C0", Offset = "0x13FCCC0", VA = "0x1813FE0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double CMJSHUKWSHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A62850", Offset = "0x8A61450", VA = "0x188A62850")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A62AD0", Offset = "0x8A616D0", VA = "0x188A62AD0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A62E60", Offset = "0x8A61A60", VA = "0x188A62E60")]
		public void UHVFBCGTZDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A62A10", Offset = "0x8A61610", VA = "0x188A62A10")]
		public void OHTUPUBNMLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A627E0", Offset = "0x8A613E0", VA = "0x188A627E0")]
		public void AAZJYVQYCWY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A62A60", Offset = "0x8A61660", VA = "0x188A62A60")]
		public void QWVFJZRCYQF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A62ED0", Offset = "0x8A61AD0", VA = "0x188A62ED0")]
		public void XHQQPSKTYOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8A628C0", Offset = "0x8A614C0", VA = "0x188A628C0")]
		public void FZRQVMVLUJO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8A62B20", Offset = "0x8A61720", VA = "0x188A62B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8A62940", Offset = "0x8A61540", VA = "0x188A62940")]
		public void GNPRLKREERE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A64EA0", Offset = "0x8A63AA0", VA = "0x188A64EA0")]
		public static IPEndPoint RVNHWWUSBDN(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A650E0", Offset = "0x8A63CE0", VA = "0x188A650E0")]
		public static IPAddress YJCSEMUJHHC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8A652B0", Offset = "0x8A63EB0", VA = "0x188A652B0")]
		public static IPAddress YJCSEMUJHHC(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A64E70", Offset = "0x8A63A70", VA = "0x188A64E70")]
		internal static int FCNLREWYGZO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4128640", Offset = "0x4127240", VA = "0x184128640")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A61EE0", Offset = "0x8A60AE0", VA = "0x188A61EE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A61F50", Offset = "0x8A60B50", VA = "0x188A61F50")]
			public void WNCQWZWPKZY(CYUJJFYJAMH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8A61E70", Offset = "0x8A60A70", VA = "0x188A61E70")]
			public bool THQXHICLCVJ(long a, OCQTFLRKKPN b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8A61E20", Offset = "0x8A60A20", VA = "0x188A61E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A63D10", Offset = "0x8A62910", VA = "0x188A63D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8A64B70", Offset = "0x8A63770", VA = "0x188A64B70")]
		public WFKFWLWBQYZ(OCQTFLRKKPN a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8A63D20", Offset = "0x8A62920", VA = "0x188A63D20")]
		private void AZSJCPXNYQC(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8A646A0", Offset = "0x8A632A0", VA = "0x188A646A0", Slot = "4")]
		protected override bool ETQCRWXQJRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8A640A0", Offset = "0x8A62CA0", VA = "0x188A640A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A511B0", Offset = "0x8A4FDB0", VA = "0x188A511B0")]
		public FHBYOFDWPLY(OCQTFLRKKPN a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8A50CF0", Offset = "0x8A4F8F0", VA = "0x188A50CF0", Slot = "4")]
		protected override bool ETQCRWXQJRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8A50A70", Offset = "0x8A4F670", VA = "0x188A50A70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4ED20", Offset = "0x8A4D920", VA = "0x188A4ED20")]
		private static void WPWXNOFAEYI(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8A62680", Offset = "0x8A61280", VA = "0x188A62680")]
		private static void WPWXNOFAEYI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8A627A0", Offset = "0x8A613A0", VA = "0x188A627A0")]
		public static void WPWXNOFAEYI(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8A62700", Offset = "0x8A61300", VA = "0x188A62700")]
		public static void SHZWPQEXDJR(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8A62720", Offset = "0x8A61320", VA = "0x188A62720")]
		public static void SHZWPQEXDJR(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8A627A0", Offset = "0x8A613A0", VA = "0x188A627A0")]
		public static void SHZWPQEXDJR(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8A627A0", Offset = "0x8A613A0", VA = "0x188A627A0")]
		public static void SHZWPQEXDJR(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8A62680", Offset = "0x8A61280", VA = "0x188A62680")]
		public static void SHZWPQEXDJR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8A62680", Offset = "0x8A61280", VA = "0x188A62680")]
		public static void SHZWPQEXDJR(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8A626F0", Offset = "0x8A612F0", VA = "0x188A626F0")]
		public static void SHZWPQEXDJR(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8A626F0", Offset = "0x8A612F0", VA = "0x188A626F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DKVZRBHFTOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF270", VA = "0x180D00670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int ZTVLDQSLGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A63560", Offset = "0x8A62160", VA = "0x188A63560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GYQALBISFUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A24640", Offset = "0x2A23240", VA = "0x182A24640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int OAPUUWRXKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8A63520", Offset = "0x8A62120", VA = "0x188A63520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8A63730", Offset = "0x8A62330", VA = "0x188A63730")]
		public void PQIIPNZHDCN(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public VSOHZOVUZLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8A63CB0", Offset = "0x8A628B0", VA = "0x188A63CB0")]
		public VSOHZOVUZLK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8A63BE0", Offset = "0x8A627E0", VA = "0x188A63BE0")]
		public IPEndPoint YNNGYCFOEES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8A63A00", Offset = "0x8A62600", VA = "0x188A63A00")]
		public byte UQIAHDOMCWS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A63A00", Offset = "0x8A62600", VA = "0x188A63A00")]
		public sbyte THBZLGHERYD()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x40C1C60", Offset = "0x40C0860", VA = "0x1840C1C60")]
		public a[] HBZHQVGUJBT<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A63570", Offset = "0x8A62170", VA = "0x188A63570")]
		public bool[] JWXQXHOYBGZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8A635B0", Offset = "0x8A621B0", VA = "0x188A635B0")]
		public ushort[] KDWGWPYMEYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A639C0", Offset = "0x8A625C0", VA = "0x188A639C0")]
		public short[] QLTQWOJBBID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8A63C70", Offset = "0x8A62870", VA = "0x188A63C70")]
		public int[] ZWGMCNDDGPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8A63BA0", Offset = "0x8A627A0", VA = "0x188A63BA0")]
		public uint[] YEBGEDVUPQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A63A80", Offset = "0x8A62680", VA = "0x188A63A80")]
		public float[] UNWJZUPLWVF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8A63770", Offset = "0x8A62370", VA = "0x188A63770")]
		public double[] PTDTJDXINYG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A634A0", Offset = "0x8A620A0", VA = "0x188A634A0")]
		public long[] EOBPLXYEZNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A634E0", Offset = "0x8A620E0", VA = "0x188A634E0")]
		public ulong[] GHIJOTALFZA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8A63620", Offset = "0x8A62220", VA = "0x188A63620")]
		public string[] LFXLWXHZAIW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A636F0", Offset = "0x8A622F0", VA = "0x188A636F0")]
		public bool LMYOCXVGACQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8A63450", Offset = "0x8A62050", VA = "0x188A63450")]
		public char BJAUHHNKYPS()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8A63450", Offset = "0x8A62050", VA = "0x188A63450")]
		public ushort IROSXOZYRTJ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8A63450", Offset = "0x8A62050", VA = "0x188A63450")]
		public short QYXXDIYAIGK()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A63AC0", Offset = "0x8A626C0", VA = "0x188A63AC0")]
		public long VACXPISJHOK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8A63AC0", Offset = "0x8A626C0", VA = "0x188A63AC0")]
		public ulong XYIFTFCYFHL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8A63530", Offset = "0x8A62130", VA = "0x188A63530")]
		public int XFGLJJICOSJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8A63530", Offset = "0x8A62130", VA = "0x188A63530")]
		public uint IALCTCPREME()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8A63420", Offset = "0x8A62020", VA = "0x188A63420")]
		public float BICZAKOTTES()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8A635F0", Offset = "0x8A621F0", VA = "0x188A635F0")]
		public double KLYPMKLFQSF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8A637B0", Offset = "0x8A623B0", VA = "0x188A637B0")]
		public string QGOSMAICKCR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8A63B30", Offset = "0x8A62730", VA = "0x188A63B30")]
		public ArraySegment<byte> WFELUJTQFYM(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A63AF0", Offset = "0x8A626F0", VA = "0x188A63AF0")]
		public sbyte[] VDFRNFBMHGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8A63A40", Offset = "0x8A62640", VA = "0x188A63A40")]
		public byte[] UFZGNDFQTPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A63480", Offset = "0x8A62080", VA = "0x188A63480")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8A66190", Offset = "0x8A64D90", VA = "0x188A66190")]
		public YMUYYZRTLWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8A660F0", Offset = "0x8A64CF0", VA = "0x188A660F0")]
		public YMUYYZRTLWM(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8A65A30", Offset = "0x8A64630", VA = "0x188A65A30")]
		public static YMUYYZRTLWM HQKDKSPPNUV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8A65B80", Offset = "0x8A64780", VA = "0x188A65B80")]
		public void QEONIRHQLDZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CE00", Offset = "0x2A9BA00", VA = "0x182A9CE00")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8A65660", Offset = "0x8A64260", VA = "0x188A65660")]
		public void FFTUNRFWXCB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8A658B0", Offset = "0x8A644B0", VA = "0x188A658B0")]
		public void FFTUNRFWXCB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8A65700", Offset = "0x8A64300", VA = "0x188A65700")]
		public void FFTUNRFWXCB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8A65700", Offset = "0x8A64300", VA = "0x188A65700")]
		public void FFTUNRFWXCB(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8A657C0", Offset = "0x8A643C0", VA = "0x188A657C0")]
		public void FFTUNRFWXCB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8A657C0", Offset = "0x8A643C0", VA = "0x188A657C0")]
		public void FFTUNRFWXCB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8A655F0", Offset = "0x8A641F0", VA = "0x188A655F0")]
		public void FFTUNRFWXCB(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A655F0", Offset = "0x8A641F0", VA = "0x188A655F0")]
		public void FFTUNRFWXCB(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8A655F0", Offset = "0x8A641F0", VA = "0x188A655F0")]
		public void FFTUNRFWXCB(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8A65850", Offset = "0x8A64450", VA = "0x188A65850")]
		public void FFTUNRFWXCB(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8A65850", Offset = "0x8A64450", VA = "0x188A65850")]
		public void FFTUNRFWXCB(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8A65750", Offset = "0x8A64350", VA = "0x188A65750")]
		public void FFTUNRFWXCB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8A65AA0", Offset = "0x8A646A0", VA = "0x188A65AA0")]
		public void MRLSCCDQWIR(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8A65AA0", Offset = "0x8A646A0", VA = "0x188A65AA0")]
		public void VFREJXATEJK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8A659D0", Offset = "0x8A645D0", VA = "0x188A659D0")]
		public void FFTUNRFWXCB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8A65F90", Offset = "0x8A64B90", VA = "0x188A65F90")]
		public void RJIYCXXWJNE(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8A65DE0", Offset = "0x8A649E0", VA = "0x188A65DE0")]
		public void RJIYCXXWJNE(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8A65C20", Offset = "0x8A64820", VA = "0x188A65C20")]
		public void RJIYCXXWJNE(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8A65C20", Offset = "0x8A64820", VA = "0x188A65C20")]
		public void RJIYCXXWJNE(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8A65C20", Offset = "0x8A64820", VA = "0x188A65C20")]
		public void RJIYCXXWJNE(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8A65DE0", Offset = "0x8A649E0", VA = "0x188A65DE0")]
		public void RJIYCXXWJNE(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8A65DE0", Offset = "0x8A649E0", VA = "0x188A65DE0")]
		public void RJIYCXXWJNE(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8A65D00", Offset = "0x8A64900", VA = "0x188A65D00")]
		public void RJIYCXXWJNE(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8A65D00", Offset = "0x8A64900", VA = "0x188A65D00")]
		public void RJIYCXXWJNE(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8A65AA0", Offset = "0x8A646A0", VA = "0x188A65AA0")]
		public void RJIYCXXWJNE(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8A65EC0", Offset = "0x8A64AC0", VA = "0x188A65EC0")]
		public void RJIYCXXWJNE(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8A65900", Offset = "0x8A64500", VA = "0x188A65900")]
		public void FFTUNRFWXCB(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A655E0", Offset = "0x8A641E0", VA = "0x188A655E0")]
		public void FFTUNRFWXCB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8A653D0", Offset = "0x8A63FD0", VA = "0x188A653D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x729CC30", Offset = "0x729B830", VA = "0x18729CC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public INBVDQUOBSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x65AF1B0", Offset = "0x65ADDB0", VA = "0x1865AF1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BQFULXHEJJU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4F7DF30", Offset = "0x4F7CB30", VA = "0x184F7DF30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A632D0", Offset = "0x8A61ED0", VA = "0x188A632D0")]
		public UJRNQXRYGIR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4089430", Offset = "0x4088030", VA = "0x184089430", Slot = "4")]
		protected virtual ulong ADRSLHKBOPW<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A63200", Offset = "0x8A61E00", VA = "0x188A63200", Slot = "5")]
		protected virtual SubscribeDelegate WJIWHOATRNF(VSOHZOVUZLK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x40894B0", Offset = "0x40880B0", VA = "0x1840894B0", Slot = "6")]
		protected virtual void BXJSBLSQHOX<b>(YMUYYZRTLWM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8A63180", Offset = "0x8A61D80", VA = "0x188A63180")]
		public void RDUXMLZQZAU(VSOHZOVUZLK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4089830", Offset = "0x4088430", VA = "0x184089830")]
		public void SQIRBZBNMTZ<j>(YMUYYZRTLWM a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8A63130", Offset = "0x8A61D30", VA = "0x188A63130")]
		public void AMLNAAAGJTK(VSOHZOVUZLK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x40896B0", Offset = "0x40882B0", VA = "0x1840896B0")]
		public void DXPECKOEYCZ<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x40896B0", Offset = "0x40882B0", VA = "0x1840896B0")]
		public void DXPECKOEYCZ<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A5E0", Offset = "0x8A591E0", VA = "0x188A5A5E0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8A61DC0", Offset = "0x8A609C0", VA = "0x188A61DC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x53EE170", Offset = "0x53ECD70", VA = "0x1853EE170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0x72CC450", Offset = "0x72CB050", VA = "0x1872CC450", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x72CC450", Offset = "0x72CB050", VA = "0x1872CC450", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x72CC380", Offset = "0x72CAF80", VA = "0x1872CC380", Slot = "9")]
			public override void FLOXBPKQHYQ(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x72CC380", Offset = "0x72CAF80", VA = "0x1872CC380", Slot = "10")]
			public override void BKACKDXHLRJ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x72CC690", Offset = "0x72CB290", VA = "0x1872CC690")]
			protected b[] SSFRGOFLYDD(a a, VSOHZOVUZLK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x72CC520", Offset = "0x72CB120", VA = "0x1872CC520")]
			protected b[] NUENPNNMTUA(a a, YMUYYZRTLWM b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x72CC930", Offset = "0x72CB530", VA = "0x1872CC930", Slot = "4")]
			public override void WNCQWZWPKZY(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x72CD410", Offset = "0x72CC010", VA = "0x1872CD410")]
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
			[Cpp2IlInjected.Address(RVA = "0x647F340", Offset = "0x647DF40", VA = "0x18647F340", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x647F7D0", Offset = "0x647E3D0", VA = "0x18647F7D0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x647F190", Offset = "0x647DD90", VA = "0x18647F190", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x647F540", Offset = "0x647E140", VA = "0x18647F540", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x647FA10", Offset = "0x647E610", VA = "0x18647FA10")]
			protected HTDKUIFRPZZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class TZVQQZPPRKC<a> : OZHLFTJLQJS<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x53E9CA0", Offset = "0x53E88A0", VA = "0x1853E9CA0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x53E9F30", Offset = "0x53E8B30", VA = "0x1853E9F30", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7A98990", Offset = "0x7A97590", VA = "0x187A98990", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x53E9CF0", Offset = "0x53E88F0", VA = "0x1853E9CF0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public TZVQQZPPRKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class DSJNUBORLRR<a> : OZHLFTJLQJS<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x53E9CA0", Offset = "0x53E88A0", VA = "0x1853E9CA0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x53E9F30", Offset = "0x53E8B30", VA = "0x1853E9F30", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A40", Offset = "0x53E8640", VA = "0x1853E9A40", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x53E9CF0", Offset = "0x53E88F0", VA = "0x1853E9CF0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public DSJNUBORLRR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class SRTNHKMNLQV<a> : OZHLFTJLQJS<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x71C0530", Offset = "0x71BF130", VA = "0x1871C0530", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x71C08E0", Offset = "0x71BF4E0", VA = "0x1871C08E0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x792E7F0", Offset = "0x792D3F0", VA = "0x18792E7F0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x71C07A0", Offset = "0x71BF3A0", VA = "0x1871C07A0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public SRTNHKMNLQV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class AAHMBTJRIRG<a> : OZHLFTJLQJS<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x71C0530", Offset = "0x71BF130", VA = "0x1871C0530", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x71C08E0", Offset = "0x71BF4E0", VA = "0x1871C08E0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x71C04E0", Offset = "0x71BF0E0", VA = "0x1871C04E0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x71C07A0", Offset = "0x71BF3A0", VA = "0x1871C07A0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public AAHMBTJRIRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class DSHGHMTMMJT<a> : OZHLFTJLQJS<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x53E9620", Offset = "0x53E8220", VA = "0x1853E9620", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x53E98C0", Offset = "0x53E84C0", VA = "0x1853E98C0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x53E94D0", Offset = "0x53E80D0", VA = "0x1853E94D0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x53E9880", Offset = "0x53E8480", VA = "0x1853E9880", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public DSHGHMTMMJT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class DTXWZSRVTAW<a> : OZHLFTJLQJS<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x53E9620", Offset = "0x53E8220", VA = "0x1853E9620", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x53E98C0", Offset = "0x53E84C0", VA = "0x1853E98C0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x53EDF50", Offset = "0x53ECB50", VA = "0x1853EDF50", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x53E9880", Offset = "0x53E8480", VA = "0x1853E9880", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public DTXWZSRVTAW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class MTROMMVRZKR<a> : OZHLFTJLQJS<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x647C180", Offset = "0x647AD80", VA = "0x18647C180", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x647C310", Offset = "0x647AF10", VA = "0x18647C310", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x6F27EE0", Offset = "0x6F26AE0", VA = "0x186F27EE0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x647C1D0", Offset = "0x647ADD0", VA = "0x18647C1D0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public MTROMMVRZKR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class HIBGCMANYWI<a> : OZHLFTJLQJS<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x647C180", Offset = "0x647AD80", VA = "0x18647C180", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x647C310", Offset = "0x647AF10", VA = "0x18647C310", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x647BF10", Offset = "0x647AB10", VA = "0x18647BF10", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x647C1D0", Offset = "0x647ADD0", VA = "0x18647C1D0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public HIBGCMANYWI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class TKHGXGYKFVL<a> : OZHLFTJLQJS<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x7A896C0", Offset = "0x7A882C0", VA = "0x187A896C0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x7A89710", Offset = "0x7A88310", VA = "0x187A89710", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x7A89460", Offset = "0x7A88060", VA = "0x187A89460", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x53E9CF0", Offset = "0x53E88F0", VA = "0x1853E9CF0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public TKHGXGYKFVL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class NOWVTPOJXTE<a> : OZHLFTJLQJS<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x7158D30", Offset = "0x7157930", VA = "0x187158D30", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7158D80", Offset = "0x7157980", VA = "0x187158D80", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7158BD0", Offset = "0x71577D0", VA = "0x187158BD0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x53E9880", Offset = "0x53E8480", VA = "0x1853E9880", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public NOWVTPOJXTE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class QMEIHHVTEAH<a> : OZHLFTJLQJS<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x76398D0", Offset = "0x76384D0", VA = "0x1876398D0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7639B40", Offset = "0x7638740", VA = "0x187639B40", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7639780", Offset = "0x7638380", VA = "0x187639780", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x647C1D0", Offset = "0x647ADD0", VA = "0x18647C1D0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8600", VA = "0x1853E9A00")]
			public QMEIHHVTEAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class ECJUJADZAED<a> : HTDKUIFRPZZ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BC60", Offset = "0x5B3A860", VA = "0x185B3BC60", Slot = "12")]
			protected override void LKTAQKPMJSP(YMUYYZRTLWM a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BC90", Offset = "0x5B3A890", VA = "0x185B3BC90", Slot = "11")]
			protected override void LXDSYVBGNGM(VSOHZOVUZLK a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BCC0", Offset = "0x5B3A8C0", VA = "0x185B3BCC0")]
			public ECJUJADZAED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class FOSXNUHLVJR<a> : HTDKUIFRPZZ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x628B110", Offset = "0x6289D10", VA = "0x18628B110", Slot = "12")]
			protected override void LKTAQKPMJSP(YMUYYZRTLWM a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x628B140", Offset = "0x6289D40", VA = "0x18628B140", Slot = "11")]
			protected override void LXDSYVBGNGM(VSOHZOVUZLK a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BCC0", Offset = "0x5B3A8C0", VA = "0x185B3BCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x51493C0", Offset = "0x5147FC0", VA = "0x1851493C0")]
			public ZTDXMOMZFLQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5148F60", Offset = "0x5147B60", VA = "0x185148F60", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5149320", Offset = "0x5147F20", VA = "0x185149320", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5148DF0", Offset = "0x51479F0", VA = "0x185148DF0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x51491D0", Offset = "0x5147DD0", VA = "0x1851491D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x85E0B90", Offset = "0x85DF790", VA = "0x1885E0B90")]
			public WZPRMGXPCNW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x85E07D0", Offset = "0x85DF3D0", VA = "0x1885E07D0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x85E0AB0", Offset = "0x85DF6B0", VA = "0x1885E0AB0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x85E0780", Offset = "0x85DF380", VA = "0x1885E0780", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x85E0780", Offset = "0x85DF380", VA = "0x1885E0780", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x85E0730", Offset = "0x85DF330", VA = "0x1885E0730", Slot = "9")]
			public override void FLOXBPKQHYQ(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x85E0730", Offset = "0x85DF330", VA = "0x1885E0730", Slot = "10")]
			public override void BKACKDXHLRJ(a a, YMUYYZRTLWM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class OFKBMBINTMZ<a> : WZPRMGXPCNW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x72A5AD0", Offset = "0x72A46D0", VA = "0x1872A5AD0")]
			public OFKBMBINTMZ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x72A58A0", Offset = "0x72A44A0", VA = "0x1872A58A0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x72A5940", Offset = "0x72A4540", VA = "0x1872A5940", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F0AFE0", Offset = "0x4F09BE0", VA = "0x184F0AFE0")]
			public BCWIUDDHMPJ(List<DUMYYWEGFOV<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4F0AD00", Offset = "0x4F09900", VA = "0x184F0AD00")]
			public void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4F0AC50", Offset = "0x4F09850", VA = "0x184F0AC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A5A550", Offset = "0x8A59150", VA = "0x188A5A550")]
		public GOTNJHNBWPZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9880", Offset = "0x3AD8480", VA = "0x183AD9880")]
		private BCWIUDDHMPJ<d> ZEGWPMQXANC<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8A10", Offset = "0x3AD7610", VA = "0x183AD8A10")]
		public void SIFQFAPRLAF<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3AD88D0", Offset = "0x3AD74D0", VA = "0x183AD88D0")]
		public bool Deserialize<T>(VSOHZOVUZLK reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8950", Offset = "0x3AD7550", VA = "0x183AD8950")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A52180", Offset = "0x8A50D80", VA = "0x188A52180")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int ZLNBWHWGZYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8A521B0", Offset = "0x8A50DB0", VA = "0x188A521B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8A51270", Offset = "0x8A4FE70", VA = "0x188A51270")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode VCPJRYGHJXB
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A51C00", Offset = "0x8A50800", VA = "0x188A51C00")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A51750", Offset = "0x8A50350", VA = "0x188A51750")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int YKSHZYUQXJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A521E0", Offset = "0x8A50DE0", VA = "0x188A521E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint BNKOVPJRQEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A51F30", Offset = "0x8A50B30", VA = "0x188A51F30")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? FOEVBPSURLY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A51F00", Offset = "0x8A50B00", VA = "0x188A51F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? MNCHTIJXFTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A52150", Offset = "0x8A50D50", VA = "0x188A52150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? HFAKIKNJXCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A51950", Offset = "0x8A50550", VA = "0x188A51950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A51D40", Offset = "0x8A50940", VA = "0x188A51D40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ZHPPITTELOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF6C4A0", Offset = "0xF6B0A0", VA = "0x180F6C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A52370", Offset = "0x8A50F70", VA = "0x188A52370")]
		public FRXFAFKMYKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A522D0", Offset = "0x8A50ED0", VA = "0x188A522D0")]
		internal FRXFAFKMYKS(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A51C30", Offset = "0x8A50830", VA = "0x188A51C30")]
		public static FRXFAFKMYKS RCSFIPQMQMQ(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A513D0", Offset = "0x8A4FFD0", VA = "0x188A513D0")]
		internal void DRLSFSGCJYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A51790", Offset = "0x8A50390", VA = "0x188A51790")]
		private void GXABVMOEHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A51A30", Offset = "0x8A50630", VA = "0x188A51A30")]
		private DateTime? NQQHBMTFXQP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A51F90", Offset = "0x8A50B90", VA = "0x188A51F90")]
		private void VKYDOYCWEMP(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A51980", Offset = "0x8A50580", VA = "0x188A51980")]
		private ulong KEHHSVZUUJB(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A512B0", Offset = "0x8A4FEB0", VA = "0x188A512B0")]
		private void DIIOJYRWUDR(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8A52210", Offset = "0x8A50E10", VA = "0x188A52210")]
		private uint ZBPANHDGEMY(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x891A0D0", Offset = "0x8918CD0", VA = "0x18891A0D0")]
		private static uint DLJLCNNSMLN(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A51370", Offset = "0x8A4FF70", VA = "0x188A51370")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A61330", Offset = "0x8A5FF30", VA = "0x188A61330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8A61340", Offset = "0x8A5FF40", VA = "0x188A61340")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A615A0", Offset = "0x8A601A0", VA = "0x188A615A0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int KKIPXQEPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8A61CF0", Offset = "0x8A608F0", VA = "0x188A61CF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint OSRBBYBPLSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8A61C90", Offset = "0x8A60890", VA = "0x188A61C90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily NHIOGIELQKU
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32B4420", Offset = "0x32B3020", VA = "0x1832B4420", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8A61D10", Offset = "0x8A60910", VA = "0x188A61D10")]
		public PHJRDRCBAPJ(AddressFamily a, GOANXSKKOIS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8A615C0", Offset = "0x8A601C0", VA = "0x188A615C0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CB0", Offset = "0x8A608B0", VA = "0x188A61CB0", Slot = "9")]
		public int QXEJMNZAIML(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8A61BA0", Offset = "0x8A607A0", VA = "0x188A61BA0", Slot = "10")]
		public int JNDRQJDDSMV(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8A61B80", Offset = "0x8A60780", VA = "0x188A61B80", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A5CE90", Offset = "0x8A5BA90", VA = "0x188A5CE90")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8A5CF30", Offset = "0x8A5BB30", VA = "0x188A5CF30")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x16230F0", Offset = "0x1621CF0", VA = "0x1816230F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5CDA0", Offset = "0x8A5B9A0", VA = "0x188A5CDA0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5CDE0", Offset = "0x8A5B9E0", VA = "0x188A5CDE0", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		internal void CMVXBYHCAXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		internal void HQHVHDPLAYR(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9D690", Offset = "0x2B9C290", VA = "0x182B9D690")]
		public NEVABRDQBVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8A5CB90", Offset = "0x8A5B790", VA = "0x188A5CB90")]
		public void TVHLCXEIYGW(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C7B0", Offset = "0x8A5B3B0", VA = "0x188A5C7B0")]
		public void PRWYBJNXAZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C360", Offset = "0x8A5AF60", VA = "0x188A5C360", Slot = "4")]
		public override void FYMCQBNTUIO(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C890", Offset = "0x8A5B490", VA = "0x188A5C890", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A66640", Offset = "0x8A65240", VA = "0x188A66640")]
			[BurstDiscard]
			private static void QGYXNOMWBVT(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8A667D0", Offset = "0x8A653D0", VA = "0x188A667D0")]
			private static IntPtr RVXPUZINCSJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8A663F0", Offset = "0x8A64FF0", VA = "0x188A663F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A62530", Offset = "0x8A61130", VA = "0x188A62530")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8A62390", Offset = "0x8A60F90", VA = "0x188A62390")]
		private uint HKRQCHBIJXM(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EC70", Offset = "0x8A4D870", VA = "0x188A4EC70")]
		private void UIFPEAZUUHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E8D0", Offset = "0x8A4D4D0", VA = "0x188A4E8D0")]
		private void LULCZTTYNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EBE0", Offset = "0x8A4D7E0", VA = "0x188A4EBE0")]
		private void RRWVWPLRHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EAE0", Offset = "0x8A4D6E0", VA = "0x188A4EAE0")]
		private void OIIWUHDEKSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8A625B0", Offset = "0x8A611B0", VA = "0x188A625B0")]
		private void SHXSGEOQYYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8A61F70", Offset = "0x8A60B70", VA = "0x188A61F70")]
		private unsafe void DMWXXUPTLLK(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8A62470", Offset = "0x8A61070", VA = "0x188A62470")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void JHREKJDNKSF([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8A623C0", Offset = "0x8A60FC0", VA = "0x188A623C0")]
		public static void JHREKJDNKSF(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8A62480", Offset = "0x8A61080", VA = "0x188A62480")]
		public static void RQBALYEEJHH(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8A62610", Offset = "0x8A61210", VA = "0x188A62610")]
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
	[Cpp2IlInjected.Address(RVA = "0x8A663B0", Offset = "0x8A64FB0", VA = "0x188A663B0")]
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
