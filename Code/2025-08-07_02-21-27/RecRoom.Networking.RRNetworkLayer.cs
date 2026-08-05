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
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0x8B49400", Offset = "0x8B48000", VA = "0x188B49400", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		private int[] XIOCEUOZJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] XIIVHNVBZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset MVEDDDGEAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset MVJKAKABJST;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x269CC00", Offset = "0x269B800", VA = "0x18269CC00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B58CC0", Offset = "0x8B578C0", VA = "0x188B58CC0")]
		private void SGYKGOYOYBS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B592F0", Offset = "0x8B57EF0", VA = "0x188B592F0")]
		private void SHDRDVSMHNB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B58C10", Offset = "0x8B57810", VA = "0x188B58C10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B59550", Offset = "0x8B58150", VA = "0x188B59550")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class JHVRJSSBZWO
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log XZHRAOCCLYQ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log UCYKOPNKDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B492B0", Offset = "0x8B47EB0", VA = "0x188B492B0")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HEKKHQTKHYQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView EPCVQWBCLSF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType TBHVWLOGYCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool YHSVXSZZPVN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "2")]
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
	internal interface OHYEOYPFJWA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool JXLMINNEJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KLLSFCVPVJT(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface CCJOSMUVBRJ : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ERBMWTZFFKA(HEKKHQTKHYQ a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BUEMJHJNWRJ(HEKKHQTKHYQ a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(HFBGITOWSIU.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YSWHESSBGOO();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SADJUTNYGIB(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum NetworkSynchronizationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		NetworkTransform,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		PlayerAvatarData,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		FullBodyPuppetData,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		AvatarSkeletonData,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		ControlDeckData,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		RCCarData,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		GroundVehicleData,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		NetworkEnemyHeadRotationData,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		DesktopScreenSharing,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		RoomieAIAudio,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		GameAIAudio,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Invalid
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NetworkSyncInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public uint senderNetworkTick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public double serverNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int serverNetworkTick;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ISZUUHTTWXQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), OHYEOYPFJWA> EEKGBVWPKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly List<HEKKHQTKHYQ> WRZKRNBJJZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> YIGOXRFPVSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int WZMRRXHNNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool LGXDPPJURWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HFBGITOWSIU.ApplyNetworkTransform LKRHHFNIYDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MemoryStream NGPQXANHNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly BitPacker YDATBPEQYFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly BitPacker KQUQLQFUAYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] HCZCCHTTOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float QMZNFEBUFZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int TTINXUBJEEQ;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F1C0", Offset = "0x8B3DDC0", VA = "0x188B3F1C0")]
		public ISZUUHTTWXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B3EBE0", Offset = "0x8B3D7E0", VA = "0x188B3EBE0")]
		public void Pause(HFBGITOWSIU.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F170", Offset = "0x8B3DD70", VA = "0x188B3F170")]
		public void YSWHESSBGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B3ED40", Offset = "0x8B3D940", VA = "0x188B3ED40")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B3DC90", Offset = "0x8B3C890", VA = "0x188B3DC90")]
		public bool Add(HEKKHQTKHYQ networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B3EC10", Offset = "0x8B3D810", VA = "0x188B3EC10")]
		public bool Remove(HEKKHQTKHYQ networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8B3E9D0", Offset = "0x8B3D5D0", VA = "0x188B3E9D0")]
		private OHYEOYPFJWA MDVTPFBKNYL(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B3EC00", Offset = "0x8B3D800", VA = "0x188B3EC00")]
		public void RHHIHOJWAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F110", Offset = "0x8B3DD10", VA = "0x188B3F110")]
		private void VVWHPTUXVJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B3E9B0", Offset = "0x8B3D5B0", VA = "0x188B3E9B0")]
		private void FOKTNIQDABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B3E600", Offset = "0x8B3D200", VA = "0x188B3E600")]
		public bool ESYWMTIYQND(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B3E210", Offset = "0x8B3CE10", VA = "0x188B3E210")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class PYDVLJYTFIR : OHYEOYPFJWA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private HEKKHQTKHYQ URKIEBGSGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private uint PUISNGPVSGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int MQFHJWPXXRX;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool JXLMINNEJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public PYDVLJYTFIR(HEKKHQTKHYQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A100", Offset = "0x8B48D00", VA = "0x188B4A100", Slot = "5")]
		public bool KLLSFCVPVJT(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A020", Offset = "0x8B48C20", VA = "0x188B4A020", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class CRVNWWSKLYW : OHYEOYPFJWA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private HFBGITOWSIU.ApplyNetworkTransform LKRHHFNIYDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly ViewId RALQDORONJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int MQFHJWPXXRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private uint PUISNGPVSGE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JXLMINNEJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6490", Offset = "0x1FD5090", VA = "0x181FD6490")]
		public CRVNWWSKLYW(ViewId a, HFBGITOWSIU.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B35800", Offset = "0x8B34400", VA = "0x188B35800", Slot = "5")]
		public bool KLLSFCVPVJT(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B35620", Offset = "0x8B34220", VA = "0x188B35620", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class TXRIGTDXECC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B56620", Offset = "0x8B55220", VA = "0x188B56620")]
		public static void Serialize(this NetworkTransformSyncData syncData, BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B55D60", Offset = "0x8B54960", VA = "0x188B55D60")]
		public static void GGDZQACNDGY(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B55BF0", Offset = "0x8B547F0", VA = "0x188B55BF0")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B56260", Offset = "0x8B54E60", VA = "0x188B56260")]
		public static void LWYDQVWEZUN(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(CCJOSMUVBRJ), new string[] { })]
	public class ZFGOWRREBYK : CCJOSMUVBRJ, INetworkUpdateSystem, MOWQOGDYZLC, BMZVOVVGZNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Log VTPTYAFJYMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private ISZUUHTTWXQ XNMCAEVNGVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private uint DVHXZQYBBFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float SSMLFMBWSKW;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B57CA0", Offset = "0x8B568A0", VA = "0x188B57CA0", Slot = "4")]
		public void ERBMWTZFFKA(HEKKHQTKHYQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B57AA0", Offset = "0x8B566A0", VA = "0x188B57AA0", Slot = "5")]
		public void BUEMJHJNWRJ(HEKKHQTKHYQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B57DC0", Offset = "0x8B569C0", VA = "0x188B57DC0", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B57F10", Offset = "0x8B56B10", VA = "0x188B57F10", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B58530", Offset = "0x8B57130", VA = "0x188B58530")]
		private void YVCMNVQBFJA(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B58320", Offset = "0x8B56F20", VA = "0x188B58320", Slot = "6")]
		public void Pause(HFBGITOWSIU.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B584D0", Offset = "0x8B570D0", VA = "0x188B584D0", Slot = "7")]
		public void YSWHESSBGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B58350", Offset = "0x8B56F50", VA = "0x188B58350", Slot = "8")]
		public void SADJUTNYGIB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B57F90", Offset = "0x8B56B90", VA = "0x188B57F90")]
		private void OnEvent(RQAGMLJLYPY networkEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B583B0", Offset = "0x8B56FB0", VA = "0x188B583B0", Slot = "11")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B58B30", Offset = "0x8B57730", VA = "0x188B58B30")]
		public ZFGOWRREBYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class EVRCWRRAIWM : OHYEOYPFJWA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float OKGQAEYNOQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int MQFHJWPXXRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private uint PUISNGPVSGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly NetworkSynchronizationType LRKJVANFMNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NetworkSyncInfo NTDJNEDHELS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int AEAGQEZCVCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte[] DVRVQSBRDVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private NetworkSyncInfo ULSOZQHJBLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int VIOICYNDLTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private byte[] YQGYPWYPEQS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JXLMINNEJAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B36C20", Offset = "0x8B35820", VA = "0x188B36C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B36C50", Offset = "0x8B35850", VA = "0x188B36C50")]
		public EVRCWRRAIWM(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B36A10", Offset = "0x8B35610", VA = "0x188B36A10", Slot = "5")]
		public bool KLLSFCVPVJT(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B36860", Offset = "0x8B35460", VA = "0x188B36860", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B36760", Offset = "0x8B35360", VA = "0x188B36760")]
		internal PYDVLJYTFIR AQSEVQOCGGU(HEKKHQTKHYQ a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B36A50", Offset = "0x8B35650", VA = "0x188B36A50")]
		private static void KXDWOHAHQVQ(PYDVLJYTFIR a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RegisterService(typeof(TSJMTWAZAEP), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class TSJMTWAZAEP : MVDRLHIYJLM, MOWQOGDYZLC, BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly Hashtable NHLRMNPHZQL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly Hashtable NEZARYOQHRJ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly Hashtable SNVZOGVVOPB;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly PZIMWREHPGJ CSCWFFUSQYZ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly PZIMWREHPGJ OLEGCIZWFZG;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly PZIMWREHPGJ EZLAYBZQVQY;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly PZIMWREHPGJ ZTDIYLDQDNL;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly PZIMWREHPGJ YMZKWYSGNVG;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static int CKJWEJMBZFL;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B54980", Offset = "0x8B53580", VA = "0x188B54980", Slot = "4")]
		public bool NZVLFSLGWOR(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B536C0", Offset = "0x8B522C0", VA = "0x188B536C0", Slot = "5")]
		public int BHYBDKDYAXP(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B53A70", Offset = "0x8B52670", VA = "0x188B53A70", Slot = "6")]
		public bool DVWPYWVHAOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B54600", Offset = "0x8B53200", VA = "0x188B54600", Slot = "7")]
		public bool KMSRIFHIDDT(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B53B00", Offset = "0x8B52700", VA = "0x188B53B00", Slot = "8")]
		public void ENZIUHTOGEM(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B54AC0", Offset = "0x8B536C0", VA = "0x188B54AC0", Slot = "9")]
		public bool QFVTMVDGFTW(RQAGMLJLYPY a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B53E40", Offset = "0x8B52A40", VA = "0x188B53E40", Slot = "10")]
		public bool HCESFMFXBVP(RQAGMLJLYPY a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B54790", Offset = "0x8B53390", VA = "0x188B54790", Slot = "11")]
		public bool KOWVSMHUDDU(RQAGMLJLYPY a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B54270", Offset = "0x8B52E70", VA = "0x188B54270", Slot = "12")]
		public void IQEMYVIRWVQ(RQAGMLJLYPY a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B54110", Offset = "0x8B52D10", VA = "0x188B54110", Slot = "13")]
		public void IBRCLJEICCJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8B544F0", Offset = "0x8B530F0", VA = "0x188B544F0", Slot = "14")]
		public void JNVNSSREISJ(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8B551F0", Offset = "0x8B53DF0", VA = "0x188B551F0", Slot = "15")]
		public void RIYYRYRGGGH(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B548B0", Offset = "0x8B534B0", VA = "0x188B548B0", Slot = "16")]
		public void MWJFYLOMYDE(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B53CE0", Offset = "0x8B528E0", VA = "0x188B53CE0", Slot = "17")]
		public void FEWOUSDIYCM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B55340", Offset = "0x8B53F40", VA = "0x188B55340")]
		private static void VRSDPADBURP(InstantiateParameters a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B54C30", Offset = "0x8B53830", VA = "0x188B54C30")]
		private static bool QFVTMVDGFTW(Hashtable a, WJBKOLNRRJE b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B55760", Offset = "0x8B54360", VA = "0x188B55760")]
		private static int WHHDINOVEJJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B54450", Offset = "0x8B53050", VA = "0x188B54450", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B552A0", Offset = "0x8B53EA0", VA = "0x188B552A0", Slot = "19")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public TSJMTWAZAEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RegisterService(typeof(DNQMIGUXZMJ), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class DNQMIGUXZMJ : CWPLPQTZFQQ, MOWQOGDYZLC, BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static Hashtable JVFUJTTMPRW;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static Hashtable RJAHKMQEKZF;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static PZIMWREHPGJ IWDRYNJQOVA;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly PZIMWREHPGJ NEESOIXGQTZ;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B35D40", Offset = "0x8B34940", VA = "0x188B35D40", Slot = "4")]
		public void HTIMSIDCFII(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B35960", Offset = "0x8B34560", VA = "0x188B35960", Slot = "5")]
		public bool FWEXUOJJKFO(RQAGMLJLYPY a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B35E20", Offset = "0x8B34A20", VA = "0x188B35E20", Slot = "6")]
		public void IHLBPHSNYDY(ViewId a, string b, RpcTarget c, WJBKOLNRRJE d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8B36510", Offset = "0x8B35110", VA = "0x188B36510", Slot = "8")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8B36470", Offset = "0x8B35070", VA = "0x188B36470", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public DNQMIGUXZMJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class TVPIAHUZMHV
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B55B10", Offset = "0x8B54710", VA = "0x188B55B10")]
		public static WJBKOLNRRJE GAHPUGKYCOW(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8B55BA0", Offset = "0x8B547A0", VA = "0x188B55BA0")]
		public static PlayerId ToPlayerId(this WJBKOLNRRJE player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, NKIPYOMYKIK, ENGUIRZTRVL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool NZSMQGYPZSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView GIAOGZZZHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<IAQVLAAHTRJ> TMDOETXLINW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool GYKRDKEJGDL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId OQWOOHFSMZW
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AB30", Offset = "0x8B49730", VA = "0x188B4AB30")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId MANQSSDMLCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AB30", Offset = "0x8B49730", VA = "0x188B4AB30", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView UKHNPDUPPFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8B4ABB0", Offset = "0x8B497B0", VA = "0x188B4ABB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView EPCVQWBCLSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8B4ABB0", Offset = "0x8B497B0", VA = "0x188B4ABB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WJBKOLNRRJE JTIZVKJZWNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B4ACB0", Offset = "0x8B498B0", VA = "0x188B4ACB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public WJBKOLNRRJE TPGTEFQVGCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B010", Offset = "0x8B49C10", VA = "0x188B4B010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool UHBWIERRIJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AE10", Offset = "0x8B49A10", VA = "0x188B4AE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool XGPLLVRGNZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AF80", Offset = "0x8B49B80", VA = "0x188B4AF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool TZRJWYPIHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AA60", Offset = "0x8B49660", VA = "0x188B4AA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool FQOQKCRZXCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AD40", Offset = "0x8B49940", VA = "0x188B4AD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool OCPENFIYVDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AA60", Offset = "0x8B49660", VA = "0x188B4AA60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ZALVYUUURPC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AAE0", Offset = "0x8B496E0", VA = "0x188B4AAE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string NLTHPMXKSNO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8B4AC20", Offset = "0x8B49820", VA = "0x188B4AC20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool JVRQGKSGIIH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4A9E0", Offset = "0x8B495E0", VA = "0x188B4A9E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<WJBKOLNRRJE> UUMTYWPKOAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8B4A8B0", Offset = "0x8B494B0", VA = "0x188B4A8B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B0A0", Offset = "0x8B49CA0", VA = "0x188B4B0A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A810", Offset = "0x8B49410", VA = "0x188B4A810")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E79180", Offset = "0x7E77D80", VA = "0x187E79180")]
		private void GLSCAVDEOVQ(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A410", Offset = "0x8B49010", VA = "0x188B4A410", Slot = "9")]
		public void RegisterDestroyHandler(IAQVLAAHTRJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A650", Offset = "0x8B49250", VA = "0x188B4A650", Slot = "10")]
		public void UnregisterDestroyHandler(IAQVLAAHTRJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A3F0", Offset = "0x8B48FF0", VA = "0x188B4A3F0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class IXPRHRRXJZS
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, WJBKOLNRRJE targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, WJBKOLNRRJE targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, WJBKOLNRRJE newOwner);

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback LFRQRVZESTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F470", Offset = "0x8B3E070", VA = "0x188B3F470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FEF0", Offset = "0x8B3EAF0", VA = "0x188B3FEF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback NYDGVYHRMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F6B0", Offset = "0x8B3E2B0", VA = "0x188B3F6B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F3B0", Offset = "0x8B3DFB0", VA = "0x188B3F3B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event InstantiateCallback JIHPQOGURMY
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8B40560", Offset = "0x8B3F160", VA = "0x188B40560")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FCB0", Offset = "0x8B3E8B0", VA = "0x188B3FCB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback CQBZRYQAJQX
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8B407F0", Offset = "0x8B3F3F0", VA = "0x188B407F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FBF0", Offset = "0x8B3E7F0", VA = "0x188B3FBF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event DestroyCallback OCJYHUEJCRY
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FA70", Offset = "0x8B3E670", VA = "0x188B3FA70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FE30", Offset = "0x8B3EA30", VA = "0x188B3FE30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCInvokedCallback VLRBASSWSPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F530", Offset = "0x8B3E130", VA = "0x188B3F530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8B403E0", Offset = "0x8B3EFE0", VA = "0x188B403E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCSendingCallback HMPXRNGXLZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8B404A0", Offset = "0x8B3F0A0", VA = "0x188B404A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FB30", Offset = "0x8B3E730", VA = "0x188B3FB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event RPCReceivedCallback DIJOPJNJUDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8B401D0", Offset = "0x8B3EDD0", VA = "0x188B401D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F9B0", Offset = "0x8B3E5B0", VA = "0x188B3F9B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler EYNCTLVQONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F770", Offset = "0x8B3E370", VA = "0x188B3F770")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FD70", Offset = "0x8B3E970", VA = "0x188B3FD70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public static event OnOwnershipTransferedHandler KIFTHWXWFWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F8F0", Offset = "0x8B3E4F0", VA = "0x188B3F8F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F5F0", Offset = "0x8B3E1F0", VA = "0x188B3F5F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F830", Offset = "0x8B3E430", VA = "0x188B3F830")]
		public static void GLECTVUEGAW([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B408B0", Offset = "0x8B3F4B0", VA = "0x188B408B0")]
		public static void ZALYCUGXLHC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8B40620", Offset = "0x8B3F220", VA = "0x188B40620")]
		public static void WUMJMMSPLVF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B3FFB0", Offset = "0x8B3EBB0", VA = "0x188B3FFB0")]
		public static void QRELCGJHJAO(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8B40040", Offset = "0x8B3EC40", VA = "0x188B40040")]
		public static void QUAWDQNULOJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B40290", Offset = "0x8B3EE90", VA = "0x188B40290")]
		public static void TDBLEVTTFYJ(RRNetworkView a, string b, WJBKOLNRRJE c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8B406B0", Offset = "0x8B3F2B0", VA = "0x188B406B0")]
		public static void XCZWGVUCFVW(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B400D0", Offset = "0x8B3ECD0", VA = "0x188B400D0")]
		public static void RLCKGHIWUPO(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class YLVBLPCNNRF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B579F0", Offset = "0x8B565F0", VA = "0x188B579F0")]
		[CanBeNull]
		private static bool UQIAPECEGYF(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B57910", Offset = "0x8B56510", VA = "0x188B57910")]
		[CanBeNull]
		public static Component JZQYYRHITGV(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x41E84F0", Offset = "0x41E70F0", VA = "0x1841E84F0")]
		[CanBeNull]
		public static a JZQYYRHITGV<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x41E8480", Offset = "0x41E7080", VA = "0x1841E8480")]
		[CanBeNull]
		public static b IQPYEPQOQYB<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x41E82D0", Offset = "0x41E6ED0", VA = "0x1841E82D0")]
		public static bool FKCFRWMLITS<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B57840", Offset = "0x8B56440", VA = "0x188B57840")]
		[CanBeNull]
		public static RRNetworkView DBIASTWBDAM(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static RRNetworkHandler RKTTWJLJQPE;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B210", Offset = "0x8B49E10", VA = "0x188B4B210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B3A0", Offset = "0x8B49FA0", VA = "0x188B4B3A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B1D0", Offset = "0x8B49DD0", VA = "0x188B4B1D0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RegisterService(typeof(JEFZXOJJJTX), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class JEFZXOJJJTX : EYMANZDSEGU, MOWQOGDYZLC, BMZVOVVGZNC, YGTTGTSBWNM, UJJANZWBMES
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class RGBAJBLOFPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int VHQVFRZTJRF;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public RGBAJBLOFPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8B4A210", Offset = "0x8B48E10", VA = "0x188B4A210")]
			internal object JJHYBKUHVJS((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static Log GXTHPEWXIXC;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static Log ULGSMHASEBK;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static Dictionary<int, HashSet<int>> GKRTZTNHRSO;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static Dictionary<int, int> EZUJQNBDNIP;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly List<(GameObject GameObject, int ParentCount)> KPFMDRQYUAW;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly List<GameObject> ODKQZQLZLOX;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static List<int> ODEVKQUXIUR;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly List<RRNetworkView> CPJNDCXTFDZ;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly PZIMWREHPGJ ZTDIYLDQDNL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly PZIMWREHPGJ YMZKWYSGNVG;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B43140", Offset = "0x8B41D40", VA = "0x188B43140", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B478F0", Offset = "0x8B464F0", VA = "0x188B478F0", Slot = "9")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B42F80", Offset = "0x8B41B80", VA = "0x188B42F80", Slot = "10")]
		public void InitExternal(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B47730", Offset = "0x8B46330", VA = "0x188B47730", Slot = "11")]
		public void ShutdownExternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B46510", Offset = "0x8B45110", VA = "0x188B46510")]
		private void OURZFIGYFCG(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B42150", Offset = "0x8B40D50", VA = "0x188B42150")]
		private void HEQAKDSAOWD(WGQKHJHIHJT a, WGQKHJHIHJT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B440B0", Offset = "0x8B42CB0", VA = "0x188B440B0")]
		public GameObject KPISTWDZNHR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B47000", Offset = "0x8B45C00", VA = "0x188B47000")]
		public GameObject PQIKNJMNIFR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B41250", Offset = "0x8B3FE50", VA = "0x188B41250")]
		public GameObject BXCMFBIQWIO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B44080", Offset = "0x8B42C80", VA = "0x188B44080")]
		public GameObject KMRFFWPFOWE(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B42F70", Offset = "0x8B41B70", VA = "0x188B42F70", Slot = "6")]
		public void HMXHRLNLREE(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B44380", Offset = "0x8B42F80", VA = "0x188B44380")]
		public void LRKINRTMXWN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B41E80", Offset = "0x8B40A80", VA = "0x188B41E80", Slot = "7")]
		public void FYDAQJYTLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B40940", Offset = "0x8B3F540", VA = "0x188B40940", Slot = "4")]
		public GameObject[] ANJUMCSOQYK(IList<UHZKUSZYQRX> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B48260", Offset = "0x8B46E60", VA = "0x188B48260", Slot = "5")]
		public void XMRFPZPHOPH(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B43490", Offset = "0x8B42090", VA = "0x188B43490")]
		public void JCDPHCXKRZF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B46630", Offset = "0x8B45230", VA = "0x188B46630")]
		private void OnEvent(RQAGMLJLYPY eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B48D30", Offset = "0x8B47930", VA = "0x188B48D30")]
		private void ZOPFDXKWIXU(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B41E90", Offset = "0x8B40A90", VA = "0x188B41E90")]
		private void GARZYZXABKI(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B40C70", Offset = "0x8B3F870", VA = "0x188B40C70")]
		private void ANLLTHZGOLO(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B46C50", Offset = "0x8B45850", VA = "0x188B46C50")]
		private void PQFVWCGPKJK(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B47C40", Offset = "0x8B46840", VA = "0x188B47C40")]
		private void TMMQGAITLAQ(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B486D0", Offset = "0x8B472D0", VA = "0x188B486D0")]
		private void YOEGHOWJQTI(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B47E30", Offset = "0x8B46A30", VA = "0x188B47E30")]
		private GameObject VFZYIEXGMHP(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B43980", Offset = "0x8B42580", VA = "0x188B43980")]
		private GameObject KGQTTZATBTB(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B476B0", Offset = "0x8B462B0", VA = "0x188B476B0")]
		private static GameObject RXREUDTCIRX(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B40F40", Offset = "0x8B3FB40", VA = "0x188B40F40")]
		private static GameObject BBBRDWNPSSE(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B41D70", Offset = "0x8B40970", VA = "0x188B41D70")]
		private static void EQZUEDEIYMD(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B415B0", Offset = "0x8B401B0", VA = "0x188B415B0")]
		private GameObject[] CIJQPLGHZUK(IList<UHZKUSZYQRX> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B46030", Offset = "0x8B44C30", VA = "0x188B46030")]
		private GameObject[] NWRIXUNENXW(InstantiateParameters[] a, int b, WJBKOLNRRJE c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B43570", Offset = "0x8B42170", VA = "0x188B43570")]
		private GameObject JVZDZDTEADI([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E56660", Offset = "0x7E55260", VA = "0x187E56660")]
		private static bool AXNDVNGCELB(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B42240", Offset = "0x8B40E40", VA = "0x188B42240")]
		private void HMCIDIILEST(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B45110", Offset = "0x8B43D10", VA = "0x188B45110")]
		private void NMQEEWXDVYP(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B472C0", Offset = "0x8B45EC0", VA = "0x188B472C0")]
		private static void RSLWZKREVNY(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B47160", Offset = "0x8B45D60", VA = "0x188B47160")]
		private void QZITJNGLQWW(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B41150", Offset = "0x8B3FD50", VA = "0x188B41150")]
		private static int BBETPFBHQBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B47100", Offset = "0x8B45D00", VA = "0x188B47100")]
		private void QFCJMABTBYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B443F0", Offset = "0x8B42FF0", VA = "0x188B443F0")]
		private void LYBMMCVGQYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B411F0", Offset = "0x8B3FDF0", VA = "0x188B411F0")]
		private static int BWVPAXJQIAG(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B414D0", Offset = "0x8B400D0", VA = "0x188B414D0")]
		private static int[] CHBAUYMQMCL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B44280", Offset = "0x8B42E80", VA = "0x188B44280")]
		private static int[] LGDUVNEMKPR(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B46C10", Offset = "0x8B45810", VA = "0x188B46C10")]
		private void OnMasterClientSwitched(WJBKOLNRRJE newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B44940", Offset = "0x8B43540", VA = "0x188B44940")]
		private void NCHSCDAFGML(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B46930", Offset = "0x8B45530", VA = "0x188B46930")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B48020", Offset = "0x8B46C20", VA = "0x188B48020")]
		private void WTJQFZUFCUL(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B48630", Offset = "0x8B47230", VA = "0x188B48630")]
		private static void YBZEYYTWTJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B46410", Offset = "0x8B45010", VA = "0x188B46410")]
		private void ODXCEZGNLUV(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public JEFZXOJJJTX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct RRProfilerCounter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private ProfilerCounterValue<long> inboundCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private ProfilerCounterValue<long> outboundCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private long lastInboundValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private long lastOutboundValue;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8B535E0", Offset = "0x8B521E0", VA = "0x188B535E0")]
			public RRProfilerCounter(string name, ProfilerMarkerDataUnit unit = ProfilerMarkerDataUnit.Count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B53570", Offset = "0x8B52170", VA = "0x188B53570")]
			public void Update(long inboundValue, long outboundValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B3E0", Offset = "0x8B49FE0", VA = "0x188B4B3E0")]
			public void HFUXYKGVOPJ(long a = 1L)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B420", Offset = "0x8B4A020", VA = "0x188B4B420")]
			public void WGBNGOOGUTU(long a = 1L)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private RRProfilerCounter SWKLXYCPVME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private RRProfilerCounter BDYPTHUESAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private RRProfilerCounter JPFWDROMIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private RRProfilerCounter KXEKZMPYJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private RRProfilerCounter ONNVGKJRYIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RRProfilerCounter WMNRWLNSAQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private RRProfilerCounter ZMOHXXVRQLN;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4C080", Offset = "0x8B4AC80", VA = "0x188B4C080")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CCA0", Offset = "0x8B4B8A0", VA = "0x188B4CCA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B420", Offset = "0x8B4A020", VA = "0x188B4B420")]
		private void RMOUCPLJMHH(RRNetworkView a, string b, WJBKOLNRRJE c, RpcTarget? d, bool e, RpcCacheOption f, object[] g, string h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B3E0", Offset = "0x8B49FE0", VA = "0x188B4B3E0")]
		private void ZZIVZAUBQLW(RRNetworkView a, string b, object[] c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B420", Offset = "0x8B4A020", VA = "0x188B4B420")]
		private void DZKUSHYFQOG(Hashtable a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B3E0", Offset = "0x8B49FE0", VA = "0x188B4B3E0")]
		private void LBBRBFGOKMB(Hashtable a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B420", Offset = "0x8B4A020", VA = "0x188B4B420")]
		private void ZZHELJUMPFG(WJBKOLNRRJE a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B3E0", Offset = "0x8B49FE0", VA = "0x188B4B3E0")]
		private void AOXBHWVERQL(WJBKOLNRRJE a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B420", Offset = "0x8B4A020", VA = "0x188B4B420")]
		private void BKMJAMEQIBN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B3E0", Offset = "0x8B49FE0", VA = "0x188B4B3E0")]
		private void CLFOIAWESIC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B420", Offset = "0x8B4A020", VA = "0x188B4B420")]
		private void RMXWFKDZDPH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B3E0", Offset = "0x8B49FE0", VA = "0x188B4B3E0")]
		private void RBFJLCXTWSE(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B420", Offset = "0x8B4A020", VA = "0x188B4B420")]
		private void RLCKGHIWUPO(RRNetworkView a, WJBKOLNRRJE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B3E0", Offset = "0x8B49FE0", VA = "0x188B4B3E0")]
		private void MGNYPJLCAXH(RRNetworkView a, WJBKOLNRRJE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B460", Offset = "0x8B4A060", VA = "0x188B4B460")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CD30", Offset = "0x8B4B930", VA = "0x188B4CD30")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RegisterService(typeof(GFYBNQNVUTB), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class GFYBNQNVUTB : MOWQOGDYZLC, BMZVOVVGZNC, EJTGRNPRMBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct RpcMethodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public readonly MethodInfo methodInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly Func<MonoBehaviour, object> accessor;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7E64890", Offset = "0x7E63490", VA = "0x187E64890")]
			public object AQYRNRBNLLX(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public object[] OQODWLGCFGJ;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8B57540", Offset = "0x8B56140", VA = "0x188B57540")]
			internal object DQRRTCUNWSY((ViewId view, string methodName, RpcTarget target, WJBKOLNRRJE player, RpcCacheOption caching, object[] parameters) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class LOJPDCGXZIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public object[] OXBJVAFPKPW;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LOJPDCGXZIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8B49370", Offset = "0x8B47F70", VA = "0x188B49370")]
			internal object GESAIQOELNR((RpcMethodInfo method, MonoBehaviour monob, object[] args) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class VOMCTXEGQPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public FieldInfo QMFNOQTZSGU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public Func<MonoBehaviour, object> VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public VOMCTXEGQPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8B57480", Offset = "0x8B56080", VA = "0x188B57480")]
			internal RpcMethodInfo RSACHYNYZOD(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x560A2B0", Offset = "0x5608EB0", VA = "0x18560A2B0")]
			internal object RRUVKRUBQCU(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class VOGVWQKJHEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Func<MonoBehaviour, object> ZKHZWKZJXOK;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public VOGVWQKJHEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E668F0", Offset = "0x7E654F0", VA = "0x187E668F0")]
			internal RpcMethodInfo RTAKUGJLUSW(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class TCPIQNKCSSB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public Type WIDJDWGTKRN;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TCPIQNKCSSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8B53680", Offset = "0x8B52280", VA = "0x188B53680")]
			internal bool XFVNBCZZIOH(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static Dictionary<string, int> BLWNYKFPUAX;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static List<string> DTGCVDZVPTQ;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static int ERBDZYOIPQT;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly Stopwatch DLTBSVUFYJZ;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static Dictionary<MethodInfo, ParameterInfo[]> BYQYIOLLKVA;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> UINDIYCEMTX;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B380F0", Offset = "0x8B36CF0", VA = "0x188B380F0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A6D0", Offset = "0x8B392D0", VA = "0x188B3A6D0", Slot = "5")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B36FE0", Offset = "0x8B35BE0", VA = "0x188B36FE0")]
		public static bool GQQSFTZFWXT(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A820", Offset = "0x8B39420", VA = "0x188B3A820")]
		public static bool WZROBLBXWTD(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8B39D20", Offset = "0x8B38920", VA = "0x188B39D20")]
		private void OnEvent(RQAGMLJLYPY eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8B38620", Offset = "0x8B37220", VA = "0x188B38620", Slot = "9")]
		public string MMALBATTXHF(RQAGMLJLYPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8B38010", Offset = "0x8B36C10", VA = "0x188B38010", Slot = "8")]
		public void HTIMSIDCFII(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8B39FD0", Offset = "0x8B38BD0", VA = "0x188B39FD0", Slot = "6")]
		public void RPC(ViewId view, string methodName, WJBKOLNRRJE player, RpcCacheOption caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A0A0", Offset = "0x8B38CA0", VA = "0x188B3A0A0", Slot = "7")]
		public void RPC(ViewId view, string methodName, RpcTarget target, RpcCacheOption caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A0D0", Offset = "0x8B38CD0", VA = "0x188B3A0D0")]
		private void RPC(ViewId view, string methodName, RpcTarget target, WJBKOLNRRJE player, RpcCacheOption caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B38650", Offset = "0x8B37250", VA = "0x188B38650")]
		private void OIUPSHEEEKH(ViewId a, string b, WJBKOLNRRJE c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8B37170", Offset = "0x8B35D70", VA = "0x188B37170")]
		private static void HLNRRBUELFH(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8B36CC0", Offset = "0x8B358C0", VA = "0x188B36CC0")]
		private static bool GHFZWACOIEA(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8B37740", Offset = "0x8B36340", VA = "0x188B37740")]
		private List<RpcMethodInfo> HMCIQHYZOGH(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B37070", Offset = "0x8B35C70", VA = "0x188B37070")]
		private static IEnumerable<MethodInfo> HBOJRDUYPGN(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8B36ED0", Offset = "0x8B35AD0", VA = "0x188B36ED0")]
		public static ParameterInfo[] GJLXJHBTQZL(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public GFYBNQNVUTB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[TooltipAttribute("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D260", Offset = "0x8B4BE60", VA = "0x188B4D260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D1E0", Offset = "0x8B4BDE0", VA = "0x188B4D1E0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RRNetworkView : MonoBehaviour, RSMNXEMFWCP, ADWLLRNKHEU, HMPFGXEOMIV, PTPJAIETWZR, ERXFZSGLFIW
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum HasExplicitViewId
		{
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			False,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int SGOTMFAHQMH;

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x8B35840", Offset = "0x8B34440", VA = "0x188B35840")]
			internal bool WGJLCSGVBEF(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static Dictionary<int, RRNetworkView> TQESQHBFORX;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static PZIMWREHPGJ PYNSMAGPZXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool LCNZVLNLVPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool ZEHAJFDUDYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool MQGRSFOFIXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int LXZAFOTVTEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool MGKGAHGSMIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int DVXMTTKGFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private WJBKOLNRRJE TPGTEFQVGCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private WJBKOLNRRJE EBHUCHAEXVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool? PRHGNJUVKER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private bool NRWDDKYPUOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		internal bool BUSXFVSAPTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		internal MonoBehaviour[] THYBEYCOHKH;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly Log QDFBGILTQYQ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId MANQSSDMLCY
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8B517E0", Offset = "0x8B503E0", VA = "0x188B517E0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId XQXXGBZVJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8B517E0", Offset = "0x8B503E0", VA = "0x188B517E0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId OQWOOHFSMZW
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8B517E0", Offset = "0x8B503E0", VA = "0x188B517E0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int XKLKPTNBTDD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int JXZMOZRFOHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xB3C3D0", Offset = "0xB3AFD0", VA = "0x180B3C3D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xF7EB30", Offset = "0xF7D730", VA = "0x180F7EB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ViewId FTKNPRWNPTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8B51650", Offset = "0x8B50250", VA = "0x188B51650")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool PVDMKDNANPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xDD0FC0", Offset = "0xDCFBC0", VA = "0x180DD0FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xC901B0", Offset = "0xC8EDB0", VA = "0x180C901B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool XVDDFJSUZGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8B51660", Offset = "0x8B50260", VA = "0x188B51660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool GTCRRRJWUTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int CHYTFMMIQWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB63A40", Offset = "0xB62640", VA = "0x180B63A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int QDPZBSPSGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8B515F0", Offset = "0x8B501F0", VA = "0x188B515F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public WJBKOLNRRJE GOJVBTVKYWI
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8B517F0", Offset = "0x8B503F0", VA = "0x188B517F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public WJBKOLNRRJE IEOOIQMIPTH
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8B515C0", Offset = "0x8B501C0", VA = "0x188B515C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public WJBKOLNRRJE JTIZVKJZWNU
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8B515C0", Offset = "0x8B501C0", VA = "0x188B515C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public WJBKOLNRRJE KIUMPELAMOK
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8B515C0", Offset = "0x8B501C0", VA = "0x188B515C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool HLKKCBZNVVI
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8B51730", Offset = "0x8B50330", VA = "0x188B51730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int IQLCGDBTQLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8B51620", Offset = "0x8B50220", VA = "0x188B51620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public object[] CAURDYKTUZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool UHBWIERRIJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8B51820", Offset = "0x8B50420", VA = "0x188B51820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool TSUPTTHZTIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8B517B0", Offset = "0x8B503B0", VA = "0x188B517B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool TTOOCIHUSTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xCBFFF0", Offset = "0xCBEBF0", VA = "0x180CBFFF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x101A520", Offset = "0x1019120", VA = "0x18101A520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool BFDQKOWTRKD
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0D0", Offset = "0xB9CCD0", VA = "0x180B9E0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<RRNetworkView> HVCHOBLOXBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8B51450", Offset = "0x8B50050", VA = "0x188B51450")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8B519E0", Offset = "0x8B505E0", VA = "0x188B519E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		private event Action<WJBKOLNRRJE> JPBWGCSFDUR
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D3D0", Offset = "0x8B4BFD0", VA = "0x188B4D3D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DCE0", Offset = "0x8B4C8E0", VA = "0x188B4DCE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<WJBKOLNRRJE> XXFUUAEAGQV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D3D0", Offset = "0x8B4BFD0", VA = "0x188B4D3D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DCE0", Offset = "0x8B4C8E0", VA = "0x188B4DCE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		private event Action<int> OOLGIOZOYJO
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4E100", Offset = "0x8B4CD00", VA = "0x188B4E100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D9E0", Offset = "0x8B4C5E0", VA = "0x188B4D9E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<int> IRKFNVKKHXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8B4E100", Offset = "0x8B4CD00", VA = "0x188B4E100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D9E0", Offset = "0x8B4C5E0", VA = "0x188B4D9E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<RRNetworkView> MKTSKGVCAWS
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8B51500", Offset = "0x8B50100", VA = "0x188B51500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8B51A90", Offset = "0x8B50690", VA = "0x188B51A90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action GWZHBOLDGTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x8B513A0", Offset = "0x8B4FFA0", VA = "0x188B513A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8B51930", Offset = "0x8B50530", VA = "0x188B51930")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8B50B90", Offset = "0x8B4F790", VA = "0x188B50B90")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DA90", Offset = "0x8B4C690", VA = "0x188B4DA90")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DE10", Offset = "0x8B4CA10", VA = "0x188B4DE10")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DDA0", Offset = "0x8B4C9A0", VA = "0x188B4DDA0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EF30", Offset = "0x8B4DB30", VA = "0x188B4EF30")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8B4ED00", Offset = "0x8B4D900", VA = "0x188B4ED00")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E750", Offset = "0x8B4D350", VA = "0x188B4E750")]
		public static void OnPlayerJoinedRoom(WJBKOLNRRJE newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DF50", Offset = "0x8B4CB50", VA = "0x188B4DF50")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DFB0", Offset = "0x8B4CBB0", VA = "0x188B4DFB0")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8B50870", Offset = "0x8B4F470", VA = "0x188B50870")]
		private void TQOXDOPXHRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D960", Offset = "0x8B4C560", VA = "0x188B4D960")]
		public bool CreatedBy(WJBKOLNRRJE player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8B509B0", Offset = "0x8B4F5B0", VA = "0x188B509B0")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8B50950", Offset = "0x8B4F550", VA = "0x188B50950")]
		public void TransferOwnership(WJBKOLNRRJE newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E2B0", Offset = "0x8B4CEB0", VA = "0x188B4E2B0", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E250", Offset = "0x8B4CE50", VA = "0x188B4E250")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D590", Offset = "0x8B4C190", VA = "0x188B4D590")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8B50CC0", Offset = "0x8B4F8C0", VA = "0x188B50CC0")]
		private void ZHOOAQXTLTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x238AE20", Offset = "0x2389A20", VA = "0x18238AE20")]
		internal void RNTLIMUTRFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B511B0", Offset = "0x8B4FDB0", VA = "0x188B511B0", Slot = "6")]
		private void ZTTGQUQUZZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E480", Offset = "0x8B4D080", VA = "0x188B4E480")]
		internal bool LCMZYJMEGAF(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E5B0", Offset = "0x8B4D1B0", VA = "0x188B4E5B0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E420", Offset = "0x8B4D020", VA = "0x188B4E420")]
		internal void JUVBJHTBTDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DD90", Offset = "0x8B4C990", VA = "0x188B4DD90")]
		private void GVHISFEZJDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E4F0", Offset = "0x8B4D0F0", VA = "0x188B4E4F0")]
		internal void NWVXMYYZKSX(WJBKOLNRRJE a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EE90", Offset = "0x8B4DA90", VA = "0x188B4EE90")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EFB0", Offset = "0x8B4DBB0", VA = "0x188B4EFB0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D5E0", Offset = "0x8B4C1E0", VA = "0x188B4D5E0")]
		private void BRGNRFGPYLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E010", Offset = "0x8B4CC10", VA = "0x188B4E010")]
		private void HCUYUANUZRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EC70", Offset = "0x8B4D870", VA = "0x188B4EC70")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EBE0", Offset = "0x8B4D7E0", VA = "0x188B4EBE0")]
		public void RPC(string methodName, WJBKOLNRRJE targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EEE0", Offset = "0x8B4DAE0", VA = "0x188B4EEE0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D680", Offset = "0x8B4C280", VA = "0x188B4D680", Slot = "8")]
		public void Bake(XWQWSOJWOPS context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EAA0", Offset = "0x8B4D6A0", VA = "0x188B4EAA0")]
		private static void PWUINKCKMGO(WJBKOLNRRJE a, [Out] WJBKOLNRRJE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B50EC0", Offset = "0x8B4FAC0", VA = "0x188B50EC0")]
		private static void ZIFABHVHQKF(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8B50C20", Offset = "0x8B4F820", VA = "0x188B50C20")]
		private static RPCInfo VAAQUSDQYRG(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB20", Offset = "0x8B4C720", VA = "0x188B4DB20")]
		private static void GALFDQNITUO(RRNetworkView a, Delegate b, WJBKOLNRRJE c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DC00", Offset = "0x8B4C800", VA = "0x188B4DC00")]
		private static void GALFDQNITUO(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D480", Offset = "0x8B4C080", VA = "0x188B4D480")]
		private static void ASLEDXLXEPP(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EB10", Offset = "0x8B4D710", VA = "0x188B4EB10")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E1B0", Offset = "0x8B4CDB0", VA = "0x188B4E1B0")]
		private static bool IDQILJKYHPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F690", Offset = "0x8B4E290", VA = "0x188B4F690", Slot = "26")]
		public void RpcAll(BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3F318B0", Offset = "0x3F304B0", VA = "0x183F318B0", Slot = "9")]
		public void RpcAll<T1>(BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3F31190", Offset = "0x3F2FD90", VA = "0x183F31190", Slot = "10")]
		public void RpcAll<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3F331A0", Offset = "0x3F31DA0", VA = "0x183F331A0", Slot = "27")]
		public void RpcAll<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F31380", Offset = "0x3F2FF80", VA = "0x183F31380", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F31EE0", Offset = "0x3F30AE0", VA = "0x183F31EE0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F33650", Offset = "0x3F32250", VA = "0x183F33650", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F31A20", Offset = "0x3F30620", VA = "0x183F31A20", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F44A30", Offset = "0x3F43630", VA = "0x183F44A30", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3F33A80", Offset = "0x3F32680", VA = "0x183F33A80", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3F322E0", Offset = "0x3F30EE0", VA = "0x183F322E0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3F49530", Offset = "0x3F48130", VA = "0x183F49530", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F35750", Offset = "0x3F34350", VA = "0x183F35750", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F34860", Offset = "0x3F33460", VA = "0x183F34860", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3F590C0", Offset = "0x3F57CC0", VA = "0x183F590C0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F460", Offset = "0x8B4E060", VA = "0x188B4F460", Slot = "36")]
		public void RpcAll(BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3F42F60", Offset = "0x3F41B60", VA = "0x183F42F60", Slot = "37")]
		public void RpcAll<T1>(BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3F42A80", Offset = "0x3F41680", VA = "0x183F42A80", Slot = "38")]
		public void RpcAll<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3F32B00", Offset = "0x3F31700", VA = "0x183F32B00", Slot = "39")]
		public void RpcAll<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FFE0", Offset = "0x3F3EBE0", VA = "0x183F3FFE0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F410", Offset = "0x3F3E010", VA = "0x183F3F410", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DEB0", Offset = "0x3F3CAB0", VA = "0x183F3DEB0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D5F0", Offset = "0x3F3C1F0", VA = "0x183F3D5F0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BA20", Offset = "0x3F3A620", VA = "0x183F3BA20", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3F3A4B0", Offset = "0x3F390B0", VA = "0x183F3A4B0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F398B0", Offset = "0x3F384B0", VA = "0x183F398B0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F38000", Offset = "0x3F36C00", VA = "0x183F38000", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F36520", Offset = "0x3F35120", VA = "0x183F36520", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B920", Offset = "0x3F5A520", VA = "0x183F5B920", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A8B0", Offset = "0x3F594B0", VA = "0x183F5A8B0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F330", Offset = "0x8B4DF30", VA = "0x188B4F330", Slot = "51")]
		public void RpcAllViaServer(BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F58BF0", Offset = "0x3F577F0", VA = "0x183F58BF0", Slot = "52")]
		public void RpcAllViaServer<T1>(BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F58D80", Offset = "0x3F57980", VA = "0x183F58D80", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3F58690", Offset = "0x3F57290", VA = "0x183F58690", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3F582B0", Offset = "0x3F56EB0", VA = "0x183F582B0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3F57E10", Offset = "0x3F56A10", VA = "0x183F57E10", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3F578B0", Offset = "0x3F564B0", VA = "0x183F578B0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3F57290", Offset = "0x3F55E90", VA = "0x183F57290", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3F56BB0", Offset = "0x3F557B0", VA = "0x183F56BB0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3F56410", Offset = "0x3F55010", VA = "0x183F56410", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3F55BB0", Offset = "0x3F547B0", VA = "0x183F55BB0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3F55290", Offset = "0x3F53E90", VA = "0x183F55290", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3F548A0", Offset = "0x3F534A0", VA = "0x183F548A0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F53DF0", Offset = "0x3F529F0", VA = "0x183F53DF0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F53260", Offset = "0x3F51E60", VA = "0x183F53260", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F200", Offset = "0x8B4DE00", VA = "0x188B4F200", Slot = "65")]
		public void RpcAllViaServer(BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F58BF0", Offset = "0x3F577F0", VA = "0x183F58BF0", Slot = "66")]
		public void RpcAllViaServer<T1>(BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F589A0", Offset = "0x3F575A0", VA = "0x183F589A0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F58690", Offset = "0x3F57290", VA = "0x183F58690", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F582B0", Offset = "0x3F56EB0", VA = "0x183F582B0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F57E10", Offset = "0x3F56A10", VA = "0x183F57E10", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F578B0", Offset = "0x3F564B0", VA = "0x183F578B0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F57290", Offset = "0x3F55E90", VA = "0x183F57290", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F56BB0", Offset = "0x3F557B0", VA = "0x183F56BB0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F56410", Offset = "0x3F55010", VA = "0x183F56410", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F55BB0", Offset = "0x3F547B0", VA = "0x183F55BB0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F55290", Offset = "0x3F53E90", VA = "0x183F55290", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F548A0", Offset = "0x3F534A0", VA = "0x183F548A0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F53DF0", Offset = "0x3F529F0", VA = "0x183F53DF0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F53260", Offset = "0x3F51E60", VA = "0x183F53260", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B50120", Offset = "0x8B4ED20", VA = "0x188B50120", Slot = "80")]
		public void RpcOthers(BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3F8DCA0", Offset = "0x3F8C8A0", VA = "0x183F8DCA0", Slot = "15")]
		public void RpcOthers<T1>(BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F94250", Offset = "0x3F92E50", VA = "0x183F94250", Slot = "81")]
		public void RpcOthers<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F8DA50", Offset = "0x3F8C650", VA = "0x183F8DA50", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F96B70", Offset = "0x3F95770", VA = "0x183F96B70", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F92B20", Offset = "0x3F91720", VA = "0x183F92B20", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F94DD0", Offset = "0x3F939D0", VA = "0x183F94DD0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F91F50", Offset = "0x3F90B50", VA = "0x183F91F50", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F95A40", Offset = "0x3F94640", VA = "0x183F95A40", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F91070", Offset = "0x3F8FC70", VA = "0x183F91070", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F95540", Offset = "0x3F94140", VA = "0x183F95540", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F8FE90", Offset = "0x3F8EA90", VA = "0x183F8FE90", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F8F480", Offset = "0x3F8E080", VA = "0x183F8F480", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E9A0", Offset = "0x3F8D5A0", VA = "0x183F8E9A0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F8DDF0", Offset = "0x3F8C9F0", VA = "0x183F8DDF0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B50270", Offset = "0x8B4EE70", VA = "0x188B50270", Slot = "93")]
		public void RpcOthers(BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F93FB0", Offset = "0x3F92BB0", VA = "0x183F93FB0", Slot = "94")]
		public void RpcOthers<T1>(BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F93DF0", Offset = "0x3F929F0", VA = "0x183F93DF0", Slot = "95")]
		public void RpcOthers<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3F933E0", Offset = "0x3F91FE0", VA = "0x183F933E0", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F93B40", Offset = "0x3F92740", VA = "0x183F93B40", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F94760", Offset = "0x3F93360", VA = "0x183F94760", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F94A70", Offset = "0x3F93670", VA = "0x183F94A70", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F91F50", Offset = "0x3F90B50", VA = "0x183F91F50", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F91840", Offset = "0x3F90440", VA = "0x183F91840", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F91070", Offset = "0x3F8FC70", VA = "0x183F91070", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F907E0", Offset = "0x3F8F3E0", VA = "0x183F907E0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F8FE90", Offset = "0x3F8EA90", VA = "0x183F8FE90", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F8F480", Offset = "0x3F8E080", VA = "0x183F8F480", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E9A0", Offset = "0x3F8D5A0", VA = "0x183F8E9A0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F8DDF0", Offset = "0x3F8C9F0", VA = "0x183F8DDF0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FE50", Offset = "0x8B4EA50", VA = "0x188B4FE50", Slot = "108")]
		public void RpcMaster(BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F728E0", Offset = "0x3F714E0", VA = "0x183F728E0", Slot = "109")]
		public void RpcMaster<T1>(BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F72C60", Offset = "0x3F71860", VA = "0x183F72C60", Slot = "17")]
		public void RpcMaster<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F72640", Offset = "0x3F71240", VA = "0x183F72640", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F72330", Offset = "0x3F70F30", VA = "0x183F72330", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F85BA0", Offset = "0x3F847A0", VA = "0x183F85BA0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F87C00", Offset = "0x3F86800", VA = "0x183F87C00", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E420", Offset = "0x3F7D020", VA = "0x183F7E420", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DAA0", Offset = "0x3F7C6A0", VA = "0x183F7DAA0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BB30", Offset = "0x3F7A730", VA = "0x183F7BB30", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3F855F0", Offset = "0x3F841F0", VA = "0x183F855F0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F845F0", Offset = "0x3F831F0", VA = "0x183F845F0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F77BC0", Offset = "0x3F767C0", VA = "0x183F77BC0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F75E80", Offset = "0x3F74A80", VA = "0x183F75E80", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F72E80", Offset = "0x3F71A80", VA = "0x183F72E80", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FC10", Offset = "0x8B4E810", VA = "0x188B4FC10", Slot = "122")]
		public void RpcMaster(BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3F72A80", Offset = "0x3F71680", VA = "0x183F72A80", Slot = "123")]
		public void RpcMaster<T1>(BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F83910", Offset = "0x3F82510", VA = "0x183F83910", Slot = "124")]
		public void RpcMaster<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F83160", Offset = "0x3F81D60", VA = "0x183F83160", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F81710", Offset = "0x3F80310", VA = "0x183F81710", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F86370", Offset = "0x3F84F70", VA = "0x183F86370", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F7FCE0", Offset = "0x3F7E8E0", VA = "0x183F7FCE0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3F7ECA0", Offset = "0x3F7D8A0", VA = "0x183F7ECA0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D0C0", Offset = "0x3F7BCC0", VA = "0x183F7D0C0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C5C0", Offset = "0x3F7B1C0", VA = "0x183F7C5C0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A380", Offset = "0x3F78F80", VA = "0x183F7A380", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F79660", Offset = "0x3F78260", VA = "0x183F79660", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F76D80", Offset = "0x3F75980", VA = "0x183F76D80", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F74F20", Offset = "0x3F73B20", VA = "0x183F74F20", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F73EA0", Offset = "0x3F72AA0", VA = "0x183F73EA0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FA60", Offset = "0x8B4E660", VA = "0x188B4FA60", Slot = "137")]
		public void RpcAuthority(BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F5CC10", Offset = "0x3F5B810", VA = "0x183F5CC10", Slot = "138")]
		public void RpcAuthority<T1>(BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F6EB10", Offset = "0x3F6D710", VA = "0x183F6EB10", Slot = "139")]
		public void RpcAuthority<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F280", Offset = "0x3F6DE80", VA = "0x183F6F280", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E810", Offset = "0x3F6D410", VA = "0x183F6E810", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C870", Offset = "0x3F5B470", VA = "0x183F5C870", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F69810", Offset = "0x3F68410", VA = "0x183F69810", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F68650", Offset = "0x3F67250", VA = "0x183F68650", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F67280", Offset = "0x3F65E80", VA = "0x183F67280", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F667B0", Offset = "0x3F653B0", VA = "0x183F667B0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F64460", Offset = "0x3F63060", VA = "0x183F64460", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F70130", Offset = "0x3F6ED30", VA = "0x183F70130", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D580", Offset = "0x3F6C180", VA = "0x183F6D580", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5FE60", Offset = "0x3F5EA60", VA = "0x183F5FE60", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F5DE80", Offset = "0x3F5CA80", VA = "0x183F5DE80", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F800", Offset = "0x8B4E400", VA = "0x188B4F800", Slot = "152")]
		public void RpcAuthority(BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D2D0", Offset = "0x3F6BED0", VA = "0x183F6D2D0", Slot = "153")]
		public void RpcAuthority<T1>(BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F6CCC0", Offset = "0x3F6B8C0", VA = "0x183F6CCC0", Slot = "154")]
		public void RpcAuthority<T1, T2>(BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F6C040", Offset = "0x3F6AC40", VA = "0x183F6C040", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3F6BA70", Offset = "0x3F6A670", VA = "0x183F6BA70", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A7A0", Offset = "0x3F693A0", VA = "0x183F6A7A0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3F69FB0", Offset = "0x3F68BB0", VA = "0x183F69FB0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3F68F10", Offset = "0x3F67B10", VA = "0x183F68F10", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3F67C40", Offset = "0x3F66840", VA = "0x183F67C40", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3F65C80", Offset = "0x3F64880", VA = "0x183F65C80", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3F65040", Offset = "0x3F63C40", VA = "0x183F65040", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3F62A10", Offset = "0x3F61610", VA = "0x183F62A10", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3F61BA0", Offset = "0x3F607A0", VA = "0x183F61BA0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3F5EED0", Offset = "0x3F5DAD0", VA = "0x183F5EED0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3F5CDC0", Offset = "0x3F5B9C0", VA = "0x183F5CDC0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8B50680", Offset = "0x8B4F280", VA = "0x188B50680", Slot = "18")]
		public void RpcPlayer(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A2B0", Offset = "0x3F98EB0", VA = "0x183F9A2B0", Slot = "19")]
		public void RpcPlayer<T1>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3F9AF50", Offset = "0x3F99B50", VA = "0x183F9AF50", Slot = "20")]
		public void RpcPlayer<T1, T2>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A9D0", Offset = "0x3F995D0", VA = "0x183F9A9D0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A470", Offset = "0x3F99070", VA = "0x183F9A470", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3FAEF30", Offset = "0x3FADB30", VA = "0x183FAEF30", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3FAEB20", Offset = "0x3FAD720", VA = "0x183FAEB20", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3FAF2C0", Offset = "0x3FADEC0", VA = "0x183FAF2C0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3FAF730", Offset = "0x3FAE330", VA = "0x183FAF730", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6490", Offset = "0x3FA5090", VA = "0x183FA6490", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4C60", Offset = "0x3FA3860", VA = "0x183FA4C60", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B7A0", Offset = "0x3F9A3A0", VA = "0x183F9B7A0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3FA23E0", Offset = "0x3FA0FE0", VA = "0x183FA23E0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3FB35B0", Offset = "0x3FB21B0", VA = "0x183FB35B0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D540", Offset = "0x3F9C140", VA = "0x183F9D540", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8B503C0", Offset = "0x8B4EFC0", VA = "0x188B503C0", Slot = "176")]
		public void RpcPlayer(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A7C0", Offset = "0x3F993C0", VA = "0x183F9A7C0", Slot = "177")]
		public void RpcPlayer<T1>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B4E0", Offset = "0x3F9A0E0", VA = "0x183F9B4E0", Slot = "24")]
		public void RpcPlayer<T1, T2>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B1A0", Offset = "0x3F99DA0", VA = "0x183F9B1A0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3F9CDB0", Offset = "0x3F9B9B0", VA = "0x183F9CDB0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3FAAFA0", Offset = "0x3FA9BA0", VA = "0x183FAAFA0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA010", Offset = "0x3FA8C10", VA = "0x183FAA010", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8E60", Offset = "0x3FA7A60", VA = "0x183FA8E60", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3FA7A90", Offset = "0x3FA6690", VA = "0x183FA7A90", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6F60", Offset = "0x3FA5B60", VA = "0x183FA6F60", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5840", Offset = "0x3FA4440", VA = "0x183FA5840", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3F00", Offset = "0x3FA2B00", VA = "0x183FA3F00", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1560", Offset = "0x3FA0160", VA = "0x183FA1560", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3FA05C0", Offset = "0x3F9F1C0", VA = "0x183FA05C0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3F9E5B0", Offset = "0x3F9D1B0", VA = "0x183F9E5B0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(WJBKOLNRRJE player, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F160", Offset = "0x8B4DD60", VA = "0x188B4F160", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3F530C0", Offset = "0x3F51CC0", VA = "0x183F530C0", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3F52E70", Offset = "0x3F51A70", VA = "0x183F52E70", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3F52B50", Offset = "0x3F51750", VA = "0x183F52B50", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3F52770", Offset = "0x3F51370", VA = "0x183F52770", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3F522D0", Offset = "0x3F50ED0", VA = "0x183F522D0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3F51D70", Offset = "0x3F50970", VA = "0x183F51D70", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3F51750", Offset = "0x3F50350", VA = "0x183F51750", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3F51070", Offset = "0x3F4FC70", VA = "0x183F51070", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3F508D0", Offset = "0x3F4F4D0", VA = "0x183F508D0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3F50060", Offset = "0x3F4EC60", VA = "0x183F50060", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3F4F730", Offset = "0x3F4E330", VA = "0x183F4F730", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3F4ED40", Offset = "0x3F4D940", VA = "0x183F4ED40", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3F4E280", Offset = "0x3F4CE80", VA = "0x183F4E280", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D6F0", Offset = "0x3F4C2F0", VA = "0x183F4D6F0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F0C0", Offset = "0x8B4DCC0", VA = "0x188B4F0C0", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3F530C0", Offset = "0x3F51CC0", VA = "0x183F530C0", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3F52E70", Offset = "0x3F51A70", VA = "0x183F52E70", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3F52B50", Offset = "0x3F51750", VA = "0x183F52B50", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3F52770", Offset = "0x3F51370", VA = "0x183F52770", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3F522D0", Offset = "0x3F50ED0", VA = "0x183F522D0", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3F51D70", Offset = "0x3F50970", VA = "0x183F51D70", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3F51750", Offset = "0x3F50350", VA = "0x183F51750", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3F51070", Offset = "0x3F4FC70", VA = "0x183F51070", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3F508D0", Offset = "0x3F4F4D0", VA = "0x183F508D0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3F50060", Offset = "0x3F4EC60", VA = "0x183F50060", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3F4F730", Offset = "0x3F4E330", VA = "0x183F4F730", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3F4ED40", Offset = "0x3F4D940", VA = "0x183F4ED40", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3F4E280", Offset = "0x3F4CE80", VA = "0x183F4E280", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D6F0", Offset = "0x3F4C2F0", VA = "0x183F4D6F0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FFE0", Offset = "0x8B4EBE0", VA = "0x188B4FFE0", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D8B0", Offset = "0x3F8C4B0", VA = "0x183F8D8B0", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D660", Offset = "0x3F8C260", VA = "0x183F8D660", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D350", Offset = "0x3F8BF50", VA = "0x183F8D350", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CF70", Offset = "0x3F8BB70", VA = "0x183F8CF70", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CAD0", Offset = "0x3F8B6D0", VA = "0x183F8CAD0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C570", Offset = "0x3F8B170", VA = "0x183F8C570", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BF50", Offset = "0x3F8AB50", VA = "0x183F8BF50", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B870", Offset = "0x3F8A470", VA = "0x183F8B870", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B0D0", Offset = "0x3F89CD0", VA = "0x183F8B0D0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3F99A40", Offset = "0x3F98640", VA = "0x183F99A40", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3F99110", Offset = "0x3F97D10", VA = "0x183F99110", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3F98720", Offset = "0x3F97320", VA = "0x183F98720", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3F97C60", Offset = "0x3F96860", VA = "0x183F97C60", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3F970D0", Offset = "0x3F95CD0", VA = "0x183F970D0", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8B50080", Offset = "0x8B4EC80", VA = "0x188B50080", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D8B0", Offset = "0x3F8C4B0", VA = "0x183F8D8B0", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D660", Offset = "0x3F8C260", VA = "0x183F8D660", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D350", Offset = "0x3F8BF50", VA = "0x183F8D350", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CF70", Offset = "0x3F8BB70", VA = "0x183F8CF70", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CAD0", Offset = "0x3F8B6D0", VA = "0x183F8CAD0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C570", Offset = "0x3F8B170", VA = "0x183F8C570", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BF50", Offset = "0x3F8AB50", VA = "0x183F8BF50", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B870", Offset = "0x3F8A470", VA = "0x183F8B870", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B0D0", Offset = "0x3F89CD0", VA = "0x183F8B0D0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3F99A40", Offset = "0x3F98640", VA = "0x183F99A40", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3F99110", Offset = "0x3F97D10", VA = "0x183F99110", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3F98720", Offset = "0x3F97320", VA = "0x183F98720", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3F97C60", Offset = "0x3F96860", VA = "0x183F97C60", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3F970D0", Offset = "0x3F95CD0", VA = "0x183F970D0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, BZXSVEIIUWD.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D6F0", Offset = "0x8B4C2F0", VA = "0x188B4D6F0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D900", Offset = "0x8B4C500", VA = "0x188B4D900", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x23DC930", Offset = "0x23DB530", VA = "0x1823DC930")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class DMDNUYMOIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8B358A0", Offset = "0x8B344A0", VA = "0x188B358A0")]
		private static bool GHRYHDJNPMV(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3A8A0B0", Offset = "0x3A88CB0", VA = "0x183A8A0B0")]
		[CanBeNull]
		public static a UQKXKPLQCQV<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public WJBKOLNRRJE[] JHJKPDJNOWM;

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8B35510", Offset = "0x8B34110", VA = "0x188B35510")]
			internal int KHMPOSIQDBS(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8B35590", Offset = "0x8B34190", VA = "0x188B35590")]
			internal void KHRWLZCNMNB(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static WJBKOLNRRJE[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		internal int EVGWPBKEAQF;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8B51CA0", Offset = "0x8B508A0", VA = "0x188B51CA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8B52310", Offset = "0x8B50F10", VA = "0x188B52310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8B526B0", Offset = "0x8B512B0", VA = "0x188B526B0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8B52730", Offset = "0x8B51330", VA = "0x188B52730")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8B53110", Offset = "0x8B51D10", VA = "0x188B53110")]
		private void TMSESOYOSFF(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8B521A0", Offset = "0x8B50DA0", VA = "0x188B521A0")]
		private void NCHSCDAFGML(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8B53280", Offset = "0x8B51E80", VA = "0x188B53280")]
		private void TQMSDAMJXHT(WJBKOLNRRJE a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8B51B50", Offset = "0x8B50750", VA = "0x188B51B50")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8B527E0", Offset = "0x8B513E0", VA = "0x188B527E0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8B520B0", Offset = "0x8B50CB0", VA = "0x188B520B0")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xB25540", Offset = "0xB24140", VA = "0x180B25540")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class HQCFXEWMEVP
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8B3D440", Offset = "0x8B3C040", VA = "0x188B3D440")]
		public static int FHMRYNRLKOX(this WJBKOLNRRJE a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8B3D6D0", Offset = "0x8B3C2D0", VA = "0x188B3D6D0")]
		public static void RJUIYTSIRBR(this WJBKOLNRRJE a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8B3D1F0", Offset = "0x8B3BDF0", VA = "0x188B3D1F0")]
		internal static string BZXSNPWBHTC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8B3D5D0", Offset = "0x8B3C1D0", VA = "0x188B3D5D0")]
		internal static string HVNIJIUUGSL(this WJBKOLNRRJE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class MGMCHEJMVMJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public delegate void RoomPropertyUpdateCallback(Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public delegate void PlayerPropertyUpdateCallback(WJBKOLNRRJE player, Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback TPIXATEJICR
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x8B49960", Offset = "0x8B48560", VA = "0x188B49960")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8B497E0", Offset = "0x8B483E0", VA = "0x188B497E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event RoomPropertyUpdateCallback YBGYJYRDIMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8B49AE0", Offset = "0x8B486E0", VA = "0x188B49AE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8B49BA0", Offset = "0x8B487A0", VA = "0x188B49BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback CYUVZBQXWXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x8B49660", Offset = "0x8B48260", VA = "0x188B49660")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x8B498A0", Offset = "0x8B484A0", VA = "0x188B498A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public static event PlayerPropertyUpdateCallback YRPIOVLMLKC
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x8B49A20", Offset = "0x8B48620", VA = "0x188B49A20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x8B49720", Offset = "0x8B48320", VA = "0x188B49720")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal static class NENKJSMVPOS
	{
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static int MRUBCBIYADS;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static int CHXYPSMHRMK;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static int HIODJBVLWGK;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B49FD0", Offset = "0x8B48BD0", VA = "0x188B49FD0")]
		public static void LUZUGOIKVSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B49EF0", Offset = "0x8B48AF0", VA = "0x188B49EF0")]
		public static void BXAWMSQFRQV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B49C60", Offset = "0x8B48860", VA = "0x188B49C60")]
		public static int BWVPAXJQIAG(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[RegisterService(typeof(GJHRPGDSXFI), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class GJHRPGDSXFI : MVDRLHIYJLM, MOWQOGDYZLC, BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly Hashtable NHLRMNPHZQL;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly Hashtable NEZARYOQHRJ;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly Hashtable SNVZOGVVOPB;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static readonly PZIMWREHPGJ CSCWFFUSQYZ;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static readonly PZIMWREHPGJ OLEGCIZWFZG;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly PZIMWREHPGJ EZLAYBZQVQY;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly PZIMWREHPGJ ZTDIYLDQDNL;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly PZIMWREHPGJ YMZKWYSGNVG;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static int CKJWEJMBZFL;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B910", Offset = "0x8B3A510", VA = "0x188B3B910", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C890", Offset = "0x8B3B490", VA = "0x188B3C890", Slot = "19")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B3BE40", Offset = "0x8B3AA40", VA = "0x188B3BE40", Slot = "4")]
		public bool NZVLFSLGWOR(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B3AB80", Offset = "0x8B39780", VA = "0x188B3AB80", Slot = "5")]
		public int BHYBDKDYAXP(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B3AF30", Offset = "0x8B39B30", VA = "0x188B3AF30", Slot = "6")]
		public bool DVWPYWVHAOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B3BAC0", Offset = "0x8B3A6C0", VA = "0x188B3BAC0", Slot = "7")]
		public bool KMSRIFHIDDT(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B3AFC0", Offset = "0x8B39BC0", VA = "0x188B3AFC0", Slot = "8")]
		public void ENZIUHTOGEM(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C670", Offset = "0x8B3B270", VA = "0x188B3C670", Slot = "9")]
		public bool QFVTMVDGFTW(RQAGMLJLYPY a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B300", Offset = "0x8B39F00", VA = "0x188B3B300", Slot = "10")]
		public bool HCESFMFXBVP(RQAGMLJLYPY a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B3BC50", Offset = "0x8B3A850", VA = "0x188B3BC50", Slot = "11")]
		public bool KOWVSMHUDDU(RQAGMLJLYPY a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B730", Offset = "0x8B3A330", VA = "0x188B3B730", Slot = "12")]
		public void IQEMYVIRWVQ(RQAGMLJLYPY a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B5D0", Offset = "0x8B3A1D0", VA = "0x188B3B5D0", Slot = "13")]
		public void IBRCLJEICCJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B9B0", Offset = "0x8B3A5B0", VA = "0x188B3B9B0", Slot = "14")]
		public void JNVNSSREISJ(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C7E0", Offset = "0x8B3B3E0", VA = "0x188B3C7E0", Slot = "15")]
		public void RIYYRYRGGGH(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B3BD70", Offset = "0x8B3A970", VA = "0x188B3BD70", Slot = "16")]
		public void MWJFYLOMYDE(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B1A0", Offset = "0x8B39DA0", VA = "0x188B3B1A0", Slot = "17")]
		public void FEWOUSDIYCM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B3CA20", Offset = "0x8B3B620", VA = "0x188B3CA20")]
		private static void VRSDPADBURP(InstantiateParameters a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B3BF80", Offset = "0x8B3AB80", VA = "0x188B3BF80")]
		private static bool QFVTMVDGFTW(Hashtable a, WJBKOLNRRJE b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C930", Offset = "0x8B3B530", VA = "0x188B3C930")]
		private static bool UGBEOCOWDLV(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B3CE40", Offset = "0x8B3BA40", VA = "0x188B3CE40")]
		private static int WHHDINOVEJJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public GJHRPGDSXFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RegisterService(typeof(RSYQASUQRUY), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class RSYQASUQRUY : CWPLPQTZFQQ, MOWQOGDYZLC, BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static Hashtable JVFUJTTMPRW;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static Hashtable RJAHKMQEKZF;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static PZIMWREHPGJ IWDRYNJQOVA;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly PZIMWREHPGJ NEESOIXGQTZ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A1E0", Offset = "0x8B58DE0", VA = "0x188B5A1E0", Slot = "8")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A140", Offset = "0x8B58D40", VA = "0x188B5A140", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B59A20", Offset = "0x8B58620", VA = "0x188B59A20", Slot = "4")]
		public void HTIMSIDCFII(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B59680", Offset = "0x8B58280", VA = "0x188B59680", Slot = "5")]
		public bool FWEXUOJJKFO(RQAGMLJLYPY a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B59B00", Offset = "0x8B58700", VA = "0x188B59B00", Slot = "6")]
		public void IHLBPHSNYDY(ViewId a, string b, RpcTarget c, WJBKOLNRRJE d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RSYQASUQRUY()
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
