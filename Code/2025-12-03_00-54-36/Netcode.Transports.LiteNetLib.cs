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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, QCKNMSDMAEP
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
		private NetworkManager AYYMMVEDYTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool IKQRTJGWWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, EHQIAMPESRI> XJMMOEYAXLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IQJPIATCGNX QLLEVNNCORD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch FCBLDGMPSIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] WJYLQLFQLQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType FEQZPKSEOUV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int YYFAJWHJART
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7468EB0", Offset = "0x7467AB0", VA = "0x187468EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7468E60", Offset = "0x7467A60", VA = "0x187468E60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7468170", Offset = "0x7466D70", VA = "0x187468170")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7468150", Offset = "0x7466D50", VA = "0x187468150")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7468020", Offset = "0x7466C20", VA = "0x187468020")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7468CB0", Offset = "0x74678B0", VA = "0x187468CB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7468280", Offset = "0x7466E80", VA = "0x187468280", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7468110", Offset = "0x7466D10", VA = "0x187468110", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7468550", Offset = "0x7467150", VA = "0x187468550", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7468890", Offset = "0x7467490", VA = "0x187468890", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74679F0", Offset = "0x74665F0", VA = "0x1874679F0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7467900", Offset = "0x7466500", VA = "0x187467900", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7467B80", Offset = "0x7466780", VA = "0x187467B80", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74684E0", Offset = "0x74670E0", VA = "0x1874684E0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7467CF0", Offset = "0x74668F0", VA = "0x187467CF0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7467F50", Offset = "0x7466B50", VA = "0x187467F50")]
		private DeliveryMethod OFIBLAKZHFS(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7468CD0", Offset = "0x74678D0", VA = "0x187468CD0", Slot = "16")]
		private void YNKXVTYGXFZ(EHQIAMPESRI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7467C20", Offset = "0x7466820", VA = "0x187467C20", Slot = "17")]
		private void IVOCXYZGAOP(EHQIAMPESRI a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "18")]
		private void DGLCVVUXOBK(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7468AB0", Offset = "0x74676B0", VA = "0x187468AB0", Slot = "19")]
		private void TVMSXLZFPWX(EHQIAMPESRI a, YYALPZRORMB b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7467800", Offset = "0x7466400", VA = "0x187467800")]
		private void AALNLKTXWMQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "20")]
		private void IGRDRSZYIGT(IPEndPoint a, YYALPZRORMB b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "21")]
		private void ANXHSOHDOPL(EHQIAMPESRI a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7467B00", Offset = "0x7466700", VA = "0x187467B00", Slot = "22")]
		private void FGEPITSTTZH(HGXXBXQMVOA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7467F20", Offset = "0x7466B20", VA = "0x187467F20")]
		private ulong NNBEOMHEDCK(EHQIAMPESRI a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7467F00", Offset = "0x7466B00", VA = "0x187467F00")]
		private ulong NNBEOMHEDCK(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7467B60", Offset = "0x7466760", VA = "0x187467B60")]
		private static int GVWYKHOXNHB(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7468D90", Offset = "0x7467990", VA = "0x187468D90")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74678D0", Offset = "0x74664D0", VA = "0x1874678D0")]
		[CompilerGenerated]
		private void ARLVPSBUYIJ(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74678D0", Offset = "0x74664D0", VA = "0x1874678D0")]
		[CompilerGenerated]
		private void TTTEDSDRXSY(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class RQNBFDSRJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly EHQIAMPESRI ISEWRXEYXGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<OUKPWKIYZCK> EUODHRTNZMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int UKJYYBPBZXB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FRAZIMNNFWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x746B750", Offset = "0x746A350", VA = "0x18746B750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x746B880", Offset = "0x746A480", VA = "0x18746B880")]
		protected RQNBFDSRJPL(EHQIAMPESRI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x746B7A0", Offset = "0x746A3A0", VA = "0x18746B7A0")]
		public void TBXOPWOYWNE(OUKPWKIYZCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x746B800", Offset = "0x746A400", VA = "0x18746B800")]
		protected void VCXKAHYZMCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x746B710", Offset = "0x746A310", VA = "0x18746B710")]
		public bool DYZFHEIYDGV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool UCJMELRVBXD();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool CXYFRRYSSWY(OUKPWKIYZCK a);
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
	public class HGXXBXQMVOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly IQJPIATCGNX YDBHIALWIAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int BDVYKRVLOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal BNHCOIPONLD AXFIAVSWATY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint AZKIDBJOBEA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult OEUNAGKSFUS
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x131EB30", Offset = "0x131D730", VA = "0x18131EB30")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x131EB20", Offset = "0x131D720", VA = "0x18131EB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x745ED80", Offset = "0x745D980", VA = "0x18745ED80")]
		internal void IJHSOSRRKRB(BNHCOIPONLD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x745EDE0", Offset = "0x745D9E0", VA = "0x18745EDE0")]
		private bool JWXQRHGYLHX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x745EE10", Offset = "0x745DA10", VA = "0x18745EE10")]
		internal HGXXBXQMVOA(IPEndPoint a, BNHCOIPONLD b, IQJPIATCGNX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x745ED20", Offset = "0x745D920", VA = "0x18745ED20")]
		public EHQIAMPESRI Accept()
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
		public YYALPZRORMB AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QCKNMSDMAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LGWAJWPNPZD(EHQIAMPESRI a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CMITBZRWCJD(EHQIAMPESRI a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SLPXYGWZDQS(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VJEFNUMXUEN(EHQIAMPESRI a, YYALPZRORMB b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BMRECREWIUJ(IPEndPoint a, YYALPZRORMB b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JVXKYRDWSRZ(EHQIAMPESRI a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JUAASYXAUCX(HGXXBXQMVOA a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface WXAPWEOXHBU
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZVRNMAMKQQD(EHQIAMPESRI a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SRVBJKOEMVW
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KSGLVACPVZJ(WUHAWHAHWVB a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface TTGHNBJPCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BFWIGQAGNBQ(EHQIAMPESRI a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class BNHCOIPONLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int GAREBUSKRRB = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long ATPSESEXGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte YZFOZCITXQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] IZOREDPPDGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly FMWJLYAGKJD TBBLLJEYAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int KUBTBLIPYUK;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7458D90", Offset = "0x7457990", VA = "0x187458D90")]
		private BNHCOIPONLD(long a, byte b, int c, byte[] d, FMWJLYAGKJD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7458B70", Offset = "0x7457770", VA = "0x187458B70")]
		public static int PCEKFICCSNS(OUKPWKIYZCK a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7458BA0", Offset = "0x74577A0", VA = "0x187458BA0")]
		public static BNHCOIPONLD QYFUAYLSBNN(OUKPWKIYZCK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7458990", Offset = "0x7457590", VA = "0x187458990")]
		public static OUKPWKIYZCK DSVANOFGRAR(XRBXODWTPKN a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class OVSQYWFNWYI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long ATPSESEXGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte YZFOZCITXQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int KUBTBLIPYUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool QUKHFQBJLMR;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x746B510", Offset = "0x746A110", VA = "0x18746B510")]
		private OVSQYWFNWYI(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x746B310", Offset = "0x7469F10", VA = "0x18746B310")]
		public static OVSQYWFNWYI QYFUAYLSBNN(OUKPWKIYZCK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x746B220", Offset = "0x7469E20", VA = "0x18746B220")]
		public static OUKPWKIYZCK DSVANOFGRAR(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x746B410", Offset = "0x746A010", VA = "0x18746B410")]
		public static OUKPWKIYZCK YKHKZHPJVGD(EHQIAMPESRI a)
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
	public interface INQQIWPCQPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZZIVDIXIDXQ(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WYCFCMLTXXG(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class AVXWJPGXKUG
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
		private class PWLBHWDSFSA
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint KKAZCEZFPJA
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string PNAJWRRNLTK
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public PWLBHWDSFSA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class JGZMAIMAKPW
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint KKAZCEZFPJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint YTCMZKDZWMU
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string PNAJWRRNLTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public JGZMAIMAKPW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class TCPHXIUPMHM
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string PNAJWRRNLTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool AXNABCNXNFK
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xBAE8E0", Offset = "0xBAD4E0", VA = "0x180BAE8E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xA97500", Offset = "0xA96100", VA = "0x180A97500")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TCPHXIUPMHM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly IQJPIATCGNX OACYGFUVYKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> SGPKNTNWIIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> UECNELUUBBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly FMWJLYAGKJD SHZZPNVGIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly XRBXODWTPKN WRZPDANVUYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly EGRYITZYSNM XOFXVGEKSCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private INQQIWPCQPJ FGZHLLMUXSN;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int PQKRKUWTQRW = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool SUFUGOLFLPN;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7458500", Offset = "0x7457100", VA = "0x187458500")]
		internal AVXWJPGXKUG(IQJPIATCGNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7458050", Offset = "0x7456C50", VA = "0x187458050")]
		internal void WYKGYALIXAH(IPEndPoint a, OUKPWKIYZCK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x304F140", Offset = "0x304DD40", VA = "0x18304F140")]
		private void ZWGXHKIVLWB<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7458370", Offset = "0x7456F70", VA = "0x187458370")]
		private void ZZIVDIXIDXQ(PWLBHWDSFSA a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7457EF0", Offset = "0x7456AF0", VA = "0x187457EF0")]
		private void LPTSKAPNIYG(JGZMAIMAKPW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74581D0", Offset = "0x7456DD0", VA = "0x1874581D0")]
		private void XGHNSCAVGQH(TCPHXIUPMHM a, IPEndPoint b)
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
	public static class JMGRYGDHDTZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] YLQTULLEVUE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int MQHNRVNEIJQ;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int ZYEXAJOPEJF;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7467510", Offset = "0x7466110", VA = "0x187467510")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7467510", Offset = "0x7466110", VA = "0x187467510")]
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
	public interface UIERANFVXLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EFVNBBHHMUN(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class MWCQPSFXOLP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static UIERANFVXLL MWIDAKSTXDV;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object WWJYKCVRSJJ;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74690F0", Offset = "0x7467CF0", VA = "0x1874690F0")]
		private static void KWFAIKSBKAI(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7469320", Offset = "0x7467F20", VA = "0x187469320")]
		internal static void SZQIFMIOHCM(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7469090", Offset = "0x7467C90", VA = "0x187469090")]
		internal static void KVHFYGHCFJY(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7469030", Offset = "0x7467C30", VA = "0x187469030")]
		internal static void ADKNXNKAXNC(string a, params object[] args)
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
	public sealed class YYALPZRORMB : FMWJLYAGKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private OUKPWKIYZCK MRIAYUEFYYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly IQJPIATCGNX GPRLIBHATIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly LSZSYDFMDMC CSKTVRNVTBH;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x746F320", Offset = "0x746DF20", VA = "0x18746F320")]
		internal YYALPZRORMB(IQJPIATCGNX a, LSZSYDFMDMC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x746F200", Offset = "0x746DE00", VA = "0x18746F200")]
		internal void ESFKBRXFJMM(OUKPWKIYZCK a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x746F270", Offset = "0x746DE70", VA = "0x18746F270")]
		internal void TRRGUVLYZIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x746F2F0", Offset = "0x746DEF0", VA = "0x18746F2F0")]
		public void YRTKUUFTIVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class LSZSYDFMDMC
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
		public LSZSYDFMDMC TFGWUSNIPYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType XSYNALKQIRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EHQIAMPESRI ISEWRXEYXGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint AZKIDBJOBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object FUVVEPKUKFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int PULDGMJPZGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError TFLRDICPCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason OHIIRXHENYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HGXXBXQMVOA HGXXBXQMVOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod IRXXIXZMPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte KFCJEENDDUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly YYALPZRORMB YQCOLFWXWHK;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7467760", Offset = "0x7466360", VA = "0x187467760")]
		public LSZSYDFMDMC(IQJPIATCGNX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class IQJPIATCGNX : IEnumerable<EHQIAMPESRI>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class BJXJWCULJIU : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x74588F0", Offset = "0x74574F0", VA = "0x1874588F0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7458960", Offset = "0x7457560", VA = "0x187458960", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public BJXJWCULJIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<EHQIAMPESRI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly EHQIAMPESRI _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private EHQIAMPESRI _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public EHQIAMPESRI Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1A555C0", Offset = "0x1A541C0", VA = "0x181A555C0")]
			public NetPeerEnumerator(EHQIAMPESRI p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x746A820", Offset = "0x7469420", VA = "0x18746A820", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x746A870", Offset = "0x7469470", VA = "0x18746A870", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread YIFHOOYXCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool WQTRBEOKKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool JWBPAHHTRLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private WCDEYMLCINI YIVBUAQOVBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent FMKYSAKMOVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<LSZSYDFMDMC> VEXNXGGIERT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<LSZSYDFMDMC> GEZTJIHUNQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private LSZSYDFMDMC YIIMSEGYYKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly QCKNMSDMAEP ONUBCTWXXMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly WXAPWEOXHBU DRNQDVSFDWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly SRVBJKOEMVW HPDYYOHEAVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly TTGHNBJPCCG XKAQGBJAIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, EHQIAMPESRI> UPHYICASZUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, HGXXBXQMVOA> QEMFCPZUHNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, ILAGRTOHVZC> QAWASPPWAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim DDHDANMZKNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private EHQIAMPESRI JCWHBKKNJQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int GBOEHHRRDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<EHQIAMPESRI> JIYYMHNZUEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private EHQIAMPESRI[] DANEXECTFJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly TQJWHIIOPDP YROIKIEMMVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int IFRMKBXGWUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> SYHAFCCQQKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte IDBMBHSEMXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object PREOPQZWGSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool WTWIKFHYTIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool DEBKOAUEALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int PAVSRJNJEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int QTRYPZOMSVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int GGPAXRJXDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int MDQHSGSRTZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool HSZOQEEOIEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool XBBPOFQQGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int CAHQRGCJLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int IBEUSDGJUIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int ZJNZKAFSAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool SUFUGOLFLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool WBOUHNNDHBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool TWBZWVTGGZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool XIOTLBUASLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int BFXPCHTJDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int PQUVQLXRAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool KSXLZDOUSEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly BWPLENTPSEF KKJVGYNGJJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool SGVXYLTFLKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly AVXWJPGXKUG AVXWJPGXKUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool UDPNDVHJXUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode JMUSZGZFGLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int ZGBQOWDTKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool WFCXAAAWXCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool RJBQXPJICRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool XAXTMSWPBRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool ZTIKGBGZPWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private OUKPWKIYZCK CPPTKIJLEHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int UTOVZGUYPYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object LMFWUBHRNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private OUKPWKIYZCK BPNEFJKVCTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int NWGHXXFFYZG;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int LVZKYZVRMRO = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int ETPNFTGEQYZ = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private JHYUNJJVAOP RNVOSZJQPZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private JHYUNJJVAOP ROGCNMXLIWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread GPQJZPNFGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread GPFWFBZKNRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint IZVYCROCXUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint IZLKIEAIEXJ;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] IAPKPURLVEN;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] LFWFAVSRWAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> QXYGZCQWNLA;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress MOCKMDFSDQJ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool EFCWXKHPKNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int JRVYSYLFIJD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FWOCZGJSQUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB74360", Offset = "0xB72F60", VA = "0x180B74360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB72EF0", Offset = "0xB71AF0", VA = "0x180B72EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int ADINRARUMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1EC2E30", Offset = "0x1EC1A30", VA = "0x181EC2E30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x20377B0", Offset = "0x20363B0", VA = "0x1820377B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte PZLYZRTUYUO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB0B120", Offset = "0xB09D20", VA = "0x180B0B120")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int HCASYJWMQKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7461360", Offset = "0x745FF60", VA = "0x187461360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short PGAEHGOADHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7466A30", Offset = "0x7465630", VA = "0x187466A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EHQIAMPESRI.OnUpdatedMtuDelegate MMYTZHHUPIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7463280", Offset = "0x7461E80", VA = "0x187463280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7466400", Offset = "0x7465000", VA = "0x187466400")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7466C70", Offset = "0x7465870", VA = "0x187466C70")]
		public void YSVDRMXXBSP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74657A0", Offset = "0x74643A0", VA = "0x1874657A0")]
		public void TNYRWLOSSJU(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7463B00", Offset = "0x7462700", VA = "0x187463B00")]
		private bool NTILXAAGSZG(IPEndPoint a, [Out] EHQIAMPESRI b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x745F7C0", Offset = "0x745E3C0", VA = "0x18745F7C0")]
		private void AMBEEDPCHPQ(EHQIAMPESRI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x74630A0", Offset = "0x7461CA0", VA = "0x1874630A0")]
		private void MEIKFZIUOXN(EHQIAMPESRI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7460070", Offset = "0x745EC70", VA = "0x187460070")]
		private void CJPSTBDGJMO(EHQIAMPESRI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7466F50", Offset = "0x7465B50", VA = "0x187466F50")]
		public IQJPIATCGNX(QCKNMSDMAEP a, [Optional] TQJWHIIOPDP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x745FD50", Offset = "0x745E950", VA = "0x18745FD50")]
		internal void BDOMKOACTUK(EHQIAMPESRI a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7461310", Offset = "0x745FF10", VA = "0x187461310")]
		internal void IZTXSERUFHA(EHQIAMPESRI a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x745F780", Offset = "0x745E380", VA = "0x18745F780")]
		internal void AJZXIMIKJBC(EHQIAMPESRI a, DisconnectReason b, SocketError c, OUKPWKIYZCK d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7465F30", Offset = "0x7464B30", VA = "0x187465F30")]
		private void VVFEEKVCCKF(EHQIAMPESRI a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, OUKPWKIYZCK h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7462CD0", Offset = "0x74618D0", VA = "0x187462CD0")]
		private void LYNUWQFUIZT(LSZSYDFMDMC.EType a, [Optional] EHQIAMPESRI b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] HGXXBXQMVOA g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] OUKPWKIYZCK j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7463330", Offset = "0x7461F30", VA = "0x187463330")]
		private void NANHRXRJYCA(LSZSYDFMDMC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x74658F0", Offset = "0x74644F0", VA = "0x1874658F0")]
		internal void TSAWUHAXSAY(LSZSYDFMDMC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x74626B0", Offset = "0x74612B0", VA = "0x1874626B0")]
		private void LFIYXQMBBXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x74650F0", Offset = "0x7463CF0", VA = "0x1874650F0")]
		private void TGFDYLDTYTW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7463F20", Offset = "0x7462B20", VA = "0x187463F20")]
		internal EHQIAMPESRI QESICBPHHNB(HGXXBXQMVOA a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x74608C0", Offset = "0x745F4C0", VA = "0x1874608C0")]
		private int DUITLOBEKYF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7465A00", Offset = "0x7464600", VA = "0x187465A00")]
		private void VBZCZWRNJNZ(IPEndPoint a, EHQIAMPESRI b, BNHCOIPONLD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7461380", Offset = "0x745FF80", VA = "0x187461380")]
		private void JILBRRUPRYS(OUKPWKIYZCK a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74664B0", Offset = "0x74650B0", VA = "0x1874664B0")]
		internal void XAQCSUBGWWI(OUKPWKIYZCK a, DeliveryMethod b, byte c, int d, EHQIAMPESRI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7464D50", Offset = "0x7463950", VA = "0x187464D50")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7464D60", Offset = "0x7463960", VA = "0x187464D60")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7464560", Offset = "0x7463160", VA = "0x187464560")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7463BA0", Offset = "0x74627A0", VA = "0x187463BA0")]
		public void PKQIOYHLBHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7460330", Offset = "0x745EF30", VA = "0x187460330")]
		public EHQIAMPESRI Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7460410", Offset = "0x745F010", VA = "0x187460410")]
		public EHQIAMPESRI Connect(string address, int port, XRBXODWTPKN connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74604F0", Offset = "0x745F0F0", VA = "0x1874604F0")]
		public EHQIAMPESRI Connect(IPEndPoint target, XRBXODWTPKN connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7464D80", Offset = "0x7463980", VA = "0x187464D80")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7464D90", Offset = "0x7463990", VA = "0x187464D90")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74631D0", Offset = "0x7461DD0", VA = "0x1874631D0")]
		public void MPPWCPAXZQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7463100", Offset = "0x7461D00", VA = "0x187463100")]
		public void MPPWCPAXZQA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7466320", Offset = "0x7464F20", VA = "0x187466320")]
		public void VVFEEKVCCKF(EHQIAMPESRI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7466360", Offset = "0x7464F60", VA = "0x187466360")]
		public void VVFEEKVCCKF(EHQIAMPESRI a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x745FFE0", Offset = "0x745EBE0", VA = "0x18745FFE0", Slot = "4")]
		private IEnumerator<EHQIAMPESRI> BVOEADUWWDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7465EA0", Offset = "0x7464AA0", VA = "0x187465EA0", Slot = "5")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7463E30", Offset = "0x7462A30", VA = "0x187463E30")]
		private OUKPWKIYZCK PSRBBTVLRUS(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7463D50", Offset = "0x7462950", VA = "0x187463D50")]
		private OUKPWKIYZCK PSRBBTVLRUS(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x745FDA0", Offset = "0x745E9A0", VA = "0x18745FDA0")]
		internal OUKPWKIYZCK BMBXRWGSNLJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x745FAE0", Offset = "0x745E6E0", VA = "0x18745FAE0")]
		internal void AOLVCLKSMQG(OUKPWKIYZCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7466E90", Offset = "0x7465A90", VA = "0x187466E90")]
		static IQJPIATCGNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB74360", Offset = "0xB72F60", VA = "0x180B74360")]
		private bool GIQRQJOOIBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x74668D0", Offset = "0x74654D0", VA = "0x1874668D0")]
		private void YFWEEKEYEBF(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7466780", Offset = "0x7465380", VA = "0x187466780")]
		private void XESZQWCZIWU(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7461150", Offset = "0x745FD50", VA = "0x187461150")]
		private bool GOGOONURMUC(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x74612F0", Offset = "0x745FEF0", VA = "0x1874612F0")]
		private void HCJNOVYFZPX(WCDEYMLCINI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7462A10", Offset = "0x7461610", VA = "0x187462A10")]
		private void LFWYQOLAKDI(JHYUNJJVAOP a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7465420", Offset = "0x7464020", VA = "0x187465420")]
		private void TNAVYZFGMRY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74645E0", Offset = "0x74631E0", VA = "0x1874645E0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74663A0", Offset = "0x7464FA0", VA = "0x1874663A0")]
		internal int WASDEBOBWMT(OUKPWKIYZCK a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7460940", Offset = "0x745F540", VA = "0x187460940")]
		internal int FBLGQHTVNMJ(OUKPWKIYZCK a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7460980", Offset = "0x745F580", VA = "0x187460980")]
		internal int FBLGQHTVNMJ(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7466AF0", Offset = "0x74656F0", VA = "0x187466AF0")]
		internal void YJVGOJAKCLO(bool a)
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
	internal sealed class OUKPWKIYZCK
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int JWCYGAHYDMJ;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] ORSCVGWWDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] ALRWUXISGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int MBSBMAIKRVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object FUVVEPKUKFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public OUKPWKIYZCK TFGWUSNIPYK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty BYKNUORMGUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x746A9F0", Offset = "0x74695F0", VA = "0x18746A9F0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x746A9B0", Offset = "0x74695B0", VA = "0x18746A9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte YZFOZCITXQK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x746ABB0", Offset = "0x74697B0", VA = "0x18746ABB0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x746AA20", Offset = "0x7469620", VA = "0x18746AA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort SLLCXTAEJRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x746A8F0", Offset = "0x74694F0", VA = "0x18746A8F0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x746A930", Offset = "0x7469530", VA = "0x18746A930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool RNVGPVOJNMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x746AC70", Offset = "0x7469870", VA = "0x18746AC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte CVMKZHFAYVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x746AC40", Offset = "0x7469840", VA = "0x18746AC40")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x746AA60", Offset = "0x7469660", VA = "0x18746AA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort LGTFQSSWSWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x746AB90", Offset = "0x7469790", VA = "0x18746AB90")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x746ABE0", Offset = "0x74697E0", VA = "0x18746ABE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort LMLDBVLHOSG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x746AC20", Offset = "0x7469820", VA = "0x18746AC20")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x746A8B0", Offset = "0x74694B0", VA = "0x18746A8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort QVGMKSBFYXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x746A910", Offset = "0x7469510", VA = "0x18746A910")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x746A970", Offset = "0x7469570", VA = "0x18746A970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x746ADD0", Offset = "0x74699D0", VA = "0x18746ADD0")]
		static OUKPWKIYZCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x746ACA0", Offset = "0x74698A0", VA = "0x18746ACA0")]
		public void YDWANJHWBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x746B1B0", Offset = "0x7469DB0", VA = "0x18746B1B0")]
		public OUKPWKIYZCK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x746B0A0", Offset = "0x7469CA0", VA = "0x18746B0A0")]
		public OUKPWKIYZCK(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x746AD60", Offset = "0x7469960", VA = "0x18746AD60")]
		public static int YVTFLTAACSR(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x746ACD0", Offset = "0x74698D0", VA = "0x18746ACD0")]
		public int YVTFLTAACSR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x746AA90", Offset = "0x7469690", VA = "0x18746AA90")]
		public bool NEZLJIDGDJU()
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
	public class EHQIAMPESRI
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class PMHHXOJAHQY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public OUKPWKIYZCK[] QPJUFHWLEAU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int LLZHIEWVRDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int RTQYPLGSAFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte CVMKZHFAYVZ;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public PMHHXOJAHQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int ADUQOHVFKMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int CIILCMIXPYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int SMTONXKGBQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double UHZYBECXULM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int AWKFCQCBLKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int FWIIKLXBVZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int YJCKPVBKHRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch RTISVOWRCEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int RAAIGAWNROZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long NKSPJWWCBYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object TPFJWSXIBQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal EHQIAMPESRI EAPWNZYHTJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal EHQIAMPESRI PUQTCEQGSEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<OUKPWKIYZCK> EDHITXVIYKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<RQNBFDSRJPL> PIFQWZXMMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly RQNBFDSRJPL[] QUGWCCCNDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int BDFNYIWCZDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int BMRJDKHEZQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool HPFDOZVMLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int WGZLSJWOFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int WBBEDEMGFFU;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int CBYKMDQGNSK = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int QUSBKGMQJUF = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object VHXOZEAYIPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int AUQFMJVDEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, PMHHXOJAHQY> NXHKBKMIXRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> OJFKTEFSMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly OUKPWKIYZCK LPXCOAAYIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int NDQAIWZZPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int NFSMNGTMBDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint BWPUMNATARR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int UOMPZPAADIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int RWOENZHBTBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long ORCZUAMKHSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte UOUFFJHXPYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState DUNVNWOHFMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OUKPWKIYZCK WFFJBMRHXOK;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int SOQUQYTXKRW = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int SITCWBTHGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly OUKPWKIYZCK ZVTPFXCQELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly OUKPWKIYZCK HJZNHDLLUXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly OUKPWKIYZCK OAZSKQBEPBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly OUKPWKIYZCK YBCZMDTGZTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality VKOALJSEDVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly IQJPIATCGNX IQJPIATCGNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int HSLXDBEEAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object DYTCSKOLWXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly BWPLENTPSEF KKJVGYNGJJW;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte EYNBNBDEHIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC2DF0", Offset = "0xAC19F0", VA = "0x180AC2DF0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x745A840", Offset = "0x7459440", VA = "0x18745A840")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint VOJCVGKHUYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB6E0C0", Offset = "0xB6CCC0", VA = "0x180B6E0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState RJPTXNFTXLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1225810", Offset = "0x1224410", VA = "0x181225810")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long NBCTKTNHSNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA96BA0", Offset = "0xA957A0", VA = "0x180A96BA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int YKUEWHHLUYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1EC2E30", Offset = "0x1EC1A30", VA = "0x181EC2E30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x20377B0", Offset = "0x20363B0", VA = "0x1820377B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BYXXXLVSPUH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x745DBF0", Offset = "0x745C7F0", VA = "0x18745DBF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int DAXRAZVGJKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAB3C70", Offset = "0xAB2870", VA = "0x180AB3C70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double OVXSZMWMIZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x27F2D20", Offset = "0x27F1920", VA = "0x1827F2D20")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate MMYTZHHUPIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x745B6B0", Offset = "0x745A2B0", VA = "0x18745B6B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x745DAC0", Offset = "0x745C6C0", VA = "0x18745DAC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x745DEA0", Offset = "0x745CAA0", VA = "0x18745DEA0")]
		internal EHQIAMPESRI(IQJPIATCGNX a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x745A8F0", Offset = "0x74594F0", VA = "0x18745A8F0")]
		internal void CJIJMMBPSZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x745B0A0", Offset = "0x7459CA0", VA = "0x18745B0A0")]
		internal void GXWVFIIOYYR(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x745DC00", Offset = "0x745C800", VA = "0x18745DC00")]
		internal void ZNAAWMSEZRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x745B540", Offset = "0x745A140", VA = "0x18745B540")]
		private void KAFMMUCOGBZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x745B760", Offset = "0x745A360", VA = "0x18745B760")]
		private void PVZVOBHEEIR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x745BB30", Offset = "0x745A730", VA = "0x18745BB30")]
		public int QPCXGIHIQDT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x745BC40", Offset = "0x745A840", VA = "0x18745BC40")]
		public int QPCXGIHIQDT(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x745C4F0", Offset = "0x745B0F0", VA = "0x18745C4F0")]
		private RQNBFDSRJPL SYRFFTIECYW(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x745E2A0", Offset = "0x745CEA0", VA = "0x18745E2A0")]
		internal EHQIAMPESRI(IQJPIATCGNX a, IPEndPoint b, int c, byte d, XRBXODWTPKN e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x745DCC0", Offset = "0x745C8C0", VA = "0x18745DCC0")]
		internal EHQIAMPESRI(IQJPIATCGNX a, HGXXBXQMVOA b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x745C4A0", Offset = "0x745B0A0", VA = "0x18745C4A0")]
		internal void Reject(BNHCOIPONLD requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x745DB70", Offset = "0x745C770", VA = "0x18745DB70")]
		internal bool XHYUXJXPEYS(OVSQYWFNWYI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x745DC90", Offset = "0x745C890", VA = "0x18745DC90")]
		public void ZWGXHKIVLWB(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x745BEB0", Offset = "0x745AAB0", VA = "0x18745BEB0")]
		private void RFGDTFPLSHO(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x745AFB0", Offset = "0x7459BB0", VA = "0x18745AFB0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x745B610", Offset = "0x745A210", VA = "0x18745B610")]
		internal DisconnectResult MLCKCFDMONU(OUKPWKIYZCK a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x745B000", Offset = "0x7459C00", VA = "0x18745B000")]
		internal void EJSJXIKQCIN(RQNBFDSRJPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x745C680", Offset = "0x745B280", VA = "0x18745C680")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x745B060", Offset = "0x7459C60", VA = "0x18745B060")]
		private void ELXVPIEBRAI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x745D220", Offset = "0x745BE20", VA = "0x18745D220")]
		internal void VTOBGHTLYLK(DeliveryMethod a, OUKPWKIYZCK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x745A300", Offset = "0x7458F00", VA = "0x18745A300")]
		private void ACBHIHECSQI(OUKPWKIYZCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x745B7A0", Offset = "0x745A3A0", VA = "0x18745B7A0")]
		private void PWUXMQQEOWI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x745D060", Offset = "0x745BC60", VA = "0x18745D060")]
		internal ConnectRequestResult VBZCZWRNJNZ(BNHCOIPONLD a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x745A910", Offset = "0x7459510", VA = "0x18745A910")]
		internal void CXYFRRYSSWY(OUKPWKIYZCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x745BD60", Offset = "0x745A960", VA = "0x18745BD60")]
		private void QRTFTZIXMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x745B0D0", Offset = "0x7459CD0", VA = "0x18745B0D0")]
		internal void HHPZOOPMLXM(OUKPWKIYZCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x745C990", Offset = "0x745B590", VA = "0x18745C990")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x745B2E0", Offset = "0x7459EE0", VA = "0x18745B2E0")]
		internal void HXYVFRNJCFA(OUKPWKIYZCK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class BWPLENTPSEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long OKJEVEORYDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long DWKFMFNRRDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long FHQQTKMFCWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long DZRKSCVLBUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long VBHIYUOHEKT;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long MBFCRTCYTUS;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long YMKZMVXAZPJ;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long XCMEHEKFSEA;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long MHUJWHIMQQB;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long HXHIEIAJMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long BISVMBKYSXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long CJBRFJAHFWV;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long FZSRAYLYOFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x74590C0", Offset = "0x7457CC0", VA = "0x1874590C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long XKHFPPILZMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7458E60", Offset = "0x7457A60", VA = "0x187458E60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long QPWROQIEFEU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7459520", Offset = "0x7458120", VA = "0x187459520")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long TRTWBUBOGSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x74590A0", Offset = "0x7457CA0", VA = "0x1874590A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long CDFCFKGWBSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x74590B0", Offset = "0x7457CB0", VA = "0x1874590B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long KNDQIMHVLDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7459090", Offset = "0x7457C90", VA = "0x187459090")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long RQBSVPJOLPX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7458F40", Offset = "0x7457B40", VA = "0x187458F40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long LDCBGOCGVOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7459590", Offset = "0x7458190", VA = "0x187459590")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality PERTEBKHMGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1103460", Offset = "0x1102060", VA = "0x181103460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double TZLDSNIHEEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7459530", Offset = "0x7458130", VA = "0x187459530")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x74590D0", Offset = "0x7457CD0", VA = "0x1874590D0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7458E00", Offset = "0x7457A00", VA = "0x187458E00")]
		public void BMOZQEJEOST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x74594D0", Offset = "0x74580D0", VA = "0x1874594D0")]
		public void UDFLBYCCIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7458ED0", Offset = "0x7457AD0", VA = "0x187458ED0")]
		public void FFBOITSHQYL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7459020", Offset = "0x7457C20", VA = "0x187459020")]
		public void IJWQQWVLKVE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7458E70", Offset = "0x7457A70", VA = "0x187458E70")]
		public void DTVTVZHGGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7459450", Offset = "0x7458050", VA = "0x187459450")]
		public void UDFHQKUAWFD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7459110", Offset = "0x7457D10", VA = "0x187459110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7458F80", Offset = "0x7457B80", VA = "0x187458F80")]
		public void IGVMHKAIMGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public BWPLENTPSEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class RTEUNDUFEWD
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> KBCTDCWHQWG;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x746B910", Offset = "0x746A510", VA = "0x18746B910")]
		public static IPEndPoint CBAFYHSQHUI(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x746BBE0", Offset = "0x746A7E0", VA = "0x18746BBE0")]
		public static IPAddress DKOIIVFUAIP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x746BB50", Offset = "0x746A750", VA = "0x18746BB50")]
		public static IPAddress DKOIIVFUAIP(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x746BDB0", Offset = "0x746A9B0", VA = "0x18746BDB0")]
		internal static int RGBHUBGLVXZ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3A061A0", Offset = "0x3A04DA0", VA = "0x183A061A0")]
		internal static T[] RDRJGULAMZU<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class NGUBXUGYZCE : RQNBFDSRJPL
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private OUKPWKIYZCK _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x746B6A0", Offset = "0x746A2A0", VA = "0x18746B6A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x746B680", Offset = "0x746A280", VA = "0x18746B680")]
			public void NXLLWCOSNCZ(OUKPWKIYZCK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x746B5C0", Offset = "0x746A1C0", VA = "0x18746B5C0")]
			public bool AAUAEGIBCAW(long a, EHQIAMPESRI b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x746B630", Offset = "0x746A230", VA = "0x18746B630")]
			public bool Clear(EHQIAMPESRI peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly OUKPWKIYZCK BNUZMFNHBHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] UAZBSEJVDXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly OUKPWKIYZCK[] ENARRPOXQRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] CVXMSASCOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int APDTKDXRCGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int GBOQJXEATIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int WTTQGPRSHTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int CRAPFZESOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool MIKBIWRNXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod IAWDDORQEZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool FSCHBVGPJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int XFXOMNYJKYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte YZLSDRBRAMF;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int DARDRLBVZQO
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x746A280", Offset = "0x7468E80", VA = "0x18746A280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x746A290", Offset = "0x7468E90", VA = "0x18746A290")]
		public NGUBXUGYZCE(EHQIAMPESRI a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7469A30", Offset = "0x7468630", VA = "0x187469A30")]
		private void KTUTAJJARAJ(OUKPWKIYZCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7469DB0", Offset = "0x74689B0", VA = "0x187469DB0", Slot = "4")]
		protected override bool UCJMELRVBXD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7469430", Offset = "0x7468030", VA = "0x187469430", Slot = "5")]
		public override bool CXYFRRYSSWY(OUKPWKIYZCK a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class INPTVYSLDSB : RQNBFDSRJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int KSAGGGCEVOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort GBOQJXEATIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool UHBNEIRWGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private OUKPWKIYZCK AWBCCSLGEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly OUKPWKIYZCK FIDUKRUOEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool HLQRVVDNYCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte YZLSDRBRAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long IPGBGPNAXHV;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x745F6C0", Offset = "0x745E2C0", VA = "0x18745F6C0")]
		public INPTVYSLDSB(EHQIAMPESRI a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x745F200", Offset = "0x745DE00", VA = "0x18745F200", Slot = "4")]
		protected override bool UCJMELRVBXD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x745EF80", Offset = "0x745DB80", VA = "0x18745EF80", Slot = "5")]
		public override bool CXYFRRYSSWY(OUKPWKIYZCK a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class KCUPZURPWRO
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
		[Cpp2IlInjected.Address(RVA = "0x7457910", Offset = "0x7456510", VA = "0x187457910")]
		private static void DPGXGELDUUJ(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7467630", Offset = "0x7466230", VA = "0x187467630")]
		private static void DPGXGELDUUJ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7467720", Offset = "0x7466320", VA = "0x187467720")]
		public static void DPGXGELDUUJ(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7467610", Offset = "0x7466210", VA = "0x187467610")]
		public static void DDAKDXOBEMY(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x74676A0", Offset = "0x74662A0", VA = "0x1874676A0")]
		public static void DDAKDXOBEMY(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7467720", Offset = "0x7466320", VA = "0x187467720")]
		public static void DDAKDXOBEMY(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7467720", Offset = "0x7466320", VA = "0x187467720")]
		public static void DDAKDXOBEMY(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7467630", Offset = "0x7466230", VA = "0x187467630")]
		public static void DDAKDXOBEMY(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7467630", Offset = "0x7466230", VA = "0x187467630")]
		public static void DDAKDXOBEMY(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7467600", Offset = "0x7466200", VA = "0x187467600")]
		public static void DDAKDXOBEMY(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7467600", Offset = "0x7466200", VA = "0x187467600")]
		public static void DDAKDXOBEMY(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class FMWJLYAGKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] CSGZSXXVHSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int AZJLOHTTELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int GYGMBEHHGJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int WGSPTZHXIFR;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] ALRWUXISGPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int VATEGSFDYEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int JWPBMLZXETP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x745EC30", Offset = "0x745D830", VA = "0x18745EC30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ICSYXLOBPPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x274E1F0", Offset = "0x274CDF0", VA = "0x18274E1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int BXYCQFNDHYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x745EC20", Offset = "0x745D820", VA = "0x18745EC20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x745E5B0", Offset = "0x745D1B0", VA = "0x18745E5B0")]
		public void ESFKBRXFJMM(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public FMWJLYAGKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x745ECC0", Offset = "0x745D8C0", VA = "0x18745ECC0")]
		public FMWJLYAGKJD(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x745EAC0", Offset = "0x745D6C0", VA = "0x18745EAC0")]
		public IPEndPoint TGYKJAFWWWB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x745E570", Offset = "0x745D170", VA = "0x18745E570")]
		public byte SKJTVUJQHXJ()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x745E570", Offset = "0x745D170", VA = "0x18745E570")]
		public sbyte DIMUEZDHUGY()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x367D720", Offset = "0x367C320", VA = "0x18367D720")]
		public a[] TBQIPCPCNNU<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x745E5F0", Offset = "0x745D1F0", VA = "0x18745E5F0")]
		public bool[] FVPGONAYJLY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x745EC80", Offset = "0x745D880", VA = "0x18745EC80")]
		public ushort[] YRHNKRGJVJZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x745E9A0", Offset = "0x745D5A0", VA = "0x18745E9A0")]
		public short[] PUEILJKPNKS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x745EA80", Offset = "0x745D680", VA = "0x18745EA80")]
		public int[] SXNXQHPQASP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x745E8F0", Offset = "0x745D4F0", VA = "0x18745E8F0")]
		public uint[] NWARWSLFYRE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x745E630", Offset = "0x745D230", VA = "0x18745E630")]
		public float[] HWTNEOLLPLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x745E930", Offset = "0x745D530", VA = "0x18745E930")]
		public double[] PLCJOEVQEUZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x745E6A0", Offset = "0x745D2A0", VA = "0x18745E6A0")]
		public long[] KWOQYSKNMMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x745EA10", Offset = "0x745D610", VA = "0x18745EA10")]
		public ulong[] QKRSSVKAVSD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x745EB50", Offset = "0x745D750", VA = "0x18745EB50")]
		public string[] WFXPANCGTNT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x745E470", Offset = "0x745D070", VA = "0x18745E470")]
		public bool AUGDZRGDIVX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x745E970", Offset = "0x745D570", VA = "0x18745E970")]
		public char PSDVREMDECN()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x745E970", Offset = "0x745D570", VA = "0x18745E970")]
		public ushort RIUOAXONZSW()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x745E970", Offset = "0x745D570", VA = "0x18745E970")]
		public short VJSXWUTVPNT()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x745E4B0", Offset = "0x745D0B0", VA = "0x18745E4B0")]
		public long BDRRGDHJHLN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x745E4B0", Offset = "0x745D0B0", VA = "0x18745E4B0")]
		public ulong FAOUWPEKOMK()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x745EA50", Offset = "0x745D650", VA = "0x18745EA50")]
		public int YQBQLKRSNOS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x745EA50", Offset = "0x745D650", VA = "0x18745EA50")]
		public uint SIXVBQEJHMZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x745E9E0", Offset = "0x745D5E0", VA = "0x18745E9E0")]
		public float QDECOWTRVBD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x745E670", Offset = "0x745D270", VA = "0x18745E670")]
		public double IMKJQLHKOPO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x745E6E0", Offset = "0x745D2E0", VA = "0x18745E6E0")]
		public string LSYQVOCHFCM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x745E500", Offset = "0x745D100", VA = "0x18745E500")]
		public ArraySegment<byte> DHRTLUZFPTX(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x745E430", Offset = "0x745D030", VA = "0x18745E430")]
		public sbyte[] ABYTSVKCTUF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x745EC40", Offset = "0x745D840", VA = "0x18745EC40")]
		public byte[] XCQVICDOOLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x745E4E0", Offset = "0x745D0E0", VA = "0x18745E4E0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class XRBXODWTPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] CSGZSXXVHSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int AZJLOHTTELF;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int ANFTHZXQZGM = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool GVQPLWQYSKL;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding FIJZWSKIQXP;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int EKCQLFNFLFY = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] CEMEYNHVUYP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] TBBLLJEYAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int EYPZHMQDKRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x746F0E0", Offset = "0x746DCE0", VA = "0x18746F0E0")]
		public XRBXODWTPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x746F160", Offset = "0x746DD60", VA = "0x18746F160")]
		public XRBXODWTPKN(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x746EFF0", Offset = "0x746DBF0", VA = "0x18746EFF0")]
		public static XRBXODWTPKN WHYAHGTJDMC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x746EF50", Offset = "0x746DB50", VA = "0x18746EF50")]
		public void RTQJCVYVCOU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x27C6610", Offset = "0x27C5210", VA = "0x1827C6610")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x746EAA0", Offset = "0x746D6A0", VA = "0x18746EAA0")]
		public void MTGZPQDROWQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x746EF00", Offset = "0x746DB00", VA = "0x18746EF00")]
		public void MTGZPQDROWQ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x746E960", Offset = "0x746D560", VA = "0x18746E960")]
		public void MTGZPQDROWQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x746E960", Offset = "0x746D560", VA = "0x18746E960")]
		public void MTGZPQDROWQ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x746EA10", Offset = "0x746D610", VA = "0x18746EA10")]
		public void MTGZPQDROWQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x746EA10", Offset = "0x746D610", VA = "0x18746EA10")]
		public void MTGZPQDROWQ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x746EE20", Offset = "0x746DA20", VA = "0x18746EE20")]
		public void MTGZPQDROWQ(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x746EE20", Offset = "0x746DA20", VA = "0x18746EE20")]
		public void MTGZPQDROWQ(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x746EE20", Offset = "0x746DA20", VA = "0x18746EE20")]
		public void MTGZPQDROWQ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x746E9B0", Offset = "0x746D5B0", VA = "0x18746E9B0")]
		public void MTGZPQDROWQ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x746E9B0", Offset = "0x746D5B0", VA = "0x18746E9B0")]
		public void MTGZPQDROWQ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x746E8F0", Offset = "0x746D4F0", VA = "0x18746E8F0")]
		public void MTGZPQDROWQ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x746E3C0", Offset = "0x746CFC0", VA = "0x18746E3C0")]
		public void XXULWIHMDDO(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x746E3C0", Offset = "0x746CFC0", VA = "0x18746E3C0")]
		public void SBTIDPYMNLV(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x746EEA0", Offset = "0x746DAA0", VA = "0x18746EEA0")]
		public void MTGZPQDROWQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x746E660", Offset = "0x746D260", VA = "0x18746E660")]
		public void HYJJMCCAEEZ(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x746E580", Offset = "0x746D180", VA = "0x18746E580")]
		public void HYJJMCCAEEZ(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x746E4A0", Offset = "0x746D0A0", VA = "0x18746E4A0")]
		public void HYJJMCCAEEZ(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x746E4A0", Offset = "0x746D0A0", VA = "0x18746E4A0")]
		public void HYJJMCCAEEZ(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x746E4A0", Offset = "0x746D0A0", VA = "0x18746E4A0")]
		public void HYJJMCCAEEZ(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x746E580", Offset = "0x746D180", VA = "0x18746E580")]
		public void HYJJMCCAEEZ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x746E580", Offset = "0x746D180", VA = "0x18746E580")]
		public void HYJJMCCAEEZ(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x746E810", Offset = "0x746D410", VA = "0x18746E810")]
		public void HYJJMCCAEEZ(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x746E810", Offset = "0x746D410", VA = "0x18746E810")]
		public void HYJJMCCAEEZ(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x746E3C0", Offset = "0x746CFC0", VA = "0x18746E3C0")]
		public void HYJJMCCAEEZ(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x746E740", Offset = "0x746D340", VA = "0x18746E740")]
		public void HYJJMCCAEEZ(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x746EB40", Offset = "0x746D740", VA = "0x18746EB40")]
		public void MTGZPQDROWQ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x746EE90", Offset = "0x746DA90", VA = "0x18746EE90")]
		public void MTGZPQDROWQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x746EC10", Offset = "0x746D810", VA = "0x18746EC10")]
		public void MTGZPQDROWQ(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class EGRYITZYSNM
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class FPZCUARGQCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong HSLXDBEEAPE;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x4C71DA0", Offset = "0x4C709A0", VA = "0x184C71DA0")]
			static FPZCUARGQCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(FMWJLYAGKJD reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class SFIXOJGFGLR<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public EGRYITZYSNM BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a BSNDOBQPPJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> DJVFVAZRGVF;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SFIXOJGFGLR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5D05610", Offset = "0x5D04210", VA = "0x185D05610")]
			internal void GHXUEGPVVRK(FMWJLYAGKJD a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class CIBUFUKWHPB<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public EGRYITZYSNM BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a BSNDOBQPPJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> DJVFVAZRGVF;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public CIBUFUKWHPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3CD4E80", Offset = "0x3CD3A80", VA = "0x183CD4E80")]
			internal void GHXUEGPVVRK(FMWJLYAGKJD a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly XODEYBDGYJU MAIETWMGAQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> FOYQIKTSDQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly XRBXODWTPKN YZYTGBRAOHW;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x745A1B0", Offset = "0x7458DB0", VA = "0x18745A1B0")]
		public EGRYITZYSNM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x35A6360", Offset = "0x35A4F60", VA = "0x1835A6360", Slot = "4")]
		protected virtual ulong LWRDPTCPTMB<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x745A010", Offset = "0x7458C10", VA = "0x18745A010", Slot = "5")]
		protected virtual SubscribeDelegate DETXTAPPUPY(FMWJLYAGKJD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x35A63E0", Offset = "0x35A4FE0", VA = "0x1835A63E0", Slot = "6")]
		protected virtual void MMYFYWRNZDU<b>(XRBXODWTPKN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x745A130", Offset = "0x7458D30", VA = "0x18745A130")]
		public void KEGZJVLLWLR(FMWJLYAGKJD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x35A6460", Offset = "0x35A5060", VA = "0x1835A6460")]
		public void UOCKZOMHYDE<j>(XRBXODWTPKN a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x745A0E0", Offset = "0x7458CE0", VA = "0x18745A0E0")]
		public void HZPNMWGLGQX(FMWJLYAGKJD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x35A6670", Offset = "0x35A5270", VA = "0x1835A6670")]
		public void YLTDWXKQPQU<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x35A6670", Offset = "0x35A5270", VA = "0x1835A6670")]
		public void YLTDWXKQPQU<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7467510", Offset = "0x7466110", VA = "0x187467510")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x746B560", Offset = "0x746A160", VA = "0x18746B560")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class XODEYBDGYJU
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
		private abstract class LJBNMZUYAXE<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType XSYNALKQIRF;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x526F6A0", Offset = "0x526E2A0", VA = "0x18526F6A0", Slot = "4")]
			public virtual void NXLLWCOSNCZ(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void NDATHOWWGCP(a a, FMWJLYAGKJD b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void UOCKZOMHYDE(a a, XRBXODWTPKN b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void FXTPPQDBPRS(a a, FMWJLYAGKJD b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void VKLNMKWUJDZ(a a, XRBXODWTPKN b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void QRALLFAVBST(a a, FMWJLYAGKJD b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void GGGDOIPELEC(a a, XRBXODWTPKN b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			protected LJBNMZUYAXE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class TXACKDUPJLB<a, b> : LJBNMZUYAXE<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> TRYMKINRNFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> VDXGKJOEJMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> IOREBVRXXUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> EOKSOUZMWCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> GMDURANEHUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> PXWYRUQCDCA;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BBF0", Offset = "0x5E4A7F0", VA = "0x185E4BBF0", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BBF0", Offset = "0x5E4A7F0", VA = "0x185E4BBF0", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BCC0", Offset = "0x5E4A8C0", VA = "0x185E4BCC0", Slot = "9")]
			public override void QRALLFAVBST(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BCC0", Offset = "0x5E4A8C0", VA = "0x185E4BCC0", Slot = "10")]
			public override void GGGDOIPELEC(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BB20", Offset = "0x5E4A720", VA = "0x185E4BB20")]
			protected b[] DPSEZABZLGQ(a a, FMWJLYAGKJD b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BD90", Offset = "0x5E4A990", VA = "0x185E4BD90")]
			protected b[] LHQEGNGTLYL(a a, XRBXODWTPKN b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BDF0", Offset = "0x5E4A9F0", VA = "0x185E4BDF0", Slot = "4")]
			public override void NXLLWCOSNCZ(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C360", Offset = "0x5E4AF60", VA = "0x185E4C360")]
			protected TXACKDUPJLB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class IUVPKPEMRII<a, b> : TXACKDUPJLB<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void WDTVESQCHEV(FMWJLYAGKJD a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void DVNNVQLKRHW(XRBXODWTPKN a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x4FAE1F0", Offset = "0x4FACDF0", VA = "0x184FAE1F0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4FAE3D0", Offset = "0x4FACFD0", VA = "0x184FAE3D0", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4FADDE0", Offset = "0x4FAC9E0", VA = "0x184FADDE0", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4FAE490", Offset = "0x4FAD090", VA = "0x184FAE490", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x4FAE740", Offset = "0x4FAD340", VA = "0x184FAE740")]
			protected IUVPKPEMRII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class BXRNPJXEYFV<a> : TXACKDUPJLB<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x530E4F0", Offset = "0x530D0F0", VA = "0x18530E4F0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x530E540", Offset = "0x530D140", VA = "0x18530E540", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x6E61C10", Offset = "0x6E60810", VA = "0x186E61C10", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x52775E0", Offset = "0x52761E0", VA = "0x1852775E0", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public BXRNPJXEYFV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class ASDIIQYGEWM<a> : TXACKDUPJLB<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x530E4F0", Offset = "0x530D0F0", VA = "0x18530E4F0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x530E540", Offset = "0x530D140", VA = "0x18530E540", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x530E380", Offset = "0x530CF80", VA = "0x18530E380", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x52775E0", Offset = "0x52761E0", VA = "0x1852775E0", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public ASDIIQYGEWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class FOSTIDDVMII<a> : TXACKDUPJLB<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4005100", Offset = "0x4003D00", VA = "0x184005100", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4005150", Offset = "0x4003D50", VA = "0x184005150", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4C71210", Offset = "0x4C6FE10", VA = "0x184C71210", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4005290", Offset = "0x4003E90", VA = "0x184005290", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public FOSTIDDVMII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class DIEXJWMFZBZ<a> : TXACKDUPJLB<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4005100", Offset = "0x4003D00", VA = "0x184005100", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x4005150", Offset = "0x4003D50", VA = "0x184005150", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4004F90", Offset = "0x4003B90", VA = "0x184004F90", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4005290", Offset = "0x4003E90", VA = "0x184005290", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public DIEXJWMFZBZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class MKEQVURKCZQ<a> : TXACKDUPJLB<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5706320", Offset = "0x5704F20", VA = "0x185706320", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5706470", Offset = "0x5705070", VA = "0x185706470", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x57061B0", Offset = "0x5704DB0", VA = "0x1857061B0", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x57065B0", Offset = "0x57051B0", VA = "0x1857065B0", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public MKEQVURKCZQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class SGHODFYRXFZ<a> : TXACKDUPJLB<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5706320", Offset = "0x5704F20", VA = "0x185706320", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x5706470", Offset = "0x5705070", VA = "0x185706470", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x5D07530", Offset = "0x5D06130", VA = "0x185D07530", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x57065B0", Offset = "0x57051B0", VA = "0x1857065B0", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public SGHODFYRXFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class BGSJNYZDTSW<a> : TXACKDUPJLB<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5274CD0", Offset = "0x52738D0", VA = "0x185274CD0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x5274E20", Offset = "0x5273A20", VA = "0x185274E20", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D91C20", Offset = "0x6D90820", VA = "0x186D91C20", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC540", Offset = "0x3DCB140", VA = "0x183DCC540", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public BGSJNYZDTSW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class LMODFOQAONL<a> : TXACKDUPJLB<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5274CD0", Offset = "0x52738D0", VA = "0x185274CD0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5274E20", Offset = "0x5273A20", VA = "0x185274E20", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5274B60", Offset = "0x5273760", VA = "0x185274B60", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC540", Offset = "0x3DCB140", VA = "0x183DCC540", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public LMODFOQAONL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class LQPAMUXHJDC<a> : TXACKDUPJLB<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x5277350", Offset = "0x5275F50", VA = "0x185277350", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x52774A0", Offset = "0x52760A0", VA = "0x1852774A0", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x52771E0", Offset = "0x5275DE0", VA = "0x1852771E0", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x52775E0", Offset = "0x52761E0", VA = "0x1852775E0", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public LQPAMUXHJDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class VNADNGNNMXT<a> : TXACKDUPJLB<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x615A1A0", Offset = "0x6158DA0", VA = "0x18615A1A0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x615A310", Offset = "0x6158F10", VA = "0x18615A310", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x615A150", Offset = "0x6158D50", VA = "0x18615A150", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x57065B0", Offset = "0x57051B0", VA = "0x1857065B0", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public VNADNGNNMXT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class XMPOZGKNFOE<a> : TXACKDUPJLB<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC3B0", Offset = "0x3DCAFB0", VA = "0x183DCC3B0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC500", Offset = "0x3DCB100", VA = "0x183DCC500", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC240", Offset = "0x3DCAE40", VA = "0x183DCC240", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC540", Offset = "0x3DCB140", VA = "0x183DCC540", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DCC680", Offset = "0x3DCB280", VA = "0x183DCC680")]
			public XMPOZGKNFOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class RRVHLLRBDPG<a> : IUVPKPEMRII<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5ADCA70", Offset = "0x5ADB670", VA = "0x185ADCA70", Slot = "12")]
			protected override void DVNNVQLKRHW(XRBXODWTPKN a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5ADCAA0", Offset = "0x5ADB6A0", VA = "0x185ADCAA0", Slot = "11")]
			protected override void WDTVESQCHEV(FMWJLYAGKJD a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x59DCEB0", Offset = "0x59DBAB0", VA = "0x1859DCEB0")]
			public RRVHLLRBDPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class PNSUHSGAHBW<a> : IUVPKPEMRII<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x59DCE40", Offset = "0x59DBA40", VA = "0x1859DCE40", Slot = "12")]
			protected override void DVNNVQLKRHW(XRBXODWTPKN a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x59DCE70", Offset = "0x59DBA70", VA = "0x1859DCE70", Slot = "11")]
			protected override void WDTVESQCHEV(FMWJLYAGKJD a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x59DCEB0", Offset = "0x59DBAB0", VA = "0x1859DCEB0")]
			public PNSUHSGAHBW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class EVZMVYFTNXX<a> : TXACKDUPJLB<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int XUHNRWXQHQG;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x468EDC0", Offset = "0x468D9C0", VA = "0x18468EDC0")]
			public EVZMVYFTNXX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x468E960", Offset = "0x468D560", VA = "0x18468E960", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x468EAD0", Offset = "0x468D6D0", VA = "0x18468EAD0", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x468E900", Offset = "0x468D500", VA = "0x18468E900", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x468EC20", Offset = "0x468D820", VA = "0x18468EC20", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class OLMENIVDPVF<a> : LJBNMZUYAXE<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo BYKNUORMGUG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type EILGVYHMBPM;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x58C8F60", Offset = "0x58C7B60", VA = "0x1858C8F60")]
			public OLMENIVDPVF(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x58C8CC0", Offset = "0x58C78C0", VA = "0x1858C8CC0", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x58C8D60", Offset = "0x58C7960", VA = "0x1858C8D60", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x58C8B00", Offset = "0x58C7700", VA = "0x1858C8B00", Slot = "7")]
			public override void FXTPPQDBPRS(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x58C8B00", Offset = "0x58C7700", VA = "0x1858C8B00", Slot = "8")]
			public override void VKLNMKWUJDZ(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x58C8B50", Offset = "0x58C7750", VA = "0x1858C8B50", Slot = "9")]
			public override void QRALLFAVBST(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x58C8B50", Offset = "0x58C7750", VA = "0x1858C8B50", Slot = "10")]
			public override void GGGDOIPELEC(a a, XRBXODWTPKN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class KTLHQNSOWRO<a> : OLMENIVDPVF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x51966C0", Offset = "0x51952C0", VA = "0x1851966C0")]
			public KTLHQNSOWRO(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x5196460", Offset = "0x5195060", VA = "0x185196460", Slot = "5")]
			public override void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x5196620", Offset = "0x5195220", VA = "0x185196620", Slot = "6")]
			public override void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class QWAOQJBOZBY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static QWAOQJBOZBY<a> PGFSJHGESKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly LJBNMZUYAXE<a>[] IOCDIFTAMTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int LNYUDSSHUOG;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x5A7F980", Offset = "0x5A7E580", VA = "0x185A7F980")]
			public QWAOQJBOZBY(List<LJBNMZUYAXE<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5A7F690", Offset = "0x5A7E290", VA = "0x185A7F690")]
			public void UOCKZOMHYDE(a a, XRBXODWTPKN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x5A7F5E0", Offset = "0x5A7E1E0", VA = "0x185A7F5E0")]
			public void NDATHOWWGCP(a a, FMWJLYAGKJD b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class LPSFPDGHTEQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract LJBNMZUYAXE<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private XRBXODWTPKN AMXBRZTLDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int FVILCVWHMVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, LPSFPDGHTEQ> MYNZTIGEMAJ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x746E330", Offset = "0x746CF30", VA = "0x18746E330")]
		public XODEYBDGYJU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3BEEE40", Offset = "0x3BEDA40", VA = "0x183BEEE40")]
		private QWAOQJBOZBY<d> AKHUTXMBPYD<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFD40", Offset = "0x3BEE940", VA = "0x183BEFD40")]
		public void OGBNJYRINGK<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFC80", Offset = "0x3BEE880", VA = "0x183BEFC80")]
		public bool Deserialize<T>(FMWJLYAGKJD reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFC00", Offset = "0x3BEE800", VA = "0x183BEFC00")]
		public void DKWNNTIDYNZ<f>(XRBXODWTPKN a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class WUHAWHAHWVB
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime NJGLSAEUDTC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] UOURWOZMUTE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator TZOPDXAHLPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x746D6C0", Offset = "0x746C2C0", VA = "0x18746D6C0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int BGWQSVGDUBS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x746DB10", Offset = "0x746C710", VA = "0x18746DB10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x746D240", Offset = "0x746BE40", VA = "0x18746D240")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode PAYWYTKPJTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x746D050", Offset = "0x746BC50", VA = "0x18746D050")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x746CF50", Offset = "0x746BB50", VA = "0x18746CF50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int CSVRHOJYQCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x746D440", Offset = "0x746C040", VA = "0x18746D440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint HITLLJESRFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x746D4A0", Offset = "0x746C0A0", VA = "0x18746D4A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? PAODYCGLMWT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x746D470", Offset = "0x746C070", VA = "0x18746D470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? ZHHMFGIUKVS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x746D8B0", Offset = "0x746C4B0", VA = "0x18746D8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? IJJMPNEFANT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x746CF20", Offset = "0x746BB20", VA = "0x18746CF20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x746D6F0", Offset = "0x746C2F0", VA = "0x18746D6F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? YIWKRCCNBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC652D0", VA = "0x180C666D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xC667D0", Offset = "0xC653D0", VA = "0x180C667D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x746DF80", Offset = "0x746CB80", VA = "0x18746DF80")]
		public WUHAWHAHWVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x746E290", Offset = "0x746CE90", VA = "0x18746E290")]
		internal WUHAWHAHWVB(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x746D280", Offset = "0x746BE80", VA = "0x18746D280")]
		public static WUHAWHAHWVB HDUOQADTCYX(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x746DB40", Offset = "0x746C740", VA = "0x18746DB40")]
		internal void YBGJWDMAZCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x746D500", Offset = "0x746C100", VA = "0x18746D500")]
		private void OZYZUCNMRRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x746D8E0", Offset = "0x746C4E0", VA = "0x18746D8E0")]
		private DateTime? SRBWFWRYLGW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x746D080", Offset = "0x746BC80", VA = "0x18746D080")]
		private void CYREQMQTLTY(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x746D390", Offset = "0x746BF90", VA = "0x18746D390")]
		private ulong IPNSKLIPRZY(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x746CF90", Offset = "0x746BB90", VA = "0x18746CF90")]
		private void CKEFQKBHCXE(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x746DEC0", Offset = "0x746CAC0", VA = "0x18746DEC0")]
		private uint ZXPUCZZWMIZ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7326180", Offset = "0x7324D80", VA = "0x187326180")]
		private static uint TUEQTEPTDBW(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x746DAB0", Offset = "0x746C6B0", VA = "0x18746DAB0")]
		private static ulong TUEQTEPTDBW(ulong a)
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
	internal sealed class ILAGRTOHVZC
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int NRKTKVSMFSN = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int NPINLRTGAHG = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int GTGGRDWBPFF = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint OBESNPZRWHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int KKXBJSVABIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int FGZWTGCWONH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool AMUWSCYMNRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x745EE80", Offset = "0x745DA80", VA = "0x18745EE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x745EE90", Offset = "0x745DA90", VA = "0x18745EE90")]
		public bool ZWGXHKIVLWB(JHYUNJJVAOP a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class WKWZTTPPNES : JHYUNJJVAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket OQSFPCJJJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly IQJPIATCGNX GDZSPORYIQR;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short PGAEHGOADHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x746CE10", Offset = "0x746BA10", VA = "0x18746CE10", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int MMDLQODLIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x746CDF0", Offset = "0x746B9F0", VA = "0x18746CDF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint MBLKPWZLKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x746CCC0", Offset = "0x746B8C0", VA = "0x18746CCC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily HWFMXSUYEUB
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2FEE7E0", Offset = "0x2FED3E0", VA = "0x182FEE7E0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x746CE70", Offset = "0x746BA70", VA = "0x18746CE70")]
		public WKWZTTPPNES(AddressFamily a, IQJPIATCGNX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x746C700", Offset = "0x746B300", VA = "0x18746C700", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x746CE30", Offset = "0x746BA30", VA = "0x18746CE30", Slot = "9")]
		public int YKUQFONHYBO(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x746CD00", Offset = "0x746B900", VA = "0x18746CD00", Slot = "10")]
		public int IYAZURCHEPO(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x746CCE0", Offset = "0x746B8E0", VA = "0x18746CCE0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface JHYUNJJVAOP
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short PGAEHGOADHP
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int MMDLQODLIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint MBLKPWZLKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily HWFMXSUYEUB
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
		int YKUQFONHYBO(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int IYAZURCHEPO(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x746A540", Offset = "0x7469140", VA = "0x18746A540")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x746A5E0", Offset = "0x74691E0", VA = "0x18746A5E0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x131EB30", Offset = "0x131D730", VA = "0x18131EB30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x746A450", Offset = "0x7469050", VA = "0x18746A450", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x746A490", Offset = "0x7469090", VA = "0x18746A490", Slot = "0")]
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
	public class WCDEYMLCINI
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string LAUHLVLJKVQ = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int QXRXNDCUXQC = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int NDSVTGSMIDK = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int HTCJUCCJRDI = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> MYHZNWJMGLB;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback GSTDZTQZWJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int UYSEESZAAHE;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		internal void YQUTVZCWGEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		internal void EFYSJLYKRBG(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class TQJWHIIOPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int HCASYJWMQKC;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
		protected TQJWHIIOPDP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OUJWKICAFHD(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void WAAEVTBKKYQ(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class EEWGGAIBLEV : TQJWHIIOPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] QDRJQNEVYTI;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator YNCJMYHGUZC;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x28C9BC0", Offset = "0x28C87C0", VA = "0x1828C9BC0")]
		public EEWGGAIBLEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7459B00", Offset = "0x7458700", VA = "0x187459B00")]
		public void SWEIHBAZZZT(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7459A20", Offset = "0x7458620", VA = "0x187459A20")]
		public void RFGPXRHQJVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x74595D0", Offset = "0x74581D0", VA = "0x1874595D0", Slot = "4")]
		public override void OUJWKICAFHD(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7459CB0", Offset = "0x74588B0", VA = "0x187459CB0", Slot = "5")]
		public override void WAAEVTBKKYQ(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class TSUURMLPWXG
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr GXEUFVNUQAE;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x746F800", Offset = "0x746E400", VA = "0x18746F800")]
			[BurstDiscard]
			private static void WVBZLHLPRRW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x746F430", Offset = "0x746E030", VA = "0x18746F430")]
			private static IntPtr HEBIDOQEHSK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x746F5B0", Offset = "0x746E1B0", VA = "0x18746F5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x746BFC0", Offset = "0x746ABC0", VA = "0x18746BFC0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x746BE70", Offset = "0x746AA70", VA = "0x18746BE70")]
		private uint JKXHSUXKOMV(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7457D10", Offset = "0x7456910", VA = "0x187457D10")]
		private void WQOFJOWDSCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7457B00", Offset = "0x7456700", VA = "0x187457B00")]
		private void OXMDWCJBZWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7457DC0", Offset = "0x74569C0", VA = "0x187457DC0")]
		private void XVXJOCIKUAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7457A00", Offset = "0x7456600", VA = "0x187457A00")]
		private void AWUVRCOOPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x746BF60", Offset = "0x746AB60", VA = "0x18746BF60")]
		private void RGBJIOJDCZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x746C0B0", Offset = "0x746ACB0", VA = "0x18746C0B0")]
		private unsafe void UODBINUGSEF(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x746BEA0", Offset = "0x746AAA0", VA = "0x18746BEA0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void JXCNLNKWMXG([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x746BEB0", Offset = "0x746AAB0", VA = "0x18746BEB0")]
		public static void JXCNLNKWMXG(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x746C4D0", Offset = "0x746B0D0", VA = "0x18746C4D0")]
		public static void VIDOZZILYDC(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x746C040", Offset = "0x746AC40", VA = "0x18746C040")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void SNSKDCLFBRV([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x746F990", Offset = "0x746E590", VA = "0x18746F990")]
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
