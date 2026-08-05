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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, CCCWMBJTFGN
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
		private NetworkManager DUHFUEXLFUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool GRXBXYALTNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, ZOINZCJBRMU> ZNWHRGBPDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CQQOUEVPJTR CUKFESHCRST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch ZOLEHXAMDTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] BKJSBYPAHQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType WQQECOHPVCT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int KFGRKIZHWDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x79036A0", Offset = "0x79026A0", VA = "0x1879036A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7903650", Offset = "0x7902650", VA = "0x187903650", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7902A30", Offset = "0x7901A30", VA = "0x187902A30")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7902A10", Offset = "0x7901A10", VA = "0x187902A10")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7902820", Offset = "0x7901820", VA = "0x187902820")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7903470", Offset = "0x7902470", VA = "0x187903470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7902C10", Offset = "0x7901C10", VA = "0x187902C10", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7902910", Offset = "0x7901910", VA = "0x187902910", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7902EE0", Offset = "0x7901EE0", VA = "0x187902EE0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7903220", Offset = "0x7902220", VA = "0x187903220", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x79022E0", Offset = "0x79012E0", VA = "0x1879022E0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79021F0", Offset = "0x79011F0", VA = "0x1879021F0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x79023F0", Offset = "0x79013F0", VA = "0x1879023F0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7902E70", Offset = "0x7901E70", VA = "0x187902E70", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7902560", Offset = "0x7901560", VA = "0x187902560", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7903490", Offset = "0x7902490", VA = "0x187903490")]
		private DeliveryMethod WCQGKPZJJMO(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7902950", Offset = "0x7901950", VA = "0x187902950", Slot = "16")]
		private void QJVCNWVRUYZ(ZOINZCJBRMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7902490", Offset = "0x7901490", VA = "0x187902490", Slot = "17")]
		private void HJUNAELOVQR(ZOINZCJBRMU a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "18")]
		private void WUWEGKPLESK(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7901FF0", Offset = "0x7900FF0", VA = "0x187901FF0", Slot = "19")]
		private void BGZFXJQDLFH(ZOINZCJBRMU a, UAKSTCDQQBN b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7902B40", Offset = "0x7901B40", VA = "0x187902B40")]
		private void SIUHYQETIOS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "20")]
		private void WAPVKRFMNKJ(IPEndPoint a, UAKSTCDQQBN b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "21")]
		private void UTRFGVXVKWP(ZOINZCJBRMU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x79027C0", Offset = "0x79017C0", VA = "0x1879027C0", Slot = "22")]
		private void LNUWGSKCJIX(IQJQMLZWCZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7902770", Offset = "0x7901770", VA = "0x187902770")]
		private ulong JRDBAXXJLHW(ZOINZCJBRMU a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x79027A0", Offset = "0x79017A0", VA = "0x1879027A0")]
		private ulong JRDBAXXJLHW(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7903560", Offset = "0x7902560", VA = "0x187903560")]
		private static int WTZTORTIPOF(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7903580", Offset = "0x7902580", VA = "0x187903580")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7903440", Offset = "0x7902440", VA = "0x187903440")]
		[CompilerGenerated]
		private void TPWUBOGXBVN(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7903440", Offset = "0x7902440", VA = "0x187903440")]
		[CompilerGenerated]
		private void UYNLMNDCUBE(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class BWLBIUHXSXJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly ZOINZCJBRMU KKXNWXSNGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<DBGLIDKCZSE> QEAMJXABJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int SUGVUGXEUGF;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FHBFDUXEBVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x78F9470", Offset = "0x78F8470", VA = "0x1878F9470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x78F94C0", Offset = "0x78F84C0", VA = "0x1878F94C0")]
		protected BWLBIUHXSXJ(ZOINZCJBRMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78F9390", Offset = "0x78F8390", VA = "0x1878F9390")]
		public void GRUKYFBBWOA(DBGLIDKCZSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78F93F0", Offset = "0x78F83F0", VA = "0x1878F93F0")]
		protected void GWEZLGUMCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x78F9350", Offset = "0x78F8350", VA = "0x1878F9350")]
		public bool GCEILAVVBMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool DPXIJTKOFLR();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool AWDLPRTIKLQ(DBGLIDKCZSE a);
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
	public class IQJQMLZWCZI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly CQQOUEVPJTR EHOSCGATDQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int IKZVYRVLPTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal MWJXMSHJKFR CGXRWXGQBKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint TSNVZUOJMVA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult GNWIUMYRKLC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x16BBF00", Offset = "0x16BAF00", VA = "0x1816BBF00")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x16BBEF0", Offset = "0x16BAEF0", VA = "0x1816BBEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7901F10", Offset = "0x7900F10", VA = "0x187901F10")]
		internal void XBPFNFQANQN(MWJXMSHJKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7901EE0", Offset = "0x7900EE0", VA = "0x187901EE0")]
		private bool MBEXWHFRKKX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7901F70", Offset = "0x7900F70", VA = "0x187901F70")]
		internal IQJQMLZWCZI(IPEndPoint a, MWJXMSHJKFR b, CQQOUEVPJTR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7901E80", Offset = "0x7900E80", VA = "0x187901E80")]
		public ZOINZCJBRMU Accept()
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
		public UAKSTCDQQBN AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface CCCWMBJTFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JMMJMUNZBJR(ZOINZCJBRMU a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IBFOHXCKLPJ(ZOINZCJBRMU a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HOVEZHDFNXC(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XMEBQUXGUPB(ZOINZCJBRMU a, UAKSTCDQQBN b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WXNUIHSDMIX(IPEndPoint a, UAKSTCDQQBN b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YUNFHDBROIB(ZOINZCJBRMU a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IZFMNPFIAFT(IQJQMLZWCZI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface BWNQRUCVNYU
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QHYTAOTUZAV(ZOINZCJBRMU a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface TSVMFSVKMWC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WHKTCIZDYHH(AWBVXLDAZHT a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface PYOSLGMSKSE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NSVVKSQJKXO(ZOINZCJBRMU a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class MWJXMSHJKFR
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int TWMDDOWFIKR = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long XJSXEVXXUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte VVDTXWRWYNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] FVCORPKHPEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly XEAYCCLKMAX JBMRVYMFEKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int EOIDEDDTBEM;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7903C20", Offset = "0x7902C20", VA = "0x187903C20")]
		private MWJXMSHJKFR(long a, byte b, int c, byte[] d, XEAYCCLKMAX e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7903BF0", Offset = "0x7902BF0", VA = "0x187903BF0")]
		public static int WZLBCAICWUK(DBGLIDKCZSE a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7903820", Offset = "0x7902820", VA = "0x187903820")]
		public static MWJXMSHJKFR OCSPKJQLBGR(DBGLIDKCZSE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7903A10", Offset = "0x7902A10", VA = "0x187903A10")]
		public static DBGLIDKCZSE OHKVTQMLUNB(VDWAUHVHOPV a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class WHAWOUYIVWS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long XJSXEVXXUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte VVDTXWRWYNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int EOIDEDDTBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool HBPNJUSQGDV;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7909340", Offset = "0x7908340", VA = "0x187909340")]
		private WHAWOUYIVWS(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7909050", Offset = "0x7908050", VA = "0x187909050")]
		public static WHAWOUYIVWS OCSPKJQLBGR(DBGLIDKCZSE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7909150", Offset = "0x7908150", VA = "0x187909150")]
		public static DBGLIDKCZSE OHKVTQMLUNB(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7909240", Offset = "0x7908240", VA = "0x187909240")]
		public static DBGLIDKCZSE YHGDUUHCBKR(ZOINZCJBRMU a)
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
	public interface AQTPAVZBRFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZZDYSSLVCDS(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OLLPRVTGQYS(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class BUGYRFNQOKE
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
		private class FPJESNGTWXU
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint CFWTCMRKDZO
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string CAWKQVHZYCK
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public FPJESNGTWXU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class IDYHXIIFMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint CFWTCMRKDZO
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint GWETBEDXATY
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string CAWKQVHZYCK
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public IDYHXIIFMLQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class RYQNYXIPBOY
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string CAWKQVHZYCK
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool XRYFIXLZZAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xBF9560", Offset = "0xBF8560", VA = "0x180BF9560")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAD5FD0", Offset = "0xAD4FD0", VA = "0x180AD5FD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public RYQNYXIPBOY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly CQQOUEVPJTR XMWSIRCBNRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> JNPVXOMRGLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> UCEEIVHTALW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly XEAYCCLKMAX SNAHMFFOKZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly VDWAUHVHOPV LTSUFZBIEGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly RDGBZRNGJRK QGOBHBGYWLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private AQTPAVZBRFP VNSDSWIXWTB;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int XTBZYZNPIEW = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool CDHACVSBXLD;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78F8F60", Offset = "0x78F7F60", VA = "0x1878F8F60")]
		internal BUGYRFNQOKE(CQQOUEVPJTR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x78F8C50", Offset = "0x78F7C50", VA = "0x1878F8C50")]
		internal void PUJMWQEYWVT(IPEndPoint a, DBGLIDKCZSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x36A5AA0", Offset = "0x36A4AA0", VA = "0x1836A5AA0")]
		private void VANHJDNTSGH<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x78F8DD0", Offset = "0x78F7DD0", VA = "0x1878F8DD0")]
		private void ZZDYSSLVCDS(FPJESNGTWXU a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78F8AF0", Offset = "0x78F7AF0", VA = "0x1878F8AF0")]
		private void CRTEVBOUUDO(IDYHXIIFMLQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x78F8960", Offset = "0x78F7960", VA = "0x1878F8960")]
		private void CJPGTDWOSYF(RYQNYXIPBOY a, IPEndPoint b)
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
	public static class HXJQPLJFZKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] VDMXUHQPEDA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int XIGKAQKPOFO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int EPQMGLFATUV;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7901FE0", Offset = "0x7900FE0", VA = "0x187901FE0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7901FE0", Offset = "0x7900FE0", VA = "0x187901FE0")]
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
	public interface DYLIJVCOVVV
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EWRECRPGDAH(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class XWXEONWVNCD
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static DYLIJVCOVVV ESETJNYEISF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object GKYJICBLNPH;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7909C80", Offset = "0x7908C80", VA = "0x187909C80")]
		private static void AICMVQKMKPQ(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7909F70", Offset = "0x7908F70", VA = "0x187909F70")]
		internal static void ZVBJGRJUFBQ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7909EB0", Offset = "0x7908EB0", VA = "0x187909EB0")]
		internal static void OSPMTWLGNNO(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7909F10", Offset = "0x7908F10", VA = "0x187909F10")]
		internal static void SYWPNCACPDM(string a, params object[] args)
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
	public sealed class UAKSTCDQQBN : XEAYCCLKMAX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DBGLIDKCZSE TDTPPGFMSJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly CQQOUEVPJTR GVZBCYMJCQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly VKNQBUHLXGM VDJUHVTANJB;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7907FC0", Offset = "0x7906FC0", VA = "0x187907FC0")]
		internal UAKSTCDQQBN(CQQOUEVPJTR a, VKNQBUHLXGM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7907F50", Offset = "0x7906F50", VA = "0x187907F50")]
		internal void XKFAAJFQEFQ(DBGLIDKCZSE a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7907EA0", Offset = "0x7906EA0", VA = "0x187907EA0")]
		internal void MNUBCIWGRRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7907F20", Offset = "0x7906F20", VA = "0x187907F20")]
		public void VFLHMNKMJZM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class VKNQBUHLXGM
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
		public VKNQBUHLXGM JIZHLMOKLUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType OVCFCLRZRCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ZOINZCJBRMU KKXNWXSNGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint TSNVZUOJMVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object FALYACBFKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int AEBTDJZRJTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError IRHKAEUUYYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason HXGZDJQSXHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IQJQMLZWCZI IQJQMLZWCZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod CQINOREDVVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte YJTMQZCTTFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly UAKSTCDQQBN LYEPIYDCIHU;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7908FB0", Offset = "0x7907FB0", VA = "0x187908FB0")]
		public VKNQBUHLXGM(CQQOUEVPJTR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CQQOUEVPJTR : IEnumerable<ZOINZCJBRMU>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class PIEJWHIORIK : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7904910", Offset = "0x7903910", VA = "0x187904910", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7904980", Offset = "0x7903980", VA = "0x187904980", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public PIEJWHIORIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<ZOINZCJBRMU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly ZOINZCJBRMU _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private ZOINZCJBRMU _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public ZOINZCJBRMU Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xC10060", Offset = "0xC0F060", VA = "0x180C10060", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xC10060", Offset = "0xC0F060", VA = "0x180C10060", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DEC3D0", Offset = "0x1DEB3D0", VA = "0x181DEC3D0")]
			public NetPeerEnumerator(ZOINZCJBRMU p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7904060", Offset = "0x7903060", VA = "0x187904060", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x79040B0", Offset = "0x79030B0", VA = "0x1879040B0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread CWUBWRMPLNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool BIYTIWHPQDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool FCGKEZUBIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private IMIAPGWYFEY XPPXNMIRSBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent EFLKGYLOCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<VKNQBUHLXGM> PUXAWQLFYNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<VKNQBUHLXGM> KEADCOQACQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private VKNQBUHLXGM DWGLJNZYXWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CCCWMBJTFGN LPMSIATCODR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly BWNQRUCVNYU GXWLAREKAVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly TSVMFSVKMWC YHIRJLHRBJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly PYOSLGMSKSE WXDUQOUHAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, ZOINZCJBRMU> BSYARJLWKFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, IQJQMLZWCZI> WQOASYQJTBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, GAUPRYYWOVM> KJCPXSTDTNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim DOIYTTVTSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ZOINZCJBRMU CTYWXWLOXUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int KXZIZBYXJQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<ZOINZCJBRMU> UTVZFQIWNXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ZOINZCJBRMU[] TCBVEKXIUUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly EDZVWQFNRVF TNRTFYRWSJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int RKQLTMOIFZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> VFVRMCVVPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte MKCJIHMNUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object KIOEPMZUXCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool OWHFNCFUUWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool MROIYLICQXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int NKVBDTOQYYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int XFVVGNGVCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int ZDJARMPCLWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int DIQNWQISWZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool WJSEDZHJDGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool JCOFANKYRAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int GBIEVYCPVCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int DNNHKYFMKQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int XGZVOYPSHRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool CDHACVSBXLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool RYJHRZRQPEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool CGKAORSIWFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool UPZBDVRBDDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int LMEPOARESGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int XWEXYXNWNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool AIMNNRTUCDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly YWDVLYKTAKL JFBAWCPSGVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool CIOPXXXYTJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly BUGYRFNQOKE BUGYRFNQOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool YJIHEUFCYIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode FJEGSGCQJTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int EZPUCALDOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool NFXURRUXQET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool XUXVPWGYVBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool FAYRFGWFQKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool NCTZYCORDTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private DBGLIDKCZSE XYYOEQIKJVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int PKTARFMJXJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object ZRXFCFWXWCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DBGLIDKCZSE XGPQIJBCYGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int FEUXREEHBVQ;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int EBBCPJNRXQW = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int RTZBFMFANBZ = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RFUVXOKZNLH OMRWFUBIQWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private RFUVXOKZNLH OMHILGNNXZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread SJREKPDBXRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread SKBSFCQWQOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint BDPGEDDEVZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint BDZTYQQZOWB;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] XANMIQWLRWP;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] HIOHICXEQCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> CIQQFLFJKNK;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress SOPMJAPLIHF;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool HNEMZSFYJST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int KVRPEDQLTDZ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EXKMHYGCUKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xC234D0", Offset = "0xC224D0", VA = "0x180C234D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD2CE70", Offset = "0xD2BE70", VA = "0x180D2CE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int OGPHUFCRLGP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBEA980", Offset = "0xBE9980", VA = "0x180BEA980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2361D50", Offset = "0x2360D50", VA = "0x182361D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte MMNJRUCIHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xED1D00", Offset = "0xED0D00", VA = "0x180ED1D00")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int KUZVYIFBHLW
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x78FA2F0", Offset = "0x78F92F0", VA = "0x1878FA2F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short IZZXLQSRZBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x78FA730", Offset = "0x78F9730", VA = "0x1878FA730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ZOINZCJBRMU.OnUpdatedMtuDelegate RHCJVYVCDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x78FFAD0", Offset = "0x78FEAD0", VA = "0x1878FFAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x78FDE80", Offset = "0x78FCE80", VA = "0x1878FDE80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x78FFFF0", Offset = "0x78FEFF0", VA = "0x1878FFFF0")]
		public void XIWYGXAFDWZ(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78FD0C0", Offset = "0x78FC0C0", VA = "0x1878FD0C0")]
		public void MOUNYUNBQKA(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x78F9870", Offset = "0x78F8870", VA = "0x1878F9870")]
		private bool CAJEROFPGTY(IPEndPoint a, [Out] ZOINZCJBRMU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x78F9910", Offset = "0x78F8910", VA = "0x1878F9910")]
		private void CGNYKFOCEYM(ZOINZCJBRMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7900210", Offset = "0x78FF210", VA = "0x187900210")]
		private void XLRGKIIEWYN(ZOINZCJBRMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78FE0E0", Offset = "0x78FD0E0", VA = "0x1878FE0E0")]
		private void SKKOFADDKGE(ZOINZCJBRMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7900CE0", Offset = "0x78FFCE0", VA = "0x187900CE0")]
		public CQQOUEVPJTR(CCCWMBJTFGN a, [Optional] EDZVWQFNRVF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7900430", Offset = "0x78FF430", VA = "0x187900430")]
		internal void ZNPDVOKHHVG(ZOINZCJBRMU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x78FD590", Offset = "0x78FC590", VA = "0x1878FD590")]
		internal void NQRNUIZXLFK(ZOINZCJBRMU a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x79003F0", Offset = "0x78FF3F0", VA = "0x1879003F0")]
		internal void ZIYSNKCAPIW(ZOINZCJBRMU a, DisconnectReason b, SocketError c, DBGLIDKCZSE d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x78FFBC0", Offset = "0x78FEBC0", VA = "0x1878FFBC0")]
		private void WURHNJHSVCP(ZOINZCJBRMU a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, DBGLIDKCZSE h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x78FF260", Offset = "0x78FE260", VA = "0x1878FF260")]
		private void TWDSNPQIFOL(VKNQBUHLXGM.EType a, [Optional] ZOINZCJBRMU b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] IQJQMLZWCZI g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] DBGLIDKCZSE j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7900480", Offset = "0x78FF480", VA = "0x187900480")]
		private void ZQLDSPEVPEO(VKNQBUHLXGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x78F9C30", Offset = "0x78F8C30", VA = "0x1878F9C30")]
		internal void CPAHYQPJHWG(VKNQBUHLXGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x78FDB20", Offset = "0x78FCB20", VA = "0x1878FDB20")]
		private void PFXKVEKWIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x78FA400", Offset = "0x78F9400", VA = "0x1878FA400")]
		private void GGPWPWWQNDI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x78FA870", Offset = "0x78F9870", VA = "0x1878FA870")]
		internal ZOINZCJBRMU HARURFONUUJ(IQJQMLZWCZI a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x78FA7F0", Offset = "0x78F97F0", VA = "0x1878FA7F0")]
		private int GZTRMCESPVZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x78FF630", Offset = "0x78FE630", VA = "0x1878FF630")]
		private void UDAGPKYARAB(IPEndPoint a, ZOINZCJBRMU b, MWJXMSHJKFR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x78FB900", Offset = "0x78FA900", VA = "0x1878FB900")]
		private void IWLVFHAEHTK(DBGLIDKCZSE a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x78FD5E0", Offset = "0x78FC5E0", VA = "0x1878FD5E0")]
		internal void ODPDUUFWRRE(DBGLIDKCZSE a, DeliveryMethod b, byte c, int d, ZOINZCJBRMU e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x78FED10", Offset = "0x78FDD10", VA = "0x1878FED10")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x78FEC70", Offset = "0x78FDC70", VA = "0x1878FEC70")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x78FEC90", Offset = "0x78FDC90", VA = "0x1878FEC90")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x78FDF30", Offset = "0x78FCF30", VA = "0x1878FDF30")]
		public void SGJLPIQRURT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78FA210", Offset = "0x78F9210", VA = "0x1878FA210")]
		public ZOINZCJBRMU Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x78FA130", Offset = "0x78F9130", VA = "0x1878FA130")]
		public ZOINZCJBRMU Connect(string address, int port, VDWAUHVHOPV connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x78F9D60", Offset = "0x78F8D60", VA = "0x1878F9D60")]
		public ZOINZCJBRMU Connect(IPEndPoint target, VDWAUHVHOPV connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x78FED20", Offset = "0x78FDD20", VA = "0x1878FED20")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x78FED30", Offset = "0x78FDD30", VA = "0x1878FED30")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7900270", Offset = "0x78FF270", VA = "0x187900270")]
		public void XWLJNXNKABY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7900320", Offset = "0x78FF320", VA = "0x187900320")]
		public void XWLJNXNKABY(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x78FFFB0", Offset = "0x78FEFB0", VA = "0x1878FFFB0")]
		public void WURHNJHSVCP(ZOINZCJBRMU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x78FFB80", Offset = "0x78FEB80", VA = "0x1878FFB80")]
		public void WURHNJHSVCP(ZOINZCJBRMU a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x78FA370", Offset = "0x78F9370", VA = "0x1878FA370", Slot = "4")]
		private IEnumerator<ZOINZCJBRMU> ETGFYWCATOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x78FCC20", Offset = "0x78FBC20", VA = "0x1878FCC20", Slot = "5")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x78FF170", Offset = "0x78FE170", VA = "0x1878FF170")]
		private DBGLIDKCZSE TOVKYLTDEYA(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x78FF090", Offset = "0x78FE090", VA = "0x1878FF090")]
		private DBGLIDKCZSE TOVKYLTDEYA(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x78FB6C0", Offset = "0x78FA6C0", VA = "0x1878FB6C0")]
		internal DBGLIDKCZSE HKACGMNQSWZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x78FD8B0", Offset = "0x78FC8B0", VA = "0x1878FD8B0")]
		internal void OENHXNIEQKM(DBGLIDKCZSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7900C20", Offset = "0x78FFC20", VA = "0x187900C20")]
		static CQQOUEVPJTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC234D0", Offset = "0xC224D0", VA = "0x180C234D0")]
		private bool OMLXMZQWLXR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x78FE3A0", Offset = "0x78FD3A0", VA = "0x1878FE3A0")]
		private void SRUUYEVSFHT(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x78FCF70", Offset = "0x78FBF70", VA = "0x1878FCF70")]
		private void MAEVKJZXWWG(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78F9550", Offset = "0x78F8550", VA = "0x1878F9550")]
		private bool AXQBHWZUXPG(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x78F9D40", Offset = "0x78F8D40", VA = "0x1878F9D40")]
		private void CUKBFQVXPSX(IMIAPGWYFEY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x78FCCB0", Offset = "0x78FBCB0", VA = "0x1878FCCB0")]
		private void KXNZURWWGHG(RFUVXOKZNLH a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x78FD210", Offset = "0x78FC210", VA = "0x1878FD210")]
		private void NFTJCABNDVO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x78FE500", Offset = "0x78FD500", VA = "0x1878FE500")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x78FA310", Offset = "0x78F9310", VA = "0x1878FA310")]
		internal int EMOIPTOTYAZ(DBGLIDKCZSE a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x78FB680", Offset = "0x78FA680", VA = "0x1878FB680")]
		internal int HHIONQBYGNZ(DBGLIDKCZSE a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x78FAEB0", Offset = "0x78F9EB0", VA = "0x1878FAEB0")]
		internal int HHIONQBYGNZ(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x78F96F0", Offset = "0x78F86F0", VA = "0x1878F96F0")]
		internal void BSWOADJXEQO(bool a)
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
	internal sealed class DBGLIDKCZSE
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int SCXVVJXUYXB;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] EILYJNPSETM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] GUXOYKBUQRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int KLXWYWZZPWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object FALYACBFKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DBGLIDKCZSE JIZHLMOKLUI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty JFAQWMBNHIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7901770", Offset = "0x7900770", VA = "0x187901770")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x79015E0", Offset = "0x79005E0", VA = "0x1879015E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte VVDTXWRWYNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7901310", Offset = "0x7900310", VA = "0x187901310")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7901560", Offset = "0x7900560", VA = "0x187901560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort VWJXUKFGNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x79017A0", Offset = "0x79007A0", VA = "0x1879017A0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x79015A0", Offset = "0x79005A0", VA = "0x1879015A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CJYNUAFQRDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7901460", Offset = "0x7900460", VA = "0x187901460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte YGXRQFGBPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7901510", Offset = "0x7900510", VA = "0x187901510")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x79012E0", Offset = "0x79002E0", VA = "0x1879012E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort QJBUSJYXXNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7901540", Offset = "0x7900540", VA = "0x187901540")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x79012A0", Offset = "0x79002A0", VA = "0x1879012A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort YXTDWFREUZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7901440", Offset = "0x7900440", VA = "0x187901440")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x79014D0", Offset = "0x79004D0", VA = "0x1879014D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort ETPUYQOWZBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7901750", Offset = "0x7900750", VA = "0x187901750")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7901490", Offset = "0x7900490", VA = "0x187901490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x79017C0", Offset = "0x79007C0", VA = "0x1879017C0")]
		static DBGLIDKCZSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7901720", Offset = "0x7900720", VA = "0x187901720")]
		public void RGFRXWFATER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7901BA0", Offset = "0x7900BA0", VA = "0x187901BA0")]
		public DBGLIDKCZSE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7901A90", Offset = "0x7900A90", VA = "0x187901A90")]
		public DBGLIDKCZSE(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7901620", Offset = "0x7900620", VA = "0x187901620")]
		public static int QRTPYRZHNVN(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7901690", Offset = "0x7900690", VA = "0x187901690")]
		public int QRTPYRZHNVN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7901340", Offset = "0x7900340", VA = "0x187901340")]
		public bool BIQFRBCARBK()
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
	public class ZOINZCJBRMU
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class VHRYTGUWATU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public DBGLIDKCZSE[] DFDCWRZAHTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int KBUHTJTNZJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int UKEUZFHFCZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte YGXRQFGBPUJ;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public VHRYTGUWATU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int QRVINSVSLOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int WSJBQYTPGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int UDLPIQPZOLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double YNKNQSUFAUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int RLOCXCCRCSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int TVNMLSXYPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int GDDCTQSGRZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch NESLPNFFTBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int QEWVDDOGPVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long JSWTHEWBDDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object RQDKRLXYXST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal ZOINZCJBRMU VFVTDGYSEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal ZOINZCJBRMU URMYLZDDVMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<DBGLIDKCZSE> QQTUUFOHPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<BWLBIUHXSXJ> GDOKFQXYPVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly BWLBIUHXSXJ[] HJXMTKLEOUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int LGHGTOCHOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int YKTWUTKKZLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool VODCPFAPLPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int HQXXQJZSWSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int NERUNXOISMU;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int SZGRHWHBYEE = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int KITUBHYDNVZ = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object USPOLFTEPLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int AESDIFRYFGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, VHRYTGUWATU> DYBTWXLJTMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> QJQHZKVKKUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly DBGLIDKCZSE MISPLBKUBWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int EAWMXBKPMUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int TAZZIHPRUSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint APXIHGMYLYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int WMNYVYGDXTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int AIYGONLUWYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long CHNWUSOIUQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte KEIJCPVZHKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState LWCWDLTINOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DBGLIDKCZSE UYYFXMTSETG;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int FCMNMPSBNXE = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int JQMSMQXNXGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly DBGLIDKCZSE LUHYLIZNTBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly DBGLIDKCZSE TDWZRVCOUNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly DBGLIDKCZSE HAYJDKSGDYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly DBGLIDKCZSE RADUSVQUYIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality GHKQCYXLYBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly CQQOUEVPJTR CQQOUEVPJTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int HGJTEJGBOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object XIYLLLFPDSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly YWDVLYKTAKL JFBAWCPSGVU;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte NQESVDDLIEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAFB350", Offset = "0xAFA350", VA = "0x180AFB350")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x790B680", Offset = "0x790A680", VA = "0x18790B680")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint ERYCVOUYXPW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xC1E5C0", Offset = "0xC1D5C0", VA = "0x180C1E5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState NCRTMFXDKMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xC1E620", Offset = "0xC1D620", VA = "0x180C1E620")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long ELQMGKSMHMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xADC200", Offset = "0xADB200", VA = "0x180ADC200")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int TSNURPQWAMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xBEA980", Offset = "0xBE9980", VA = "0x180BEA980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2361D50", Offset = "0x2360D50", VA = "0x182361D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int IVUTNWAHBON
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x790CA60", Offset = "0x790BA60", VA = "0x18790CA60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int HXTLXISOSSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAEC5E0", Offset = "0xAEB5E0", VA = "0x180AEC5E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double EEVSPIKJZFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC96F0", Offset = "0x2AC86F0", VA = "0x182AC96F0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate RHCJVYVCDCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x790D9C0", Offset = "0x790C9C0", VA = "0x18790D9C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x790C110", Offset = "0x790B110", VA = "0x18790C110")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x790E580", Offset = "0x790D580", VA = "0x18790E580")]
		internal ZOINZCJBRMU(CQQOUEVPJTR a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x790E060", Offset = "0x790D060", VA = "0x18790E060")]
		internal void YIWXEPBGSUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x790B600", Offset = "0x790A600", VA = "0x18790B600")]
		internal void DMGLMEZGSDB(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x790D230", Offset = "0x790C230", VA = "0x18790D230")]
		internal void UETIHVPZDQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x790C000", Offset = "0x790B000", VA = "0x18790C000")]
		private void QGQUUVQEKLL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x790C0D0", Offset = "0x790B0D0", VA = "0x18790C0D0")]
		private void QKUBKKEVSGD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x790B4F0", Offset = "0x790A4F0", VA = "0x18790B4F0")]
		public int CTBSOOULABN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x790B3D0", Offset = "0x790A3D0", VA = "0x18790B3D0")]
		public int CTBSOOULABN(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x790E080", Offset = "0x790D080", VA = "0x18790E080")]
		private BWLBIUHXSXJ YJEHYLNSAXC(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x790E3F0", Offset = "0x790D3F0", VA = "0x18790E3F0")]
		internal ZOINZCJBRMU(CQQOUEVPJTR a, IPEndPoint b, int c, byte d, VDWAUHVHOPV e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x790E210", Offset = "0x790D210", VA = "0x18790E210")]
		internal ZOINZCJBRMU(CQQOUEVPJTR a, IQJQMLZWCZI b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x790CA70", Offset = "0x790BA70", VA = "0x18790CA70")]
		internal void Reject(MWJXMSHJKFR requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x790B940", Offset = "0x790A940", VA = "0x18790B940")]
		internal bool MNSNLMSHFKE(WHAWOUYIVWS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x790D990", Offset = "0x790C990", VA = "0x18790D990")]
		public void VANHJDNTSGH(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x790DA70", Offset = "0x790CA70", VA = "0x18790DA70")]
		private void WMEJUXTYSZA(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x790B630", Offset = "0x790A630", VA = "0x18790B630")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x790B9C0", Offset = "0x790A9C0", VA = "0x18790B9C0")]
		internal DisconnectResult OLPCMMYRRMM(DBGLIDKCZSE a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x790BFA0", Offset = "0x790AFA0", VA = "0x18790BFA0")]
		internal void PEOFCVEYTBV(BWLBIUHXSXJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x790CD20", Offset = "0x790BD20", VA = "0x18790CD20")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x790D030", Offset = "0x790C030", VA = "0x18790D030")]
		private void TLIGJRLXWXU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x790C1C0", Offset = "0x790B1C0", VA = "0x18790C1C0")]
		internal void QUMRETOMGWC(DeliveryMethod a, DBGLIDKCZSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x790BA60", Offset = "0x790AA60", VA = "0x18790BA60")]
		private void PCIPVRDDVLU(DBGLIDKCZSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x790A9A0", Offset = "0x79099A0", VA = "0x18790A9A0")]
		private void AUVNOUSGDZE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x790D070", Offset = "0x790C070", VA = "0x18790D070")]
		internal ConnectRequestResult UDAGPKYARAB(MWJXMSHJKFR a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x790AD30", Offset = "0x7909D30", VA = "0x18790AD30")]
		internal void AWDLPRTIKLQ(DBGLIDKCZSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x790A850", Offset = "0x7909850", VA = "0x18790A850")]
		private void ABKMHKNJMSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x790B730", Offset = "0x790A730", VA = "0x18790B730")]
		internal void JTKAHCPWTVK(DBGLIDKCZSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x790D2C0", Offset = "0x790C2C0", VA = "0x18790D2C0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x790CAC0", Offset = "0x790BAC0", VA = "0x18790CAC0")]
		internal void SQQNVCLABNS(DBGLIDKCZSE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class YWDVLYKTAKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long FDFOODDSHSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long FHTHMFJOJSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long XFOPLPONENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long AJYDZHRPTTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long USOOMBWIJUJ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long MGADECFSXKM;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long PTRMJXFYRZX;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long IFMWPWZKETM;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long ZMQPBDDPKIH;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long WGIPMFPDJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long KCYNKTVKAFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long UMXMJEFWGML;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long MYGZOIUYTZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x790A240", Offset = "0x7909240", VA = "0x18790A240")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long KEYMKYRCZNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x790A730", Offset = "0x7909730", VA = "0x18790A730")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long UPBBSYYUNTE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x790A830", Offset = "0x7909830", VA = "0x18790A830")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long WODYPLCQKPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x790A820", Offset = "0x7909820", VA = "0x18790A820")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long BBVFUNUUREG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x790A840", Offset = "0x7909840", VA = "0x18790A840")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long ZKFVQQVUSUC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x790A0F0", Offset = "0x79090F0", VA = "0x18790A0F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long OYCINQKGSNR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x790A7E0", Offset = "0x79097E0", VA = "0x18790A7E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long HEKJGJYWUSK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x790A360", Offset = "0x7909360", VA = "0x18790A360")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality UCAYBTCKAQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x14B3750", Offset = "0x14B2750", VA = "0x1814B3750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double QKLVUUTLECX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x790A160", Offset = "0x7909160", VA = "0x18790A160")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x790A2C0", Offset = "0x79092C0", VA = "0x18790A2C0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x790A100", Offset = "0x7909100", VA = "0x18790A100")]
		public void KHTYJEHQCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x790A3A0", Offset = "0x79093A0", VA = "0x18790A3A0")]
		public void SOJSXLSZHYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x790A250", Offset = "0x7909250", VA = "0x18790A250")]
		public void QQXTUTERQOR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x790A080", Offset = "0x7909080", VA = "0x18790A080")]
		public void DTDLJREXNGU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x790A300", Offset = "0x7909300", VA = "0x18790A300")]
		public void SHPDCVNMPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x790A1C0", Offset = "0x79091C0", VA = "0x18790A1C0")]
		public void MRHINPLPLDN(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x790A3F0", Offset = "0x79093F0", VA = "0x18790A3F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x790A740", Offset = "0x7909740", VA = "0x18790A740")]
		public void VCGNTGOKDUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public YWDVLYKTAKL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class QKOQEDQCMLT
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> PUJZTGUIOVG;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7904B60", Offset = "0x7903B60", VA = "0x187904B60")]
		public static IPEndPoint DRWFEYYSGLY(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7904DA0", Offset = "0x7903DA0", VA = "0x187904DA0")]
		public static IPAddress ICOAMPJUZIJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7904F70", Offset = "0x7903F70", VA = "0x187904F70")]
		public static IPAddress ICOAMPJUZIJ(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7905000", Offset = "0x7904000", VA = "0x187905000")]
		internal static int OLTYBIWXHFH(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3900", Offset = "0x3CB2900", VA = "0x183CB3900")]
		internal static T[] RGNTJPPFPTC<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class SRXSKFFTXYK : BWLBIUHXSXJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private DBGLIDKCZSE _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7904AF0", Offset = "0x7903AF0", VA = "0x187904AF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7904AD0", Offset = "0x7903AD0", VA = "0x187904AD0")]
			public void RTFNZEQTDKX(DBGLIDKCZSE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7904A60", Offset = "0x7903A60", VA = "0x187904A60")]
			public bool LATFDPKDNPG(long a, ZOINZCJBRMU b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7904A10", Offset = "0x7903A10", VA = "0x187904A10")]
			public bool Clear(ZOINZCJBRMU peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly DBGLIDKCZSE TYPOPZLFTUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] PLIFFORFKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly DBGLIDKCZSE[] MJKLKDNIDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] DKIBZRVIREC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int EMEJVQNLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int OBTIJIROWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int ZKRHEUCRNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int HJLAPLHGVFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool UEXTSJEFMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod HCKLSTOSGXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool MZVBGNFXXWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int FVHSJIVMYYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte QKMBYROWFBZ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int VTQIPLQPVUU
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7907B50", Offset = "0x7906B50", VA = "0x187907B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7907B60", Offset = "0x7906B60", VA = "0x187907B60")]
		public SRXSKFFTXYK(ZOINZCJBRMU a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7907300", Offset = "0x7906300", VA = "0x187907300")]
		private void CDDMRLCTVYH(DBGLIDKCZSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7907680", Offset = "0x7906680", VA = "0x187907680", Slot = "4")]
		protected override bool DPXIJTKOFLR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7906D00", Offset = "0x7905D00", VA = "0x187906D00", Slot = "5")]
		public override bool AWDLPRTIKLQ(DBGLIDKCZSE a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class SKZNPLNKXTJ : BWLBIUHXSXJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int QBWNZZLFHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort OBTIJIROWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool JHBZTQODAVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private DBGLIDKCZSE NABPPMZBEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly DBGLIDKCZSE SCEIVNFEVDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool NSJMEDMKDWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte QKMBYROWFBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long ZLQPJLOTKHX;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7906C40", Offset = "0x7905C40", VA = "0x187906C40")]
		public SKZNPLNKXTJ(ZOINZCJBRMU a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7906780", Offset = "0x7905780", VA = "0x187906780", Slot = "4")]
		protected override bool DPXIJTKOFLR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7906500", Offset = "0x7905500", VA = "0x187906500", Slot = "5")]
		public override bool AWDLPRTIKLQ(DBGLIDKCZSE a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class UXRAELGQOLA
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
		[Cpp2IlInjected.Address(RVA = "0x78F73C0", Offset = "0x78F63C0", VA = "0x1878F73C0")]
		private static void ELNSGXTLQZF(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7908010", Offset = "0x7907010", VA = "0x187908010")]
		private static void ELNSGXTLQZF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7908080", Offset = "0x7907080", VA = "0x187908080")]
		public static void ELNSGXTLQZF(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7908150", Offset = "0x7907150", VA = "0x187908150")]
		public static void OOTZXUDEDPE(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x79080D0", Offset = "0x79070D0", VA = "0x1879080D0")]
		public static void OOTZXUDEDPE(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7908080", Offset = "0x7907080", VA = "0x187908080")]
		public static void OOTZXUDEDPE(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7908080", Offset = "0x7907080", VA = "0x187908080")]
		public static void OOTZXUDEDPE(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7908010", Offset = "0x7907010", VA = "0x187908010")]
		public static void OOTZXUDEDPE(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7908010", Offset = "0x7907010", VA = "0x187908010")]
		public static void OOTZXUDEDPE(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x79080C0", Offset = "0x79070C0", VA = "0x1879080C0")]
		public static void OOTZXUDEDPE(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x79080C0", Offset = "0x79070C0", VA = "0x1879080C0")]
		public static void OOTZXUDEDPE(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class XEAYCCLKMAX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] EHNGONPJQQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int JRFHXJQBPRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int VVJUFLJIHCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int CQKYTVUFEUN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] GUXOYKBUQRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int RGTGWICQEHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int BVEYDFQYQWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7909750", Offset = "0x7908750", VA = "0x187909750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool YWGMFOQGOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A21FD0", Offset = "0x2A20FD0", VA = "0x182A21FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int UHDXSOZRRKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x79099B0", Offset = "0x79089B0", VA = "0x1879099B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7909B10", Offset = "0x7908B10", VA = "0x187909B10")]
		public void XKFAAJFQEFQ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public XEAYCCLKMAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7909C20", Offset = "0x7908C20", VA = "0x187909C20")]
		public XEAYCCLKMAX(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7909B50", Offset = "0x7908B50", VA = "0x187909B50")]
		public IPEndPoint XWQTBWVTQDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7909390", Offset = "0x7908390", VA = "0x187909390")]
		public byte ATGIXFYQAQR()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7909390", Offset = "0x7908390", VA = "0x187909390")]
		public sbyte FPHAVUXYALM()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FE30", Offset = "0x3F4EE30", VA = "0x183F4FE30")]
		public a[] WSFBGWOXTMM<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x79099F0", Offset = "0x79089F0", VA = "0x1879099F0")]
		public bool[] SKCVJZVVQQM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7909970", Offset = "0x7908970", VA = "0x187909970")]
		public ushort[] RNZSKMFIIIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7909AA0", Offset = "0x7908AA0", VA = "0x187909AA0")]
		public short[] TXHQMPBLYDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x79096A0", Offset = "0x79086A0", VA = "0x1879096A0")]
		public int[] JHPEZOTMCMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7909490", Offset = "0x7908490", VA = "0x187909490")]
		public uint[] DJENEXULZAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7909510", Offset = "0x7908510", VA = "0x187909510")]
		public float[] EVRUJHHQOBS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7909BE0", Offset = "0x7908BE0", VA = "0x187909BE0")]
		public double[] YABVYYICHTN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7909620", Offset = "0x7908620", VA = "0x187909620")]
		public long[] HHQLYNGXGSK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x79094D0", Offset = "0x79084D0", VA = "0x1879094D0")]
		public ulong[] DYFHEVDFZEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7909550", Offset = "0x7908550", VA = "0x187909550")]
		public string[] GJUEFWRVCWD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7909710", Offset = "0x7908710", VA = "0x187909710")]
		public bool NGDPMFXEMFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x79093D0", Offset = "0x79083D0", VA = "0x1879093D0")]
		public char BJAFZKWTEYD()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x79093D0", Offset = "0x79083D0", VA = "0x1879093D0")]
		public ushort OGXGTQGWTKU()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x79093D0", Offset = "0x79083D0", VA = "0x1879093D0")]
		public short ZGIIAWMYUFR()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x79096E0", Offset = "0x79086E0", VA = "0x1879096E0")]
		public long WVVLAAZHNEJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x79096E0", Offset = "0x79086E0", VA = "0x1879096E0")]
		public ulong MVSCMEQYSOI()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7909400", Offset = "0x7908400", VA = "0x187909400")]
		public int BJLRNAIVRDC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7909400", Offset = "0x7908400", VA = "0x187909400")]
		public uint OSHQYYWNSFZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x79099C0", Offset = "0x79089C0", VA = "0x1879099C0")]
		public float SGIKCFVKAYH()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7909AE0", Offset = "0x7908AE0", VA = "0x187909AE0")]
		public double UHQBEJRSGCS()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7909760", Offset = "0x7908760", VA = "0x187909760")]
		public string OBSIVEYETQK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7909A30", Offset = "0x7908A30", VA = "0x187909A30")]
		public ArraySegment<byte> SLPJRUOTDCH(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7909660", Offset = "0x7908660", VA = "0x187909660")]
		public sbyte[] HQDRBPNTKBR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7909450", Offset = "0x7908450", VA = "0x187909450")]
		public byte[] DBQHIBZYLNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7909430", Offset = "0x7908430", VA = "0x187909430")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class VDWAUHVHOPV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] EHNGONPJQQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int JRFHXJQBPRH;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int UINYFEMSQEO = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool IUJOBATPHFL;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding MURUIAOKNWX;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int PEICOBEYBGU = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] TLMHVKWRWKF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] JBMRVYMFEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7908F30", Offset = "0x7907F30", VA = "0x187908F30")]
		public VDWAUHVHOPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7908E90", Offset = "0x7907E90", VA = "0x187908E90")]
		public VDWAUHVHOPV(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7908DA0", Offset = "0x7907DA0", VA = "0x187908DA0")]
		public static VDWAUHVHOPV UMISJWKDCNC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x79086A0", Offset = "0x79076A0", VA = "0x1879086A0")]
		public void EZMFMGVRHHU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A5C0", Offset = "0x2A995C0", VA = "0x182A9A5C0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7908870", Offset = "0x7907870", VA = "0x187908870")]
		public void OHNODJPVCXM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7908740", Offset = "0x7907740", VA = "0x187908740")]
		public void OHNODJPVCXM(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7908B20", Offset = "0x7907B20", VA = "0x187908B20")]
		public void OHNODJPVCXM(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7908B20", Offset = "0x7907B20", VA = "0x187908B20")]
		public void OHNODJPVCXM(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7908B70", Offset = "0x7907B70", VA = "0x187908B70")]
		public void OHNODJPVCXM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7908B70", Offset = "0x7907B70", VA = "0x187908B70")]
		public void OHNODJPVCXM(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7908800", Offset = "0x7907800", VA = "0x187908800")]
		public void OHNODJPVCXM(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7908800", Offset = "0x7907800", VA = "0x187908800")]
		public void OHNODJPVCXM(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7908800", Offset = "0x7907800", VA = "0x187908800")]
		public void OHNODJPVCXM(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7908C00", Offset = "0x7907C00", VA = "0x187908C00")]
		public void OHNODJPVCXM(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7908C00", Offset = "0x7907C00", VA = "0x187908C00")]
		public void OHNODJPVCXM(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7908790", Offset = "0x7907790", VA = "0x187908790")]
		public void OHNODJPVCXM(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x79085C0", Offset = "0x79075C0", VA = "0x1879085C0")]
		public void PRAAAXVMCFM(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x79085C0", Offset = "0x79075C0", VA = "0x1879085C0")]
		public void YJLDJTSTQMV(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7908D40", Offset = "0x7907D40", VA = "0x187908D40")]
		public void OHNODJPVCXM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7908170", Offset = "0x7907170", VA = "0x187908170")]
		public void DPZLXITXFKD(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7908250", Offset = "0x7907250", VA = "0x187908250")]
		public void DPZLXITXFKD(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7908410", Offset = "0x7907410", VA = "0x187908410")]
		public void DPZLXITXFKD(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7908410", Offset = "0x7907410", VA = "0x187908410")]
		public void DPZLXITXFKD(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7908410", Offset = "0x7907410", VA = "0x187908410")]
		public void DPZLXITXFKD(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7908250", Offset = "0x7907250", VA = "0x187908250")]
		public void DPZLXITXFKD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7908250", Offset = "0x7907250", VA = "0x187908250")]
		public void DPZLXITXFKD(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7908330", Offset = "0x7907330", VA = "0x187908330")]
		public void DPZLXITXFKD(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7908330", Offset = "0x7907330", VA = "0x187908330")]
		public void DPZLXITXFKD(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x79085C0", Offset = "0x79075C0", VA = "0x1879085C0")]
		public void DPZLXITXFKD(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x79084F0", Offset = "0x79074F0", VA = "0x1879084F0")]
		public void DPZLXITXFKD(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7908C70", Offset = "0x7907C70", VA = "0x187908C70")]
		public void OHNODJPVCXM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7908C60", Offset = "0x7907C60", VA = "0x187908C60")]
		public void OHNODJPVCXM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7908910", Offset = "0x7907910", VA = "0x187908910")]
		public void OHNODJPVCXM(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class RDGBZRNGJRK
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class ZTWBUMLDAGO<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong HGJTEJGBOEM;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x41DC220", Offset = "0x41DB220", VA = "0x1841DC220")]
			static ZTWBUMLDAGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(XEAYCCLKMAX reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class FYMBHEPZRRX<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public RDGBZRNGJRK FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a BREIUMGBLAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> SIMWXPWUAEZ;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public FYMBHEPZRRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x50E2480", Offset = "0x50E1480", VA = "0x1850E2480")]
			internal void BMPCIVDWRIG(XEAYCCLKMAX a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class BOTNHXNJQMZ<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public RDGBZRNGJRK FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a BREIUMGBLAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> SIMWXPWUAEZ;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public BOTNHXNJQMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x74AFD00", Offset = "0x74AED00", VA = "0x1874AFD00")]
			internal void BMPCIVDWRIG(XEAYCCLKMAX a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly FXPDFOOQNOY CIDEKLFBYAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> BDGAKLLCNPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly VDWAUHVHOPV XFVSMNGAEIS;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7905CA0", Offset = "0x7904CA0", VA = "0x187905CA0")]
		public RDGBZRNGJRK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA8C0", Offset = "0x3CB98C0", VA = "0x183CBA8C0", Slot = "4")]
		protected virtual ulong TDEPNOOTIBB<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7905B50", Offset = "0x7904B50", VA = "0x187905B50", Slot = "5")]
		protected virtual SubscribeDelegate GRCJCISUTGU(XEAYCCLKMAX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA9D0", Offset = "0x3CB99D0", VA = "0x183CBA9D0", Slot = "6")]
		protected virtual void WDXQMUQGYBO<b>(VDWAUHVHOPV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7905C20", Offset = "0x7904C20", VA = "0x187905C20")]
		public void IWFXCVRKLIN(XEAYCCLKMAX a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA940", Offset = "0x3CB9940", VA = "0x183CBA940")]
		public void UHEUJRAAHAM<j>(VDWAUHVHOPV a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7905B00", Offset = "0x7904B00", VA = "0x187905B00")]
		public void FUQGEYPCLDD(XEAYCCLKMAX a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA740", Offset = "0x3CB9740", VA = "0x183CBA740")]
		public void NDHAATNODTQ<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3CBA740", Offset = "0x3CB9740", VA = "0x183CBA740")]
		public void NDHAATNODTQ<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7901FE0", Offset = "0x7900FE0", VA = "0x187901FE0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x79049B0", Offset = "0x79039B0", VA = "0x1879049B0")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class FXPDFOOQNOY
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
		private abstract class CYXUSJBYHZK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType OVCFCLRZRCZ;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4236570", Offset = "0x4235570", VA = "0x184236570", Slot = "4")]
			public virtual void RTFNZEQTDKX(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void HCZJXBJJVIF(a a, XEAYCCLKMAX b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void UHEUJRAAHAM(a a, VDWAUHVHOPV b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void TYYGJGVICDE(a a, XEAYCCLKMAX b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void UOYTBXHSIAF(a a, VDWAUHVHOPV b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void UZNGZXMDJGV(a a, XEAYCCLKMAX b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void MWUWFZKNQGM(a a, VDWAUHVHOPV b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			protected CYXUSJBYHZK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class REWIMSYHGXH<a, b> : CYXUSJBYHZK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> KGHZMQDJHLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> FVRNQDXYLIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> OJDDRKMATXT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> MMCJXBOMLZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> LKJIKLWAYVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> MXXROWSGXQS;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5EC5690", Offset = "0x5EC4690", VA = "0x185EC5690", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5EC5690", Offset = "0x5EC4690", VA = "0x185EC5690", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4A80", Offset = "0x5EC3A80", VA = "0x185EC4A80", Slot = "9")]
			public override void UZNGZXMDJGV(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4A80", Offset = "0x5EC3A80", VA = "0x185EC4A80", Slot = "10")]
			public override void MWUWFZKNQGM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5EC47B0", Offset = "0x5EC37B0", VA = "0x185EC47B0")]
			protected b[] FHMDBABGNCW(a a, XEAYCCLKMAX b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4630", Offset = "0x5EC3630", VA = "0x185EC4630")]
			protected b[] EZMPXQHAVFH(a a, VDWAUHVHOPV b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4B50", Offset = "0x5EC3B50", VA = "0x185EC4B50", Slot = "4")]
			public override void RTFNZEQTDKX(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5EC5760", Offset = "0x5EC4760", VA = "0x185EC5760")]
			protected REWIMSYHGXH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class PNKSEFIAKXE<a, b> : REWIMSYHGXH<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void YLTJTAHUCGD(XEAYCCLKMAX a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void TLKVNVCYDUC(VDWAUHVHOPV a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x5DAF0F0", Offset = "0x5DAE0F0", VA = "0x185DAF0F0", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x5DAF3F0", Offset = "0x5DAE3F0", VA = "0x185DAF3F0", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x5DAF1F0", Offset = "0x5DAE1F0", VA = "0x185DAF1F0", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5DAF650", Offset = "0x5DAE650", VA = "0x185DAF650", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x5DAF8F0", Offset = "0x5DAE8F0", VA = "0x185DAF8F0")]
			protected PNKSEFIAKXE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class LERBYONWBDH<a> : REWIMSYHGXH<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x55CE810", Offset = "0x55CD810", VA = "0x1855CE810", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x55CEC00", Offset = "0x55CDC00", VA = "0x1855CEC00", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x55CEAA0", Offset = "0x55CDAA0", VA = "0x1855CEAA0", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x418F0C0", Offset = "0x418E0C0", VA = "0x18418F0C0", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public LERBYONWBDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class LUXCGRPOWZM<a> : REWIMSYHGXH<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x55CE810", Offset = "0x55CD810", VA = "0x1855CE810", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x55CEC00", Offset = "0x55CDC00", VA = "0x1855CEC00", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x55DE3A0", Offset = "0x55DD3A0", VA = "0x1855DE3A0", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x418F0C0", Offset = "0x418E0C0", VA = "0x18418F0C0", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public LUXCGRPOWZM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class CUBMTBGTMCO<a> : REWIMSYHGXH<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4233CF0", Offset = "0x4232CF0", VA = "0x184233CF0", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x42340E0", Offset = "0x42330E0", VA = "0x1842340E0", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4233E70", Offset = "0x4232E70", VA = "0x184233E70", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4234120", Offset = "0x4233120", VA = "0x184234120", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public CUBMTBGTMCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class OCWQFAPACZD<a> : REWIMSYHGXH<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4233CF0", Offset = "0x4232CF0", VA = "0x184233CF0", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x42340E0", Offset = "0x42330E0", VA = "0x1842340E0", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5CBA990", Offset = "0x5CB9990", VA = "0x185CBA990", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4234120", Offset = "0x4233120", VA = "0x184234120", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public OCWQFAPACZD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class UWSIXGRNXJC<a> : REWIMSYHGXH<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x62977C0", Offset = "0x62967C0", VA = "0x1862977C0", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x6297BB0", Offset = "0x6296BB0", VA = "0x186297BB0", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x65B16A0", Offset = "0x65B06A0", VA = "0x1865B16A0", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x540D490", Offset = "0x540C490", VA = "0x18540D490", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public UWSIXGRNXJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class TGCVZJZGSIZ<a> : REWIMSYHGXH<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x62977C0", Offset = "0x62967C0", VA = "0x1862977C0", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x6297BB0", Offset = "0x6296BB0", VA = "0x186297BB0", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6297A50", Offset = "0x6296A50", VA = "0x186297A50", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x540D490", Offset = "0x540C490", VA = "0x18540D490", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public TGCVZJZGSIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class ZLMRZBTKVLC<a> : REWIMSYHGXH<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x41C8370", Offset = "0x41C7370", VA = "0x1841C8370", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x41C8630", Offset = "0x41C7630", VA = "0x1841C8630", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x41C83C0", Offset = "0x41C73C0", VA = "0x1841C83C0", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x41C8780", Offset = "0x41C7780", VA = "0x1841C8780", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public ZLMRZBTKVLC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class VUQRDHJDHMH<a> : REWIMSYHGXH<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x41C8370", Offset = "0x41C7370", VA = "0x1841C8370", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x41C8630", Offset = "0x41C7630", VA = "0x1841C8630", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x66F6160", Offset = "0x66F5160", VA = "0x1866F6160", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x41C8780", Offset = "0x41C7780", VA = "0x1841C8780", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public VUQRDHJDHMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class XWDVRHERFWC<a> : REWIMSYHGXH<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x418EC90", Offset = "0x418DC90", VA = "0x18418EC90", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x418F080", Offset = "0x418E080", VA = "0x18418F080", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x418EF20", Offset = "0x418DF20", VA = "0x18418EF20", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x418F0C0", Offset = "0x418E0C0", VA = "0x18418F0C0", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public XWDVRHERFWC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class JCXVBDOLDZV<a> : REWIMSYHGXH<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x540CF50", Offset = "0x540BF50", VA = "0x18540CF50", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x540D230", Offset = "0x540C230", VA = "0x18540D230", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x540D1E0", Offset = "0x540C1E0", VA = "0x18540D1E0", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x540D490", Offset = "0x540C490", VA = "0x18540D490", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public JCXVBDOLDZV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class CNTBSNBUPFU<a> : REWIMSYHGXH<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x4225720", Offset = "0x4224720", VA = "0x184225720", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x42259E0", Offset = "0x42249E0", VA = "0x1842259E0", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x4225770", Offset = "0x4224770", VA = "0x184225770", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x41C8780", Offset = "0x41C7780", VA = "0x1841C8780", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			public CNTBSNBUPFU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class ZDDDZEVOIXE<a> : PNKSEFIAKXE<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x41A52D0", Offset = "0x41A42D0", VA = "0x1841A52D0", Slot = "12")]
			protected override void TLKVNVCYDUC(VDWAUHVHOPV a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x41A5300", Offset = "0x41A4300", VA = "0x1841A5300", Slot = "11")]
			protected override void YLTJTAHUCGD(XEAYCCLKMAX a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x41A5330", Offset = "0x41A4330", VA = "0x1841A5330")]
			public ZDDDZEVOIXE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class TLTEQWZLONY<a> : PNKSEFIAKXE<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x62C5380", Offset = "0x62C4380", VA = "0x1862C5380", Slot = "12")]
			protected override void TLKVNVCYDUC(VDWAUHVHOPV a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x62C53B0", Offset = "0x62C43B0", VA = "0x1862C53B0", Slot = "11")]
			protected override void YLTJTAHUCGD(XEAYCCLKMAX a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x41A5330", Offset = "0x41A4330", VA = "0x1841A5330")]
			public TLTEQWZLONY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class PHYRGEUECIL<a> : REWIMSYHGXH<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int WCTPPXGCRVK;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5DA3F80", Offset = "0x5DA2F80", VA = "0x185DA3F80")]
			public PHYRGEUECIL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5DA39C0", Offset = "0x5DA29C0", VA = "0x185DA39C0", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5DA3DD0", Offset = "0x5DA2DD0", VA = "0x185DA3DD0", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5DA3C60", Offset = "0x5DA2C60", VA = "0x185DA3C60", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5DA3F30", Offset = "0x5DA2F30", VA = "0x185DA3F30", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class THAGUQWZOMN<a> : CYXUSJBYHZK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo JFAQWMBNHIY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type XVYCRODXNNG;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x62AB4B0", Offset = "0x62AA4B0", VA = "0x1862AB4B0")]
			public THAGUQWZOMN(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x62AB1D0", Offset = "0x62AA1D0", VA = "0x1862AB1D0", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x62AB310", Offset = "0x62AA310", VA = "0x1862AB310", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x62AB2C0", Offset = "0x62AA2C0", VA = "0x1862AB2C0", Slot = "7")]
			public override void TYYGJGVICDE(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x62AB2C0", Offset = "0x62AA2C0", VA = "0x1862AB2C0", Slot = "8")]
			public override void UOYTBXHSIAF(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x62AB270", Offset = "0x62AA270", VA = "0x1862AB270", Slot = "9")]
			public override void UZNGZXMDJGV(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x62AB270", Offset = "0x62AA270", VA = "0x1862AB270", Slot = "10")]
			public override void MWUWFZKNQGM(a a, VDWAUHVHOPV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class GASQUTWZWIO<a> : THAGUQWZOMN<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x51F7CE0", Offset = "0x51F6CE0", VA = "0x1851F7CE0")]
			public GASQUTWZWIO(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x51F7970", Offset = "0x51F6970", VA = "0x1851F7970", Slot = "5")]
			public override void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x51F7B40", Offset = "0x51F6B40", VA = "0x1851F7B40", Slot = "6")]
			public override void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class UEFDMDVANNO<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static UEFDMDVANNO<a> HNQVBJEYTYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly CYXUSJBYHZK<a>[] WVNDRQNEQBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int ESASIPUNXBW;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x64EFFC0", Offset = "0x64EEFC0", VA = "0x1864EFFC0")]
			public UEFDMDVANNO(List<CYXUSJBYHZK<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x64EFE70", Offset = "0x64EEE70", VA = "0x1864EFE70")]
			public void UHEUJRAAHAM(a a, VDWAUHVHOPV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x64EFBF0", Offset = "0x64EEBF0", VA = "0x1864EFBF0")]
			public void HCZJXBJJVIF(a a, XEAYCCLKMAX b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class FIGGFGLCBOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract CYXUSJBYHZK<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private VDWAUHVHOPV MRFSKPXDBVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int RNRGOYPQLZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, FIGGFGLCBOK> VMXDABERSLF;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7901C10", Offset = "0x7900C10", VA = "0x187901C10")]
		public FXPDFOOQNOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39841F0", Offset = "0x39831F0", VA = "0x1839841F0")]
		private UEFDMDVANNO<d> XICUOKKDYXH<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3984FF0", Offset = "0x3983FF0", VA = "0x183984FF0")]
		public void YTBQRMTMKZK<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3983290", Offset = "0x3982290", VA = "0x183983290")]
		public bool Deserialize<T>(XEAYCCLKMAX reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3983310", Offset = "0x3982310", VA = "0x183983310")]
		public void LDGVYQLXUAF<f>(VDWAUHVHOPV a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class AWBVXLDAZHT
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime KGGJTFCNRCK;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] ZYPCUEDVLLW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator HEHAVPMTBLS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x78F7F30", Offset = "0x78F6F30", VA = "0x1878F7F30")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int NHOIMXYLPAW
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x78F8420", Offset = "0x78F7420", VA = "0x1878F8420")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x78F8450", Offset = "0x78F7450", VA = "0x1878F8450")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode EBHZNDTKXHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x78F7E20", Offset = "0x78F6E20", VA = "0x1878F7E20")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x78F8320", Offset = "0x78F7320", VA = "0x1878F8320")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int DYSMHIDWPIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x78F7F00", Offset = "0x78F6F00", VA = "0x1878F7F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint LFLHGGXDUED
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x78F7930", Offset = "0x78F6930", VA = "0x1878F7930")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? VXTDSPUCGWN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x78F7740", Offset = "0x78F6740", VA = "0x1878F7740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? JSSRVLDVRZI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x78F82F0", Offset = "0x78F72F0", VA = "0x1878F82F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? PUQPHPVDCCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x78F7550", Offset = "0x78F6550", VA = "0x1878F7550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x78F7F60", Offset = "0x78F6F60", VA = "0x1878F7F60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? YMIFGDVPSHT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6080", Offset = "0xCD5080", VA = "0x180CD6080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x10244D0", Offset = "0x10234D0", VA = "0x1810244D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x78F85B0", Offset = "0x78F75B0", VA = "0x1878F85B0")]
		public AWBVXLDAZHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x78F88C0", Offset = "0x78F78C0", VA = "0x1878F88C0")]
		internal AWBVXLDAZHT(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x78F7D10", Offset = "0x78F6D10", VA = "0x1878F7D10")]
		public static AWBVXLDAZHT LPTXBLAIJNL(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x78F7990", Offset = "0x78F6990", VA = "0x1878F7990")]
		internal void JYOVKHLQVNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x78F7770", Offset = "0x78F6770", VA = "0x1878F7770")]
		private void FJVSAVKLKFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x78F8120", Offset = "0x78F7120", VA = "0x1878F8120")]
		private DateTime? NUPHPPKFYDG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x78F7580", Offset = "0x78F6580", VA = "0x1878F7580")]
		private void CRKGGAPNIYI(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x78F7E50", Offset = "0x78F6E50", VA = "0x1878F7E50")]
		private ulong MRHQAYSGKQE(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x78F8360", Offset = "0x78F7360", VA = "0x1878F8360")]
		private void TFBMTGARFOY(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x78F84F0", Offset = "0x78F74F0", VA = "0x1878F84F0")]
		private uint YQJUGVINJFF(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x77C5800", Offset = "0x77C4800", VA = "0x1877C5800")]
		private static uint WNPPRFWSAVI(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x78F8490", Offset = "0x78F7490", VA = "0x1878F8490")]
		private static ulong WNPPRFWSAVI(ulong a)
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
	internal sealed class GAUPRYYWOVM
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int KEYHNGRRGOP = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int DZDTYLGXKYC = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int JJFSVNMZRQR = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint TSWSGLAGYFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int BHFGQNLVPFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int FECODVTZWCD;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool LKUFLTUWUVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7901CA0", Offset = "0x7900CA0", VA = "0x187901CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7901CB0", Offset = "0x7900CB0", VA = "0x187901CB0")]
		public bool VANHJDNTSGH(RFUVXOKZNLH a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class OTUTMCIUWBO : RFUVXOKZNLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket YOBKYVQRJLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly CQQOUEVPJTR IKDUYNSXSED;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short IZZXLQSRZBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x79046D0", Offset = "0x79036D0", VA = "0x1879046D0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int WYBUSUZFFUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x79046F0", Offset = "0x79036F0", VA = "0x1879046F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint AVQCVUJQIEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x7904840", Offset = "0x7903840", VA = "0x187904840", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily VOENKEBKMHR
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32B0DD0", Offset = "0x32AFDD0", VA = "0x1832B0DD0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7904860", Offset = "0x7903860", VA = "0x187904860")]
		public OTUTMCIUWBO(AddressFamily a, CQQOUEVPJTR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x79040F0", Offset = "0x79030F0", VA = "0x1879040F0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7904710", Offset = "0x7903710", VA = "0x187904710", Slot = "9")]
		public int RVWRLBYDBWG(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7904750", Offset = "0x7903750", VA = "0x187904750", Slot = "10")]
		public int SOHEMLCKGZU(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x79046B0", Offset = "0x79036B0", VA = "0x1879046B0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface RFUVXOKZNLH
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short IZZXLQSRZBR
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int WYBUSUZFFUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint AVQCVUJQIEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily VOENKEBKMHR
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
		int RVWRLBYDBWG(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int SOHEMLCKGZU(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x7903D80", Offset = "0x7902D80", VA = "0x187903D80")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7903E20", Offset = "0x7902E20", VA = "0x187903E20")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x16BBF00", Offset = "0x16BAF00", VA = "0x1816BBF00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7903C90", Offset = "0x7902C90", VA = "0x187903C90", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7903CD0", Offset = "0x7902CD0", VA = "0x187903CD0", Slot = "0")]
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
	public class IMIAPGWYFEY
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string REGYAAVNMUM = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int RFUWHADRSVW = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int MBHURFRGBZQ = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int GJZXDOBYHNK = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> RAGDLSFFKJH;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback RHZNKBQPRAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int ORIPZCNBOYE;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		internal void NGSMJZRFJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		internal void YOGPSDEZOBY(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class EDZVWQFNRVF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int KUZVYIFBHLW;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
		protected EDZVWQFNRVF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void PNXDYLCRSTN(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void MVNTHOQEPLA(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class QMOXXCAYVKD : EDZVWQFNRVF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] VBWKGQRZQUI;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator GZYQKCTCEOK;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A010", Offset = "0x2B99010", VA = "0x182B9A010")]
		public QMOXXCAYVKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x79050C0", Offset = "0x79040C0", VA = "0x1879050C0")]
		public void CNAVMQXWUFV(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x79059C0", Offset = "0x79049C0", VA = "0x1879059C0")]
		public void XDXZIOZGQOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7905570", Offset = "0x7904570", VA = "0x187905570", Slot = "4")]
		public override void PNXDYLCRSTN(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7905270", Offset = "0x7904270", VA = "0x187905270", Slot = "5")]
		public override void MVNTHOQEPLA(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class EWHAFHDMXYK
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr LJICLUMXWIO;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x790EB00", Offset = "0x790DB00", VA = "0x18790EB00")]
			[BurstDiscard]
			private static void FMUAVNHLTMG(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x790E980", Offset = "0x790D980", VA = "0x18790E980")]
			private static IntPtr COKLGEUWUXC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x790EC90", Offset = "0x790DC90", VA = "0x18790EC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7906450", Offset = "0x7905450", VA = "0x187906450")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x79064D0", Offset = "0x79054D0", VA = "0x1879064D0")]
		private uint VMJPIOZCHLJ(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x78F6F70", Offset = "0x78F5F70", VA = "0x1878F6F70")]
		private void ATKVSOKLUCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x78F71B0", Offset = "0x78F61B0", VA = "0x1878F71B0")]
		private void UGLUBCSRSUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x78F7020", Offset = "0x78F6020", VA = "0x1878F7020")]
		private void HEMFTTHUJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x78F70B0", Offset = "0x78F60B0", VA = "0x1878F70B0")]
		private void NENOZZFFBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7905DF0", Offset = "0x7904DF0", VA = "0x187905DF0")]
		private void BTEMRCTYWOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7905EC0", Offset = "0x7904EC0", VA = "0x187905EC0")]
		private unsafe void KUSIAXECYFR(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7906390", Offset = "0x7905390", VA = "0x187906390")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void LIWJOBQAUMG([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x79062E0", Offset = "0x79052E0", VA = "0x1879062E0")]
		public static void LIWJOBQAUMG(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x79063A0", Offset = "0x79053A0", VA = "0x1879063A0")]
		public static void QLXCFHWUOOS(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7905E50", Offset = "0x7904E50", VA = "0x187905E50")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void IMCOOWEUIBL([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x790EFA0", Offset = "0x790DFA0", VA = "0x18790EFA0")]
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
