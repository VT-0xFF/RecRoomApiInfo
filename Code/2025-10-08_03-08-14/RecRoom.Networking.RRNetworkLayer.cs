using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
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
		[Cpp2IlInjected.Address(RVA = "0x86B7580", Offset = "0x86B6380", VA = "0x1886B7580", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		private int[] RBTJYOZOMSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] RBODBIFRDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset MXKLQTZDJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset MXPSOATASPL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23AEDE0", Offset = "0x23ADBE0", VA = "0x1823AEDE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86CE680", Offset = "0x86CD480", VA = "0x1886CE680")]
		private void GQKVENIQDUS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86CEDC0", Offset = "0x86CDBC0", VA = "0x1886CEDC0")]
		private void GQQCBUCNNGB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86CF020", Offset = "0x86CDE20", VA = "0x1886CF020", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86CF0D0", Offset = "0x86CDED0", VA = "0x1886CF0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class QOMBXGMFRCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log OVFUZPNBJOW;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log CUVVNTYYOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x86BB0D0", Offset = "0x86B9ED0", VA = "0x1886BB0D0")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface DTSYYKNQTWO
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView IIWGJFGQOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType QATUIVSJJVK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool AIXFSJTCFKV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "2")]
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
	internal interface WJLHDMRJFYG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool NTCMAUJACRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MGOQQNNKXWD(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface BTDQAFXYSBL : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PUOFOOQAOVA(DTSYYKNQTWO a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UICJQLYJDWB(DTSYYKNQTWO a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(PCGEVNEUCVU.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LCSWQUFWCVC();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WVPJQLJWLCH(object a);
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
	public class NFDDCNFEBYM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), WJLHDMRJFYG> AUXHSBNZNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<DTSYYKNQTWO> UQBQMHGYYZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> VGGCJQKUAUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int YINGKZAJHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool GWHJMZBRJPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PCGEVNEUCVU.ApplyNetworkTransform TRGEZGRENET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream DQFMOJJZNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker ZWQADRFREJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker VJZXDGJSOCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] PHERSYQWFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float KUIZDTUCRDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int JSVEEFFLHHE;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86B9050", Offset = "0x86B7E50", VA = "0x1886B9050")]
		public NFDDCNFEBYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86B8B30", Offset = "0x86B7930", VA = "0x1886B8B30")]
		public void Pause(PCGEVNEUCVU.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86B8A60", Offset = "0x86B7860", VA = "0x1886B8A60")]
		public void LCSWQUFWCVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86B8C80", Offset = "0x86B7A80", VA = "0x1886B8C80")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86B7B90", Offset = "0x86B6990", VA = "0x1886B7B90")]
		public bool Add(DTSYYKNQTWO networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86B8B50", Offset = "0x86B7950", VA = "0x1886B8B50")]
		public bool Remove(DTSYYKNQTWO networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86B8850", Offset = "0x86B7650", VA = "0x1886B8850")]
		private WJLHDMRJFYG LBPADKKGPRD(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86B8840", Offset = "0x86B7640", VA = "0x1886B8840")]
		public void LBAAAYDQYJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86B8AB0", Offset = "0x86B78B0", VA = "0x1886B8AB0")]
		private void OKNDQXQGJCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86B8B10", Offset = "0x86B7910", VA = "0x1886B8B10")]
		private void OTUCMBXDJAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86B80A0", Offset = "0x86B6EA0", VA = "0x1886B80A0")]
		public bool DOEKWUMLCLF(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86B8450", Offset = "0x86B7250", VA = "0x1886B8450")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class ODZGRCIKOKH : WJLHDMRJFYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DTSYYKNQTWO HSWPQJSFLTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint NJRDOWRYZPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int CGVDMVWCLRR;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NTCMAUJACRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public ODZGRCIKOKH(DTSYYKNQTWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86B9320", Offset = "0x86B8120", VA = "0x1886B9320", Slot = "5")]
		public bool MGOQQNNKXWD(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86B9240", Offset = "0x86B8040", VA = "0x1886B9240", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class FALIORJOILO : WJLHDMRJFYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PCGEVNEUCVU.ApplyNetworkTransform TRGEZGRENET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId CIKMBCLWHTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int CGVDMVWCLRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint NJRDOWRYZPU;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NTCMAUJACRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1D00", Offset = "0x1CA0B00", VA = "0x181CA1D00")]
		public FALIORJOILO(ViewId a, PCGEVNEUCVU.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86AE850", Offset = "0x86AD650", VA = "0x1886AE850", Slot = "5")]
		public bool MGOQQNNKXWD(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86AE670", Offset = "0x86AD470", VA = "0x1886AE670", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class UXGFVFZBFJW
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86C34F0", Offset = "0x86C22F0", VA = "0x1886C34F0")]
		public static void VVUFAYMMXPR(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86C2FF0", Offset = "0x86C1DF0", VA = "0x1886C2FF0")]
		public static void VIKUCVMVSTU(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86C2AD0", Offset = "0x86C18D0", VA = "0x1886C2AD0")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86C2C40", Offset = "0x86C1A40", VA = "0x1886C2C40")]
		public static void PXDRXIBCZHZ(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(BTDQAFXYSBL), new string[] { })]
	public class PLDMTNXPJDW : BTDQAFXYSBL, INetworkUpdateSystem, DWTJJRQESLQ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log PCGYFMAWLUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NFDDCNFEBYM EYIHNRNSWCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint ENTTAQXIBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float GSZHXBQBWXK;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86B9780", Offset = "0x86B8580", VA = "0x1886B9780", Slot = "4")]
		public void PUOFOOQAOVA(DTSYYKNQTWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86B9C60", Offset = "0x86B8A60", VA = "0x1886B9C60", Slot = "5")]
		public void UICJQLYJDWB(DTSYYKNQTWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86B9430", Offset = "0x86B8230", VA = "0x1886B9430", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86B95E0", Offset = "0x86B83E0", VA = "0x1886B95E0", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86B9EC0", Offset = "0x86B8CC0", VA = "0x1886B9EC0")]
		private void YOCVJHCCCFG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86B98A0", Offset = "0x86B86A0", VA = "0x1886B98A0", Slot = "6")]
		public void Pause(PCGEVNEUCVU.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86B9580", Offset = "0x86B8380", VA = "0x1886B9580", Slot = "7")]
		public void LCSWQUFWCVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86B9E60", Offset = "0x86B8C60", VA = "0x1886B9E60", Slot = "8")]
		public void WVPJQLJWLCH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86B98D0", Offset = "0x86B86D0", VA = "0x1886B98D0")]
		private void QVEMTFCCSAW(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86B9660", Offset = "0x86B8460", VA = "0x1886B9660", Slot = "11")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86BA4D0", Offset = "0x86B92D0", VA = "0x1886BA4D0")]
		public PLDMTNXPJDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QBMSYEVYGVM : WJLHDMRJFYG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float BYTRUKNYGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int CGVDMVWCLRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint NJRDOWRYZPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType YDXTLWQIBYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo PIIWEZHMHZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int PXBARVAGAQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] CKGBLSLSYRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo NYJHMSRQQNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int FDGDOEGIWPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] URWNTGBOIGQ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool NTCMAUJACRC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x86BA960", Offset = "0x86B9760", VA = "0x1886BA960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86BAA90", Offset = "0x86B9890", VA = "0x1886BAA90")]
		public QBMSYEVYGVM(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86BA920", Offset = "0x86B9720", VA = "0x1886BA920", Slot = "5")]
		public bool MGOQQNNKXWD(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86BA5A0", Offset = "0x86B93A0", VA = "0x1886BA5A0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86BA990", Offset = "0x86B9790", VA = "0x1886BA990")]
		internal ODZGRCIKOKH TZMKSZIZPPQ(DTSYYKNQTWO a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x86BA750", Offset = "0x86B9550", VA = "0x1886BA750")]
		private static void EEAHGUCJLHO(ODZGRCIKOKH a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RegisterService(typeof(FNQXSOLAQXP), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class FNQXSOLAQXP : CHIZWZJOAHG, DWTJJRQESLQ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Hashtable MPHWCAVSWLH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Hashtable UYJQZPPUSHX;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Hashtable HXWXBDEBTTT;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly QBWHSXSYUOT XICCMWQWFOX;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly QBWHSXSYUOT QOSWSKVKECO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly QBWHSXSYUOT TTHNJLNLPZI;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly QBWHSXSYUOT EBMMIWMAHFJ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly QBWHSXSYUOT XKNQPMAXMUC;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static int SEMPLVSMSGD;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86B08A0", Offset = "0x86AF6A0", VA = "0x1886B08A0", Slot = "4")]
		public bool YHDPPRQJXZR(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86AE890", Offset = "0x86AD690", VA = "0x1886AE890", Slot = "5")]
		public int CVILFHRCKDB(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86AFFB0", Offset = "0x86AEDB0", VA = "0x1886AFFB0", Slot = "6")]
		public bool UUQULIVZQUS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86AEC40", Offset = "0x86ADA40", VA = "0x1886AEC40", Slot = "7")]
		public bool GARRCOAAWXV(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86AF4E0", Offset = "0x86AE2E0", VA = "0x1886AF4E0", Slot = "8")]
		public void IYVQSIUQPXI(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86AF370", Offset = "0x86AE170", VA = "0x1886AF370", Slot = "9")]
		public bool ITLPZFLUSXM(EREVFMKOODS a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86B05C0", Offset = "0x86AF3C0", VA = "0x1886B05C0", Slot = "10")]
		public bool XTPJRTMAYID(EREVFMKOODS a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86AFEA0", Offset = "0x86AECA0", VA = "0x1886AFEA0", Slot = "11")]
		public bool SCVIIPVZBCY(EREVFMKOODS a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86AF8B0", Offset = "0x86AE6B0", VA = "0x1886AF8B0", Slot = "12")]
		public void QYMRFPZMICQ(EREVFMKOODS a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86B0390", Offset = "0x86AF190", VA = "0x1886B0390", Slot = "13")]
		public void XSEDHXIJEBB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86B0040", Offset = "0x86AEE40", VA = "0x1886B0040", Slot = "14")]
		public void UXXJUSKQJHB(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86AF760", Offset = "0x86AE560", VA = "0x1886AF760", Slot = "15")]
		public void KPMLLDTCYIB(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86B04F0", Offset = "0x86AF2F0", VA = "0x1886B04F0", Slot = "16")]
		public void XTAJZHXEKIU(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86B0150", Offset = "0x86AEF50", VA = "0x1886B0150", Slot = "17")]
		public void VHGYJLEIQFA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86AFA80", Offset = "0x86AE880", VA = "0x1886AFA80")]
		private static void RHKDODNVHML(InstantiateParameters a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86AEDC0", Offset = "0x86ADBC0", VA = "0x1886AEDC0")]
		private static bool ITLPZFLUSXM(Hashtable a, XGOJTPBZDNO b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86B02B0", Offset = "0x86AF0B0", VA = "0x1886B02B0")]
		private static int VMYWWRZFSYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86AF6C0", Offset = "0x86AE4C0", VA = "0x1886AF6C0", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x86AF810", Offset = "0x86AE610", VA = "0x1886AF810", Slot = "19")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public FNQXSOLAQXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RegisterService(typeof(ZMVEAAUSNFB), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class ZMVEAAUSNFB : IXCKPELZQVE, DWTJJRQESLQ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static Hashtable ZGZSFKYPBDM;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Hashtable HNXKEKBLSHL;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static QBWHSXSYUOT LQXCCEWWPOU;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly QBWHSXSYUOT AZJURSUPPER;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86CD9D0", Offset = "0x86CC7D0", VA = "0x1886CD9D0", Slot = "4")]
		public void KUNNFJFQVXE(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x86CDB50", Offset = "0x86CC950", VA = "0x1886CDB50", Slot = "5")]
		public bool TEGVWYMBSKC(EREVFMKOODS a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x86CDE80", Offset = "0x86CCC80", VA = "0x1886CDE80", Slot = "6")]
		public void ZACQMZPIBHG(ViewId a, string b, RpcTarget c, XGOJTPBZDNO d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x86CDAB0", Offset = "0x86CC8B0", VA = "0x1886CDAB0", Slot = "8")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86CD930", Offset = "0x86CC730", VA = "0x1886CD930", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ZMVEAAUSNFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ITUYZDJXYNT
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86B7390", Offset = "0x86B6190", VA = "0x1886B7390")]
		public static XGOJTPBZDNO JOHDMEWOAJS(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86B7420", Offset = "0x86B6220", VA = "0x1886B7420")]
		public static PlayerId ToPlayerId(this XGOJTPBZDNO player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, HRGIJDBXRTW, ZNLKIYOYHAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool PCZJEQRXKJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView WICXAOBWNET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<SLWJPQELUAZ> VRDIYSHRRNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool HFCWSEAEEXV;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId CAJPOHAFBEO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x86BB9D0", Offset = "0x86BA7D0", VA = "0x1886BB9D0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId KUSKCIRACRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x86BB9D0", Offset = "0x86BA7D0", VA = "0x1886BB9D0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView THVQYGYLLME
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x86BBA50", Offset = "0x86BA850", VA = "0x1886BBA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView IIWGJFGQOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x86BBA50", Offset = "0x86BA850", VA = "0x1886BBA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public XGOJTPBZDNO KOBDEQQFYPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x86BBB50", Offset = "0x86BA950", VA = "0x1886BBB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public XGOJTPBZDNO NQEXSIARXOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x86BBEB0", Offset = "0x86BACB0", VA = "0x1886BBEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZZDPBVRQUUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x86BBCB0", Offset = "0x86BAAB0", VA = "0x1886BBCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool UFGOUGCAXYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x86BBE20", Offset = "0x86BAC20", VA = "0x1886BBE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GEATPJHHZBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x86BB900", Offset = "0x86BA700", VA = "0x1886BB900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PWMYOFSSRNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x86BBBE0", Offset = "0x86BA9E0", VA = "0x1886BBBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PROXLXCNZXU
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x86BB900", Offset = "0x86BA700", VA = "0x1886BB900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool AURCHPLFRYG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x86BB980", Offset = "0x86BA780", VA = "0x1886BB980", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string SVKBYNEZAWG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x86BBAC0", Offset = "0x86BA8C0", VA = "0x1886BBAC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MYVNAIANAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x86BB880", Offset = "0x86BA680", VA = "0x1886BB880", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<XGOJTPBZDNO> SYXQCLSIUZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x86BB750", Offset = "0x86BA550", VA = "0x1886BB750")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x86BBF40", Offset = "0x86BAD40", VA = "0x1886BBF40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86BB6B0", Offset = "0x86BA4B0", VA = "0x1886BB6B0")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x79F96B0", Offset = "0x79F84B0", VA = "0x1879F96B0")]
		private void YDHDMMZQZVC(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86BB2B0", Offset = "0x86BA0B0", VA = "0x1886BB2B0", Slot = "9")]
		public void RegisterDestroyHandler(SLWJPQELUAZ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x86BB4F0", Offset = "0x86BA2F0", VA = "0x1886BB4F0", Slot = "10")]
		public void UnregisterDestroyHandler(SLWJPQELUAZ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86BB290", Offset = "0x86BA090", VA = "0x1886BB290", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class XFWRSVSCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, XGOJTPBZDNO targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, XGOJTPBZDNO targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, XGOJTPBZDNO newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CompilerGenerated]
		private static InstantiateCallback VSYOXBEWPUG;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback ZGRYNYLGVFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x86CC390", Offset = "0x86CB190", VA = "0x1886CC390")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x86CCD90", Offset = "0x86CBB90", VA = "0x1886CCD90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback EOARJIJXVYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x86CC7B0", Offset = "0x86CB5B0", VA = "0x1886CC7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x86CCC40", Offset = "0x86CBA40", VA = "0x1886CCC40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback ACNOIXNUBQF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x86CCE50", Offset = "0x86CBC50", VA = "0x1886CCE50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x86CC4E0", Offset = "0x86CB2E0", VA = "0x1886CC4E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback WZJZOLBDILS
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x86CC930", Offset = "0x86CB730", VA = "0x1886CC930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x86CC6F0", Offset = "0x86CB4F0", VA = "0x1886CC6F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback GBRVPSUVIFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x86CCB80", Offset = "0x86CB980", VA = "0x1886CCB80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x86CD210", Offset = "0x86CC010", VA = "0x1886CD210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback SPGMXKOFVGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x86CCFD0", Offset = "0x86CBDD0", VA = "0x1886CCFD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x86CCF10", Offset = "0x86CBD10", VA = "0x1886CCF10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback WFPIDITQWBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x86CC210", Offset = "0x86CB010", VA = "0x1886CC210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x86CC870", Offset = "0x86CB670", VA = "0x1886CC870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler CJFMMUTNJXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x86CC150", Offset = "0x86CAF50", VA = "0x1886CC150")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x86CC2D0", Offset = "0x86CB0D0", VA = "0x1886CC2D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler RXRDOCGHWIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x86CC5A0", Offset = "0x86CB3A0", VA = "0x1886CC5A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x86CD090", Offset = "0x86CBE90", VA = "0x1886CD090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86CD150", Offset = "0x86CBF50", VA = "0x1886CD150")]
		public static void SPCJJRNYTTC([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86CC660", Offset = "0x86CB460", VA = "0x1886CC660")]
		public static void EDHGRNSIIRI(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86CC9F0", Offset = "0x86CB7F0", VA = "0x1886CC9F0")]
		public static void HTJJRAELYOV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86CC450", Offset = "0x86CB250", VA = "0x1886CC450")]
		public static void DQOVKHKJFDO(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x86CCD00", Offset = "0x86CBB00", VA = "0x1886CCD00")]
		public static void MXPTMAYKMVN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x86CD2D0", Offset = "0x86CC0D0", VA = "0x1886CD2D0")]
		public static void WVXQMNRCTOH(RRNetworkView a, string b, XGOJTPBZDNO c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86CD420", Offset = "0x86CC220", VA = "0x1886CD420")]
		public static void ZZPZVQABEHQ(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86CCA80", Offset = "0x86CB880", VA = "0x1886CCA80")]
		public static void KPZGBKTEQAC(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class BCCQNPQVPZD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86AD670", Offset = "0x86AC470", VA = "0x1886AD670")]
		[CanBeNull]
		private static bool OAJTXYOAQEL(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86AD720", Offset = "0x86AC520", VA = "0x1886AD720")]
		[CanBeNull]
		public static Component PDEKIZQQINJ(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3616FF0", Offset = "0x3615DF0", VA = "0x183616FF0")]
		[CanBeNull]
		public static a PDEKIZQQINJ<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x36171A0", Offset = "0x3615FA0", VA = "0x1836171A0")]
		[CanBeNull]
		public static b YQMJQRUEZMD<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3617110", Offset = "0x3615F10", VA = "0x183617110")]
		public static bool PNSXQUBKFVQ<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x86AD600", Offset = "0x86AC400", VA = "0x1886AD600")]
		[CanBeNull]
		public static RRNetworkView CNYHQMKDIFE(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler VUSGKOYVZZO;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x86BC070", Offset = "0x86BAE70", VA = "0x1886BC070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86BC220", Offset = "0x86BB020", VA = "0x1886BC220")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86BC1E0", Offset = "0x86BAFE0", VA = "0x1886BC1E0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RegisterService(typeof(WWBLYUOHTRR), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class WWBLYUOHTRR : QNODZBPZCZA, DWTJJRQESLQ, RPNCXIAYMUG, SEJXOWERIYM, GLGKAAXCGMM, KSWDMDRTSDM, ZDJVRLQDMXE
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class VBZDFZLFUJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int MSDQVGDUUMB;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VBZDFZLFUJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x86C36B0", Offset = "0x86C24B0", VA = "0x1886C36B0")]
			internal object HJQJENKIVOC((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static Log FZFACNDPGTI;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static Log JKZQKDOFMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[DependsOn]
		private MGOIFTIJFFL WAWTJCGUOTE;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Dictionary<int, HashSet<int>> CQCFZFYSPVC;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<int, int> QFEVBFAVVER;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<(GameObject GameObject, int ParentCount)> CFEHGUDURVO;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<GameObject> XNTZVHFXZSF;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static List<int> WMMXQPZXKIL;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly List<RRNetworkView> JQQHIFIURHL;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly QBWHSXSYUOT EBMMIWMAHFJ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly QBWHSXSYUOT XKNQPMAXMUC;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86C6280", Offset = "0x86C5080", VA = "0x1886C6280", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86C7870", Offset = "0x86C6670", VA = "0x1886C7870", Slot = "9")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x86C60C0", Offset = "0x86C4EC0", VA = "0x1886C60C0", Slot = "10")]
		public void InitExternal(FCHQYTALOWK services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86C8C90", Offset = "0x86C7A90", VA = "0x1886C8C90", Slot = "11")]
		public void QTYYDWOCTQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x86C6940", Offset = "0x86C5740", VA = "0x1886C6940")]
		private void MGFYIGDBSYM(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x86C5930", Offset = "0x86C4730", VA = "0x1886C5930")]
		private void HTXXOZTOBVP(IPMVOLERGYH a, IPMVOLERGYH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x86C98B0", Offset = "0x86C86B0", VA = "0x1886C98B0")]
		public GameObject UTYWAWODPGN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x86C91F0", Offset = "0x86C7FF0", VA = "0x1886C91F0")]
		public GameObject SUXKQMWMFKZ(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86C48E0", Offset = "0x86C36E0", VA = "0x1886C48E0")]
		public GameObject EXTYENTFENO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86C47D0", Offset = "0x86C35D0", VA = "0x1886C47D0")]
		public GameObject DSQZHXILZZM(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86C9840", Offset = "0x86C8640", VA = "0x1886C9840", Slot = "6")]
		public void TIZYDJPHAOC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86C9D70", Offset = "0x86C8B70", VA = "0x1886C9D70")]
		public void XBCGFBFUCGL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x86C9DE0", Offset = "0x86C8BE0", VA = "0x1886C9DE0", Slot = "7")]
		public void XBHZXIKNZNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86CB9F0", Offset = "0x86CA7F0", VA = "0x1886CB9F0", Slot = "4")]
		public GameObject[] ZFWTYLEFRAI(IList<NDZRBGPKBQL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x86C80D0", Offset = "0x86C6ED0", VA = "0x1886C80D0", Slot = "5")]
		public void PHMTFEENHVZ(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x86C4800", Offset = "0x86C3600", VA = "0x1886C4800")]
		public void DTWZFMWZATT(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86C8E50", Offset = "0x86C7C50", VA = "0x1886C8E50")]
		private void QVEMTFCCSAW(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86C43A0", Offset = "0x86C31A0", VA = "0x1886C43A0")]
		private void CRQFQDALKXS(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86C4570", Offset = "0x86C3370", VA = "0x1886C4570")]
		private void DGMYFVYRWPA(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86C65C0", Offset = "0x86C53C0", VA = "0x1886C65C0")]
		private void JCHQUEWUAWK(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x86C5CE0", Offset = "0x86C4AE0", VA = "0x1886C5CE0")]
		private void IYKONJNNWKO(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x86C7680", Offset = "0x86C6480", VA = "0x1886C7680")]
		private void NZYTGYCMFXE(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x86C86B0", Offset = "0x86C74B0", VA = "0x1886C86B0")]
		private void QFOTSICRAIA(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x86C9B80", Offset = "0x86C8980", VA = "0x1886C9B80")]
		private GameObject VTORGJBKFCX(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x86C9DF0", Offset = "0x86C8BF0", VA = "0x1886C9DF0")]
		private GameObject XGXZKBDNIQN(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x86C3870", Offset = "0x86C2670", VA = "0x1886C3870")]
		private static GameObject BNYFQWVSUVN(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86C7BB0", Offset = "0x86C69B0", VA = "0x1886C7BB0")]
		private static GameObject OVOSDHYOQMS(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B60", Offset = "0x86C3960", VA = "0x1886C4B60")]
		private static void FKNYBXMXEQV(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86C6A60", Offset = "0x86C5860", VA = "0x1886C6A60")]
		private GameObject[] MVMMXCTSZAI(IList<NDZRBGPKBQL> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86C5A20", Offset = "0x86C4820", VA = "0x1886C5A20")]
		private GameObject[] ISNIMGMOFVI(InstantiateParameters[] a, int b, XGOJTPBZDNO c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x86C7280", Offset = "0x86C6080", VA = "0x1886C7280")]
		private GameObject NQAATAFGZZG([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x79DA2B0", Offset = "0x79D90B0", VA = "0x1879DA2B0")]
		private static bool UQUUQOPYLSR(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x86C4C70", Offset = "0x86C3A70", VA = "0x1886C4C70")]
		private void FPMXGMRKZUV(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x86CA640", Offset = "0x86C9440", VA = "0x1886CA640")]
		private void XVSKTYBWJER(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x86CB600", Offset = "0x86CA400", VA = "0x1886CB600")]
		private static void YKDRRALUWZK(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x86CA4E0", Offset = "0x86C92E0", VA = "0x1886CA4E0")]
		private void XNWWPMWYVLS(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x86C5890", Offset = "0x86C4690", VA = "0x1886C5890")]
		private static int GRDSPYLKJGE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86C9850", Offset = "0x86C8650", VA = "0x1886C9850")]
		private void UANRLBBLTTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86C92E0", Offset = "0x86C80E0", VA = "0x1886C92E0")]
		private void SZEASZXHYWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD20", Offset = "0x86CAB20", VA = "0x1886CBD20")]
		private static int ZXLOUBTRNAM(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86CB520", Offset = "0x86CA320", VA = "0x1886CB520")]
		private static int[] YCVNLMEEWLD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x86C6840", Offset = "0x86C5640", VA = "0x1886C6840")]
		private static int[] JHNZMEZIFJD(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x86C8090", Offset = "0x86C6E90", VA = "0x1886C8090")]
		private void OnMasterClientSwitched(XGOJTPBZDNO newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x86C38F0", Offset = "0x86C26F0", VA = "0x1886C38F0")]
		private void BVCJEVXHZKR(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x86C7DC0", Offset = "0x86C6BC0", VA = "0x1886C7DC0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x86C8470", Offset = "0x86C7270", VA = "0x1886C8470")]
		private void QAMICNBLTYF(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x86C9150", Offset = "0x86C7F50", VA = "0x1886C9150")]
		private static void SMRXPCZPYZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x86C9A80", Offset = "0x86C8880", VA = "0x1886C9A80")]
		private void UYSUMOMSRGL(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD80", Offset = "0x86CAB80", VA = "0x1886CBD80", Slot = "12")]
		private void ZZSCPZJHWHS(FCHQYTALOWK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x133C350", Offset = "0x133B150", VA = "0x18133C350", Slot = "13")]
		private void NNPEZXMTYDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public WWBLYUOHTRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(FOHMRAUXVSJ), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class FOHMRAUXVSJ : DWTJJRQESLQ, RPNCXIAYMUG, OPHUDFYFNLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct RpcMethodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public readonly MethodInfo methodInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly Func<MonoBehaviour, object> accessor;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x79E60F0", Offset = "0x79E4EF0", VA = "0x1879E60F0")]
			public object QYKNYKAHTRB(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WRYZWRRZYVR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public FieldInfo QSSCPCYFRXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Func<MonoBehaviour, object> CAVGZRMNGDV;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRYZWRRZYVR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x86C37B0", Offset = "0x86C25B0", VA = "0x1886C37B0")]
			internal RpcMethodInfo HTSROPTWGZX(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x5057010", Offset = "0x5055E10", VA = "0x185057010")]
			internal object HTNKRIZYXOO(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class WRTSZKYCPKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Func<MonoBehaviour, object> SASSBGUEQNS;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRTSZKYCPKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x79E6110", Offset = "0x79E4F10", VA = "0x1879E6110")]
			internal RpcMethodInfo HTXYLWNTQLG(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class VCNKWXLRMEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Type WIZTWNXTJNH;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VCNKWXLRMEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x86C3770", Offset = "0x86C2570", VA = "0x1886C3770")]
			internal bool OSDALKLMBTP(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, int> QKGQHTTYIRL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static List<string> PNXXAQBAXHG;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int BTMOEIJQCLX;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Stopwatch ZRHBMAIRYIB;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static Dictionary<MethodInfo, ParameterInfo[]> TAFCSSBTTRW;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> IXFEXTQXGTR;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x86B0E10", Offset = "0x86AFC10", VA = "0x1886B0E10", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x86B1540", Offset = "0x86B0340", VA = "0x1886B1540", Slot = "5")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86B0D80", Offset = "0x86AFB80", VA = "0x1886B0D80")]
		public static bool HEGMFNVSQNZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x86B0CA0", Offset = "0x86AFAA0", VA = "0x1886B0CA0")]
		public static bool DGEOCMXGOFJ(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86B1D30", Offset = "0x86B0B30", VA = "0x1886B1D30")]
		private void QVEMTFCCSAW(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86B0C70", Offset = "0x86AFA70", VA = "0x1886B0C70", Slot = "9")]
		public string CQBHGNGZOFP(EREVFMKOODS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86B1360", Offset = "0x86B0160", VA = "0x1886B1360", Slot = "8")]
		public void KUNNFJFQVXE(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x86B24F0", Offset = "0x86B12F0", VA = "0x1886B24F0", Slot = "6")]
		public void RJSZVFLGOGG(ViewId a, string b, XGOJTPBZDNO c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x86B24C0", Offset = "0x86B12C0", VA = "0x1886B24C0", Slot = "7")]
		public void RJSZVFLGOGG(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x86B1FE0", Offset = "0x86B0DE0", VA = "0x1886B1FE0")]
		private void RJSZVFLGOGG(ViewId a, string b, RpcTarget c, XGOJTPBZDNO d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x86B26D0", Offset = "0x86B14D0", VA = "0x1886B26D0")]
		private void WGVYEWXYRKZ(ViewId a, string b, XGOJTPBZDNO c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x86B18A0", Offset = "0x86B06A0", VA = "0x1886B18A0")]
		private static void QUFTTJWPCJN(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86B1690", Offset = "0x86B0490", VA = "0x1886B1690")]
		private static bool PWOIFPNHIQC(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x86B3D30", Offset = "0x86B2B30", VA = "0x1886B3D30")]
		private List<RpcMethodInfo> XNPVVOZEKAN(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86B1440", Offset = "0x86B0240", VA = "0x1886B1440")]
		private static IEnumerable<MethodInfo> LEXTPJFMZSL(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x86B25C0", Offset = "0x86B13C0", VA = "0x1886B25C0")]
		public static ParameterInfo[] VSFLFVUYBGD(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public FOHMRAUXVSJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[TooltipAttribute("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x86BC2E0", Offset = "0x86BB0E0", VA = "0x1886BC2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86BC260", Offset = "0x86BB060", VA = "0x1886BC260")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, QRQMRHQLAIR, NKZYDTUSTFA, USDSEOHFKTV, USNMZRQMMUB, EVAOIQLBAMA
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[RegisterService(typeof(MGOIFTIJFFL), new string[] { })]
		internal class XHBQEXRROMC : DWTJJRQESLQ, RPNCXIAYMUG, MGOIFTIJFFL
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Dictionary<int, RRNetworkView> YYHIXOKIJGL;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x86CD560", Offset = "0x86CC360", VA = "0x1886CD560", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x86CD560", Offset = "0x86CC360", VA = "0x1886CD560", Slot = "5")]
			public void OCFMKRRHFHW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x86CD570", Offset = "0x86CC370", VA = "0x1886CD570", Slot = "6")]
			public void YJHWLBRGTTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public XHBQEXRROMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum HasExplicitViewId
		{
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int CYTCGWSJYQN;

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x86AE610", Offset = "0x86AD410", VA = "0x1886AE610")]
			internal bool YMXKGAVMJHN(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static QBWHSXSYUOT FQXDTMRGQDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool BYGDAVCDKQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool GVJRIVMFTFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool IMKOAHRUHTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int AYTXEOCIJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool ESMVRCKQUHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int TMDBIIZPYSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private XGOJTPBZDNO NQEXSIARXOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private XGOJTPBZDNO GHXBVOZBARZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool? OAVZXCWSCRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool FDCJFIYZNTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal bool OJCZUTHGAOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal MonoBehaviour[] UEFZUTGOBMB;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly Log AMPHQOMOGUK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> YYHIXOKIJGL
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x86C0340", Offset = "0x86BF140", VA = "0x1886C0340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId KUSKCIRACRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x86C08F0", Offset = "0x86BF6F0", VA = "0x1886C08F0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId GBMGCIXXZVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x86C08F0", Offset = "0x86BF6F0", VA = "0x1886C08F0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId CAJPOHAFBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x86C08F0", Offset = "0x86BF6F0", VA = "0x1886C08F0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int GHYSSRKRPUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int SRFJYCVXRKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId HPMQSTWAGRF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x86C0760", Offset = "0x86BF560", VA = "0x1886C0760")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool LCQWAHCOMAV
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD78480", VA = "0x180D79680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC330C0", Offset = "0xC31EC0", VA = "0x180C330C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool VGFLHTSMYIY
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x86C0770", Offset = "0x86BF570", VA = "0x1886C0770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool QSIXHHOHRPN
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC12EC0", Offset = "0xC11CC0", VA = "0x180C12EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC56AC0", Offset = "0xC558C0", VA = "0x180C56AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int ZDCGZGGCMZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB0D1F0", Offset = "0xB0BFF0", VA = "0x180B0D1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int TYNSXCNXXNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x86C0700", Offset = "0x86BF500", VA = "0x1886C0700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public XGOJTPBZDNO RESKSREYGRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x86C0900", Offset = "0x86BF700", VA = "0x1886C0900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public XGOJTPBZDNO RJSLNMBCKXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x86C06D0", Offset = "0x86BF4D0", VA = "0x1886C06D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public XGOJTPBZDNO KOBDEQQFYPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x86C06D0", Offset = "0x86BF4D0", VA = "0x1886C06D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public XGOJTPBZDNO IXOYYPEGNBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x86C06D0", Offset = "0x86BF4D0", VA = "0x1886C06D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool UJOHYTRNEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x86C0840", Offset = "0x86BF640", VA = "0x1886C0840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int AGBTERYUDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x86C0730", Offset = "0x86BF530", VA = "0x1886C0730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] WWAYLFCEYOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ZZDPBVRQUUS
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x86C0930", Offset = "0x86BF730", VA = "0x1886C0930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AHYSEOMDUGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x86C08C0", Offset = "0x86BF6C0", VA = "0x1886C08C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KIZZGSRSATH
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E90", Offset = "0xFBFC90", VA = "0x180FC0E90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xFBFE70", Offset = "0xFBEC70", VA = "0x180FBFE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OJMGCEJESPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40220", VA = "0x180B41420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> YROUZIUXCWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x86C0560", Offset = "0x86BF360", VA = "0x1886C0560")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x86C0AF0", Offset = "0x86BF8F0", VA = "0x1886C0AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<XGOJTPBZDNO> VJHODOQAAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x86BC500", Offset = "0x86BB300", VA = "0x1886BC500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x86BC6C0", Offset = "0x86BB4C0", VA = "0x1886BC6C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<XGOJTPBZDNO> YWBVKYRPCIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x86BC500", Offset = "0x86BB300", VA = "0x1886BC500")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x86BC6C0", Offset = "0x86BB4C0", VA = "0x1886BC6C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> LPDGLXOYDWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x86BD360", Offset = "0x86BC160", VA = "0x1886BD360")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x86BCB10", Offset = "0x86BB910", VA = "0x1886BCB10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> QNJOJATXMZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x86BD360", Offset = "0x86BC160", VA = "0x1886BD360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x86BCB10", Offset = "0x86BB910", VA = "0x1886BCB10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> EGOQVGEPAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x86C0610", Offset = "0x86BF410", VA = "0x1886C0610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x86C0BA0", Offset = "0x86BF9A0", VA = "0x1886C0BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action HOUAHKTFQCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x86C04B0", Offset = "0x86BF2B0", VA = "0x1886C04B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x86C0A40", Offset = "0x86BF840", VA = "0x1886C0A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x86C0020", Offset = "0x86BEE20", VA = "0x1886C0020")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86BCE30", Offset = "0x86BBC30", VA = "0x1886BCE30")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x86BCF90", Offset = "0x86BBD90", VA = "0x1886BCF90")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x86BCEF0", Offset = "0x86BBCF0", VA = "0x1886BCEF0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x86BE470", Offset = "0x86BD270", VA = "0x1886BE470")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x86BE210", Offset = "0x86BD010", VA = "0x1886BE210")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x86BD800", Offset = "0x86BC600", VA = "0x1886BD800")]
		public static void OnPlayerJoinedRoom(XGOJTPBZDNO newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x86BD0F0", Offset = "0x86BBEF0", VA = "0x1886BD0F0")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x86BD150", Offset = "0x86BBF50", VA = "0x1886BD150")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86BD5E0", Offset = "0x86BC3E0", VA = "0x1886BD5E0")]
		private void JAEYOQMTDIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x86BCA90", Offset = "0x86BB890", VA = "0x1886BCA90")]
		public bool CreatedBy(XGOJTPBZDNO player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x86BFE40", Offset = "0x86BEC40", VA = "0x1886BFE40")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86BFDE0", Offset = "0x86BEBE0", VA = "0x1886BFDE0")]
		public void TransferOwnership(XGOJTPBZDNO newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x86BD470", Offset = "0x86BC270", VA = "0x1886BD470", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x86BD410", Offset = "0x86BC210", VA = "0x1886BD410")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x86BC4B0", Offset = "0x86BB2B0", VA = "0x1886BC4B0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x86C00E0", Offset = "0x86BEEE0", VA = "0x1886C00E0")]
		private void UWQNAWHMJGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x20A9880", Offset = "0x20A8680", VA = "0x1820A9880")]
		internal void AXTNAOZAWFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x86C0390", Offset = "0x86BF190", VA = "0x1886C0390", Slot = "6")]
		private void WHUVFXMXGYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x86BC440", Offset = "0x86BB240", VA = "0x1886BC440")]
		internal bool ANAGTUQAPMT(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x86BD6C0", Offset = "0x86BC4C0", VA = "0x1886BD6C0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x86BCCE0", Offset = "0x86BBAE0", VA = "0x1886BCCE0")]
		internal void FKRGXGWTKWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x86BCC30", Offset = "0x86BBA30", VA = "0x1886BCC30")]
		private void EUDNDGSKTHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x86BC770", Offset = "0x86BB570", VA = "0x1886BC770")]
		internal void CGDRGYYBQVL(XGOJTPBZDNO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x86BE3D0", Offset = "0x86BD1D0", VA = "0x1886BE3D0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x86BE520", Offset = "0x86BD320", VA = "0x1886BE520")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x86BCC40", Offset = "0x86BBA40", VA = "0x1886BCC40")]
		private void EVMOMTCBANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x86BCD40", Offset = "0x86BBB40", VA = "0x1886BCD40")]
		private void FNRYEUXPQXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x86BDFC0", Offset = "0x86BCDC0", VA = "0x1886BDFC0")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x86BDF30", Offset = "0x86BCD30", VA = "0x1886BDF30")]
		public void RPC(string methodName, XGOJTPBZDNO targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x86BE420", Offset = "0x86BD220", VA = "0x1886BE420")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86BC650", Offset = "0x86BB450", VA = "0x1886BC650", Slot = "8")]
		public void Bake(JSEALEMQFTE context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x86BCBC0", Offset = "0x86BB9C0", VA = "0x1886BCBC0")]
		private static void DSKRDILSLHC(XGOJTPBZDNO a, [Out] XGOJTPBZDNO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x86BDB70", Offset = "0x86BC970", VA = "0x1886BDB70")]
		private static void RLRSGDNKEPF(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x86BC5B0", Offset = "0x86BB3B0", VA = "0x1886BC5B0")]
		private static RPCInfo BILABHATEFA(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86BE050", Offset = "0x86BCE50", VA = "0x1886BE050")]
		private static void RPEKPYFDJDO(RRNetworkView a, Delegate b, XGOJTPBZDNO c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x86BE130", Offset = "0x86BCF30", VA = "0x1886BE130")]
		private static void RPEKPYFDJDO(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86BD250", Offset = "0x86BC050", VA = "0x1886BD250")]
		private static void IIAKJMNGIJJ(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x86BDE60", Offset = "0x86BCC60", VA = "0x1886BDE60")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x86BD1B0", Offset = "0x86BBFB0", VA = "0x1886BD1B0")]
		private static bool HRUGHGVFSIY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x86BE9D0", Offset = "0x86BD7D0", VA = "0x1886BE9D0", Slot = "26")]
		public void RpcAll(YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DD00", Offset = "0x3C3CB00", VA = "0x183C3DD00", Slot = "9")]
		public void RpcAll<T1>(YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D5E0", Offset = "0x3C3C3E0", VA = "0x183C3D5E0", Slot = "10")]
		public void RpcAll<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3C3FDD0", Offset = "0x3C3EBD0", VA = "0x183C3FDD0", Slot = "27")]
		public void RpcAll<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D7D0", Offset = "0x3C3C5D0", VA = "0x183C3D7D0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E330", Offset = "0x3C3D130", VA = "0x183C3E330", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3C40280", Offset = "0x3C3F080", VA = "0x183C40280", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DE70", Offset = "0x3C3CC70", VA = "0x183C3DE70", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C54630", Offset = "0x3C53430", VA = "0x183C54630", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3C406B0", Offset = "0x3C3F4B0", VA = "0x183C406B0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C3EF10", Offset = "0x3C3DD10", VA = "0x183C3EF10", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3C59130", Offset = "0x3C57F30", VA = "0x183C59130", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C46180", Offset = "0x3C44F80", VA = "0x183C46180", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3C43510", Offset = "0x3C42310", VA = "0x183C43510", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E730", Offset = "0x3C3D530", VA = "0x183C3E730", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x86BEB40", Offset = "0x86BD940", VA = "0x1886BEB40", Slot = "36")]
		public void RpcAll(YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3C52B60", Offset = "0x3C51960", VA = "0x183C52B60", Slot = "37")]
		public void RpcAll<T1>(YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C52680", Offset = "0x3C51480", VA = "0x183C52680", Slot = "38")]
		public void RpcAll<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F730", Offset = "0x3C3E530", VA = "0x183C3F730", Slot = "39")]
		public void RpcAll<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FBE0", Offset = "0x3C4E9E0", VA = "0x183C4FBE0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E9C0", Offset = "0x3C4D7C0", VA = "0x183C4E9C0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E210", Offset = "0x3C4D010", VA = "0x183C4E210", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C980", Offset = "0x3C4B780", VA = "0x183C4C980", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B620", Offset = "0x3C4A420", VA = "0x183C4B620", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3C4AB40", Offset = "0x3C49940", VA = "0x183C4AB40", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3C48910", Offset = "0x3C47710", VA = "0x183C48910", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3C47C00", Offset = "0x3C46A00", VA = "0x183C47C00", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3C45350", Offset = "0x3C44150", VA = "0x183C45350", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3C44400", Offset = "0x3C43200", VA = "0x183C44400", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3C424A0", Offset = "0x3C412A0", VA = "0x183C424A0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x86BE770", Offset = "0x86BD570", VA = "0x1886BE770", Slot = "51")]
		public void RpcAllViaServer(YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D110", Offset = "0x3C3BF10", VA = "0x183C3D110", Slot = "52")]
		public void RpcAllViaServer<T1>(YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D2A0", Offset = "0x3C3C0A0", VA = "0x183C3D2A0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CBB0", Offset = "0x3C3B9B0", VA = "0x183C3CBB0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C7D0", Offset = "0x3C3B5D0", VA = "0x183C3C7D0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C330", Offset = "0x3C3B130", VA = "0x183C3C330", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C3BDD0", Offset = "0x3C3ABD0", VA = "0x183C3BDD0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B7B0", Offset = "0x3C3A5B0", VA = "0x183C3B7B0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B0D0", Offset = "0x3C39ED0", VA = "0x183C3B0D0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A930", Offset = "0x3C39730", VA = "0x183C3A930", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A0D0", Offset = "0x3C38ED0", VA = "0x183C3A0D0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C397B0", Offset = "0x3C385B0", VA = "0x183C397B0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3C38DC0", Offset = "0x3C37BC0", VA = "0x183C38DC0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C38310", Offset = "0x3C37110", VA = "0x183C38310", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3C37780", Offset = "0x3C36580", VA = "0x183C37780", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x86BE8A0", Offset = "0x86BD6A0", VA = "0x1886BE8A0", Slot = "65")]
		public void RpcAllViaServer(YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D110", Offset = "0x3C3BF10", VA = "0x183C3D110", Slot = "66")]
		public void RpcAllViaServer<T1>(YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CEC0", Offset = "0x3C3BCC0", VA = "0x183C3CEC0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CBB0", Offset = "0x3C3B9B0", VA = "0x183C3CBB0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C7D0", Offset = "0x3C3B5D0", VA = "0x183C3C7D0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C330", Offset = "0x3C3B130", VA = "0x183C3C330", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C3BDD0", Offset = "0x3C3ABD0", VA = "0x183C3BDD0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B7B0", Offset = "0x3C3A5B0", VA = "0x183C3B7B0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B0D0", Offset = "0x3C39ED0", VA = "0x183C3B0D0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A930", Offset = "0x3C39730", VA = "0x183C3A930", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A0D0", Offset = "0x3C38ED0", VA = "0x183C3A0D0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C397B0", Offset = "0x3C385B0", VA = "0x183C397B0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C38DC0", Offset = "0x3C37BC0", VA = "0x183C38DC0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C38310", Offset = "0x3C37110", VA = "0x183C38310", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C37780", Offset = "0x3C36580", VA = "0x183C37780", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x86BF690", Offset = "0x86BE490", VA = "0x1886BF690", Slot = "80")]
		public void RpcOthers(YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C920C0", Offset = "0x3C90EC0", VA = "0x183C920C0", Slot = "15")]
		public void RpcOthers<T1>(YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3C98670", Offset = "0x3C97470", VA = "0x183C98670", Slot = "81")]
		public void RpcOthers<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3C91E70", Offset = "0x3C90C70", VA = "0x183C91E70", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AF90", Offset = "0x3C99D90", VA = "0x183C9AF90", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3C96F40", Offset = "0x3C95D40", VA = "0x183C96F40", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3C991F0", Offset = "0x3C97FF0", VA = "0x183C991F0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C96370", Offset = "0x3C95170", VA = "0x183C96370", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C99E60", Offset = "0x3C98C60", VA = "0x183C99E60", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C95490", Offset = "0x3C94290", VA = "0x183C95490", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C99960", Offset = "0x3C98760", VA = "0x183C99960", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C942B0", Offset = "0x3C930B0", VA = "0x183C942B0", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C938A0", Offset = "0x3C926A0", VA = "0x183C938A0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C92DC0", Offset = "0x3C91BC0", VA = "0x183C92DC0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C92210", Offset = "0x3C91010", VA = "0x183C92210", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x86BF7E0", Offset = "0x86BE5E0", VA = "0x1886BF7E0", Slot = "93")]
		public void RpcOthers(YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C983D0", Offset = "0x3C971D0", VA = "0x183C983D0", Slot = "94")]
		public void RpcOthers<T1>(YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C98210", Offset = "0x3C97010", VA = "0x183C98210", Slot = "95")]
		public void RpcOthers<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C97800", Offset = "0x3C96600", VA = "0x183C97800", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C97F60", Offset = "0x3C96D60", VA = "0x183C97F60", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C98B80", Offset = "0x3C97980", VA = "0x183C98B80", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C98E90", Offset = "0x3C97C90", VA = "0x183C98E90", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C96370", Offset = "0x3C95170", VA = "0x183C96370", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C95C60", Offset = "0x3C94A60", VA = "0x183C95C60", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C95490", Offset = "0x3C94290", VA = "0x183C95490", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C94C00", Offset = "0x3C93A00", VA = "0x183C94C00", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C942B0", Offset = "0x3C930B0", VA = "0x183C942B0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C938A0", Offset = "0x3C926A0", VA = "0x183C938A0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C92DC0", Offset = "0x3C91BC0", VA = "0x183C92DC0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C92210", Offset = "0x3C91010", VA = "0x183C92210", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x86BF3C0", Offset = "0x86BE1C0", VA = "0x1886BF3C0", Slot = "108")]
		public void RpcMaster(YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C73310", Offset = "0x3C72110", VA = "0x183C73310", Slot = "109")]
		public void RpcMaster<T1>(YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C73690", Offset = "0x3C72490", VA = "0x183C73690", Slot = "17")]
		public void RpcMaster<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C75370", Offset = "0x3C74170", VA = "0x183C75370", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C755D0", Offset = "0x3C743D0", VA = "0x183C755D0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C875E0", Offset = "0x3C863E0", VA = "0x183C875E0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C894B0", Offset = "0x3C882B0", VA = "0x183C894B0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C819F0", Offset = "0x3C807F0", VA = "0x183C819F0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C807A0", Offset = "0x3C7F5A0", VA = "0x183C807A0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F330", Offset = "0x3C7E130", VA = "0x183C7F330", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C87030", Offset = "0x3C85E30", VA = "0x183C87030", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C86240", Offset = "0x3C85040", VA = "0x183C86240", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A8C0", Offset = "0x3C796C0", VA = "0x183C7A8C0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C78B80", Offset = "0x3C77980", VA = "0x183C78B80", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C76C00", Offset = "0x3C75A00", VA = "0x183C76C00", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x86BF180", Offset = "0x86BDF80", VA = "0x1886BF180", Slot = "122")]
		public void RpcMaster(YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C734B0", Offset = "0x3C722B0", VA = "0x183C734B0", Slot = "123")]
		public void RpcMaster<T1>(YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C74170", Offset = "0x3C72F70", VA = "0x183C74170", Slot = "124")]
		public void RpcMaster<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C859A0", Offset = "0x3C847A0", VA = "0x183C859A0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C84410", Offset = "0x3C83210", VA = "0x183C84410", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C87C20", Offset = "0x3C86A20", VA = "0x183C87C20", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C82270", Offset = "0x3C81070", VA = "0x183C82270", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C81120", Offset = "0x3C7FF20", VA = "0x183C81120", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FDC0", Offset = "0x3C7EBC0", VA = "0x183C7FDC0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E830", Offset = "0x3C7D630", VA = "0x183C7E830", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DC20", Offset = "0x3C7CA20", VA = "0x183C7DC20", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C360", Offset = "0x3C7B160", VA = "0x183C7C360", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C79A80", Offset = "0x3C78880", VA = "0x183C79A80", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C77C20", Offset = "0x3C76A20", VA = "0x183C77C20", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C75B80", Offset = "0x3C74980", VA = "0x183C75B80", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x86BED70", Offset = "0x86BDB70", VA = "0x1886BED70", Slot = "137")]
		public void RpcAuthority(YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DBF0", Offset = "0x3C5C9F0", VA = "0x183C5DBF0", Slot = "138")]
		public void RpcAuthority<T1>(YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FAF0", Offset = "0x3C6E8F0", VA = "0x183C6FAF0", Slot = "139")]
		public void RpcAuthority<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C70260", Offset = "0x3C6F060", VA = "0x183C70260", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F7F0", Offset = "0x3C6E5F0", VA = "0x183C6F7F0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D850", Offset = "0x3C5C650", VA = "0x183C5D850", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AFE0", Offset = "0x3C69DE0", VA = "0x183C6AFE0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C69F30", Offset = "0x3C68D30", VA = "0x183C69F30", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C68260", Offset = "0x3C67060", VA = "0x183C68260", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C67790", Offset = "0x3C66590", VA = "0x183C67790", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C66080", Offset = "0x3C64E80", VA = "0x183C66080", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C71110", Offset = "0x3C6FF10", VA = "0x183C71110", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E560", Offset = "0x3C6D360", VA = "0x183C6E560", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FEB0", Offset = "0x3C5ECB0", VA = "0x183C5FEB0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DDA0", Offset = "0x3C5CBA0", VA = "0x183C5DDA0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86BEF20", Offset = "0x86BDD20", VA = "0x1886BEF20", Slot = "152")]
		public void RpcAuthority(YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E060", Offset = "0x3C6CE60", VA = "0x183C6E060", Slot = "153")]
		public void RpcAuthority<T1>(YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DCA0", Offset = "0x3C6CAA0", VA = "0x183C6DCA0", Slot = "154")]
		public void RpcAuthority<T1, T2>(YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D020", Offset = "0x3C6BE20", VA = "0x183C6D020", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CA50", Offset = "0x3C6B850", VA = "0x183C6CA50", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B780", Offset = "0x3C6A580", VA = "0x183C6B780", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A7F0", Offset = "0x3C695F0", VA = "0x183C6A7F0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C69630", Offset = "0x3C68430", VA = "0x183C69630", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C68C20", Offset = "0x3C67A20", VA = "0x183C68C20", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C66C60", Offset = "0x3C65A60", VA = "0x183C66C60", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C65440", Offset = "0x3C64240", VA = "0x183C65440", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C646F0", Offset = "0x3C634F0", VA = "0x183C646F0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C61D70", Offset = "0x3C60B70", VA = "0x183C61D70", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C60DE0", Offset = "0x3C5FBE0", VA = "0x183C60DE0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EDF0", Offset = "0x3C5DBF0", VA = "0x183C5EDF0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x86BF930", Offset = "0x86BE730", VA = "0x1886BF930", Slot = "18")]
		public void RpcPlayer(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B4F0", Offset = "0x3C9A2F0", VA = "0x183C9B4F0", Slot = "19")]
		public void RpcPlayer<T1>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C190", Offset = "0x3C9AF90", VA = "0x183C9C190", Slot = "20")]
		public void RpcPlayer<T1, T2>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BC10", Offset = "0x3C9AA10", VA = "0x183C9BC10", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B6B0", Offset = "0x3C9A4B0", VA = "0x183C9B6B0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFF60", Offset = "0x3CAED60", VA = "0x183CAFF60", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFB50", Offset = "0x3CAE950", VA = "0x183CAFB50", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB02F0", Offset = "0x3CAF0F0", VA = "0x183CB02F0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0760", Offset = "0x3CAF560", VA = "0x183CB0760", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8200", Offset = "0x3CA7000", VA = "0x183CA8200", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5EA0", Offset = "0x3CA4CA0", VA = "0x183CA5EA0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C9E0", Offset = "0x3C9B7E0", VA = "0x183C9C9E0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3620", Offset = "0x3CA2420", VA = "0x183CA3620", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3CB45E0", Offset = "0x3CB33E0", VA = "0x183CB45E0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F850", Offset = "0x3C9E650", VA = "0x183C9F850", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x86BFB20", Offset = "0x86BE920", VA = "0x1886BFB20", Slot = "176")]
		public void RpcPlayer(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BA00", Offset = "0x3C9A800", VA = "0x183C9BA00", Slot = "177")]
		public void RpcPlayer<T1>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C720", Offset = "0x3C9B520", VA = "0x183C9C720", Slot = "24")]
		public void RpcPlayer<T1, T2>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C3E0", Offset = "0x3C9B1E0", VA = "0x183C9C3E0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DFF0", Offset = "0x3C9CDF0", VA = "0x183C9DFF0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC1E0", Offset = "0x3CAAFE0", VA = "0x183CAC1E0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3CAB9F0", Offset = "0x3CAA7F0", VA = "0x183CAB9F0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA0A0", Offset = "0x3CA8EA0", VA = "0x183CAA0A0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8CD0", Offset = "0x3CA7AD0", VA = "0x183CA8CD0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3CA76D0", Offset = "0x3CA64D0", VA = "0x183CA76D0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6A80", Offset = "0x3CA5880", VA = "0x183CA6A80", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5140", Offset = "0x3CA3F40", VA = "0x183CA5140", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA27A0", Offset = "0x3CA15A0", VA = "0x183CA27A0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA08C0", Offset = "0x3C9F6C0", VA = "0x183CA08C0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E780", Offset = "0x3C9D580", VA = "0x183C9E780", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(XGOJTPBZDNO player, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x86BE630", Offset = "0x86BD430", VA = "0x1886BE630", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3C375E0", Offset = "0x3C363E0", VA = "0x183C375E0", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3C37390", Offset = "0x3C36190", VA = "0x183C37390", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3C37070", Offset = "0x3C35E70", VA = "0x183C37070", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3C36C90", Offset = "0x3C35A90", VA = "0x183C36C90", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3C367F0", Offset = "0x3C355F0", VA = "0x183C367F0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3C36290", Offset = "0x3C35090", VA = "0x183C36290", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3C35C70", Offset = "0x3C34A70", VA = "0x183C35C70", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3C35590", Offset = "0x3C34390", VA = "0x183C35590", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3C34DF0", Offset = "0x3C33BF0", VA = "0x183C34DF0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3C34580", Offset = "0x3C33380", VA = "0x183C34580", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3C33C50", Offset = "0x3C32A50", VA = "0x183C33C50", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3C33260", Offset = "0x3C32060", VA = "0x183C33260", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3C327A0", Offset = "0x3C315A0", VA = "0x183C327A0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3C31C10", Offset = "0x3C30A10", VA = "0x183C31C10", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x86BE6D0", Offset = "0x86BD4D0", VA = "0x1886BE6D0", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3C375E0", Offset = "0x3C363E0", VA = "0x183C375E0", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3C37390", Offset = "0x3C36190", VA = "0x183C37390", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3C37070", Offset = "0x3C35E70", VA = "0x183C37070", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3C36C90", Offset = "0x3C35A90", VA = "0x183C36C90", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3C367F0", Offset = "0x3C355F0", VA = "0x183C367F0", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3C36290", Offset = "0x3C35090", VA = "0x183C36290", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3C35C70", Offset = "0x3C34A70", VA = "0x183C35C70", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3C35590", Offset = "0x3C34390", VA = "0x183C35590", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3C34DF0", Offset = "0x3C33BF0", VA = "0x183C34DF0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3C34580", Offset = "0x3C33380", VA = "0x183C34580", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3C33C50", Offset = "0x3C32A50", VA = "0x183C33C50", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3C33260", Offset = "0x3C32060", VA = "0x183C33260", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3C327A0", Offset = "0x3C315A0", VA = "0x183C327A0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3C31C10", Offset = "0x3C30A10", VA = "0x183C31C10", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x86BF550", Offset = "0x86BE350", VA = "0x1886BF550", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, YNACYAKAJPH.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3C91CD0", Offset = "0x3C90AD0", VA = "0x183C91CD0", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3C91A80", Offset = "0x3C90880", VA = "0x183C91A80", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3C91770", Offset = "0x3C90570", VA = "0x183C91770", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3C91390", Offset = "0x3C90190", VA = "0x183C91390", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3C90EF0", Offset = "0x3C8FCF0", VA = "0x183C90EF0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3C90990", Offset = "0x3C8F790", VA = "0x183C90990", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3C90370", Offset = "0x3C8F170", VA = "0x183C90370", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FC90", Offset = "0x3C8EA90", VA = "0x183C8FC90", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F4F0", Offset = "0x3C8E2F0", VA = "0x183C8F4F0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3C8EC80", Offset = "0x3C8DA80", VA = "0x183C8EC80", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E350", Offset = "0x3C8D150", VA = "0x183C8E350", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D960", Offset = "0x3C8C760", VA = "0x183C8D960", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8CEA0", Offset = "0x3C8BCA0", VA = "0x183C8CEA0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C310", Offset = "0x3C8B110", VA = "0x183C8C310", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x86BF5F0", Offset = "0x86BE3F0", VA = "0x1886BF5F0", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3C91CD0", Offset = "0x3C90AD0", VA = "0x183C91CD0", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3C91A80", Offset = "0x3C90880", VA = "0x183C91A80", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3C91770", Offset = "0x3C90570", VA = "0x183C91770", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3C91390", Offset = "0x3C90190", VA = "0x183C91390", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3C90EF0", Offset = "0x3C8FCF0", VA = "0x183C90EF0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3C90990", Offset = "0x3C8F790", VA = "0x183C90990", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3C90370", Offset = "0x3C8F170", VA = "0x183C90370", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FC90", Offset = "0x3C8EA90", VA = "0x183C8FC90", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F4F0", Offset = "0x3C8E2F0", VA = "0x183C8F4F0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3C8EC80", Offset = "0x3C8DA80", VA = "0x183C8EC80", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E350", Offset = "0x3C8D150", VA = "0x183C8E350", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D960", Offset = "0x3C8C760", VA = "0x183C8D960", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3C8CEA0", Offset = "0x3C8BCA0", VA = "0x183C8CEA0", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C310", Offset = "0x3C8B110", VA = "0x183C8C310", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, YNACYAKAJPH.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x86BC830", Offset = "0x86BB630", VA = "0x1886BC830", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x86BCA30", Offset = "0x86BB830", VA = "0x1886BCA30", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x20F70E0", Offset = "0x20F5EE0", VA = "0x1820F70E0")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class CYAXUYTZJVK
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x86AD800", Offset = "0x86AC600", VA = "0x1886AD800")]
		private static bool PFEMBLDATDV(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x371CA90", Offset = "0x371B890", VA = "0x18371CA90")]
		[CanBeNull]
		public static a UIOMOPZMJDZ<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class LYLAIXIKLRH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public XGOJTPBZDNO[] RKRALIHDYVU;

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LYLAIXIKLRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x86B7470", Offset = "0x86B6270", VA = "0x1886B7470")]
			internal int NNPDRAQLWNK(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x86B74F0", Offset = "0x86B62F0", VA = "0x1886B74F0")]
			internal void NNUKOHKJFYT(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static XGOJTPBZDNO[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int EUVINGZSRBZ;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x86C0DB0", Offset = "0x86BFBB0", VA = "0x1886C0DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x86C1390", Offset = "0x86C0190", VA = "0x1886C1390")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x86C1710", Offset = "0x86C0510", VA = "0x1886C1710")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x86C1780", Offset = "0x86C0580", VA = "0x1886C1780")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x86C11A0", Offset = "0x86BFFA0", VA = "0x1886C11A0")]
		private void HZBKMVIHEWR(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x86C11A0", Offset = "0x86BFFA0", VA = "0x1886C11A0")]
		private void BVCJEVXHZKR(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x86C12A0", Offset = "0x86C00A0", VA = "0x1886C12A0")]
		private void OPWJVLAWRKD(XGOJTPBZDNO a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x86C0C60", Offset = "0x86BFA60", VA = "0x1886C0C60")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x86C1820", Offset = "0x86C0620", VA = "0x1886C1820")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x86C11B0", Offset = "0x86BFFB0", VA = "0x1886C11B0")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xACF360", Offset = "0xACE160", VA = "0x180ACF360")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class QNPTHASQSRZ
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x86BAEC0", Offset = "0x86B9CC0", VA = "0x1886BAEC0")]
		public static int NPVICUEAGXP(this XGOJTPBZDNO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x86BAB00", Offset = "0x86B9900", VA = "0x1886BAB00")]
		public static void LUGQFHMRJRT(this XGOJTPBZDNO a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class TDPOODZCLXN
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void RoomPropertyUpdateCallback(Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate void PlayerPropertyUpdateCallback(XGOJTPBZDNO player, Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback ZQQFPVKQEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x86C1F00", Offset = "0x86C0D00", VA = "0x1886C1F00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x86C2140", Offset = "0x86C0F40", VA = "0x1886C2140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback WHXANUEXYOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x86C2440", Offset = "0x86C1240", VA = "0x1886C2440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x86C2200", Offset = "0x86C1000", VA = "0x1886C2200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback PXHJTTBXSGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x86C2080", Offset = "0x86C0E80", VA = "0x1886C2080")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x86C1FC0", Offset = "0x86C0DC0", VA = "0x1886C1FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback MHEEOFSVDKE
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x86C22C0", Offset = "0x86C10C0", VA = "0x1886C22C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x86C2380", Offset = "0x86C1180", VA = "0x1886C2380")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal static class MAWCKMDYIOM
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int BQCHVRZYUGC;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int UIIBRAZUTTS;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int VHDVKGNQHLC;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x86B77E0", Offset = "0x86B65E0", VA = "0x1886B77E0")]
		public static void CJSDJYFVYXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x86B7830", Offset = "0x86B6630", VA = "0x1886B7830")]
		public static void VDBIGSQWLCD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x86B7910", Offset = "0x86B6710", VA = "0x1886B7910")]
		public static int ZXLOUBTRNAM(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RegisterService(typeof(HJLGUOOMQAM), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class HJLGUOOMQAM : CHIZWZJOAHG, DWTJJRQESLQ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Dictionary<object, object> MPHWCAVSWLH;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly Dictionary<object, object> UYJQZPPUSHX;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly Dictionary<object, object> HXWXBDEBTTT;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly QBWHSXSYUOT XICCMWQWFOX;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly QBWHSXSYUOT QOSWSKVKECO;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly QBWHSXSYUOT TTHNJLNLPZI;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly QBWHSXSYUOT EBMMIWMAHFJ;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly QBWHSXSYUOT XKNQPMAXMUC;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static int SEMPLVSMSGD;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x86B5960", Offset = "0x86B4760", VA = "0x1886B5960", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x86B5AE0", Offset = "0x86B48E0", VA = "0x1886B5AE0", Slot = "19")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x86B6FA0", Offset = "0x86B5DA0", VA = "0x1886B6FA0", Slot = "4")]
		public bool YHDPPRQJXZR(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x86B4800", Offset = "0x86B3600", VA = "0x1886B4800", Slot = "5")]
		public int CVILFHRCKDB(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x86B6500", Offset = "0x86B5300", VA = "0x1886B6500", Slot = "6")]
		public bool UUQULIVZQUS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x86B4C10", Offset = "0x86B3A10", VA = "0x1886B4C10", Slot = "7")]
		public bool GARRCOAAWXV(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x86B5750", Offset = "0x86B4550", VA = "0x1886B5750", Slot = "8")]
		public void IYVQSIUQPXI(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x86B55E0", Offset = "0x86B43E0", VA = "0x1886B55E0", Slot = "9")]
		public bool ITLPZFLUSXM(EREVFMKOODS a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x86B6C70", Offset = "0x86B5A70", VA = "0x1886B6C70", Slot = "10")]
		public bool XTPJRTMAYID(EREVFMKOODS a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x86B6320", Offset = "0x86B5120", VA = "0x1886B6320", Slot = "11")]
		public bool SCVIIPVZBCY(EREVFMKOODS a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x86B5B80", Offset = "0x86B4980", VA = "0x1886B5B80", Slot = "12")]
		public void QYMRFPZMICQ(EREVFMKOODS a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x86B69A0", Offset = "0x86B57A0", VA = "0x1886B69A0", Slot = "13")]
		public void XSEDHXIJEBB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x86B6590", Offset = "0x86B5390", VA = "0x1886B6590", Slot = "14")]
		public void UXXJUSKQJHB(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x86B5A00", Offset = "0x86B4800", VA = "0x1886B5A00", Slot = "15")]
		public void KPMLLDTCYIB(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x86B6B60", Offset = "0x86B5960", VA = "0x1886B6B60", Slot = "16")]
		public void XTAJZHXEKIU(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x86B6700", Offset = "0x86B5500", VA = "0x1886B6700", Slot = "17")]
		public void VHGYJLEIQFA(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x86B5DD0", Offset = "0x86B4BD0", VA = "0x1886B5DD0")]
		private static void RHKDODNVHML(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x86B4DC0", Offset = "0x86B3BC0", VA = "0x1886B4DC0")]
		private static bool ITLPZFLUSXM(Dictionary<object, object> a, XGOJTPBZDNO b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x86B6460", Offset = "0x86B5260", VA = "0x1886B6460")]
		private static bool UGAJQJZPINP(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x86B68C0", Offset = "0x86B56C0", VA = "0x1886B68C0")]
		private static int VMYWWRZFSYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public HJLGUOOMQAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RegisterService(typeof(EGRRSZEGJUS), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class EGRRSZEGJUS : IXCKPELZQVE, DWTJJRQESLQ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static Hashtable ZGZSFKYPBDM;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static Hashtable HNXKEKBLSHL;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static QBWHSXSYUOT LQXCCEWWPOU;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly QBWHSXSYUOT AZJURSUPPER;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x86ADA40", Offset = "0x86AC840", VA = "0x1886ADA40", Slot = "8")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x86AD8C0", Offset = "0x86AC6C0", VA = "0x1886AD8C0", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x86AD960", Offset = "0x86AC760", VA = "0x1886AD960", Slot = "4")]
		public void KUNNFJFQVXE(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x86ADAE0", Offset = "0x86AC8E0", VA = "0x1886ADAE0", Slot = "5")]
		public bool TEGVWYMBSKC(EREVFMKOODS a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x86ADE10", Offset = "0x86ACC10", VA = "0x1886ADE10", Slot = "6")]
		public void ZACQMZPIBHG(ViewId a, string b, RpcTarget c, XGOJTPBZDNO d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public EGRRSZEGJUS()
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
