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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, UOBTKOSGHEF
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
		private NetworkManager XZILGNPUNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool LRTGMYUGGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, PMSTCWOODUI> FGBNKCGXBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private EJWJHWSSZOX LXXKVPOOQXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch SRDRHDAKYWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] ACJWUFESMHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType GOIRYULWENF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int RRMLKXOHMDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C25360", Offset = "0x7C23F60", VA = "0x187C25360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7C25310", Offset = "0x7C23F10", VA = "0x187C25310", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C247C0", Offset = "0x7C233C0", VA = "0x187C247C0")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C247A0", Offset = "0x7C233A0", VA = "0x187C247A0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C24470", Offset = "0x7C23070", VA = "0x187C24470")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C251D0", Offset = "0x7C23DD0", VA = "0x187C251D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C248D0", Offset = "0x7C234D0", VA = "0x187C248D0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C24760", Offset = "0x7C23360", VA = "0x187C24760", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C24BA0", Offset = "0x7C237A0", VA = "0x187C24BA0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C24EE0", Offset = "0x7C23AE0", VA = "0x187C24EE0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C23DA0", Offset = "0x7C229A0", VA = "0x187C23DA0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C23CB0", Offset = "0x7C228B0", VA = "0x187C23CB0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C23FA0", Offset = "0x7C22BA0", VA = "0x187C23FA0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B30", Offset = "0x7C23730", VA = "0x187C24B30", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C24070", Offset = "0x7C22C70", VA = "0x187C24070", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C25100", Offset = "0x7C23D00", VA = "0x187C25100")]
		private DeliveryMethod UVOJWFBNGDA(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C24350", Offset = "0x7C22F50", VA = "0x187C24350", Slot = "16")]
		private void NPFMDNBCNRP(PMSTCWOODUI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C23ED0", Offset = "0x7C22AD0", VA = "0x187C23ED0", Slot = "17")]
		private void ERIGVRRZBMN(PMSTCWOODUI a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "18")]
		private void CYWBNXZWVDY(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C24560", Offset = "0x7C23160", VA = "0x187C24560", Slot = "19")]
		private void PGVUMIUFSMZ(PMSTCWOODUI a, QHCYODGZRNV b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C24280", Offset = "0x7C22E80", VA = "0x187C24280")]
		private void KIPUOXDZDNM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "20")]
		private void ZOCJLTNJDVP(IPEndPoint a, QHCYODGZRNV b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "21")]
		private void TKKAVFJXERN(PMSTCWOODUI a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C24410", Offset = "0x7C23010", VA = "0x187C24410", Slot = "22")]
		private void NUZSKAIGXFZ(HAOCQBFITIC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C251F0", Offset = "0x7C23DF0", VA = "0x187C251F0")]
		private ulong WLGFIJUEBQA(PMSTCWOODUI a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C25220", Offset = "0x7C23E20", VA = "0x187C25220")]
		private ulong WLGFIJUEBQA(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C23EB0", Offset = "0x7C22AB0", VA = "0x187C23EB0")]
		private static int EJWRNCEMPUN(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C25240", Offset = "0x7C23E40", VA = "0x187C25240")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C24040", Offset = "0x7C22C40", VA = "0x187C24040")]
		[CompilerGenerated]
		private void LSGVEZJAIPB(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C24040", Offset = "0x7C22C40", VA = "0x187C24040")]
		[CompilerGenerated]
		private void HXYEVAGGKCW(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class FVIWRWOQLZN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly PMSTCWOODUI BMGLVDAOOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<PMNHNWFJYVW> TULMNWODUUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int SZINDPRZZLL;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int XYPXOSRAYSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7C21730", Offset = "0x7C20330", VA = "0x187C21730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C217E0", Offset = "0x7C203E0", VA = "0x187C217E0")]
		protected FVIWRWOQLZN(PMSTCWOODUI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C21780", Offset = "0x7C20380", VA = "0x187C21780")]
		public void WMANEBSAZPG(PMNHNWFJYVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C21670", Offset = "0x7C20270", VA = "0x187C21670")]
		protected void EIELHKNMFBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C216F0", Offset = "0x7C202F0", VA = "0x187C216F0")]
		public bool ENTZOZGQTBZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool VYCKNEKHKHJ();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool TOCIBIURMXE(PMNHNWFJYVW a);
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
	public class HAOCQBFITIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly EJWJHWSSZOX WUVFVTSRWRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int GINUDKCPXQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal NKSSTQFNVDF OIWCWVBHIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint ZYMZWACEHRQ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult SPCBIKWMREI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x16E6ED0", Offset = "0x16E5AD0", VA = "0x1816E6ED0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x16E6EE0", Offset = "0x16E5AE0", VA = "0x1816E6EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C218D0", Offset = "0x7C204D0", VA = "0x187C218D0")]
		internal void HWFUFKDUMRD(NKSSTQFNVDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C21930", Offset = "0x7C20530", VA = "0x187C21930")]
		private bool ZSKIUQTLTMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C21960", Offset = "0x7C20560", VA = "0x187C21960")]
		internal HAOCQBFITIC(IPEndPoint a, NKSSTQFNVDF b, EJWJHWSSZOX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C21870", Offset = "0x7C20470", VA = "0x187C21870")]
		public PMSTCWOODUI Accept()
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
		public QHCYODGZRNV AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface UOBTKOSGHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FYDDKMIRVOD(PMSTCWOODUI a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BEQFMBKIVWP(PMSTCWOODUI a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ECAJKUBVOMI(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JYVIHFBFJAX(PMSTCWOODUI a, QHCYODGZRNV b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DXVYUDVISXN(IPEndPoint a, QHCYODGZRNV b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WRVKJZLQOLX(PMSTCWOODUI a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RBIUUTRXRMF(HAOCQBFITIC a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QZQFFVPNWKY
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GBUDHBUILKF(PMSTCWOODUI a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LOJYPGEUCNQ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KSYCRPNUVPX(JKFIFABLLJL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface NMTIZHJNREY
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EFYLAJRATLW(PMSTCWOODUI a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class NKSSTQFNVDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int NJCNYUDUPFT = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long DJWMZKMRKTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte TDOCDYKHLYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] BAQOCGYGGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly ZRQXHSKTRTJ RXLJWTQVVNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int CHYVCHFPLVG;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C25AE0", Offset = "0x7C246E0", VA = "0x187C25AE0")]
		private NKSSTQFNVDF(long a, byte b, int c, byte[] d, ZRQXHSKTRTJ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7C256E0", Offset = "0x7C242E0", VA = "0x187C256E0")]
		public static int FCZYJNMXNAC(PMNHNWFJYVW a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C258F0", Offset = "0x7C244F0", VA = "0x187C258F0")]
		public static NKSSTQFNVDF QXMEOAEUWGR(PMNHNWFJYVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C25710", Offset = "0x7C24310", VA = "0x187C25710")]
		public static PMNHNWFJYVW HBXGPJZHEFF(PZCLKDPONBJ a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class PWOPAVNCMYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long DJWMZKMRKTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte TDOCDYKHLYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int CHYVCHFPLVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool QBXEQQIRMBV;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AD40", Offset = "0x7C29940", VA = "0x187C2AD40")]
		private PWOPAVNCMYG(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AB40", Offset = "0x7C29740", VA = "0x187C2AB40")]
		public static PWOPAVNCMYG QXMEOAEUWGR(PMNHNWFJYVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AA50", Offset = "0x7C29650", VA = "0x187C2AA50")]
		public static PMNHNWFJYVW HBXGPJZHEFF(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC40", Offset = "0x7C29840", VA = "0x187C2AC40")]
		public static PMNHNWFJYVW VKLASDIQNGF(PMSTCWOODUI a)
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
	public interface TOHNFJZIZIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SMMKGRFXBBO(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QAUVFNKMKLQ(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class YVJWISHUCCI
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
		private class IESGGZRCOKK
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint FTWNLTJMHTW
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string FCWFZLEDINY
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IESGGZRCOKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class XSGNWYMTDBM
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint FTWNLTJMHTW
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint ZAPKMNXUEJQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string FCWFZLEDINY
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XSGNWYMTDBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class GOIQHLJYWGA
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string FCWFZLEDINY
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool OOUEXQPDYJY
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xB1A400", Offset = "0xB19000", VA = "0x180B1A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GOIQHLJYWGA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly EJWJHWSSZOX LFYXNIJKYHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> LVWGAVQDYJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> LQTZMYFKJEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly ZRQXHSKTRTJ GEDEKZFQIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly PZCLKDPONBJ XIOCSXQPTQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly JHKQWAOOONC UUVFDZXELTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TOHNFJZIZIN CSWYGNHYDVN;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int MIFEMSNGYCG = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool QSGQKHGOZGZ;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EC50", Offset = "0x7C2D850", VA = "0x187C2EC50")]
		internal YVJWISHUCCI(EJWJHWSSZOX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E650", Offset = "0x7C2D250", VA = "0x187C2E650")]
		internal void BIVPGOBUHMN(IPEndPoint a, PMNHNWFJYVW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x41EC110", Offset = "0x41EAD10", VA = "0x1841EC110")]
		private void GTVILGOLMDJ<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E960", Offset = "0x7C2D560", VA = "0x187C2E960")]
		private void SMMKGRFXBBO(IESGGZRCOKK a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EAF0", Offset = "0x7C2D6F0", VA = "0x187C2EAF0")]
		private void ZNWVTUKFEUY(XSGNWYMTDBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E7D0", Offset = "0x7C2D3D0", VA = "0x187C2E7D0")]
		private void ILFKQTINERP(GOIQHLJYWGA a, IPEndPoint b)
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
	public static class CDRIJMIRGAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] ANEEPTUFJVE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int NKFYHRFWTYQ;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int HJDZLMJBTNP;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7C225A0", Offset = "0x7C211A0", VA = "0x187C225A0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C225A0", Offset = "0x7C211A0", VA = "0x187C225A0")]
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
	public interface RMMILISZKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KHLHUOWQRBZ(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class HFASZCKZXNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static RMMILISZKMH ZDUXGRPYFEZ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object LHUWKVIQOMF;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C21A30", Offset = "0x7C20630", VA = "0x187C21A30")]
		private static void CDHCPSFGHDI(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C21CC0", Offset = "0x7C208C0", VA = "0x187C21CC0")]
		internal static void SZKCOTAZTGK(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C219D0", Offset = "0x7C205D0", VA = "0x187C219D0")]
		internal static void ADPBYZWBUCU(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C60", Offset = "0x7C20860", VA = "0x187C21C60")]
		internal static void KQFEUZEKURA(string a, params object[] args)
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
	public sealed class QHCYODGZRNV : ZRQXHSKTRTJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private PMNHNWFJYVW DNHKEBJVVZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly EJWJHWSSZOX JAQYDYHNJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly VWDFVUMBMKU INMJXBOKUTF;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BEA0", Offset = "0x7C2AAA0", VA = "0x187C2BEA0")]
		internal QHCYODGZRNV(EJWJHWSSZOX a, VWDFVUMBMKU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BE30", Offset = "0x7C2AA30", VA = "0x187C2BE30")]
		internal void PGCHBNWMHJA(PMNHNWFJYVW a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BD80", Offset = "0x7C2A980", VA = "0x187C2BD80")]
		internal void CGGIQTWSKVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BE00", Offset = "0x7C2AA00", VA = "0x187C2BE00")]
		public void EJRHHUKMAWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class VWDFVUMBMKU
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
		public VWDFVUMBMKU ZFJJOLSAJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType JGVJNZJVVLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PMSTCWOODUI BMGLVDAOOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint ZYMZWACEHRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object IXXYSRRZEBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int IWMIYYNDRHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError LIDVTAOMDWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason VYHGJLSYYBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HAOCQBFITIC HAOCQBFITIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod ROZIECCLHTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte BXTVNYQNWXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly QHCYODGZRNV BLUFZGKLPUK;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CFA0", Offset = "0x7C2BBA0", VA = "0x187C2CFA0")]
		public VWDFVUMBMKU(EJWJHWSSZOX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EJWJHWSSZOX : IEnumerable<PMSTCWOODUI>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class NCBEBEFXHFE : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7C25640", Offset = "0x7C24240", VA = "0x187C25640", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7C256B0", Offset = "0x7C242B0", VA = "0x187C256B0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public NCBEBEFXHFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<PMSTCWOODUI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly PMSTCWOODUI _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private PMSTCWOODUI _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public PMSTCWOODUI Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2031140", Offset = "0x202FD40", VA = "0x182031140")]
			public NetPeerEnumerator(PMSTCWOODUI p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7C25F20", Offset = "0x7C24B20", VA = "0x187C25F20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C25F70", Offset = "0x7C24B70", VA = "0x187C25F70", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread BLWCIGFHGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool EDPMIACRLTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool KIGENKNDWJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private JFOGELVWMFO NEZZXIKDTRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent YLAWLWDAVTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<VWDFVUMBMKU> JBFEVSJIMUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<VWDFVUMBMKU> LTOVWPQNHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private VWDFVUMBMKU BYCYUURGEWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly UOBTKOSGHEF YUJMSZFIKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly QZQFFVPNWKY XTGTXLKXJJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly LOJYPGEUCNQ XFHPZQHVXTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly NMTIZHJNREY OEVPQKYDZNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, PMSTCWOODUI> FHEANGKZXTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, HAOCQBFITIC> WUNGNFVMDOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, ZZFBVKRFOBA> BIVZAERWYXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim JNTPVSDQLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private PMSTCWOODUI LCSIZOIEKAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int LQBDREDXYBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<PMSTCWOODUI> JAKNPXEZOSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private PMSTCWOODUI[] XVNFDURRQZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly JGDJVWFLAJF UUGRKWXAEUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int RBSJRUSYTLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> XUBNHJYQRGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte VIVWAIWEWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object XZYALVVPPZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool ZCPIBOXJDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool DSFOGVNTNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int SGSXHIZTTBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int FQQFKOLISYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int TLHEZGSGOQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int UDCNDESQXQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool MPYVCCEPMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool LTNFCPCPWXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int TWRZCRTMNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int BBNZOSBZYZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int DYBXTXPQQVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool QSGQKHGOZGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool FDEGLDYRSBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool AUTNLTOCFYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool PJWIIAKDKQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int WNZBSWAFAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int JYHSSDQCKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool ZVVOAGHYAEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly IJOBGFBPWGX HJTWIDHDPQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool TLITKWCIIXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly YVJWISHUCCI YVJWISHUCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool WIEKCSQGCRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode CZSIAOIHOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int MKTLCZEDICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool TUKGSPAKIOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool VOEHEDXROLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool WYWOKVVHIYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool UPKLORMJJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private PMNHNWFJYVW HLHPSWNCBXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int OCTRSBLPEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object QGOTGTNXKRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private PMNHNWFJYVW LGCRDFZTUDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int DLJJRMWDPRU;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int WKVHRWWHPPE = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int IDOXPSISASH = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private OUXPLKHTPTT BLFEDIBKVBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private OUXPLKHTPTT BKUQIUNQCEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread LYHZBJPNMSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread LYSMVXDIFOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint AOSJPGHCBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint APCXJTUWUGV;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] NCKGEJWRBCD;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] RWPGRXBMZVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> XHQQLNTPZBK;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress AQCKEMNUFBZ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool EACGFXHAPOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int JYDABRJQUGT;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool VOZSCDFXYQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBD7AA0", Offset = "0xBD66A0", VA = "0x180BD7AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xC35E00", Offset = "0xC34A00", VA = "0x180C35E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int GEKHPUYVDTB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBA6130", Offset = "0xBA4D30", VA = "0x180BA6130")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xC03AB0", Offset = "0xC026B0", VA = "0x180C03AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte ZVDKGYKRSGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE78B90", Offset = "0xE77790", VA = "0x180E78B90")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int ZLREEVQAPDS
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1B950", Offset = "0x7C1A550", VA = "0x187C1B950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short JJPTCTYDPXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7C1E260", Offset = "0x7C1CE60", VA = "0x187C1E260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PMSTCWOODUI.OnUpdatedMtuDelegate VFPZNJTQRLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7C1C890", Offset = "0x7C1B490", VA = "0x187C1C890")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F260", Offset = "0x7C1DE60", VA = "0x187C1F260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EEC0", Offset = "0x7C1DAC0", VA = "0x187C1EEC0")]
		public void TYAHOSMMUDX(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C940", Offset = "0x7C1B540", VA = "0x187C1C940")]
		public void QEGYZWPZGKE(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C19610", Offset = "0x7C18210", VA = "0x187C19610")]
		private bool BUJQCJVXYHM(IPEndPoint a, [Out] PMSTCWOODUI b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BDE0", Offset = "0x7C1A9E0", VA = "0x187C1BDE0")]
		private void KAUYRJMKNIE(PMSTCWOODUI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C830", Offset = "0x7C1B430", VA = "0x187C1C830")]
		private void OUUMWJRBYHD(PMSTCWOODUI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C570", Offset = "0x7C1B170", VA = "0x187C1C570")]
		private void OQVPOIZTGFS(PMSTCWOODUI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C208B0", Offset = "0x7C1F4B0", VA = "0x187C208B0")]
		public EJWJHWSSZOX(UOBTKOSGHEF a, [Optional] JGDJVWFLAJF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C190", Offset = "0x7C1AD90", VA = "0x187C1C190")]
		internal void NKCQOIINYYY(PMSTCWOODUI a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B620", Offset = "0x7C1A220", VA = "0x187C1B620")]
		internal void GMZWVTQGWMM(PMSTCWOODUI a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F460", Offset = "0x7C1E060", VA = "0x187C1F460")]
		internal void XGSIZKPNVBQ(PMSTCWOODUI a, DisconnectReason b, SocketError c, PMNHNWFJYVW d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B9F0", Offset = "0x7C1A5F0", VA = "0x187C1B9F0")]
		private void JSAPXHUJDJN(PMSTCWOODUI a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, PMNHNWFJYVW h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F770", Offset = "0x7C1E370", VA = "0x187C1F770")]
		private void YLNDITAFWDZ(VWDFVUMBMKU.EType a, [Optional] PMSTCWOODUI b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] HAOCQBFITIC g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] PMNHNWFJYVW j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7C20050", Offset = "0x7C1EC50", VA = "0x187C20050")]
		private void ZXCOKGBXDYC(VWDFVUMBMKU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B670", Offset = "0x7C1A270", VA = "0x187C1B670")]
		internal void HJIZYJUBEEK(VWDFVUMBMKU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C19FE0", Offset = "0x7C18BE0", VA = "0x187C19FE0")]
		private void DMYAFKMWHWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A340", Offset = "0x7C18F40", VA = "0x187C1A340")]
		private void DOSYXQLCHVA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AE80", Offset = "0x7C19A80", VA = "0x187C1AE80")]
		internal PMSTCWOODUI DWLCEWMAJGN(HAOCQBFITIC a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C196B0", Offset = "0x7C182B0", VA = "0x187C196B0")]
		private int CNSORYCQQMT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C190E0", Offset = "0x7C17CE0", VA = "0x187C190E0")]
		private void ASUDNEUSHQN(IPEndPoint a, PMSTCWOODUI b, NKSSTQFNVDF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CF40", Offset = "0x7C1BB40", VA = "0x187C1CF40")]
		private void RYPKFGQZBFK(PMNHNWFJYVW a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F4A0", Offset = "0x7C1E0A0", VA = "0x187C1F4A0")]
		internal void YHCGMCXSRMK(PMNHNWFJYVW a, DeliveryMethod b, byte c, int d, PMSTCWOODUI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E320", Offset = "0x7C1CF20", VA = "0x187C1E320")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EB30", Offset = "0x7C1D730", VA = "0x187C1EB30")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EAB0", Offset = "0x7C1D6B0", VA = "0x187C1EAB0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FBD0", Offset = "0x7C1E7D0", VA = "0x187C1FBD0")]
		public void ZGOUBXKYXXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C19F00", Offset = "0x7C18B00", VA = "0x187C19F00")]
		public PMSTCWOODUI Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C19E20", Offset = "0x7C18A20", VA = "0x187C19E20")]
		public PMSTCWOODUI Connect(string address, int port, PZCLKDPONBJ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C19A50", Offset = "0x7C18650", VA = "0x187C19A50")]
		public PMSTCWOODUI Connect(IPEndPoint target, PZCLKDPONBJ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EB50", Offset = "0x7C1D750", VA = "0x187C1EB50")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EB60", Offset = "0x7C1D760", VA = "0x187C1EB60")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C19730", Offset = "0x7C18330", VA = "0x187C19730")]
		public void CVSQDUVCXCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C197E0", Offset = "0x7C183E0", VA = "0x187C197E0")]
		public void CVSQDUVCXCO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B9B0", Offset = "0x7C1A5B0", VA = "0x187C1B9B0")]
		public void JSAPXHUJDJN(PMSTCWOODUI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B970", Offset = "0x7C1A570", VA = "0x187C1B970")]
		public void JSAPXHUJDJN(PMSTCWOODUI a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7C19580", Offset = "0x7C18180", VA = "0x187C19580", Slot = "4")]
		private IEnumerator<PMSTCWOODUI> ASYNWEUVLPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FB40", Offset = "0x7C1E740", VA = "0x187C1FB40", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B860", Offset = "0x7C1A460", VA = "0x187C1B860")]
		private PMNHNWFJYVW HVVELLVNLPS(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B780", Offset = "0x7C1A380", VA = "0x187C1B780")]
		private PMNHNWFJYVW HVVELLVNLPS(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CD00", Offset = "0x7C1B900", VA = "0x187C1CD00")]
		internal PMNHNWFJYVW RNUINSQZFNL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CA90", Offset = "0x7C1B690", VA = "0x187C1CA90")]
		internal void QEQKTVBKQME(PMNHNWFJYVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C207F0", Offset = "0x7C1F3F0", VA = "0x187C207F0")]
		static EJWJHWSSZOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBD7AA0", Offset = "0xBD66A0", VA = "0x180BD7AA0")]
		private bool SGZBYYBIKJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B4C0", Offset = "0x7C1A0C0", VA = "0x187C1B4C0")]
		private void EJNLTHDZHAN(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F310", Offset = "0x7C1DF10", VA = "0x187C1F310")]
		private void WPEZXEBWAQW(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C198B0", Offset = "0x7C184B0", VA = "0x187C198B0")]
		private bool CZNGRJUIISY(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C170", Offset = "0x7C1AD70", VA = "0x187C1C170")]
		private void KUTHOMKWBUH(JFOGELVWMFO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FD80", Offset = "0x7C1E980", VA = "0x187C1FD80")]
		private void ZOIMYGCAPLG(OUXPLKHTPTT a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C1E0", Offset = "0x7C1ADE0", VA = "0x187C1C1E0")]
		private void OHHIVKGFHNK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E330", Offset = "0x7C1CF30", VA = "0x187C1E330")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C110", Offset = "0x7C1AD10", VA = "0x187C1C110")]
		internal int KQKBHVLWLGN(PMNHNWFJYVW a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A670", Offset = "0x7C19270", VA = "0x187C1A670")]
		internal int DUUOBZPSDTV(PMNHNWFJYVW a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A6B0", Offset = "0x7C192B0", VA = "0x187C1A6B0")]
		internal int DUUOBZPSDTV(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F0E0", Offset = "0x7C1DCE0", VA = "0x187C1F0E0")]
		internal void UXXQTBHMBWC(bool a)
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
	internal sealed class PMNHNWFJYVW
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int FDTLNPABDSL;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] QNTQFXMREUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] XOOYTKZJQPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int PPXFIKOTQOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object IXXYSRRZEBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public PMNHNWFJYVW ZFJJOLSAJOI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty NGRPTMWFSVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C25FD0", Offset = "0x7C24BD0", VA = "0x187C25FD0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7C26400", Offset = "0x7C25000", VA = "0x187C26400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte TDOCDYKHLYA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7C26240", Offset = "0x7C24E40", VA = "0x187C26240")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7C26270", Offset = "0x7C24E70", VA = "0x187C26270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort FVSDMKGLNQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C25FB0", Offset = "0x7C24BB0", VA = "0x187C25FB0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C26100", Offset = "0x7C24D00", VA = "0x187C26100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GBIEWLBHPNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7C263A0", Offset = "0x7C24FA0", VA = "0x187C263A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte IBYGJYWNYGV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7C262B0", Offset = "0x7C24EB0", VA = "0x187C262B0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7C263D0", Offset = "0x7C24FD0", VA = "0x187C263D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort ZBEHXOVAMEQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7C26480", Offset = "0x7C25080", VA = "0x187C26480")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7C26360", Offset = "0x7C24F60", VA = "0x187C26360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort IEJDZATOSZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7C26340", Offset = "0x7C24F40", VA = "0x187C26340")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7C26440", Offset = "0x7C25040", VA = "0x187C26440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort UFTZRMDVDRW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7C262E0", Offset = "0x7C24EE0", VA = "0x187C262E0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7C26300", Offset = "0x7C24F00", VA = "0x187C26300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C264D0", Offset = "0x7C250D0", VA = "0x187C264D0")]
		static PMNHNWFJYVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C264A0", Offset = "0x7C250A0", VA = "0x187C264A0")]
		public void ZTNYDVIWBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C267A0", Offset = "0x7C253A0", VA = "0x187C267A0")]
		public PMNHNWFJYVW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C26810", Offset = "0x7C25410", VA = "0x187C26810")]
		public PMNHNWFJYVW(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C26000", Offset = "0x7C24C00", VA = "0x187C26000")]
		public static int JBAZDWVKHUL(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C26070", Offset = "0x7C24C70", VA = "0x187C26070")]
		public int JBAZDWVKHUL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C26140", Offset = "0x7C24D40", VA = "0x187C26140")]
		public bool JUGFGBWMPDK()
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
	public class PMSTCWOODUI
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class WCQLZDLLSYW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public PMNHNWFJYVW[] SKWINHIIMWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int RNADFRWCLCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int LRRFOHCISTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte IBYGJYWNYGV;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WCQLZDLLSYW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int TMGSVKLQKVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int SGTSORGSXCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int SEKINLIALNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double TGEOOZOUMIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int CHGWPVYJETH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int FCBZGUJETRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int ZGENAPYZDFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch JLNNOMXNYWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int OVVZGNCUEHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long LMWVOWVKKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object LWZIWCRAMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal PMSTCWOODUI FPDPSUAHDKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal PMSTCWOODUI ZLVTJUXFOLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<PMNHNWFJYVW> IABIXEROCWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<FVIWRWOQLZN> BEFCJQPEIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly FVIWRWOQLZN[] BQRGVBKABAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int XULHHYHORRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int XCIMDCUIUIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool PGUTEPZROSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int EIQNHFEIFBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int WHXMGDFKNCI;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int LYGYYQMBZME = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int KNEOCPFHHWD = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object TOXXJSHTJRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int WGJVMZDOGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, WCQLZDLLSYW> QGOKCBTELBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> ESESWGTMSPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly PMNHNWFJYVW SCJOAMYPYVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int PWNXKLQZVKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int BCHONBCWJQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint JFMONTVIQSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int JXFMWEDRGIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int NMNWBNAQIRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long MEPVGEMYMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte HCEHUQIMVZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState BEZFGXAQQTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private PMNHNWFJYVW SBIVYUKKCGE;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int BAWGTKJOZOK = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int PHGQLYESDGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly PMNHNWFJYVW ZTWBUCHOFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly PMNHNWFJYVW MCRDPGDGJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly PMNHNWFJYVW TYDYFWFQAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly PMNHNWFJYVW RQTKRCUDLFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality KHPHBMJKZRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly EJWJHWSSZOX EJWJHWSSZOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int AXUVQJAOTPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object HIRAJOAJXXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly IJOBGFBPWGX HJTWIDHDPQW;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte GAARMGATDNR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB41AE0", Offset = "0xB406E0", VA = "0x180B41AE0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7C26B30", Offset = "0x7C25730", VA = "0x187C26B30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint ZTEDLTAUMEU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBD4160", Offset = "0xBD2D60", VA = "0x180BD4160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState OZSEJXQJTOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xBD41B0", Offset = "0xBD2DB0", VA = "0x180BD41B0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long SKBRRXCRMGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xB1B7A0", Offset = "0xB1A3A0", VA = "0x180B1B7A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int DUXKIPKWJDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xBA6130", Offset = "0xBA4D30", VA = "0x180BA6130")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xC03AB0", Offset = "0xC026B0", VA = "0x180C03AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int PECZXKUUJQV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7C27610", Offset = "0x7C26210", VA = "0x187C27610")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int FJZDJNYWHAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB31CA0", Offset = "0xB308A0", VA = "0x180B31CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double GVJPVSSVVFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x5310E80", Offset = "0x530FA80", VA = "0x185310E80")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate VFPZNJTQRLX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7C28250", Offset = "0x7C26E50", VA = "0x187C28250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7C291B0", Offset = "0x7C27DB0", VA = "0x187C291B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A470", Offset = "0x7C29070", VA = "0x187C2A470")]
		internal PMSTCWOODUI(EJWJHWSSZOX a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C27620", Offset = "0x7C26220", VA = "0x187C27620")]
		internal void KVHQUZELZRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C26E70", Offset = "0x7C25A70", VA = "0x187C26E70")]
		internal void EPMDODGDHDB(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C28A50", Offset = "0x7C27650", VA = "0x187C28A50")]
		internal void UIOIHMUWZRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C29BA0", Offset = "0x7C287A0", VA = "0x187C29BA0")]
		private void ZNEGDHLFOOR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C26DE0", Offset = "0x7C259E0", VA = "0x187C26DE0")]
		private void DUZZQXKWLXZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C28020", Offset = "0x7C26C20", VA = "0x187C28020")]
		public int ORKXWDABDZN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C28130", Offset = "0x7C26D30", VA = "0x187C28130")]
		public int ORKXWDABDZN(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C27E90", Offset = "0x7C26A90", VA = "0x187C27E90")]
		private FVIWRWOQLZN NAUGHYAASLW(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A2E0", Offset = "0x7C28EE0", VA = "0x187C2A2E0")]
		internal PMSTCWOODUI(EJWJHWSSZOX a, IPEndPoint b, int c, byte d, PZCLKDPONBJ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A870", Offset = "0x7C29470", VA = "0x187C2A870")]
		internal PMSTCWOODUI(EJWJHWSSZOX a, HAOCQBFITIC b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C28300", Offset = "0x7C26F00", VA = "0x187C28300")]
		internal void Reject(NKSSTQFNVDF requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A260", Offset = "0x7C28E60", VA = "0x187C2A260")]
		internal bool ZZXOJZILPLO(PWOPAVNCMYG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C27490", Offset = "0x7C26090", VA = "0x187C27490")]
		public void GTVILGOLMDJ(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C26EA0", Offset = "0x7C25AA0", VA = "0x187C26EA0")]
		private void FOAMQUVHUXI(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C26E20", Offset = "0x7C25A20", VA = "0x187C26E20")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B00", Offset = "0x7C28700", VA = "0x187C29B00")]
		internal DisconnectResult YGKKCUYPZJG(PMNHNWFJYVW a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C28350", Offset = "0x7C26F50", VA = "0x187C28350")]
		internal void TMKVTMGPXBB(FVIWRWOQLZN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C27B80", Offset = "0x7C26780", VA = "0x187C27B80")]
		internal ShutdownResult NAAZYCVMWID(byte[] a, int b, int c, bool d)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C26DA0", Offset = "0x7C259A0", VA = "0x187C26DA0")]
		private void BXOBMZYQQIG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C29260", Offset = "0x7C27E60", VA = "0x187C29260")]
		internal void WOKWTJXEQYS(DeliveryMethod a, PMNHNWFJYVW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C27640", Offset = "0x7C26240", VA = "0x187C27640")]
		private void LAEVYITGRNE(PMNHNWFJYVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C29ED0", Offset = "0x7C28AD0", VA = "0x187C29ED0")]
		private void ZPWAJLBVUOK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C26BE0", Offset = "0x7C257E0", VA = "0x187C26BE0")]
		internal ConnectRequestResult ASUDNEUSHQN(NKSSTQFNVDF a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C283B0", Offset = "0x7C26FB0", VA = "0x187C283B0")]
		internal void TOCIBIURMXE(PMNHNWFJYVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C274C0", Offset = "0x7C260C0", VA = "0x187C274C0")]
		private void HBNGRVNWLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C26920", Offset = "0x7C25520", VA = "0x187C26920")]
		internal void AFHGEIFYRHK(PMNHNWFJYVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C28AE0", Offset = "0x7C276E0", VA = "0x187C28AE0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C29C70", Offset = "0x7C28870", VA = "0x187C29C70")]
		internal void ZOALJCZVSUM(PMNHNWFJYVW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class IJOBGFBPWGX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long MMKMZHLSGMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long OHELDDGHMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long NTVZRACQVAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long QMMCGLYXRZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long UKLPWYTDIOV;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long SHUIYOXERXG;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long OABDVCFJHWJ;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long MXZQMZDMIMW;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long JMOVCKTWLDB;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long JTULVNQTWRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long EZXVRLRYEQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long JNABOABKQTJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long THSCGKAQZKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7C22590", Offset = "0x7C21190", VA = "0x187C22590")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long NYWZUQCOOXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7C22030", Offset = "0x7C20C30", VA = "0x187C22030")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long KPLUGETVJBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C22580", Offset = "0x7C21180", VA = "0x187C22580")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long MBAAVCXHFFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7C22490", Offset = "0x7C21090", VA = "0x187C22490")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long NOQAZELFPXM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7C21DD0", Offset = "0x7C209D0", VA = "0x187C21DD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long HNOPCHVONSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7C21F20", Offset = "0x7C20B20", VA = "0x187C21F20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long QHEFPFEYTFR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7C21EE0", Offset = "0x7C20AE0", VA = "0x187C21EE0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long XRFPZOAIBMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7C21F80", Offset = "0x7C20B80", VA = "0x187C21F80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality OHFFAGJPOCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x14CABB0", Offset = "0x14C97B0", VA = "0x1814CABB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double AYIQBWNYVZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7C21E80", Offset = "0x7C20A80", VA = "0x187C21E80")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C22040", Offset = "0x7C20C40", VA = "0x187C22040")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C22520", Offset = "0x7C21120", VA = "0x187C22520")]
		public void XASIWIZLREF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C21F30", Offset = "0x7C20B30", VA = "0x187C21F30")]
		public void GRFJIRKSLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C21FC0", Offset = "0x7C20BC0", VA = "0x187C21FC0")]
		public void NTHWSLWRVHP(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C220E0", Offset = "0x7C20CE0", VA = "0x187C220E0")]
		public void SZBLTJTRVOQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C22080", Offset = "0x7C20C80", VA = "0x187C22080")]
		public void SVQMSLOKKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C224A0", Offset = "0x7C210A0", VA = "0x187C224A0")]
		public void UNAMDIHXWQL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C22150", Offset = "0x7C20D50", VA = "0x187C22150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C21DE0", Offset = "0x7C209E0", VA = "0x187C21DE0")]
		public void CIAUZCRRLAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public IJOBGFBPWGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class XSPJBCNIOMV
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> WJNSPKVQZRG;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D040", Offset = "0x7C2BC40", VA = "0x187C2D040")]
		public static IPEndPoint MFXMFOKQJUW(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D310", Offset = "0x7C2BF10", VA = "0x187C2D310")]
		public static IPAddress SMXSPTVPGNP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D280", Offset = "0x7C2BE80", VA = "0x187C2D280")]
		public static IPAddress SMXSPTVPGNP(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D4E0", Offset = "0x7C2C0E0", VA = "0x187C2D4E0")]
		internal static int YDUKCUOMQFP(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x41E1F70", Offset = "0x41E0B70", VA = "0x1841E1F70")]
		internal static T[] SVYMMYWYVJK<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class YGAVVHWUJDI : FVIWRWOQLZN
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private PMNHNWFJYVW _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7C2BD10", Offset = "0x7C2A910", VA = "0x187C2BD10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7C2BC80", Offset = "0x7C2A880", VA = "0x187C2BC80")]
			public void HRTIXRMSTIX(PMNHNWFJYVW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7C2BCA0", Offset = "0x7C2A8A0", VA = "0x187C2BCA0")]
			public bool KRDRBUPTHYQ(long a, PMSTCWOODUI b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7C2BC30", Offset = "0x7C2A830", VA = "0x187C2BC30")]
			public bool Clear(PMSTCWOODUI peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly PMNHNWFJYVW EHQASPFDZRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] JVCBLGUZHXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly PMNHNWFJYVW[] SCPOAZEWEYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] OKRBMQPIDHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int OCKFRMUCGZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int LMLFIIRYBXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int TKPOWYHLEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int MMQIQWPRRBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool VDCSQOHDNZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod DFWDKZGZHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool OHANOFUXWNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int ZGZQRKXBXXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte RCREIWQDNHB;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int SDLWHGTZYCA
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D5A0", Offset = "0x7C2C1A0", VA = "0x187C2D5A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E400", Offset = "0x7C2D000", VA = "0x187C2E400")]
		public YGAVVHWUJDI(PMSTCWOODUI a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E080", Offset = "0x7C2CC80", VA = "0x187C2E080")]
		private void ZCNXGURTSFV(PMNHNWFJYVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DBB0", Offset = "0x7C2C7B0", VA = "0x187C2DBB0", Slot = "4")]
		protected override bool VYCKNEKHKHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D5B0", Offset = "0x7C2C1B0", VA = "0x187C2D5B0", Slot = "5")]
		public override bool TOCIBIURMXE(PMNHNWFJYVW a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class FQBUMNVGNID : FVIWRWOQLZN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int SVJWGHKNZKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort LMLFIIRYBXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool HQEADVJFVFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private PMNHNWFJYVW ISOVAPONSUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly PMNHNWFJYVW KYBUEDCFJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool QGLQRJCFTIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte RCREIWQDNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long PUTIDNGJDEF;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7C215B0", Offset = "0x7C201B0", VA = "0x187C215B0")]
		public FQBUMNVGNID(PMSTCWOODUI a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7C210F0", Offset = "0x7C1FCF0", VA = "0x187C210F0", Slot = "4")]
		protected override bool VYCKNEKHKHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7C20E70", Offset = "0x7C1FA70", VA = "0x187C20E70", Slot = "5")]
		public override bool TOCIBIURMXE(PMNHNWFJYVW a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class NBTUUXYPEHU
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
		[Cpp2IlInjected.Address(RVA = "0x7C17FE0", Offset = "0x7C16BE0", VA = "0x187C17FE0")]
		private static void VDTZHRQUHOL(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C25530", Offset = "0x7C24130", VA = "0x187C25530")]
		private static void VDTZHRQUHOL(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C254E0", Offset = "0x7C240E0", VA = "0x187C254E0")]
		public static void VDTZHRQUHOL(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C255A0", Offset = "0x7C241A0", VA = "0x187C255A0")]
		public static void LXVIJLEMLMO(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7C255C0", Offset = "0x7C241C0", VA = "0x187C255C0")]
		public static void LXVIJLEMLMO(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7C254E0", Offset = "0x7C240E0", VA = "0x187C254E0")]
		public static void LXVIJLEMLMO(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7C254E0", Offset = "0x7C240E0", VA = "0x187C254E0")]
		public static void LXVIJLEMLMO(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7C25530", Offset = "0x7C24130", VA = "0x187C25530")]
		public static void LXVIJLEMLMO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7C25530", Offset = "0x7C24130", VA = "0x187C25530")]
		public static void LXVIJLEMLMO(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7C25520", Offset = "0x7C24120", VA = "0x187C25520")]
		public static void LXVIJLEMLMO(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7C25520", Offset = "0x7C24120", VA = "0x187C25520")]
		public static void LXVIJLEMLMO(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ZRQXHSKTRTJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] JMISDHBXAZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int YCTDRJPKPTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int ESRYVFUJKRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int UGPPRUVATMV;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] XOOYTKZJQPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int VMTHPLGRKYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int HIPVDBNNZRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F620", Offset = "0x7C2E220", VA = "0x187C2F620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool LSJQSRLHTAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2C6C720", Offset = "0x2C6B320", VA = "0x182C6C720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int BHLFEHHJWSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F7F0", Offset = "0x7C2E3F0", VA = "0x187C2F7F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F5A0", Offset = "0x7C2E1A0", VA = "0x187C2F5A0")]
		public void PGCHBNWMHJA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ZRQXHSKTRTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F8D0", Offset = "0x7C2E4D0", VA = "0x187C2F8D0")]
		public ZRQXHSKTRTJ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F760", Offset = "0x7C2E360", VA = "0x187C2F760")]
		public IPEndPoint VNVFZXINRNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F040", Offset = "0x7C2DC40", VA = "0x187C2F040")]
		public byte AJAISZQOHPD()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F040", Offset = "0x7C2DC40", VA = "0x187C2F040")]
		public sbyte RHGYINHWLJA()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x41F3ED0", Offset = "0x41F2AD0", VA = "0x1841F3ED0")]
		public a[] YWXUVKVCGMU<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F630", Offset = "0x7C2E230", VA = "0x187C2F630")]
		public bool[] RCGJAVYPRMU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F670", Offset = "0x7C2E270", VA = "0x187C2F670")]
		public ushort[] SEOVMFGOASZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F6E0", Offset = "0x7C2E2E0", VA = "0x187C2F6E0")]
		public short[] TYLWLFYEQKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F530", Offset = "0x7C2E130", VA = "0x187C2F530")]
		public int[] ORLADADMVNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F100", Offset = "0x7C2DD00", VA = "0x187C2F100")]
		public uint[] BWTIALSOXCU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F0C0", Offset = "0x7C2DCC0", VA = "0x187C2F0C0")]
		public float[] AZSFDVWFQKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F720", Offset = "0x7C2E320", VA = "0x187C2F720")]
		public double[] UYQYHRVPTFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F4F0", Offset = "0x7C2E0F0", VA = "0x187C2F4F0")]
		public long[] KWYFNLJBBTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F080", Offset = "0x7C2DC80", VA = "0x187C2F080")]
		public ulong[] AKHXUPMOKTX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F800", Offset = "0x7C2E400", VA = "0x187C2F800")]
		public string[] ZFEWGMHKCED(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F5E0", Offset = "0x7C2E1E0", VA = "0x187C2F5E0")]
		public bool PVEARDDDPZF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F4C0", Offset = "0x7C2E0C0", VA = "0x187C2F4C0")]
		public char LBMDZZUAMDB()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F4C0", Offset = "0x7C2E0C0", VA = "0x187C2F4C0")]
		public ushort KLDFWJOMEFO()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F4C0", Offset = "0x7C2E0C0", VA = "0x187C2F4C0")]
		public short WJKVIYDXVPN()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F1B0", Offset = "0x7C2DDB0", VA = "0x187C2F1B0")]
		public long CQBXYCGYEOF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F1B0", Offset = "0x7C2DDB0", VA = "0x187C2F1B0")]
		public ulong SZGYDVENLQM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F180", Offset = "0x7C2DD80", VA = "0x187C2F180")]
		public int GSCAFFHZXSA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F180", Offset = "0x7C2DD80", VA = "0x187C2F180")]
		public uint CCQCGAAGHPF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F570", Offset = "0x7C2E170", VA = "0x187C2F570")]
		public float OUHRUHMBODV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F6B0", Offset = "0x7C2E2B0", VA = "0x187C2F6B0")]
		public double TSMZPAEQMSW()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F1E0", Offset = "0x7C2DDE0", VA = "0x187C2F1E0")]
		public string CYNWVUHUSXE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F450", Offset = "0x7C2E050", VA = "0x187C2F450")]
		public ArraySegment<byte> KAKNDUXOHPB(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F140", Offset = "0x7C2DD40", VA = "0x187C2F140")]
		public sbyte[] CCAYYFOLTML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F410", Offset = "0x7C2E010", VA = "0x187C2F410")]
		public byte[] HSWEBGTBWCW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F3F0", Offset = "0x7C2DFF0", VA = "0x187C2F3F0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class PZCLKDPONBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] JMISDHBXAZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int YCTDRJPKPTP;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int HRAHSJQKHCS = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool DUVLKJZLBMZ;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding KABOIJEYTYX;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int AYIALAEEVLW = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] XWQTKCJTDAR;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] RXLJWTQVVNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int TXICYPISMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BB50", Offset = "0x7C2A750", VA = "0x187C2BB50")]
		public PZCLKDPONBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BAB0", Offset = "0x7C2A6B0", VA = "0x187C2BAB0")]
		public PZCLKDPONBJ(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B9C0", Offset = "0x7C2A5C0", VA = "0x187C2B9C0")]
		public static PZCLKDPONBJ VICVMZXHTQE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AE70", Offset = "0x7C29A70", VA = "0x187C2AE70")]
		public void JKYCMCTJAQS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE4C90", Offset = "0x2CE3890", VA = "0x182CE4C90")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B3C0", Offset = "0x7C29FC0", VA = "0x187C2B3C0")]
		public void QKMLMDDYRPE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B910", Offset = "0x7C2A510", VA = "0x187C2B910")]
		public void QKMLMDDYRPE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B670", Offset = "0x7C2A270", VA = "0x187C2B670")]
		public void QKMLMDDYRPE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B670", Offset = "0x7C2A270", VA = "0x187C2B670")]
		public void QKMLMDDYRPE(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B800", Offset = "0x7C2A400", VA = "0x187C2B800")]
		public void QKMLMDDYRPE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B800", Offset = "0x7C2A400", VA = "0x187C2B800")]
		public void QKMLMDDYRPE(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B6C0", Offset = "0x7C2A2C0", VA = "0x187C2B6C0")]
		public void QKMLMDDYRPE(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B6C0", Offset = "0x7C2A2C0", VA = "0x187C2B6C0")]
		public void QKMLMDDYRPE(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B6C0", Offset = "0x7C2A2C0", VA = "0x187C2B6C0")]
		public void QKMLMDDYRPE(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B360", Offset = "0x7C29F60", VA = "0x187C2B360")]
		public void QKMLMDDYRPE(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B360", Offset = "0x7C29F60", VA = "0x187C2B360")]
		public void QKMLMDDYRPE(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B890", Offset = "0x7C2A490", VA = "0x187C2B890")]
		public void QKMLMDDYRPE(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AD90", Offset = "0x7C29990", VA = "0x187C2AD90")]
		public void HNIAMVAJLOK(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AD90", Offset = "0x7C29990", VA = "0x187C2AD90")]
		public void FMWXTYFVJIF(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B960", Offset = "0x7C2A560", VA = "0x187C2B960")]
		public void QKMLMDDYRPE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B1B0", Offset = "0x7C29DB0", VA = "0x187C2B1B0")]
		public void NVILSYUZGBN(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B0D0", Offset = "0x7C29CD0", VA = "0x187C2B0D0")]
		public void NVILSYUZGBN(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AF10", Offset = "0x7C29B10", VA = "0x187C2AF10")]
		public void NVILSYUZGBN(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AF10", Offset = "0x7C29B10", VA = "0x187C2AF10")]
		public void NVILSYUZGBN(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AF10", Offset = "0x7C29B10", VA = "0x187C2AF10")]
		public void NVILSYUZGBN(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B0D0", Offset = "0x7C29CD0", VA = "0x187C2B0D0")]
		public void NVILSYUZGBN(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B0D0", Offset = "0x7C29CD0", VA = "0x187C2B0D0")]
		public void NVILSYUZGBN(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AFF0", Offset = "0x7C29BF0", VA = "0x187C2AFF0")]
		public void NVILSYUZGBN(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AFF0", Offset = "0x7C29BF0", VA = "0x187C2AFF0")]
		public void NVILSYUZGBN(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AD90", Offset = "0x7C29990", VA = "0x187C2AD90")]
		public void NVILSYUZGBN(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B290", Offset = "0x7C29E90", VA = "0x187C2B290")]
		public void NVILSYUZGBN(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B730", Offset = "0x7C2A330", VA = "0x187C2B730")]
		public void QKMLMDDYRPE(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B900", Offset = "0x7C2A500", VA = "0x187C2B900")]
		public void QKMLMDDYRPE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B460", Offset = "0x7C2A060", VA = "0x187C2B460")]
		public void QKMLMDDYRPE(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class JHKQWAOOONC
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class LDIQANBDBFI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong AXUVQJAOTPO;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x597C7F0", Offset = "0x597B3F0", VA = "0x18597C7F0")]
			static LDIQANBDBFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(ZRQXHSKTRTJ reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class JALIWHYGVOR<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public JHKQWAOOONC VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a YLVLHLCXVYO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> EKJNFTMCRMR;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public JALIWHYGVOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5635020", Offset = "0x5633C20", VA = "0x185635020")]
			internal void SRBTLZAVUNM(ZRQXHSKTRTJ a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class DXHJABJJYMN<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public JHKQWAOOONC VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a YLVLHLCXVYO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> EKJNFTMCRMR;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public DXHJABJJYMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x468A6A0", Offset = "0x46892A0", VA = "0x18468A6A0")]
			internal void SRBTLZAVUNM(ZRQXHSKTRTJ a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly YTRXRXEZRTK XWYRVATBYNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> UDMJWGBNLVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly PZCLKDPONBJ SWOJXPVWBCG;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7C22750", Offset = "0x7C21350", VA = "0x187C22750")]
		public JHKQWAOOONC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3C43900", Offset = "0x3C42500", VA = "0x183C43900", Slot = "4")]
		protected virtual ulong GVWTBCHBWMP<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7C22630", Offset = "0x7C21230", VA = "0x187C22630", Slot = "5")]
		protected virtual SubscribeDelegate HNMMHJKXMEI(ZRQXHSKTRTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C43980", Offset = "0x3C42580", VA = "0x183C43980", Slot = "6")]
		protected virtual void LRRIUEIVFBW<b>(PZCLKDPONBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7C225B0", Offset = "0x7C211B0", VA = "0x187C225B0")]
		public void HABMXABFSVL(ZRQXHSKTRTJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C43D00", Offset = "0x3C42900", VA = "0x183C43D00")]
		public void XEFYRRLNBZG<j>(PZCLKDPONBJ a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7C22700", Offset = "0x7C21300", VA = "0x187C22700")]
		public void ITRSGAMMCKV(ZRQXHSKTRTJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C43B80", Offset = "0x3C42780", VA = "0x183C43B80")]
		public void UQVXMQCYBIS<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C43B80", Offset = "0x3C42780", VA = "0x183C43B80")]
		public void UQVXMQCYBIS<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7C225A0", Offset = "0x7C211A0", VA = "0x187C225A0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BBD0", Offset = "0x7C2A7D0", VA = "0x187C2BBD0")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class YTRXRXEZRTK
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
		private abstract class PCIGEOBAYZK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType JGVJNZJVVLT;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6176DD0", Offset = "0x61759D0", VA = "0x186176DD0", Slot = "4")]
			public virtual void HRTIXRMSTIX(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void OUZYHILIVFP(a a, ZRQXHSKTRTJ b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void XEFYRRLNBZG(a a, PZCLKDPONBJ b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void OXERJRNRXCO(a a, ZRQXHSKTRTJ b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void VFWFLRDSDWZ(a a, PZCLKDPONBJ b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void MMTJRICHTMV(a a, ZRQXHSKTRTJ b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void PJBVKMIIYIE(a a, PZCLKDPONBJ b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			protected PCIGEOBAYZK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class DDWHSCXRTYN<a, b> : PCIGEOBAYZK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> TTUJSIVHIXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> CECJIZCGLIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> HSBCUAXGBWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> DBIRKARNDEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> VGXKHXDQRVI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> KYPHOJDCIBI;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4653B40", Offset = "0x4652740", VA = "0x184653B40", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4653B40", Offset = "0x4652740", VA = "0x184653B40", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4653A70", Offset = "0x4652670", VA = "0x184653A70", Slot = "9")]
			public override void MMTJRICHTMV(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4653A70", Offset = "0x4652670", VA = "0x184653A70", Slot = "10")]
			public override void PJBVKMIIYIE(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4653C10", Offset = "0x4652810", VA = "0x184653C10")]
			protected b[] ZBEEBOFUULU(a a, ZRQXHSKTRTJ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4653900", Offset = "0x4652500", VA = "0x184653900")]
			protected b[] KGGQRMQGQTT(a a, PZCLKDPONBJ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4652E20", Offset = "0x4651A20", VA = "0x184652E20", Slot = "4")]
			public override void HRTIXRMSTIX(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4653EB0", Offset = "0x4652AB0", VA = "0x184653EB0")]
			protected DDWHSCXRTYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class PAMFRASXMNE<a, b> : DDWHSCXRTYN<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void TZFRQXUXDWL(ZRQXHSKTRTJ a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void WTCPBPPBSMS(PZCLKDPONBJ a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x61763C0", Offset = "0x6174FC0", VA = "0x1861763C0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6176D30", Offset = "0x6175930", VA = "0x186176D30", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6176820", Offset = "0x6175420", VA = "0x186176820", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6176960", Offset = "0x6175560", VA = "0x186176960", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6176D90", Offset = "0x6175990", VA = "0x186176D90")]
			protected PAMFRASXMNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class BSTAJIJMWOZ<a> : DDWHSCXRTYN<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x4663C50", Offset = "0x4662850", VA = "0x184663C50", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4663EF0", Offset = "0x4662AF0", VA = "0x184663EF0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x77C4C70", Offset = "0x77C3870", VA = "0x1877C4C70", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x44B2980", Offset = "0x44B1580", VA = "0x1844B2980", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public BSTAJIJMWOZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class DKBUHEQAPFU<a> : DDWHSCXRTYN<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x4663C50", Offset = "0x4662850", VA = "0x184663C50", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x4663EF0", Offset = "0x4662AF0", VA = "0x184663EF0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4663DA0", Offset = "0x46629A0", VA = "0x184663DA0", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x44B2980", Offset = "0x44B1580", VA = "0x1844B2980", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public DKBUHEQAPFU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class ZGKDMFBROSK<a> : DDWHSCXRTYN<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x44895B0", Offset = "0x44881B0", VA = "0x1844895B0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4489AB0", Offset = "0x44886B0", VA = "0x184489AB0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x44906D0", Offset = "0x448F2D0", VA = "0x1844906D0", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4489970", Offset = "0x4488570", VA = "0x184489970", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public ZGKDMFBROSK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class YOSJNJDVNJT<a> : DDWHSCXRTYN<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x44895B0", Offset = "0x44881B0", VA = "0x1844895B0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x4489AB0", Offset = "0x44886B0", VA = "0x184489AB0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4489720", Offset = "0x4488320", VA = "0x184489720", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4489970", Offset = "0x4488570", VA = "0x184489970", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public YOSJNJDVNJT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class BXRHHANFGBS<a> : DDWHSCXRTYN<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5C9E240", Offset = "0x5C9CE40", VA = "0x185C9E240", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5C9E5F0", Offset = "0x5C9D1F0", VA = "0x185C9E5F0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x77C4EC0", Offset = "0x77C3AC0", VA = "0x1877C4EC0", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x438B7B0", Offset = "0x438A3B0", VA = "0x18438B7B0", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public BXRHHANFGBS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class AZRRHPQVTKF<a> : DDWHSCXRTYN<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5C9E240", Offset = "0x5C9CE40", VA = "0x185C9E240", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C9E5F0", Offset = "0x5C9D1F0", VA = "0x185C9E5F0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C9E4A0", Offset = "0x5C9D0A0", VA = "0x185C9E4A0", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x438B7B0", Offset = "0x438A3B0", VA = "0x18438B7B0", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public AZRRHPQVTKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class JBBXZUBTUQI<a> : DDWHSCXRTYN<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x56352A0", Offset = "0x5633EA0", VA = "0x1856352A0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x56356A0", Offset = "0x56342A0", VA = "0x1856356A0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5635410", Offset = "0x5634010", VA = "0x185635410", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5635560", Offset = "0x5634160", VA = "0x185635560", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public JBBXZUBTUQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class TDKCFUMZPLV<a> : DDWHSCXRTYN<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x56352A0", Offset = "0x5633EA0", VA = "0x1856352A0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x56356A0", Offset = "0x56342A0", VA = "0x1856356A0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x65E7670", Offset = "0x65E6270", VA = "0x1865E7670", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5635560", Offset = "0x5634160", VA = "0x185635560", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public TDKCFUMZPLV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class ZSEFIXGFLFI<a> : DDWHSCXRTYN<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x44B25D0", Offset = "0x44B11D0", VA = "0x1844B25D0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x44B29C0", Offset = "0x44B15C0", VA = "0x1844B29C0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x44B2830", Offset = "0x44B1430", VA = "0x1844B2830", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x44B2980", Offset = "0x44B1580", VA = "0x1844B2980", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public ZSEFIXGFLFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class CEYAQNDBSVV<a> : DDWHSCXRTYN<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x438B400", Offset = "0x438A000", VA = "0x18438B400", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x438B7F0", Offset = "0x438A3F0", VA = "0x18438B7F0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x438B560", Offset = "0x438A160", VA = "0x18438B560", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x438B7B0", Offset = "0x438A3B0", VA = "0x18438B7B0", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public CEYAQNDBSVV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class TSHQFRYXNMS<a> : DDWHSCXRTYN<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6604C10", Offset = "0x6603810", VA = "0x186604C10", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6604ED0", Offset = "0x6603AD0", VA = "0x186604ED0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6604E80", Offset = "0x6603A80", VA = "0x186604E80", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x5635560", Offset = "0x5634160", VA = "0x185635560", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x438B950", Offset = "0x438A550", VA = "0x18438B950")]
			public TSHQFRYXNMS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class LKPSHLHMAPA<a> : PAMFRASXMNE<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5988340", Offset = "0x5986F40", VA = "0x185988340", Slot = "12")]
			protected override void WTCPBPPBSMS(PZCLKDPONBJ a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5988310", Offset = "0x5986F10", VA = "0x185988310", Slot = "11")]
			protected override void TZFRQXUXDWL(ZRQXHSKTRTJ a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5988370", Offset = "0x5986F70", VA = "0x185988370")]
			public LKPSHLHMAPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class WQJQLFIBZTM<a> : PAMFRASXMNE<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6D749A0", Offset = "0x6D735A0", VA = "0x186D749A0", Slot = "12")]
			protected override void WTCPBPPBSMS(PZCLKDPONBJ a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6D74960", Offset = "0x6D73560", VA = "0x186D74960", Slot = "11")]
			protected override void TZFRQXUXDWL(ZRQXHSKTRTJ a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5988370", Offset = "0x5986F70", VA = "0x185988370")]
			public WQJQLFIBZTM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class QCJOXGSKPRB<a> : DDWHSCXRTYN<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int VUCPAZWNJJG;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x620A3A0", Offset = "0x6208FA0", VA = "0x18620A3A0")]
			public QCJOXGSKPRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x6209DD0", Offset = "0x62089D0", VA = "0x186209DD0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x620A300", Offset = "0x6208F00", VA = "0x18620A300", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x620A050", Offset = "0x6208C50", VA = "0x18620A050", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x620A1B0", Offset = "0x6208DB0", VA = "0x18620A1B0", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class AWYICTHCMOF<a> : PCIGEOBAYZK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo NGRPTMWFSVG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type VKVIOUJPFWY;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C9DA10", Offset = "0x5C9C610", VA = "0x185C9DA10")]
			public AWYICTHCMOF(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C9D780", Offset = "0x5C9C380", VA = "0x185C9D780", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5C9D870", Offset = "0x5C9C470", VA = "0x185C9D870", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x5C9D820", Offset = "0x5C9C420", VA = "0x185C9D820", Slot = "7")]
			public override void OXERJRNRXCO(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x5C9D820", Offset = "0x5C9C420", VA = "0x185C9D820", Slot = "8")]
			public override void VFWFLRDSDWZ(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x5C9D610", Offset = "0x5C9C210", VA = "0x185C9D610", Slot = "9")]
			public override void MMTJRICHTMV(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x5C9D610", Offset = "0x5C9C210", VA = "0x185C9D610", Slot = "10")]
			public override void PJBVKMIIYIE(a a, PZCLKDPONBJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class YRRWRHSWOBA<a> : AWYICTHCMOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x448C220", Offset = "0x448AE20", VA = "0x18448C220")]
			public YRRWRHSWOBA(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x448BED0", Offset = "0x448AAD0", VA = "0x18448BED0", Slot = "5")]
			public override void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x448C1A0", Offset = "0x448ADA0", VA = "0x18448C1A0", Slot = "6")]
			public override void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class UFQDKHULNAE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static UFQDKHULNAE<a> CFGULCWBBYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly PCIGEOBAYZK<a>[] TERGXUNLATF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int PRVEVIHIRSQ;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x680AD20", Offset = "0x6809920", VA = "0x18680AD20")]
			public UFQDKHULNAE(List<PCIGEOBAYZK<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x680AC70", Offset = "0x6809870", VA = "0x18680AC70")]
			public void XEFYRRLNBZG(a a, PZCLKDPONBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x680A880", Offset = "0x6809480", VA = "0x18680A880")]
			public void OUZYHILIVFP(a a, ZRQXHSKTRTJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class RKCZMGFQIVM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract PCIGEOBAYZK<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PZCLKDPONBJ BJCYSYZKQQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int TKABGHTDDRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, RKCZMGFQIVM> YOWAYXJVQDJ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E5C0", Offset = "0x7C2D1C0", VA = "0x187C2E5C0")]
		public YTRXRXEZRTK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x41EB380", Offset = "0x41E9F80", VA = "0x1841EB380")]
		private UFQDKHULNAE<d> ZBIUOLLXJVD<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x41EA490", Offset = "0x41E9090", VA = "0x1841EA490")]
		public void ERBMWTZFFKA<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x41EA3D0", Offset = "0x41E8FD0", VA = "0x1841EA3D0")]
		public bool Deserialize<T>(ZRQXHSKTRTJ reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x41EA4D0", Offset = "0x41E90D0", VA = "0x1841EA4D0")]
		public void Serialize<T>(PZCLKDPONBJ writer, T obj) where T : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class JKFIFABLLJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime LNDQSWOHUQO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] LOARWSVIPKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator BXSMFQCSGOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7C22AF0", Offset = "0x7C216F0", VA = "0x187C22AF0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int JTTBFFMRCVU
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C22AC0", Offset = "0x7C216C0", VA = "0x187C22AC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x7C23060", Offset = "0x7C21C60", VA = "0x187C23060")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode ZPLJYBKEGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x7C228D0", Offset = "0x7C214D0", VA = "0x187C228D0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x7C23130", Offset = "0x7C21D30", VA = "0x187C23130")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int IOTEXQFDITR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7C231D0", Offset = "0x7C21DD0", VA = "0x187C231D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint LTGLTFDQTFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7C23230", Offset = "0x7C21E30", VA = "0x187C23230")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? XYPKSQEWGTX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7C23100", Offset = "0x7C21D00", VA = "0x187C23100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? BDOKKHJEJPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C23200", Offset = "0x7C21E00", VA = "0x187C23200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? JVKOJVWJLTV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x7C228A0", Offset = "0x7C214A0", VA = "0x187C228A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x7C22EA0", Offset = "0x7C21AA0", VA = "0x187C22EA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? LNZYNROUNRP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xDF45B0", Offset = "0xDF31B0", VA = "0x180DF45B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xFCD260", Offset = "0xFCBE60", VA = "0x180FCD260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C239A0", Offset = "0x7C225A0", VA = "0x187C239A0")]
		public JKFIFABLLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C23900", Offset = "0x7C22500", VA = "0x187C23900")]
		internal JKFIFABLLJL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C236D0", Offset = "0x7C222D0", VA = "0x187C236D0")]
		public static JKFIFABLLJL ZAXNTXCGIOJ(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C22B20", Offset = "0x7C21720", VA = "0x187C22B20")]
		internal void LPLQTMXMZVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C23510", Offset = "0x7C22110", VA = "0x187C23510")]
		private void XVYYMQTMAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C23290", Offset = "0x7C21E90", VA = "0x187C23290")]
		private DateTime? UZXBKCHCJGQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C22900", Offset = "0x7C21500", VA = "0x187C22900")]
		private void KJYEACKNEGI(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C23460", Offset = "0x7C22060", VA = "0x187C23460")]
		private ulong XVWXXNNREXC(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C237E0", Offset = "0x7C223E0", VA = "0x187C237E0")]
		private void ZKAXSHEDWMU(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7C23170", Offset = "0x7C21D70", VA = "0x187C23170")]
		private uint QTMDRWBTVFZ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5790", Offset = "0x7AE4390", VA = "0x187AE5790")]
		private static uint OTVXHMIYYVU(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7C230A0", Offset = "0x7C21CA0", VA = "0x187C230A0")]
		private static ulong OTVXHMIYYVU(ulong a)
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
	internal sealed class ZZFBVKRFOBA
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int UJAFEMJYXRJ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int LTOJNXZJIUW = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int IVUUGBMTBWR = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint TZDTSHWKTSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int RKIWGTBNSYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int EHBZOYJNRIX;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool FAIITVBXROE
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7C2FA20", Offset = "0x7C2E620", VA = "0x187C2FA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F930", Offset = "0x7C2E530", VA = "0x187C2F930")]
		public bool GTVILGOLMDJ(OUXPLKHTPTT a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class VICOSGGCXHS : OUXPLKHTPTT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket NJIACMNOSQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly EJWJHWSSZOX GXSMAVMNSQH;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short JJPTCTYDPXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x7C2CED0", Offset = "0x7C2BAD0", VA = "0x187C2CED0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int VPJPWYWBMRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7C2CD60", Offset = "0x7C2B960", VA = "0x187C2CD60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint TLPETUIOREN
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x7C2CE70", Offset = "0x7C2BA70", VA = "0x187C2CE70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily LUUZOHGQQHN
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x4413CE0", Offset = "0x44128E0", VA = "0x184413CE0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CEF0", Offset = "0x7C2BAF0", VA = "0x187C2CEF0")]
		public VICOSGGCXHS(AddressFamily a, EJWJHWSSZOX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C780", Offset = "0x7C2B380", VA = "0x187C2C780", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CE90", Offset = "0x7C2BA90", VA = "0x187C2CE90", Slot = "9")]
		public int SIPWFRVXQJI(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CD80", Offset = "0x7C2B980", VA = "0x187C2CD80", Slot = "10")]
		public int KSQJCSMPPCK(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CD40", Offset = "0x7C2B940", VA = "0x187C2CD40", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface OUXPLKHTPTT
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short JJPTCTYDPXB
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int VPJPWYWBMRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint TLPETUIOREN
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily LUUZOHGQQHN
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
		int SIPWFRVXQJI(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int KSQJCSMPPCK(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x7C25C40", Offset = "0x7C24840", VA = "0x187C25C40")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7C25CE0", Offset = "0x7C248E0", VA = "0x187C25CE0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x16E6ED0", Offset = "0x16E5AD0", VA = "0x1816E6ED0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7C25B50", Offset = "0x7C24750", VA = "0x187C25B50", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7C25B90", Offset = "0x7C24790", VA = "0x187C25B90", Slot = "0")]
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
	public class JFOGELVWMFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string YCJINYTTKCE = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int NFZOJAWZGNS = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int VXTIZJSMYZA = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int WYMHRTBUWAU = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> QOOCCSCDTAB;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback PZQWZKINHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int JHTIMRAHQNO;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		internal void OSVDSEKJUHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		internal void LUMPFUYHZWO(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class JGDJVWFLAJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int ZLREEVQAPDS;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
		protected JGDJVWFLAJF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void IJQUPVENZQL(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PRTIDUNOKNE(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ECOEUWCNEXR : JGDJVWFLAJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] NFHQLEPGVHS;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator MHMAJIAPLGC;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF1E0", Offset = "0x2DFDDE0", VA = "0x182DFF1E0")]
		public ECOEUWCNEXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7C18ED0", Offset = "0x7C17AD0", VA = "0x187C18ED0")]
		public void VAUBQMLTCZZ(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7C186A0", Offset = "0x7C172A0", VA = "0x187C186A0")]
		public void GWTUXNXMFES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7C18780", Offset = "0x7C17380", VA = "0x187C18780", Slot = "4")]
		public override void IJQUPVENZQL(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7C18BD0", Offset = "0x7C177D0", VA = "0x187C18BD0", Slot = "5")]
		public override void PRTIDUNOKNE(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class XKIXOLMZICW
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7C2FD80", Offset = "0x7C2E980", VA = "0x187C2FD80")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7C2FF10", Offset = "0x7C2EB10", VA = "0x187C2FF10")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2FB30", Offset = "0x7C2E730", VA = "0x187C2FB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2C550", Offset = "0x7C2B150", VA = "0x187C2C550")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C5D0", Offset = "0x7C2B1D0", VA = "0x187C2C5D0")]
		private uint WHBBDLMWMAX(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7C18270", Offset = "0x7C16E70", VA = "0x187C18270")]
		private void FWWLKKPUBXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7C183B0", Offset = "0x7C16FB0", VA = "0x187C183B0")]
		private void WQYXMGCJHER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7C18320", Offset = "0x7C16F20", VA = "0x187C18320")]
		private void JFWDPRUIRTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7C18170", Offset = "0x7C16D70", VA = "0x187C18170")]
		private void BCGQKXFGOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C430", Offset = "0x7C2B030", VA = "0x187C2C430")]
		private void LZTCNBBHOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BF60", Offset = "0x7C2AB60", VA = "0x187C2BF60")]
		private unsafe void JKLVXIZHXTN(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C540", Offset = "0x7C2B140", VA = "0x187C2C540")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void RLAPVPOBAWO([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C490", Offset = "0x7C2B090", VA = "0x187C2C490")]
		public static void RLAPVPOBAWO(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7C2C380", Offset = "0x7C2AF80", VA = "0x187C2C380")]
		public static void LGDXOFEHAZI(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BEF0", Offset = "0x7C2AAF0", VA = "0x187C2BEF0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void CSJVLLKZHUF([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FAF0", Offset = "0x7C2E6F0", VA = "0x187C2FAF0")]
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
