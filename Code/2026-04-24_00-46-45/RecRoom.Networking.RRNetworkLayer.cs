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
		[Cpp2IlInjected.Address(RVA = "0x9AE3BF0", Offset = "0x9AE25F0", VA = "0x189AE3BF0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		private int[] YLRGDEQABQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] YLWNALJXLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset KVULHZCLSVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset KVPEKSIOJKC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x226C780", Offset = "0x226B180", VA = "0x18226C780", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9AFCBC0", Offset = "0x9AFB5C0", VA = "0x189AFCBC0")]
		private void AWUQDEJRHIB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC960", Offset = "0x9AFB360", VA = "0x189AFC960")]
		private void AWPJFXPTXWS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9AFD0D0", Offset = "0x9AFBAD0", VA = "0x189AFD0D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AFD180", Offset = "0x9AFBB80", VA = "0x189AFD180")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class JFYLFTKLOPR
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log UWQWHKDYJXX;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log SVTMTTBNLHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9AE2890", Offset = "0x9AE1290", VA = "0x189AE2890")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface ZKGDYLMGWKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView AGRBJTIBKUI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType LKECTAWUHKF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool AYSDYCCMFUE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "2")]
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
	internal interface PJDFMXBWQWB
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool UJCAYCNBZCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OVVGVQALFPK(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface TKEBYMIRURM : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WSFSWRIEDET(ZKGDYLMGWKP a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QNRHIMHGGAQ(ZKGDYLMGWKP a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(UMGNXMXAJWH.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HCEZSLBLXCR();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SSHIISEMTDS(object a);
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
	public class WXTQLGYKJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), PJDFMXBWQWB> BHZPMFUNLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<ZKGDYLMGWKP> NEPMGBKHKQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> RJZGDTVHEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int NTCTYSWPAIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool PZFXEJETDOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private UMGNXMXAJWH.ApplyNetworkTransform ABMOMLVOELS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream FWXJAVZSSUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker YEZTLSAYWLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker ITOJKDSFTOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] BFADKHRVSGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float QWJBGIUJVBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int FKRSHYWRPHB;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8340", Offset = "0x9AF6D40", VA = "0x189AF8340")]
		public WXTQLGYKJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AF7800", Offset = "0x9AF6200", VA = "0x189AF7800")]
		public void Pause(UMGNXMXAJWH.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AF7780", Offset = "0x9AF6180", VA = "0x189AF7780")]
		public void HCEZSLBLXCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AF79B0", Offset = "0x9AF63B0", VA = "0x189AF79B0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AF6E80", Offset = "0x9AF5880", VA = "0x189AF6E80")]
		public bool Add(ZKGDYLMGWKP networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF7820", Offset = "0x9AF6220", VA = "0x189AF7820")]
		public bool Remove(ZKGDYLMGWKP networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8130", Offset = "0x9AF6B30", VA = "0x189AF8130")]
		private PJDFMXBWQWB VVYMHUIEXJO(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF77F0", Offset = "0x9AF61F0", VA = "0x189AF77F0")]
		public void PDMCSZUBZJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AF7950", Offset = "0x9AF6350", VA = "0x189AF7950")]
		private void USMZDJLKZPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AF77D0", Offset = "0x9AF61D0", VA = "0x189AF77D0")]
		private void JIAAKVZHSMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9AF7D80", Offset = "0x9AF6780", VA = "0x189AF7D80")]
		public bool VGRXSELVBZE(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AF7390", Offset = "0x9AF5D90", VA = "0x189AF7390")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class XKVWSNASVYC : PJDFMXBWQWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ZKGDYLMGWKP FGCBBBDFFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint VRVCTRDOWAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int OBNKCKWVDPQ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool UJCAYCNBZCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public XKVWSNASVYC(ZKGDYLMGWKP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8650", Offset = "0x9AF7050", VA = "0x189AF8650", Slot = "5")]
		public bool OVVGVQALFPK(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8570", Offset = "0x9AF6F70", VA = "0x189AF8570", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SKZJJIZBAAN : PJDFMXBWQWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private UMGNXMXAJWH.ApplyNetworkTransform ABMOMLVOELS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId HDBKQDDKLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int OBNKCKWVDPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint VRVCTRDOWAF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool UJCAYCNBZCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1D39E80", Offset = "0x1D38880", VA = "0x181D39E80")]
		public SKZJJIZBAAN(ViewId a, UMGNXMXAJWH.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA60", Offset = "0x9AEC460", VA = "0x189AEDA60", Slot = "5")]
		public bool OVVGVQALFPK(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9AED880", Offset = "0x9AEC280", VA = "0x189AED880", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class HPOLNFMMWIV
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1CD0", Offset = "0x9AE06D0", VA = "0x189AE1CD0")]
		public static void NZJDRENIZKU(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1660", Offset = "0x9AE0060", VA = "0x189AE1660")]
		public static void AYKBCGCVLQZ(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1B60", Offset = "0x9AE0560", VA = "0x189AE1B60")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1E90", Offset = "0x9AE0890", VA = "0x189AE1E90")]
		public static void WQFLOKMOEEU(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(TKEBYMIRURM), new string[] { })]
	public class HEGGRNTJEVH : TKEBYMIRURM, INetworkUpdateSystem, VKFETTFTWPV, PLILCFKSRWT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log FKJPYFGLEGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private WXTQLGYKJLF QLOLLTCUPZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint XUWQYZGETAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float CBJGXMAVHOT;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1460", Offset = "0x9ADFE60", VA = "0x189AE1460", Slot = "4")]
		public void WSFSWRIEDET(ZKGDYLMGWKP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1200", Offset = "0x9ADFC00", VA = "0x189AE1200", Slot = "5")]
		public void QNRHIMHGGAQ(ZKGDYLMGWKP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0B50", Offset = "0x9ADF550", VA = "0x189AE0B50", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1030", Offset = "0x9ADFA30", VA = "0x189AE1030", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0530", Offset = "0x9ADEF30", VA = "0x189AE0530")]
		private void IUKQASMSIUL(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9AE11D0", Offset = "0x9ADFBD0", VA = "0x189AE11D0", Slot = "6")]
		public void Pause(UMGNXMXAJWH.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9AE04D0", Offset = "0x9ADEED0", VA = "0x189AE04D0", Slot = "7")]
		public void HCEZSLBLXCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1400", Offset = "0x9ADFE00", VA = "0x189AE1400", Slot = "8")]
		public void SSHIISEMTDS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0CA0", Offset = "0x9ADF6A0", VA = "0x189AE0CA0")]
		private void MZPDYTEMTXD(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9AE10B0", Offset = "0x9ADFAB0", VA = "0x189AE10B0", Slot = "11")]
		public void ONYBPXDDZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1580", Offset = "0x9ADFF80", VA = "0x189AE1580")]
		public HEGGRNTJEVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IEQKHMHSLLV : PJDFMXBWQWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float DCVQANKSUEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int OBNKCKWVDPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint VRVCTRDOWAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType RXGNGCQVXKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo JXDAJWVSYBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int CJTWNUPCMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] OFXMVINWCKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo WTZNQNNTYOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int TVSNQSGMJQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] ZTIYBWGREGZ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool UJCAYCNBZCF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE27F0", Offset = "0x9AE11F0", VA = "0x189AE27F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2820", Offset = "0x9AE1220", VA = "0x189AE2820")]
		public IEQKHMHSLLV(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE27B0", Offset = "0x9AE11B0", VA = "0x189AE27B0", Slot = "5")]
		public bool OVVGVQALFPK(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2330", Offset = "0x9AE0D30", VA = "0x189AE2330", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE24E0", Offset = "0x9AE0EE0", VA = "0x189AE24E0")]
		internal XKVWSNASVYC FZGOFAVENHV(ZKGDYLMGWKP a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AE25E0", Offset = "0x9AE0FE0", VA = "0x189AE25E0")]
		private static void GUQJLZKZVCP(XKVWSNASVYC a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class IANPRPMVQRG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2250", Offset = "0x9AE0C50", VA = "0x189AE2250")]
		public static KDSOOWCXYNX GTTZYUPUMGX(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AE22E0", Offset = "0x9AE0CE0", VA = "0x189AE22E0")]
		public static PlayerId ToPlayerId(this KDSOOWCXYNX player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RRNetworkBehavior : MonoBehaviour, KIFQTBBYBUB, PENMSEVEISY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool ANMCEGJYCJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private RRNetworkView QZLMOQDFTOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<PPFVVNKSZNQ> GOKMFPZGUCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FIUTWJFKCIM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId AZSFQEOFQNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7210", Offset = "0x9AE5C10", VA = "0x189AE7210")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId BZAVQXYMJBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7210", Offset = "0x9AE5C10", VA = "0x189AE7210", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView RQVXVLRYGGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7290", Offset = "0x9AE5C90", VA = "0x189AE7290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView AGRBJTIBKUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7290", Offset = "0x9AE5C90", VA = "0x189AE7290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KDSOOWCXYNX UAPTHTBAEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7390", Offset = "0x9AE5D90", VA = "0x189AE7390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KDSOOWCXYNX GXTZTHXXLWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9AE76F0", Offset = "0x9AE60F0", VA = "0x189AE76F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OAYZFEAYCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9AE74F0", Offset = "0x9AE5EF0", VA = "0x189AE74F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PEVSTBRYGLV
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7660", Offset = "0x9AE6060", VA = "0x189AE7660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NNUKVHLVKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7140", Offset = "0x9AE5B40", VA = "0x189AE7140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DVNTBUWZUTF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7420", Offset = "0x9AE5E20", VA = "0x189AE7420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KKEKQWARIXR
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7140", Offset = "0x9AE5B40", VA = "0x189AE7140", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HEYYGZFGLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AE71C0", Offset = "0x9AE5BC0", VA = "0x189AE71C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string NIMTUHLJNWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7300", Offset = "0x9AE5D00", VA = "0x189AE7300", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NMKQSUITEME
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AE70C0", Offset = "0x9AE5AC0", VA = "0x189AE70C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<KDSOOWCXYNX> DWFOTVFDGIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AE6F90", Offset = "0x9AE5990", VA = "0x189AE6F90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7780", Offset = "0x9AE6180", VA = "0x189AE7780")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6EF0", Offset = "0x9AE58F0", VA = "0x189AE6EF0")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6AB0", Offset = "0x9AE54B0", VA = "0x189AE6AB0")]
		private void OLXYXKDJQIV(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6AF0", Offset = "0x9AE54F0", VA = "0x189AE6AF0", Slot = "9")]
		public void RegisterDestroyHandler(PPFVVNKSZNQ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6D30", Offset = "0x9AE5730", VA = "0x189AE6D30", Slot = "10")]
		public void UnregisterDestroyHandler(PPFVVNKSZNQ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6AD0", Offset = "0x9AE54D0", VA = "0x189AE6AD0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class FIOVAECAQNF
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, KDSOOWCXYNX targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, KDSOOWCXYNX targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, KDSOOWCXYNX newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[CompilerGenerated]
		private static InstantiateCallback TTQVUDMVPAR;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback XPUFGXLSXJK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF990", Offset = "0x9ADE390", VA = "0x189ADF990")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF420", Offset = "0x9ADDE20", VA = "0x189ADF420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback ISSOMASACRU
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9ADE7A0", Offset = "0x9ADD1A0", VA = "0x189ADE7A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9ADFA50", Offset = "0x9ADE450", VA = "0x189ADFA50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback QUQJOHQJKVK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9ADED40", Offset = "0x9ADD740", VA = "0x189ADED40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEB00", Offset = "0x9ADD500", VA = "0x189ADEB00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback VCYNNGXIZUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF4E0", Offset = "0x9ADDEE0", VA = "0x189ADF4E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF5A0", Offset = "0x9ADDFA0", VA = "0x189ADF5A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback DOPPKQQASGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9ADE6E0", Offset = "0x9ADD0E0", VA = "0x189ADE6E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF2A0", Offset = "0x9ADDCA0", VA = "0x189ADF2A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback WXTSRSKHEVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF8D0", Offset = "0x9ADE2D0", VA = "0x189ADF8D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEBC0", Offset = "0x9ADD5C0", VA = "0x189ADEBC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback LZDFXTZRSRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEE00", Offset = "0x9ADD800", VA = "0x189ADEE00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF360", Offset = "0x9ADDD60", VA = "0x189ADF360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler ZKHQRCMUIBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEC80", Offset = "0x9ADD680", VA = "0x189ADEC80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF1E0", Offset = "0x9ADDBE0", VA = "0x189ADF1E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler HBBCNIHEWWX
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9ADE860", Offset = "0x9ADD260", VA = "0x189ADE860")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEA40", Offset = "0x9ADD440", VA = "0x189ADEA40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEEC0", Offset = "0x9ADD8C0", VA = "0x189ADEEC0")]
		public static void ORZRRVANTDZ([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE920", Offset = "0x9ADD320", VA = "0x189ADE920")]
		public static void FNKXLRPAVBF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE9B0", Offset = "0x9ADD3B0", VA = "0x189ADE9B0")]
		public static void GLEWZQAPEDU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF7B0", Offset = "0x9ADE1B0", VA = "0x189ADF7B0")]
		public static void WVTVLNRGTNL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF840", Offset = "0x9ADE240", VA = "0x189ADF840")]
		public static void XVBFZPFVIGU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF660", Offset = "0x9ADE060", VA = "0x189ADF660")]
		public static void WHKZEYHNJHY(RRNetworkView a, string b, KDSOOWCXYNX c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF090", Offset = "0x9ADDA90", VA = "0x189ADF090")]
		public static void RRRPUPNUYZH(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEF80", Offset = "0x9ADD980", VA = "0x189ADEF80")]
		public static void RAUDXHRWYJD(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class LFETJXUHPXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3A80", Offset = "0x9AE2480", VA = "0x189AE3A80")]
		[CanBeNull]
		private static bool HRDRFIJOHDG(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3930", Offset = "0x9AE2330", VA = "0x189AE3930")]
		[CanBeNull]
		public static Component ETRWYEGGQPS(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A7F0", Offset = "0x3C091F0", VA = "0x183C0A7F0")]
		[CanBeNull]
		public static a ETRWYEGGQPS<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A860", Offset = "0x3C09260", VA = "0x183C0A860")]
		[CanBeNull]
		public static b LMRRXUEZMLS<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A980", Offset = "0x3C09380", VA = "0x183C0A980")]
		public static bool OJWZLQKTLSD<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3A10", Offset = "0x9AE2410", VA = "0x189AE3A10")]
		[CanBeNull]
		public static RRNetworkView EUXSCPRPWNX(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static RRNetworkHandler OEISXJMFTFD;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7930", Offset = "0x9AE6330", VA = "0x189AE7930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9AE78F0", Offset = "0x9AE62F0", VA = "0x189AE78F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE78B0", Offset = "0x9AE62B0", VA = "0x189AE78B0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RegisterService(typeof(SVAHFTVBEYU), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class SVAHFTVBEYU : YVPMBYMROHF, VKFETTFTWPV, PLILCFKSRWT, FIGEDIDLMZD, NMBRFEVQYMV, KZDQEQUQNCZ, PGANNZBSSYB
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class XUQBWUXHYTS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int IIDLMPSXTCO;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XUQBWUXHYTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9AF8760", Offset = "0x9AF7160", VA = "0x189AF8760")]
			internal object JITPWPXKYIX((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static Log FFRYTBUEJHJ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static Log LJEJBHOFHVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private FMUUXLFNHQM KAXXFIYNQHX;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static BSKWJXIHMZF TJNSOUCIQSC;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static Dictionary<int, HashSet<int>> EVFULJZFOGH;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static Dictionary<int, int> BFERQABUGOE;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly List<(GameObject GameObject, int ParentCount)> FRYUKNLNUID;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly List<GameObject> DTUDECIFXOY;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static List<int> CKUMDHXASSM;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly List<RRNetworkView> QNCPIBCWLVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private ZOJPPDKVFNP DFSECTKIVUE;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly CBEOKZVPQNC YKEHAJQXVAY;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly CBEOKZVPQNC TPRURBSDPOJ;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF720", Offset = "0x9AEE120", VA = "0x189AEF720", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0AB0", Offset = "0x9AEF4B0", VA = "0x189AF0AB0", Slot = "9")]
		public void ONYBPXDDZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF610", Offset = "0x9AEE010", VA = "0x189AEF610", Slot = "10")]
		public void InitExternal(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4640", Offset = "0x9AF3040", VA = "0x189AF4640", Slot = "11")]
		public void TTKGXOYTYRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE0A0", Offset = "0x9AECAA0", VA = "0x189AEE0A0")]
		private void BCYFIDNCHJP(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4D80", Offset = "0x9AF3780", VA = "0x189AF4D80")]
		public GameObject VCEYFMZSNYS(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AF08B0", Offset = "0x9AEF2B0", VA = "0x189AF08B0")]
		public GameObject NJFPSSBRCRC(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE340", Offset = "0x9AECD40", VA = "0x189AEE340")]
		public GameObject DEHLGPTNCFP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE110", Offset = "0x9AECB10", VA = "0x189AEE110")]
		public GameObject BFUWNKQCRHR(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9AF37A0", Offset = "0x9AF21A0", VA = "0x189AF37A0", Slot = "6")]
		public void RZQPTSGPRFN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF5A0", Offset = "0x9AEDFA0", VA = "0x189AEF5A0")]
		public void IKOUOAERFUK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9AF08A0", Offset = "0x9AEF2A0", VA = "0x189AF08A0", Slot = "7")]
		public void NDZCIWOJAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9AF24B0", Offset = "0x9AF0EB0", VA = "0x189AF24B0", Slot = "4")]
		public GameObject[] PTJPDMCELRF(IList<DYUPRJOGCEW> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF1D0", Offset = "0x9AEDBD0", VA = "0x189AEF1D0", Slot = "5")]
		public void GHXBTNFPIQS(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE5C0", Offset = "0x9AECFC0", VA = "0x189AEE5C0")]
		public void DGPODCSTBSO(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9AF05C0", Offset = "0x9AEEFC0", VA = "0x189AF05C0")]
		private void MZPDYTEMTXD(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE1A0", Offset = "0x9AECBA0", VA = "0x189AEE1A0")]
		private void CMQXIFVFXHF(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF37B0", Offset = "0x9AF21B0", VA = "0x189AF37B0")]
		private void SBDXQLSURHT(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5ED0", Offset = "0x9AF48D0", VA = "0x189AF5ED0")]
		private void WYAUXURYCCP(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4250", Offset = "0x9AF2C50", VA = "0x189AF4250")]
		private void TOQMXFNVQPF(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF20", Offset = "0x9AEE920", VA = "0x189AEFF20")]
		private void KDNBNATFRAR(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF47A0", Offset = "0x9AF31A0", VA = "0x189AF47A0")]
		private void UYMVSHBPRNJ(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9AF00F0", Offset = "0x9AEEAF0", VA = "0x189AF00F0")]
		private GameObject KNNZJKISRVI(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9AF57F0", Offset = "0x9AF41F0", VA = "0x189AF57F0")]
		private GameObject WAOAIVEEGXW(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9AF6150", Offset = "0x9AF4B50", VA = "0x189AF6150")]
		private static GameObject XNLUHUXDSPC(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9AF39F0", Offset = "0x9AF23F0", VA = "0x189AF39F0")]
		private static GameObject SOQMBOMYXUF(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3FF0", Offset = "0x9AF29F0", VA = "0x189AF3FF0")]
		private static void SZOHOMCPNPK(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1D00", Offset = "0x9AF0700", VA = "0x189AF1D00")]
		private GameObject[] PRDCONJLOBJ(IList<DYUPRJOGCEW> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4F50", Offset = "0x9AF3950", VA = "0x189AF4F50")]
		private GameObject[] VCSCXIQRYYZ(InstantiateParameters[] a, int b, KDSOOWCXYNX c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB10", Offset = "0x9AEE510", VA = "0x189AEFB10")]
		private GameObject JPLZGHYWKLV([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4780", Offset = "0x9AF3180", VA = "0x189AF4780")]
		private static bool UOEHWGPIFQQ(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1120", Offset = "0x9AEFB20", VA = "0x189AF1120")]
		private void PCVRZEFDBEW(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9AF28E0", Offset = "0x9AF12E0", VA = "0x189AF28E0")]
		private void RSCLELHAIEA(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3C00", Offset = "0x9AF2600", VA = "0x189AF3C00")]
		private static void SULYRCJOAUZ(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4100", Offset = "0x9AF2B00", VA = "0x189AF4100")]
		private void TCULYRGKOMH(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0520", Offset = "0x9AEEF20", VA = "0x189AF0520")]
		private static int MZOVXXLPDCJ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE140", Offset = "0x9AECB40", VA = "0x189AEE140")]
		private void CHYTZHVEXQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5270", Offset = "0x9AF3C70", VA = "0x189AF5270")]
		private void VOUJZDPRSDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5210", Offset = "0x9AF3C10", VA = "0x189AF5210")]
		private static int VKSCLUXOBIZ(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9AF6250", Offset = "0x9AF4C50", VA = "0x189AF6250")]
		private static int[] ZQOQAKDSFMU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9AF27E0", Offset = "0x9AF11E0", VA = "0x189AF27E0")]
		private static int[] QZNFVLNULMG(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AF10E0", Offset = "0x9AEFAE0", VA = "0x189AF10E0")]
		private void OnMasterClientSwitched(KDSOOWCXYNX newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE740", Offset = "0x9AED140", VA = "0x189AEE740")]
		private void FNEWKEQLRSE(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0E00", Offset = "0x9AEF800", VA = "0x189AF0E00")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AF02E0", Offset = "0x9AEECE0", VA = "0x189AF02E0")]
		private void KZQFCCFLZQI(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE6A0", Offset = "0x9AED0A0", VA = "0x189AEE6A0")]
		private static void FKQNQVVWSWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9AF09B0", Offset = "0x9AEF3B0", VA = "0x189AF09B0")]
		private void NNEQJCQFKPS(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4730", Offset = "0x9AF3130", VA = "0x189AF4730", Slot = "12")]
		private void UBCVDPRMWRT(VBPLBVQDNMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xF8A2E0", Offset = "0xF88CE0", VA = "0x180F8A2E0", Slot = "13")]
		private void UYXNLSZGBZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public SVAHFTVBEYU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RegisterService(typeof(ZIKDPGRVQWC), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class ZIKDPGRVQWC : VKFETTFTWPV, PLILCFKSRWT, YRGGLPTVQOD, YMKBVOLYXIE, DUHJSGRNEWU
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
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9AED860", Offset = "0x9AEC260", VA = "0x189AED860")]
			public object AWCWYNRWLEA(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class ZNFZFMCQBYN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public FieldInfo XLLRGRIMWOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Func<MonoBehaviour, object> XZIAYVAGGLQ;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ZNFZFMCQBYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9AFC8A0", Offset = "0x9AFB2A0", VA = "0x189AFC8A0")]
			internal RpcMethodInfo GBUZQNBYUVI(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x75D8590", Offset = "0x75D6F90", VA = "0x1875D8590")]
			internal object GCAGNTVWEGR(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class ZNASIFISSNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Func<MonoBehaviour, object> ZKNUERQPTVP;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ZNASIFISSNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9AFC850", Offset = "0x9AFB250", VA = "0x189AFC850")]
			internal RpcMethodInfo GAUREFGLZQP(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class XKNHXSJBZBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Type APYRNMJMIXU;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XKNHXSJBZBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9AF8530", Offset = "0x9AF6F30", VA = "0x189AF8530")]
			internal bool PAOQOHPSYTY(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static Dictionary<string, int> PEGGBSUHNBC;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static List<string> LBJPRMNBQHD;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static int FPWGDKUNTBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private LOPPTEIYDKP JBHGWSBMPBU;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Stopwatch ZDBTQLDCZAM;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static Dictionary<MethodInfo, ParameterInfo[]> UYBUSHUOTOH;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> LOCZOEGKTTC;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9DA0", Offset = "0x9AF87A0", VA = "0x189AF9DA0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB560", Offset = "0x9AF9F60", VA = "0x189AFB560")]
		private void KOZPGKPOYZB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9EA0", Offset = "0x9AF88A0", VA = "0x189AF9EA0", Slot = "10")]
		public void InitReferences(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xF8A2E0", Offset = "0xF88CE0", VA = "0x180F8A2E0", Slot = "11")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBEB0", Offset = "0x9AFA8B0", VA = "0x189AFBEB0", Slot = "5")]
		public void ONYBPXDDZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8BE0", Offset = "0x9AF75E0", VA = "0x189AF8BE0")]
		public static bool BSFLZEZDWUA(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9CB0", Offset = "0x9AF86B0", VA = "0x189AF9CB0")]
		public static bool IIJXXLJXHXW(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB30", Offset = "0x9AFA530", VA = "0x189AFBB30")]
		private void MZPDYTEMTXD(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC5B0", Offset = "0x9AFAFB0", VA = "0x189AFC5B0", Slot = "9")]
		public string XNXIPPYNOHC(EPOORIVUAQX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AF99F0", Offset = "0x9AF83F0", VA = "0x189AF99F0", Slot = "8")]
		public void GUAARKLHPPJ(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC4B0", Offset = "0x9AFAEB0", VA = "0x189AFC4B0", Slot = "6")]
		public void UJWWJMJCTRX(ViewId a, string b, KDSOOWCXYNX c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC580", Offset = "0x9AFAF80", VA = "0x189AFC580", Slot = "7")]
		public void UJWWJMJCTRX(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC000", Offset = "0x9AFAA00", VA = "0x189AFC000")]
		private void UJWWJMJCTRX(ViewId a, string b, RpcTarget c, KDSOOWCXYNX d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9EF0", Offset = "0x9AF88F0", VA = "0x189AF9EF0")]
		private void KFYISACOTIQ(ViewId a, string b, KDSOOWCXYNX c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8C70", Offset = "0x9AF7670", VA = "0x189AF8C70")]
		private static void CBFTWYTPTAU(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9AA0", Offset = "0x9AF84A0", VA = "0x189AF9AA0")]
		private static bool IHZCMYSYJFR(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9130", Offset = "0x9AF7B30", VA = "0x189AF9130")]
		private List<RpcMethodInfo> EXWASNTDZVI(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBDB0", Offset = "0x9AFA7B0", VA = "0x189AFBDB0")]
		private static IEnumerable<MethodInfo> OGXYHKEOKIM(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBA20", Offset = "0x9AFA420", VA = "0x189AFBA20")]
		public static ParameterInfo[] MRWKKQIPCGQ(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ZIKDPGRVQWC()
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
			[Cpp2IlInjected.Address(RVA = "0x9AE7B40", Offset = "0x9AE6540", VA = "0x189AE7B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7AC0", Offset = "0x9AE64C0", VA = "0x189AE7AC0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RRNetworkView : MonoBehaviour, DOIVUUSAOOU, UOKKAIDFHVP, CGZDUARXCHU, PVNROETDIYK, YUCDALFBEZL
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[RegisterService(typeof(FMUUXLFNHQM), new string[] { })]
		internal class FQARDHSLRDL : VKFETTFTWPV, PLILCFKSRWT, FMUUXLFNHQM
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Dictionary<int, RRNetworkView> GJEMIMTDBQG;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x9ADFB10", Offset = "0x9ADE510", VA = "0x189ADFB10", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x9ADFB10", Offset = "0x9ADE510", VA = "0x189ADFB10", Slot = "5")]
			public void ONYBPXDDZTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x9ADFB20", Offset = "0x9ADE520", VA = "0x189ADFB20", Slot = "6")]
			public void YEPWWIXQWMW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public FQARDHSLRDL()
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
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int ORKVZISZQEG;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x9ADE680", Offset = "0x9ADD080", VA = "0x189ADE680")]
			internal bool VRRFXPVGBNI(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static CBEOKZVPQNC EKDONELBRHA;

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
		private bool QQZPFRHULZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool MDRGXVZVGXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool LXYLOZYUWIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int NIOGPFKNZOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool UCBOSIYIKFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int JKDGAAEXKMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private KDSOOWCXYNX GXTZTHXXLWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KDSOOWCXYNX XZIWQLFJTJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool? RGNAXPZOTBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool PGLCAQGLHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal bool MNKWMPNCJBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal MonoBehaviour[] YQTWPFLHRSO;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Log WOBYKJOJGHZ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> GJEMIMTDBQG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9AE82E0", Offset = "0x9AE6CE0", VA = "0x189AE82E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId BZAVQXYMJBR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC1D0", Offset = "0x9AEABD0", VA = "0x189AEC1D0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId BXSDRUYDYGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC1D0", Offset = "0x9AEABD0", VA = "0x189AEC1D0", Slot = "6")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId AZSFQEOFQNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC1D0", Offset = "0x9AEABD0", VA = "0x189AEC1D0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int BRFRBMLKIHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD67210", Offset = "0xD65C10", VA = "0x180D67210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int UIOKIEGPPHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD39090", Offset = "0xD37A90", VA = "0x180D39090")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xF22B20", Offset = "0xF21520", VA = "0x180F22B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId LKLEISGSGYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC040", Offset = "0x9AEAA40", VA = "0x189AEC040")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool VFJXVHTBDRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xDA45D0", Offset = "0xDA2FD0", VA = "0x180DA45D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xDA45E0", Offset = "0xDA2FE0", VA = "0x180DA45E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool SGTHTKGBEMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC050", Offset = "0x9AEAA50", VA = "0x189AEC050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool ATHGMMUTZZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xD70630", Offset = "0xD6F030", VA = "0x180D70630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int MHGUWETLSJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD61B70", Offset = "0xD60570", VA = "0x180D61B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int PXVYUKOWJAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBFE0", Offset = "0x9AEA9E0", VA = "0x189AEBFE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public KDSOOWCXYNX TIHIGXPNWXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC1E0", Offset = "0x9AEABE0", VA = "0x189AEC1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public KDSOOWCXYNX CFGPIWWKEWS
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBFB0", Offset = "0x9AEA9B0", VA = "0x189AEBFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public KDSOOWCXYNX UAPTHTBAEAP
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBFB0", Offset = "0x9AEA9B0", VA = "0x189AEBFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public KDSOOWCXYNX ZQWLDRDZSVN
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBFB0", Offset = "0x9AEA9B0", VA = "0x189AEBFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool SAITEYZOUXR
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC120", Offset = "0x9AEAB20", VA = "0x189AEC120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int UDONKISDOYX
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC010", Offset = "0x9AEAA10", VA = "0x189AEC010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] UOFDNEXEEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xD141E0", Offset = "0xD12BE0", VA = "0x180D141E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OAYZFEAYCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC210", Offset = "0x9AEAC10", VA = "0x189AEC210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OKNMOLBSLHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC1A0", Offset = "0x9AEABA0", VA = "0x189AEC1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JFPDTLGEIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xFD0570", Offset = "0xFCEF70", VA = "0x180FD0570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xFD06A0", Offset = "0xFCF0A0", VA = "0x180FD06A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool WBPMVWTIPDO
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xFCEFE0", Offset = "0xFCD9E0", VA = "0x180FCEFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> CYALSNNFZVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBE40", Offset = "0x9AEA840", VA = "0x189AEBE40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC3D0", Offset = "0x9AEADD0", VA = "0x189AEC3D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<KDSOOWCXYNX> KWCEHESCBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9AE8230", Offset = "0x9AE6C30", VA = "0x189AE8230")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9080", Offset = "0x9AE7A80", VA = "0x189AE9080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<KDSOOWCXYNX> LBVGVKWDWAG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE8230", Offset = "0x9AE6C30", VA = "0x189AE8230")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9080", Offset = "0x9AE7A80", VA = "0x189AE9080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> DLOLHLJVVMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBC10", Offset = "0x9AEA610", VA = "0x189AEBC10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBB60", Offset = "0x9AEA560", VA = "0x189AEBB60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> EGXIBRGLTNX
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBC10", Offset = "0x9AEA610", VA = "0x189AEBC10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBB60", Offset = "0x9AEA560", VA = "0x189AEBB60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> BGGDAZXXTTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBEF0", Offset = "0x9AEA8F0", VA = "0x189AEBEF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC480", Offset = "0x9AEAE80", VA = "0x189AEC480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action PFJCSBWUCBD
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEBD90", Offset = "0x9AEA790", VA = "0x189AEBD90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC320", Offset = "0x9AEAD20", VA = "0x189AEC320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB670", Offset = "0x9AEA070", VA = "0x189AEB670")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8330", Offset = "0x9AE6D30", VA = "0x189AE8330")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9AE84A0", Offset = "0x9AE6EA0", VA = "0x189AE84A0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9AE83F0", Offset = "0x9AE6DF0", VA = "0x189AE83F0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9AB0", Offset = "0x9AE84B0", VA = "0x189AE9AB0")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9850", Offset = "0x9AE8250", VA = "0x189AE9850")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9280", Offset = "0x9AE7C80", VA = "0x189AE9280")]
		public static void OnPlayerJoinedRoom(KDSOOWCXYNX newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8610", Offset = "0x9AE7010", VA = "0x189AE8610")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8670", Offset = "0x9AE7070", VA = "0x189AE8670")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8C50", Offset = "0x9AE7650", VA = "0x189AE8C50")]
		private void JKTSFGPUTSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8040", Offset = "0x9AE6A40", VA = "0x189AE8040")]
		public bool CreatedBy(KDSOOWCXYNX player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB480", Offset = "0x9AE9E80", VA = "0x189AEB480")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB420", Offset = "0x9AE9E20", VA = "0x189AEB420")]
		public void TransferOwnership(KDSOOWCXYNX newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8860", Offset = "0x9AE7260", VA = "0x189AE8860", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8800", Offset = "0x9AE7200", VA = "0x189AE8800")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7CB0", Offset = "0x9AE66B0", VA = "0x189AE7CB0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9AE89D0", Offset = "0x9AE73D0", VA = "0x189AE89D0")]
		private void JBIUESGDIRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1366210", Offset = "0x1364C10", VA = "0x181366210")]
		internal void DKYEUWSJJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7D70", Offset = "0x9AE6770", VA = "0x189AE7D70", Slot = "7")]
		private void CEUHNCIPJQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8790", Offset = "0x9AE7190", VA = "0x189AE8790")]
		internal bool IZMIARDIMZE(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9140", Offset = "0x9AE7B40", VA = "0x189AE9140")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9AE81D0", Offset = "0x9AE6BD0", VA = "0x189AE81D0")]
		internal void ENBOALSDZUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9130", Offset = "0x9AE7B30", VA = "0x189AE9130")]
		private void NYRPPMKRTFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9AE86D0", Offset = "0x9AE70D0", VA = "0x189AE86D0")]
		internal void HUWGJIKLHMA(KDSOOWCXYNX a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9A10", Offset = "0x9AE8410", VA = "0x189AE9A10")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9B60", Offset = "0x9AE8560", VA = "0x189AE9B60")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBAC0", Offset = "0x9AEA4C0", VA = "0x189AEBAC0")]
		private void ZAQWLZNHDVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8F90", Offset = "0x9AE7990", VA = "0x189AE8F90")]
		private void MDAVMBJEWPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9730", Offset = "0x9AE8130", VA = "0x189AE9730")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9AE97C0", Offset = "0x9AE81C0", VA = "0x189AE97C0")]
		public void RPC(string methodName, KDSOOWCXYNX targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9A60", Offset = "0x9AE8460", VA = "0x189AE9A60")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7D00", Offset = "0x9AE6700", VA = "0x189AE7D00", Slot = "9")]
		public void Bake(QQYPAOLAOXV context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE95F0", Offset = "0x9AE7FF0", VA = "0x189AE95F0")]
		private static void RCQKOFWDMMV(KDSOOWCXYNX a, [Out] KDSOOWCXYNX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB730", Offset = "0x9AEA130", VA = "0x189AEB730")]
		private static void UHMTAYFMYRK(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D30", Offset = "0x9AE7730", VA = "0x189AE8D30")]
		private static RPCInfo JYATEFOTFCJ(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8EB0", Offset = "0x9AE78B0", VA = "0x189AE8EB0")]
		private static void LTQBVBTYZHV(RRNetworkView a, Delegate b, KDSOOWCXYNX c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8DD0", Offset = "0x9AE77D0", VA = "0x189AE8DD0")]
		private static void LTQBVBTYZHV(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9AE80C0", Offset = "0x9AE6AC0", VA = "0x189AE80C0")]
		private static void DFFJOUZSEXW(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9660", Offset = "0x9AE8060", VA = "0x189AE9660")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBA20", Offset = "0x9AEA420", VA = "0x189AEBA20")]
		private static bool YZTPFZASGCR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA010", Offset = "0x9AE8A10", VA = "0x189AEA010", Slot = "26")]
		public void RpcAll(QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A430", Offset = "0x3E58E30", VA = "0x183E5A430", Slot = "10")]
		public void RpcAll<T1>(QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E59D10", Offset = "0x3E58710", VA = "0x183E59D10", Slot = "11")]
		public void RpcAll<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C680", Offset = "0x3E5B080", VA = "0x183E5C680", Slot = "27")]
		public void RpcAll<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3E59F00", Offset = "0x3E58900", VA = "0x183E59F00", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3E5AA60", Offset = "0x3E59460", VA = "0x183E5AA60", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3E5CB30", Offset = "0x3E5B530", VA = "0x183E5CB30", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A5A0", Offset = "0x3E58FA0", VA = "0x183E5A5A0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3E713C0", Offset = "0x3E6FDC0", VA = "0x183E713C0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3E5CF60", Offset = "0x3E5B960", VA = "0x183E5CF60", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3E5B7C0", Offset = "0x3E5A1C0", VA = "0x183E5B7C0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E75F30", Offset = "0x3E74930", VA = "0x183E75F30", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3E6E980", Offset = "0x3E6D380", VA = "0x183E6E980", Slot = "14")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3E60D10", Offset = "0x3E5F710", VA = "0x183E60D10", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3E5AFE0", Offset = "0x3E599E0", VA = "0x183E5AFE0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA180", Offset = "0x9AE8B80", VA = "0x189AEA180", Slot = "36")]
		public void RpcAll(QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F510", Offset = "0x3E6DF10", VA = "0x183E6F510", Slot = "37")]
		public void RpcAll<T1>(QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F030", Offset = "0x3E6DA30", VA = "0x183E6F030", Slot = "38")]
		public void RpcAll<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3E5BFE0", Offset = "0x3E5A9E0", VA = "0x183E5BFE0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3E6BF50", Offset = "0x3E6A950", VA = "0x183E6BF50", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B270", Offset = "0x3E69C70", VA = "0x183E6B270", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A360", Offset = "0x3E68D60", VA = "0x183E6A360", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3E69AA0", Offset = "0x3E684A0", VA = "0x183E69AA0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3E67ED0", Offset = "0x3E668D0", VA = "0x183E67ED0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3E66960", Offset = "0x3E65360", VA = "0x183E66960", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3E65D60", Offset = "0x3E64760", VA = "0x183E65D60", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3E63800", Offset = "0x3E62200", VA = "0x183E63800", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3E629D0", Offset = "0x3E613D0", VA = "0x183E629D0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3E5FDC0", Offset = "0x3E5E7C0", VA = "0x183E5FDC0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3E5DD40", Offset = "0x3E5C740", VA = "0x183E5DD40", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9DB0", Offset = "0x9AE87B0", VA = "0x189AE9DB0", Slot = "51")]
		public void RpcAllViaServer(QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3E84950", Offset = "0x3E83350", VA = "0x183E84950", Slot = "52")]
		public void RpcAllViaServer<T1>(QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3E84AE0", Offset = "0x3E834E0", VA = "0x183E84AE0", Slot = "15")]
		public void RpcAllViaServer<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3E843F0", Offset = "0x3E82DF0", VA = "0x183E843F0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3E84010", Offset = "0x3E82A10", VA = "0x183E84010", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3E83B70", Offset = "0x3E82570", VA = "0x183E83B70", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3E83610", Offset = "0x3E82010", VA = "0x183E83610", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3E82FF0", Offset = "0x3E819F0", VA = "0x183E82FF0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E82910", Offset = "0x3E81310", VA = "0x183E82910", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3E82170", Offset = "0x3E80B70", VA = "0x183E82170", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3E81910", Offset = "0x3E80310", VA = "0x183E81910", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3E80FF0", Offset = "0x3E7F9F0", VA = "0x183E80FF0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3E80600", Offset = "0x3E7F000", VA = "0x183E80600", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FB50", Offset = "0x3E7E550", VA = "0x183E7FB50", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EFC0", Offset = "0x3E7D9C0", VA = "0x183E7EFC0", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9EE0", Offset = "0x9AE88E0", VA = "0x189AE9EE0", Slot = "65")]
		public void RpcAllViaServer(QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3E84950", Offset = "0x3E83350", VA = "0x183E84950", Slot = "66")]
		public void RpcAllViaServer<T1>(QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3E84700", Offset = "0x3E83100", VA = "0x183E84700", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3E843F0", Offset = "0x3E82DF0", VA = "0x183E843F0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3E84010", Offset = "0x3E82A10", VA = "0x183E84010", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3E83B70", Offset = "0x3E82570", VA = "0x183E83B70", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3E83610", Offset = "0x3E82010", VA = "0x183E83610", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3E82FF0", Offset = "0x3E819F0", VA = "0x183E82FF0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3E82910", Offset = "0x3E81310", VA = "0x183E82910", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E82170", Offset = "0x3E80B70", VA = "0x183E82170", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E81910", Offset = "0x3E80310", VA = "0x183E81910", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E80FF0", Offset = "0x3E7F9F0", VA = "0x183E80FF0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E80600", Offset = "0x3E7F000", VA = "0x183E80600", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FB50", Offset = "0x3E7E550", VA = "0x183E7FB50", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EFC0", Offset = "0x3E7D9C0", VA = "0x183E7EFC0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEACD0", Offset = "0x9AE96D0", VA = "0x189AEACD0", Slot = "80")]
		public void RpcOthers(QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3EB91F0", Offset = "0x3EB7BF0", VA = "0x183EB91F0", Slot = "16")]
		public void RpcOthers<T1>(QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF7A0", Offset = "0x3EBE1A0", VA = "0x183EBF7A0", Slot = "81")]
		public void RpcOthers<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8FA0", Offset = "0x3EB79A0", VA = "0x183EB8FA0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2670", Offset = "0x3EC1070", VA = "0x183EC2670", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3EBE070", Offset = "0x3EBCA70", VA = "0x183EBE070", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3EC0540", Offset = "0x3EBEF40", VA = "0x183EC0540", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD4A0", Offset = "0x3EBBEA0", VA = "0x183EBD4A0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3EC11B0", Offset = "0x3EBFBB0", VA = "0x183EC11B0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3EBC5C0", Offset = "0x3EBAFC0", VA = "0x183EBC5C0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3EC0CB0", Offset = "0x3EBF6B0", VA = "0x183EC0CB0", Slot = "17")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3EBB3E0", Offset = "0x3EB9DE0", VA = "0x183EBB3E0", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA9D0", Offset = "0x3EB93D0", VA = "0x183EBA9D0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9EF0", Offset = "0x3EB88F0", VA = "0x183EB9EF0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9340", Offset = "0x3EB7D40", VA = "0x183EB9340", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAE20", Offset = "0x9AE9820", VA = "0x189AEAE20", Slot = "93")]
		public void RpcOthers(QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF500", Offset = "0x3EBDF00", VA = "0x183EBF500", Slot = "94")]
		public void RpcOthers<T1>(QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF340", Offset = "0x3EBDD40", VA = "0x183EBF340", Slot = "95")]
		public void RpcOthers<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3EBE930", Offset = "0x3EBD330", VA = "0x183EBE930", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF090", Offset = "0x3EBDA90", VA = "0x183EBF090", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3EBFCB0", Offset = "0x3EBE6B0", VA = "0x183EBFCB0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3EBFFC0", Offset = "0x3EBE9C0", VA = "0x183EBFFC0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD4A0", Offset = "0x3EBBEA0", VA = "0x183EBD4A0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3EBCD90", Offset = "0x3EBB790", VA = "0x183EBCD90", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EBC5C0", Offset = "0x3EBAFC0", VA = "0x183EBC5C0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3EBBD30", Offset = "0x3EBA730", VA = "0x183EBBD30", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3EBB3E0", Offset = "0x3EB9DE0", VA = "0x183EBB3E0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA9D0", Offset = "0x3EB93D0", VA = "0x183EBA9D0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9EF0", Offset = "0x3EB88F0", VA = "0x183EB9EF0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9340", Offset = "0x3EB7D40", VA = "0x183EB9340", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA7C0", Offset = "0x9AE91C0", VA = "0x189AEA7C0", Slot = "108")]
		public void RpcMaster(QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C380", Offset = "0x3E9AD80", VA = "0x183E9C380", Slot = "109")]
		public void RpcMaster<T1>(QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C520", Offset = "0x3E9AF20", VA = "0x183E9C520", Slot = "110")]
		public void RpcMaster<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B990", Offset = "0x3E9A390", VA = "0x183E9B990", Slot = "111")]
		public void RpcMaster<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BBF0", Offset = "0x3E9A5F0", VA = "0x183E9BBF0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEAA0", Offset = "0x3EAD4A0", VA = "0x183EAEAA0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0B00", Offset = "0x3EAF500", VA = "0x183EB0B00", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EA85B0", Offset = "0x3EA6FB0", VA = "0x183EA85B0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7360", Offset = "0x3EA5D60", VA = "0x183EA7360", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5EF0", Offset = "0x3EA48F0", VA = "0x183EA5EF0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE4F0", Offset = "0x3EACEF0", VA = "0x183EAE4F0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EADEB0", Offset = "0x3EAC8B0", VA = "0x183EADEB0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1480", Offset = "0x3E9FE80", VA = "0x183EA1480", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E9E7E0", Offset = "0x3E9D1E0", VA = "0x183E9E7E0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C740", Offset = "0x3E9B140", VA = "0x183E9C740", Slot = "122")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA950", Offset = "0x9AE9350", VA = "0x189AEA950", Slot = "123")]
		public void RpcMaster(QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C1A0", Offset = "0x3E9ABA0", VA = "0x183E9C1A0", Slot = "124")]
		public void RpcMaster<T1>(QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD1D0", Offset = "0x3EABBD0", VA = "0x183EAD1D0", Slot = "125")]
		public void RpcMaster<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EACA20", Offset = "0x3EAB420", VA = "0x183EACA20", Slot = "126")]
		public void RpcMaster<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3EAAFD0", Offset = "0x3EA99D0", VA = "0x183EAAFD0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3EAF270", Offset = "0x3EADC70", VA = "0x183EAF270", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3EA95A0", Offset = "0x3EA7FA0", VA = "0x183EA95A0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7CE0", Offset = "0x3EA66E0", VA = "0x183EA7CE0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6980", Offset = "0x3EA5380", VA = "0x183EA6980", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3EA53F0", Offset = "0x3EA3DF0", VA = "0x183EA53F0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EA47E0", Offset = "0x3EA31E0", VA = "0x183EA47E0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2260", Offset = "0x3EA0C60", VA = "0x183EA2260", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0640", Offset = "0x3E9F040", VA = "0x183EA0640", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F6E0", Offset = "0x3E9E0E0", VA = "0x183E9F6E0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D760", Offset = "0x3E9C160", VA = "0x183E9D760", Slot = "137")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA3B0", Offset = "0x9AE8DB0", VA = "0x189AEA3B0", Slot = "138")]
		public void RpcAuthority(QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E85400", Offset = "0x3E83E00", VA = "0x183E85400", Slot = "139")]
		public void RpcAuthority<T1>(QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E851C0", Offset = "0x3E83BC0", VA = "0x183E851C0", Slot = "140")]
		public void RpcAuthority<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E96630", Offset = "0x3E95030", VA = "0x183E96630", Slot = "141")]
		public void RpcAuthority<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E97E70", Offset = "0x3E96870", VA = "0x183E97E70", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E84E20", Offset = "0x3E83820", VA = "0x183E84E20", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E927F0", Offset = "0x3E911F0", VA = "0x183E927F0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E90E40", Offset = "0x3E8F840", VA = "0x183E90E40", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E8FA70", Offset = "0x3E8E470", VA = "0x183E8FA70", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E470", Offset = "0x3E8CE70", VA = "0x183E8E470", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CC50", Offset = "0x3E8B650", VA = "0x183E8CC50", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E99790", Offset = "0x3E98190", VA = "0x183E99790", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E95D70", Offset = "0x3E94770", VA = "0x183E95D70", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E876C0", Offset = "0x3E860C0", VA = "0x183E876C0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E86670", Offset = "0x3E85070", VA = "0x183E86670", Slot = "152")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA560", Offset = "0x9AE8F60", VA = "0x189AEA560", Slot = "153")]
		public void RpcAuthority(QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3E95AC0", Offset = "0x3E944C0", VA = "0x183E95AC0", Slot = "154")]
		public void RpcAuthority<T1>(QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3E954B0", Offset = "0x3E93EB0", VA = "0x183E954B0", Slot = "155")]
		public void RpcAuthority<T1, T2>(QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3E94CA0", Offset = "0x3E936A0", VA = "0x183E94CA0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3>(QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3E93CE0", Offset = "0x3E926E0", VA = "0x183E93CE0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E92F90", Offset = "0x3E91990", VA = "0x183E92F90", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E92000", Offset = "0x3E90A00", VA = "0x183E92000", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E91700", Offset = "0x3E90100", VA = "0x183E91700", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E90430", Offset = "0x3E8EE30", VA = "0x183E90430", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E8EF40", Offset = "0x3E8D940", VA = "0x183E8EF40", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D830", Offset = "0x3E8C230", VA = "0x183E8D830", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B200", Offset = "0x3E89C00", VA = "0x183E8B200", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E89580", Offset = "0x3E87F80", VA = "0x183E89580", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E885F0", Offset = "0x3E86FF0", VA = "0x183E885F0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E855B0", Offset = "0x3E83FB0", VA = "0x183E855B0", Slot = "167")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB230", Offset = "0x9AE9C30", VA = "0x189AEB230", Slot = "18")]
		public void RpcPlayer(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3760", Offset = "0x3EC2160", VA = "0x183EC3760", Slot = "19")]
		public void RpcPlayer<T1>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4400", Offset = "0x3EC2E00", VA = "0x183EC4400", Slot = "20")]
		public void RpcPlayer<T1, T2>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3E80", Offset = "0x3EC2880", VA = "0x183EC3E80", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3920", Offset = "0x3EC2320", VA = "0x183EC3920", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3ED81D0", Offset = "0x3ED6BD0", VA = "0x183ED81D0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7DC0", Offset = "0x3ED67C0", VA = "0x183ED7DC0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8560", Offset = "0x3ED6F60", VA = "0x183ED8560", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3ED89D0", Offset = "0x3ED73D0", VA = "0x183ED89D0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF940", Offset = "0x3ECE340", VA = "0x183ECF940", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE110", Offset = "0x3ECCB10", VA = "0x183ECE110", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4C50", Offset = "0x3EC3650", VA = "0x183EC4C50", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAA10", Offset = "0x3EC9410", VA = "0x183ECAA10", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD430", Offset = "0x3EDBE30", VA = "0x183EDD430", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7AC0", Offset = "0x3EC64C0", VA = "0x183EC7AC0", Slot = "176")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAF70", Offset = "0x9AE9970", VA = "0x189AEAF70", Slot = "177")]
		public void RpcPlayer(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3C70", Offset = "0x3EC2670", VA = "0x183EC3C70", Slot = "178")]
		public void RpcPlayer<T1>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4990", Offset = "0x3EC3390", VA = "0x183EC4990", Slot = "24")]
		public void RpcPlayer<T1, T2>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4650", Offset = "0x3EC3050", VA = "0x183EC4650", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6260", Offset = "0x3EC4C60", VA = "0x183EC6260", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4AF0", Offset = "0x3ED34F0", VA = "0x183ED4AF0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3ED34C0", Offset = "0x3ED1EC0", VA = "0x183ED34C0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2BC0", Offset = "0x3ED15C0", VA = "0x183ED2BC0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0F40", Offset = "0x3ECF940", VA = "0x183ED0F40", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0410", Offset = "0x3ECEE10", VA = "0x183ED0410", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3ECECF0", Offset = "0x3ECD6F0", VA = "0x183ECECF0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD3B0", Offset = "0x3ECBDB0", VA = "0x183ECD3B0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB830", Offset = "0x3ECA230", VA = "0x183ECB830", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9A70", Offset = "0x3EC8470", VA = "0x183EC9A70", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3EC69F0", Offset = "0x3EC53F0", VA = "0x183EC69F0", Slot = "189")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KDSOOWCXYNX player, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9C70", Offset = "0x9AE8670", VA = "0x189AE9C70", Slot = "190")]
		public void RpcAllBuffered(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E59B70", Offset = "0x3E58570", VA = "0x183E59B70", Slot = "191")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E59920", Offset = "0x3E58320", VA = "0x183E59920", Slot = "192")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E59600", Offset = "0x3E58000", VA = "0x183E59600", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E59220", Offset = "0x3E57C20", VA = "0x183E59220", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E58D80", Offset = "0x3E57780", VA = "0x183E58D80", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E58820", Offset = "0x3E57220", VA = "0x183E58820", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E9A0", Offset = "0x3E7D3A0", VA = "0x183E7E9A0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E2C0", Offset = "0x3E7CCC0", VA = "0x183E7E2C0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DB20", Offset = "0x3E7C520", VA = "0x183E7DB20", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D2B0", Offset = "0x3E7BCB0", VA = "0x183E7D2B0", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C980", Offset = "0x3E7B380", VA = "0x183E7C980", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BF90", Offset = "0x3E7A990", VA = "0x183E7BF90", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B4D0", Offset = "0x3E79ED0", VA = "0x183E7B4D0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A940", Offset = "0x3E79340", VA = "0x183E7A940", Slot = "204")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9D10", Offset = "0x9AE8710", VA = "0x189AE9D10", Slot = "205")]
		public void RpcAllBuffered(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3E59B70", Offset = "0x3E58570", VA = "0x183E59B70", Slot = "206")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3E59920", Offset = "0x3E58320", VA = "0x183E59920", Slot = "207")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3E59600", Offset = "0x3E58000", VA = "0x183E59600", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3E59220", Offset = "0x3E57C20", VA = "0x183E59220", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3E58D80", Offset = "0x3E57780", VA = "0x183E58D80", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3E58820", Offset = "0x3E57220", VA = "0x183E58820", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E9A0", Offset = "0x3E7D3A0", VA = "0x183E7E9A0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E2C0", Offset = "0x3E7CCC0", VA = "0x183E7E2C0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DB20", Offset = "0x3E7C520", VA = "0x183E7DB20", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D2B0", Offset = "0x3E7BCB0", VA = "0x183E7D2B0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C980", Offset = "0x3E7B380", VA = "0x183E7C980", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BF90", Offset = "0x3E7A990", VA = "0x183E7BF90", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B4D0", Offset = "0x3E79ED0", VA = "0x183E7B4D0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A940", Offset = "0x3E79340", VA = "0x183E7A940", Slot = "219")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAC30", Offset = "0x9AE9630", VA = "0x189AEAC30", Slot = "220")]
		public void RpcOthersBuffered(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8E00", Offset = "0x3EB7800", VA = "0x183EB8E00", Slot = "221")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8BB0", Offset = "0x3EB75B0", VA = "0x183EB8BB0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3EB88A0", Offset = "0x3EB72A0", VA = "0x183EB88A0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3EB84C0", Offset = "0x3EB6EC0", VA = "0x183EB84C0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8020", Offset = "0x3EB6A20", VA = "0x183EB8020", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7AC0", Offset = "0x3EB64C0", VA = "0x183EB7AC0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB74A0", Offset = "0x3EB5EA0", VA = "0x183EB74A0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6DC0", Offset = "0x3EB57C0", VA = "0x183EB6DC0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6620", Offset = "0x3EB5020", VA = "0x183EB6620", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5DB0", Offset = "0x3EB47B0", VA = "0x183EB5DB0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5480", Offset = "0x3EB3E80", VA = "0x183EB5480", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4A90", Offset = "0x3EB3490", VA = "0x183EB4A90", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3EB3FD0", Offset = "0x3EB29D0", VA = "0x183EB3FD0", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2BD0", Offset = "0x3EC15D0", VA = "0x183EC2BD0", Slot = "234")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAB90", Offset = "0x9AE9590", VA = "0x189AEAB90", Slot = "235")]
		public void RpcOthersBuffered(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8E00", Offset = "0x3EB7800", VA = "0x183EB8E00", Slot = "236")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8BB0", Offset = "0x3EB75B0", VA = "0x183EB8BB0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3EB88A0", Offset = "0x3EB72A0", VA = "0x183EB88A0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3EB84C0", Offset = "0x3EB6EC0", VA = "0x183EB84C0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8020", Offset = "0x3EB6A20", VA = "0x183EB8020", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7AC0", Offset = "0x3EB64C0", VA = "0x183EB7AC0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB74A0", Offset = "0x3EB5EA0", VA = "0x183EB74A0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6DC0", Offset = "0x3EB57C0", VA = "0x183EB6DC0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6620", Offset = "0x3EB5020", VA = "0x183EB6620", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5DB0", Offset = "0x3EB47B0", VA = "0x183EB5DB0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5480", Offset = "0x3EB3E80", VA = "0x183EB5480", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4A90", Offset = "0x3EB3490", VA = "0x183EB4A90", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3EB3FD0", Offset = "0x3EB29D0", VA = "0x183EB3FD0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2BD0", Offset = "0x3EC15D0", VA = "0x183EC2BD0", Slot = "249")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, QYXFZEQRJJG.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7DD0", Offset = "0x9AE67D0", VA = "0x189AE7DD0", Slot = "250")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7FE0", Offset = "0x9AE69E0", VA = "0x189AE7FE0", Slot = "251")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1769950", Offset = "0x1768350", VA = "0x181769950")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class LIHSZSNESPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3B30", Offset = "0x9AE2530", VA = "0x189AE3B30")]
		private static bool ZRWOCIVKWOM(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B6E0", Offset = "0x3C0A0E0", VA = "0x183C0B6E0")]
		[CanBeNull]
		public static a IVTINVQHOSI<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class UAMNTENCRHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public KDSOOWCXYNX[] QDZJIZJUAVN;

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public UAMNTENCRHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x9AF6E00", Offset = "0x9AF5800", VA = "0x189AF6E00")]
			internal int ECGBKVHROXR(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x9AF6D70", Offset = "0x9AF5770", VA = "0x189AF6D70")]
			internal void ECAUNONUFMI(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static KDSOOWCXYNX[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal int XMFEKNLVVIC;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9AEC690", Offset = "0x9AEB090", VA = "0x189AEC690")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9AECBA0", Offset = "0x9AEB5A0", VA = "0x189AECBA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9AECF40", Offset = "0x9AEB940", VA = "0x189AECF40")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9AECFC0", Offset = "0x9AEB9C0", VA = "0x189AECFC0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9AECB90", Offset = "0x9AEB590", VA = "0x189AECB90")]
		private void POSNRXNEBBA(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9AECB90", Offset = "0x9AEB590", VA = "0x189AECB90")]
		private void FNEWKEQLRSE(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9AED700", Offset = "0x9AEC100", VA = "0x189AED700")]
		private void VQEUQXMGXCS(KDSOOWCXYNX a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEC540", Offset = "0x9AEAF40", VA = "0x189AEC540")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9AED070", Offset = "0x9AEBA70", VA = "0x189AED070")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9AECAA0", Offset = "0x9AEB4A0", VA = "0x189AECAA0")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xD22380", Offset = "0xD20D80", VA = "0x180D22380")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class GCWDINCQYPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9AE02C0", Offset = "0x9ADECC0", VA = "0x189AE02C0")]
		public static int QZBDJBHPNIG(this KDSOOWCXYNX a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFF00", Offset = "0x9ADE900", VA = "0x189ADFF00")]
		public static void FGTGRBKWSTY(this KDSOOWCXYNX a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class SOXPTGJUTRM
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate void RoomPropertyUpdateCallback(Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void PlayerPropertyUpdateCallback(KDSOOWCXYNX player, Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback VRYGJDYCQQE
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDC20", Offset = "0x9AEC620", VA = "0x189AEDC20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDFE0", Offset = "0x9AEC9E0", VA = "0x189AEDFE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback FRSEWFNVGJV
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDDA0", Offset = "0x9AEC7A0", VA = "0x189AEDDA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDE60", Offset = "0x9AEC860", VA = "0x189AEDE60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback FASGDOFYRQC
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDCE0", Offset = "0x9AEC6E0", VA = "0x189AEDCE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDB60", Offset = "0x9AEC560", VA = "0x189AEDB60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback BFVCLLKHVCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDAA0", Offset = "0x9AEC4A0", VA = "0x189AEDAA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDF20", Offset = "0x9AEC920", VA = "0x189AEDF20")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class YUMZUCYGTDR
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static int JZNRFZGDGER;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static int BFPJHBZVBZL;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static int RBHLPZEBKXZ;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8820", Offset = "0x9AF7220", VA = "0x189AF8820")]
		public static void MVTLKIMXHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8870", Offset = "0x9AF7270", VA = "0x189AF8870")]
		public static void NWKKPSHPNQO(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9AF8950", Offset = "0x9AF7350", VA = "0x189AF8950")]
		public static int VKSCLUXOBIZ(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RegisterService(typeof(ZOJPPDKVFNP), new string[] { })]
	public class NGSYCBLVKXJ : ZOJPPDKVFNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Dictionary<object, object> BRCEJSXBDTK;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly Dictionary<object, object> BGOQRZWVRYI;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly Dictionary<object, object> UCZFFQVLQAY;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly CBEOKZVPQNC PEZUZYBLBWS;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly CBEOKZVPQNC IWSTZGFMPFD;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly CBEOKZVPQNC FTAEEXHNDBT;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly CBEOKZVPQNC YKEHAJQXVAY;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly CBEOKZVPQNC TPRURBSDPOJ;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int QNZIQPLVZEK;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4210", Offset = "0x9AE2C10", VA = "0x189AE4210", Slot = "4")]
		public bool BKJXRHZSEMU(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3E00", Offset = "0x9AE2800", VA = "0x189AE3E00", Slot = "5")]
		public int BBISJNGDGOE(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6450", Offset = "0x9AE4E50", VA = "0x189AE6450", Slot = "6")]
		public bool YYDJSHMAKMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4F80", Offset = "0x9AE3980", VA = "0x189AE4F80", Slot = "7")]
		public bool LFPIHPPSCXI(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5C40", Offset = "0x9AE4640", VA = "0x189AE5C40", Slot = "8")]
		public void RGVESGZJYRR(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5960", Offset = "0x9AE4360", VA = "0x189AE5960", Slot = "9")]
		public bool NOWWXKPXLNB(EPOORIVUAQX a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4950", Offset = "0x9AE3350", VA = "0x189AE4950", Slot = "10")]
		public bool HCZBTHZTHXS(EPOORIVUAQX a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4C80", Offset = "0x9AE3680", VA = "0x189AE4C80", Slot = "11")]
		public bool JQEHZGPWGSR(EPOORIVUAQX a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4510", Offset = "0x9AE2F10", VA = "0x189AE4510", Slot = "12")]
		public void EWNEHPNLXDT(EPOORIVUAQX a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4DC0", Offset = "0x9AE37C0", VA = "0x189AE4DC0", Slot = "13")]
		public void KFKPMHEHEUO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5AD0", Offset = "0x9AE44D0", VA = "0x189AE5AD0", Slot = "14")]
		public void QPXLBSRAEHG(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4760", Offset = "0x9AE3160", VA = "0x189AE4760", Slot = "15")]
		public void EZQGWTBCCRK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4840", Offset = "0x9AE3240", VA = "0x189AE4840", Slot = "16")]
		public void FHOVOXQIETZ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4350", Offset = "0x9AE2D50", VA = "0x189AE4350", Slot = "17")]
		public void CVOJSQGZSQH(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5F00", Offset = "0x9AE4900", VA = "0x189AE5F00")]
		private static void WFEAFMWAAEO(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5140", Offset = "0x9AE3B40", VA = "0x189AE5140")]
		private static bool NOWWXKPXLNB(Dictionary<object, object> a, KDSOOWCXYNX b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5E60", Offset = "0x9AE4860", VA = "0x189AE5E60")]
		private static bool VKAQULHDKCY(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE64E0", Offset = "0x9AE4EE0", VA = "0x189AE64E0")]
		private static int ZEIMBZMKAVK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public NGSYCBLVKXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RegisterService(typeof(LOPPTEIYDKP), new string[] { })]
	public class JOKSHRPWCND : LOPPTEIYDKP
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly object LCSVTTYROOB;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly object LCNOWNEUFCS;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly object LCIHZGKWVRJ;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly object LCDBBZQZMGA;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly object LBXUESXCCUR;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static Dictionary<object, object> HMMUAVOFOTJ;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static Dictionary<object, object> VQWOAUTUEJE;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static CBEOKZVPQNC SVXTRPBHHRJ;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly CBEOKZVPQNC MTRJIRHTCDQ;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2950", Offset = "0x9AE1350", VA = "0x189AE2950", Slot = "4")]
		public void GUAARKLHPPJ(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3120", Offset = "0x9AE1B20", VA = "0x189AE3120", Slot = "5")]
		public bool TFTTCEFJKCX(EPOORIVUAQX a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2A50", Offset = "0x9AE1450", VA = "0x189AE2A50", Slot = "6")]
		public void NWSGXGOTPUB(ViewId a, string b, RpcTarget c, KDSOOWCXYNX d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public JOKSHRPWCND()
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
