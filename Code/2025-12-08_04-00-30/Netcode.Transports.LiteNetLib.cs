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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, YBRAVNOKEID
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
		private NetworkManager EOHIZCPSENY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool VHUZZDOISOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, MGYHLJMUOOC> RVGGXJUBOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IKISLUNONDT CACYAVDZLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch QRVRNKXFJQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] PQXOVWJHJSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType GEHOUGVFBIV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int IYLOPQSIMLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x74BFF90", Offset = "0x74BE790", VA = "0x1874BFF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x74BFF40", Offset = "0x74BE740", VA = "0x1874BFF40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74BF3B0", Offset = "0x74BDBB0", VA = "0x1874BF3B0")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74BF390", Offset = "0x74BDB90", VA = "0x1874BF390")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74BF240", Offset = "0x74BDA40", VA = "0x1874BF240")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74BFE00", Offset = "0x74BE600", VA = "0x1874BFE00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74BF4C0", Offset = "0x74BDCC0", VA = "0x1874BF4C0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74BF350", Offset = "0x74BDB50", VA = "0x1874BF350", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74BF790", Offset = "0x74BDF90", VA = "0x1874BF790", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74BFB20", Offset = "0x74BE320", VA = "0x1874BFB20", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74BE980", Offset = "0x74BD180", VA = "0x1874BE980", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74BE890", Offset = "0x74BD090", VA = "0x1874BE890", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74BEAC0", Offset = "0x74BD2C0", VA = "0x1874BEAC0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74BF720", Offset = "0x74BDF20", VA = "0x1874BF720", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74BEC90", Offset = "0x74BD490", VA = "0x1874BEC90", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74BEEA0", Offset = "0x74BD6A0", VA = "0x1874BEEA0")]
		private DeliveryMethod MSIEJJOBRYA(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74BFD40", Offset = "0x74BE540", VA = "0x1874BFD40", Slot = "16")]
		private void UJGWVVYXOJR(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74BF170", Offset = "0x74BD970", VA = "0x1874BF170", Slot = "17")]
		private void ODBCGCJNHRR(MGYHLJMUOOC a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "18")]
		private void ARSMNDLXOAQ(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74BEF70", Offset = "0x74BD770", VA = "0x1874BEF70", Slot = "19")]
		private void NUPAGRECQYT(MGYHLJMUOOC a, BPPHYDMZXSJ b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74BEB60", Offset = "0x74BD360", VA = "0x1874BEB60")]
		private void IEDTJSLIEZS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "20")]
		private void XFGFAUXZYHN(IPEndPoint a, BPPHYDMZXSJ b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "21")]
		private void MWLYDHJKPEZ(MGYHLJMUOOC a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74BEC30", Offset = "0x74BD430", VA = "0x1874BEC30", Slot = "22")]
		private void IXQQJGQQEON(HNNARTJWOGI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74BFE40", Offset = "0x74BE640", VA = "0x1874BFE40")]
		private ulong WXIDYCSVUOC(MGYHLJMUOOC a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74BFE20", Offset = "0x74BE620", VA = "0x1874BFE20")]
		private ulong WXIDYCSVUOC(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74BF330", Offset = "0x74BDB30", VA = "0x1874BF330")]
		private static int PPUYDQVXGUX(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74BFE70", Offset = "0x74BE670", VA = "0x1874BFE70")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74BEA90", Offset = "0x74BD290", VA = "0x1874BEA90")]
		[CompilerGenerated]
		private void EZZTVSEQVJP(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74BEA90", Offset = "0x74BD290", VA = "0x1874BEA90")]
		[CompilerGenerated]
		private void VQFPQQVEGKA(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class KMQIKSOFVGR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly MGYHLJMUOOC JBCUUHOEEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<AYUMDUPRRMK> BAFJISIPOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int WXDPRYSETFB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int YFCVCRAIRFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x74BD570", Offset = "0x74BBD70", VA = "0x1874BD570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74BD680", Offset = "0x74BBE80", VA = "0x1874BD680")]
		protected KMQIKSOFVGR(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74BD510", Offset = "0x74BBD10", VA = "0x1874BD510")]
		public void EKRBMLINKZA(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74BD600", Offset = "0x74BBE00", VA = "0x1874BD600")]
		protected void WUPUERTVULJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74BD5C0", Offset = "0x74BBDC0", VA = "0x1874BD5C0")]
		public bool VGPMDJQVEPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool GBMXGKGPATT();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool AGQYOAVXJCQ(AYUMDUPRRMK a);
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
	public class HNNARTJWOGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly IKISLUNONDT VNXHQRZVPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int PYNILXBVYZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal PPZUIBJCTRT WMQSQGKTZOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint PCPEEPGOTWY;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult UFLLPZXZAGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x13373D0", Offset = "0x1335BD0", VA = "0x1813373D0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x13373C0", Offset = "0x1335BC0", VA = "0x1813373C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74B52A0", Offset = "0x74B3AA0", VA = "0x1874B52A0")]
		internal void SIPMEKLAYXZ(PPZUIBJCTRT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74B5270", Offset = "0x74B3A70", VA = "0x1874B5270")]
		private bool IMPENFRPMPX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x74B5300", Offset = "0x74B3B00", VA = "0x1874B5300")]
		internal HNNARTJWOGI(IPEndPoint a, PPZUIBJCTRT b, IKISLUNONDT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74B5210", Offset = "0x74B3A10", VA = "0x1874B5210")]
		public MGYHLJMUOOC Accept()
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
		public BPPHYDMZXSJ AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface YBRAVNOKEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void STOYWFBFYQF(MGYHLJMUOOC a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UMXZLPGQEMZ(MGYHLJMUOOC a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PTJBPWEXXKC(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IAXXXAQZHNL(MGYHLJMUOOC a, BPPHYDMZXSJ b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JVTPBSKGPQJ(IPEndPoint a, BPPHYDMZXSJ b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FKFSRNLSMLR(MGYHLJMUOOC a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UBTYQIUFDTF(HNNARTJWOGI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface LYBKPFLGXMS
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SABXHXGAVRZ(MGYHLJMUOOC a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HXIYMLIANGM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZUKARGMTBAH(XURPEPDNBMD a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface TDFVPJWPTDM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BZXKGSNHAEC(MGYHLJMUOOC a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class PPZUIBJCTRT
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int MZQMEWXEFIX = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long XAIMRHAERFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte PEYBASLMECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] KULYHEQOQLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly TADVJBOQRIF DQYIQAERBXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int FCOEHCRDDPU;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74C4FB0", Offset = "0x74C37B0", VA = "0x1874C4FB0")]
		private PPZUIBJCTRT(long a, byte b, int c, byte[] d, TADVJBOQRIF e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74C4BB0", Offset = "0x74C33B0", VA = "0x1874C4BB0")]
		public static int EDFKTGRZEPK(AYUMDUPRRMK a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74C4DC0", Offset = "0x74C35C0", VA = "0x1874C4DC0")]
		public static PPZUIBJCTRT QDJQYLVSUHR(AYUMDUPRRMK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74C4BE0", Offset = "0x74C33E0", VA = "0x1874C4BE0")]
		public static AYUMDUPRRMK IDYAUSSHBYV(DAKXRRCCFEN a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class DBWSXKNBUWA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long XAIMRHAERFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte PEYBASLMECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int FCOEHCRDDPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool OLIVGPJODYV;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x74B46F0", Offset = "0x74B2EF0", VA = "0x1874B46F0")]
		private DBWSXKNBUWA(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74B44F0", Offset = "0x74B2CF0", VA = "0x1874B44F0")]
		public static DBWSXKNBUWA QDJQYLVSUHR(AYUMDUPRRMK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74B4400", Offset = "0x74B2C00", VA = "0x1874B4400")]
		public static AYUMDUPRRMK IDYAUSSHBYV(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74B45F0", Offset = "0x74B2DF0", VA = "0x1874B45F0")]
		public static AYUMDUPRRMK RLZBRFDAKMP(MGYHLJMUOOC a)
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
	public interface MLQKFXLJXPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NKFDLAYGQKK(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void REMVDINWFNG(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class LASTCCWVYOW
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
		private class KVNQJKFYKDG
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint OITCHLCSHSC
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string WYHCRWXGQAQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KVNQJKFYKDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class EVZCYRRXCDC
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint OITCHLCSHSC
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint CMOVOGVUSCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string WYHCRWXGQAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public EVZCYRRXCDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class ZHFYMSVRKWK
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string WYHCRWXGQAQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool XXZDDEHRPXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xBE0F00", Offset = "0xBDF700", VA = "0x180BE0F00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAA2A00", Offset = "0xAA1200", VA = "0x180AA2A00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZHFYMSVRKWK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly IKISLUNONDT HSCQQJZJHIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> IZYLHXDVUBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> ZNRQFXXGDQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly TADVJBOQRIF ZDPZHSRPHXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly DAKXRRCCFEN WOHCEMKAIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly BBNXVCUZKCO WASUMCAYRDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MLQKFXLJXPB MYNALXWSQOF;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int BBTZYWMMSEU = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool GXPYNKFRPUH;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74BDD00", Offset = "0x74BC500", VA = "0x1874BDD00")]
		internal LASTCCWVYOW(IKISLUNONDT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74BD890", Offset = "0x74BC090", VA = "0x1874BD890")]
		internal void XIQYQPXMGPR(IPEndPoint a, AYUMDUPRRMK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3744A20", Offset = "0x3743220", VA = "0x183744A20")]
		private void TOAWYNQYTMB<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74BD710", Offset = "0x74BBF10", VA = "0x1874BD710")]
		private void NKFDLAYGQKK(KVNQJKFYKDG a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74BDA10", Offset = "0x74BC210", VA = "0x1874BDA10")]
		private void YRSUNWVMDTY(EVZCYRRXCDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74BDB70", Offset = "0x74BC370", VA = "0x1874BDB70")]
		private void ZPACRPVQGBB(ZHFYMSVRKWK a, IPEndPoint b)
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
	public static class PSLYOPVCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] BTNSBAAXEWQ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int RQUMZJSECRM;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int YQEGYIKWKNR;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x74BD500", Offset = "0x74BBD00", VA = "0x1874BD500")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x74BD500", Offset = "0x74BBD00", VA = "0x1874BD500")]
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
	public interface UUETJVKIBWJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KZRJXCHROQZ(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class HXLVUHXUHYV
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static UUETJVKIBWJ LZJDFIZHUDF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object KBEPSCXOLMT;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74B5490", Offset = "0x74B3C90", VA = "0x1874B5490")]
		private static void YKXSVLLISXG(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x74B5430", Offset = "0x74B3C30", VA = "0x1874B5430")]
		internal static void YFYWHBILTEE(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x74B5370", Offset = "0x74B3B70", VA = "0x1874B5370")]
		internal static void DYITUXCZCWO(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x74B53D0", Offset = "0x74B3BD0", VA = "0x1874B53D0")]
		internal static void MPXVAQUFKNK(string a, params object[] args)
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
	public sealed class BPPHYDMZXSJ : TADVJBOQRIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private AYUMDUPRRMK IJFKOAUHLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly IKISLUNONDT OSHBDINBSXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly FICHDWIRUCW OXOCGVRUNFL;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x74B2550", Offset = "0x74B0D50", VA = "0x1874B2550")]
		internal BPPHYDMZXSJ(IKISLUNONDT a, FICHDWIRUCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74B24B0", Offset = "0x74B0CB0", VA = "0x1874B24B0")]
		internal void XEGXWUYSEBS(AYUMDUPRRMK a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x74B2430", Offset = "0x74B0C30", VA = "0x1874B2430")]
		internal void NSCVVRIYSCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74B2520", Offset = "0x74B0D20", VA = "0x1874B2520")]
		public void XTCCFNTHVMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class FICHDWIRUCW
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
		public FICHDWIRUCW NQNUEHVSNFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType BFJYMHQJKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public MGYHLJMUOOC JBCUUHOEEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint PCPEEPGOTWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object YSYFRIXKVFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int KZKGWRQIFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError TNEVJZNSBXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason TQKTQFNIGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HNNARTJWOGI HNNARTJWOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod GDRKJHKAGTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte VGNRZLTUBQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly BPPHYDMZXSJ PTIOOXXTAWA;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74B5170", Offset = "0x74B3970", VA = "0x1874B5170")]
		public FICHDWIRUCW(IKISLUNONDT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class IKISLUNONDT : IEnumerable<MGYHLJMUOOC>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class XIDWFWVLLGU : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x74C6EA0", Offset = "0x74C56A0", VA = "0x1874C6EA0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x74C6F10", Offset = "0x74C5710", VA = "0x1874C6F10", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public XIDWFWVLLGU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<MGYHLJMUOOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly MGYHLJMUOOC _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private MGYHLJMUOOC _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public MGYHLJMUOOC Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xC71A80", Offset = "0xC70280", VA = "0x180C71A80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xC71A80", Offset = "0xC70280", VA = "0x180C71A80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1A96DE0", Offset = "0x1A955E0", VA = "0x181A96DE0")]
			public NetPeerEnumerator(MGYHLJMUOOC p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x74C4B20", Offset = "0x74C3320", VA = "0x1874C4B20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x74C4B70", Offset = "0x74C3370", VA = "0x1874C4B70", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread KCBNNZDCJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool DQTCAJRDMQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool ZJRMZRJWHQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private KLWGIWTQIRU GNHKUHCWYEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent QHXNQQCAWFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<FICHDWIRUCW> LXIXHFETWRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<FICHDWIRUCW> VLYBTVEZTQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private FICHDWIRUCW FHQMJHVALQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly YBRAVNOKEID VAZMDNZPJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly LYBKPFLGXMS RPVJEJZRLTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly HXIYMLIANGM VKFSBEATEAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly TDFVPJWPTDM SNBUUSSDDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, MGYHLJMUOOC> AGDOITWRXBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, HNNARTJWOGI> VVWGNBBKVOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, VTIISBSCVLC> DJOQWWMKHWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim VJEHBVFWBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private MGYHLJMUOOC BWMXUEJQSZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int XTIFXYZATRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<MGYHLJMUOOC> IBUDJUYQMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private MGYHLJMUOOC[] RHSDCQOITAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly DVPCEZLVHTT BRQFUJNCSXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int WAIZCNVLCWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> JVDYOJMZHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte AJYQITOYBXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object DTWACIZAGBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool CIMMOUFXFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool UWHHHEVXVEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int PJZMXWTQUUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int WWHQMLPYJWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int QHQGLOMSXMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int VSTVEBJDPWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool PUUOPHWTQOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool ZOMVHZRIRXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int JNRUTGKPSFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int BNVESEBMIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int FRGBXLTSLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool GXPYNKFRPUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool YKDIRHXUOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool MQLUEFPJVPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool MDMJPDHWNUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int VDIQFFQMDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int SQRPZSMAJZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool DERVDUQRBPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly LVBJUIWURGB DYHAIDDIPPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool OWCGOSXPZBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly LASTCCWVYOW LASTCCWVYOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool PNDZWCRBTWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode DMDJYYOPYRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int GHOOMTDJHRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool BLGNIFDEYVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool ZDVTWQYZYHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool AUXCOCCKSRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool CUQEHXHARTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private AYUMDUPRRMK KEHWROCINOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int WMIKAVFIPCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object QOZBGRCFEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private AYUMDUPRRMK RFECXEITFYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int JOOEXAKIOEE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int SXXRLGGBUJK = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int PPJWJKSSVQB = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IOBNEDXIGVF XRVOCGMKXWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private IOBNEDXIGVF XSGBWUAFQSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread REJHOJIIBSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread RDYTTVUNIVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint JARAHGHDXDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint JAGMMSTJEGX;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] XQSMUMBKGPX;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] HOZOPJBFRRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> GQFTAKUXKOC;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress AWNNMRZULYV;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool SSJIIEVCGQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int LMKGUEJBFIF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ROZSFYGNPZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBA32C0", Offset = "0xBA1AC0", VA = "0x180BA32C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBA2FF0", Offset = "0xBA17F0", VA = "0x180BA2FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int PHQGNZZKRVH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB430", Offset = "0x1EF9C30", VA = "0x181EFB430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2057B60", Offset = "0x2056360", VA = "0x182057B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte UVGOLUMRXSC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB385E0", Offset = "0xB36DE0", VA = "0x180B385E0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int SSOLTKFTZHA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x74B90C0", Offset = "0x74B78C0", VA = "0x1874B90C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short ZUNVCEAMMVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x74B9620", Offset = "0x74B7E20", VA = "0x1874B9620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MGYHLJMUOOC.OnUpdatedMtuDelegate BUHCMLNYTWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x74BC0C0", Offset = "0x74BA8C0", VA = "0x1874BC0C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x74BCDD0", Offset = "0x74BB5D0", VA = "0x1874BCDD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x74B9FB0", Offset = "0x74B87B0", VA = "0x1874B9FB0")]
		public void MYOJYLLVYOP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74B9DE0", Offset = "0x74B85E0", VA = "0x1874B9DE0")]
		public void MCXCETPHXCS(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x74BAFA0", Offset = "0x74B97A0", VA = "0x1874BAFA0")]
		private bool RUTJJLKMYSQ(IPEndPoint a, [Out] MGYHLJMUOOC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x74B5760", Offset = "0x74B3F60", VA = "0x1874B5760")]
		private void AFUTXWRGVRY(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x74B9CF0", Offset = "0x74B84F0", VA = "0x1874B9CF0")]
		private void LECXRDCAWMP(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x74BA1D0", Offset = "0x74B89D0", VA = "0x1874BA1D0")]
		private void OGAXRHPIAHQ(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x74BCF40", Offset = "0x74BB740", VA = "0x1874BCF40")]
		public IKISLUNONDT(YBRAVNOKEID a, [Optional] DVPCEZLVHTT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x74B6890", Offset = "0x74B5090", VA = "0x1874B6890")]
		internal void CGUBBNZQCGG(MGYHLJMUOOC a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x74B9070", Offset = "0x74B7870", VA = "0x1874B9070")]
		internal void HMSFVOMEIEW(MGYHLJMUOOC a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x74BAF60", Offset = "0x74B9760", VA = "0x1874BAF60")]
		internal void RUMSBWTRTVW(MGYHLJMUOOC a, DisconnectReason b, SocketError c, AYUMDUPRRMK d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x74BC860", Offset = "0x74BB060", VA = "0x1874BC860")]
		private void YKIWOHUNLEB(MGYHLJMUOOC a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, AYUMDUPRRMK h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x74BC1D0", Offset = "0x74BA9D0", VA = "0x1874BC1D0")]
		private void XTGDILJDEJP(FICHDWIRUCW.EType a, [Optional] MGYHLJMUOOC b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] HNNARTJWOGI g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] AYUMDUPRRMK j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x74B6FD0", Offset = "0x74B57D0", VA = "0x1874B6FD0")]
		private void EUZMRBYZQYY(FICHDWIRUCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x74B9880", Offset = "0x74B8080", VA = "0x1874B9880")]
		internal void JOWGYAWDSWY(FICHDWIRUCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x74B9990", Offset = "0x74B8190", VA = "0x1874B9990")]
		private void KASXBOTTVDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x74B5A80", Offset = "0x74B4280", VA = "0x1874B5A80")]
		private void APPJYOVFZJC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x74BA930", Offset = "0x74B9130", VA = "0x1874BA930")]
		internal MGYHLJMUOOC PSZACHAZMSX(HNNARTJWOGI a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x74B9F30", Offset = "0x74B8730", VA = "0x1874B9F30")]
		private int MGLEDVINTPP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x74BA490", Offset = "0x74B8C90", VA = "0x1874BA490")]
		private void PLVKBSPZCTF(IPEndPoint a, MGYHLJMUOOC b, PPZUIBJCTRT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74B78E0", Offset = "0x74B60E0", VA = "0x1874B78E0")]
		private void GYTOKMAAYJA(AYUMDUPRRMK a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74B65C0", Offset = "0x74B4DC0", VA = "0x1874B65C0")]
		internal void BTEFQMYXAOU(AYUMDUPRRMK a, DeliveryMethod b, byte c, int d, MGYHLJMUOOC e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x74BBC30", Offset = "0x74BA430", VA = "0x1874BBC30")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x74BB4A0", Offset = "0x74B9CA0", VA = "0x1874BB4A0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74BB420", Offset = "0x74B9C20", VA = "0x1874BB420")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74B8EC0", Offset = "0x74B76C0", VA = "0x1874B8EC0")]
		public void HDIZRRXCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x74B68E0", Offset = "0x74B50E0", VA = "0x1874B68E0")]
		public MGYHLJMUOOC Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x74B6D90", Offset = "0x74B5590", VA = "0x1874B6D90")]
		public MGYHLJMUOOC Connect(string address, int port, DAKXRRCCFEN connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74B69C0", Offset = "0x74B51C0", VA = "0x1874B69C0")]
		public MGYHLJMUOOC Connect(IPEndPoint target, DAKXRRCCFEN connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74BC000", Offset = "0x74BA800", VA = "0x1874BC000")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74BBCA0", Offset = "0x74BA4A0", VA = "0x1874BBCA0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74BCD20", Offset = "0x74BB520", VA = "0x1874BCD20")]
		public void YWODELFMPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74BCC50", Offset = "0x74BB450", VA = "0x1874BCC50")]
		public void YWODELFMPOI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74BC7E0", Offset = "0x74BAFE0", VA = "0x1874BC7E0")]
		public void YKIWOHUNLEB(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x74BC820", Offset = "0x74BB020", VA = "0x1874BC820")]
		public void YKIWOHUNLEB(MGYHLJMUOOC a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74B9D50", Offset = "0x74B8550", VA = "0x1874B9D50", Slot = "4")]
		private IEnumerator<MGYHLJMUOOC> LNTAABKJYQS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74BC030", Offset = "0x74BA830", VA = "0x1874BC030", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x74B9540", Offset = "0x74B7D40", VA = "0x1874B9540")]
		private AYUMDUPRRMK IGYUVIPDZCC(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x74B9460", Offset = "0x74B7C60", VA = "0x1874B9460")]
		private AYUMDUPRRMK IGYUVIPDZCC(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74BC5A0", Offset = "0x74BADA0", VA = "0x1874BC5A0")]
		internal AYUMDUPRRMK YJXARFNHZDF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74BB1C0", Offset = "0x74B99C0", VA = "0x1874BB1C0")]
		internal void SYUCMHLKQPU(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x74BCE80", Offset = "0x74BB680", VA = "0x1874BCE80")]
		static IKISLUNONDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBA32C0", Offset = "0xBA1AC0", VA = "0x180BA32C0")]
		private bool BNNDFGNXEUZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x74B6E70", Offset = "0x74B5670", VA = "0x1874B6E70")]
		private void DIKFFLIHJPJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x74B7790", Offset = "0x74B5F90", VA = "0x1874B7790")]
		private void GQWINNJIEPO(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x74B96E0", Offset = "0x74B7EE0", VA = "0x1874B96E0")]
		private bool IVGVXOVRJFQ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x74BC010", Offset = "0x74BA810", VA = "0x1874BC010")]
		private void UZHUPCRDFEB(KLWGIWTQIRU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x74B8C00", Offset = "0x74B7400", VA = "0x1874B8C00")]
		private void HDFMPGKGQAC(IOBNEDXIGVF a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x74B90E0", Offset = "0x74B78E0", VA = "0x1874B90E0")]
		private void IFEPOLVSWRE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74BB4C0", Offset = "0x74B9CC0", VA = "0x1874BB4C0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74BC170", Offset = "0x74BA970", VA = "0x1874BC170")]
		internal int XJNMNPGYDJR(AYUMDUPRRMK a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x74B5DB0", Offset = "0x74B45B0", VA = "0x1874B5DB0")]
		internal int BOXKOSMEWPT(AYUMDUPRRMK a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74B5DF0", Offset = "0x74B45F0", VA = "0x1874B5DF0")]
		internal int BOXKOSMEWPT(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74BB040", Offset = "0x74B9840", VA = "0x1874BB040")]
		internal void SLACZMYCCWU(bool a)
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
	internal sealed class AYUMDUPRRMK
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int GMDVWUOWECN;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] QMEPZEQKPSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] UDKINGTVBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int XCHBIZTVHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object YSYFRIXKVFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AYUMDUPRRMK NQNUEHVSNFU;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty PPRLZTXFBIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x74B1350", Offset = "0x74AFB50", VA = "0x1874B1350")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x74B14D0", Offset = "0x74AFCD0", VA = "0x1874B14D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte PEYBASLMECO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x74B1150", Offset = "0x74AF950", VA = "0x1874B1150")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x74B11C0", Offset = "0x74AF9C0", VA = "0x1874B11C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort WJMFBTLNTWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x74B1380", Offset = "0x74AFB80", VA = "0x1874B1380")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x74B1180", Offset = "0x74AF980", VA = "0x1874B1180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CZATPMCQUOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x74B14A0", Offset = "0x74AFCA0", VA = "0x1874B14A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte DOMIGNPEITZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x74B1200", Offset = "0x74AFA00", VA = "0x1874B1200")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x74B12C0", Offset = "0x74AFAC0", VA = "0x1874B12C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort GHXCLSIKGSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x74B12F0", Offset = "0x74AFAF0", VA = "0x1874B12F0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x74B1260", Offset = "0x74AFA60", VA = "0x1874B1260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort ISHHQWUZGGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x74B0FF0", Offset = "0x74AF7F0", VA = "0x1874B0FF0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x74B1310", Offset = "0x74AFB10", VA = "0x1874B1310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort PZMWMPVOHYO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x74B12A0", Offset = "0x74AFAA0", VA = "0x1874B12A0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x74B1010", Offset = "0x74AF810", VA = "0x1874B1010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x74B1510", Offset = "0x74AFD10", VA = "0x1874B1510")]
		static AYUMDUPRRMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74B1230", Offset = "0x74AFA30", VA = "0x1874B1230")]
		public void MKMSXNNAUQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74B18D0", Offset = "0x74B00D0", VA = "0x1874B18D0")]
		public AYUMDUPRRMK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74B17C0", Offset = "0x74AFFC0", VA = "0x1874B17C0")]
		public AYUMDUPRRMK(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74B1050", Offset = "0x74AF850", VA = "0x1874B1050")]
		public static int DSMGOFQWNYF(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x74B10C0", Offset = "0x74AF8C0", VA = "0x1874B10C0")]
		public int DSMGOFQWNYF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x74B13A0", Offset = "0x74AFBA0", VA = "0x1874B13A0")]
		public bool YAIAMGOHGLQ()
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
	public class MGYHLJMUOOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class WVTGXLJURZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public AYUMDUPRRMK[] MOPEBVLBHLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int VVVZPOPBGOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int UMOZEBEFEKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte DOMIGNPEITZ;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public WVTGXLJURZS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int ASIYWUQWTYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int BDIQCJZYMYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int DRTUHHVHUUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double VRQNLZSHYSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int DDGAJBZVCSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int XTNGGXFTEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int WECDQAAJTRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch JDJSOIUGDOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int BATCHXXIAQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long QPJUGGGHMQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object LIMZYBAEAHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal MGYHLJMUOOC NFSHMIOWFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal MGYHLJMUOOC YVOEMRXDXEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<AYUMDUPRRMK> VZCROQCXPXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<KMQIKSOFVGR> MWVEVXKWSSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly KMQIKSOFVGR[] OZXVMPQFGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int YUGCAPUSTKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int CRKOQFKSCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool QJEDPEJLEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int BVPHWAJQMWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int OWAXHGNGIEW;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int ABOYIIKOQHY = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int PYWKSASTFQJ = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object ALGEBULTELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int LEKXCPAQRKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, WVTGXLJURZS> AKBZVTQTVLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> RMJEJIUPAAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly AYUMDUPRRMK XIXORCUMRAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int EVCPOPTCFRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int RWQTBAFRBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint AYHUKJXWBOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int MWLGZEDUXNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int VSIEDXNQYCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long FQOGBTDWUQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte GXJGZOGLXEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState XZHOVWATGZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private AYUMDUPRRMK SXEUIFUPLLE;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int DXZXPRKENZO = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int USGQNCKQQMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly AYUMDUPRRMK IJRQLJQNBEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly AYUMDUPRRMK OBBDYXLBVXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly AYUMDUPRRMK GQUKUWJCGHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly AYUMDUPRRMK XPRYIHVZQXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality DXNKTEGNWND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly IKISLUNONDT IKISLUNONDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int CXQIBDZHUDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object QCNENNJVDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly LVBJUIWURGB DYHAIDDIPPW;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte JGHBYKTBLVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xACC640", Offset = "0xACAE40", VA = "0x180ACC640")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x74C1A40", Offset = "0x74C0240", VA = "0x1874C1A40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint DDHJPTNDYVM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB9D440", Offset = "0xB9BC40", VA = "0x180B9D440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState WJYMXKQITKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1232410", Offset = "0x1230C10", VA = "0x181232410")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long QGVJWWOPSAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA8830", VA = "0x180AAA030")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int SILDFLTGJSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB430", Offset = "0x1EF9C30", VA = "0x181EFB430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2057B60", Offset = "0x2056360", VA = "0x182057B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FCTHDHWLGXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x74C0E50", Offset = "0x74BF650", VA = "0x1874C0E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int JHQZAHSLHDS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xABD670", Offset = "0xABBE70", VA = "0x180ABD670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double ATQQSWEJGGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2803E50", Offset = "0x2802650", VA = "0x182803E50")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate BUHCMLNYTWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x74C38C0", Offset = "0x74C20C0", VA = "0x1874C38C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x74C39F0", Offset = "0x74C21F0", VA = "0x1874C39F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x74C3C80", Offset = "0x74C2480", VA = "0x1874C3C80")]
		internal MGYHLJMUOOC(IKISLUNONDT a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x74C0EF0", Offset = "0x74BF6F0", VA = "0x1874C0EF0")]
		internal void LKGNYLVCTEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x74C0F10", Offset = "0x74BF710", VA = "0x1874C0F10")]
		internal void MUQXWMGKUTX(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x74C0E60", Offset = "0x74BF660", VA = "0x1874C0E60")]
		internal void KYULADWKOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x74C0B80", Offset = "0x74BF380", VA = "0x1874C0B80")]
		private void FDFXBSRORPF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x74C1160", Offset = "0x74BF960", VA = "0x1874C1160")]
		private void QZTNWEGBGJL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x74C37B0", Offset = "0x74C1FB0", VA = "0x1874C37B0")]
		public int VIRBLCIMFYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x74C3690", Offset = "0x74C1E90", VA = "0x1874C3690")]
		public int VIRBLCIMFYR(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74C2590", Offset = "0x74C0D90", VA = "0x1874C2590")]
		private KMQIKSOFVGR TEACQKAKHEW(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x74C4080", Offset = "0x74C2880", VA = "0x1874C4080")]
		internal MGYHLJMUOOC(IKISLUNONDT a, IPEndPoint b, int c, byte d, DAKXRRCCFEN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x74C3AA0", Offset = "0x74C22A0", VA = "0x1874C3AA0")]
		internal MGYHLJMUOOC(IKISLUNONDT a, HNNARTJWOGI b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x74C1AF0", Offset = "0x74C02F0", VA = "0x1874C1AF0")]
		internal void Reject(PPZUIBJCTRT requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x74C3970", Offset = "0x74C2170", VA = "0x1874C3970")]
		internal bool XRFBUBYLUHQ(DBWSXKNBUWA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x74C29C0", Offset = "0x74C11C0", VA = "0x1874C29C0")]
		public void TOAWYNQYTMB(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74C1B40", Offset = "0x74C0340", VA = "0x1874C1B40")]
		private void SEDMWBSJJWY(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x74C0B30", Offset = "0x74BF330", VA = "0x1874C0B30")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74C35F0", Offset = "0x74C1DF0", VA = "0x1874C35F0")]
		internal DisconnectResult VEILAMSUAOW(AYUMDUPRRMK a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x74C0F40", Offset = "0x74BF740", VA = "0x1874C0F40")]
		internal void NCPKWFMUVPX(KMQIKSOFVGR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74C2280", Offset = "0x74C0A80", VA = "0x1874C2280")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x74C2980", Offset = "0x74C1180", VA = "0x1874C2980")]
		private void TLLVJDUBPUM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x74C11A0", Offset = "0x74BF9A0", VA = "0x1874C11A0")]
		internal void RGERCHAHXTC(DeliveryMethod a, AYUMDUPRRMK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x74C29F0", Offset = "0x74C11F0", VA = "0x1874C29F0")]
		private void UEUUUGVZMXW(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74C07A0", Offset = "0x74BEFA0", VA = "0x1874C07A0")]
		private void CHVFXDOYAZO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x74C0FA0", Offset = "0x74BF7A0", VA = "0x1874C0FA0")]
		internal ConnectRequestResult PLVKBSPZCTF(PPZUIBJCTRT a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74C0100", Offset = "0x74BE900", VA = "0x1874C0100")]
		internal void AGQYOAVXJCQ(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x74C2130", Offset = "0x74C0930", VA = "0x1874C2130")]
		private void SPHPIJPJIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74C0C50", Offset = "0x74BF450", VA = "0x1874C0C50")]
		internal void HFQHQNPISXU(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74C2F20", Offset = "0x74C1720", VA = "0x1874C2F20")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74C2720", Offset = "0x74C0F20", VA = "0x1874C2720")]
		internal void TKUZWHEVKCS(AYUMDUPRRMK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class LVBJUIWURGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long RXBZCLFTNWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long RNSVATTMMYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long DJXGPZVFQIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long KUDJOUGPAYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long HOIEZUAELPZ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long KTGEEDTYAAC;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long BMFNIUKJMEP;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long XGOSGDDXNQY;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long GKGNOWTYSTX;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long PQEBOQXCHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long QVQZPGSJBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long PCIZGNSTGLT;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long TIBMIZAYMOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x74BE220", Offset = "0x74BCA20", VA = "0x1874BE220")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long ALZVLIXXDZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x74BE1B0", Offset = "0x74BC9B0", VA = "0x1874BE1B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long BLNAOJBDSOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x74BE880", Offset = "0x74BD080", VA = "0x1874BE880")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long QGLAALBSDUB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x74BE340", Offset = "0x74BCB40", VA = "0x1874BE340")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long RHDJZRBVRGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x74BE810", Offset = "0x74BD010", VA = "0x1874BE810")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long WBAVCDGKHFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x74BE0F0", Offset = "0x74BC8F0", VA = "0x1874BE0F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long FRKRDQGJXQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x74BE350", Offset = "0x74BCB50", VA = "0x1874BE350")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long QSOWVSYCCSA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x74BE100", Offset = "0x74BC900", VA = "0x1874BE100")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality JDVMWPCABSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x112E260", Offset = "0x112CA60", VA = "0x18112E260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double VVCEECMNJFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x74BE2E0", Offset = "0x74BCAE0", VA = "0x1874BE2E0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x74BE3F0", Offset = "0x74BCBF0", VA = "0x1874BE3F0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74BE820", Offset = "0x74BD020", VA = "0x1874BE820")]
		public void WTIOGBMUVYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x74BE290", Offset = "0x74BCA90", VA = "0x1874BE290")]
		public void NULFXMUYNXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x74BE390", Offset = "0x74BCB90", VA = "0x1874BE390")]
		public void QMYWFXDYLRR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x74BE230", Offset = "0x74BCA30", VA = "0x1874BE230")]
		public void NNLRMZKZQNA(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x74BE1C0", Offset = "0x74BC9C0", VA = "0x1874BE1C0")]
		public void MITOELWSPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x74BE140", Offset = "0x74BC940", VA = "0x1874BE140")]
		public void FNOFXUFRVYV(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x74BE4D0", Offset = "0x74BCCD0", VA = "0x1874BE4D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x74BE430", Offset = "0x74BCC30", VA = "0x1874BE430")]
		public void SOPSLXFYKSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LVBJUIWURGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class NVOSWVPNYRR
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> WPXJVVLSXZQ;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x74C4490", Offset = "0x74C2C90", VA = "0x1874C4490")]
		public static IPEndPoint YRYQPUVCAQY(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x74C42A0", Offset = "0x74C2AA0", VA = "0x1874C42A0")]
		public static IPAddress JORNIIFFKJR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x74C4210", Offset = "0x74C2A10", VA = "0x1874C4210")]
		public static IPAddress JORNIIFFKJR(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74C4460", Offset = "0x74C2C60", VA = "0x1874C4460")]
		internal static int KALCEPTNUMH(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3856650", Offset = "0x3854E50", VA = "0x183856650")]
		internal static T[] UDIDIGFFYIS<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class CMMXSDUMWKE : KMQIKSOFVGR
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private AYUMDUPRRMK _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x74C5230", Offset = "0x74C3A30", VA = "0x1874C5230", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x74C5150", Offset = "0x74C3950", VA = "0x1874C5150")]
			public void BDNHZJHRRDD(AYUMDUPRRMK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x74C51C0", Offset = "0x74C39C0", VA = "0x1874C51C0")]
			public bool KGIGTECUNTY(long a, MGYHLJMUOOC b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x74C5170", Offset = "0x74C3970", VA = "0x1874C5170")]
			public bool Clear(MGYHLJMUOOC peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly AYUMDUPRRMK XXVJKGKEUWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] RXPNUXSFDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly AYUMDUPRRMK[] RVUKPXGFWHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] OOGWTTJEZMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int VUCBWDAOZSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int BUAKNTKNFHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int ZDCEJOOUJIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int XSTAQNZQEYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool XVTRRIOZHUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod EPEQSWGRNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool AACUPFIQJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int MDVOUUYCESV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte PBEBWEBAWYR;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int BAYEQQMKQHA
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x74B33F0", Offset = "0x74B1BF0", VA = "0x1874B33F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x74B3400", Offset = "0x74B1C00", VA = "0x1874B3400")]
		public CMMXSDUMWKE(MGYHLJMUOOC a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x74B2BA0", Offset = "0x74B13A0", VA = "0x1874B2BA0")]
		private void EWHKTYZTMIB(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x74B2F20", Offset = "0x74B1720", VA = "0x1874B2F20", Slot = "4")]
		protected override bool GBMXGKGPATT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x74B25A0", Offset = "0x74B0DA0", VA = "0x1874B25A0", Slot = "5")]
		public override bool AGQYOAVXJCQ(AYUMDUPRRMK a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class BMCIWJHNNEB : KMQIKSOFVGR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int ASGCFHOJETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort BUAKNTKNFHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool FPUOKJMVQSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private AYUMDUPRRMK MIBAMYHZBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly AYUMDUPRRMK GCOYELHHWBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool BVIMZPAUUCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte PBEBWEBAWYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long QAIWZHWSCRR;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x74B2370", Offset = "0x74B0B70", VA = "0x1874B2370")]
		public BMCIWJHNNEB(MGYHLJMUOOC a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74B1EB0", Offset = "0x74B06B0", VA = "0x1874B1EB0", Slot = "4")]
		protected override bool GBMXGKGPATT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x74B1C30", Offset = "0x74B0430", VA = "0x1874B1C30", Slot = "5")]
		public override bool AGQYOAVXJCQ(AYUMDUPRRMK a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class VUQHITIJRLS
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
		[Cpp2IlInjected.Address(RVA = "0x74B0F00", Offset = "0x74AF700", VA = "0x1874B0F00")]
		private static void NKBPHMJPUWJ(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x74C6540", Offset = "0x74C4D40", VA = "0x1874C6540")]
		private static void NKBPHMJPUWJ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x74C6630", Offset = "0x74C4E30", VA = "0x1874C6630")]
		public static void NKBPHMJPUWJ(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x74C6520", Offset = "0x74C4D20", VA = "0x1874C6520")]
		public static void KHIJLIKLCYM(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x74C65B0", Offset = "0x74C4DB0", VA = "0x1874C65B0")]
		public static void KHIJLIKLCYM(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x74C6630", Offset = "0x74C4E30", VA = "0x1874C6630")]
		public static void KHIJLIKLCYM(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x74C6630", Offset = "0x74C4E30", VA = "0x1874C6630")]
		public static void KHIJLIKLCYM(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x74C6540", Offset = "0x74C4D40", VA = "0x1874C6540")]
		public static void KHIJLIKLCYM(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x74C6540", Offset = "0x74C4D40", VA = "0x1874C6540")]
		public static void KHIJLIKLCYM(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x74C6670", Offset = "0x74C4E70", VA = "0x1874C6670")]
		public static void KHIJLIKLCYM(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x74C6670", Offset = "0x74C4E70", VA = "0x1874C6670")]
		public static void KHIJLIKLCYM(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class TADVJBOQRIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] KGWXKXLYBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int NSLCHFYACDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int TJFNDDGMXMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int TBWHBVAESEP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] UDKINGTVBBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int CGVBHYMQWBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CEDHTYFIQZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x74C5A20", Offset = "0x74C4220", VA = "0x1874C5A20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ZKRDGYTSEZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2761B00", Offset = "0x2760300", VA = "0x182761B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int NMGCJUIVKTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x74C6060", Offset = "0x74C4860", VA = "0x1874C6060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x74C6070", Offset = "0x74C4870", VA = "0x1874C6070")]
		public void XEGXWUYSEBS(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public TADVJBOQRIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x74C6240", Offset = "0x74C4A40", VA = "0x1874C6240")]
		public TADVJBOQRIF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x74C5FD0", Offset = "0x74C47D0", VA = "0x1874C5FD0")]
		public IPEndPoint USWPUEXKZTP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x74C5C40", Offset = "0x74C4440", VA = "0x1874C5C40")]
		public byte LKZEPRFDLAT()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x74C5C40", Offset = "0x74C4440", VA = "0x1874C5C40")]
		public sbyte RVAWSZJSAHK()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3A67290", Offset = "0x3A65A90", VA = "0x183A67290")]
		public a[] TPTKRXGEHMK<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x74C6180", Offset = "0x74C4980", VA = "0x1874C6180")]
		public bool[] XGSVGVQOIZM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x74C5A50", Offset = "0x74C4250", VA = "0x1874C5A50")]
		public ushort[] FBAQBLIIXTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x74C59E0", Offset = "0x74C41E0", VA = "0x1874C59E0")]
		public short[] BSOZSSPAYBU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x74C5C80", Offset = "0x74C4480", VA = "0x1874C5C80")]
		public int[] MARLBRHSNSH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x74C61C0", Offset = "0x74C49C0", VA = "0x1874C61C0")]
		public uint[] XWMPEMYNNKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x74C6200", Offset = "0x74C4A00", VA = "0x1874C6200")]
		public float[] ZXGXXEXDKYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x74C5CC0", Offset = "0x74C44C0", VA = "0x1874C5CC0")]
		public double[] NFMJEUZNQSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x74C5F10", Offset = "0x74C4710", VA = "0x1874C5F10")]
		public long[] QRFMHLTZEBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x74C5F90", Offset = "0x74C4790", VA = "0x1874C5F90")]
		public ulong[] TXXCSINNQYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x74C60B0", Offset = "0x74C48B0", VA = "0x1874C60B0")]
		public string[] XFPJZRRUTDD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x74C5B60", Offset = "0x74C4360", VA = "0x1874C5B60")]
		public bool IYYSZZXWCPX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x74C5AF0", Offset = "0x74C42F0", VA = "0x1874C5AF0")]
		public char NUNLNXZZWZL()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x74C5AF0", Offset = "0x74C42F0", VA = "0x1874C5AF0")]
		public ushort HEWXPPKYGIS()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x74C5AF0", Offset = "0x74C42F0", VA = "0x1874C5AF0")]
		public short IRYOVKVFWLP()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x74C5A90", Offset = "0x74C4290", VA = "0x1874C5A90")]
		public long PHCACZUQHCL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x74C5A90", Offset = "0x74C4290", VA = "0x1874C5A90")]
		public ulong FGRNVYAENLU()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x74C59B0", Offset = "0x74C41B0", VA = "0x1874C59B0")]
		public int AQXPVAFQFXM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x74C59B0", Offset = "0x74C41B0", VA = "0x1874C59B0")]
		public uint EQFMVAUUGXL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x74C5AC0", Offset = "0x74C42C0", VA = "0x1874C5AC0")]
		public float HDUWKXUEZIZ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x74C5BA0", Offset = "0x74C43A0", VA = "0x1874C5BA0")]
		public double JBQXQXUHLPW()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x74C5D00", Offset = "0x74C4500", VA = "0x1874C5D00")]
		public string PTFGVERFHXG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x74C5BD0", Offset = "0x74C43D0", VA = "0x1874C5BD0")]
		public ArraySegment<byte> KEQNKDRFRXT(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x74C5B20", Offset = "0x74C4320", VA = "0x1874C5B20")]
		public sbyte[] IAVJOZCEZCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x74C5F50", Offset = "0x74C4750", VA = "0x1874C5F50")]
		public byte[] TIDOMOPUSTS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x74C5A30", Offset = "0x74C4230", VA = "0x1874C5A30")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class DAKXRRCCFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] KGWXKXLYBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int NSLCHFYACDB;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int BVNBSAGGETC = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool XBXKZFISCNR;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding PMPFTUDKNXP;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int WTHRBXFKEXE = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] UFFMHFVSZKT;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int VURRPMXXQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAA3180", Offset = "0xAA1980", VA = "0x180AA3180")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x74B4380", Offset = "0x74B2B80", VA = "0x1874B4380")]
		public DAKXRRCCFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x74B42E0", Offset = "0x74B2AE0", VA = "0x1874B42E0")]
		public DAKXRRCCFEN(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x74B36A0", Offset = "0x74B1EA0", VA = "0x1874B36A0")]
		public static DAKXRRCCFEN GDGIXQFHEQC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x74B3710", Offset = "0x74B1F10", VA = "0x1874B3710")]
		public void LFYPDAMTHDC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x27D9BF0", Offset = "0x27D83F0", VA = "0x1827D9BF0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x74B3CC0", Offset = "0x74B24C0", VA = "0x1874B3CC0")]
		public void OJEWEOAZQVG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x74B3DC0", Offset = "0x74B25C0", VA = "0x1874B3DC0")]
		public void OJEWEOAZQVG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x74B3900", Offset = "0x74B2100", VA = "0x1874B3900")]
		public void OJEWEOAZQVG(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x74B3900", Offset = "0x74B2100", VA = "0x1874B3900")]
		public void OJEWEOAZQVG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x74B3BD0", Offset = "0x74B23D0", VA = "0x1874B3BD0")]
		public void OJEWEOAZQVG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x74B3BD0", Offset = "0x74B23D0", VA = "0x1874B3BD0")]
		public void OJEWEOAZQVG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x74B37C0", Offset = "0x74B1FC0", VA = "0x1874B37C0")]
		public void OJEWEOAZQVG(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x74B37C0", Offset = "0x74B1FC0", VA = "0x1874B37C0")]
		public void OJEWEOAZQVG(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x74B37C0", Offset = "0x74B1FC0", VA = "0x1874B37C0")]
		public void OJEWEOAZQVG(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x74B3D60", Offset = "0x74B2560", VA = "0x1874B3D60")]
		public void OJEWEOAZQVG(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x74B3D60", Offset = "0x74B2560", VA = "0x1874B3D60")]
		public void OJEWEOAZQVG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x74B3B60", Offset = "0x74B2360", VA = "0x1874B3B60")]
		public void OJEWEOAZQVG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x74B35C0", Offset = "0x74B1DC0", VA = "0x1874B35C0")]
		public void FQAJBPEBAEE(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x74B35C0", Offset = "0x74B1DC0", VA = "0x1874B35C0")]
		public void COZAGWTZUSP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x74B3C60", Offset = "0x74B2460", VA = "0x1874B3C60")]
		public void OJEWEOAZQVG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x74B3FD0", Offset = "0x74B27D0", VA = "0x1874B3FD0")]
		public void VBGAQWSTJWV(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x74B4180", Offset = "0x74B2980", VA = "0x1874B4180")]
		public void VBGAQWSTJWV(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x74B3E10", Offset = "0x74B2610", VA = "0x1874B3E10")]
		public void VBGAQWSTJWV(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x74B3E10", Offset = "0x74B2610", VA = "0x1874B3E10")]
		public void VBGAQWSTJWV(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x74B3E10", Offset = "0x74B2610", VA = "0x1874B3E10")]
		public void VBGAQWSTJWV(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x74B4180", Offset = "0x74B2980", VA = "0x1874B4180")]
		public void VBGAQWSTJWV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x74B4180", Offset = "0x74B2980", VA = "0x1874B4180")]
		public void VBGAQWSTJWV(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x74B3EF0", Offset = "0x74B26F0", VA = "0x1874B3EF0")]
		public void VBGAQWSTJWV(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x74B3EF0", Offset = "0x74B26F0", VA = "0x1874B3EF0")]
		public void VBGAQWSTJWV(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x74B35C0", Offset = "0x74B1DC0", VA = "0x1874B35C0")]
		public void VBGAQWSTJWV(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x74B40B0", Offset = "0x74B28B0", VA = "0x1874B40B0")]
		public void VBGAQWSTJWV(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x74B3830", Offset = "0x74B2030", VA = "0x1874B3830")]
		public void OJEWEOAZQVG(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x74B37B0", Offset = "0x74B1FB0", VA = "0x1874B37B0")]
		public void OJEWEOAZQVG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x74B3950", Offset = "0x74B2150", VA = "0x1874B3950")]
		public void OJEWEOAZQVG(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class BBNXVCUZKCO
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class SCULIHHUVUQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong CXQIBDZHUDY;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5E0CA30", Offset = "0x5E0B230", VA = "0x185E0CA30")]
			static SCULIHHUVUQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(TADVJBOQRIF reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class FNGJUMVUDQP<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public BBNXVCUZKCO VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a JLKPRNFRXSQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> VLJPZZVSSFR;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public FNGJUMVUDQP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x4C954F0", Offset = "0x4C93CF0", VA = "0x184C954F0")]
			internal void PMKBDUHYANS(TADVJBOQRIF a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class IZRISKDTWWT<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public BBNXVCUZKCO VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a JLKPRNFRXSQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> VLJPZZVSSFR;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public IZRISKDTWWT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x5007CE0", Offset = "0x50064E0", VA = "0x185007CE0")]
			internal void PMKBDUHYANS(TADVJBOQRIF a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly YGWXJDEJWSO XQFOYIMSNLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> CXQXCXHUNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly DAKXRRCCFEN TKHYEHTLAWU;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x74B1AE0", Offset = "0x74B02E0", VA = "0x1874B1AE0")]
		public BBNXVCUZKCO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x339D800", Offset = "0x339C000", VA = "0x18339D800", Slot = "4")]
		protected virtual ulong INMISEPZWFX<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x74B1940", Offset = "0x74B0140", VA = "0x1874B1940", Slot = "5")]
		protected virtual SubscribeDelegate BGVORZIKRFE(TADVJBOQRIF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x339D880", Offset = "0x339C080", VA = "0x18339D880", Slot = "6")]
		protected virtual void UKRZHBMVAFA<b>(DAKXRRCCFEN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x74B1A60", Offset = "0x74B0260", VA = "0x1874B1A60")]
		public void WYBDCBTGBLJ(TADVJBOQRIF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x339D770", Offset = "0x339BF70", VA = "0x18339D770")]
		public void DKMXHPDZVPU<j>(DAKXRRCCFEN a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x74B1A10", Offset = "0x74B0210", VA = "0x1874B1A10")]
		public void NFCQLFLDAHV(TADVJBOQRIF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x339D5F0", Offset = "0x339BDF0", VA = "0x18339D5F0")]
		public void CRVWLCNYMVS<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x339D5F0", Offset = "0x339BDF0", VA = "0x18339D5F0")]
		public void CRVWLCNYMVS<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x74BD500", Offset = "0x74BBD00", VA = "0x1874BD500")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x74C50F0", Offset = "0x74C38F0", VA = "0x1874C50F0")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class YGWXJDEJWSO
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
		private abstract class UPXKHPVYLWO<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType BFJYMHQJKIL;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x611BB10", Offset = "0x611A310", VA = "0x18611BB10", Slot = "4")]
			public virtual void BDNHZJHRRDD(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void ZBJHAFIXLBJ(a a, TADVJBOQRIF b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void DKMXHPDZVPU(a a, DAKXRRCCFEN b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void XBSLJPLYEHO(a a, TADVJBOQRIF b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void QLLFCTUOQBF(a a, DAKXRRCCFEN b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void QQJXUNEPPNJ(a a, TADVJBOQRIF b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void BCZTVSTQJGC(a a, DAKXRRCCFEN b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			protected UPXKHPVYLWO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class ANBWEBDMULJ<a, b> : UPXKHPVYLWO<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> THESGMIYUHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> CQHQKWIXVVG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> IADOWHURYTV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> RYHYIVIZXJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> NNBXPOWUCRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> MCJKZLAWAPG;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5367440", Offset = "0x5365C40", VA = "0x185367440", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5367440", Offset = "0x5365C40", VA = "0x185367440", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5366720", Offset = "0x5364F20", VA = "0x185366720", Slot = "9")]
			public override void QQJXUNEPPNJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5366720", Offset = "0x5364F20", VA = "0x185366720", Slot = "10")]
			public override void BCZTVSTQJGC(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x53676E0", Offset = "0x5365EE0", VA = "0x1853676E0")]
			protected b[] ZBGDAGTDXFW(a a, TADVJBOQRIF b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x53672D0", Offset = "0x5365AD0", VA = "0x1853672D0")]
			protected b[] KSGCJFEXSRR(a a, DAKXRRCCFEN b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x53667F0", Offset = "0x5364FF0", VA = "0x1853667F0", Slot = "4")]
			public override void BDNHZJHRRDD(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x53677B0", Offset = "0x5365FB0", VA = "0x1853677B0")]
			protected ANBWEBDMULJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class VJDLTLUMZIM<a, b> : ANBWEBDMULJ<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void QSYSNZBOGRT(TADVJBOQRIF a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void BQRGDPAWSQE(DAKXRRCCFEN a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6271950", Offset = "0x6270150", VA = "0x186271950", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x62711F0", Offset = "0x626F9F0", VA = "0x1862711F0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x62716C0", Offset = "0x626FEC0", VA = "0x1862716C0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6271620", Offset = "0x626FE20", VA = "0x186271620", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6271BF0", Offset = "0x62703F0", VA = "0x186271BF0")]
			protected VJDLTLUMZIM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class AICHQFUWAFR<a> : ANBWEBDMULJ<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8900", Offset = "0x3DF7100", VA = "0x183DF8900", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8510", Offset = "0x3DF6D10", VA = "0x183DF8510", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5365F60", Offset = "0x5364760", VA = "0x185365F60", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8650", Offset = "0x3DF6E50", VA = "0x183DF8650", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x53660B0", Offset = "0x53648B0", VA = "0x1853660B0")]
			public AICHQFUWAFR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class YSUUHTHJKCQ<a> : ANBWEBDMULJ<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8900", Offset = "0x3DF7100", VA = "0x183DF8900", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8510", Offset = "0x3DF6D10", VA = "0x183DF8510", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8790", Offset = "0x3DF6F90", VA = "0x183DF8790", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8650", Offset = "0x3DF6E50", VA = "0x183DF8650", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public YSUUHTHJKCQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class OPTXCLKMCTG<a> : ANBWEBDMULJ<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x59F95D0", Offset = "0x59F7DD0", VA = "0x1859F95D0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x59F91E0", Offset = "0x59F79E0", VA = "0x1859F91E0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x59F9460", Offset = "0x59F7C60", VA = "0x1859F9460", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x59F9220", Offset = "0x59F7A20", VA = "0x1859F9220", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public OPTXCLKMCTG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class STXHDHFMUFZ<a> : ANBWEBDMULJ<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x59F95D0", Offset = "0x59F7DD0", VA = "0x1859F95D0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x59F91E0", Offset = "0x59F79E0", VA = "0x1859F91E0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5E322E0", Offset = "0x5E30AE0", VA = "0x185E322E0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x59F9220", Offset = "0x59F7A20", VA = "0x1859F9220", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public STXHDHFMUFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class WYBZIETUIXQ<a> : ANBWEBDMULJ<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x4E58060", Offset = "0x4E56860", VA = "0x184E58060", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x4E57D90", Offset = "0x4E56590", VA = "0x184E57D90", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6623650", Offset = "0x6621E50", VA = "0x186623650", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x4E57DD0", Offset = "0x4E565D0", VA = "0x184E57DD0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public WYBZIETUIXQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class HSNKWXYGIQT<a> : ANBWEBDMULJ<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x4E58060", Offset = "0x4E56860", VA = "0x184E58060", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4E57D90", Offset = "0x4E56590", VA = "0x184E57D90", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4E58010", Offset = "0x4E56810", VA = "0x184E58010", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4E57DD0", Offset = "0x4E565D0", VA = "0x184E57DD0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public HSNKWXYGIQT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class XKPCRNWROQS<a> : ANBWEBDMULJ<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2990", Offset = "0x3DD1190", VA = "0x183DD2990", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3DD25A0", Offset = "0x3DD0DA0", VA = "0x183DD25A0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2820", Offset = "0x3DD1020", VA = "0x183DD2820", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD25E0", Offset = "0x3DD0DE0", VA = "0x183DD25E0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public XKPCRNWROQS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class ENQPUAJCQAR<a> : ANBWEBDMULJ<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2990", Offset = "0x3DD1190", VA = "0x183DD2990", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3DD25A0", Offset = "0x3DD0DA0", VA = "0x183DD25A0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x4682980", Offset = "0x4681180", VA = "0x184682980", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DD25E0", Offset = "0x3DD0DE0", VA = "0x183DD25E0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public ENQPUAJCQAR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class ZDIUIDPZYOE<a> : ANBWEBDMULJ<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3E1D8F0", Offset = "0x3E1C0F0", VA = "0x183E1D8F0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x3E1D760", Offset = "0x3E1BF60", VA = "0x183E1D760", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x3E1D8A0", Offset = "0x3E1C0A0", VA = "0x183E1D8A0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8650", Offset = "0x3DF6E50", VA = "0x183DF8650", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public ZDIUIDPZYOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class IXHHWYZFACR<a> : ANBWEBDMULJ<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4FEE830", Offset = "0x4FED030", VA = "0x184FEE830", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x4FEE580", Offset = "0x4FECD80", VA = "0x184FEE580", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x4FEE5C0", Offset = "0x4FECDC0", VA = "0x184FEE5C0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x4E57DD0", Offset = "0x4E565D0", VA = "0x184E57DD0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public IXHHWYZFACR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class MSJNIRWHOWM<a> : ANBWEBDMULJ<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x57D5FF0", Offset = "0x57D47F0", VA = "0x1857D5FF0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x57D5E60", Offset = "0x57D4660", VA = "0x1857D5E60", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x57D5EA0", Offset = "0x57D46A0", VA = "0x1857D5EA0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x3DD25E0", Offset = "0x3DD0DE0", VA = "0x183DD25E0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A00", Offset = "0x3DD1200", VA = "0x183DD2A00")]
			public MSJNIRWHOWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class JHQNVLNQKCI<a> : VJDLTLUMZIM<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x50E5EA0", Offset = "0x50E46A0", VA = "0x1850E5EA0", Slot = "12")]
			protected override void BQRGDPAWSQE(DAKXRRCCFEN a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x50E5ED0", Offset = "0x50E46D0", VA = "0x1850E5ED0", Slot = "11")]
			protected override void QSYSNZBOGRT(TADVJBOQRIF a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x50E5F00", Offset = "0x50E4700", VA = "0x1850E5F00")]
			public JHQNVLNQKCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class PJHDTNUMJHW<a> : VJDLTLUMZIM<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5B15E70", Offset = "0x5B14670", VA = "0x185B15E70", Slot = "12")]
			protected override void BQRGDPAWSQE(DAKXRRCCFEN a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5B15EA0", Offset = "0x5B146A0", VA = "0x185B15EA0", Slot = "11")]
			protected override void QSYSNZBOGRT(TADVJBOQRIF a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x50E5F00", Offset = "0x50E4700", VA = "0x1850E5F00")]
			public PJHDTNUMJHW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class APDPJAYQYGZ<a> : ANBWEBDMULJ<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int JKIBUPNPLUK;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5368E40", Offset = "0x5367640", VA = "0x185368E40")]
			public APDPJAYQYGZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5368D90", Offset = "0x5367590", VA = "0x185368D90", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5368870", Offset = "0x5367070", VA = "0x185368870", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5368B10", Offset = "0x5367310", VA = "0x185368B10", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x53689C0", Offset = "0x53671C0", VA = "0x1853689C0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class FAQCWGMUQXJ<a> : UPXKHPVYLWO<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo PPRLZTXFBIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type TVZBPRYYIJQ;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D910", Offset = "0x4C8C110", VA = "0x184C8D910")]
			public FAQCWGMUQXJ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D6F0", Offset = "0x4C8BEF0", VA = "0x184C8D6F0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D500", Offset = "0x4C8BD00", VA = "0x184C8D500", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D6A0", Offset = "0x4C8BEA0", VA = "0x184C8D6A0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D6A0", Offset = "0x4C8BEA0", VA = "0x184C8D6A0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D4B0", Offset = "0x4C8BCB0", VA = "0x184C8D4B0", Slot = "9")]
			public override void QQJXUNEPPNJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D4B0", Offset = "0x4C8BCB0", VA = "0x184C8D4B0", Slot = "10")]
			public override void BCZTVSTQJGC(a a, DAKXRRCCFEN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class IPXMFRNHWZC<a> : FAQCWGMUQXJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA120", Offset = "0x4FE8920", VA = "0x184FEA120")]
			public IPXMFRNHWZC(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x4FE9F60", Offset = "0x4FE8760", VA = "0x184FE9F60", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x4FE9EE0", Offset = "0x4FE86E0", VA = "0x184FE9EE0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class GHRILXXDTZM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static GHRILXXDTZM<a> GUPHEVFTUDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly UPXKHPVYLWO<a>[] DEEOQVDHVYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int THSXILBATQK;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4DC9DA0", Offset = "0x4DC85A0", VA = "0x184DC9DA0")]
			public GHRILXXDTZM(List<UPXKHPVYLWO<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4DC98E0", Offset = "0x4DC80E0", VA = "0x184DC98E0")]
			public void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4DC9CF0", Offset = "0x4DC84F0", VA = "0x184DC9CF0")]
			public void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class QSICCJLULPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract UPXKHPVYLWO<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private DAKXRRCCFEN MVHQDSXRPTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int PJCSVFMQYNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, QSICCJLULPG> AEHUNCZPGKZ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x74C8350", Offset = "0x74C6B50", VA = "0x1874C8350")]
		public YGWXJDEJWSO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3BEA2A0", Offset = "0x3BE8AA0", VA = "0x183BEA2A0")]
		private GHRILXXDTZM<d> DBDYSBGZTDZ<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB0E0", Offset = "0x3BE98E0", VA = "0x183BEB0E0")]
		public void JIBLBJTHOBM<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB020", Offset = "0x3BE9820", VA = "0x183BEB020")]
		public bool Deserialize<T>(TADVJBOQRIF reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB120", Offset = "0x3BE9920", VA = "0x183BEB120")]
		public void JVPEYACKYLR<f>(DAKXRRCCFEN a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class XURPEPDNBMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime JJQEQOWOEXK;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] NRTATFLWZDU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator MULPSBIEQBY
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x74C7C70", Offset = "0x74C6470", VA = "0x1874C7C70")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int BIBYNZPQUGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x74C76D0", Offset = "0x74C5ED0", VA = "0x1874C76D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x74C7470", Offset = "0x74C5C70", VA = "0x1874C7470")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode FZFJHADPKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x74C6F40", Offset = "0x74C5740", VA = "0x1874C6F40")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x74C73D0", Offset = "0x74C5BD0", VA = "0x1874C73D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int QTUHVBXGDPX
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x74C73A0", Offset = "0x74C5BA0", VA = "0x1874C73A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint EPENFUZGJBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x74C6FA0", Offset = "0x74C57A0", VA = "0x1874C6FA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? SJDHFPLFTKT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x74C7A80", Offset = "0x74C6280", VA = "0x1874C7A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? RKDARNZYOFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x74C6F70", Offset = "0x74C5770", VA = "0x1874C6F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? XRSMTEDCQMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x74C7D50", Offset = "0x74C6550", VA = "0x1874C7D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x74C7510", Offset = "0x74C5D10", VA = "0x1874C7510")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ROKWYWKGJFR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xC98390", Offset = "0xC96B90", VA = "0x180C98390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xC98490", Offset = "0xC96C90", VA = "0x180C98490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x74C7FA0", Offset = "0x74C67A0", VA = "0x1874C7FA0")]
		public XURPEPDNBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x74C82B0", Offset = "0x74C6AB0", VA = "0x1874C82B0")]
		internal XURPEPDNBMD(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x74C7000", Offset = "0x74C5800", VA = "0x1874C7000")]
		public static XURPEPDNBMD ECDARFHPNCT(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x74C7700", Offset = "0x74C5F00", VA = "0x1874C7700")]
		internal void SYTGTACIVXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x74C7D80", Offset = "0x74C6580", VA = "0x1874C7D80")]
		private void ZURCPOGTEAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x74C71D0", Offset = "0x74C59D0", VA = "0x1874C71D0")]
		private DateTime? GBYQIPBFKFI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x74C7AB0", Offset = "0x74C62B0", VA = "0x1874C7AB0")]
		private void UTOGFHYERUC(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x74C7CA0", Offset = "0x74C64A0", VA = "0x1874C7CA0")]
		private ulong VXGFSHKNWUC(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x74C7110", Offset = "0x74C5910", VA = "0x1874C7110")]
		private void FJKXTVVZGTA(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x74C74B0", Offset = "0x74C5CB0", VA = "0x1874C74B0")]
		private uint MOSKSNPBDUJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x737FDB0", Offset = "0x737E5B0", VA = "0x18737FDB0")]
		private static uint JGSJRRGBKII(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x74C7410", Offset = "0x74C5C10", VA = "0x1874C7410")]
		private static ulong JGSJRRGBKII(ulong a)
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
	internal sealed class VTIISBSCVLC
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int WOLYVKEVMWN = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int ELRNIEQUAXS = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int LDMTXGBABIL = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint CCRLKKFRSVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int BPIIHFISLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int XPQCVWWPQZT;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool GLNGTWBJXZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x74C6510", Offset = "0x74C4D10", VA = "0x1874C6510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x74C6420", Offset = "0x74C4C20", VA = "0x1874C6420")]
		public bool TOAWYNQYTMB(IOBNEDXIGVF a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class XGYXWCQEKSG : IOBNEDXIGVF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket VHOQLWMVQEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly IKISLUNONDT VWYIQZMUMIV;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short ZUNVCEAMMVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x74C6CC0", Offset = "0x74C54C0", VA = "0x1874C6CC0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int DVTSBMXKWWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x74C6DD0", Offset = "0x74C55D0", VA = "0x1874C6DD0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint IONQBTPGGUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x74C6680", Offset = "0x74C4E80", VA = "0x1874C6680", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily MXECROWUPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2FE8B30", Offset = "0x2FE7330", VA = "0x182FE8B30", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x74C6DF0", Offset = "0x74C55F0", VA = "0x1874C6DF0")]
		public XGYXWCQEKSG(AddressFamily a, IKISLUNONDT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x74C66A0", Offset = "0x74C4EA0", VA = "0x1874C66A0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x74C6C80", Offset = "0x74C5480", VA = "0x1874C6C80", Slot = "9")]
		public int DOAMKFHANOU(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x74C6CE0", Offset = "0x74C54E0", VA = "0x1874C6CE0", Slot = "10")]
		public int XWWWSJQOMJW(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x74C6C60", Offset = "0x74C5460", VA = "0x1874C6C60", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface IOBNEDXIGVF
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short ZUNVCEAMMVL
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int DVTSBMXKWWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint IONQBTPGGUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily MXECROWUPUJ
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
		int DOAMKFHANOU(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int XWWWSJQOMJW(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x74C4840", Offset = "0x74C3040", VA = "0x1874C4840")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x74C48E0", Offset = "0x74C30E0", VA = "0x1874C48E0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x13373D0", Offset = "0x1335BD0", VA = "0x1813373D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x74C4750", Offset = "0x74C2F50", VA = "0x1874C4750", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x74C4790", Offset = "0x74C2F90", VA = "0x1874C4790", Slot = "0")]
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
	public class KLWGIWTQIRU
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string ASQUOFTJRFY = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int NOLZTQXCOUS = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int XBLRFMLGQEE = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int PYVLMTZQHTE = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> TBUEVRVEPXB;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback OLCEWCUMMWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int DGFIRPBGBWG;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		internal void PVCFPUEUCUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		internal void DFRTDLDDWDS(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class DVPCEZLVHTT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int SSOLTKFTZHA;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
		protected DVPCEZLVHTT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void QKXXSXQGLJL(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void EAHUYEAXWQU(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class DCFFNMGLQVT : DVPCEZLVHTT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] UWHDEJCLXLY;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator JJPAGHKEOGM;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x28E0F90", Offset = "0x28DF790", VA = "0x1828E0F90")]
		public DCFFNMGLQVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x74B4B20", Offset = "0x74B3320", VA = "0x1874B4B20")]
		public void JREYKAJHNTT(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x74B4A40", Offset = "0x74B3240", VA = "0x1874B4A40")]
		public void FDZEVQUCYLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x74B4CD0", Offset = "0x74B34D0", VA = "0x1874B4CD0", Slot = "4")]
		public override void QKXXSXQGLJL(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x74B4740", Offset = "0x74B2F40", VA = "0x1874B4740", Slot = "5")]
		public override void EAHUYEAXWQU(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class XMWDAIDDSMY
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr NBMNCECCVPO;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x74C8720", Offset = "0x74C6F20", VA = "0x1874C8720")]
			[BurstDiscard]
			private static void SEPJJVIVUGU(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x74C88B0", Offset = "0x74C70B0", VA = "0x1874C88B0")]
			private static IntPtr XCHCCHVYGKC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x74C84E0", Offset = "0x74C6CE0", VA = "0x1874C84E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74C5830", Offset = "0x74C4030", VA = "0x1874C5830")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x74C58B0", Offset = "0x74C40B0", VA = "0x1874C58B0")]
		private uint TQXNYCIGXCB(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x74B0B40", Offset = "0x74AF340", VA = "0x1874B0B40")]
		private void TFIFXGVDZKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x74B0BF0", Offset = "0x74AF3F0", VA = "0x1874B0BF0")]
		private void WFVZNTLPPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x74B0AB0", Offset = "0x74AF2B0", VA = "0x1874B0AB0")]
		private void KJJEJJEHOOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x74B0E00", Offset = "0x74AF600", VA = "0x1874B0E00")]
		private void WIWXAKMNFSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x74C5950", Offset = "0x74C4150", VA = "0x1874C5950")]
		private void VMJOUPAUVLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x74C52A0", Offset = "0x74C3AA0", VA = "0x1874C52A0")]
		private unsafe void BHODDBXJGNX(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x74C56C0", Offset = "0x74C3EC0", VA = "0x1874C56C0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void GXSIHCPMQEA([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x74C56D0", Offset = "0x74C3ED0", VA = "0x1874C56D0")]
		public static void GXSIHCPMQEA(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x74C5780", Offset = "0x74C3F80", VA = "0x1874C5780")]
		public static void NPUVGSZMMJK(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x74C58E0", Offset = "0x74C40E0", VA = "0x1874C58E0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void URLTXKCAKRN([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x74C84A0", Offset = "0x74C6CA0", VA = "0x1874C84A0")]
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
