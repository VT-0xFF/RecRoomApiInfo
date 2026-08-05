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
		[Cpp2IlInjected.Address(RVA = "0x8362830", Offset = "0x8361030", VA = "0x188362830", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B170", Offset = "0x1F19970", VA = "0x181F1B170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8370A30", Offset = "0x836F230", VA = "0x188370A30")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8370F40", Offset = "0x836F740", VA = "0x188370F40")]
		private void ANXAERWSNVX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83711A0", Offset = "0x836F9A0", VA = "0x1883711A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8371250", Offset = "0x836FA50", VA = "0x188371250")]
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
			[Cpp2IlInjected.Address(RVA = "0x83704B0", Offset = "0x836ECB0", VA = "0x1883704B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x835D850", Offset = "0x835C050", VA = "0x18835D850")]
		public DPHCSCGVDXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x835D2C0", Offset = "0x835BAC0", VA = "0x18835D2C0")]
		public void Pause(LMTUKNOEKUK.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x835C330", Offset = "0x835AB30", VA = "0x18835C330")]
		public void AHPOIFQISDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x835D470", Offset = "0x835BC70", VA = "0x18835D470")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x835C380", Offset = "0x835AB80", VA = "0x18835C380")]
		public bool Add(SWJFQMQXLSK networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x835D2E0", Offset = "0x835BAE0", VA = "0x18835D2E0")]
		public bool Remove(SWJFQMQXLSK networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x835D090", Offset = "0x835B890", VA = "0x18835D090")]
		private GYHQXHTJSPQ IDOMPEZPQGZ(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x835D840", Offset = "0x835C040", VA = "0x18835D840")]
		public void ZUUPRTQGSMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x835D410", Offset = "0x835BC10", VA = "0x18835D410")]
		private void TRQHOKRCBFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x835D2A0", Offset = "0x835BAA0", VA = "0x18835D2A0")]
		private void KWBNVUQUGGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x835C8F0", Offset = "0x835B0F0", VA = "0x18835C8F0")]
		public bool DBIZAVDXMHZ(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x835CCA0", Offset = "0x835B4A0", VA = "0x18835CCA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public JXOVQNEUUHJ(SWJFQMQXLSK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8361F20", Offset = "0x8360720", VA = "0x188361F20", Slot = "5")]
		public bool WNBADTQLDFB(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8361E40", Offset = "0x8360640", VA = "0x188361E40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1A12150", Offset = "0x1A10950", VA = "0x181A12150")]
		public JOJUDDQZKLC(ViewId a, LMTUKNOEKUK.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8361E00", Offset = "0x8360600", VA = "0x188361E00", Slot = "5")]
		public bool WNBADTQLDFB(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8361C20", Offset = "0x8360420", VA = "0x188361C20", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ALTYELHJNIU
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8353720", Offset = "0x8351F20", VA = "0x188353720")]
		public static void JVPEYACKYLR(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8352D00", Offset = "0x8351500", VA = "0x188352D00")]
		public static void DRNICORZPZI(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8353200", Offset = "0x8351A00", VA = "0x188353200")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8353370", Offset = "0x8351B70", VA = "0x188353370")]
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
		[Cpp2IlInjected.Address(RVA = "0x8365910", Offset = "0x8364110", VA = "0x188365910", Slot = "4")]
		public void JIBLBJTHOBM(SWJFQMQXLSK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8365A30", Offset = "0x8364230", VA = "0x188365A30", Slot = "5")]
		public void KBLBKORKNFH(SWJFQMQXLSK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83657C0", Offset = "0x8363FC0", VA = "0x1883657C0", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8365C30", Offset = "0x8364430", VA = "0x188365C30", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8365CE0", Offset = "0x83644E0", VA = "0x188365CE0")]
		private void YAKNXCTUGOA(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8365CB0", Offset = "0x83644B0", VA = "0x188365CB0", Slot = "6")]
		public void Pause(LMTUKNOEKUK.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83652B0", Offset = "0x8363AB0", VA = "0x1883652B0", Slot = "7")]
		public void AHPOIFQISDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83662F0", Offset = "0x8364AF0", VA = "0x1883662F0", Slot = "8")]
		public void YMRXESXMUGP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8365430", Offset = "0x8363C30", VA = "0x188365430")]
		private void CBQQHQMHGPE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8365310", Offset = "0x8363B10", VA = "0x188365310", Slot = "11")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8366350", Offset = "0x8364B50", VA = "0x188366350")]
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
			[Cpp2IlInjected.Address(RVA = "0x835DEF0", Offset = "0x835C6F0", VA = "0x18835DEF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x835DF20", Offset = "0x835C720", VA = "0x18835DF20")]
		public EQBBWPBERYG(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x835DEB0", Offset = "0x835C6B0", VA = "0x18835DEB0", Slot = "5")]
		public bool WNBADTQLDFB(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x835DA40", Offset = "0x835C240", VA = "0x18835DA40", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x835DBF0", Offset = "0x835C3F0", VA = "0x18835DBF0")]
		internal JXOVQNEUUHJ SCOOGVFQJBY(SWJFQMQXLSK a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x835DCF0", Offset = "0x835C4F0", VA = "0x18835DCF0")]
		private static void TYZFITOXVFG(JXOVQNEUUHJ a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class WAUOGVJLVWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8370560", Offset = "0x836ED60", VA = "0x188370560")]
		public static RHIZVYSCBOY HLSSGVIUYVG(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83705F0", Offset = "0x836EDF0", VA = "0x1883705F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8366D90", Offset = "0x8365590", VA = "0x188366D90")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId QNYDEQJWDXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8366D90", Offset = "0x8365590", VA = "0x188366D90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8366E10", Offset = "0x8365610", VA = "0x188366E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView MFEJFLHFAPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8366E10", Offset = "0x8365610", VA = "0x188366E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RHIZVYSCBOY YCAGPJHWGBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8366F10", Offset = "0x8365710", VA = "0x188366F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RHIZVYSCBOY IAKYPZPNSRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8367270", Offset = "0x8365A70", VA = "0x188367270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool REJWXANXIRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8367070", Offset = "0x8365870", VA = "0x188367070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HNZBBORMKZW
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83671E0", Offset = "0x83659E0", VA = "0x1883671E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OUTXDSEQKSW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8366CC0", Offset = "0x83654C0", VA = "0x188366CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool SRYOYMNMKVA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8366FA0", Offset = "0x83657A0", VA = "0x188366FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KLYIAAEMXPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8366CC0", Offset = "0x83654C0", VA = "0x188366CC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LHYUNIINVRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8366D40", Offset = "0x8365540", VA = "0x188366D40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string PJTKIJZTVAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8366E80", Offset = "0x8365680", VA = "0x188366E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MZBGYDVMOZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8366C40", Offset = "0x8365440", VA = "0x188366C40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RHIZVYSCBOY> UGYMNRFFUXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8366B10", Offset = "0x8365310", VA = "0x188366B10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8367300", Offset = "0x8365B00", VA = "0x188367300")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8366A70", Offset = "0x8365270", VA = "0x188366A70")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8366650", Offset = "0x8364E50", VA = "0x188366650")]
		private void PCLHFZZFJYQ(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8366670", Offset = "0x8364E70", VA = "0x188366670", Slot = "9")]
		public void RegisterDestroyHandler(UNSAYDJFQCJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83668B0", Offset = "0x83650B0", VA = "0x1883668B0", Slot = "10")]
		public void UnregisterDestroyHandler(UNSAYDJFQCJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8366630", Offset = "0x8364E30", VA = "0x188366630", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
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
			[Cpp2IlInjected.Address(RVA = "0x8363440", Offset = "0x8361C40", VA = "0x188363440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8363940", Offset = "0x8362140", VA = "0x188363940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback XOHMDSSYAQH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8363AC0", Offset = "0x83622C0", VA = "0x188363AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8363740", Offset = "0x8361F40", VA = "0x188363740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback PDZVWBCPXHD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8363C10", Offset = "0x8362410", VA = "0x188363C10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8363D90", Offset = "0x8362590", VA = "0x188363D90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback BIICECYWUVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83635C0", Offset = "0x8361DC0", VA = "0x1883635C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8362FE0", Offset = "0x83617E0", VA = "0x188362FE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback MVRDVGLCESK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8363500", Offset = "0x8361D00", VA = "0x188363500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8363A00", Offset = "0x8362200", VA = "0x188363A00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback ADANAHYCBLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83630A0", Offset = "0x83618A0", VA = "0x1883630A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8362E60", Offset = "0x8361660", VA = "0x188362E60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback RHSDTZQXELH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8363680", Offset = "0x8361E80", VA = "0x188363680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8363380", Offset = "0x8361B80", VA = "0x188363380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler YXTSILWJNUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8362DA0", Offset = "0x83615A0", VA = "0x188362DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8362F20", Offset = "0x8361720", VA = "0x188362F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler UBYCNSELLBS
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8363CD0", Offset = "0x83624D0", VA = "0x188363CD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8362C20", Offset = "0x8361420", VA = "0x188362C20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8362CE0", Offset = "0x83614E0", VA = "0x188362CE0")]
		public static void CPHWOQVYDEM([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8363B80", Offset = "0x8362380", VA = "0x188363B80")]
		public static void UYAFRYFDEMG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8362A40", Offset = "0x8361240", VA = "0x188362A40")]
		public static void AONFDJLVQKZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83632F0", Offset = "0x8361AF0", VA = "0x1883632F0")]
		public static void LEAUHTBIKBK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8363260", Offset = "0x8361A60", VA = "0x188363260")]
		public static void KAHTAOKJEUL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8362AD0", Offset = "0x83612D0", VA = "0x188362AD0")]
		public static void AXIGHSNAEVR(RRNetworkView a, string b, RHIZVYSCBOY c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8363800", Offset = "0x8362000", VA = "0x188363800")]
		public static void RPZEGRDVJUW(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8363160", Offset = "0x8361960", VA = "0x188363160")]
		public static void JZPMBGAJRVQ(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class LIXMVYPJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83626A0", Offset = "0x8360EA0", VA = "0x1883626A0")]
		[CanBeNull]
		private static bool KSSMJXIQUUX(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8362750", Offset = "0x8360F50", VA = "0x188362750")]
		[CanBeNull]
		public static Component NNVZFDGPLRJ(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3747D80", Offset = "0x3746580", VA = "0x183747D80")]
		[CanBeNull]
		public static a NNVZFDGPLRJ<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3747F30", Offset = "0x3746730", VA = "0x183747F30")]
		[CanBeNull]
		public static b RXNSEKYXFFF<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3747EA0", Offset = "0x37466A0", VA = "0x183747EA0")]
		public static bool POBZRGHYDRM<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8362630", Offset = "0x8360E30", VA = "0x188362630")]
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
			[Cpp2IlInjected.Address(RVA = "0x8367430", Offset = "0x8365C30", VA = "0x188367430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83675E0", Offset = "0x8365DE0", VA = "0x1883675E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83675A0", Offset = "0x8365DA0", VA = "0x1883675A0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public HXGPKBFCMYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x835DF90", Offset = "0x835C790", VA = "0x18835DF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x83575A0", Offset = "0x8355DA0", VA = "0x1883575A0", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83541D0", Offset = "0x83529D0", VA = "0x1883541D0", Slot = "9")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8357490", Offset = "0x8355C90", VA = "0x188357490", Slot = "10")]
		public void InitExternal(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83590F0", Offset = "0x83578F0", VA = "0x1883590F0", Slot = "11")]
		public void OINRTVSEBTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8355A10", Offset = "0x8354210", VA = "0x188355A10")]
		private void DCOUYDNIKPK(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83591E0", Offset = "0x83579E0", VA = "0x1883591E0")]
		public GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8354510", Offset = "0x8352D10", VA = "0x188354510")]
		public GameObject BYIMWJMKMSR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8356BF0", Offset = "0x83553F0", VA = "0x188356BF0")]
		public GameObject HVFLYDJDGRK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x835ACE0", Offset = "0x83594E0", VA = "0x18835ACE0")]
		public GameObject TGBMEVFUOLQ(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x83569B0", Offset = "0x83551B0", VA = "0x1883569B0", Slot = "6")]
		public void FXNLMHIJMYS(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8359DB0", Offset = "0x83585B0", VA = "0x188359DB0")]
		public void RFVZPLGLMBB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8359860", Offset = "0x8358060", VA = "0x188359860", Slot = "7")]
		public void PHEBUFUYYQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8357940", Offset = "0x8356140", VA = "0x188357940", Slot = "4")]
		public GameObject[] KQMOPPPQLKA(IList<MOFTTNXWVKL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83570F0", Offset = "0x83558F0", VA = "0x1883570F0", Slot = "5")]
		public void IMNKTNEZVMP(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8357C50", Offset = "0x8356450", VA = "0x188357C50")]
		public void LCHQJSVARHD(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8355480", Offset = "0x8353C80", VA = "0x188355480")]
		private void CBQQHQMHGPE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x835A380", Offset = "0x8358B80", VA = "0x18835A380")]
		private void SBWNDUJIYFK(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83569C0", Offset = "0x83551C0", VA = "0x1883569C0")]
		private void GWUSTCDSKRY(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8356E70", Offset = "0x8355670", VA = "0x188356E70")]
		private void IHSPLDJOOAS(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8353CE0", Offset = "0x83524E0", VA = "0x188353CE0")]
		private void BFKZFQGUSBE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83565B0", Offset = "0x8354DB0", VA = "0x1883565B0")]
		private void FKDLNFQRNAG(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x835B060", Offset = "0x8359860", VA = "0x18835B060")]
		private void YATGMJTMIUU(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x835AE10", Offset = "0x8359610", VA = "0x18835AE10")]
		private GameObject WJNALVMQPWD(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x835A5F0", Offset = "0x8358DF0", VA = "0x18835A5F0")]
		private GameObject SVFHTZEAPKZ(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8356530", Offset = "0x8354D30", VA = "0x188356530")]
		private static GameObject FGDIMUCPOVJ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x835B620", Offset = "0x8359E20", VA = "0x18835B620")]
		private static GameObject YOOMJPWDMVU(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83540C0", Offset = "0x83528C0", VA = "0x1883540C0")]
		private static void BNCHJWFGVGJ(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8357D30", Offset = "0x8356530", VA = "0x188357D30")]
		private GameObject[] NZKAWUEQZFC(IList<MOFTTNXWVKL> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8355750", Offset = "0x8353F50", VA = "0x188355750")]
		private GameObject[] CZSNUVBZAHU(InstantiateParameters[] a, int b, RHIZVYSCBOY c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83599B0", Offset = "0x83581B0", VA = "0x1883599B0")]
		private GameObject QZJTEPTVJGY([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83538E0", Offset = "0x83520E0", VA = "0x1883538E0")]
		private static bool AJKUCYTRMXP(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8358520", Offset = "0x8356D20", VA = "0x188358520")]
		private void OIEEQGDDUNT(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8354600", Offset = "0x8352E00", VA = "0x188354600")]
		private void CBLVCJAFJVL(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8353900", Offset = "0x8352100", VA = "0x188353900")]
		private static void AJQTUYVUSNO(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8359870", Offset = "0x8358070", VA = "0x188359870")]
		private void QRAROONWBWA(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83593B0", Offset = "0x8357BB0", VA = "0x1883593B0")]
		private static int OOMMDTDZISM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83578E0", Offset = "0x83560E0", VA = "0x1883578E0")]
		private void KPIONIAKHGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8359E20", Offset = "0x8358620", VA = "0x188359E20")]
		private void RGSVHAJUJUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x835B000", Offset = "0x8359800", VA = "0x18835B000")]
		private static int WYAAZNZGYPG(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x835A510", Offset = "0x8358D10", VA = "0x18835A510")]
		private static int[] SJSNLEAIEEN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8359450", Offset = "0x8357C50", VA = "0x188359450")]
		private static int[] OPZGUFJBAKR(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8359820", Offset = "0x8358020", VA = "0x188359820")]
		private void OnMasterClientSwitched(RHIZVYSCBOY newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8355A80", Offset = "0x8354280", VA = "0x188355A80")]
		private void DOLLZZBYIHP(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8359550", Offset = "0x8357D50", VA = "0x188359550")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8356770", Offset = "0x8354F70", VA = "0x188356770")]
		private void FQQDEJPCUPH(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x835B830", Offset = "0x835A030", VA = "0x18835B830")]
		private static void ZAYKGRNVYIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x835AD10", Offset = "0x8359510", VA = "0x18835AD10")]
		private void VJIACRPIGSL(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83564E0", Offset = "0x8354CE0", VA = "0x1883564E0", Slot = "12")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC990B0", Offset = "0xC978B0", VA = "0x180C990B0", Slot = "13")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public BGWAUNMGNEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
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
			[Cpp2IlInjected.Address(RVA = "0xE12FC0", Offset = "0xE117C0", VA = "0x180E12FC0")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x836D2B0", Offset = "0x836BAB0", VA = "0x18836D2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public TXCIFAKKTSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x836D2D0", Offset = "0x836BAD0", VA = "0x18836D2D0")]
			internal RpcMethodInfo CJMHSWJEKEF(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x50B5E80", Offset = "0x50B4680", VA = "0x1850B5E80")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public TXHPCHEIDDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x836D390", Offset = "0x836BB90", VA = "0x18836D390")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public YJGILQXVTGT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8370640", Offset = "0x836EE40", VA = "0x188370640")]
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
		[Cpp2IlInjected.Address(RVA = "0x835ED90", Offset = "0x835D590", VA = "0x18835ED90", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8360670", Offset = "0x835EE70", VA = "0x188360670")]
		private void OFMZRIJSWGO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x835EEE0", Offset = "0x835D6E0", VA = "0x18835EEE0", Slot = "10")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xC990B0", Offset = "0xC978B0", VA = "0x180C990B0", Slot = "11")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x835E260", Offset = "0x835CA60", VA = "0x18835E260", Slot = "5")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8360F90", Offset = "0x835F790", VA = "0x188360F90")]
		public static bool TBCRZWKQSGT(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8360590", Offset = "0x835ED90", VA = "0x188360590")]
		public static bool LGGFEUFFQCD(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x835E3B0", Offset = "0x835CBB0", VA = "0x18835E3B0")]
		private void CBQQHQMHGPE(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8361020", Offset = "0x835F820", VA = "0x188361020", Slot = "9")]
		public string TTHLELOONQR(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x835ECE0", Offset = "0x835D4E0", VA = "0x18835ECE0", Slot = "8")]
		public void IINMLGXJFGC(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x835EC10", Offset = "0x835D410", VA = "0x18835EC10", Slot = "6")]
		public void HYADYLYDQOK(ViewId a, string b, RHIZVYSCBOY c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x835EBE0", Offset = "0x835D3E0", VA = "0x18835EBE0", Slot = "7")]
		public void HYADYLYDQOK(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x835E730", Offset = "0x835CF30", VA = "0x18835E730")]
		private void HYADYLYDQOK(ViewId a, string b, RpcTarget c, RHIZVYSCBOY d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x835EF30", Offset = "0x835D730", VA = "0x18835EF30")]
		private void JLUEDTGHHZX(ViewId a, string b, RHIZVYSCBOY c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8360B00", Offset = "0x835F300", VA = "0x188360B00")]
		private static void PHOGQXTEKZR(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x835E050", Offset = "0x835C850", VA = "0x18835E050")]
		private static bool BHKTECXPOSK(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8361050", Offset = "0x835F850", VA = "0x188361050")]
		private List<RpcMethodInfo> VZJKPIKDHCJ(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x835E630", Offset = "0x835CE30", VA = "0x18835E630")]
		private static IEnumerable<MethodInfo> CUQXMULZDSX(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83618D0", Offset = "0x83600D0", VA = "0x1883618D0")]
		public static ParameterInfo[] ZYDEFTLUCQP(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x83676A0", Offset = "0x8365EA0", VA = "0x1883676A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8367620", Offset = "0x8365E20", VA = "0x188367620")]
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
			[Cpp2IlInjected.Address(RVA = "0x8364E80", Offset = "0x8363680", VA = "0x188364E80", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8364E80", Offset = "0x8363680", VA = "0x188364E80", Slot = "5")]
			public void BTTVCOLODYQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8364E90", Offset = "0x8363690", VA = "0x188364E90", Slot = "6")]
			public void ZNQVMXLECIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PBZSWMUOFRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x8365250", Offset = "0x8363A50", VA = "0x188365250")]
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
			[Cpp2IlInjected.Address(RVA = "0x8368460", Offset = "0x8366C60", VA = "0x188368460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId QNYDEQJWDXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x836BCB0", Offset = "0x836A4B0", VA = "0x18836BCB0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId RBVXVZPLUQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x836BCB0", Offset = "0x836A4B0", VA = "0x18836BCB0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId NUXFNOEWMXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x836BCB0", Offset = "0x836A4B0", VA = "0x18836BCB0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int RIIKMICFKPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF8A10", VA = "0x180AFA210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int DHVEXGEEYMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AE0", Offset = "0xAC62E0", VA = "0x180AC7AE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xC13A70", Offset = "0xC12270", VA = "0x180C13A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId KJBLQWJMSRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x836BB20", Offset = "0x836A320", VA = "0x18836BB20")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HCOTHNEAPUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xC9BBE0", Offset = "0xC9A3E0", VA = "0x180C9BBE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xC9BBF0", Offset = "0xC9A3F0", VA = "0x180C9BBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool LZHUPPLTFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x836BB30", Offset = "0x836A330", VA = "0x18836BB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool PRTJBJEVGKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xB03320", Offset = "0xB01B20", VA = "0x180B03320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int XQBIGACLWWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAEE380", Offset = "0xAECB80", VA = "0x180AEE380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int NLJSZGLTHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x836BAC0", Offset = "0x836A2C0", VA = "0x18836BAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RHIZVYSCBOY KUVXXYXLJUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x836BCC0", Offset = "0x836A4C0", VA = "0x18836BCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public RHIZVYSCBOY YNHMGNTGALB
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x836BA90", Offset = "0x836A290", VA = "0x18836BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RHIZVYSCBOY YCAGPJHWGBW
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x836BA90", Offset = "0x836A290", VA = "0x18836BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public RHIZVYSCBOY KZVOCWQWMFG
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x836BA90", Offset = "0x836A290", VA = "0x18836BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool SFZEOHARSQU
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x836BC00", Offset = "0x836A400", VA = "0x18836BC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int YQRWIQZVNWG
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x836BAF0", Offset = "0x836A2F0", VA = "0x18836BAF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] PTDQJUSIVJK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xA9E120", Offset = "0xA9C920", VA = "0x180A9E120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool REJWXANXIRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x836BCF0", Offset = "0x836A4F0", VA = "0x18836BCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool THXSWCEEJVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x836BC80", Offset = "0x836A480", VA = "0x18836BC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xCDFB10", Offset = "0xCDE310", VA = "0x180CDFB10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xCDFB20", Offset = "0xCDE320", VA = "0x180CDFB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xCDF340", Offset = "0xCDDB40", VA = "0x180CDF340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> SQIMOXBVVQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x836B920", Offset = "0x836A120", VA = "0x18836B920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x836BEB0", Offset = "0x836A6B0", VA = "0x18836BEB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<RHIZVYSCBOY> UAPATPYSPXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8368790", Offset = "0x8366F90", VA = "0x188368790")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8369470", Offset = "0x8367C70", VA = "0x188369470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<RHIZVYSCBOY> JLJEGJSZYOT
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8368790", Offset = "0x8366F90", VA = "0x188368790")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8369470", Offset = "0x8367C70", VA = "0x188369470")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> XXSTVRPBZVA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8368510", Offset = "0x8366D10", VA = "0x188368510")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8369530", Offset = "0x8367D30", VA = "0x188369530")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> ENPEFUQVFTU
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8368510", Offset = "0x8366D10", VA = "0x188368510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8369530", Offset = "0x8367D30", VA = "0x188369530")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> YCPAYDSRNHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x836B9D0", Offset = "0x836A1D0", VA = "0x18836B9D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x836BF60", Offset = "0x836A760", VA = "0x18836BF60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action DRTLJCALEEI
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x836B870", Offset = "0x836A070", VA = "0x18836B870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x836BE00", Offset = "0x836A600", VA = "0x18836BE00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x836B5E0", Offset = "0x8369DE0", VA = "0x18836B5E0")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83680E0", Offset = "0x83668E0", VA = "0x1883680E0")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8368240", Offset = "0x8366A40", VA = "0x188368240")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83681A0", Offset = "0x83669A0", VA = "0x1883681A0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8369A30", Offset = "0x8368230", VA = "0x188369A30")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83697D0", Offset = "0x8367FD0", VA = "0x1883697D0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8369100", Offset = "0x8367900", VA = "0x188369100")]
		public static void OnPlayerJoinedRoom(RHIZVYSCBOY newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83683A0", Offset = "0x8366BA0", VA = "0x1883683A0")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8368400", Offset = "0x8366C00", VA = "0x188368400")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8368E40", Offset = "0x8367640", VA = "0x188368E40")]
		private void OBLPFJODNRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8367DE0", Offset = "0x83665E0", VA = "0x188367DE0")]
		public bool CreatedBy(RHIZVYSCBOY player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x836B400", Offset = "0x8369C00", VA = "0x18836B400")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x836B3A0", Offset = "0x8369BA0", VA = "0x18836B3A0")]
		public void TransferOwnership(RHIZVYSCBOY newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8368620", Offset = "0x8366E20", VA = "0x188368620", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83685C0", Offset = "0x8366DC0", VA = "0x1883685C0")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8367800", Offset = "0x8366000", VA = "0x188367800")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8367920", Offset = "0x8366120", VA = "0x188367920")]
		private void CURVMWTUQPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1103220", Offset = "0x1101A20", VA = "0x181103220")]
		internal void NOMWEAMFCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x83678C0", Offset = "0x83660C0", VA = "0x1883678C0", Slot = "6")]
		private void CGYYJIJTCPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8368840", Offset = "0x8367040", VA = "0x188368840")]
		internal bool KSIPPLTJFMX(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8368FC0", Offset = "0x83677C0", VA = "0x188368FC0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x83684B0", Offset = "0x8366CB0", VA = "0x1883684B0")]
		internal void HZUINWXMEVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8369520", Offset = "0x8367D20", VA = "0x188369520")]
		private void RBNZUSRAFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8367E60", Offset = "0x8366660", VA = "0x188367E60")]
		internal void DIYDQWWDMVP(RHIZVYSCBOY a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8369990", Offset = "0x8368190", VA = "0x188369990")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8369AE0", Offset = "0x83682E0", VA = "0x188369AE0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8368DA0", Offset = "0x83675A0", VA = "0x188368DA0")]
		private void NYAXMJESJPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x83688B0", Offset = "0x83670B0", VA = "0x1883688B0")]
		private void LMKXDPNXIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x83696B0", Offset = "0x8367EB0", VA = "0x1883696B0")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8369740", Offset = "0x8367F40", VA = "0x188369740")]
		public void RPC(string methodName, RHIZVYSCBOY targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x83699E0", Offset = "0x83681E0", VA = "0x1883699E0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8367850", Offset = "0x8366050", VA = "0x188367850", Slot = "8")]
		public void Bake(WQKTEDFFTLA context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x836B6A0", Offset = "0x8369EA0", VA = "0x18836B6A0")]
		private static void UIHSUTNKFYE(RHIZVYSCBOY a, [Out] RHIZVYSCBOY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x83689A0", Offset = "0x83671A0", VA = "0x1883689A0")]
		private static void LRWHPZDIEZN(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8368F20", Offset = "0x8367720", VA = "0x188368F20")]
		private static RPCInfo OHOIVVEFMCS(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8367F20", Offset = "0x8366720", VA = "0x188367F20")]
		private static void EBAOGRWPCPO(RRNetworkView a, Delegate b, RHIZVYSCBOY c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8368000", Offset = "0x8366800", VA = "0x188368000")]
		private static void EBAOGRWPCPO(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8368C90", Offset = "0x8367490", VA = "0x188368C90")]
		private static void MAKHTJGVITZ(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x83695E0", Offset = "0x8367DE0", VA = "0x1883695E0")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x836B710", Offset = "0x8369F10", VA = "0x18836B710")]
		private static bool WQAJKSDFCGY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x836A1C0", Offset = "0x83689C0", VA = "0x18836A1C0", Slot = "25")]
		public void RpcAll(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3970110", Offset = "0x396E910", VA = "0x183970110", Slot = "9")]
		public void RpcAll<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x396FD00", Offset = "0x396E500", VA = "0x18396FD00", Slot = "10")]
		public void RpcAll<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3970770", Offset = "0x396EF70", VA = "0x183970770", Slot = "26")]
		public void RpcAll<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3982E80", Offset = "0x3981680", VA = "0x183982E80", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3983650", Offset = "0x3981E50", VA = "0x183983650", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3984C00", Offset = "0x3983400", VA = "0x183984C00", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3983190", Offset = "0x3981990", VA = "0x183983190", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3996B30", Offset = "0x3995330", VA = "0x183996B30", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3985030", Offset = "0x3983830", VA = "0x183985030", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3984230", Offset = "0x3982A30", VA = "0x183984230", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3999A60", Offset = "0x3998260", VA = "0x183999A60", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x39956D0", Offset = "0x3993ED0", VA = "0x1839956D0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3988B90", Offset = "0x3987390", VA = "0x183988B90", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3983A50", Offset = "0x3982250", VA = "0x183983A50", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8369F90", Offset = "0x8368790", VA = "0x188369F90", Slot = "35")]
		public void RpcAll(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3972B90", Offset = "0x3971390", VA = "0x183972B90", Slot = "36")]
		public void RpcAll<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x39726B0", Offset = "0x3970EB0", VA = "0x1839726B0", Slot = "37")]
		public void RpcAll<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3970490", Offset = "0x396EC90", VA = "0x183970490", Slot = "38")]
		public void RpcAll<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3994820", Offset = "0x3993020", VA = "0x183994820", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3993590", Offset = "0x3991D90", VA = "0x183993590", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3992DB0", Offset = "0x39915B0", VA = "0x183992DB0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3991470", Offset = "0x398FC70", VA = "0x183991470", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3990090", Offset = "0x398E890", VA = "0x183990090", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x398EA80", Offset = "0x398D280", VA = "0x18398EA80", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x398D230", Offset = "0x398BA30", VA = "0x18398D230", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x398C4C0", Offset = "0x398ACC0", VA = "0x18398C4C0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x398A920", Offset = "0x3989120", VA = "0x18398A920", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3987BD0", Offset = "0x39863D0", VA = "0x183987BD0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3986AE0", Offset = "0x39852E0", VA = "0x183986AE0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8369D30", Offset = "0x8368530", VA = "0x188369D30", Slot = "50")]
		public void RpcAllViaServer(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x39829B0", Offset = "0x39811B0", VA = "0x1839829B0", Slot = "51")]
		public void RpcAllViaServer<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3982B40", Offset = "0x3981340", VA = "0x183982B40", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3982440", Offset = "0x3980C40", VA = "0x183982440", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3982050", Offset = "0x3980850", VA = "0x183982050", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3981BA0", Offset = "0x39803A0", VA = "0x183981BA0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3981630", Offset = "0x397FE30", VA = "0x183981630", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3981000", Offset = "0x397F800", VA = "0x183981000", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3980900", Offset = "0x397F100", VA = "0x183980900", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3980140", Offset = "0x397E940", VA = "0x183980140", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x397F8C0", Offset = "0x397E0C0", VA = "0x18397F8C0", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x397EF80", Offset = "0x397D780", VA = "0x18397EF80", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x397E570", Offset = "0x397CD70", VA = "0x18397E570", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x397DA90", Offset = "0x397C290", VA = "0x18397DA90", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x397CEE0", Offset = "0x397B6E0", VA = "0x18397CEE0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8369E60", Offset = "0x8368660", VA = "0x188369E60", Slot = "64")]
		public void RpcAllViaServer(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x39829B0", Offset = "0x39811B0", VA = "0x1839829B0", Slot = "65")]
		public void RpcAllViaServer<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3982760", Offset = "0x3980F60", VA = "0x183982760", Slot = "66")]
		public void RpcAllViaServer<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3982440", Offset = "0x3980C40", VA = "0x183982440", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3982050", Offset = "0x3980850", VA = "0x183982050", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3981BA0", Offset = "0x39803A0", VA = "0x183981BA0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3981630", Offset = "0x397FE30", VA = "0x183981630", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3981000", Offset = "0x397F800", VA = "0x183981000", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3980900", Offset = "0x397F100", VA = "0x183980900", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3980140", Offset = "0x397E940", VA = "0x183980140", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x397F8C0", Offset = "0x397E0C0", VA = "0x18397F8C0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x397EF80", Offset = "0x397D780", VA = "0x18397EF80", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x397E570", Offset = "0x397CD70", VA = "0x18397E570", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x397DA90", Offset = "0x397C290", VA = "0x18397DA90", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x397CEE0", Offset = "0x397B6E0", VA = "0x18397CEE0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x836ADA0", Offset = "0x83695A0", VA = "0x18836ADA0", Slot = "79")]
		public void RpcOthers(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39D2560", Offset = "0x39D0D60", VA = "0x1839D2560", Slot = "15")]
		public void RpcOthers<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39D8C70", Offset = "0x39D7470", VA = "0x1839D8C70", Slot = "80")]
		public void RpcOthers<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x39D2310", Offset = "0x39D0B10", VA = "0x1839D2310", Slot = "81")]
		public void RpcOthers<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x39DBB40", Offset = "0x39DA340", VA = "0x1839DBB40", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39D74F0", Offset = "0x39D5CF0", VA = "0x1839D74F0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x39D9A10", Offset = "0x39D8210", VA = "0x1839D9A10", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x39D68F0", Offset = "0x39D50F0", VA = "0x1839D68F0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x39DA680", Offset = "0x39D8E80", VA = "0x1839DA680", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x39D59E0", Offset = "0x39D41E0", VA = "0x1839D59E0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x39DA180", Offset = "0x39D8980", VA = "0x1839DA180", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x39D47C0", Offset = "0x39D2FC0", VA = "0x1839D47C0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x39D3D90", Offset = "0x39D2590", VA = "0x1839D3D90", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x39D3290", Offset = "0x39D1A90", VA = "0x1839D3290", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x39D26B0", Offset = "0x39D0EB0", VA = "0x1839D26B0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x836AC50", Offset = "0x8369450", VA = "0x18836AC50", Slot = "92")]
		public void RpcOthers(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x39D89D0", Offset = "0x39D71D0", VA = "0x1839D89D0", Slot = "93")]
		public void RpcOthers<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x39D8810", Offset = "0x39D7010", VA = "0x1839D8810", Slot = "94")]
		public void RpcOthers<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x39D7DD0", Offset = "0x39D65D0", VA = "0x1839D7DD0", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x39D8560", Offset = "0x39D6D60", VA = "0x1839D8560", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x39D9180", Offset = "0x39D7980", VA = "0x1839D9180", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x39D9490", Offset = "0x39D7C90", VA = "0x1839D9490", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x39D68F0", Offset = "0x39D50F0", VA = "0x1839D68F0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x39D61D0", Offset = "0x39D49D0", VA = "0x1839D61D0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x39D59E0", Offset = "0x39D41E0", VA = "0x1839D59E0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x39D5130", Offset = "0x39D3930", VA = "0x1839D5130", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x39D47C0", Offset = "0x39D2FC0", VA = "0x1839D47C0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x39D3D90", Offset = "0x39D2590", VA = "0x1839D3D90", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x39D3290", Offset = "0x39D1A90", VA = "0x1839D3290", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x39D26B0", Offset = "0x39D0EB0", VA = "0x1839D26B0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x836A740", Offset = "0x8368F40", VA = "0x18836A740", Slot = "107")]
		public void RpcMaster(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x39B36D0", Offset = "0x39B1ED0", VA = "0x1839B36D0", Slot = "108")]
		public void RpcMaster<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x39B3870", Offset = "0x39B2070", VA = "0x1839B3870", Slot = "109")]
		public void RpcMaster<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x39B2CE0", Offset = "0x39B14E0", VA = "0x1839B2CE0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x39B2F40", Offset = "0x39B1740", VA = "0x1839B2F40", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x39C21B0", Offset = "0x39C09B0", VA = "0x1839C21B0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x39C4210", Offset = "0x39C2A10", VA = "0x1839C4210", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x39BAF40", Offset = "0x39B9740", VA = "0x1839BAF40", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x39B9C60", Offset = "0x39B8460", VA = "0x1839B9C60", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x39B7C00", Offset = "0x39B6400", VA = "0x1839B7C00", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x39C19F0", Offset = "0x39C01F0", VA = "0x1839C19F0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x39C0C00", Offset = "0x39BF400", VA = "0x1839C0C00", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x39B3A90", Offset = "0x39B2290", VA = "0x1839B3A90", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x39C9880", Offset = "0x39C8080", VA = "0x1839C9880", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x39C87E0", Offset = "0x39C6FE0", VA = "0x1839C87E0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x836A8D0", Offset = "0x83690D0", VA = "0x18836A8D0", Slot = "122")]
		public void RpcMaster(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x39B34F0", Offset = "0x39B1CF0", VA = "0x1839B34F0", Slot = "123")]
		public void RpcMaster<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x39BFF00", Offset = "0x39BE700", VA = "0x1839BFF00", Slot = "124")]
		public void RpcMaster<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x39BF560", Offset = "0x39BDD60", VA = "0x1839BF560", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x39BD510", Offset = "0x39BBD10", VA = "0x1839BD510", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x39C2980", Offset = "0x39C1180", VA = "0x1839C2980", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x39BB800", Offset = "0x39BA000", VA = "0x1839BB800", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x39BA630", Offset = "0x39B8E30", VA = "0x1839BA630", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x39B9230", Offset = "0x39B7A30", VA = "0x1839B9230", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x39B86E0", Offset = "0x39B6EE0", VA = "0x1839B86E0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x39B63A0", Offset = "0x39B4BA0", VA = "0x1839B63A0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x39B48E0", Offset = "0x39B30E0", VA = "0x1839B48E0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x39CB7C0", Offset = "0x39C9FC0", VA = "0x1839CB7C0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x39CA7F0", Offset = "0x39C8FF0", VA = "0x1839CA7F0", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x39C76E0", Offset = "0x39C5EE0", VA = "0x1839C76E0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x836A590", Offset = "0x8368D90", VA = "0x18836A590", Slot = "137")]
		public void RpcAuthority(UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x399CE60", Offset = "0x399B660", VA = "0x18399CE60", Slot = "138")]
		public void RpcAuthority<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x39AF4C0", Offset = "0x39ADCC0", VA = "0x1839AF4C0", Slot = "139")]
		public void RpcAuthority<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x39AFC30", Offset = "0x39AE430", VA = "0x1839AFC30", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x39AF1C0", Offset = "0x39AD9C0", VA = "0x1839AF1C0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x399CAC0", Offset = "0x399B2C0", VA = "0x18399CAC0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x39AA870", Offset = "0x39A9070", VA = "0x1839AA870", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x39A8E10", Offset = "0x39A7610", VA = "0x1839A8E10", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x39A79B0", Offset = "0x39A61B0", VA = "0x1839A79B0", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x39A6310", Offset = "0x39A4B10", VA = "0x1839A6310", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x39A4A30", Offset = "0x39A3230", VA = "0x1839A4A30", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x39B0AE0", Offset = "0x39AF2E0", VA = "0x1839B0AE0", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x39ADF30", Offset = "0x39AC730", VA = "0x1839ADF30", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x399F210", Offset = "0x399DA10", VA = "0x18399F210", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x399D010", Offset = "0x399B810", VA = "0x18399D010", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x836A330", Offset = "0x8368B30", VA = "0x18836A330", Slot = "152")]
		public void RpcAuthority(UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x39ADC70", Offset = "0x39AC470", VA = "0x1839ADC70", Slot = "153")]
		public void RpcAuthority<T1>(UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x39AD640", Offset = "0x39ABE40", VA = "0x1839AD640", Slot = "154")]
		public void RpcAuthority<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x39ACE00", Offset = "0x39AB600", VA = "0x1839ACE00", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x39AC390", Offset = "0x39AAB90", VA = "0x1839AC390", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x39AB040", Offset = "0x39A9840", VA = "0x1839AB040", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x39AA050", Offset = "0x39A8850", VA = "0x1839AA050", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x39A9710", Offset = "0x39A7F10", VA = "0x1839A9710", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x39A83B0", Offset = "0x39A6BB0", VA = "0x1839A83B0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x39A6E30", Offset = "0x39A5630", VA = "0x1839A6E30", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x39A5670", Offset = "0x39A3E70", VA = "0x1839A5670", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39A2F20", Offset = "0x39A1720", VA = "0x1839A2F20", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x39A2040", Offset = "0x39A0840", VA = "0x1839A2040", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x39A01B0", Offset = "0x399E9B0", VA = "0x1839A01B0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x399E0E0", Offset = "0x399C8E0", VA = "0x18399E0E0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x836AEF0", Offset = "0x83696F0", VA = "0x18836AEF0", Slot = "17")]
		public void RpcPlayer(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x39DC0A0", Offset = "0x39DA8A0", VA = "0x1839DC0A0", Slot = "18")]
		public void RpcPlayer<T1>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x39DCD40", Offset = "0x39DB540", VA = "0x1839DCD40", Slot = "19")]
		public void RpcPlayer<T1, T2>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x39DC7C0", Offset = "0x39DAFC0", VA = "0x1839DC7C0", Slot = "20")]
		public void RpcPlayer<T1, T2, T3>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x39DC260", Offset = "0x39DAA60", VA = "0x1839DC260", Slot = "21")]
		public void RpcPlayer<T1, T2, T3, T4>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x39F1250", Offset = "0x39EFA50", VA = "0x1839F1250", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x39F0E40", Offset = "0x39EF640", VA = "0x1839F0E40", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x39F15E0", Offset = "0x39EFDE0", VA = "0x1839F15E0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x39F1A50", Offset = "0x39F0250", VA = "0x1839F1A50", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x39E86B0", Offset = "0x39E6EB0", VA = "0x1839E86B0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x39E6DD0", Offset = "0x39E55D0", VA = "0x1839E6DD0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x39DD590", Offset = "0x39DBD90", VA = "0x1839DD590", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x39E4420", Offset = "0x39E2C20", VA = "0x1839E4420", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x39F64B0", Offset = "0x39F4CB0", VA = "0x1839F64B0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x39DF330", Offset = "0x39DDB30", VA = "0x1839DF330", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x836B0E0", Offset = "0x83698E0", VA = "0x18836B0E0", Slot = "176")]
		public void RpcPlayer(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x39DC5B0", Offset = "0x39DADB0", VA = "0x1839DC5B0", Slot = "177")]
		public void RpcPlayer<T1>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x39DD2D0", Offset = "0x39DBAD0", VA = "0x1839DD2D0", Slot = "23")]
		public void RpcPlayer<T1, T2>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x39DCF90", Offset = "0x39DB790", VA = "0x1839DCF90", Slot = "24")]
		public void RpcPlayer<T1, T2, T3>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x39DEBA0", Offset = "0x39DD3A0", VA = "0x1839DEBA0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x39ED3E0", Offset = "0x39EBBE0", VA = "0x1839ED3E0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x39ECBB0", Offset = "0x39EB3B0", VA = "0x1839ECBB0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x39EB1B0", Offset = "0x39E99B0", VA = "0x1839EB1B0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x39E9D50", Offset = "0x39E8550", VA = "0x1839E9D50", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x39E91D0", Offset = "0x39E79D0", VA = "0x1839E91D0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x39E7A10", Offset = "0x39E6210", VA = "0x1839E7A10", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x39E52B0", Offset = "0x39E3AB0", VA = "0x1839E52B0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x39E3530", Offset = "0x39E1D30", VA = "0x1839E3530", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x39E1560", Offset = "0x39DFD60", VA = "0x1839E1560", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x39E0410", Offset = "0x39DEC10", VA = "0x1839E0410", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8369BF0", Offset = "0x83683F0", VA = "0x188369BF0", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x397CD40", Offset = "0x397B540", VA = "0x18397CD40", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x397CAF0", Offset = "0x397B2F0", VA = "0x18397CAF0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x397C7D0", Offset = "0x397AFD0", VA = "0x18397C7D0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x397C3F0", Offset = "0x397ABF0", VA = "0x18397C3F0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x397BF40", Offset = "0x397A740", VA = "0x18397BF40", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x397B9C0", Offset = "0x397A1C0", VA = "0x18397B9C0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x397B390", Offset = "0x3979B90", VA = "0x18397B390", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x397AC90", Offset = "0x3979490", VA = "0x18397AC90", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x397A4D0", Offset = "0x3978CD0", VA = "0x18397A4D0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3979C40", Offset = "0x3978440", VA = "0x183979C40", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x39792F0", Offset = "0x3977AF0", VA = "0x1839792F0", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x39788E0", Offset = "0x39770E0", VA = "0x1839788E0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3977E00", Offset = "0x3976600", VA = "0x183977E00", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3977250", Offset = "0x3975A50", VA = "0x183977250", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8369C90", Offset = "0x8368490", VA = "0x188369C90", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x397CD40", Offset = "0x397B540", VA = "0x18397CD40", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x397CAF0", Offset = "0x397B2F0", VA = "0x18397CAF0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x397C7D0", Offset = "0x397AFD0", VA = "0x18397C7D0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x397C3F0", Offset = "0x397ABF0", VA = "0x18397C3F0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x397BF40", Offset = "0x397A740", VA = "0x18397BF40", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x397B9C0", Offset = "0x397A1C0", VA = "0x18397B9C0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x397B390", Offset = "0x3979B90", VA = "0x18397B390", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x397AC90", Offset = "0x3979490", VA = "0x18397AC90", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x397A4D0", Offset = "0x3978CD0", VA = "0x18397A4D0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3979C40", Offset = "0x3978440", VA = "0x183979C40", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x39792F0", Offset = "0x3977AF0", VA = "0x1839792F0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x39788E0", Offset = "0x39770E0", VA = "0x1839788E0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3977E00", Offset = "0x3976600", VA = "0x183977E00", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3977250", Offset = "0x3975A50", VA = "0x183977250", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x836AB10", Offset = "0x8369310", VA = "0x18836AB10", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x39D2170", Offset = "0x39D0970", VA = "0x1839D2170", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x39D1F20", Offset = "0x39D0720", VA = "0x1839D1F20", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x39D1C00", Offset = "0x39D0400", VA = "0x1839D1C00", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x39D1810", Offset = "0x39D0010", VA = "0x1839D1810", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x39D1360", Offset = "0x39CFB60", VA = "0x1839D1360", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x39D0DE0", Offset = "0x39CF5E0", VA = "0x1839D0DE0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x39D07B0", Offset = "0x39CEFB0", VA = "0x1839D07B0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x39D00B0", Offset = "0x39CE8B0", VA = "0x1839D00B0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x39CF8F0", Offset = "0x39CE0F0", VA = "0x1839CF8F0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x39CF060", Offset = "0x39CD860", VA = "0x1839CF060", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x39CE710", Offset = "0x39CCF10", VA = "0x1839CE710", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x39CDD00", Offset = "0x39CC500", VA = "0x1839CDD00", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x39CD220", Offset = "0x39CBA20", VA = "0x1839CD220", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x39CC670", Offset = "0x39CAE70", VA = "0x1839CC670", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x836ABB0", Offset = "0x83693B0", VA = "0x18836ABB0", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x39D2170", Offset = "0x39D0970", VA = "0x1839D2170", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x39D1F20", Offset = "0x39D0720", VA = "0x1839D1F20", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x39D1C00", Offset = "0x39D0400", VA = "0x1839D1C00", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x39D1810", Offset = "0x39D0010", VA = "0x1839D1810", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x39D1360", Offset = "0x39CFB60", VA = "0x1839D1360", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x39D0DE0", Offset = "0x39CF5E0", VA = "0x1839D0DE0", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x39D07B0", Offset = "0x39CEFB0", VA = "0x1839D07B0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x39D00B0", Offset = "0x39CE8B0", VA = "0x1839D00B0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x39CF8F0", Offset = "0x39CE0F0", VA = "0x1839CF8F0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x39CF060", Offset = "0x39CD860", VA = "0x1839CF060", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x39CE710", Offset = "0x39CCF10", VA = "0x1839CE710", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x39CDD00", Offset = "0x39CC500", VA = "0x1839CDD00", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x39CD220", Offset = "0x39CBA20", VA = "0x1839CD220", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x39CC670", Offset = "0x39CAE70", VA = "0x1839CC670", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8367B80", Offset = "0x8366380", VA = "0x188367B80", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8367D80", Offset = "0x8366580", VA = "0x188367D80", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x14D1D80", Offset = "0x14D0580", VA = "0x1814D1D80")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class PWWQECDORVG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8366420", Offset = "0x8364C20", VA = "0x188366420")]
		private static bool CMMUOIKTVUX(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x38BEDB0", Offset = "0x38BD5B0", VA = "0x1838BEDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CGWGTPBDRTH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x835BC50", Offset = "0x835A450", VA = "0x18835BC50")]
			internal int OSIYPUXEPRC(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x835BCD0", Offset = "0x835A4D0", VA = "0x18835BCD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x836C170", Offset = "0x836A970", VA = "0x18836C170")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x836C660", Offset = "0x836AE60", VA = "0x18836C660")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x836C9E0", Offset = "0x836B1E0", VA = "0x18836C9E0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x836CA50", Offset = "0x836B250", VA = "0x18836CA50")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x836C650", Offset = "0x836AE50", VA = "0x18836C650")]
		private void GACKFCPNKPL(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x836C650", Offset = "0x836AE50", VA = "0x18836C650")]
		private void DOLLZZBYIHP(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x836D150", Offset = "0x836B950", VA = "0x18836D150")]
		private void ULBBXHNBDNB(RHIZVYSCBOY a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x836C020", Offset = "0x836A820", VA = "0x18836C020")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x836CAF0", Offset = "0x836B2F0", VA = "0x18836CAF0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x836C560", Offset = "0x836AD60", VA = "0x18836C560")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAB0690", Offset = "0xAAEE90", VA = "0x180AB0690")]
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
		[Cpp2IlInjected.Address(RVA = "0x835C120", Offset = "0x835A920", VA = "0x18835C120")]
		public static int VKIKCVXUSYB(this RHIZVYSCBOY a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x835BD60", Offset = "0x835A560", VA = "0x18835BD60")]
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
			[Cpp2IlInjected.Address(RVA = "0x83621B0", Offset = "0x83609B0", VA = "0x1883621B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x83623F0", Offset = "0x8360BF0", VA = "0x1883623F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback XDVKBVGFFNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x83624B0", Offset = "0x8360CB0", VA = "0x1883624B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x8362330", Offset = "0x8360B30", VA = "0x188362330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback SUEVHMKCLDL
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x8362270", Offset = "0x8360A70", VA = "0x188362270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x8362570", Offset = "0x8360D70", VA = "0x188362570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback CCDHRZEMIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8362030", Offset = "0x8360830", VA = "0x188362030")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x83620F0", Offset = "0x83608F0", VA = "0x1883620F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8370680", Offset = "0x836EE80", VA = "0x188370680")]
		public static void FTITSHBMOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x83706D0", Offset = "0x836EED0", VA = "0x1883706D0")]
		public static void PFODWHCGXOH(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x83707B0", Offset = "0x836EFB0", VA = "0x1883707B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83700C0", Offset = "0x836E8C0", VA = "0x1883700C0", Slot = "4")]
		public bool ZZBOOEVYRWL(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x836E7A0", Offset = "0x836CFA0", VA = "0x18836E7A0", Slot = "5")]
		public int WLBWSFWHPNN(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x836DA60", Offset = "0x836C260", VA = "0x18836DA60", Slot = "6")]
		public bool HGMRPFSDVDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x836DFD0", Offset = "0x836C7D0", VA = "0x18836DFD0", Slot = "7")]
		public bool LDNOFLHLLXF(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x836E4B0", Offset = "0x836CCB0", VA = "0x18836E4B0", Slot = "8")]
		public void PFIQKUQQBPM(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x836FE70", Offset = "0x836E670", VA = "0x18836FE70", Slot = "9")]
		public bool ZIGKNSHETOG(LWCFHEHHVPK a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x836E180", Offset = "0x836C980", VA = "0x18836E180", Slot = "10")]
		public bool MXMFJLJNVMD(LWCFHEHHVPK a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x836F510", Offset = "0x836DD10", VA = "0x18836F510", Slot = "11")]
		public bool YVPCYTPBLFW(LWCFHEHHVPK a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x836ED70", Offset = "0x836D570", VA = "0x18836ED70", Slot = "12")]
		public void YCDUDGCQYUQ(LWCFHEHHVPK a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x836DC00", Offset = "0x836C400", VA = "0x18836DC00", Slot = "13")]
		public void JBBXQLRMZUT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x836DDC0", Offset = "0x836C5C0", VA = "0x18836DDC0", Slot = "14")]
		public void JMYQTRHEZIL(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x836E6C0", Offset = "0x836CEC0", VA = "0x18836E6C0", Slot = "15")]
		public void PHPQDJKYKAV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x836DAF0", Offset = "0x836C2F0", VA = "0x18836DAF0", Slot = "16")]
		public void IRBSIWXNJME(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x836EBB0", Offset = "0x836D3B0", VA = "0x18836EBB0", Slot = "17")]
		public void XAFMAHYAJZA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x836EFC0", Offset = "0x836D7C0", VA = "0x18836EFC0")]
		private static void YUBSGSUCCHF(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x836F650", Offset = "0x836DE50", VA = "0x18836F650")]
		private static bool ZIGKNSHETOG(Dictionary<object, object> a, RHIZVYSCBOY b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x836DF30", Offset = "0x836C730", VA = "0x18836DF30")]
		private static bool KNWCJOYLKLH(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x836FFE0", Offset = "0x836E7E0", VA = "0x18836FFE0")]
		private static int ZOTLGEVSRYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8364340", Offset = "0x8362B40", VA = "0x188364340", Slot = "4")]
		public void IINMLGXJFGC(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8363E50", Offset = "0x8362650", VA = "0x188363E50", Slot = "5")]
		public bool BSTIYTPZKSW(LWCFHEHHVPK a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8364440", Offset = "0x8362C40", VA = "0x188364440", Slot = "6")]
		public void NBSUAFGFUWY(ViewId a, string b, RpcTarget c, RHIZVYSCBOY d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
