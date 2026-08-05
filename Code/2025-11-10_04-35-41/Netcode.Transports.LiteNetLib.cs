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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, XJKZQZVJOQY
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
		private NetworkManager IDSGGAKVKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool HIQLHODDSKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, OKUEOWKFYRD> APGHHKNSPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ANMAVLVKKFG AMJWYTZXUCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch DCUBQBEKTFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] HRGDJKSODCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType LKHHQXFQJPK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int BLGMDDWLHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x74703C0", Offset = "0x746F7C0", VA = "0x1874703C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7470370", Offset = "0x746F770", VA = "0x187470370", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x746F7C0", Offset = "0x746EBC0", VA = "0x18746F7C0")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x746F7A0", Offset = "0x746EBA0", VA = "0x18746F7A0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x746F470", Offset = "0x746E870", VA = "0x18746F470")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7470280", Offset = "0x746F680", VA = "0x187470280")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x746F8D0", Offset = "0x746ECD0", VA = "0x18746F8D0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x746F560", Offset = "0x746E960", VA = "0x18746F560", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x746FBA0", Offset = "0x746EFA0", VA = "0x18746FBA0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x746FF30", Offset = "0x746F330", VA = "0x18746FF30", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x746EE80", Offset = "0x746E280", VA = "0x18746EE80", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x746ED90", Offset = "0x746E190", VA = "0x18746ED90", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x746F0A0", Offset = "0x746E4A0", VA = "0x18746F0A0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x746FB30", Offset = "0x746EF30", VA = "0x18746FB30", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x746F210", Offset = "0x746E610", VA = "0x18746F210", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7470150", Offset = "0x746F550", VA = "0x187470150")]
		private DeliveryMethod TENTCTVREOZ(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x746EFE0", Offset = "0x746E3E0", VA = "0x18746EFE0", Slot = "16")]
		private void GOOSCILRJVA(OKUEOWKFYRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x746ECC0", Offset = "0x746E0C0", VA = "0x18746ECC0", Slot = "17")]
		private void CEWIDCZEMLK(OKUEOWKFYRD a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "18")]
		private void NULQLGYUSNR(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x746F5A0", Offset = "0x746E9A0", VA = "0x18746F5A0", Slot = "19")]
		private void RCZRIZFPXUE(OKUEOWKFYRD a, OJXVQXREABE b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x746F140", Offset = "0x746E540", VA = "0x18746F140")]
		private void ILISNGRCUDR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "20")]
		private void APRBZMXLAJE(IPEndPoint a, OJXVQXREABE b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "21")]
		private void ZSNNVTUZLHQ(OKUEOWKFYRD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7470220", Offset = "0x746F620", VA = "0x187470220", Slot = "22")]
		private void UIJCTFKMLUA(AHYWKVZUFJJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x746EFB0", Offset = "0x746E3B0", VA = "0x18746EFB0")]
		private ulong ENOBFKESHWX(OKUEOWKFYRD a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x746EF90", Offset = "0x746E390", VA = "0x18746EF90")]
		private ulong ENOBFKESHWX(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x746F450", Offset = "0x746E850", VA = "0x18746F450")]
		private static int KTVARHOEGNG(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74702A0", Offset = "0x746F6A0", VA = "0x1874702A0")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x746F420", Offset = "0x746E820", VA = "0x18746F420")]
		[CompilerGenerated]
		private void PZFPTQXVGHS(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x746F420", Offset = "0x746E820", VA = "0x18746F420")]
		[CompilerGenerated]
		private void KEUDUCACGEJ(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class YODCEJDTCTM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly OKUEOWKFYRD JRMVEZFYUHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<QCMCCDULBTT> ZYTILBXMMUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int RKGDPJLGCKO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FMSSZEKHMXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x747A390", Offset = "0x7479790", VA = "0x18747A390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x747A3E0", Offset = "0x74797E0", VA = "0x18747A3E0")]
		protected YODCEJDTCTM(OKUEOWKFYRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x747A270", Offset = "0x7479670", VA = "0x18747A270")]
		public void PFONZCPFKTV(QCMCCDULBTT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x747A310", Offset = "0x7479710", VA = "0x18747A310")]
		protected void VONXREBXRIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x747A2D0", Offset = "0x74796D0", VA = "0x18747A2D0")]
		public bool SPRGATRICQW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool HVMVMBLQWAW();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool VPBHZMLYTHN(QCMCCDULBTT a);
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
	public class AHYWKVZUFJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly ANMAVLVKKFG VROUMNCZEFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int QBHBMQPVWFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal OHCEFHLTRTA PXWSJDFJHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint MEFIDCOJORD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult PKTGOURPEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7463B70", Offset = "0x7462F70", VA = "0x187463B70")]
		internal void PYXKDCNAOOE(OHCEFHLTRTA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7463B40", Offset = "0x7462F40", VA = "0x187463B40")]
		private bool JVXYKTFRYKW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7463BD0", Offset = "0x7462FD0", VA = "0x187463BD0")]
		internal AHYWKVZUFJJ(IPEndPoint a, OHCEFHLTRTA b, ANMAVLVKKFG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7463AE0", Offset = "0x7462EE0", VA = "0x187463AE0")]
		public OKUEOWKFYRD Accept()
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
		public OJXVQXREABE AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface XJKZQZVJOQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CLVOURBUBVE(OKUEOWKFYRD a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MMOZVEHJASY(OKUEOWKFYRD a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EXWBZLBHVWH(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RJLCUQAORGU(OKUEOWKFYRD a, OJXVQXREABE b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OWAERFTBSMC(IPEndPoint a, OJXVQXREABE b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CNXCTOAUXKO(OKUEOWKFYRD a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UCIZFGBZKQQ(AHYWKVZUFJJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface RUVKAOPLHZB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HXOKDXEGXLA(OKUEOWKFYRD a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface TJRWSEEVWQH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HXUCHKWDWNC(EXJIKDFEPOU a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BJMTXJHAKZP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TMEVCXYHYGH(OKUEOWKFYRD a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class OHCEFHLTRTA
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int OBCVBQMPARU = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long VLXEZHSVPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte ONHZUINTTID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] YZLAEJNIEGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly NYFAHCSWMFI VQVHWHVOHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int SEIUHHEBKWH;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7471680", Offset = "0x7470A80", VA = "0x187471680")]
		private OHCEFHLTRTA(long a, byte b, int c, byte[] d, NYFAHCSWMFI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7471650", Offset = "0x7470A50", VA = "0x187471650")]
		public static int XOJNOIYDYFN(QCMCCDULBTT a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7471280", Offset = "0x7470680", VA = "0x187471280")]
		public static OHCEFHLTRTA BSANSRIORTI(QCMCCDULBTT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7471470", Offset = "0x7470870", VA = "0x187471470")]
		public static QCMCCDULBTT NQBKGQVBKCQ(QIDRNUEFOPY a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class IFWHTXJPEGR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long VLXEZHSVPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte ONHZUINTTID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int SEIUHHEBKWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool HKIKTRFDHGI;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x746E7E0", Offset = "0x746DBE0", VA = "0x18746E7E0")]
		private IFWHTXJPEGR(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x746E4F0", Offset = "0x746D8F0", VA = "0x18746E4F0")]
		public static IFWHTXJPEGR BSANSRIORTI(QCMCCDULBTT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x746E6F0", Offset = "0x746DAF0", VA = "0x18746E6F0")]
		public static QCMCCDULBTT NQBKGQVBKCQ(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x746E5F0", Offset = "0x746D9F0", VA = "0x18746E5F0")]
		public static QCMCCDULBTT LHLVNYIYZHE(OKUEOWKFYRD a)
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
	public interface QPGREYVKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void REJXIJBBFRB(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SCUTSQKJVJX(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class ZRCTRVQMNCX
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
		private class KXIOPNXSQRN
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint KMJVOKEBETN
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string SPHJVOAGGSP
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public KXIOPNXSQRN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class NHEAENRAHWN
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint KMJVOKEBETN
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint EEDJUZZWFQZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string SPHJVOAGGSP
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public NHEAENRAHWN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class HVXLQGEJGDR
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string SPHJVOAGGSP
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool PJLEBHHGDSZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public HVXLQGEJGDR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly ANMAVLVKKFG ROYELQSZQLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> FZJKONYNWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> LRSISMJBRKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly NYFAHCSWMFI IXALWSAXKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly QIDRNUEFOPY PEIFARTRIAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DXSJHEYNHHV YRWVCXSATAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private QPGREYVKDKM UNBRSZKLTFM;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int GLOUOMLEMTX = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool RJCWGCYANRI;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x747AA70", Offset = "0x7479E70", VA = "0x18747AA70")]
		internal ZRCTRVQMNCX(ANMAVLVKKFG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x747A760", Offset = "0x7479B60", VA = "0x18747A760")]
		internal void ROBOWZORCPE(IPEndPoint a, QCMCCDULBTT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B010", Offset = "0x3C2A410", VA = "0x183C2B010")]
		private void SPZOFEDLTUI<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x747A5D0", Offset = "0x74799D0", VA = "0x18747A5D0")]
		private void REJXIJBBFRB(KXIOPNXSQRN a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x747A470", Offset = "0x7479870", VA = "0x18747A470")]
		private void DESFJNWGIRT(NHEAENRAHWN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x747A8E0", Offset = "0x7479CE0", VA = "0x18747A8E0")]
		private void UKSKTKSKIEK(HVXLQGEJGDR a, IPEndPoint b)
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
	public static class BSVZCOCPSUW
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] VZDVNKKTBDR;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int WRLEDWHLTJL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int ZXCWQPQHCIY;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x746E830", Offset = "0x746DC30", VA = "0x18746E830")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x746E830", Offset = "0x746DC30", VA = "0x18746E830")]
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
	public interface ZEYHBRBGXJW
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PAYHNDGSYXG(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class LMNZWLPLEYE
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static ZEYHBRBGXJW KJPPRXDQMSO;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object DCYGUSMQOSG;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x746E8D0", Offset = "0x746DCD0", VA = "0x18746E8D0")]
		private static void DLOMCYFDZDL(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x746EB00", Offset = "0x746DF00", VA = "0x18746EB00")]
		internal static void IQHTSNTKFCV(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x746EBC0", Offset = "0x746DFC0", VA = "0x18746EBC0")]
		internal static void URCXWOFTPHR(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x746EB60", Offset = "0x746DF60", VA = "0x18746EB60")]
		internal static void NIORVVCFYXL(string a, params object[] args)
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
	public sealed class OJXVQXREABE : NYFAHCSWMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private QCMCCDULBTT RXBAOIIXHMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly ANMAVLVKKFG ESTZGFFYMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly RHEGAYDNTCD VLBLDYYJLFC;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7471810", Offset = "0x7470C10", VA = "0x187471810")]
		internal OJXVQXREABE(ANMAVLVKKFG a, RHEGAYDNTCD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74716F0", Offset = "0x7470AF0", VA = "0x1874716F0")]
		internal void PGKBTWHUICH(QCMCCDULBTT a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7471760", Offset = "0x7470B60", VA = "0x187471760")]
		internal void SRIWBVVIBTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74717E0", Offset = "0x7470BE0", VA = "0x1874717E0")]
		public void VHYECHRORIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class RHEGAYDNTCD
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
		public RHEGAYDNTCD PSAZZCEBCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType IRYCWFFEKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OKUEOWKFYRD JRMVEZFYUHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint MEFIDCOJORD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object WRVCMJHHELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int TGHYFDNOXKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError HGPOMNJSTLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason LZIGNMGKFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AHYWKVZUFJJ AHYWKVZUFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod DPGRFCPOGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte TQXLHRSJFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly OJXVQXREABE HMFSIDLTCDD;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7477290", Offset = "0x7476690", VA = "0x187477290")]
		public RHEGAYDNTCD(ANMAVLVKKFG a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ANMAVLVKKFG : IEnumerable<OKUEOWKFYRD>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class VLZFKONGNNL : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x74784E0", Offset = "0x74778E0", VA = "0x1874784E0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7478550", Offset = "0x7477950", VA = "0x187478550", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public VLZFKONGNNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<OKUEOWKFYRD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly OKUEOWKFYRD _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private OKUEOWKFYRD _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public OKUEOWKFYRD Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1A36B60", Offset = "0x1A35F60", VA = "0x181A36B60")]
			public NetPeerEnumerator(OKUEOWKFYRD p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x74711F0", Offset = "0x74705F0", VA = "0x1874711F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7471240", Offset = "0x7470640", VA = "0x187471240", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread BBBRBVTZBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool QMUKGQSUBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool YPCSJYLPIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private USWIWWYPYHL VBZIYMHLFVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent BAKMBIQSZBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<RHEGAYDNTCD> TYPJCMUZWHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<RHEGAYDNTCD> TVWYYIKXFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private RHEGAYDNTCD FAOILVDJXUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly XJKZQZVJOQY NEXIMDXQLFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly RUVKAOPLHZB YNXLCKKUWFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly TJRWSEEVWQH NIMCDZVVWUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly BJMTXJHAKZP NPLRYJAHJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, OKUEOWKFYRD> DHKVTPLXDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, AHYWKVZUFJJ> HHNAFQWYZMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, STLGIMZQAEV> GPVFVBFXSBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim OOLHQFXBELR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private OKUEOWKFYRD VJBTZPFSVUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int DHISIUWFSZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<OKUEOWKFYRD> WGNIQPASGFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private OKUEOWKFYRD[] LWNUPLINZHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly AZWEWWDCEDI CORONXNUYKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int EWGWHMDTLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> SETQYDOPTHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte XJYKWCPILSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object LTSZBJNWMUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool QXBJLEHLNZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool OJKCISDYAFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int JRGDJXBBTKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int QFDXEUCVCVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int JOKKKZCFDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int PLQFBGPKSED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool GRJEUYJOGPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool OCYSCPFQJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int TGTJPXYFSJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int YDCMQBKEIIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int WTCSFGFPZKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool RJCWGCYANRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool JZSCXFQVQJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool YQEHOHDYIPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool DPAYLJYYVXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int VQVZEGJMNAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int ASJJTVCGKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool WAMRQHRPFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly VSRZTEWTIOK CTXDHRUHERH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool TBAQBJSAHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly ZRCTRVQMNCX ZRCTRVQMNCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool REQJSIYIYMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode DCUKDDQKROA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int DRJUBLPQXAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool CFCBNEKTRLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool ROEJISRWGHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool KQYJSZTGSTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool ICIDQSYWBZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private QCMCCDULBTT HJPZWAEOOHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int IIAYQJGEYOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object LPHOPNQZJDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private QCMCCDULBTT UUALNDTJZRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int WXKRHHDYJDR;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int LPBAIQKHDPL = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int DHVDXWQQJNM = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private ALHDURJKPBG ASPTKCZOGHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private ALHDURJKPBG ASFFPPLTNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread OCXTXKRCOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread OCNGCXDHVEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint KWKSYGVBBVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint KWAFDTHGIYM;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] SHTZFJKZQSC;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] NGMNHRIVSIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> GUJGDWHQLCT;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress CQJDILLIPPC;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool OCSWSXQOVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int XFNADRHJUUE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool XPGDQQHZTAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB70D80", Offset = "0xB70180", VA = "0x180B70D80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB70A10", Offset = "0xB6FE10", VA = "0x180B70A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int IJTMSXRVTQC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1E9C770", Offset = "0x1E9BB70", VA = "0x181E9C770")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2016DB0", Offset = "0x20161B0", VA = "0x182016DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte IBFKTAKCXAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB13BD0", Offset = "0xB12FD0", VA = "0x180B13BD0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int CVBJXTWUJUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x746ABB0", Offset = "0x7469FB0", VA = "0x18746ABB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short GKIFQBWNBMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7463F90", Offset = "0x7463390", VA = "0x187463F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OKUEOWKFYRD.OnUpdatedMtuDelegate NZEUZSDIAHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7465D60", Offset = "0x7465160", VA = "0x187465D60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x746AC40", Offset = "0x746A040", VA = "0x18746AC40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x74696B0", Offset = "0x7468AB0", VA = "0x1874696B0")]
		public void SUQKGIWCEUI(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7469560", Offset = "0x7468960", VA = "0x187469560")]
		public void SPHSKHVJVPP(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7465FC0", Offset = "0x74653C0", VA = "0x187465FC0")]
		private bool GXOREETZRCF(IPEndPoint a, [Out] OKUEOWKFYRD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x74663A0", Offset = "0x74657A0", VA = "0x1874663A0")]
		private void JXWJHIAPAMR(OKUEOWKFYRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x746AB50", Offset = "0x7469F50", VA = "0x18746AB50")]
		private void VSERRPHNQTU(OKUEOWKFYRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x746A720", Offset = "0x7469B20", VA = "0x18746A720")]
		private void TLNSQAITWKT(OKUEOWKFYRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x746B3E0", Offset = "0x746A7E0", VA = "0x18746B3E0")]
		public ANMAVLVKKFG(XJKZQZVJOQY a, [Optional] AZWEWWDCEDI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x74684D0", Offset = "0x74678D0", VA = "0x1874684D0")]
		internal void NIHOCYWNIMH(OKUEOWKFYRD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x746ABD0", Offset = "0x7469FD0", VA = "0x18746ABD0")]
		internal void WSDVGAPRERV(OKUEOWKFYRD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7468BA0", Offset = "0x7467FA0", VA = "0x187468BA0")]
		internal void OPNVGNQBBUD(OKUEOWKFYRD a, DisconnectReason b, SocketError c, QCMCCDULBTT d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7465570", Offset = "0x7464970", VA = "0x187465570")]
		private void EXAJBCRWWPG(OKUEOWKFYRD a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, QCMCCDULBTT h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7465990", Offset = "0x7464D90", VA = "0x187465990")]
		private void FTCLDDWCAAG(RHEGAYDNTCD.EType a, [Optional] OKUEOWKFYRD b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] AHYWKVZUFJJ g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] QCMCCDULBTT j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7464050", Offset = "0x7463450", VA = "0x187464050")]
		private void BXOWQNFUJBT(RHEGAYDNTCD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x746A9E0", Offset = "0x7469DE0", VA = "0x18746A9E0")]
		internal void TYDQOMSVGVH(RHEGAYDNTCD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7465050", Offset = "0x7464450", VA = "0x187465050")]
		private void EBQJWCAHYYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7468BE0", Offset = "0x7467FE0", VA = "0x187468BE0")]
		private void QFTEVCXZSDH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x746ACF0", Offset = "0x746A0F0", VA = "0x18746ACF0")]
		internal OKUEOWKFYRD YSAYUUFBHTQ(AHYWKVZUFJJ a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7463F10", Offset = "0x7463310", VA = "0x187463F10")]
		private int BSMJVHOQFUO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7468520", Offset = "0x7467920", VA = "0x187468520")]
		private void NOZXWVGKOUI(IPEndPoint a, OKUEOWKFYRD b, OHCEFHLTRTA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74671D0", Offset = "0x74665D0", VA = "0x1874671D0")]
		private void MRGPKIBOVAR(QCMCCDULBTT a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7469290", Offset = "0x7468690", VA = "0x187469290")]
		internal void REBQADAQLBH(QCMCCDULBTT a, DeliveryMethod b, byte c, int d, OKUEOWKFYRD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x746A060", Offset = "0x7469460", VA = "0x18746A060")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x74698D0", Offset = "0x7468CD0", VA = "0x1874698D0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x746A0D0", Offset = "0x74694D0", VA = "0x18746A0D0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7465E10", Offset = "0x7465210", VA = "0x187465E10")]
		public void GFPIWIBBQRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7464F70", Offset = "0x7464370", VA = "0x187464F70")]
		public OKUEOWKFYRD Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7464AC0", Offset = "0x7463EC0", VA = "0x187464AC0")]
		public OKUEOWKFYRD Connect(string address, int port, QIDRNUEFOPY connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7464BA0", Offset = "0x7463FA0", VA = "0x187464BA0")]
		public OKUEOWKFYRD Connect(IPEndPoint target, QIDRNUEFOPY connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x746A4B0", Offset = "0x74698B0", VA = "0x18746A4B0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x746A150", Offset = "0x7469550", VA = "0x18746A150")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74653B0", Offset = "0x74647B0", VA = "0x1874653B0")]
		public void EMXWZNRHJQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7465460", Offset = "0x7464860", VA = "0x187465460")]
		public void EMXWZNRHJQH(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7465530", Offset = "0x7464930", VA = "0x187465530")]
		public void EXAJBCRWWPG(OKUEOWKFYRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7465950", Offset = "0x7464D50", VA = "0x187465950")]
		public void EXAJBCRWWPG(OKUEOWKFYRD a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7468B10", Offset = "0x7467F10", VA = "0x187468B10", Slot = "4")]
		private IEnumerator<OKUEOWKFYRD> OKMUUYZUJCT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7464A30", Offset = "0x7463E30", VA = "0x187464A30", Slot = "5")]
		private IEnumerator CQMSCGRISCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7466140", Offset = "0x7465540", VA = "0x187466140")]
		private QCMCCDULBTT HVQGWPBOLDX(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7466060", Offset = "0x7465460", VA = "0x187466060")]
		private QCMCCDULBTT HVQGWPBOLDX(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74647F0", Offset = "0x7463BF0", VA = "0x1874647F0")]
		internal QCMCCDULBTT CAJHOZBRSXS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x746A4C0", Offset = "0x74698C0", VA = "0x18746A4C0")]
		internal void TAKQREXTPMF(QCMCCDULBTT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x746B320", Offset = "0x746A720", VA = "0x18746B320")]
		static ANMAVLVKKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB70D80", Offset = "0xB70180", VA = "0x180B70D80")]
		private bool WMTAQBKUULG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7467070", Offset = "0x7466470", VA = "0x187467070")]
		private void MJZMPSOYTRU(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x74689C0", Offset = "0x7467DC0", VA = "0x1874689C0")]
		private void OHQKTLSPOIJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7466ED0", Offset = "0x74662D0", VA = "0x187466ED0")]
		private bool LONALJQSUET(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x746AC20", Offset = "0x746A020", VA = "0x18746AC20")]
		private void WUYTWEFFNNO(USWIWWYPYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7463C40", Offset = "0x7463040", VA = "0x187463C40")]
		private void ANYZHWJINLL(ALHDURJKPBG a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7468F10", Offset = "0x7468310", VA = "0x187468F10")]
		private void RAZZSDYIXLV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74698F0", Offset = "0x7468CF0", VA = "0x1874698F0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x746AAF0", Offset = "0x7469EF0", VA = "0x18746AAF0")]
		internal int UBRUAERSMQU(QCMCCDULBTT a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7466E90", Offset = "0x7466290", VA = "0x187466E90")]
		internal int KZCTDPCNBDQ(QCMCCDULBTT a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74666C0", Offset = "0x7465AC0", VA = "0x1874666C0")]
		internal int KZCTDPCNBDQ(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7466220", Offset = "0x7465620", VA = "0x187466220")]
		internal void IWQDPMDONYP(bool a)
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
	internal sealed class QCMCCDULBTT
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int NTAKGCQHJYO;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] JSOMFRUUZVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] SRKVBRXBKIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int CYCMXIALNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object WRVCMJHHELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public QCMCCDULBTT PSAZZCEBCFB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty FPQWNIOTCZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7475BC0", Offset = "0x7474FC0", VA = "0x187475BC0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7475E30", Offset = "0x7475230", VA = "0x187475E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte ONHZUINTTID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7475B40", Offset = "0x7474F40", VA = "0x187475B40")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7475C90", Offset = "0x7475090", VA = "0x187475C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort KCXLGHSNEHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7476000", Offset = "0x7475400", VA = "0x187476000")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7475B00", Offset = "0x7474F00", VA = "0x187475B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DDJFQDEKCLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7475B70", Offset = "0x7474F70", VA = "0x187475B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte IJKDOPYAZHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7475C60", Offset = "0x7475060", VA = "0x187475C60")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7475FD0", Offset = "0x74753D0", VA = "0x187475FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort REIWVJGNACX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7475E10", Offset = "0x7475210", VA = "0x187475E10")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7475C20", Offset = "0x7475020", VA = "0x187475C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort ZYXGBCMDZCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7475BA0", Offset = "0x7474FA0", VA = "0x187475BA0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7475F70", Offset = "0x7475370", VA = "0x187475F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort ECYWIVFREUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7475FB0", Offset = "0x74753B0", VA = "0x187475FB0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7475CD0", Offset = "0x74750D0", VA = "0x187475CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7476020", Offset = "0x7475420", VA = "0x187476020")]
		static QCMCCDULBTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7475BF0", Offset = "0x7474FF0", VA = "0x187475BF0")]
		public void GWMDQAPFXPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74763E0", Offset = "0x74757E0", VA = "0x1874763E0")]
		public QCMCCDULBTT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74762D0", Offset = "0x74756D0", VA = "0x1874762D0")]
		public QCMCCDULBTT(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7475F00", Offset = "0x7475300", VA = "0x187475F00")]
		public static int RSBPFNQTPTQ(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7475E70", Offset = "0x7475270", VA = "0x187475E70")]
		public int RSBPFNQTPTQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7475D10", Offset = "0x7475110", VA = "0x187475D10")]
		public bool PEFZFZYBECT()
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
	public class OKUEOWKFYRD
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class TFKESLERHPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public QCMCCDULBTT[] OGSARHGNYNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int RFRANRQLQAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int LLKDEKHYOON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte IJKDOPYAZHS;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public TFKESLERHPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int LHOMGGJJGVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int TJZZBLWIBSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int ZHYLGLNOVDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double JHFARRDNFLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int SPNZCWEKHDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int NSPPUIWKUSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int CVEJXTRQQOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch SFZTMLPONCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int INLVXXMPSYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long UBYZWPAFDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object MSCQJIIOUGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal OKUEOWKFYRD XFVEOWFMIVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal OKUEOWKFYRD VTQCFUSLAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<QCMCCDULBTT> GUSBYWZWMUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<YODCEJDTCTM> FPUPOLBTTZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly YODCEJDTCTM[] WYFWQIDOWQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int NOQHLHQYLRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int JJAXHAICVPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool KEVTGWGUXSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int OVZAWAUPBVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int DPQVQPJZAVT;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int CYUNLWXYCRH = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int UHSWCKHTIHU = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object VRGBMBNAWDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int DXEKXZQCIZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, TFKESLERHPN> VFRJXQFDVAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> UZDJYYUJXNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly QCMCCDULBTT QDNENAEBKRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int ISYCTDKHEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int EWHJMHNYCOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint YEWGKYVRHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int WIXQFNWVQSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int JXUGEEDKFZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long KNROQXCFUBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte ZNYDGSNNOSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState EFKDOLEPQXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private QCMCCDULBTT VYAGQXWHYHH;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int SPODKYYAUWD = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int YJVJCNUIHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly QCMCCDULBTT YQOWLCYBSRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly QCMCCDULBTT OLKKPYFXDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly QCMCCDULBTT ICPCJJNVGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly QCMCCDULBTT SPIQTGCIJYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality USVPVMLYBQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly ANMAVLVKKFG ANMAVLVKKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int OQGVUCEGDTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object TTWIYQYWOVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly VSRZTEWTIOK CTXDHRUHERH;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte DXVMFZEMVOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAD1510", Offset = "0xAD0910", VA = "0x180AD1510")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x74728F0", Offset = "0x7471CF0", VA = "0x1874728F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint GFXOXMOCRGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB688E0", Offset = "0xB67CE0", VA = "0x180B688E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState WAOULXEPZVR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1240400", Offset = "0x123F800", VA = "0x181240400")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long SHNMOKFXIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA6AB0", Offset = "0xAA5EB0", VA = "0x180AA6AB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int ECKBVJZGWFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1E9C770", Offset = "0x1E9BB70", VA = "0x181E9C770")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2016DB0", Offset = "0x20161B0", VA = "0x182016DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int TCMOBMIVOUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x74728B0", Offset = "0x7471CB0", VA = "0x1874728B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int THDRYOSDWQL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double OSDKXAREOGU
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x27B2FB0", Offset = "0x27B23B0", VA = "0x1827B2FB0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate NZEUZSDIAHY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7472800", Offset = "0x7471C00", VA = "0x187472800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7474C30", Offset = "0x7474030", VA = "0x187474C30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7475550", Offset = "0x7474950", VA = "0x187475550")]
		internal OKUEOWKFYRD(ANMAVLVKKFG a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7471F10", Offset = "0x7471310", VA = "0x187471F10")]
		internal void FRIXFAUNEUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x74728C0", Offset = "0x7471CC0", VA = "0x1874728C0")]
		internal void IQVZGYRVHYU(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7473610", Offset = "0x7472A10", VA = "0x187473610")]
		internal void SHTIFOGBJTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7475110", Offset = "0x7474510", VA = "0x187475110")]
		private void YURALWPPWPY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7471860", Offset = "0x7470C60", VA = "0x187471860")]
		private void CXALRYSYQLY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7475000", Offset = "0x7474400", VA = "0x187475000")]
		public int YRERDDXWAMA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7474EE0", Offset = "0x74742E0", VA = "0x187474EE0")]
		public int YRERDDXWAMA(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74729A0", Offset = "0x7471DA0", VA = "0x1874729A0")]
		private YODCEJDTCTM LDAIHKRVSVL(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x74751E0", Offset = "0x74745E0", VA = "0x1874751E0")]
		internal OKUEOWKFYRD(ANMAVLVKKFG a, IPEndPoint b, int c, byte d, QIDRNUEFOPY e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7475370", Offset = "0x7474770", VA = "0x187475370")]
		internal OKUEOWKFYRD(ANMAVLVKKFG a, AHYWKVZUFJJ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x74735C0", Offset = "0x74729C0", VA = "0x1874735C0")]
		internal void Reject(OHCEFHLTRTA requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7472520", Offset = "0x7471920", VA = "0x187472520")]
		internal bool GCKJYYGJAZZ(IFWHTXJPEGR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x74736A0", Offset = "0x7472AA0", VA = "0x1874736A0")]
		public void SPZOFEDLTUI(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7471F30", Offset = "0x7471330", VA = "0x187471F30")]
		private void FUZDWGRYBER(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7471E60", Offset = "0x7471260", VA = "0x187471E60")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74718A0", Offset = "0x7470CA0", VA = "0x1874718A0")]
		internal DisconnectResult DCTZWELKROJ(QCMCCDULBTT a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7471EB0", Offset = "0x74712B0", VA = "0x187471EB0")]
		internal void EOQHUHNSTNI(YODCEJDTCTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74736D0", Offset = "0x7472AD0", VA = "0x1874736D0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7473580", Offset = "0x7472980", VA = "0x187473580")]
		private void PGKCBLNHFSL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7472CF0", Offset = "0x74720F0", VA = "0x187472CF0")]
		internal void OJCLRVFPMJF(DeliveryMethod a, QCMCCDULBTT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7471940", Offset = "0x7470D40", VA = "0x187471940")]
		private void DGTXXMMHMJX(QCMCCDULBTT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7473B30", Offset = "0x7472F30", VA = "0x187473B30")]
		private void TVWKPVTFZAB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7472B30", Offset = "0x7471F30", VA = "0x187472B30")]
		internal ConnectRequestResult NOZXWVGKOUI(OHCEFHLTRTA a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7474590", Offset = "0x7473990", VA = "0x187474590")]
		internal void VPBHZMLYTHN(QCMCCDULBTT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x74739E0", Offset = "0x7472DE0", VA = "0x1874739E0")]
		private void TITZMFHMYOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7474CE0", Offset = "0x74740E0", VA = "0x187474CE0")]
		internal void YAPZSZFIGST(QCMCCDULBTT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7473EC0", Offset = "0x74732C0", VA = "0x187473EC0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74725A0", Offset = "0x74719A0", VA = "0x1874725A0")]
		internal void GDHHOCWJZQB(QCMCCDULBTT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class VSRZTEWTIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long LCUIZITYUBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long XBAQIFPQQUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long EOTYEIYKORK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long QNPRCFPFPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long JZFLRFABCUI;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long SWZRUOJRPQX;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long SRTYGGITHIK;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long SHLHQNGOXNX;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long EWSUOMOCTEI;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long HRGGAUVFVID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long ZUPQXZXTQFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long SUKNKLAVDGQ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long MWDVFPMICHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7478830", Offset = "0x7477C30", VA = "0x187478830")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long IJQSRWPDYYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7478880", Offset = "0x7477C80", VA = "0x187478880")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long SZNPDQFTDHV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7478710", Offset = "0x7477B10", VA = "0x187478710")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long CVKXCOQKJWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7478D00", Offset = "0x7478100", VA = "0x187478D00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long MWSGMFHROYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7478760", Offset = "0x7477B60", VA = "0x187478760")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long PLXTQWRRKUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7478700", Offset = "0x7477B00", VA = "0x187478700")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long RRSHSZDJOAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7478720", Offset = "0x7477B20", VA = "0x187478720")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long CZEHBSIOKHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7478BC0", Offset = "0x7477FC0", VA = "0x187478BC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality BEAULWPGZGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double GMCOKVGDMFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7478770", Offset = "0x7477B70", VA = "0x187478770")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7478840", Offset = "0x7477C40", VA = "0x187478840")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7478580", Offset = "0x7477980", VA = "0x187478580")]
		public void AEZMARUXPWW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x74786B0", Offset = "0x7477AB0", VA = "0x1874786B0")]
		public void ETVOWBIBWSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x74785E0", Offset = "0x74779E0", VA = "0x1874785E0")]
		public void CPOMWHNFSUK(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x74787D0", Offset = "0x7477BD0", VA = "0x1874787D0")]
		public void OMUXLEYNPKH(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7478CA0", Offset = "0x74780A0", VA = "0x187478CA0")]
		public void YBACTSWMIZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7478640", Offset = "0x7477A40", VA = "0x187478640")]
		public void EEBVUVFGZUC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7478890", Offset = "0x7477C90", VA = "0x187478890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7478C00", Offset = "0x7478000", VA = "0x187478C00")]
		public void XPNSTQXUKHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public VSRZTEWTIOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class WBAUNALLUOG
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> QCIOTDJYHKX;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7478D40", Offset = "0x7478140", VA = "0x187478D40")]
		public static IPEndPoint WTFPRHXWKXX(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7478F80", Offset = "0x7478380", VA = "0x187478F80")]
		public static IPAddress ZVLOGVIAVXM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7479140", Offset = "0x7478540", VA = "0x187479140")]
		public static IPAddress ZVLOGVIAVXM(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7478D10", Offset = "0x7478110", VA = "0x187478D10")]
		internal static int MMAIPSJCLPE(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3BF65D0", Offset = "0x3BF59D0", VA = "0x183BF65D0")]
		internal static T[] OSUQSIUSMLJ<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class XAZSFHNOTDN : YODCEJDTCTM
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private QCMCCDULBTT _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7475A90", Offset = "0x7474E90", VA = "0x187475A90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7475A00", Offset = "0x7474E00", VA = "0x187475A00")]
			public void DWRZVDJUYSA(QCMCCDULBTT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7475A20", Offset = "0x7474E20", VA = "0x187475A20")]
			public bool FPCHMUCZKBH(long a, OKUEOWKFYRD b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x74759B0", Offset = "0x7474DB0", VA = "0x1874759B0")]
			public bool Clear(OKUEOWKFYRD peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly QCMCCDULBTT HNXXUDZLOSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] CVJVYQRGOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly QCMCCDULBTT[] DLRJGVTZPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] XBYDLOQLOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int CWZUQGHNDWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int SBXFRVQZLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int JJIAVDJYMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int OYYKHIENTCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool HDMXUALLNJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod GZMFUUISHXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool LNRNXPDSLVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int NZODBLUTMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte DPJFNRQVAVU;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int UKLMNXFWZQB
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7479250", Offset = "0x7478650", VA = "0x187479250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x747A0B0", Offset = "0x74794B0", VA = "0x18747A0B0")]
		public XAZSFHNOTDN(OKUEOWKFYRD a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7479D30", Offset = "0x7479130", VA = "0x187479D30")]
		private void ZPSJUFCMESI(QCMCCDULBTT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7479260", Offset = "0x7478660", VA = "0x187479260", Slot = "4")]
		protected override bool HVMVMBLQWAW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7479730", Offset = "0x7478B30", VA = "0x187479730", Slot = "5")]
		public override bool VPBHZMLYTHN(QCMCCDULBTT a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class HFRMOEPLALS : YODCEJDTCTM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int FRTJMTNWPXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort SBXFRVQZLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool DRVBALFYUXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private QCMCCDULBTT UNIXPYENKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly QCMCCDULBTT MZPZZIELIJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool EZCLRTUCOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte DPJFNRQVAVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long NOZPNTWYUOU;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x746DA10", Offset = "0x746CE10", VA = "0x18746DA10")]
		public HFRMOEPLALS(OKUEOWKFYRD a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x746D2D0", Offset = "0x746C6D0", VA = "0x18746D2D0", Slot = "4")]
		protected override bool HVMVMBLQWAW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x746D790", Offset = "0x746CB90", VA = "0x18746D790", Slot = "5")]
		public override bool VPBHZMLYTHN(QCMCCDULBTT a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class EHKAUEJYWBL
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
		[Cpp2IlInjected.Address(RVA = "0x7463500", Offset = "0x7462900", VA = "0x187463500")]
		private static void IGMAVHZTVTA(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x746BDA0", Offset = "0x746B1A0", VA = "0x18746BDA0")]
		private static void IGMAVHZTVTA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x746BD60", Offset = "0x746B160", VA = "0x18746BD60")]
		public static void IGMAVHZTVTA(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x746BE20", Offset = "0x746B220", VA = "0x18746BE20")]
		public static void PSBKLPCBUVP(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x746BE40", Offset = "0x746B240", VA = "0x18746BE40")]
		public static void PSBKLPCBUVP(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x746BD60", Offset = "0x746B160", VA = "0x18746BD60")]
		public static void PSBKLPCBUVP(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x746BD60", Offset = "0x746B160", VA = "0x18746BD60")]
		public static void PSBKLPCBUVP(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x746BDA0", Offset = "0x746B1A0", VA = "0x18746BDA0")]
		public static void PSBKLPCBUVP(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x746BDA0", Offset = "0x746B1A0", VA = "0x18746BDA0")]
		public static void PSBKLPCBUVP(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x746BE10", Offset = "0x746B210", VA = "0x18746BE10")]
		public static void PSBKLPCBUVP(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x746BE10", Offset = "0x746B210", VA = "0x18746BE10")]
		public static void PSBKLPCBUVP(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class NYFAHCSWMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] CHEHRVMCRPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int OMQJCZUIPSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int VCLTTAQCLEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int NTMVCKUBXYM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] SRKVBRXBKIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int RVAUUKOZTRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int KPNVLUPMKUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x74705B0", Offset = "0x746F9B0", VA = "0x1874705B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool RKLUZWHEVJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x271E840", Offset = "0x271DC40", VA = "0x18271E840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int PQHJJRRGJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x74705A0", Offset = "0x746F9A0", VA = "0x1874705A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7470C10", Offset = "0x7470010", VA = "0x187470C10")]
		public void PGKBTWHUICH(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NYFAHCSWMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7470DC0", Offset = "0x74701C0", VA = "0x187470DC0")]
		public NYFAHCSWMFI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7470B80", Offset = "0x746FF80", VA = "0x187470B80")]
		public IPEndPoint NEBUYHWPNMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7470B40", Offset = "0x746FF40", VA = "0x187470B40")]
		public byte KFJYZAFTAOM()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7470B40", Offset = "0x746FF40", VA = "0x187470B40")]
		public sbyte ZEYIFZSHDVD()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x382CB80", Offset = "0x382BF80", VA = "0x18382CB80")]
		public a[] PLMAZJMWGXN<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7470870", Offset = "0x746FC70", VA = "0x187470870")]
		public bool[] IRVKVXFKESL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7470620", Offset = "0x746FA20", VA = "0x187470620")]
		public ushort[] CLZCWNHQFRQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7470D00", Offset = "0x7470100", VA = "0x187470D00")]
		public short[] UBDDYLDZDKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x74708B0", Offset = "0x746FCB0", VA = "0x1874708B0")]
		public int[] IWTKQQMMQQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7470D40", Offset = "0x7470140", VA = "0x187470D40")]
		public uint[] WIJIKAUXSMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7470560", Offset = "0x746F960", VA = "0x187470560")]
		public float[] AEPRNTXEGZD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7470B00", Offset = "0x746FF00", VA = "0x187470B00")]
		public double[] JUMCYYPLDJW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7470830", Offset = "0x746FC30", VA = "0x187470830")]
		public long[] HNEEKKQNNXH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7470C50", Offset = "0x7470050", VA = "0x187470C50")]
		public ulong[] SBEQAZBDQUQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7470720", Offset = "0x746FB20", VA = "0x187470720")]
		public string[] GKFQRNZHUOU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7470D80", Offset = "0x7470180", VA = "0x187470D80")]
		public bool XQBPAKMJDVQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x74706C0", Offset = "0x746FAC0", VA = "0x1874706C0")]
		public char JXSRRFXOJSW()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x74706C0", Offset = "0x746FAC0", VA = "0x1874706C0")]
		public ushort FUFTOJDKQFL()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x74706C0", Offset = "0x746FAC0", VA = "0x1874706C0")]
		public short SHKSTYEUMAM()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7470530", Offset = "0x746F930", VA = "0x187470530")]
		public long ADGFIXNPAJS()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7470530", Offset = "0x746F930", VA = "0x187470530")]
		public ulong SJGKWUENYCP()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x74705F0", Offset = "0x746F9F0", VA = "0x1874705F0")]
		public int TWSMHBFUZCL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x74705F0", Offset = "0x746F9F0", VA = "0x1874705F0")]
		public uint CHYHODIWSZU()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x74706F0", Offset = "0x746FAF0", VA = "0x1874706F0")]
		public float GHRMTOZKXPW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x74705C0", Offset = "0x746F9C0", VA = "0x1874705C0")]
		public double CBETYYAIASD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x74708F0", Offset = "0x746FCF0", VA = "0x1874708F0")]
		public string JPHZVEJTRTJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7470C90", Offset = "0x7470090", VA = "0x187470C90")]
		public ArraySegment<byte> TCHVWWZLBAG(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x74707F0", Offset = "0x746FBF0", VA = "0x1874707F0")]
		public sbyte[] HCNEYOVLZRI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7470680", Offset = "0x746FA80", VA = "0x187470680")]
		public byte[] ERBTRYVMQQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7470660", Offset = "0x746FA60", VA = "0x187470660")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class QIDRNUEFOPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] CHEHRVMCRPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int OMQJCZUIPSQ;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int BHPWHXXPPZF = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool RWLHTXIOQYA;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding QYQKEJDQMSA;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int OJOMJCDAMSN = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] JIDGEOKSOYI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] VQVHWHVOHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int WFHQKHTXLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7477170", Offset = "0x7476570", VA = "0x187477170")]
		public QIDRNUEFOPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x74771F0", Offset = "0x74765F0", VA = "0x1874771F0")]
		public QIDRNUEFOPY(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7476A20", Offset = "0x7475E20", VA = "0x187476A20")]
		public static QIDRNUEFOPY VGEAHQWEIVR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7476530", Offset = "0x7475930", VA = "0x187476530")]
		public void OITEVVUKLPL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2796640", Offset = "0x2795A40", VA = "0x182796640")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7476DE0", Offset = "0x74761E0", VA = "0x187476DE0")]
		public void YINJSYLHNIP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7476D90", Offset = "0x7476190", VA = "0x187476D90")]
		public void YINJSYLHNIP(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7476E80", Offset = "0x7476280", VA = "0x187476E80")]
		public void YINJSYLHNIP(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7476E80", Offset = "0x7476280", VA = "0x187476E80")]
		public void YINJSYLHNIP(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7476D00", Offset = "0x7476100", VA = "0x187476D00")]
		public void YINJSYLHNIP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7476D00", Offset = "0x7476100", VA = "0x187476D00")]
		public void YINJSYLHNIP(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7476FA0", Offset = "0x74763A0", VA = "0x187476FA0")]
		public void YINJSYLHNIP(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7476FA0", Offset = "0x74763A0", VA = "0x187476FA0")]
		public void YINJSYLHNIP(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7476FA0", Offset = "0x74763A0", VA = "0x187476FA0")]
		public void YINJSYLHNIP(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7476CA0", Offset = "0x74760A0", VA = "0x187476CA0")]
		public void YINJSYLHNIP(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7476CA0", Offset = "0x74760A0", VA = "0x187476CA0")]
		public void YINJSYLHNIP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7477070", Offset = "0x7476470", VA = "0x187477070")]
		public void YINJSYLHNIP(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7476450", Offset = "0x7475850", VA = "0x187476450")]
		public void EFVARANSABJ(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7476450", Offset = "0x7475850", VA = "0x187476450")]
		public void CYLGKSKZGUG(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7477010", Offset = "0x7476410", VA = "0x187477010")]
		public void YINJSYLHNIP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7476780", Offset = "0x7475B80", VA = "0x187476780")]
		public void QXCDGAOANSI(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7476860", Offset = "0x7475C60", VA = "0x187476860")]
		public void QXCDGAOANSI(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7476940", Offset = "0x7475D40", VA = "0x187476940")]
		public void QXCDGAOANSI(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7476940", Offset = "0x7475D40", VA = "0x187476940")]
		public void QXCDGAOANSI(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7476940", Offset = "0x7475D40", VA = "0x187476940")]
		public void QXCDGAOANSI(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7476860", Offset = "0x7475C60", VA = "0x187476860")]
		public void QXCDGAOANSI(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7476860", Offset = "0x7475C60", VA = "0x187476860")]
		public void QXCDGAOANSI(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x74766A0", Offset = "0x7475AA0", VA = "0x1874766A0")]
		public void QXCDGAOANSI(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x74766A0", Offset = "0x7475AA0", VA = "0x1874766A0")]
		public void QXCDGAOANSI(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7476450", Offset = "0x7475850", VA = "0x187476450")]
		public void QXCDGAOANSI(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x74765D0", Offset = "0x74759D0", VA = "0x1874765D0")]
		public void QXCDGAOANSI(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7476ED0", Offset = "0x74762D0", VA = "0x187476ED0")]
		public void YINJSYLHNIP(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x74770E0", Offset = "0x74764E0", VA = "0x1874770E0")]
		public void YINJSYLHNIP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7476A90", Offset = "0x7475E90", VA = "0x187476A90")]
		public void YINJSYLHNIP(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class DXSJHEYNHHV
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class KOTCBFPZOVR<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong OQGVUCEGDTZ;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x52208D0", Offset = "0x521FCD0", VA = "0x1852208D0")]
			static KOTCBFPZOVR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(NYFAHCSWMFI reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class ATTUMYEKKDK<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public DXSJHEYNHHV MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a QXDRGMPEEQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> UESFZYAVUYE;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ATTUMYEKKDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5482380", Offset = "0x5481780", VA = "0x185482380")]
			internal void PJFXHEMNXWP(NYFAHCSWMFI a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class MLDXZNCMZPK<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public DXSJHEYNHHV MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a QXDRGMPEEQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> UESFZYAVUYE;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MLDXZNCMZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x57D22E0", Offset = "0x57D16E0", VA = "0x1857D22E0")]
			internal void PJFXHEMNXWP(NYFAHCSWMFI a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly KGUZWFLTUVD KMAJQOGUNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> JENIQOVUGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly QIDRNUEFOPY EOIMAISSZXP;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x746BC10", Offset = "0x746B010", VA = "0x18746BC10")]
		public DXSJHEYNHHV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3502840", Offset = "0x3501C40", VA = "0x183502840", Slot = "4")]
		protected virtual ulong GWQAWEUIJXE<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x746BB40", Offset = "0x746AF40", VA = "0x18746BB40", Slot = "5")]
		protected virtual SubscribeDelegate KOWSEELQABT(NYFAHCSWMFI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x35027C0", Offset = "0x3501BC0", VA = "0x1835027C0", Slot = "6")]
		protected virtual void GTUFLEMAAKB<b>(QIDRNUEFOPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x746BA70", Offset = "0x746AE70", VA = "0x18746BA70")]
		public void CEJIVPPCGEW(NYFAHCSWMFI a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x35028C0", Offset = "0x3501CC0", VA = "0x1835028C0")]
		public void MXOKRHSTACN<j>(QIDRNUEFOPY a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x746BAF0", Offset = "0x746AEF0", VA = "0x18746BAF0")]
		public void HVNLQYOLAWK(NYFAHCSWMFI a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3502640", Offset = "0x3501A40", VA = "0x183502640")]
		public void CHXACEVGQZJ<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3502640", Offset = "0x3501A40", VA = "0x183502640")]
		public void CHXACEVGQZJ<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x746E830", Offset = "0x746DC30", VA = "0x18746E830")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7475950", Offset = "0x7474D50", VA = "0x187475950")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KGUZWFLTUVD
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
		private abstract class OWGCGBEOIDZ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType IRYCWFFEKLI;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x59A4370", Offset = "0x59A3770", VA = "0x1859A4370", Slot = "4")]
			public virtual void DWRZVDJUYSA(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void DOMUIQPPDGG(a a, NYFAHCSWMFI b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void MXOKRHSTACN(a a, QIDRNUEFOPY b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void KIBVPTXZDSH(a a, NYFAHCSWMFI b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void YGBWKPYHDDQ(a a, QIDRNUEFOPY b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void FGWJYPBWSHE(a a, NYFAHCSWMFI b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LFHHJGVHKCB(a a, QIDRNUEFOPY b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			protected OWGCGBEOIDZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class NAVGQNBMUEK<a, b> : OWGCGBEOIDZ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> HUJLBGKPPAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> DUZRYJOBBCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> BYVVIFOIRVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> IUSFQNLXFGU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> LGJGEQQABVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> KHLTHYKLJUJ;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5846AA0", Offset = "0x5845EA0", VA = "0x185846AA0", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5846AA0", Offset = "0x5845EA0", VA = "0x185846AA0", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x58469D0", Offset = "0x5845DD0", VA = "0x1858469D0", Slot = "9")]
			public override void FGWJYPBWSHE(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x58469D0", Offset = "0x5845DD0", VA = "0x1858469D0", Slot = "10")]
			public override void LFHHJGVHKCB(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5846B70", Offset = "0x5845F70", VA = "0x185846B70")]
			protected b[] LCDKQGFOAPV(a a, NYFAHCSWMFI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x5846E10", Offset = "0x5846210", VA = "0x185846E10")]
			protected b[] SWTTUOTPRVI(a a, QIDRNUEFOPY b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5845EF0", Offset = "0x58452F0", VA = "0x185845EF0", Slot = "4")]
			public override void DWRZVDJUYSA(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5846F80", Offset = "0x5846380", VA = "0x185846F80")]
			protected NAVGQNBMUEK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class VLPSOEREMCF<a, b> : NAVGQNBMUEK<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void VKELUGSVNVQ(NYFAHCSWMFI a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void KWTHPEPDBQF(QIDRNUEFOPY a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x624F9F0", Offset = "0x624EDF0", VA = "0x18624F9F0", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x624FF00", Offset = "0x624F300", VA = "0x18624FF00", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x624FE60", Offset = "0x624F260", VA = "0x18624FE60", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x62501E0", Offset = "0x624F5E0", VA = "0x1862501E0", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x62503D0", Offset = "0x624F7D0", VA = "0x1862503D0")]
			protected VLPSOEREMCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class DQFCCPVOHTW<a> : NAVGQNBMUEK<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x414F510", Offset = "0x414E910", VA = "0x18414F510", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x414F6B0", Offset = "0x414EAB0", VA = "0x18414F6B0", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x414FF10", Offset = "0x414F310", VA = "0x18414FF10", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x414F7F0", Offset = "0x414EBF0", VA = "0x18414F7F0", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public DQFCCPVOHTW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class DPDPUBRWCSN<a> : NAVGQNBMUEK<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x414F510", Offset = "0x414E910", VA = "0x18414F510", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x414F6B0", Offset = "0x414EAB0", VA = "0x18414F6B0", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x414F560", Offset = "0x414E960", VA = "0x18414F560", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x414F7F0", Offset = "0x414EBF0", VA = "0x18414F7F0", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public DPDPUBRWCSN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class ZSYVYJTXCKD<a> : NAVGQNBMUEK<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DC70", Offset = "0x3F0D070", VA = "0x183F0DC70", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DF10", Offset = "0x3F0D310", VA = "0x183F0DF10", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DCC0", Offset = "0x3F0D0C0", VA = "0x183F0DCC0", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DF50", Offset = "0x3F0D350", VA = "0x183F0DF50", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public ZSYVYJTXCKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class GZJSWZRUYHU<a> : NAVGQNBMUEK<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DC70", Offset = "0x3F0D070", VA = "0x183F0DC70", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DF10", Offset = "0x3F0D310", VA = "0x183F0DF10", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4EDF060", Offset = "0x4EDE460", VA = "0x184EDF060", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DF50", Offset = "0x3F0D350", VA = "0x183F0DF50", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public GZJSWZRUYHU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class YPLBQLESWVN<a> : NAVGQNBMUEK<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3E78680", Offset = "0x3E77A80", VA = "0x183E78680", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3E78A40", Offset = "0x3E77E40", VA = "0x183E78A40", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3E788F0", Offset = "0x3E77CF0", VA = "0x183E788F0", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3E78B80", Offset = "0x3E77F80", VA = "0x183E78B80", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public YPLBQLESWVN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class SPKQUULIURW<a> : NAVGQNBMUEK<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3E78680", Offset = "0x3E77A80", VA = "0x183E78680", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3E78A40", Offset = "0x3E77E40", VA = "0x183E78A40", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x5DFE3D0", Offset = "0x5DFD7D0", VA = "0x185DFE3D0", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3E78B80", Offset = "0x3E77F80", VA = "0x183E78B80", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public SPKQUULIURW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class LAPPZVTYRGL<a> : NAVGQNBMUEK<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x52FAA00", Offset = "0x52F9E00", VA = "0x1852FAA00", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x52FADC0", Offset = "0x52FA1C0", VA = "0x1852FADC0", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x52FAB70", Offset = "0x52F9F70", VA = "0x1852FAB70", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x52FAF00", Offset = "0x52FA300", VA = "0x1852FAF00", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public LAPPZVTYRGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class QRIPYEMKJCG<a> : NAVGQNBMUEK<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x52FAA00", Offset = "0x52F9E00", VA = "0x1852FAA00", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x52FADC0", Offset = "0x52FA1C0", VA = "0x1852FADC0", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5AEE200", Offset = "0x5AED600", VA = "0x185AEE200", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x52FAF00", Offset = "0x52FA300", VA = "0x1852FAF00", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public QRIPYEMKJCG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class BORCREMNATF<a> : NAVGQNBMUEK<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x6F6CBE0", Offset = "0x6F6BFE0", VA = "0x186F6CBE0", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x6F6CFA0", Offset = "0x6F6C3A0", VA = "0x186F6CFA0", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6F6CE50", Offset = "0x6F6C250", VA = "0x186F6CE50", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x414F7F0", Offset = "0x414EBF0", VA = "0x18414F7F0", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public BORCREMNATF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class WEZOACJPHKU<a> : NAVGQNBMUEK<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x65A8440", Offset = "0x65A7840", VA = "0x1865A8440", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x65A8700", Offset = "0x65A7B00", VA = "0x1865A8700", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x65A86B0", Offset = "0x65A7AB0", VA = "0x1865A86B0", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3E78B80", Offset = "0x3E77F80", VA = "0x183E78B80", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public WEZOACJPHKU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class TLBVQEVABIF<a> : NAVGQNBMUEK<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x5EEF2D0", Offset = "0x5EEE6D0", VA = "0x185EEF2D0", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x5EEF470", Offset = "0x5EEE870", VA = "0x185EEF470", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x5EEF420", Offset = "0x5EEE820", VA = "0x185EEF420", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x52FAF00", Offset = "0x52FA300", VA = "0x1852FAF00", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3E78BE0", Offset = "0x3E77FE0", VA = "0x183E78BE0")]
			public TLBVQEVABIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class TTRMJVFGOBX<a> : VLPSOEREMCF<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5F085D0", Offset = "0x5F079D0", VA = "0x185F085D0", Slot = "12")]
			protected override void KWTHPEPDBQF(QIDRNUEFOPY a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5F08600", Offset = "0x5F07A00", VA = "0x185F08600", Slot = "11")]
			protected override void VKELUGSVNVQ(NYFAHCSWMFI a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x4EB8C80", Offset = "0x4EB8080", VA = "0x184EB8C80")]
			public TTRMJVFGOBX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class GADVVZLMBTX<a> : VLPSOEREMCF<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x4EB8C10", Offset = "0x4EB8010", VA = "0x184EB8C10", Slot = "12")]
			protected override void KWTHPEPDBQF(QIDRNUEFOPY a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x4EB8C40", Offset = "0x4EB8040", VA = "0x184EB8C40", Slot = "11")]
			protected override void VKELUGSVNVQ(NYFAHCSWMFI a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4EB8C80", Offset = "0x4EB8080", VA = "0x184EB8C80")]
			public GADVVZLMBTX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class KHSJMTCVQII<a> : NAVGQNBMUEK<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int ZWAALQEAFNN;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5219940", Offset = "0x5218D40", VA = "0x185219940")]
			public KHSJMTCVQII(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x52193C0", Offset = "0x52187C0", VA = "0x1852193C0", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x52196A0", Offset = "0x5218AA0", VA = "0x1852196A0", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5219640", Offset = "0x5218A40", VA = "0x185219640", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x52198F0", Offset = "0x5218CF0", VA = "0x1852198F0", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class CDRSPOIRBZA<a> : OWGCGBEOIDZ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo FPQWNIOTCZB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type JETPMBKSLHB;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B9B0", Offset = "0x3D2ADB0", VA = "0x183D2B9B0")]
			public CDRSPOIRBZA(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B690", Offset = "0x3D2AA90", VA = "0x183D2B690", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B8E0", Offset = "0x3D2ACE0", VA = "0x183D2B8E0", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B780", Offset = "0x3D2AB80", VA = "0x183D2B780", Slot = "7")]
			public override void KIBVPTXZDSH(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B780", Offset = "0x3D2AB80", VA = "0x183D2B780", Slot = "8")]
			public override void YGBWKPYHDDQ(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B730", Offset = "0x3D2AB30", VA = "0x183D2B730", Slot = "9")]
			public override void FGWJYPBWSHE(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B730", Offset = "0x3D2AB30", VA = "0x183D2B730", Slot = "10")]
			public override void LFHHJGVHKCB(a a, QIDRNUEFOPY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class OFVOXEELBJZ<a> : CDRSPOIRBZA<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x59887F0", Offset = "0x5987BF0", VA = "0x1859887F0")]
			public OFVOXEELBJZ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x59885D0", Offset = "0x59879D0", VA = "0x1859885D0", Slot = "5")]
			public override void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x5988780", Offset = "0x5987B80", VA = "0x185988780", Slot = "6")]
			public override void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class MNUKIYYMTFD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static MNUKIYYMTFD<a> LVYKDVFRYUJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly OWGCGBEOIDZ<a>[] CSPSFNCVZHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int LJUCSONRLFP;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x57D64B0", Offset = "0x57D58B0", VA = "0x1857D64B0")]
			public MNUKIYYMTFD(List<OWGCGBEOIDZ<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x57D61C0", Offset = "0x57D55C0", VA = "0x1857D61C0")]
			public void MXOKRHSTACN(a a, QIDRNUEFOPY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x57D6110", Offset = "0x57D5510", VA = "0x1857D6110")]
			public void DOMUIQPPDGG(a a, NYFAHCSWMFI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class TMRCLMIZWYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract OWGCGBEOIDZ<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private QIDRNUEFOPY JIEYSHYFGRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int CDSNZZYQBFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, TMRCLMIZWYN> TTAIYGRBDDS;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x746E840", Offset = "0x746DC40", VA = "0x18746E840")]
		public KGUZWFLTUVD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3717BC0", Offset = "0x3716FC0", VA = "0x183717BC0")]
		private MNUKIYYMTFD<d> ERXVSMHLLCG<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x37189B0", Offset = "0x3717DB0", VA = "0x1837189B0")]
		public void SHWXSEAJSCT<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3716CF0", Offset = "0x37160F0", VA = "0x183716CF0")]
		public bool Deserialize<T>(NYFAHCSWMFI reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3716C70", Offset = "0x3716070", VA = "0x183716C70")]
		public void CQVTSUWTJSM<f>(QIDRNUEFOPY a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class EXJIKDFEPOU
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime SRASNHWIIPR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] DQHTREVZOSB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator WEFPFMGDAQR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x746CC70", Offset = "0x746C070", VA = "0x18746CC70")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int FBDJYCBBUDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x746BFD0", Offset = "0x746B3D0", VA = "0x18746BFD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x746CAF0", Offset = "0x746BEF0", VA = "0x18746CAF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode BALPIKTSLUR
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x746C6D0", Offset = "0x746BAD0", VA = "0x18746C6D0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x746C000", Offset = "0x746B400", VA = "0x18746C000")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int WXAWYUJDIHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x746C040", Offset = "0x746B440", VA = "0x18746C040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint TVCGFXSWWMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x746CA90", Offset = "0x746BE90", VA = "0x18746CA90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? JNTSHPWVMSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x746C070", Offset = "0x746B470", VA = "0x18746C070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? ERQZBJLRFKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x746C160", Offset = "0x746B560", VA = "0x18746C160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? YATQFUUQCBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x746CBE0", Offset = "0x746BFE0", VA = "0x18746CBE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x746C8D0", Offset = "0x746BCD0", VA = "0x18746C8D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ABVEVXOPYVA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x746CFC0", Offset = "0x746C3C0", VA = "0x18746CFC0")]
		public EXJIKDFEPOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x746CF20", Offset = "0x746C320", VA = "0x18746CF20")]
		internal EXJIKDFEPOU(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x746BEC0", Offset = "0x746B2C0", VA = "0x18746BEC0")]
		public static EXJIKDFEPOU CITNUVFOYLI(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x746C190", Offset = "0x746B590", VA = "0x18746C190")]
		internal void MEJZEUOTXTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x746C510", Offset = "0x746B910", VA = "0x18746C510")]
		private void MEMMZHRTXDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x746C700", Offset = "0x746BB00", VA = "0x18746C700")]
		private DateTime? PDJOVXBGMSR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x746CD00", Offset = "0x746C100", VA = "0x18746CD00")]
		private void ZMZOYZOLIQZ(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x746CB30", Offset = "0x746BF30", VA = "0x18746CB30")]
		private ulong WARXQMFMMEF(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x746C0A0", Offset = "0x746B4A0", VA = "0x18746C0A0")]
		private void IWMXULNOZWJ(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x746CC10", Offset = "0x746C010", VA = "0x18746CC10")]
		private uint WWKEPKKPKTQ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7332C90", Offset = "0x7332090", VA = "0x187332C90")]
		private static uint ZAVVIVLKQXX(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x746CCA0", Offset = "0x746C0A0", VA = "0x18746CCA0")]
		private static ulong ZAVVIVLKQXX(ulong a)
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
	internal sealed class STLGIMZQAEV
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int FSWGUSXZFPQ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int XKYQSJKPBAH = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int ZOLKZJKUCSA = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint CNMPCFFIPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int EIECTCQUNGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int ARXRLQFKPAO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool REQHGDSNJST
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7478260", Offset = "0x7477660", VA = "0x187478260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7478270", Offset = "0x7477670", VA = "0x187478270")]
		public bool SPZOFEDLTUI(ALHDURJKPBG a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class RPYADCIDYVD : ALHDURJKPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket PUJKAZQEBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly ANMAVLVKKFG IXETPGUNMNG;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short GKIFQBWNBMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x7477330", Offset = "0x7476730", VA = "0x187477330", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int WNMBUHAKRDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7477970", Offset = "0x7476D70", VA = "0x187477970", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint USUUOHQXEGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x7477A80", Offset = "0x7476E80", VA = "0x187477A80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily ZLDLGHMCYEK
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2FA88E0", Offset = "0x2FA7CE0", VA = "0x182FA88E0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7477AA0", Offset = "0x7476EA0", VA = "0x187477AA0")]
		public RPYADCIDYVD(AddressFamily a, ANMAVLVKKFG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7477350", Offset = "0x7476750", VA = "0x187477350", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7477930", Offset = "0x7476D30", VA = "0x187477930", Slot = "9")]
		public int NWRVHUPZSGR(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7477990", Offset = "0x7476D90", VA = "0x187477990", Slot = "10")]
		public int WSDJHFVTUZJ(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7477910", Offset = "0x7476D10", VA = "0x187477910", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface ALHDURJKPBG
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short GKIFQBWNBMS
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int WNMBUHAKRDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint USUUOHQXEGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily ZLDLGHMCYEK
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
		int NWRVHUPZSGR(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int WSDJHFVTUZJ(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x7470F10", Offset = "0x7470310", VA = "0x187470F10")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7470FB0", Offset = "0x74703B0", VA = "0x187470FB0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7470E20", Offset = "0x7470220", VA = "0x187470E20", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7470E60", Offset = "0x7470260", VA = "0x187470E60", Slot = "0")]
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
	public class USWIWWYPYHL
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string RBCHLAGDSHH = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int SAZSTUCBEZB = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int MYTNPAYOUJH = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int ORZBXVLNCHL = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> FQBMMGOXKBW;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback SZXAQLQPHBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int LFVJZADHLAT;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		internal void DNSCZJOPFJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		internal void VATPSXGHJJF(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class AZWEWWDCEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int CVBJXTWUJUJ;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
		protected AZWEWWDCEDI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GDUMWTWXGLC(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void XBSOZJVLHOX(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class HHDKJMAXPTM : AZWEWWDCEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] RJWUJQXIPUR;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator NQUHZOAIYSH;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x28A0600", Offset = "0x289FA00", VA = "0x1828A0600")]
		public HHDKJMAXPTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x746DF10", Offset = "0x746D310", VA = "0x18746DF10")]
		public void HFNTBKOWQCA(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x746E0C0", Offset = "0x746D4C0", VA = "0x18746E0C0")]
		public void PLKNKOTDFAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x746DAD0", Offset = "0x746CED0", VA = "0x18746DAD0", Slot = "4")]
		public override void GDUMWTWXGLC(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x746E1A0", Offset = "0x746D5A0", VA = "0x18746E1A0", Slot = "5")]
		public override void XBSOZJVLHOX(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class KDUQCSVCXYZ
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr VDKUMJYYAVF;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x747B0A0", Offset = "0x747A4A0", VA = "0x18747B0A0")]
			[BurstDiscard]
			private static void GJGWBSMAIYL(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x747AF20", Offset = "0x747A320", VA = "0x18747AF20")]
			private static IntPtr FKKZKDNIDRR()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x747B230", Offset = "0x747A630", VA = "0x18747B230")]
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
		[Cpp2IlInjected.Address(RVA = "0x7477D60", Offset = "0x7477160", VA = "0x187477D60")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7477C80", Offset = "0x7477080", VA = "0x187477C80")]
		private uint INNFGUMXUPK(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x74638A0", Offset = "0x7462CA0", VA = "0x1874638A0")]
		private void VNLKSXAPLMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7463690", Offset = "0x7462A90", VA = "0x187463690")]
		private void BLXCIIASXSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7463950", Offset = "0x7462D50", VA = "0x187463950")]
		private void XSRBETNFGNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x74639E0", Offset = "0x7462DE0", VA = "0x1874639E0")]
		private void ZUZHASFUVGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7478200", Offset = "0x7477600", VA = "0x187478200")]
		private void XSRIMPACZZX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7477DE0", Offset = "0x74771E0", VA = "0x187477DE0")]
		private unsafe void TKEYTTMVBIS(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7477B50", Offset = "0x7476F50", VA = "0x187477B50")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void CNPOBSKAPRB([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7477B60", Offset = "0x7476F60", VA = "0x187477B60")]
		public static void CNPOBSKAPRB(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7477CB0", Offset = "0x74770B0", VA = "0x187477CB0")]
		public static void RFHIRULMQRR(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7477C10", Offset = "0x7477010", VA = "0x187477C10")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void DKWXGZSUSXQ([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x747B470", Offset = "0x747A870", VA = "0x18747B470")]
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
