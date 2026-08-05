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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, AOLAIRSGEKT
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
		private NetworkManager BOFYLGBUUBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool CPBBRUYDICT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, XBZXQDKASCO> JNLRNOWUXWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MGNESVRMCDL DCZXTKMMEUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch CKYFJXQMEQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] YWYEEGVSTUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType FULICMQFOAF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int QWLMOCIYUVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76E3050", Offset = "0x76E2050", VA = "0x1876E3050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x76E3000", Offset = "0x76E2000", VA = "0x1876E3000", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x76E2120", Offset = "0x76E1120", VA = "0x1876E2120")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76E2100", Offset = "0x76E1100", VA = "0x1876E2100")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76E1FD0", Offset = "0x76E0FD0", VA = "0x1876E1FD0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76E2C40", Offset = "0x76E1C40", VA = "0x1876E2C40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76E2300", Offset = "0x76E1300", VA = "0x1876E2300", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76E20C0", Offset = "0x76E10C0", VA = "0x1876E20C0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76E25D0", Offset = "0x76E15D0", VA = "0x1876E25D0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76E2960", Offset = "0x76E1960", VA = "0x1876E2960", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76E1A40", Offset = "0x76E0A40", VA = "0x1876E1A40", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76E1950", Offset = "0x76E0950", VA = "0x1876E1950", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76E1B80", Offset = "0x76E0B80", VA = "0x1876E1B80", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76E2560", Offset = "0x76E1560", VA = "0x1876E2560", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76E1C20", Offset = "0x76E0C20", VA = "0x1876E1C20", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76E2230", Offset = "0x76E1230", VA = "0x1876E2230")]
		private DeliveryMethod SQXYEBOIPZC(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76E2B80", Offset = "0x76E1B80", VA = "0x1876E2B80", Slot = "16")]
		private void UKPWSBWEBBZ(XBZXQDKASCO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76E1E30", Offset = "0x76E0E30", VA = "0x1876E1E30", Slot = "17")]
		private void LJNFTTPLQFB(XBZXQDKASCO a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "18")]
		private void SCWZUYCTEWA(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76E2D10", Offset = "0x76E1D10", VA = "0x1876E2D10", Slot = "19")]
		private void XSJGTPVYJIT(XBZXQDKASCO a, NIWYMTUMOQV b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76E1F00", Offset = "0x76E0F00", VA = "0x1876E1F00")]
		private void NZBKIZXCWBG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "20")]
		private void SMZHYFKQALR(IPEndPoint a, NIWYMTUMOQV b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "21")]
		private void YKLDRZVQUYR(XBZXQDKASCO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76E2C60", Offset = "0x76E1C60", VA = "0x1876E2C60", Slot = "22")]
		private void VYAJITNOQRL(XNPYVOBYHGI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x76E2CE0", Offset = "0x76E1CE0", VA = "0x1876E2CE0")]
		private ulong WTQFFBRRFRE(XBZXQDKASCO a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76E2CC0", Offset = "0x76E1CC0", VA = "0x1876E2CC0")]
		private ulong WTQFFBRRFRE(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x76E2F10", Offset = "0x76E1F10", VA = "0x1876E2F10")]
		private static int ZMUVHFSXBSD(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76E2F30", Offset = "0x76E1F30", VA = "0x1876E2F30")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76E1B50", Offset = "0x76E0B50", VA = "0x1876E1B50")]
		[CompilerGenerated]
		private void GSFOIYTOION(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76E1B50", Offset = "0x76E0B50", VA = "0x1876E1B50")]
		[CompilerGenerated]
		private void IIKPOQPCMTS(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class SIFERPMZMQV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly XBZXQDKASCO BUIKPGPTCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<EJPAVELXNXA> CCLJSZNFRMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int LALUHFDBXTB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DSHGTLSWPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x76EC8E0", Offset = "0x76EB8E0", VA = "0x1876EC8E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76EC9B0", Offset = "0x76EB9B0", VA = "0x1876EC9B0")]
		protected SIFERPMZMQV(XBZXQDKASCO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76EC840", Offset = "0x76EB840", VA = "0x1876EC840")]
		public void BZAUOHQSAZE(EJPAVELXNXA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76EC930", Offset = "0x76EB930", VA = "0x1876EC930")]
		protected void VYMJJLAPMCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x76EC8A0", Offset = "0x76EB8A0", VA = "0x1876EC8A0")]
		public bool DOWPFOPFNDT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool HUKZVZSTNMB();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool ODWJQVSTYYU(EJPAVELXNXA a);
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
	public class XNPYVOBYHGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MGNESVRMCDL NMERWNWHLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int WQZZEXVPRAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal JVDULATUVMJ SXCZJSWBFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint DLGAHDCQNCU;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult TRWXYLRCTHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x13B8030", Offset = "0x13B7030", VA = "0x1813B8030")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x13B8020", Offset = "0x13B7020", VA = "0x1813B8020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76F1860", Offset = "0x76F0860", VA = "0x1876F1860")]
		internal void UTJXJEPTLLZ(JVDULATUVMJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76F18C0", Offset = "0x76F08C0", VA = "0x1876F18C0")]
		private bool ZMGSYXJXLFT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x76F18F0", Offset = "0x76F08F0", VA = "0x1876F18F0")]
		internal XNPYVOBYHGI(IPEndPoint a, JVDULATUVMJ b, MGNESVRMCDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x76F1800", Offset = "0x76F0800", VA = "0x1876F1800")]
		public XBZXQDKASCO Accept()
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
		public NIWYMTUMOQV AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface AOLAIRSGEKT
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CWMIQRZKSAJ(XBZXQDKASCO a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void POJSHCVVOYF(XBZXQDKASCO a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UWELOEOJYLQ(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZDLIXYPYYKZ(XBZXQDKASCO a, NIWYMTUMOQV b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HUHCRRMVFKR(IPEndPoint a, NIWYMTUMOQV b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JYRKCWPOPZF(XBZXQDKASCO a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZJLYHPNIFOL(XNPYVOBYHGI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface HHQVZJJLRPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RFXVFDXDICH(XBZXQDKASCO a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NGGZKCGURQU
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RWYNAZKZJQD(XUHYCLBHZOL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface MABLIYUVYLU
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RDLBDYEUMVM(XBZXQDKASCO a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class JVDULATUVMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int UYYTFYDIHQT = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long YVDWGNTAXJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte CCZZSAQFCXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] RNJLDRAMTLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly XDZARUHUNOF TNFSBSIRYTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int EXQZVLLACTU;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x76E0AA0", Offset = "0x76DFAA0", VA = "0x1876E0AA0")]
		private JVDULATUVMJ(long a, byte b, int c, byte[] d, XDZARUHUNOF e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x76E06A0", Offset = "0x76DF6A0", VA = "0x1876E06A0")]
		public static int FBZCEVPRVYQ(EJPAVELXNXA a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x76E08B0", Offset = "0x76DF8B0", VA = "0x1876E08B0")]
		public static JVDULATUVMJ NXPVUVHCVGD(EJPAVELXNXA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76E06D0", Offset = "0x76DF6D0", VA = "0x1876E06D0")]
		public static EJPAVELXNXA JDBSHPVILXT(LTVONMSWSUV a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class JBQSIESIIAY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long YVDWGNTAXJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte CCZZSAQFCXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int EXQZVLLACTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool GDMHOLHOZNH;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x76DFEC0", Offset = "0x76DEEC0", VA = "0x1876DFEC0")]
		private JBQSIESIIAY(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x76DFDC0", Offset = "0x76DEDC0", VA = "0x1876DFDC0")]
		public static JBQSIESIIAY NXPVUVHCVGD(EJPAVELXNXA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x76DFCD0", Offset = "0x76DECD0", VA = "0x1876DFCD0")]
		public static EJPAVELXNXA JDBSHPVILXT(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x76DFBD0", Offset = "0x76DEBD0", VA = "0x1876DFBD0")]
		public static EJPAVELXNXA EDAWNYQJBRV(XBZXQDKASCO a)
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
	public interface KMQLTNIBNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GIOAHSFECOO(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WTHDLPHPVYE(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class CRBIMGKCQRU
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
		private class CHEROLOKZLG
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint GDUYCNDQATQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string OCHREYSWFNW
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CHEROLOKZLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class IGUXJPDLIRS
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint GDUYCNDQATQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint FBNMANNAVXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string OCHREYSWFNW
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public IGUXJPDLIRS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class EPLROTBIMVY
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string OCHREYSWFNW
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool FUUEQGTXQOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAD0090", Offset = "0xACF090", VA = "0x180AD0090")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public EPLROTBIMVY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MGNESVRMCDL XOTJXOXSXWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> ORSELXWFOTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> YVEPUEIKSLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly XDZARUHUNOF TYOGHSKAMYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly LTVONMSWSUV FRDNCPLNVGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly HXHFXLDTTNA IFOOECEIAOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private KMQLTNIBNAD SKQKKCCNSUV;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int VCLWVUUXEMY = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool JMOOAVDWIVF;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x76DD0B0", Offset = "0x76DC0B0", VA = "0x1876DD0B0")]
		internal CRBIMGKCQRU(MGNESVRMCDL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x76DCC40", Offset = "0x76DBC40", VA = "0x1876DCC40")]
		internal void CDSUQDVIQYD(IPEndPoint a, EJPAVELXNXA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x34E7C70", Offset = "0x34E6C70", VA = "0x1834E7C70")]
		private void AMONIKBVVAV<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76DCDC0", Offset = "0x76DBDC0", VA = "0x1876DCDC0")]
		private void GIOAHSFECOO(CHEROLOKZLG a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76DCF50", Offset = "0x76DBF50", VA = "0x1876DCF50")]
		private void UDXCSVXJIQG(IGUXJPDLIRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x76DCAB0", Offset = "0x76DBAB0", VA = "0x1876DCAB0")]
		private void BIFLOFQAJOH(EPLROTBIMVY a, IPEndPoint b)
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
	public static class WCOVQNWWVNV
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] TEDMAIRVQWM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int XELZJMNZCPU;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int BSLEXFCDHEL;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x76DFBC0", Offset = "0x76DEBC0", VA = "0x1876DFBC0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x76DFBC0", Offset = "0x76DEBC0", VA = "0x1876DFBC0")]
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
	public interface ZUVUDXBOXJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CHVTFTMMGHP(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class QDOTUTESHFP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static ZUVUDXBOXJH CIRDOSZAHYL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object UYZZDRJEHLZ;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x76EBBE0", Offset = "0x76EABE0", VA = "0x1876EBBE0")]
		private static void MLIKWWCAPPG(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76EBE70", Offset = "0x76EAE70", VA = "0x1876EBE70")]
		internal static void ZLBTBLWJCEE(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x76EBED0", Offset = "0x76EAED0", VA = "0x1876EBED0")]
		internal static void ZLUEHEYPJVI(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x76EBE10", Offset = "0x76EAE10", VA = "0x1876EBE10")]
		internal static void OKUGNGPPHGA(string a, params object[] args)
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
	public sealed class NIWYMTUMOQV : XDZARUHUNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private EJPAVELXNXA YIKGEPFHBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly MGNESVRMCDL ZKYVJRTNXBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly FGFXLTGYTIK IJMGZWZRFQJ;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x76EB040", Offset = "0x76EA040", VA = "0x1876EB040")]
		internal NIWYMTUMOQV(MGNESVRMCDL a, FGFXLTGYTIK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76EAF20", Offset = "0x76E9F20", VA = "0x1876EAF20")]
		internal void DFIKXVLXIPC(EJPAVELXNXA a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x76EAFC0", Offset = "0x76E9FC0", VA = "0x1876EAFC0")]
		internal void QHYJDINTAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76EAF90", Offset = "0x76E9F90", VA = "0x1876EAF90")]
		public void EXRDLQODWTC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class FGFXLTGYTIK
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
		public FGFXLTGYTIK CQNORJGDYTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType GLAENVNETGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public XBZXQDKASCO BUIKPGPTCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint DLGAHDCQNCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object MMMZNVLTZHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int PSAROJVOHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError OBRPBIBVNPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason VGXFTVTTPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public XNPYVOBYHGI XNPYVOBYHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod NLJNAWELSJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte GNNLDSRFYBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly NIWYMTUMOQV YPBILZSCZGQ;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76DDDF0", Offset = "0x76DCDF0", VA = "0x1876DDDF0")]
		public FGFXLTGYTIK(MGNESVRMCDL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class MGNESVRMCDL : IEnumerable<XBZXQDKASCO>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class YRXMDRBMTUM : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x76F2D70", Offset = "0x76F1D70", VA = "0x1876F2D70", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x76F2DE0", Offset = "0x76F1DE0", VA = "0x1876F2DE0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public YRXMDRBMTUM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<XBZXQDKASCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly XBZXQDKASCO _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private XBZXQDKASCO _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public XBZXQDKASCO Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xCC4250", Offset = "0xCC3250", VA = "0x180CC4250", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xCC4250", Offset = "0xCC3250", VA = "0x180CC4250", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1B02120", Offset = "0x1B01120", VA = "0x181B02120")]
			public NetPeerEnumerator(XBZXQDKASCO p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x76EB9A0", Offset = "0x76EA9A0", VA = "0x1876EB9A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x76EB9F0", Offset = "0x76EA9F0", VA = "0x1876EB9F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread FKGPXMRKFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool PEHYVCFNCMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool YZWDULOUKZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private USBBXVNSRSS TTGGLAPCREQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent LTUTGEQUMZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<FGFXLTGYTIK> OMRBMDZGBRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<FGFXLTGYTIK> LZEIEYYZMVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private FGFXLTGYTIK CGDXMBQXDXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly AOLAIRSGEKT DAAMDFWFKWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly HHQVZJJLRPA QJCFWNYKTIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly NGGZKCGURQU HNWABIBFIXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MABLIYUVYLU GGSKRVTPQNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, XBZXQDKASCO> RJSXKJYQBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, XNPYVOBYHGI> HYFVDXWWHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, TQRRPWPMWOU> TPUYVJXHGUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim TWLNIAOKFIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private XBZXQDKASCO FACWKREHOXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int PMVMRYEEAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<XBZXQDKASCO> XIYCLVGNIRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private XBZXQDKASCO[] RMQYRHPEIGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly UZQIVKXUSMJ WBOVXHBYPMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int ESVWYKSFGAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> SHBXJCRTSZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte HIPNGUIFLKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object MPHYIHJICKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool VLHDUROTXSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool UUMZWLGXCHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int WCIZTGIUPZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int UVQQZVJYCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int VPYSGAIXHKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int ZHSMLMGOYWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool NWFMBOARCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool ZUBZNLBOJWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int GAQJPXQTHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int XRNEMOFNJUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int BVEBTMAKYBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool JMOOAVDWIVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool PYEWFLZBGQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool EHQXHYSWZGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool VTVGTLAXOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int BPMOQEXXABZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int JSSPDUQWWZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool ROUABWZMKEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly JPAEFDFFXAZ AICJUTAOMLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool TIRHKQIMHWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly CRBIMGKCQRU CRBIMGKCQRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool KNHUAUYUCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode TKUQBJUSLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int JHYZZZOQNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool EAGIQZZLPRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool RHVOYYYEHGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool QQXSOZGCQIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool CJGPBUGXQWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private EJPAVELXNXA MOMPGNZMNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int VNLBIMSHVSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object XHELPKLSEJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private EJPAVELXNXA GBTOUQPNYLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int YDQXQOOAMAI;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int BDMJKTZMCAI = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int ATVTCFUZUGF = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private MZXGTKOKXSD AKDJCLVATIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MZXGTKOKXSD AKNWWZIVMEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread QKFJYYIJKNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread QJUWEKUORRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint ZYONSMIONMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint ZYDZXYUTUPR;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] AGFVNXYJJIF;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] JLDVBOXRJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> FZYJALLVFNU;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress MIIIHGUCQKR;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool JPAHYCCGVFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int DWNVKPBRDRX;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IPEYEHLWCZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBFCBA0", Offset = "0xBFBBA0", VA = "0x180BFCBA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBFA9A0", Offset = "0xBF99A0", VA = "0x180BFA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int XMBNXIMUAUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1F845F0", Offset = "0x1F835F0", VA = "0x181F845F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x20BFC30", Offset = "0x20BEC30", VA = "0x1820BFC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte NBEMWLMIVYS
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB85300", Offset = "0xB84300", VA = "0x180B85300")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int PJRGOODGRVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x76E4730", Offset = "0x76E3730", VA = "0x1876E4730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short TWLFSOHLUSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x76E4300", Offset = "0x76E3300", VA = "0x1876E4300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event XBZXQDKASCO.OnUpdatedMtuDelegate WAVZLMQZHZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x76E4250", Offset = "0x76E3250", VA = "0x1876E4250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x76E64B0", Offset = "0x76E54B0", VA = "0x1876E64B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x76E9B60", Offset = "0x76E8B60", VA = "0x1876E9B60")]
		public void UXHWBCEUPLF(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x76E4100", Offset = "0x76E3100", VA = "0x1876E4100")]
		public void FPDFDEFULCW(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x76E4060", Offset = "0x76E3060", VA = "0x1876E4060")]
		private bool FDRUEPDPUTS(IPEndPoint a, [Out] XBZXQDKASCO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x76E43C0", Offset = "0x76E33C0", VA = "0x1876E43C0")]
		private void GVEUDEJCFQO(XBZXQDKASCO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x76E9B00", Offset = "0x76E8B00", VA = "0x1876E9B00")]
		private void UIODZOZXSXF(XBZXQDKASCO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x76E3360", Offset = "0x76E2360", VA = "0x1876E3360")]
		private void CYZTDNQLWCW(XBZXQDKASCO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76EA960", Offset = "0x76E9960", VA = "0x1876EA960")]
		public MGNESVRMCDL(AOLAIRSGEKT a, [Optional] UZQIVKXUSMJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x76E46E0", Offset = "0x76E36E0", VA = "0x1876E46E0")]
		internal void GYEKAAJUTNQ(XBZXQDKASCO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x76EA850", Offset = "0x76E9850", VA = "0x1876EA850")]
		internal void ZKXIPDCNMKO(XBZXQDKASCO a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x76E9ED0", Offset = "0x76E8ED0", VA = "0x1876E9ED0")]
		internal void XEZFOUINZWY(XBZXQDKASCO a, DisconnectReason b, SocketError c, EJPAVELXNXA d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x76E9F90", Offset = "0x76E8F90", VA = "0x1876E9F90")]
		private void XNYALVZLRSB(XBZXQDKASCO a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, EJPAVELXNXA h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76E7230", Offset = "0x76E6230", VA = "0x1876E7230")]
		private void OQYCOQZSPJX(FGFXLTGYTIK.EType a, [Optional] XBZXQDKASCO b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] XNPYVOBYHGI g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] EJPAVELXNXA j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x76E92D0", Offset = "0x76E82D0", VA = "0x1876E92D0")]
		private void TTEPVFXKPIQ(FGFXLTGYTIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x76E6A00", Offset = "0x76E5A00", VA = "0x1876E6A00")]
		internal void LOQVVELEXWA(FGFXLTGYTIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x76E6B90", Offset = "0x76E5B90", VA = "0x1876E6B90")]
		private void MCFNZMBJUHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x76E3D30", Offset = "0x76E2D30", VA = "0x1876E3D30")]
		private void ENNRGJLOJPS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x76E7E10", Offset = "0x76E6E10", VA = "0x1876E7E10")]
		internal XBZXQDKASCO QNFEBACTOQX(XNPYVOBYHGI a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x76E6B10", Offset = "0x76E5B10", VA = "0x1876E6B10")]
		private int LWHSDIMETOF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x76E6560", Offset = "0x76E5560", VA = "0x1876E6560")]
		private void LITKNMNBLZJ(IPEndPoint a, XBZXQDKASCO b, JVDULATUVMJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x76E4C10", Offset = "0x76E3C10", VA = "0x1876E4C10")]
		private void JPCOSVPQZIK(EJPAVELXNXA a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x76E5F10", Offset = "0x76E4F10", VA = "0x1876E5F10")]
		internal void KGACPWAAQRS(EJPAVELXNXA a, DeliveryMethod b, byte c, int d, XBZXQDKASCO e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x76E8700", Offset = "0x76E7700", VA = "0x1876E8700")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x76E86E0", Offset = "0x76E76E0", VA = "0x1876E86E0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x76E8770", Offset = "0x76E7770", VA = "0x1876E8770")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76E4750", Offset = "0x76E3750", VA = "0x1876E4750")]
		public void HDAPJMFWHZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76E3700", Offset = "0x76E2700", VA = "0x1876E3700")]
		public XBZXQDKASCO Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x76E3620", Offset = "0x76E2620", VA = "0x1876E3620")]
		public XBZXQDKASCO Connect(string address, int port, LTVONMSWSUV connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76E37E0", Offset = "0x76E27E0", VA = "0x1876E37E0")]
		public XBZXQDKASCO Connect(IPEndPoint target, LTVONMSWSUV connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76E92C0", Offset = "0x76E82C0", VA = "0x1876E92C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x76E8F60", Offset = "0x76E7F60", VA = "0x1876E8F60")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x76E3BB0", Offset = "0x76E2BB0", VA = "0x1876E3BB0")]
		public void EMFSHLVFISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x76E3C60", Offset = "0x76E2C60", VA = "0x1876E3C60")]
		public void EMFSHLVFISA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x76E9F10", Offset = "0x76E8F10", VA = "0x1876E9F10")]
		public void XNYALVZLRSB(XBZXQDKASCO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x76E9F50", Offset = "0x76E8F50", VA = "0x1876E9F50")]
		public void XNYALVZLRSB(XBZXQDKASCO a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x76E9A70", Offset = "0x76E8A70", VA = "0x1876E9A70", Slot = "4")]
		private IEnumerator<XBZXQDKASCO> UEXNXCUTBGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x76E4900", Offset = "0x76E3900", VA = "0x1876E4900", Slot = "5")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x76E6EF0", Offset = "0x76E5EF0", VA = "0x1876E6EF0")]
		private EJPAVELXNXA NHDDEACOYKC(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x76E6FD0", Offset = "0x76E5FD0", VA = "0x1876E6FD0")]
		private EJPAVELXNXA NHDDEACOYKC(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x76E8440", Offset = "0x76E7440", VA = "0x1876E8440")]
		internal EJPAVELXNXA QOLWANPSQSH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x76E49B0", Offset = "0x76E39B0", VA = "0x1876E49B0")]
		internal void ISNWTPNPHUK(EJPAVELXNXA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76EA8A0", Offset = "0x76E98A0", VA = "0x1876EA8A0")]
		static MGNESVRMCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBFCBA0", Offset = "0xBFBBA0", VA = "0x180BFCBA0")]
		private bool OZFZDJKYTIJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x76EA6F0", Offset = "0x76E96F0", VA = "0x1876EA6F0")]
		private void YKAKYQRAHFR(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D80", Offset = "0x76E8D80", VA = "0x1876E9D80")]
		private void WGRVSDQNJZS(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x76E31C0", Offset = "0x76E21C0", VA = "0x1876E31C0")]
		private bool AVRXFXNTTMG(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x76E4990", Offset = "0x76E3990", VA = "0x1876E4990")]
		private void HZTQVGOPBIN(USBBXVNSRSS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x76E61E0", Offset = "0x76E51E0", VA = "0x1876E61E0")]
		private void KGDJHRYAVWO(MZXGTKOKXSD a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x76EA370", Offset = "0x76E9370", VA = "0x1876EA370")]
		private void XRLGNRCXZHA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x76E87F0", Offset = "0x76E77F0", VA = "0x1876E87F0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x76E8680", Offset = "0x76E7680", VA = "0x1876E8680")]
		internal int SUKOZNWVFTR(EJPAVELXNXA a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x76E7DD0", Offset = "0x76E6DD0", VA = "0x1876E7DD0")]
		internal int PVSDGPQFMRL(EJPAVELXNXA a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x76E7600", Offset = "0x76E6600", VA = "0x1876E7600")]
		internal int PVSDGPQFMRL(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x76E70B0", Offset = "0x76E60B0", VA = "0x1876E70B0")]
		internal void OMJMVCHFXIQ(bool a)
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
	internal sealed class EJPAVELXNXA
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int RXQEEPVWQHX;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] BBFRUCUXRRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] LCSGWFWFRZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int WXXVDKLEOHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object MMMZNVLTZHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public EJPAVELXNXA CQNORJGDYTQ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty OZXNKABXNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x76DD820", Offset = "0x76DC820", VA = "0x1876DD820")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x76DD7A0", Offset = "0x76DC7A0", VA = "0x1876DD7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte CCZZSAQFCXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x76DD6B0", Offset = "0x76DC6B0", VA = "0x1876DD6B0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x76DD4D0", Offset = "0x76DC4D0", VA = "0x1876DD4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort GDRGCMMXSVM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x76DD880", Offset = "0x76DC880", VA = "0x1876DD880")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x76DD6E0", Offset = "0x76DC6E0", VA = "0x1876DD6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool YHJJITTKNFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x76DD4A0", Offset = "0x76DC4A0", VA = "0x1876DD4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte YFSCGEBBWKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x76DD510", Offset = "0x76DC510", VA = "0x1876DD510")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x76DD580", Offset = "0x76DC580", VA = "0x1876DD580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort WAVBXKWLKBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x76DD780", Offset = "0x76DC780", VA = "0x1876DD780")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x76DD740", Offset = "0x76DC740", VA = "0x1876DD740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort RTBZSRZZSBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x76DD720", Offset = "0x76DC720", VA = "0x1876DD720")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x76DD540", Offset = "0x76DC540", VA = "0x1876DD540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort PODCXPIHLIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x76DD9A0", Offset = "0x76DC9A0", VA = "0x1876DD9A0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x76DD7E0", Offset = "0x76DC7E0", VA = "0x1876DD7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76DD9C0", Offset = "0x76DC9C0", VA = "0x1876DD9C0")]
		static EJPAVELXNXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76DD850", Offset = "0x76DC850", VA = "0x1876DD850")]
		public void XBHNIJBXHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76DDD80", Offset = "0x76DCD80", VA = "0x1876DDD80")]
		public EJPAVELXNXA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76DDC70", Offset = "0x76DCC70", VA = "0x1876DDC70")]
		public EJPAVELXNXA(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x76DD930", Offset = "0x76DC930", VA = "0x1876DD930")]
		public static int YFZVCBFTYZL(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x76DD8A0", Offset = "0x76DC8A0", VA = "0x1876DD8A0")]
		public int YFZVCBFTYZL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x76DD5B0", Offset = "0x76DC5B0", VA = "0x1876DD5B0")]
		public bool FCMMKGFFKZQ()
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
	public class XBZXQDKASCO
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class HQLDRNARQXW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public EJPAVELXNXA[] PQPYQWXCKVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int UCJYCZLKSZF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int ISXQVDBBSWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte YFSCGEBBWKH;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQLDRNARQXW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int KPFSLZJBCWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int EGNELQFVETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int KDICYZBRXRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double DJOOCDRZOWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int JKNGVZHUKXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int VKRKFIPJSXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int FGNUERTSVJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch LRGSBAEKQBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int FCKIHYUOHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long ZOHFUMKGBUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object NIFPYGVGUGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal XBZXQDKASCO SFYOFZFPAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal XBZXQDKASCO NQSPIJZILQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<EJPAVELXNXA> ZKGCGIJZXVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<SIFERPMZMQV> QGTPLUJHDSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly SIFERPMZMQV[] JNGLLMKVUCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int CJPYRNNRKUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int NEFTWRTHPWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool DXSCWJAMVKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int FHBMDQXVPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int XNQNAJIHXNE;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int VIFXSOMDEJA = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int CYRHOFTVRGJ = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object WLCKHZTSTMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int NEWOJPSHTWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, HQLDRNARQXW> HRMHQUAMYBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> WRFKWDSWZPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly EJPAVELXNXA MGXVKLYSLDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int VKDRTIPGCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int BWDPAUPYARB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint CHLFTDNQAZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int COXZNZGQPXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int OHZCLXCORET;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long DJNKRLUUGQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte AVZKVZPFYBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState DIFSPFFZNSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private EJPAVELXNXA VORHRCUCDHY;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int XSAZEXESVRS = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int CBZFNVBDHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly EJPAVELXNXA LQEZNCFSUUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly EJPAVELXNXA TXBXCWIJFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly EJPAVELXNXA AFBKHIBMMRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly EJPAVELXNXA IIVJQQGACAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality WYZFWNMFSLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly MGNESVRMCDL MGNESVRMCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int TXKKVYGLDVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object PLCVLEQYIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly JPAEFDFFXAZ AICJUTAOMLW;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte NLBLQNDYQJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAF88B0", Offset = "0xAF78B0", VA = "0x180AF88B0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x76ED1E0", Offset = "0x76EC1E0", VA = "0x1876ED1E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint DPSNWISLJBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBF5610", Offset = "0xBF4610", VA = "0x180BF5610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState DFXLUWXMKVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x125D5D0", Offset = "0x125C5D0", VA = "0x18125D5D0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long GJSAQAQGEGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAD3F30", Offset = "0xAD2F30", VA = "0x180AD3F30")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int POWHKRIHPGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F845F0", Offset = "0x1F835F0", VA = "0x181F845F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x20BFC30", Offset = "0x20BEC30", VA = "0x1820BFC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int APJQXVQSBGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x76EE4E0", Offset = "0x76ED4E0", VA = "0x1876EE4E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int CJWAPIUGLCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAE9560", Offset = "0xAE8560", VA = "0x180AE9560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double MSNMGETUIOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x286F880", Offset = "0x286E880", VA = "0x18286F880")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate WAVZLMQZHZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x76EDB70", Offset = "0x76ECB70", VA = "0x1876EDB70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x76EDC60", Offset = "0x76ECC60", VA = "0x1876EDC60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x76F0980", Offset = "0x76EF980", VA = "0x1876F0980")]
		internal XBZXQDKASCO(MGNESVRMCDL a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x76EE4C0", Offset = "0x76ED4C0", VA = "0x1876EE4C0")]
		internal void LWCNQGCPDUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x76EEED0", Offset = "0x76EDED0", VA = "0x1876EEED0")]
		internal void RNFMZGWGBQN(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x76EF500", Offset = "0x76EE500", VA = "0x1876EF500")]
		internal void UBYJHKYSNEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x76EE230", Offset = "0x76ED230", VA = "0x1876EE230")]
		private void LFNOGTLRNHJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x76EEF50", Offset = "0x76EDF50", VA = "0x1876EEF50")]
		private void SAKBECWRYSV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x76EFCE0", Offset = "0x76EECE0", VA = "0x1876EFCE0")]
		public int WBNMVRLCKYJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x76EFDF0", Offset = "0x76EEDF0", VA = "0x1876EFDF0")]
		public int WBNMVRLCKYJ(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x76EECE0", Offset = "0x76EDCE0", VA = "0x1876EECE0")]
		private SIFERPMZMQV OLKGIJNCWAG(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x76F0D80", Offset = "0x76EFD80", VA = "0x1876F0D80")]
		internal XBZXQDKASCO(MGNESVRMCDL a, IPEndPoint b, int c, byte d, LTVONMSWSUV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x76F07A0", Offset = "0x76EF7A0", VA = "0x1876F07A0")]
		internal XBZXQDKASCO(MGNESVRMCDL a, XNPYVOBYHGI b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x76EEF00", Offset = "0x76EDF00", VA = "0x1876EEF00")]
		internal void Reject(JVDULATUVMJ requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x76EF590", Offset = "0x76EE590", VA = "0x1876EF590")]
		internal bool UNXXVVUFVJE(JBQSIESIIAY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x76ECE20", Offset = "0x76EBE20", VA = "0x1876ECE20")]
		public void AMONIKBVVAV(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x76ED580", Offset = "0x76EC580", VA = "0x1876ED580")]
		private void FRDWGQKHNII(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x76ED290", Offset = "0x76EC290", VA = "0x1876ED290")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x76ED4E0", Offset = "0x76EC4E0", VA = "0x1876ED4E0")]
		internal DisconnectResult EUNFGOHCMLQ(EJPAVELXNXA a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x76EEE70", Offset = "0x76EDE70", VA = "0x1876EEE70")]
		internal void PERMEDKMJEJ(SIFERPMZMQV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x76EF1F0", Offset = "0x76EE1F0", VA = "0x1876EF1F0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x76EDC20", Offset = "0x76ECC20", VA = "0x1876EDC20")]
		private void KKZIFQLSLOM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x76EFF10", Offset = "0x76EEF10", VA = "0x1876EFF10")]
		internal void ZCAKOSKFNKA(DeliveryMethod a, EJPAVELXNXA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x76EDD10", Offset = "0x76ECD10", VA = "0x1876EDD10")]
		private void LETHJLSMWNG(EJPAVELXNXA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76ECE50", Offset = "0x76EBE50", VA = "0x1876ECE50")]
		private void CLOIFYSCOOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x76EE300", Offset = "0x76ED300", VA = "0x1876EE300")]
		internal ConnectRequestResult LITKNMNBLZJ(JVDULATUVMJ a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76EE640", Offset = "0x76ED640", VA = "0x1876EE640")]
		internal void ODWJQVSTYYU(EJPAVELXNXA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x76EE4F0", Offset = "0x76ED4F0", VA = "0x1876EE4F0")]
		private void NVKLEKSCWAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x76ED2E0", Offset = "0x76EC2E0", VA = "0x1876ED2E0")]
		internal void EODWQCRPLXE(EJPAVELXNXA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x76EF610", Offset = "0x76EE610", VA = "0x1876EF610")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x76EEF90", Offset = "0x76EDF90", VA = "0x1876EEF90")]
		internal void SAROIDTSYVQ(EJPAVELXNXA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class JPAEFDFFXAZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long SOCGYMQQKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long KQWMBOFYQTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long PDIGGUKHLEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long THOCCWWPJRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long IXBLAZSYGJN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long DSGFMJIVDIS;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long LWTXIQRCFYP;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long IVHVDZSXOVW;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long ZURZWVDHNZL;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long EQWACKNFWBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long OSTYOJGHHSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long OEUFOTZOJBP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long CTIQMBRFDAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x76E0250", Offset = "0x76DF250", VA = "0x1876E0250")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long YTATRUDDBCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x76E00A0", Offset = "0x76DF0A0", VA = "0x1876E00A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long VNZAZRMQASM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x76DFF60", Offset = "0x76DEF60", VA = "0x1876DFF60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long ZYHRNJYABDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x76E0050", Offset = "0x76DF050", VA = "0x1876E0050")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long SXHMWMQAHFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x76E0040", Offset = "0x76DF040", VA = "0x1876E0040")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long LWYOAQXBQKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x76DFF70", Offset = "0x76DEF70", VA = "0x1876DFF70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long TQQNNZJZGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x76E0260", Offset = "0x76DF260", VA = "0x1876E0260")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long PFKJAEEQSUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x76E0060", Offset = "0x76DF060", VA = "0x1876E0060")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality SWIDHGGHBWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1192490", Offset = "0x1191490", VA = "0x181192490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double FMHGZHYTEOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x76DFF80", Offset = "0x76DEF80", VA = "0x1876DFF80")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76E0170", Offset = "0x76DF170", VA = "0x1876E0170")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76E05D0", Offset = "0x76DF5D0", VA = "0x1876E05D0")]
		public void VYTXJJWUAEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x76DFF10", Offset = "0x76DEF10", VA = "0x1876DFF10")]
		public void CIKNZBQXUQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x76E0110", Offset = "0x76DF110", VA = "0x1876E0110")]
		public void RPKMYAZCLHB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x76E00B0", Offset = "0x76DF0B0", VA = "0x1876E00B0")]
		public void QWLEMWICHSG(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76DFFE0", Offset = "0x76DEFE0", VA = "0x1876DFFE0")]
		public void IDJZABAPDJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x76E0630", Offset = "0x76DF630", VA = "0x1876E0630")]
		public void VZRBAAKKACJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x76E02A0", Offset = "0x76DF2A0", VA = "0x1876E02A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x76E01B0", Offset = "0x76DF1B0", VA = "0x1876E01B0")]
		public void SEFJQDAGOQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public JPAEFDFFXAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class NNSIJWKRAUX
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> VKFHGGIEPKK;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x76EB310", Offset = "0x76EA310", VA = "0x1876EB310")]
		public static IPEndPoint SJDCDIADGGQ(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x76EB150", Offset = "0x76EA150", VA = "0x1876EB150")]
		public static IPAddress JYIAWJMQNGP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76EB0C0", Offset = "0x76EA0C0", VA = "0x1876EB0C0")]
		public static IPAddress JYIAWJMQNGP(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x76EB090", Offset = "0x76EA090", VA = "0x1876EB090")]
		internal static int CSLGMXZIBJN(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x390C0C0", Offset = "0x390B0C0", VA = "0x18390C0C0")]
		internal static T[] OZMJHMSNRNQ<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class IGAOKKPUIBC : SIFERPMZMQV
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private EJPAVELXNXA _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x76EBB70", Offset = "0x76EAB70", VA = "0x1876EBB70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x76EBAE0", Offset = "0x76EAAE0", VA = "0x1876EBAE0")]
			public void GRLRHMOCTOZ(EJPAVELXNXA a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x76EBB00", Offset = "0x76EAB00", VA = "0x1876EBB00")]
			public bool QLHPGFHUBJY(long a, XBZXQDKASCO b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x76EBA90", Offset = "0x76EAA90", VA = "0x1876EBA90")]
			public bool Clear(XBZXQDKASCO peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly EJPAVELXNXA WQLPBBFGTHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] INHUCTUQKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly EJPAVELXNXA[] RRPPUFNAZIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] QSBPKTXUTBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int EQRXCPOEBKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int ALGNVWZZLYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int HEMPNTGQZQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int HBYPGGPTYJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool OPMDFRFHPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod FEQDBSQLSBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool LROMMQDUSDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int BKCSTTBHONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte MLRHXBCEJQB;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int PXMWNPAFENQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x76DF070", Offset = "0x76DE070", VA = "0x1876DF070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x76DFA00", Offset = "0x76DEA00", VA = "0x1876DFA00")]
		public IGAOKKPUIBC(XBZXQDKASCO a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x76DF680", Offset = "0x76DE680", VA = "0x1876DF680")]
		private void YZGZPNSTDQJ(EJPAVELXNXA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76DEBA0", Offset = "0x76DDBA0", VA = "0x1876DEBA0", Slot = "4")]
		protected override bool HUKZVZSTNMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x76DF080", Offset = "0x76DE080", VA = "0x1876DF080", Slot = "5")]
		public override bool ODWJQVSTYYU(EJPAVELXNXA a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class ZMUGPQGRSKV : SIFERPMZMQV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int MANUQFZTDMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort ALGNVWZZLYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool OQLEPJXDQPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private EJPAVELXNXA JNWLWYQNENW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly EJPAVELXNXA QLNBFFTCTFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool LENDKBEHKQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte MLRHXBCEJQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long YPJVPXISTUD;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x76F3550", Offset = "0x76F2550", VA = "0x1876F3550")]
		public ZMUGPQGRSKV(XBZXQDKASCO a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x76F2E10", Offset = "0x76F1E10", VA = "0x1876F2E10", Slot = "4")]
		protected override bool HUKZVZSTNMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x76F32D0", Offset = "0x76F22D0", VA = "0x1876F32D0", Slot = "5")]
		public override bool ODWJQVSTYYU(EJPAVELXNXA a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class SFJULWWECWU
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
		[Cpp2IlInjected.Address(RVA = "0x76DC9C0", Offset = "0x76DB9C0", VA = "0x1876DC9C0")]
		private static void GSGIQEGTCPT(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x76EC6E0", Offset = "0x76EB6E0", VA = "0x1876EC6E0")]
		private static void GSGIQEGTCPT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x76EC750", Offset = "0x76EB750", VA = "0x1876EC750")]
		public static void GSGIQEGTCPT(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x76EC790", Offset = "0x76EB790", VA = "0x1876EC790")]
		public static void MFRVPKRZXYU(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x76EC7C0", Offset = "0x76EB7C0", VA = "0x1876EC7C0")]
		public static void MFRVPKRZXYU(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x76EC750", Offset = "0x76EB750", VA = "0x1876EC750")]
		public static void MFRVPKRZXYU(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x76EC750", Offset = "0x76EB750", VA = "0x1876EC750")]
		public static void MFRVPKRZXYU(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x76EC6E0", Offset = "0x76EB6E0", VA = "0x1876EC6E0")]
		public static void MFRVPKRZXYU(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x76EC6E0", Offset = "0x76EB6E0", VA = "0x1876EC6E0")]
		public static void MFRVPKRZXYU(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x76EC7B0", Offset = "0x76EB7B0", VA = "0x1876EC7B0")]
		public static void MFRVPKRZXYU(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x76EC7B0", Offset = "0x76EB7B0", VA = "0x1876EC7B0")]
		public static void MFRVPKRZXYU(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class XDZARUHUNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] OMBJDAIUITS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int CHKTSKZFKMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int NURRWPEYDSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int EEEOFSJBTDZ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] LCSGWFWFRZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int NITECGBQNBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int SDXYIDZIGYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x76F14D0", Offset = "0x76F04D0", VA = "0x1876F14D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CLAHYKORRQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x27C8B60", Offset = "0x27C7B60", VA = "0x1827C8B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int CPLSQMGHIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x76F10A0", Offset = "0x76F00A0", VA = "0x1876F10A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x76F1020", Offset = "0x76F0020", VA = "0x1876F1020")]
		public void DFIKXVLXIPC(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public XDZARUHUNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x76F17A0", Offset = "0x76F07A0", VA = "0x1876F17A0")]
		public XDZARUHUNOF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x76F1710", Offset = "0x76F0710", VA = "0x1876F1710")]
		public IPEndPoint YQKOXJYOFAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x76F1490", Offset = "0x76F0490", VA = "0x1876F1490")]
		public byte QFDGVEHBIGH()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x76F1490", Offset = "0x76F0490", VA = "0x1876F1490")]
		public sbyte TIXQXRUUDYA()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3C659C0", Offset = "0x3C649C0", VA = "0x183C659C0")]
		public a[] HZGNGPYYZWK<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x76F1590", Offset = "0x76F0590", VA = "0x1876F1590")]
		public bool[] VZLLCPXXDYG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x76F0F50", Offset = "0x76EFF50", VA = "0x1876F0F50")]
		public ushort[] AVZSECMLUFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x76F0F10", Offset = "0x76EFF10", VA = "0x1876F0F10")]
		public short[] AAGVAYNDVTI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x76F1180", Offset = "0x76F0180", VA = "0x1876F1180")]
		public int[] KQGFGETKUKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x76F1060", Offset = "0x76F0060", VA = "0x1876F1060")]
		public uint[] DQSXQYVRGTI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x76F11C0", Offset = "0x76F01C0", VA = "0x1876F11C0")]
		public float[] MRCTHKFKYZY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x76F1200", Offset = "0x76F0200", VA = "0x1876F1200")]
		public double[] NCGMYXBVRTH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x76F10B0", Offset = "0x76F00B0", VA = "0x1876F10B0")]
		public long[] FLBXXWBTHWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x76F1600", Offset = "0x76F0600", VA = "0x1876F1600")]
		public ulong[] WWDCWTCOEOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x76F1640", Offset = "0x76F0640", VA = "0x1876F1640")]
		public string[] XETZWDHADFT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x76F1450", Offset = "0x76F0450", VA = "0x1876F1450")]
		public bool PISYTSUFQVX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x76F0F90", Offset = "0x76EFF90", VA = "0x1876F0F90")]
		public char YUYHWBQDKZP()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x76F0F90", Offset = "0x76EFF90", VA = "0x1876F0F90")]
		public ushort QPQLHWXWCRE()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x76F0F90", Offset = "0x76EFF90", VA = "0x1876F0F90")]
		public short BGEBTLQJWHT()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x76F1120", Offset = "0x76F0120", VA = "0x1876F1120")]
		public long MVDYXXUGCCD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x76F1120", Offset = "0x76F0120", VA = "0x1876F1120")]
		public ulong JLGWFNSRXHA()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x76F1150", Offset = "0x76F0150", VA = "0x1876F1150")]
		public int WSZZZPXMNLA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1150", Offset = "0x76F0150", VA = "0x1876F1150")]
		public uint KNTELQMVBER()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x76F10F0", Offset = "0x76F00F0", VA = "0x1876F10F0")]
		public float HCZFXGZJSSF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x76F15D0", Offset = "0x76F05D0", VA = "0x1876F15D0")]
		public double WOCWMPCQHWE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x76F1240", Offset = "0x76F0240", VA = "0x1876F1240")]
		public string OEPFZZEEFAI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76F14E0", Offset = "0x76F04E0", VA = "0x1876F14E0")]
		public ArraySegment<byte> SZHXTRDQUIZ(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x76F0FE0", Offset = "0x76EFFE0", VA = "0x1876F0FE0")]
		public sbyte[] DEIZFPYLCQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x76F1550", Offset = "0x76F0550", VA = "0x1876F1550")]
		public byte[] TNNLTFGHBKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x76F0FC0", Offset = "0x76EFFC0", VA = "0x1876F0FC0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class LTVONMSWSUV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] OMBJDAIUITS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int CHKTSKZFKMT;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int DFKPLQYHPOM = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool UARPWXFSVTF;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding OORPRFQCALH;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int GBRJLUOYWXA = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] BFCKEJWHSUP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] TNFSBSIRYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int KNJNUUEZHUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x76E1830", Offset = "0x76E0830", VA = "0x1876E1830")]
		public LTVONMSWSUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x76E18B0", Offset = "0x76E08B0", VA = "0x1876E18B0")]
		public LTVONMSWSUV(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x76E0BF0", Offset = "0x76DFBF0", VA = "0x1876E0BF0")]
		public static LTVONMSWSUV JCTSJWHUUZE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76E0C60", Offset = "0x76DFC60", VA = "0x1876E0C60")]
		public void OBEACFWIUQQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2840A60", Offset = "0x283FA60", VA = "0x182840A60")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x76E1230", Offset = "0x76E0230", VA = "0x1876E1230")]
		public void YKXDXXFWEPW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x76E1760", Offset = "0x76E0760", VA = "0x1876E1760")]
		public void YKXDXXFWEPW(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x76E1150", Offset = "0x76E0150", VA = "0x1876E1150")]
		public void YKXDXXFWEPW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x76E1150", Offset = "0x76E0150", VA = "0x1876E1150")]
		public void YKXDXXFWEPW(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x76E11A0", Offset = "0x76E01A0", VA = "0x1876E11A0")]
		public void YKXDXXFWEPW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76E11A0", Offset = "0x76E01A0", VA = "0x1876E11A0")]
		public void YKXDXXFWEPW(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x76E13A0", Offset = "0x76E03A0", VA = "0x1876E13A0")]
		public void YKXDXXFWEPW(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76E13A0", Offset = "0x76E03A0", VA = "0x1876E13A0")]
		public void YKXDXXFWEPW(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x76E13A0", Offset = "0x76E03A0", VA = "0x1876E13A0")]
		public void YKXDXXFWEPW(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x76E1620", Offset = "0x76E0620", VA = "0x1876E1620")]
		public void YKXDXXFWEPW(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x76E1620", Offset = "0x76E0620", VA = "0x1876E1620")]
		public void YKXDXXFWEPW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x76E1680", Offset = "0x76E0680", VA = "0x1876E1680")]
		public void YKXDXXFWEPW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x76E0B10", Offset = "0x76DFB10", VA = "0x1876E0B10")]
		public void HTHFHTWHGJO(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x76E0B10", Offset = "0x76DFB10", VA = "0x1876E0B10")]
		public void FDFUBVQIRPN(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x76E1700", Offset = "0x76E0700", VA = "0x1876E1700")]
		public void YKXDXXFWEPW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x76E0EB0", Offset = "0x76DFEB0", VA = "0x1876E0EB0")]
		public void YCKOVFSTYUB(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x76E0F90", Offset = "0x76DFF90", VA = "0x1876E0F90")]
		public void YCKOVFSTYUB(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x76E0DD0", Offset = "0x76DFDD0", VA = "0x1876E0DD0")]
		public void YCKOVFSTYUB(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x76E0DD0", Offset = "0x76DFDD0", VA = "0x1876E0DD0")]
		public void YCKOVFSTYUB(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x76E0DD0", Offset = "0x76DFDD0", VA = "0x1876E0DD0")]
		public void YCKOVFSTYUB(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x76E0F90", Offset = "0x76DFF90", VA = "0x1876E0F90")]
		public void YCKOVFSTYUB(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x76E0F90", Offset = "0x76DFF90", VA = "0x1876E0F90")]
		public void YCKOVFSTYUB(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x76E1070", Offset = "0x76E0070", VA = "0x1876E1070")]
		public void YCKOVFSTYUB(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x76E1070", Offset = "0x76E0070", VA = "0x1876E1070")]
		public void YCKOVFSTYUB(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x76E0B10", Offset = "0x76DFB10", VA = "0x1876E0B10")]
		public void YCKOVFSTYUB(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x76E0D00", Offset = "0x76DFD00", VA = "0x1876E0D00")]
		public void YCKOVFSTYUB(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x76E12D0", Offset = "0x76E02D0", VA = "0x1876E12D0")]
		public void YKXDXXFWEPW(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x76E16F0", Offset = "0x76E06F0", VA = "0x1876E16F0")]
		public void YKXDXXFWEPW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x76E1410", Offset = "0x76E0410", VA = "0x1876E1410")]
		public void YKXDXXFWEPW(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class HXHFXLDTTNA
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class CMNHUCATPRC<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong TXKKVYGLDVU;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3ED0DE0", Offset = "0x3ECFDE0", VA = "0x183ED0DE0")]
			static CMNHUCATPRC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(XDZARUHUNOF reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class ATEDBYHCBVZ<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public HXHFXLDTTNA SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a LBBXDHJOBXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> KCPDXIKOVYT;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ATEDBYHCBVZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x58BC260", Offset = "0x58BB260", VA = "0x1858BC260")]
			internal void OECAFJJGEZG(XDZARUHUNOF a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class GQCFGJVLIIL<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public HXHFXLDTTNA SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a LBBXDHJOBXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> KCPDXIKOVYT;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public GQCFGJVLIIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x503D8D0", Offset = "0x503C8D0", VA = "0x18503D8D0")]
			internal void OECAFJJGEZG(XDZARUHUNOF a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly TJXXBRMXBTE RMPFCFUYEFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> PTVPDMCRXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly LTVONMSWSUV ICNTDIJFHYA;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x76DEA50", Offset = "0x76DDA50", VA = "0x1876DEA50")]
		public HXHFXLDTTNA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3764360", Offset = "0x3763360", VA = "0x183764360", Slot = "4")]
		protected virtual ulong LWJFMZVLCGB<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x76DE980", Offset = "0x76DD980", VA = "0x1876DE980", Slot = "5")]
		protected virtual SubscribeDelegate NJZOTQGWBLU(XDZARUHUNOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x37643E0", Offset = "0x37633E0", VA = "0x1837643E0", Slot = "6")]
		protected virtual void SFDEGPKRBWG<b>(LTVONMSWSUV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x76DE900", Offset = "0x76DD900", VA = "0x1876DE900")]
		public void MLYOLOWJOEX(XDZARUHUNOF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3764460", Offset = "0x3763460", VA = "0x183764460")]
		public void VCPJVSQNYKO<j>(LTVONMSWSUV a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x76DE8B0", Offset = "0x76DD8B0", VA = "0x1876DE8B0")]
		public void KMQJNYSPTRZ(XDZARUHUNOF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x37641E0", Offset = "0x37631E0", VA = "0x1837641E0")]
		public void CUDNYRZAFUU<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x37641E0", Offset = "0x37631E0", VA = "0x1837641E0")]
		public void CUDNYRZAFUU<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x76DFBC0", Offset = "0x76DEBC0", VA = "0x1876DFBC0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x76EBA30", Offset = "0x76EAA30", VA = "0x1876EBA30")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class TJXXBRMXBTE
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
		private abstract class SLCLVXVYNAG<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType GLAENVNETGX;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x60DB5C0", Offset = "0x60DA5C0", VA = "0x1860DB5C0", Slot = "4")]
			public virtual void GRLRHMOCTOZ(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void RPBXVQSXYXN(a a, XDZARUHUNOF b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void VCPJVSQNYKO(a a, LTVONMSWSUV b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void LMWKIDJWCVG(a a, XDZARUHUNOF b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void ZWBBHUMOGNB(a a, LTVONMSWSUV b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void TCWMCMYZZIH(a a, XDZARUHUNOF b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void LJPDJTXLXVQ(a a, LTVONMSWSUV b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			protected SLCLVXVYNAG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class RJJWWDRXVLR<a, b> : SLCLVXVYNAG<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> HTMYBPLJHEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> MXDPWZCCXHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> DSJXWXULNZJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> WUKAXXDFLYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> POOYJPJHTXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> AOOWVFRZFZK;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C190", Offset = "0x5E7B190", VA = "0x185E7C190", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C190", Offset = "0x5E7B190", VA = "0x185E7C190", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C0C0", Offset = "0x5E7B0C0", VA = "0x185E7C0C0", Slot = "9")]
			public override void TCWMCMYZZIH(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C0C0", Offset = "0x5E7B0C0", VA = "0x185E7C0C0", Slot = "10")]
			public override void LJPDJTXLXVQ(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C260", Offset = "0x5E7B260", VA = "0x185E7C260")]
			protected b[] WOJOQDGRMBO(a a, XDZARUHUNOF b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BF50", Offset = "0x5E7AF50", VA = "0x185E7BF50")]
			protected b[] IHMBNKGEMTR(a a, LTVONMSWSUV b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B410", Offset = "0x5E7A410", VA = "0x185E7B410", Slot = "4")]
			public override void GRLRHMOCTOZ(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C520", Offset = "0x5E7B520", VA = "0x185E7C520")]
			protected RJJWWDRXVLR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class DFOITRRPZAA<a, b> : RJJWWDRXVLR<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void QEJYZYBPFWB(XDZARUHUNOF a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void WSCQZYGIHFC(LTVONMSWSUV a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x4223BA0", Offset = "0x4222BA0", VA = "0x184223BA0", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4223DB0", Offset = "0x4222DB0", VA = "0x184223DB0", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4223A90", Offset = "0x4222A90", VA = "0x184223A90", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4224200", Offset = "0x4223200", VA = "0x184224200", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x42242A0", Offset = "0x42232A0", VA = "0x1842242A0")]
			protected DFOITRRPZAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class MEQFPHMEIIH<a> : RJJWWDRXVLR<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x5A86360", Offset = "0x5A85360", VA = "0x185A86360", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5A864D0", Offset = "0x5A854D0", VA = "0x185A864D0", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5A86210", Offset = "0x5A85210", VA = "0x185A86210", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x422CCA0", Offset = "0x422BCA0", VA = "0x18422CCA0", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public MEQFPHMEIIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class WERSWKMYADK<a> : RJJWWDRXVLR<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5A86360", Offset = "0x5A85360", VA = "0x185A86360", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x5A864D0", Offset = "0x5A854D0", VA = "0x185A864D0", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6862D90", Offset = "0x6861D90", VA = "0x186862D90", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x422CCA0", Offset = "0x422BCA0", VA = "0x18422CCA0", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public WERSWKMYADK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class JGACAZGVRTW<a> : RJJWWDRXVLR<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x52A9B90", Offset = "0x52A8B90", VA = "0x1852A9B90", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x52A9E20", Offset = "0x52A8E20", VA = "0x1852A9E20", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x52A9B40", Offset = "0x52A8B40", VA = "0x1852A9B40", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x52A9E60", Offset = "0x52A8E60", VA = "0x1852A9E60", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public JGACAZGVRTW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class SUTEIUFSZBR<a> : RJJWWDRXVLR<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x52A9B90", Offset = "0x52A8B90", VA = "0x1852A9B90", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x52A9E20", Offset = "0x52A8E20", VA = "0x1852A9E20", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x60EE0D0", Offset = "0x60ED0D0", VA = "0x1860EE0D0", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x52A9E60", Offset = "0x52A8E60", VA = "0x1852A9E60", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public SUTEIUFSZBR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class CUHMJTGRKTU<a> : RJJWWDRXVLR<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5750", Offset = "0x3ED4750", VA = "0x183ED5750", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3ED57A0", Offset = "0x3ED47A0", VA = "0x183ED57A0", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3ED54E0", Offset = "0x3ED44E0", VA = "0x183ED54E0", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3ED58F0", Offset = "0x3ED48F0", VA = "0x183ED58F0", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public CUHMJTGRKTU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class NIBSXYLKDTV<a> : RJJWWDRXVLR<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5750", Offset = "0x3ED4750", VA = "0x183ED5750", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3ED57A0", Offset = "0x3ED47A0", VA = "0x183ED57A0", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x5B5D540", Offset = "0x5B5C540", VA = "0x185B5D540", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3ED58F0", Offset = "0x3ED48F0", VA = "0x183ED58F0", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public NIBSXYLKDTV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class LWTOPODMIOS<a> : RJJWWDRXVLR<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x48CD9C0", Offset = "0x48CC9C0", VA = "0x1848CD9C0", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x48CDB20", Offset = "0x48CCB20", VA = "0x1848CDB20", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5575490", Offset = "0x5574490", VA = "0x185575490", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3F44290", Offset = "0x3F43290", VA = "0x183F44290", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public LWTOPODMIOS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class ELPTGQABWLH<a> : RJJWWDRXVLR<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x48CD9C0", Offset = "0x48CC9C0", VA = "0x1848CD9C0", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x48CDB20", Offset = "0x48CCB20", VA = "0x1848CDB20", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x48CD850", Offset = "0x48CC850", VA = "0x1848CD850", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3F44290", Offset = "0x3F43290", VA = "0x183F44290", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public ELPTGQABWLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class DGWTWCHFXEQ<a> : RJJWWDRXVLR<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x422CB00", Offset = "0x422BB00", VA = "0x18422CB00", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x422CC60", Offset = "0x422BC60", VA = "0x18422CC60", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x422C890", Offset = "0x422B890", VA = "0x18422C890", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x422CCA0", Offset = "0x422BCA0", VA = "0x18422CCA0", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public DGWTWCHFXEQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class VXIUZXLKHTX<a> : RJJWWDRXVLR<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x64E98F0", Offset = "0x64E88F0", VA = "0x1864E98F0", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x64E9A50", Offset = "0x64E8A50", VA = "0x1864E9A50", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x64E9780", Offset = "0x64E8780", VA = "0x1864E9780", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3ED58F0", Offset = "0x3ED48F0", VA = "0x183ED58F0", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public VXIUZXLKHTX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class ZKZJDOUVERK<a> : RJJWWDRXVLR<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x3F43EC0", Offset = "0x3F42EC0", VA = "0x183F43EC0", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x3F44030", Offset = "0x3F43030", VA = "0x183F44030", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x3F43E70", Offset = "0x3F42E70", VA = "0x183F43E70", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x3F44290", Offset = "0x3F43290", VA = "0x183F44290", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3ED5A40", Offset = "0x3ED4A40", VA = "0x183ED5A40")]
			public ZKZJDOUVERK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class ZGLDZCFQWZO<a> : DFOITRRPZAA<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x3F36790", Offset = "0x3F35790", VA = "0x183F36790", Slot = "12")]
			protected override void WSCQZYGIHFC(LTVONMSWSUV a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x3F36760", Offset = "0x3F35760", VA = "0x183F36760", Slot = "11")]
			protected override void QEJYZYBPFWB(XDZARUHUNOF a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x3E925E0", Offset = "0x3E915E0", VA = "0x183E925E0")]
			public ZGLDZCFQWZO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class XAUVHAKCVFW<a> : DFOITRRPZAA<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x3E925B0", Offset = "0x3E915B0", VA = "0x183E925B0", Slot = "12")]
			protected override void WSCQZYGIHFC(LTVONMSWSUV a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3E92570", Offset = "0x3E91570", VA = "0x183E92570", Slot = "11")]
			protected override void QEJYZYBPFWB(XDZARUHUNOF a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x3E925E0", Offset = "0x3E915E0", VA = "0x183E925E0")]
			public XAUVHAKCVFW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class XPLQOLWBYEJ<a> : RJJWWDRXVLR<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int SGSILUFJCNQ;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3E99BA0", Offset = "0x3E98BA0", VA = "0x183E99BA0")]
			public XPLQOLWBYEJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x3E99880", Offset = "0x3E98880", VA = "0x183E99880", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x3E999F0", Offset = "0x3E989F0", VA = "0x183E999F0", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x3E99700", Offset = "0x3E98700", VA = "0x183E99700", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x3E99A40", Offset = "0x3E98A40", VA = "0x183E99A40", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class LUNOSXACMXF<a> : SLCLVXVYNAG<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo OZXNKABXNMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type EHNVZGTCLRQ;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5573CB0", Offset = "0x5572CB0", VA = "0x185573CB0")]
			public LUNOSXACMXF(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x55738F0", Offset = "0x55728F0", VA = "0x1855738F0", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5573BE0", Offset = "0x5572BE0", VA = "0x185573BE0", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x55738A0", Offset = "0x55728A0", VA = "0x1855738A0", Slot = "7")]
			public override void LMWKIDJWCVG(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x55738A0", Offset = "0x55728A0", VA = "0x1855738A0", Slot = "8")]
			public override void ZWBBHUMOGNB(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x5573850", Offset = "0x5572850", VA = "0x185573850", Slot = "9")]
			public override void TCWMCMYZZIH(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x5573850", Offset = "0x5572850", VA = "0x185573850", Slot = "10")]
			public override void LJPDJTXLXVQ(a a, LTVONMSWSUV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class OESISNUPEEQ<a> : LUNOSXACMXF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1EF0", Offset = "0x5CA0EF0", VA = "0x185CA1EF0")]
			public OESISNUPEEQ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1CC0", Offset = "0x5CA0CC0", VA = "0x185CA1CC0", Slot = "5")]
			public override void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1E80", Offset = "0x5CA0E80", VA = "0x185CA1E80", Slot = "6")]
			public override void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class BBJREDUWPIK<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static BBJREDUWPIK<a> QSHZKWMVMOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly SLCLVXVYNAG<a>[] RRKXORCKAFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int GRPWDHVEREO;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x3D439A0", Offset = "0x3D429A0", VA = "0x183D439A0")]
			public BBJREDUWPIK(List<SLCLVXVYNAG<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3D43850", Offset = "0x3D42850", VA = "0x183D43850")]
			public void VCPJVSQNYKO(a a, LTVONMSWSUV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3D435F0", Offset = "0x3D425F0", VA = "0x183D435F0")]
			public void RPBXVQSXYXN(a a, XDZARUHUNOF b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class XYJGMYCTKXW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract SLCLVXVYNAG<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private LTVONMSWSUV YNGMRHQUAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int FDZXAIZFJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, XYJGMYCTKXW> VWXFHSUSDRT;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x76ECA40", Offset = "0x76EBA40", VA = "0x1876ECA40")]
		public TJXXBRMXBTE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AFDAC0", Offset = "0x3AFCAC0", VA = "0x183AFDAC0")]
		private BBJREDUWPIK<d> AFDPKUACVFB<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE880", Offset = "0x3AFD880", VA = "0x183AFE880")]
		public void BPSMAKIBARY<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE8C0", Offset = "0x3AFD8C0", VA = "0x183AFE8C0")]
		public bool Deserialize<T>(XDZARUHUNOF reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE940", Offset = "0x3AFD940", VA = "0x183AFE940")]
		public void XRHSQBYDVHR<f>(LTVONMSWSUV a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class XUHYCLBHZOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime AVEMPYCUHEI;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] AHLRTDIYUYC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator SSDVNJEYERU
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x76F2930", Offset = "0x76F1930", VA = "0x1876F2930")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int YSGNJWGPFVW
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x76F1BE0", Offset = "0x76F0BE0", VA = "0x1876F1BE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x76F2510", Offset = "0x76F1510", VA = "0x1876F2510")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode ZIVQKMULLMU
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x76F1B20", Offset = "0x76F0B20", VA = "0x1876F1B20")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x76F2700", Offset = "0x76F1700", VA = "0x1876F2700")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ONMYSLSCOBT
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x76F2900", Offset = "0x76F1900", VA = "0x1876F2900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint KMUQZVLXZTP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x76F2640", Offset = "0x76F1640", VA = "0x1876F2640")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? UQVPJNHPFNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x76F1BB0", Offset = "0x76F0BB0", VA = "0x1876F1BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? OVETHYGNRLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x76F2310", Offset = "0x76F1310", VA = "0x1876F2310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? TTJLKLLILAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x76F2610", Offset = "0x76F1610", VA = "0x1876F2610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x76F1960", Offset = "0x76F0960", VA = "0x1876F1960")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? FONLXNIMSZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCE16B0", Offset = "0xCE06B0", VA = "0x180CE16B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xD065E0", Offset = "0xD055E0", VA = "0x180D065E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x76F29C0", Offset = "0x76F19C0", VA = "0x1876F29C0")]
		public XUHYCLBHZOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x76F2CD0", Offset = "0x76F1CD0", VA = "0x1876F2CD0")]
		internal XUHYCLBHZOL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C10", Offset = "0x76F0C10", VA = "0x1876F1C10")]
		public static XUHYCLBHZOL EZISGXGUCZV(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F90", Offset = "0x76F0F90", VA = "0x1876F1F90")]
		internal void JEHDRHCDCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D20", Offset = "0x76F0D20", VA = "0x1876F1D20")]
		private void HDEIBZICCKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x76F2340", Offset = "0x76F1340", VA = "0x1876F2340")]
		private DateTime? OSDQRYZJJCO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x76F2740", Offset = "0x76F1740", VA = "0x1876F2740")]
		private void VIFXOHOTKVY(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x76F1EE0", Offset = "0x76F0EE0", VA = "0x1876F1EE0")]
		private ulong ILJSUBFHZDU(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x76F2550", Offset = "0x76F1550", VA = "0x1876F2550")]
		private void RNRHIBNRYIS(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x76F26A0", Offset = "0x76F16A0", VA = "0x1876F26A0")]
		private uint THICINVNNZT(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x75AB640", Offset = "0x75AA640", VA = "0x1875AB640")]
		private static uint CQAWYUKZNCE(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B50", Offset = "0x76F0B50", VA = "0x1876F1B50")]
		private static ulong CQAWYUKZNCE(ulong a)
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
	internal sealed class TQRRPWPMWOU
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int VIPUVJFMJYB = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int XTFGPYXIPWE = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int TSOYHWDNHKD = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint QEZNJCKILMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int YDHJUQQNBTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int QQNOZVFHQVH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool VAOXRMMKAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x76ECBC0", Offset = "0x76EBBC0", VA = "0x1876ECBC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x76ECAD0", Offset = "0x76EBAD0", VA = "0x1876ECAD0")]
		public bool AMONIKBVVAV(MZXGTKOKXSD a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class ZPDOKITIDMS : MZXGTKOKXSD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket KPZVIDHCNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly MGNESVRMCDL JUDIMMQARXX;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short TWLFSOHLUSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x76F3C10", Offset = "0x76F2C10", VA = "0x1876F3C10", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int ESOBKPVIGBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x76F3BF0", Offset = "0x76F2BF0", VA = "0x1876F3BF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint MBJWMZYTKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x76F3D20", Offset = "0x76F2D20", VA = "0x1876F3D20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily CQBDUVIXYZH
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x304E310", Offset = "0x304D310", VA = "0x18304E310", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x76F3D80", Offset = "0x76F2D80", VA = "0x1876F3D80")]
		public ZPDOKITIDMS(AddressFamily a, MGNESVRMCDL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x76F3610", Offset = "0x76F2610", VA = "0x1876F3610", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x76F3D40", Offset = "0x76F2D40", VA = "0x1876F3D40", Slot = "9")]
		public int OGYBUGPVOJG(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x76F3C30", Offset = "0x76F2C30", VA = "0x1876F3C30", Slot = "10")]
		public int KNIBQUVOWYE(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x76F3BD0", Offset = "0x76F2BD0", VA = "0x1876F3BD0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface MZXGTKOKXSD
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short TWLFSOHLUSV
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int ESOBKPVIGBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint MBJWMZYTKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily CQBDUVIXYZH
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
		int OGYBUGPVOJG(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int KNIBQUVOWYE(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x76EB6C0", Offset = "0x76EA6C0", VA = "0x1876EB6C0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x76EB760", Offset = "0x76EA760", VA = "0x1876EB760")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x13B8030", Offset = "0x13B7030", VA = "0x1813B8030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x76EB5D0", Offset = "0x76EA5D0", VA = "0x1876EB5D0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x76EB610", Offset = "0x76EA610", VA = "0x1876EB610", Slot = "0")]
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
	public class USBBXVNSRSS
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string VBGZVBEVJTI = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int RIGKFYCARSW = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int PWERMVYSKIA = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int LTQRKUTSRMW = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> WXLOJIOEACD;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback LFPXGWYQOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int WNVINUWLSZQ;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		internal void EHLDRQFXFFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		internal void VDQOGMAHALO(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class UZQIVKXUSMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int PJRGOODGRVQ;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
		protected UZQIVKXUSMJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UEUYBVRZFKN(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OSZTPGRGPRC(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class FVCPKHHCIGF : UZQIVKXUSMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] MFGYHTMRNRY;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator ZZTQIZHNPJO;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2943980", Offset = "0x2942980", VA = "0x182943980")]
		public FVCPKHHCIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x76DDE90", Offset = "0x76DCE90", VA = "0x1876DDE90")]
		public void AIFIAXPUUDL(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x76DE040", Offset = "0x76DD040", VA = "0x1876DE040")]
		public void JUXTFHGSNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x76DE420", Offset = "0x76DD420", VA = "0x1876DE420", Slot = "4")]
		public override void UEUYBVRZFKN(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x76DE120", Offset = "0x76DD120", VA = "0x1876DE120", Slot = "5")]
		public override void OSZTPGRGPRC(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class ZJXPMJAKVVS
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr RRRBRXCHXBW;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x76F42F0", Offset = "0x76F32F0", VA = "0x1876F42F0")]
			[BurstDiscard]
			private static void QSTKGPBCEDO(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x76F3F30", Offset = "0x76F2F30", VA = "0x1876F3F30")]
			private static IntPtr IUQYFJLMUJA()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x76F40B0", Offset = "0x76F30B0", VA = "0x1876F40B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76EC600", Offset = "0x76EB600", VA = "0x1876EC600")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x76EC460", Offset = "0x76EB460", VA = "0x1876EC460")]
		private uint MQHQOBMQLFH(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x76DC600", Offset = "0x76DB600", VA = "0x1876DC600")]
		private void KOWBLPGFGTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x76DC6B0", Offset = "0x76DB6B0", VA = "0x1876DC6B0")]
		private void NYPRUPBASTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x76DC570", Offset = "0x76DB570", VA = "0x1876DC570")]
		private void ABFJCGDXJTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x76DC8C0", Offset = "0x76DB8C0", VA = "0x1876DC8C0")]
		private void PKSKQQQKRTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x76EC680", Offset = "0x76EB680", VA = "0x1876EC680")]
		private void YMOWMEIEIYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x76EBFD0", Offset = "0x76EAFD0", VA = "0x1876EBFD0")]
		private unsafe void EFQYJFRSNHL(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x76EC540", Offset = "0x76EB540", VA = "0x1876EC540")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void NKKPAABWLAA([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x76EC550", Offset = "0x76EB550", VA = "0x1876EC550")]
		public static void NKKPAABWLAA(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x76EC490", Offset = "0x76EB490", VA = "0x1876EC490")]
		public static void NAODDLXOZDG(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x76EC3F0", Offset = "0x76EB3F0", VA = "0x1876EC3F0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void FTWBMGTDATF([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x76F3EF0", Offset = "0x76F2EF0", VA = "0x1876F3EF0")]
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
