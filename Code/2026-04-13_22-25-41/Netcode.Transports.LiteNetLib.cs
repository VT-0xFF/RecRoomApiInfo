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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A5A860", Offset = "0x8A59260", VA = "0x188A5A860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A5A810", Offset = "0x8A59210", VA = "0x188A5A810", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A59D10", Offset = "0x8A58710", VA = "0x188A59D10")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A59CF0", Offset = "0x8A586F0", VA = "0x188A59CF0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A59B50", Offset = "0x8A58550", VA = "0x188A59B50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A650", Offset = "0x8A59050", VA = "0x188A5A650")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A59E20", Offset = "0x8A58820", VA = "0x188A59E20", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A59C60", Offset = "0x8A58660", VA = "0x188A59C60", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A0F0", Offset = "0x8A58AF0", VA = "0x188A5A0F0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A430", Offset = "0x8A58E30", VA = "0x188A5A430", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A59370", Offset = "0x8A57D70", VA = "0x188A59370", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A59280", Offset = "0x8A57C80", VA = "0x188A59280", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A59780", Offset = "0x8A58180", VA = "0x188A59780", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A080", Offset = "0x8A58A80", VA = "0x188A5A080", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A598E0", Offset = "0x8A582E0", VA = "0x188A598E0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A670", Offset = "0x8A59070", VA = "0x188A5A670")]
		private DeliveryMethod ZBIGXIELOYX(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A59820", Offset = "0x8A58220", VA = "0x188A59820", Slot = "16")]
		private void HTTUHBIAVOI(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A591B0", Offset = "0x8A57BB0", VA = "0x188A591B0", Slot = "17")]
		private void CTUFYUEMEJI(OCQTFLRKKPN a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "18")]
		private void DBHBQZWGNVX(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A59580", Offset = "0x8A57F80", VA = "0x188A59580", Slot = "19")]
		private void FPVHCMHIPZI(OCQTFLRKKPN a, OQXRLZMXBEE b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A594B0", Offset = "0x8A57EB0", VA = "0x188A594B0")]
		private void FNAJUKCBPHL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "20")]
		private void IIQBTLXWPCI(IPEndPoint a, OQXRLZMXBEE b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "21")]
		private void QNNZWEUKELG(OCQTFLRKKPN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A59AF0", Offset = "0x8A584F0", VA = "0x188A59AF0", Slot = "22")]
		private void KWFNPOYLOFQ(FULTMNFEJJL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A59CC0", Offset = "0x8A586C0", VA = "0x188A59CC0")]
		private ulong QPEOZRHLDNH(OCQTFLRKKPN a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A59CA0", Offset = "0x8A586A0", VA = "0x188A59CA0")]
		private ulong QPEOZRHLDNH(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A59C40", Offset = "0x8A58640", VA = "0x188A59C40")]
		private static int PCNSXNCFEAC(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A740", Offset = "0x8A59140", VA = "0x188A5A740")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A59480", Offset = "0x8A57E80", VA = "0x188A59480")]
		[CompilerGenerated]
		private void FCPSOWYINXY(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A59480", Offset = "0x8A57E80", VA = "0x188A59480")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A5AB00", Offset = "0x8A59500", VA = "0x188A5AB00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AB50", Offset = "0x8A59550", VA = "0x188A5AB50")]
		protected MZKDLBKFQPW(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AAA0", Offset = "0x8A594A0", VA = "0x188A5AAA0")]
		public void UBIZAIIRWHD(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AA20", Offset = "0x8A59420", VA = "0x188A5AA20")]
		protected void TBKRAEODFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A9E0", Offset = "0x8A593E0", VA = "0x188A5A9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1621850", Offset = "0x1620250", VA = "0x181621850")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1621860", Offset = "0x1620260", VA = "0x181621860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A50F90", Offset = "0x8A4F990", VA = "0x188A50F90")]
		internal void SXYTOUDPSTY(EEIAXPLQIVG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A50F60", Offset = "0x8A4F960", VA = "0x188A50F60")]
		private bool RJMSHEJSAVS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A50FF0", Offset = "0x8A4F9F0", VA = "0x188A50FF0")]
		internal FULTMNFEJJL(IPEndPoint a, EEIAXPLQIVG b, GOANXSKKOIS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A50F00", Offset = "0x8A4F900", VA = "0x188A50F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4E8A0", Offset = "0x8A4D2A0", VA = "0x188A4E8A0")]
		private EEIAXPLQIVG(long a, byte b, int c, byte[] d, VSOHZOVUZLK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E690", Offset = "0x8A4D090", VA = "0x188A4E690")]
		public static int QNUBXTLZXGF(CYUJJFYJAMH a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E4A0", Offset = "0x8A4CEA0", VA = "0x188A4E4A0")]
		public static EEIAXPLQIVG CGLMLKKSOFO(CYUJJFYJAMH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E6C0", Offset = "0x8A4D0C0", VA = "0x188A4E6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A59160", Offset = "0x8A57B60", VA = "0x188A59160")]
		private LHLSOUSYCDZ(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A58E70", Offset = "0x8A57870", VA = "0x188A58E70")]
		public static LHLSOUSYCDZ CGLMLKKSOFO(CYUJJFYJAMH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A59070", Offset = "0x8A57A70", VA = "0x188A59070")]
		public static CYUJJFYJAMH UWQIXUHMKTE(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A58F70", Offset = "0x8A57970", VA = "0x188A58F70")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool ZRASMFHJEIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2830", VA = "0x180EA3E30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFBE70", VA = "0x180CFD470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4EF00", Offset = "0x8A4D900", VA = "0x188A4EF00")]
		internal EEXLWYVHYOF(GOANXSKKOIS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E910", Offset = "0x8A4D310", VA = "0x188A4E910")]
		internal void BJPPHEBTOUU(IPEndPoint a, CYUJJFYJAMH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x392D6F0", Offset = "0x392C0F0", VA = "0x18392D6F0")]
		private void UBSUEOKZGUG<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EC20", Offset = "0x8A4D620", VA = "0x188A4EC20")]
		private void SNVVUWGPTLL(PYTAQRNLWLD a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EDA0", Offset = "0x8A4D7A0", VA = "0x188A4EDA0")]
		private void SSKYYSBTWWX(NALHHLHTHZZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EA90", Offset = "0x8A4D490", VA = "0x188A4EA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A58E60", Offset = "0x8A57860", VA = "0x188A58E60")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A58E60", Offset = "0x8A57860", VA = "0x188A58E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4D7F0", Offset = "0x8A4C1F0", VA = "0x188A4D7F0")]
		private static void NJGPZYTRUUD(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D730", Offset = "0x8A4C130", VA = "0x188A4D730")]
		internal static void IZOOQSZXUAH(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DA20", Offset = "0x8A4C420", VA = "0x188A4DA20")]
		internal static void RRFVMZDVWAZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D790", Offset = "0x8A4C190", VA = "0x188A4D790")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A5FDD0", Offset = "0x8A5E7D0", VA = "0x188A5FDD0")]
		internal OQXRLZMXBEE(GOANXSKKOIS a, WJQSCCGWVLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FD60", Offset = "0x8A5E760", VA = "0x188A5FD60")]
		internal void PQIIPNZHDCN(CYUJJFYJAMH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FCB0", Offset = "0x8A5E6B0", VA = "0x188A5FCB0")]
		internal void BGOSPSYHFWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FD30", Offset = "0x8A5E730", VA = "0x188A5FD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A635B0", Offset = "0x8A61FB0", VA = "0x188A635B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A63650", Offset = "0x8A62050", VA = "0x188A63650", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A636C0", Offset = "0x8A620C0", VA = "0x188A636C0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25AD0", VA = "0x180F270D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25AD0", VA = "0x180F270D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D782B0", Offset = "0x1D76CB0", VA = "0x181D782B0")]
			public NetPeerEnumerator(OCQTFLRKKPN p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A5B9F0", Offset = "0x8A5A3F0", VA = "0x188A5B9F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8A5BA40", Offset = "0x8A5A440", VA = "0x188A5BA40", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xE63420", Offset = "0xE61E20", VA = "0x180E63420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE62010", Offset = "0xE60A10", VA = "0x180E62010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int UVQUBDZJAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x222CBD0", Offset = "0x222B5D0", VA = "0x18222CBD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x233C190", Offset = "0x233AB90", VA = "0x18233C190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte GPZIAPKYVTF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDEBD20", Offset = "0xDEA720", VA = "0x180DEBD20")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int QVHRJCTSBOH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8A547A0", Offset = "0x8A531A0", VA = "0x188A547A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short MBUDKUCDGHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A51060", Offset = "0x8A4FA60", VA = "0x188A51060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OCQTFLRKKPN.OnUpdatedMtuDelegate QHPAZVRQBWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8A514F0", Offset = "0x8A4FEF0", VA = "0x188A514F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A55980", Offset = "0x8A54380", VA = "0x188A55980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A55D50", Offset = "0x8A54750", VA = "0x188A55D50")]
		public void SSGUIUUMOFY(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A54150", Offset = "0x8A52B50", VA = "0x188A54150")]
		public void KTEMDKPMFNJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A55120", Offset = "0x8A53B20", VA = "0x188A55120")]
		private bool PTBBCJTQCHN(IPEndPoint a, [Out] OCQTFLRKKPN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A547C0", Offset = "0x8A531C0", VA = "0x188A547C0")]
		private void OONQCQVWKPF(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A586F0", Offset = "0x8A570F0", VA = "0x188A586F0")]
		private void ZWTXJPCYBBO(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A55A30", Offset = "0x8A54430", VA = "0x188A55A30")]
		private void RNPVRDDBVVH(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A58810", Offset = "0x8A57210", VA = "0x188A58810")]
		public GOANXSKKOIS(FEVINBEOZCO a, [Optional] KPIREJNTFAE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A56B00", Offset = "0x8A55500", VA = "0x188A56B00")]
		internal void TKDPVTPQHKF(OCQTFLRKKPN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A513F0", Offset = "0x8A4FDF0", VA = "0x188A513F0")]
		internal void ARZJRDGRVJP(OCQTFLRKKPN a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A54420", Offset = "0x8A52E20", VA = "0x188A54420")]
		internal void MQFMOXRPJDH(OCQTFLRKKPN a, DisconnectReason b, SocketError c, CYUJJFYJAMH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A57AF0", Offset = "0x8A564F0", VA = "0x188A57AF0")]
		private void WPJIYGSUTVM(OCQTFLRKKPN a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, CYUJJFYJAMH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8A56FF0", Offset = "0x8A559F0", VA = "0x188A56FF0")]
		private void UORGUOEZNYQ(WJQSCCGWVLX.EType a, [Optional] OCQTFLRKKPN b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] FULTMNFEJJL g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] CYUJJFYJAMH j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A551C0", Offset = "0x8A53BC0", VA = "0x188A551C0")]
		private void QJJMLZSISLR(WJQSCCGWVLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A53000", Offset = "0x8A51A00", VA = "0x188A53000")]
		internal void DTTNPBNELZB(WJQSCCGWVLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A58390", Offset = "0x8A56D90", VA = "0x188A58390")]
		private void YECIANEKJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A53340", Offset = "0x8A51D40", VA = "0x188A53340")]
		private void INTRBRWFSDF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A54AE0", Offset = "0x8A534E0", VA = "0x188A54AE0")]
		internal OCQTFLRKKPN PACNMMCQKJK(FULTMNFEJJL a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A54720", Offset = "0x8A53120", VA = "0x188A54720")]
		private int NHNHBTKJHVW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8A56B50", Offset = "0x8A55550", VA = "0x188A56B50")]
		private void ULYSYQEWQEO(IPEndPoint a, OCQTFLRKKPN b, EEIAXPLQIVG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8A51CE0", Offset = "0x8A506E0", VA = "0x188A51CE0")]
		private void DRYAHFQOHPJ(CYUJJFYJAMH a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8A51120", Offset = "0x8A4FB20", VA = "0x188A51120")]
		internal void AISQPDKAXLZ(CYUJJFYJAMH a, DeliveryMethod b, byte c, int d, OCQTFLRKKPN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8A56760", Offset = "0x8A55160", VA = "0x188A56760")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A56770", Offset = "0x8A55170", VA = "0x188A56770")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A566E0", Offset = "0x8A550E0", VA = "0x188A566E0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A51B30", Offset = "0x8A50530", VA = "0x188A51B30")]
		public void DFNWFVVOIEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A515A0", Offset = "0x8A4FFA0", VA = "0x188A515A0")]
		public OCQTFLRKKPN Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A51680", Offset = "0x8A50080", VA = "0x188A51680")]
		public OCQTFLRKKPN Connect(string address, int port, YMUYYZRTLWM connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A51760", Offset = "0x8A50160", VA = "0x188A51760")]
		public OCQTFLRKKPN Connect(IPEndPoint target, YMUYYZRTLWM connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A56790", Offset = "0x8A55190", VA = "0x188A56790")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A567A0", Offset = "0x8A551A0", VA = "0x188A567A0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A54370", Offset = "0x8A52D70", VA = "0x188A54370")]
		public void KUAENCXCTFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A542A0", Offset = "0x8A52CA0", VA = "0x188A542A0")]
		public void KUAENCXCTFT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A57A70", Offset = "0x8A56470", VA = "0x188A57A70")]
		public void WPJIYGSUTVM(OCQTFLRKKPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A57AB0", Offset = "0x8A564B0", VA = "0x188A57AB0")]
		public void WPJIYGSUTVM(OCQTFLRKKPN a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A51440", Offset = "0x8A4FE40", VA = "0x188A51440", Slot = "4")]
		private IEnumerator<OCQTFLRKKPN> AVEGICOYTWF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A532B0", Offset = "0x8A51CB0", VA = "0x188A532B0", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A57520", Offset = "0x8A55F20", VA = "0x188A57520")]
		private CYUJJFYJAMH WESZGSNGUGX(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A57610", Offset = "0x8A56010", VA = "0x188A57610")]
		private CYUJJFYJAMH WESZGSNGUGX(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A58150", Offset = "0x8A56B50", VA = "0x188A58150")]
		internal CYUJJFYJAMH XWGUBPRMQVA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A57EE0", Offset = "0x8A568E0", VA = "0x188A57EE0")]
		internal void XKGTVUAQUVJ(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A58750", Offset = "0x8A57150", VA = "0x188A58750")]
		static GOANXSKKOIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE63420", Offset = "0xE61E20", VA = "0x180E63420")]
		private bool CZNZYGZCSPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A573C0", Offset = "0x8A55DC0", VA = "0x188A573C0")]
		private void VVRDJMWMWWM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A537F0", Offset = "0x8A521F0", VA = "0x188A537F0")]
		private void JHLLBKYTTWL(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A53110", Offset = "0x8A51B10", VA = "0x188A53110")]
		private bool GEYQRICKIUR(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A514D0", Offset = "0x8A4FED0", VA = "0x188A514D0")]
		private void BLGTBTEQEPU(XYZFMNSORLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A54460", Offset = "0x8A52E60", VA = "0x188A54460")]
		private void MXHIJGTRYPN(VUAUYYXFOFY a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A576F0", Offset = "0x8A560F0", VA = "0x188A576F0")]
		private void WLSKFIOGGAB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A55F70", Offset = "0x8A54970", VA = "0x188A55F70")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A55CF0", Offset = "0x8A546F0", VA = "0x188A55CF0")]
		internal int ROIKABCFZPI(CYUJJFYJAMH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A53940", Offset = "0x8A52340", VA = "0x188A53940")]
		internal int JUJEVSALHPO(CYUJJFYJAMH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A53980", Offset = "0x8A52380", VA = "0x188A53980")]
		internal int JUJEVSALHPO(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A53670", Offset = "0x8A52070", VA = "0x188A53670")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A4E020", Offset = "0x8A4CA20", VA = "0x188A4E020")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DB80", Offset = "0x8A4C580", VA = "0x188A4DB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte FDGKRNYVTFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DE40", Offset = "0x8A4C840", VA = "0x188A4DE40")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DDE0", Offset = "0x8A4C7E0", VA = "0x188A4DDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort GOKTHNKTCUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DEA0", Offset = "0x8A4C8A0", VA = "0x188A4DEA0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DFE0", Offset = "0x8A4C9E0", VA = "0x188A4DFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KOQLWLSRTCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DC00", Offset = "0x8A4C600", VA = "0x188A4DC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte WYEXHECRDZI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DB30", Offset = "0x8A4C530", VA = "0x188A4DB30")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DE70", Offset = "0x8A4C870", VA = "0x188A4DE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort UKGEKTZAIJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DE20", Offset = "0x8A4C820", VA = "0x188A4DE20")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DC30", Offset = "0x8A4C630", VA = "0x188A4DC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort YQYKFSMHSPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DB60", Offset = "0x8A4C560", VA = "0x188A4DB60")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DDA0", Offset = "0x8A4C7A0", VA = "0x188A4DDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort EJMTTFVWBWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DFC0", Offset = "0x8A4C9C0", VA = "0x188A4DFC0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DBC0", Offset = "0x8A4C5C0", VA = "0x188A4DBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E050", Offset = "0x8A4CA50", VA = "0x188A4E050")]
		static CYUJJFYJAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DD70", Offset = "0x8A4C770", VA = "0x188A4DD70")]
		public void MPNPMSRWUYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E320", Offset = "0x8A4CD20", VA = "0x188A4E320")]
		public CYUJJFYJAMH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E390", Offset = "0x8A4CD90", VA = "0x188A4E390")]
		public CYUJJFYJAMH(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DEC0", Offset = "0x8A4C8C0", VA = "0x188A4DEC0")]
		public static int RXVTEMZPECM(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DF30", Offset = "0x8A4C930", VA = "0x188A4DF30")]
		public int RXVTEMZPECM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DC70", Offset = "0x8A4C670", VA = "0x188A4DC70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1C430", Offset = "0xD1AE30", VA = "0x180D1C430")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A5C390", Offset = "0x8A5AD90", VA = "0x188A5C390")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint YIHNLWXFZYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE5B330", Offset = "0xE59D30", VA = "0x180E5B330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState WPXQOVCXGZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1495EA0", Offset = "0x14948A0", VA = "0x181495EA0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long CIIATORKXPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCF2B20", Offset = "0xCF1520", VA = "0x180CF2B20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int CMWYGMPHNGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x222CBD0", Offset = "0x222B5D0", VA = "0x18222CBD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x233C190", Offset = "0x233AB90", VA = "0x18233C190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int AEPNNXYTLUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A5E540", Offset = "0x8A5CF40", VA = "0x188A5E540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int PVONBMMDATT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B760", VA = "0x180D0CD60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double YUTRINPMXGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC79B0", Offset = "0x2AC63B0", VA = "0x182AC79B0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate QHPAZVRQBWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A5C290", Offset = "0x8A5AC90", VA = "0x188A5C290")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A5E550", Offset = "0x8A5CF50", VA = "0x188A5E550")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F440", Offset = "0x8A5DE40", VA = "0x188A5F440")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E710", Offset = "0x8A5D110", VA = "0x188A5E710")]
		internal void RPEVXJECHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F410", Offset = "0x8A5DE10", VA = "0x188A5F410")]
		internal void WNEBNTZMCMW(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D610", Offset = "0x8A5C010", VA = "0x188A5D610")]
		internal void GMYDFJAZERX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E600", Offset = "0x8A5D000", VA = "0x188A5E600")]
		private void RKREQNMKRQA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E6D0", Offset = "0x8A5D0D0", VA = "0x188A5E6D0")]
		private void RKRKYLFLMSI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BCB0", Offset = "0x8A5A6B0", VA = "0x188A5BCB0")]
		public int CPAHDYGIBBY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BDC0", Offset = "0x8A5A7C0", VA = "0x188A5BDC0")]
		public int CPAHDYGIBBY(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BA80", Offset = "0x8A5A480", VA = "0x188A5BA80")]
		private MZKDLBKFQPW ALHJSUTODAL(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FA20", Offset = "0x8A5E420", VA = "0x188A5FA20")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, IPEndPoint b, int c, byte d, YMUYYZRTLWM e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F840", Offset = "0x8A5E240", VA = "0x188A5F840")]
		internal OCQTFLRKKPN(GOANXSKKOIS a, FULTMNFEJJL b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E730", Offset = "0x8A5D130", VA = "0x188A5E730")]
		internal void Reject(EEIAXPLQIVG requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E780", Offset = "0x8A5D180", VA = "0x188A5E780")]
		internal bool SCEQTRNWUXP(LHLSOUSYCDZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EB50", Offset = "0x8A5D550", VA = "0x188A5EB50")]
		public void UBSUEOKZGUG(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A5CAE0", Offset = "0x8A5B4E0", VA = "0x188A5CAE0")]
		private void FFHEPJOZIKX(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C340", Offset = "0x8A5AD40", VA = "0x188A5C340")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BC10", Offset = "0x8A5A610", VA = "0x188A5BC10")]
		internal DisconnectResult CHWVAVKYABJ(CYUJJFYJAMH a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D6A0", Offset = "0x8A5C0A0", VA = "0x188A5D6A0")]
		internal void HVPULIRNCZC(MZKDLBKFQPW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E800", Offset = "0x8A5D200", VA = "0x188A5E800")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EB10", Offset = "0x8A5D510", VA = "0x188A5EB10")]
		private void TQYAZDOELDP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D700", Offset = "0x8A5C100", VA = "0x188A5D700")]
		internal void LBDELCVZUWB(DeliveryMethod a, CYUJJFYJAMH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D0D0", Offset = "0x8A5BAD0", VA = "0x188A5D0D0")]
		private void FQPPIRXRTNB(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A5DFA0", Offset = "0x8A5C9A0", VA = "0x188A5DFA0")]
		private void NLRIEEJPOIT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EB80", Offset = "0x8A5D580", VA = "0x188A5EB80")]
		internal ConnectRequestResult ULYSYQEWQEO(EEIAXPLQIVG a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C440", Offset = "0x8A5AE40", VA = "0x188A5C440")]
		internal void ENPPMPFUXFL(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C140", Offset = "0x8A5AB40", VA = "0x188A5C140")]
		private void CWJATSQXGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E330", Offset = "0x8A5CD30", VA = "0x188A5E330")]
		internal void OCTLINGEQTD(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A5ED40", Offset = "0x8A5D740", VA = "0x188A5ED40")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BEE0", Offset = "0x8A5A8E0", VA = "0x188A5BEE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A61270", Offset = "0x8A5FC70", VA = "0x188A61270")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long FKKJLNQQCFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A61260", Offset = "0x8A5FC60", VA = "0x188A61260")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long SQIEECQQMVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A61390", Offset = "0x8A5FD90", VA = "0x188A61390")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long KNGHKAYILGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A61740", Offset = "0x8A60140", VA = "0x188A61740")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long UDTISHDKIQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A61130", Offset = "0x8A5FB30", VA = "0x188A61130")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long DJPLLIPFGIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8A61280", Offset = "0x8A5FC80", VA = "0x188A61280")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long POSMUPVXQEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A617B0", Offset = "0x8A601B0", VA = "0x188A617B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long VHQFQIKEBTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8A617F0", Offset = "0x8A601F0", VA = "0x188A617F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality GWWUJKNKCMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x13FE0C0", Offset = "0x13FCAC0", VA = "0x1813FE0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double CMJSHUKWSHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A610D0", Offset = "0x8A5FAD0", VA = "0x188A610D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A61350", Offset = "0x8A5FD50", VA = "0x188A61350")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A616E0", Offset = "0x8A600E0", VA = "0x188A616E0")]
		public void UHVFBCGTZDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A61290", Offset = "0x8A5FC90", VA = "0x188A61290")]
		public void OHTUPUBNMLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A61060", Offset = "0x8A5FA60", VA = "0x188A61060")]
		public void AAZJYVQYCWY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A612E0", Offset = "0x8A5FCE0", VA = "0x188A612E0")]
		public void QWVFJZRCYQF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A61750", Offset = "0x8A60150", VA = "0x188A61750")]
		public void XHQQPSKTYOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8A61140", Offset = "0x8A5FB40", VA = "0x188A61140")]
		public void FZRQVMVLUJO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8A613A0", Offset = "0x8A5FDA0", VA = "0x188A613A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8A611C0", Offset = "0x8A5FBC0", VA = "0x188A611C0")]
		public void GNPRLKREERE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A63720", Offset = "0x8A62120", VA = "0x188A63720")]
		public static IPEndPoint RVNHWWUSBDN(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A63960", Offset = "0x8A62360", VA = "0x188A63960")]
		public static IPAddress YJCSEMUJHHC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8A63B30", Offset = "0x8A62530", VA = "0x188A63B30")]
		public static IPAddress YJCSEMUJHHC(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A636F0", Offset = "0x8A620F0", VA = "0x188A636F0")]
		internal static int FCNLREWYGZO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4126F50", Offset = "0x4125950", VA = "0x184126F50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A60760", Offset = "0x8A5F160", VA = "0x188A60760", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A607D0", Offset = "0x8A5F1D0", VA = "0x188A607D0")]
			public void WNCQWZWPKZY(CYUJJFYJAMH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8A606F0", Offset = "0x8A5F0F0", VA = "0x188A606F0")]
			public bool THQXHICLCVJ(long a, OCQTFLRKKPN b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8A606A0", Offset = "0x8A5F0A0", VA = "0x188A606A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A62590", Offset = "0x8A60F90", VA = "0x188A62590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8A633F0", Offset = "0x8A61DF0", VA = "0x188A633F0")]
		public WFKFWLWBQYZ(OCQTFLRKKPN a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8A625A0", Offset = "0x8A60FA0", VA = "0x188A625A0")]
		private void AZSJCPXNYQC(CYUJJFYJAMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8A62F20", Offset = "0x8A61920", VA = "0x188A62F20", Slot = "4")]
		protected override bool ETQCRWXQJRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8A62920", Offset = "0x8A61320", VA = "0x188A62920", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4FA30", Offset = "0x8A4E430", VA = "0x188A4FA30")]
		public FHBYOFDWPLY(OCQTFLRKKPN a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F570", Offset = "0x8A4DF70", VA = "0x188A4F570", Slot = "4")]
		protected override bool ETQCRWXQJRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F2F0", Offset = "0x8A4DCF0", VA = "0x188A4F2F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A4D5A0", Offset = "0x8A4BFA0", VA = "0x188A4D5A0")]
		private static void WPWXNOFAEYI(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8A60F00", Offset = "0x8A5F900", VA = "0x188A60F00")]
		private static void WPWXNOFAEYI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8A61020", Offset = "0x8A5FA20", VA = "0x188A61020")]
		public static void WPWXNOFAEYI(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8A60F80", Offset = "0x8A5F980", VA = "0x188A60F80")]
		public static void SHZWPQEXDJR(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8A60FA0", Offset = "0x8A5F9A0", VA = "0x188A60FA0")]
		public static void SHZWPQEXDJR(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8A61020", Offset = "0x8A5FA20", VA = "0x188A61020")]
		public static void SHZWPQEXDJR(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8A61020", Offset = "0x8A5FA20", VA = "0x188A61020")]
		public static void SHZWPQEXDJR(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8A60F00", Offset = "0x8A5F900", VA = "0x188A60F00")]
		public static void SHZWPQEXDJR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8A60F00", Offset = "0x8A5F900", VA = "0x188A60F00")]
		public static void SHZWPQEXDJR(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8A60F70", Offset = "0x8A5F970", VA = "0x188A60F70")]
		public static void SHZWPQEXDJR(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8A60F70", Offset = "0x8A5F970", VA = "0x188A60F70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DKVZRBHFTOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int ZTVLDQSLGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A61DE0", Offset = "0x8A607E0", VA = "0x188A61DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GYQALBISFUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A233B0", Offset = "0x2A21DB0", VA = "0x182A233B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int OAPUUWRXKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8A61DA0", Offset = "0x8A607A0", VA = "0x188A61DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8A61FB0", Offset = "0x8A609B0", VA = "0x188A61FB0")]
		public void PQIIPNZHDCN(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public VSOHZOVUZLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8A62530", Offset = "0x8A60F30", VA = "0x188A62530")]
		public VSOHZOVUZLK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8A62460", Offset = "0x8A60E60", VA = "0x188A62460")]
		public IPEndPoint YNNGYCFOEES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8A62280", Offset = "0x8A60C80", VA = "0x188A62280")]
		public byte UQIAHDOMCWS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A62280", Offset = "0x8A60C80", VA = "0x188A62280")]
		public sbyte THBZLGHERYD()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x40C0570", Offset = "0x40BEF70", VA = "0x1840C0570")]
		public a[] HBZHQVGUJBT<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A61DF0", Offset = "0x8A607F0", VA = "0x188A61DF0")]
		public bool[] JWXQXHOYBGZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8A61E30", Offset = "0x8A60830", VA = "0x188A61E30")]
		public ushort[] KDWGWPYMEYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A62240", Offset = "0x8A60C40", VA = "0x188A62240")]
		public short[] QLTQWOJBBID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8A624F0", Offset = "0x8A60EF0", VA = "0x188A624F0")]
		public int[] ZWGMCNDDGPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8A62420", Offset = "0x8A60E20", VA = "0x188A62420")]
		public uint[] YEBGEDVUPQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A62300", Offset = "0x8A60D00", VA = "0x188A62300")]
		public float[] UNWJZUPLWVF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8A61FF0", Offset = "0x8A609F0", VA = "0x188A61FF0")]
		public double[] PTDTJDXINYG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A61D20", Offset = "0x8A60720", VA = "0x188A61D20")]
		public long[] EOBPLXYEZNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A61D60", Offset = "0x8A60760", VA = "0x188A61D60")]
		public ulong[] GHIJOTALFZA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8A61EA0", Offset = "0x8A608A0", VA = "0x188A61EA0")]
		public string[] LFXLWXHZAIW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A61F70", Offset = "0x8A60970", VA = "0x188A61F70")]
		public bool LMYOCXVGACQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CD0", Offset = "0x8A606D0", VA = "0x188A61CD0")]
		public char BJAUHHNKYPS()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CD0", Offset = "0x8A606D0", VA = "0x188A61CD0")]
		public ushort IROSXOZYRTJ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CD0", Offset = "0x8A606D0", VA = "0x188A61CD0")]
		public short QYXXDIYAIGK()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A62340", Offset = "0x8A60D40", VA = "0x188A62340")]
		public long VACXPISJHOK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8A62340", Offset = "0x8A60D40", VA = "0x188A62340")]
		public ulong XYIFTFCYFHL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8A61DB0", Offset = "0x8A607B0", VA = "0x188A61DB0")]
		public int XFGLJJICOSJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8A61DB0", Offset = "0x8A607B0", VA = "0x188A61DB0")]
		public uint IALCTCPREME()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CA0", Offset = "0x8A606A0", VA = "0x188A61CA0")]
		public float BICZAKOTTES()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8A61E70", Offset = "0x8A60870", VA = "0x188A61E70")]
		public double KLYPMKLFQSF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8A62030", Offset = "0x8A60A30", VA = "0x188A62030")]
		public string QGOSMAICKCR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8A623B0", Offset = "0x8A60DB0", VA = "0x188A623B0")]
		public ArraySegment<byte> WFELUJTQFYM(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A62370", Offset = "0x8A60D70", VA = "0x188A62370")]
		public sbyte[] VDFRNFBMHGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8A622C0", Offset = "0x8A60CC0", VA = "0x188A622C0")]
		public byte[] UFZGNDFQTPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A61D00", Offset = "0x8A60700", VA = "0x188A61D00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8A64A10", Offset = "0x8A63410", VA = "0x188A64A10")]
		public YMUYYZRTLWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8A64970", Offset = "0x8A63370", VA = "0x188A64970")]
		public YMUYYZRTLWM(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8A642B0", Offset = "0x8A62CB0", VA = "0x188A642B0")]
		public static YMUYYZRTLWM HQKDKSPPNUV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8A64400", Offset = "0x8A62E00", VA = "0x188A64400")]
		public void QEONIRHQLDZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BB70", Offset = "0x2A9A570", VA = "0x182A9BB70")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8A63EE0", Offset = "0x8A628E0", VA = "0x188A63EE0")]
		public void FFTUNRFWXCB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8A64130", Offset = "0x8A62B30", VA = "0x188A64130")]
		public void FFTUNRFWXCB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8A63F80", Offset = "0x8A62980", VA = "0x188A63F80")]
		public void FFTUNRFWXCB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8A63F80", Offset = "0x8A62980", VA = "0x188A63F80")]
		public void FFTUNRFWXCB(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8A64040", Offset = "0x8A62A40", VA = "0x188A64040")]
		public void FFTUNRFWXCB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8A64040", Offset = "0x8A62A40", VA = "0x188A64040")]
		public void FFTUNRFWXCB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8A63E70", Offset = "0x8A62870", VA = "0x188A63E70")]
		public void FFTUNRFWXCB(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A63E70", Offset = "0x8A62870", VA = "0x188A63E70")]
		public void FFTUNRFWXCB(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8A63E70", Offset = "0x8A62870", VA = "0x188A63E70")]
		public void FFTUNRFWXCB(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8A640D0", Offset = "0x8A62AD0", VA = "0x188A640D0")]
		public void FFTUNRFWXCB(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8A640D0", Offset = "0x8A62AD0", VA = "0x188A640D0")]
		public void FFTUNRFWXCB(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8A63FD0", Offset = "0x8A629D0", VA = "0x188A63FD0")]
		public void FFTUNRFWXCB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8A64320", Offset = "0x8A62D20", VA = "0x188A64320")]
		public void MRLSCCDQWIR(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8A64320", Offset = "0x8A62D20", VA = "0x188A64320")]
		public void VFREJXATEJK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8A64250", Offset = "0x8A62C50", VA = "0x188A64250")]
		public void FFTUNRFWXCB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8A64810", Offset = "0x8A63210", VA = "0x188A64810")]
		public void RJIYCXXWJNE(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8A64660", Offset = "0x8A63060", VA = "0x188A64660")]
		public void RJIYCXXWJNE(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8A644A0", Offset = "0x8A62EA0", VA = "0x188A644A0")]
		public void RJIYCXXWJNE(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8A644A0", Offset = "0x8A62EA0", VA = "0x188A644A0")]
		public void RJIYCXXWJNE(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8A644A0", Offset = "0x8A62EA0", VA = "0x188A644A0")]
		public void RJIYCXXWJNE(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8A64660", Offset = "0x8A63060", VA = "0x188A64660")]
		public void RJIYCXXWJNE(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8A64660", Offset = "0x8A63060", VA = "0x188A64660")]
		public void RJIYCXXWJNE(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8A64580", Offset = "0x8A62F80", VA = "0x188A64580")]
		public void RJIYCXXWJNE(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8A64580", Offset = "0x8A62F80", VA = "0x188A64580")]
		public void RJIYCXXWJNE(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8A64320", Offset = "0x8A62D20", VA = "0x188A64320")]
		public void RJIYCXXWJNE(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8A64740", Offset = "0x8A63140", VA = "0x188A64740")]
		public void RJIYCXXWJNE(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8A64180", Offset = "0x8A62B80", VA = "0x188A64180")]
		public void FFTUNRFWXCB(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A63E60", Offset = "0x8A62860", VA = "0x188A63E60")]
		public void FFTUNRFWXCB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8A63C50", Offset = "0x8A62650", VA = "0x188A63C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x729B4B0", Offset = "0x7299EB0", VA = "0x18729B4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public INBVDQUOBSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x65ADA30", Offset = "0x65AC430", VA = "0x1865ADA30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public BQFULXHEJJU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4F7C840", Offset = "0x4F7B240", VA = "0x184F7C840")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A61B50", Offset = "0x8A60550", VA = "0x188A61B50")]
		public UJRNQXRYGIR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4087D40", Offset = "0x4086740", VA = "0x184087D40", Slot = "4")]
		protected virtual ulong ADRSLHKBOPW<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A61A80", Offset = "0x8A60480", VA = "0x188A61A80", Slot = "5")]
		protected virtual SubscribeDelegate WJIWHOATRNF(VSOHZOVUZLK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4087DC0", Offset = "0x40867C0", VA = "0x184087DC0", Slot = "6")]
		protected virtual void BXJSBLSQHOX<b>(YMUYYZRTLWM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8A61A00", Offset = "0x8A60400", VA = "0x188A61A00")]
		public void RDUXMLZQZAU(VSOHZOVUZLK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4088140", Offset = "0x4086B40", VA = "0x184088140")]
		public void SQIRBZBNMTZ<j>(YMUYYZRTLWM a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8A619B0", Offset = "0x8A603B0", VA = "0x188A619B0")]
		public void AMLNAAAGJTK(VSOHZOVUZLK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4087FC0", Offset = "0x40869C0", VA = "0x184087FC0")]
		public void DXPECKOEYCZ<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4087FC0", Offset = "0x40869C0", VA = "0x184087FC0")]
		public void DXPECKOEYCZ<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8A58E60", Offset = "0x8A57860", VA = "0x188A58E60")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8A60640", Offset = "0x8A5F040", VA = "0x188A60640")]
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
			[Cpp2IlInjected.Address(RVA = "0x53EC9F0", Offset = "0x53EB3F0", VA = "0x1853EC9F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0x72CACD0", Offset = "0x72C96D0", VA = "0x1872CACD0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x72CACD0", Offset = "0x72C96D0", VA = "0x1872CACD0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x72CAC00", Offset = "0x72C9600", VA = "0x1872CAC00", Slot = "9")]
			public override void FLOXBPKQHYQ(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x72CAC00", Offset = "0x72C9600", VA = "0x1872CAC00", Slot = "10")]
			public override void BKACKDXHLRJ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x72CAF10", Offset = "0x72C9910", VA = "0x1872CAF10")]
			protected b[] SSFRGOFLYDD(a a, VSOHZOVUZLK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x72CADA0", Offset = "0x72C97A0", VA = "0x1872CADA0")]
			protected b[] NUENPNNMTUA(a a, YMUYYZRTLWM b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x72CB1B0", Offset = "0x72C9BB0", VA = "0x1872CB1B0", Slot = "4")]
			public override void WNCQWZWPKZY(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x72CBC90", Offset = "0x72CA690", VA = "0x1872CBC90")]
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
			[Cpp2IlInjected.Address(RVA = "0x647DBC0", Offset = "0x647C5C0", VA = "0x18647DBC0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x647E050", Offset = "0x647CA50", VA = "0x18647E050", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x647DA10", Offset = "0x647C410", VA = "0x18647DA10", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x647DDC0", Offset = "0x647C7C0", VA = "0x18647DDC0", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x647E290", Offset = "0x647CC90", VA = "0x18647E290")]
			protected HTDKUIFRPZZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class TZVQQZPPRKC<a> : OZHLFTJLQJS<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x53E8520", Offset = "0x53E6F20", VA = "0x1853E8520", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x53E87B0", Offset = "0x53E71B0", VA = "0x1853E87B0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7A97210", Offset = "0x7A95C10", VA = "0x187A97210", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x53E8570", Offset = "0x53E6F70", VA = "0x1853E8570", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public TZVQQZPPRKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class DSJNUBORLRR<a> : OZHLFTJLQJS<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x53E8520", Offset = "0x53E6F20", VA = "0x1853E8520", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x53E87B0", Offset = "0x53E71B0", VA = "0x1853E87B0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x53E82C0", Offset = "0x53E6CC0", VA = "0x1853E82C0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x53E8570", Offset = "0x53E6F70", VA = "0x1853E8570", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public DSJNUBORLRR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class SRTNHKMNLQV<a> : OZHLFTJLQJS<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x71BEDB0", Offset = "0x71BD7B0", VA = "0x1871BEDB0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x71BF160", Offset = "0x71BDB60", VA = "0x1871BF160", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x792D070", Offset = "0x792BA70", VA = "0x18792D070", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x71BF020", Offset = "0x71BDA20", VA = "0x1871BF020", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public SRTNHKMNLQV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class AAHMBTJRIRG<a> : OZHLFTJLQJS<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x71BEDB0", Offset = "0x71BD7B0", VA = "0x1871BEDB0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x71BF160", Offset = "0x71BDB60", VA = "0x1871BF160", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x71BED60", Offset = "0x71BD760", VA = "0x1871BED60", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x71BF020", Offset = "0x71BDA20", VA = "0x1871BF020", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public AAHMBTJRIRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class DSHGHMTMMJT<a> : OZHLFTJLQJS<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x53E7EA0", Offset = "0x53E68A0", VA = "0x1853E7EA0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x53E8140", Offset = "0x53E6B40", VA = "0x1853E8140", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x53E7D50", Offset = "0x53E6750", VA = "0x1853E7D50", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x53E8100", Offset = "0x53E6B00", VA = "0x1853E8100", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public DSHGHMTMMJT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class DTXWZSRVTAW<a> : OZHLFTJLQJS<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x53E7EA0", Offset = "0x53E68A0", VA = "0x1853E7EA0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x53E8140", Offset = "0x53E6B40", VA = "0x1853E8140", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x53EC7D0", Offset = "0x53EB1D0", VA = "0x1853EC7D0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x53E8100", Offset = "0x53E6B00", VA = "0x1853E8100", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public DTXWZSRVTAW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class MTROMMVRZKR<a> : OZHLFTJLQJS<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x647AA00", Offset = "0x6479400", VA = "0x18647AA00", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x647AB90", Offset = "0x6479590", VA = "0x18647AB90", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x6F26760", Offset = "0x6F25160", VA = "0x186F26760", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x647AA50", Offset = "0x6479450", VA = "0x18647AA50", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public MTROMMVRZKR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class HIBGCMANYWI<a> : OZHLFTJLQJS<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x647AA00", Offset = "0x6479400", VA = "0x18647AA00", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x647AB90", Offset = "0x6479590", VA = "0x18647AB90", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x647A790", Offset = "0x6479190", VA = "0x18647A790", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x647AA50", Offset = "0x6479450", VA = "0x18647AA50", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public HIBGCMANYWI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class TKHGXGYKFVL<a> : OZHLFTJLQJS<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x7A87F40", Offset = "0x7A86940", VA = "0x187A87F40", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x7A87F90", Offset = "0x7A86990", VA = "0x187A87F90", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x7A87CE0", Offset = "0x7A866E0", VA = "0x187A87CE0", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x53E8570", Offset = "0x53E6F70", VA = "0x1853E8570", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public TKHGXGYKFVL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class NOWVTPOJXTE<a> : OZHLFTJLQJS<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x71575B0", Offset = "0x7155FB0", VA = "0x1871575B0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7157600", Offset = "0x7156000", VA = "0x187157600", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7157450", Offset = "0x7155E50", VA = "0x187157450", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x53E8100", Offset = "0x53E6B00", VA = "0x1853E8100", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public NOWVTPOJXTE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class QMEIHHVTEAH<a> : OZHLFTJLQJS<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x7638150", Offset = "0x7636B50", VA = "0x187638150", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x76383C0", Offset = "0x7636DC0", VA = "0x1876383C0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7638000", Offset = "0x7636A00", VA = "0x187638000", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x647AA50", Offset = "0x6479450", VA = "0x18647AA50", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x53E8280", Offset = "0x53E6C80", VA = "0x1853E8280")]
			public QMEIHHVTEAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class ECJUJADZAED<a> : HTDKUIFRPZZ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A4E0", Offset = "0x5B38EE0", VA = "0x185B3A4E0", Slot = "12")]
			protected override void LKTAQKPMJSP(YMUYYZRTLWM a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A510", Offset = "0x5B38F10", VA = "0x185B3A510", Slot = "11")]
			protected override void LXDSYVBGNGM(VSOHZOVUZLK a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A540", Offset = "0x5B38F40", VA = "0x185B3A540")]
			public ECJUJADZAED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class FOSXNUHLVJR<a> : HTDKUIFRPZZ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6289990", Offset = "0x6288390", VA = "0x186289990", Slot = "12")]
			protected override void LKTAQKPMJSP(YMUYYZRTLWM a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x62899C0", Offset = "0x62883C0", VA = "0x1862899C0", Slot = "11")]
			protected override void LXDSYVBGNGM(VSOHZOVUZLK a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A540", Offset = "0x5B38F40", VA = "0x185B3A540")]
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
			[Cpp2IlInjected.Address(RVA = "0x5147C40", Offset = "0x5146640", VA = "0x185147C40")]
			public ZTDXMOMZFLQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x51477E0", Offset = "0x51461E0", VA = "0x1851477E0", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5147BA0", Offset = "0x51465A0", VA = "0x185147BA0", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5147670", Offset = "0x5146070", VA = "0x185147670", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5147A50", Offset = "0x5146450", VA = "0x185147A50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x85DF410", Offset = "0x85DDE10", VA = "0x1885DF410")]
			public WZPRMGXPCNW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x85DF050", Offset = "0x85DDA50", VA = "0x1885DF050", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x85DF330", Offset = "0x85DDD30", VA = "0x1885DF330", Slot = "6")]
			public override void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x85DF000", Offset = "0x85DDA00", VA = "0x1885DF000", Slot = "7")]
			public override void BLYRCTESPYN(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x85DF000", Offset = "0x85DDA00", VA = "0x1885DF000", Slot = "8")]
			public override void MNPXBCKTGYM(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x85DEFB0", Offset = "0x85DD9B0", VA = "0x1885DEFB0", Slot = "9")]
			public override void FLOXBPKQHYQ(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x85DEFB0", Offset = "0x85DD9B0", VA = "0x1885DEFB0", Slot = "10")]
			public override void BKACKDXHLRJ(a a, YMUYYZRTLWM b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class OFKBMBINTMZ<a> : WZPRMGXPCNW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x72A4350", Offset = "0x72A2D50", VA = "0x1872A4350")]
			public OFKBMBINTMZ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x72A4120", Offset = "0x72A2B20", VA = "0x1872A4120", Slot = "5")]
			public override void LYKZYHORDOU(a a, VSOHZOVUZLK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x72A41C0", Offset = "0x72A2BC0", VA = "0x1872A41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F098F0", Offset = "0x4F082F0", VA = "0x184F098F0")]
			public BCWIUDDHMPJ(List<DUMYYWEGFOV<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4F09610", Offset = "0x4F08010", VA = "0x184F09610")]
			public void SQIRBZBNMTZ(a a, YMUYYZRTLWM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4F09560", Offset = "0x4F07F60", VA = "0x184F09560")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A58DD0", Offset = "0x8A577D0", VA = "0x188A58DD0")]
		public GOTNJHNBWPZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8190", Offset = "0x3AD6B90", VA = "0x183AD8190")]
		private BCWIUDDHMPJ<d> ZEGWPMQXANC<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7320", Offset = "0x3AD5D20", VA = "0x183AD7320")]
		public void SIFQFAPRLAF<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3AD71E0", Offset = "0x3AD5BE0", VA = "0x183AD71E0")]
		public bool Deserialize<T>(VSOHZOVUZLK reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7260", Offset = "0x3AD5C60", VA = "0x183AD7260")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A50A00", Offset = "0x8A4F400", VA = "0x188A50A00")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int ZLNBWHWGZYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8A50A30", Offset = "0x8A4F430", VA = "0x188A50A30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8A4FAF0", Offset = "0x8A4E4F0", VA = "0x188A4FAF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode VCPJRYGHJXB
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A50480", Offset = "0x8A4EE80", VA = "0x188A50480")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A4FFD0", Offset = "0x8A4E9D0", VA = "0x188A4FFD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int YKSHZYUQXJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A50A60", Offset = "0x8A4F460", VA = "0x188A50A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint BNKOVPJRQEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A507B0", Offset = "0x8A4F1B0", VA = "0x188A507B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? FOEVBPSURLY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A50780", Offset = "0x8A4F180", VA = "0x188A50780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? MNCHTIJXFTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A509D0", Offset = "0x8A4F3D0", VA = "0x188A509D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? HFAKIKNJXCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A501D0", Offset = "0x8A4EBD0", VA = "0x188A501D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A505C0", Offset = "0x8A4EFC0", VA = "0x188A505C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ZHPPITTELOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87230", VA = "0x180D88830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF6C4A0", Offset = "0xF6AEA0", VA = "0x180F6C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A50BF0", Offset = "0x8A4F5F0", VA = "0x188A50BF0")]
		public FRXFAFKMYKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A50B50", Offset = "0x8A4F550", VA = "0x188A50B50")]
		internal FRXFAFKMYKS(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A504B0", Offset = "0x8A4EEB0", VA = "0x188A504B0")]
		public static FRXFAFKMYKS RCSFIPQMQMQ(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FC50", Offset = "0x8A4E650", VA = "0x188A4FC50")]
		internal void DRLSFSGCJYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A50010", Offset = "0x8A4EA10", VA = "0x188A50010")]
		private void GXABVMOEHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A502B0", Offset = "0x8A4ECB0", VA = "0x188A502B0")]
		private DateTime? NQQHBMTFXQP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A50810", Offset = "0x8A4F210", VA = "0x188A50810")]
		private void VKYDOYCWEMP(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A50200", Offset = "0x8A4EC00", VA = "0x188A50200")]
		private ulong KEHHSVZUUJB(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FB30", Offset = "0x8A4E530", VA = "0x188A4FB30")]
		private void DIIOJYRWUDR(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8A50A90", Offset = "0x8A4F490", VA = "0x188A50A90")]
		private uint ZBPANHDGEMY(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8918950", Offset = "0x8917350", VA = "0x188918950")]
		private static uint DLJLCNNSMLN(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FBF0", Offset = "0x8A4E5F0", VA = "0x188A4FBF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A5FBB0", Offset = "0x8A5E5B0", VA = "0x188A5FBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FBC0", Offset = "0x8A5E5C0", VA = "0x188A5FBC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A5FE20", Offset = "0x8A5E820", VA = "0x188A5FE20", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int KKIPXQEPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8A60570", Offset = "0x8A5EF70", VA = "0x188A60570", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint OSRBBYBPLSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8A60510", Offset = "0x8A5EF10", VA = "0x188A60510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily NHIOGIELQKU
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32B3190", Offset = "0x32B1B90", VA = "0x1832B3190", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8A60590", Offset = "0x8A5EF90", VA = "0x188A60590")]
		public PHJRDRCBAPJ(AddressFamily a, GOANXSKKOIS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FE40", Offset = "0x8A5E840", VA = "0x188A5FE40", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8A60530", Offset = "0x8A5EF30", VA = "0x188A60530", Slot = "9")]
		public int QXEJMNZAIML(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8A60420", Offset = "0x8A5EE20", VA = "0x188A60420", Slot = "10")]
		public int JNDRQJDDSMV(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8A60400", Offset = "0x8A5EE00", VA = "0x188A60400", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A5B710", Offset = "0x8A5A110", VA = "0x188A5B710")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B7B0", Offset = "0x8A5A1B0", VA = "0x188A5B7B0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1621850", Offset = "0x1620250", VA = "0x181621850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B620", Offset = "0x8A5A020", VA = "0x188A5B620", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B660", Offset = "0x8A5A060", VA = "0x188A5B660", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		internal void CMVXBYHCAXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		internal void HQHVHDPLAYR(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9C400", Offset = "0x2B9AE00", VA = "0x182B9C400")]
		public NEVABRDQBVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B410", Offset = "0x8A59E10", VA = "0x188A5B410")]
		public void TVHLCXEIYGW(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B030", Offset = "0x8A59A30", VA = "0x188A5B030")]
		public void PRWYBJNXAZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8A5ABE0", Offset = "0x8A595E0", VA = "0x188A5ABE0", Slot = "4")]
		public override void FYMCQBNTUIO(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B110", Offset = "0x8A59B10", VA = "0x188A5B110", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A64EC0", Offset = "0x8A638C0", VA = "0x188A64EC0")]
			[BurstDiscard]
			private static void QGYXNOMWBVT(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8A65050", Offset = "0x8A63A50", VA = "0x188A65050")]
			private static IntPtr RVXPUZINCSJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8A64C70", Offset = "0x8A63670", VA = "0x188A64C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A60DB0", Offset = "0x8A5F7B0", VA = "0x188A60DB0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8A60C10", Offset = "0x8A5F610", VA = "0x188A60C10")]
		private uint HKRQCHBIJXM(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D4F0", Offset = "0x8A4BEF0", VA = "0x188A4D4F0")]
		private void UIFPEAZUUHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D150", Offset = "0x8A4BB50", VA = "0x188A4D150")]
		private void LULCZTTYNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D460", Offset = "0x8A4BE60", VA = "0x188A4D460")]
		private void RRWVWPLRHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D360", Offset = "0x8A4BD60", VA = "0x188A4D360")]
		private void OIIWUHDEKSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8A60E30", Offset = "0x8A5F830", VA = "0x188A60E30")]
		private void SHXSGEOQYYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8A607F0", Offset = "0x8A5F1F0", VA = "0x188A607F0")]
		private unsafe void DMWXXUPTLLK(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8A60CF0", Offset = "0x8A5F6F0", VA = "0x188A60CF0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void JHREKJDNKSF([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8A60C40", Offset = "0x8A5F640", VA = "0x188A60C40")]
		public static void JHREKJDNKSF(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8A60D00", Offset = "0x8A5F700", VA = "0x188A60D00")]
		public static void RQBALYEEJHH(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8A60E90", Offset = "0x8A5F890", VA = "0x188A60E90")]
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
	[Cpp2IlInjected.Address(RVA = "0x8A64C30", Offset = "0x8A63630", VA = "0x188A64C30")]
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
