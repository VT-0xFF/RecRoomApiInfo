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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, ZSTIEYOGZUS
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
		private NetworkManager KIUSGJHURWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool PFLEJDOJPXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, BUVKBUSBFLJ> ECYFANZDCNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ZGEWPXFQKRQ IKVHMQBTNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch HZODPLLMRIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] EBWJCJTDIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType YGKMHXWIXAG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int WSHOOZMJQAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x771A160", Offset = "0x7718760", VA = "0x18771A160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x771A110", Offset = "0x7718710", VA = "0x18771A110", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77194A0", Offset = "0x7717AA0", VA = "0x1877194A0")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7719480", Offset = "0x7717A80", VA = "0x187719480")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7719150", Offset = "0x7717750", VA = "0x187719150")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x771A020", Offset = "0x7718620", VA = "0x18771A020")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77195B0", Offset = "0x7717BB0", VA = "0x1877195B0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7719440", Offset = "0x7717A40", VA = "0x187719440", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7719880", Offset = "0x7717E80", VA = "0x187719880", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7719C10", Offset = "0x7718210", VA = "0x187719C10", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7718B50", Offset = "0x7717150", VA = "0x187718B50", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7718A60", Offset = "0x7717060", VA = "0x187718A60", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7718C60", Offset = "0x7717260", VA = "0x187718C60", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7719810", Offset = "0x7717E10", VA = "0x187719810", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7718D30", Offset = "0x7717330", VA = "0x187718D30", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7719E90", Offset = "0x7718490", VA = "0x187719E90")]
		private DeliveryMethod TZMDVANKYWD(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7719F60", Offset = "0x7718560", VA = "0x187719F60", Slot = "16")]
		private void UGIZACNUEPK(BUVKBUSBFLJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7719060", Offset = "0x7717660", VA = "0x187719060", Slot = "17")]
		private void NHBULNDELGS(BUVKBUSBFLJ a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "18")]
		private void DNGZULWLCHP(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7719240", Offset = "0x7717840", VA = "0x187719240", Slot = "19")]
		private void PFVQEUFVAFM(BUVKBUSBFLJ a, SVLDGHZZFTG b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7718F90", Offset = "0x7717590", VA = "0x187718F90")]
		private void LQENRHLOXLT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "20")]
		private void IZBGHXZHZFC(IPEndPoint a, SVLDGHZZFTG b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "21")]
		private void BPFQDIIQPOE(BUVKBUSBFLJ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7719E30", Offset = "0x7718430", VA = "0x187719E30", Slot = "22")]
		private void TMGJJEIWWWW(PRDIWZKCHJL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7718F40", Offset = "0x7717540", VA = "0x187718F40")]
		private ulong KNJVHUTNRWN(BUVKBUSBFLJ a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7718F70", Offset = "0x7717570", VA = "0x187718F70")]
		private ulong KNJVHUTNRWN(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7719130", Offset = "0x7717730", VA = "0x187719130")]
		private static int OAFNYXECLVU(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x771A040", Offset = "0x7718640", VA = "0x18771A040")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7718D00", Offset = "0x7717300", VA = "0x187718D00")]
		[CompilerGenerated]
		private void IPGPWZKAMUS(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7718D00", Offset = "0x7717300", VA = "0x187718D00")]
		[CompilerGenerated]
		private void PSVCUSNPTUL(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class FXBOSETULOU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly BUVKBUSBFLJ HXIKKTBMSUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<DKUQYQMXHVJ> HHJGXNFHSEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int ACWAKAMJXGY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PAZFFDTGAHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7717B20", Offset = "0x7716120", VA = "0x187717B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7717C90", Offset = "0x7716290", VA = "0x187717C90")]
		protected FXBOSETULOU(BUVKBUSBFLJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7717BF0", Offset = "0x77161F0", VA = "0x187717BF0")]
		public void GMWRHSCRAEB(DKUQYQMXHVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7717B70", Offset = "0x7716170", VA = "0x187717B70")]
		protected void BTMNOERHXBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7717C50", Offset = "0x7716250", VA = "0x187717C50")]
		public bool VDZJANBVWCI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool PWIJXESAMTO();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool UMQSCKWIUEZ(DKUQYQMXHVJ a);
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
	public class PRDIWZKCHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly ZGEWPXFQKRQ PJVQDHURBGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int PPJYJGHNQNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal KXVHABNSABG XRQSWMZXGZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint BDIGZHPKRSL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult JXQUNSAPXOR
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1658470", Offset = "0x1656A70", VA = "0x181658470")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1658460", Offset = "0x1656A60", VA = "0x181658460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x771C850", Offset = "0x771AE50", VA = "0x18771C850")]
		internal void CGYXDVZUAJU(KXVHABNSABG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x771C8B0", Offset = "0x771AEB0", VA = "0x18771C8B0")]
		private bool QPIANCUEWNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x771C8E0", Offset = "0x771AEE0", VA = "0x18771C8E0")]
		internal PRDIWZKCHJL(IPEndPoint a, KXVHABNSABG b, ZGEWPXFQKRQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x771C7F0", Offset = "0x771ADF0", VA = "0x18771C7F0")]
		public BUVKBUSBFLJ Accept()
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
		public SVLDGHZZFTG AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ZSTIEYOGZUS
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OAIEEIQXCUY(BUVKBUSBFLJ a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KORXDGJIGBY(BUVKBUSBFLJ a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SITXXNYVCMN(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NSQSJWQGDDM(BUVKBUSBFLJ a, SVLDGHZZFTG b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TYTAYESQJUU(IPEndPoint a, SVLDGHZZFTG b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HGMWCPQOZQI(BUVKBUSBFLJ a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WKWEOLEXDPA(PRDIWZKCHJL a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface DBIKUZMUJIZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LDNYJCVFHRC(BUVKBUSBFLJ a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CTIOZBNRYTH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GKFIFMQFIUK(NAVHEISXPDM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface NMQVXCHGMLR
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KQALUFKICOF(BUVKBUSBFLJ a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class KXVHABNSABG
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int REUODBAWBOE = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long TDLDZKOZKRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte TLMHPWHXAVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] QRMGDKULLUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly EOGZYNEQWUE EPIXYLBKGFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int MRUHVHEKODL;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x77189F0", Offset = "0x7716FF0", VA = "0x1877189F0")]
		private KXVHABNSABG(long a, byte b, int c, byte[] d, EOGZYNEQWUE e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x77189C0", Offset = "0x7716FC0", VA = "0x1877189C0")]
		public static int YIXJPHEJMFD(DKUQYQMXHVJ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77187D0", Offset = "0x7716DD0", VA = "0x1877187D0")]
		public static KXVHABNSABG BYGEDJQZJSA(DKUQYQMXHVJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77185F0", Offset = "0x7716BF0", VA = "0x1877185F0")]
		public static DKUQYQMXHVJ BESIDHYTVGK(TXEBGPMTMGQ a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class TPKKCBCDDLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long TDLDZKOZKRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte TLMHPWHXAVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int MRUHVHEKODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool HQQCYXUCQTY;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x771E9A0", Offset = "0x771CFA0", VA = "0x18771E9A0")]
		private TPKKCBCDDLF(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x771E7A0", Offset = "0x771CDA0", VA = "0x18771E7A0")]
		public static TPKKCBCDDLF BYGEDJQZJSA(DKUQYQMXHVJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x771E6B0", Offset = "0x771CCB0", VA = "0x18771E6B0")]
		public static DKUQYQMXHVJ BESIDHYTVGK(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x771E8A0", Offset = "0x771CEA0", VA = "0x18771E8A0")]
		public static DKUQYQMXHVJ HDYILVSLPJG(BUVKBUSBFLJ a)
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
	public interface HAXRLUBCHUO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IXTXYSPNDAB(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SVUVWQVRSHB(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class FLRCVSXIRVL
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
		private class IEZDJLNSJAF
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint BXHWHXUJKAZ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string XYYIWYZAGLX
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IEZDJLNSJAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class UYYSFCGNPTN
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint BXHWHXUJKAZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint QGACFWCZSWT
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string XYYIWYZAGLX
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UYYSFCGNPTN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class AVVXNXKVDWV
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string XYYIWYZAGLX
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool AQCZKERECDB
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAB3D10", Offset = "0xAB2310", VA = "0x180AB3D10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AVVXNXKVDWV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly ZGEWPXFQKRQ ZVMPFGJWWVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> VNPPKDXIMSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> CGMVNLHTXRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly EOGZYNEQWUE QGWDGVITIXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly TXEBGPMTMGQ MRWGKCLIKOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly JSXMGFFRLXX DXDQJIGVYYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HAXRLUBCHUO UKPKEHQLKBC;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int STITRJODISP = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool GGMPYVMOCRK;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7717730", Offset = "0x7715D30", VA = "0x187717730")]
		internal FLRCVSXIRVL(ZGEWPXFQKRQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77172C0", Offset = "0x77158C0", VA = "0x1877172C0")]
		internal void QOCREAOXAWQ(IPEndPoint a, DKUQYQMXHVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x38C5760", Offset = "0x38C3D60", VA = "0x1838C5760")]
		private void GKAAXDZSDXE<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7717140", Offset = "0x7715740", VA = "0x187717140")]
		private void IXTXYSPNDAB(IEZDJLNSJAF a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77175D0", Offset = "0x7715BD0", VA = "0x1877175D0")]
		private void XNLVFLXCMED(UYYSFCGNPTN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7717440", Offset = "0x7715A40", VA = "0x187717440")]
		private void XBNATZEAUYI(AVVXNXKVDWV a, IPEndPoint b)
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
	public static class YJQBRMJVZAQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] BKFIFGKERGB;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int WPGPKRXIGBN;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int CMYUMBQQCYS;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7717D20", Offset = "0x7716320", VA = "0x187717D20")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7717D20", Offset = "0x7716320", VA = "0x187717D20")]
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
	public interface GQAORUCCOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LOZHJBQURXQ(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class OEYVTDFAQLM
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static GQAORUCCOOG HYODHPLVJJW;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object MQLQADQOSYA;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x771C420", Offset = "0x771AA20", VA = "0x18771C420")]
		private static void JLSYAYYEANJ(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x771C650", Offset = "0x771AC50", VA = "0x18771C650")]
		internal static void RXZOFVXIIDJ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x771C3C0", Offset = "0x771A9C0", VA = "0x18771C3C0")]
		internal static void FWKYPJPHDKZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x771C360", Offset = "0x771A960", VA = "0x18771C360")]
		internal static void EDCZMJGNILJ(string a, params object[] args)
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
	public sealed class SVLDGHZZFTG : EOGZYNEQWUE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DKUQYQMXHVJ JVEVDCXQNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly ZGEWPXFQKRQ BBMPVGPISTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly ZEYKAJTSDDH XCQCHSIPEJA;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x771E660", Offset = "0x771CC60", VA = "0x18771E660")]
		internal SVLDGHZZFTG(ZGEWPXFQKRQ a, ZEYKAJTSDDH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x771E5F0", Offset = "0x771CBF0", VA = "0x18771E5F0")]
		internal void YFEEYLRGWXP(DKUQYQMXHVJ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x771E540", Offset = "0x771CB40", VA = "0x18771E540")]
		internal void GEKUGNFEFRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x771E5C0", Offset = "0x771CBC0", VA = "0x18771E5C0")]
		public void OTOHNFUKMLH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class ZEYKAJTSDDH
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
		public ZEYKAJTSDDH WEELCONHWNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType BTZTINVWBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public BUVKBUSBFLJ HXIKKTBMSUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint BDIGZHPKRSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object CQONINSUMTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int BWYTSNYROQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError WOGDPUAUUFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason NIEKVBAVBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PRDIWZKCHJL PRDIWZKCHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod KEPCSQHNJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte KBRATJJTJXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly SVLDGHZZFTG MADUDDVXGOH;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7720BA0", Offset = "0x771F1A0", VA = "0x187720BA0")]
		public ZEYKAJTSDDH(ZGEWPXFQKRQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ZGEWPXFQKRQ : IEnumerable<BUVKBUSBFLJ>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class PHDKYMRECGD : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x771C750", Offset = "0x771AD50", VA = "0x18771C750", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x771C7C0", Offset = "0x771ADC0", VA = "0x18771C7C0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PHDKYMRECGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<BUVKBUSBFLJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly BUVKBUSBFLJ _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private BUVKBUSBFLJ _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public BUVKBUSBFLJ Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xBBDF80", Offset = "0xBBC580", VA = "0x180BBDF80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xBBDF80", Offset = "0xBBC580", VA = "0x180BBDF80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D77250", Offset = "0x1D75850", VA = "0x181D77250")]
			public NetPeerEnumerator(BUVKBUSBFLJ p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x771C2D0", Offset = "0x771A8D0", VA = "0x18771C2D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x771C320", Offset = "0x771A920", VA = "0x18771C320", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread YGRIRPKICXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool MJJSFXNQJRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool ZWXEOEENETX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private WUNHVHOZOQT XFTSCBDJTOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent SUUQSBXTJIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<ZEYKAJTSDDH> MJEGQWHNPQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<ZEYKAJTSDDH> LJIZEZJLTQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private ZEYKAJTSDDH FWLCXMREFQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly ZSTIEYOGZUS CUNYDLTKESE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly DBIKUZMUJIZ ZLRTKKSVMSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CTIOZBNRYTH QJYVNOINYGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly NMQVXCHGMLR IULTAUXWHQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, BUVKBUSBFLJ> SCKWHTORABQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, PRDIWZKCHJL> QCJNRJEDCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, XFSFQSQUYGP> NQQWFAJOXSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim CSQFQZJOERP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private BUVKBUSBFLJ SOHYAKXDXSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int WKMOIUJPZOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<BUVKBUSBFLJ> OJFDKEVUVDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private BUVKBUSBFLJ[] PLCNXSIQNWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly VGSFUBFCWZG KYMNRXQULJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int CNBNNMAETKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> PFYHMNXYGGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte CKUDRAAQVXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object IBWDNRNHCTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool CGNGPYVYYJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool IUWBTOCPJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int AYJOIRHOZSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int KXEVDOCMLGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int WFVWNUVOVBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int ESFYNTHSAAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool FHFMKGRCUJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool CHKLTZPIZEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int HFZFTYAUFSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int DHCDHDSUETP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int LEZXLLUXLVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool GGMPYVMOCRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool DRFIKXMEWOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool MBNNARRDFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool EVXBYYGQWLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int AWLMWMKAREM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int GAOCCWLKCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool TZHUEQFERAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly PWEYPLJAYEQ LTTPQKRHLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool GOHVJKPBWQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly FLRCVSXIRVL FLRCVSXIRVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool LXXUDTTXFPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode BEHVOMYRRIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int BNGRDNZELAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool LERITTBBUTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool TFNLSBBVMGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool SCKKCSXUDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool TYKWYIGDZMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private DKUQYQMXHVJ IGRVTZHDGVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int XTOJHLCTMSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object RWCKJCBXVBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DKUQYQMXHVJ NXJTMJTBFDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int SJNKIXZPRWB;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int ENWFWJTSLJZ = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int GJTFZNIXFNC = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private FVUNALBMBWC ECQVKZMYXHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private FVUNALBMBWC EDBJFNATQEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread UKJTGIRYWJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread UKUHAWFTPFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint RIZTXWSVQPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint RJKHSKGQJLY;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] LPJWXVOZKSA;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] ABNQRBHWUXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> YVWQOTWDGJL;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress YRQWDBVVSHE;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool BYFWLZLPYTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int QJLAGFJQOXU;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool JTZCOCTIYXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBCC670", Offset = "0xBCAC70", VA = "0x180BCC670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCC6EF0", Offset = "0xCC54F0", VA = "0x180CC6EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int NXFPDLJXGWA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB98010", Offset = "0xB96610", VA = "0x180B98010")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x22E0050", Offset = "0x22DE650", VA = "0x1822E0050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte DAGUBVNXKWT
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE7C8E0", Offset = "0xE7AEE0", VA = "0x180E7C8E0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int KKMOJQFMZJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7722680", Offset = "0x7720C80", VA = "0x187722680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short DQLCXNXQOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7723ED0", Offset = "0x77224D0", VA = "0x187723ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BUVKBUSBFLJ.OnUpdatedMtuDelegate ACWGDVPBPBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7720DE0", Offset = "0x771F3E0", VA = "0x187720DE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7724A70", Offset = "0x7723070", VA = "0x187724A70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7727D90", Offset = "0x7726390", VA = "0x187727D90")]
		public void YMDHJEOOOQS(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7723F90", Offset = "0x7722590", VA = "0x187723F90")]
		public void JGIREXPIOMX(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x77225E0", Offset = "0x7720BE0", VA = "0x1877225E0")]
		private bool EUOKWXQXLEH(IPEndPoint a, [Out] BUVKBUSBFLJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7727910", Offset = "0x7725F10", VA = "0x187727910")]
		private void VZSGFBJEOAD(BUVKBUSBFLJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7726290", Offset = "0x7724890", VA = "0x187726290")]
		private void OHFWNMVEDHC(BUVKBUSBFLJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7721B60", Offset = "0x7720160", VA = "0x187721B60")]
		private void DRFZFCUTMYF(BUVKBUSBFLJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7728430", Offset = "0x7726A30", VA = "0x187728430")]
		public ZGEWPXFQKRQ(ZSTIEYOGZUS a, [Optional] VGSFUBFCWZG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x77282E0", Offset = "0x77268E0", VA = "0x1877282E0")]
		internal void YPYVYRGHNZX(BUVKBUSBFLJ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x77243E0", Offset = "0x77229E0", VA = "0x1877243E0")]
		internal void LNRUUTIRUND(BUVKBUSBFLJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7728330", Offset = "0x7726930", VA = "0x187728330")]
		internal void ZUVBJKPUIDL(BUVKBUSBFLJ a, DisconnectReason b, SocketError c, DKUQYQMXHVJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x77227C0", Offset = "0x7720DC0", VA = "0x1877227C0")]
		private void GJXERQLSBYO(BUVKBUSBFLJ a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, DKUQYQMXHVJ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7721790", Offset = "0x771FD90", VA = "0x187721790")]
		private void DGZDECMIOMU(ZEYKAJTSDDH.EType a, [Optional] BUVKBUSBFLJ b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] PRDIWZKCHJL g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] DKUQYQMXHVJ j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7721E20", Offset = "0x7720420", VA = "0x187721E20")]
		private void EFDVNTPAGXB(ZEYKAJTSDDH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x77262F0", Offset = "0x77248F0", VA = "0x1877262F0")]
		internal void RFSESCBKEBV(ZEYKAJTSDDH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7723B70", Offset = "0x7722170", VA = "0x187723B70")]
		private void IMZELTCPKYF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7727FB0", Offset = "0x77265B0", VA = "0x187727FB0")]
		private void YNNHKXIISYT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x77272C0", Offset = "0x77258C0", VA = "0x1877272C0")]
		internal BUVKBUSBFLJ UCTNXNLFMJS(PRDIWZKCHJL a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x77226A0", Offset = "0x7720CA0", VA = "0x1877226A0")]
		private int FPYOYIJIVWE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7722EC0", Offset = "0x77214C0", VA = "0x187722EC0")]
		private void HAPEBKMGMUW(IPEndPoint a, BUVKBUSBFLJ b, KXVHABNSABG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7724C80", Offset = "0x7723280", VA = "0x187724C80")]
		private void MYLSJOYSGLN(DKUQYQMXHVJ a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7722BF0", Offset = "0x77211F0", VA = "0x187722BF0")]
		internal void GKLISRUKHLR(DKUQYQMXHVJ a, DeliveryMethod b, byte c, int d, BUVKBUSBFLJ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7726CA0", Offset = "0x77252A0", VA = "0x187726CA0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7726490", Offset = "0x7724A90", VA = "0x187726490")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x77264B0", Offset = "0x7724AB0", VA = "0x1877264B0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7721050", Offset = "0x771F650", VA = "0x187721050")]
		public void CQUWOGPNOGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x77215D0", Offset = "0x771FBD0", VA = "0x1877215D0")]
		public BUVKBUSBFLJ Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x77216B0", Offset = "0x771FCB0", VA = "0x1877216B0")]
		public BUVKBUSBFLJ Connect(string address, int port, TXEBGPMTMGQ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7721200", Offset = "0x771F800", VA = "0x187721200")]
		public BUVKBUSBFLJ Connect(IPEndPoint target, TXEBGPMTMGQ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7727070", Offset = "0x7725670", VA = "0x187727070")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7726D10", Offset = "0x7725310", VA = "0x187726D10")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77240E0", Offset = "0x77226E0", VA = "0x1877240E0")]
		public void KYMKEYTTDXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7724190", Offset = "0x7722790", VA = "0x187724190")]
		public void KYMKEYTTDXP(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7722780", Offset = "0x7720D80", VA = "0x187722780")]
		public void GJXERQLSBYO(BUVKBUSBFLJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7722BB0", Offset = "0x77211B0", VA = "0x187722BB0")]
		public void GJXERQLSBYO(BUVKBUSBFLJ a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7726400", Offset = "0x7724A00", VA = "0x187726400", Slot = "4")]
		private IEnumerator<BUVKBUSBFLJ> SSVPPSXDVCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7725FA0", Offset = "0x77245A0", VA = "0x187725FA0", Slot = "5")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7720E90", Offset = "0x771F490", VA = "0x187720E90")]
		private DKUQYQMXHVJ CEDKEOVOVQX(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7720F70", Offset = "0x771F570", VA = "0x187720F70")]
		private DKUQYQMXHVJ CEDKEOVOVQX(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7727080", Offset = "0x7725680", VA = "0x187727080")]
		internal DKUQYQMXHVJ TBHYGPMFZBE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7726030", Offset = "0x7724630", VA = "0x187726030")]
		internal void NUDBKUUSRDB(DKUQYQMXHVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7728370", Offset = "0x7726970", VA = "0x187728370")]
		static ZGEWPXFQKRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBCC670", Offset = "0xBCAC70", VA = "0x180BCC670")]
		private bool VZYMOQWIBMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7724B20", Offset = "0x7723120", VA = "0x187724B20")]
		private void MRXJFRNTAOE(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7727C40", Offset = "0x7726240", VA = "0x187727C40")]
		private void XRSMYJYWCHF(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7720C40", Offset = "0x771F240", VA = "0x187720C40")]
		private bool AWGRONFUTFT(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x77278F0", Offset = "0x7725EF0", VA = "0x1877278F0")]
		private void USGHQWYSQVQ(WUNHVHOZOQT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x77247B0", Offset = "0x7722DB0", VA = "0x1877247B0")]
		private void MQPMXAIXNXB(FVUNALBMBWC a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7724430", Offset = "0x7722A30", VA = "0x187724430")]
		private void LRUVFBCMHEN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7726530", Offset = "0x7724B30", VA = "0x187726530")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7722720", Offset = "0x7720D20", VA = "0x187722720")]
		internal int FRSZHBKBHJE(DKUQYQMXHVJ a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7723B30", Offset = "0x7722130", VA = "0x187723B30")]
		internal int HLTARZEYMOU(DKUQYQMXHVJ a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7723360", Offset = "0x7721960", VA = "0x187723360")]
		internal int HLTARZEYMOU(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7724260", Offset = "0x7722860", VA = "0x187724260")]
		internal void LKHKFLNBNMJ(bool a)
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
	internal sealed class DKUQYQMXHVJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int KCAWXOXFRTC;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] BLTBPJDDZFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] OEAJTPZCDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int THKGQWWYIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object CQONINSUMTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DKUQYQMXHVJ WEELCONHWNH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty YWXLDIBZMSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7715BF0", Offset = "0x77141F0", VA = "0x187715BF0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7715700", Offset = "0x7713D00", VA = "0x187715700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte TLMHPWHXAVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x77159A0", Offset = "0x7713FA0", VA = "0x1877159A0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7715740", Offset = "0x7713D40", VA = "0x187715740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort XYOFWRYLUSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7715880", Offset = "0x7713E80", VA = "0x187715880")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7715A80", Offset = "0x7714080", VA = "0x187715A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool BBOFUUJPSZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7715B20", Offset = "0x7714120", VA = "0x187715B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte BIXRCCAGJZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7715AC0", Offset = "0x77140C0", VA = "0x187715AC0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7715AF0", Offset = "0x77140F0", VA = "0x187715AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort SFRCZQUSLQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7715BD0", Offset = "0x77141D0", VA = "0x187715BD0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7715B70", Offset = "0x7714170", VA = "0x187715B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort IQEYOQWMAWB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7715BB0", Offset = "0x77141B0", VA = "0x187715BB0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7715A40", Offset = "0x7714040", VA = "0x187715A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort FZHCBODJKLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7715B50", Offset = "0x7714150", VA = "0x187715B50")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x77159D0", Offset = "0x7713FD0", VA = "0x1877159D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7715C20", Offset = "0x7714220", VA = "0x187715C20")]
		static DKUQYQMXHVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7715A10", Offset = "0x7714010", VA = "0x187715A10")]
		public void KTEXHMXOZWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7715FE0", Offset = "0x77145E0", VA = "0x187715FE0")]
		public DKUQYQMXHVJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7715ED0", Offset = "0x77144D0", VA = "0x187715ED0")]
		public DKUQYQMXHVJ(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7715810", Offset = "0x7713E10", VA = "0x187715810")]
		public static int EJZUZZKMGRO(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7715780", Offset = "0x7713D80", VA = "0x187715780")]
		public int EJZUZZKMGRO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x77158A0", Offset = "0x7713EA0", VA = "0x1877158A0")]
		public bool HRKRGJXOPIZ()
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
	public class BUVKBUSBFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class YLJCOEYDAUN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public DKUQYQMXHVJ[] RAMEQGMBTGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int LKBLEIINONA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int NHMPPEESBIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte BIXRCCAGJZQ;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public YLJCOEYDAUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int MPPYBRJSXMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int BKVDPRJKPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int TXLBWCOZYNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double BMGBREOGUBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int URHVZCRUGTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int SRELCKATQWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int EOQFKLFITYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch EUYCOBZGZIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int TKGCMJIUVCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long CDXDYDVHZOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object BGNPSFFQPQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal BUVKBUSBFLJ WXNOVWUGODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal BUVKBUSBFLJ BVCNMODPFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<DKUQYQMXHVJ> GJFTREVEAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<FXBOSETULOU> BJVATVVXACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly FXBOSETULOU[] KBPFJYCRPRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int PGQICZZEMRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int HSDAGXJLBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool DOOWPMTXNMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int EQPAUNFIPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int IZIIRJTKDJB;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int PNDJQJPCQBZ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int DUEMWXSDMZG = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object GHCPMYZXSQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int YKLOLTBAIHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, YLJCOEYDAUN> ALKUMYKVWRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> LCHARFGXIWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly DKUQYQMXHVJ KOTDEDVPJTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int KPAFGTFHRQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int DPGIMZDNUKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint POXLBRUYDPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int FVGENHZCMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int VYLUONALJJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long QONFMLPPJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte ASMJWKAFEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState OTCRYQDGQJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DKUQYQMXHVJ UNRJNGDHSNV;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int PUOGOUHDMHH = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int SUANJOIMATS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly DKUQYQMXHVJ WQZOIXCBDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly DKUQYQMXHVJ EWIDDLWEVEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly DKUQYQMXHVJ WMJYDHWLMWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly DKUQYQMXHVJ BDTYAHUEPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality MVJEDGBPNPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly ZGEWPXFQKRQ ZGEWPXFQKRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int SNTOXKRGJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object PHKXKWQIFRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly PWEYPLJAYEQ LTTPQKRHLOT;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte KNYBMBBVHMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAD3630", Offset = "0xAD1C30", VA = "0x180AD3630")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7714A20", Offset = "0x7713020", VA = "0x187714A20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint HUNJJINWUEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBD1670", Offset = "0xBCFC70", VA = "0x180BD1670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState IIBMVDKNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xBD1300", Offset = "0xBCF900", VA = "0x180BD1300")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long KTSJNFGGLOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E90", Offset = "0xAA8490", VA = "0x180AA9E90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int EADRIHADGNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xB98010", Offset = "0xB96610", VA = "0x180B98010")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x22E0050", Offset = "0x22DE650", VA = "0x1822E0050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int NPHMGURULWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7713300", Offset = "0x7711900", VA = "0x187713300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int SCTXYDGKXCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC4500", Offset = "0xAC2B00", VA = "0x180AC4500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double QKPHUIWTYHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2A53FF0", Offset = "0x2A525F0", VA = "0x182A53FF0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate ACWGDVPBPBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7711610", Offset = "0x770FC10", VA = "0x187711610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7712CA0", Offset = "0x77112A0", VA = "0x187712CA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7715120", Offset = "0x7713720", VA = "0x187715120")]
		internal BUVKBUSBFLJ(ZGEWPXFQKRQ a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x77115F0", Offset = "0x770FBF0", VA = "0x1877115F0")]
		internal void ADWCLHKXFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7712EA0", Offset = "0x77114A0", VA = "0x187712EA0")]
		internal void QDAZRSCNNIC(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7714D00", Offset = "0x7713300", VA = "0x187714D00")]
		internal void ZUPJPQACEDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7713230", Offset = "0x7711830", VA = "0x187713230")]
		private void TNPUSACWQIM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x77123C0", Offset = "0x77109C0", VA = "0x1877123C0")]
		private void KGMWHGIQDLS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7711700", Offset = "0x770FD00", VA = "0x187711700")]
		public int DKYKOHASRCG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7711810", Offset = "0x770FE10", VA = "0x187711810")]
		public int DKYKOHASRCG(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7714B70", Offset = "0x7713170", VA = "0x187714B70")]
		private FXBOSETULOU ZRCPSCDSBVJ(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7714F90", Offset = "0x7713590", VA = "0x187714F90")]
		internal BUVKBUSBFLJ(ZGEWPXFQKRQ a, IPEndPoint b, int c, byte d, TXEBGPMTMGQ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7715520", Offset = "0x7713B20", VA = "0x187715520")]
		internal BUVKBUSBFLJ(ZGEWPXFQKRQ a, PRDIWZKCHJL b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7712ED0", Offset = "0x77114D0", VA = "0x187712ED0")]
		internal void Reject(KXVHABNSABG requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7714410", Offset = "0x7712A10", VA = "0x187714410")]
		internal bool WDRLAXMNPIJ(TPKKCBCDDLF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x77121D0", Offset = "0x77107D0", VA = "0x1877121D0")]
		public void GKAAXDZSDXE(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7711930", Offset = "0x770FF30", VA = "0x187711930")]
		private void DNEICRUQNWL(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7711F20", Offset = "0x7710520", VA = "0x187711F20")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7714AD0", Offset = "0x77130D0", VA = "0x187714AD0")]
		internal DisconnectResult ZKHKTUORPBN(DKUQYQMXHVJ a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x77149C0", Offset = "0x7712FC0", VA = "0x1877149C0")]
		internal void XYQROGSWPNW(FXBOSETULOU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7712F20", Offset = "0x7711520", VA = "0x187712F20")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x77116C0", Offset = "0x770FCC0", VA = "0x1877116C0")]
		private void COHKQIRNMBP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7712400", Offset = "0x7710A00", VA = "0x187712400")]
		internal void LKMPJMCCHPL(DeliveryMethod a, DKUQYQMXHVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7714490", Offset = "0x7712A90", VA = "0x187714490")]
		private void XUYMLYPAMQP(DKUQYQMXHVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x77139B0", Offset = "0x7711FB0", VA = "0x1877139B0")]
		private void UZCPBVFFZVN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7712200", Offset = "0x7710800", VA = "0x187712200")]
		internal ConnectRequestResult HAPEBKMGMUW(KXVHABNSABG a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7713310", Offset = "0x7711910", VA = "0x187713310")]
		internal void UMQSCKWIUEZ(DKUQYQMXHVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7712D50", Offset = "0x7711350", VA = "0x187712D50")]
		private void OGZBEACHPZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7714D90", Offset = "0x7713390", VA = "0x187714D90")]
		internal void ZZVFZYVTLYF(DKUQYQMXHVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7713D40", Offset = "0x7712340", VA = "0x187713D40")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7711F70", Offset = "0x7710570", VA = "0x187711F70")]
		internal void FCSNQUNCYFZ(DKUQYQMXHVJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class PWEYPLJAYEQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long BUNOZVWRHZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long SAXNVGQYSTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long CWNECOMIHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long HGWOVAHWILZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long NUMTASRSXJQ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long LTJRQQOJPYV;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long CHZZVDBAFBS;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long GYIEIYGRCLR;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long VFCNGRXTVPQ;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long JTCIQPEDZRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long KJIMHIFWPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long QCCPRTGTWEG;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long KMYOOJIOBZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x771CAA0", Offset = "0x771B0A0", VA = "0x18771CAA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long LGYJVTLDMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x771D080", Offset = "0x771B680", VA = "0x18771D080")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long TMVVDTUBSOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x771C9B0", Offset = "0x771AFB0", VA = "0x18771C9B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long YWWSSQRDZTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x771CA20", Offset = "0x771B020", VA = "0x18771CA20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long JPHTJUMQYMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x771CCA0", Offset = "0x771B2A0", VA = "0x18771CCA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long JTPVOWXTBGV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x771CCF0", Offset = "0x771B2F0", VA = "0x18771CCF0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long ENAIQSHRNOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x771CC00", Offset = "0x771B200", VA = "0x18771CC00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long QHOMQQTPJND
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x771D040", Offset = "0x771B640", VA = "0x18771D040")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality ZSVTUCMRNRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x145E270", Offset = "0x145C870", VA = "0x18145E270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double ZWYLAHJRTMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x771C9C0", Offset = "0x771AFC0", VA = "0x18771C9C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x771CCB0", Offset = "0x771B2B0", VA = "0x18771CCB0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x771C950", Offset = "0x771AF50", VA = "0x18771C950")]
		public void ABQNZBWDFMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x771CBB0", Offset = "0x771B1B0", VA = "0x18771CBB0")]
		public void JMMTHBTYLLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x771CB50", Offset = "0x771B150", VA = "0x18771CB50")]
		public void IJSMZCGTYRS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x771D090", Offset = "0x771B690", VA = "0x18771D090")]
		public void YCZUXRUIFYJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x771CC40", Offset = "0x771B240", VA = "0x18771CC40")]
		public void NAIQNKCCYCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x771CA30", Offset = "0x771B030", VA = "0x18771CA30")]
		public void FMJUBJDYENG(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x771CD00", Offset = "0x771B300", VA = "0x18771CD00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x771CAB0", Offset = "0x771B0B0", VA = "0x18771CAB0")]
		public void IEMLZPQVMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PWEYPLJAYEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class JPJKDEJBHMA
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> ZCJHPRLFODH;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7717D30", Offset = "0x7716330", VA = "0x187717D30")]
		public static IPEndPoint IKZYYVHXWTJ(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7717F70", Offset = "0x7716570", VA = "0x187717F70")]
		public static IPAddress MBPSXQDOHBO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7718130", Offset = "0x7716730", VA = "0x187718130")]
		public static IPAddress MBPSXQDOHBO(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77181C0", Offset = "0x77167C0", VA = "0x1877181C0")]
		internal static int TATJFJIHUTS(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x39814E0", Offset = "0x397FAE0", VA = "0x1839814E0")]
		internal static T[] HJWHYITXLSV<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class TYUIXVQZUBH : FXBOSETULOU
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private DKUQYQMXHVJ _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x771D230", Offset = "0x771B830", VA = "0x18771D230", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x771D210", Offset = "0x771B810", VA = "0x18771D210")]
			public void FTYJJGFKYMC(DKUQYQMXHVJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x771D150", Offset = "0x771B750", VA = "0x18771D150")]
			public bool BCFLTXNRQKH(long a, BUVKBUSBFLJ b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x771D1C0", Offset = "0x771B7C0", VA = "0x18771D1C0")]
			public bool Clear(BUVKBUSBFLJ peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly DKUQYQMXHVJ ZPWNPFLIUPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] VNBMNNCSEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly DKUQYQMXHVJ[] XTVMRMRWONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] DLXLYKXNZTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int LMZOZTNRMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int PGIGXHYENHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int XEXEDYNDJZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int HGIOJPHHCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool LFZTDKJJLRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod WVTBFHLQOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool QATJXYTHQOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int NSBHBWDSQKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte XDSVBXEIPLW;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int RIMVQYJVMLN
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x771F830", Offset = "0x771DE30", VA = "0x18771F830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7720690", Offset = "0x771EC90", VA = "0x187720690")]
		public TYUIXVQZUBH(BUVKBUSBFLJ a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x771F840", Offset = "0x771DE40", VA = "0x18771F840")]
		private void OMBSBDXSDXA(DKUQYQMXHVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x771FBC0", Offset = "0x771E1C0", VA = "0x18771FBC0", Slot = "4")]
		protected override bool PWIJXESAMTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7720090", Offset = "0x771E690", VA = "0x187720090", Slot = "5")]
		public override bool UMQSCKWIUEZ(DKUQYQMXHVJ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class EKSJBLABJWC : FXBOSETULOU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int ZXIILZSIPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort PGIGXHYENHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool KIAKTJZNIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private DKUQYQMXHVJ ISFLKBOKCJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly DKUQYQMXHVJ UIUMOPPAESW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool IQPNTUSXVJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte XDSVBXEIPLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long RNMONGOVEPQ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7716790", Offset = "0x7714D90", VA = "0x187716790")]
		public EKSJBLABJWC(BUVKBUSBFLJ a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7716050", Offset = "0x7714650", VA = "0x187716050", Slot = "4")]
		protected override bool PWIJXESAMTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7716510", Offset = "0x7714B10", VA = "0x187716510", Slot = "5")]
		public override bool UMQSCKWIUEZ(DKUQYQMXHVJ a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class QJKYJXWKVEX
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
		[Cpp2IlInjected.Address(RVA = "0x7711010", Offset = "0x770F610", VA = "0x187711010")]
		private static void TABLXCVXUYY(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x771D310", Offset = "0x771B910", VA = "0x18771D310")]
		private static void TABLXCVXUYY(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x771D2D0", Offset = "0x771B8D0", VA = "0x18771D2D0")]
		public static void TABLXCVXUYY(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x771D2B0", Offset = "0x771B8B0", VA = "0x18771D2B0")]
		public static void GPCRVCUOFAT(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x771D380", Offset = "0x771B980", VA = "0x18771D380")]
		public static void GPCRVCUOFAT(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x771D2D0", Offset = "0x771B8D0", VA = "0x18771D2D0")]
		public static void GPCRVCUOFAT(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x771D2D0", Offset = "0x771B8D0", VA = "0x18771D2D0")]
		public static void GPCRVCUOFAT(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x771D310", Offset = "0x771B910", VA = "0x18771D310")]
		public static void GPCRVCUOFAT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x771D310", Offset = "0x771B910", VA = "0x18771D310")]
		public static void GPCRVCUOFAT(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x771D2A0", Offset = "0x771B8A0", VA = "0x18771D2A0")]
		public static void GPCRVCUOFAT(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x771D2A0", Offset = "0x771B8A0", VA = "0x18771D2A0")]
		public static void GPCRVCUOFAT(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class EOGZYNEQWUE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] WKRMYUPJBSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int FCRDTWOAPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int JYVONYBBOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int HAUCUMANSBQ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] OEAJTPZCDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DAJHQGUTCRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int PVEZNQTDZAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7716C90", Offset = "0x7715290", VA = "0x187716C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KAYQLNNXQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x29ACC60", Offset = "0x29AB260", VA = "0x1829ACC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int FGDHVJGALMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7716D80", Offset = "0x7715380", VA = "0x187716D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7717030", Offset = "0x7715630", VA = "0x187717030")]
		public void YFEEYLRGWXP(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public EOGZYNEQWUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x77170E0", Offset = "0x77156E0", VA = "0x1877170E0")]
		public EOGZYNEQWUE(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7716BC0", Offset = "0x77151C0", VA = "0x187716BC0")]
		public IPEndPoint FIFEXAQWOUS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7716CA0", Offset = "0x77152A0", VA = "0x187716CA0")]
		public byte WYIZEWZOVBQ()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7716CA0", Offset = "0x77152A0", VA = "0x187716CA0")]
		public sbyte IINFVCQMXZZ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x37F2940", Offset = "0x37F0F40", VA = "0x1837F2940")]
		public a[] XCZRPWDYBSB<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7716B40", Offset = "0x7715140", VA = "0x187716B40")]
		public bool[] ERFSZYIRHIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7716DD0", Offset = "0x77153D0", VA = "0x187716DD0")]
		public ushort[] LXRXKBVQBNS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7716B00", Offset = "0x7715100", VA = "0x187716B00")]
		public short[] ENIMIUGYRBZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7716E70", Offset = "0x7715470", VA = "0x187716E70")]
		public int[] UZNEOOCASPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7716D90", Offset = "0x7715390", VA = "0x187716D90")]
		public uint[] LXMHPJFKENP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7716F80", Offset = "0x7715580", VA = "0x187716F80")]
		public float[] VTELRGHMITR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7716850", Offset = "0x7714E50", VA = "0x187716850")]
		public double[] AKRVXTIYLFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7716C50", Offset = "0x7715250", VA = "0x187716C50")]
		public long[] FVOQCTCZWLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7716FF0", Offset = "0x77155F0", VA = "0x187716FF0")]
		public ulong[] WVNVZHQZHXU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7716EB0", Offset = "0x77154B0", VA = "0x187716EB0")]
		public string[] VKUAJYDUXKG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7716D40", Offset = "0x7715340", VA = "0x187716D40")]
		public bool LAQJKUKAHFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7716CE0", Offset = "0x77152E0", VA = "0x187716CE0")]
		public char KGCYKDSMWVG()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7716CE0", Offset = "0x77152E0", VA = "0x187716CE0")]
		public ushort YVCDHZEQNUH()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7716CE0", Offset = "0x77152E0", VA = "0x187716CE0")]
		public short NYSPLRAXWCK()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7716FC0", Offset = "0x77155C0", VA = "0x187716FC0")]
		public long WUBIAQMDGDE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7716FC0", Offset = "0x77155C0", VA = "0x187716FC0")]
		public ulong ZMQKNJAOSGZ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7716D10", Offset = "0x7715310", VA = "0x187716D10")]
		public int NBKKJJNMVWN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7716D10", Offset = "0x7715310", VA = "0x187716D10")]
		public uint KXATJCPZOMU()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7716E10", Offset = "0x7715410", VA = "0x187716E10")]
		public float PSVIDHNOCLA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7716E40", Offset = "0x7715440", VA = "0x187716E40")]
		public double UBBUXGXETEF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x77168D0", Offset = "0x7714ED0", VA = "0x1877168D0")]
		public string CABXOKJZAOR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7717070", Offset = "0x7715670", VA = "0x187717070")]
		public ArraySegment<byte> ZEBYVNODKVG(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7716B80", Offset = "0x7715180", VA = "0x187716B80")]
		public sbyte[] EWAOZTJBBNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7716890", Offset = "0x7714E90", VA = "0x187716890")]
		public byte[] BUTWDKOJIBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7716AE0", Offset = "0x77150E0", VA = "0x187716AE0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class TXEBGPMTMGQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] WKRMYUPJBSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int FCRDTWOAPNM;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int YLGHXNHZLEJ = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool ONUOZSLUZXQ;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding UTVHNUMQBKG;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int URWEVPLRHJB = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] HFCXUHXIRKK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] EPIXYLBKGFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int VQADIKBXVTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x771F710", Offset = "0x771DD10", VA = "0x18771F710")]
		public TXEBGPMTMGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x771F790", Offset = "0x771DD90", VA = "0x18771F790")]
		public TXEBGPMTMGQ(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x771F580", Offset = "0x771DB80", VA = "0x18771F580")]
		public static TXEBGPMTMGQ MRBDOOBLZLX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x771F5F0", Offset = "0x771DBF0", VA = "0x18771F5F0")]
		public void VRAYRZDIJUP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A24E30", Offset = "0x2A23430", VA = "0x182A24E30")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x771F040", Offset = "0x771D640", VA = "0x18771F040")]
		public void GGKNXIOIXSZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x771EF90", Offset = "0x771D590", VA = "0x18771EF90")]
		public void GGKNXIOIXSZ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x771F0E0", Offset = "0x771D6E0", VA = "0x18771F0E0")]
		public void GGKNXIOIXSZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x771F0E0", Offset = "0x771D6E0", VA = "0x18771F0E0")]
		public void GGKNXIOIXSZ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x771F3B0", Offset = "0x771D9B0", VA = "0x18771F3B0")]
		public void GGKNXIOIXSZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x771F3B0", Offset = "0x771D9B0", VA = "0x18771F3B0")]
		public void GGKNXIOIXSZ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x771EF20", Offset = "0x771D520", VA = "0x18771EF20")]
		public void GGKNXIOIXSZ(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x771EF20", Offset = "0x771D520", VA = "0x18771EF20")]
		public void GGKNXIOIXSZ(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x771EF20", Offset = "0x771D520", VA = "0x18771EF20")]
		public void GGKNXIOIXSZ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x771F340", Offset = "0x771D940", VA = "0x18771F340")]
		public void GGKNXIOIXSZ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x771F340", Offset = "0x771D940", VA = "0x18771F340")]
		public void GGKNXIOIXSZ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x771F510", Offset = "0x771DB10", VA = "0x18771F510")]
		public void GGKNXIOIXSZ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x771E9F0", Offset = "0x771CFF0", VA = "0x18771E9F0")]
		public void ICNFECEEGYZ(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x771E9F0", Offset = "0x771CFF0", VA = "0x18771E9F0")]
		public void CUWXRXNRDMI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x771EFE0", Offset = "0x771D5E0", VA = "0x18771EFE0")]
		public void GGKNXIOIXSZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x771EC90", Offset = "0x771D290", VA = "0x18771EC90")]
		public void FCELGMDWGPU(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x771EAD0", Offset = "0x771D0D0", VA = "0x18771EAD0")]
		public void FCELGMDWGPU(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x771EBB0", Offset = "0x771D1B0", VA = "0x18771EBB0")]
		public void FCELGMDWGPU(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x771EBB0", Offset = "0x771D1B0", VA = "0x18771EBB0")]
		public void FCELGMDWGPU(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x771EBB0", Offset = "0x771D1B0", VA = "0x18771EBB0")]
		public void FCELGMDWGPU(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x771EAD0", Offset = "0x771D0D0", VA = "0x18771EAD0")]
		public void FCELGMDWGPU(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x771EAD0", Offset = "0x771D0D0", VA = "0x18771EAD0")]
		public void FCELGMDWGPU(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x771ED70", Offset = "0x771D370", VA = "0x18771ED70")]
		public void FCELGMDWGPU(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x771ED70", Offset = "0x771D370", VA = "0x18771ED70")]
		public void FCELGMDWGPU(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x771E9F0", Offset = "0x771CFF0", VA = "0x18771E9F0")]
		public void FCELGMDWGPU(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x771EE50", Offset = "0x771D450", VA = "0x18771EE50")]
		public void FCELGMDWGPU(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x771F440", Offset = "0x771DA40", VA = "0x18771F440")]
		public void GGKNXIOIXSZ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x771F3A0", Offset = "0x771D9A0", VA = "0x18771F3A0")]
		public void GGKNXIOIXSZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x771F130", Offset = "0x771D730", VA = "0x18771F130")]
		public void GGKNXIOIXSZ(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class JSXMGFFRLXX
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class MWLLBSQQKGB<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong SNTOXKRGJFP;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5A05E10", Offset = "0x5A04410", VA = "0x185A05E10")]
			static MWLLBSQQKGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(EOGZYNEQWUE reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class YZIYXDTNWHY<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public JSXMGFFRLXX CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a EVLXNWFFUYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> JACWUJNPZHU;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public YZIYXDTNWHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x40BA310", Offset = "0x40B8910", VA = "0x1840BA310")]
			internal void IVWVBKSDEHD(EOGZYNEQWUE a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class NQKCHFIQUGO<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public JSXMGFFRLXX CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a EVLXNWFFUYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> JACWUJNPZHU;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NQKCHFIQUGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x5A825F0", Offset = "0x5A80BF0", VA = "0x185A825F0")]
			internal void IVWVBKSDEHD(EOGZYNEQWUE a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly JUNZWRJELYL JALPKDKKVMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> RYHSKTBMIZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly TXEBGPMTMGQ XWKADQYQFXN;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7718410", Offset = "0x7716A10", VA = "0x187718410")]
		public JSXMGFFRLXX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3983A90", Offset = "0x3982090", VA = "0x183983A90", Slot = "4")]
		protected virtual ulong MTQRKDNZJAY<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7718340", Offset = "0x7716940", VA = "0x187718340", Slot = "5")]
		protected virtual SubscribeDelegate KFTUMQXJDLZ(EOGZYNEQWUE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3983A10", Offset = "0x3982010", VA = "0x183983A10", Slot = "6")]
		protected virtual void MIQSGSQFJDN<b>(TXEBGPMTMGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x77182C0", Offset = "0x77168C0", VA = "0x1877182C0")]
		public void DZKEVMFULFC(EOGZYNEQWUE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3983950", Offset = "0x3981F50", VA = "0x183983950")]
		public void GYNQACGGPQL<j>(TXEBGPMTMGQ a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7718270", Offset = "0x7716870", VA = "0x187718270")]
		public void BFMPZASDAVK(EOGZYNEQWUE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x39837C0", Offset = "0x3981DC0", VA = "0x1839837C0")]
		public void DWYXVZLJBNX<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x39837C0", Offset = "0x3981DC0", VA = "0x1839837C0")]
		public void DWYXVZLJBNX<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7717D20", Offset = "0x7716320", VA = "0x187717D20")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x771D0F0", Offset = "0x771B6F0", VA = "0x18771D0F0")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class JUNZWRJELYL
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
		private abstract class LIXIWTFJZAR<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType BTZTINVWBHG;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x547BFA0", Offset = "0x547A5A0", VA = "0x18547BFA0", Slot = "4")]
			public virtual void FTYJJGFKYMC(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void JMIEBPCXEWY(a a, EOGZYNEQWUE b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void GYNQACGGPQL(a a, TXEBGPMTMGQ b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void RIVZLQHGWXD(a a, EOGZYNEQWUE b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void VYERJNIJIJC(a a, TXEBGPMTMGQ b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void UGGLXRCJNGM(a a, EOGZYNEQWUE b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void EVGTUCWDTPV(a a, TXEBGPMTMGQ b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			protected LIXIWTFJZAR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class RUHCTYJOHIA<a, b> : LIXIWTFJZAR<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> HRNRXTQWKRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> IKJJXCBHDVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> CJKHJVRFYVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> ENHXVPVJHYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> ADGSMGWDWMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> OBCYOVFXBUX;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5D6BCA0", Offset = "0x5D6A2A0", VA = "0x185D6BCA0", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5D6BCA0", Offset = "0x5D6A2A0", VA = "0x185D6BCA0", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5D6B0F0", Offset = "0x5D696F0", VA = "0x185D6B0F0", Slot = "9")]
			public override void UGGLXRCJNGM(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5D6B0F0", Offset = "0x5D696F0", VA = "0x185D6B0F0", Slot = "10")]
			public override void EVGTUCWDTPV(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5D6BD70", Offset = "0x5D6A370", VA = "0x185D6BD70")]
			protected b[] YMLBYYGBEPD(a a, EOGZYNEQWUE b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x5D6AF80", Offset = "0x5D69580", VA = "0x185D6AF80")]
			protected b[] CEZCGGMNLPS(a a, TXEBGPMTMGQ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5D6B1C0", Offset = "0x5D697C0", VA = "0x185D6B1C0", Slot = "4")]
			public override void FTYJJGFKYMC(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5D6C010", Offset = "0x5D6A610", VA = "0x185D6C010")]
			protected RUHCTYJOHIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class FMMXYIHWFPV<a, b> : RUHCTYJOHIA<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void EXXBVRRZFMA(EOGZYNEQWUE a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void BHEHOFBCMAP(TXEBGPMTMGQ a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x4F37100", Offset = "0x4F35700", VA = "0x184F37100", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4F37030", Offset = "0x4F35630", VA = "0x184F37030", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4F37310", Offset = "0x4F35910", VA = "0x184F37310", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4F37640", Offset = "0x4F35C40", VA = "0x184F37640", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x4F37850", Offset = "0x4F35E50", VA = "0x184F37850")]
			protected FMMXYIHWFPV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class EQMVFZUBWCW<a> : RUHCTYJOHIA<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x4935790", Offset = "0x4933D90", VA = "0x184935790", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4935630", Offset = "0x4933C30", VA = "0x184935630", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x49358E0", Offset = "0x4933EE0", VA = "0x1849358E0", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x4935930", Offset = "0x4933F30", VA = "0x184935930", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public EQMVFZUBWCW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class UNSXTIQQJOX<a> : RUHCTYJOHIA<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x4935790", Offset = "0x4933D90", VA = "0x184935790", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x4935630", Offset = "0x4933C30", VA = "0x184935630", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x63B8CF0", Offset = "0x63B72F0", VA = "0x1863B8CF0", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4935930", Offset = "0x4933F30", VA = "0x184935930", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public UNSXTIQQJOX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class KEYSFPTIKLL<a> : RUHCTYJOHIA<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4319C50", Offset = "0x4318250", VA = "0x184319C50", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x43199F0", Offset = "0x4317FF0", VA = "0x1843199F0", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x53ADE20", Offset = "0x53AC420", VA = "0x1853ADE20", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4319DF0", Offset = "0x43183F0", VA = "0x184319DF0", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public KEYSFPTIKLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class DMFVCZMIGPC<a> : RUHCTYJOHIA<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4319C50", Offset = "0x4318250", VA = "0x184319C50", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x43199F0", Offset = "0x4317FF0", VA = "0x1843199F0", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4319CA0", Offset = "0x43182A0", VA = "0x184319CA0", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4319DF0", Offset = "0x43183F0", VA = "0x184319DF0", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public DMFVCZMIGPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class YFKWUXVRCUN<a> : RUHCTYJOHIA<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x409A1A0", Offset = "0x40987A0", VA = "0x18409A1A0", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x409A160", Offset = "0x4098760", VA = "0x18409A160", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x409A410", Offset = "0x4098A10", VA = "0x18409A410", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x409A560", Offset = "0x4098B60", VA = "0x18409A560", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public YFKWUXVRCUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class DFTBOEAHMPU<a> : RUHCTYJOHIA<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x409A1A0", Offset = "0x40987A0", VA = "0x18409A1A0", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x409A160", Offset = "0x4098760", VA = "0x18409A160", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4314E10", Offset = "0x4313410", VA = "0x184314E10", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x409A560", Offset = "0x4098B60", VA = "0x18409A560", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public DFTBOEAHMPU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class NGDUQKXBXUN<a> : RUHCTYJOHIA<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x51D5B50", Offset = "0x51D4150", VA = "0x1851D5B50", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x51D59F0", Offset = "0x51D3FF0", VA = "0x1851D59F0", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5A72230", Offset = "0x5A70830", VA = "0x185A72230", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x51D5DF0", Offset = "0x51D43F0", VA = "0x1851D5DF0", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public NGDUQKXBXUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class IKCJKNETQPW<a> : RUHCTYJOHIA<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x51D5B50", Offset = "0x51D4150", VA = "0x1851D5B50", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x51D59F0", Offset = "0x51D3FF0", VA = "0x1851D59F0", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x51D5BA0", Offset = "0x51D41A0", VA = "0x1851D5BA0", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x51D5DF0", Offset = "0x51D43F0", VA = "0x1851D5DF0", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public IKCJKNETQPW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class AYGQCQAHMUZ<a> : RUHCTYJOHIA<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x575CA30", Offset = "0x575B030", VA = "0x18575CA30", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x575C7D0", Offset = "0x575ADD0", VA = "0x18575C7D0", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x575CA80", Offset = "0x575B080", VA = "0x18575CA80", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x4935930", Offset = "0x4933F30", VA = "0x184935930", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public AYGQCQAHMUZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class CSYTOJCEASK<a> : RUHCTYJOHIA<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4111BE0", Offset = "0x41101E0", VA = "0x184111BE0", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x4111980", Offset = "0x410FF80", VA = "0x184111980", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x4111C30", Offset = "0x4110230", VA = "0x184111C30", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x409A560", Offset = "0x4098B60", VA = "0x18409A560", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public CSYTOJCEASK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class NGEJOMFFLNB<a> : RUHCTYJOHIA<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x5A723C0", Offset = "0x5A709C0", VA = "0x185A723C0", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x5A72280", Offset = "0x5A70880", VA = "0x185A72280", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x5A72530", Offset = "0x5A70B30", VA = "0x185A72530", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x51D5DF0", Offset = "0x51D43F0", VA = "0x1851D5DF0", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x409A5C0", Offset = "0x4098BC0", VA = "0x18409A5C0")]
			public NGEJOMFFLNB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class WCJBEDEFXTJ<a> : FMMXYIHWFPV<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6857510", Offset = "0x6855B10", VA = "0x186857510", Slot = "12")]
			protected override void BHEHOFBCMAP(TXEBGPMTMGQ a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6857540", Offset = "0x6855B40", VA = "0x186857540", Slot = "11")]
			protected override void EXXBVRRZFMA(EOGZYNEQWUE a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5C80250", Offset = "0x5C7E850", VA = "0x185C80250")]
			public WCJBEDEFXTJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class PJBBHZWOXOX<a> : FMMXYIHWFPV<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5C801E0", Offset = "0x5C7E7E0", VA = "0x185C801E0", Slot = "12")]
			protected override void BHEHOFBCMAP(TXEBGPMTMGQ a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5C80210", Offset = "0x5C7E810", VA = "0x185C80210", Slot = "11")]
			protected override void EXXBVRRZFMA(EOGZYNEQWUE a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5C80250", Offset = "0x5C7E850", VA = "0x185C80250")]
			public PJBBHZWOXOX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class ZBMVCZMTWJY<a> : RUHCTYJOHIA<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int NZPVUYBOOER;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x40D4050", Offset = "0x40D2650", VA = "0x1840D4050")]
			public ZBMVCZMTWJY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x40D3C20", Offset = "0x40D2220", VA = "0x1840D3C20", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x40D3BD0", Offset = "0x40D21D0", VA = "0x1840D3BD0", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x40D3EA0", Offset = "0x40D24A0", VA = "0x1840D3EA0", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x40D3F00", Offset = "0x40D2500", VA = "0x1840D3F00", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class NJAMGABBWSM<a> : LIXIWTFJZAR<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo YWXLDIBZMSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type SNWVJCGMFNT;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5A73150", Offset = "0x5A71750", VA = "0x185A73150")]
			public NJAMGABBWSM(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5A73000", Offset = "0x5A71600", VA = "0x185A73000", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5A72D40", Offset = "0x5A71340", VA = "0x185A72D40", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x5A730A0", Offset = "0x5A716A0", VA = "0x185A730A0", Slot = "7")]
			public override void RIVZLQHGWXD(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x5A730A0", Offset = "0x5A716A0", VA = "0x185A730A0", Slot = "8")]
			public override void VYERJNIJIJC(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x5A72CF0", Offset = "0x5A712F0", VA = "0x185A72CF0", Slot = "9")]
			public override void UGGLXRCJNGM(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x5A72CF0", Offset = "0x5A712F0", VA = "0x185A72CF0", Slot = "10")]
			public override void EVGTUCWDTPV(a a, TXEBGPMTMGQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class GPAFAHKIUVL<a> : NJAMGABBWSM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x506F3D0", Offset = "0x506D9D0", VA = "0x18506F3D0")]
			public GPAFAHKIUVL(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x506F210", Offset = "0x506D810", VA = "0x18506F210", Slot = "5")]
			public override void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x506F190", Offset = "0x506D790", VA = "0x18506F190", Slot = "6")]
			public override void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class DRZAXSHONXV<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static DRZAXSHONXV<a> ZQTZABWNUIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly LIXIWTFJZAR<a>[] AVHQQZDTEHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int NWUVRPLRQAX;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x431D950", Offset = "0x431BF50", VA = "0x18431D950")]
			public DRZAXSHONXV(List<LIXIWTFJZAR<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x431D5B0", Offset = "0x431BBB0", VA = "0x18431D5B0")]
			public void GYNQACGGPQL(a a, TXEBGPMTMGQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x431D660", Offset = "0x431BC60", VA = "0x18431D660")]
			public void JMIEBPCXEWY(a a, EOGZYNEQWUE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class OVEPDWRANQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract LIXIWTFJZAR<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TXEBGPMTMGQ IQENYRKQTDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int BZGZAFYRGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, OVEPDWRANQX> JRDSFHNBFZI;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7718560", Offset = "0x7716B60", VA = "0x187718560")]
		public JUNZWRJELYL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39851C0", Offset = "0x39837C0", VA = "0x1839851C0")]
		private DRZAXSHONXV<d> IVJEDJQCNNO<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3985FB0", Offset = "0x39845B0", VA = "0x183985FB0")]
		public void KQPXXDZDTRT<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39842F0", Offset = "0x39828F0", VA = "0x1839842F0")]
		public bool Deserialize<T>(EOGZYNEQWUE reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3985FF0", Offset = "0x39845F0", VA = "0x183985FF0")]
		public void KYZOGDONURM<f>(TXEBGPMTMGQ a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NAVHEISXPDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime QCAOXXXRSMF;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] EKHYLBGHHLB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator LGPSKDMAECL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x771AD70", Offset = "0x7719370", VA = "0x18771AD70")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int BEXBBISUEZL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x771B020", Offset = "0x7719620", VA = "0x18771B020")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x771AD30", Offset = "0x7719330", VA = "0x18771AD30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode YEYCFIUEXSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x771AA40", Offset = "0x7719040", VA = "0x18771AA40")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x771A810", Offset = "0x7718E10", VA = "0x18771A810")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int DHHCOLJYHAM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x771AC40", Offset = "0x7719240", VA = "0x18771AC40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint YHOASKJFVGY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x771B0B0", Offset = "0x77196B0", VA = "0x18771B0B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? VMLPBODOBTQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x771AA10", Offset = "0x7719010", VA = "0x18771AA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? SYKRIZOLXAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x771ADA0", Offset = "0x77193A0", VA = "0x18771ADA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? IMKGTREGVKA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x771AE30", Offset = "0x7719430", VA = "0x18771AE30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x771A850", Offset = "0x7718E50", VA = "0x18771A850")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ZQSSGXNWYVW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xFCA5C0", Offset = "0xFC8BC0", VA = "0x180FCA5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x771B3D0", Offset = "0x77199D0", VA = "0x18771B3D0")]
		public NAVHEISXPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x771B330", Offset = "0x7719930", VA = "0x18771B330")]
		internal NAVHEISXPDM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x771B110", Offset = "0x7719710", VA = "0x18771B110")]
		public static NAVHEISXPDM YWFGZIELDXW(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x771A2D0", Offset = "0x77188D0", VA = "0x18771A2D0")]
		internal void ABYDBUWEBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x771A650", Offset = "0x7718C50", VA = "0x18771A650")]
		private void BZCTYYJYAPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x771AA70", Offset = "0x7719070", VA = "0x18771AA70")]
		private DateTime? NIHCKXPAGRZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x771AE60", Offset = "0x7719460", VA = "0x18771AE60")]
		private void URHVNKNDAJN(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x771B220", Offset = "0x7719820", VA = "0x18771B220")]
		private ulong ZLXQRGYNQBB(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x771AC70", Offset = "0x7719270", VA = "0x18771AC70")]
		private void PEQOHBDVZLN(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x771ADD0", Offset = "0x77193D0", VA = "0x18771ADD0")]
		private uint RGFWNZDENOI(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x75E05B0", Offset = "0x75DEBB0", VA = "0x1875E05B0")]
		private static uint YGYAFPCLJYX(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x771B050", Offset = "0x7719650", VA = "0x18771B050")]
		private static ulong YGYAFPCLJYX(ulong a)
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
	internal sealed class XFSFQSQUYGP
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int LHPJIYYJLAE = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int WDEEFAKHGYJ = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int GIJDJWWMTOO = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint ENBBSCYDGUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int FJKSTHCPBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int XWZIRHYZEBO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool DNOYSSIFWSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7720AC0", Offset = "0x771F0C0", VA = "0x187720AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x77209D0", Offset = "0x771EFD0", VA = "0x1877209D0")]
		public bool GKAAXDZSDXE(FVUNALBMBWC a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class NPUWTMQQEVN : FVUNALBMBWC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket MOSKLKQSWYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly ZGEWPXFQKRQ VGQWOLXNPHY;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short DQLCXNXQOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x771BD00", Offset = "0x771A300", VA = "0x18771BD00", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int EEPAXHXMATV
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x771BE30", Offset = "0x771A430", VA = "0x18771BE30", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint YPRYONXNDWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x771BD20", Offset = "0x771A320", VA = "0x18771BD20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily NQNVOCVNFME
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x3237E60", Offset = "0x3236460", VA = "0x183237E60", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x771BE50", Offset = "0x771A450", VA = "0x18771BE50")]
		public NPUWTMQQEVN(AddressFamily a, ZGEWPXFQKRQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x771B6E0", Offset = "0x7719CE0", VA = "0x18771B6E0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x771BCA0", Offset = "0x771A2A0", VA = "0x18771BCA0", Slot = "9")]
		public int CPSBWWGNJQP(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x771BD40", Offset = "0x771A340", VA = "0x18771BD40", Slot = "10")]
		public int NAQRHDIYYWJ(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x771BCE0", Offset = "0x771A2E0", VA = "0x18771BCE0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface FVUNALBMBWC
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short DQLCXNXQOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int EEPAXHXMATV
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint YPRYONXNDWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily NQNVOCVNFME
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
		int CPSBWWGNJQP(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int NAQRHDIYYWJ(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x771BFF0", Offset = "0x771A5F0", VA = "0x18771BFF0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x771C090", Offset = "0x771A690", VA = "0x18771C090")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1658470", Offset = "0x1656A70", VA = "0x181658470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x771BF00", Offset = "0x771A500", VA = "0x18771BF00", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x771BF40", Offset = "0x771A540", VA = "0x18771BF40", Slot = "0")]
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
	public class WUNHVHOZOQT
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string XRHGPSQLDFR = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int UUTSDEWYADP = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int PFPBEYQCKNF = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int URTLDBFHATJ = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> WICYOXNKRBE;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback LHIELFNIKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int JDWRPRFALGB;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		internal void BOIUTWRSVBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		internal void BKXPWWQRAAJ(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class VGSFUBFCWZG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int KKMOJQFMZJB;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
		protected VGSFUBFCWZG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void WWCOCMDCVAK(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void HWQFJCTYGSN(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ROFVOTHHKRW : VGSFUBFCWZG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] PYMENAUFSNV;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator NBQATWBAMIV;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2B27460", Offset = "0x2B25A60", VA = "0x182B27460")]
		public ROFVOTHHKRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x771D7E0", Offset = "0x771BDE0", VA = "0x18771D7E0")]
		public void ORUNEZSIKLE(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x771D700", Offset = "0x771BD00", VA = "0x18771D700")]
		public void JLVTTITRFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x771D990", Offset = "0x771BF90", VA = "0x18771D990", Slot = "4")]
		public override void WWCOCMDCVAK(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x771D400", Offset = "0x771BA00", VA = "0x18771D400", Slot = "5")]
		public override void HWQFJCTYGSN(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class NEQFKPALYYX
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr LRUBSODGKDT;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7728E70", Offset = "0x7727470", VA = "0x187728E70")]
			[BurstDiscard]
			private static void LDCAZZDRNOJ(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7728AB0", Offset = "0x77270B0", VA = "0x187728AB0")]
			private static IntPtr IHMFOJOPPUJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7728C30", Offset = "0x7727230", VA = "0x187728C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x771E4C0", Offset = "0x771CAC0", VA = "0x18771E4C0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x771E000", Offset = "0x771C600", VA = "0x18771E000")]
		private uint HOURLSFYLMK(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x77114A0", Offset = "0x770FAA0", VA = "0x1877114A0")]
		private void VGDAYYSUJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7711100", Offset = "0x770F700", VA = "0x187711100")]
		private void LOLVUTXCNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7711410", Offset = "0x770FA10", VA = "0x187711410")]
		private void SUSXODPDVSQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7711310", Offset = "0x770F910", VA = "0x187711310")]
		private void RLBPTZOJDKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x771DEE0", Offset = "0x771C4E0", VA = "0x18771DEE0")]
		private void EEBMJDKXLCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x771E0A0", Offset = "0x771C6A0", VA = "0x18771E0A0")]
		private unsafe void MTTZBECPNCU(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x771DF40", Offset = "0x771C540", VA = "0x18771DF40")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void HDQMZSOULOZ([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x771DF50", Offset = "0x771C550", VA = "0x18771DF50")]
		public static void HDQMZSOULOZ(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x771DE30", Offset = "0x771C430", VA = "0x18771DE30")]
		public static void EAACOKTZQMZ(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x771E030", Offset = "0x771C630", VA = "0x18771E030")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void IJTOPNZNKHS([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7729000", Offset = "0x7727600", VA = "0x187729000")]
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
