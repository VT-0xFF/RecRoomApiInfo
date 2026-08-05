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
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, IEAPOLOPDNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KIODPOIFGNE
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			Client
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Tooltip("The port to listen on (if server) or connect to (if client)")]
		public ushort Port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("The address to connect to as client; ignored if server")]
		public string Address;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Tooltip("Interval between ping packets used for detecting latency and checking connection, in seconds")]
		public float PingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Tooltip("Maximum duration for a connection to survive without receiving packets, in seconds")]
		public float DisconnectTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Delay between connection attempts, in seconds")]
		public float ReconnectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Tooltip("Maximum connection attempts before client stops and reports a disconnection")]
		public int MaxConnectAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Tooltip("Size of default buffer for decoding incoming packets, in bytes")]
		public int MessageBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Tooltip("Simulated chance for a packet to be \"lost\", from 0 (no simulation) to 100 percent")]
		public int SimulatePacketLossChance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Tooltip("Simulated minimum additional latency for packets in milliseconds (0 for no simulation)")]
		public int SimulateMinLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Tooltip("Simulated maximum additional latency for packets in milliseconds (0 for no simulation")]
		public int SimulateMaxLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NetworkManager MCKNAHHFKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, DCAJPFGHPOC> AGOIONOLLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GIAAAHOFKBG PGPCFEONHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] CCEKHMAJNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KIODPOIFGNE IMCFKEGABFL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong FKHOKHKDPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GELHGAMLHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5654700", Offset = "0x5653B00", VA = "0x185654700", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5653C00", Offset = "0x5653000", VA = "0x185653C00")]
		public void RecRoom_SetEncryptionInfo(ulong AIKCEDDPPEI, byte[] NIOPCMHKLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5653BE0", Offset = "0x5652FE0", VA = "0x185653BE0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5653AB0", Offset = "0x5652EB0", VA = "0x185653AB0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5654600", Offset = "0x5653A00", VA = "0x185654600")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5653E00", Offset = "0x5653200", VA = "0x185653E00", Slot = "6")]
		public override void Send(ulong PIHLICCHEOF, ArraySegment<byte> FLKOGFDGJDF, NetworkDelivery MFPPKLECDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5653BA0", Offset = "0x5652FA0", VA = "0x185653BA0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong PIHLICCHEOF, [Out] ArraySegment<byte> KJOCNIDJGCN, [Out] float BBGDIBDPIEL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x56540F0", Offset = "0x56534F0", VA = "0x1856540F0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5654520", Offset = "0x5653920", VA = "0x185654520", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x56530C0", Offset = "0x56524C0", VA = "0x1856530C0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong PIHLICCHEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5652F70", Offset = "0x5652370", VA = "0x185652F70", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5653370", Offset = "0x5652770", VA = "0x185653370", Slot = "12")]
		public override ulong GetCurrentRtt(ulong PIHLICCHEOF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5654080", Offset = "0x5653480", VA = "0x185654080", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5653700", Offset = "0x5652B00", VA = "0x185653700", Slot = "14")]
		public override void Initialize([Optional] NetworkManager MCKNAHHFKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5653920", Offset = "0x5652D20", VA = "0x185653920")]
		private LJHBGDLHINL KANOLAPIGPK(NetworkDelivery NBMJAHOKHAI)
		{
			return default(LJHBGDLHINL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x56539F0", Offset = "0x5652DF0", VA = "0x1856539F0", Slot = "15")]
		private void OOEKNNELMCP(DCAJPFGHPOC JBOMFEIJMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5653230", Offset = "0x5652630", VA = "0x185653230", Slot = "16")]
		private void GPIGNHILJBA(DCAJPFGHPOC JBOMFEIJMDD, HNPOLGOOCHL AJPABCCJLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "17")]
		private void HBEAHPJLOAK(IPEndPoint AFCIGMCAOAB, SocketError ELEDJBJHEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x56534F0", Offset = "0x56528F0", VA = "0x1856534F0", Slot = "18")]
		private void HFGHGJNGLKK(DCAJPFGHPOC JBOMFEIJMDD, PGHPNHDNGMG JIKGIJPCJAL, byte MNPFNILDNBP, LJHBGDLHINL DDEPHFLNBBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5653410", Offset = "0x5652810", VA = "0x185653410")]
		private void HEDOCFGHPGD(int HIAJHKACHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "19")]
		private void MJJLKKCAAPP(IPEndPoint JIGIGHHIDNG, PGHPNHDNGMG JIKGIJPCJAL, LBLIDEBAMIF PKAMJGOJLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "20")]
		private void MGGOBPBKLPG(DCAJPFGHPOC JBOMFEIJMDD, int PJNCLAKELMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56538C0", Offset = "0x5652CC0", VA = "0x1856538C0", Slot = "21")]
		private void JCDKAIJNFMP(BNDHBAELKNH BDAAOBFBLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5652F20", Offset = "0x5652320", VA = "0x185652F20")]
		private ulong DILAEKKMMPM(DCAJPFGHPOC JBOMFEIJMDD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5652F50", Offset = "0x5652350", VA = "0x185652F50")]
		private static int DMHIBGCCCOO(float ABEDOEMHLPN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5654620", Offset = "0x5653A20", VA = "0x185654620")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class GAFMBPMDOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly DCAJPFGHPOC LNDJLAGBGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<NPCMMBJHICN> FJJBOGEGMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int PCFNPGDGHKP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5647C40", Offset = "0x5647040", VA = "0x185647C40")]
	protected GAFMBPMDOOI(DCAJPFGHPOC JBOMFEIJMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5647BE0", Offset = "0x5646FE0", VA = "0x185647BE0")]
	public void MOEODCAPKIK(NPCMMBJHICN NNECHFOMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5647B20", Offset = "0x5646F20", VA = "0x185647B20")]
	protected void FLMNKDINEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5647BA0", Offset = "0x5646FA0", VA = "0x185647BA0")]
	public bool KHGIACFBEBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool HKBBCMOIINP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool DEJABFNMLPB(NPCMMBJHICN NNECHFOMFEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum BANMFFBPGKN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BNDHBAELKNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GIAAAHOFKBG IEIMELPOHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int GINJOJGFLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GCDHIOBBOOK KMMJOOMCDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint NALEGIHKOJK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BANMFFBPGKN GJKHNPEPLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E60B0", Offset = "0x7E54B0", VA = "0x1807E60B0")]
		[CompilerGenerated]
		get
		{
			return default(BANMFFBPGKN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x968FF0", Offset = "0x9683F0", VA = "0x180968FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5642130", Offset = "0x5641530", VA = "0x185642130")]
	internal void OPLDPLJJBGD(GCDHIOBBOOK GDEKFLLEAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56420A0", Offset = "0x56414A0", VA = "0x1856420A0")]
	private bool APIJJGKLGDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5642190", Offset = "0x5641590", VA = "0x185642190")]
	internal BNDHBAELKNH(IPEndPoint JIGIGHHIDNG, GCDHIOBBOOK CFABOEMJGHD, GIAAAHOFKBG NKHKCPNHGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56420D0", Offset = "0x56414D0", VA = "0x1856420D0")]
	public DCAJPFGHPOC HHBCCHFBHAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LBLIDEBAMIF
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JDMGDCBBODL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HNPOLGOOCHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JDMGDCBBODL DBOOKGIIFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError IDKECEINBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public PGHPNHDNGMG APPGFLMAIHF;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IEAPOLOPDNN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEPPDKPGNPN(DCAJPFGHPOC JBOMFEIJMDD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKKJFNELGDO(DCAJPFGHPOC JBOMFEIJMDD, HNPOLGOOCHL AJPABCCJLCK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNMGJDEKKAJ(IPEndPoint AFCIGMCAOAB, SocketError ELEDJBJHEBN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBODFJCALEO(DCAJPFGHPOC JBOMFEIJMDD, PGHPNHDNGMG JIKGIJPCJAL, byte MNPFNILDNBP, LJHBGDLHINL DDEPHFLNBBI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGOBKKBOPMO(IPEndPoint JIGIGHHIDNG, PGHPNHDNGMG JIKGIJPCJAL, LBLIDEBAMIF PKAMJGOJLIN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCLIGGDLCAI(DCAJPFGHPOC JBOMFEIJMDD, int PJNCLAKELMM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPFDLJMBCIA(BNDHBAELKNH BDAAOBFBLIB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MPLLEMAIEEM
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGEBJFNKHBJ(DCAJPFGHPOC JBOMFEIJMDD, object JAPIGMAKNLK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IHBFGLLHKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFIIOKBOJLE(GAKEDMOBFNI NNECHFOMFEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EJKMKBFKFKP
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAPKPLAAKKC(DCAJPFGHPOC JBOMFEIJMDD, IPEndPoint OBJBOKNEFNL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GCDHIOBBOOK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int COKFNLAKEGI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long AIABAFFMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte KAELDJBDPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] EIJKHIIFKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly ADMFICABCPD CIKHIKEBPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int MGAFJHPIAAF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x56494D0", Offset = "0x56488D0", VA = "0x1856494D0")]
	private GCDHIOBBOOK(long OJLOGEHMBHA, byte HIFNLKDECHJ, int KIPEPOENGME, byte[] DJBNEJOCBDA, ADMFICABCPD FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5649470", Offset = "0x5648870", VA = "0x185649470")]
	public static int GNIDFMENHDH(NPCMMBJHICN NNECHFOMFEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5649250", Offset = "0x5648650", VA = "0x185649250")]
	public static GCDHIOBBOOK EOFDMMJDKJJ(NPCMMBJHICN NNECHFOMFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5649070", Offset = "0x5648470", VA = "0x185649070")]
	public static NPCMMBJHICN CDMJOGHOPNN(NBADJKOBJGH NIIMEDIODCJ, SocketAddress MJLACPJGFAC, long OMKOLINOPMB, int KIPEPOENGME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PLCCPEJAMPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long AIABAFFMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte KAELDJBDPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int MGAFJHPIAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool INLCMHCLPLN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5656A10", Offset = "0x5655E10", VA = "0x185656A10")]
	private PLCCPEJAMPL(long OJLOGEHMBHA, byte HIFNLKDECHJ, int HJKAPLLJKJC, bool LFAPMCODFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x56568C0", Offset = "0x5655CC0", VA = "0x1856568C0")]
	public static PLCCPEJAMPL EOFDMMJDKJJ(NPCMMBJHICN NNECHFOMFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x56567D0", Offset = "0x5655BD0", VA = "0x1856567D0")]
	public static NPCMMBJHICN CDMJOGHOPNN(long OMKOLINOPMB, byte MGCEHEFLCLK, int HOGMDEJLJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x56566D0", Offset = "0x5655AD0", VA = "0x1856566D0")]
	public static NPCMMBJHICN ADFIEDMPDDN(DCAJPFGHPOC JBOMFEIJMDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum BIEBMJCECFH
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EIKLMNLBACP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKCEPOGDGIP(IPEndPoint CNKNCLIFLAB, IPEndPoint JIGIGHHIDNG, string ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHNEBKONLPP(IPEndPoint IJLFLGKBBPB, BIEBMJCECFH NBMJAHOKHAI, string ICNJFMMNIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JDMCFDMIHMG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MMCCKLJMJEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint GHNOJJKPMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint NALEGIHKOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string IEBLPLMIONB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct MDNMKIELFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint APHNEMEEIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BIEBMJCECFH HCHJICPCOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string IEBLPLMIONB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class MPNKGPJHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint MKPKNEFPMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IEBLPLMIONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MPNKGPJHMDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class GPMMDJFHBMC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint MKPKNEFPMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint FECEIGOJLGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string IEBLPLMIONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GPMMDJFHBMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class MMPAIOEBPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IEBLPLMIONB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PEKKIPGIKHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7CBD20", Offset = "0x7CB120", VA = "0x1807CBD20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MMPAIOEBPCJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GIAAAHOFKBG CNBAODPILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<MMCCKLJMJEH> HAJKOEMFECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<MDNMKIELFBI> KEEEOADMNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ADMFICABCPD ELMOJDNOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly NBADJKOBJGH MHNKJCELHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly BEMJIOPIMCB COBPDJIOJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EIKLMNLBACP AOHPGFMFBAO;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int DGNCIJFLBFL = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool KLDPNEKFLKD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5651140", Offset = "0x5650540", VA = "0x185651140")]
	internal JDMCFDMIHMG(GIAAAHOFKBG AOAIHFEICOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5650CF0", Offset = "0x56500F0", VA = "0x185650CF0")]
	internal void GANAKEGGNBN(IPEndPoint IKJEPAIAHLL, NPCMMBJHICN NNECHFOMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2841630", Offset = "0x2840A30", VA = "0x182841630")]
	private void DIDDGAMGKCD<T>(T NNECHFOMFEJ, IPEndPoint NDIKGOAJKGJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5650FB0", Offset = "0x56503B0", VA = "0x185650FB0")]
	private void KKCEPOGDGIP(MPNKGPJHMDD ADCJMDNGCKH, IPEndPoint IKJEPAIAHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5650E50", Offset = "0x5650250", VA = "0x185650E50")]
	private void GCPAMJHBOED(GPMMDJFHBMC ADCJMDNGCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5650B50", Offset = "0x564FF50", VA = "0x185650B50")]
	private void DBDKFNCIHKI(MMPAIOEBPCJ ADCJMDNGCKH, IPEndPoint IKJEPAIAHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum LJHBGDLHINL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CNLPALKBFIL : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FPELODNCGPA
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] NPGMBMMLEJB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int ODODONOKGCD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int CHINFDGOODE;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DMIGEDCLEBA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5646790", Offset = "0x5645B90", VA = "0x185646790")]
	public DMIGEDCLEBA(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EIMMPDOBIEE : DMIGEDCLEBA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5646790", Offset = "0x5645B90", VA = "0x185646790")]
	public EIMMPDOBIEE(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FFHPDAGOGLG
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CDNIPNOJGML
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPDOKDIINMH(FFHPDAGOGLG MOGIOJIPFMD, string PPPBBGPLHME, params object[] EGGAPMGLGIF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DEJDMJAKGJB
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static CDNIPNOJGML CKBHHMAOICL;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object EFHCDDALFIO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5646450", Offset = "0x5645850", VA = "0x185646450")]
	private static void KFFNFADHNIB(FFHPDAGOGLG NPIKIMGGGEA, string PPPBBGPLHME, params object[] EGGAPMGLGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5646390", Offset = "0x5645790", VA = "0x185646390")]
	internal static void BPHGHFMIBGI(string PPPBBGPLHME, params object[] EGGAPMGLGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56463F0", Offset = "0x56457F0", VA = "0x1856463F0")]
	internal static void HGNOOAALEDP(string PPPBBGPLHME, params object[] EGGAPMGLGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5646680", Offset = "0x5645A80", VA = "0x185646680")]
	internal static void PKIMMCHLNDO(string PPPBBGPLHME, params object[] EGGAPMGLGIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum FPNANPACGHN
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PGHPNHDNGMG : ADMFICABCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NPCMMBJHICN JEMEMIJCJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GIAAAHOFKBG GGGOFIGBIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CDKILMIEOHA NKMAALAJOEL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5656680", Offset = "0x5655A80", VA = "0x185656680")]
	internal PGHPNHDNGMG(GIAAAHOFKBG BJMBJJIMGHO, CDKILMIEOHA PLMGHLKAGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5656610", Offset = "0x5655A10", VA = "0x185656610")]
	internal void IEFEOPCLKCG(NPCMMBJHICN NNECHFOMFEJ, int INJGCNKCCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5656560", Offset = "0x5655960", VA = "0x185656560")]
	internal void CJJACAPLJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x56565E0", Offset = "0x56559E0", VA = "0x1856565E0")]
	public void DDDLNFHJLAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CDKILMIEOHA
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GDGCGKJMLFK
	{
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public CDKILMIEOHA KPEIOJKKKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GDGCGKJMLFK HCHJICPCOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public DCAJPFGHPOC LNDJLAGBGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint NALEGIHKOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object MFOGKCGALOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int DKCGPJIFKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError NHCGBADOIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public JDMGDCBBODL HMHOLOOBINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public BNDHBAELKNH HGAFPBLBEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public LJHBGDLHINL PEFLLIHNKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte OFEDEGAMIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly PGHPNHDNGMG IHHLFFNEHOB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5642200", Offset = "0x5641600", VA = "0x185642200")]
	public CDKILMIEOHA(GIAAAHOFKBG BJMBJJIMGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GIAAAHOFKBG : IEnumerable<DCAJPFGHPOC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class HOLPFMAMMOJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5650AE0", Offset = "0x564FEE0", VA = "0x185650AE0", Slot = "4")]
		public bool Equals(IPEndPoint LCKGOLLEJPE, IPEndPoint OHIBEIOBHMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5106C80", Offset = "0x5106080", VA = "0x185106C80", Slot = "5")]
		public int GetHashCode(IPEndPoint LIKEKIACGIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HOLPFMAMMOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct CLCPMHPFNOI : IEnumerator<DCAJPFGHPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly DCAJPFGHPOC EHDPFHIJAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DCAJPFGHPOC JIMAOHBDBCG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DCAJPFGHPOC MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x90B110", Offset = "0x90A510", VA = "0x18090B110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x90B110", Offset = "0x90A510", VA = "0x18090B110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF6C740", Offset = "0xF6BB40", VA = "0x180F6C740")]
		public CLCPMHPFNOI(DCAJPFGHPOC FBPAJEFFKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x56422A0", Offset = "0x56416A0", VA = "0x1856422A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x56422F0", Offset = "0x56416F0", VA = "0x1856422F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread FPEECFAPFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool HMOIENFHCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent OAEJECJGHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<CDKILMIEOHA> CCDKCDNGFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<CDKILMIEOHA> FLDFOIKMAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CDKILMIEOHA BJCAFGGHEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IEAPOLOPDNN FHJJLMPMKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MPLLEMAIEEM JLPIEDBJPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly IHBFGLLHKDE JILDAJNOFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EJKMKBFKFKP MDEMKPLLCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, DCAJPFGHPOC> FEDJCKJMHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, BNDHBAELKNH> AKNJNDPAFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, LLCLEJJLFGB> FAGOFJPALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim ELGPPBHCHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private DCAJPFGHPOC IMILAPAPKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int FLHAIGEOLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<DCAJPFGHPOC> GBOHAOEHJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private DCAJPFGHPOC[] PDBDJBJFGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FOHFMMFAGMJ OBCALJCFJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int IMANFPOIDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> EAEHKLPHGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte BOAKPIBKMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object AEMMOHBBKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool AIIDIOCLNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool FFBNLNKOPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BCPKNLKBGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int KKIPNACLJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int IPEHLOCEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int GJHIFECIJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool CFPBLBKKFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MJPNFHNKEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int FKGIEOMDOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NDLLMBHMOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MIALMJFAMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool KLDPNEKFLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool DNOIPHPPMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool OHIOOFELJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool FKOGHMAIDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int JOOLAGNIHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int NLEPBADCFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool JPCBNNHNPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly HOKFLJJNCIG CHKOKBDLCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool KOAFFGINCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly JDMCFDMIHMG LANOAJDNFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool BADMELLOLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public FPNANPACGHN BAABOGJHABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int IGEEMDPCAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool FFBHGNJCNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool OEACGIDPGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool NNOONCHJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool JBHMGDGAFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NPCMMBJHICN MLALOMNIHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int JMFLJNMFEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object BLIOIOKNMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NPCMMBJHICN NEADBCMAKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int GGPFDNJEDOM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int ILPMHOEDPCA = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int JGBDHFOGFJG = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BHPDBGLFEEA BPKFNFKJDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private BHPDBGLFEEA MCFHNHHPPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread PNMAKOIADAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread FHKKJGHJOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint CLAIOHBEDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint BIHKEIJFKJC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] DBABKMLJCCO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] MIDINGLBOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<JLOAFKEKJCA, IPEndPoint> MBHFNNCMBIK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress BBCKPABBEAH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool MOEECFCDDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int AEBHLODOBNI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CEKHKOOPPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA699D0", Offset = "0xA68DD0", VA = "0x180A699D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB2D170", Offset = "0xB2C570", VA = "0x180B2D170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GIKDMCBNJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1311D70", Offset = "0x1311170", VA = "0x181311D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x16264F0", Offset = "0x16258F0", VA = "0x1816264F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte PNJCICDKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBA0", Offset = "0x8CDFA0", VA = "0x1808CEBA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KOJBKLKFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x564CAE0", Offset = "0x564BEE0", VA = "0x18564CAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short OEJIIOMIEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x564E970", Offset = "0x564DD70", VA = "0x18564E970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x564BA00", Offset = "0x564AE00", VA = "0x18564BA00")]
	public void FNJLIMMIOHD(IPEndPoint AFCIGMCAOAB, byte[] NIOPCMHKLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x564BBA0", Offset = "0x564AFA0", VA = "0x18564BBA0")]
	public void GIONKOMLPDP(IPEndPoint AFCIGMCAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x564AEE0", Offset = "0x564A2E0", VA = "0x18564AEE0")]
	private bool EMCLBDCIJCI(IPEndPoint AFCIGMCAOAB, [Out] DCAJPFGHPOC JBOMFEIJMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x564C1C0", Offset = "0x564B5C0", VA = "0x18564C1C0")]
	private void HGNEANLJDOJ(DCAJPFGHPOC JBOMFEIJMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x564AE90", Offset = "0x564A290", VA = "0x18564AE90")]
	private void EADKNBBLKPN(DCAJPFGHPOC JBOMFEIJMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x564BCF0", Offset = "0x564B0F0", VA = "0x18564BCF0")]
	private void GLGLMEALMLE(DCAJPFGHPOC JBOMFEIJMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x564FEC0", Offset = "0x564F2C0", VA = "0x18564FEC0")]
	public GIAAAHOFKBG(IEAPOLOPDNN NKHKCPNHGEE, [Optional] FOHFMMFAGMJ GFADBJPOCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x564C170", Offset = "0x564B570", VA = "0x18564C170")]
	internal void HDOLHKICPOA(DCAJPFGHPOC AHEAFHONKJF, int PJNCLAKELMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x564D4C0", Offset = "0x564C8C0", VA = "0x18564D4C0")]
	internal void JONBKHEFLMF(DCAJPFGHPOC AHEAFHONKJF, object JAPIGMAKNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x564E440", Offset = "0x564D840", VA = "0x18564E440")]
	internal void NDAMJKKJJEM(DCAJPFGHPOC JBOMFEIJMDD, JDMGDCBBODL HOKIEGJILGD, SocketError HGBCBPCFLLC, NPCMMBJHICN LMBNCDMECGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x564B7E0", Offset = "0x564ABE0", VA = "0x18564B7E0")]
	private void FDPMFPGNMIJ(DCAJPFGHPOC JBOMFEIJMDD, JDMGDCBBODL HOKIEGJILGD, SocketError HGBCBPCFLLC, bool DOPMCGBECME, byte[] FLKOGFDGJDF, int IEPLFGFMPDD, int JDBLGKLFJDF, NPCMMBJHICN LMBNCDMECGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x564D100", Offset = "0x564C500", VA = "0x18564D100")]
	private void JACBGPLPBMG(CDKILMIEOHA.GDGCGKJMLFK NBMJAHOKHAI, [Optional] DCAJPFGHPOC JBOMFEIJMDD, [Optional] IPEndPoint JIGIGHHIDNG, SocketError MNEGDIGLFLH = SocketError.Success, int PJNCLAKELMM = 0, JDMGDCBBODL KBFLNHCHGJK = JDMGDCBBODL.ConnectionFailed, [Optional] BNDHBAELKNH CEBDIEKKMDC, LJHBGDLHINL DDEPHFLNBBI = LJHBGDLHINL.Unreliable, byte MNPFNILDNBP = 0, [Optional] NPCMMBJHICN MEBEKFCAPLC, [Optional] object JAPIGMAKNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x564AF70", Offset = "0x564A370", VA = "0x18564AF70")]
	private void FBHNPALFGOL(CDKILMIEOHA PLMGHLKAGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x564BAA0", Offset = "0x564AEA0", VA = "0x18564BAA0")]
	internal void FOCMAHEAOIB(CDKILMIEOHA PLMGHLKAGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x564F9A0", Offset = "0x564EDA0", VA = "0x18564F9A0")]
	private void PGAAHABLIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5649E20", Offset = "0x5649220", VA = "0x185649E20")]
	private void CPPMILJPPEB(int LMEDKFJOIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x564EA30", Offset = "0x564DE30", VA = "0x18564EA30")]
	internal DCAJPFGHPOC NKONMOFKFGO(BNDHBAELKNH BDAAOBFBLIB, byte[] EKGLPMAOOIA, int IEPLFGFMPDD, int POJMEHKIPEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x564B980", Offset = "0x564AD80", VA = "0x18564B980")]
	private int FENPMIIKEDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x564E510", Offset = "0x564D910", VA = "0x18564E510")]
	private void NGDGMBOBNEB(IPEndPoint JIGIGHHIDNG, DCAJPFGHPOC LAKPPBCPLMK, GCDHIOBBOOK INBLAJOEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x564A140", Offset = "0x5649540", VA = "0x18564A140")]
	private void DCDPDOOOIHA(NPCMMBJHICN NNECHFOMFEJ, IPEndPoint JIGIGHHIDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x564DDB0", Offset = "0x564D1B0", VA = "0x18564DDB0")]
	internal void MGKBAJIHCAO(NPCMMBJHICN NNECHFOMFEJ, LJHBGDLHINL PEHEMBLLCEM, byte MNPFNILDNBP, int INJGCNKCCKG, DCAJPFGHPOC AHEAFHONKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x564F1D0", Offset = "0x564E5D0", VA = "0x18564F1D0")]
	public bool OEBPOHMGJLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x564F1B0", Offset = "0x564E5B0", VA = "0x18564F1B0")]
	public bool OEBPOHMGJLL(IPAddress JCKJKIFPCNK, IPAddress FCCIGCMPDNA, int EOAJDOPMJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x564F130", Offset = "0x564E530", VA = "0x18564F130")]
	public bool OEBPOHMGJLL(int EOAJDOPMJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x564E2A0", Offset = "0x564D6A0", VA = "0x18564E2A0")]
	public void MMKMBHHNOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x564D5F0", Offset = "0x564C9F0", VA = "0x18564D5F0")]
	public DCAJPFGHPOC KECENKKDBCD(string HNJLDECIPHF, int EOAJDOPMJNG, string NIOPCMHKLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x564D510", Offset = "0x564C910", VA = "0x18564D510")]
	public DCAJPFGHPOC KECENKKDBCD(string HNJLDECIPHF, int EOAJDOPMJNG, NBADJKOBJGH ANLDOHODEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x564D6D0", Offset = "0x564CAD0", VA = "0x18564D6D0")]
	public DCAJPFGHPOC KECENKKDBCD(IPEndPoint NDIKGOAJKGJ, NBADJKOBJGH ANLDOHODEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5649890", Offset = "0x5648C90", VA = "0x185649890")]
	public void AOGMNIMOPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5649540", Offset = "0x5648940", VA = "0x185649540")]
	public void AOGMNIMOPIB(bool LLCPHKHEGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x564BF50", Offset = "0x564B350", VA = "0x18564BF50")]
	public void HCPBFEMBKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x564C050", Offset = "0x564B450", VA = "0x18564C050")]
	public void HCPBFEMBKBM(byte[] FLKOGFDGJDF, int IEPLFGFMPDD, int JDBLGKLFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x564B730", Offset = "0x564AB30", VA = "0x18564B730")]
	public void FDPMFPGNMIJ(DCAJPFGHPOC JBOMFEIJMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x564B8C0", Offset = "0x564ACC0", VA = "0x18564B8C0")]
	public void FDPMFPGNMIJ(DCAJPFGHPOC JBOMFEIJMDD, byte[] FLKOGFDGJDF, int IEPLFGFMPDD, int JDBLGKLFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x564FCE0", Offset = "0x564F0E0", VA = "0x18564FCE0", Slot = "4")]
	private IEnumerator<DCAJPFGHPOC> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x564FD70", Offset = "0x564F170", VA = "0x18564FD70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x56498A0", Offset = "0x5648CA0", VA = "0x1856498A0")]
	private NPCMMBJHICN BKBIFHJAAIL(KAIGKLPNPJB KENAPEDMLDN, int HIAJHKACHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5649990", Offset = "0x5648D90", VA = "0x185649990")]
	private NPCMMBJHICN BKBIFHJAAIL(KAIGKLPNPJB KENAPEDMLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x564E070", Offset = "0x564D470", VA = "0x18564E070")]
	internal NPCMMBJHICN MMECFIIGBMB(int HIAJHKACHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5649A70", Offset = "0x5648E70", VA = "0x185649A70")]
	internal void CIJODCAMGJG(NPCMMBJHICN NNECHFOMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x564FE00", Offset = "0x564F200", VA = "0x18564FE00")]
	static GIAAAHOFKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA699D0", Offset = "0xA68DD0", VA = "0x180A699D0")]
	private bool GFOFEGAGLDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5649D30", Offset = "0x5649130", VA = "0x185649D30")]
	private void CPJHKOGLBEC(IPEndPoint LHMBFOAJEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x564F050", Offset = "0x564E450", VA = "0x18564F050")]
	private void NOKJNOEDHLC(IPEndPoint LHMBFOAJEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x564DC10", Offset = "0x564D010", VA = "0x18564DC10")]
	private bool MCFIMCHLMJK(SocketException DAAIKNOAPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x564C810", Offset = "0x564BC10", VA = "0x18564C810")]
	private void HLPLFPBJPAH(BHPDBGLFEEA AOAIHFEICOB, EndPoint AFCPMGOJEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x564C480", Offset = "0x564B880", VA = "0x18564C480")]
	private void HKKJAOKDOGF(object KDDFGNJPJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x564F1E0", Offset = "0x564E5E0", VA = "0x18564F1E0")]
	public bool OEBPOHMGJLL(IPAddress JCKJKIFPCNK, IPAddress FCCIGCMPDNA, int EOAJDOPMJNG, bool FBPGIGPNDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5649CD0", Offset = "0x56490D0", VA = "0x185649CD0")]
	internal int CMHBGFFMAJP(NPCMMBJHICN NNECHFOMFEJ, IPEndPoint JIGIGHHIDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x564CB00", Offset = "0x564BF00", VA = "0x18564CB00")]
	internal int IIHNDJKBLJD(NPCMMBJHICN NNECHFOMFEJ, IPEndPoint JIGIGHHIDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x564CB40", Offset = "0x564BF40", VA = "0x18564CB40")]
	internal int IIHNDJKBLJD(byte[] JEBCFBFPEMG, int IEPLFGFMPDD, int POJMEHKIPEF, IPEndPoint JIGIGHHIDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x564DAA0", Offset = "0x564CEA0", VA = "0x18564DAA0")]
	internal void KFEHDFNBHOC(bool CECGOOLHBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum KAIGKLPNPJB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class NPCMMBJHICN
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int HAFAPBPBGFF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] HGNDIOBAPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] NDKPDJFBNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int JOOOJCLOMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object MFOGKCGALOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NPCMMBJHICN KPEIOJKKKLO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public KAIGKLPNPJB EGMBFMDCIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5655BC0", Offset = "0x5654FC0", VA = "0x185655BC0")]
		get
		{
			return default(KAIGKLPNPJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5656030", Offset = "0x5655430", VA = "0x185656030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte KAELDJBDPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5655B50", Offset = "0x5654F50", VA = "0x185655B50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5655CF0", Offset = "0x56550F0", VA = "0x185655CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort ABLAABCBOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5655D30", Offset = "0x5655130", VA = "0x185655D30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5655AE0", Offset = "0x5654EE0", VA = "0x185655AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AIEBNNOGFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5655D90", Offset = "0x5655190", VA = "0x185655D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte JLOMIIEBGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5656070", Offset = "0x5655470", VA = "0x185656070")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5655B20", Offset = "0x5654F20", VA = "0x185655B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort BJKHLDJLHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5655F40", Offset = "0x5655340", VA = "0x185655F40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5655B80", Offset = "0x5654F80", VA = "0x185655B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort PMDOOBHADHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5655FD0", Offset = "0x56553D0", VA = "0x185655FD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5655F00", Offset = "0x5655300", VA = "0x185655F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PKMAAGLHNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x56560A0", Offset = "0x56554A0", VA = "0x1856560A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5655DC0", Offset = "0x56551C0", VA = "0x185655DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5656100", Offset = "0x5655500", VA = "0x185656100")]
	static NPCMMBJHICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5655FA0", Offset = "0x56553A0", VA = "0x185655FA0")]
	public void KKKKJGMLFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x56563E0", Offset = "0x56557E0", VA = "0x1856563E0")]
	public NPCMMBJHICN(int HIAJHKACHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5656450", Offset = "0x5655850", VA = "0x185656450")]
	public NPCMMBJHICN(KAIGKLPNPJB KENAPEDMLDN, int HIAJHKACHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5655E90", Offset = "0x5655290", VA = "0x185655E90")]
	public static int IKJCJOAOMIN(KAIGKLPNPJB KENAPEDMLDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5655E00", Offset = "0x5655200", VA = "0x185655E00")]
	public int IKJCJOAOMIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5655BF0", Offset = "0x5654FF0", VA = "0x185655BF0")]
	public bool DHICOMIFOLJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum CAJPMEOCCBL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal enum AAIENOOHDDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum EOHPOPCFCBA
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum DGDAPKMNNIE
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DCAJPFGHPOC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class ECGOIICPPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NPCMMBJHICN[] IOODKAFLKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int MGKNKOAKIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PKAIKFOHEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte JLOMIIEBGKA;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ECGOIICPPDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void MEOICNECMJM(ulong PIDPNJGAOFA, int DGBJDEKJGCD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int HIHHMPGGLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int LALMNOBHCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int BJHMPIFLFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double KKLHFGOIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int MOEDINJPGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int MICGBGHEIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int BLNOADFFHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch KAKJLJGNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HBOFFMHKILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long BOJMEHIKHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object LLANNBBLHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal DCAJPFGHPOC NIBBKBGPJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal DCAJPFGHPOC LHNBEKFMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<NPCMMBJHICN> JBAMKJBDKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<GAFMBPMDOOI> GFCFGGBGHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly GAFMBPMDOOI[] AEMKELBPIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int ELEGFHPKNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int HKJAELFCICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool JEOEEGODEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int JNHCIJOOJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int KJEIBKEMHFF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int PFIOCONJCKF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int FGJCNBHDJIL = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object KLCKEHOEPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KBCEPBPALEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, ECGOIICPPDD> FNOHHLEKDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> IAIAOHEAGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NPCMMBJHICN NGPCJIPLCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int NKCJNLMNGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int MJDKMDMIBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint AGIKHGMPENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int NLEBJGHOKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int OIKKFOECDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long GMCNGELPPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte DCIAHPICANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private CAJPMEOCCBL KGCINNLAPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NPCMMBJHICN ALKIGENFFFO;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int GAINLPGFKPP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int HNLDBBCFBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly NPCMMBJHICN LKKCFHGPAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly NPCMMBJHICN MEDHNKFFFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly NPCMMBJHICN AEJOMOEHDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly NPCMMBJHICN LGHIIPNIPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private CNLPALKBFIL LICIMEMEJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly GIAAAHOFKBG OILGBBNINAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int KGFFFPMLIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object IFKEADLGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly HOKFLJJNCIG CHKOKBDLCBK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte EEPNOKJELFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA6560", Offset = "0xAA5960", VA = "0x180AA6560")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x56448A0", Offset = "0x5643CA0", VA = "0x1856448A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint ADKALABNDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA80", Offset = "0x8FCE80", VA = "0x1808FDA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CAJPMEOCCBL CELHLNKAAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x162E4A0", Offset = "0x162D8A0", VA = "0x18162E4A0")]
		get
		{
			return default(CAJPMEOCCBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long CDCLHAMFAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BED40", Offset = "0x7BE140", VA = "0x1807BED40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int AJJLLNFMMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB71070", Offset = "0xB70470", VA = "0x180B71070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1457BE0", Offset = "0x1456FE0", VA = "0x181457BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int HHCCJMBJGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5642640", Offset = "0x5641A40", VA = "0x185642640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DEPHILPLFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CD110", Offset = "0x7CC510", VA = "0x1807CD110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double PJDAPKEAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x184AC00", Offset = "0x184A000", VA = "0x18184AC00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MEOICNECMJM HAEPFPBMGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5645210", Offset = "0x5644610", VA = "0x185645210")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5644730", Offset = "0x5643B30", VA = "0x185644730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5645D50", Offset = "0x5645150", VA = "0x185645D50")]
	internal DCAJPFGHPOC(GIAAAHOFKBG AGCJADAEEED, IPEndPoint JIGIGHHIDNG, int BFMGPLIBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5643630", Offset = "0x5642A30", VA = "0x185643630")]
	internal void HKFMAAJMECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5644820", Offset = "0x5643C20", VA = "0x185644820")]
	internal void LHJEBPEJOFM(IPEndPoint CKOOCBNMOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56426D0", Offset = "0x5641AD0", VA = "0x1856426D0")]
	internal void DBHMEFNCPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5643390", Offset = "0x5642790", VA = "0x185643390")]
	private void GNGKCBJOJLE(int BPDBLBNANMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56447E0", Offset = "0x5643BE0", VA = "0x1856447E0")]
	private void LGPCEMKBGFG(int GHIJPNJMGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5645000", Offset = "0x5644400", VA = "0x185645000")]
	private GAFMBPMDOOI LOGHHNMGHLP(byte IFCNELFPJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5645BC0", Offset = "0x5644FC0", VA = "0x185645BC0")]
	internal DCAJPFGHPOC(GIAAAHOFKBG AGCJADAEEED, IPEndPoint JIGIGHHIDNG, int BFMGPLIBCKL, byte MGCEHEFLCLK, NBADJKOBJGH NIIMEDIODCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x56461B0", Offset = "0x56455B0", VA = "0x1856461B0")]
	internal DCAJPFGHPOC(GIAAAHOFKBG AGCJADAEEED, BNDHBAELKNH BDAAOBFBLIB, int BFMGPLIBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5644850", Offset = "0x5643C50", VA = "0x185644850")]
	internal void LHOBPFGOCHJ(GCDHIOBBOOK BLHCGBMFNHJ, byte[] FLKOGFDGJDF, int IEPLFGFMPDD, int POJMEHKIPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5642650", Offset = "0x5641A50", VA = "0x185642650")]
	internal bool CKJJJOAAAKL(PLCCPEJAMPL NNECHFOMFEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5642E10", Offset = "0x5642210", VA = "0x185642E10")]
	public void DIDDGAMGKCD(byte[] FLKOGFDGJDF, int IEPLFGFMPDD, int POJMEHKIPEF, LJHBGDLHINL ABKDMFHFFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5642E40", Offset = "0x5642240", VA = "0x185642E40")]
	private void FLHCAGNEODA(byte[] FLKOGFDGJDF, int IEPLFGFMPDD, int POJMEHKIPEF, byte MNPFNILDNBP, LJHBGDLHINL DDEPHFLNBBI, object JAPIGMAKNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5645800", Offset = "0x5644C00", VA = "0x185645800")]
	public void OBOLMEBAKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5644530", Offset = "0x5643930", VA = "0x185644530")]
	internal EOHPOPCFCBA JJJEHHKNEDI(NPCMMBJHICN NNECHFOMFEJ)
	{
		return default(EOHPOPCFCBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x56451B0", Offset = "0x56445B0", VA = "0x1856451B0")]
	internal void LPNHCGMKGMG(GAFMBPMDOOI CDLGIHHMCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x56458B0", Offset = "0x5644CB0", VA = "0x1856458B0")]
	internal DGDAPKMNNIE PNHIHLJPELJ(byte[] FLKOGFDGJDF, int IEPLFGFMPDD, int POJMEHKIPEF, bool DOPMCGBECME)
	{
		return default(DGDAPKMNNIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5642600", Offset = "0x5641A00", VA = "0x185642600")]
	private void BHFKPFKCLHA(int JOINMCJADDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5643BA0", Offset = "0x5642FA0", VA = "0x185643BA0")]
	internal void IPHDHDBIGNJ(LJHBGDLHINL PEHEMBLLCEM, NPCMMBJHICN FBPAJEFFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5643650", Offset = "0x5642A50", VA = "0x185643650")]
	private void IAJABDHCADL(NPCMMBJHICN NNECHFOMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5645480", Offset = "0x5644880", VA = "0x185645480")]
	private void NNLCFBHHOCL(int MEOLIKAEACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x56452C0", Offset = "0x56446C0", VA = "0x1856452C0")]
	internal AAIENOOHDDJ NGDGMBOBNEB(GCDHIOBBOOK INBLAJOEBLM)
	{
		return default(AAIENOOHDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5642760", Offset = "0x5641B60", VA = "0x185642760")]
	internal void DEJABFNMLPB(NPCMMBJHICN NNECHFOMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5644610", Offset = "0x5643A10", VA = "0x185644610")]
	private void KAAIMKOLIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5643460", Offset = "0x5642860", VA = "0x185643460")]
	internal void HJPJJKNCLAG(NPCMMBJHICN NNECHFOMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5644950", Offset = "0x5643D50", VA = "0x185644950")]
	internal void LLBOFPOPBEE(int MEOLIKAEACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5642340", Offset = "0x5641740", VA = "0x185642340")]
	internal void BBNPPMMOOKG(NPCMMBJHICN NNECHFOMFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HOKFLJJNCIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long EJLPODIJEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long NKPJIHIJJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long HPHFJDNFFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long IEEKECCGFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HNOPDBCHGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long ANHCLFDOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long BIGANEMBCPC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long OHNAMEAEDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5650670", Offset = "0x564FA70", VA = "0x185650670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long BFFDABHFPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5650660", Offset = "0x564FA60", VA = "0x185650660")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long IHCEJAKPEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5650530", Offset = "0x564F930", VA = "0x185650530")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long JMOFCNPDIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5650750", Offset = "0x564FB50", VA = "0x185650750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long OCLKOCAHBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5650520", Offset = "0x564F920", VA = "0x185650520")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long PELBKELJKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x56505F0", Offset = "0x564F9F0", VA = "0x1856505F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private CNLPALKBFIL NGIBOALMEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6750", Offset = "0x1AB5B50", VA = "0x181AB6750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double BHNNJFIBGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5650600", Offset = "0x564FA00", VA = "0x185650600")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5650580", Offset = "0x564F980", VA = "0x185650580")]
	public void HIHHBKCGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5650760", Offset = "0x564FB60", VA = "0x185650760")]
	public void ONENGPILMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5650510", Offset = "0x564F910", VA = "0x185650510")]
	public void BOHNHHHAGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5650790", Offset = "0x564FB90", VA = "0x185650790")]
	public void PONEKGHMNIN(long MEKKALHLNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x56505E0", Offset = "0x564F9E0", VA = "0x1856505E0")]
	public void INAGKEJKDHC(long MOCHCIJBGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5650720", Offset = "0x564FB20", VA = "0x185650720")]
	public void OCMDGCPCGGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5650540", Offset = "0x564F940", VA = "0x185650540")]
	public void GEHPAEMNGCA(long FMPEJKIIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56507A0", Offset = "0x564FBA0", VA = "0x1856507A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5650680", Offset = "0x564FA80", VA = "0x185650680")]
	public void NJKIHKKBDMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HOKFLJJNCIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MMMOOBCGMCD
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> AMOJJEABEBK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x56549B0", Offset = "0x5653DB0", VA = "0x1856549B0")]
	public static IPEndPoint LJHLILMELHA(string MGJNHCNJCHD, int EOAJDOPMJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5654750", Offset = "0x5653B50", VA = "0x185654750")]
	public static IPAddress KKKMNMMCACP(string MGJNHCNJCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5654920", Offset = "0x5653D20", VA = "0x185654920")]
	public static IPAddress KKKMNMMCACP(string MGJNHCNJCHD, AddressFamily NEGNDNCPFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5654720", Offset = "0x5653B20", VA = "0x185654720")]
	internal static int JDPDBBOINNN(int PFOIBCCNACC, int DDFBBJMHKLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x28B2A10", Offset = "0x28B1E10", VA = "0x1828B2A10")]
	internal static T[] FOLEPGLJPAD<T>(int JDBLGKLFJDF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class EAFBFDHBECC : GAFMBPMDOOI
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KEMINEMFAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private NPCMMBJHICN JEMEMIJCJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long HPIFNMKDNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool GLABMLDEEGI;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x56524B0", Offset = "0x56518B0", VA = "0x1856524B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5652490", Offset = "0x5651890", VA = "0x185652490")]
		public void PJKLBDDMIFJ(NPCMMBJHICN NNECHFOMFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x56523D0", Offset = "0x56517D0", VA = "0x1856523D0")]
		public bool AIHENKNNFHB(long OLNGMPNNPCA, DCAJPFGHPOC JBOMFEIJMDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5652440", Offset = "0x5651840", VA = "0x185652440")]
		public bool OIGNPMFKFFL(DCAJPFGHPOC JBOMFEIJMDD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly NPCMMBJHICN LJCKOFKJMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly KEMINEMFAHO[] DBNJHLHABKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly NPCMMBJHICN[] LFDEEKMMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] INIGOOAPLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int HHPGEPJHGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int FFENBNPKJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int JJDOBJBMACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int PDHCHFBODLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool CBOFBEFPAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly LJHBGDLHINL HBBIPEGLNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool GHOHGEKBNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int DFNGIIMLNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte KOPPILNNJMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5647670", Offset = "0x5646A70", VA = "0x185647670")]
	public EAFBFDHBECC(DCAJPFGHPOC JBOMFEIJMDD, bool LFIKHPBGHIH, byte BFMGPLIBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5646E00", Offset = "0x5646200", VA = "0x185646E00")]
	private void EHILBHANLBD(NPCMMBJHICN NNECHFOMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56471C0", Offset = "0x56465C0", VA = "0x1856471C0", Slot = "4")]
	protected override bool HKBBCMOIINP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56467A0", Offset = "0x5645BA0", VA = "0x1856467A0", Slot = "5")]
	public override bool DEJABFNMLPB(NPCMMBJHICN NNECHFOMFEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KMPDHMHEBIK : GAFMBPMDOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int AIJJPEMFIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort FFENBNPKJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool EDKJEDCBLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NPCMMBJHICN HEPGAENPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly NPCMMBJHICN OAEECFMNMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool BFKGKHNLDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte KOPPILNNJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long INAPNBLOKEI;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5652D00", Offset = "0x5652100", VA = "0x185652D00")]
	public KMPDHMHEBIK(DCAJPFGHPOC JBOMFEIJMDD, bool KLGCDAIDNBK, byte BFMGPLIBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5652860", Offset = "0x5651C60", VA = "0x185652860", Slot = "4")]
	protected override bool HKBBCMOIINP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5652550", Offset = "0x5651950", VA = "0x185652550", Slot = "5")]
	public override bool DEJABFNMLPB(NPCMMBJHICN NNECHFOMFEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FBFIEBDNHJD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct KNDFBDJCCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong FJFHAOJDMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double KNBAFKEFEAA;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OEBGJOHCGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int GKLECFJOLBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float KELIPKDGGEC;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5640720", Offset = "0x563FB20", VA = "0x185640720")]
	private static void FMHDHLPIHKC(byte[] DPJOGLFAKHN, int PADMGOMCMCK, ulong FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5647920", Offset = "0x5646D20", VA = "0x185647920")]
	private static void FMHDHLPIHKC(byte[] DPJOGLFAKHN, int PADMGOMCMCK, int FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x56478E0", Offset = "0x5646CE0", VA = "0x1856478E0")]
	public static void FMHDHLPIHKC(byte[] DPJOGLFAKHN, int PADMGOMCMCK, short FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5647A20", Offset = "0x5646E20", VA = "0x185647A20")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, double PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x56479A0", Offset = "0x5646DA0", VA = "0x1856479A0")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, float PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x56478E0", Offset = "0x5646CE0", VA = "0x1856478E0")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, short PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x56478E0", Offset = "0x5646CE0", VA = "0x1856478E0")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, ushort PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5647920", Offset = "0x5646D20", VA = "0x185647920")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, int PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5647920", Offset = "0x5646D20", VA = "0x185647920")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, uint PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5647990", Offset = "0x5646D90", VA = "0x185647990")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, long PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5647990", Offset = "0x5646D90", VA = "0x185647990")]
	public static void MCDDEDFJAPG(byte[] GHDDMAGGOCG, int CAIMMNKGOCP, ulong PCGOHCLJAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ADMFICABCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] CPFCAALFHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int PGOOJDLKMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int PCEPKJGFPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int GGMBJLNPFKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] NDKPDJFBNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int PBAHDGDDJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HADFFGFBBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5640CB0", Offset = "0x56400B0", VA = "0x185640CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BKEKECHPLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1CFF780", Offset = "0x1CFEB80", VA = "0x181CFF780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MLJDOOBGFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5640930", Offset = "0x563FD30", VA = "0x185640930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5640E60", Offset = "0x5640260", VA = "0x185640E60")]
	public void IEFEOPCLKCG(byte[] CNGBAHCAJJB, int PADMGOMCMCK, int CGHIOJGHDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public ADMFICABCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x56414A0", Offset = "0x56408A0", VA = "0x1856414A0")]
	public ADMFICABCPD(byte[] CNGBAHCAJJB, int PADMGOMCMCK, int CGHIOJGHDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x56411F0", Offset = "0x56405F0", VA = "0x1856411F0")]
	public IPEndPoint NOPBNFEPHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5641140", Offset = "0x5640540", VA = "0x185641140")]
	public byte OBOEKPAEJHN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5641140", Offset = "0x5640540", VA = "0x185641140")]
	public sbyte MFLCCKILBIB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB13D0", Offset = "0x2DB07D0", VA = "0x182DB13D0")]
	public T[] AAKGJHIKHJC<T>(ushort HIAJHKACHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5640F50", Offset = "0x5640350", VA = "0x185640F50")]
	public bool[] LANPAODIOGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5640F90", Offset = "0x5640390", VA = "0x185640F90")]
	public ushort[] LFLPIKCPIJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x56408B0", Offset = "0x563FCB0", VA = "0x1856408B0")]
	public short[] AAINIHOIPFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5641100", Offset = "0x5640500", VA = "0x185641100")]
	public int[] LNJJKGOIKKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5640E20", Offset = "0x5640220", VA = "0x185640E20")]
	public uint[] HPEMOHAGOIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5640940", Offset = "0x563FD40", VA = "0x185640940")]
	public float[] CJFGJFOJDJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5640D70", Offset = "0x5640170", VA = "0x185640D70")]
	public double[] HALDMONIIMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x56408F0", Offset = "0x563FCF0", VA = "0x1856408F0")]
	public long[] AGJIBHJIPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5640D30", Offset = "0x5640130", VA = "0x185640D30")]
	public ulong[] GGHGPCNKHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5640FD0", Offset = "0x56403D0", VA = "0x185640FD0")]
	public string[] LJHDOLLHKCB(int DBELDEBCOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5640C30", Offset = "0x5640030", VA = "0x185640C30")]
	public bool DPDMLHCMJLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5640BC0", Offset = "0x563FFC0", VA = "0x185640BC0")]
	public char GOBIFFOFGBG()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5640BC0", Offset = "0x563FFC0", VA = "0x185640BC0")]
	public ushort DLIPBCJDHDB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5640DB0", Offset = "0x56401B0", VA = "0x185640DB0")]
	public short HMHFGOOFGCF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5640CC0", Offset = "0x56400C0", VA = "0x185640CC0")]
	public long GFENDDLCKNA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x56412C0", Offset = "0x56406C0", VA = "0x1856412C0")]
	public ulong ODHJBCHLJBL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5640EA0", Offset = "0x56402A0", VA = "0x185640EA0")]
	public int IPKNBIPEDBA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5641330", Offset = "0x5640730", VA = "0x185641330")]
	public uint ODKFCDGKHBE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5641180", Offset = "0x5640580", VA = "0x185641180")]
	public float NFLJNEDMPNH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x56413A0", Offset = "0x56407A0", VA = "0x1856413A0")]
	public double OEHPGMEMPPC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5640980", Offset = "0x563FD80", VA = "0x185640980")]
	public string DKFLLFJCDLD(int FKEMEGDKKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5641430", Offset = "0x5640830", VA = "0x185641430")]
	public ArraySegment<byte> PBCBHOPPEDB(int JDBLGKLFJDF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5640C70", Offset = "0x5640070", VA = "0x185640C70")]
	public sbyte[] EJBAKJPKEDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5640F10", Offset = "0x5640310", VA = "0x185640F10")]
	public byte[] LACGLEJPPKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5641410", Offset = "0x5640810", VA = "0x185641410")]
	public void OIGNPMFKFFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NBADJKOBJGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] CPFCAALFHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int PGOOJDLKMFH;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int HELLIGAIONF = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool GHHMOJACLOA;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding LBBGKMEJHFO;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int JAICMFIOBGF = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] JHANCCIOHKK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] CIKHIKEBPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int GGHIHFENJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5655A60", Offset = "0x5654E60", VA = "0x185655A60")]
	public NBADJKOBJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x56559C0", Offset = "0x5654DC0", VA = "0x1856559C0")]
	public NBADJKOBJGH(bool IFIBCGPEIEK, int OAJHGFIEKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5654C90", Offset = "0x5654090", VA = "0x185654C90")]
	public static NBADJKOBJGH CPABHACIFGJ(string PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5654DE0", Offset = "0x56541E0", VA = "0x185654DE0")]
	public void HHCKDKJKLII(int DGPLGHIHJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1D79400", Offset = "0x1D78800", VA = "0x181D79400")]
	public void HIHHBKCGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x56556A0", Offset = "0x5654AA0", VA = "0x1856556A0")]
	public void JDPJAAFIMMK(float PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5655870", Offset = "0x5654C70", VA = "0x185655870")]
	public void JDPJAAFIMMK(double PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5655550", Offset = "0x5654950", VA = "0x185655550")]
	public void JDPJAAFIMMK(long PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5655550", Offset = "0x5654950", VA = "0x185655550")]
	public void JDPJAAFIMMK(ulong PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x56555A0", Offset = "0x56549A0", VA = "0x1856555A0")]
	public void JDPJAAFIMMK(int PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x56555A0", Offset = "0x56549A0", VA = "0x1856555A0")]
	public void JDPJAAFIMMK(uint PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x56552D0", Offset = "0x56546D0", VA = "0x1856552D0")]
	public void JDPJAAFIMMK(char PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x56552D0", Offset = "0x56546D0", VA = "0x1856552D0")]
	public void JDPJAAFIMMK(ushort PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x56552D0", Offset = "0x56546D0", VA = "0x1856552D0")]
	public void JDPJAAFIMMK(short PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5655740", Offset = "0x5654B40", VA = "0x185655740")]
	public void JDPJAAFIMMK(sbyte PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5655740", Offset = "0x5654B40", VA = "0x185655740")]
	public void JDPJAAFIMMK(byte PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x56558C0", Offset = "0x5654CC0", VA = "0x1856558C0")]
	public void JDPJAAFIMMK(byte[] FLKOGFDGJDF, int PADMGOMCMCK, int POJMEHKIPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5654D00", Offset = "0x5654100", VA = "0x185654D00")]
	public void EGFFKJCFCAF(sbyte[] FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5654D00", Offset = "0x5654100", VA = "0x185654D00")]
	public void HDHHPPGEECG(byte[] FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5655640", Offset = "0x5654A40", VA = "0x185655640")]
	public void JDPJAAFIMMK(bool PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5655120", Offset = "0x5654520", VA = "0x185655120")]
	public void JCLDJFAONKK(Array NCFKHLBNIHO, int ALFJBAENFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5655040", Offset = "0x5654440", VA = "0x185655040")]
	public void JCLDJFAONKK(float[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5654F60", Offset = "0x5654360", VA = "0x185654F60")]
	public void JCLDJFAONKK(double[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5654F60", Offset = "0x5654360", VA = "0x185654F60")]
	public void JCLDJFAONKK(long[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5654F60", Offset = "0x5654360", VA = "0x185654F60")]
	public void JCLDJFAONKK(ulong[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5655040", Offset = "0x5654440", VA = "0x185655040")]
	public void JCLDJFAONKK(int[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5655040", Offset = "0x5654440", VA = "0x185655040")]
	public void JCLDJFAONKK(uint[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5654E80", Offset = "0x5654280", VA = "0x185654E80")]
	public void JCLDJFAONKK(ushort[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5654E80", Offset = "0x5654280", VA = "0x185654E80")]
	public void JCLDJFAONKK(short[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5654D00", Offset = "0x5654100", VA = "0x185654D00")]
	public void JCLDJFAONKK(bool[] PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5655200", Offset = "0x5654600", VA = "0x185655200")]
	public void JCLDJFAONKK(string[] PCGOHCLJAPN, int FMBPPLJILFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56557A0", Offset = "0x5654BA0", VA = "0x1856557A0")]
	public void JDPJAAFIMMK(IPEndPoint AFCIGMCAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5655630", Offset = "0x5654A30", VA = "0x185655630")]
	public void JDPJAAFIMMK(string PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5655340", Offset = "0x5654740", VA = "0x185655340")]
	public void JDPJAAFIMMK(string PCGOHCLJAPN, int FKEMEGDKKAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BEMJIOPIMCB
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class IEBNLPPEDFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong KGFFFPMLIDM;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x39A2D00", Offset = "0x39A2100", VA = "0x1839A2D00")]
		static IEBNLPPEDFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void LLGNBBAEEOJ(ADMFICABCPD JIKGIJPCJAL, object JAPIGMAKNLK);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CIPNOEBNGLJ<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public BEMJIOPIMCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public CIPNOEBNGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4BD1F30", Offset = "0x4BD1330", VA = "0x184BD1F30")]
		internal void PCEBBBHHNFB(ADMFICABCPD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NAPMGMPPIAH<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public BEMJIOPIMCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public NAPMGMPPIAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3F690C0", Offset = "0x3F684C0", VA = "0x183F690C0")]
		internal void PCEBBBHHNFB(ADMFICABCPD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly ELHKHDBGBPN FMHLPGHLHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, LLGNBBAEEOJ> NJMGEFCFKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly NBADJKOBJGH FOEIOGFFHJA;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5641F20", Offset = "0x5641320", VA = "0x185641F20")]
	public BEMJIOPIMCB(int DBELDEBCOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2598490", Offset = "0x2597890", VA = "0x182598490", Slot = "4")]
	protected virtual ulong PGMMMODBMLE<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5641DA0", Offset = "0x56411A0", VA = "0x185641DA0", Slot = "5")]
	protected virtual LLGNBBAEEOJ JLOFNKEEMJM(ADMFICABCPD JIKGIJPCJAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2598390", Offset = "0x2597790", VA = "0x182598390", Slot = "6")]
	protected virtual void GFDDGEHNHMM<T>(NBADJKOBJGH NHJJKKKEGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5641D20", Offset = "0x5641120", VA = "0x185641D20")]
	public void HPPDJDHDICL(ADMFICABCPD JIKGIJPCJAL, object JAPIGMAKNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2598400", Offset = "0x2597800", VA = "0x182598400")]
	public void KAIGLPDMMCL<T>(NBADJKOBJGH NHJJKKKEGHL, T NNECHFOMFEJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5641ED0", Offset = "0x56412D0", VA = "0x185641ED0")]
	public void OHOJDECCPGP(ADMFICABCPD JIKGIJPCJAL, object JAPIGMAKNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2598210", Offset = "0x2597610", VA = "0x182598210")]
	public void BLFCPMHFABG<T>(Action<T> HECLJIDILJK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2598090", Offset = "0x2597490", VA = "0x182598090")]
	public void BLFCPMHFABG<T, TUserData>(Action<T, TUserData> HECLJIDILJK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NLBKCPPPKCE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5646790", Offset = "0x5645B90", VA = "0x185646790")]
	public NLBKCPPPKCE(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LBLMNKFBEGC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5652DC0", Offset = "0x56521C0", VA = "0x185652DC0")]
	public LBLMNKFBEGC(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ELHKHDBGBPN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum JLHMNHJGBDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class CFLMHCOAHGN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public JLHMNHJGBDP HCHJICPCOMN;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4AEA7C0", Offset = "0x4AE9BC0", VA = "0x184AEA7C0", Slot = "4")]
		public virtual void PJKLBDDMIFJ(MethodInfo PPFEMIFMPCI, MethodInfo KGDCCDHHFLL, JLHMNHJGBDP NBMJAHOKHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void POJLDNFFKEF(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void KEDJNMCFBFN(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		protected CFLMHCOAHGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class GNDIMHBKBBL<TClass, TProperty> : CFLMHCOAHGN<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> GCDNNPPHICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> BDHKMBNKIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> IFGMDBJJAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> PIHHINHPPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> HKENHOIMIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> KDPJMOCCHEF;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x37E8A50", Offset = "0x37E7E50", VA = "0x1837E8A50", Slot = "7")]
		public override void EMNOGKCJEOO(TClass CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x37E96B0", Offset = "0x37E8AB0", VA = "0x1837E96B0", Slot = "8")]
		public override void HBHHMLKEFGJ(TClass CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x37EF280", Offset = "0x37EE680", VA = "0x1837EF280", Slot = "9")]
		public override void POJLDNFFKEF(TClass CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x37E9B10", Offset = "0x37E8F10", VA = "0x1837E9B10", Slot = "10")]
		public override void KEDJNMCFBFN(TClass CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x37E8B30", Offset = "0x37E7F30", VA = "0x1837E8B30")]
		protected TProperty[] GIFEGJLLAMI(TClass CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x37EA2F0", Offset = "0x37E96F0", VA = "0x1837EA2F0")]
		protected TProperty[] PIEKODLHMIF(TClass CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x37ECBA0", Offset = "0x37EBFA0", VA = "0x1837ECBA0", Slot = "4")]
		public override void PJKLBDDMIFJ(MethodInfo PPFEMIFMPCI, MethodInfo KGDCCDHHFLL, JLHMNHJGBDP NBMJAHOKHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x37EF980", Offset = "0x37EED80", VA = "0x1837EF980")]
		protected GNDIMHBKBBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class EAEEFDMJPKC<TClass, TProperty> : GNDIMHBKBBL<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void EBDPAGFEIMO(ADMFICABCPD ODIMBMMGNME, [Out] TProperty GEGFGGCOHCE);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void ECNLGEBPGPL(NBADJKOBJGH HIJJEKIGNJP, TProperty GEGFGGCOHCE);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x33136E0", Offset = "0x3312AE0", VA = "0x1833136E0", Slot = "5")]
		public override void HPJHOMGBHDO(TClass CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x33137D0", Offset = "0x3312BD0", VA = "0x1833137D0", Slot = "6")]
		public override void KAIGLPDMMCL(TClass CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3313480", Offset = "0x3312880", VA = "0x183313480", Slot = "7")]
		public override void EMNOGKCJEOO(TClass CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3313520", Offset = "0x3312920", VA = "0x183313520", Slot = "8")]
		public override void HBHHMLKEFGJ(TClass CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3313840", Offset = "0x3312C40", VA = "0x183313840")]
		protected EAEEFDMJPKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class GICJECAKFKL<T> : GNDIMHBKBBL<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x37C7C50", Offset = "0x37C7050", VA = "0x1837C7C50", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x37C7CC0", Offset = "0x37C70C0", VA = "0x1837C7CC0", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x37C7B80", Offset = "0x37C6F80", VA = "0x1837C7B80", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x37C7BF0", Offset = "0x37C6FF0", VA = "0x1837C7BF0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public GICJECAKFKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LBBMCFLIHDM<T> : GNDIMHBKBBL<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C6F0", Offset = "0x3D0BAF0", VA = "0x183D0C6F0", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x37C7CC0", Offset = "0x37C70C0", VA = "0x1837C7CC0", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C680", Offset = "0x3D0BA80", VA = "0x183D0C680", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x37C7BF0", Offset = "0x37C6FF0", VA = "0x1837C7BF0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public LBBMCFLIHDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class PFMFDFPKLND<T> : GNDIMHBKBBL<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4198330", Offset = "0x4197730", VA = "0x184198330", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x38570C0", Offset = "0x38564C0", VA = "0x1838570C0", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x41982C0", Offset = "0x41976C0", VA = "0x1841982C0", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3856FF0", Offset = "0x38563F0", VA = "0x183856FF0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public PFMFDFPKLND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class HFFGKPEGPKM<T> : GNDIMHBKBBL<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3857050", Offset = "0x3856450", VA = "0x183857050", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x38570C0", Offset = "0x38564C0", VA = "0x1838570C0", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3856F80", Offset = "0x3856380", VA = "0x183856F80", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3856FF0", Offset = "0x38563F0", VA = "0x183856FF0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public HFFGKPEGPKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NHGJPPDCGEA<T> : GNDIMHBKBBL<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3FAEC70", Offset = "0x3FAE070", VA = "0x183FAEC70", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CD80", Offset = "0x3C7C180", VA = "0x183C7CD80", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3FAEC00", Offset = "0x3FAE000", VA = "0x183FAEC00", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CCB0", Offset = "0x3C7C0B0", VA = "0x183C7CCB0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public NHGJPPDCGEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class KJLAKGOENKD<T> : GNDIMHBKBBL<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CD10", Offset = "0x3C7C110", VA = "0x183C7CD10", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CD80", Offset = "0x3C7C180", VA = "0x183C7CD80", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CC40", Offset = "0x3C7C040", VA = "0x183C7CC40", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CCB0", Offset = "0x3C7C0B0", VA = "0x183C7CCB0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public KJLAKGOENKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ALKLKPOMJHE<T> : GNDIMHBKBBL<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D420", Offset = "0x3A1C820", VA = "0x183A1D420", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D490", Offset = "0x3A1C890", VA = "0x183A1D490", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D350", Offset = "0x3A1C750", VA = "0x183A1D350", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D3C0", Offset = "0x3A1C7C0", VA = "0x183A1D3C0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public ALKLKPOMJHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class CIGJIMFIOLI<T> : GNDIMHBKBBL<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D420", Offset = "0x3A1C820", VA = "0x183A1D420", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D490", Offset = "0x3A1C890", VA = "0x183A1D490", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4AEF260", Offset = "0x4AEE660", VA = "0x184AEF260", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D3C0", Offset = "0x3A1C7C0", VA = "0x183A1D3C0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public CIGJIMFIOLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BKOKKJGCKBG<T> : GNDIMHBKBBL<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4829680", Offset = "0x4828A80", VA = "0x184829680", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x48296F0", Offset = "0x4828AF0", VA = "0x1848296F0", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4829610", Offset = "0x4828A10", VA = "0x184829610", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x37C7BF0", Offset = "0x37C6FF0", VA = "0x1837C7BF0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public BKOKKJGCKBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class OIPJIPBGIIM<T> : GNDIMHBKBBL<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x40DA8F0", Offset = "0x40D9CF0", VA = "0x1840DA8F0", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x40DA960", Offset = "0x40D9D60", VA = "0x1840DA960", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x40DA880", Offset = "0x40D9C80", VA = "0x1840DA880", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CCB0", Offset = "0x3C7C0B0", VA = "0x183C7CCB0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public OIPJIPBGIIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class OPMKOOOAJKI<T> : GNDIMHBKBBL<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x410A4A0", Offset = "0x41098A0", VA = "0x18410A4A0", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x410A510", Offset = "0x4109910", VA = "0x18410A510", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x410A430", Offset = "0x4109830", VA = "0x18410A430", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D3C0", Offset = "0x3A1C7C0", VA = "0x183A1D3C0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x37C7D20", Offset = "0x37C7120", VA = "0x1837C7D20")]
		public OPMKOOOAJKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class EEBDIOKHJJD<T> : EAEEFDMJPKC<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x331E9A0", Offset = "0x331DDA0", VA = "0x18331E9A0", Slot = "12")]
		protected override void ECNLGEBPGPL(NBADJKOBJGH HIJJEKIGNJP, char GEGFGGCOHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x331E970", Offset = "0x331DD70", VA = "0x18331E970", Slot = "11")]
		protected override void EBDPAGFEIMO(ADMFICABCPD ODIMBMMGNME, [Out] char GEGFGGCOHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x331E9D0", Offset = "0x331DDD0", VA = "0x18331E9D0")]
		public EEBDIOKHJJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class LPDOHHDBDIP<T> : EAEEFDMJPKC<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D308C0", Offset = "0x3D2FCC0", VA = "0x183D308C0", Slot = "12")]
		protected override void ECNLGEBPGPL(NBADJKOBJGH HIJJEKIGNJP, IPEndPoint GEGFGGCOHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D30880", Offset = "0x3D2FC80", VA = "0x183D30880", Slot = "11")]
		protected override void EBDPAGFEIMO(ADMFICABCPD ODIMBMMGNME, [Out] IPEndPoint GEGFGGCOHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x331E9D0", Offset = "0x331DDD0", VA = "0x18331E9D0")]
		public LPDOHHDBDIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BADFOJGMNBN<T> : GNDIMHBKBBL<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int MFACCOFONDA;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x47FB410", Offset = "0x47FA810", VA = "0x1847FB410")]
		public BADFOJGMNBN(int FKEMEGDKKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x47FB330", Offset = "0x47FA730", VA = "0x1847FB330", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x47FB3A0", Offset = "0x47FA7A0", VA = "0x1847FB3A0", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x47FB250", Offset = "0x47FA650", VA = "0x1847FB250", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x47FB2C0", Offset = "0x47FA6C0", VA = "0x1847FB2C0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class IKHAMFADLNO<T> : CFLMHCOAHGN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo EGMBFMDCIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type EHCBEGADJHI;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x39BEB40", Offset = "0x39BDF40", VA = "0x1839BEB40")]
		public IKHAMFADLNO(PropertyInfo KENAPEDMLDN, Type FDPGIDPJBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x39BE910", Offset = "0x39BDD10", VA = "0x1839BE910", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x39BE9D0", Offset = "0x39BDDD0", VA = "0x1839BE9D0", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x39BE850", Offset = "0x39BDC50", VA = "0x1839BE850", Slot = "7")]
		public override void EMNOGKCJEOO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x39BE8B0", Offset = "0x39BDCB0", VA = "0x1839BE8B0", Slot = "8")]
		public override void HBHHMLKEFGJ(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x39BEAE0", Offset = "0x39BDEE0", VA = "0x1839BEAE0", Slot = "9")]
		public override void POJLDNFFKEF(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x39BEA80", Offset = "0x39BDE80", VA = "0x1839BEA80", Slot = "10")]
		public override void KEDJNMCFBFN(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class LKABHFMPLNP<T> : IKHAMFADLNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x336E730", Offset = "0x336DB30", VA = "0x18336E730")]
		public LKABHFMPLNP(PropertyInfo KENAPEDMLDN, Type FDPGIDPJBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CFC0", Offset = "0x3D1C3C0", VA = "0x183D1CFC0", Slot = "5")]
		public override void HPJHOMGBHDO(T CANNGEAKGPP, ADMFICABCPD ODIMBMMGNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D080", Offset = "0x3D1C480", VA = "0x183D1D080", Slot = "6")]
		public override void KAIGLPDMMCL(T CANNGEAKGPP, NBADJKOBJGH HIJJEKIGNJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class PHMKGLBNGCP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static PHMKGLBNGCP<T> GDCHCCJBKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly CFLMHCOAHGN<T>[] NJDLCKPBNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int LENKAEGEPIL;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x41A1910", Offset = "0x41A0D10", VA = "0x1841A1910")]
		public PHMKGLBNGCP(List<CFLMHCOAHGN<T>> FEEGPKBFIPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x41A1860", Offset = "0x41A0C60", VA = "0x1841A1860")]
		public void KAIGLPDMMCL(T LIKEKIACGIL, NBADJKOBJGH NHJJKKKEGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x41A17B0", Offset = "0x41A0BB0", VA = "0x1841A17B0")]
		public void HPJHOMGBHDO(T LIKEKIACGIL, ADMFICABCPD JIKGIJPCJAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class KOKHEFJKNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract CFLMHCOAHGN<T> EBLDKANKNCA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NBADJKOBJGH GOJICCMBNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int FBDBPPMGMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, KOKHEFJKNKP> IMJMBEMHHCE;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5647840", Offset = "0x5646C40", VA = "0x185647840")]
	public ELHKHDBGBPN(int DBELDEBCOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x268A7C0", Offset = "0x2689BC0", VA = "0x18268A7C0")]
	private PHMKGLBNGCP<T> HCODFFJJAIJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x261FD60", Offset = "0x261F160", VA = "0x18261FD60")]
	public void GPKLHHLKJHO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x268A6E0", Offset = "0x2689AE0", VA = "0x18268A6E0")]
	public bool CMCHCKHHIFC<T>(ADMFICABCPD JIKGIJPCJAL, T NDIKGOAJKGJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x268A760", Offset = "0x2689B60", VA = "0x18268A760")]
	public void HBIMCCJEPGN<T>(NBADJKOBJGH NHJJKKKEGHL, T LIKEKIACGIL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GAKEDMOBFNI
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime IGAFCLPKKOD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] GHMPACENOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KCKCDGMKENF NOIMIIMKKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5647D10", Offset = "0x5647110", VA = "0x185647D10")]
		get
		{
			return default(KCKCDGMKENF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int PPJFICFIMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5648560", Offset = "0x5647960", VA = "0x185648560")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5648C00", Offset = "0x5648000", VA = "0x185648C00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GFLLKKLLIFG HLDGHGNJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5647CE0", Offset = "0x56470E0", VA = "0x185647CE0")]
		get
		{
			return default(GFLLKKLLIFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5648590", Offset = "0x5647990", VA = "0x185648590")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PMDOAIDHAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5648AD0", Offset = "0x5647ED0", VA = "0x185648AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint EDJNIPKMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5647D40", Offset = "0x5647140", VA = "0x185647D40")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? LIOKENGBLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5648160", Offset = "0x5647560", VA = "0x185648160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? DFBLNGNAFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5648BD0", Offset = "0x5647FD0", VA = "0x185648BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? ANMLMJLDAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x56489E0", Offset = "0x5647DE0", VA = "0x1856489E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5648390", Offset = "0x5647790", VA = "0x185648390")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? JJLDBFKBDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAE23A0", Offset = "0xAE17A0", VA = "0x180AE23A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x910430", Offset = "0x90F830", VA = "0x180910430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5648D50", Offset = "0x5648150", VA = "0x185648D50")]
	public GAKEDMOBFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5648CA0", Offset = "0x56480A0", VA = "0x185648CA0")]
	internal GAKEDMOBFNI(byte[] GHDDMAGGOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x56485D0", Offset = "0x56479D0", VA = "0x1856485D0")]
	public static GAKEDMOBFNI HGIFNGKFPNI(byte[] GHDDMAGGOCG, DateTime HPLCOIFFJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5648190", Offset = "0x5647590", VA = "0x185648190")]
	internal void GCHAFHCJLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5647DC0", Offset = "0x56471C0", VA = "0x185647DC0")]
	private void DMNGCEABHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5648780", Offset = "0x5647B80", VA = "0x185648780")]
	private DateTime? IBDIBMPLAGL(int PADMGOMCMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5647F90", Offset = "0x5647390", VA = "0x185647F90")]
	private void EINMKFGFEII(int PADMGOMCMCK, DateTime? PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5648B00", Offset = "0x5647F00", VA = "0x185648B00")]
	private ulong MNHOOHOAHGB(int PADMGOMCMCK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5648A10", Offset = "0x5647E10", VA = "0x185648A10")]
	private void LKMGMDBCFAI(int PADMGOMCMCK, ulong PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x56486F0", Offset = "0x5647AF0", VA = "0x1856486F0")]
	private uint HLPPFJOMOLN(int PADMGOMCMCK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5513C30", Offset = "0x5513030", VA = "0x185513C30")]
	private static uint JEFILKOCKME(uint LCKGOLLEJPE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5648980", Offset = "0x5647D80", VA = "0x185648980")]
	private static ulong JEFILKOCKME(ulong LCKGOLLEJPE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum KCKCDGMKENF
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum GFLLKKLLIFG
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class LLCLEJJLFGB
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int OOGMHDDDKPK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int OLBGNDBCFIF = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int NIJPOOFILFE = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint BFMDCEMHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int KCKLINBNGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int KMCLCEDLEEG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LIBOCLDCOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5652F10", Offset = "0x5652310", VA = "0x185652F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5652E20", Offset = "0x5652220", VA = "0x185652E20")]
	public bool DIDDGAMGKCD(BHPDBGLFEEA AOAIHFEICOB, int BBPLEPJCAHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class AGOOCALOBKJ : BHPDBGLFEEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket AOAIHFEICOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly GIAAAHOFKBG AGCJADAEEED;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short OEJIIOMIEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5641C10", Offset = "0x5641010", VA = "0x185641C10", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int ANCJJJKIFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5641500", Offset = "0x5640900", VA = "0x185641500", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint GHNOJJKPMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5641BD0", Offset = "0x5640FD0", VA = "0x185641BD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily DOIPNLOGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3480", Offset = "0x3CF2880", VA = "0x183CF3480", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5641C70", Offset = "0x5641070", VA = "0x185641C70")]
	public AGOOCALOBKJ(AddressFamily NEGNDNCPFCJ, GIAAAHOFKBG AGCJADAEEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5641610", Offset = "0x5640A10", VA = "0x185641610", Slot = "8")]
	public bool LANNCOFHMDO(IPEndPoint AFCIGMCAOAB, FPNANPACGHN EIKDCCLGKKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5641C30", Offset = "0x5641030", VA = "0x185641C30", Slot = "9")]
	public int PDDANNIPCAP(byte[] DPJOGLFAKHN, int PADMGOMCMCK, int HIAJHKACHMC, IPEndPoint JIGIGHHIDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5641520", Offset = "0x5640920", VA = "0x185641520", Slot = "10")]
	public int CFEPMBDLPHI(byte[] DPJOGLFAKHN, EndPoint BPHLMBFJOLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5641BF0", Offset = "0x5640FF0", VA = "0x185641BF0", Slot = "11")]
	public void MGEMCKPMJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface BHPDBGLFEEA
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short OEJIIOMIEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int ANCJJJKIFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint GHNOJJKPMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily DOIPNLOGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LANNCOFHMDO(IPEndPoint AFCIGMCAOAB, FPNANPACGHN EIKDCCLGKKM);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int PDDANNIPCAP(byte[] DPJOGLFAKHN, int PADMGOMCMCK, int HIAJHKACHMC, IPEndPoint JIGIGHHIDNG);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CFEPMBDLPHI(byte[] DPJOGLFAKHN, EndPoint JIGIGHHIDNG);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MGEMCKPMJAL();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct JLOAFKEKJCA : IEquatable<JLOAFKEKJCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long HCGGNCAEJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long HNFBJBBEJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long JNEBJDAPGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int EIOIADDKHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int ALKMNCIJLNK;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x56522E0", Offset = "0x56516E0", VA = "0x1856522E0")]
	public JLOAFKEKJCA(byte[] HNJLDECIPHF, int CDODKHCCPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7E60B0", Offset = "0x7E54B0", VA = "0x1807E60B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x56522A0", Offset = "0x56516A0", VA = "0x1856522A0", Slot = "4")]
	public bool Equals(JLOAFKEKJCA MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x56521F0", Offset = "0x56515F0", VA = "0x1856521F0", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class MFJOJPOMPAL : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] GHLMEBGJMHM;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class FOHFMMFAGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int KOJBKLKFIPK;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
	protected FOHFMMFAGMJ(int EOAPCIJIDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KLCOMOPHKBL(IPEndPoint AFCIGMCAOAB, byte[] FLKOGFDGJDF, int PADMGOMCMCK, int POJMEHKIPEF);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AMICIBDIBFC(IPEndPoint AFCIGMCAOAB, byte[] FLKOGFDGJDF, int PADMGOMCMCK, int POJMEHKIPEF);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class JLFOLMGGDAF : FOHFMMFAGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider GDNOAKHCCEC;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator DMGKFKNIHJK;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x56521D0", Offset = "0x56515D0", VA = "0x1856521D0")]
	public JLFOLMGGDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5651E50", Offset = "0x5651250", VA = "0x185651E50")]
	public void KPOCLCKJENJ(IPEndPoint AFCIGMCAOAB, byte[] NIOPCMHKLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5652090", Offset = "0x5651490", VA = "0x185652090")]
	public void NLNMPPOCNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5651930", Offset = "0x5650D30", VA = "0x185651930")]
	private byte[] EMPEMDCLLEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x56519C0", Offset = "0x5650DC0", VA = "0x1856519C0", Slot = "4")]
	public override void KLCOMOPHKBL(IPEndPoint AFCIGMCAOAB, byte[] FLKOGFDGJDF, int PADMGOMCMCK, int POJMEHKIPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5651590", Offset = "0x5650990", VA = "0x185651590", Slot = "5")]
	public override void AMICIBDIBFC(IPEndPoint AFCIGMCAOAB, byte[] FLKOGFDGJDF, int PADMGOMCMCK, int POJMEHKIPEF)
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
