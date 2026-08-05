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
		[Cpp2IlInjected.Address(RVA = "0x8465A70", Offset = "0x8464470", VA = "0x188465A70", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		private int[] TVXWIVSLKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] TVSPLOYOBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EJWMBZOWMVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset EKBSZGITWGJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F321F0", Offset = "0x1F30BF0", VA = "0x181F321F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8473C10", Offset = "0x8472610", VA = "0x188473C10")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8474120", Offset = "0x8472B20", VA = "0x188474120")]
		private void ANXAERWSNVX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8474380", Offset = "0x8472D80", VA = "0x188474380", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8474430", Offset = "0x8472E30", VA = "0x188474430")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class UNCYEDTOEMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log JUZKUUELVXI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log PNUXRBJESND
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8473690", Offset = "0x8472090", VA = "0x188473690")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface SWJFQMQXLSK
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView MFEJFLHFAPV
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType JEKVFLYJMYE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool CYLLTPBTDFT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "2")]
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
	internal interface GYHQXHTJSPQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IYZDKEVKYNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WNBADTQLDFB(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface CWYXLPPOPSB : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JIBLBJTHOBM(SWJFQMQXLSK a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KBLBKORKNFH(SWJFQMQXLSK a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(LMTUKNOEKUK.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AHPOIFQISDS();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YMRXESXMUGP(object a);
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
	public class DPHCSCGVDXK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), GYHQXHTJSPQ> TALIBWVMAVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<SWJFQMQXLSK> SVXZJHSIIHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> ODNMMMYYMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int HHYMZHGRRTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool KNKTFWWPQGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private LMTUKNOEKUK.ApplyNetworkTransform BJGRJYUGLJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream RHJVKJRQWUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker QUCCVNKGKSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker NPBURDANUXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] BPZLPSRRMSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float WLNIWPPBASY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int NKSOUXRBZNU;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8460AC0", Offset = "0x845F4C0", VA = "0x188460AC0")]
		public DPHCSCGVDXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8460530", Offset = "0x845EF30", VA = "0x188460530")]
		public void Pause(LMTUKNOEKUK.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x845F600", Offset = "0x845E000", VA = "0x18845F600")]
		public void AHPOIFQISDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84606E0", Offset = "0x845F0E0", VA = "0x1884606E0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x845F650", Offset = "0x845E050", VA = "0x18845F650")]
		public bool Add(SWJFQMQXLSK networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8460550", Offset = "0x845EF50", VA = "0x188460550")]
		public bool Remove(SWJFQMQXLSK networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8460300", Offset = "0x845ED00", VA = "0x188460300")]
		private GYHQXHTJSPQ IDOMPEZPQGZ(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8460AB0", Offset = "0x845F4B0", VA = "0x188460AB0")]
		public void ZUUPRTQGSMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8460680", Offset = "0x845F080", VA = "0x188460680")]
		private void TRQHOKRCBFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8460510", Offset = "0x845EF10", VA = "0x188460510")]
		private void KWBNVUQUGGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x845FB60", Offset = "0x845E560", VA = "0x18845FB60")]
		public bool DBIZAVDXMHZ(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x845FF10", Offset = "0x845E910", VA = "0x18845FF10")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class JXOVQNEUUHJ : GYHQXHTJSPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private SWJFQMQXLSK XSHODABNMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint YEUMXRXDORY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int KZKHIQRCXMX;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IYZDKEVKYNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public JXOVQNEUUHJ(SWJFQMQXLSK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8465160", Offset = "0x8463B60", VA = "0x188465160", Slot = "5")]
		public bool WNBADTQLDFB(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8465080", Offset = "0x8463A80", VA = "0x188465080", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class JOJUDDQZKLC : GYHQXHTJSPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private LMTUKNOEKUK.ApplyNetworkTransform BJGRJYUGLJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId EEBXDPDUFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int KZKHIQRCXMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint YEUMXRXDORY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IYZDKEVKYNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1A295C0", Offset = "0x1A27FC0", VA = "0x181A295C0")]
		public JOJUDDQZKLC(ViewId a, LMTUKNOEKUK.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8465040", Offset = "0x8463A40", VA = "0x188465040", Slot = "5")]
		public bool WNBADTQLDFB(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8464E60", Offset = "0x8463860", VA = "0x188464E60", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ALTYELHJNIU
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8456970", Offset = "0x8455370", VA = "0x188456970")]
		public static void JVPEYACKYLR(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8455F50", Offset = "0x8454950", VA = "0x188455F50")]
		public static void DRNICORZPZI(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8456450", Offset = "0x8454E50", VA = "0x188456450")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84565C0", Offset = "0x8454FC0", VA = "0x1884565C0")]
		public static void IVVRNASEOUH(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(CWYXLPPOPSB), new string[] { })]
	public class POISQUANAKA : CWYXLPPOPSB, INetworkUpdateSystem, QSRIFETEKVI, XVYQGXFPXEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log SJCOIICRAJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private DPHCSCGVDXK VXZAFHZFQNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint HVIZMNCJVRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float NLOPKQCFRVW;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8468B40", Offset = "0x8467540", VA = "0x188468B40", Slot = "4")]
		public void JIBLBJTHOBM(SWJFQMQXLSK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8468C60", Offset = "0x8467660", VA = "0x188468C60", Slot = "5")]
		public void KBLBKORKNFH(SWJFQMQXLSK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84689F0", Offset = "0x84673F0", VA = "0x1884689F0", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8468E60", Offset = "0x8467860", VA = "0x188468E60", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8468F10", Offset = "0x8467910", VA = "0x188468F10")]
		private void YAKNXCTUGOA(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8468EE0", Offset = "0x84678E0", VA = "0x188468EE0", Slot = "6")]
		public void Pause(LMTUKNOEKUK.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84684E0", Offset = "0x8466EE0", VA = "0x1884684E0", Slot = "7")]
		public void AHPOIFQISDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8469520", Offset = "0x8467F20", VA = "0x188469520", Slot = "8")]
		public void YMRXESXMUGP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8468660", Offset = "0x8467060", VA = "0x188468660")]
		private void CBQQHQMHGPE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8468540", Offset = "0x8466F40", VA = "0x188468540", Slot = "11")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8469580", Offset = "0x8467F80", VA = "0x188469580")]
		public POISQUANAKA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EQBBWPBERYG : GYHQXHTJSPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float EASLHLENSXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int KZKHIQRCXMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint YEUMXRXDORY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType WRCIZHFZNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo UOSFQBPQTFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int LGASHLFZGHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] NZPFXIFJGKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo VQFCPICHTLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int BIGVRRPMMXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] YUPQNGXGZSY;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IYZDKEVKYNO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8461170", Offset = "0x845FB70", VA = "0x188461170", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84611A0", Offset = "0x845FBA0", VA = "0x1884611A0")]
		public EQBBWPBERYG(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8461130", Offset = "0x845FB30", VA = "0x188461130", Slot = "5")]
		public bool WNBADTQLDFB(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8460CB0", Offset = "0x845F6B0", VA = "0x188460CB0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8460E60", Offset = "0x845F860", VA = "0x188460E60")]
		internal JXOVQNEUUHJ SCOOGVFQJBY(SWJFQMQXLSK a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8460F60", Offset = "0x845F960", VA = "0x188460F60")]
		private static void TYZFITOXVFG(JXOVQNEUUHJ a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class WAUOGVJLVWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8473740", Offset = "0x8472140", VA = "0x188473740")]
		public static RHIZVYSCBOY HLSSGVIUYVG(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84737D0", Offset = "0x84721D0", VA = "0x1884737D0")]
		public static PlayerId ToPlayerId(this RHIZVYSCBOY player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RRNetworkBehavior : MonoBehaviour, YXCJTLIQRXC, GPQEQALGKDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool JVVPPYQVSVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private RRNetworkView WRLTTSMXPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<UNSAYDJFQCJ> XJZPXWJWKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FADXRESSMCD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId NUXFNOEWMXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8469FC0", Offset = "0x84689C0", VA = "0x188469FC0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId QNYDEQJWDXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8469FC0", Offset = "0x84689C0", VA = "0x188469FC0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView HIWFAXHKEEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x846A040", Offset = "0x8468A40", VA = "0x18846A040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView MFEJFLHFAPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x846A040", Offset = "0x8468A40", VA = "0x18846A040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RHIZVYSCBOY YCAGPJHWGBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x846A140", Offset = "0x8468B40", VA = "0x18846A140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RHIZVYSCBOY IAKYPZPNSRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x846A4A0", Offset = "0x8468EA0", VA = "0x18846A4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool REJWXANXIRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x846A2A0", Offset = "0x8468CA0", VA = "0x18846A2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HNZBBORMKZW
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x846A410", Offset = "0x8468E10", VA = "0x18846A410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OUTXDSEQKSW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8469EF0", Offset = "0x84688F0", VA = "0x188469EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool SRYOYMNMKVA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x846A1D0", Offset = "0x8468BD0", VA = "0x18846A1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KLYIAAEMXPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8469EF0", Offset = "0x84688F0", VA = "0x188469EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LHYUNIINVRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8469F70", Offset = "0x8468970", VA = "0x188469F70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string PJTKIJZTVAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x846A0B0", Offset = "0x8468AB0", VA = "0x18846A0B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MZBGYDVMOZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8469E70", Offset = "0x8468870", VA = "0x188469E70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RHIZVYSCBOY> UGYMNRFFUXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8469D40", Offset = "0x8468740", VA = "0x188469D40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x846A530", Offset = "0x8468F30", VA = "0x18846A530")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8469CA0", Offset = "0x84686A0", VA = "0x188469CA0")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8469880", Offset = "0x8468280", VA = "0x188469880")]
		private void PCLHFZZFJYQ(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84698A0", Offset = "0x84682A0", VA = "0x1884698A0", Slot = "9")]
		public void RegisterDestroyHandler(UNSAYDJFQCJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8469AE0", Offset = "0x84684E0", VA = "0x188469AE0", Slot = "10")]
		public void UnregisterDestroyHandler(UNSAYDJFQCJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8469860", Offset = "0x8468260", VA = "0x188469860", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MXXLYVYEIEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, RHIZVYSCBOY targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, RHIZVYSCBOY targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, RHIZVYSCBOY newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[CompilerGenerated]
		private static InstantiateCallback PCRCTHEVSAW;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback DTEFYTEEYAP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8466680", Offset = "0x8465080", VA = "0x188466680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8466B80", Offset = "0x8465580", VA = "0x188466B80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback XOHMDSSYAQH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8466D00", Offset = "0x8465700", VA = "0x188466D00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8466980", Offset = "0x8465380", VA = "0x188466980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback PDZVWBCPXHD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8466E50", Offset = "0x8465850", VA = "0x188466E50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8466FD0", Offset = "0x84659D0", VA = "0x188466FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback BIICECYWUVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8466800", Offset = "0x8465200", VA = "0x188466800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8466220", Offset = "0x8464C20", VA = "0x188466220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback MVRDVGLCESK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8466740", Offset = "0x8465140", VA = "0x188466740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8466C40", Offset = "0x8465640", VA = "0x188466C40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback ADANAHYCBLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x84662E0", Offset = "0x8464CE0", VA = "0x1884662E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x84660A0", Offset = "0x8464AA0", VA = "0x1884660A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback RHSDTZQXELH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84668C0", Offset = "0x84652C0", VA = "0x1884668C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84665C0", Offset = "0x8464FC0", VA = "0x1884665C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler YXTSILWJNUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8465FE0", Offset = "0x84649E0", VA = "0x188465FE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8466160", Offset = "0x8464B60", VA = "0x188466160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler UBYCNSELLBS
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8466F10", Offset = "0x8465910", VA = "0x188466F10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8465E60", Offset = "0x8464860", VA = "0x188465E60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8465F20", Offset = "0x8464920", VA = "0x188465F20")]
		public static void CPHWOQVYDEM([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8466DC0", Offset = "0x84657C0", VA = "0x188466DC0")]
		public static void UYAFRYFDEMG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8465C80", Offset = "0x8464680", VA = "0x188465C80")]
		public static void AONFDJLVQKZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8466530", Offset = "0x8464F30", VA = "0x188466530")]
		public static void LEAUHTBIKBK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84664A0", Offset = "0x8464EA0", VA = "0x1884664A0")]
		public static void KAHTAOKJEUL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8465D10", Offset = "0x8464710", VA = "0x188465D10")]
		public static void AXIGHSNAEVR(RRNetworkView a, string b, RHIZVYSCBOY c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8466A40", Offset = "0x8465440", VA = "0x188466A40")]
		public static void RPZEGRDVJUW(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84663A0", Offset = "0x8464DA0", VA = "0x1884663A0")]
		public static void JZPMBGAJRVQ(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class LIXMVYPJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84658E0", Offset = "0x84642E0", VA = "0x1884658E0")]
		[CanBeNull]
		private static bool KSSMJXIQUUX(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8465990", Offset = "0x8464390", VA = "0x188465990")]
		[CanBeNull]
		public static Component NNVZFDGPLRJ(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3761BB0", Offset = "0x37605B0", VA = "0x183761BB0")]
		[CanBeNull]
		public static a NNVZFDGPLRJ<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3761D60", Offset = "0x3760760", VA = "0x183761D60")]
		[CanBeNull]
		public static b RXNSEKYXFFF<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3761CD0", Offset = "0x37606D0", VA = "0x183761CD0")]
		public static bool POBZRGHYDRM<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8465870", Offset = "0x8464270", VA = "0x188465870")]
		[CanBeNull]
		public static RRNetworkView ANCAEIBCRVM(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static RRNetworkHandler OCBBNXVVYII;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x846A660", Offset = "0x8469060", VA = "0x18846A660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x846A810", Offset = "0x8469210", VA = "0x18846A810")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x846A7D0", Offset = "0x84691D0", VA = "0x18846A7D0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RegisterService(typeof(BGWAUNMGNEP), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class BGWAUNMGNEP : OQNXQJTKCPY, QSRIFETEKVI, XVYQGXFPXEO, PFYTZJIIFSI, TNWCTSLULIM, TTDQLFCDEXA, TFZKCIODVYK
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class HXGPKBFCMYE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int QRVGXNXYGYF;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public HXGPKBFCMYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8461210", Offset = "0x845FC10", VA = "0x188461210")]
			internal object GRKUPZAXIHY((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static Log NWNGMXSRMKG;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static Log ZDUYAJTTITI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private BNQAORQQDQJ IRVIDEWZIXQ;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<int, HashSet<int>> ZIOGBQDWDSE;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static Dictionary<int, int> ZBDIFNKHMKV;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly List<(GameObject GameObject, int ParentCount)> JJIUGRMYGOE;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly List<GameObject> TTZZXLQYTSJ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static List<int> NYBMHEPPKSL;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly List<RRNetworkView> UWEHPRZTNVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FRWOCALBUOM ZCFRLVLDAFR;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly TGLBYERUDJN ZRQCLUWZKJR;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly TGLBYERUDJN DWKPWPWPTFY;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x845A840", Offset = "0x8459240", VA = "0x18845A840", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8457430", Offset = "0x8455E30", VA = "0x188457430", Slot = "9")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x845A730", Offset = "0x8459130", VA = "0x18845A730", Slot = "10")]
		public void InitExternal(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x845C3B0", Offset = "0x845ADB0", VA = "0x18845C3B0", Slot = "11")]
		public void OINRTVSEBTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8458C70", Offset = "0x8457670", VA = "0x188458C70")]
		private void DCOUYDNIKPK(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x845C4A0", Offset = "0x845AEA0", VA = "0x18845C4A0")]
		public GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8457770", Offset = "0x8456170", VA = "0x188457770")]
		public GameObject BYIMWJMKMSR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8459E90", Offset = "0x8458890", VA = "0x188459E90")]
		public GameObject HVFLYDJDGRK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x845DFB0", Offset = "0x845C9B0", VA = "0x18845DFB0")]
		public GameObject TGBMEVFUOLQ(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8459C40", Offset = "0x8458640", VA = "0x188459C40", Slot = "6")]
		public void FXNLMHIJMYS(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x845D070", Offset = "0x845BA70", VA = "0x18845D070")]
		public void RFVZPLGLMBB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x845CB20", Offset = "0x845B520", VA = "0x18845CB20", Slot = "7")]
		public void PHEBUFUYYQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x845ABE0", Offset = "0x84595E0", VA = "0x18845ABE0", Slot = "4")]
		public GameObject[] KQMOPPPQLKA(IList<MOFTTNXWVKL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x845A390", Offset = "0x8458D90", VA = "0x18845A390", Slot = "5")]
		public void IMNKTNEZVMP(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x845AF00", Offset = "0x8459900", VA = "0x18845AF00")]
		public void LCHQJSVARHD(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84586E0", Offset = "0x84570E0", VA = "0x1884586E0")]
		private void CBQQHQMHGPE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x845D640", Offset = "0x845C040", VA = "0x18845D640")]
		private void SBWNDUJIYFK(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8459C50", Offset = "0x8458650", VA = "0x188459C50")]
		private void GWUSTCDSKRY(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x845A110", Offset = "0x8458B10", VA = "0x18845A110")]
		private void IHSPLDJOOAS(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8456F40", Offset = "0x8455940", VA = "0x188456F40")]
		private void BFKZFQGUSBE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8459830", Offset = "0x8458230", VA = "0x188459830")]
		private void FKDLNFQRNAG(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x845E330", Offset = "0x845CD30", VA = "0x18845E330")]
		private void YATGMJTMIUU(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x845E0E0", Offset = "0x845CAE0", VA = "0x18845E0E0")]
		private GameObject WJNALVMQPWD(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x845D8B0", Offset = "0x845C2B0", VA = "0x18845D8B0")]
		private GameObject SVFHTZEAPKZ(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84597B0", Offset = "0x84581B0", VA = "0x1884597B0")]
		private static GameObject FGDIMUCPOVJ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x845E8F0", Offset = "0x845D2F0", VA = "0x18845E8F0")]
		private static GameObject YOOMJPWDMVU(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8457320", Offset = "0x8455D20", VA = "0x188457320")]
		private static void BNCHJWFGVGJ(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x845AFE0", Offset = "0x84599E0", VA = "0x18845AFE0")]
		private GameObject[] NZKAWUEQZFC(IList<MOFTTNXWVKL> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84589B0", Offset = "0x84573B0", VA = "0x1884589B0")]
		private GameObject[] CZSNUVBZAHU(InstantiateParameters[] a, int b, RHIZVYSCBOY c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x845CC70", Offset = "0x845B670", VA = "0x18845CC70")]
		private GameObject QZJTEPTVJGY([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8456B30", Offset = "0x8455530", VA = "0x188456B30")]
		private static bool AJKUCYTRMXP(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x845B7D0", Offset = "0x845A1D0", VA = "0x18845B7D0")]
		private void OIEEQGDDUNT(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8457860", Offset = "0x8456260", VA = "0x188457860")]
		private void CBLVCJAFJVL(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8456B50", Offset = "0x8455550", VA = "0x188456B50")]
		private static void AJQTUYVUSNO(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x845CB30", Offset = "0x845B530", VA = "0x18845CB30")]
		private void QRAROONWBWA(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x845C670", Offset = "0x845B070", VA = "0x18845C670")]
		private static int OOMMDTDZISM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x845AB80", Offset = "0x8459580", VA = "0x18845AB80")]
		private void KPIONIAKHGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x845D0E0", Offset = "0x845BAE0", VA = "0x18845D0E0")]
		private void RGSVHAJUJUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x845E2D0", Offset = "0x845CCD0", VA = "0x18845E2D0")]
		private static int WYAAZNZGYPG(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x845D7D0", Offset = "0x845C1D0", VA = "0x18845D7D0")]
		private static int[] SJSNLEAIEEN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x845C710", Offset = "0x845B110", VA = "0x18845C710")]
		private static int[] OPZGUFJBAKR(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x845CAE0", Offset = "0x845B4E0", VA = "0x18845CAE0")]
		private void OnMasterClientSwitched(RHIZVYSCBOY newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8458CE0", Offset = "0x84576E0", VA = "0x188458CE0")]
		private void DOLLZZBYIHP(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x845C810", Offset = "0x845B210", VA = "0x18845C810")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8459A00", Offset = "0x8458400", VA = "0x188459A00")]
		private void FQQDEJPCUPH(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x845EB00", Offset = "0x845D500", VA = "0x18845EB00")]
		private static void ZAYKGRNVYIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x845DFE0", Offset = "0x845C9E0", VA = "0x18845DFE0")]
		private void VJIACRPIGSL(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8459760", Offset = "0x8458160", VA = "0x188459760", Slot = "12")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCB03D0", Offset = "0xCAEDD0", VA = "0x180CB03D0", Slot = "13")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public BGWAUNMGNEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RegisterService(typeof(IRGQDYIKGND), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class IRGQDYIKGND : QSRIFETEKVI, XVYQGXFPXEO, DWTGDEAVLNW, IPQERUQWVJD, EEYQRLXJBSJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct RpcMethodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public readonly MethodInfo methodInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly Func<MonoBehaviour, object> accessor;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x84704E0", Offset = "0x846EEE0", VA = "0x1884704E0")]
			public object MLKCNJIJFVF(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class TXCIFAKKTSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public FieldInfo KDHLQANOZGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<MonoBehaviour, object> VRHIMZSTVPN;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public TXCIFAKKTSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8470500", Offset = "0x846EF00", VA = "0x188470500")]
			internal RpcMethodInfo CJMHSWJEKEF(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5138D00", Offset = "0x5137700", VA = "0x185138D00")]
			internal object CJHAVPPHASW(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class TXHPCHEIDDX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Func<MonoBehaviour, object> WJLLVRRJSQA;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public TXHPCHEIDDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x84705C0", Offset = "0x846EFC0", VA = "0x1884705C0")]
			internal RpcMethodInfo CIBLMAZWWCU(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class YJGILQXVTGT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Type QAUVAWKKUVP;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public YJGILQXVTGT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8473820", Offset = "0x8472220", VA = "0x188473820")]
			internal bool PVFVCXLBDIJ(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static Dictionary<string, int> FQJCOBESVPX;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static List<string> ILCRZCGLBIA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static int KNQZDHQKOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CQBVWYKCFEO FCRXKAGRSDD;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Stopwatch KFTWMXJVCFL;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static Dictionary<MethodInfo, ParameterInfo[]> DHTTOUUJRFS;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> DTJWFAOXFDZ;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8462010", Offset = "0x8460A10", VA = "0x188462010", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84638A0", Offset = "0x84622A0", VA = "0x1884638A0")]
		private void OFMZRIJSWGO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8462160", Offset = "0x8460B60", VA = "0x188462160", Slot = "10")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xCB03D0", Offset = "0xCAEDD0", VA = "0x180CB03D0", Slot = "11")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84614E0", Offset = "0x845FEE0", VA = "0x1884614E0", Slot = "5")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84641C0", Offset = "0x8462BC0", VA = "0x1884641C0")]
		public static bool TBCRZWKQSGT(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84637C0", Offset = "0x84621C0", VA = "0x1884637C0")]
		public static bool LGGFEUFFQCD(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8461630", Offset = "0x8460030", VA = "0x188461630")]
		private void CBQQHQMHGPE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8464250", Offset = "0x8462C50", VA = "0x188464250", Slot = "9")]
		public string TTHLELOONQR(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8461F60", Offset = "0x8460960", VA = "0x188461F60", Slot = "8")]
		public void IINMLGXJFGC(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8461E90", Offset = "0x8460890", VA = "0x188461E90", Slot = "6")]
		public void HYADYLYDQOK(ViewId a, string b, RHIZVYSCBOY c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8461E60", Offset = "0x8460860", VA = "0x188461E60", Slot = "7")]
		public void HYADYLYDQOK(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84619B0", Offset = "0x84603B0", VA = "0x1884619B0")]
		private void HYADYLYDQOK(ViewId a, string b, RpcTarget c, RHIZVYSCBOY d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x84621B0", Offset = "0x8460BB0", VA = "0x1884621B0")]
		private void JLUEDTGHHZX(ViewId a, string b, RHIZVYSCBOY c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8463D30", Offset = "0x8462730", VA = "0x188463D30")]
		private static void PHOGQXTEKZR(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x84612D0", Offset = "0x845FCD0", VA = "0x1884612D0")]
		private static bool BHKTECXPOSK(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8464280", Offset = "0x8462C80", VA = "0x188464280")]
		private List<RpcMethodInfo> VZJKPIKDHCJ(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84618B0", Offset = "0x84602B0", VA = "0x1884618B0")]
		private static IEnumerable<MethodInfo> CUQXMULZDSX(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8464B10", Offset = "0x8463510", VA = "0x188464B10")]
		public static ParameterInfo[] ZYDEFTLUCQP(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public IRGQDYIKGND()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[TooltipAttribute("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x846A8D0", Offset = "0x84692D0", VA = "0x18846A8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x846A850", Offset = "0x8469250", VA = "0x18846A850")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RRNetworkView : MonoBehaviour, DKIETDLJBYJ, YILDGXFKBSK, WDTOYYFEYVF, ZHZKZDOVLTT, FTVZVRKLTVG
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[RegisterService(typeof(BNQAORQQDQJ), new string[] { })]
		internal class OJHNPJGNYPA : QSRIFETEKVI, XVYQGXFPXEO, BNQAORQQDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Dictionary<int, RRNetworkView> WHCQUBMZACL;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x84680B0", Offset = "0x8466AB0", VA = "0x1884680B0", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x84680B0", Offset = "0x8466AB0", VA = "0x1884680B0", Slot = "5")]
			public void BTTVCOLODYQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x84680C0", Offset = "0x8466AC0", VA = "0x1884680C0", Slot = "6")]
			public void ZNQVMXLECIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public OJHNPJGNYPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum HasExplicitViewId
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class PBZSWMUOFRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public int YHAOJACMJUN;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PBZSWMUOFRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x8468480", Offset = "0x8466E80", VA = "0x188468480")]
			internal bool TIYFXARRGGX(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static TGLBYERUDJN GHNTLBDZRIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool RGXKKMGJGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool BTSTTVYPAXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool JUELXQHHFYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int JIWQLFKPAVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool GSKLULIRPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int PGOYACSZDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private RHIZVYSCBOY IAKYPZPNSRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RHIZVYSCBOY RNAEXXFWVED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private bool? ATAHIPEELFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool JDGWHXJJHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		internal bool BHXTVEJILKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal MonoBehaviour[] XSYVZECXATL;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly Log COLYXJNWQGS;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> WHCQUBMZACL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x846B690", Offset = "0x846A090", VA = "0x18846B690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId QNYDEQJWDXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x846EEE0", Offset = "0x846D8E0", VA = "0x18846EEE0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId RBVXVZPLUQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x846EEE0", Offset = "0x846D8E0", VA = "0x18846EEE0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId NUXFNOEWMXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x846EEE0", Offset = "0x846D8E0", VA = "0x18846EEE0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int RIIKMICFKPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int DHVEXGEEYMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId KJBLQWJMSRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x846ED50", Offset = "0x846D750", VA = "0x18846ED50")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HCOTHNEAPUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F30", Offset = "0xCB1930", VA = "0x180CB2F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool LZHUPPLTFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x846ED60", Offset = "0x846D760", VA = "0x18846ED60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool PRTJBJEVGKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4D0", Offset = "0xB18ED0", VA = "0x180B1A4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int XQBIGACLWWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int NLJSZGLTHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x846ECF0", Offset = "0x846D6F0", VA = "0x18846ECF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RHIZVYSCBOY KUVXXYXLJUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x846EEF0", Offset = "0x846D8F0", VA = "0x18846EEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public RHIZVYSCBOY YNHMGNTGALB
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x846ECC0", Offset = "0x846D6C0", VA = "0x18846ECC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RHIZVYSCBOY YCAGPJHWGBW
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x846ECC0", Offset = "0x846D6C0", VA = "0x18846ECC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public RHIZVYSCBOY KZVOCWQWMFG
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x846ECC0", Offset = "0x846D6C0", VA = "0x18846ECC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool SFZEOHARSQU
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x846EE30", Offset = "0x846D830", VA = "0x18846EE30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int YQRWIQZVNWG
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x846ED20", Offset = "0x846D720", VA = "0x18846ED20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] PTDQJUSIVJK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool REJWXANXIRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x846EF20", Offset = "0x846D920", VA = "0x18846EF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool THXSWCEEJVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x846EEB0", Offset = "0x846D8B0", VA = "0x18846EEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xCF6EF0", Offset = "0xCF58F0", VA = "0x180CF6EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xCF6F00", Offset = "0xCF5900", VA = "0x180CF6F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6720", Offset = "0xCF5120", VA = "0x180CF6720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> SQIMOXBVVQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x846EB50", Offset = "0x846D550", VA = "0x18846EB50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x846F0E0", Offset = "0x846DAE0", VA = "0x18846F0E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<RHIZVYSCBOY> UAPATPYSPXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x846B9C0", Offset = "0x846A3C0", VA = "0x18846B9C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x846C6A0", Offset = "0x846B0A0", VA = "0x18846C6A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<RHIZVYSCBOY> JLJEGJSZYOT
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x846B9C0", Offset = "0x846A3C0", VA = "0x18846B9C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x846C6A0", Offset = "0x846B0A0", VA = "0x18846C6A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> XXSTVRPBZVA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x846B740", Offset = "0x846A140", VA = "0x18846B740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x846C760", Offset = "0x846B160", VA = "0x18846C760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> ENPEFUQVFTU
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x846B740", Offset = "0x846A140", VA = "0x18846B740")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x846C760", Offset = "0x846B160", VA = "0x18846C760")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> YCPAYDSRNHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x846EC00", Offset = "0x846D600", VA = "0x18846EC00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x846F190", Offset = "0x846DB90", VA = "0x18846F190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action DRTLJCALEEI
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x846EAA0", Offset = "0x846D4A0", VA = "0x18846EAA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x846F030", Offset = "0x846DA30", VA = "0x18846F030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x846E810", Offset = "0x846D210", VA = "0x18846E810")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x846B310", Offset = "0x8469D10", VA = "0x18846B310")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x846B470", Offset = "0x8469E70", VA = "0x18846B470")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x846B3D0", Offset = "0x8469DD0", VA = "0x18846B3D0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x846CC60", Offset = "0x846B660", VA = "0x18846CC60")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x846CA00", Offset = "0x846B400", VA = "0x18846CA00")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x846C330", Offset = "0x846AD30", VA = "0x18846C330")]
		public static void OnPlayerJoinedRoom(RHIZVYSCBOY newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x846B5D0", Offset = "0x8469FD0", VA = "0x18846B5D0")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x846B630", Offset = "0x846A030", VA = "0x18846B630")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x846C070", Offset = "0x846AA70", VA = "0x18846C070")]
		private void OBLPFJODNRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x846B010", Offset = "0x8469A10", VA = "0x18846B010")]
		public bool CreatedBy(RHIZVYSCBOY player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x846E630", Offset = "0x846D030", VA = "0x18846E630")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x846E5D0", Offset = "0x846CFD0", VA = "0x18846E5D0")]
		public void TransferOwnership(RHIZVYSCBOY newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x846B850", Offset = "0x846A250", VA = "0x18846B850", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x846B7F0", Offset = "0x846A1F0", VA = "0x18846B7F0")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x846AA30", Offset = "0x8469430", VA = "0x18846AA30")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x846AB50", Offset = "0x8469550", VA = "0x18846AB50")]
		private void CURVMWTUQPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x111AAB0", Offset = "0x11194B0", VA = "0x18111AAB0")]
		internal void NOMWEAMFCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x846AAF0", Offset = "0x84694F0", VA = "0x18846AAF0", Slot = "6")]
		private void CGYYJIJTCPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x846BA70", Offset = "0x846A470", VA = "0x18846BA70")]
		internal bool KSIPPLTJFMX(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x846C1F0", Offset = "0x846ABF0", VA = "0x18846C1F0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x846B6E0", Offset = "0x846A0E0", VA = "0x18846B6E0")]
		internal void HZUINWXMEVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x846C750", Offset = "0x846B150", VA = "0x18846C750")]
		private void RBNZUSRAFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x846B090", Offset = "0x8469A90", VA = "0x18846B090")]
		internal void DIYDQWWDMVP(RHIZVYSCBOY a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x846CBC0", Offset = "0x846B5C0", VA = "0x18846CBC0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x846CD10", Offset = "0x846B710", VA = "0x18846CD10")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x846BFD0", Offset = "0x846A9D0", VA = "0x18846BFD0")]
		private void NYAXMJESJPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x846BAE0", Offset = "0x846A4E0", VA = "0x18846BAE0")]
		private void LMKXDPNXIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x846C8E0", Offset = "0x846B2E0", VA = "0x18846C8E0")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x846C970", Offset = "0x846B370", VA = "0x18846C970")]
		public void RPC(string methodName, RHIZVYSCBOY targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x846CC10", Offset = "0x846B610", VA = "0x18846CC10")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x846AA80", Offset = "0x8469480", VA = "0x18846AA80", Slot = "8")]
		public void Bake(WQKTEDFFTLA context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x846E8D0", Offset = "0x846D2D0", VA = "0x18846E8D0")]
		private static void UIHSUTNKFYE(RHIZVYSCBOY a, [Out] RHIZVYSCBOY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x846BBD0", Offset = "0x846A5D0", VA = "0x18846BBD0")]
		private static void LRWHPZDIEZN(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x846C150", Offset = "0x846AB50", VA = "0x18846C150")]
		private static RPCInfo OHOIVVEFMCS(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x846B150", Offset = "0x8469B50", VA = "0x18846B150")]
		private static void EBAOGRWPCPO(RRNetworkView a, Delegate b, RHIZVYSCBOY c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x846B230", Offset = "0x8469C30", VA = "0x18846B230")]
		private static void EBAOGRWPCPO(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x846BEC0", Offset = "0x846A8C0", VA = "0x18846BEC0")]
		private static void MAKHTJGVITZ(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x846C810", Offset = "0x846B210", VA = "0x18846C810")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x846E940", Offset = "0x846D340", VA = "0x18846E940")]
		private static bool WQAJKSDFCGY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x846D3F0", Offset = "0x846BDF0", VA = "0x18846D3F0", Slot = "25")]
		public void RpcAll(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x398C380", Offset = "0x398AD80", VA = "0x18398C380", Slot = "9")]
		public void RpcAll<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x398BF70", Offset = "0x398A970", VA = "0x18398BF70", Slot = "10")]
		public void RpcAll<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x398C9E0", Offset = "0x398B3E0", VA = "0x18398C9E0", Slot = "26")]
		public void RpcAll<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x399EB00", Offset = "0x399D500", VA = "0x18399EB00", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x399F2B0", Offset = "0x399DCB0", VA = "0x18399F2B0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x39A0800", Offset = "0x399F200", VA = "0x1839A0800", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x399EE00", Offset = "0x399D800", VA = "0x18399EE00", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x39B1D00", Offset = "0x39B0700", VA = "0x1839B1D00", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x39A0C20", Offset = "0x399F620", VA = "0x1839A0C20", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x399FE50", Offset = "0x399E850", VA = "0x18399FE50", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x39B4B40", Offset = "0x39B3540", VA = "0x1839B4B40", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x39B0910", Offset = "0x39AF310", VA = "0x1839B0910", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x39A4560", Offset = "0x39A2F60", VA = "0x1839A4560", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x399F6A0", Offset = "0x399E0A0", VA = "0x18399F6A0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x846D1C0", Offset = "0x846BBC0", VA = "0x18846D1C0", Slot = "35")]
		public void RpcAll(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x398ED70", Offset = "0x398D770", VA = "0x18398ED70", Slot = "36")]
		public void RpcAll<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x398E890", Offset = "0x398D290", VA = "0x18398E890", Slot = "37")]
		public void RpcAll<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x398C700", Offset = "0x398B100", VA = "0x18398C700", Slot = "38")]
		public void RpcAll<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x39AFAE0", Offset = "0x39AE4E0", VA = "0x1839AFAE0", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x39AE8F0", Offset = "0x39AD2F0", VA = "0x1839AE8F0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x39AE150", Offset = "0x39ACB50", VA = "0x1839AE150", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x39AC900", Offset = "0x39AB300", VA = "0x1839AC900", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x39AB5E0", Offset = "0x39A9FE0", VA = "0x1839AB5E0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x39AA0A0", Offset = "0x39A8AA0", VA = "0x1839AA0A0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x39A8940", Offset = "0x39A7340", VA = "0x1839A8940", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x39A7C50", Offset = "0x39A6650", VA = "0x1839A7C50", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x39A61C0", Offset = "0x39A4BC0", VA = "0x1839A61C0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x39A3640", Offset = "0x39A2040", VA = "0x1839A3640", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x39A2600", Offset = "0x39A1000", VA = "0x1839A2600", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x846CF60", Offset = "0x846B960", VA = "0x18846CF60", Slot = "50")]
		public void RpcAllViaServer(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x399E630", Offset = "0x399D030", VA = "0x18399E630", Slot = "51")]
		public void RpcAllViaServer<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x399E7C0", Offset = "0x399D1C0", VA = "0x18399E7C0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x399E0E0", Offset = "0x399CAE0", VA = "0x18399E0E0", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x399DD10", Offset = "0x399C710", VA = "0x18399DD10", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x399D880", Offset = "0x399C280", VA = "0x18399D880", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x399D330", Offset = "0x399BD30", VA = "0x18399D330", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x399CD20", Offset = "0x399B720", VA = "0x18399CD20", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x399C650", Offset = "0x399B050", VA = "0x18399C650", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x399BED0", Offset = "0x399A8D0", VA = "0x18399BED0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x399B690", Offset = "0x399A090", VA = "0x18399B690", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x399AD90", Offset = "0x3999790", VA = "0x18399AD90", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x399A3D0", Offset = "0x3998DD0", VA = "0x18399A3D0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3999940", Offset = "0x3998340", VA = "0x183999940", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3998DE0", Offset = "0x39977E0", VA = "0x183998DE0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x846D090", Offset = "0x846BA90", VA = "0x18846D090", Slot = "64")]
		public void RpcAllViaServer(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x399E630", Offset = "0x399D030", VA = "0x18399E630", Slot = "65")]
		public void RpcAllViaServer<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x399E3E0", Offset = "0x399CDE0", VA = "0x18399E3E0", Slot = "66")]
		public void RpcAllViaServer<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x399E0E0", Offset = "0x399CAE0", VA = "0x18399E0E0", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x399DD10", Offset = "0x399C710", VA = "0x18399DD10", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x399D880", Offset = "0x399C280", VA = "0x18399D880", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x399D330", Offset = "0x399BD30", VA = "0x18399D330", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x399CD20", Offset = "0x399B720", VA = "0x18399CD20", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x399C650", Offset = "0x399B050", VA = "0x18399C650", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x399BED0", Offset = "0x399A8D0", VA = "0x18399BED0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x399B690", Offset = "0x399A090", VA = "0x18399B690", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x399AD90", Offset = "0x3999790", VA = "0x18399AD90", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x399A3D0", Offset = "0x3998DD0", VA = "0x18399A3D0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3999940", Offset = "0x3998340", VA = "0x183999940", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3998DE0", Offset = "0x39977E0", VA = "0x183998DE0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x846DFD0", Offset = "0x846C9D0", VA = "0x18846DFD0", Slot = "79")]
		public void RpcOthers(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39EBCA0", Offset = "0x39EA6A0", VA = "0x1839EBCA0", Slot = "15")]
		public void RpcOthers<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39F2100", Offset = "0x39F0B00", VA = "0x1839F2100", Slot = "80")]
		public void RpcOthers<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x39EBA60", Offset = "0x39EA460", VA = "0x1839EBA60", Slot = "81")]
		public void RpcOthers<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x39F4F00", Offset = "0x39F3900", VA = "0x1839F4F00", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39F0A00", Offset = "0x39EF400", VA = "0x1839F0A00", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x39F2E70", Offset = "0x39F1870", VA = "0x1839F2E70", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x39EFE60", Offset = "0x39EE860", VA = "0x1839EFE60", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x39F3A90", Offset = "0x39F2490", VA = "0x1839F3A90", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x39EEFC0", Offset = "0x39ED9C0", VA = "0x1839EEFC0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x39F35B0", Offset = "0x39F1FB0", VA = "0x1839F35B0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x39EDE20", Offset = "0x39EC820", VA = "0x1839EDE20", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x39ED430", Offset = "0x39EBE30", VA = "0x1839ED430", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x39EC980", Offset = "0x39EB380", VA = "0x1839EC980", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x39EBDF0", Offset = "0x39EA7F0", VA = "0x1839EBDF0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x846DE80", Offset = "0x846C880", VA = "0x18846DE80", Slot = "92")]
		public void RpcOthers(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x39F1E60", Offset = "0x39F0860", VA = "0x1839F1E60", Slot = "93")]
		public void RpcOthers<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x39F1CA0", Offset = "0x39F06A0", VA = "0x1839F1CA0", Slot = "94")]
		public void RpcOthers<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x39F12A0", Offset = "0x39EFCA0", VA = "0x1839F12A0", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x39F1A00", Offset = "0x39F0400", VA = "0x1839F1A00", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x39F2610", Offset = "0x39F1010", VA = "0x1839F2610", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x39F2910", Offset = "0x39F1310", VA = "0x1839F2910", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x39EFE60", Offset = "0x39EE860", VA = "0x1839EFE60", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x39EF770", Offset = "0x39EE170", VA = "0x1839EF770", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x39EEFC0", Offset = "0x39ED9C0", VA = "0x1839EEFC0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x39EE750", Offset = "0x39ED150", VA = "0x1839EE750", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x39EDE20", Offset = "0x39EC820", VA = "0x1839EDE20", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x39ED430", Offset = "0x39EBE30", VA = "0x1839ED430", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x39EC980", Offset = "0x39EB380", VA = "0x1839EC980", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x39EBDF0", Offset = "0x39EA7F0", VA = "0x1839EBDF0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x846D970", Offset = "0x846C370", VA = "0x18846D970", Slot = "107")]
		public void RpcMaster(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x39CDC00", Offset = "0x39CC600", VA = "0x1839CDC00", Slot = "108")]
		public void RpcMaster<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x39CDD90", Offset = "0x39CC790", VA = "0x1839CDD90", Slot = "109")]
		public void RpcMaster<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x39CD230", Offset = "0x39CBC30", VA = "0x1839CD230", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x39CD490", Offset = "0x39CBE90", VA = "0x1839CD490", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x39DBF70", Offset = "0x39DA970", VA = "0x1839DBF70", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x39DDF80", Offset = "0x39DC980", VA = "0x1839DDF80", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x39D4FD0", Offset = "0x39D39D0", VA = "0x1839D4FD0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x39D3DA0", Offset = "0x39D27A0", VA = "0x1839D3DA0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x39D1E80", Offset = "0x39D0880", VA = "0x1839D1E80", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x39DB7C0", Offset = "0x39DA1C0", VA = "0x1839DB7C0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x39DAA10", Offset = "0x39D9410", VA = "0x1839DAA10", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x39CDFB0", Offset = "0x39CC9B0", VA = "0x1839CDFB0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x39E33F0", Offset = "0x39E1DF0", VA = "0x1839E33F0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x39E23F0", Offset = "0x39E0DF0", VA = "0x1839E23F0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x846DB00", Offset = "0x846C500", VA = "0x18846DB00", Slot = "122")]
		public void RpcMaster(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x39CDA20", Offset = "0x39CC420", VA = "0x1839CDA20", Slot = "123")]
		public void RpcMaster<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x39D9D30", Offset = "0x39D8730", VA = "0x1839D9D30", Slot = "124")]
		public void RpcMaster<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x39D93A0", Offset = "0x39D7DA0", VA = "0x1839D93A0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x39D7440", Offset = "0x39D5E40", VA = "0x1839D7440", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x39DC740", Offset = "0x39DB140", VA = "0x1839DC740", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x39D5840", Offset = "0x39D4240", VA = "0x1839D5840", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x39D4710", Offset = "0x39D3110", VA = "0x1839D4710", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x39D33D0", Offset = "0x39D1DD0", VA = "0x1839D33D0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x39D28F0", Offset = "0x39D12F0", VA = "0x1839D28F0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x39D0710", Offset = "0x39CF110", VA = "0x1839D0710", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x39CED70", Offset = "0x39CD770", VA = "0x1839CED70", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x39E5200", Offset = "0x39E3C00", VA = "0x1839E5200", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x39E42C0", Offset = "0x39E2CC0", VA = "0x1839E42C0", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x39E1390", Offset = "0x39DFD90", VA = "0x1839E1390", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x846D7C0", Offset = "0x846C1C0", VA = "0x18846D7C0", Slot = "137")]
		public void RpcAuthority(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x39B7E90", Offset = "0x39B6890", VA = "0x1839B7E90", Slot = "138")]
		public void RpcAuthority<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x39C9AC0", Offset = "0x39C84C0", VA = "0x1839C9AC0", Slot = "139")]
		public void RpcAuthority<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x39CA220", Offset = "0x39C8C20", VA = "0x1839CA220", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x39C97C0", Offset = "0x39C81C0", VA = "0x1839C97C0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x39B7B00", Offset = "0x39B6500", VA = "0x1839B7B00", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x39C5070", Offset = "0x39C3A70", VA = "0x1839C5070", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x39C3710", Offset = "0x39C2110", VA = "0x1839C3710", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x39C2370", Offset = "0x39C0D70", VA = "0x1839C2370", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x39C0DB0", Offset = "0x39BF7B0", VA = "0x1839C0DB0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x39BF5D0", Offset = "0x39BDFD0", VA = "0x1839BF5D0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x39CB090", Offset = "0x39C9A90", VA = "0x1839CB090", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x39C8580", Offset = "0x39C6F80", VA = "0x1839C8580", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x39BA100", Offset = "0x39B8B00", VA = "0x1839BA100", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x39B8040", Offset = "0x39B6A40", VA = "0x1839B8040", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x846D560", Offset = "0x846BF60", VA = "0x18846D560", Slot = "152")]
		public void RpcAuthority(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x39C82D0", Offset = "0x39C6CD0", VA = "0x1839C82D0", Slot = "153")]
		public void RpcAuthority<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x39C7CC0", Offset = "0x39C66C0", VA = "0x1839C7CC0", Slot = "154")]
		public void RpcAuthority<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x39C74B0", Offset = "0x39C5EB0", VA = "0x1839C74B0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x39C6A90", Offset = "0x39C5490", VA = "0x1839C6A90", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x39C57F0", Offset = "0x39C41F0", VA = "0x1839C57F0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x39C48A0", Offset = "0x39C32A0", VA = "0x1839C48A0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x39C3FB0", Offset = "0x39C29B0", VA = "0x1839C3FB0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x39C2D10", Offset = "0x39C1710", VA = "0x1839C2D10", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x39C1860", Offset = "0x39C0260", VA = "0x1839C1860", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x39C0190", Offset = "0x39BEB90", VA = "0x1839C0190", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39BDBC0", Offset = "0x39BC5C0", VA = "0x1839BDBC0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x39BCD70", Offset = "0x39BB770", VA = "0x1839BCD70", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x39BB010", Offset = "0x39B9A10", VA = "0x1839BB010", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x39B9070", Offset = "0x39B7A70", VA = "0x1839B9070", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x846E120", Offset = "0x846CB20", VA = "0x18846E120", Slot = "17")]
		public void RpcPlayer(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x39F5440", Offset = "0x39F3E40", VA = "0x1839F5440", Slot = "18")]
		public void RpcPlayer<T1>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x39F60C0", Offset = "0x39F4AC0", VA = "0x1839F60C0", Slot = "19")]
		public void RpcPlayer<T1, T2>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x39F5B50", Offset = "0x39F4550", VA = "0x1839F5B50", Slot = "20")]
		public void RpcPlayer<T1, T2, T3>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x39F5600", Offset = "0x39F4000", VA = "0x1839F5600", Slot = "21")]
		public void RpcPlayer<T1, T2, T3, T4>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A09BA0", Offset = "0x3A085A0", VA = "0x183A09BA0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A097A0", Offset = "0x3A081A0", VA = "0x183A097A0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A09F20", Offset = "0x3A08920", VA = "0x183A09F20", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A370", Offset = "0x3A08D70", VA = "0x183A0A370", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3A01420", Offset = "0x39FFE20", VA = "0x183A01420", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x39FFC30", Offset = "0x39FE630", VA = "0x1839FFC30", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x39F68F0", Offset = "0x39F52F0", VA = "0x1839F68F0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x39FD410", Offset = "0x39FBE10", VA = "0x1839FD410", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EC90", Offset = "0x3A0D690", VA = "0x183A0EC90", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x39F8630", Offset = "0x39F7030", VA = "0x1839F8630", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x846E310", Offset = "0x846CD10", VA = "0x18846E310", Slot = "176")]
		public void RpcPlayer(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x39F5940", Offset = "0x39F4340", VA = "0x1839F5940", Slot = "177")]
		public void RpcPlayer<T1>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x39F6640", Offset = "0x39F5040", VA = "0x1839F6640", Slot = "23")]
		public void RpcPlayer<T1, T2>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x39F6310", Offset = "0x39F4D10", VA = "0x1839F6310", Slot = "24")]
		public void RpcPlayer<T1, T2, T3>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x39F7EC0", Offset = "0x39F68C0", VA = "0x1839F7EC0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A05E80", Offset = "0x3A04880", VA = "0x183A05E80", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A056A0", Offset = "0x3A040A0", VA = "0x183A056A0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A03D90", Offset = "0x3A02790", VA = "0x183A03D90", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A029F0", Offset = "0x3A013F0", VA = "0x183A029F0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3A01ED0", Offset = "0x3A008D0", VA = "0x183A01ED0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A007F0", Offset = "0x39FF1F0", VA = "0x183A007F0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x39FE210", Offset = "0x39FCC10", VA = "0x1839FE210", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x39FC5B0", Offset = "0x39FAFB0", VA = "0x1839FC5B0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x39FA710", Offset = "0x39F9110", VA = "0x1839FA710", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x39F9670", Offset = "0x39F8070", VA = "0x1839F9670", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x846CE20", Offset = "0x846B820", VA = "0x18846CE20", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3998C40", Offset = "0x3997640", VA = "0x183998C40", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x39989F0", Offset = "0x39973F0", VA = "0x1839989F0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x39986E0", Offset = "0x39970E0", VA = "0x1839986E0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3998310", Offset = "0x3996D10", VA = "0x183998310", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3997E80", Offset = "0x3996880", VA = "0x183997E80", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3997930", Offset = "0x3996330", VA = "0x183997930", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3997320", Offset = "0x3995D20", VA = "0x183997320", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3996C50", Offset = "0x3995650", VA = "0x183996C50", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x39964C0", Offset = "0x3994EC0", VA = "0x1839964C0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3995C70", Offset = "0x3994670", VA = "0x183995C70", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3995360", Offset = "0x3993D60", VA = "0x183995360", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3994990", Offset = "0x3993390", VA = "0x183994990", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3993F00", Offset = "0x3992900", VA = "0x183993F00", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x39933A0", Offset = "0x3991DA0", VA = "0x1839933A0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x846CEC0", Offset = "0x846B8C0", VA = "0x18846CEC0", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3998C40", Offset = "0x3997640", VA = "0x183998C40", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x39989F0", Offset = "0x39973F0", VA = "0x1839989F0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x39986E0", Offset = "0x39970E0", VA = "0x1839986E0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3998310", Offset = "0x3996D10", VA = "0x183998310", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3997E80", Offset = "0x3996880", VA = "0x183997E80", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3997930", Offset = "0x3996330", VA = "0x183997930", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3997320", Offset = "0x3995D20", VA = "0x183997320", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3996C50", Offset = "0x3995650", VA = "0x183996C50", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x39964C0", Offset = "0x3994EC0", VA = "0x1839964C0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3995C70", Offset = "0x3994670", VA = "0x183995C70", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3995360", Offset = "0x3993D60", VA = "0x183995360", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3994990", Offset = "0x3993390", VA = "0x183994990", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3993F00", Offset = "0x3992900", VA = "0x183993F00", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x39933A0", Offset = "0x3991DA0", VA = "0x1839933A0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x846DD40", Offset = "0x846C740", VA = "0x18846DD40", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x39EB8C0", Offset = "0x39EA2C0", VA = "0x1839EB8C0", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x39EB670", Offset = "0x39EA070", VA = "0x1839EB670", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x39EB360", Offset = "0x39E9D60", VA = "0x1839EB360", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x39EAF90", Offset = "0x39E9990", VA = "0x1839EAF90", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x39EAB00", Offset = "0x39E9500", VA = "0x1839EAB00", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x39EA5B0", Offset = "0x39E8FB0", VA = "0x1839EA5B0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x39E9FA0", Offset = "0x39E89A0", VA = "0x1839E9FA0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x39E98D0", Offset = "0x39E82D0", VA = "0x1839E98D0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x39E9140", Offset = "0x39E7B40", VA = "0x1839E9140", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x39E88F0", Offset = "0x39E72F0", VA = "0x1839E88F0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x39E7FE0", Offset = "0x39E69E0", VA = "0x1839E7FE0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x39E7610", Offset = "0x39E6010", VA = "0x1839E7610", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x39E6B80", Offset = "0x39E5580", VA = "0x1839E6B80", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x39E6020", Offset = "0x39E4A20", VA = "0x1839E6020", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x846DDE0", Offset = "0x846C7E0", VA = "0x18846DDE0", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x39EB8C0", Offset = "0x39EA2C0", VA = "0x1839EB8C0", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x39EB670", Offset = "0x39EA070", VA = "0x1839EB670", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x39EB360", Offset = "0x39E9D60", VA = "0x1839EB360", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x39EAF90", Offset = "0x39E9990", VA = "0x1839EAF90", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x39EAB00", Offset = "0x39E9500", VA = "0x1839EAB00", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x39EA5B0", Offset = "0x39E8FB0", VA = "0x1839EA5B0", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x39E9FA0", Offset = "0x39E89A0", VA = "0x1839E9FA0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x39E98D0", Offset = "0x39E82D0", VA = "0x1839E98D0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x39E9140", Offset = "0x39E7B40", VA = "0x1839E9140", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x39E88F0", Offset = "0x39E72F0", VA = "0x1839E88F0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x39E7FE0", Offset = "0x39E69E0", VA = "0x1839E7FE0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x39E7610", Offset = "0x39E6010", VA = "0x1839E7610", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x39E6B80", Offset = "0x39E5580", VA = "0x1839E6B80", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x39E6020", Offset = "0x39E4A20", VA = "0x1839E6020", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x846ADB0", Offset = "0x84697B0", VA = "0x18846ADB0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x846AFB0", Offset = "0x84699B0", VA = "0x18846AFB0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x14E9280", Offset = "0x14E7C80", VA = "0x1814E9280")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class PWWQECDORVG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8469650", Offset = "0x8468050", VA = "0x188469650")]
		private static bool CMMUOIKTVUX(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x38DA000", Offset = "0x38D8A00", VA = "0x1838DA000")]
		[CanBeNull]
		public static a TSBRIMWTAMX<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class CGWGTPBDRTH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public RHIZVYSCBOY[] FAXXDZFYLMW;

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CGWGTPBDRTH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x845EF20", Offset = "0x845D920", VA = "0x18845EF20")]
			internal int OSIYPUXEPRC(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x845EFA0", Offset = "0x845D9A0", VA = "0x18845EFA0")]
			internal void OSOFNBRBZCL(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static RHIZVYSCBOY[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal int XLBHAAXUZRN;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x846F3A0", Offset = "0x846DDA0", VA = "0x18846F3A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x846F890", Offset = "0x846E290", VA = "0x18846F890")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x846FC10", Offset = "0x846E610", VA = "0x18846FC10")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x846FC80", Offset = "0x846E680", VA = "0x18846FC80")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x846F880", Offset = "0x846E280", VA = "0x18846F880")]
		private void GACKFCPNKPL(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x846F880", Offset = "0x846E280", VA = "0x18846F880")]
		private void DOLLZZBYIHP(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8470380", Offset = "0x846ED80", VA = "0x188470380")]
		private void ULBBXHNBDNB(RHIZVYSCBOY a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x846F250", Offset = "0x846DC50", VA = "0x18846F250")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x846FD20", Offset = "0x846E720", VA = "0x18846FD20")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x846F790", Offset = "0x846E190", VA = "0x18846F790")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAC7530", Offset = "0xAC5F30", VA = "0x180AC7530")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class DOKWEFGSEMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x845F3F0", Offset = "0x845DDF0", VA = "0x18845F3F0")]
		public static int VKIKCVXUSYB(this RHIZVYSCBOY a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x845F030", Offset = "0x845DA30", VA = "0x18845F030")]
		public static void EWQYTOQEHWV(this RHIZVYSCBOY a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class KFWDJUMRBLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate void RoomPropertyUpdateCallback(Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void PlayerPropertyUpdateCallback(RHIZVYSCBOY player, Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback STCMKRCTGHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x84653F0", Offset = "0x8463DF0", VA = "0x1884653F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x8465630", Offset = "0x8464030", VA = "0x188465630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback XDVKBVGFFNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x84656F0", Offset = "0x84640F0", VA = "0x1884656F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x8465570", Offset = "0x8463F70", VA = "0x188465570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback SUEVHMKCLDL
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x84654B0", Offset = "0x8463EB0", VA = "0x1884654B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x84657B0", Offset = "0x84641B0", VA = "0x1884657B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback CCDHRZEMIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8465270", Offset = "0x8463C70", VA = "0x188465270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x8465330", Offset = "0x8463D30", VA = "0x188465330")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class ZWNOXHSKJEY
	{
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static int ODZRRQGLCGG;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static int XMPRRRGXUEI;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static int FPBNAKUTMKU;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8473860", Offset = "0x8472260", VA = "0x188473860")]
		public static void FTITSHBMOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x84738B0", Offset = "0x84722B0", VA = "0x1884738B0")]
		public static void PFODWHCGXOH(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8473990", Offset = "0x8472390", VA = "0x188473990")]
		public static int WYAAZNZGYPG(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RegisterService(typeof(FRWOCALBUOM), new string[] { })]
	public class UFERXASWARO : FRWOCALBUOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly Dictionary<object, object> XBWTDPDCZND;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Dictionary<object, object> NUDPZPYBXCB;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly Dictionary<object, object> YXWCZZYQSJX;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly TGLBYERUDJN YEEGHXHPWSX;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly TGLBYERUDJN PVTTRROYOUO;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly TGLBYERUDJN IFXAFNPKRVU;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly TGLBYERUDJN ZRQCLUWZKJR;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly TGLBYERUDJN DWKPWPWPTFY;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static int WITNVQKSLIX;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x84732A0", Offset = "0x8471CA0", VA = "0x1884732A0", Slot = "4")]
		public bool ZZBOOEVYRWL(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x84719C0", Offset = "0x84703C0", VA = "0x1884719C0", Slot = "5")]
		public int WLBWSFWHPNN(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8470C90", Offset = "0x846F690", VA = "0x188470C90", Slot = "6")]
		public bool HGMRPFSDVDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8471200", Offset = "0x846FC00", VA = "0x188471200", Slot = "7")]
		public bool LDNOFLHLLXF(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x84716D0", Offset = "0x84700D0", VA = "0x1884716D0", Slot = "8")]
		public void PFIQKUQQBPM(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8473050", Offset = "0x8471A50", VA = "0x188473050", Slot = "9")]
		public bool ZIGKNSHETOG(LWCFHEHHVPK a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x84713B0", Offset = "0x846FDB0", VA = "0x1884713B0", Slot = "10")]
		public bool MXMFJLJNVMD(LWCFHEHHVPK a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8472720", Offset = "0x8471120", VA = "0x188472720", Slot = "11")]
		public bool YVPCYTPBLFW(LWCFHEHHVPK a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8471F90", Offset = "0x8470990", VA = "0x188471F90", Slot = "12")]
		public void YCDUDGCQYUQ(LWCFHEHHVPK a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8470E30", Offset = "0x846F830", VA = "0x188470E30", Slot = "13")]
		public void JBBXQLRMZUT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8470FF0", Offset = "0x846F9F0", VA = "0x188470FF0", Slot = "14")]
		public void JMYQTRHEZIL(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x84718E0", Offset = "0x84702E0", VA = "0x1884718E0", Slot = "15")]
		public void PHPQDJKYKAV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8470D20", Offset = "0x846F720", VA = "0x188470D20", Slot = "16")]
		public void IRBSIWXNJME(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8471DD0", Offset = "0x84707D0", VA = "0x188471DD0", Slot = "17")]
		public void XAFMAHYAJZA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x84721D0", Offset = "0x8470BD0", VA = "0x1884721D0")]
		private static void YUBSGSUCCHF(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8472860", Offset = "0x8471260", VA = "0x188472860")]
		private static bool ZIGKNSHETOG(Dictionary<object, object> a, RHIZVYSCBOY b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8471160", Offset = "0x846FB60", VA = "0x188471160")]
		private static bool KNWCJOYLKLH(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x84731C0", Offset = "0x8471BC0", VA = "0x1884731C0")]
		private static int ZOTLGEVSRYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UFERXASWARO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RegisterService(typeof(CQBVWYKCFEO), new string[] { })]
	public class NWKTEUYIXAG : CQBVWYKCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly object CKAUONNCFCI;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly object CKGBLUGZONR;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly object CKLIJBAWXZA;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly object CKQPGHUUHKJ;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly object CKVWDOORQVS;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static Dictionary<object, object> IDGVCHCUUEC;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static Dictionary<object, object> MMFXQDVGXEB;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static TGLBYERUDJN NUALZIZMCFW;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly TGLBYERUDJN IKYOIKNGXNL;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8467570", Offset = "0x8465F70", VA = "0x188467570", Slot = "4")]
		public void IINMLGXJFGC(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8467090", Offset = "0x8465A90", VA = "0x188467090", Slot = "5")]
		public bool BSTIYTPZKSW(LWCFHEHHVPK a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8467670", Offset = "0x8466070", VA = "0x188467670", Slot = "6")]
		public void NBSUAFGFUWY(ViewId a, string b, RpcTarget c, RHIZVYSCBOY d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public NWKTEUYIXAG()
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
