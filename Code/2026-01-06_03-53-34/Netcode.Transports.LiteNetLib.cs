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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C4120", Offset = "0x75C2B20", VA = "0x1875C4120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x75C40D0", Offset = "0x75C2AD0", VA = "0x1875C40D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C3540", Offset = "0x75C1F40", VA = "0x1875C3540")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75C3520", Offset = "0x75C1F20", VA = "0x1875C3520")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75C33D0", Offset = "0x75C1DD0", VA = "0x1875C33D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F90", Offset = "0x75C2990", VA = "0x1875C3F90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75C3650", Offset = "0x75C2050", VA = "0x1875C3650", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75C34E0", Offset = "0x75C1EE0", VA = "0x1875C34E0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75C3920", Offset = "0x75C2320", VA = "0x1875C3920", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75C3CB0", Offset = "0x75C26B0", VA = "0x1875C3CB0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75C2B10", Offset = "0x75C1510", VA = "0x1875C2B10", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75C2A20", Offset = "0x75C1420", VA = "0x1875C2A20", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75C2C50", Offset = "0x75C1650", VA = "0x1875C2C50", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75C38B0", Offset = "0x75C22B0", VA = "0x1875C38B0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75C2E20", Offset = "0x75C1820", VA = "0x1875C2E20", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75C3030", Offset = "0x75C1A30", VA = "0x1875C3030")]
		private DeliveryMethod MSIEJJOBRYA(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75C3ED0", Offset = "0x75C28D0", VA = "0x1875C3ED0", Slot = "16")]
		private void UJGWVVYXOJR(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75C3300", Offset = "0x75C1D00", VA = "0x1875C3300", Slot = "17")]
		private void ODBCGCJNHRR(MGYHLJMUOOC a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "18")]
		private void ARSMNDLXOAQ(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75C3100", Offset = "0x75C1B00", VA = "0x1875C3100", Slot = "19")]
		private void NUPAGRECQYT(MGYHLJMUOOC a, BPPHYDMZXSJ b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75C2CF0", Offset = "0x75C16F0", VA = "0x1875C2CF0")]
		private void IEDTJSLIEZS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "20")]
		private void XFGFAUXZYHN(IPEndPoint a, BPPHYDMZXSJ b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "21")]
		private void MWLYDHJKPEZ(MGYHLJMUOOC a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x75C2DC0", Offset = "0x75C17C0", VA = "0x1875C2DC0", Slot = "22")]
		private void IXQQJGQQEON(HNNARTJWOGI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75C3FD0", Offset = "0x75C29D0", VA = "0x1875C3FD0")]
		private ulong WXIDYCSVUOC(MGYHLJMUOOC a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75C3FB0", Offset = "0x75C29B0", VA = "0x1875C3FB0")]
		private ulong WXIDYCSVUOC(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75C34C0", Offset = "0x75C1EC0", VA = "0x1875C34C0")]
		private static int PPUYDQVXGUX(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75C4000", Offset = "0x75C2A00", VA = "0x1875C4000")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75C2C20", Offset = "0x75C1620", VA = "0x1875C2C20")]
		[CompilerGenerated]
		private void EZZTVSEQVJP(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75C2C20", Offset = "0x75C1620", VA = "0x1875C2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C16F0", Offset = "0x75C00F0", VA = "0x1875C16F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75C1800", Offset = "0x75C0200", VA = "0x1875C1800")]
		protected KMQIKSOFVGR(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75C1690", Offset = "0x75C0090", VA = "0x1875C1690")]
		public void EKRBMLINKZA(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75C1780", Offset = "0x75C0180", VA = "0x1875C1780")]
		protected void WUPUERTVULJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75C1740", Offset = "0x75C0140", VA = "0x1875C1740")]
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
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75B9440", Offset = "0x75B7E40", VA = "0x1875B9440")]
		internal void SIPMEKLAYXZ(PPZUIBJCTRT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75B9410", Offset = "0x75B7E10", VA = "0x1875B9410")]
		private bool IMPENFRPMPX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75B94A0", Offset = "0x75B7EA0", VA = "0x1875B94A0")]
		internal HNNARTJWOGI(IPEndPoint a, PPZUIBJCTRT b, IKISLUNONDT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x75B93B0", Offset = "0x75B7DB0", VA = "0x1875B93B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C9120", Offset = "0x75C7B20", VA = "0x1875C9120")]
		private PPZUIBJCTRT(long a, byte b, int c, byte[] d, TADVJBOQRIF e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x75C8D20", Offset = "0x75C7720", VA = "0x1875C8D20")]
		public static int EDFKTGRZEPK(AYUMDUPRRMK a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75C8F30", Offset = "0x75C7930", VA = "0x1875C8F30")]
		public static PPZUIBJCTRT QDJQYLVSUHR(AYUMDUPRRMK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75C8D50", Offset = "0x75C7750", VA = "0x1875C8D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B88A0", Offset = "0x75B72A0", VA = "0x1875B88A0")]
		private DBWSXKNBUWA(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x75B86A0", Offset = "0x75B70A0", VA = "0x1875B86A0")]
		public static DBWSXKNBUWA QDJQYLVSUHR(AYUMDUPRRMK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75B85B0", Offset = "0x75B6FB0", VA = "0x1875B85B0")]
		public static AYUMDUPRRMK IDYAUSSHBYV(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75B87A0", Offset = "0x75B71A0", VA = "0x1875B87A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool XXZDDEHRPXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C1EA0", Offset = "0x75C08A0", VA = "0x1875C1EA0")]
		internal LASTCCWVYOW(IKISLUNONDT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75C1A20", Offset = "0x75C0420", VA = "0x1875C1A20")]
		internal void XIQYQPXMGPR(IPEndPoint a, AYUMDUPRRMK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x375E8A0", Offset = "0x375D2A0", VA = "0x18375E8A0")]
		private void TOAWYNQYTMB<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75C1890", Offset = "0x75C0290", VA = "0x1875C1890")]
		private void NKFDLAYGQKK(KVNQJKFYKDG a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75C1BA0", Offset = "0x75C05A0", VA = "0x1875C1BA0")]
		private void YRSUNWVMDTY(EVZCYRRXCDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75C1D00", Offset = "0x75C0700", VA = "0x1875C1D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C1680", Offset = "0x75C0080", VA = "0x1875C1680")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x75C1680", Offset = "0x75C0080", VA = "0x1875C1680")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B9630", Offset = "0x75B8030", VA = "0x1875B9630")]
		private static void YKXSVLLISXG(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75B95D0", Offset = "0x75B7FD0", VA = "0x1875B95D0")]
		internal static void YFYWHBILTEE(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x75B9510", Offset = "0x75B7F10", VA = "0x1875B9510")]
		internal static void DYITUXCZCWO(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x75B9570", Offset = "0x75B7F70", VA = "0x1875B9570")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B6700", Offset = "0x75B5100", VA = "0x1875B6700")]
		internal BPPHYDMZXSJ(IKISLUNONDT a, FICHDWIRUCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75B6660", Offset = "0x75B5060", VA = "0x1875B6660")]
		internal void XEGXWUYSEBS(AYUMDUPRRMK a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x75B65E0", Offset = "0x75B4FE0", VA = "0x1875B65E0")]
		internal void NSCVVRIYSCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75B66D0", Offset = "0x75B50D0", VA = "0x1875B66D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B9310", Offset = "0x75B7D10", VA = "0x1875B9310")]
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
			[Cpp2IlInjected.Address(RVA = "0x75CB010", Offset = "0x75C9A10", VA = "0x1875CB010", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x75CB080", Offset = "0x75C9A80", VA = "0x1875CB080", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1AAE050", Offset = "0x1AACA50", VA = "0x181AAE050")]
			public NetPeerEnumerator(MGYHLJMUOOC p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x75C8C90", Offset = "0x75C7690", VA = "0x1875C8C90", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x75C8CE0", Offset = "0x75C76E0", VA = "0x1875C8CE0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xBBA470", Offset = "0xBB8E70", VA = "0x180BBA470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBBA1A0", Offset = "0xBB8BA0", VA = "0x180BBA1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int PHQGNZZKRVH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1F127C0", Offset = "0x1F111C0", VA = "0x181F127C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x206EE00", Offset = "0x206D800", VA = "0x18206EE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte UVGOLUMRXSC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB4F720", Offset = "0xB4E120", VA = "0x180B4F720")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int SSOLTKFTZHA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x75BD250", Offset = "0x75BBC50", VA = "0x1875BD250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short ZUNVCEAMMVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x75BD7B0", Offset = "0x75BC1B0", VA = "0x1875BD7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MGYHLJMUOOC.OnUpdatedMtuDelegate BUHCMLNYTWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x75C0250", Offset = "0x75BEC50", VA = "0x1875C0250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x75C0F50", Offset = "0x75BF950", VA = "0x1875C0F50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x75BE140", Offset = "0x75BCB40", VA = "0x1875BE140")]
		public void MYOJYLLVYOP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75BDF70", Offset = "0x75BC970", VA = "0x1875BDF70")]
		public void MCXCETPHXCS(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x75BF130", Offset = "0x75BDB30", VA = "0x1875BF130")]
		private bool RUTJJLKMYSQ(IPEndPoint a, [Out] MGYHLJMUOOC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x75B9900", Offset = "0x75B8300", VA = "0x1875B9900")]
		private void AFUTXWRGVRY(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x75BDE80", Offset = "0x75BC880", VA = "0x1875BDE80")]
		private void LECXRDCAWMP(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x75BE360", Offset = "0x75BCD60", VA = "0x1875BE360")]
		private void OGAXRHPIAHQ(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x75C10C0", Offset = "0x75BFAC0", VA = "0x1875C10C0")]
		public IKISLUNONDT(YBRAVNOKEID a, [Optional] DVPCEZLVHTT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x75BAA30", Offset = "0x75B9430", VA = "0x1875BAA30")]
		internal void CGUBBNZQCGG(MGYHLJMUOOC a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x75BD200", Offset = "0x75BBC00", VA = "0x1875BD200")]
		internal void HMSFVOMEIEW(MGYHLJMUOOC a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x75BF0F0", Offset = "0x75BDAF0", VA = "0x1875BF0F0")]
		internal void RUMSBWTRTVW(MGYHLJMUOOC a, DisconnectReason b, SocketError c, AYUMDUPRRMK d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x75C09F0", Offset = "0x75BF3F0", VA = "0x1875C09F0")]
		private void YKIWOHUNLEB(MGYHLJMUOOC a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, AYUMDUPRRMK h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75C0360", Offset = "0x75BED60", VA = "0x1875C0360")]
		private void XTGDILJDEJP(FICHDWIRUCW.EType a, [Optional] MGYHLJMUOOC b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] HNNARTJWOGI g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] AYUMDUPRRMK j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75BB170", Offset = "0x75B9B70", VA = "0x1875BB170")]
		private void EUZMRBYZQYY(FICHDWIRUCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x75BDA10", Offset = "0x75BC410", VA = "0x1875BDA10")]
		internal void JOWGYAWDSWY(FICHDWIRUCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x75BDB20", Offset = "0x75BC520", VA = "0x1875BDB20")]
		private void KASXBOTTVDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75B9C20", Offset = "0x75B8620", VA = "0x1875B9C20")]
		private void APPJYOVFZJC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75BEAC0", Offset = "0x75BD4C0", VA = "0x1875BEAC0")]
		internal MGYHLJMUOOC PSZACHAZMSX(HNNARTJWOGI a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75BE0C0", Offset = "0x75BCAC0", VA = "0x1875BE0C0")]
		private int MGLEDVINTPP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x75BE620", Offset = "0x75BD020", VA = "0x1875BE620")]
		private void PLVKBSPZCTF(IPEndPoint a, MGYHLJMUOOC b, PPZUIBJCTRT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x75BBA90", Offset = "0x75BA490", VA = "0x1875BBA90")]
		private void GYTOKMAAYJA(AYUMDUPRRMK a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x75BA760", Offset = "0x75B9160", VA = "0x1875BA760")]
		internal void BTEFQMYXAOU(AYUMDUPRRMK a, DeliveryMethod b, byte c, int d, MGYHLJMUOOC e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x75BFDC0", Offset = "0x75BE7C0", VA = "0x1875BFDC0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75BF630", Offset = "0x75BE030", VA = "0x1875BF630")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75BF5B0", Offset = "0x75BDFB0", VA = "0x1875BF5B0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x75BD050", Offset = "0x75BBA50", VA = "0x1875BD050")]
		public void HDIZRRXCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x75BAA80", Offset = "0x75B9480", VA = "0x1875BAA80")]
		public MGYHLJMUOOC Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x75BAF30", Offset = "0x75B9930", VA = "0x1875BAF30")]
		public MGYHLJMUOOC Connect(string address, int port, DAKXRRCCFEN connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75BAB60", Offset = "0x75B9560", VA = "0x1875BAB60")]
		public MGYHLJMUOOC Connect(IPEndPoint target, DAKXRRCCFEN connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75C0190", Offset = "0x75BEB90", VA = "0x1875C0190")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x75BFE30", Offset = "0x75BE830", VA = "0x1875BFE30")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x75C0EA0", Offset = "0x75BF8A0", VA = "0x1875C0EA0")]
		public void YWODELFMPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x75C0DD0", Offset = "0x75BF7D0", VA = "0x1875C0DD0")]
		public void YWODELFMPOI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x75C0970", Offset = "0x75BF370", VA = "0x1875C0970")]
		public void YKIWOHUNLEB(MGYHLJMUOOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75C09B0", Offset = "0x75BF3B0", VA = "0x1875C09B0")]
		public void YKIWOHUNLEB(MGYHLJMUOOC a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75BDEE0", Offset = "0x75BC8E0", VA = "0x1875BDEE0", Slot = "4")]
		private IEnumerator<MGYHLJMUOOC> LNTAABKJYQS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x75C01C0", Offset = "0x75BEBC0", VA = "0x1875C01C0", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75BD6D0", Offset = "0x75BC0D0", VA = "0x1875BD6D0")]
		private AYUMDUPRRMK IGYUVIPDZCC(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75BD5F0", Offset = "0x75BBFF0", VA = "0x1875BD5F0")]
		private AYUMDUPRRMK IGYUVIPDZCC(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x75C0730", Offset = "0x75BF130", VA = "0x1875C0730")]
		internal AYUMDUPRRMK YJXARFNHZDF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x75BF350", Offset = "0x75BDD50", VA = "0x1875BF350")]
		internal void SYUCMHLKQPU(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75C1000", Offset = "0x75BFA00", VA = "0x1875C1000")]
		static IKISLUNONDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBBA470", Offset = "0xBB8E70", VA = "0x180BBA470")]
		private bool BNNDFGNXEUZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x75BB010", Offset = "0x75B9A10", VA = "0x1875BB010")]
		private void DIKFFLIHJPJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x75BB940", Offset = "0x75BA340", VA = "0x1875BB940")]
		private void GQWINNJIEPO(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x75BD870", Offset = "0x75BC270", VA = "0x1875BD870")]
		private bool IVGVXOVRJFQ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x75C01A0", Offset = "0x75BEBA0", VA = "0x1875C01A0")]
		private void UZHUPCRDFEB(KLWGIWTQIRU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75BCD90", Offset = "0x75BB790", VA = "0x1875BCD90")]
		private void HDFMPGKGQAC(IOBNEDXIGVF a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75BD270", Offset = "0x75BBC70", VA = "0x1875BD270")]
		private void IFEPOLVSWRE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x75BF650", Offset = "0x75BE050", VA = "0x1875BF650")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75C0300", Offset = "0x75BED00", VA = "0x1875C0300")]
		internal int XJNMNPGYDJR(AYUMDUPRRMK a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75B9F50", Offset = "0x75B8950", VA = "0x1875B9F50")]
		internal int BOXKOSMEWPT(AYUMDUPRRMK a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75B9F90", Offset = "0x75B8990", VA = "0x1875B9F90")]
		internal int BOXKOSMEWPT(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75BF1D0", Offset = "0x75BDBD0", VA = "0x1875BF1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75B5500", Offset = "0x75B3F00", VA = "0x1875B5500")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x75B5680", Offset = "0x75B4080", VA = "0x1875B5680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte PEYBASLMECO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x75B5300", Offset = "0x75B3D00", VA = "0x1875B5300")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x75B5370", Offset = "0x75B3D70", VA = "0x1875B5370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort WJMFBTLNTWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x75B5530", Offset = "0x75B3F30", VA = "0x1875B5530")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x75B5330", Offset = "0x75B3D30", VA = "0x1875B5330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CZATPMCQUOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x75B5650", Offset = "0x75B4050", VA = "0x1875B5650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte DOMIGNPEITZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x75B53B0", Offset = "0x75B3DB0", VA = "0x1875B53B0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x75B5470", Offset = "0x75B3E70", VA = "0x1875B5470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort GHXCLSIKGSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x75B54A0", Offset = "0x75B3EA0", VA = "0x1875B54A0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x75B5410", Offset = "0x75B3E10", VA = "0x1875B5410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort ISHHQWUZGGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x75B51A0", Offset = "0x75B3BA0", VA = "0x1875B51A0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x75B54C0", Offset = "0x75B3EC0", VA = "0x1875B54C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort PZMWMPVOHYO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x75B5450", Offset = "0x75B3E50", VA = "0x1875B5450")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x75B51C0", Offset = "0x75B3BC0", VA = "0x1875B51C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75B56C0", Offset = "0x75B40C0", VA = "0x1875B56C0")]
		static AYUMDUPRRMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75B53E0", Offset = "0x75B3DE0", VA = "0x1875B53E0")]
		public void MKMSXNNAUQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x75B5A80", Offset = "0x75B4480", VA = "0x1875B5A80")]
		public AYUMDUPRRMK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x75B5970", Offset = "0x75B4370", VA = "0x1875B5970")]
		public AYUMDUPRRMK(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x75B5200", Offset = "0x75B3C00", VA = "0x1875B5200")]
		public static int DSMGOFQWNYF(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75B5270", Offset = "0x75B3C70", VA = "0x1875B5270")]
		public int DSMGOFQWNYF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75B5550", Offset = "0x75B3F50", VA = "0x1875B5550")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAE3590", Offset = "0xAE1F90", VA = "0x180AE3590")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x75C5BC0", Offset = "0x75C45C0", VA = "0x1875C5BC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint DDHJPTNDYVM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBB45E0", Offset = "0xBB2FE0", VA = "0x180BB45E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState WJYMXKQITKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x124A6D0", Offset = "0x12490D0", VA = "0x18124A6D0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long QGVJWWOPSAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F20", Offset = "0xABF920", VA = "0x180AC0F20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int SILDFLTGJSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F127C0", Offset = "0x1F111C0", VA = "0x181F127C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x206EE00", Offset = "0x206D800", VA = "0x18206EE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FCTHDHWLGXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x75C4FE0", Offset = "0x75C39E0", VA = "0x1875C4FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int JHQZAHSLHDS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double ATQQSWEJGGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2816580", Offset = "0x2814F80", VA = "0x182816580")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate BUHCMLNYTWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x75C7A30", Offset = "0x75C6430", VA = "0x1875C7A30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x75C7B60", Offset = "0x75C6560", VA = "0x1875C7B60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75C7DF0", Offset = "0x75C67F0", VA = "0x1875C7DF0")]
		internal MGYHLJMUOOC(IKISLUNONDT a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x75C5080", Offset = "0x75C3A80", VA = "0x1875C5080")]
		internal void LKGNYLVCTEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x75C50A0", Offset = "0x75C3AA0", VA = "0x1875C50A0")]
		internal void MUQXWMGKUTX(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x75C4FF0", Offset = "0x75C39F0", VA = "0x1875C4FF0")]
		internal void KYULADWKOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75C4D10", Offset = "0x75C3710", VA = "0x1875C4D10")]
		private void FDFXBSRORPF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x75C52F0", Offset = "0x75C3CF0", VA = "0x1875C52F0")]
		private void QZTNWEGBGJL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x75C7920", Offset = "0x75C6320", VA = "0x1875C7920")]
		public int VIRBLCIMFYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x75C7800", Offset = "0x75C6200", VA = "0x1875C7800")]
		public int VIRBLCIMFYR(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x75C6710", Offset = "0x75C5110", VA = "0x1875C6710")]
		private KMQIKSOFVGR TEACQKAKHEW(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x75C81F0", Offset = "0x75C6BF0", VA = "0x1875C81F0")]
		internal MGYHLJMUOOC(IKISLUNONDT a, IPEndPoint b, int c, byte d, DAKXRRCCFEN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x75C7C10", Offset = "0x75C6610", VA = "0x1875C7C10")]
		internal MGYHLJMUOOC(IKISLUNONDT a, HNNARTJWOGI b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x75C5C70", Offset = "0x75C4670", VA = "0x1875C5C70")]
		internal void Reject(PPZUIBJCTRT requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x75C7AE0", Offset = "0x75C64E0", VA = "0x1875C7AE0")]
		internal bool XRFBUBYLUHQ(DBWSXKNBUWA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x75C6B40", Offset = "0x75C5540", VA = "0x1875C6B40")]
		public void TOAWYNQYTMB(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x75C5CC0", Offset = "0x75C46C0", VA = "0x1875C5CC0")]
		private void SEDMWBSJJWY(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x75C4CC0", Offset = "0x75C36C0", VA = "0x1875C4CC0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x75C7760", Offset = "0x75C6160", VA = "0x1875C7760")]
		internal DisconnectResult VEILAMSUAOW(AYUMDUPRRMK a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x75C50D0", Offset = "0x75C3AD0", VA = "0x1875C50D0")]
		internal void NCPKWFMUVPX(KMQIKSOFVGR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x75C6400", Offset = "0x75C4E00", VA = "0x1875C6400")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x75C6B00", Offset = "0x75C5500", VA = "0x1875C6B00")]
		private void TLLVJDUBPUM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x75C5330", Offset = "0x75C3D30", VA = "0x1875C5330")]
		internal void RGERCHAHXTC(DeliveryMethod a, AYUMDUPRRMK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x75C6B70", Offset = "0x75C5570", VA = "0x1875C6B70")]
		private void UEUUUGVZMXW(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x75C4930", Offset = "0x75C3330", VA = "0x1875C4930")]
		private void CHVFXDOYAZO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x75C5130", Offset = "0x75C3B30", VA = "0x1875C5130")]
		internal ConnectRequestResult PLVKBSPZCTF(PPZUIBJCTRT a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x75C4290", Offset = "0x75C2C90", VA = "0x1875C4290")]
		internal void AGQYOAVXJCQ(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x75C62B0", Offset = "0x75C4CB0", VA = "0x1875C62B0")]
		private void SPHPIJPJIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x75C4DE0", Offset = "0x75C37E0", VA = "0x1875C4DE0")]
		internal void HFQHQNPISXU(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x75C7090", Offset = "0x75C5A90", VA = "0x1875C7090")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x75C68A0", Offset = "0x75C52A0", VA = "0x1875C68A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C23C0", Offset = "0x75C0DC0", VA = "0x1875C23C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long ALZVLIXXDZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x75C2350", Offset = "0x75C0D50", VA = "0x1875C2350")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long BLNAOJBDSOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x75C2A10", Offset = "0x75C1410", VA = "0x1875C2A10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long QGLAALBSDUB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x75C24E0", Offset = "0x75C0EE0", VA = "0x1875C24E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long RHDJZRBVRGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x75C29A0", Offset = "0x75C13A0", VA = "0x1875C29A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long WBAVCDGKHFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x75C2290", Offset = "0x75C0C90", VA = "0x1875C2290")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long FRKRDQGJXQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x75C24F0", Offset = "0x75C0EF0", VA = "0x1875C24F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long QSOWVSYCCSA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x75C22A0", Offset = "0x75C0CA0", VA = "0x1875C22A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality JDVMWPCABSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double VVCEECMNJFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x75C2480", Offset = "0x75C0E80", VA = "0x1875C2480")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75C2590", Offset = "0x75C0F90", VA = "0x1875C2590")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x75C29B0", Offset = "0x75C13B0", VA = "0x1875C29B0")]
		public void WTIOGBMUVYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x75C2430", Offset = "0x75C0E30", VA = "0x1875C2430")]
		public void NULFXMUYNXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x75C2530", Offset = "0x75C0F30", VA = "0x1875C2530")]
		public void QMYWFXDYLRR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x75C23D0", Offset = "0x75C0DD0", VA = "0x1875C23D0")]
		public void NNLRMZKZQNA(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x75C2360", Offset = "0x75C0D60", VA = "0x1875C2360")]
		public void MITOELWSPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x75C22E0", Offset = "0x75C0CE0", VA = "0x1875C22E0")]
		public void FNOFXUFRVYV(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x75C2670", Offset = "0x75C1070", VA = "0x1875C2670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x75C25D0", Offset = "0x75C0FD0", VA = "0x1875C25D0")]
		public void SOPSLXFYKSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C8600", Offset = "0x75C7000", VA = "0x1875C8600")]
		public static IPEndPoint YRYQPUVCAQY(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x75C8410", Offset = "0x75C6E10", VA = "0x1875C8410")]
		public static IPAddress JORNIIFFKJR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x75C8380", Offset = "0x75C6D80", VA = "0x1875C8380")]
		public static IPAddress JORNIIFFKJR(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x75C85D0", Offset = "0x75C6FD0", VA = "0x1875C85D0")]
		internal static int KALCEPTNUMH(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3871EB0", Offset = "0x38708B0", VA = "0x183871EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C93A0", Offset = "0x75C7DA0", VA = "0x1875C93A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x75C92C0", Offset = "0x75C7CC0", VA = "0x1875C92C0")]
			public void BDNHZJHRRDD(AYUMDUPRRMK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x75C9330", Offset = "0x75C7D30", VA = "0x1875C9330")]
			public bool KGIGTECUNTY(long a, MGYHLJMUOOC b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x75C92E0", Offset = "0x75C7CE0", VA = "0x1875C92E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75B75A0", Offset = "0x75B5FA0", VA = "0x1875B75A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x75B75B0", Offset = "0x75B5FB0", VA = "0x1875B75B0")]
		public CMMXSDUMWKE(MGYHLJMUOOC a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x75B6D50", Offset = "0x75B5750", VA = "0x1875B6D50")]
		private void EWHKTYZTMIB(AYUMDUPRRMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x75B70D0", Offset = "0x75B5AD0", VA = "0x1875B70D0", Slot = "4")]
		protected override bool GBMXGKGPATT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x75B6750", Offset = "0x75B5150", VA = "0x1875B6750", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B6520", Offset = "0x75B4F20", VA = "0x1875B6520")]
		public BMCIWJHNNEB(MGYHLJMUOOC a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75B6060", Offset = "0x75B4A60", VA = "0x1875B6060", Slot = "4")]
		protected override bool GBMXGKGPATT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x75B5DE0", Offset = "0x75B47E0", VA = "0x1875B5DE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B50B0", Offset = "0x75B3AB0", VA = "0x1875B50B0")]
		private static void NKBPHMJPUWJ(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x75CA6B0", Offset = "0x75C90B0", VA = "0x1875CA6B0")]
		private static void NKBPHMJPUWJ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x75CA7A0", Offset = "0x75C91A0", VA = "0x1875CA7A0")]
		public static void NKBPHMJPUWJ(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x75CA690", Offset = "0x75C9090", VA = "0x1875CA690")]
		public static void KHIJLIKLCYM(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x75CA720", Offset = "0x75C9120", VA = "0x1875CA720")]
		public static void KHIJLIKLCYM(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x75CA7A0", Offset = "0x75C91A0", VA = "0x1875CA7A0")]
		public static void KHIJLIKLCYM(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x75CA7A0", Offset = "0x75C91A0", VA = "0x1875CA7A0")]
		public static void KHIJLIKLCYM(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x75CA6B0", Offset = "0x75C90B0", VA = "0x1875CA6B0")]
		public static void KHIJLIKLCYM(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x75CA6B0", Offset = "0x75C90B0", VA = "0x1875CA6B0")]
		public static void KHIJLIKLCYM(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x75CA7E0", Offset = "0x75C91E0", VA = "0x1875CA7E0")]
		public static void KHIJLIKLCYM(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x75CA7E0", Offset = "0x75C91E0", VA = "0x1875CA7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int CGVBHYMQWBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CEDHTYFIQZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x75C9B90", Offset = "0x75C8590", VA = "0x1875C9B90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ZKRDGYTSEZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x27745B0", Offset = "0x2772FB0", VA = "0x1827745B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int NMGCJUIVKTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x75CA1D0", Offset = "0x75C8BD0", VA = "0x1875CA1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x75CA1E0", Offset = "0x75C8BE0", VA = "0x1875CA1E0")]
		public void XEGXWUYSEBS(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TADVJBOQRIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x75CA3B0", Offset = "0x75C8DB0", VA = "0x1875CA3B0")]
		public TADVJBOQRIF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x75CA140", Offset = "0x75C8B40", VA = "0x1875CA140")]
		public IPEndPoint USWPUEXKZTP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x75C9DB0", Offset = "0x75C87B0", VA = "0x1875C9DB0")]
		public byte LKZEPRFDLAT()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x75C9DB0", Offset = "0x75C87B0", VA = "0x1875C9DB0")]
		public sbyte RVAWSZJSAHK()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3A7F0C0", Offset = "0x3A7DAC0", VA = "0x183A7F0C0")]
		public a[] TPTKRXGEHMK<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x75CA2F0", Offset = "0x75C8CF0", VA = "0x1875CA2F0")]
		public bool[] XGSVGVQOIZM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x75C9BC0", Offset = "0x75C85C0", VA = "0x1875C9BC0")]
		public ushort[] FBAQBLIIXTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x75C9B50", Offset = "0x75C8550", VA = "0x1875C9B50")]
		public short[] BSOZSSPAYBU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x75C9DF0", Offset = "0x75C87F0", VA = "0x1875C9DF0")]
		public int[] MARLBRHSNSH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x75CA330", Offset = "0x75C8D30", VA = "0x1875CA330")]
		public uint[] XWMPEMYNNKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x75CA370", Offset = "0x75C8D70", VA = "0x1875CA370")]
		public float[] ZXGXXEXDKYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75C9E30", Offset = "0x75C8830", VA = "0x1875C9E30")]
		public double[] NFMJEUZNQSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x75CA080", Offset = "0x75C8A80", VA = "0x1875CA080")]
		public long[] QRFMHLTZEBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x75CA100", Offset = "0x75C8B00", VA = "0x1875CA100")]
		public ulong[] TXXCSINNQYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x75CA220", Offset = "0x75C8C20", VA = "0x1875CA220")]
		public string[] XFPJZRRUTDD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x75C9CD0", Offset = "0x75C86D0", VA = "0x1875C9CD0")]
		public bool IYYSZZXWCPX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x75C9C60", Offset = "0x75C8660", VA = "0x1875C9C60")]
		public char NUNLNXZZWZL()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x75C9C60", Offset = "0x75C8660", VA = "0x1875C9C60")]
		public ushort HEWXPPKYGIS()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x75C9C60", Offset = "0x75C8660", VA = "0x1875C9C60")]
		public short IRYOVKVFWLP()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x75C9C00", Offset = "0x75C8600", VA = "0x1875C9C00")]
		public long PHCACZUQHCL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x75C9C00", Offset = "0x75C8600", VA = "0x1875C9C00")]
		public ulong FGRNVYAENLU()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x75C9B20", Offset = "0x75C8520", VA = "0x1875C9B20")]
		public int AQXPVAFQFXM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x75C9B20", Offset = "0x75C8520", VA = "0x1875C9B20")]
		public uint EQFMVAUUGXL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x75C9C30", Offset = "0x75C8630", VA = "0x1875C9C30")]
		public float HDUWKXUEZIZ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x75C9D10", Offset = "0x75C8710", VA = "0x1875C9D10")]
		public double JBQXQXUHLPW()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x75C9E70", Offset = "0x75C8870", VA = "0x1875C9E70")]
		public string PTFGVERFHXG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x75C9D40", Offset = "0x75C8740", VA = "0x1875C9D40")]
		public ArraySegment<byte> KEQNKDRFRXT(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75C9C90", Offset = "0x75C8690", VA = "0x1875C9C90")]
		public sbyte[] IAVJOZCEZCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x75CA0C0", Offset = "0x75C8AC0", VA = "0x1875CA0C0")]
		public byte[] TIDOMOPUSTS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x75C9BA0", Offset = "0x75C85A0", VA = "0x1875C9BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int VURRPMXXQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x75B8530", Offset = "0x75B6F30", VA = "0x1875B8530")]
		public DAKXRRCCFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x75B8490", Offset = "0x75B6E90", VA = "0x1875B8490")]
		public DAKXRRCCFEN(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x75B7850", Offset = "0x75B6250", VA = "0x1875B7850")]
		public static DAKXRRCCFEN GDGIXQFHEQC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x75B78C0", Offset = "0x75B62C0", VA = "0x1875B78C0")]
		public void LFYPDAMTHDC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x27EC360", Offset = "0x27EAD60", VA = "0x1827EC360")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x75B7E70", Offset = "0x75B6870", VA = "0x1875B7E70")]
		public void OJEWEOAZQVG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x75B7F70", Offset = "0x75B6970", VA = "0x1875B7F70")]
		public void OJEWEOAZQVG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x75B7AB0", Offset = "0x75B64B0", VA = "0x1875B7AB0")]
		public void OJEWEOAZQVG(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x75B7AB0", Offset = "0x75B64B0", VA = "0x1875B7AB0")]
		public void OJEWEOAZQVG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x75B7D80", Offset = "0x75B6780", VA = "0x1875B7D80")]
		public void OJEWEOAZQVG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x75B7D80", Offset = "0x75B6780", VA = "0x1875B7D80")]
		public void OJEWEOAZQVG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x75B7970", Offset = "0x75B6370", VA = "0x1875B7970")]
		public void OJEWEOAZQVG(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x75B7970", Offset = "0x75B6370", VA = "0x1875B7970")]
		public void OJEWEOAZQVG(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x75B7970", Offset = "0x75B6370", VA = "0x1875B7970")]
		public void OJEWEOAZQVG(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x75B7F10", Offset = "0x75B6910", VA = "0x1875B7F10")]
		public void OJEWEOAZQVG(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x75B7F10", Offset = "0x75B6910", VA = "0x1875B7F10")]
		public void OJEWEOAZQVG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x75B7D10", Offset = "0x75B6710", VA = "0x1875B7D10")]
		public void OJEWEOAZQVG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x75B7770", Offset = "0x75B6170", VA = "0x1875B7770")]
		public void FQAJBPEBAEE(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x75B7770", Offset = "0x75B6170", VA = "0x1875B7770")]
		public void COZAGWTZUSP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x75B7E10", Offset = "0x75B6810", VA = "0x1875B7E10")]
		public void OJEWEOAZQVG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x75B8180", Offset = "0x75B6B80", VA = "0x1875B8180")]
		public void VBGAQWSTJWV(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x75B8330", Offset = "0x75B6D30", VA = "0x1875B8330")]
		public void VBGAQWSTJWV(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x75B7FC0", Offset = "0x75B69C0", VA = "0x1875B7FC0")]
		public void VBGAQWSTJWV(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x75B7FC0", Offset = "0x75B69C0", VA = "0x1875B7FC0")]
		public void VBGAQWSTJWV(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x75B7FC0", Offset = "0x75B69C0", VA = "0x1875B7FC0")]
		public void VBGAQWSTJWV(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x75B8330", Offset = "0x75B6D30", VA = "0x1875B8330")]
		public void VBGAQWSTJWV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x75B8330", Offset = "0x75B6D30", VA = "0x1875B8330")]
		public void VBGAQWSTJWV(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x75B80A0", Offset = "0x75B6AA0", VA = "0x1875B80A0")]
		public void VBGAQWSTJWV(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x75B80A0", Offset = "0x75B6AA0", VA = "0x1875B80A0")]
		public void VBGAQWSTJWV(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x75B7770", Offset = "0x75B6170", VA = "0x1875B7770")]
		public void VBGAQWSTJWV(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x75B8260", Offset = "0x75B6C60", VA = "0x1875B8260")]
		public void VBGAQWSTJWV(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x75B79E0", Offset = "0x75B63E0", VA = "0x1875B79E0")]
		public void OJEWEOAZQVG(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x75B7960", Offset = "0x75B6360", VA = "0x1875B7960")]
		public void OJEWEOAZQVG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x75B7B00", Offset = "0x75B6500", VA = "0x1875B7B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EE2020", Offset = "0x5EE0A20", VA = "0x185EE2020")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FNGJUMVUDQP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x4CFE340", Offset = "0x4CFCD40", VA = "0x184CFE340")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public IZRISKDTWWT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x50867A0", Offset = "0x50851A0", VA = "0x1850867A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B5C90", Offset = "0x75B4690", VA = "0x1875B5C90")]
		public BBNXVCUZKCO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x33B8BB0", Offset = "0x33B75B0", VA = "0x1833B8BB0", Slot = "4")]
		protected virtual ulong INMISEPZWFX<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x75B5AF0", Offset = "0x75B44F0", VA = "0x1875B5AF0", Slot = "5")]
		protected virtual SubscribeDelegate BGVORZIKRFE(TADVJBOQRIF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x33B8C30", Offset = "0x33B7630", VA = "0x1833B8C30", Slot = "6")]
		protected virtual void UKRZHBMVAFA<b>(DAKXRRCCFEN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x75B5C10", Offset = "0x75B4610", VA = "0x1875B5C10")]
		public void WYBDCBTGBLJ(TADVJBOQRIF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x33B8B20", Offset = "0x33B7520", VA = "0x1833B8B20")]
		public void DKMXHPDZVPU<j>(DAKXRRCCFEN a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x75B5BC0", Offset = "0x75B45C0", VA = "0x1875B5BC0")]
		public void NFCQLFLDAHV(TADVJBOQRIF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x33B89A0", Offset = "0x33B73A0", VA = "0x1833B89A0")]
		public void CRVWLCNYMVS<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x33B89A0", Offset = "0x33B73A0", VA = "0x1833B89A0")]
		public void CRVWLCNYMVS<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x75C1680", Offset = "0x75C0080", VA = "0x1875C1680")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x75C9260", Offset = "0x75C7C60", VA = "0x1875C9260")]
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
			[Cpp2IlInjected.Address(RVA = "0x6202A70", Offset = "0x6201470", VA = "0x186202A70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x53FAD20", Offset = "0x53F9720", VA = "0x1853FAD20", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x53FAD20", Offset = "0x53F9720", VA = "0x1853FAD20", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x53F9FA0", Offset = "0x53F89A0", VA = "0x1853F9FA0", Slot = "9")]
			public override void QQJXUNEPPNJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x53F9FA0", Offset = "0x53F89A0", VA = "0x1853F9FA0", Slot = "10")]
			public override void BCZTVSTQJGC(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x53FAFD0", Offset = "0x53F99D0", VA = "0x1853FAFD0")]
			protected b[] ZBGDAGTDXFW(a a, TADVJBOQRIF b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x53FABB0", Offset = "0x53F95B0", VA = "0x1853FABB0")]
			protected b[] KSGCJFEXSRR(a a, DAKXRRCCFEN b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x53FA070", Offset = "0x53F8A70", VA = "0x1853FA070", Slot = "4")]
			public override void BDNHZJHRRDD(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x53FB0B0", Offset = "0x53F9AB0", VA = "0x1853FB0B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x635E350", Offset = "0x635CD50", VA = "0x18635E350", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x635DBC0", Offset = "0x635C5C0", VA = "0x18635DBC0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x635E0B0", Offset = "0x635CAB0", VA = "0x18635E0B0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x635E010", Offset = "0x635CA10", VA = "0x18635E010", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x635E5F0", Offset = "0x635CFF0", VA = "0x18635E5F0")]
			protected VJDLTLUMZIM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class AICHQFUWAFR<a> : ANBWEBDMULJ<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3E15F70", Offset = "0x3E14970", VA = "0x183E15F70", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3E15B70", Offset = "0x3E14570", VA = "0x183E15B70", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x53F97C0", Offset = "0x53F81C0", VA = "0x1853F97C0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3E15CC0", Offset = "0x3E146C0", VA = "0x183E15CC0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x53F9910", Offset = "0x53F8310", VA = "0x1853F9910")]
			public AICHQFUWAFR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class YSUUHTHJKCQ<a> : ANBWEBDMULJ<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3E15F70", Offset = "0x3E14970", VA = "0x183E15F70", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3E15B70", Offset = "0x3E14570", VA = "0x183E15B70", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3E15E00", Offset = "0x3E14800", VA = "0x183E15E00", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3E15CC0", Offset = "0x3E146C0", VA = "0x183E15CC0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public YSUUHTHJKCQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class OPTXCLKMCTG<a> : ANBWEBDMULJ<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5AB8BA0", Offset = "0x5AB75A0", VA = "0x185AB8BA0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5AB8790", Offset = "0x5AB7190", VA = "0x185AB8790", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5AB8A20", Offset = "0x5AB7420", VA = "0x185AB8A20", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x5AB87D0", Offset = "0x5AB71D0", VA = "0x185AB87D0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public OPTXCLKMCTG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class STXHDHFMUFZ<a> : ANBWEBDMULJ<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x5AB8BA0", Offset = "0x5AB75A0", VA = "0x185AB8BA0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5AB8790", Offset = "0x5AB7190", VA = "0x185AB8790", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5F07F50", Offset = "0x5F06950", VA = "0x185F07F50", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x5AB87D0", Offset = "0x5AB71D0", VA = "0x185AB87D0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public STXHDHFMUFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class WYBZIETUIXQ<a> : ANBWEBDMULJ<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC4A0", Offset = "0x4ECAEA0", VA = "0x184ECC4A0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC1C0", Offset = "0x4ECABC0", VA = "0x184ECC1C0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6722AF0", Offset = "0x67214F0", VA = "0x186722AF0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC200", Offset = "0x4ECAC00", VA = "0x184ECC200", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public WYBZIETUIXQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class HSNKWXYGIQT<a> : ANBWEBDMULJ<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC4A0", Offset = "0x4ECAEA0", VA = "0x184ECC4A0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC1C0", Offset = "0x4ECABC0", VA = "0x184ECC1C0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC450", Offset = "0x4ECAE50", VA = "0x184ECC450", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC200", Offset = "0x4ECAC00", VA = "0x184ECC200", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public HSNKWXYGIQT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class XKPCRNWROQS<a> : ANBWEBDMULJ<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF030", Offset = "0x3DEDA30", VA = "0x183DEF030", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEC30", Offset = "0x3DED630", VA = "0x183DEEC30", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEEC0", Offset = "0x3DED8C0", VA = "0x183DEEEC0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEC70", Offset = "0x3DED670", VA = "0x183DEEC70", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public XKPCRNWROQS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class ENQPUAJCQAR<a> : ANBWEBDMULJ<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF030", Offset = "0x3DEDA30", VA = "0x183DEF030", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEC30", Offset = "0x3DED630", VA = "0x183DEEC30", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x46D1500", Offset = "0x46CFF00", VA = "0x1846D1500", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEC70", Offset = "0x3DED670", VA = "0x183DEEC70", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public ENQPUAJCQAR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class ZDIUIDPZYOE<a> : ANBWEBDMULJ<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3E3BD30", Offset = "0x3E3A730", VA = "0x183E3BD30", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x3E3BBA0", Offset = "0x3E3A5A0", VA = "0x183E3BBA0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x3E3BCE0", Offset = "0x3E3A6E0", VA = "0x183E3BCE0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3E15CC0", Offset = "0x3E146C0", VA = "0x183E15CC0", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public ZDIUIDPZYOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class IXHHWYZFACR<a> : ANBWEBDMULJ<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x506C750", Offset = "0x506B150", VA = "0x18506C750", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x506C4A0", Offset = "0x506AEA0", VA = "0x18506C4A0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x506C4E0", Offset = "0x506AEE0", VA = "0x18506C4E0", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x4ECC200", Offset = "0x4ECAC00", VA = "0x184ECC200", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public IXHHWYZFACR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class MSJNIRWHOWM<a> : ANBWEBDMULJ<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x58868B0", Offset = "0x58852B0", VA = "0x1858868B0", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x5886720", Offset = "0x5885120", VA = "0x185886720", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x5886760", Offset = "0x5885160", VA = "0x185886760", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEC70", Offset = "0x3DED670", VA = "0x183DEEC70", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF0A0", Offset = "0x3DEDAA0", VA = "0x183DEF0A0")]
			public MSJNIRWHOWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class JHQNVLNQKCI<a> : VJDLTLUMZIM<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5169C00", Offset = "0x5168600", VA = "0x185169C00", Slot = "12")]
			protected override void BQRGDPAWSQE(DAKXRRCCFEN a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5169C30", Offset = "0x5168630", VA = "0x185169C30", Slot = "11")]
			protected override void QSYSNZBOGRT(TADVJBOQRIF a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5169C60", Offset = "0x5168660", VA = "0x185169C60")]
			public JHQNVLNQKCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class PJHDTNUMJHW<a> : VJDLTLUMZIM<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5BDEC30", Offset = "0x5BDD630", VA = "0x185BDEC30", Slot = "12")]
			protected override void BQRGDPAWSQE(DAKXRRCCFEN a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5BDEC60", Offset = "0x5BDD660", VA = "0x185BDEC60", Slot = "11")]
			protected override void QSYSNZBOGRT(TADVJBOQRIF a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5169C60", Offset = "0x5168660", VA = "0x185169C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x53FC7E0", Offset = "0x53FB1E0", VA = "0x1853FC7E0")]
			public APDPJAYQYGZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x53FC730", Offset = "0x53FB130", VA = "0x1853FC730", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x53FC1D0", Offset = "0x53FABD0", VA = "0x1853FC1D0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x53FC490", Offset = "0x53FAE90", VA = "0x1853FC490", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x53FC330", Offset = "0x53FAD30", VA = "0x1853FC330", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4CF61B0", Offset = "0x4CF4BB0", VA = "0x184CF61B0")]
			public FAQCWGMUQXJ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x4CF5F80", Offset = "0x4CF4980", VA = "0x184CF5F80", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x4CF5DA0", Offset = "0x4CF47A0", VA = "0x184CF5DA0", Slot = "6")]
			public override void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x4CF5F30", Offset = "0x4CF4930", VA = "0x184CF5F30", Slot = "7")]
			public override void XBSLJPLYEHO(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x4CF5F30", Offset = "0x4CF4930", VA = "0x184CF5F30", Slot = "8")]
			public override void QLLFCTUOQBF(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x4CF5D50", Offset = "0x4CF4750", VA = "0x184CF5D50", Slot = "9")]
			public override void QQJXUNEPPNJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x4CF5D50", Offset = "0x4CF4750", VA = "0x184CF5D50", Slot = "10")]
			public override void BCZTVSTQJGC(a a, DAKXRRCCFEN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class IPXMFRNHWZC<a> : FAQCWGMUQXJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x5067DE0", Offset = "0x50667E0", VA = "0x185067DE0")]
			public IPXMFRNHWZC(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x5067C10", Offset = "0x5066610", VA = "0x185067C10", Slot = "5")]
			public override void ZBJHAFIXLBJ(a a, TADVJBOQRIF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x5067BA0", Offset = "0x50665A0", VA = "0x185067BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E39350", Offset = "0x4E37D50", VA = "0x184E39350")]
			public GHRILXXDTZM(List<UPXKHPVYLWO<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4E38E90", Offset = "0x4E37890", VA = "0x184E38E90")]
			public void DKMXHPDZVPU(a a, DAKXRRCCFEN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4E392A0", Offset = "0x4E37CA0", VA = "0x184E392A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75CC4C0", Offset = "0x75CAEC0", VA = "0x1875CC4C0")]
		public YGWXJDEJWSO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C015B0", Offset = "0x3BFFFB0", VA = "0x183C015B0")]
		private GHRILXXDTZM<d> DBDYSBGZTDZ<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C023F0", Offset = "0x3C00DF0", VA = "0x183C023F0")]
		public void JIBLBJTHOBM<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C02330", Offset = "0x3C00D30", VA = "0x183C02330")]
		public bool Deserialize<T>(TADVJBOQRIF reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C02430", Offset = "0x3C00E30", VA = "0x183C02430")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x75CBDE0", Offset = "0x75CA7E0", VA = "0x1875CBDE0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int BIBYNZPQUGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x75CB840", Offset = "0x75CA240", VA = "0x1875CB840")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x75CB5E0", Offset = "0x75C9FE0", VA = "0x1875CB5E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode FZFJHADPKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x75CB0B0", Offset = "0x75C9AB0", VA = "0x1875CB0B0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x75CB540", Offset = "0x75C9F40", VA = "0x1875CB540")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int QTUHVBXGDPX
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x75CB510", Offset = "0x75C9F10", VA = "0x1875CB510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint EPENFUZGJBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x75CB110", Offset = "0x75C9B10", VA = "0x1875CB110")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? SJDHFPLFTKT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x75CBBF0", Offset = "0x75CA5F0", VA = "0x1875CBBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? RKDARNZYOFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x75CB0E0", Offset = "0x75C9AE0", VA = "0x1875CB0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? XRSMTEDCQMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x75CBEC0", Offset = "0x75CA8C0", VA = "0x1875CBEC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x75CB680", Offset = "0x75CA080", VA = "0x1875CB680")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ROKWYWKGJFR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x75CC110", Offset = "0x75CAB10", VA = "0x1875CC110")]
		public XURPEPDNBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x75CC420", Offset = "0x75CAE20", VA = "0x1875CC420")]
		internal XURPEPDNBMD(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x75CB170", Offset = "0x75C9B70", VA = "0x1875CB170")]
		public static XURPEPDNBMD ECDARFHPNCT(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x75CB870", Offset = "0x75CA270", VA = "0x1875CB870")]
		internal void SYTGTACIVXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x75CBEF0", Offset = "0x75CA8F0", VA = "0x1875CBEF0")]
		private void ZURCPOGTEAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x75CB340", Offset = "0x75C9D40", VA = "0x1875CB340")]
		private DateTime? GBYQIPBFKFI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x75CBC20", Offset = "0x75CA620", VA = "0x1875CBC20")]
		private void UTOGFHYERUC(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x75CBE10", Offset = "0x75CA810", VA = "0x1875CBE10")]
		private ulong VXGFSHKNWUC(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x75CB280", Offset = "0x75C9C80", VA = "0x1875CB280")]
		private void FJKXTVVZGTA(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x75CB620", Offset = "0x75CA020", VA = "0x1875CB620")]
		private uint MOSKSNPBDUJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x74842A0", Offset = "0x7482CA0", VA = "0x1874842A0")]
		private static uint JGSJRRGBKII(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x75CB580", Offset = "0x75C9F80", VA = "0x1875CB580")]
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
			[Cpp2IlInjected.Address(RVA = "0x75CA680", Offset = "0x75C9080", VA = "0x1875CA680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x75CA590", Offset = "0x75C8F90", VA = "0x1875CA590")]
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
			[Cpp2IlInjected.Address(RVA = "0x75CAE30", Offset = "0x75C9830", VA = "0x1875CAE30", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int DVTSBMXKWWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x75CAF40", Offset = "0x75C9940", VA = "0x1875CAF40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint IONQBTPGGUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x75CA7F0", Offset = "0x75C91F0", VA = "0x1875CA7F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily MXECROWUPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2FFE020", Offset = "0x2FFCA20", VA = "0x182FFE020", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x75CAF60", Offset = "0x75C9960", VA = "0x1875CAF60")]
		public XGYXWCQEKSG(AddressFamily a, IKISLUNONDT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x75CA810", Offset = "0x75C9210", VA = "0x1875CA810", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x75CADF0", Offset = "0x75C97F0", VA = "0x1875CADF0", Slot = "9")]
		public int DOAMKFHANOU(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x75CAE50", Offset = "0x75C9850", VA = "0x1875CAE50", Slot = "10")]
		public int XWWWSJQOMJW(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x75CADD0", Offset = "0x75C97D0", VA = "0x1875CADD0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C89B0", Offset = "0x75C73B0", VA = "0x1875C89B0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x75C8A50", Offset = "0x75C7450", VA = "0x1875C8A50")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x75C88C0", Offset = "0x75C72C0", VA = "0x1875C88C0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x75C8900", Offset = "0x75C7300", VA = "0x1875C8900", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		internal void PVCFPUEUCUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		internal void DFRTDLDDWDS(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28F3770", Offset = "0x28F2170", VA = "0x1828F3770")]
		public DCFFNMGLQVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x75B8CD0", Offset = "0x75B76D0", VA = "0x1875B8CD0")]
		public void JREYKAJHNTT(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x75B8BF0", Offset = "0x75B75F0", VA = "0x1875B8BF0")]
		public void FDZEVQUCYLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x75B8E80", Offset = "0x75B7880", VA = "0x1875B8E80", Slot = "4")]
		public override void QKXXSXQGLJL(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x75B88F0", Offset = "0x75B72F0", VA = "0x1875B88F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x75CC890", Offset = "0x75CB290", VA = "0x1875CC890")]
			[BurstDiscard]
			private static void SEPJJVIVUGU(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x75CCA20", Offset = "0x75CB420", VA = "0x1875CCA20")]
			private static IntPtr XCHCCHVYGKC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x75CC650", Offset = "0x75CB050", VA = "0x1875CC650")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C99A0", Offset = "0x75C83A0", VA = "0x1875C99A0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x75C9A20", Offset = "0x75C8420", VA = "0x1875C9A20")]
		private uint TQXNYCIGXCB(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x75B4CF0", Offset = "0x75B36F0", VA = "0x1875B4CF0")]
		private void TFIFXGVDZKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x75B4DA0", Offset = "0x75B37A0", VA = "0x1875B4DA0")]
		private void WFVZNTLPPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x75B4C60", Offset = "0x75B3660", VA = "0x1875B4C60")]
		private void KJJEJJEHOOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x75B4FB0", Offset = "0x75B39B0", VA = "0x1875B4FB0")]
		private void WIWXAKMNFSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x75C9AC0", Offset = "0x75C84C0", VA = "0x1875C9AC0")]
		private void VMJOUPAUVLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x75C9410", Offset = "0x75C7E10", VA = "0x1875C9410")]
		private unsafe void BHODDBXJGNX(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x75C9830", Offset = "0x75C8230", VA = "0x1875C9830")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void GXSIHCPMQEA([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x75C9840", Offset = "0x75C8240", VA = "0x1875C9840")]
		public static void GXSIHCPMQEA(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x75C98F0", Offset = "0x75C82F0", VA = "0x1875C98F0")]
		public static void NPUVGSZMMJK(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x75C9A50", Offset = "0x75C8450", VA = "0x1875C9A50")]
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
	[Cpp2IlInjected.Address(RVA = "0x75CC610", Offset = "0x75CB010", VA = "0x1875CC610")]
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
