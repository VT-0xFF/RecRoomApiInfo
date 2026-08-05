using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.Core.ResourceManagement;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.Networking.SynchronizedFields;
using RecRoom.ObjectModel;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85B2D60", Offset = "0x85B1D60", VA = "0x1885B2D60", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] DGVDDFJHVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] DGPWFYPKLTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset XRLFBVIQUFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset XRQLZCCODQN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC640", Offset = "0x1FBB640", VA = "0x181FBC640", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85C83D0", Offset = "0x85C73D0", VA = "0x1885C83D0")]
		private void ZASTUGVTQWC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85C88F0", Offset = "0x85C78F0", VA = "0x1885C88F0")]
		private void ZAYARNPRAHL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85C8320", Offset = "0x85C7320", VA = "0x1885C8320", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85C8B50", Offset = "0x85C7B50", VA = "0x1885C8B50")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class UWNIXDDKQGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log LKPGBCATEYG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log QKSPPLLYIYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x85C55D0", Offset = "0x85C45D0", VA = "0x1885C55D0")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OUYXAJFLDNA
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView LPDBWVMLSVN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType ZUXXSZKTBXG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IIVCUXLGPQR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "2")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool Serialize(BitPacker bitpacker);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal interface AESITYPYSZA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool BINBJBQOXVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TSATYBXRVEH(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface KLUFQBEIFWN : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BPSMAKIBARY(OUYXAJFLDNA a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GNUCJQLWVOR(OUYXAJFLDNA a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(KNQKXSRZPRQ.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BKEESUOJXYY();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AGFICARMTGP(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NetworkSyncInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint senderNetworkTick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public double serverNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int serverNetworkTick;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class XJTGSENEGCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), AESITYPYSZA> JQFBEECSVYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<OUYXAJFLDNA> UIERMCZRYPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> FPWEBUWSTUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int KBIVAWBBXWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool ACCHCYLHKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private KNQKXSRZPRQ.ApplyNetworkTransform VITDLAEHVUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream DJCOKSWICBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker CRPKIASSRQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker KJOOTGFULHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] BBOVEULLINX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float UFEPJJGYGYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int RLUNOYMZGEW;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85C7110", Offset = "0x85C6110", VA = "0x1885C7110")]
		public XJTGSENEGCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85C6B80", Offset = "0x85C5B80", VA = "0x1885C6B80")]
		public void Pause(KNQKXSRZPRQ.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85C6160", Offset = "0x85C5160", VA = "0x1885C6160")]
		public void BKEESUOJXYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85C6CE0", Offset = "0x85C5CE0", VA = "0x1885C6CE0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85C5C50", Offset = "0x85C4C50", VA = "0x1885C5C50")]
		public bool Add(OUYXAJFLDNA networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85C6BA0", Offset = "0x85C5BA0", VA = "0x1885C6BA0")]
		public bool Remove(OUYXAJFLDNA networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85C6970", Offset = "0x85C5970", VA = "0x1885C6970")]
		private AESITYPYSZA POMVFBVCHUF(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85C6CD0", Offset = "0x85C5CD0", VA = "0x1885C6CD0")]
		public void SORSLFWWETE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85C70B0", Offset = "0x85C60B0", VA = "0x1885C70B0")]
		private void ZIXIHWMRCRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85C6950", Offset = "0x85C5950", VA = "0x1885C6950")]
		private void PIQFZGZFOVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85C65A0", Offset = "0x85C55A0", VA = "0x1885C65A0")]
		public bool KTFIRWNTINJ(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85C61B0", Offset = "0x85C51B0", VA = "0x1885C61B0")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class QHNKWBBIJMH : AESITYPYSZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private OUYXAJFLDNA UTPNQOCMOQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint GSZPZHUQBCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int DRXFFCKSWWD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool BINBJBQOXVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public QHNKWBBIJMH(OUYXAJFLDNA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85B46A0", Offset = "0x85B36A0", VA = "0x1885B46A0", Slot = "5")]
		public bool TSATYBXRVEH(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85B45C0", Offset = "0x85B35C0", VA = "0x1885B45C0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MBOFFQJMXBG : AESITYPYSZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KNQKXSRZPRQ.ApplyNetworkTransform VITDLAEHVUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId ZNKKIHKODDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int DRXFFCKSWWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint GSZPZHUQBCW;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BINBJBQOXVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1A7E440", Offset = "0x1A7D440", VA = "0x181A7E440")]
		public MBOFFQJMXBG(ViewId a, KNQKXSRZPRQ.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85B3150", Offset = "0x85B2150", VA = "0x1885B3150", Slot = "5")]
		public bool TSATYBXRVEH(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85B2F70", Offset = "0x85B1F70", VA = "0x1885B2F70", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class HLVFTQRYHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85B1EA0", Offset = "0x85B0EA0", VA = "0x1885B1EA0")]
		public static void XRHSQBYDVHR(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85B19A0", Offset = "0x85B09A0", VA = "0x1885B19A0")]
		public static void MMLRKRCFORY(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85B1830", Offset = "0x85B0830", VA = "0x1885B1830")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85B2060", Offset = "0x85B1060", VA = "0x1885B2060")]
		public static void YXIMGFHEKJR(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(KLUFQBEIFWN), new string[] { })]
	public class MXPNRRNANQM : KLUFQBEIFWN, INetworkUpdateSystem, KUDSHOZAGXY, YKHKLPHTBGW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log SAVEFMIYBUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private XJTGSENEGCU FINJBGNWKMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint TUSXELYDFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float AQWHOYOWLKA;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85B3250", Offset = "0x85B2250", VA = "0x1885B3250", Slot = "4")]
		public void BPSMAKIBARY(OUYXAJFLDNA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85B3700", Offset = "0x85B2700", VA = "0x1885B3700", Slot = "5")]
		public void GNUCJQLWVOR(OUYXAJFLDNA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85B3900", Offset = "0x85B2900", VA = "0x1885B3900", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85B3A50", Offset = "0x85B2A50", VA = "0x1885B3A50", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85B3C20", Offset = "0x85B2C20", VA = "0x1885B3C20")]
		private void SJELSLLCNFK(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85B3AD0", Offset = "0x85B2AD0", VA = "0x1885B3AD0", Slot = "6")]
		public void Pause(KNQKXSRZPRQ.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85B31F0", Offset = "0x85B21F0", VA = "0x1885B31F0", Slot = "7")]
		public void BKEESUOJXYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85B3190", Offset = "0x85B2190", VA = "0x1885B3190", Slot = "8")]
		public void AGFICARMTGP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85B3370", Offset = "0x85B2370", VA = "0x1885B3370")]
		private void DLFTRAQXPZQ(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85B3B00", Offset = "0x85B2B00", VA = "0x1885B3B00", Slot = "11")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85B4230", Offset = "0x85B3230", VA = "0x1885B4230")]
		public MXPNRRNANQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KYGKSMZJMMW : AESITYPYSZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float TFRKQMAGBFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int DRXFFCKSWWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint GSZPZHUQBCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType QFRFCRWQFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo IJJKXKYTOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int ITVEGZYZPYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] XLBEVTXNHIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo FPXYGZDVLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int KWNMSELPTEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] JRBGFWXCAGQ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool BINBJBQOXVG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x85B2600", Offset = "0x85B1600", VA = "0x1885B2600", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85B2940", Offset = "0x85B1940", VA = "0x1885B2940")]
		public KYGKSMZJMMW(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85B2800", Offset = "0x85B1800", VA = "0x1885B2800", Slot = "5")]
		public bool TSATYBXRVEH(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85B2450", Offset = "0x85B1450", VA = "0x1885B2450", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85B2840", Offset = "0x85B1840", VA = "0x1885B2840")]
		internal QHNKWBBIJMH VFEJCTIFWZQ(OUYXAJFLDNA a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85B2630", Offset = "0x85B1630", VA = "0x1885B2630")]
		private static void QRDSKFLJPBK(QHNKWBBIJMH a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CYYCGCMRNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85ADAA0", Offset = "0x85ACAA0", VA = "0x1885ADAA0")]
		public static OVSEBXDBUJS YLPXWKQBKGA(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85ADA50", Offset = "0x85ACA50", VA = "0x1885ADA50")]
		public static PlayerId ToPlayerId(this OVSEBXDBUJS player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RRNetworkBehavior : MonoBehaviour, GDNETMRXOLS, FFHJLRAELVV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool CXRRYXUXFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private RRNetworkView WSBTDWSZCUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<SMDYNWTJNDH> DKLEUQYYVDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool ZSYABUSPQML;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId IRZPMKYBMMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x85B6470", Offset = "0x85B5470", VA = "0x1885B6470")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId HNZVHGFNDLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x85B6470", Offset = "0x85B5470", VA = "0x1885B6470", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView MHJYCOKPMCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x85B64F0", Offset = "0x85B54F0", VA = "0x1885B64F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView LPDBWVMLSVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85B64F0", Offset = "0x85B54F0", VA = "0x1885B64F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OVSEBXDBUJS THSAFJBLBFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85B65F0", Offset = "0x85B55F0", VA = "0x1885B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OVSEBXDBUJS KQHNAOZIGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x85B6950", Offset = "0x85B5950", VA = "0x1885B6950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool YLMCIVDLHQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x85B6750", Offset = "0x85B5750", VA = "0x1885B6750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IOUHFDLPXDC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x85B68C0", Offset = "0x85B58C0", VA = "0x1885B68C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IDFQRPVTWEO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x85B63A0", Offset = "0x85B53A0", VA = "0x1885B63A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PEJQVLXZZQS
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85B6680", Offset = "0x85B5680", VA = "0x1885B6680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool WLVSURWXUOC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x85B63A0", Offset = "0x85B53A0", VA = "0x1885B63A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ZKATOGNQQWG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x85B6420", Offset = "0x85B5420", VA = "0x1885B6420", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string HZIBFLVKVJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x85B6560", Offset = "0x85B5560", VA = "0x1885B6560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool YMRAHILDUXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x85B6320", Offset = "0x85B5320", VA = "0x1885B6320", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<OVSEBXDBUJS> WKFIHTOHXQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x85B61F0", Offset = "0x85B51F0", VA = "0x1885B61F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x85B69E0", Offset = "0x85B59E0", VA = "0x1885B69E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85B6150", Offset = "0x85B5150", VA = "0x1885B6150")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D10", Offset = "0x85B4D10", VA = "0x1885B5D10")]
		private void AIYFRFIOOMY(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D50", Offset = "0x85B4D50", VA = "0x1885B5D50", Slot = "9")]
		public void RegisterDestroyHandler(SMDYNWTJNDH handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85B5F90", Offset = "0x85B4F90", VA = "0x1885B5F90", Slot = "10")]
		public void UnregisterDestroyHandler(SMDYNWTJNDH handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85B5D30", Offset = "0x85B4D30", VA = "0x1885B5D30", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RBZGRCTNZZI
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, OVSEBXDBUJS targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, OVSEBXDBUJS targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, OVSEBXDBUJS newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[CompilerGenerated]
		private static InstantiateCallback QMGYIQVKGLE;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback QWMQGFOUHBV
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x85B4F30", Offset = "0x85B3F30", VA = "0x1885B4F30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85B49F0", Offset = "0x85B39F0", VA = "0x1885B49F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback OLPLXSNBGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85B5940", Offset = "0x85B4940", VA = "0x1885B5940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x85B4CF0", Offset = "0x85B3CF0", VA = "0x1885B4CF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback QWKIEERCIQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x85B4930", Offset = "0x85B3930", VA = "0x1885B4930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85B5B00", Offset = "0x85B4B00", VA = "0x1885B5B00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback BEILZPVJDPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x85B4FF0", Offset = "0x85B3FF0", VA = "0x1885B4FF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x85B53D0", Offset = "0x85B43D0", VA = "0x1885B53D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback CJHIYONASMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x85B4870", Offset = "0x85B3870", VA = "0x1885B4870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x85B5490", Offset = "0x85B4490", VA = "0x1885B5490")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback WTIYMDUBGRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x85B56A0", Offset = "0x85B46A0", VA = "0x1885B56A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x85B4B70", Offset = "0x85B3B70", VA = "0x1885B4B70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback OHGAUDVVNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85B4E70", Offset = "0x85B3E70", VA = "0x1885B4E70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85B47B0", Offset = "0x85B37B0", VA = "0x1885B47B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler AOEVGHHQHTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85B5760", Offset = "0x85B4760", VA = "0x1885B5760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85B50B0", Offset = "0x85B40B0", VA = "0x1885B50B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler MMURPDHKIDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x85B4AB0", Offset = "0x85B3AB0", VA = "0x1885B4AB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85B4DB0", Offset = "0x85B3DB0", VA = "0x1885B4DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C30", Offset = "0x85B3C30", VA = "0x1885B4C30")]
		public static void GKYGRSHOVZO([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85B5170", Offset = "0x85B4170", VA = "0x1885B5170")]
		public static void IGFKVJFVVFU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85B5820", Offset = "0x85B4820", VA = "0x1885B5820")]
		public static void TKGZNZAQAAZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85B58B0", Offset = "0x85B48B0", VA = "0x1885B58B0")]
		public static void UADZIEHUOMY(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85B5200", Offset = "0x85B4200", VA = "0x1885B5200")]
		public static void IKMTDUWVQBN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85B5550", Offset = "0x85B4550", VA = "0x1885B5550")]
		public static void NHVSSAPKFWP(RRNetworkView a, string b, OVSEBXDBUJS c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85B5290", Offset = "0x85B4290", VA = "0x1885B5290")]
		public static void IQIKBCCKQVM(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85B5A00", Offset = "0x85B4A00", VA = "0x1885B5A00")]
		public static void XFAHJIZZZTI(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class PATFGALOUJX
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85B4510", Offset = "0x85B3510", VA = "0x1885B4510")]
		[CanBeNull]
		private static bool TVQTZMZZXJV(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85B43C0", Offset = "0x85B33C0", VA = "0x1885B43C0")]
		[CanBeNull]
		public static Component LEMKWGDEPAP(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x396E230", Offset = "0x396D230", VA = "0x18396E230")]
		[CanBeNull]
		public static a LEMKWGDEPAP<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x396E2A0", Offset = "0x396D2A0", VA = "0x18396E2A0")]
		[CanBeNull]
		public static b XMRVKWSOSRN<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x396E080", Offset = "0x396D080", VA = "0x18396E080")]
		public static bool HYKFEECBLKO<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85B44A0", Offset = "0x85B34A0", VA = "0x1885B44A0")]
		[CanBeNull]
		public static RRNetworkView RCMIASXEPQS(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static RRNetworkHandler BHFGTEQSRMY;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x85B6B10", Offset = "0x85B5B10", VA = "0x1885B6B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85B6CC0", Offset = "0x85B5CC0", VA = "0x1885B6CC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85B6C80", Offset = "0x85B5C80", VA = "0x1885B6C80")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RegisterService(typeof(RXBJAECPKTB), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class RXBJAECPKTB : VOXNUUPKVVU, KUDSHOZAGXY, YKHKLPHTBGW, WETTKMMHKBK, MTIYIUMNIKQ, FGJPSHLXWSW, OZDTSOBLUVI
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ZGBPCWLNZTB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int FDZACDQVROB;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZGBPCWLNZTB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x85C7300", Offset = "0x85C6300", VA = "0x1885C7300")]
			internal object QYGGLWYCUNQ((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static Log NYAYCNWAYYG;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static Log BFDMXQXCFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private YAUUWMNIGEZ JCSEKFZJGBA;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static JDVXRUIPJPQ FGOSPYUUAZH;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static Dictionary<int, HashSet<int>> HOKEHHWEEZW;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static Dictionary<int, int> LBSLCQUEEYV;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly List<(GameObject GameObject, int ParentCount)> KPAVODEDXTC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly List<GameObject> ALLXQFDCUUN;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static List<int> XZLZMFLNGCH;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly List<RRNetworkView> DOGHMRGUYAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private WVMUMOWZWPW NQDSAHNFKKL;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly XSNAFSFANWP WQVGFLLFFXF;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly XSNAFSFANWP MNAXQJIRKJY;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85BDF70", Offset = "0x85BCF70", VA = "0x1885BDF70", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x85C0E70", Offset = "0x85BFE70", VA = "0x1885C0E70", Slot = "9")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85BDE60", Offset = "0x85BCE60", VA = "0x1885BDE60", Slot = "10")]
		public void InitExternal(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85BCA30", Offset = "0x85BBA30", VA = "0x1885BCA30", Slot = "11")]
		public void CPMAGOHOWGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x85BF2C0", Offset = "0x85BE2C0", VA = "0x1885BF2C0")]
		private void KHMMEAIGRQI(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85C0440", Offset = "0x85BF440", VA = "0x1885C0440")]
		public GameObject MYWTBZEQNWN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85C06F0", Offset = "0x85BF6F0", VA = "0x1885C06F0")]
		public GameObject OMDOZHRUPRL(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x85C0AF0", Offset = "0x85BFAF0", VA = "0x1885C0AF0")]
		public GameObject QADAWGWRIEY(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85C3300", Offset = "0x85C2300", VA = "0x1885C3300")]
		public GameObject WJXELRSILTY(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85BFA10", Offset = "0x85BEA10", VA = "0x1885BFA10", Slot = "6")]
		public void LZSXTYRSNTU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85BC9C0", Offset = "0x85BB9C0", VA = "0x1885BC9C0")]
		public void CIEQOSCEICL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85C2E30", Offset = "0x85C1E30", VA = "0x1885C2E30", Slot = "7")]
		public void TVMULYCLITD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85BD980", Offset = "0x85BC980", VA = "0x1885BD980", Slot = "4")]
		public GameObject[] HALCYCPJDLS(IList<QXJDRMKUGNF> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85C3DB0", Offset = "0x85C2DB0", VA = "0x1885C3DB0", Slot = "5")]
		public void WZUAHGOWNOP(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85C3220", Offset = "0x85C2220", VA = "0x1885C3220")]
		public void WDFBVLRAOAB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85BCDE0", Offset = "0x85BBDE0", VA = "0x1885BCDE0")]
		private void DLFTRAQXPZQ(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85C2020", Offset = "0x85C1020", VA = "0x1885C2020")]
		private void RKFQXLDLSJO(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85C4150", Offset = "0x85C3150", VA = "0x1885C4150")]
		private void XBSAJJEAIAG(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85C01C0", Offset = "0x85BF1C0", VA = "0x1885C01C0")]
		private void MGKGBWFWBYS(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85C2E40", Offset = "0x85C1E40", VA = "0x1885C2E40")]
		private void UEHZYDRUJGS(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85BDCA0", Offset = "0x85BCCA0", VA = "0x1885BDCA0")]
		private void IDJZPJKUBGO(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85C4380", Offset = "0x85C3380", VA = "0x1885C4380")]
		private void XVNGQBEOAXS(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85BF820", Offset = "0x85BE820", VA = "0x1885BF820")]
		private GameObject LSWGLXJSFSX(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85C1710", Offset = "0x85C0710", VA = "0x1885C1710")]
		private GameObject RGJKNOCPAHX(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85C11B0", Offset = "0x85C01B0", VA = "0x1885C11B0")]
		private static GameObject QTWBGGWQANN(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85BD770", Offset = "0x85BC770", VA = "0x1885BD770")]
		private static GameObject FQTGLOAUFDY(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85BD660", Offset = "0x85BC660", VA = "0x1885BD660")]
		private static void FDVXIUINIQV(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85BFA20", Offset = "0x85BEA20", VA = "0x1885BFA20")]
		private GameObject[] MDYMGTQXLSU(IList<QXJDRMKUGNF> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85BCB20", Offset = "0x85BBB20", VA = "0x1885BCB20")]
		private GameObject[] CVYOURUWBES(InstantiateParameters[] a, int b, OVSEBXDBUJS c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85C1310", Offset = "0x85C0310", VA = "0x1885C1310")]
		private GameObject REVHYIFTUNK([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85C4A80", Offset = "0x85C3A80", VA = "0x1885C4A80")]
		private static bool ZLZMUUOZKAR(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85C21C0", Offset = "0x85C11C0", VA = "0x1885C21C0")]
		private void RKJOTOXNNIF(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85BE440", Offset = "0x85BD440", VA = "0x1885BE440")]
		private void KFALADSMCTH(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85BF330", Offset = "0x85BE330", VA = "0x1885BF330")]
		private static void KRRPTKGJEMM(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85C4940", Offset = "0x85C3940", VA = "0x1885C4940")]
		private void YFHLGBRHSSA(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85BE3A0", Offset = "0x85BD3A0", VA = "0x1885BE3A0")]
		private static int JOIUVHALLLC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85BE340", Offset = "0x85BD340", VA = "0x1885BE340")]
		private void JARVATJASLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85BD100", Offset = "0x85BC100", VA = "0x1885BD100")]
		private void DWHBTDMDJWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85C12B0", Offset = "0x85C02B0", VA = "0x1885C12B0")]
		private static int RANQTHHUOWU(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85C0610", Offset = "0x85BF610", VA = "0x1885C0610")]
		private static int[] OFGDOSZBRXH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85BF720", Offset = "0x85BE720", VA = "0x1885BF720")]
		private static int[] LSPVXDZCUYR(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x85C0AB0", Offset = "0x85BFAB0", VA = "0x1885C0AB0")]
		private void OnMasterClientSwitched(OVSEBXDBUJS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x85C3330", Offset = "0x85C2330", VA = "0x1885C3330")]
		private void WWKBDIVLFIV(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85C07E0", Offset = "0x85BF7E0", VA = "0x1885C07E0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85C1DE0", Offset = "0x85C0DE0", VA = "0x1885C1DE0")]
		private void RINKETASNGJ(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D90", Offset = "0x85C1D90", VA = "0x1885C2D90")]
		private static void SEXBQJCNHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85C0D70", Offset = "0x85BFD70", VA = "0x1885C0D70")]
		private void QPQUIXUAHGD(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85BD0B0", Offset = "0x85BC0B0", VA = "0x1885BD0B0", Slot = "12")]
		private void DRCAJKSLWZO(MEMEGXEKDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCE8C60", Offset = "0xCE7C60", VA = "0x180CE8C60", Slot = "13")]
		private void ZWDRINULYCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RXBJAECPKTB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RegisterService(typeof(FZQLBUTZAJH), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class FZQLBUTZAJH : KUDSHOZAGXY, YKHKLPHTBGW, UUDCUIBOXPO, AXDTJKLCJPD, OIEOCLRSVGV
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct RpcMethodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public readonly MethodInfo methodInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private readonly Func<MonoBehaviour, object> accessor;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x85C4E20", Offset = "0x85C3E20", VA = "0x1885C4E20")]
			public object ZFTAPIRAWVV(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class GIAEDGEGVNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public FieldInfo BTTIWEHSUNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Func<MonoBehaviour, object> VBYJXZPQDHR;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public GIAEDGEGVNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x85B1720", Offset = "0x85B0720", VA = "0x1885B1720")]
			internal RpcMethodInfo TBSAOMPLAVP(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5250700", Offset = "0x524F700", VA = "0x185250700")]
			internal object TBMTRFVNRKG(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class GIFLAMYEEYN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Func<MonoBehaviour, object> VYMLXJZLXWE;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public GIFLAMYEEYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x85B17E0", Offset = "0x85B07E0", VA = "0x1885B17E0")]
			internal RpcMethodInfo TBXHLTJIKGY(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class JLGYVBEQVAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Type CIAAXSJNMHH;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public JLGYVBEQVAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x85B2410", Offset = "0x85B1410", VA = "0x1885B2410")]
			internal bool YOFXVTPHVVT(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static Dictionary<string, int> GQFSVELRGXP;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static List<string> KDOUFUWRMQQ;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static int IRJJMOWFWQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JIKIFDLTYCC ORBPZQTLISR;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Stopwatch INWWTAIRKIZ;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static Dictionary<MethodInfo, ParameterInfo[]> SLDQBNMRSWY;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> LJZYRXMJDVZ;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85AF110", Offset = "0x85AE110", VA = "0x1885AF110", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85AEC80", Offset = "0x85ADC80", VA = "0x1885AEC80")]
		private void IWJVQHSYWLA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85AF260", Offset = "0x85AE260", VA = "0x1885AF260", Slot = "10")]
		public void InitReferences(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xCE8C60", Offset = "0xCE7C60", VA = "0x180CE8C60", Slot = "11")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85B0950", Offset = "0x85AF950", VA = "0x1885B0950", Slot = "5")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85B08C0", Offset = "0x85AF8C0", VA = "0x1885B08C0")]
		public static bool MHFOUHYBOZB(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85B10E0", Offset = "0x85B00E0", VA = "0x1885B10E0")]
		public static bool URJFYYRMQFR(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x85AE9D0", Offset = "0x85AD9D0", VA = "0x1885AE9D0")]
		private void DLFTRAQXPZQ(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x85AEC50", Offset = "0x85ADC50", VA = "0x1885AEC50", Slot = "9")]
		public string HVJTRJXXWPL(VASLQQLLDVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x85B0BA0", Offset = "0x85AFBA0", VA = "0x1885B0BA0", Slot = "8")]
		public void TQJOIYYWNSG(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x85AE8D0", Offset = "0x85AD8D0", VA = "0x1885AE8D0", Slot = "6")]
		public void CSWAUNIXGNY(ViewId a, string b, OVSEBXDBUJS c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x85AE9A0", Offset = "0x85AD9A0", VA = "0x1885AE9A0", Slot = "7")]
		public void CSWAUNIXGNY(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x85AE420", Offset = "0x85AD420", VA = "0x1885AE420")]
		private void CSWAUNIXGNY(ViewId a, string b, RpcTarget c, OVSEBXDBUJS d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85AF2B0", Offset = "0x85AE2B0", VA = "0x1885AF2B0")]
		private void LTFPFISCAIR(ViewId a, string b, OVSEBXDBUJS c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x85B0C50", Offset = "0x85AFC50", VA = "0x1885B0C50")]
		private static void UNEOSVKAPIL(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x85B11C0", Offset = "0x85B01C0", VA = "0x1885B11C0")]
		private static bool WTIANMDIPXI(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x85ADB90", Offset = "0x85ACB90", VA = "0x1885ADB90")]
		private List<RpcMethodInfo> ARYYZBPYJLT(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85B0AA0", Offset = "0x85AFAA0", VA = "0x1885B0AA0")]
		private static IEnumerable<MethodInfo> SNBCUQRMDHB(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85B13D0", Offset = "0x85B03D0", VA = "0x1885B13D0")]
		public static ParameterInfo[] XGOBYKGSGCH(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public FZQLBUTZAJH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[TooltipAttribute("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x85B6D80", Offset = "0x85B5D80", VA = "0x1885B6D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x85B6D00", Offset = "0x85B5D00", VA = "0x1885B6D00")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RRNetworkView : MonoBehaviour, KQXBXWSKSDT, EOXSJHNKFUC, FHMTEKPWHIX, ZGVDXNLKQCF, BWZDQSTONJS
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[RegisterService(typeof(YAUUWMNIGEZ), new string[] { })]
		internal class CNMHLSYBMWW : KUDSHOZAGXY, YKHKLPHTBGW, YAUUWMNIGEZ
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Dictionary<int, RRNetworkView> AESPXIUYWNB;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x85AD5C0", Offset = "0x85AC5C0", VA = "0x1885AD5C0", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x85AD5C0", Offset = "0x85AC5C0", VA = "0x1885AD5C0", Slot = "5")]
			public void QQFIGNLTLAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x85AD5D0", Offset = "0x85AC5D0", VA = "0x1885AD5D0", Slot = "6")]
			public void SDFWTMPQMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CNMHLSYBMWW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum HasExplicitViewId
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class EHHPOGHKTEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int UDEBFPRSLBP;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public EHHPOGHKTEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x85ADB30", Offset = "0x85ACB30", VA = "0x1885ADB30")]
			internal bool JIWXMJDGOGD(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static XSNAFSFANWP XJTINXTSGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool EDDBPLYBGPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool LYPSMINXJFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool NLVKIYAAVYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int HVLKURMFDQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool XGCOLERKIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int UTJEMQJABAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private OVSEBXDBUJS KQHNAOZIGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private OVSEBXDBUJS XMHMZRELMZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool? VIOZFSIKFVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool IGUGXMDXWEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal bool KMVMNCCTPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal MonoBehaviour[] AGIIYBFZIVT;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Log GBIVPRISPQO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> AESPXIUYWNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x85B7F40", Offset = "0x85B6F40", VA = "0x1885B7F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId HNZVHGFNDLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x85BB3B0", Offset = "0x85BA3B0", VA = "0x1885BB3B0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId YRJDJHZRYLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x85BB3B0", Offset = "0x85BA3B0", VA = "0x1885BB3B0", Slot = "6")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId IRZPMKYBMMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x85BB3B0", Offset = "0x85BA3B0", VA = "0x1885BB3B0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int YKWQSZMYIMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xB23EE0", Offset = "0xB22EE0", VA = "0x180B23EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int MCCZSYYCMCV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAF3A00", Offset = "0xAF2A00", VA = "0x180AF3A00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xCA39E0", Offset = "0xCA29E0", VA = "0x180CA39E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId VLJKHLYIWMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x85BB220", Offset = "0x85BA220", VA = "0x1885BB220")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IMXTLZTANBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xCE16F0", Offset = "0xCE06F0", VA = "0x180CE16F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xCE16A0", Offset = "0xCE06A0", VA = "0x180CE16A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ODDZUPOOGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x85BB230", Offset = "0x85BA230", VA = "0x1885BB230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool CXBHLLIDAKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int NRHBDLVSUHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xB1B470", Offset = "0xB1A470", VA = "0x180B1B470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int SOHHKPYXQVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x85BB1C0", Offset = "0x85BA1C0", VA = "0x1885BB1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public OVSEBXDBUJS FNLUAHDEJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x85BB3C0", Offset = "0x85BA3C0", VA = "0x1885BB3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public OVSEBXDBUJS BPOHGAQPEXN
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x85BB190", Offset = "0x85BA190", VA = "0x1885BB190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public OVSEBXDBUJS THSAFJBLBFG
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x85BB190", Offset = "0x85BA190", VA = "0x1885BB190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public OVSEBXDBUJS QVHBIRDPRSU
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x85BB190", Offset = "0x85BA190", VA = "0x1885BB190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IKFSPZUQWJG
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x85BB300", Offset = "0x85BA300", VA = "0x1885BB300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int WWGAKALEDNE
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x85BB1F0", Offset = "0x85BA1F0", VA = "0x1885BB1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] MMEGIFSVRUY
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xACDCE0", Offset = "0xACCCE0", VA = "0x180ACDCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xACDF50", Offset = "0xACCF50", VA = "0x180ACDF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool YLMCIVDLHQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x85BB3F0", Offset = "0x85BA3F0", VA = "0x1885BB3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JLEDMXFKAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x85BB380", Offset = "0x85BA380", VA = "0x1885BB380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KFGBTMRRIIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xD446C0", Offset = "0xD436C0", VA = "0x180D446C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xD45AD0", Offset = "0xD44AD0", VA = "0x180D45AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NDIPECDBQMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED90", Offset = "0xD2DD90", VA = "0x180D2ED90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> CQDALRQTKOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x85BB020", Offset = "0x85BA020", VA = "0x1885BB020")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x85BB5B0", Offset = "0x85BA5B0", VA = "0x1885BB5B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<OVSEBXDBUJS> UPVNIDOGXDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x85B86D0", Offset = "0x85B76D0", VA = "0x1885B86D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x85B6FA0", Offset = "0x85B5FA0", VA = "0x1885B6FA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<OVSEBXDBUJS> ANDDZSDGTLB
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x85B86D0", Offset = "0x85B76D0", VA = "0x1885B86D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x85B6FA0", Offset = "0x85B5FA0", VA = "0x1885B6FA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> OMETQHUBMZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x85B8580", Offset = "0x85B7580", VA = "0x1885B8580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x85BAB30", Offset = "0x85B9B30", VA = "0x1885BAB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> FTZUVOKJEUS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x85B8580", Offset = "0x85B7580", VA = "0x1885B8580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x85BAB30", Offset = "0x85B9B30", VA = "0x1885BAB30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> FFNGELVAANW
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x85BB0D0", Offset = "0x85BA0D0", VA = "0x1885BB0D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x85BB660", Offset = "0x85BA660", VA = "0x1885BB660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action BMVIZRSJNUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x85BAF70", Offset = "0x85B9F70", VA = "0x1885BAF70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x85BB500", Offset = "0x85BA500", VA = "0x1885BB500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85BAA70", Offset = "0x85B9A70", VA = "0x1885BAA70")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85B7470", Offset = "0x85B6470", VA = "0x1885B7470")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85B75D0", Offset = "0x85B65D0", VA = "0x1885B75D0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85B7530", Offset = "0x85B6530", VA = "0x1885B7530")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x85B8E50", Offset = "0x85B7E50", VA = "0x1885B8E50")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85B8BF0", Offset = "0x85B7BF0", VA = "0x1885B8BF0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85B8170", Offset = "0x85B7170", VA = "0x1885B8170")]
		public static void OnPlayerJoinedRoom(OVSEBXDBUJS newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85B7730", Offset = "0x85B6730", VA = "0x1885B7730")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85B7790", Offset = "0x85B6790", VA = "0x1885B7790")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85B7330", Offset = "0x85B6330", VA = "0x1885B7330")]
		private void DBAUELGKCRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x85B72B0", Offset = "0x85B62B0", VA = "0x1885B72B0")]
		public bool CreatedBy(OVSEBXDBUJS player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85BA890", Offset = "0x85B9890", VA = "0x1885BA890")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85BA830", Offset = "0x85B9830", VA = "0x1885BA830")]
		public void TransferOwnership(OVSEBXDBUJS newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x85B79B0", Offset = "0x85B69B0", VA = "0x1885B79B0", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85B7950", Offset = "0x85B6950", VA = "0x1885B7950")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x85B6EE0", Offset = "0x85B5EE0", VA = "0x1885B6EE0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x85B8780", Offset = "0x85B7780", VA = "0x1885B8780")]
		private void QZVNBTNTCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1125E80", Offset = "0x1124E80", VA = "0x181125E80")]
		internal void SEDELDTFJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x85B78F0", Offset = "0x85B68F0", VA = "0x1885B78F0", Slot = "7")]
		private void IQVNSFOOXHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x85B7ED0", Offset = "0x85B6ED0", VA = "0x1885B7ED0")]
		internal bool MSWKNIXQFQD(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85B8030", Offset = "0x85B7030", VA = "0x1885B8030")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85B7410", Offset = "0x85B6410", VA = "0x1885B7410")]
		internal void ETXNKQNMTWW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x85B77F0", Offset = "0x85B67F0", VA = "0x1885B77F0")]
		private void HUKHOEIMHAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x85B7E10", Offset = "0x85B6E10", VA = "0x1885B7E10")]
		internal void MOAYJFNJIWB(OVSEBXDBUJS a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x85B8DB0", Offset = "0x85B7DB0", VA = "0x1885B8DB0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85B8F00", Offset = "0x85B7F00", VA = "0x1885B8F00")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x85B7F90", Offset = "0x85B6F90", VA = "0x1885B7F90")]
		private void OXGSIKJGXUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x85B7800", Offset = "0x85B6800", VA = "0x1885B7800")]
		private void IOWPPDOPWZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x85B8AD0", Offset = "0x85B7AD0", VA = "0x1885B8AD0")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x85B8B60", Offset = "0x85B7B60", VA = "0x1885B8B60")]
		public void RPC(string methodName, OVSEBXDBUJS targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x85B8E00", Offset = "0x85B7E00", VA = "0x1885B8E00")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x85B6F30", Offset = "0x85B5F30", VA = "0x1885B6F30", Slot = "9")]
		public void Bake(LTEGTZEKNTU context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x85BA7C0", Offset = "0x85B97C0", VA = "0x1885BA7C0")]
		private static void TRRAZRKZFUA(OVSEBXDBUJS a, [Out] OVSEBXDBUJS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x85B7B20", Offset = "0x85B6B20", VA = "0x1885B7B20")]
		private static void MDNZUPVORHB(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x85B8630", Offset = "0x85B7630", VA = "0x1885B8630")]
		private static RPCInfo QQUGQMYZFJE(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x85BACF0", Offset = "0x85B9CF0", VA = "0x1885BACF0")]
		private static void ZPCUIQFYVCQ(RRNetworkView a, Delegate b, OVSEBXDBUJS c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85BADD0", Offset = "0x85B9DD0", VA = "0x1885BADD0")]
		private static void ZPCUIQFYVCQ(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85BABE0", Offset = "0x85B9BE0", VA = "0x1885BABE0")]
		private static void ZCCWOQHSTFF(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x85B8A00", Offset = "0x85B7A00", VA = "0x1885B8A00")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85B84E0", Offset = "0x85B74E0", VA = "0x1885B84E0")]
		private static bool PTYIUMWNYNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x85B95E0", Offset = "0x85B85E0", VA = "0x1885B95E0", Slot = "26")]
		public void RpcAll(KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3A09680", Offset = "0x3A08680", VA = "0x183A09680", Slot = "10")]
		public void RpcAll<T1>(KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3A08F70", Offset = "0x3A07F70", VA = "0x183A08F70", Slot = "11")]
		public void RpcAll<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B860", Offset = "0x3A0A860", VA = "0x183A0B860", Slot = "27")]
		public void RpcAll<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3A09160", Offset = "0x3A08160", VA = "0x183A09160", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3A09CA0", Offset = "0x3A08CA0", VA = "0x183A09CA0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BD00", Offset = "0x3A0AD00", VA = "0x183A0BD00", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3A097F0", Offset = "0x3A087F0", VA = "0x183A097F0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3A201D0", Offset = "0x3A1F1D0", VA = "0x183A201D0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C120", Offset = "0x3A0B120", VA = "0x183A0C120", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A9C0", Offset = "0x3A099C0", VA = "0x183A0A9C0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3A24C20", Offset = "0x3A23C20", VA = "0x183A24C20", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D820", Offset = "0x3A1C820", VA = "0x183A1D820", Slot = "14")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3A0FE10", Offset = "0x3A0EE10", VA = "0x183A0FE10", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A210", Offset = "0x3A09210", VA = "0x183A0A210", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x85B93B0", Offset = "0x85B83B0", VA = "0x1885B93B0", Slot = "36")]
		public void RpcAll(KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3A1E4F0", Offset = "0x3A1D4F0", VA = "0x183A1E4F0", Slot = "37")]
		public void RpcAll<T1>(KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3A1DEA0", Offset = "0x3A1CEA0", VA = "0x183A1DEA0", Slot = "38")]
		public void RpcAll<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B1C0", Offset = "0x3A0A1C0", VA = "0x183A0B1C0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3A1B390", Offset = "0x3A1A390", VA = "0x183A1B390", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A1A0", Offset = "0x3A191A0", VA = "0x183A1A1A0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3A19A00", Offset = "0x3A18A00", VA = "0x183A19A00", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3A18A10", Offset = "0x3A17A10", VA = "0x183A18A10", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3A177F0", Offset = "0x3A167F0", VA = "0x183A177F0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3A163C0", Offset = "0x3A153C0", VA = "0x183A163C0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3A141F0", Offset = "0x3A131F0", VA = "0x183A141F0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3A13500", Offset = "0x3A12500", VA = "0x183A13500", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3A11A70", Offset = "0x3A10A70", VA = "0x183A11A70", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EEF0", Offset = "0x3A0DEF0", VA = "0x183A0EEF0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3A0DEB0", Offset = "0x3A0CEB0", VA = "0x183A0DEB0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x85B9150", Offset = "0x85B8150", VA = "0x1885B9150", Slot = "51")]
		public void RpcAllViaServer(KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3A2FB80", Offset = "0x3A2EB80", VA = "0x183A2FB80", Slot = "52")]
		public void RpcAllViaServer<T1>(KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3A2FD10", Offset = "0x3A2ED10", VA = "0x183A2FD10", Slot = "15")]
		public void RpcAllViaServer<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F630", Offset = "0x3A2E630", VA = "0x183A2F630", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F260", Offset = "0x3A2E260", VA = "0x183A2F260", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EDD0", Offset = "0x3A2DDD0", VA = "0x183A2EDD0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E880", Offset = "0x3A2D880", VA = "0x183A2E880", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E270", Offset = "0x3A2D270", VA = "0x183A2E270", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3A2DBA0", Offset = "0x3A2CBA0", VA = "0x183A2DBA0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D420", Offset = "0x3A2C420", VA = "0x183A2D420", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3A2CBE0", Offset = "0x3A2BBE0", VA = "0x183A2CBE0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3A2C2E0", Offset = "0x3A2B2E0", VA = "0x183A2C2E0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B920", Offset = "0x3A2A920", VA = "0x183A2B920", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3A2AE90", Offset = "0x3A29E90", VA = "0x183A2AE90", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A330", Offset = "0x3A29330", VA = "0x183A2A330", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x85B9280", Offset = "0x85B8280", VA = "0x1885B9280", Slot = "65")]
		public void RpcAllViaServer(KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3A2FB80", Offset = "0x3A2EB80", VA = "0x183A2FB80", Slot = "66")]
		public void RpcAllViaServer<T1>(KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F930", Offset = "0x3A2E930", VA = "0x183A2F930", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F630", Offset = "0x3A2E630", VA = "0x183A2F630", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F260", Offset = "0x3A2E260", VA = "0x183A2F260", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EDD0", Offset = "0x3A2DDD0", VA = "0x183A2EDD0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E880", Offset = "0x3A2D880", VA = "0x183A2E880", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E270", Offset = "0x3A2D270", VA = "0x183A2E270", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3A2DBA0", Offset = "0x3A2CBA0", VA = "0x183A2DBA0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D420", Offset = "0x3A2C420", VA = "0x183A2D420", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3A2CBE0", Offset = "0x3A2BBE0", VA = "0x183A2CBE0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3A2C2E0", Offset = "0x3A2B2E0", VA = "0x183A2C2E0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B920", Offset = "0x3A2A920", VA = "0x183A2B920", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3A2AE90", Offset = "0x3A29E90", VA = "0x183A2AE90", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A330", Offset = "0x3A29330", VA = "0x183A2A330", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x85BA1C0", Offset = "0x85B91C0", VA = "0x1885BA1C0", Slot = "80")]
		public void RpcOthers(KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3A646E0", Offset = "0x3A636E0", VA = "0x183A646E0", Slot = "16")]
		public void RpcOthers<T1>(KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3A6AB40", Offset = "0x3A69B40", VA = "0x183A6AB40", Slot = "81")]
		public void RpcOthers<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3A644A0", Offset = "0x3A634A0", VA = "0x183A644A0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D940", Offset = "0x3A6C940", VA = "0x183A6D940", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3A69440", Offset = "0x3A68440", VA = "0x183A69440", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B8B0", Offset = "0x3A6A8B0", VA = "0x183A6B8B0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3A688A0", Offset = "0x3A678A0", VA = "0x183A688A0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C4D0", Offset = "0x3A6B4D0", VA = "0x183A6C4D0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3A67A00", Offset = "0x3A66A00", VA = "0x183A67A00", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3A6BFF0", Offset = "0x3A6AFF0", VA = "0x183A6BFF0", Slot = "17")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3A66860", Offset = "0x3A65860", VA = "0x183A66860", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3A65E70", Offset = "0x3A64E70", VA = "0x183A65E70", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3A653C0", Offset = "0x3A643C0", VA = "0x183A653C0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3A64830", Offset = "0x3A63830", VA = "0x183A64830", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x85BA070", Offset = "0x85B9070", VA = "0x1885BA070", Slot = "93")]
		public void RpcOthers(KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A8A0", Offset = "0x3A698A0", VA = "0x183A6A8A0", Slot = "94")]
		public void RpcOthers<T1>(KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A6E0", Offset = "0x3A696E0", VA = "0x183A6A6E0", Slot = "95")]
		public void RpcOthers<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3A69CE0", Offset = "0x3A68CE0", VA = "0x183A69CE0", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A440", Offset = "0x3A69440", VA = "0x183A6A440", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B050", Offset = "0x3A6A050", VA = "0x183A6B050", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B350", Offset = "0x3A6A350", VA = "0x183A6B350", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3A688A0", Offset = "0x3A678A0", VA = "0x183A688A0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3A681B0", Offset = "0x3A671B0", VA = "0x183A681B0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3A67A00", Offset = "0x3A66A00", VA = "0x183A67A00", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3A67190", Offset = "0x3A66190", VA = "0x183A67190", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3A66860", Offset = "0x3A65860", VA = "0x183A66860", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3A65E70", Offset = "0x3A64E70", VA = "0x183A65E70", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3A653C0", Offset = "0x3A643C0", VA = "0x183A653C0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3A64830", Offset = "0x3A63830", VA = "0x183A64830", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x85B9B60", Offset = "0x85B8B60", VA = "0x1885B9B60", Slot = "108")]
		public void RpcMaster(KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3A471F0", Offset = "0x3A461F0", VA = "0x183A471F0", Slot = "109")]
		public void RpcMaster<T1>(KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3A47380", Offset = "0x3A46380", VA = "0x183A47380", Slot = "110")]
		public void RpcMaster<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3A46820", Offset = "0x3A45820", VA = "0x183A46820", Slot = "111")]
		public void RpcMaster<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3A46A80", Offset = "0x3A45A80", VA = "0x183A46A80", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A59640", Offset = "0x3A58640", VA = "0x183A59640", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B650", Offset = "0x3A5A650", VA = "0x183A5B650", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3A53250", Offset = "0x3A52250", VA = "0x183A53250", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A52020", Offset = "0x3A51020", VA = "0x183A52020", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A50100", Offset = "0x3A4F100", VA = "0x183A50100", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A590A0", Offset = "0x3A580A0", VA = "0x183A590A0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A58A80", Offset = "0x3A57A80", VA = "0x183A58A80", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A4C230", Offset = "0x3A4B230", VA = "0x183A4C230", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3A49600", Offset = "0x3A48600", VA = "0x183A49600", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A48600", Offset = "0x3A47600", VA = "0x183A48600", Slot = "122")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x85B9CF0", Offset = "0x85B8CF0", VA = "0x1885B9CF0", Slot = "123")]
		public void RpcMaster(KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A47010", Offset = "0x3A46010", VA = "0x183A47010", Slot = "124")]
		public void RpcMaster<T1>(KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A57FB0", Offset = "0x3A56FB0", VA = "0x183A57FB0", Slot = "125")]
		public void RpcMaster<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A57620", Offset = "0x3A56620", VA = "0x183A57620", Slot = "126")]
		public void RpcMaster<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A55C10", Offset = "0x3A54C10", VA = "0x183A55C10", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A59E10", Offset = "0x3A58E10", VA = "0x183A59E10", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A53AC0", Offset = "0x3A52AC0", VA = "0x183A53AC0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A52990", Offset = "0x3A51990", VA = "0x183A52990", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A51650", Offset = "0x3A50650", VA = "0x183A51650", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A50B70", Offset = "0x3A4FB70", VA = "0x183A50B70", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E990", Offset = "0x3A4D990", VA = "0x183A4E990", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A4DC90", Offset = "0x3A4CC90", VA = "0x183A4DC90", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B410", Offset = "0x3A4A410", VA = "0x183A4B410", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A4D0", Offset = "0x3A494D0", VA = "0x183A4A4D0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3A475A0", Offset = "0x3A465A0", VA = "0x183A475A0", Slot = "137")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x85B99B0", Offset = "0x85B89B0", VA = "0x1885B99B0", Slot = "138")]
		public void RpcAuthority(KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A30610", Offset = "0x3A2F610", VA = "0x183A30610", Slot = "139")]
		public void RpcAuthority<T1>(KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A303E0", Offset = "0x3A2F3E0", VA = "0x183A303E0", Slot = "140")]
		public void RpcAuthority<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A41590", Offset = "0x3A40590", VA = "0x183A41590", Slot = "141")]
		public void RpcAuthority<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A42DB0", Offset = "0x3A41DB0", VA = "0x183A42DB0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A30050", Offset = "0x3A2F050", VA = "0x183A30050", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A3D020", Offset = "0x3A3C020", VA = "0x183A3D020", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C780", Offset = "0x3A3B780", VA = "0x183A3C780", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A3AAF0", Offset = "0x3A39AF0", VA = "0x183A3AAF0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A040", Offset = "0x3A39040", VA = "0x183A3A040", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A38970", Offset = "0x3A37970", VA = "0x183A38970", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A44680", Offset = "0x3A43680", VA = "0x183A44680", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A40D00", Offset = "0x3A3FD00", VA = "0x183A40D00", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A32880", Offset = "0x3A31880", VA = "0x183A32880", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A307C0", Offset = "0x3A2F7C0", VA = "0x183A307C0", Slot = "152")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x85B9750", Offset = "0x85B8750", VA = "0x1885B9750", Slot = "153")]
		public void RpcAuthority(KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A40800", Offset = "0x3A3F800", VA = "0x183A40800", Slot = "154")]
		public void RpcAuthority<T1>(KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A40440", Offset = "0x3A3F440", VA = "0x183A40440", Slot = "155")]
		public void RpcAuthority<T1, T2>(KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A3FC30", Offset = "0x3A3EC30", VA = "0x183A3FC30", Slot = "156")]
		public void RpcAuthority<T1, T2, T3>(KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A3ECA0", Offset = "0x3A3DCA0", VA = "0x183A3ECA0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E5E0", Offset = "0x3A3D5E0", VA = "0x183A3E5E0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A3D7A0", Offset = "0x3A3C7A0", VA = "0x183A3D7A0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BE90", Offset = "0x3A3AE90", VA = "0x183A3BE90", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B490", Offset = "0x3A3A490", VA = "0x183A3B490", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A39530", Offset = "0x3A38530", VA = "0x183A39530", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3A37D50", Offset = "0x3A36D50", VA = "0x183A37D50", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3A37020", Offset = "0x3A36020", VA = "0x183A37020", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3A354F0", Offset = "0x3A344F0", VA = "0x183A354F0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A33790", Offset = "0x3A32790", VA = "0x183A33790", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3A317F0", Offset = "0x3A307F0", VA = "0x183A317F0", Slot = "167")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x85BA310", Offset = "0x85B9310", VA = "0x1885BA310", Slot = "18")]
		public void RpcPlayer(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A6DE80", Offset = "0x3A6CE80", VA = "0x183A6DE80", Slot = "19")]
		public void RpcPlayer<T1>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E250", Offset = "0x3A6D250", VA = "0x183A6E250", Slot = "20")]
		public void RpcPlayer<T1, T2>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3A70980", Offset = "0x3A6F980", VA = "0x183A70980", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A70640", Offset = "0x3A6F640", VA = "0x183A70640", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A83040", Offset = "0x3A82040", VA = "0x183A83040", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A82C40", Offset = "0x3A81C40", VA = "0x183A82C40", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A833C0", Offset = "0x3A823C0", VA = "0x183A833C0", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A83810", Offset = "0x3A82810", VA = "0x183A83810", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3A7BD70", Offset = "0x3A7AD70", VA = "0x183A7BD70", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A690", Offset = "0x3A79690", VA = "0x183A7A690", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3A71220", Offset = "0x3A70220", VA = "0x183A71220", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3A763E0", Offset = "0x3A753E0", VA = "0x183A763E0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3A876D0", Offset = "0x3A866D0", VA = "0x183A876D0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3A73500", Offset = "0x3A72500", VA = "0x183A73500", Slot = "176")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x85BA500", Offset = "0x85B9500", VA = "0x1885BA500", Slot = "177")]
		public void RpcPlayer(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E040", Offset = "0x3A6D040", VA = "0x183A6E040", Slot = "178")]
		public void RpcPlayer<T1>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E4A0", Offset = "0x3A6D4A0", VA = "0x183A6E4A0", Slot = "24")]
		public void RpcPlayer<T1, T2>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A70EF0", Offset = "0x3A6FEF0", VA = "0x183A70EF0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A720E0", Offset = "0x3A710E0", VA = "0x183A720E0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FCB0", Offset = "0x3A7ECB0", VA = "0x183A7FCB0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A7F4D0", Offset = "0x3A7E4D0", VA = "0x183A7F4D0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A7DBC0", Offset = "0x3A7CBC0", VA = "0x183A7DBC0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A7D1C0", Offset = "0x3A7C1C0", VA = "0x183A7D1C0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B250", Offset = "0x3A7A250", VA = "0x183A7B250", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A79A60", Offset = "0x3A78A60", VA = "0x183A79A60", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A78D20", Offset = "0x3A77D20", VA = "0x183A78D20", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3A771E0", Offset = "0x3A761E0", VA = "0x183A771E0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A74540", Offset = "0x3A73540", VA = "0x183A74540", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3A72460", Offset = "0x3A71460", VA = "0x183A72460", Slot = "189")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OVSEBXDBUJS player, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x85B90B0", Offset = "0x85B80B0", VA = "0x1885B90B0", Slot = "190")]
		public void RpcAllBuffered(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3A08DD0", Offset = "0x3A07DD0", VA = "0x183A08DD0", Slot = "191")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3A08B80", Offset = "0x3A07B80", VA = "0x183A08B80", Slot = "192")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3A08870", Offset = "0x3A07870", VA = "0x183A08870", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3A084A0", Offset = "0x3A074A0", VA = "0x183A084A0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3A08010", Offset = "0x3A07010", VA = "0x183A08010", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A07AC0", Offset = "0x3A06AC0", VA = "0x183A07AC0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A074B0", Offset = "0x3A064B0", VA = "0x183A074B0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A06DE0", Offset = "0x3A05DE0", VA = "0x183A06DE0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3A06650", Offset = "0x3A05650", VA = "0x183A06650", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3A05E00", Offset = "0x3A04E00", VA = "0x183A05E00", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3A054F0", Offset = "0x3A044F0", VA = "0x183A054F0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3A04B20", Offset = "0x3A03B20", VA = "0x183A04B20", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3A04090", Offset = "0x3A03090", VA = "0x183A04090", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3A297D0", Offset = "0x3A287D0", VA = "0x183A297D0", Slot = "204")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x85B9010", Offset = "0x85B8010", VA = "0x1885B9010", Slot = "205")]
		public void RpcAllBuffered(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3A08DD0", Offset = "0x3A07DD0", VA = "0x183A08DD0", Slot = "206")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3A08B80", Offset = "0x3A07B80", VA = "0x183A08B80", Slot = "207")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3A08870", Offset = "0x3A07870", VA = "0x183A08870", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3A084A0", Offset = "0x3A074A0", VA = "0x183A084A0", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3A08010", Offset = "0x3A07010", VA = "0x183A08010", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3A07AC0", Offset = "0x3A06AC0", VA = "0x183A07AC0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3A074B0", Offset = "0x3A064B0", VA = "0x183A074B0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3A06DE0", Offset = "0x3A05DE0", VA = "0x183A06DE0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3A06650", Offset = "0x3A05650", VA = "0x183A06650", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3A05E00", Offset = "0x3A04E00", VA = "0x183A05E00", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3A054F0", Offset = "0x3A044F0", VA = "0x183A054F0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3A04B20", Offset = "0x3A03B20", VA = "0x183A04B20", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3A04090", Offset = "0x3A03090", VA = "0x183A04090", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3A297D0", Offset = "0x3A287D0", VA = "0x183A297D0", Slot = "219")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x85B9FD0", Offset = "0x85B8FD0", VA = "0x1885B9FD0", Slot = "220")]
		public void RpcOthersBuffered(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3A64300", Offset = "0x3A63300", VA = "0x183A64300", Slot = "221")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3A640B0", Offset = "0x3A630B0", VA = "0x183A640B0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3A63DA0", Offset = "0x3A62DA0", VA = "0x183A63DA0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3A639D0", Offset = "0x3A629D0", VA = "0x183A639D0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3A63540", Offset = "0x3A62540", VA = "0x183A63540", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3A62FF0", Offset = "0x3A61FF0", VA = "0x183A62FF0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3A629E0", Offset = "0x3A619E0", VA = "0x183A629E0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3A62310", Offset = "0x3A61310", VA = "0x183A62310", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3A61B80", Offset = "0x3A60B80", VA = "0x183A61B80", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3A61330", Offset = "0x3A60330", VA = "0x183A61330", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3A60A20", Offset = "0x3A5FA20", VA = "0x183A60A20", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3A60050", Offset = "0x3A5F050", VA = "0x183A60050", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F5C0", Offset = "0x3A5E5C0", VA = "0x183A5F5C0", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EA60", Offset = "0x3A5DA60", VA = "0x183A5EA60", Slot = "234")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x85B9F30", Offset = "0x85B8F30", VA = "0x1885B9F30", Slot = "235")]
		public void RpcOthersBuffered(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3A64300", Offset = "0x3A63300", VA = "0x183A64300", Slot = "236")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3A640B0", Offset = "0x3A630B0", VA = "0x183A640B0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3A63DA0", Offset = "0x3A62DA0", VA = "0x183A63DA0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3A639D0", Offset = "0x3A629D0", VA = "0x183A639D0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3A63540", Offset = "0x3A62540", VA = "0x183A63540", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3A62FF0", Offset = "0x3A61FF0", VA = "0x183A62FF0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3A629E0", Offset = "0x3A619E0", VA = "0x183A629E0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3A62310", Offset = "0x3A61310", VA = "0x183A62310", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3A61B80", Offset = "0x3A60B80", VA = "0x183A61B80", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3A61330", Offset = "0x3A60330", VA = "0x183A61330", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3A60A20", Offset = "0x3A5FA20", VA = "0x183A60A20", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3A60050", Offset = "0x3A5F050", VA = "0x183A60050", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F5C0", Offset = "0x3A5E5C0", VA = "0x183A5F5C0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EA60", Offset = "0x3A5DA60", VA = "0x183A5EA60", Slot = "249")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KLBPDCHXGBX.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x85B7050", Offset = "0x85B6050", VA = "0x1885B7050", Slot = "250")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x85B7250", Offset = "0x85B6250", VA = "0x1885B7250", Slot = "251")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1503D10", Offset = "0x1502D10", VA = "0x181503D10")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class COSHNWSDJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x85AD990", Offset = "0x85AC990", VA = "0x1885AD990")]
		private static bool IEOIXRSJPTN(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x34E7A40", Offset = "0x34E6A40", VA = "0x1834E7A40")]
		[CanBeNull]
		public static a NRWWAJNWXJV<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class SKFMMGJLHKV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public OVSEBXDBUJS[] ODWASKVTJFQ;

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public SKFMMGJLHKV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x85C4E40", Offset = "0x85C3E40", VA = "0x1885C4E40")]
			internal int CZCYNSDWIHW(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x85C4EC0", Offset = "0x85C3EC0", VA = "0x1885C4EC0")]
			internal void CZIFKYXTRTF(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static OVSEBXDBUJS[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal int XOSVBQSVGXB;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x85BB870", Offset = "0x85BA870", VA = "0x1885BB870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x85BBE50", Offset = "0x85BAE50", VA = "0x1885BBE50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x85BC1D0", Offset = "0x85BB1D0", VA = "0x1885BC1D0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x85BC240", Offset = "0x85BB240", VA = "0x1885BC240")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x85BBE40", Offset = "0x85BAE40", VA = "0x1885BBE40")]
		private void KANQLDEPKUN(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x85BBE40", Offset = "0x85BAE40", VA = "0x1885BBE40")]
		private void WWKBDIVLFIV(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x85BBD50", Offset = "0x85BAD50", VA = "0x1885BBD50")]
		private void EHPAJBIDOMT(OVSEBXDBUJS a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x85BB720", Offset = "0x85BA720", VA = "0x1885BB720")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x85BC2E0", Offset = "0x85BB2E0", VA = "0x1885BC2E0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x85BBC60", Offset = "0x85BAC60", VA = "0x1885BBC60")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xADC3C0", Offset = "0xADB3C0", VA = "0x180ADC3C0")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class VWRXDLECIMT
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x85C5680", Offset = "0x85C4680", VA = "0x1885C5680")]
		public static int EBJQHVBYDHL(this OVSEBXDBUJS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x85C5810", Offset = "0x85C4810", VA = "0x1885C5810")]
		public static void HWIQVLTJJTP(this OVSEBXDBUJS a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class AJTGYGMWSFV
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate void RoomPropertyUpdateCallback(Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void PlayerPropertyUpdateCallback(OVSEBXDBUJS player, Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback IUXNGPECJGT
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x85AD440", Offset = "0x85AC440", VA = "0x1885AD440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x85AD500", Offset = "0x85AC500", VA = "0x1885AD500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback RUEEAZBVYTM
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x85ACFC0", Offset = "0x85ABFC0", VA = "0x1885ACFC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x85AD080", Offset = "0x85AC080", VA = "0x1885AD080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback EJEDLGXLPPX
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x85AD140", Offset = "0x85AC140", VA = "0x1885AD140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x85AD380", Offset = "0x85AC380", VA = "0x1885AD380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback JYWFHBVWFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x85AD2C0", Offset = "0x85AC2C0", VA = "0x1885AD2C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x85AD200", Offset = "0x85AC200", VA = "0x1885AD200")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class LIIDVKNWRWI
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static int LRXYJVGRICC;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static int NJRMVOLVKZS;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static int VRQBACHUHHK;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x85B2D10", Offset = "0x85B1D10", VA = "0x1885B2D10")]
		public static void WOUJFBSJDZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x85B2C30", Offset = "0x85B1C30", VA = "0x1885B2C30")]
		public static void WNDESYDTDCL(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x85B29B0", Offset = "0x85B19B0", VA = "0x1885B29B0")]
		public static int RANQTHHUOWU(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RegisterService(typeof(WVMUMOWZWPW), new string[] { })]
	public class AJKRFGRVSWQ : WVMUMOWZWPW
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Dictionary<object, object> FUTUMARZEJL;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly Dictionary<object, object> QRJPFMJRVER;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly Dictionary<object, object> EHDWIQACUEN;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly XSNAFSFANWP VZJRBETQMQH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly XSNAFSFANWP VFJTJRGEJTA;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly XSNAFSFANWP ETURIWIFGKS;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly XSNAFSFANWP WQVGFLLFFXF;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly XSNAFSFANWP MNAXQJIRKJY;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int JMNPVXJEJZJ;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x85AC680", Offset = "0x85AB680", VA = "0x1885AC680", Slot = "4")]
		public bool YNWTCAOAMVN(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x85AAEF0", Offset = "0x85A9EF0", VA = "0x1885AAEF0", Slot = "5")]
		public int JPOKNXHTBXV(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x85ABC60", Offset = "0x85AAC60", VA = "0x1885ABC60", Slot = "6")]
		public bool MTVDPQTJGCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x85AA720", Offset = "0x85A9720", VA = "0x1885AA720", Slot = "7")]
		public bool AKYAXHOSHDJ(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x85AC470", Offset = "0x85AB470", VA = "0x1885AC470", Slot = "8")]
		public void VLMXMXFZYGG(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x85AB300", Offset = "0x85AA300", VA = "0x1885AB300", Slot = "9")]
		public bool MLKEAMPZPAG(VASLQQLLDVS a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x85AA8D0", Offset = "0x85A98D0", VA = "0x1885AA8D0", Slot = "10")]
		public bool EWIVHDVKPFV(VASLQQLLDVS a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x85AADB0", Offset = "0x85A9DB0", VA = "0x1885AADB0", Slot = "11")]
		public bool IVSOUIEIGUI(VASLQQLLDVS a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x85AC220", Offset = "0x85AB220", VA = "0x1885AC220", Slot = "12")]
		public void UMHVVOVJHDS(VASLQQLLDVS a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x85AABF0", Offset = "0x85A9BF0", VA = "0x1885AABF0", Slot = "13")]
		public void FGYIZBQKROT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85AA5B0", Offset = "0x85A95B0", VA = "0x1885AA5B0", Slot = "14")]
		public void AGIVKCUVLST(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x85AC140", Offset = "0x85AB140", VA = "0x1885AC140", Slot = "15")]
		public void THHJBUWYAWV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x85ABE70", Offset = "0x85AAE70", VA = "0x1885ABE70", Slot = "16")]
		public void SACOMECEVSU(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x85ABF80", Offset = "0x85AAF80", VA = "0x1885ABF80", Slot = "17")]
		public void SJUNSMRRRQG(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x85AC7B0", Offset = "0x85AB7B0", VA = "0x1885AC7B0")]
		private static void ZQHETHSGWAP(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x85AB470", Offset = "0x85AA470", VA = "0x1885AB470")]
		private static bool MLKEAMPZPAG(Dictionary<object, object> a, OVSEBXDBUJS b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x85ABCF0", Offset = "0x85AACF0", VA = "0x1885ABCF0")]
		private static bool NSIHRJRANNT(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x85ABD90", Offset = "0x85AAD90", VA = "0x1885ABD90")]
		private static int PXAZRDAYPIV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public AJKRFGRVSWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RegisterService(typeof(JIKIFDLTYCC), new string[] { })]
	public class ZNDXUMRHAIW : JIKIFDLTYCC
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly object YXVVZSYQYUU;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly object YYBCWZSOIGD;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly object YYGJUGMLRRM;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly object YYLQRNGJBCV;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly object YXAUKRXBNBK;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static Dictionary<object, object> OULXABUOYMO;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static Dictionary<object, object> QANDKLPDBOZ;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static XSNAFSFANWP GMRGCEWVJUY;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly XSNAFSFANWP SQIGMRSOUFL;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x85C7F50", Offset = "0x85C6F50", VA = "0x1885C7F50", Slot = "4")]
		public void TQJOIYYWNSG(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x85C73C0", Offset = "0x85C63C0", VA = "0x1885C73C0", Slot = "5")]
		public bool CPZWEFKBTFA(VASLQQLLDVS a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x85C78A0", Offset = "0x85C68A0", VA = "0x1885C78A0", Slot = "6")]
		public void MYVRKSBHZGI(ViewId a, string b, RpcTarget c, OVSEBXDBUJS d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ZNDXUMRHAIW()
		{
		}
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
