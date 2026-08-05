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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, KXMNWZIMDLE
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
		private NetworkManager EYPICPGXBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool OQLEILVCGQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, BMWKYROENAP> VZQXHBZVAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private EQDSUDNIBGS HLZDPOWFFXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch WWRSIZVYGMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] VRREBESKODX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType WBSZBMIPQAK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int FOANEGYLIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7761690", Offset = "0x7760490", VA = "0x187761690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7761640", Offset = "0x7760440", VA = "0x187761640", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7760880", Offset = "0x775F680", VA = "0x187760880")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7760860", Offset = "0x775F660", VA = "0x187760860")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77606E0", Offset = "0x775F4E0", VA = "0x1877606E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7761490", Offset = "0x7760290", VA = "0x187761490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7760B90", Offset = "0x775F990", VA = "0x187760B90", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77607D0", Offset = "0x775F5D0", VA = "0x1877607D0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7760E60", Offset = "0x775FC60", VA = "0x187760E60", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77611A0", Offset = "0x775FFA0", VA = "0x1877611A0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77601C0", Offset = "0x775EFC0", VA = "0x1877601C0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77600D0", Offset = "0x775EED0", VA = "0x1877600D0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77602D0", Offset = "0x775F0D0", VA = "0x1877602D0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7760DF0", Offset = "0x775FBF0", VA = "0x187760DF0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7760370", Offset = "0x775F170", VA = "0x187760370", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77613C0", Offset = "0x77601C0", VA = "0x1877613C0")]
		private DeliveryMethod UTNSBRMHGAP(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77614B0", Offset = "0x77602B0", VA = "0x1877614B0", Slot = "16")]
		private void YQCEJHEZJNS(BMWKYROENAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77605B0", Offset = "0x775F3B0", VA = "0x1877605B0", Slot = "17")]
		private void JYFPMITWWWW(BMWKYROENAP a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "18")]
		private void IRVLEMCECBD(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7760990", Offset = "0x775F790", VA = "0x187760990", Slot = "19")]
		private void SMARZOZZTZY(BMWKYROENAP a, OALUHSHYXEM b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x775FFE0", Offset = "0x775EDE0", VA = "0x18775FFE0")]
		private void BYKTCMHCQMV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "20")]
		private void XNTSLTDBNIU(IPEndPoint a, OALUHSHYXEM b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "21")]
		private void FAQPJMNBUGI(BMWKYROENAP a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7760680", Offset = "0x775F480", VA = "0x187760680", Slot = "22")]
		private void KGKBGKJMSTU(LRXKPYUEFRT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7760810", Offset = "0x775F610", VA = "0x187760810")]
		private ulong QZNDVIVSTHD(BMWKYROENAP a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7760840", Offset = "0x775F640", VA = "0x187760840")]
		private ulong QZNDVIVSTHD(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77600B0", Offset = "0x775EEB0", VA = "0x1877600B0")]
		private static int CVVUYXQJARQ(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7761570", Offset = "0x7760370", VA = "0x187761570")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7760580", Offset = "0x775F380", VA = "0x187760580")]
		[CompilerGenerated]
		private void MZAZSZSHZAO(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7760580", Offset = "0x775F380", VA = "0x187760580")]
		[CompilerGenerated]
		private void JNBJSUAQDUT(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class LGAUOZBVEOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly BMWKYROENAP GNHJWYMYEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<URQKWMWFVTV> KYCYCGTTPXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int ZAWMUROBDXO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int JVARPRWNLAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x775FDA0", Offset = "0x775EBA0", VA = "0x18775FDA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x775FDF0", Offset = "0x775EBF0", VA = "0x18775FDF0")]
		protected LGAUOZBVEOI(BMWKYROENAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x775FD40", Offset = "0x775EB40", VA = "0x18775FD40")]
		public void RFYQPWMETKB(URQKWMWFVTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x775FC80", Offset = "0x775EA80", VA = "0x18775FC80")]
		protected void FXPQAKTBQIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x775FD00", Offset = "0x775EB00", VA = "0x18775FD00")]
		public bool PLDLWWZVFBG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool APAPHLCXZUI();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool KVIYRCKTUNX(URQKWMWFVTV a);
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
	public class LRXKPYUEFRT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly EQDSUDNIBGS JCMEGQCYHSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int KAVEEPIXKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal YUPYITPLATK VRFVYXKRQWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint PAQHSHVZXEH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult GKZMZURZBUN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x14078F0", Offset = "0x14066F0", VA = "0x1814078F0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1407900", Offset = "0x1406700", VA = "0x181407900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x775FEE0", Offset = "0x775ECE0", VA = "0x18775FEE0")]
		internal void SARXXDXVYYG(YUPYITPLATK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x775FF40", Offset = "0x775ED40", VA = "0x18775FF40")]
		private bool UUSTONCAMOQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x775FF70", Offset = "0x775ED70", VA = "0x18775FF70")]
		internal LRXKPYUEFRT(IPEndPoint a, YUPYITPLATK b, EQDSUDNIBGS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x775FE80", Offset = "0x775EC80", VA = "0x18775FE80")]
		public BMWKYROENAP Accept()
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
		public OALUHSHYXEM AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface KXMNWZIMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RVIBNTHAHNC(BMWKYROENAP a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FWIFJMVYPHY(BMWKYROENAP a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EFBYCMJMQNT(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZACIMAGBPOG(BMWKYROENAP a, OALUHSHYXEM b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MRSWJPFUFXG(IPEndPoint a, OALUHSHYXEM b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CCJIMENMHGU(BMWKYROENAP a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void KOXACRBGDYO(LRXKPYUEFRT a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ZEPPUWUIMXH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VPKDQQKBVEM(BMWKYROENAP a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LQQLRRINFGV
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YFZSKXHTJZE(NUAGIRTWHKO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface RDVMTFOINRR
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZZNIUVSGDCJ(BMWKYROENAP a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class YUPYITPLATK
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int CHPIBEHJZSU = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long WHVAKLRSTGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte SIDHZAUAYTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] TNTMROEAXLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly AWTVWEPWQCQ FFDULGKWPQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int IPOUBTJJMPT;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7769460", Offset = "0x7768260", VA = "0x187769460")]
		private YUPYITPLATK(long a, byte b, int c, byte[] d, AWTVWEPWQCQ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7769060", Offset = "0x7767E60", VA = "0x187769060")]
		public static int BKSRPWPNMVT(URQKWMWFVTV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7769270", Offset = "0x7768070", VA = "0x187769270")]
		public static YUPYITPLATK PGISFZYEKAY(URQKWMWFVTV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7769090", Offset = "0x7767E90", VA = "0x187769090")]
		public static URQKWMWFVTV BUNEQDIGEQS(XOADITSHTZG a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class EBWRQVWVWFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long WHVAKLRSTGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte SIDHZAUAYTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int IPOUBTJJMPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool ZOFBOBKWPHU;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7757A30", Offset = "0x7756830", VA = "0x187757A30")]
		private EBWRQVWVWFF(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7757830", Offset = "0x7756630", VA = "0x187757830")]
		public static EBWRQVWVWFF PGISFZYEKAY(URQKWMWFVTV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7757740", Offset = "0x7756540", VA = "0x187757740")]
		public static URQKWMWFVTV BUNEQDIGEQS(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7757930", Offset = "0x7756730", VA = "0x187757930")]
		public static URQKWMWFVTV XGSZBNXWCPW(BMWKYROENAP a)
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
	public interface CMGAJIIYYOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JPMJUBEYEUN(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HVLADTDDLYT(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class TQXMXIYJMMR
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
		private class IFBPMCWJCNH
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint GJKLBBXUOWF
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string HPHWNWZYCNT
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IFBPMCWJCNH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class NSSWUKXTNVB
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint GJKLBBXUOWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint JGNCOHQWMHJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string HPHWNWZYCNT
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NSSWUKXTNVB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class LNSEYKGWOZT
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string HPHWNWZYCNT
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool BKWUGXNNTOX
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xC70C00", Offset = "0xC6FA00", VA = "0x180C70C00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xACF2E0", Offset = "0xACE0E0", VA = "0x180ACF2E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public LNSEYKGWOZT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly EQDSUDNIBGS CVNHRZPBDQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> HECAEPAUGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> XFHWDMYRKWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly AWTVWEPWQCQ VPSTFVKQKDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly XOADITSHTZG JRYNAEDANVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly ZFQREOHHWFP UUKBLCTPCWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CMGAJIIYYOG JWRWXOZPXSE;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int QITBJVIYVFF = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool BWFPVSRFSDO;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7766690", Offset = "0x7765490", VA = "0x187766690")]
		internal TQXMXIYJMMR(EQDSUDNIBGS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7766510", Offset = "0x7765310", VA = "0x187766510")]
		internal void WRRYKQXKLSE(IPEndPoint a, URQKWMWFVTV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B3AC50", Offset = "0x3B39A50", VA = "0x183B3AC50")]
		private void ECUKHSHYZYC<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7766230", Offset = "0x7765030", VA = "0x187766230")]
		private void JPMJUBEYEUN(IFBPMCWJCNH a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77663B0", Offset = "0x77651B0", VA = "0x1877663B0")]
		private void PDTVKAVYPTB(NSSWUKXTNVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77660A0", Offset = "0x7764EA0", VA = "0x1877660A0")]
		private void JAEADDJEAOM(LNSEYKGWOZT a, IPEndPoint b)
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
	public static class WFGERPTYCJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] XFZVZQEWCVH;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int UZJEWWPBWHJ;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int MFLHVPYBLVU;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x775FC70", Offset = "0x775EA70", VA = "0x18775FC70")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x775FC70", Offset = "0x775EA70", VA = "0x18775FC70")]
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
	public interface CWKEXYZXCWO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JYJZZROKGCO(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class HZEBRLULMBY
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static CWKEXYZXCWO HIXIVZEKAZC;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object LILNDUURFFK;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x775F870", Offset = "0x775E670", VA = "0x18775F870")]
		private static void GVRRDATIYPF(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x775FAA0", Offset = "0x775E8A0", VA = "0x18775FAA0")]
		internal static void NTQBHZAPSNV(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x775FB60", Offset = "0x775E960", VA = "0x18775FB60")]
		internal static void YRGVKLWLWEZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x775FB00", Offset = "0x775E900", VA = "0x18775FB00")]
		internal static void RVCKUDPMELR(string a, params object[] args)
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
	public sealed class OALUHSHYXEM : AWTVWEPWQCQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private URQKWMWFVTV ELNDFQLZPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly EQDSUDNIBGS LASVPSXNBOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly UYZMZIHDWMJ KXNJPMTOSFI;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7763700", Offset = "0x7762500", VA = "0x187763700")]
		internal OALUHSHYXEM(EQDSUDNIBGS a, UYZMZIHDWMJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7763660", Offset = "0x7762460", VA = "0x187763660")]
		internal void PQVROWYSDEZ(URQKWMWFVTV a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x77635E0", Offset = "0x77623E0", VA = "0x1877635E0")]
		internal void GLMWXRDUNKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x77636D0", Offset = "0x77624D0", VA = "0x1877636D0")]
		public void TLXUFJAHJVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class UYZMZIHDWMJ
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
		public UYZMZIHDWMJ WTZHPJWUFXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType ULTKTFGCAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public BMWKYROENAP GNHJWYMYEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint PAQHSHVZXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object XTXAWHCVGFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int KCSJBUJNVOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError JSZUAGXWJXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason CMCZEKGEZDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LRXKPYUEFRT LRXKPYUEFRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod ZZKWMYCOAAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte HNBMKEEZISG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly OALUHSHYXEM FXTTUMUGAHN;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7767570", Offset = "0x7766370", VA = "0x187767570")]
		public UYZMZIHDWMJ(EQDSUDNIBGS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EQDSUDNIBGS : IEnumerable<BMWKYROENAP>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class HBHUKPFDTVB : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x775F7D0", Offset = "0x775E5D0", VA = "0x18775F7D0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x775F840", Offset = "0x775E640", VA = "0x18775F840", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HBHUKPFDTVB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<BMWKYROENAP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly BMWKYROENAP _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private BMWKYROENAP _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public BMWKYROENAP Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xD028E0", Offset = "0xD016E0", VA = "0x180D028E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xD028E0", Offset = "0xD016E0", VA = "0x180D028E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1B4D640", Offset = "0x1B4C440", VA = "0x181B4D640")]
			public NetPeerEnumerator(BMWKYROENAP p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7763550", Offset = "0x7762350", VA = "0x187763550", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x77635A0", Offset = "0x77623A0", VA = "0x1877635A0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread VVCJJXGZLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool HHGAUKFDLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool DFHHKFYJAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private FUMCJUHFUNZ HGUWDOPOQXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent ZJDXNISJLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<UYZMZIHDWMJ> IAWHCHDJLKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<UYZMZIHDWMJ> CPPCSUPQAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private UYZMZIHDWMJ HZQQARIJYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly KXMNWZIMDLE OXTMVUQAPHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly ZEPPUWUIMXH OSBRYGXCSTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly LQQLRRINFGV VKYCYAWHDOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly RDVMTFOINRR AFNJDDACCER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, BMWKYROENAP> EVTIEWJWSVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, LRXKPYUEFRT> WWUOFJRDFTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, VILWAIGGUNZ> AZXZJEVYBRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim PLYROCETXLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private BMWKYROENAP QDJEJSLVANZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int YLUBNBQZDZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<BMWKYROENAP> KVNEJCCYPXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private BMWKYROENAP[] OAUMUIRUZAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly AQDXGWNVULC NZCPSNWXOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int JUNYPFHHQIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> SBHVDNQKEOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte YRCPNCYFHYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object QBDAOEYCAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool NCJEMKWVHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool YSIZHRZRCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int RELMXZUONPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int GOYCCDKUNXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int HDRKXDOBZNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int QDEIFIPDDTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool WDIJBXAVAWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool CPEVCAIGBKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int DHRQNHRIBUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int GWXTJICNPMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int XKUJQSOTNZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool BWFPVSRFSDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool AZHCPGEWBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool PYLZFPLAMNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool CZHMAXADSUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int VTSJEVLVGVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int ZYXQQCXUZJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool ZXXAHFZMCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly TQWULVIHMTS OPQXSZLCEVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool HBZGRJRXBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly TQXMXIYJMMR TQXMXIYJMMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool JIVUYKCRODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode NPFBZKLKQHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int FDWDFKZKTUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool OMFOAXQUNQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool PSDMEGLVLYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool QCNTSXZNCWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool IOKOQQBSCZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private URQKWMWFVTV KREGTXYXVHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int IRMCMCGUKWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object KIRTGGWLBIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private URQKWMWFVTV GFVHYBRNOJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int CKVCWMPIRYF;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int HHSWGMOZSWD = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int JRCATTZDRUM = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private JPQHFFEHRHA IGIQAVBZLQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private JPQHFFEHRHA IGTDVIPUEMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread OJZURMUCASP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread OKKIMAHWTPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint WOHZDTUIDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint WOSMYHICWGW;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] AKOQYUZMSHW;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] XGKGUAYEOLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> WAZRISRCZWF;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress KEPMPRXERWK;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool GTHYNZWNTVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int TCYZHYISXBM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ADKXCTXSLEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xC3C0E0", Offset = "0xC3AEE0", VA = "0x180C3C0E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xC3B0D0", Offset = "0xC39ED0", VA = "0x180C3B0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int IMTFCDEWYUE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1FD1780", Offset = "0x1FD0580", VA = "0x181FD1780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x210DC30", Offset = "0x210CA30", VA = "0x18210DC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte DPFNCZKQAXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xBC49A0", Offset = "0xBC37A0", VA = "0x180BC49A0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int FBNUIMKDXJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x775D900", Offset = "0x775C700", VA = "0x18775D900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short TBARLAGIOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7759EF0", Offset = "0x7758CF0", VA = "0x187759EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BMWKYROENAP.OnUpdatedMtuDelegate HOZYNBWEOWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x775C530", Offset = "0x775B330", VA = "0x18775C530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x775F0A0", Offset = "0x775DEA0", VA = "0x18775F0A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x775C310", Offset = "0x775B110", VA = "0x18775C310")]
		public void UEAEEVJLHLY(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x775D920", Offset = "0x775C720", VA = "0x18775D920")]
		public void WNAPFUZUFWX(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7758710", Offset = "0x7757510", VA = "0x187758710")]
		private bool DGAAPYUOBTR(IPEndPoint a, [Out] BMWKYROENAP b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x775A270", Offset = "0x7759070", VA = "0x18775A270")]
		private void IMCNQCVWMOP(BMWKYROENAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x775E230", Offset = "0x775D030", VA = "0x18775E230")]
		private void XGANSAHLSRK(BMWKYROENAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7759FB0", Offset = "0x7758DB0", VA = "0x187759FB0")]
		private void IIQAGYHKXJX(BMWKYROENAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x775F210", Offset = "0x775E010", VA = "0x18775F210")]
		public EQDSUDNIBGS(KXMNWZIMDLE a, [Optional] AQDXGWNVULC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7757F20", Offset = "0x7756D20", VA = "0x187757F20")]
		internal void BNCSSOSJTER(BMWKYROENAP a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7757F70", Offset = "0x7756D70", VA = "0x187757F70")]
		internal void CSJTYKYCTAR(BMWKYROENAP a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7757FC0", Offset = "0x7756DC0", VA = "0x187757FC0")]
		internal void CUWJKDANRKZ(BMWKYROENAP a, DisconnectReason b, SocketError c, URQKWMWFVTV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x77589F0", Offset = "0x77577F0", VA = "0x1877589F0")]
		private void EHCZPTKHSLE(BMWKYROENAP a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, URQKWMWFVTV h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x775A760", Offset = "0x7759560", VA = "0x18775A760")]
		private void JSDDYSFZFTK(UYZMZIHDWMJ.EType a, [Optional] BMWKYROENAP b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] LRXKPYUEFRT g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] URQKWMWFVTV j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x775DA70", Offset = "0x775C870", VA = "0x18775DA70")]
		private void WVGRJLRXKBV(UYZMZIHDWMJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x775B190", Offset = "0x7759F90", VA = "0x18775B190")]
		internal void QZPBXOZOUQP(UYZMZIHDWMJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x775AE30", Offset = "0x7759C30", VA = "0x18775AE30")]
		private void QGVPAPMBMPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x775E950", Offset = "0x775D750", VA = "0x18775E950")]
		private void YCBWYZKEUIL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x775E310", Offset = "0x775D110", VA = "0x18775E310")]
		internal BMWKYROENAP XZXIZVOQMEM(LRXKPYUEFRT a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x775E290", Offset = "0x775D090", VA = "0x18775E290")]
		private int XRLNLVGNUFK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7757A80", Offset = "0x7756880", VA = "0x187757A80")]
		private void AZSFSMXOYXI(IPEndPoint a, BMWKYROENAP b, YUPYITPLATK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x775C5E0", Offset = "0x775B3E0", VA = "0x18775C5E0")]
		private void VXVHSLMUQBZ(URQKWMWFVTV a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x775EC80", Offset = "0x775DA80", VA = "0x18775EC80")]
		internal void YGEWUPDQQVJ(URQKWMWFVTV a, DeliveryMethod b, byte c, int d, BMWKYROENAP e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x775BCA0", Offset = "0x775AAA0", VA = "0x18775BCA0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x775BC80", Offset = "0x775AA80", VA = "0x18775BC80")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x775BCB0", Offset = "0x775AAB0", VA = "0x18775BCB0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77599F0", Offset = "0x77587F0", VA = "0x1877599F0")]
		public void GXBCPDWCDRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7758260", Offset = "0x7757060", VA = "0x187758260")]
		public BMWKYROENAP Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7758180", Offset = "0x7756F80", VA = "0x187758180")]
		public BMWKYROENAP Connect(string address, int port, XOADITSHTZG connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7758340", Offset = "0x7757140", VA = "0x187758340")]
		public BMWKYROENAP Connect(IPEndPoint target, XOADITSHTZG connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x775BD30", Offset = "0x775AB30", VA = "0x18775BD30")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x775BD40", Offset = "0x775AB40", VA = "0x18775BD40")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77580D0", Offset = "0x7756ED0", VA = "0x1877580D0")]
		public void CZWXPEWYIFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7758000", Offset = "0x7756E00", VA = "0x187758000")]
		public void CZWXPEWYIFX(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7758DD0", Offset = "0x7757BD0", VA = "0x187758DD0")]
		public void EHCZPTKHSLE(BMWKYROENAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7758E10", Offset = "0x7757C10", VA = "0x187758E10")]
		public void EHCZPTKHSLE(BMWKYROENAP a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x775B480", Offset = "0x775A280", VA = "0x18775B480", Slot = "4")]
		private IEnumerator<BMWKYROENAP> SKOCTQPCEGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7759E60", Offset = "0x7758C60", VA = "0x187759E60", Slot = "5")]
		private IEnumerator HTHYFOXNRHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x775A590", Offset = "0x7759390", VA = "0x18775A590")]
		private URQKWMWFVTV JJRFOIHCNEP(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x775A680", Offset = "0x7759480", VA = "0x18775A680")]
		private URQKWMWFVTV JJRFOIHCNEP(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x77587B0", Offset = "0x77575B0", VA = "0x1877587B0")]
		internal URQKWMWFVTV DGYHQYDOCRI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x775C0A0", Offset = "0x775AEA0", VA = "0x18775C0A0")]
		internal void TDCHHPCTKCP(URQKWMWFVTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x775F150", Offset = "0x775DF50", VA = "0x18775F150")]
		static EQDSUDNIBGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC3C0E0", Offset = "0xC3AEE0", VA = "0x180C3C0E0")]
		private bool NDANQTLGWKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x775AB30", Offset = "0x7759930", VA = "0x18775AB30")]
		private void LBGSUJJIYBO(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x775EF50", Offset = "0x775DD50", VA = "0x18775EF50")]
		private void YLDQRCHGAZJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x775AC90", Offset = "0x7759A90", VA = "0x18775AC90")]
		private bool LOIIIBJLLYN(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x775D8E0", Offset = "0x775C6E0", VA = "0x18775D8E0")]
		private void WCZOCRLRKFA(FUMCJUHFUNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7759BA0", Offset = "0x77589A0", VA = "0x187759BA0")]
		private void HIBPNZRJPLR(JPQHFFEHRHA a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7758E50", Offset = "0x7757C50", VA = "0x187758E50")]
		private void FPDOXRFTZMN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x775B510", Offset = "0x775A310", VA = "0x18775B510")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x775B2A0", Offset = "0x775A0A0", VA = "0x18775B2A0")]
		internal int RLLYCLPKZMW(URQKWMWFVTV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x77591E0", Offset = "0x7757FE0", VA = "0x1877591E0")]
		internal int FWQCSRLFOQA(URQKWMWFVTV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7759220", Offset = "0x7758020", VA = "0x187759220")]
		internal int FWQCSRLFOQA(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x775B300", Offset = "0x775A100", VA = "0x18775B300")]
		internal void ROREURIEXIB(bool a)
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
	internal sealed class URQKWMWFVTV
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int EXVGOPOQZIY;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] PQJLTEVDGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] ILQQPUOPUZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int ZFAVQKDWIFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object XTXAWHCVGFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public URQKWMWFVTV WTZHPJWUFXP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty QOCKRLGXWAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7766EA0", Offset = "0x7765CA0", VA = "0x187766EA0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7766C60", Offset = "0x7765A60", VA = "0x187766C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte SIDHZAUAYTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7766C00", Offset = "0x7765A00", VA = "0x187766C00")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7766FA0", Offset = "0x7765DA0", VA = "0x187766FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort QMJMZPUZBPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7766FE0", Offset = "0x7765DE0", VA = "0x187766FE0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7766F10", Offset = "0x7765D10", VA = "0x187766F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RUDKDZOIHQF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7766E70", Offset = "0x7765C70", VA = "0x187766E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte EASXRTSJEEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7766DC0", Offset = "0x7765BC0", VA = "0x187766DC0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7766F50", Offset = "0x7765D50", VA = "0x187766F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort XXTOVGYJBVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7766F80", Offset = "0x7765D80", VA = "0x187766F80")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7766E30", Offset = "0x7765C30", VA = "0x187766E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort FZWQXYAWENL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7766CA0", Offset = "0x7765AA0", VA = "0x187766CA0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7766ED0", Offset = "0x7765CD0", VA = "0x187766ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort FFOAFJVRTMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7767000", Offset = "0x7765E00", VA = "0x187767000")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7766DF0", Offset = "0x7765BF0", VA = "0x187766DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7767120", Offset = "0x7765F20", VA = "0x187767120")]
		static URQKWMWFVTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7766C30", Offset = "0x7765A30", VA = "0x187766C30")]
		public void DTPJYNWAGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7767500", Offset = "0x7766300", VA = "0x187767500")]
		public URQKWMWFVTV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x77673F0", Offset = "0x77661F0", VA = "0x1877673F0")]
		public URQKWMWFVTV(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x77670B0", Offset = "0x7765EB0", VA = "0x1877670B0")]
		public static int ZRQRTPYWQUI(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7767020", Offset = "0x7765E20", VA = "0x187767020")]
		public int ZRQRTPYWQUI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7766CC0", Offset = "0x7765AC0", VA = "0x187766CC0")]
		public bool HBTWUTQDGYF()
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
	public class BMWKYROENAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class BXCDHRHVFIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public URQKWMWFVTV[] QOEWUMXUIGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int JXZOFLYAOSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int ZKYHNTDUSTV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte EASXRTSJEEO;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public BXCDHRHVFIR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int HSEUWTQEZPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int JEKMTEUIMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int JNVYQQOHMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double HSHVDYLMROB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int KROBVDZLHOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int IGDGKBQKMWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int MZIREBLDCBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch DLJXKTAQFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int JHDAVJAVHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long JHQDLYGPDYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object CNWUEBRCNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal BMWKYROENAP UOGJIBJRKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal BMWKYROENAP YELWDDQMQEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<URQKWMWFVTV> RJJGSGKSHQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<LGAUOZBVEOI> ABEMONKPZHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly LGAUOZBVEOI[] USTGJMUSUQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int DBNPKUKEAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int MCKLFCWOOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool MLDYSGPKWNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int LYETTPRXZPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int MIHGBPZCXPV;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int LYCMCKINCBJ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int CCONKOXFBCI = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object VLNYVNXKZFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int CUGYPEVLPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, BXCDHRHVFIR> EPKWROBRTFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> VPIPRVWHBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly URQKWMWFVTV IUDEOXLEOVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int FZOPBDJRNWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int OCUURWLOJVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint ZEDJWPHLUOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int BUNNHSVSWFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int JNZDOXAHKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long KUGGXTYQQLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte HWYUXFPVVMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState EMGOMFUZLFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private URQKWMWFVTV JGLXZUDPJWP;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int BUTXXAQVEXH = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int IZGZEATTZDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly URQKWMWFVTV SHCMOOWFRSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly URQKWMWFVTV JWIBMYOYQRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly URQKWMWFVTV VDRJEEDFAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly URQKWMWFVTV QAETRFDGPUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality NFAXIOBCQKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly EQDSUDNIBGS EQDSUDNIBGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int ZVXCDESMJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object ESALYIZAFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly TQWULVIHMTS OPQXSZLCEVB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte WDTDBHDBLSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAF43A0", Offset = "0xAF31A0", VA = "0x180AF43A0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7756950", Offset = "0x7755750", VA = "0x187756950")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint UHLHWWCPRHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xC32CD0", Offset = "0xC31AD0", VA = "0x180C32CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState RSZQDFLEUUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x126BBE0", Offset = "0x126A9E0", VA = "0x18126BBE0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long PAPPGCPNRCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xACDAA0", Offset = "0xACC8A0", VA = "0x180ACDAA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int ODLERTOLRTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1FD1780", Offset = "0x1FD0580", VA = "0x181FD1780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x210DC30", Offset = "0x210CA30", VA = "0x18210DC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int SPTLEQVNWEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7753860", Offset = "0x7752660", VA = "0x187753860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int SBGCVTYKIZX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAE5670", Offset = "0xAE4470", VA = "0x180AE5670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double DRPJKNKZDYO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2883EB0", Offset = "0x2882CB0", VA = "0x182883EB0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate HOZYNBWEOWM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7755BE0", Offset = "0x77549E0", VA = "0x187755BE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7756B90", Offset = "0x7755990", VA = "0x187756B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7757050", Offset = "0x7755E50", VA = "0x187757050")]
		internal BMWKYROENAP(EQDSUDNIBGS a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7753A00", Offset = "0x7752800", VA = "0x187753A00")]
		internal void KCGPGYVGWRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7754EB0", Offset = "0x7753CB0", VA = "0x187754EB0")]
		internal void RPPXJLRNLBQ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x77536D0", Offset = "0x77524D0", VA = "0x1877536D0")]
		internal void CDHEBCBEPWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7754450", Offset = "0x7753250", VA = "0x187754450")]
		private void NCJOSRUJAOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x77534D0", Offset = "0x77522D0", VA = "0x1877534D0")]
		private void AKXHXBGAUGQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7756C40", Offset = "0x7755A40", VA = "0x187756C40")]
		public int ZRVANENTBYS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7756D50", Offset = "0x7755B50", VA = "0x187756D50")]
		public int ZRVANENTBYS(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7756A00", Offset = "0x7755800", VA = "0x187756A00")]
		private LGAUOZBVEOI XQCKJOCVRIT(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7757450", Offset = "0x7756250", VA = "0x187757450")]
		internal BMWKYROENAP(EQDSUDNIBGS a, IPEndPoint b, int c, byte d, XOADITSHTZG e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7756E70", Offset = "0x7755C70", VA = "0x187756E70")]
		internal BMWKYROENAP(EQDSUDNIBGS a, LRXKPYUEFRT b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7754EE0", Offset = "0x7753CE0", VA = "0x187754EE0")]
		internal void Reject(YUPYITPLATK requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x77537B0", Offset = "0x77525B0", VA = "0x1877537B0")]
		internal bool EBALFEBQRMR(EBWRQVWVWFF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7753830", Offset = "0x7752630", VA = "0x187753830")]
		public void ECUKHSHYZYC(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7756360", Offset = "0x7755160", VA = "0x187756360")]
		private void VOUVBCFREFR(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7753760", Offset = "0x7752560", VA = "0x187753760")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7754DB0", Offset = "0x7753BB0", VA = "0x187754DB0")]
		internal DisconnectResult QUYITBNTDFV(URQKWMWFVTV a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7754E50", Offset = "0x7753C50", VA = "0x187754E50")]
		internal void QZPWOMBSTEA(LGAUOZBVEOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x77556C0", Offset = "0x77544C0", VA = "0x1877556C0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x77539C0", Offset = "0x77527C0", VA = "0x1877539C0")]
		private void KAWKVGHXSTT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7754520", Offset = "0x7753320", VA = "0x187754520")]
		internal void PLPSPSIZLBP(DeliveryMethod a, URQKWMWFVTV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7755190", Offset = "0x7753F90", VA = "0x187755190")]
		private void SIGKSHOLMCT(URQKWMWFVTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x77540C0", Offset = "0x7752EC0", VA = "0x1877540C0")]
		private void MLXNIQVXYWH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7753510", Offset = "0x7752310", VA = "0x187753510")]
		internal ConnectRequestResult AZSFSMXOYXI(YUPYITPLATK a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7753A20", Offset = "0x7752820", VA = "0x187753A20")]
		internal void KVIYRCKTUNX(URQKWMWFVTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7753870", Offset = "0x7752670", VA = "0x187753870")]
		private void HSXVYTEBKIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x77559D0", Offset = "0x77547D0", VA = "0x1877559D0")]
		internal void UFHBRCCVNLP(URQKWMWFVTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7755C90", Offset = "0x7754A90", VA = "0x187755C90")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7754F30", Offset = "0x7753D30", VA = "0x187754F30")]
		internal void SFBBFPZOOGH(URQKWMWFVTV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class TQWULVIHMTS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long JEACGIGUWFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long MYVIYTLREUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long UWQPOICDVPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long IVFYRNLBHDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long BSRFZGBQGUG;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long OMCTPFESKJH;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long HTXEEFJTGOE;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long FYNPQPGXBNR;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long WGVDPKXTJRM;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long CRLTLHCNHOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long ZVMQZDIHEXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long ENEMKCGQYNM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long WPBTSJURAQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7765AD0", Offset = "0x77648D0", VA = "0x187765AD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long WWMIMOPQAHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7765AC0", Offset = "0x77648C0", VA = "0x187765AC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long IUNSPTRPTYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7765A70", Offset = "0x7764870", VA = "0x187765A70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long YOAZUIRGSQE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7765FD0", Offset = "0x7764DD0", VA = "0x187765FD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long SBKRIUHPBID
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x77658E0", Offset = "0x77646E0", VA = "0x1877658E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long YCBJFEQQPTT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7765A60", Offset = "0x7764860", VA = "0x187765A60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long KJLULUOGEDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7765A80", Offset = "0x7764880", VA = "0x187765A80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long JEEYGQVLBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7765FE0", Offset = "0x7764DE0", VA = "0x187765FE0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality RRGWQMUVGOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x11D5CC0", Offset = "0x11D4AC0", VA = "0x1811D5CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double SOPFNIMPNCU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7765BD0", Offset = "0x77649D0", VA = "0x187765BD0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7765B30", Offset = "0x7764930", VA = "0x187765B30")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x77658F0", Offset = "0x77646F0", VA = "0x1877658F0")]
		public void FWHZLDXELIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7765AE0", Offset = "0x77648E0", VA = "0x187765AE0")]
		public void PZGYCWFTUKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7765F60", Offset = "0x7764D60", VA = "0x187765F60")]
		public void VTRWNQUAICQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7765950", Offset = "0x7764750", VA = "0x187765950")]
		public void HHCAWQXGWTH(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7765B70", Offset = "0x7764970", VA = "0x187765B70")]
		public void SLUDHGJTJQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7766020", Offset = "0x7764E20", VA = "0x187766020")]
		public void YVLBCFETJEU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7765C30", Offset = "0x7764A30", VA = "0x187765C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77659C0", Offset = "0x77647C0", VA = "0x1877659C0")]
		public void INGFAIQJDBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public TQWULVIHMTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class NTCRFGSUQWQ
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> JCHROERTXOV;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7761840", Offset = "0x7760640", VA = "0x187761840")]
		public static IPEndPoint TBPEPFOUJJJ(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7761A80", Offset = "0x7760880", VA = "0x187761A80")]
		public static IPAddress UFQUARHOKRC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7761C50", Offset = "0x7760A50", VA = "0x187761C50")]
		public static IPAddress UFQUARHOKRC(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7761810", Offset = "0x7760610", VA = "0x187761810")]
		internal static int PREGVZLQURO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3937C60", Offset = "0x3936A60", VA = "0x183937C60")]
		internal static T[] LQLGVCBBGCZ<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class PYLHCOOWORX : LGAUOZBVEOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private URQKWMWFVTV _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7764940", Offset = "0x7763740", VA = "0x187764940", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x77648B0", Offset = "0x77636B0", VA = "0x1877648B0")]
			public void NRKVJJKJWDM(URQKWMWFVTV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x77648D0", Offset = "0x77636D0", VA = "0x1877648D0")]
			public bool RDEWSBKZWWH(long a, BMWKYROENAP b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7764860", Offset = "0x7763660", VA = "0x187764860")]
			public bool Clear(BMWKYROENAP peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly URQKWMWFVTV MGMQXMNAACR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] VUJKYNTICVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly URQKWMWFVTV[] HGLWGMBLMQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] UQTJDWTWXTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int QSGEMPOZDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int GDQZOVHWKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int DJAJZUXNHAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int YVOVANCTSER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool SSUXNUHDPDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod WWGPVHCHOYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool XCZCQEAGMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int SVUXQXMIGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte JRHWNCLVCAQ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int LFOYMYUSUTF
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7763CB0", Offset = "0x7762AB0", VA = "0x187763CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7764640", Offset = "0x7763440", VA = "0x187764640")]
		public PYLHCOOWORX(BMWKYROENAP a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7763CC0", Offset = "0x7762AC0", VA = "0x187763CC0")]
		private void KSOLPUACJXY(URQKWMWFVTV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x77637E0", Offset = "0x77625E0", VA = "0x1877637E0", Slot = "4")]
		protected override bool APAPHLCXZUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7764040", Offset = "0x7762E40", VA = "0x187764040", Slot = "5")]
		public override bool KVIYRCKTUNX(URQKWMWFVTV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class BLHPRLYKMAK : LGAUOZBVEOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int MQRDSNBAASB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort GDQZOVHWKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool TVYWHDLCMWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private URQKWMWFVTV GFVJOAEMMVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly URQKWMWFVTV YFOKOAXVSLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool VYUMIPKAFZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte JRHWNCLVCAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long PMIACNDOULA;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7753410", Offset = "0x7752210", VA = "0x187753410")]
		public BLHPRLYKMAK(BMWKYROENAP a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7752CD0", Offset = "0x7751AD0", VA = "0x187752CD0", Slot = "4")]
		protected override bool APAPHLCXZUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7753190", Offset = "0x7751F90", VA = "0x187753190", Slot = "5")]
		public override bool KVIYRCKTUNX(URQKWMWFVTV a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class BPPJDXZQDMP
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
		[Cpp2IlInjected.Address(RVA = "0x7751E00", Offset = "0x7750C00", VA = "0x187751E00")]
		private static void IWQECWJHYXC(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7757620", Offset = "0x7756420", VA = "0x187757620")]
		private static void IWQECWJHYXC(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x77575E0", Offset = "0x77563E0", VA = "0x1877575E0")]
		public static void IWQECWJHYXC(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7757690", Offset = "0x7756490", VA = "0x187757690")]
		public static void THDCOOXVWRN(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x77576C0", Offset = "0x77564C0", VA = "0x1877576C0")]
		public static void THDCOOXVWRN(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x77575E0", Offset = "0x77563E0", VA = "0x1877575E0")]
		public static void THDCOOXVWRN(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x77575E0", Offset = "0x77563E0", VA = "0x1877575E0")]
		public static void THDCOOXVWRN(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7757620", Offset = "0x7756420", VA = "0x187757620")]
		public static void THDCOOXVWRN(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7757620", Offset = "0x7756420", VA = "0x187757620")]
		public static void THDCOOXVWRN(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x77576B0", Offset = "0x77564B0", VA = "0x1877576B0")]
		public static void THDCOOXVWRN(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x77576B0", Offset = "0x77564B0", VA = "0x1877576B0")]
		public static void THDCOOXVWRN(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AWTVWEPWQCQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] IAWXQIOHVMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int OAFZSTVVYDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int AFIORQEGKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int KREKWBJLVCK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] ILQQPUOPUZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int WGOMHMKWBXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAD8650", Offset = "0xAD7450", VA = "0x180AD8650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int AERSLOATERQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7752660", Offset = "0x7751460", VA = "0x187752660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BIOPXIPYOMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x27E1A30", Offset = "0x27E0830", VA = "0x1827E1A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int NLEUFYEOMMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7752B20", Offset = "0x7751920", VA = "0x187752B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7752820", Offset = "0x7751620", VA = "0x187752820")]
		public void PQVROWYSDEZ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AWTVWEPWQCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7752C70", Offset = "0x7751A70", VA = "0x187752C70")]
		public AWTVWEPWQCQ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x77524C0", Offset = "0x77512C0", VA = "0x1877524C0")]
		public IPEndPoint DHDBWHRRPGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7752460", Offset = "0x7751260", VA = "0x187752460")]
		public byte UCZTDIQIACK()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7752460", Offset = "0x7751260", VA = "0x187752460")]
		public sbyte CPSMTICZERN()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x30ED480", Offset = "0x30EC280", VA = "0x1830ED480")]
		public a[] UQBUNTHRREF<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7752550", Offset = "0x7751350", VA = "0x187752550")]
		public bool[] EWCXEPQGAWV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7752A70", Offset = "0x7751870", VA = "0x187752A70")]
		public ushort[] RCLKHXFYZXO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x77527A0", Offset = "0x77515A0", VA = "0x1877527A0")]
		public short[] LXVVJHYKXGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7752B70", Offset = "0x7751970", VA = "0x187752B70")]
		public int[] TBGDNTYZFZI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x77527E0", Offset = "0x77515E0", VA = "0x1877527E0")]
		public uint[] PFTTBVJEMAR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7752BB0", Offset = "0x77519B0", VA = "0x187752BB0")]
		public float[] TKZBFXBGAQP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7752C30", Offset = "0x7751A30", VA = "0x187752C30")]
		public double[] ZAWWVRMQLGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7752420", Offset = "0x7751220", VA = "0x187752420")]
		public long[] AGGIBGSGZJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x77523E0", Offset = "0x77511E0", VA = "0x1877523E0")]
		public ulong[] ABSIJGDAGKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7752670", Offset = "0x7751470", VA = "0x187752670")]
		public string[] JRLAECNEJRI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7752BF0", Offset = "0x77519F0", VA = "0x187752BF0")]
		public bool YAPATREBKPW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7752770", Offset = "0x7751570", VA = "0x187752770")]
		public char PIUXKTIMMIA()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7752770", Offset = "0x7751570", VA = "0x187752770")]
		public ushort VLNGBVCRMZB()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7752770", Offset = "0x7751570", VA = "0x187752770")]
		public short LLUSJOERLOO()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7752740", Offset = "0x7751540", VA = "0x187752740")]
		public long TBNLXKZRVNE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7752740", Offset = "0x7751540", VA = "0x187752740")]
		public ulong KMIEXQTNMYV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7752600", Offset = "0x7751400", VA = "0x187752600")]
		public int GQEEKBEZGCZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7752600", Offset = "0x7751400", VA = "0x187752600")]
		public uint JAKOSJIOPUI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x77525D0", Offset = "0x77513D0", VA = "0x1877525D0")]
		public float FMSENFPRTOW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7752630", Offset = "0x7751430", VA = "0x187752630")]
		public double IKWVXGFTZYN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7752860", Offset = "0x7751660", VA = "0x187752860")]
		public string QJWYOJSOHIZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7752AB0", Offset = "0x77518B0", VA = "0x187752AB0")]
		public ArraySegment<byte> RRJNSBROSHK(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7752590", Offset = "0x7751390", VA = "0x187752590")]
		public sbyte[] EWUZZFZICVW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7752B30", Offset = "0x7751930", VA = "0x187752B30")]
		public byte[] SJWZGTRCPRZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x77524A0", Offset = "0x77512A0", VA = "0x1877524A0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class XOADITSHTZG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] IAWXQIOHVMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int OAFZSTVVYDU;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int NQXBCQWRWVT = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool ISSVEUECXPI;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding IRTVWDJOAOC;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int KHRKRPAZOOT = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] RBCIQHCNVBM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] FFDULGKWPQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int ZLALHUOTOGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7768F40", Offset = "0x7767D40", VA = "0x187768F40")]
		public XOADITSHTZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7768FC0", Offset = "0x7767DC0", VA = "0x187768FC0")]
		public XOADITSHTZG(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7768220", Offset = "0x7767020", VA = "0x187768220")]
		public static XOADITSHTZG GCZYJHDFTUV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x77689D0", Offset = "0x77677D0", VA = "0x1877689D0")]
		public void WUVYQCHBFJV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x285A300", Offset = "0x2859100", VA = "0x18285A300")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7768920", Offset = "0x7767720", VA = "0x187768920")]
		public void OJIMXNBOJKB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7768870", Offset = "0x7767670", VA = "0x187768870")]
		public void OJIMXNBOJKB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7768750", Offset = "0x7767550", VA = "0x187768750")]
		public void OJIMXNBOJKB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7768750", Offset = "0x7767550", VA = "0x187768750")]
		public void OJIMXNBOJKB(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7768370", Offset = "0x7767170", VA = "0x187768370")]
		public void OJIMXNBOJKB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7768370", Offset = "0x7767170", VA = "0x187768370")]
		public void OJIMXNBOJKB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x77684D0", Offset = "0x77672D0", VA = "0x1877684D0")]
		public void OJIMXNBOJKB(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x77684D0", Offset = "0x77672D0", VA = "0x1877684D0")]
		public void OJIMXNBOJKB(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x77684D0", Offset = "0x77672D0", VA = "0x1877684D0")]
		public void OJIMXNBOJKB(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7768470", Offset = "0x7767270", VA = "0x187768470")]
		public void OJIMXNBOJKB(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7768470", Offset = "0x7767270", VA = "0x187768470")]
		public void OJIMXNBOJKB(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7768400", Offset = "0x7767200", VA = "0x187768400")]
		public void OJIMXNBOJKB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7768290", Offset = "0x7767090", VA = "0x187768290")]
		public void JSKTMGEKMBH(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7768290", Offset = "0x7767090", VA = "0x187768290")]
		public void VVJIVEATMOQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x77688C0", Offset = "0x77676C0", VA = "0x1877688C0")]
		public void OJIMXNBOJKB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7768D10", Offset = "0x7767B10", VA = "0x187768D10")]
		public void YWJREUTHCGG(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7768B50", Offset = "0x7767950", VA = "0x187768B50")]
		public void YWJREUTHCGG(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7768C30", Offset = "0x7767A30", VA = "0x187768C30")]
		public void YWJREUTHCGG(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7768C30", Offset = "0x7767A30", VA = "0x187768C30")]
		public void YWJREUTHCGG(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7768C30", Offset = "0x7767A30", VA = "0x187768C30")]
		public void YWJREUTHCGG(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7768B50", Offset = "0x7767950", VA = "0x187768B50")]
		public void YWJREUTHCGG(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7768B50", Offset = "0x7767950", VA = "0x187768B50")]
		public void YWJREUTHCGG(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7768A70", Offset = "0x7767870", VA = "0x187768A70")]
		public void YWJREUTHCGG(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7768A70", Offset = "0x7767870", VA = "0x187768A70")]
		public void YWJREUTHCGG(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7768290", Offset = "0x7767090", VA = "0x187768290")]
		public void YWJREUTHCGG(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7768DF0", Offset = "0x7767BF0", VA = "0x187768DF0")]
		public void YWJREUTHCGG(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x77687A0", Offset = "0x77675A0", VA = "0x1877687A0")]
		public void OJIMXNBOJKB(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x77689C0", Offset = "0x77677C0", VA = "0x1877689C0")]
		public void OJIMXNBOJKB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7768540", Offset = "0x7767340", VA = "0x187768540")]
		public void OJIMXNBOJKB(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ZFQREOHHWFP
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class QADHVRDELIZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong ZVXCDESMJGV;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5CD2170", Offset = "0x5CD0F70", VA = "0x185CD2170")]
			static QADHVRDELIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(AWTVWEPWQCQ reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class PEVLYQYKJWO<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public ZFQREOHHWFP FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a FZERDNJVQPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> VGWNWQPGGCK;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public PEVLYQYKJWO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5C3E260", Offset = "0x5C3D060", VA = "0x185C3E260")]
			internal void RUBBIYUJFVD(AWTVWEPWQCQ a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class YTESSIPTGYK<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public ZFQREOHHWFP FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a FZERDNJVQPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> VGWNWQPGGCK;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public YTESSIPTGYK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3FCC940", Offset = "0x3FCB740", VA = "0x183FCC940")]
			internal void RUBBIYUJFVD(AWTVWEPWQCQ a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly ODCTZJSJIEH ZAQFMIBWGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> TYRFMTGELJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly XOADITSHTZG RZYCCZRQZAD;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7769670", Offset = "0x7768470", VA = "0x187769670")]
		public ZFQREOHHWFP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0120", Offset = "0x3CBEF20", VA = "0x183CC0120", Slot = "4")]
		protected virtual ulong RWIQKTDYYNS<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x77694D0", Offset = "0x77682D0", VA = "0x1877694D0", Slot = "5")]
		protected virtual SubscribeDelegate BJQUMJJDZXZ(AWTVWEPWQCQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC00A0", Offset = "0x3CBEEA0", VA = "0x183CC00A0", Slot = "6")]
		protected virtual void LKWDNPGRWTZ<b>(XOADITSHTZG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x77695F0", Offset = "0x77683F0", VA = "0x1877695F0")]
		public void QFQQCYLXNOY(AWTVWEPWQCQ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0010", Offset = "0x3CBEE10", VA = "0x183CC0010")]
		public void DOQRKGDHTJZ<j>(XOADITSHTZG a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x77695A0", Offset = "0x77683A0", VA = "0x1877695A0")]
		public void GIXMBPBWFWU(AWTVWEPWQCQ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFE90", Offset = "0x3CBEC90", VA = "0x183CBFE90")]
		public void CPYDQCOSNDT<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFE90", Offset = "0x3CBEC90", VA = "0x183CBFE90")]
		public void CPYDQCOSNDT<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x775FC70", Offset = "0x775EA70", VA = "0x18775FC70")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7764800", Offset = "0x7763600", VA = "0x187764800")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class ODCTZJSJIEH
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
		private abstract class EQHPVITELBX<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType ULTKTFGCAFO;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4851330", Offset = "0x4850130", VA = "0x184851330", Slot = "4")]
			public virtual void NRKVJJKJWDM(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void KCDAOKMJOHG(a a, AWTVWEPWQCQ b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void DOQRKGDHTJZ(a a, XOADITSHTZG b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void YPZCYHAZWZK(a a, XOADITSHTZG b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void RJKWMAKLEKY(a a, AWTVWEPWQCQ b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void OSNXFKNCFBR(a a, XOADITSHTZG b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			protected EQHPVITELBX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class WYGYUJWOBII<a, b> : EQHPVITELBX<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> MJSPYVGWSUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> HUSPLLTVVKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> EQOPJGZWFVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> RNWASTDLWUC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> EHLVSLOCGCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> NUVHBAUUVXB;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x6872930", Offset = "0x6871730", VA = "0x186872930", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6872930", Offset = "0x6871730", VA = "0x186872930", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x6873080", Offset = "0x6871E80", VA = "0x186873080", Slot = "9")]
			public override void RJKWMAKLEKY(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6873080", Offset = "0x6871E80", VA = "0x186873080", Slot = "10")]
			public override void OSNXFKNCFBR(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6872A00", Offset = "0x6871800", VA = "0x186872A00")]
			protected b[] GHFWCONSWFH(a a, AWTVWEPWQCQ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6873150", Offset = "0x6871F50", VA = "0x186873150")]
			protected b[] SWQVYUVOKLG(a a, XOADITSHTZG b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6872AE0", Offset = "0x68718E0", VA = "0x186872AE0", Slot = "4")]
			public override void NRKVJJKJWDM(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x68731B0", Offset = "0x6871FB0", VA = "0x1868731B0")]
			protected WYGYUJWOBII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class YWEGDONGMNN<a, b> : WYGYUJWOBII<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void NFUPHTATCFC(AWTVWEPWQCQ a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void PYPTHNEQELR(XOADITSHTZG a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3FCD7D0", Offset = "0x3FCC5D0", VA = "0x183FCD7D0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3FCD120", Offset = "0x3FCBF20", VA = "0x183FCD120", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3FCD470", Offset = "0x3FCC270", VA = "0x183FCD470", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3FCD830", Offset = "0x3FCC630", VA = "0x183FCD830", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3FCDAD0", Offset = "0x3FCC8D0", VA = "0x183FCDAD0")]
			protected YWEGDONGMNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class RZAYFYJCWZI<a> : WYGYUJWOBII<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x5B2ADF0", Offset = "0x5B29BF0", VA = "0x185B2ADF0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5B2AA40", Offset = "0x5B29840", VA = "0x185B2AA40", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC430", Offset = "0x5DDB230", VA = "0x185DDC430", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3DE08B0", Offset = "0x3DDF6B0", VA = "0x183DE08B0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public RZAYFYJCWZI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class OIVAWBYAVID<a> : WYGYUJWOBII<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5B2ADF0", Offset = "0x5B29BF0", VA = "0x185B2ADF0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x5B2AA40", Offset = "0x5B29840", VA = "0x185B2AA40", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x5B2AC80", Offset = "0x5B29A80", VA = "0x185B2AC80", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE08B0", Offset = "0x3DDF6B0", VA = "0x183DE08B0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public OIVAWBYAVID()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class YQZFXRCVPDP<a> : WYGYUJWOBII<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB7C0", Offset = "0x3FCA5C0", VA = "0x183FCB7C0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB500", Offset = "0x3FCA300", VA = "0x183FCB500", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB640", Offset = "0x3FCA440", VA = "0x183FCB640", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB920", Offset = "0x3FCA720", VA = "0x183FCB920", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public YQZFXRCVPDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class OWPAEAKJNAE<a> : WYGYUJWOBII<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB7C0", Offset = "0x3FCA5C0", VA = "0x183FCB7C0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB500", Offset = "0x3FCA300", VA = "0x183FCB500", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5B4D450", Offset = "0x5B4C250", VA = "0x185B4D450", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB920", Offset = "0x3FCA720", VA = "0x183FCB920", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public OWPAEAKJNAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class MGCCYPBBEVL<a> : WYGYUJWOBII<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5953960", Offset = "0x5952760", VA = "0x185953960", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x59537D0", Offset = "0x59525D0", VA = "0x1859537D0", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5953810", Offset = "0x5952610", VA = "0x185953810", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x56690A0", Offset = "0x5667EA0", VA = "0x1856690A0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public MGCCYPBBEVL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class NAMNPOAGKSW<a> : WYGYUJWOBII<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5953960", Offset = "0x5952760", VA = "0x185953960", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x59537D0", Offset = "0x59525D0", VA = "0x1859537D0", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x59E59F0", Offset = "0x59E47F0", VA = "0x1859E59F0", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x56690A0", Offset = "0x5667EA0", VA = "0x1856690A0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public NAMNPOAGKSW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class RFECIRGUGIB<a> : WYGYUJWOBII<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5D70DA0", Offset = "0x5D6FBA0", VA = "0x185D70DA0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x5D70B00", Offset = "0x5D6F900", VA = "0x185D70B00", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5D70D50", Offset = "0x5D6FB50", VA = "0x185D70D50", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3FC61D0", Offset = "0x3FC4FD0", VA = "0x183FC61D0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public RFECIRGUGIB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class RSIJQLKIMLG<a> : WYGYUJWOBII<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5D70DA0", Offset = "0x5D6FBA0", VA = "0x185D70DA0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5D70B00", Offset = "0x5D6F900", VA = "0x185D70B00", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5DDAB10", Offset = "0x5DD9910", VA = "0x185DDAB10", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3FC61D0", Offset = "0x3FC4FD0", VA = "0x183FC61D0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public RSIJQLKIMLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class CPQJLNNUQER<a> : WYGYUJWOBII<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0860", Offset = "0x3DDF660", VA = "0x183DE0860", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DE04A0", Offset = "0x3DDF2A0", VA = "0x183DE04A0", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x3DE06F0", Offset = "0x3DDF4F0", VA = "0x183DE06F0", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3DE08B0", Offset = "0x3DDF6B0", VA = "0x183DE08B0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public CPQJLNNUQER()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class AMRLNBOJTZA<a> : WYGYUJWOBII<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x5669050", Offset = "0x5667E50", VA = "0x185669050", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x5668DA0", Offset = "0x5667BA0", VA = "0x185668DA0", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x5668EE0", Offset = "0x5667CE0", VA = "0x185668EE0", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x56690A0", Offset = "0x5667EA0", VA = "0x1856690A0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public AMRLNBOJTZA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class YNQYNVHILOP<a> : WYGYUJWOBII<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x3FC6070", Offset = "0x3FC4E70", VA = "0x183FC6070", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x3FC5DC0", Offset = "0x3FC4BC0", VA = "0x183FC5DC0", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x3FC5F00", Offset = "0x3FC4D00", VA = "0x183FC5F00", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x3FC61D0", Offset = "0x3FC4FD0", VA = "0x183FC61D0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0A20", Offset = "0x3DDF820", VA = "0x183DE0A20")]
			public YNQYNVHILOP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class FKQXLWIGLCL<a> : YWEGDONGMNN<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4E88350", Offset = "0x4E87150", VA = "0x184E88350", Slot = "12")]
			protected override void PYPTHNEQELR(XOADITSHTZG a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x4E88320", Offset = "0x4E87120", VA = "0x184E88320", Slot = "11")]
			protected override void NFUPHTATCFC(AWTVWEPWQCQ a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD4C0", Offset = "0x3DDC2C0", VA = "0x183DDD4C0")]
			public FKQXLWIGLCL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class CEQYDRHJHIL<a> : YWEGDONGMNN<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD490", Offset = "0x3DDC290", VA = "0x183DDD490", Slot = "12")]
			protected override void PYPTHNEQELR(XOADITSHTZG a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD450", Offset = "0x3DDC250", VA = "0x183DDD450", Slot = "11")]
			protected override void NFUPHTATCFC(AWTVWEPWQCQ a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD4C0", Offset = "0x3DDC2C0", VA = "0x183DDD4C0")]
			public CEQYDRHJHIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class EGWAKPQNBYW<a> : WYGYUJWOBII<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int NZRHMMOAHOJ;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x484B5E0", Offset = "0x484A3E0", VA = "0x18484B5E0")]
			public EGWAKPQNBYW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x484B2B0", Offset = "0x484A0B0", VA = "0x18484B2B0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x484B0E0", Offset = "0x4849EE0", VA = "0x18484B0E0", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x484B130", Offset = "0x4849F30", VA = "0x18484B130", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x484B430", Offset = "0x484A230", VA = "0x18484B430", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class KCICRPUIIMY<a> : EQHPVITELBX<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo QOCKRLGXWAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type XQKCHMCZFTP;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x537B690", Offset = "0x537A490", VA = "0x18537B690")]
			public KCICRPUIIMY(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x537B410", Offset = "0x537A210", VA = "0x18537B410", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x537B230", Offset = "0x537A030", VA = "0x18537B230", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x537B3C0", Offset = "0x537A1C0", VA = "0x18537B3C0", Slot = "7")]
			public override void FYOIRQQPQIJ(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x537B3C0", Offset = "0x537A1C0", VA = "0x18537B3C0", Slot = "8")]
			public override void YPZCYHAZWZK(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x537B5E0", Offset = "0x537A3E0", VA = "0x18537B5E0", Slot = "9")]
			public override void RJKWMAKLEKY(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x537B5E0", Offset = "0x537A3E0", VA = "0x18537B5E0", Slot = "10")]
			public override void OSNXFKNCFBR(a a, XOADITSHTZG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class WACICRRCUWR<a> : KCICRPUIIMY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x6865050", Offset = "0x6863E50", VA = "0x186865050")]
			public WACICRRCUWR(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x6864FB0", Offset = "0x6863DB0", VA = "0x186864FB0", Slot = "5")]
			public override void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x6864CF0", Offset = "0x6863AF0", VA = "0x186864CF0", Slot = "6")]
			public override void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class OQYJLGXBDOP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static OQYJLGXBDOP<a> PKFRARWZTTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly EQHPVITELBX<a>[] IDRZUMMLRBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int PFCYELVNUST;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x5B3DA90", Offset = "0x5B3C890", VA = "0x185B3DA90")]
			public OQYJLGXBDOP(List<EQHPVITELBX<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D5D0", Offset = "0x5B3C3D0", VA = "0x185B3D5D0")]
			public void DOQRKGDHTJZ(a a, XOADITSHTZG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D9E0", Offset = "0x5B3C7E0", VA = "0x185B3D9E0")]
			public void KCDAOKMJOHG(a a, AWTVWEPWQCQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class ZTGTPQYGWOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract EQHPVITELBX<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private XOADITSHTZG NEJYDYWHCZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int WJAOCMMADYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, ZTGTPQYGWOH> IMKOGKUFMKC;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7763750", Offset = "0x7762550", VA = "0x187763750")]
		public ODCTZJSJIEH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39749A0", Offset = "0x39737A0", VA = "0x1839749A0")]
		private OQYJLGXBDOP<d> KXQCTPUAKCI<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3973AB0", Offset = "0x39728B0", VA = "0x183973AB0")]
		public void DELFABVRANX<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3973AF0", Offset = "0x39728F0", VA = "0x183973AF0")]
		public bool Deserialize<T>(AWTVWEPWQCQ reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3975730", Offset = "0x3974530", VA = "0x183975730")]
		public void ZLPVCWRAQLQ<f>(XOADITSHTZG a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NUAGIRTWHKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime BSFZPLWQMGR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] BAKZVFDILEP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator UXYCDAFPWFN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7761D70", Offset = "0x7760B70", VA = "0x187761D70")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int GAUABDWYGLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x7762700", Offset = "0x7761500", VA = "0x187762700")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x7762BC0", Offset = "0x77619C0", VA = "0x187762BC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode YUSYSEDRHCT
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x7762760", Offset = "0x7761560", VA = "0x187762760")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x7762660", Offset = "0x7761460", VA = "0x187762660")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int SUSHKZQHCFW
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7762C00", Offset = "0x7761A00", VA = "0x187762C00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint QOGIXMOXXEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7762440", Offset = "0x7761240", VA = "0x187762440")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? PZKFFBWDCLE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7762730", Offset = "0x7761530", VA = "0x187762730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? EAQLOBKLPAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7762C30", Offset = "0x7761A30", VA = "0x187762C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? TKSNHQKKTKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x77621F0", Offset = "0x7760FF0", VA = "0x1877621F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x7761DA0", Offset = "0x7760BA0", VA = "0x187761DA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? MZMNNPKZBPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xB611B0", Offset = "0xB5FFB0", VA = "0x180B611B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xD47FC0", Offset = "0xD46DC0", VA = "0x180D47FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7762E70", Offset = "0x7761C70", VA = "0x187762E70")]
		public NUAGIRTWHKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7762DD0", Offset = "0x7761BD0", VA = "0x187762DD0")]
		internal NUAGIRTWHKO(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7762C60", Offset = "0x7761A60", VA = "0x187762C60")]
		public static NUAGIRTWHKO ZUUWNJKCHVC(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7762840", Offset = "0x7761640", VA = "0x187762840")]
		internal void XEUUYHEAZTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x77624A0", Offset = "0x77612A0", VA = "0x1877624A0")]
		private void KPNGOLIIMHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7762020", Offset = "0x7760E20", VA = "0x187762020")]
		private DateTime? HKLHIGBPTFF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7762220", Offset = "0x7761020", VA = "0x187762220")]
		private void IQKTJOFWSSD(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7762790", Offset = "0x7761590", VA = "0x187762790")]
		private ulong WODXVUZOYXN(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7761F60", Offset = "0x7760D60", VA = "0x187761F60")]
		private void GVUQGPNZLWH(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x77626A0", Offset = "0x77614A0", VA = "0x1877626A0")]
		private uint PIKCFVDGIHC(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x761FF40", Offset = "0x761ED40", VA = "0x18761FF40")]
		private static uint ISTLOEMNSPN(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x77623E0", Offset = "0x77611E0", VA = "0x1877623E0")]
		private static ulong ISTLOEMNSPN(ulong a)
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
	internal sealed class VILWAIGGUNZ
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int BLPYBKNUEAY = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int JRYMGXJCLGB = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int QSDOINHXBRA = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint MNYZJWNBZFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int BUVFWTTPNUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int CFFBETVGCJO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool NBMGXAKZXXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7767700", Offset = "0x7766500", VA = "0x187767700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7767610", Offset = "0x7766410", VA = "0x187767610")]
		public bool ECUKHSHYZYC(JPQHFFEHRHA a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class QUMXHOAJGDR : JPQHFFEHRHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket TDXZQIKWNVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly EQDSUDNIBGS FSRFTHUFJHA;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short TBARLAGIOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x77650A0", Offset = "0x7763EA0", VA = "0x1877650A0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int QEXYYOJRWRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x77650C0", Offset = "0x7763EC0", VA = "0x1877650C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint WJOCMAUVEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x7764F70", Offset = "0x7763D70", VA = "0x187764F70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily GHADCYTUPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x3087B60", Offset = "0x3086960", VA = "0x183087B60", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7765120", Offset = "0x7763F20", VA = "0x187765120")]
		public QUMXHOAJGDR(AddressFamily a, EQDSUDNIBGS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x77649B0", Offset = "0x77637B0", VA = "0x1877649B0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x77650E0", Offset = "0x7763EE0", VA = "0x1877650E0", Slot = "9")]
		public int SRSLOCOEYUT(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7764F90", Offset = "0x7763D90", VA = "0x187764F90", Slot = "10")]
		public int COBWDRPHUBT(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7765080", Offset = "0x7763E80", VA = "0x187765080", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface JPQHFFEHRHA
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short TBARLAGIOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int QEXYYOJRWRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint WJOCMAUVEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily GHADCYTUPRC
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
		int SRSLOCOEYUT(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int COBWDRPHUBT(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x7763270", Offset = "0x7762070", VA = "0x187763270")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7763310", Offset = "0x7762110", VA = "0x187763310")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x14078F0", Offset = "0x14066F0", VA = "0x1814078F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7763180", Offset = "0x7761F80", VA = "0x187763180", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x77631C0", Offset = "0x7761FC0", VA = "0x1877631C0", Slot = "0")]
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
	public class FUMCJUHFUNZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string QCDYVXLUMHB = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int YNANVMHWQYN = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int BGQUSWYSMJF = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int ECBUJQPICST = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> YXSGHSLQNSK;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback CQDHKAINNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int BQENMCPYJAF;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		internal void ZUZMRUVSIKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		internal void EANDUWMCXFD(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class AQDXGWNVULC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int FBNUIMKDXJB;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
		protected AQDXGWNVULC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void NRUEYGVWPHM(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CPJMUOYYSHL(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class WIMOHFCZMXS : AQDXGWNVULC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] IBCPJYJQVFR;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator PIYOGINDQRD;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x295EF20", Offset = "0x295DD20", VA = "0x18295EF20")]
		public WIMOHFCZMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7768010", Offset = "0x7766E10", VA = "0x187768010")]
		public void XTYREZLFJWS(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7767AF0", Offset = "0x77668F0", VA = "0x187767AF0")]
		public void ILKDXZYEKPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7767BD0", Offset = "0x77669D0", VA = "0x187767BD0", Slot = "4")]
		public override void NRUEYGVWPHM(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x77677F0", Offset = "0x77665F0", VA = "0x1877677F0", Slot = "5")]
		public override void CPJMUOYYSHL(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class IRHWDWIVWIT
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7769AD0", Offset = "0x77688D0", VA = "0x187769AD0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7769C60", Offset = "0x7768A60", VA = "0x187769C60")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7769880", Offset = "0x7768680", VA = "0x187769880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7765200", Offset = "0x7764000", VA = "0x187765200")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x77651D0", Offset = "0x7763FD0", VA = "0x1877651D0")]
		private uint MQISKPSHWDA(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7752290", Offset = "0x7751090", VA = "0x187752290")]
		private void ZCOOLETSWNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7752080", Offset = "0x7750E80", VA = "0x187752080")]
		private void ORYTMXZOSTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7751FF0", Offset = "0x7750DF0", VA = "0x187751FF0")]
		private void KLCBUPAJMHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7751EF0", Offset = "0x7750CF0", VA = "0x187751EF0")]
		private void KBRBPCWXSCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7765280", Offset = "0x7764080", VA = "0x187765280")]
		private void SJEJKMJEYMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7765400", Offset = "0x7764200", VA = "0x187765400")]
		private unsafe void XACUOIUOJHK(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7765820", Offset = "0x7764620", VA = "0x187765820")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void YYKLLAVYWPD([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7765830", Offset = "0x7764630", VA = "0x187765830")]
		public static void YYKLLAVYWPD(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x77652E0", Offset = "0x77640E0", VA = "0x1877652E0")]
		public static void TSHFZDXYXWB(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7765390", Offset = "0x7764190", VA = "0x187765390")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void WFUOHVFMOJW([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7769DE0", Offset = "0x7768BE0", VA = "0x187769DE0")]
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
