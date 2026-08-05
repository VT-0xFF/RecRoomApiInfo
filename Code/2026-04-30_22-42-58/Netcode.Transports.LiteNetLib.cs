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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BWFQPONRQPS
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
		private NetworkManager LFPLYOXASJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool DVNLKLYJBEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, IUKCYHJIYJD> JJOOYDSYBQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CCTOFGXGRWY KHMWNRBLVUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch ILKUXJIKIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] PYHLFOZDOZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType RQLUWQFJHOM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LZJLSQMBODS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x89B6460", Offset = "0x89B5860", VA = "0x1889B6460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x89B6410", Offset = "0x89B5810", VA = "0x1889B6410", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89B5930", Offset = "0x89B4D30", VA = "0x1889B5930")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89B5910", Offset = "0x89B4D10", VA = "0x1889B5910")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89B5790", Offset = "0x89B4B90", VA = "0x1889B5790")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89B6320", Offset = "0x89B5720", VA = "0x1889B6320")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89B5AA0", Offset = "0x89B4EA0", VA = "0x1889B5AA0", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89B58D0", Offset = "0x89B4CD0", VA = "0x1889B58D0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89B5D70", Offset = "0x89B5170", VA = "0x1889B5D70", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89B6100", Offset = "0x89B5500", VA = "0x1889B6100", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89B4FE0", Offset = "0x89B43E0", VA = "0x1889B4FE0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89B4EF0", Offset = "0x89B42F0", VA = "0x1889B4EF0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89B51F0", Offset = "0x89B45F0", VA = "0x1889B51F0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89B5D00", Offset = "0x89B5100", VA = "0x1889B5D00", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89B5290", Offset = "0x89B4690", VA = "0x1889B5290", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89B4E20", Offset = "0x89B4220", VA = "0x1889B4E20")]
		private DeliveryMethod ATYVWBZURPL(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89B4D60", Offset = "0x89B4160", VA = "0x1889B4D60", Slot = "16")]
		private void AKYLNKATVRQ(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x89B5120", Offset = "0x89B4520", VA = "0x1889B5120", Slot = "17")]
		private void FHQHQTNWNXW(IUKCYHJIYJD a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "18")]
		private void XVVCOLQVKVR(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89B5570", Offset = "0x89B4970", VA = "0x1889B5570", Slot = "19")]
		private void LAIVKDILSFG(IUKCYHJIYJD a, BDATYCOHOFE b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x89B54A0", Offset = "0x89B48A0", VA = "0x1889B54A0")]
		private void KJVSEXTTWVF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "20")]
		private void QQFTFNEQVSW(IPEndPoint a, BDATYCOHOFE b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "21")]
		private void IKFNGGAHJKS(IUKCYHJIYJD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89B5A40", Offset = "0x89B4E40", VA = "0x1889B5A40", Slot = "22")]
		private void SGMALFTNEDG(HWKZXQUYVED a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x89B58A0", Offset = "0x89B4CA0", VA = "0x1889B58A0")]
		private ulong PPSRCQCJASL(IUKCYHJIYJD a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89B5880", Offset = "0x89B4C80", VA = "0x1889B5880")]
		private ulong PPSRCQCJASL(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89B5770", Offset = "0x89B4B70", VA = "0x1889B5770")]
		private static int NMIARPTVLYE(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89B6340", Offset = "0x89B5740", VA = "0x1889B6340")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89B50F0", Offset = "0x89B44F0", VA = "0x1889B50F0")]
		[CompilerGenerated]
		private void EREPQPNBYFW(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89B50F0", Offset = "0x89B44F0", VA = "0x1889B50F0")]
		[CompilerGenerated]
		private void GWZZRXYRCKN(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class YGOVBZNOKMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly IUKCYHJIYJD MQAKAQHXIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<GCAKMZMLOAV> VDEDUHYITFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int IGIGQLSQSUC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DIODCFDMGNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x89B9680", Offset = "0x89B8A80", VA = "0x1889B9680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89B96D0", Offset = "0x89B8AD0", VA = "0x1889B96D0")]
		protected YGOVBZNOKMS(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89B95A0", Offset = "0x89B89A0", VA = "0x1889B95A0")]
		public void ECOVDJZTLUP(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89B9600", Offset = "0x89B8A00", VA = "0x1889B9600")]
		protected void ESKCPQRJKKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89B9560", Offset = "0x89B8960", VA = "0x1889B9560")]
		public bool AYLQONJGZAS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool KOVOIXGGFHM();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool NYKIXUVJJQL(GCAKMZMLOAV a);
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
	public class HWKZXQUYVED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly CCTOFGXGRWY HTNWIJRKRPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int EIFJOZRBYLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal NWXAGOGBNCC RJROYKEQOZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint DKZBGTEUXSF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult LFFMOTSPEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1631700", Offset = "0x1630B00", VA = "0x181631700")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1631710", Offset = "0x1630B10", VA = "0x181631710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89AE5D0", Offset = "0x89AD9D0", VA = "0x1889AE5D0")]
		internal void OCUBMUWTRWI(NWXAGOGBNCC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89AE5A0", Offset = "0x89AD9A0", VA = "0x1889AE5A0")]
		private bool FZYAMEXALBE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89AE630", Offset = "0x89ADA30", VA = "0x1889AE630")]
		internal HWKZXQUYVED(IPEndPoint a, NWXAGOGBNCC b, CCTOFGXGRWY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89AE540", Offset = "0x89AD940", VA = "0x1889AE540")]
		public IUKCYHJIYJD Accept()
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
		public BDATYCOHOFE AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface BWFQPONRQPS
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UYWXBONYCCG(IUKCYHJIYJD a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KEUFFLETOFK(IUKCYHJIYJD a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SYEEZBWUTUD(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QBGSNTGZRQQ(IUKCYHJIYJD a, BDATYCOHOFE b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZDNVHUANTTA(IPEndPoint a, BDATYCOHOFE b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BEYYYEOHWAW(IUKCYHJIYJD a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FWYNINEOJCQ(HWKZXQUYVED a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface UEREJSTGLET
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GWLVZMOQHJM(IUKCYHJIYJD a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NYMBZNTYPYT
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RNORJXGRSHW(ENWPNYEPXMI a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ZIMFIKNURAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VMZGQBLWYAT(IUKCYHJIYJD a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class NWXAGOGBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int EFQORRILICC = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long BNKPUHTQTLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte ADLHWLNUETR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] JPNCNDXEZSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly LUQYATNJAPE YVVJIHKGLFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int HNXEMUAIPNN;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89B69D0", Offset = "0x89B5DD0", VA = "0x1889B69D0")]
		private NWXAGOGBNCC(long a, byte b, int c, byte[] d, LUQYATNJAPE e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89B67B0", Offset = "0x89B5BB0", VA = "0x1889B67B0")]
		public static int WLPUPLMELYD(GCAKMZMLOAV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89B67E0", Offset = "0x89B5BE0", VA = "0x1889B67E0")]
		public static NWXAGOGBNCC WQNXGLVMKQK(GCAKMZMLOAV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89B65D0", Offset = "0x89B59D0", VA = "0x1889B65D0")]
		public static GCAKMZMLOAV QVHZAINYILO(HSNKFEDGGUG a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class GIYTCFQLWTP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long BNKPUHTQTLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte ADLHWLNUETR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int HNXEMUAIPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool VBFADOYYFME;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89AD6B0", Offset = "0x89ACAB0", VA = "0x1889AD6B0")]
		private GIYTCFQLWTP(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89AD5B0", Offset = "0x89AC9B0", VA = "0x1889AD5B0")]
		public static GIYTCFQLWTP WQNXGLVMKQK(GCAKMZMLOAV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89AD4C0", Offset = "0x89AC8C0", VA = "0x1889AD4C0")]
		public static GCAKMZMLOAV QVHZAINYILO(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89AD3C0", Offset = "0x89AC7C0", VA = "0x1889AD3C0")]
		public static GCAKMZMLOAV KBPCQZHFCLI(IUKCYHJIYJD a)
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
	public interface JBCNJCMQNYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZQMZYQGDGXJ(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GEWXPNTYQGZ(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class KHJUKRVOSMX
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
		private class ZESCCEGOCKD
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint GEJNJYCSKGX
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string HMAZRGHHANJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public ZESCCEGOCKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class CLIELUAYJXD
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint GEJNJYCSKGX
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint VIGATXHRUOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string HMAZRGHHANJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public CLIELUAYJXD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class JSLTHHYKJOX
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string HMAZRGHHANJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool LXXRXBTJJND
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEABB30", Offset = "0xEAAF30", VA = "0x180EABB30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xCF6C00", Offset = "0xCF6000", VA = "0x180CF6C00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public JSLTHHYKJOX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly CCTOFGXGRWY ZEVPMCRUIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> RAITAEKMKQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> FTHHCZASDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly LUQYATNJAPE YPFHOQYKQLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly HSNKFEDGGUG CNESAWYQLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly POGCMBAQPHV BLIAPAIQBWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JBCNJCMQNYQ TEOEAQMFCXE;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int OPSBJKRKASJ = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool BJADNHVWRJA;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x89B35D0", Offset = "0x89B29D0", VA = "0x1889B35D0")]
		internal KHJUKRVOSMX(CCTOFGXGRWY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x89B32C0", Offset = "0x89B26C0", VA = "0x1889B32C0")]
		internal void VSZMDSBKSSW(IPEndPoint a, GCAKMZMLOAV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7420", Offset = "0x3BB6820", VA = "0x183BB7420")]
		private void RXBHTTODHVW<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89B3440", Offset = "0x89B2840", VA = "0x1889B3440")]
		private void ZQMZYQGDGXJ(ZESCCEGOCKD a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89B2FC0", Offset = "0x89B23C0", VA = "0x1889B2FC0")]
		private void AUJUZPPQTDL(CLIELUAYJXD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89B3120", Offset = "0x89B2520", VA = "0x1889B3120")]
		private void BNBYKHDLEEK(JSLTHHYKJOX a, IPEndPoint b)
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
	public static class UGYCNQGTZJQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] KDYFQAJCNKL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int JYTUJWEHIMR;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int SDFWZHDULWY;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89B2790", Offset = "0x89B1B90", VA = "0x1889B2790")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x89B2790", Offset = "0x89B1B90", VA = "0x1889B2790")]
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
	public interface IQBWLEWNNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BCZITCKCBWU(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BZSPZEKGLCE
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static IQBWLEWNNOM KHLKFNYWTNM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object QIFKSYAZMOW;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x89A26E0", Offset = "0x89A1AE0", VA = "0x1889A26E0")]
		private static void ZCWFDZDVYYV(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89A2680", Offset = "0x89A1A80", VA = "0x1889A2680")]
		internal static void UYWJPOCTLMZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x89A2620", Offset = "0x89A1A20", VA = "0x1889A2620")]
		internal static void HAWLIORFMTN(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89A25C0", Offset = "0x89A19C0", VA = "0x1889A25C0")]
		internal static void CRFYZRVAMPL(string a, params object[] args)
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
	public sealed class BDATYCOHOFE : LUQYATNJAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private GCAKMZMLOAV HYWXXBDAYEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly CCTOFGXGRWY WNJLULMYZPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly XAPFEPUGBUX SRSLQKXVFLW;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x89A2570", Offset = "0x89A1970", VA = "0x1889A2570")]
		internal BDATYCOHOFE(CCTOFGXGRWY a, XAPFEPUGBUX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x89A24D0", Offset = "0x89A18D0", VA = "0x1889A24D0")]
		internal void GUCJYSOKIVR(GCAKMZMLOAV a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89A2450", Offset = "0x89A1850", VA = "0x1889A2450")]
		internal void CZMSADAKTPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89A2540", Offset = "0x89A1940", VA = "0x1889A2540")]
		public void VWZSAZHZBWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class XAPFEPUGBUX
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
		public XAPFEPUGBUX GQSESNXTZCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType UXYUOXCBTLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IUKCYHJIYJD MQAKAQHXIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint DKZBGTEUXSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object IHPEQKWQVFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int EGMUSXKGPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError XKGHHUYASSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason NXRVZXRGXQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HWKZXQUYVED HWKZXQUYVED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod PKICWRUKKSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte ETIJUQTCPIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly BDATYCOHOFE AIWJDMCOISV;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x89B94C0", Offset = "0x89B88C0", VA = "0x1889B94C0")]
		public XAPFEPUGBUX(CCTOFGXGRWY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CCTOFGXGRWY : IEnumerable<IUKCYHJIYJD>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class YJAZEUQTBEV : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x89B9760", Offset = "0x89B8B60", VA = "0x1889B9760", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x89B97D0", Offset = "0x89B8BD0", VA = "0x1889B97D0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public YJAZEUQTBEV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<IUKCYHJIYJD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly IUKCYHJIYJD _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private IUKCYHJIYJD _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public IUKCYHJIYJD Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xF3E410", Offset = "0xF3D810", VA = "0x180F3E410", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF3E410", Offset = "0xF3D810", VA = "0x180F3E410", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D7F640", Offset = "0x1D7EA40", VA = "0x181D7F640")]
			public NetPeerEnumerator(IUKCYHJIYJD p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x89B6E10", Offset = "0x89B6210", VA = "0x1889B6E10", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x89B6E60", Offset = "0x89B6260", VA = "0x1889B6E60", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread NROJKLSIJTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool PHZCMJEFEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool MFVSCDBMFSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private XBVVASIKIDT OWWWBSKCRDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent JDFSANPHTVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<XAPFEPUGBUX> LTBDYURUWQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<XAPFEPUGBUX> CMJHHYYDIBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private XAPFEPUGBUX YXDQWTUUGQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly BWFQPONRQPS CGOHDWTLGXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly UEREJSTGLET KXPAQDGJTFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly NYMBZNTYPYT HIHREFBUHCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly ZIMFIKNURAF HWEVYARUZWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, IUKCYHJIYJD> DNFTFLDWQMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, HWKZXQUYVED> XWWSARQKZTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, DLESYOQMZPL> UDSIEDGBLFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim FNXNSAJEBXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IUKCYHJIYJD XDMQPHPLVSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int ITQJCSYFMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<IUKCYHJIYJD> FXJXTXBFYSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private IUKCYHJIYJD[] JRODUJNPGGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly JZGSZEAVDXU QIZJIVMBWRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int YFRIXJNRMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> XOZJPZJZRRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte RSXMHLXOYTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object VNVZSVNNMLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool UAFSLQYILIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool BWGXGJDRQXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int CVJSATIJQXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int QJISCGTYLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int IBGKBRDMQKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int TQBIKLRMMBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool APGAOOGGBUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool OTKDSPBWSKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int RHXCVDBRAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int IIYIZSSWYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int WRVWNHALAER;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool BJADNHVWRJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool HXOHWUEKIJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool AVPLYQOKVZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool NUMUDBUSPXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int NDSFQJBKHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int YXTWESTJGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool PBWLYCNTWBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly CHFMEICIMXA GFEHRHNOMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool YRKHVFBQYSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly KHJUKRVOSMX KHJUKRVOSMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool TTSSWYMXZSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode XADSDNPMDSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int CBSPBEILYZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool EBZBVFQFCTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool MVDFCJXAEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool DRSOGWEURCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool XDAZPOXCRFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private GCAKMZMLOAV UYTYFMWBEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int QJQZJUROMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object GCJZWYMGLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private GCAKMZMLOAV FCUPFEAPMXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int QIKMEHKCICX;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int TZJVDVAUUYN = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int QYRSHFFFLCC = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private WKKNWIOZJWM AQSZXVJCXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private WKKNWIOZJWM AQIMDHVIEDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread RVERYQYNQPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread RUUEEDKSXTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint JZFSYDYEERQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint JYVFDQKJLUY;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] HRATQDHAJHM;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] JUZTTKVSWRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> HAKZUQKSSQD;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress EOXXYJKXWPG;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool YOAJCIWWVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int BBSOONLDFMY;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ZLVTDCBYXWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE74780", Offset = "0xE73B80", VA = "0x180E74780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE72470", Offset = "0xE71870", VA = "0x180E72470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int ENPVCMIYBBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x222E4F0", Offset = "0x222D8F0", VA = "0x18222E4F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23472E0", Offset = "0x23466E0", VA = "0x1823472E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte UMJSSUUJCDX
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE0AED0", Offset = "0xE0A2D0", VA = "0x180E0AED0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int YFVUIQHRRGV
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x89A4200", Offset = "0x89A3600", VA = "0x1889A4200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short KBPLVEBKAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x89A3F90", Offset = "0x89A3390", VA = "0x1889A3F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IUKCYHJIYJD.OnUpdatedMtuDelegate NIAJCBWLFVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89A9530", Offset = "0x89A8930", VA = "0x1889A9530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89A48C0", Offset = "0x89A3CC0", VA = "0x1889A48C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89A29B0", Offset = "0x89A1DB0", VA = "0x1889A29B0")]
		public void ABBPREUCZQU(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x89A93E0", Offset = "0x89A87E0", VA = "0x1889A93E0")]
		public void VCCRPLITEWF(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x89A5FD0", Offset = "0x89A53D0", VA = "0x1889A5FD0")]
		private bool LVSJELNLXJP(IPEndPoint a, [Out] IUKCYHJIYJD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89A98B0", Offset = "0x89A8CB0", VA = "0x1889A98B0")]
		private void YDXXCTXWLEV(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89A6510", Offset = "0x89A5910", VA = "0x1889A6510")]
		private void OEWBOHCIFCK(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x89A45A0", Offset = "0x89A39A0", VA = "0x1889A45A0")]
		private void JLCNKCOBVBJ(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89AA170", Offset = "0x89A9570", VA = "0x1889AA170")]
		public CCTOFGXGRWY(BWFQPONRQPS a, [Optional] JZGSZEAVDXU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89A3030", Offset = "0x89A2430", VA = "0x1889A3030")]
		internal void AJOBCMZAXXN(IUKCYHJIYJD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x89A9F00", Offset = "0x89A9300", VA = "0x1889A9F00")]
		internal void ZKZWZGQWAXZ(IUKCYHJIYJD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x89A7000", Offset = "0x89A6400", VA = "0x1889A7000")]
		internal void SHCBXJEPONN(IUKCYHJIYJD a, DisconnectReason b, SocketError c, GCAKMZMLOAV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89A2C10", Offset = "0x89A2010", VA = "0x1889A2C10")]
		private void ABWNDGIFNZW(IUKCYHJIYJD a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, GCAKMZMLOAV h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x89A9010", Offset = "0x89A8410", VA = "0x1889A9010")]
		private void ULJNDNSIXDE(XAPFEPUGBUX.EType a, [Optional] IUKCYHJIYJD b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] HWKZXQUYVED g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] GCAKMZMLOAV j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89A70D0", Offset = "0x89A64D0", VA = "0x1889A70D0")]
		private void SSLZRBSROON(XAPFEPUGBUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x89A6570", Offset = "0x89A5970", VA = "0x1889A6570")]
		internal void OJUROZJTWIB(XAPFEPUGBUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89A4220", Offset = "0x89A3620", VA = "0x1889A4220")]
		private void GRDGZGKAYVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89A9BD0", Offset = "0x89A8FD0", VA = "0x1889A9BD0")]
		private void YRJAVPIYDRH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89A6950", Offset = "0x89A5D50", VA = "0x1889A6950")]
		internal IUKCYHJIYJD QCZHYWDLJMG(HWKZXQUYVED a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89A6F80", Offset = "0x89A6380", VA = "0x1889A6F80")]
		private int QHTUMHJJBNU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89A6070", Offset = "0x89A5470", VA = "0x1889A6070")]
		private void NZEABDRSYUY(IPEndPoint a, IUKCYHJIYJD b, NWXAGOGBNCC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89A4CD0", Offset = "0x89A40D0", VA = "0x1889A4CD0")]
		private void LDZNETRORLL(GCAKMZMLOAV a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x89A6680", Offset = "0x89A5A80", VA = "0x1889A6680")]
		internal void OPVATKDETHT(GCAKMZMLOAV a, DeliveryMethod b, byte c, int d, IUKCYHJIYJD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89A7890", Offset = "0x89A6C90", VA = "0x1889A7890")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x89A7980", Offset = "0x89A6D80", VA = "0x1889A7980")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89A7900", Offset = "0x89A6D00", VA = "0x1889A7900")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89A4050", Offset = "0x89A3450", VA = "0x1889A4050")]
		public void FBUHSVHTYNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89A32E0", Offset = "0x89A26E0", VA = "0x1889A32E0")]
		public IUKCYHJIYJD Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89A3200", Offset = "0x89A2600", VA = "0x1889A3200")]
		public IUKCYHJIYJD Connect(string address, int port, HSNKFEDGGUG connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89A33C0", Offset = "0x89A27C0", VA = "0x1889A33C0")]
		public IUKCYHJIYJD Connect(IPEndPoint target, HSNKFEDGGUG connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89A8110", Offset = "0x89A7510", VA = "0x1889A8110")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89A8120", Offset = "0x89A7520", VA = "0x1889A8120")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89A3C80", Offset = "0x89A3080", VA = "0x1889A3C80")]
		public void EDHTBTLICJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89A3BB0", Offset = "0x89A2FB0", VA = "0x1889A3BB0")]
		public void EDHTBTLICJZ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x89A2BD0", Offset = "0x89A1FD0", VA = "0x1889A2BD0")]
		public void ABWNDGIFNZW(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89A2FF0", Offset = "0x89A23F0", VA = "0x1889A2FF0")]
		public void ABWNDGIFNZW(IUKCYHJIYJD a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89A9820", Offset = "0x89A8C20", VA = "0x1889A9820", Slot = "4")]
		private IEnumerator<IUKCYHJIYJD> XQDNBEVPDEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89A7040", Offset = "0x89A6440", VA = "0x1889A7040", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89A4BF0", Offset = "0x89A3FF0", VA = "0x1889A4BF0")]
		private GCAKMZMLOAV LCVVMFRAMAJ(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89A4B10", Offset = "0x89A3F10", VA = "0x1889A4B10")]
		private GCAKMZMLOAV LCVVMFRAMAJ(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x89A95E0", Offset = "0x89A89E0", VA = "0x1889A95E0")]
		internal GCAKMZMLOAV XMVARGPPRRK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x89A3D30", Offset = "0x89A3130", VA = "0x1889A3D30")]
		internal void EHZRGIQFHCB(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89AA0B0", Offset = "0x89A94B0", VA = "0x1889AA0B0")]
		static CCTOFGXGRWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE74780", Offset = "0xE73B80", VA = "0x180E74780")]
		private bool PDOLUVAGPUY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x89A9F50", Offset = "0x89A9350", VA = "0x1889A9F50")]
		private void ZSBTVQJTGAC(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89A3A60", Offset = "0x89A2E60", VA = "0x1889A3A60")]
		private void EAXGUSMPEIJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x89A4970", Offset = "0x89A3D70", VA = "0x1889A4970")]
		private bool KXLWILEGMZJ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89A4580", Offset = "0x89A3980", VA = "0x1889A4580")]
		private void IJJUNSAISWQ(XBVVASIKIDT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89A3790", Offset = "0x89A2B90", VA = "0x1889A3790")]
		private void DSSXXQAHHSN(WKKNWIOZJWM a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89A8C90", Offset = "0x89A8090", VA = "0x1889A8C90")]
		private void TUXWNIAFYBF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x89A79A0", Offset = "0x89A6DA0", VA = "0x1889A79A0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x89A4860", Offset = "0x89A3C60", VA = "0x1889A4860")]
		internal int JUJQNGNZHKU(GCAKMZMLOAV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x89A8C50", Offset = "0x89A8050", VA = "0x1889A8C50")]
		internal int TGAJIQLKXFE(GCAKMZMLOAV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x89A8480", Offset = "0x89A7880", VA = "0x1889A8480")]
		internal int TGAJIQLKXFE(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x89A3080", Offset = "0x89A2480", VA = "0x1889A3080")]
		internal void BBVKTFKIARB(bool a)
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
	internal sealed class GCAKMZMLOAV
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int PMEUNOFFDDQ;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] KTBGLDRZXJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] BEEQTBJBAUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int MQIMAXWABZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object IHPEQKWQVFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GCAKMZMLOAV GQSESNXTZCL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty WIAAFFAKCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x89ACC50", Offset = "0x89AC050", VA = "0x1889ACC50")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x89ACD10", Offset = "0x89AC110", VA = "0x1889ACD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte ADLHWLNUETR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x89ACA90", Offset = "0x89ABE90", VA = "0x1889ACA90")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x89ACF10", Offset = "0x89AC310", VA = "0x1889ACF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort FGZHLSIACBV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x89ACC30", Offset = "0x89AC030", VA = "0x1889ACC30")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x89ACCA0", Offset = "0x89AC0A0", VA = "0x1889ACCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IQVNKOSSZUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x89ACCE0", Offset = "0x89AC0E0", VA = "0x1889ACCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte JEVUVWVPZKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x89ACEA0", Offset = "0x89AC2A0", VA = "0x1889ACEA0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x89ACD70", Offset = "0x89AC170", VA = "0x1889ACD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort ETMXHSTLTLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x89ACA70", Offset = "0x89ABE70", VA = "0x1889ACA70")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x89ACF50", Offset = "0x89AC350", VA = "0x1889ACF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort GRCXOLWKAMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x89ACD50", Offset = "0x89AC150", VA = "0x1889ACD50")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x89ACED0", Offset = "0x89AC2D0", VA = "0x1889ACED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort CXSJLEHJEMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x89ACC80", Offset = "0x89AC080", VA = "0x1889ACC80")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x89ACBF0", Offset = "0x89ABFF0", VA = "0x1889ACBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89ACF90", Offset = "0x89AC390", VA = "0x1889ACF90")]
		static GCAKMZMLOAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x89ACAC0", Offset = "0x89ABEC0", VA = "0x1889ACAC0")]
		public void CCHRDHWHLWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x89AD240", Offset = "0x89AC640", VA = "0x1889AD240")]
		public GCAKMZMLOAV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x89AD2B0", Offset = "0x89AC6B0", VA = "0x1889AD2B0")]
		public GCAKMZMLOAV(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x89ACDA0", Offset = "0x89AC1A0", VA = "0x1889ACDA0")]
		public static int NYNVNTQGVLI(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x89ACE10", Offset = "0x89AC210", VA = "0x1889ACE10")]
		public int NYNVNTQGVLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x89ACAF0", Offset = "0x89ABEF0", VA = "0x1889ACAF0")]
		public bool CTFANBOYOTR()
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
	public class IUKCYHJIYJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class VKXHCWSNBAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public GCAKMZMLOAV[] XBBQDPUPGRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int FQWIUDLSGUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int AGIOEDGLYWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte JEVUVWVPZKU;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VKXHCWSNBAT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int VVMFAPUXHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int ORIQRDIPMQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int DREPRINWNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double IQKKCETKTGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int ENAMVDPPQYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int HGQZEMGTMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int BEWQYHGHOIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch DXWTZLYRTIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int VGDPXIIIWCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long ZNKDFKHQYKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object MDDANJZHOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal IUKCYHJIYJD JNOFCVCOJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal IUKCYHJIYJD YVEVWHLEUDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<GCAKMZMLOAV> ANFZLJNJOQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<YGOVBZNOKMS> OXNEFXEYFQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly YGOVBZNOKMS[] BIQAUUCDNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int DLDGRXWGDIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int XAKNMLXNIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool MBKOZTGXREU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int ZPDLADIKQYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int ZDCGDUVXAPX;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int YCDFLUQWDVT = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int CHEKXMQXQJY = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object WRGICONXCTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int LHKTLTJUTPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, VKXHCWSNBAT> XDQKBIPXBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> QCHXUKYPGKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly GCAKMZMLOAV XUZBNFFPNMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int YACYSVOOFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int FOWXPOVMDRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint YAIWLXONVVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int QCVYYOTQEGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int WOWPMBUKPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long XBHZHUHHIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte WCLMLQBMWDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState LIQQZNUWFKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GCAKMZMLOAV HXEOOOSKBMB;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int URUEFUNFEUX = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int ZGZRAYHOOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly GCAKMZMLOAV XTDRHOLQGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly GCAKMZMLOAV KVYHMLCJNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly GCAKMZMLOAV LONRYWGLCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly GCAKMZMLOAV CBTJWYBYBJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality TIHUUNVRFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly CCTOFGXGRWY CCTOFGXGRWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int SGYXLDBUDMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object LZHYGFSTXJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly CHFMEICIMXA GFEHRHNOMKN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte HBJNUYEPHWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD21650", Offset = "0xD20A50", VA = "0x180D21650")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x89AF7A0", Offset = "0x89AEBA0", VA = "0x1889AF7A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint MYONXUJBADV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE70150", Offset = "0xE6F550", VA = "0x180E70150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState SSOQXRBHUMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1490760", Offset = "0x148FB60", VA = "0x181490760")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long RJEKMLTWWMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCFF450", Offset = "0xCFE850", VA = "0x180CFF450")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int HNGEFDPZETT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x222E4F0", Offset = "0x222D8F0", VA = "0x18222E4F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x23472E0", Offset = "0x23466E0", VA = "0x1823472E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int IMPCINVETVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x89AED40", Offset = "0x89AE140", VA = "0x1889AED40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int IKIWHDCOFBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD11F80", Offset = "0xD11380", VA = "0x180D11F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double QKDBJYNLKRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9F30", Offset = "0x2AC9330", VA = "0x182AC9F30")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate NIAJCBWLFVY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x89B1830", Offset = "0x89B0C30", VA = "0x1889B1830")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x89AEFE0", Offset = "0x89AE3E0", VA = "0x1889AEFE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x89B21B0", Offset = "0x89B15B0", VA = "0x1889B21B0")]
		internal IUKCYHJIYJD(CCTOFGXGRWY a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x89B1810", Offset = "0x89B0C10", VA = "0x1889B1810")]
		internal void VDOIAAWVREQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x89AF090", Offset = "0x89AE490", VA = "0x1889AF090")]
		internal void LJZGCGEUONG(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x89AED50", Offset = "0x89AE150", VA = "0x1889AED50")]
		internal void JHTWBTLLLVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x89AEC70", Offset = "0x89AE070", VA = "0x1889AEC70")]
		private void IHKXCXSVPVA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x89AF0C0", Offset = "0x89AE4C0", VA = "0x1889AF0C0")]
		private void MSTTJBNUTUK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x89B1920", Offset = "0x89B0D20", VA = "0x1889B1920")]
		public int YCRIBDMDEVW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x89B1A30", Offset = "0x89B0E30", VA = "0x1889B1A30")]
		public int YCRIBDMDEVW(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x89B0000", Offset = "0x89AF400", VA = "0x1889B0000")]
		private YGOVBZNOKMS OORBIXNNNKF(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x89B2020", Offset = "0x89B1420", VA = "0x1889B2020")]
		internal IUKCYHJIYJD(CCTOFGXGRWY a, IPEndPoint b, int c, byte d, HSNKFEDGGUG e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x89B25B0", Offset = "0x89B19B0", VA = "0x1889B25B0")]
		internal IUKCYHJIYJD(CCTOFGXGRWY a, HWKZXQUYVED b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x89B0550", Offset = "0x89AF950", VA = "0x1889B0550")]
		internal void Reject(NWXAGOGBNCC requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F00", Offset = "0x89B1300", VA = "0x1889B1F00")]
		internal bool YYCYHIBBRGL(GIYTCFQLWTP a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x89B0520", Offset = "0x89AF920", VA = "0x1889B0520")]
		public void RXBHTTODHVW(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x89AFA10", Offset = "0x89AEE10", VA = "0x1889AFA10")]
		private void OMXYBRRJSDH(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x89AEC20", Offset = "0x89AE020", VA = "0x1889AEC20")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F80", Offset = "0x89B1380", VA = "0x1889B1F80")]
		internal DisconnectResult ZTERVFBTGBX(GCAKMZMLOAV a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x89AEBC0", Offset = "0x89ADFC0", VA = "0x1889AEBC0")]
		internal void CLDPXQZRZVA(YGOVBZNOKMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x89B0E30", Offset = "0x89B0230", VA = "0x1889B0E30")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x89B18E0", Offset = "0x89B0CE0", VA = "0x1889B18E0")]
		private void WUFAKURBJFV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x89B05A0", Offset = "0x89AF9A0", VA = "0x1889B05A0")]
		internal void SZINCMUSMUH(DeliveryMethod a, GCAKMZMLOAV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x89AE6A0", Offset = "0x89ADAA0", VA = "0x1889AE6A0")]
		private void BFIOEQNLFZL(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x89B0190", Offset = "0x89AF590", VA = "0x1889B0190")]
		private void RBELSKEJGPP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x89AF850", Offset = "0x89AEC50", VA = "0x1889AF850")]
		internal ConnectRequestResult NZEABDRSYUY(NWXAGOGBNCC a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x89AF100", Offset = "0x89AE500", VA = "0x1889AF100")]
		internal void NYKIXUVJJQL(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x89B1B50", Offset = "0x89B0F50", VA = "0x1889B1B50")]
		private void YQRLHLCLZTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x89AEDE0", Offset = "0x89AE1E0", VA = "0x1889AEDE0")]
		internal void JTUIWTRYFZJ(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x89B1140", Offset = "0x89B0540", VA = "0x1889B1140")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x89B1CA0", Offset = "0x89B10A0", VA = "0x1889B1CA0")]
		internal void YSSCVWBCNGV(GCAKMZMLOAV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class CHFMEICIMXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long GWSBXWLCABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long QQCZEDTKCQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long RBNMUARCTYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long DCDOZRHQSCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long VCUTHATRIPK;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long DEOWWIDWSNJ;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long MDSXPFLWSMG;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long WMBIZJZSESJ;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long SWKYAMBZDBG;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long BXMJTBSRAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long MRRAXNLICZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long SZYIGTSIEEA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long CHUMONHWKSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x89AA7E0", Offset = "0x89A9BE0", VA = "0x1889AA7E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long UFYXQQAEGQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x89AA830", Offset = "0x89A9C30", VA = "0x1889AA830")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long SSNUDUZYCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x89AAE40", Offset = "0x89AA240", VA = "0x1889AAE40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long DLZPQBDHSZA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x89AA8F0", Offset = "0x89A9CF0", VA = "0x1889AA8F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long WFQCGRCPSIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x89AA8E0", Offset = "0x89A9CE0", VA = "0x1889AA8E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long VJLLHTKCYDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x89AAEB0", Offset = "0x89AA2B0", VA = "0x1889AAEB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long QPZBQSGTAXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x89AA7F0", Offset = "0x89A9BF0", VA = "0x1889AA7F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long LEXRBYXBLXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x89AA9D0", Offset = "0x89A9DD0", VA = "0x1889AA9D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality UTXHCKXEQYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x141C5C0", Offset = "0x141B9C0", VA = "0x18141C5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double RQJFVNNRBHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x89AA970", Offset = "0x89A9D70", VA = "0x1889AA970")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x89AAA70", Offset = "0x89A9E70", VA = "0x1889AAA70")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x89AAAB0", Offset = "0x89A9EB0", VA = "0x1889AAAB0")]
		public void TPCCZOAWKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x89AA790", Offset = "0x89A9B90", VA = "0x1889AA790")]
		public void AFGOEZCQMCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x89AAA10", Offset = "0x89A9E10", VA = "0x1889AAA10")]
		public void RPJRWXXQEGO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x89AA730", Offset = "0x89A9B30", VA = "0x1889AA730")]
		public void AAJIIPFINJZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x89AAE50", Offset = "0x89AA250", VA = "0x1889AAE50")]
		public void VUWPHRNUNMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x89AA900", Offset = "0x89A9D00", VA = "0x1889AA900")]
		public void MHNOYQWNXCO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x89AAB10", Offset = "0x89A9F10", VA = "0x1889AAB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x89AA840", Offset = "0x89A9C40", VA = "0x1889AA840")]
		public void IZDFAWVDAYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public CHFMEICIMXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class FQCHWESBWTE
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> VJYJYGOTFML;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x89AC560", Offset = "0x89AB960", VA = "0x1889AC560")]
		public static IPEndPoint SKHEGXXBHMB(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x89AC830", Offset = "0x89ABC30", VA = "0x1889AC830")]
		public static IPAddress TZIKFLNVLWO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x89AC7A0", Offset = "0x89ABBA0", VA = "0x1889AC7A0")]
		public static IPAddress TZIKFLNVLWO(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x89AC530", Offset = "0x89AB930", VA = "0x1889AC530")]
		internal static int GTNWDWHKZKW(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6450", Offset = "0x3AA5850", VA = "0x183AA6450")]
		internal static T[] KZHOSYGHUDZ<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class OWBOZSBACXR : YGOVBZNOKMS
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private GCAKMZMLOAV _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x89B82F0", Offset = "0x89B76F0", VA = "0x1889B82F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x89B82D0", Offset = "0x89B76D0", VA = "0x1889B82D0")]
			public void ORLMZSMEYLO(GCAKMZMLOAV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x89B8260", Offset = "0x89B7660", VA = "0x1889B8260")]
			public bool FYIZWJYZTDX(long a, IUKCYHJIYJD b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x89B8210", Offset = "0x89B7610", VA = "0x1889B8210")]
			public bool Clear(IUKCYHJIYJD peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly GCAKMZMLOAV CPZOZQBSVEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] BRPCOGISXFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly GCAKMZMLOAV[] ZMQYARYXEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] VHMDCNDOILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int QEKFYUNGXQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int FQJDTMUMBQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int XPVOUSVGCGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int RIRBCIQDRTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool KOWJITBUEQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod CLGNSCVMTFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool PKPPEDCUWHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int AGTGDJTDGAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte YQIKSJKKWIO;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int KJYIKEHPKNL
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x89B6EA0", Offset = "0x89B62A0", VA = "0x1889B6EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x89B7D00", Offset = "0x89B7100", VA = "0x1889B7D00")]
		public OWBOZSBACXR(IUKCYHJIYJD a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x89B6EB0", Offset = "0x89B62B0", VA = "0x1889B6EB0")]
		private void JBEDJOPDPZW(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x89B7230", Offset = "0x89B6630", VA = "0x1889B7230", Slot = "4")]
		protected override bool KOVOIXGGFHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x89B7700", Offset = "0x89B6B00", VA = "0x1889B7700", Slot = "5")]
		public override bool NYKIXUVJJQL(GCAKMZMLOAV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class ROABTRPFKBG : YGOVBZNOKMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int ZDCEVGUCOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort FQJDTMUMBQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool EGIQXADCPAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private GCAKMZMLOAV RSEIMQDBBTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly GCAKMZMLOAV QGCNVQNKNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool NBUVFDKUYFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte YQIKSJKKWIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long PXFIQCUWPFK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x89B8AA0", Offset = "0x89B7EA0", VA = "0x1889B8AA0")]
		public ROABTRPFKBG(IUKCYHJIYJD a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x89B8360", Offset = "0x89B7760", VA = "0x1889B8360", Slot = "4")]
		protected override bool KOVOIXGGFHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x89B8820", Offset = "0x89B7C20", VA = "0x1889B8820", Slot = "5")]
		public override bool NYKIXUVJJQL(GCAKMZMLOAV a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class DVXSDUIBKCR
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
		[Cpp2IlInjected.Address(RVA = "0x89A1E70", Offset = "0x89A1270", VA = "0x1889A1E70")]
		private static void SGUPCYATOOG(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x89AB080", Offset = "0x89AA480", VA = "0x1889AB080")]
		private static void SGUPCYATOOG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x89AB040", Offset = "0x89AA440", VA = "0x1889AB040")]
		public static void SGUPCYATOOG(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x89AB100", Offset = "0x89AA500", VA = "0x1889AB100")]
		public static void OTSNVORVUSV(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x89AAFC0", Offset = "0x89AA3C0", VA = "0x1889AAFC0")]
		public static void OTSNVORVUSV(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x89AB040", Offset = "0x89AA440", VA = "0x1889AB040")]
		public static void OTSNVORVUSV(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x89AB040", Offset = "0x89AA440", VA = "0x1889AB040")]
		public static void OTSNVORVUSV(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x89AB080", Offset = "0x89AA480", VA = "0x1889AB080")]
		public static void OTSNVORVUSV(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x89AB080", Offset = "0x89AA480", VA = "0x1889AB080")]
		public static void OTSNVORVUSV(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x89AB0F0", Offset = "0x89AA4F0", VA = "0x1889AB0F0")]
		public static void OTSNVORVUSV(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x89AB0F0", Offset = "0x89AA4F0", VA = "0x1889AB0F0")]
		public static void OTSNVORVUSV(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class LUQYATNJAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] DLSQRHEKROT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int RLUMZHWODVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int KBLMHJPEDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int HUPNAREFAZW;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] BEEQTBJBAUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int NRVGIJHTRIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int DECIKYRRGUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x89B4420", Offset = "0x89B3820", VA = "0x1889B4420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool QRXKUPFYYJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A28F50", Offset = "0x2A28350", VA = "0x182A28F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int BFNWEGIJTKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x89B4870", Offset = "0x89B3C70", VA = "0x1889B4870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x89B4640", Offset = "0x89B3A40", VA = "0x1889B4640")]
		public void GUCJYSOKIVR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public LUQYATNJAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x89B4C70", Offset = "0x89B4070", VA = "0x1889B4C70")]
		public LUQYATNJAPE(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x89B47E0", Offset = "0x89B3BE0", VA = "0x1889B47E0")]
		public IPEndPoint KVLNYDZWFNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x89B43E0", Offset = "0x89B37E0", VA = "0x1889B43E0")]
		public byte AGOTOAHCIOM()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x89B43E0", Offset = "0x89B37E0", VA = "0x1889B43E0")]
		public sbyte TIILXMQIDOZ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFAB0", Offset = "0x3BCEEB0", VA = "0x183BCFAB0")]
		public a[] BYGHRXBYCRB<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x89B4730", Offset = "0x89B3B30", VA = "0x1889B4730")]
		public bool[] JJYPHCOSGEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x89B49A0", Offset = "0x89B3DA0", VA = "0x1889B49A0")]
		public ushort[] WGRLQOLBQUW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x89B48C0", Offset = "0x89B3CC0", VA = "0x1889B48C0")]
		public short[] TPMJTMPOLJT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x89B4880", Offset = "0x89B3C80", VA = "0x1889B4880")]
		public int[] RPACAGKZYZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x89B4A20", Offset = "0x89B3E20", VA = "0x1889B4A20")]
		public uint[] YYCGCSOZCUP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x89B4450", Offset = "0x89B3850", VA = "0x1889B4450")]
		public float[] DDGTBRHWNXD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x89B4600", Offset = "0x89B3A00", VA = "0x1889B4600")]
		public double[] FXAEEOIONYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x89B49E0", Offset = "0x89B3DE0", VA = "0x1889B49E0")]
		public long[] WOSCJUQNAGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x89B46C0", Offset = "0x89B3AC0", VA = "0x1889B46C0")]
		public ulong[] IRJRTXYXGAY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x89B4530", Offset = "0x89B3930", VA = "0x1889B4530")]
		public string[] FSFHPTGVKIA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x89B4960", Offset = "0x89B3D60", VA = "0x1889B4960")]
		public bool VQYKIOKGIEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89B44C0", Offset = "0x89B38C0", VA = "0x1889B44C0")]
		public char NMQYYXEJQTQ()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x89B44C0", Offset = "0x89B38C0", VA = "0x1889B44C0")]
		public ushort DXUDQPHPOOJ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x89B44C0", Offset = "0x89B38C0", VA = "0x1889B44C0")]
		public short VMNEZVGHYME()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x89B4490", Offset = "0x89B3890", VA = "0x1889B4490")]
		public long INHLJWPXJPK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x89B4490", Offset = "0x89B3890", VA = "0x1889B4490")]
		public ulong DEDOHGAEUOX()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x89B4900", Offset = "0x89B3D00", VA = "0x1889B4900")]
		public int UDVENIWAVAX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x89B4900", Offset = "0x89B3D00", VA = "0x1889B4900")]
		public uint YCOMYPNMJGO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x89B4700", Offset = "0x89B3B00", VA = "0x1889B4700")]
		public float JGCNNUQWZNK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x89B4930", Offset = "0x89B3D30", VA = "0x1889B4930")]
		public double VCBWHTECNTN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x89B4A60", Offset = "0x89B3E60", VA = "0x1889B4A60")]
		public string ZCKLFKVEXWD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x89B4770", Offset = "0x89B3B70", VA = "0x1889B4770")]
		public ArraySegment<byte> JYQFMSLTHVE(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x89B44F0", Offset = "0x89B38F0", VA = "0x1889B44F0")]
		public sbyte[] EORALOVMNVQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x89B4680", Offset = "0x89B3A80", VA = "0x1889B4680")]
		public byte[] IKMAHXNPEWB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x89B4430", Offset = "0x89B3830", VA = "0x1889B4430")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class HSNKFEDGGUG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] DLSQRHEKROT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int RLUMZHWODVK;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int ORJLNSELRVN = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool LQLHYGYSTWQ;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding ZQAZUKVYMSI;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int EKGBINSOJRL = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] ELAWRUJEPAM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] YVVJIHKGLFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int JEDXTOZKJHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x89AE4C0", Offset = "0x89AD8C0", VA = "0x1889AE4C0")]
		public HSNKFEDGGUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x89AE420", Offset = "0x89AD820", VA = "0x1889AE420")]
		public HSNKFEDGGUG(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x89ADCD0", Offset = "0x89AD0D0", VA = "0x1889ADCD0")]
		public static HSNKFEDGGUG PCAIEYWVEWX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x89ADC30", Offset = "0x89AD030", VA = "0x1889ADC30")]
		public void KBZRLDFKMCB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0CD0", Offset = "0x2AA00D0", VA = "0x182AA0CD0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x89AE060", Offset = "0x89AD460", VA = "0x1889AE060")]
		public void YZNWNPIPDWD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x89AE100", Offset = "0x89AD500", VA = "0x1889AE100")]
		public void YZNWNPIPDWD(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x89AE220", Offset = "0x89AD620", VA = "0x1889AE220")]
		public void YZNWNPIPDWD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x89AE220", Offset = "0x89AD620", VA = "0x1889AE220")]
		public void YZNWNPIPDWD(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x89ADFD0", Offset = "0x89AD3D0", VA = "0x1889ADFD0")]
		public void YZNWNPIPDWD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x89ADFD0", Offset = "0x89AD3D0", VA = "0x1889ADFD0")]
		public void YZNWNPIPDWD(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x89ADD40", Offset = "0x89AD140", VA = "0x1889ADD40")]
		public void YZNWNPIPDWD(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x89ADD40", Offset = "0x89AD140", VA = "0x1889ADD40")]
		public void YZNWNPIPDWD(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x89ADD40", Offset = "0x89AD140", VA = "0x1889ADD40")]
		public void YZNWNPIPDWD(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x89AE270", Offset = "0x89AD670", VA = "0x1889AE270")]
		public void YZNWNPIPDWD(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x89AE270", Offset = "0x89AD670", VA = "0x1889AE270")]
		public void YZNWNPIPDWD(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x89AE2D0", Offset = "0x89AD6D0", VA = "0x1889AE2D0")]
		public void YZNWNPIPDWD(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA80", Offset = "0x89ACE80", VA = "0x1889ADA80")]
		public void HNLMBHQNKHF(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA80", Offset = "0x89ACE80", VA = "0x1889ADA80")]
		public void PBEQDFCWTFI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x89AE340", Offset = "0x89AD740", VA = "0x1889AE340")]
		public void YZNWNPIPDWD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x89AD8C0", Offset = "0x89ACCC0", VA = "0x1889AD8C0")]
		public void FPMSNQAQOUY(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x89AD7E0", Offset = "0x89ACBE0", VA = "0x1889AD7E0")]
		public void FPMSNQAQOUY(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x89AD700", Offset = "0x89ACB00", VA = "0x1889AD700")]
		public void FPMSNQAQOUY(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x89AD700", Offset = "0x89ACB00", VA = "0x1889AD700")]
		public void FPMSNQAQOUY(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x89AD700", Offset = "0x89ACB00", VA = "0x1889AD700")]
		public void FPMSNQAQOUY(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x89AD7E0", Offset = "0x89ACBE0", VA = "0x1889AD7E0")]
		public void FPMSNQAQOUY(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x89AD7E0", Offset = "0x89ACBE0", VA = "0x1889AD7E0")]
		public void FPMSNQAQOUY(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x89AD9A0", Offset = "0x89ACDA0", VA = "0x1889AD9A0")]
		public void FPMSNQAQOUY(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x89AD9A0", Offset = "0x89ACDA0", VA = "0x1889AD9A0")]
		public void FPMSNQAQOUY(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA80", Offset = "0x89ACE80", VA = "0x1889ADA80")]
		public void FPMSNQAQOUY(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x89ADB60", Offset = "0x89ACF60", VA = "0x1889ADB60")]
		public void FPMSNQAQOUY(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x89AE150", Offset = "0x89AD550", VA = "0x1889AE150")]
		public void YZNWNPIPDWD(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x89ADDB0", Offset = "0x89AD1B0", VA = "0x1889ADDB0")]
		public void YZNWNPIPDWD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x89ADDC0", Offset = "0x89AD1C0", VA = "0x1889ADDC0")]
		public void YZNWNPIPDWD(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class POGCMBAQPHV
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class RWHDONEJNYP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong SGYXLDBUDMX;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x76CD4D0", Offset = "0x76CC8D0", VA = "0x1876CD4D0")]
			static RWHDONEJNYP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(LUQYATNJAPE reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class VULLNNBHPBK<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public POGCMBAQPHV IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a ZVNSXGSSVRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> XMCAYDWEFUI;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VULLNNBHPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x7E554E0", Offset = "0x7E548E0", VA = "0x187E554E0")]
			internal void KKAJGCLYKXJ(LUQYATNJAPE a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class HSXMHOTZTKE<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public POGCMBAQPHV IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a ZVNSXGSSVRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> XMCAYDWEFUI;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public HSXMHOTZTKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6454800", Offset = "0x6453C00", VA = "0x186454800")]
			internal void KKAJGCLYKXJ(LUQYATNJAPE a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly LYJTWFFXCXP VKKHBKVCLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> SCNSCTOWPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly HSNKFEDGGUG RMNTAFATOFP;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x89B8060", Offset = "0x89B7460", VA = "0x1889B8060")]
		public POGCMBAQPHV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3D534C0", Offset = "0x3D528C0", VA = "0x183D534C0", Slot = "4")]
		protected virtual ulong SWDGNTTEATI<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x89B7F90", Offset = "0x89B7390", VA = "0x1889B7F90", Slot = "5")]
		protected virtual SubscribeDelegate JIYNEOFRFPD(LUQYATNJAPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3D53540", Offset = "0x3D52940", VA = "0x183D53540", Slot = "6")]
		protected virtual void SWLMGWGWIFL<b>(HSNKFEDGGUG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x89B7F10", Offset = "0x89B7310", VA = "0x1889B7F10")]
		public void EZQTJCQCXYC(LUQYATNJAPE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3D53430", Offset = "0x3D52830", VA = "0x183D53430")]
		public void SISZBYWUTCR<j>(HSNKFEDGGUG a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x89B7EC0", Offset = "0x89B72C0", VA = "0x1889B7EC0")]
		public void EALOKRSWRTE(LUQYATNJAPE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3D53740", Offset = "0x3D52B40", VA = "0x183D53740")]
		public void YRNYDOOGLBF<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3D53740", Offset = "0x3D52B40", VA = "0x183D53740")]
		public void YRNYDOOGLBF<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x89B2790", Offset = "0x89B1B90", VA = "0x1889B2790")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x89B81B0", Offset = "0x89B75B0", VA = "0x1889B81B0")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class LYJTWFFXCXP
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
		private abstract class LINHOWVFUBN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType UXYUOXCBTLU;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x689B8B0", Offset = "0x689ACB0", VA = "0x18689B8B0", Slot = "4")]
			public virtual void ORLMZSMEYLO(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void DWMISJDBTWO(a a, LUQYATNJAPE b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void SISZBYWUTCR(a a, HSNKFEDGGUG b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void QSTCCTBXDQD(a a, LUQYATNJAPE b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void MHQMHLBLONI(a a, HSNKFEDGGUG b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void CMARJVDOIXE(a a, LUQYATNJAPE b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void ZOCLZKLCWCR(a a, HSNKFEDGGUG b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			protected LINHOWVFUBN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class SNCOYDQJMQS<a, b> : LINHOWVFUBN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> XNGFNIRFMJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> JDCNMFZHFGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> PNASKLRCDWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> RKBYNWZMRZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> JGPFNNPNAQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> QCATUGGJQPX;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x792A9B0", Offset = "0x7929DB0", VA = "0x18792A9B0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x792A9B0", Offset = "0x7929DB0", VA = "0x18792A9B0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x792A8E0", Offset = "0x7929CE0", VA = "0x18792A8E0", Slot = "9")]
			public override void CMARJVDOIXE(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x792A8E0", Offset = "0x7929CE0", VA = "0x18792A8E0", Slot = "10")]
			public override void ZOCLZKLCWCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x792B6D0", Offset = "0x792AAD0", VA = "0x18792B6D0")]
			protected b[] XNXINNJLOEL(a a, LUQYATNJAPE b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x792AA80", Offset = "0x7929E80", VA = "0x18792AA80")]
			protected b[] NKRUTKNPCWC(a a, HSNKFEDGGUG b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x792ABF0", Offset = "0x7929FF0", VA = "0x18792ABF0", Slot = "4")]
			public override void ORLMZSMEYLO(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x792B970", Offset = "0x792AD70", VA = "0x18792B970")]
			protected SNCOYDQJMQS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class YDHONURWCQZ<a, b> : SNCOYDQJMQS<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void KWCQBLYAGFM(LUQYATNJAPE a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void NASFRIFOXRT(HSNKFEDGGUG a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x5068CE0", Offset = "0x50680E0", VA = "0x185068CE0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x5069400", Offset = "0x5068800", VA = "0x185069400", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x5069210", Offset = "0x5068610", VA = "0x185069210", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5068F80", Offset = "0x5068380", VA = "0x185068F80", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x5069640", Offset = "0x5068A40", VA = "0x185069640")]
			protected YDHONURWCQZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class ZWDOYZYRFOA<a> : SNCOYDQJMQS<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x508EF00", Offset = "0x508E300", VA = "0x18508EF00", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x508F3F0", Offset = "0x508E7F0", VA = "0x18508F3F0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x508F1A0", Offset = "0x508E5A0", VA = "0x18508F1A0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x508F060", Offset = "0x508E460", VA = "0x18508F060", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public ZWDOYZYRFOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class USLAWRCPRNT<a> : SNCOYDQJMQS<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x508EF00", Offset = "0x508E300", VA = "0x18508EF00", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x508F3F0", Offset = "0x508E7F0", VA = "0x18508F3F0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7D61EF0", Offset = "0x7D612F0", VA = "0x187D61EF0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x508F060", Offset = "0x508E460", VA = "0x18508F060", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public USLAWRCPRNT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class PALMWFEIUJF<a> : SNCOYDQJMQS<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A500", Offset = "0x5B29900", VA = "0x185B2A500", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A8E0", Offset = "0x5B29CE0", VA = "0x185B2A8E0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x744A980", Offset = "0x7449D80", VA = "0x18744A980", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A550", Offset = "0x5B29950", VA = "0x185B2A550", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public PALMWFEIUJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class EVBVMCHHSVA<a> : SNCOYDQJMQS<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A500", Offset = "0x5B29900", VA = "0x185B2A500", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A8E0", Offset = "0x5B29CE0", VA = "0x185B2A8E0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A690", Offset = "0x5B29A90", VA = "0x185B2A690", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A550", Offset = "0x5B29950", VA = "0x185B2A550", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public EVBVMCHHSVA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class YRYFPWFOXWH<a> : SNCOYDQJMQS<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5071560", Offset = "0x5070960", VA = "0x185071560", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5071940", Offset = "0x5070D40", VA = "0x185071940", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x50716F0", Offset = "0x5070AF0", VA = "0x1850716F0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x50716B0", Offset = "0x5070AB0", VA = "0x1850716B0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public YRYFPWFOXWH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class WFIJBPVSOPK<a> : SNCOYDQJMQS<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5071560", Offset = "0x5070960", VA = "0x185071560", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x5071940", Offset = "0x5070D40", VA = "0x185071940", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8519500", Offset = "0x8518900", VA = "0x188519500", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x50716B0", Offset = "0x5070AB0", VA = "0x1850716B0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public WFIJBPVSOPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class CRFNHEQPNSD<a> : SNCOYDQJMQS<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x4F9DDF0", Offset = "0x4F9D1F0", VA = "0x184F9DDF0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E0D0", Offset = "0x4F9D4D0", VA = "0x184F9E0D0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x4F9DF80", Offset = "0x4F9D380", VA = "0x184F9DF80", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x4F9DF40", Offset = "0x4F9D340", VA = "0x184F9DF40", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public CRFNHEQPNSD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class XQLYXJTEBLU<a> : SNCOYDQJMQS<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x4F9DDF0", Offset = "0x4F9D1F0", VA = "0x184F9DDF0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E0D0", Offset = "0x4F9D4D0", VA = "0x184F9E0D0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5032710", Offset = "0x5031B10", VA = "0x185032710", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x4F9DF40", Offset = "0x4F9D340", VA = "0x184F9DF40", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public XQLYXJTEBLU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class ITNVZUMCUXN<a> : SNCOYDQJMQS<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x65651F0", Offset = "0x65645F0", VA = "0x1865651F0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x6565390", Offset = "0x6564790", VA = "0x186565390", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6565240", Offset = "0x6564640", VA = "0x186565240", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x508F060", Offset = "0x508E460", VA = "0x18508F060", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public ITNVZUMCUXN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class RNFTALUSQOY<a> : SNCOYDQJMQS<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x76A7C90", Offset = "0x76A7090", VA = "0x1876A7C90", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x76A7F40", Offset = "0x76A7340", VA = "0x1876A7F40", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x76A7DF0", Offset = "0x76A71F0", VA = "0x1876A7DF0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x50716B0", Offset = "0x5070AB0", VA = "0x1850716B0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public RNFTALUSQOY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class KONPWYFYTZL<a> : SNCOYDQJMQS<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6778A90", Offset = "0x6777E90", VA = "0x186778A90", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6778C30", Offset = "0x6778030", VA = "0x186778C30", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6778BE0", Offset = "0x6777FE0", VA = "0x186778BE0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x4F9DF40", Offset = "0x4F9D340", VA = "0x184F9DF40", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x4F9E230", Offset = "0x4F9D630", VA = "0x184F9E230")]
			public KONPWYFYTZL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class EKBOARPXWPL<a> : YDHONURWCQZ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE3A0", Offset = "0x5ACD7A0", VA = "0x185ACE3A0", Slot = "12")]
			protected override void NASFRIFOXRT(HSNKFEDGGUG a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE370", Offset = "0x5ACD770", VA = "0x185ACE370", Slot = "11")]
			protected override void KWCQBLYAGFM(LUQYATNJAPE a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE3D0", Offset = "0x5ACD7D0", VA = "0x185ACE3D0")]
			public EKBOARPXWPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class VQIWYPDLHGB<a> : YDHONURWCQZ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7E50480", Offset = "0x7E4F880", VA = "0x187E50480", Slot = "12")]
			protected override void NASFRIFOXRT(HSNKFEDGGUG a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7E50440", Offset = "0x7E4F840", VA = "0x187E50440", Slot = "11")]
			protected override void KWCQBLYAGFM(LUQYATNJAPE a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE3D0", Offset = "0x5ACD7D0", VA = "0x185ACE3D0")]
			public VQIWYPDLHGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class XMNHTYDGMVG<a> : SNCOYDQJMQS<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int NREAJHSPXHB;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x50231E0", Offset = "0x50225E0", VA = "0x1850231E0")]
			public XMNHTYDGMVG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5022D20", Offset = "0x5022120", VA = "0x185022D20", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5023140", Offset = "0x5022540", VA = "0x185023140", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5022FE0", Offset = "0x50223E0", VA = "0x185022FE0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5022D80", Offset = "0x5022180", VA = "0x185022D80", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class LGCQNHRJNGW<a> : LINHOWVFUBN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo WIAAFFAKCFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type VJEXQKKNIZJ;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6895210", Offset = "0x6894610", VA = "0x186895210")]
			public LGCQNHRJNGW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6894FA0", Offset = "0x68943A0", VA = "0x186894FA0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6895090", Offset = "0x6894490", VA = "0x186895090", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6895040", Offset = "0x6894440", VA = "0x186895040", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6895040", Offset = "0x6894440", VA = "0x186895040", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6894E30", Offset = "0x6894230", VA = "0x186894E30", Slot = "9")]
			public override void CMARJVDOIXE(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x6894E30", Offset = "0x6894230", VA = "0x186894E30", Slot = "10")]
			public override void ZOCLZKLCWCR(a a, HSNKFEDGGUG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class TSIBOWZXVMT<a> : LGCQNHRJNGW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x7ABB090", Offset = "0x7ABA490", VA = "0x187ABB090")]
			public TSIBOWZXVMT(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x7ABAD50", Offset = "0x7ABA150", VA = "0x187ABAD50", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x7ABB020", Offset = "0x7ABA420", VA = "0x187ABB020", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class BWNWYDAGBHP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static BWNWYDAGBHP<a> LDHSFMFGGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly LINHOWVFUBN<a>[] CTREGFFMPNW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int ZVOLBDYDIWZ;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4E9A880", Offset = "0x4E99C80", VA = "0x184E9A880")]
			public BWNWYDAGBHP(List<LINHOWVFUBN<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4E9A7D0", Offset = "0x4E99BD0", VA = "0x184E9A7D0")]
			public void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4E9A580", Offset = "0x4E99980", VA = "0x184E9A580")]
			public void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class SJBUDIHCLER
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract LINHOWVFUBN<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private HSNKFEDGGUG FVGHAKMPFXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int LCPHQUSLGOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, SJBUDIHCLER> IHUISQDCGYE;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x89B4CD0", Offset = "0x89B40D0", VA = "0x1889B4CD0")]
		public LYJTWFFXCXP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD5020", Offset = "0x3BD4420", VA = "0x183BD5020")]
		private BWNWYDAGBHP<d> UOMWEFCKSPY<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD41C0", Offset = "0x3BD35C0", VA = "0x183BD41C0")]
		public void GZVUEGYMGMP<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4100", Offset = "0x3BD3500", VA = "0x183BD4100")]
		public bool Deserialize<T>(LUQYATNJAPE reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4080", Offset = "0x3BD3480", VA = "0x183BD4080")]
		public void BGVSXQNQAUM<f>(HSNKFEDGGUG a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class ENWPNYEPXMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime QFLGGHCWCXR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] ZTZFZBTKJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator EWRRIOBZXXX
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x89ABC90", Offset = "0x89AB090", VA = "0x1889ABC90")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int RCZQBLCXCMP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x89AB750", Offset = "0x89AAB50", VA = "0x1889AB750")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x89AB780", Offset = "0x89AAB80", VA = "0x1889AB780")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode HBFTZFMHXCV
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x89ABF30", Offset = "0x89AB330", VA = "0x1889ABF30")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x89ABCC0", Offset = "0x89AB0C0", VA = "0x1889ABCC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int WUXJVCEDXVE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x89AB690", Offset = "0x89AAA90", VA = "0x1889AB690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint ALNUSPNPUDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x89ABC30", Offset = "0x89AB030", VA = "0x1889ABC30")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? XTUILXLDAFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x89AB2E0", Offset = "0x89AA6E0", VA = "0x1889AB2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? CMSXRDCOFBD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x89AB6C0", Offset = "0x89AAAC0", VA = "0x1889AB6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? RCXABKLLBFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x89AB870", Offset = "0x89AAC70", VA = "0x1889AB870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x89AB120", Offset = "0x89AA520", VA = "0x1889AB120")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? AYGJAOSQGTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF65B60", Offset = "0xF64F60", VA = "0x180F65B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x89AC220", Offset = "0x89AB620", VA = "0x1889AC220")]
		public ENWPNYEPXMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x89AC180", Offset = "0x89AB580", VA = "0x1889AC180")]
		internal ENWPNYEPXMI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x89ABD00", Offset = "0x89AB100", VA = "0x1889ABD00")]
		public static ENWPNYEPXMI QTHQXQBJXKG(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x89AB310", Offset = "0x89AA710", VA = "0x1889AB310")]
		internal void BBIPSJEEYTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x89AB8A0", Offset = "0x89AACA0", VA = "0x1889AB8A0")]
		private void ILLLCDVFASL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x89ABA60", Offset = "0x89AAE60", VA = "0x1889ABA60")]
		private DateTime? JAENJORIJYZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x89ABF60", Offset = "0x89AB360", VA = "0x1889ABF60")]
		private void ZJUHHREDXQF(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x89AB7C0", Offset = "0x89AABC0", VA = "0x1889AB7C0")]
		private ulong GLMYIZCKALH(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x89ABE10", Offset = "0x89AB210", VA = "0x1889ABE10")]
		private void SQNJJQLNZLX(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x89AB6F0", Offset = "0x89AAAF0", VA = "0x1889AB6F0")]
		private uint CMVAZOSGNRI(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x886E6C0", Offset = "0x886DAC0", VA = "0x18886E6C0")]
		private static uint TXOJZMVFWAV(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x89ABED0", Offset = "0x89AB2D0", VA = "0x1889ABED0")]
		private static ulong TXOJZMVFWAV(ulong a)
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
	internal sealed class DLESYOQMZPL
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int PQDXJJWZGSG = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int TLMPWUGIDZV = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int FJIOEAKLHBW = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint XORUYHFLJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int QRMNFTHYOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int VTIODPIJTGS;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool NEEENYCGLWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x89AAEC0", Offset = "0x89AA2C0", VA = "0x1889AAEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x89AAED0", Offset = "0x89AA2D0", VA = "0x1889AAED0")]
		public bool RXBHTTODHVW(WKKNWIOZJWM a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class KEVYSQWDZZP : WKKNWIOZJWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket PFXVGPGHMBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly CCTOFGXGRWY QXACBPNSEXS;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short KBPLVEBKAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x89B2EB0", Offset = "0x89B22B0", VA = "0x1889B2EB0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int IOQVICFDKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x89B2ED0", Offset = "0x89B22D0", VA = "0x1889B2ED0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint OGFTDRHEWHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x89B2EF0", Offset = "0x89B22F0", VA = "0x1889B2EF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily LDMKYLUBREW
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32B3E30", Offset = "0x32B3230", VA = "0x1832B3E30", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x89B2F10", Offset = "0x89B2310", VA = "0x1889B2F10")]
		public KEVYSQWDZZP(AddressFamily a, CCTOFGXGRWY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x89B27A0", Offset = "0x89B1BA0", VA = "0x1889B27A0", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x89B2D80", Offset = "0x89B2180", VA = "0x1889B2D80", Slot = "9")]
		public int DKMHJAIDLZX(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x89B2DC0", Offset = "0x89B21C0", VA = "0x1889B2DC0", Slot = "10")]
		public int EAXIICUCCUD(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x89B2D60", Offset = "0x89B2160", VA = "0x1889B2D60", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface WKKNWIOZJWM
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short KBPLVEBKAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int IOQVICFDKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint OGFTDRHEWHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily LDMKYLUBREW
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
		int DKMHJAIDLZX(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int EAXIICUCCUD(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x89B6B30", Offset = "0x89B5F30", VA = "0x1889B6B30")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x89B6BD0", Offset = "0x89B5FD0", VA = "0x1889B6BD0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1631700", Offset = "0x1630B00", VA = "0x181631700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x89B6A40", Offset = "0x89B5E40", VA = "0x1889B6A40", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x89B6A80", Offset = "0x89B5E80", VA = "0x1889B6A80", Slot = "0")]
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
	public class XBVVASIKIDT
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string XEXJSDXAYDH = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int CANTKQTIJYH = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int SAHKUEUZUCN = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int MASUYCIUIIJ = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> WZDZVSKUSNO;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback XBHHZKIPVEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int BUJCPTSEDRJ;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		internal void ZTICFUODRDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		internal void UVPVXLQVMNZ(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class JZGSZEAVDXU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int YFVUIQHRRGV;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
		protected JZGSZEAVDXU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void WPFTLQKXJHW(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void QCMCLJSPTFZ(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class KZLVRDLDNMC : JZGSZEAVDXU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] WBDMRGPRNOV;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator ALKCAXELTXZ;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BA37B0", Offset = "0x2BA2BB0", VA = "0x182BA37B0")]
		public KZLVRDLDNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x89B3DA0", Offset = "0x89B31A0", VA = "0x1889B3DA0")]
		public void SQVJVFJCUWA(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x89B39C0", Offset = "0x89B2DC0", VA = "0x1889B39C0")]
		public void CDDLZPLTDGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x89B3F50", Offset = "0x89B3350", VA = "0x1889B3F50", Slot = "4")]
		public override void WPFTLQKXJHW(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x89B3AA0", Offset = "0x89B2EA0", VA = "0x1889B3AA0", Slot = "5")]
		public override void QCMCLJSPTFZ(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class JHKKUYOAWCV
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr LZCUBCGCEZV;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x89B98C0", Offset = "0x89B8CC0", VA = "0x1889B98C0")]
			[BurstDiscard]
			private static void DLIEWRUGLGL(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x89B9C90", Offset = "0x89B9090", VA = "0x1889B9C90")]
			private static IntPtr JTCUYQYXPHF()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x89B9A50", Offset = "0x89B8E50", VA = "0x1889B9A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x89B9070", Offset = "0x89B8470", VA = "0x1889B9070")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x89B8B60", Offset = "0x89B7F60", VA = "0x1889B8B60")]
		private uint BNVQMUBANCY(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x89A2090", Offset = "0x89A1490", VA = "0x1889A2090")]
		private void EZIJFBTZETB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x89A2240", Offset = "0x89A1640", VA = "0x1889A2240")]
		private void UEDIGOTUHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x89A2000", Offset = "0x89A1400", VA = "0x1889A2000")]
		private void BHATTAKBCOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x89A2140", Offset = "0x89A1540", VA = "0x1889A2140")]
		private void NBKPYBYXROG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x89B91A0", Offset = "0x89B85A0", VA = "0x1889B91A0")]
		private void YDKBKJOJGHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x89B8C50", Offset = "0x89B8050", VA = "0x1889B8C50")]
		private unsafe void KTPBJKYQYNE(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x89B8B90", Offset = "0x89B7F90", VA = "0x1889B8B90")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void EHINQLBBEXB([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x89B8BA0", Offset = "0x89B7FA0", VA = "0x1889B8BA0")]
		public static void EHINQLBBEXB(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x89B90F0", Offset = "0x89B84F0", VA = "0x1889B90F0")]
		public static void WGMXAXLYZDR(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x89B9200", Offset = "0x89B8600", VA = "0x1889B9200")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void ZPOZWYFBWEO([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x89B9E10", Offset = "0x89B9210", VA = "0x1889B9E10")]
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
