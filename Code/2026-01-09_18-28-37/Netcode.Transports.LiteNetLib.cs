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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, QWNWUANKYMU
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
		private NetworkManager ZNWVCPDBZFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool GKQPOVLFZDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, NVWERYDFGQJ> OUOAVJLXSLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CPGHTRNWCDG RSWQVUWBBVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch OWQHKEHAAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] HVGZNNBKEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType XFSQUQDEKJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int VZIWGAVNBVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x748CE80", Offset = "0x748C280", VA = "0x18748CE80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x748CE30", Offset = "0x748C230", VA = "0x18748CE30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x748C160", Offset = "0x748B560", VA = "0x18748C160")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x748C140", Offset = "0x748B540", VA = "0x18748C140")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x748BFB0", Offset = "0x748B3B0", VA = "0x18748BFB0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x748CB40", Offset = "0x748BF40", VA = "0x18748CB40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x748C270", Offset = "0x748B670", VA = "0x18748C270", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x748C100", Offset = "0x748B500", VA = "0x18748C100", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x748C540", Offset = "0x748B940", VA = "0x18748C540", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x748C8D0", Offset = "0x748BCD0", VA = "0x18748C8D0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x748B960", Offset = "0x748AD60", VA = "0x18748B960", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x748B870", Offset = "0x748AC70", VA = "0x18748B870", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x748BA70", Offset = "0x748AE70", VA = "0x18748BA70", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x748C4D0", Offset = "0x748B8D0", VA = "0x18748C4D0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x748BB40", Offset = "0x748AF40", VA = "0x18748BB40", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x748BD50", Offset = "0x748B150", VA = "0x18748BD50")]
		private DeliveryMethod KCVHAGYGIQZ(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x748BE20", Offset = "0x748B220", VA = "0x18748BE20", Slot = "16")]
		private void KWTKLABWXVM(NVWERYDFGQJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x748B780", Offset = "0x748AB80", VA = "0x18748B780", Slot = "17")]
		private void AJOEMAKSKHG(NVWERYDFGQJ a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "18")]
		private void LRTGBIPRTHV(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x748CB60", Offset = "0x748BF60", VA = "0x18748CB60", Slot = "19")]
		private void ZTBIJCBWCBS(NVWERYDFGQJ a, CITCSPWOZFE b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x748BEE0", Offset = "0x748B2E0", VA = "0x18748BEE0")]
		private void NJCLVCLLASP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "20")]
		private void FXXBHOAPYNA(IPEndPoint a, CITCSPWOZFE b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "21")]
		private void PAXGXVRGDQS(NVWERYDFGQJ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x748C0A0", Offset = "0x748B4A0", VA = "0x18748C0A0", Slot = "22")]
		private void PUTMEJKSMTS(GOMPTZRXQNB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x748CAF0", Offset = "0x748BEF0", VA = "0x18748CAF0")]
		private ulong TEWGTLTWDFF(NVWERYDFGQJ a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x748CB20", Offset = "0x748BF20", VA = "0x18748CB20")]
		private ulong TEWGTLTWDFF(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x748B850", Offset = "0x748AC50", VA = "0x18748B850")]
		private static int BADRXNPYAAE(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x748CD60", Offset = "0x748C160", VA = "0x18748CD60")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x748BB10", Offset = "0x748AF10", VA = "0x18748BB10")]
		[CompilerGenerated]
		private void HIFQRRGQOVK(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x748BB10", Offset = "0x748AF10", VA = "0x18748BB10")]
		[CompilerGenerated]
		private void HTUYMQWAANL(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class WRPCBDSKKNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly NVWERYDFGQJ LTTPKYIUCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<AEAJIGRLXCJ> MWFBQJHJBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int FNTBOCXFTWO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NRTHBCZMQVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7496AF0", Offset = "0x7495EF0", VA = "0x187496AF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7496C60", Offset = "0x7496060", VA = "0x187496C60")]
		protected WRPCBDSKKNE(NVWERYDFGQJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7496BC0", Offset = "0x7495FC0", VA = "0x187496BC0")]
		public void MPFMGYEILNZ(AEAJIGRLXCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7496B40", Offset = "0x7495F40", VA = "0x187496B40")]
		protected void EMZXTSUGWHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7496C20", Offset = "0x7496020", VA = "0x187496C20")]
		public bool UADIWTBHWMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool AZVWBPWXWVI();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool SBZNEOKGKLF(AEAJIGRLXCJ a);
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
	public class GOMPTZRXQNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly CPGHTRNWCDG XZGBHPICPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int KLDZJZZGBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal RYAWVIJYLPE DHWAHUCZMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint GZBZVCEIAJP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult NZOWBMPPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x133B1E0", Offset = "0x133A5E0", VA = "0x18133B1E0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x133B1F0", Offset = "0x133A5F0", VA = "0x18133B1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x748A4C0", Offset = "0x74898C0", VA = "0x18748A4C0")]
		internal void FBJIDZFRBXC(RYAWVIJYLPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x748A520", Offset = "0x7489920", VA = "0x18748A520")]
		private bool FLDHJLKKASC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x748A550", Offset = "0x7489950", VA = "0x18748A550")]
		internal GOMPTZRXQNB(IPEndPoint a, RYAWVIJYLPE b, CPGHTRNWCDG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x748A460", Offset = "0x7489860", VA = "0x18748A460")]
		public NVWERYDFGQJ Accept()
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
		public CITCSPWOZFE AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QWNWUANKYMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OIZUUTWDRDE(NVWERYDFGQJ a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DPOAJRKZFPW(NVWERYDFGQJ a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DVXIBTSQJVV(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NFQHFYUKSMQ(NVWERYDFGQJ a, CITCSPWOZFE b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZSDQJQLROTI(IPEndPoint a, CITCSPWOZFE b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IDVZQLLISLU(NVWERYDFGQJ a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ROGHLDNANRG(GOMPTZRXQNB a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface YKKFMEVBZPZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QKGSIWMATTM(NVWERYDFGQJ a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VYGEDFJYJVN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VIIDAZQKNME(NFMVMVKIOGU a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface LJSWCVHSFER
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QPUXQOKYTSH(NVWERYDFGQJ a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class RYAWVIJYLPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int JQGDZWSVXNU = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long PVOTSMIHROH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte QYMAIHGPYWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] ATNAQAGAKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly RICQERVXMOC OEEWMRVQBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int ILGUXLOFPYL;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74950E0", Offset = "0x74944E0", VA = "0x1874950E0")]
		private RYAWVIJYLPE(long a, byte b, int c, byte[] d, RICQERVXMOC e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74950B0", Offset = "0x74944B0", VA = "0x1874950B0")]
		public static int NUSKNZYSGSP(AEAJIGRLXCJ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7494EC0", Offset = "0x74942C0", VA = "0x187494EC0")]
		public static RYAWVIJYLPE JMCMHYZYRAC(AEAJIGRLXCJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7494CE0", Offset = "0x74940E0", VA = "0x187494CE0")]
		public static AEAJIGRLXCJ AIBNXCFWEVW(NTCTHYYMOFA a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class IJCRNZYZISN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long PVOTSMIHROH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte QYMAIHGPYWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int ILGUXLOFPYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool BIEQNLWHNZO;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x748ACA0", Offset = "0x748A0A0", VA = "0x18748ACA0")]
		private IJCRNZYZISN(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x748AAA0", Offset = "0x7489EA0", VA = "0x18748AAA0")]
		public static IJCRNZYZISN JMCMHYZYRAC(AEAJIGRLXCJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x748A9B0", Offset = "0x7489DB0", VA = "0x18748A9B0")]
		public static AEAJIGRLXCJ AIBNXCFWEVW(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x748ABA0", Offset = "0x7489FA0", VA = "0x18748ABA0")]
		public static AEAJIGRLXCJ MTRYGNQDEBY(NVWERYDFGQJ a)
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
	public interface LFLAYXHWKVW
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MFQRUHWHQDF(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MPLUSYORACV(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class OLIYIXGNHEH
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
		private class RJTGQAOZHNN
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint RQWAAOAAHYT
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string RUIIPENJFET
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public RJTGQAOZHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class UAXRKYMUMFX
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint RQWAAOAAHYT
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint YIBNKQFRDIF
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string RUIIPENJFET
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public UAXRKYMUMFX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class VPKYTACSNJV
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string RUIIPENJFET
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool YTICEHHMBDT
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xBFA2C0", Offset = "0xBF96C0", VA = "0x180BFA2C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAAC1E0", Offset = "0xAAB5E0", VA = "0x180AAC1E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VPKYTACSNJV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly CPGHTRNWCDG DIVXALALIAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> UJULFSSXYZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> SXMRULUZOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly RICQERVXMOC SWDRYSQUBAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly NTCTHYYMOFA ETVKZCJGDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly AMVIRTEQHAX NCWZFVUHGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private LFLAYXHWKVW SLCQNJEVGUG;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int NEOPVRLZEEZ = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool OCJKKRLIRQG;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7493E50", Offset = "0x7493250", VA = "0x187493E50")]
		internal OLIYIXGNHEH(CPGHTRNWCDG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7493850", Offset = "0x7492C50", VA = "0x187493850")]
		internal void FRTWTANRRXM(IPEndPoint a, AEAJIGRLXCJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x38B1D00", Offset = "0x38B1100", VA = "0x1838B1D00")]
		private void VHAEMUFKRJS<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74939D0", Offset = "0x7492DD0", VA = "0x1874939D0")]
		private void MFQRUHWHQDF(RJTGQAOZHNN a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7493B60", Offset = "0x7492F60", VA = "0x187493B60")]
		private void QQDAKDPVYVP(UAXRKYMUMFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7493CC0", Offset = "0x74930C0", VA = "0x187493CC0")]
		private void WQMVBSYMQPQ(VPKYTACSNJV a, IPEndPoint b)
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
	public static class UNZXNFJBDBU
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] GMEUXRLXLQD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int VIJRAWDZCFD;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int WHZCIAPJCBK;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x748ACF0", Offset = "0x748A0F0", VA = "0x18748ACF0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x748ACF0", Offset = "0x748A0F0", VA = "0x18748ACF0")]
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
	public interface SLITRQDDYPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LURHKYZMKKU(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class IHATYIPBODK
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static SLITRQDDYPC RMDIZIAYCJM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object SZSCKGURRRI;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x748A620", Offset = "0x7489A20", VA = "0x18748A620")]
		private static void FKNURXEOLJD(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x748A8B0", Offset = "0x7489CB0", VA = "0x18748A8B0")]
		internal static void YCPGGFGKGEZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x748A5C0", Offset = "0x74899C0", VA = "0x18748A5C0")]
		internal static void DYNQSGHGMVV(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x748A850", Offset = "0x7489C50", VA = "0x18748A850")]
		internal static void WNHBUVOEKTX(string a, params object[] args)
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
	public sealed class CITCSPWOZFE : RICQERVXMOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private AEAJIGRLXCJ XJTWRFGNJSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly CPGHTRNWCDG RQDHOFBPQTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly MMPJUKITLBR WZADZKFGAKY;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7481670", Offset = "0x7480A70", VA = "0x187481670")]
		internal CITCSPWOZFE(CPGHTRNWCDG a, MMPJUKITLBR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7481550", Offset = "0x7480950", VA = "0x187481550")]
		internal void CRXJIZJFLVZ(AEAJIGRLXCJ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x74815F0", Offset = "0x74809F0", VA = "0x1874815F0")]
		internal void WESFOFXDJES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74815C0", Offset = "0x74809C0", VA = "0x1874815C0")]
		public void MUZOMGUMXVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class MMPJUKITLBR
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
		public MMPJUKITLBR HIQVXEWZVNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType FHKJLFTGJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NVWERYDFGQJ LTTPKYIUCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint GZBZVCEIAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object HLALIPBWLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int UFSZYRAZINW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError BPGTERYYFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason KAJYRGZZUDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GOMPTZRXQNB GOMPTZRXQNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod KILOBEBUWBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte LMQZXYWEMWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly CITCSPWOZFE YYHVLJSSDQB;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x748CFF0", Offset = "0x748C3F0", VA = "0x18748CFF0")]
		public MMPJUKITLBR(CPGHTRNWCDG a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CPGHTRNWCDG : IEnumerable<NVWERYDFGQJ>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class SDWJABXKCAV : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7495860", Offset = "0x7494C60", VA = "0x187495860", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x74958D0", Offset = "0x7494CD0", VA = "0x1874958D0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public SDWJABXKCAV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<NVWERYDFGQJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly NVWERYDFGQJ _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private NVWERYDFGQJ _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public NVWERYDFGQJ Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xC75ED0", Offset = "0xC752D0", VA = "0x180C75ED0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xC75ED0", Offset = "0xC752D0", VA = "0x180C75ED0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1A9D530", Offset = "0x1A9C930", VA = "0x181A9D530")]
			public NetPeerEnumerator(NVWERYDFGQJ p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x74937C0", Offset = "0x7492BC0", VA = "0x1874937C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7493810", Offset = "0x7492C10", VA = "0x187493810", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread PRRGGSRIVAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool LACIQYZRJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool WOTVLUTMMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private CRFRAVDYSDP MJXWMPITIEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent ALHEUPCQZIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<MMPJUKITLBR> VARQVDLFSMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<MMPJUKITLBR> INFBPZCZBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private MMPJUKITLBR PLWNRSYJADY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly QWNWUANKYMU ZYQGTIMYZEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly YKKFMEVBZPZ JDMRFASDKZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly VYGEDFJYJVN CKTKDKGJJFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly LJSWCVHSFER CTOTWPGJNVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, NVWERYDFGQJ> VFQLIGPYDYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, GOMPTZRXQNB> SCUNLCHFSNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, JDXXIHEYSBP> EGWTEHPEYYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim MRSGVPRLMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private NVWERYDFGQJ YRRDMTILOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int AQNEDVCQDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<NVWERYDFGQJ> IUTNGJGBMRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private NVWERYDFGQJ[] JCEQVGGPQMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly EYTUSXUZGNY HKQHEWBPLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int RCTFBEKICWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> CPCUGBESHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte ATZELKKHUBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object BGIRZMAUDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool RYUSOAMCFVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool EDMETQHZWHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int CVWUATPLBTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int RCZOYUJVJNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int UEXCPVONHWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int SLTOUTEMABV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool IGPBBEWQAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool MCFWXIXVZGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int STBUHHDECVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int YIUNLNMMNLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int YXRYERLNCZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool OCJKKRLIRQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool OCTKMIAWAUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool IOVBQFJIEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool SXLNBANTEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int UXJAJFESJDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int QFPZMUSFKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool FNXARBJPNYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly SGGKHYJCQFY VOPCBVAWAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool ILHMOQISUBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly OLIYIXGNHEH OLIYIXGNHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool MBJWCVLPQDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode YBRFUXAFVHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int YERRDTYDKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool KBBOGAEBVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool YRXNGLRUPZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool FIYGFUPRWXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool RDGELOHUWWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private AEAJIGRLXCJ HZGOAPQXEYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int RQACNDLFZHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object IJUAHBADTYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private AEAJIGRLXCJ SRSTSGAKNXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int DGAKLUFYZTF;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int ZJDQQWWOCCN = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int LDDXIQJHRMC = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private MBXXEDIZKYA AHSMMVGMXHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MBXXEDIZKYA AHHYSHSSELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread HWMJCDQFUJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread HWBVHQCLBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint XOOWFGNMPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint XOEIKSZRWQQ;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] LYESHIAJOZQ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] MKLVNANYBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> IVRQRIAOVNB;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress BDZIAZGINOY;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool NXXOSWBXJES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int DGTHZNSHXOY;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool NTDQRICPSQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBA6EA0", Offset = "0xBA62A0", VA = "0x180BA6EA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBA6890", Offset = "0xBA5C90", VA = "0x180BA6890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int YFYSIGLNCSG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF850", Offset = "0x1EFEC50", VA = "0x181EFF850")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x205C3B0", Offset = "0x205B7B0", VA = "0x18205C3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte HWGVAMZPAWV
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB3D050", Offset = "0xB3C450", VA = "0x180B3D050")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int UVSZUMGGMXD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7485E80", Offset = "0x7485280", VA = "0x187485E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short FPUWDVMSAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7488470", Offset = "0x7487870", VA = "0x187488470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NVWERYDFGQJ.OnUpdatedMtuDelegate THBYBILHTFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7484290", Offset = "0x7483690", VA = "0x187484290")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7486650", Offset = "0x7485A50", VA = "0x187486650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7485EA0", Offset = "0x74852A0", VA = "0x187485EA0")]
		public void FYSONBIJZMY(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7488880", Offset = "0x7487C80", VA = "0x187488880")]
		public void SCPQEGAFCZD(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x74870A0", Offset = "0x74864A0", VA = "0x1874870A0")]
		private bool MTNDSNYWEFX(IPEndPoint a, [Out] NVWERYDFGQJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7489A10", Offset = "0x7488E10", VA = "0x187489A10")]
		private void WVZMDSRIPEZ(NVWERYDFGQJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x74826E0", Offset = "0x7481AE0", VA = "0x1874826E0")]
		private void AUFMPDEYJAC(NVWERYDFGQJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7488530", Offset = "0x7487930", VA = "0x187488530")]
		private void RJLKKEMGNXB(NVWERYDFGQJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7489EA0", Offset = "0x74892A0", VA = "0x187489EA0")]
		public CPGHTRNWCDG(QWNWUANKYMU a, [Optional] EYTUSXUZGNY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7489D30", Offset = "0x7489130", VA = "0x187489D30")]
		internal void ZFWVPSHKVFV(NVWERYDFGQJ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x74863A0", Offset = "0x74857A0", VA = "0x1874863A0")]
		internal void JHQODQFZOQT(NVWERYDFGQJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x74875B0", Offset = "0x74869B0", VA = "0x1874875B0")]
		internal void OENKUJTDRDB(NVWERYDFGQJ a, DisconnectReason b, SocketError c, AEAJIGRLXCJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x74871C0", Offset = "0x74865C0", VA = "0x1874871C0")]
		private void NTUNJCWTIDC(NVWERYDFGQJ a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, AEAJIGRLXCJ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7487EF0", Offset = "0x74872F0", VA = "0x187487EF0")]
		private void PJGLQMHFTXY(MMPJUKITLBR.EType a, [Optional] NVWERYDFGQJ b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] GOMPTZRXQNB g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] AEAJIGRLXCJ j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7486790", Offset = "0x7485B90", VA = "0x187486790")]
		private void KPNCXYZTBGV(MMPJUKITLBR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7484A50", Offset = "0x7483E50", VA = "0x187484A50")]
		internal void FHQIJLJGCQF(MMPJUKITLBR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x74843C0", Offset = "0x74837C0", VA = "0x1874843C0")]
		private void EEEQAQPHZGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7484720", Offset = "0x7483B20", VA = "0x187484720")]
		private void ELYBOGNOAEB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7482900", Offset = "0x7481D00", VA = "0x187482900")]
		internal NVWERYDFGQJ CGJHIDFCGOS(GOMPTZRXQNB a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7484340", Offset = "0x7483740", VA = "0x187484340")]
		private int ECCJCUBTLDM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x74875F0", Offset = "0x74869F0", VA = "0x1874875F0")]
		private void ONDCYBVNTKU(IPEndPoint a, NVWERYDFGQJ b, RYAWVIJYLPE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7484B60", Offset = "0x7483F60", VA = "0x187484B60")]
		private void FNUPKJUKUUR(AEAJIGRLXCJ a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7489740", Offset = "0x7488B40", VA = "0x187489740")]
		internal void WSZKCCBHWNP(AEAJIGRLXCJ a, DeliveryMethod b, byte c, int d, NVWERYDFGQJ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7489360", Offset = "0x7488760", VA = "0x187489360")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7489340", Offset = "0x7488740", VA = "0x187489340")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7488B50", Offset = "0x7487F50", VA = "0x187488B50")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74882C0", Offset = "0x74876C0", VA = "0x1874882C0")]
		public void PZVAIIJNQAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x74834F0", Offset = "0x74828F0", VA = "0x1874834F0")]
		public NVWERYDFGQJ Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x74835D0", Offset = "0x74829D0", VA = "0x1874835D0")]
		public NVWERYDFGQJ Connect(string address, int port, NTCTHYYMOFA connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74836B0", Offset = "0x7482AB0", VA = "0x1874836B0")]
		public NVWERYDFGQJ Connect(IPEndPoint target, NTCTHYYMOFA connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74893D0", Offset = "0x74887D0", VA = "0x1874893D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74893E0", Offset = "0x74887E0", VA = "0x1874893E0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74862F0", Offset = "0x74856F0", VA = "0x1874862F0")]
		public void IYZZOORSTGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7486220", Offset = "0x7485620", VA = "0x187486220")]
		public void IYZZOORSTGH(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7487180", Offset = "0x7486580", VA = "0x187487180")]
		public void NTUNJCWTIDC(NVWERYDFGQJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7487140", Offset = "0x7486540", VA = "0x187487140")]
		public void NTUNJCWTIDC(NVWERYDFGQJ a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74887F0", Offset = "0x7487BF0", VA = "0x1874887F0", Slot = "4")]
		private IEnumerator<NVWERYDFGQJ> RSXSLLJWEUH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7486700", Offset = "0x7485B00", VA = "0x187486700", Slot = "5")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7482820", Offset = "0x7481C20", VA = "0x187482820")]
		private AEAJIGRLXCJ BYZGWOZEFTT(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7482740", Offset = "0x7481B40", VA = "0x187482740")]
		private AEAJIGRLXCJ BYZGWOZEFTT(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7482F30", Offset = "0x7482330", VA = "0x187482F30")]
		internal AEAJIGRLXCJ CKVEOYIHRVG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74863F0", Offset = "0x74857F0", VA = "0x1874863F0")]
		internal void KFDOJETLJTT(AEAJIGRLXCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7489DE0", Offset = "0x74891E0", VA = "0x187489DE0")]
		static CPGHTRNWCDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBA6EA0", Offset = "0xBA62A0", VA = "0x180BA6EA0")]
		private bool NAFUZWRYWHC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x74860C0", Offset = "0x74854C0", VA = "0x1874860C0")]
		private void HTCDQOWYCPA(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7486F50", Offset = "0x7486350", VA = "0x187486F50")]
		private void LJEUQCRVAOJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7487D50", Offset = "0x7487150", VA = "0x187487D50")]
		private bool OZBUVVIEFSH(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7486F30", Offset = "0x7486330", VA = "0x187486F30")]
		private void LBKEQWBENHG(CRFRAVDYSDP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7487A90", Offset = "0x7486E90", VA = "0x187487A90")]
		private void OOWXGMQBMYB(MBXXEDIZKYA a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7483170", Offset = "0x7482570", VA = "0x187483170")]
		private void CXEDUECUTTR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7488BD0", Offset = "0x7487FD0", VA = "0x187488BD0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7489D80", Offset = "0x7489180", VA = "0x187489D80")]
		internal int ZMQHVXQMPAM(AEAJIGRLXCJ a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7484250", Offset = "0x7483650", VA = "0x187484250")]
		internal int DCVLXSIDHLU(AEAJIGRLXCJ a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7483A80", Offset = "0x7482E80", VA = "0x187483A80")]
		internal int DCVLXSIDHLU(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74889D0", Offset = "0x7487DD0", VA = "0x1874889D0")]
		internal void SSZVDKFQSDJ(bool a)
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
	internal sealed class AEAJIGRLXCJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int TFVWAUUHWIG;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] HUVFUALHADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] WKMIPDFNEMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int PRRTIFOWKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object HLALIPBWLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AEAJIGRLXCJ HIQVXEWZVNB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty SVLTXAFSJGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7480D20", Offset = "0x7480120", VA = "0x187480D20")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7480AB0", Offset = "0x747FEB0", VA = "0x187480AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte QYMAIHGPYWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7480A80", Offset = "0x747FE80", VA = "0x187480A80")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7480B10", Offset = "0x747FF10", VA = "0x187480B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort JIGAJKCKKML
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7480CC0", Offset = "0x74800C0", VA = "0x187480CC0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7480D50", Offset = "0x7480150", VA = "0x187480D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IJFBFIZOOMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7480DE0", Offset = "0x74801E0", VA = "0x187480DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte WTKOXGHVDXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7480D90", Offset = "0x7480190", VA = "0x187480D90")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7480A50", Offset = "0x747FE50", VA = "0x187480A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort ASTSTBUDLCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7480E10", Offset = "0x7480210", VA = "0x187480E10")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7480B50", Offset = "0x747FF50", VA = "0x187480B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort ACJROTLOCLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7480DC0", Offset = "0x74801C0", VA = "0x187480DC0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7480CE0", Offset = "0x74800E0", VA = "0x187480CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort DGAELYHBBPR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7480AF0", Offset = "0x747FEF0", VA = "0x187480AF0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7480A10", Offset = "0x747FE10", VA = "0x187480A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7480E30", Offset = "0x7480230", VA = "0x187480E30")]
		static AEAJIGRLXCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7480C90", Offset = "0x7480090", VA = "0x187480C90")]
		public void KNJPGXVDURY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74811F0", Offset = "0x74805F0", VA = "0x1874811F0")]
		public AEAJIGRLXCJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74810E0", Offset = "0x74804E0", VA = "0x1874810E0")]
		public AEAJIGRLXCJ(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7480910", Offset = "0x747FD10", VA = "0x187480910")]
		public static int DFLXQHGWBUK(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7480980", Offset = "0x747FD80", VA = "0x187480980")]
		public int DFLXQHGWBUK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7480B90", Offset = "0x747FF90", VA = "0x187480B90")]
		public bool KDXIDWLKMOP()
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
	public class NVWERYDFGQJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class BSKJQMCUKUL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public AEAJIGRLXCJ[] WRIJFPDXDNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int MOFJLQRYBQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int AIPSNUUWOVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte WTKOXGHVDXW;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public BSKJQMCUKUL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int IXOOLQJPWGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int PFQGOJOYSYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int FPFIJIHRQPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double OFLLAHAUSRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int OSOSEFPQTOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int EIUMDXGGCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int WLVABBLAHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch MPQMVFZSIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int HVAMYVKDBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long EQNPGRAESFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object WSFGNKTNIVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal NVWERYDFGQJ KFLPQOQLSEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal NVWERYDFGQJ ERENRSDHJSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<AEAJIGRLXCJ> ZWJOYAZZMQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<WRPCBDSKKNE> HQUPMAYDRHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly WRPCBDSKKNE[] AFYMPKEVTBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int OIQQNGBAGFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int JGQKGMPGLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool OIAODUODCZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int CZAQWPJNYCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int EPNJXUELFJD;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int JEQQZMFNIWJ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int UQRKTUCQDRI = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object CJNPSXFDKQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int TABKSMAUZIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, BSKJQMCUKUL> OAVAYHEGKTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> LBXHPDJONYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly AEAJIGRLXCJ OBCCHBREODX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int ERREDLZJATL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int BHQYPOWFUNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint VWDHJJJZNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int GWEUJMPWVAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int QGJCBWPIQBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long VAQUEUWGLQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte AQMMVQYTCER;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState XDRGJEXUHVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private AEAJIGRLXCJ HPYMJAGWRYF;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int EYYFMQOUMYT = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int SJEVCGAAGXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly AEAJIGRLXCJ IALITPEGKZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly AEAJIGRLXCJ VOBOSBNHHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly AEAJIGRLXCJ XOCENQKRKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly AEAJIGRLXCJ XHKMSWHRISP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality EQMPZVRTSIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly CPGHTRNWCDG CPGHTRNWCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int KVDFRQPXLVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object RDQBVWTLATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly SGGKHYJCQFY VOPCBVAWAIV;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte OFGBHUBLBPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF9C0", VA = "0x180AD05C0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x748FFF0", Offset = "0x748F3F0", VA = "0x18748FFF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint GGLSKJBRMMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBA1430", Offset = "0xBA0830", VA = "0x180BA1430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState PVIJJGIPYYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1236370", Offset = "0x1235770", VA = "0x181236370")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long KYVOEUCDJAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA4700", Offset = "0xAA3B00", VA = "0x180AA4700")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int BMBTDPAZETP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF850", Offset = "0x1EFEC50", VA = "0x181EFF850")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x205C3B0", Offset = "0x205B7B0", VA = "0x18205C3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int RWKAAVKCHZU
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x748F8A0", Offset = "0x748ECA0", VA = "0x18748F8A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int EPWENXJFOLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0E30", Offset = "0xAC0230", VA = "0x180AC0E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double LRGFWZOKRBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x27FDCC0", Offset = "0x27FD0C0", VA = "0x1827FDCC0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate THBYBILHTFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x748F380", Offset = "0x748E780", VA = "0x18748F380")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x748F7F0", Offset = "0x748EBF0", VA = "0x18748F7F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7492E10", Offset = "0x7492210", VA = "0x187492E10")]
		internal NVWERYDFGQJ(CPGHTRNWCDG a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7490850", Offset = "0x748FC50", VA = "0x187490850")]
		internal void QNBSPNZFRHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x748F720", Offset = "0x748EB20", VA = "0x18748F720")]
		internal void GUQURJBUCSY(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7491270", Offset = "0x7490670", VA = "0x187491270")]
		internal void UADVFLGLIVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x74903F0", Offset = "0x748F7F0", VA = "0x1874903F0")]
		private void OSDVEUFVYOW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x748F480", Offset = "0x748E880", VA = "0x18748F480")]
		private void EIJEDGEONBE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7491300", Offset = "0x7490700", VA = "0x187491300")]
		public int UCLTPMPVFRO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7491410", Offset = "0x7490810", VA = "0x187491410")]
		public int UCLTPMPVFRO(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74900A0", Offset = "0x748F4A0", VA = "0x1874900A0")]
		private WRPCBDSKKNE NMLUEEPVKNP(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7492C80", Offset = "0x7492080", VA = "0x187492C80")]
		internal NVWERYDFGQJ(CPGHTRNWCDG a, IPEndPoint b, int c, byte d, NTCTHYYMOFA e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7493210", Offset = "0x7492610", VA = "0x187493210")]
		internal NVWERYDFGQJ(CPGHTRNWCDG a, GOMPTZRXQNB b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7490870", Offset = "0x748FC70", VA = "0x187490870")]
		internal void Reject(RYAWVIJYLPE requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7491530", Offset = "0x7490930", VA = "0x187491530")]
		internal bool USGECWZQJBZ(IJCRNZYZISN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7491C80", Offset = "0x7491080", VA = "0x187491C80")]
		public void VHAEMUFKRJS(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x748FA00", Offset = "0x748EE00", VA = "0x18748FA00")]
		private void LERXRMSKTCR(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x748F430", Offset = "0x748E830", VA = "0x18748F430")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x748F750", Offset = "0x748EB50", VA = "0x18748F750")]
		internal DisconnectResult IHOKNKLQQPP(AEAJIGRLXCJ a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x748F320", Offset = "0x748E720", VA = "0x18748F320")]
		internal void CRCUAJOLCVY(WRPCBDSKKNE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7490F60", Offset = "0x7490360", VA = "0x187490F60")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x748F2E0", Offset = "0x748E6E0", VA = "0x18748F2E0")]
		private void AHYJGIITXJJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x74923E0", Offset = "0x74917E0", VA = "0x1874923E0")]
		internal void ZNHLWUJJDMH(DeliveryMethod a, AEAJIGRLXCJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7491CB0", Offset = "0x74910B0", VA = "0x187491CB0")]
		private void VQQCVWCMQSB(AEAJIGRLXCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74904C0", Offset = "0x748F8C0", VA = "0x1874904C0")]
		private void PNGLDHUWGXT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7490230", Offset = "0x748F630", VA = "0x187490230")]
		internal ConnectRequestResult ONDCYBVNTKU(RYAWVIJYLPE a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74908C0", Offset = "0x748FCC0", VA = "0x1874908C0")]
		internal void SBZNEOKGKLF(AEAJIGRLXCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x748F8B0", Offset = "0x748ECB0", VA = "0x18748F8B0")]
		private void KRJIHQLGCTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74921E0", Offset = "0x74915E0", VA = "0x1874921E0")]
		internal void XUEMBJMNZNN(AEAJIGRLXCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74915B0", Offset = "0x74909B0", VA = "0x1874915B0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x748F4C0", Offset = "0x748E8C0", VA = "0x18748F4C0")]
		internal void EIXVQESQZRL(AEAJIGRLXCJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class SGGKHYJCQFY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long RKHKAVXFKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long BKMXOXJMQZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long RLBLGQYSSUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long LTQFPKGBACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long IZWCBZEDFZO;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long KFAYEISCECL;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long KVLEKKAAAAS;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long EWKACXHNEJH;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long QTMVKUEPMMA;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long KWPKOCHUSED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long QQXGVJRSOYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long GZZHZTZDYYU;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long TMHRPJQZNQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7495A80", Offset = "0x7494E80", VA = "0x187495A80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long YURXJAKIUCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x74959A0", Offset = "0x7494DA0", VA = "0x1874959A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long OCUWQVKAEWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7495910", Offset = "0x7494D10", VA = "0x187495910")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long PBKSMZZTZXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7495A90", Offset = "0x7494E90", VA = "0x187495A90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long ASSMFYVANJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7495900", Offset = "0x7494D00", VA = "0x187495900")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long FBNHUNSAXSD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7495A10", Offset = "0x7494E10", VA = "0x187495A10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long IXMUEADJGUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7495920", Offset = "0x7494D20", VA = "0x187495920")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long SDWHLWKJJZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7495960", Offset = "0x7494D60", VA = "0x187495960")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality SQXAOGOIQZL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1131ED0", Offset = "0x11312D0", VA = "0x181131ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double LABDXTZMIRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7495AE0", Offset = "0x7494EE0", VA = "0x187495AE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7495AA0", Offset = "0x7494EA0", VA = "0x187495AA0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7495A20", Offset = "0x7494E20", VA = "0x187495A20")]
		public void KLAOJWBPSBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7496050", Offset = "0x7495450", VA = "0x187496050")]
		public void XWIWNIAAIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7495B40", Offset = "0x7494F40", VA = "0x187495B40")]
		public void SKTVSCOBUIW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7495F80", Offset = "0x7495380", VA = "0x187495F80")]
		public void ULZQVXAQSJJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x74959B0", Offset = "0x7494DB0", VA = "0x1874959B0")]
		public void JXRBAMZVHWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7495FE0", Offset = "0x74953E0", VA = "0x187495FE0")]
		public void UNIWAEZXOEC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7495C40", Offset = "0x7495040", VA = "0x187495C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7495BA0", Offset = "0x7494FA0", VA = "0x187495BA0")]
		public void TKLIYCZSOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SGGKHYJCQFY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class YJFTRTVCJBA
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> GEXDWGVYFQH;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7496CF0", Offset = "0x74960F0", VA = "0x187496CF0")]
		public static IPEndPoint GIULIEELXRL(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7496F30", Offset = "0x7496330", VA = "0x187496F30")]
		public static IPAddress KHSURQFACFA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x74970F0", Offset = "0x74964F0", VA = "0x1874970F0")]
		public static IPAddress KHSURQFACFA(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7497180", Offset = "0x7496580", VA = "0x187497180")]
		internal static int UONOFRWVRCK(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C006C0", Offset = "0x3BFFAC0", VA = "0x183C006C0")]
		internal static T[] BUOPZQPUDFN<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class CNIMXQSGHQX : WRPCBDSKKNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private AEAJIGRLXCJ _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7494380", Offset = "0x7493780", VA = "0x187494380", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x74942F0", Offset = "0x74936F0", VA = "0x1874942F0")]
			public void HGSJECSPXBK(AEAJIGRLXCJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7494310", Offset = "0x7493710", VA = "0x187494310")]
			public bool QHTFMBADGEF(long a, NVWERYDFGQJ b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x74942A0", Offset = "0x74936A0", VA = "0x1874942A0")]
			public bool Clear(NVWERYDFGQJ peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly AEAJIGRLXCJ WUTFSNUTUUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] ZGZNQASRTAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly AEAJIGRLXCJ[] HYGGWJWMGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] XCIQXPZKKEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int AYIQNIVAGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int WDZTMJOCHJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int DKAALNQMVSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int FEMSJMXUEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool CIPFTYGHWRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod AVNOWNZQZXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool PTOUHSKQJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int NONRULBFZWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte KPPJHRQIDAO;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int FLYPXCWMXOR
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7481F10", Offset = "0x7481310", VA = "0x187481F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7482520", Offset = "0x7481920", VA = "0x187482520")]
		public CNIMXQSGHQX(NVWERYDFGQJ a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x74816C0", Offset = "0x7480AC0", VA = "0x1874816C0")]
		private void AXAFZIBNZQU(AEAJIGRLXCJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7481A40", Offset = "0x7480E40", VA = "0x187481A40", Slot = "4")]
		protected override bool AZVWBPWXWVI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7481F20", Offset = "0x7481320", VA = "0x187481F20", Slot = "5")]
		public override bool SBZNEOKGKLF(AEAJIGRLXCJ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class TZIUGJTOHCM : WRPCBDSKKNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int PHCEINOWXBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort WDZTMJOCHJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool BMPUUWWGOWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private AEAJIGRLXCJ YOXUTPPQIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly AEAJIGRLXCJ UXZYLAEXTRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool MNUTOWKVHYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte KPPJHRQIDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long JXVKTWYOPCE;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x74967E0", Offset = "0x7495BE0", VA = "0x1874967E0")]
		public TZIUGJTOHCM(NVWERYDFGQJ a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74960A0", Offset = "0x74954A0", VA = "0x1874960A0", Slot = "4")]
		protected override bool AZVWBPWXWVI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7496560", Offset = "0x7495960", VA = "0x187496560", Slot = "5")]
		public override bool SBZNEOKGKLF(AEAJIGRLXCJ a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class LUXSHCOPCSV
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
		[Cpp2IlInjected.Address(RVA = "0x747F900", Offset = "0x747ED00", VA = "0x18747F900")]
		private static void HNLLHEZVOJM(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x748B660", Offset = "0x748AA60", VA = "0x18748B660")]
		private static void HNLLHEZVOJM(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x748B620", Offset = "0x748AA20", VA = "0x18748B620")]
		public static void HNLLHEZVOJM(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x748B6D0", Offset = "0x748AAD0", VA = "0x18748B6D0")]
		public static void NMXZRRRUIDH(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x748B700", Offset = "0x748AB00", VA = "0x18748B700")]
		public static void NMXZRRRUIDH(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x748B620", Offset = "0x748AA20", VA = "0x18748B620")]
		public static void NMXZRRRUIDH(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x748B620", Offset = "0x748AA20", VA = "0x18748B620")]
		public static void NMXZRRRUIDH(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x748B660", Offset = "0x748AA60", VA = "0x18748B660")]
		public static void NMXZRRRUIDH(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x748B660", Offset = "0x748AA60", VA = "0x18748B660")]
		public static void NMXZRRRUIDH(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x748B6F0", Offset = "0x748AAF0", VA = "0x18748B6F0")]
		public static void NMXZRRRUIDH(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x748B6F0", Offset = "0x748AAF0", VA = "0x18748B6F0")]
		public static void NMXZRRRUIDH(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class RICQERVXMOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] SSUYQTCBQQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int IJQPLBOTVEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int RLSGKPPDUJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int LGZKWMKFVQQ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] WKMIPDFNEMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int LLNBDNHUYBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int RKJOASXFYPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7494B80", Offset = "0x7493F80", VA = "0x187494B80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool XGZATZDCEZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2767390", Offset = "0x2766790", VA = "0x182767390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int SOTZQFWXUTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7494940", Offset = "0x7493D40", VA = "0x187494940")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x74944E0", Offset = "0x74938E0", VA = "0x1874944E0")]
		public void CRXJIZJFLVZ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public RICQERVXMOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7494C80", Offset = "0x7494080", VA = "0x187494C80")]
		public RICQERVXMOC(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7494A10", Offset = "0x7493E10", VA = "0x187494A10")]
		public IPEndPoint OJILMCBEQRO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7494890", Offset = "0x7493C90", VA = "0x187494890")]
		public byte QVLYNPCDERS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7494890", Offset = "0x7493C90", VA = "0x187494890")]
		public sbyte FYBLPRMNXXL()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x39468A0", Offset = "0x3945CA0", VA = "0x1839468A0")]
		public a[] GURCZFRAZVR<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7494430", Offset = "0x7493830", VA = "0x187494430")]
		public bool[] AXLJNVYCDTJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7494C00", Offset = "0x7494000", VA = "0x187494C00")]
		public ushort[] YYRWLRRZCYS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x74949D0", Offset = "0x7493DD0", VA = "0x1874949D0")]
		public short[] LTMASOLXVJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7494820", Offset = "0x7493C20", VA = "0x187494820")]
		public int[] EPRCHTKMHZG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x74943F0", Offset = "0x74937F0", VA = "0x1874943F0")]
		public uint[] ANRHCBUASLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7494990", Offset = "0x7493D90", VA = "0x187494990")]
		public float[] LLMQNWBFWYJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x74944A0", Offset = "0x74938A0", VA = "0x1874944A0")]
		public double[] BRVZBVMRMNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7494950", Offset = "0x7493D50", VA = "0x187494950")]
		public long[] LENHFMIDARD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7494C40", Offset = "0x7494040", VA = "0x187494C40")]
		public ulong[] ZRNKAFKTQCQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7494540", Offset = "0x7493940", VA = "0x187494540")]
		public string[] DOEXZXWKEUE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7494B10", Offset = "0x7493F10", VA = "0x187494B10")]
		public bool WYMHUIPWDPA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7494470", Offset = "0x7493870", VA = "0x187494470")]
		public char BFSFHRMUEJY()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7494470", Offset = "0x7493870", VA = "0x187494470")]
		public ushort WEAYICMXTIF()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7494470", Offset = "0x7493870", VA = "0x187494470")]
		public short MENBRVXREFO()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7494910", Offset = "0x7493D10", VA = "0x187494910")]
		public long GUDWPFWUGNO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7494910", Offset = "0x7493D10", VA = "0x187494910")]
		public ulong LUBEGHVABBR()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7494860", Offset = "0x7493C60", VA = "0x187494860")]
		public int VLKAURBWOXB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7494860", Offset = "0x7493C60", VA = "0x187494860")]
		public uint FJHDVXJLNAW()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7494B50", Offset = "0x7493F50", VA = "0x187494B50")]
		public float XNKHIULZGKA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7494AA0", Offset = "0x7493EA0", VA = "0x187494AA0")]
		public double OMYDXMDUCHV()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7494610", Offset = "0x7493A10", VA = "0x187494610")]
		public string EEUUGMVHCHJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7494B90", Offset = "0x7493F90", VA = "0x187494B90")]
		public ArraySegment<byte> YUTSTXNCVNA(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x74948D0", Offset = "0x7493CD0", VA = "0x1874948D0")]
		public sbyte[] GRCZNWFZPHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7494AD0", Offset = "0x7493ED0", VA = "0x187494AD0")]
		public byte[] PSPRXCMAKMR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7494520", Offset = "0x7493920", VA = "0x187494520")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class NTCTHYYMOFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] SSUYQTCBQQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int IJQPLBOTVEQ;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int WUZMNPGXFGX = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool RNIEEDXVBTC;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding ZLFGXGPCCXS;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int JUMQHFOWUCB = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] EEDTZCJTJEY;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] OEEWMRVQBKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int VYHQWEDMMIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x748F1C0", Offset = "0x748E5C0", VA = "0x18748F1C0")]
		public NTCTHYYMOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x748F240", Offset = "0x748E640", VA = "0x18748F240")]
		public NTCTHYYMOFA(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x748F0D0", Offset = "0x748E4D0", VA = "0x18748F0D0")]
		public static NTCTHYYMOFA YMSORPRDUMX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x748F030", Offset = "0x748E430", VA = "0x18748F030")]
		public void XUGCLUZBVOB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x27DF190", Offset = "0x27DE590", VA = "0x1827DF190")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x748EA60", Offset = "0x748DE60", VA = "0x18748EA60")]
		public void EJMCKICORJJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x748E6B0", Offset = "0x748DAB0", VA = "0x18748E6B0")]
		public void EJMCKICORJJ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x748E660", Offset = "0x748DA60", VA = "0x18748E660")]
		public void EJMCKICORJJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x748E660", Offset = "0x748DA60", VA = "0x18748E660")]
		public void EJMCKICORJJ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x748E510", Offset = "0x748D910", VA = "0x18748E510")]
		public void EJMCKICORJJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x748E510", Offset = "0x748D910", VA = "0x18748E510")]
		public void EJMCKICORJJ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x748E700", Offset = "0x748DB00", VA = "0x18748E700")]
		public void EJMCKICORJJ(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x748E700", Offset = "0x748DB00", VA = "0x18748E700")]
		public void EJMCKICORJJ(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x748E700", Offset = "0x748DB00", VA = "0x18748E700")]
		public void EJMCKICORJJ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x748E600", Offset = "0x748DA00", VA = "0x18748E600")]
		public void EJMCKICORJJ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x748E600", Offset = "0x748DA00", VA = "0x18748E600")]
		public void EJMCKICORJJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x748E4A0", Offset = "0x748D8A0", VA = "0x18748E4A0")]
		public void EJMCKICORJJ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x748EB00", Offset = "0x748DF00", VA = "0x18748EB00")]
		public void GKYVDPWEVQT(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x748EB00", Offset = "0x748DF00", VA = "0x18748EB00")]
		public void NUDKFDCPRLA(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x748E5A0", Offset = "0x748D9A0", VA = "0x18748E5A0")]
		public void EJMCKICORJJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x748EF50", Offset = "0x748E350", VA = "0x18748EF50")]
		public void GSTLJLAHNPS(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x748ED90", Offset = "0x748E190", VA = "0x18748ED90")]
		public void GSTLJLAHNPS(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x748EBE0", Offset = "0x748DFE0", VA = "0x18748EBE0")]
		public void GSTLJLAHNPS(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x748EBE0", Offset = "0x748DFE0", VA = "0x18748EBE0")]
		public void GSTLJLAHNPS(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x748EBE0", Offset = "0x748DFE0", VA = "0x18748EBE0")]
		public void GSTLJLAHNPS(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x748ED90", Offset = "0x748E190", VA = "0x18748ED90")]
		public void GSTLJLAHNPS(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x748ED90", Offset = "0x748E190", VA = "0x18748ED90")]
		public void GSTLJLAHNPS(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x748EE70", Offset = "0x748E270", VA = "0x18748EE70")]
		public void GSTLJLAHNPS(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x748EE70", Offset = "0x748E270", VA = "0x18748EE70")]
		public void GSTLJLAHNPS(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x748EB00", Offset = "0x748DF00", VA = "0x18748EB00")]
		public void GSTLJLAHNPS(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x748ECC0", Offset = "0x748E0C0", VA = "0x18748ECC0")]
		public void GSTLJLAHNPS(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x748E980", Offset = "0x748DD80", VA = "0x18748E980")]
		public void EJMCKICORJJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x748EA50", Offset = "0x748DE50", VA = "0x18748EA50")]
		public void EJMCKICORJJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x748E770", Offset = "0x748DB70", VA = "0x18748E770")]
		public void EJMCKICORJJ(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AMVIRTEQHAX
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class CICJGCTQHBB<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong KVDFRQPXLVJ;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9320", Offset = "0x3CF8720", VA = "0x183CF9320")]
			static CICJGCTQHBB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(RICQERVXMOC reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class JYWFFKSWQNS<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public AMVIRTEQHAX ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a VHNJLMLUGXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> XUXKRQNPBEE;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public JYWFFKSWQNS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5134C90", Offset = "0x5134090", VA = "0x185134C90")]
			internal void OTMVWKKZBPJ(RICQERVXMOC a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class VJTWBREFQAQ<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public AMVIRTEQHAX ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a VHNJLMLUGXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> XUXKRQNPBEE;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VJTWBREFQAQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x624FB50", Offset = "0x624EF50", VA = "0x18624FB50")]
			internal void OTMVWKKZBPJ(RICQERVXMOC a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly ZYMFUMWAJJL WFCBHMOYSWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> LFRXRGYJNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly NTCTHYYMOFA RRIPARINJVH;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7481400", Offset = "0x7480800", VA = "0x187481400")]
		public AMVIRTEQHAX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x306E0B0", Offset = "0x306D4B0", VA = "0x18306E0B0", Slot = "4")]
		protected virtual ulong ZKGMVBUGCMS<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7481260", Offset = "0x7480660", VA = "0x187481260", Slot = "5")]
		protected virtual SubscribeDelegate GWRGZPUTSVH(RICQERVXMOC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x306DFA0", Offset = "0x306D3A0", VA = "0x18306DFA0", Slot = "6")]
		protected virtual void BQDBMVOKTAN<b>(NTCTHYYMOFA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7481380", Offset = "0x7480780", VA = "0x187481380")]
		public void TMDKJZHWLOS(RICQERVXMOC a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x306E020", Offset = "0x306D420", VA = "0x18306E020")]
		public void IYIBFQZDSVL<j>(NTCTHYYMOFA a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7481330", Offset = "0x7480730", VA = "0x187481330")]
		public void RIHJINOVRDI(RICQERVXMOC a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x306DE20", Offset = "0x306D220", VA = "0x18306DE20")]
		public void AJNQSTLQUCL<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x306DE20", Offset = "0x306D220", VA = "0x18306DE20")]
		public void AJNQSTLQUCL<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x748ACF0", Offset = "0x748A0F0", VA = "0x18748ACF0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7494240", Offset = "0x7493640", VA = "0x187494240")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class ZYMFUMWAJJL
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
		private abstract class PGRLNXYWHQP<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType FHKJLFTGJNM;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5A45920", Offset = "0x5A44D20", VA = "0x185A45920", Slot = "4")]
			public virtual void HGSJECSPXBK(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void SKXQQQWOOAS(a a, RICQERVXMOC b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void IYIBFQZDSVL(a a, NTCTHYYMOFA b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void MJUPNITZHNV(a a, RICQERVXMOC b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void CXZLTABFISS(a a, NTCTHYYMOFA b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void EUSKWLRPLRI(a a, RICQERVXMOC b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void UEJGEHXOAZP(a a, NTCTHYYMOFA b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			protected PGRLNXYWHQP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class EWGYOOOMJLU<a, b> : PGRLNXYWHQP<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> SUEJZCCDZOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> XYBCBLAYNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> UPEBUPVVTBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> JEICGLBXZUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> UANBUNVWWDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> DRXTQGHENGR;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x475A090", Offset = "0x4759490", VA = "0x18475A090", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x475A090", Offset = "0x4759490", VA = "0x18475A090", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x475A160", Offset = "0x4759560", VA = "0x18475A160", Slot = "9")]
			public override void EUSKWLRPLRI(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x475A160", Offset = "0x4759560", VA = "0x18475A160", Slot = "10")]
			public override void UEJGEHXOAZP(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x475A7A0", Offset = "0x4759BA0", VA = "0x18475A7A0")]
			protected b[] OVVSSKCZCCL(a a, RICQERVXMOC b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x475A870", Offset = "0x4759C70", VA = "0x18475A870")]
			protected b[] YAJQXGZTFHI(a a, NTCTHYYMOFA b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x475A230", Offset = "0x4759630", VA = "0x18475A230", Slot = "4")]
			public override void HGSJECSPXBK(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x475A8D0", Offset = "0x4759CD0", VA = "0x18475A8D0")]
			protected EWGYOOOMJLU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class VYNKQTSCDFX<a, b> : EWGYOOOMJLU<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void KHNXLDTLWAS(RICQERVXMOC a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void XYKCXGSMRDD(NTCTHYYMOFA a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x626D210", Offset = "0x626C610", VA = "0x18626D210", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x626CBA0", Offset = "0x626BFA0", VA = "0x18626CBA0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x626CDE0", Offset = "0x626C1E0", VA = "0x18626CDE0", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x626C910", Offset = "0x626BD10", VA = "0x18626C910", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x626D300", Offset = "0x626C700", VA = "0x18626D300")]
			protected VYNKQTSCDFX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class ZZEAWVDZXKM<a> : EWGYOOOMJLU<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3F1AB40", Offset = "0x3F19F40", VA = "0x183F1AB40", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3F1A8A0", Offset = "0x3F19CA0", VA = "0x183F1A8A0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3F1A8E0", Offset = "0x3F19CE0", VA = "0x183F1A8E0", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3F1A660", Offset = "0x3F19A60", VA = "0x183F1A660", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public ZZEAWVDZXKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class SFGQSMHLNRH<a> : EWGYOOOMJLU<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3F1AB40", Offset = "0x3F19F40", VA = "0x183F1AB40", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3F1A8A0", Offset = "0x3F19CA0", VA = "0x183F1A8A0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x5DAD8F0", Offset = "0x5DACCF0", VA = "0x185DAD8F0", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3F1A660", Offset = "0x3F19A60", VA = "0x183F1A660", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public SFGQSMHLNRH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class KQSEXETGWBJ<a> : EWGYOOOMJLU<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4D65080", Offset = "0x4D64480", VA = "0x184D65080", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4D64EF0", Offset = "0x4D642F0", VA = "0x184D64EF0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5272460", Offset = "0x5271860", VA = "0x185272460", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4D64CB0", Offset = "0x4D640B0", VA = "0x184D64CB0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public KQSEXETGWBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class FLCSYHECTJY<a> : EWGYOOOMJLU<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4D65080", Offset = "0x4D64480", VA = "0x184D65080", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x4D64EF0", Offset = "0x4D642F0", VA = "0x184D64EF0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4D64F30", Offset = "0x4D64330", VA = "0x184D64F30", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4D64CB0", Offset = "0x4D640B0", VA = "0x184D64CB0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public FLCSYHECTJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class ZKCOGDBJUXF<a> : EWGYOOOMJLU<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0AC0", Offset = "0x3EAFEC0", VA = "0x183EB0AC0", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0720", Offset = "0x3EAFB20", VA = "0x183EB0720", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0960", Offset = "0x3EAFD60", VA = "0x183EB0960", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3EB06E0", Offset = "0x3EAFAE0", VA = "0x183EB06E0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public ZKCOGDBJUXF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class DKYHZRXQXMI<a> : EWGYOOOMJLU<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0AC0", Offset = "0x3EAFEC0", VA = "0x183EB0AC0", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0720", Offset = "0x3EAFB20", VA = "0x183EB0720", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x407CAC0", Offset = "0x407BEC0", VA = "0x18407CAC0", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3EB06E0", Offset = "0x3EAFAE0", VA = "0x183EB06E0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public DKYHZRXQXMI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class OQJTXHLYBNR<a> : EWGYOOOMJLU<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x59895B0", Offset = "0x59889B0", VA = "0x1859895B0", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x5989320", Offset = "0x5988720", VA = "0x185989320", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5989560", Offset = "0x5988960", VA = "0x185989560", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5863BD0", Offset = "0x5862FD0", VA = "0x185863BD0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public OQJTXHLYBNR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class RNIMAUXTEVY<a> : EWGYOOOMJLU<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x59895B0", Offset = "0x59889B0", VA = "0x1859895B0", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5989320", Offset = "0x5988720", VA = "0x185989320", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5B65FB0", Offset = "0x5B653B0", VA = "0x185B65FB0", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5863BD0", Offset = "0x5862FD0", VA = "0x185863BD0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public RNIMAUXTEVY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class KJDJJIOXWBF<a> : EWGYOOOMJLU<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x5234D40", Offset = "0x5234140", VA = "0x185234D40", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x5234AB0", Offset = "0x5233EB0", VA = "0x185234AB0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x5234CF0", Offset = "0x52340F0", VA = "0x185234CF0", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3F1A660", Offset = "0x3F19A60", VA = "0x183F1A660", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public KJDJJIOXWBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class IHTVJBHZLSY<a> : EWGYOOOMJLU<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x5015890", Offset = "0x5014C90", VA = "0x185015890", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x50154F0", Offset = "0x50148F0", VA = "0x1850154F0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x5015730", Offset = "0x5014B30", VA = "0x185015730", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3EB06E0", Offset = "0x3EAFAE0", VA = "0x183EB06E0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public IHTVJBHZLSY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class NWDVEAMLVVP<a> : EWGYOOOMJLU<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x5863FA0", Offset = "0x58633A0", VA = "0x185863FA0", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x5863E10", Offset = "0x5863210", VA = "0x185863E10", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x5863F50", Offset = "0x5863350", VA = "0x185863F50", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x5863BD0", Offset = "0x5862FD0", VA = "0x185863BD0", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B10", Offset = "0x3EAFF10", VA = "0x183EB0B10")]
			public NWDVEAMLVVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class GGRVZWTAUTX<a> : VYNKQTSCDFX<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4E8D060", Offset = "0x4E8C460", VA = "0x184E8D060", Slot = "12")]
			protected override void XYKCXGSMRDD(NTCTHYYMOFA a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x4E8D030", Offset = "0x4E8C430", VA = "0x184E8D030", Slot = "11")]
			protected override void KHNXLDTLWAS(RICQERVXMOC a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x4E8D090", Offset = "0x4E8C490", VA = "0x184E8D090")]
			public GGRVZWTAUTX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class RSAQSPZVIBT<a> : VYNKQTSCDFX<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5B815A0", Offset = "0x5B809A0", VA = "0x185B815A0", Slot = "12")]
			protected override void XYKCXGSMRDD(NTCTHYYMOFA a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5B81560", Offset = "0x5B80960", VA = "0x185B81560", Slot = "11")]
			protected override void KHNXLDTLWAS(RICQERVXMOC a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4E8D090", Offset = "0x4E8C490", VA = "0x184E8D090")]
			public RSAQSPZVIBT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class DFSSTQBLEBS<a> : EWGYOOOMJLU<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int ADIMKEBKAJF;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x40794F0", Offset = "0x40788F0", VA = "0x1840794F0")]
			public DFSSTQBLEBS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4079440", Offset = "0x4078840", VA = "0x184079440", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4079070", Offset = "0x4078470", VA = "0x184079070", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x40791C0", Offset = "0x40785C0", VA = "0x1840791C0", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x4079020", Offset = "0x4078420", VA = "0x184079020", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class LMYLCGNVAWO<a> : PGRLNXYWHQP<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo SVLTXAFSJGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type UVASSHPVFOH;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5324030", Offset = "0x5323430", VA = "0x185324030")]
			public LMYLCGNVAWO(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5323E70", Offset = "0x5323270", VA = "0x185323E70", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5323DF0", Offset = "0x53231F0", VA = "0x185323DF0", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x5323C30", Offset = "0x5323030", VA = "0x185323C30", Slot = "7")]
			public override void MJUPNITZHNV(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x5323C30", Offset = "0x5323030", VA = "0x185323C30", Slot = "8")]
			public override void CXZLTABFISS(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x5323C80", Offset = "0x5323080", VA = "0x185323C80", Slot = "9")]
			public override void EUSKWLRPLRI(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x5323C80", Offset = "0x5323080", VA = "0x185323C80", Slot = "10")]
			public override void UEJGEHXOAZP(a a, NTCTHYYMOFA b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class PTIBONHPUCH<a> : LMYLCGNVAWO<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x5A662B0", Offset = "0x5A656B0", VA = "0x185A662B0")]
			public PTIBONHPUCH(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x5A660F0", Offset = "0x5A654F0", VA = "0x185A660F0", Slot = "5")]
			public override void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x5A66070", Offset = "0x5A65470", VA = "0x185A66070", Slot = "6")]
			public override void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class ESIKAVOTLQJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static ESIKAVOTLQJ<a> ZOZTORXSSBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly PGRLNXYWHQP<a>[] HUOCYETGEZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int YVSMUPWCPCZ;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4754FD0", Offset = "0x47543D0", VA = "0x184754FD0")]
			public ESIKAVOTLQJ(List<PGRLNXYWHQP<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4754CD0", Offset = "0x47540D0", VA = "0x184754CD0")]
			public void IYIBFQZDSVL(a a, NTCTHYYMOFA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4754D80", Offset = "0x4754180", VA = "0x184754D80")]
			public void SKXQQQWOOAS(a a, RICQERVXMOC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class SFWMLYQLGJX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract PGRLNXYWHQP<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private NTCTHYYMOFA OEEKSXWFKWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int QPHMCCQEXIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, SFWMLYQLGJX> QMSABLQEQNO;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7497230", Offset = "0x7496630", VA = "0x187497230")]
		public ZYMFUMWAJJL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C16910", Offset = "0x3C15D10", VA = "0x183C16910")]
		private ESIKAVOTLQJ<d> JNQPHSSLDAW<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C17750", Offset = "0x3C16B50", VA = "0x183C17750")]
		public void MKOAUOREKWX<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C15A70", Offset = "0x3C14E70", VA = "0x183C15A70")]
		public bool Deserialize<T>(RICQERVXMOC reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C17690", Offset = "0x3C16A90", VA = "0x183C17690")]
		public void MFMKHXDBDDO<f>(NTCTHYYMOFA a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NFMVMVKIOGU
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime AIMGJLLZFTZ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] QDCHQLCOZTP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator LUGIVIFEYUN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x748D0F0", Offset = "0x748C4F0", VA = "0x18748D0F0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int SSHVHVXCIXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x748D310", Offset = "0x748C710", VA = "0x18748D310")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x748DED0", Offset = "0x748D2D0", VA = "0x18748DED0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode OBBIKPCYHUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x748D2E0", Offset = "0x748C6E0", VA = "0x18748D2E0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x748E020", Offset = "0x748D420", VA = "0x18748E020")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int BAGCEUCQTJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x748E060", Offset = "0x748D460", VA = "0x18748E060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint MPHUKAHTYRI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x748D340", Offset = "0x748C740", VA = "0x18748D340")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? AKAERMNTOFS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x748DD80", Offset = "0x748D180", VA = "0x18748DD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? NATMTPXXOGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x748DDB0", Offset = "0x748D1B0", VA = "0x18748DDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? XISXTOJAVWG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x748DDE0", Offset = "0x748D1E0", VA = "0x18748DDE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x748D570", Offset = "0x748C970", VA = "0x18748D570")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? QBGJPJVXUXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xC97CF0", Offset = "0xC970F0", VA = "0x180C97CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x748E0F0", Offset = "0x748D4F0", VA = "0x18748E0F0")]
		public NFMVMVKIOGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x748E400", Offset = "0x748D800", VA = "0x18748E400")]
		internal NFMVMVKIOGU(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x748DF10", Offset = "0x748D310", VA = "0x18748DF10")]
		public static NFMVMVKIOGU WSBKJFLGXOS(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x748D730", Offset = "0x748CB30", VA = "0x18748D730")]
		internal void LSYTFXHEEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x748D120", Offset = "0x748C520", VA = "0x18748D120")]
		private void DWPKYSQSKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x748D3A0", Offset = "0x748C7A0", VA = "0x18748D3A0")]
		private DateTime? JKMTOIBVYRX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x748DBC0", Offset = "0x748CFC0", VA = "0x18748DBC0")]
		private void OZOHVRPFLGN(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x748DAB0", Offset = "0x748CEB0", VA = "0x18748DAB0")]
		private ulong MYCHKRNFAHT(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x748DE10", Offset = "0x748D210", VA = "0x18748DE10")]
		private void SLBCFWTXJFX(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x748DB60", Offset = "0x748CF60", VA = "0x18748DB60")]
		private uint OFDZKGNUCUS(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x734EC90", Offset = "0x734E090", VA = "0x18734EC90")]
		private static uint CKKVHFWPOVH(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x748D090", Offset = "0x748C490", VA = "0x18748D090")]
		private static ulong CKKVHFWPOVH(ulong a)
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
	internal sealed class JDXXIHEYSBP
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int JXPWOQFDPAC = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int MDKEXXIIZVR = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int XWRKCSRKAGM = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint JQKXQDXMRTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int TQPSXZAAEWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int GRYZFZHCJJI;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool YMQJFHOMMLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x748AD00", Offset = "0x748A100", VA = "0x18748AD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x748AD10", Offset = "0x748A110", VA = "0x18748AD10")]
		public bool VHAEMUFKRJS(MBXXEDIZKYA a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class JIFWAFNYGFH : MBXXEDIZKYA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket YWMXUBLZXGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly CPGHTRNWCDG EDOQIQGEDJG;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short FPUWDVMSAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x748B4F0", Offset = "0x748A8F0", VA = "0x18748B4F0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int SSUSXSZZQAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x748AE00", Offset = "0x748A200", VA = "0x18748AE00", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint PPZXGCSASPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x748B510", Offset = "0x748A910", VA = "0x18748B510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily JXYTSNDZJYC
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2FEE880", Offset = "0x2FEDC80", VA = "0x182FEE880", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x748B570", Offset = "0x748A970", VA = "0x18748B570")]
		public JIFWAFNYGFH(AddressFamily a, CPGHTRNWCDG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x748AE20", Offset = "0x748A220", VA = "0x18748AE20", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x748B530", Offset = "0x748A930", VA = "0x18748B530", Slot = "9")]
		public int XUESSIICSTD(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x748B400", Offset = "0x748A800", VA = "0x18748B400", Slot = "10")]
		public int IUSGWWCLPYD(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x748B3E0", Offset = "0x748A7E0", VA = "0x18748B3E0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface MBXXEDIZKYA
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short FPUWDVMSAKG
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int SSUSXSZZQAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint PPZXGCSASPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily JXYTSNDZJYC
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
		int XUESSIICSTD(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int IUSGWWCLPYD(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x74934E0", Offset = "0x74928E0", VA = "0x1874934E0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7493580", Offset = "0x7492980", VA = "0x187493580")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x133B1E0", Offset = "0x133A5E0", VA = "0x18133B1E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x74933F0", Offset = "0x74927F0", VA = "0x1874933F0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7493430", Offset = "0x7492830", VA = "0x187493430", Slot = "0")]
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
	public class CRFRAVDYSDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string BHPANSTKYDL = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int JMESRSBIEBF = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int QSFPPJPTNWV = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int MNAUPKIYHVH = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> RWASWSSYKXW;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback NTCHWAWNJLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int VNKTNYZYTGD;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		internal void DMJRCXRILSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		internal void THYTXZBEXLV(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class EYTUSXUZGNY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int UVSZUMGGMXD;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
		protected EYTUSXUZGNY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CBBKGUCYJZO(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void JNMTWRUNGNZ(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ADNJYYAZDEG : EYTUSXUZGNY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] OGKRXNXYGFP;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator FVIHXPYLHLF;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x28E5F70", Offset = "0x28E5370", VA = "0x1828E5F70")]
		public ADNJYYAZDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7480630", Offset = "0x747FA30", VA = "0x187480630")]
		public void JWTENXWBUMA(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x74807E0", Offset = "0x747FBE0", VA = "0x1874807E0")]
		public void KQIQNAQKIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x747FEE0", Offset = "0x747F2E0", VA = "0x18747FEE0", Slot = "4")]
		public override void CBBKGUCYJZO(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7480330", Offset = "0x747F730", VA = "0x187480330", Slot = "5")]
		public override void JNMTWRUNGNZ(IPEndPoint a, byte[] b, int c, int d)
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
		public unsafe delegate void Encrypt_0000039F$PostfixBurstDelegate([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int length);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		internal static class VHCWCOKIKHT
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr SFNQWWGNGJJ;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x74973C0", Offset = "0x74967C0", VA = "0x1874973C0")]
			[BurstDiscard]
			private static void BLWLEECSSFF(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7497790", Offset = "0x7496B90", VA = "0x187497790")]
			private static IntPtr ONEWNOTNXCL()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7497550", Offset = "0x7496950", VA = "0x187497550")]
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
		[Cpp2IlInjected.Address(RVA = "0x7495780", Offset = "0x7494B80", VA = "0x187495780")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7495750", Offset = "0x7494B50", VA = "0x187495750")]
		private uint KPTFYBYZRHK(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x747FB20", Offset = "0x747EF20", VA = "0x18747FB20")]
		private void EHSVDZFMNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x747FCD0", Offset = "0x747F0D0", VA = "0x18747FCD0")]
		private void WWPBODBJRWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x747FA90", Offset = "0x747EE90", VA = "0x18747FA90")]
		private void BYTMBOAAVUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x747FBD0", Offset = "0x747EFD0", VA = "0x18747FBD0")]
		private void QAWHQLXAEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7495800", Offset = "0x7494C00", VA = "0x187495800")]
		private void VGPDPSHDPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7495200", Offset = "0x7494600", VA = "0x187495200")]
		private unsafe void HCBFDLUAOMK(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7495620", Offset = "0x7494A20", VA = "0x187495620")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void HLDTKAWBXBN([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7495630", Offset = "0x7494A30", VA = "0x187495630")]
		public static void HLDTKAWBXBN(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7495150", Offset = "0x7494550", VA = "0x187495150")]
		public static void AYDWNJIWGEP(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x74956E0", Offset = "0x7494AE0", VA = "0x1874956E0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void ISIMKBQQACW([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7497380", Offset = "0x7496780", VA = "0x187497380")]
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
