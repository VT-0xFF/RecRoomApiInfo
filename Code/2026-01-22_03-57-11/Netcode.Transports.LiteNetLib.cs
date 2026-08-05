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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, IPADWAPEAUD
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
		private NetworkManager PNDHMKJYGTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool WOLXCSCLFFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, YVEZMVSSWEO> AXEHLGWKVKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FQKDQTMBFMJ MJOSWXCIOFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch THZMDMTRSFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] PLJSNWJHLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType YYUSIXWKYJP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int XUPAKXIWNXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x756EC90", Offset = "0x756D490", VA = "0x18756EC90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x756EC40", Offset = "0x756D440", VA = "0x18756EC40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x756E0F0", Offset = "0x756C8F0", VA = "0x18756E0F0")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x756E0D0", Offset = "0x756C8D0", VA = "0x18756E0D0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x756DFA0", Offset = "0x756C7A0", VA = "0x18756DFA0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x756EB50", Offset = "0x756D350", VA = "0x18756EB50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x756E2D0", Offset = "0x756CAD0", VA = "0x18756E2D0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x756E090", Offset = "0x756C890", VA = "0x18756E090", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x756E5A0", Offset = "0x756CDA0", VA = "0x18756E5A0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x756E930", Offset = "0x756D130", VA = "0x18756E930", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x756D730", Offset = "0x756BF30", VA = "0x18756D730", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x756D640", Offset = "0x756BE40", VA = "0x18756D640", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x756D900", Offset = "0x756C100", VA = "0x18756D900", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x756E530", Offset = "0x756CD30", VA = "0x18756E530", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x756DA70", Offset = "0x756C270", VA = "0x18756DA70", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x756DC80", Offset = "0x756C480", VA = "0x18756DC80")]
		private DeliveryMethod JOEIRXUYMVC(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x756D840", Offset = "0x756C040", VA = "0x18756D840", Slot = "16")]
		private void FXAVCCHJZQH(YVEZMVSSWEO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x756D9A0", Offset = "0x756C1A0", VA = "0x18756D9A0", Slot = "17")]
		private void HZIVSZNYOQP(YVEZMVSSWEO a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "18")]
		private void RRSJIEMYNVS(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x756DD50", Offset = "0x756C550", VA = "0x18756DD50", Slot = "19")]
		private void MXACXIJWJQH(YVEZMVSSWEO a, KWEBVEHVULD b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x756E200", Offset = "0x756CA00", VA = "0x18756E200")]
		private void SGGTYQYRSWI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "20")]
		private void QHWFQYLADDZ(IPEndPoint a, KWEBVEHVULD b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "21")]
		private void UDKNCIASMFT(YVEZMVSSWEO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x756D5C0", Offset = "0x756BDC0", VA = "0x18756D5C0", Slot = "22")]
		private void DWQDMRRKIAR(GRTMSFIQSDO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x756DF70", Offset = "0x756C770", VA = "0x18756DF70")]
		private ulong OPMGKQXXAHQ(YVEZMVSSWEO a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x756DF50", Offset = "0x756C750", VA = "0x18756DF50")]
		private ulong OPMGKQXXAHQ(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x756D620", Offset = "0x756BE20", VA = "0x18756D620")]
		private static int DYOBJCXSQFF(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x756EB70", Offset = "0x756D370", VA = "0x18756EB70")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x756D590", Offset = "0x756BD90", VA = "0x18756D590")]
		[CompilerGenerated]
		private void AAWHAENCQHP(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x756D590", Offset = "0x756BD90", VA = "0x18756D590")]
		[CompilerGenerated]
		private void DXFFYWLNEMU(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class DUNQZJSKCFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly YVEZMVSSWEO MLJCNJUGAMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<QYYKZFGKMNU> DNLBLLIHOSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int TLCNIIZVKAH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int CMICYKKIHHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7562AF0", Offset = "0x75612F0", VA = "0x187562AF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7562C60", Offset = "0x7561460", VA = "0x187562C60")]
		protected DUNQZJSKCFX(YVEZMVSSWEO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7562B80", Offset = "0x7561380", VA = "0x187562B80")]
		public void KPWHCVMWHPQ(QYYKZFGKMNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7562BE0", Offset = "0x75613E0", VA = "0x187562BE0")]
		protected void WXADDRRXRWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7562B40", Offset = "0x7561340", VA = "0x187562B40")]
		public bool HIZAUGRMZTH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool XQUONBIUNCZ();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool MGNKCETUBRK(QYYKZFGKMNU a);
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
	public class GRTMSFIQSDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly FQKDQTMBFMJ BSSTRQXXXKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int DOBMCAWWJGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal ATUAEUSZOQR XAAXUBJVONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint DKJFOBEFBKY;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult XUALJKXXDTA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x136AC40", Offset = "0x1369440", VA = "0x18136AC40")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x136AC30", Offset = "0x1369430", VA = "0x18136AC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x756B4F0", Offset = "0x7569CF0", VA = "0x18756B4F0")]
		internal void HJFCARFDXZZ(ATUAEUSZOQR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x756B550", Offset = "0x7569D50", VA = "0x18756B550")]
		private bool HUVYPEKYAXH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x756B580", Offset = "0x7569D80", VA = "0x18756B580")]
		internal GRTMSFIQSDO(IPEndPoint a, ATUAEUSZOQR b, FQKDQTMBFMJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x756B490", Offset = "0x7569C90", VA = "0x18756B490")]
		public YVEZMVSSWEO Accept()
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
		public KWEBVEHVULD AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IPADWAPEAUD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SWHZCAWUZLT(YVEZMVSSWEO a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VRQRAYDDUDT(YVEZMVSSWEO a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NNLTANAYQEK(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IEWSRZPYMIJ(YVEZMVSSWEO a, KWEBVEHVULD b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RXQROYGYFQJ(IPEndPoint a, KWEBVEHVULD b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NOIAEQOLFSX(YVEZMVSSWEO a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LWIVUUWYJJB(GRTMSFIQSDO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface LBMRLFMHIWK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LKVXKFKMLCP(YVEZMVSSWEO a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface YGIMFQGGNUY
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MGYLNPZGFVF(OSGVFLXEIVN a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ARWLVSRGGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KJUPYGGWRSC(YVEZMVSSWEO a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class ATUAEUSZOQR
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int SCRZCGNJAOP = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long VCYEJFFTXAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte LVNQIMVMSAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] MTCWFOPTKTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly ENYQFYCWRNL AROSVOGBSTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int IVRGNQGSIGK;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75615A0", Offset = "0x755FDA0", VA = "0x1875615A0")]
		private ATUAEUSZOQR(long a, byte b, int c, byte[] d, ENYQFYCWRNL e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7561570", Offset = "0x755FD70", VA = "0x187561570")]
		public static int SCGLUFMTCWU(QYYKZFGKMNU a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75611A0", Offset = "0x755F9A0", VA = "0x1875611A0")]
		public static ATUAEUSZOQR FRRCJKWJZOX(QYYKZFGKMNU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7561390", Offset = "0x755FB90", VA = "0x187561390")]
		public static QYYKZFGKMNU HFZENDSMFAF(SQEEUROIYMJ a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class ZQXLQDMMDIQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long VCYEJFFTXAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte LVNQIMVMSAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int IVRGNQGSIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool GTILUBYNMZX;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7577D50", Offset = "0x7576550", VA = "0x187577D50")]
		private ZQXLQDMMDIQ(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7577A60", Offset = "0x7576260", VA = "0x187577A60")]
		public static ZQXLQDMMDIQ FRRCJKWJZOX(QYYKZFGKMNU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7577B60", Offset = "0x7576360", VA = "0x187577B60")]
		public static QYYKZFGKMNU HFZENDSMFAF(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7577C50", Offset = "0x7576450", VA = "0x187577C50")]
		public static QYYKZFGKMNU OZIIBDARBPV(YVEZMVSSWEO a)
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
	public interface BOLWTMGKGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QRVDKCZWDPU(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VJLOCPDDBIY(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class GVTCOSATETM
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
		private class YCNXERCSQJK
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint OAYZITZQKJY
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string LHZDBWYTFRC
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YCNXERCSQJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class OUCMCHJIZCA
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint OAYZITZQKJY
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint ODJCFAKFJOA
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string LHZDBWYTFRC
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OUCMCHJIZCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class OYVVRYRYNKW
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string LHZDBWYTFRC
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool BFDKYZLSDQI
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAB0610", Offset = "0xAAEE10", VA = "0x180AB0610")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OYVVRYRYNKW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly FQKDQTMBFMJ UPFJFNUCMCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> YZOSLAVDJSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> SFTHDTYCNQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly ENYQFYCWRNL KUHRXKJCKRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly SQEEUROIYMJ IYYKPSUUGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly MIYHTNEFYLE FOLGODTFHXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private BOLWTMGKGPF GYSSIZLTLRL;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int JFHPPYIXVYA = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool NWBRVIAELEH;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x756BC00", Offset = "0x756A400", VA = "0x18756BC00")]
		internal GVTCOSATETM(FQKDQTMBFMJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x756BA80", Offset = "0x756A280", VA = "0x18756BA80")]
		internal void YRCBFWYDILB(IPEndPoint a, QYYKZFGKMNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x36C9A90", Offset = "0x36C8290", VA = "0x1836C9A90")]
		private void YTTTAOCXCKJ<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x756B790", Offset = "0x7569F90", VA = "0x18756B790")]
		private void QRVDKCZWDPU(YCNXERCSQJK a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x756B920", Offset = "0x756A120", VA = "0x18756B920")]
		private void QSNOWAONTSS(OUCMCHJIZCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x756B5F0", Offset = "0x7569DF0", VA = "0x18756B5F0")]
		private void IOUIUYXNNPZ(OYVVRYRYNKW a, IPEndPoint b)
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
	public static class LPWBPKURJAT
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] JSQMZVUEZPS;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int FPROUKFJNOO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int UHPQFHWAKBB;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x756C080", Offset = "0x756A880", VA = "0x18756C080")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x756C080", Offset = "0x756A880", VA = "0x18756C080")]
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
	public interface XGVNZTXHMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HJXKWYVHMEB(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class RVNZJYWUTKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static XGVNZTXHMGN PKJXWGLGWGP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object QSWDNSFDYKT;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7571E90", Offset = "0x7570690", VA = "0x187571E90")]
		private static void GROZIPUQAXW(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7572120", Offset = "0x7570920", VA = "0x187572120")]
		internal static void LVJWKBCAHJC(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x75720C0", Offset = "0x75708C0", VA = "0x1875720C0")]
		internal static void JYSNJHXICRA(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7572180", Offset = "0x7570980", VA = "0x187572180")]
		internal static void XXEPURHWJQQ(string a, params object[] args)
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
	public sealed class KWEBVEHVULD : ENYQFYCWRNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private QYYKZFGKMNU PWWYSLSIXUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly FQKDQTMBFMJ SIBMIRDIWKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly JMNPGDUXCYK JLJJEYDIUFX;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x756D310", Offset = "0x756BB10", VA = "0x18756D310")]
		internal KWEBVEHVULD(FQKDQTMBFMJ a, JMNPGDUXCYK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x756D1F0", Offset = "0x756B9F0", VA = "0x18756D1F0")]
		internal void BMJIPHUJMGQ(QYYKZFGKMNU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x756D290", Offset = "0x756BA90", VA = "0x18756D290")]
		internal void UYZGPKWIHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x756D260", Offset = "0x756BA60", VA = "0x18756D260")]
		public void PREBCRVHFGM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class JMNPGDUXCYK
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
		public JMNPGDUXCYK AZNBPSIKRMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType QWAVKIDXYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public YVEZMVSSWEO MLJCNJUGAMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint DKJFOBEFBKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object AQUHDGUGMGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int FIXMMDNDSZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError WDHIZBVYUBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason OYNDXURCXXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GRTMSFIQSDO GRTMSFIQSDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod KHOXWPTEFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte MBAORNYJAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly KWEBVEHVULD PYCRSRJWDTC;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x756C090", Offset = "0x756A890", VA = "0x18756C090")]
		public JMNPGDUXCYK(FQKDQTMBFMJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FQKDQTMBFMJ : IEnumerable<YVEZMVSSWEO>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class JSXLGEHLRUY : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x756C130", Offset = "0x756A930", VA = "0x18756C130", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x756C1A0", Offset = "0x756A9A0", VA = "0x18756C1A0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JSXLGEHLRUY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<YVEZMVSSWEO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly YVEZMVSSWEO _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private YVEZMVSSWEO _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public YVEZMVSSWEO Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xCA48C0", Offset = "0xCA30C0", VA = "0x180CA48C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xCA48C0", Offset = "0xCA30C0", VA = "0x180CA48C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB410", Offset = "0x1AD9C10", VA = "0x181ADB410")]
			public NetPeerEnumerator(YVEZMVSSWEO p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x756F4C0", Offset = "0x756DCC0", VA = "0x18756F4C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x756F510", Offset = "0x756DD10", VA = "0x18756F510", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread IPPQLHNITCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool UHTAGQCKWRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool WJOJUQTMIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private IRTBGLXMWKK VUDGXNLWWNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent GGKXKDGGFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<JMNPGDUXCYK> JIVPSVSANAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<JMNPGDUXCYK> CELZAQQWDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private JMNPGDUXCYK FEKFNWAODSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly IPADWAPEAUD FIETBMYDSWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly LBMRLFMHIWK WSSUXCCVGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly YGIMFQGGNUY VJFVSUPZIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly ARWLVSRGGFM JUSFZWLSEDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, YVEZMVSSWEO> ECIOAQVADBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, GRTMSFIQSDO> JOFRZNSAYSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, FYSPCSZKLLC> GNJNCOKIIUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim KBQQRIOLVNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YVEZMVSSWEO KDJUWRFJNRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int NVJMTXTGDSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<YVEZMVSSWEO> KRUJKYKKTLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private YVEZMVSSWEO[] NNBWPABEBTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly XWHPLYETOZT EYGLSVHMXBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int QOKUTYTFOBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> NIGJXQTROEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte FFRJLZWHIYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object OYWOFGWNTAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool DWEEXSLVEPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool PKRLXDGSRRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int GLBOFWHEFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int LVFSXTKKWAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int BUOAAVWJSAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int MQFUPOSHCZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool FOCDLQDVBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool WVEXJXVMAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int ZQJQSSUSMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int ZWMUBEXHPKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int BSRYDKCMTJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool NWBRVIAELEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool YUVBVPAVWVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool ROOGATOEFCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool NSOHSWUKKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int QWNUFAOJXUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int JVWURIYVOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool ZJQUNRUBTPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly DRRBWLHQTKZ BSFVAYSICNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool VDZPPNMXIXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly GVTCOSATETM GVTCOSATETM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool PJALKQGMQBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode CPRLFASNZJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int ETOEOEEDLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool NVVABUMNOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool AQTQFVXGDZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool QHPOBQOUTPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool UAAOZMHBIDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private QYYKZFGKMNU DLLZBBZYLQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int PQIRLTETRFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object GTFXAOKPJBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private QYYKZFGKMNU UXSAYZTSYCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int BTXZKWEYBKE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int HJEBRQPZUZS = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int BPQLLFIPESB = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private YQKZKJATHYD UIWGXDHQRWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private YQKZKJATHYD UJGURQVLKSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread NJHDIUEHIHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread NIWPOGQMPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint IOCWAHRGCQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint INSIFUDLJTZ;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] NCFFALSPLRP;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] EOQJQELVXLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> CXVUJXHMDZA;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress SOJISVTHTKR;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool VWGNBPUOXSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int GYXDYJBGLZD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ANJTJWSMAHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDB8C0", VA = "0x180BDD0C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBDADF0", Offset = "0xBD95F0", VA = "0x180BDADF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int OENFMPNLXAR
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1F41580", Offset = "0x1F3FD80", VA = "0x181F41580")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x209B330", Offset = "0x2099B30", VA = "0x18209B330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte VIDQCWQKLYW
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB63C20", Offset = "0xB62420", VA = "0x180B63C20")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int XZXVGLZHHDI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x75667B0", Offset = "0x7564FB0", VA = "0x1875667B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short JLHXHWOQGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7565300", Offset = "0x7563B00", VA = "0x187565300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event YVEZMVSSWEO.OnUpdatedMtuDelegate JWFFGTBVHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x756AC60", Offset = "0x7569460", VA = "0x18756AC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7563F80", Offset = "0x7562780", VA = "0x187563F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x756A540", Offset = "0x7568D40", VA = "0x18756A540")]
		public void XAHAEQZXXYX(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75663A0", Offset = "0x7564BA0", VA = "0x1875663A0")]
		public void NDMMILPHKHM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x756A7B0", Offset = "0x7568FB0", VA = "0x18756A7B0")]
		private bool XXFVKRGRSUU(IPEndPoint a, [Out] YVEZMVSSWEO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x75699B0", Offset = "0x75681B0", VA = "0x1875699B0")]
		private void UMTAGQRIMEG(YVEZMVSSWEO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7569930", Offset = "0x7568130", VA = "0x187569930")]
		private void ULYNTRCMUIX(YVEZMVSSWEO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x75664F0", Offset = "0x7564CF0", VA = "0x1875664F0")]
		private void OHGFPLYJHUC(YVEZMVSSWEO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x756ADD0", Offset = "0x75695D0", VA = "0x18756ADD0")]
		public FQKDQTMBFMJ(IPADWAPEAUD a, [Optional] XWHPLYETOZT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7564B70", Offset = "0x7563370", VA = "0x187564B70")]
		internal void KIZEYNYFVHQ(YVEZMVSSWEO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x756A760", Offset = "0x7568F60", VA = "0x18756A760")]
		internal void XQGVCEYQXSW(YVEZMVSSWEO a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x75639B0", Offset = "0x75621B0", VA = "0x1875639B0")]
		internal void AXVHJISZMDO(YVEZMVSSWEO a, DisconnectReason b, SocketError c, QYYKZFGKMNU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7565F30", Offset = "0x7564730", VA = "0x187565F30")]
		private void NAZKEPJISRD(YVEZMVSSWEO a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, QYYKZFGKMNU h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75635E0", Offset = "0x7561DE0", VA = "0x1875635E0")]
		private void ASLAUSJHHAF(JMNPGDUXCYK.EType a, [Optional] YVEZMVSSWEO b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] GRTMSFIQSDO g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] QYYKZFGKMNU j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75643A0", Offset = "0x7562BA0", VA = "0x1875643A0")]
		private void JRCDNCKZHSQ(JMNPGDUXCYK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7564030", Offset = "0x7562830", VA = "0x187564030")]
		internal void GTFCDCZLKCY(JMNPGDUXCYK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7564BC0", Offset = "0x75633C0", VA = "0x187564BC0")]
		private void KLVLKGRCWHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7567120", Offset = "0x7565920", VA = "0x187567120")]
		private void SVTCNKZMAZG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7566AF0", Offset = "0x75652F0", VA = "0x187566AF0")]
		internal YVEZMVSSWEO SOSRDKUYEGP(GRTMSFIQSDO a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75655D0", Offset = "0x7563DD0", VA = "0x1875655D0")]
		private int MHTDMJITVSB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7565A90", Offset = "0x7564290", VA = "0x187565A90")]
		private void MVKSVAKWTHJ(IPEndPoint a, YVEZMVSSWEO b, ATUAEUSZOQR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x75681F0", Offset = "0x75669F0", VA = "0x1875681F0")]
		private void TCMZFCWMPAW(QYYKZFGKMNU a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7569510", Offset = "0x7567D10", VA = "0x187569510")]
		internal void TOIWWTAXGUY(QYYKZFGKMNU a, DeliveryMethod b, byte c, int d, YVEZMVSSWEO e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7567DF0", Offset = "0x75665F0", VA = "0x187567DF0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7567E60", Offset = "0x7566660", VA = "0x187567E60")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7567D70", Offset = "0x7566570", VA = "0x187567D70")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7567450", Offset = "0x7565C50", VA = "0x187567450")]
		public void SXULLXZURBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7563DC0", Offset = "0x75625C0", VA = "0x187563DC0")]
		public YVEZMVSSWEO Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7563EA0", Offset = "0x75626A0", VA = "0x187563EA0")]
		public YVEZMVSSWEO Connect(string address, int port, SQEEUROIYMJ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75639F0", Offset = "0x75621F0", VA = "0x1875639F0")]
		public YVEZMVSSWEO Connect(IPEndPoint target, SQEEUROIYMJ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7567E80", Offset = "0x7566680", VA = "0x187567E80")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7567E90", Offset = "0x7566690", VA = "0x187567E90")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7565520", Offset = "0x7563D20", VA = "0x187565520")]
		public void MGQCYZRQNRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7565450", Offset = "0x7563C50", VA = "0x187565450")]
		public void MGQCYZRQNRK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7566320", Offset = "0x7564B20", VA = "0x187566320")]
		public void NAZKEPJISRD(YVEZMVSSWEO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7566360", Offset = "0x7564B60", VA = "0x187566360")]
		public void NAZKEPJISRD(YVEZMVSSWEO a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x756ABD0", Offset = "0x75693D0", VA = "0x18756ABD0", Slot = "4")]
		private IEnumerator<YVEZMVSSWEO> YKHCGWRXDBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x75653C0", Offset = "0x7563BC0", VA = "0x1875653C0", Slot = "5")]
		private IEnumerator LRASTPXJBWO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7566A10", Offset = "0x7565210", VA = "0x187566A10")]
		private QYYKZFGKMNU RNWIWLLIANY(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7566930", Offset = "0x7565130", VA = "0x187566930")]
		private QYYKZFGKMNU RNWIWLLIANY(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7564F20", Offset = "0x7563720", VA = "0x187564F20")]
		internal QYYKZFGKMNU KSJMGOWAMXB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7564140", Offset = "0x7562940", VA = "0x187564140")]
		internal void HJXJKZDBUVI(QYYKZFGKMNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x756AD10", Offset = "0x7569510", VA = "0x18756AD10")]
		static FQKDQTMBFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDB8C0", VA = "0x180BDD0C0")]
		private bool OTIKKQAYTNT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x75667D0", Offset = "0x7564FD0", VA = "0x1875667D0")]
		private void RBDHHBDZMWP(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x75697E0", Offset = "0x7567FE0", VA = "0x1875697E0")]
		private void TUDHDZWXAIE(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7565160", Offset = "0x7563960", VA = "0x187565160")]
		private bool LLBDCQWWMHQ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7569990", Offset = "0x7568190", VA = "0x187569990")]
		private void UMCEVFUQFIJ(IRTBGLXMWKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75657D0", Offset = "0x7563FD0", VA = "0x1875657D0")]
		private void MVILZFKGRSS(YQKZKJATHYD a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x756A850", Offset = "0x7569050", VA = "0x18756A850")]
		private void YEZBSBFEJRA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7567600", Offset = "0x7565E00", VA = "0x187567600")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7569CD0", Offset = "0x75684D0", VA = "0x187569CD0")]
		internal int VMVKYYIRKYP(QYYKZFGKMNU a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7569D30", Offset = "0x7568530", VA = "0x187569D30")]
		internal int VUVLYYJBDDX(QYYKZFGKMNU a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7569D70", Offset = "0x7568570", VA = "0x187569D70")]
		internal int VUVLYYJBDDX(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7565650", Offset = "0x7563E50", VA = "0x187565650")]
		internal void MMDHUEZINVK(bool a)
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
	internal sealed class QYYKZFGKMNU
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int GHYJJCEUBFD;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] JISSHIWWYZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] IIRNEVPEPUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int JHYPQHCWLXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object AQUHDGUGMGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public QYYKZFGKMNU AZNBPSIKRMW;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty LAWCCXCQZRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7571A30", Offset = "0x7570230", VA = "0x187571A30")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x75715E0", Offset = "0x756FDE0", VA = "0x1875715E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte LVNQIMVMSAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7571540", Offset = "0x756FD40", VA = "0x187571540")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x75718B0", Offset = "0x75700B0", VA = "0x1875718B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort EWCPHVMYGWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7571910", Offset = "0x7570110", VA = "0x187571910")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7571570", Offset = "0x756FD70", VA = "0x187571570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NDYWCFIJSCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7571930", Offset = "0x7570130", VA = "0x187571930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte IMCHXFELBGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x75719C0", Offset = "0x75701C0", VA = "0x1875719C0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x75715B0", Offset = "0x756FDB0", VA = "0x1875715B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort FDABQBPWXUC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7571960", Offset = "0x7570160", VA = "0x187571960")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x75719F0", Offset = "0x75701F0", VA = "0x1875719F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort PYUOOMDBJNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7571820", Offset = "0x7570020", VA = "0x187571820")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7571980", Offset = "0x7570180", VA = "0x187571980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort TLXRSUVQIAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x75718F0", Offset = "0x75700F0", VA = "0x1875718F0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7571870", Offset = "0x7570070", VA = "0x187571870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7571A60", Offset = "0x7570260", VA = "0x187571A60")]
		static QYYKZFGKMNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7571840", Offset = "0x7570040", VA = "0x187571840")]
		public void PUSCHVRKYWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7571E20", Offset = "0x7570620", VA = "0x187571E20")]
		public QYYKZFGKMNU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7571D10", Offset = "0x7570510", VA = "0x187571D10")]
		public QYYKZFGKMNU(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x75716B0", Offset = "0x756FEB0", VA = "0x1875716B0")]
		public static int KMZJJWHWEQB(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7571620", Offset = "0x756FE20", VA = "0x187571620")]
		public int KMZJJWHWEQB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7571720", Offset = "0x756FF20", VA = "0x187571720")]
		public bool PHXSIBTAXVI()
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
	public class YVEZMVSSWEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class UWKMEQAYTMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public QYYKZFGKMNU[] QBMFMXORZIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int QIBGKWVEXPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int ONBRNNCDLSC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte IMCHXFELBGX;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public UWKMEQAYTMU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int NTSFGINHREW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int XVESYFURCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int ECYIMQTMXFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double XIDUYBQNKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int BMOWAWMDKVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int WTMIGNDEENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int BQECWWYETOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch EMQGXTLZSAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int YQQPUMESYLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long LKNPFFYFTII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object KMADRNMGVYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal YVEZMVSSWEO MWGBJNSWZTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal YVEZMVSSWEO JDKLRZJFVBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<QYYKZFGKMNU> WBCJTQXMEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<DUNQZJSKCFX> LKYGUXANQZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly DUNQZJSKCFX[] TCNYMSPCZWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int UCTNHVKUBTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int NICLTVOYMBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool VHORRKAPCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int OPZKBEALFXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int BGCFQQTUAQG;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int BHRBQRLXEJU = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int EBQVXCJUQOB = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object ZVNMMHBWLZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int KZLNVBXXNCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, UWKMEQAYTMU> ZCHVHLHKJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> TVNEJMBEYLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly QYYKZFGKMNU ZQYCIARYCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int QWBXGYRDTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int XRPTFQXMKVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint CXNUQJJMTLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int RDEGBJYNMUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int FWUYJPYFBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long NVVTFTKXHYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte TWVHSVWOKVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState AVNYWVROWUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private QYYKZFGKMNU QCRUWTUFVDU;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int DFVRMZDYXUQ = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int IKYOUWEURGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly QYYKZFGKMNU WVFEYVSTTHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly QYYKZFGKMNU GNLRCDIZXYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly QYYKZFGKMNU HHAKINWSOFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly QYYKZFGKMNU ZNZPBKAGIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality SIIODSRTJWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly FQKDQTMBFMJ FQKDQTMBFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int VXYCUIZXFBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object ZJONUTEVMDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly DRRBWLHQTKZ BSFVAYSICNG;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte RPKWXZIENAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xADA660", Offset = "0xAD8E60", VA = "0x180ADA660")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7575600", Offset = "0x7573E00", VA = "0x187575600")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint PDLATXFIXHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBD5A70", Offset = "0xBD4270", VA = "0x180BD5A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState RSTOKUBVFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1244F70", Offset = "0x1243770", VA = "0x181244F70")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long PBIERHDAOXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAA980", VA = "0x180AAC180")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int IOILINRCMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F41580", Offset = "0x1F3FD80", VA = "0x181F41580")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x209B330", Offset = "0x2099B30", VA = "0x18209B330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int IVSIMGERMIX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7575A10", Offset = "0x7574210", VA = "0x187575A10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int MCECICJFMDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xACB450", Offset = "0xAC9C50", VA = "0x180ACB450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double UTJKQNGPQRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2828B00", Offset = "0x2827300", VA = "0x182828B00")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate JWFFGTBVHDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7577240", Offset = "0x7575A40", VA = "0x187577240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7574470", Offset = "0x7572C70", VA = "0x187574470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75772F0", Offset = "0x7575AF0", VA = "0x1875772F0")]
		internal YVEZMVSSWEO(FQKDQTMBFMJ a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7574750", Offset = "0x7572F50", VA = "0x187574750")]
		internal void HLDKRXUUQDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7576BB0", Offset = "0x75753B0", VA = "0x187576BB0")]
		internal void VJKTUMEOQLP(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7575270", Offset = "0x7573A70", VA = "0x187575270")]
		internal void OKUIFTOTAZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7575360", Offset = "0x7573B60", VA = "0x187575360")]
		private void QKIIRUVREKL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x75749D0", Offset = "0x75731D0", VA = "0x1875749D0")]
		private void KTMLEZSNBAB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7574520", Offset = "0x7572D20", VA = "0x187574520")]
		public int GQOKODYUXEZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7574630", Offset = "0x7572E30", VA = "0x187574630")]
		public int GQOKODYUXEZ(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7573950", Offset = "0x7572150", VA = "0x187573950")]
		private DUNQZJSKCFX AOFCUKOXFLI(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x75776F0", Offset = "0x7575EF0", VA = "0x1875776F0")]
		internal YVEZMVSSWEO(FQKDQTMBFMJ a, IPEndPoint b, int c, byte d, SQEEUROIYMJ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7577880", Offset = "0x7576080", VA = "0x187577880")]
		internal YVEZMVSSWEO(FQKDQTMBFMJ a, GRTMSFIQSDO b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x75756B0", Offset = "0x7573EB0", VA = "0x1875756B0")]
		internal void Reject(ATUAEUSZOQR requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7575580", Offset = "0x7573D80", VA = "0x187575580")]
		internal bool RWIJRDKHKRM(ZQXLQDMMDIQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x75771D0", Offset = "0x75759D0", VA = "0x1875771D0")]
		public void YTTTAOCXCKJ(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7576BE0", Offset = "0x75753E0", VA = "0x187576BE0")]
		private void YPAKLVWPNXG(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7573B80", Offset = "0x7572380", VA = "0x187573B80")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7573AE0", Offset = "0x75722E0", VA = "0x187573AE0")]
		internal DisconnectResult CBIUEIAXCIK(QYYKZFGKMNU a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7575300", Offset = "0x7573B00", VA = "0x187575300")]
		internal void PVYZUGMTZGR(DUNQZJSKCFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7575700", Offset = "0x7573F00", VA = "0x187575700")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7577200", Offset = "0x7575A00", VA = "0x187577200")]
		private void ZSNRPSCLDEE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7573BD0", Offset = "0x75723D0", VA = "0x187573BD0")]
		internal void EVSLZCBXOOA(DeliveryMethod a, QYYKZFGKMNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7575FB0", Offset = "0x75747B0", VA = "0x187575FB0")]
		private void UTLGWQFIKKA(QYYKZFGKMNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7575A20", Offset = "0x7574220", VA = "0x187575A20")]
		private void TLLGDBNMZRC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x75750B0", Offset = "0x75738B0", VA = "0x1875750B0")]
		internal ConnectRequestResult MVKSVAKWTHJ(ATUAEUSZOQR a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7574A10", Offset = "0x7573210", VA = "0x187574A10")]
		internal void MGNKCETUBRK(QYYKZFGKMNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7575430", Offset = "0x7573C30", VA = "0x187575430")]
		private void RWAMWJPWSEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7575DB0", Offset = "0x75745B0", VA = "0x187575DB0")]
		internal void UQIPFIYWDPI(QYYKZFGKMNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x75764E0", Offset = "0x7574CE0", VA = "0x1875764E0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7574770", Offset = "0x7572F70", VA = "0x187574770")]
		internal void JAWRUOTXMUO(QYYKZFGKMNU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class DRRBWLHQTKZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long BUAJLZRQSHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long LCCXQGADCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long LEFHEIITPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long IRAEFIUTGQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long YGZEAKRDCDV;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long IOJIETBKDLA;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long HRDBFGZHOQH;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long GNYKRNXVIYE;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long TRDXGVWNHVP;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long ZRZMYCYBDXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long XDETAUZYBXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long DIJCQKGQEXT;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long YBGJGACLBTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7562350", Offset = "0x7560B50", VA = "0x187562350")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long CVGUGYRRMDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7562620", Offset = "0x7560E20", VA = "0x187562620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long BZNQLXSBENK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x75624B0", Offset = "0x7560CB0", VA = "0x1875624B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long EBOFDBOWLBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x75625B0", Offset = "0x7560DB0", VA = "0x1875625B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long XRGCZBODUOU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7562420", Offset = "0x7560C20", VA = "0x187562420")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long ZJLDGVXGQQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x75626E0", Offset = "0x7560EE0", VA = "0x1875626E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long MZXROMLVQCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7562430", Offset = "0x7560C30", VA = "0x187562430")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long UUILZHYCJUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7562470", Offset = "0x7560C70", VA = "0x187562470")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality VBLPJTIUACO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1180CC0", Offset = "0x117F4C0", VA = "0x181180CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double ZWMRRJZWTKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7562360", Offset = "0x7560B60", VA = "0x187562360")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75626A0", Offset = "0x7560EA0", VA = "0x1875626A0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x75625C0", Offset = "0x7560DC0", VA = "0x1875625C0")]
		public void LIWHYXFMEBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7562560", Offset = "0x7560D60", VA = "0x187562560")]
		public void IQHTIEHZYSC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7562A90", Offset = "0x7561290", VA = "0x187562A90")]
		public void XDLGEDLVSCL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7562A30", Offset = "0x7561230", VA = "0x187562A30")]
		public void VBKPQCKQQFQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x75623C0", Offset = "0x7560BC0", VA = "0x1875623C0")]
		public void EUFRGGVAFPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7562630", Offset = "0x7560E30", VA = "0x187562630")]
		public void PHCRXTYSWOV(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x75626F0", Offset = "0x7560EF0", VA = "0x1875626F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x75624C0", Offset = "0x7560CC0", VA = "0x1875624C0")]
		public void HGXLYVGTAFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public DRRBWLHQTKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class BKCRQLPZYTF
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> SGUVKDDNYHQ;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7561E10", Offset = "0x7560610", VA = "0x187561E10")]
		public static IPEndPoint AZPCVCOOZEU(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7562080", Offset = "0x7560880", VA = "0x187562080")]
		public static IPAddress DEYHYTSSWNZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7562240", Offset = "0x7560A40", VA = "0x187562240")]
		public static IPAddress DEYHYTSSWNZ(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7562050", Offset = "0x7560850", VA = "0x187562050")]
		internal static int BPKNUPLHUPR(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x33E2E10", Offset = "0x33E1610", VA = "0x1833E2E10")]
		internal static T[] VPIFHXILKLE<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class KNDPPBOQTRS : DUNQZJSKCFX
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private QYYKZFGKMNU _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7570AA0", Offset = "0x756F2A0", VA = "0x187570AA0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7570A80", Offset = "0x756F280", VA = "0x187570A80")]
			public void RUCBQSMBUXH(QYYKZFGKMNU a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7570A10", Offset = "0x756F210", VA = "0x187570A10")]
			public bool HUWNOLGQZJU(long a, YVEZMVSSWEO b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x75709C0", Offset = "0x756F1C0", VA = "0x1875709C0")]
			public bool Clear(YVEZMVSSWEO peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly QYYKZFGKMNU LZRLNAEHLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] USQCAGVKMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly QYYKZFGKMNU[] LJJZMUXFYBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] VBQUDRZAWIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int PEIPOHHBQQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int IJDZMNNDMET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int IBARJYEMPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int UMDHGHTTRAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool VKJZETRYEER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod IMGELCDRCNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool LPIRHKAOJWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int BAUYYFHKDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte DYGSTIZTARP;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int KGHTXIFSVOO
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x756CB50", Offset = "0x756B350", VA = "0x18756CB50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x756D030", Offset = "0x756B830", VA = "0x18756D030")]
		public KNDPPBOQTRS(YVEZMVSSWEO a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x756C1D0", Offset = "0x756A9D0", VA = "0x18756C1D0")]
		private void CLSHYDGFNOZ(QYYKZFGKMNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x756CB60", Offset = "0x756B360", VA = "0x18756CB60", Slot = "4")]
		protected override bool XQUONBIUNCZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x756C550", Offset = "0x756AD50", VA = "0x18756C550", Slot = "5")]
		public override bool MGNKCETUBRK(QYYKZFGKMNU a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class AVUWOOYVIYF : DUNQZJSKCFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int FNMVNESMIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort IJDZMNNDMET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool WTTQINCNFYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private QYYKZFGKMNU KYBLFGREYGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly QYYKZFGKMNU IOHUHTOUTAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool AFMOENNHLOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte DYGSTIZTARP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long RUSUFOHHCKX;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7561D50", Offset = "0x7560550", VA = "0x187561D50")]
		public AVUWOOYVIYF(YVEZMVSSWEO a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7561890", Offset = "0x7560090", VA = "0x187561890", Slot = "4")]
		protected override bool XQUONBIUNCZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7561610", Offset = "0x755FE10", VA = "0x187561610", Slot = "5")]
		public override bool MGNKCETUBRK(QYYKZFGKMNU a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class LIEHEUKMFUI
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
		[Cpp2IlInjected.Address(RVA = "0x75603A0", Offset = "0x755EBA0", VA = "0x1875603A0")]
		private static void OHLCYAAHERT(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x756D3A0", Offset = "0x756BBA0", VA = "0x18756D3A0")]
		private static void OHLCYAAHERT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x756D360", Offset = "0x756BB60", VA = "0x18756D360")]
		public static void OHLCYAAHERT(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x756D4A0", Offset = "0x756BCA0", VA = "0x18756D4A0")]
		public static void OKOJWAXODFW(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x756D410", Offset = "0x756BC10", VA = "0x18756D410")]
		public static void OKOJWAXODFW(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x756D360", Offset = "0x756BB60", VA = "0x18756D360")]
		public static void OKOJWAXODFW(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x756D360", Offset = "0x756BB60", VA = "0x18756D360")]
		public static void OKOJWAXODFW(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x756D3A0", Offset = "0x756BBA0", VA = "0x18756D3A0")]
		public static void OKOJWAXODFW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x756D3A0", Offset = "0x756BBA0", VA = "0x18756D3A0")]
		public static void OKOJWAXODFW(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x756D490", Offset = "0x756BC90", VA = "0x18756D490")]
		public static void OKOJWAXODFW(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x756D490", Offset = "0x756BC90", VA = "0x18756D490")]
		public static void OKOJWAXODFW(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ENYQFYCWRNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] AFCNXRPGEGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int FTNEBYYIZBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int UTCPFHTHTWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int FJMAGJSQJHN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] IIRNEVPEPUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int LLQUKOHUOQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int LUHUOSKYDYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7562E00", Offset = "0x7561600", VA = "0x187562E00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NPCEVELPKBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x27892E0", Offset = "0x2787AE0", VA = "0x1827892E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int VMMLNVISCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x75631E0", Offset = "0x75619E0", VA = "0x1875631E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7562D30", Offset = "0x7561530", VA = "0x187562D30")]
		public void BMJIPHUJMGQ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ENYQFYCWRNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7563580", Offset = "0x7561D80", VA = "0x187563580")]
		public ENYQFYCWRNL(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x75630D0", Offset = "0x75618D0", VA = "0x1875630D0")]
		public IPEndPoint HJCXOFDKAVH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7563160", Offset = "0x7561960", VA = "0x187563160")]
		public byte IROLAEQOBXV()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7563160", Offset = "0x7561960", VA = "0x187563160")]
		public sbyte WLDTFRMKRVS()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x35CF2B0", Offset = "0x35CDAB0", VA = "0x1835CF2B0")]
		public a[] DAMLCKRPAMG<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7562CF0", Offset = "0x75614F0", VA = "0x187562CF0")]
		public bool[] BKRURAGLAHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7563380", Offset = "0x7561B80", VA = "0x187563380")]
		public ushort[] UNFGABQZQZR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7562E10", Offset = "0x7561610", VA = "0x187562E10")]
		public short[] DREOWMHKJLU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x75631A0", Offset = "0x75619A0", VA = "0x1875631A0")]
		public int[] KJMCGASXIZF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7562E50", Offset = "0x7561650", VA = "0x187562E50")]
		public uint[] ECYDNDECNKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7563310", Offset = "0x7561B10", VA = "0x187563310")]
		public float[] TFOXTMSPZWO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7563260", Offset = "0x7561A60", VA = "0x187563260")]
		public double[] NZSGVRMSYLX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7563430", Offset = "0x7561C30", VA = "0x187563430")]
		public long[] VAJTUHTUUVG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7562DC0", Offset = "0x75615C0", VA = "0x187562DC0")]
		public ulong[] DIDBATFFSKT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7563470", Offset = "0x7561C70", VA = "0x187563470")]
		public string[] WFHAICELKWZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7563540", Offset = "0x7561D40", VA = "0x187563540")]
		public bool YXHTRMXRSPX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x75632E0", Offset = "0x7561AE0", VA = "0x1875632E0")]
		public char QVXJRUIJKJD()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x75632E0", Offset = "0x7561AE0", VA = "0x1875632E0")]
		public ushort YSAGZLOOQVQ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x75632E0", Offset = "0x7561AE0", VA = "0x1875632E0")]
		public short WHEFDCHXYBT()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7562D70", Offset = "0x7561570", VA = "0x187562D70")]
		public long YJZIDUKGYML()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7562D70", Offset = "0x7561570", VA = "0x187562D70")]
		public ulong BURNKUFRATI()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7562E90", Offset = "0x7561690", VA = "0x187562E90")]
		public int MLHUNWVMZMS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7562E90", Offset = "0x7561690", VA = "0x187562E90")]
		public uint GKBDPHHFYPD()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7563230", Offset = "0x7561A30", VA = "0x187563230")]
		public float MRPWVJNMDLL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7563350", Offset = "0x7561B50", VA = "0x187563350")]
		public double TQVDDYZJEQA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7562EC0", Offset = "0x75616C0", VA = "0x187562EC0")]
		public string GQYOJHZYNNC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x75633C0", Offset = "0x7561BC0", VA = "0x1875633C0")]
		public ArraySegment<byte> UQVPNWWKKMN(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75632A0", Offset = "0x7561AA0", VA = "0x1875632A0")]
		public sbyte[] PKKLHSFPFMR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x75631F0", Offset = "0x75619F0", VA = "0x1875631F0")]
		public byte[] LPXWBVGDQDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7562DA0", Offset = "0x75615A0", VA = "0x187562DA0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SQEEUROIYMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] AFCNXRPGEGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int FTNEBYYIZBB;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int FKCLGHUFKUQ = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool HZHWATLTACH;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding TQALYIOIBSJ;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int RBCYXYFGSCG = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] HPGMOFWCETF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] AROSVOGBSTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int KGSUFPGCCQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x75736B0", Offset = "0x7571EB0", VA = "0x1875736B0")]
		public SQEEUROIYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7573730", Offset = "0x7571F30", VA = "0x187573730")]
		public SQEEUROIYMJ(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x75735C0", Offset = "0x7571DC0", VA = "0x1875735C0")]
		public static SQEEUROIYMJ MMRSKRKORLA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7573520", Offset = "0x7571D20", VA = "0x187573520")]
		public void MMBONOWXZXK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2801060", Offset = "0x27FF860", VA = "0x182801060")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7573330", Offset = "0x7571B30", VA = "0x187573330")]
		public void JGDMARETBHG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7573210", Offset = "0x7571A10", VA = "0x187573210")]
		public void JGDMARETBHG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7573150", Offset = "0x7571950", VA = "0x187573150")]
		public void JGDMARETBHG(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7573150", Offset = "0x7571950", VA = "0x187573150")]
		public void JGDMARETBHG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7573490", Offset = "0x7571C90", VA = "0x187573490")]
		public void JGDMARETBHG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7573490", Offset = "0x7571C90", VA = "0x187573490")]
		public void JGDMARETBHG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x75731A0", Offset = "0x75719A0", VA = "0x1875731A0")]
		public void JGDMARETBHG(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x75731A0", Offset = "0x75719A0", VA = "0x1875731A0")]
		public void JGDMARETBHG(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x75731A0", Offset = "0x75719A0", VA = "0x1875731A0")]
		public void JGDMARETBHG(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x75733D0", Offset = "0x7571BD0", VA = "0x1875733D0")]
		public void JGDMARETBHG(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x75733D0", Offset = "0x7571BD0", VA = "0x1875733D0")]
		public void JGDMARETBHG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7572EC0", Offset = "0x75716C0", VA = "0x187572EC0")]
		public void JGDMARETBHG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7572990", Offset = "0x7571190", VA = "0x187572990")]
		public void RCTABRZNADW(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7572990", Offset = "0x7571190", VA = "0x187572990")]
		public void EXQZFZXPWJZ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7573430", Offset = "0x7571C30", VA = "0x187573430")]
		public void JGDMARETBHG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7572DE0", Offset = "0x75715E0", VA = "0x187572DE0")]
		public void FNDLWGMUZLT(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7572B50", Offset = "0x7571350", VA = "0x187572B50")]
		public void FNDLWGMUZLT(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7572A70", Offset = "0x7571270", VA = "0x187572A70")]
		public void FNDLWGMUZLT(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7572A70", Offset = "0x7571270", VA = "0x187572A70")]
		public void FNDLWGMUZLT(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7572A70", Offset = "0x7571270", VA = "0x187572A70")]
		public void FNDLWGMUZLT(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7572B50", Offset = "0x7571350", VA = "0x187572B50")]
		public void FNDLWGMUZLT(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7572B50", Offset = "0x7571350", VA = "0x187572B50")]
		public void FNDLWGMUZLT(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7572D00", Offset = "0x7571500", VA = "0x187572D00")]
		public void FNDLWGMUZLT(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7572D00", Offset = "0x7571500", VA = "0x187572D00")]
		public void FNDLWGMUZLT(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7572990", Offset = "0x7571190", VA = "0x187572990")]
		public void FNDLWGMUZLT(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7572C30", Offset = "0x7571430", VA = "0x187572C30")]
		public void FNDLWGMUZLT(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7573260", Offset = "0x7571A60", VA = "0x187573260")]
		public void JGDMARETBHG(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7572F30", Offset = "0x7571730", VA = "0x187572F30")]
		public void JGDMARETBHG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7572F40", Offset = "0x7571740", VA = "0x187572F40")]
		public void JGDMARETBHG(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class MIYHTNEFYLE
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class WZFJFYLVANK<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong VXYCUIZXFBQ;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x66D5AF0", Offset = "0x66D42F0", VA = "0x1866D5AF0")]
			static WZFJFYLVANK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(ENYQFYCWRNL reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class TMVAEUQLYED<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public MIYHTNEFYLE BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a RFKRVVWLHGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> YWNOOPARXBV;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TMVAEUQLYED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5FA7270", Offset = "0x5FA5A70", VA = "0x185FA7270")]
			internal void NOCYSNWXVFO(ENYQFYCWRNL a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class UEVESAGXRKH<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public MIYHTNEFYLE BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a RFKRVVWLHGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> YWNOOPARXBV;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public UEVESAGXRKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6199F30", Offset = "0x6198730", VA = "0x186199F30")]
			internal void NOCYSNWXVFO(ENYQFYCWRNL a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly HQYVQPECJVE THPLNUSICCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> KCQOFWYJHUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly SQEEUROIYMJ ZYTJORJHEGM;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x756EFA0", Offset = "0x756D7A0", VA = "0x18756EFA0")]
		public MIYHTNEFYLE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x37DAB90", Offset = "0x37D9390", VA = "0x1837DAB90", Slot = "4")]
		protected virtual ulong OTUCAQKDHMF<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x756EED0", Offset = "0x756D6D0", VA = "0x18756EED0", Slot = "5")]
		protected virtual SubscribeDelegate XZSJJWCRLYO(ENYQFYCWRNL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x37DAA80", Offset = "0x37D9280", VA = "0x1837DAA80", Slot = "6")]
		protected virtual void GFLTCYQJORI<b>(SQEEUROIYMJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x756EE50", Offset = "0x756D650", VA = "0x18756EE50")]
		public void BTUMEJDWAEL(ENYQFYCWRNL a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x37DAB00", Offset = "0x37D9300", VA = "0x1837DAB00")]
		public void NRKQGERBRVA<j>(SQEEUROIYMJ a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x756EE00", Offset = "0x756D600", VA = "0x18756EE00")]
		public void BPVNYLZSCVR(ENYQFYCWRNL a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x37DA900", Offset = "0x37D9100", VA = "0x1837DA900")]
		public void CVKXGHGLHRO<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x37DA900", Offset = "0x37D9100", VA = "0x1837DA900")]
		public void CVKXGHGLHRO<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x756C080", Offset = "0x756A880", VA = "0x18756C080")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7570960", Offset = "0x756F160", VA = "0x187570960")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class HQYVQPECJVE
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
		private abstract class FGAXTSOMSOK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType QWAVKIDXYXV;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4D7A760", Offset = "0x4D78F60", VA = "0x184D7A760", Slot = "4")]
			public virtual void RUCBQSMBUXH(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void YLXFDFFRGEH(a a, ENYQFYCWRNL b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void NRKQGERBRVA(a a, SQEEUROIYMJ b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void OHNXZEEHYBK(a a, ENYQFYCWRNL b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void JXTHBHHIBVR(a a, SQEEUROIYMJ b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void WESUIKQPLWH(a a, ENYQFYCWRNL b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void JYTEYXBFSAK(a a, SQEEUROIYMJ b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			protected FGAXTSOMSOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class NHQHBSOPXHV<a, b> : FGAXTSOMSOK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> QJFYWCOCFOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> VQUNXQDACZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> DCEXOVLZVBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> ITVFXQXSKHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> ZNKJINMHUZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> WKBFBRVQDDK;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5884A40", Offset = "0x5883240", VA = "0x185884A40", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x5884A40", Offset = "0x5883240", VA = "0x185884A40", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5884B10", Offset = "0x5883310", VA = "0x185884B10", Slot = "9")]
			public override void WESUIKQPLWH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x5884B10", Offset = "0x5883310", VA = "0x185884B10", Slot = "10")]
			public override void JYTEYXBFSAK(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5884BE0", Offset = "0x58833E0", VA = "0x185884BE0")]
			protected b[] OMIDCNHIFBW(a a, ENYQFYCWRNL b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x58848D0", Offset = "0x58830D0", VA = "0x1858848D0")]
			protected b[] CAKVAFJDFYX(a a, SQEEUROIYMJ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5884E80", Offset = "0x5883680", VA = "0x185884E80", Slot = "4")]
			public override void RUCBQSMBUXH(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x5885960", Offset = "0x5884160", VA = "0x185885960")]
			protected NHQHBSOPXHV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class XPBAHVYWGGE<a, b> : NHQHBSOPXHV<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void RHSSLDXTIUN(ENYQFYCWRNL a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void KEZOSOWBQHW(SQEEUROIYMJ a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3E3E3F0", Offset = "0x3E3CBF0", VA = "0x183E3E3F0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3E3E0A0", Offset = "0x3E3C8A0", VA = "0x183E3E0A0", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3E3E350", Offset = "0x3E3CB50", VA = "0x183E3E350", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3E3DDE0", Offset = "0x3E3C5E0", VA = "0x183E3DDE0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3E3E670", Offset = "0x3E3CE70", VA = "0x183E3E670")]
			protected XPBAHVYWGGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class QQNWLMKKDVN<a> : NHQHBSOPXHV<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3E30990", Offset = "0x3E2F190", VA = "0x183E30990", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3E30700", Offset = "0x3E2EF00", VA = "0x183E30700", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5BD9530", Offset = "0x5BD7D30", VA = "0x185BD9530", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3E306C0", Offset = "0x3E2EEC0", VA = "0x183E306C0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public QQNWLMKKDVN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class XGWUUZFVIHO<a> : NHQHBSOPXHV<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3E30990", Offset = "0x3E2F190", VA = "0x183E30990", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3E30700", Offset = "0x3E2EF00", VA = "0x183E30700", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3E30840", Offset = "0x3E2F040", VA = "0x183E30840", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3E306C0", Offset = "0x3E2EEC0", VA = "0x183E306C0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public XGWUUZFVIHO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class ORHYCIJAIVS<a> : NHQHBSOPXHV<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x59DE900", Offset = "0x59DD100", VA = "0x1859DE900", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x59DE650", Offset = "0x59DCE50", VA = "0x1859DE650", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x59DE790", Offset = "0x59DCF90", VA = "0x1859DE790", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x59DE510", Offset = "0x59DCD10", VA = "0x1859DE510", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public ORHYCIJAIVS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class TFZHSBITERR<a> : NHQHBSOPXHV<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x59DE900", Offset = "0x59DD100", VA = "0x1859DE900", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x59DE650", Offset = "0x59DCE50", VA = "0x1859DE650", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5F9AFB0", Offset = "0x5F997B0", VA = "0x185F9AFB0", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x59DE510", Offset = "0x59DCD10", VA = "0x1859DE510", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public TFZHSBITERR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class NBHQCLBTXES<a> : NHQHBSOPXHV<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x57EA0F0", Offset = "0x57E88F0", VA = "0x1857EA0F0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x57E9E60", Offset = "0x57E8660", VA = "0x1857E9E60", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5880E80", Offset = "0x587F680", VA = "0x185880E80", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x53379E0", Offset = "0x53361E0", VA = "0x1853379E0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x5880FD0", Offset = "0x587F7D0", VA = "0x185880FD0")]
			public NBHQCLBTXES()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class MFXMPYMVIDF<a> : NHQHBSOPXHV<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x57EA0F0", Offset = "0x57E88F0", VA = "0x1857EA0F0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x57E9E60", Offset = "0x57E8660", VA = "0x1857E9E60", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x57EA0A0", Offset = "0x57E88A0", VA = "0x1857EA0A0", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x53379E0", Offset = "0x53361E0", VA = "0x1853379E0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public MFXMPYMVIDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class JRTJKXTGSAS<a> : NHQHBSOPXHV<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x50D93A0", Offset = "0x50D7BA0", VA = "0x1850D93A0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x50D8FF0", Offset = "0x50D77F0", VA = "0x1850D8FF0", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x50D9130", Offset = "0x50D7930", VA = "0x1850D9130", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x50D8FB0", Offset = "0x50D77B0", VA = "0x1850D8FB0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public JRTJKXTGSAS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class WCMKRESKGEZ<a> : NHQHBSOPXHV<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x50D93A0", Offset = "0x50D7BA0", VA = "0x1850D93A0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x50D8FF0", Offset = "0x50D77F0", VA = "0x1850D8FF0", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x66AC4D0", Offset = "0x66AACD0", VA = "0x1866AC4D0", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x50D8FB0", Offset = "0x50D77B0", VA = "0x1850D8FB0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public WCMKRESKGEZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class KERSWFBIFCY<a> : NHQHBSOPXHV<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x5211FE0", Offset = "0x52107E0", VA = "0x185211FE0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x5211C30", Offset = "0x5210430", VA = "0x185211C30", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x5211E70", Offset = "0x5210670", VA = "0x185211E70", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3E306C0", Offset = "0x3E2EEC0", VA = "0x183E306C0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public KERSWFBIFCY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class LTUWXLILOTX<a> : NHQHBSOPXHV<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x5337ED0", Offset = "0x53366D0", VA = "0x185337ED0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x5337B20", Offset = "0x5336320", VA = "0x185337B20", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x5337D60", Offset = "0x5336560", VA = "0x185337D60", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x53379E0", Offset = "0x53361E0", VA = "0x1853379E0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public LTUWXLILOTX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class PLREEIFDFDW<a> : NHQHBSOPXHV<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x5AB7780", Offset = "0x5AB5F80", VA = "0x185AB7780", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x5AB75F0", Offset = "0x5AB5DF0", VA = "0x185AB75F0", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x5AB7630", Offset = "0x5AB5E30", VA = "0x185AB7630", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x50D8FB0", Offset = "0x50D77B0", VA = "0x1850D8FB0", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x3E30B20", Offset = "0x3E2F320", VA = "0x183E30B20")]
			public PLREEIFDFDW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class DYFYMBRWRHC<a> : XPBAHVYWGGE<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4128A20", Offset = "0x4127220", VA = "0x184128A20", Slot = "12")]
			protected override void KEZOSOWBQHW(SQEEUROIYMJ a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x4128A50", Offset = "0x4127250", VA = "0x184128A50", Slot = "11")]
			protected override void RHSSLDXTIUN(ENYQFYCWRNL a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x4128A80", Offset = "0x4127280", VA = "0x184128A80")]
			public DYFYMBRWRHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class OWXPPOEJREE<a> : XPBAHVYWGGE<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x59FFB70", Offset = "0x59FE370", VA = "0x1859FFB70", Slot = "12")]
			protected override void KEZOSOWBQHW(SQEEUROIYMJ a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x59FFBA0", Offset = "0x59FE3A0", VA = "0x1859FFBA0", Slot = "11")]
			protected override void RHSSLDXTIUN(ENYQFYCWRNL a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4128A80", Offset = "0x4127280", VA = "0x184128A80")]
			public OWXPPOEJREE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class RKLBPOMGDJH<a> : NHQHBSOPXHV<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int TERFDSQUHIS;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5C0D960", Offset = "0x5C0C160", VA = "0x185C0D960")]
			public RKLBPOMGDJH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5C0D8B0", Offset = "0x5C0C0B0", VA = "0x185C0D8B0", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5C0D5E0", Offset = "0x5C0BDE0", VA = "0x185C0D5E0", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5C0D630", Offset = "0x5C0BE30", VA = "0x185C0D630", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5C0D490", Offset = "0x5C0BC90", VA = "0x185C0D490", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class RUZYGNZVEZV<a> : FGAXTSOMSOK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo LAWCCXCQZRU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type NBCBPLNYKZA;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C31130", Offset = "0x5C2F930", VA = "0x185C31130")]
			public RUZYGNZVEZV(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C31090", Offset = "0x5C2F890", VA = "0x185C31090", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5C30DD0", Offset = "0x5C2F5D0", VA = "0x185C30DD0", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x5C30D30", Offset = "0x5C2F530", VA = "0x185C30D30", Slot = "7")]
			public override void OHNXZEEHYBK(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x5C30D30", Offset = "0x5C2F530", VA = "0x185C30D30", Slot = "8")]
			public override void JXTHBHHIBVR(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x5C30D80", Offset = "0x5C2F580", VA = "0x185C30D80", Slot = "9")]
			public override void WESUIKQPLWH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x5C30D80", Offset = "0x5C2F580", VA = "0x185C30D80", Slot = "10")]
			public override void JYTEYXBFSAK(a a, SQEEUROIYMJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class OGCGPSRPVJO<a> : RUZYGNZVEZV<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x59D6F30", Offset = "0x59D5730", VA = "0x1859D6F30")]
			public OGCGPSRPVJO(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x59D6E70", Offset = "0x59D5670", VA = "0x1859D6E70", Slot = "5")]
			public override void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x59D6BB0", Offset = "0x59D53B0", VA = "0x1859D6BB0", Slot = "6")]
			public override void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class HILVUJLRKZI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static HILVUJLRKZI<a> QIBVUYLFYAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly FGAXTSOMSOK<a>[] EJKXGTHXXVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int EDWVWCOCWLY;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4F352D0", Offset = "0x4F33AD0", VA = "0x184F352D0")]
			public HILVUJLRKZI(List<FGAXTSOMSOK<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4F34FC0", Offset = "0x4F337C0", VA = "0x184F34FC0")]
			public void NRKQGERBRVA(a a, SQEEUROIYMJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4F35070", Offset = "0x4F33870", VA = "0x184F35070")]
			public void YLXFDFFRGEH(a a, ENYQFYCWRNL b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class NDHGCCXWNIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract FGAXTSOMSOK<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private SQEEUROIYMJ MKKSGYSEAVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int ULWQKFBYODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, NDHGCCXWNIM> SDSPCFHOBDT;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x756BFF0", Offset = "0x756A7F0", VA = "0x18756BFF0")]
		public HQYVQPECJVE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x36E04B0", Offset = "0x36DECB0", VA = "0x1836E04B0")]
		private HILVUJLRKZI<d> PPFISHIVENZ<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x36DF620", Offset = "0x36DDE20", VA = "0x1836DF620")]
		public void JPLRKQDWIBU<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x36DF560", Offset = "0x36DDD60", VA = "0x1836DF560")]
		public bool Deserialize<T>(ENYQFYCWRNL reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x36E1260", Offset = "0x36DFA60", VA = "0x1836E1260")]
		public void VOPQGDPBGDJ<f>(SQEEUROIYMJ a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class OSGVFLXEIVN
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime KLKBXTZOCIQ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] GMQWATHEDSO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator EDPLWXAJDHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7570330", Offset = "0x756EB30", VA = "0x187570330")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int MBRLXZEPVGY
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x756FF70", Offset = "0x756E770", VA = "0x18756FF70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x756FCC0", Offset = "0x756E4C0", VA = "0x18756FCC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode SQMPCVEDKCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x7570000", Offset = "0x756E800", VA = "0x187570000")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x756F670", Offset = "0x756DE70", VA = "0x18756F670")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int LGJEKLPVHAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7570300", Offset = "0x756EB00", VA = "0x187570300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint XUMTIVDUHZX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x756FFA0", Offset = "0x756E7A0", VA = "0x18756FFA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? RERPFLJNWCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x756FA60", Offset = "0x756E260", VA = "0x18756FA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? USATZNFPPSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7570360", Offset = "0x756EB60", VA = "0x187570360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? EYWTHKKJBND
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x756FA30", Offset = "0x756E230", VA = "0x18756FA30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x756FD00", Offset = "0x756E500", VA = "0x18756FD00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? GGPWQKOWOYH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xCE6710", Offset = "0xCE4F10", VA = "0x180CE6710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7570650", Offset = "0x756EE50", VA = "0x187570650")]
		public OSGVFLXEIVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x75705B0", Offset = "0x756EDB0", VA = "0x1875705B0")]
		internal OSGVFLXEIVN(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7570030", Offset = "0x756E830", VA = "0x187570030")]
		public static OSGVFLXEIVN SABNEJTUTPZ(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x756F6B0", Offset = "0x756DEB0", VA = "0x18756F6B0")]
		internal void DZYSZQLOOMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7570140", Offset = "0x756E940", VA = "0x187570140")]
		private void TEDKTPRYXOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x756FA90", Offset = "0x756E290", VA = "0x18756FA90")]
		private DateTime? IDJRVWBIISO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7570390", Offset = "0x756EB90", VA = "0x187570390")]
		private void ZCCJIGJNACK(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x756FEC0", Offset = "0x756E6C0", VA = "0x18756FEC0")]
		private ulong LTRAOGCOJUW(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x756F5B0", Offset = "0x756DDB0", VA = "0x18756F5B0")]
		private void BMJYMUSIZHM(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x756F550", Offset = "0x756DD50", VA = "0x18756F550")]
		private uint ALHINWJATCN(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x742F390", Offset = "0x742DB90", VA = "0x18742F390")]
		private static uint JXEKBUMOJOA(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x756FC60", Offset = "0x756E460", VA = "0x18756FC60")]
		private static ulong JXEKBUMOJOA(ulong a)
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
	internal sealed class FYSPCSZKLLC
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int XSIJXSONILT = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int WYCRSCNLTOQ = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int MBGFMOVYMCD = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint HXIJAMWIOUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int BVMEIDWRNNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int WYSSASVBCAN;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool FYFOTTSARDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x756B390", Offset = "0x7569B90", VA = "0x18756B390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x756B3A0", Offset = "0x7569BA0", VA = "0x18756B3A0")]
		public bool YTTTAOCXCKJ(YQKZKJATHYD a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class AHBQWDQHSMC : YQKZKJATHYD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket XTYQADGDBWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly FQKDQTMBFMJ QXDJMVMJVDT;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short JLHXHWOQGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x7560FA0", Offset = "0x755F7A0", VA = "0x187560FA0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int TNJDQBIOCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x75610B0", Offset = "0x755F8B0", VA = "0x1875610B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint LJJBLAXQRPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x75610D0", Offset = "0x755F8D0", VA = "0x1875610D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily BABUNKUBDJX
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x30094F0", Offset = "0x3007CF0", VA = "0x1830094F0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x75610F0", Offset = "0x755F8F0", VA = "0x1875610F0")]
		public AHBQWDQHSMC(AddressFamily a, FQKDQTMBFMJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7560980", Offset = "0x755F180", VA = "0x187560980", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7560F60", Offset = "0x755F760", VA = "0x187560F60", Slot = "9")]
		public int FAAFCCSCDSM(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7560FC0", Offset = "0x755F7C0", VA = "0x187560FC0", Slot = "10")]
		public int QGZMXVQZVBC(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7560F40", Offset = "0x755F740", VA = "0x187560F40", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface YQKZKJATHYD
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short JLHXHWOQGMF
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int TNJDQBIOCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint LJJBLAXQRPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily BABUNKUBDJX
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
		int FAAFCCSCDSM(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int QGZMXVQZVBC(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x756F1E0", Offset = "0x756D9E0", VA = "0x18756F1E0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x756F280", Offset = "0x756DA80", VA = "0x18756F280")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x136AC40", Offset = "0x1369440", VA = "0x18136AC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x756F0F0", Offset = "0x756D8F0", VA = "0x18756F0F0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x756F130", Offset = "0x756D930", VA = "0x18756F130", Slot = "0")]
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
	public class IRTBGLXMWKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string ORRVPTYFAKS = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int OVIBJKHVAIS = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int UFPRXZZEZOU = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int REYHVQLZSSC = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> GUWRKHGIAOP;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback WGSXZNAZOCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int FMCJELVCPWW;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		internal void KOIFOASCPEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		internal void YXTGOIBUNDG(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class XWHPLYETOZT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int XZXVGLZHHDI;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
		protected XWHPLYETOZT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GAHAVSXPIQB(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ADIAOSZXVTS(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class QQXZBUKTQGB : XWHPLYETOZT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] TVIXTBMOZHI;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator CCJZVUECRIU;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x290AF50", Offset = "0x2909750", VA = "0x18290AF50")]
		public QQXZBUKTQGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7570E10", Offset = "0x756F610", VA = "0x187570E10")]
		public void EXOYNUAKXYJ(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7571410", Offset = "0x756FC10", VA = "0x187571410")]
		public void RXLWMPHBJRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7570FC0", Offset = "0x756F7C0", VA = "0x187570FC0", Slot = "4")]
		public override void GAHAVSXPIQB(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7570B10", Offset = "0x756F310", VA = "0x187570B10", Slot = "5")]
		public override void ADIAOSZXVTS(IPEndPoint a, byte[] b, int c, int d)
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
		public unsafe delegate void Encrypt_000002A7$PostfixBurstDelegate([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int length);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		internal static class CZILBGSAKAM
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr ELAHYUKWAZW;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7577DA0", Offset = "0x75765A0", VA = "0x187577DA0")]
			[BurstDiscard]
			private static void BWIIRLRIEUI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7577F30", Offset = "0x7576730", VA = "0x187577F30")]
			private static IntPtr HEVBIXECYIW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x75780B0", Offset = "0x75768B0", VA = "0x1875780B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7572850", Offset = "0x7571050", VA = "0x187572850")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7572750", Offset = "0x7570F50", VA = "0x187572750")]
		private uint IFIDFOWBFOR(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x75606A0", Offset = "0x755EEA0", VA = "0x1875606A0")]
		private void OVCKOXARCQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7560490", Offset = "0x755EC90", VA = "0x187560490")]
		private void FILCDIIOPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7560850", Offset = "0x755F050", VA = "0x187560850")]
		private void XKLIUWYYZWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7560750", Offset = "0x755EF50", VA = "0x187560750")]
		private void TDEHYSBUQPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x75727F0", Offset = "0x7570FF0", VA = "0x1875727F0")]
		private void RTMNTAESRTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7572330", Offset = "0x7570B30", VA = "0x187572330")]
		private unsafe void CNCHCPGLDXH(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x75728D0", Offset = "0x75710D0", VA = "0x1875728D0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void VDISWQINJUM([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x75728E0", Offset = "0x75710E0", VA = "0x1875728E0")]
		public static void VDISWQINJUM(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7572280", Offset = "0x7570A80", VA = "0x187572280")]
		public static void AZSRFMHMFHS(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7572780", Offset = "0x7570F80", VA = "0x187572780")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void PWTTHLVWXKH([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x75783B0", Offset = "0x7576BB0", VA = "0x1875783B0")]
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
