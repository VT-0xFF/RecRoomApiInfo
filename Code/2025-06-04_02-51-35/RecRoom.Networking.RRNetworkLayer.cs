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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.ObjectModel;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80DAEA0", Offset = "0x80D96A0", VA = "0x1880DAEA0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21579F0", Offset = "0x21561F0", VA = "0x1821579F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80E48E0", Offset = "0x80E30E0", VA = "0x1880E48E0")]
		private void MBKOFANELHN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80E4670", Offset = "0x80E2E70", VA = "0x1880E4670")]
		private void EDNGKHAEMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80E4F30", Offset = "0x80E3730", VA = "0x1880E4F30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80E4FE0", Offset = "0x80E37E0", VA = "0x1880E4FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BOEFJGOGPHI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly BMELPJIFPCL LCPLPGNINPG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BMELPJIFPCL MKJHBCGGBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80C4860", Offset = "0x80C3060", VA = "0x1880C4860")]
		get
		{
			return default(BMELPJIFPCL);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DAJDOJMCKOF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView BFEMADNEOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KLDCCILAIGB OBENCKGJPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool Serialize(LDBOJJADKGC JGGLCDNKBNB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Deserialize(KMHOFPFBDDH NGABBABGLLA, LDBOJJADKGC JGGLCDNKBNB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface DEJJPHLPEOE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NMEGIIHCGME
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JMLFECFJFJF(KMHOFPFBDDH NGABBABGLLA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLFGCACBCKJ(KMHOFPFBDDH NGABBABGLLA, LDBOJJADKGC JGGLCDNKBNB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface LGKGGAMOFGI : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KELFLPPCOLM(DAJDOJMCKOF MAFBCPJDAFO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIDPNIODDKH(DAJDOJMCKOF MAFBCPJDAFO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOLNOEONKMG(KNHNDCMLNDE.CDJFNPIKIGM IIGFLJINNHA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDPPGOPOLJD();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAIDEKPPLKJ(object NPLHFNMEMBD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KLDCCILAIGB : byte
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
	Invalid
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KMHOFPFBDDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public int EIKFCLBNLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public uint OHIHICIBMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public double OEJBLABCNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int ABFMDBMMOPK;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BCPHBFAJGHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<(ViewId, KLDCCILAIGB), DEJJPHLPEOE> FEPDMLNILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<DAJDOJMCKOF> LEHDHGLLDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HashSet<(ViewId, KLDCCILAIGB)> ALMMGPDHDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int LIJCECJEMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public bool FNEFOMNCPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KNHNDCMLNDE.CDJFNPIKIGM IIGFLJINNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly MemoryStream BHJNHAMMGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly LDBOJJADKGC EPHFDCPEPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly LDBOJJADKGC MLOLDPNLMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private byte[] BFFOFBFJHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float MDENPOGDHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int HNEHPBIBEOE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80C4640", Offset = "0x80C2E40", VA = "0x1880C4640")]
	public BCPHBFAJGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80C3E20", Offset = "0x80C2620", VA = "0x1880C3E20")]
	public void IOLNOEONKMG(KNHNDCMLNDE.CDJFNPIKIGM IIGFLJINNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80C31A0", Offset = "0x80C19A0", VA = "0x1880C31A0")]
	public void BDPPGOPOLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80C3EA0", Offset = "0x80C26A0", VA = "0x1880C3EA0")]
	public void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80C37D0", Offset = "0x80C1FD0", VA = "0x1880C37D0")]
	public bool GGGBGBDKNKJ(DAJDOJMCKOF MAFBCPJDAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80C3CF0", Offset = "0x80C24F0", VA = "0x1880C3CF0")]
	public bool HKOLMKDGPPH(DAJDOJMCKOF MAFBCPJDAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80C3590", Offset = "0x80C1D90", VA = "0x1880C3590")]
	private DEJJPHLPEOE DFMHIJBFNMD(ViewId HEFGNKGLBJE, KLDCCILAIGB DMLMDCJJCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80C4630", Offset = "0x80C2E30", VA = "0x1880C4630")]
	public void PJPPOMHBGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80C3E40", Offset = "0x80C2640", VA = "0x1880C3E40")]
	private void JEELFKLLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80C37B0", Offset = "0x80C1FB0", VA = "0x1880C37B0")]
	private void EMKADPPEFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80C31F0", Offset = "0x80C19F0", VA = "0x1880C31F0")]
	public bool BLPBDGPLOHJ(FastBufferWriter LFDMHEHCHCC, int ANGIKFHABNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80C4280", Offset = "0x80C2A80", VA = "0x1880C4280")]
	public void OLFGCACBCKJ(KMHOFPFBDDH NGABBABGLLA, FastBufferReader JEPFPDOKDAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class EHMNFBIGHNM : DEJJPHLPEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private DAJDOJMCKOF HMBNBFBNLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private uint GAMGNGLGOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int CNBFPHJNJJB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NMEGIIHCGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public EHMNFBIGHNM(DAJDOJMCKOF HMBNBFBNLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80C5D60", Offset = "0x80C4560", VA = "0x1880C5D60", Slot = "5")]
	public bool JMLFECFJFJF(KMHOFPFBDDH NGABBABGLLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80C5E50", Offset = "0x80C4650", VA = "0x1880C5E50", Slot = "6")]
	public void OLFGCACBCKJ(KMHOFPFBDDH NGABBABGLLA, LDBOJJADKGC JGGLCDNKBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NLAHEDPBOMA : DEJJPHLPEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KNHNDCMLNDE.CDJFNPIKIGM IIGFLJINNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ViewId HEFGNKGLBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int CNBFPHJNJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private uint GAMGNGLGOFO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NMEGIIHCGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0C30", Offset = "0x1A9F430", VA = "0x181AA0C30")]
	public NLAHEDPBOMA(ViewId HEFGNKGLBJE, KNHNDCMLNDE.CDJFNPIKIGM IIGFLJINNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80DB1C0", Offset = "0x80D99C0", VA = "0x1880DB1C0", Slot = "5")]
	public bool JMLFECFJFJF(KMHOFPFBDDH NGABBABGLLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80DB200", Offset = "0x80D9A00", VA = "0x1880DB200", Slot = "6")]
	public void OLFGCACBCKJ(KMHOFPFBDDH NGABBABGLLA, LDBOJJADKGC JGGLCDNKBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OHDIPIKELJN
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80DB8E0", Offset = "0x80DA0E0", VA = "0x1880DB8E0")]
	public static void GJCNJFECIPF(this DILHAMBPDCK CHEPDNGDHLG, LDBOJJADKGC HOPLLEFFBIG, ViewId MJAGIMDGJBK, bool LIGFADKCJAA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80DB3E0", Offset = "0x80D9BE0", VA = "0x1880DB3E0")]
	public static void ELHJCJIOCHB(this DILHAMBPDCK CHEPDNGDHLG, LDBOJJADKGC HOPLLEFFBIG, bool LIGFADKCJAA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80DBE50", Offset = "0x80DA650", VA = "0x1880DBE50")]
	public static DILHAMBPDCK OLFGCACBCKJ(LDBOJJADKGC HOPLLEFFBIG, ViewId MJAGIMDGJBK, bool LIGFADKCJAA = true)
	{
		return default(DILHAMBPDCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80DBAA0", Offset = "0x80DA2A0", VA = "0x1880DBAA0")]
	public static void IEDCDAEFFMN(this DILHAMBPDCK CHEPDNGDHLG, LDBOJJADKGC HOPLLEFFBIG, bool LIGFADKCJAA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(LGKGGAMOFGI), new string[] { })]
public class DCMJHLPKMGM : LGKGGAMOFGI, INetworkUpdateSystem, EGBPELOCMDI, DEPOIAMCLIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BMELPJIFPCL GPGKLAGNKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private BCPHBFAJGHE NNEBHIGOOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private uint ECODCLEOIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float CJLMIAOGJDP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80C5660", Offset = "0x80C3E60", VA = "0x1880C5660", Slot = "4")]
	public void KELFLPPCOLM(DAJDOJMCKOF MAFBCPJDAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80C5430", Offset = "0x80C3C30", VA = "0x1880C5430", Slot = "5")]
	public void HIDPNIODDKH(DAJDOJMCKOF MAFBCPJDAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80C52D0", Offset = "0x80C3AD0", VA = "0x1880C52D0", Slot = "10")]
	public void HAMEHJBFDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80C5780", Offset = "0x80C3F80", VA = "0x1880C5780", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage HFGLNAGBPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80C4CA0", Offset = "0x80C34A0", VA = "0x1880C4CA0")]
	private void BOIIHOABJLM(uint ELEDGMNAJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80C5630", Offset = "0x80C3E30", VA = "0x1880C5630", Slot = "6")]
	public void IOLNOEONKMG(KNHNDCMLNDE.CDJFNPIKIGM IIGFLJINNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80C4C40", Offset = "0x80C3440", VA = "0x1880C4C40", Slot = "7")]
	public void BDPPGOPOLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80C5270", Offset = "0x80C3A70", VA = "0x1880C5270", Slot = "8")]
	public void FAIDEKPPLKJ(object CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80C5800", Offset = "0x80C4000", VA = "0x1880C5800")]
	private void PEJPCFBEJFL(IIBEMPIBOEO CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80C4B20", Offset = "0x80C3320", VA = "0x1880C4B20", Slot = "11")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80C5B80", Offset = "0x80C4380", VA = "0x1880C5B80")]
	public DCMJHLPKMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HFFDALBBLFP : DEJJPHLPEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float ALLKDPAHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int CNBFPHJNJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private uint GAMGNGLGOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly KLDCCILAIGB NPNKGPMEGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public KMHOFPFBDDH IABNAOFFIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int PKMHEOOEMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public byte[] EMDBDPCCHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private KMHOFPFBDDH MDIIGFPBEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int IHMNNEACECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private byte[] ABNKEAIDPNH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NMEGIIHCGME
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80C97D0", Offset = "0x80C7FD0", VA = "0x1880C97D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80C9AC0", Offset = "0x80C82C0", VA = "0x1880C9AC0")]
	public HFFDALBBLFP(KLDCCILAIGB NPNKGPMEGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80C9790", Offset = "0x80C7F90", VA = "0x1880C9790", Slot = "5")]
	public bool JMLFECFJFJF(KMHOFPFBDDH NGABBABGLLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80C9910", Offset = "0x80C8110", VA = "0x1880C9910", Slot = "6")]
	public void OLFGCACBCKJ(KMHOFPFBDDH NGABBABGLLA, LDBOJJADKGC JGGLCDNKBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80C9800", Offset = "0x80C8000", VA = "0x1880C9800")]
	internal EHMNFBIGHNM MBNFFDMEJKG(DAJDOJMCKOF MAFBCPJDAFO, LDBOJJADKGC HOPLLEFFBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80C95D0", Offset = "0x80C7DD0", VA = "0x1880C95D0")]
	private static void GDAKEJAAOOD(EHMNFBIGHNM BDOKJFILGDA, LDBOJJADKGC HOPLLEFFBIG, KMHOFPFBDDH ABGAFLLNFKE, byte[] FLHFCEEIHBP, int KMDOFHCNPBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(FJDJAAABGJI), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class FJDJAAABGJI : AHOMPNPPOHL, EGBPELOCMDI, DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly Hashtable FDPJNICBIGF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable CKCBONIPBFO;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable PPPNACMBPMG;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly IKNIODLHFBI JIPHKHBJEHL;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly IKNIODLHFBI DOKNDCLLFAL;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly IKNIODLHFBI NBPLCAAJAMM;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly IKNIODLHFBI HACJJLAPKNE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly IKNIODLHFBI NKGCLIECEDA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int HFKJIKHGKJP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80C64F0", Offset = "0x80C4CF0", VA = "0x1880C64F0", Slot = "4")]
	public bool EMLGNAJAMHK(DKBEJJEFNCK JCPNJLMMOLN, bool HCBBMPKKMCB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80C7610", Offset = "0x80C5E10", VA = "0x1880C7610", Slot = "5")]
	public int MFNAGHHIAKL(DKBEJJEFNCK[] IABGAPCJMBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80C6460", Offset = "0x80C4C60", VA = "0x1880C6460", Slot = "6")]
	public bool ELKJBKDGNIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80C7480", Offset = "0x80C5C80", VA = "0x1880C7480", Slot = "7")]
	public bool KHBDDAEEOKB(int HEFGNKGLBJE, int FDPIKKAKNIC, bool DNGNBAJCLMC, GameObject EMOLHEPHCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80C7F60", Offset = "0x80C6760", VA = "0x1880C7F60", Slot = "8")]
	public void PJMFPMHDMDB(int FDPIKKAKNIC, [Optional] int? AJOOBFJKIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80C68B0", Offset = "0x80C50B0", VA = "0x1880C68B0", Slot = "9")]
	public bool IIDPKHBKAPN(IIBEMPIBOEO NPLHFNMEMBD, [Out] DKBEJJEFNCK ILMCHJANNEM, bool PPGKJMKGMBE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80C70F0", Offset = "0x80C58F0", VA = "0x1880C70F0", Slot = "10")]
	public bool JPMCJMDDONA(IIBEMPIBOEO NPLHFNMEMBD, [Out] int BGBAHFKHLPL, [Out] DKBEJJEFNCK[] IABGAPCJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80C6FD0", Offset = "0x80C57D0", VA = "0x1880C6FD0", Slot = "11")]
	public bool JJGADCMAOOP(IIBEMPIBOEO NPLHFNMEMBD, [Out] int FDPIKKAKNIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80C6110", Offset = "0x80C4910", VA = "0x1880C6110", Slot = "12")]
	public void COKICBACPIA(IIBEMPIBOEO NPLHFNMEMBD, [Out] int OOPDCJLDMBJ, [Out] int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80C79D0", Offset = "0x80C61D0", VA = "0x1880C79D0", Slot = "13")]
	public void OFMBLNIILHP(int BGBAHFKHLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80C6790", Offset = "0x80C4F90", VA = "0x1880C6790", Slot = "14")]
	public void HHMGNEJPEMO(int BGBAHFKHLPL, int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80C73D0", Offset = "0x80C5BD0", VA = "0x1880C73D0", Slot = "15")]
	public void KBAANJJMLHN(int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80C6620", Offset = "0x80C4E20", VA = "0x1880C6620", Slot = "16")]
	public void GLIIKPFFCLB(int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80C62F0", Offset = "0x80C4AF0", VA = "0x1880C62F0", Slot = "17")]
	public void DOPIHBFOECJ(int BGBAHFKHLPL, int FDPIKKAKNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80C7B30", Offset = "0x80C6330", VA = "0x1880C7B30")]
	private static void PFNOONKJIPE(DKBEJJEFNCK JCPNJLMMOLN, Hashtable LMOGGHBNICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80C6A20", Offset = "0x80C5220", VA = "0x1880C6A20")]
	private static bool IIDPKHBKAPN(Hashtable LMOGGHBNICE, EIGONBNGIIK GIJBBJGBHCJ, [Out] DKBEJJEFNCK ILMCHJANNEM, bool PPGKJMKGMBE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80C6030", Offset = "0x80C4830", VA = "0x1880C6030")]
	private static int BODALHEBAOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80C66F0", Offset = "0x80C4EF0", VA = "0x1880C66F0", Slot = "18")]
	public void HAMEHJBFDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80C5F90", Offset = "0x80C4790", VA = "0x1880C5F90", Slot = "19")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FJDJAAABGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(JHDECKODMKM), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class JHDECKODMKM : FKHMCKMLEDD, EGBPELOCMDI, DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static Hashtable IIPEKCKDJAB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable KMGMABNNPDC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static IKNIODLHFBI CDBKOINFDOJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly IKNIODLHFBI NAOHFLKALHF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80D9BD0", Offset = "0x80D83D0", VA = "0x1880D9BD0", Slot = "4")]
	public void AHPLKOAGDDK(ViewId HEFGNKGLBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80DA310", Offset = "0x80D8B10", VA = "0x1880DA310", Slot = "5")]
	public bool EBCLBEJGFCA(IIBEMPIBOEO NPLHFNMEMBD, [Out] ViewId HEFGNKGLBJE, [Out] string PICMFECJKDH, [Out] int DGFKOBCJLIP, [Out] object[] FKIDLMLIFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80D9D60", Offset = "0x80D8560", VA = "0x1880D9D60", Slot = "6")]
	public void CKJKJOGJPKD(ViewId KBMPEIPJGHK, string PICMFECJKDH, MLCIMENIGOO ONBJOFHAOIN, EIGONBNGIIK OINLJEGCCDI, GMHJIAHJCPH FOIOOGEDCJG, object[] JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80D9CC0", Offset = "0x80D84C0", VA = "0x1880D9CC0", Slot = "8")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80DA650", Offset = "0x80D8E50", VA = "0x1880DA650", Slot = "7")]
	public void HAMEHJBFDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JHDECKODMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AEKPCJPKJLK
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80C30C0", Offset = "0x80C18C0", VA = "0x1880C30C0")]
	public static EIGONBNGIIK LBFFHGFOGPA(this GBNNBLFIGLH FIOLDALLLFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80C3150", Offset = "0x80C1950", VA = "0x1880C3150")]
	public static GBNNBLFIGLH NCGNGLGACCA(this EIGONBNGIIK OINLJEGCCDI)
	{
		return default(GBNNBLFIGLH);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, LCJPPOOGNFI, MBOKBFNEDFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<MJBIGNKEAKN> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ViewId CCNPHGHHLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x80DCF20", Offset = "0x80DB720", VA = "0x1880DCF20")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId CHOJBAGLNJM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80DCF20", Offset = "0x80DB720", VA = "0x1880DCF20", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView AMHLEGGNPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x80DCFA0", Offset = "0x80DB7A0", VA = "0x1880DCFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RRNetworkView BFEMADNEOFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x80DCFA0", Offset = "0x80DB7A0", VA = "0x1880DCFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EIGONBNGIIK OGMCJCKBFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x80DD0A0", Offset = "0x80DB8A0", VA = "0x1880DD0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EIGONBNGIIK PKBMMFHCONE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x80DD400", Offset = "0x80DBC00", VA = "0x1880DD400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DBOEKIJEKEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x80DD200", Offset = "0x80DBA00", VA = "0x1880DD200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NGNNOAPECAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x80DD370", Offset = "0x80DBB70", VA = "0x1880DD370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NGFEPCGDJAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x80DCE50", Offset = "0x80DB650", VA = "0x1880DCE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LBFMGEFDAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x80DD130", Offset = "0x80DB930", VA = "0x1880DD130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool FDGJDDEPNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x80DCE50", Offset = "0x80DB650", VA = "0x1880DCE50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HCCNGCNINIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x80DCED0", Offset = "0x80DB6D0", VA = "0x1880DCED0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string NPFFLFPBIIK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x80DD010", Offset = "0x80DB810", VA = "0x1880DD010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BCHJGCBONCG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x80DCDD0", Offset = "0x80DB5D0", VA = "0x1880DCDD0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<EIGONBNGIIK> DBLOMLJPNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x80DCCA0", Offset = "0x80DB4A0", VA = "0x1880DCCA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x80DD490", Offset = "0x80DBC90", VA = "0x1880DD490")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x80DCC00", Offset = "0x80DB400", VA = "0x1880DCC00")]
		public bool WasSpawnedForPlayer(int NEMLJNNBOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x745EB80", Offset = "0x745D380", VA = "0x18745EB80")]
		private void IHKCJFFCLPD(RRNetworkView FOIMOKIBLGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x80DC830", Offset = "0x80DB030", VA = "0x1880DC830", Slot = "9")]
		public void RegisterDestroyHandler(MJBIGNKEAKN HHPGBAHCBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80DCA30", Offset = "0x80DB230", VA = "0x1880DCA30", Slot = "10")]
		public void UnregisterDestroyHandler(MJBIGNKEAKN HHPGBAHCBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80DC810", Offset = "0x80DB010", VA = "0x1880DC810", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IFGHKGEAHEG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void FLFBDACCOOI([In] DKBEJJEFNCK JCPNJLMMOLN, bool KNJPLBIFPNL, bool LMOGGHBNICE, bool MBAMEPAOIHD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void HPBNFNJLAIC(GameObject LEHCGNOJDEA);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void LJMHPFNGOIG(GameObject LEHCGNOJDEA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void LNCKFEIIHOB(RRNetworkView KBMPEIPJGHK, string PICMFECJKDH, EIGONBNGIIK CBCINDIMJOG, MLCIMENIGOO? OLBBKGLINIK, bool MABFGPKAKCN, GMHJIAHJCPH PFDDBFBACEP, object[] JCPNJLMMOLN, string KPDOEBDNFCB);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void CJMDJBBPKNK(RRNetworkView KBMPEIPJGHK, string PICMFECJKDH, EIGONBNGIIK CBCINDIMJOG, MLCIMENIGOO? OLBBKGLINIK, bool MABFGPKAKCN, GMHJIAHJCPH PFDDBFBACEP, object[] JCPNJLMMOLN, string KPDOEBDNFCB);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void JOPJAFEALIA(RRNetworkView KBMPEIPJGHK, string PICMFECJKDH, object[] FKIDLMLIFPK, string JHMONIBONJP);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void EBIIOHOCHJI(RRNetworkView KBMPEIPJGHK, EIGONBNGIIK KJEADPKKIEA);

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[CompilerGenerated]
	private static HPBNFNJLAIC GGJGGIIAEMP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event FLFBDACCOOI ECALHFFKHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80CAE80", Offset = "0x80C9680", VA = "0x1880CAE80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x80CA170", Offset = "0x80C8970", VA = "0x1880CA170")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event HPBNFNJLAIC ILNFGGKOMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x80C9FF0", Offset = "0x80C87F0", VA = "0x1880C9FF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x80CA0B0", Offset = "0x80C88B0", VA = "0x1880CA0B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event LJMHPFNGOIG KGLHFFDAGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x80C9E70", Offset = "0x80C8670", VA = "0x1880C9E70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80CAAF0", Offset = "0x80C92F0", VA = "0x1880CAAF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event LJMHPFNGOIG JBPJFBDECNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x80C9BF0", Offset = "0x80C83F0", VA = "0x1880C9BF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x80CAC70", Offset = "0x80C9470", VA = "0x1880CAC70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event LNCKFEIIHOB CCKFPBHEPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x80C9F30", Offset = "0x80C8730", VA = "0x1880C9F30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x80C9CB0", Offset = "0x80C84B0", VA = "0x1880C9CB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event CJMDJBBPKNK HHMNMIPKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x80CADC0", Offset = "0x80C95C0", VA = "0x1880CADC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x80CA710", Offset = "0x80C8F10", VA = "0x1880CA710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event JOPJAFEALIA BMCAGMKOMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x80CA230", Offset = "0x80C8A30", VA = "0x1880CA230")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x80CA650", Offset = "0x80C8E50", VA = "0x1880CA650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event EBIIOHOCHJI ENDPMMHCGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80CA590", Offset = "0x80C8D90", VA = "0x1880CA590")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80C9B30", Offset = "0x80C8330", VA = "0x1880C9B30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event EBIIOHOCHJI FECJCCDFCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x80CABB0", Offset = "0x80C93B0", VA = "0x1880CABB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80CA4D0", Offset = "0x80C8CD0", VA = "0x1880CA4D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x80CA8F0", Offset = "0x80C90F0", VA = "0x1880CA8F0")]
	public static void MICMJOOFJJA([In] DKBEJJEFNCK JCPNJLMMOLN, bool KNJPLBIFPNL, bool LMOGGHBNICE, bool MBAMEPAOIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80CA440", Offset = "0x80C8C40", VA = "0x1880CA440")]
	public static void KDBGBDEEKON(GameObject LEHCGNOJDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80CA860", Offset = "0x80C9060", VA = "0x1880CA860")]
	public static void MHLEAKAPEKJ(GameObject LEHCGNOJDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x80CAD30", Offset = "0x80C9530", VA = "0x1880CAD30")]
	public static void PLDFIBLNEKF(GameObject LEHCGNOJDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x80CA7D0", Offset = "0x80C8FD0", VA = "0x1880CA7D0")]
	public static void MGAPKMKNBJI(GameObject LEHCGNOJDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80CA2F0", Offset = "0x80C8AF0", VA = "0x1880CA2F0")]
	public static void JGKLDBLAPFC(RRNetworkView KBMPEIPJGHK, string PICMFECJKDH, EIGONBNGIIK CBCINDIMJOG, MLCIMENIGOO? OLBBKGLINIK, bool MABFGPKAKCN, GMHJIAHJCPH PFDDBFBACEP, object[] JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x80CA9B0", Offset = "0x80C91B0", VA = "0x1880CA9B0")]
	public static void MJMDJDLACLM(RRNetworkView KBMPEIPJGHK, string PICMFECJKDH, int FOHLLOCIBJO, object[] FKIDLMLIFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x80C9D70", Offset = "0x80C8570", VA = "0x1880C9D70")]
	public static void DNMOBJCEHFD(int HEFGNKGLBJE, int FIOLDALLLFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PMGLONNFDPG
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x80DC5B0", Offset = "0x80DADB0", VA = "0x1880DC5B0")]
	[CanBeNull]
	private static bool AEMIJFHGDLF(ViewId EBHOIBHGECB, [Out] RRNetworkView KBMPEIPJGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x80DC660", Offset = "0x80DAE60", VA = "0x1880DC660")]
	[CanBeNull]
	public static Component CHAKOKEJPLD(this ViewId KBMPEIPJGHK, Type BGBIGBOOJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6F00", Offset = "0x3BA5700", VA = "0x183BA6F00")]
	[CanBeNull]
	public static T CHAKOKEJPLD<T>(this ViewId KBMPEIPJGHK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6F00", Offset = "0x3BA5700", VA = "0x183BA6F00")]
	[CanBeNull]
	public static T BOGGGPGNKAA<T>(this ViewId KBMPEIPJGHK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6F70", Offset = "0x3BA5770", VA = "0x183BA6F70")]
	public static bool GFBIBIAIDMP<T>(this ViewId KBMPEIPJGHK, [Out] T KJCFPPKBAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x80DC740", Offset = "0x80DAF40", VA = "0x1880DC740")]
	[CanBeNull]
	public static RRNetworkView NBDPAPJHGOH(this ViewId KBMPEIPJGHK)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static RRNetworkHandler CMJLAOBGHAL;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		internal static RRNetworkHandler HPECEAELCLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x80DD5C0", Offset = "0x80DBDC0", VA = "0x1880DD5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x80DD770", Offset = "0x80DBF70", VA = "0x1880DD770")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x80DD730", Offset = "0x80DBF30", VA = "0x1880DD730")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(IKNOHMJPHFN), new string[] { "Photon" })]
public sealed class IKNOHMJPHFN : DPKIIGLOEPO, EGBPELOCMDI, DEPOIAMCLIH, NLLGALIJPAA, CEMPNLCLMHD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MODBAMILBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MODBAMILBML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x80DB100", Offset = "0x80D9900", VA = "0x1880DB100")]
		internal object MPMJHNMOEBD((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static BMELPJIFPCL CDHCJFHMDKF;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static BMELPJIFPCL HCOJFICFNMF;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, HashSet<int>> DFNIHCCCJCO;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, int> HLLIDLABADA;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly List<(GameObject GameObject, int ParentCount)> LNDILLLHDJH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<GameObject> GDIJMEDNENJ;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static List<int> JBEILOIIAPF;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<RRNetworkView> CLGOAPDEKCB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly IKNIODLHFBI HACJJLAPKNE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly IKNIODLHFBI NKGCLIECEDA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x80CE1A0", Offset = "0x80CC9A0", VA = "0x1880CE1A0", Slot = "8")]
	public void HAMEHJBFDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80CAFA0", Offset = "0x80C97A0", VA = "0x1880CAFA0", Slot = "9")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80CFD60", Offset = "0x80CE560", VA = "0x1880CFD60", Slot = "10")]
	public void InitExternal(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80CB7C0", Offset = "0x80C9FC0", VA = "0x1880CB7C0", Slot = "11")]
	public void BHGLJKNHMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80CB300", Offset = "0x80C9B00", VA = "0x1880CB300")]
	private void APIHOFCIMPA(NMFABPNHMKD DECOACEOOPP, NMFABPNHMKD OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x80CFF30", Offset = "0x80CE730", VA = "0x1880CFF30")]
	private void JIILPLFCFHH(LNJGFMPIPIM AGLAJFMOALJ, LNJGFMPIPIM KHGEBBJBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80D1800", Offset = "0x80D0000", VA = "0x1880D1800")]
	public GameObject OIAJEPPGCGK(string HPANEBBHGAC, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, Vector3 DKMKOJPHLDD, ViewId HEFGNKGLBJE, APNNOCBGIPF JCPNJLMMOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x80D0030", Offset = "0x80CE830", VA = "0x1880D0030")]
	public GameObject KFBENHNMMMG(string HPANEBBHGAC, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float DKMKOJPHLDD, object[] JCPNJLMMOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x80CE500", Offset = "0x80CCD00", VA = "0x1880CE500")]
	public GameObject HBIGEHPCCCA(string HPANEBBHGAC, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, Vector3 DKMKOJPHLDD, ViewId KBMPEIPJGHK, APNNOCBGIPF JCPNJLMMOLN, bool MBAMEPAOIHD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x80D1710", Offset = "0x80CFF10", VA = "0x1880D1710")]
	public GameObject LFHHOEPGDDN(DKBEJJEFNCK JCPNJLMMOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x80D0B00", Offset = "0x80CF300", VA = "0x1880D0B00", Slot = "6")]
	public void KNMNNEGFDNK(GameObject LEHCGNOJDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80D1740", Offset = "0x80CFF40", VA = "0x1880D1740")]
	public void LNGAFDGAICF(GameObject EMOLHEPHCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80D17B0", Offset = "0x80CFFB0", VA = "0x1880D17B0", Slot = "7")]
	public void LOBBHIGHIDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x80D2150", Offset = "0x80D0950", VA = "0x1880D2150", Slot = "4")]
	public GameObject[] PBOOHFJCJJG(IList<KFGMHEKKOBA> IGDPJPHPMIJ, bool JLEAKKPBKEE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x80CD7D0", Offset = "0x80CBFD0", VA = "0x1880CD7D0", Slot = "5")]
	public void ELNKCBGJDFN(List<GameObject> NFACCHLCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80CE980", Offset = "0x80CD180", VA = "0x1880CE980")]
	public void HJMADDFFIEH(GameObject EMOLHEPHCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x80D2460", Offset = "0x80D0C60", VA = "0x1880D2460")]
	private void PEJPCFBEJFL(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x80D19D0", Offset = "0x80D01D0", VA = "0x1880D19D0")]
	private void OJOEKGEMPLC(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x80D1D90", Offset = "0x80D0590", VA = "0x1880D1D90")]
	private void OLEJAJBEJEC(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80CEA60", Offset = "0x80CD260", VA = "0x1880CEA60")]
	private void HPNOBJIAPHC(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80D0760", Offset = "0x80CEF60", VA = "0x1880D0760")]
	private void KKCHEBBAPAP(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80CDB90", Offset = "0x80CC390", VA = "0x1880CDB90")]
	private void FFMMICGABJG(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80D0120", Offset = "0x80CE920", VA = "0x1880D0120")]
	private void KIHBBMAJCJH(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80CE790", Offset = "0x80CCF90", VA = "0x1880CE790")]
	private GameObject HJELGFGDCHE(string PFNNEAHDLNK, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, Vector3 DKMKOJPHLDD, byte LCPLPGNINPG = 0, [Optional] object[] IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x80CEE40", Offset = "0x80CD640", VA = "0x1880CEE40")]
	private GameObject IDDCLJAPPLA(DKBEJJEFNCK JCPNJLMMOLN, bool KNJPLBIFPNL = false, bool LMOGGHBNICE = false, bool MBAMEPAOIHD = true, bool MLBHEKGJBKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80CDF80", Offset = "0x80CC780", VA = "0x1880CDF80")]
	private static GameObject FMIGBCLFHHM(string PFNNEAHDLNK, bool DLDPAPFDCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80D1B80", Offset = "0x80D0380", VA = "0x1880D1B80")]
	private static GameObject OKFOCDJFHLN(GameObject OJKJJCNLKLJ, DKBEJJEFNCK JCPNJLMMOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80D2040", Offset = "0x80D0840", VA = "0x1880D2040")]
	private static void PBAPLEGEGLA(GameObject LEHCGNOJDEA, RRNetworkView KBMPEIPJGHK, [In] DKBEJJEFNCK JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80CF530", Offset = "0x80CDD30", VA = "0x1880CF530")]
	private GameObject[] IKOBCALHCHG(IList<KFGMHEKKOBA> IGDPJPHPMIJ, bool JLEAKKPBKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80CBDA0", Offset = "0x80CA5A0", VA = "0x1880CBDA0")]
	private GameObject[] DCHCFHPJOBE(DKBEJJEFNCK[] IABGAPCJMBK, int BGBAHFKHLPL, EIGONBNGIIK OINLJEGCCDI, GameObject[] KFMIGDFNKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80CB990", Offset = "0x80CA190", VA = "0x1880CB990")]
	private GameObject CFEGNMHCLEF([In] DKBEJJEFNCK JCPNJLMMOLN, GameObject OJKJJCNLKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7436970", Offset = "0x7435170", VA = "0x187436970")]
	private static bool OFPHEDFPBCP(bool KNJPLBIFPNL, bool MBAMEPAOIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x80D2750", Offset = "0x80D0F50", VA = "0x1880D2750")]
	private void PFEBEODHNHB(IEnumerable<GameObject> NFACCHLCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80CC900", Offset = "0x80CB100", VA = "0x1880CC900")]
	private void EFKBMFPONGO(GameObject LEHCGNOJDEA, bool MLBHEKGJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80D1040", Offset = "0x80CF840", VA = "0x1880D1040")]
	private static void LCDMAFFPBLA(IEnumerable<GameObject> NGHKPFHIFNK, List<(GameObject GameObject, int ParentCount)> PPBJBFOAAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80CB420", Offset = "0x80C9C20", VA = "0x1880CB420")]
	private void BBGJONIJOAI(int FDPIKKAKNIC, int BGBAHFKHLPL, bool MLBHEKGJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80CE000", Offset = "0x80CC800", VA = "0x1880CE000")]
	private static int GGAGLHGBDHM(int FDPIKKAKNIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80CC8A0", Offset = "0x80CB0A0", VA = "0x1880CC8A0")]
	private void DNCKKOPFJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x80D0B10", Offset = "0x80CF310", VA = "0x1880D0B10")]
	private void KOGJJGDEAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80CAF40", Offset = "0x80C9740", VA = "0x1880CAF40")]
	private static int AGOBKGJKEGN(int OKBBFDAMBEO, bool MBAMEPAOIHD = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x80D3360", Offset = "0x80D1B60", VA = "0x1880D3360")]
	private static int[] PHJOCICHIIL(int HCDACCPJHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x80CED40", Offset = "0x80CD540", VA = "0x1880CED40")]
	private static int[] HPPCNNPFNIA(int PKBMMFHCONE, int HCDACCPJHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x80D17C0", Offset = "0x80CFFC0", VA = "0x1880D17C0")]
	private void NCFLGNMOMLP(EIGONBNGIIK LJBMHOEFMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x80CC0E0", Offset = "0x80CA8E0", VA = "0x1880CC0E0")]
	private void DIPJLEHJBLP(EIGONBNGIIK OINLJEGCCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x80D1440", Offset = "0x80CFC40", VA = "0x1880D1440")]
	private void LDECBALKMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x80CB580", Offset = "0x80C9D80", VA = "0x1880CB580")]
	private void BHGBOKJDHKP(EIGONBNGIIK OINLJEGCCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x80CC040", Offset = "0x80CA840", VA = "0x1880CC040")]
	private static void DGLKPBLAHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x80CE0A0", Offset = "0x80CC8A0", VA = "0x1880CE0A0")]
	private void GPPFPCJELGJ(int[] FALJFNGGMDA, int NPAKEGEBJLN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IKNOHMJPHFN()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(ILJMBMFBHBD), new string[] { "Photon" })]
public class ILJMBMFBHBD : EGBPELOCMDI, DEPOIAMCLIH, NLHGIDBIBOG
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct IBPBGHONFIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly MethodInfo LKLFEMCAKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Func<MonoBehaviour, object> GLNNBMAMHLC;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
		public IBPBGHONFIJ(MethodInfo LKLFEMCAKEA, [Optional] Func<MonoBehaviour, object> GLNNBMAMHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x74473E0", Offset = "0x7445BE0", VA = "0x1874473E0")]
		public object CPADGIDDFIK(MonoBehaviour GBNLHKHJDCC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DIHEEBGGDIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DIHEEBGGDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x80C5C50", Offset = "0x80C4450", VA = "0x1880C5C50")]
		internal IBPBGHONFIJ AOBBGKHBBME(MethodInfo methodInfo)
		{
			return default(IBPBGHONFIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x47E1870", Offset = "0x47E0070", VA = "0x1847E1870")]
		internal object LJAMNECCMBJ(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IDCDGDMJFKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IDCDGDMJFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7429190", Offset = "0x7427990", VA = "0x187429190")]
		internal IBPBGHONFIJ JEFGKEAIPCK(MethodInfo methodInfo)
		{
			return default(IBPBGHONFIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EEIMGHAIPAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EEIMGHAIPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x80C5D20", Offset = "0x80C4520", VA = "0x1880C5D20")]
		internal bool NEAINPDEHPJ(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Stopwatch BLNPCMEINMD;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Dictionary<MethodInfo, ParameterInfo[]> LFEMNMLEHBD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<Type, List<IBPBGHONFIJ>> BJFJICELBNE;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x80D5FF0", Offset = "0x80D47F0", VA = "0x1880D5FF0", Slot = "4")]
	public void HAMEHJBFDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80D38E0", Offset = "0x80D20E0", VA = "0x1880D38E0", Slot = "5")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80D70F0", Offset = "0x80D58F0", VA = "0x1880D70F0")]
	private void PEJPCFBEJFL(IIBEMPIBOEO NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x80D6C30", Offset = "0x80D5430", VA = "0x1880D6C30", Slot = "9")]
	public string MHMKAPJDGLP(IIBEMPIBOEO NPLHFNMEMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x80D3800", Offset = "0x80D2000", VA = "0x1880D3800", Slot = "8")]
	public void AHPLKOAGDDK(ViewId HEFGNKGLBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x80D5820", Offset = "0x80D4020", VA = "0x1880D5820", Slot = "6")]
	public void CLAMEKHMPCK(ViewId KBMPEIPJGHK, string PICMFECJKDH, EIGONBNGIIK OINLJEGCCDI, GMHJIAHJCPH PFDDBFBACEP, params object[] JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x80D57F0", Offset = "0x80D3FF0", VA = "0x1880D57F0", Slot = "7")]
	public void CLAMEKHMPCK(ViewId KBMPEIPJGHK, string PICMFECJKDH, MLCIMENIGOO OLBBKGLINIK, GMHJIAHJCPH PFDDBFBACEP, params object[] JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x80D58F0", Offset = "0x80D40F0", VA = "0x1880D58F0")]
	private void CLAMEKHMPCK(ViewId KBMPEIPJGHK, string PICMFECJKDH, MLCIMENIGOO OLBBKGLINIK, EIGONBNGIIK OINLJEGCCDI, GMHJIAHJCPH PFDDBFBACEP, params object[] JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x80D3B40", Offset = "0x80D2340", VA = "0x1880D3B40")]
	private void CJPDJOELBLO(ViewId HEFGNKGLBJE, string PICMFECJKDH, EIGONBNGIIK OHCFIGMIAEM, int DGFKOBCJLIP, object[] FKIDLMLIFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80D6C60", Offset = "0x80D5460", VA = "0x1880D6C60")]
	private static void PDLALDCHADO(IBPBGHONFIJ LMGEPDDDDPA, MonoBehaviour GNODMLNGGHP, object[] JALDLFHONHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80D5DC0", Offset = "0x80D45C0", VA = "0x1880D5DC0")]
	private static bool DAIMKKACDJL(ParameterInfo[] IDGAIBBGPKE, Type[] HFINJFOOLCN, [Out] bool FLKBOPLCEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x80D6140", Offset = "0x80D4940", VA = "0x1880D6140")]
	private List<IBPBGHONFIJ> HHFEGMHDIHG(MonoBehaviour GNODMLNGGHP, Type EKDPBBCGKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x80D6B30", Offset = "0x80D5330", VA = "0x1880D6B30")]
	private static IEnumerable<MethodInfo> KEKOHFNHIBL(Type CEPGAJKBPDM, Type KGKAMHCFLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80D3A30", Offset = "0x80D2230", VA = "0x1880D3A30")]
	public static ParameterInfo[] CCOHCPEGBOF(MethodInfo LBLOOAMBIGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ILJMBMFBHBD()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, AEGIMLOKCDC, BKMLAMEFBLM, JJIBMHKNOBJ, PJJHFEPBJLP, MCENAIEHOIL
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum MIFHGEBAMHB
		{
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class EMCMKGMHPKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public EMCMKGMHPKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x80C5F30", Offset = "0x80C4730", VA = "0x1880C5F30")]
			internal bool ADLNGFNECND(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static Dictionary<int, RRNetworkView> PKOLOGFMGGE;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static IKNIODLHFBI BIAHGLOCKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private bool LHDAMHPIHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal bool LBKCJHHLLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public MIFHGEBAMHB hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool EDBMEMFBBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool LFEEAFJMBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int IILCLDPHPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool IEEEKPNFPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int EABKPOPGEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private EIGONBNGIIK PKBMMFHCONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private EIGONBNGIIK FLBGLLONNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool? EDMOMLOFNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool GIPMILIAJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal bool GKBMDKILIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal MonoBehaviour[] BHDGOJGHLCD;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly BMELPJIFPCL BIFFPPLGCLD;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ViewId CHOJBAGLNJM
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x80E2A00", Offset = "0x80E1200", VA = "0x1880E2A00")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId HAHHANMGHEF
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x80E2A00", Offset = "0x80E1200", VA = "0x1880E2A00", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId CCNPHGHHLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x80E2A00", Offset = "0x80E1200", VA = "0x1880E2A00")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int GIFAJNHJEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BFLOAHCNIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId AJMPHJDMOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x80E2870", Offset = "0x80E1070", VA = "0x1880E2870")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool DNGNBAJCLMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BGNLIKEMEOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x80E2880", Offset = "0x80E1080", VA = "0x1880E2880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EAKINKKEIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int PLKJNEPCLEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4D80", Offset = "0xCF3580", VA = "0x180CF4D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int ODDFCAJCACL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x80E2810", Offset = "0x80E1010", VA = "0x1880E2810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public EIGONBNGIIK GEFAGIIPHNP
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x80E2A10", Offset = "0x80E1210", VA = "0x1880E2A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EIGONBNGIIK NDICHDMGEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x80E27E0", Offset = "0x80E0FE0", VA = "0x1880E27E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public EIGONBNGIIK OGMCJCKBFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x80E27E0", Offset = "0x80E0FE0", VA = "0x1880E27E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public EIGONBNGIIK KDGNDKJDBBP
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x80E27E0", Offset = "0x80E0FE0", VA = "0x1880E27E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BNLIDHECOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x80E2950", Offset = "0x80E1150", VA = "0x1880E2950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int LFAGFBCGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x80E2840", Offset = "0x80E1040", VA = "0x1880E2840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public object[] PGMBBDBPJMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool DBOEKIJEKEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x80E2A40", Offset = "0x80E1240", VA = "0x1880E2A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool OBELCKAIKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x80E29D0", Offset = "0x80E11D0", VA = "0x1880E29D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool CKMFIGLLOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xDC2EA0", Offset = "0xDC16A0", VA = "0x180DC2EA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xF06CE0", Offset = "0xF054E0", VA = "0x180F06CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CFKGHHENCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> AOANMNOOLNF
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x80E2680", Offset = "0x80E0E80", VA = "0x1880E2680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x80E2C00", Offset = "0x80E1400", VA = "0x1880E2C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<EIGONBNGIIK> CLPNBIKMFIO
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x80DED50", Offset = "0x80DD550", VA = "0x1880DED50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x80DE4C0", Offset = "0x80DCCC0", VA = "0x1880DE4C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<EIGONBNGIIK> JBFEFNNKFBH
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x80DED50", Offset = "0x80DD550", VA = "0x1880DED50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x80DE4C0", Offset = "0x80DCCC0", VA = "0x1880DE4C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> MAPMHALMBCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x80DDA40", Offset = "0x80DC240", VA = "0x1880DDA40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x80DDF80", Offset = "0x80DC780", VA = "0x1880DDF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> AFMBOJDOEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x80DDA40", Offset = "0x80DC240", VA = "0x1880DDA40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x80DDF80", Offset = "0x80DC780", VA = "0x1880DDF80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> IJCPCKPNBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x80E2730", Offset = "0x80E0F30", VA = "0x1880E2730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x80E2CB0", Offset = "0x80E14B0", VA = "0x1880E2CB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action JBAGCHMIHFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x80E25D0", Offset = "0x80E0DD0", VA = "0x1880E25D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x80E2B50", Offset = "0x80E1350", VA = "0x1880E2B50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x80E2410", Offset = "0x80E0C10", VA = "0x1880E2410")]
		public static bool TryGetNetworkView(int HEFGNKGLBJE, [Out] RRNetworkView KBMPEIPJGHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x80DE030", Offset = "0x80DC830", VA = "0x1880DE030")]
		public static RRNetworkView Find(int HEFGNKGLBJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x80DE220", Offset = "0x80DCA20", VA = "0x1880DE220")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int NLAPHBJBIHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80DE1B0", Offset = "0x80DC9B0", VA = "0x1880DE1B0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80DFB80", Offset = "0x80DE380", VA = "0x1880DFB80")]
		public static bool RemoveNetworkView(RRNetworkView KBMPEIPJGHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x80DF950", Offset = "0x80DE150", VA = "0x1880DF950")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80DF290", Offset = "0x80DDA90", VA = "0x1880DF290")]
		public static void OnPlayerJoinedRoom(EIGONBNGIIK KFJHMGCHPIP, List<int> FALJFNGGMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x80DE360", Offset = "0x80DCB60", VA = "0x1880DE360")]
		public static RRNetworkView Get(Component EIBGHDHLJMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80DE3C0", Offset = "0x80DCBC0", VA = "0x1880DE3C0")]
		public static RRNetworkView Get(GameObject FABGOEMDHPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x80DDDE0", Offset = "0x80DC5E0", VA = "0x1880DDDE0")]
		private void DHFIBGINPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x80DDD60", Offset = "0x80DC560", VA = "0x1880DDD60")]
		public bool CreatedBy(EIGONBNGIIK OINLJEGCCDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x80E2220", Offset = "0x80E0A20", VA = "0x1880E2220")]
		public void TransferOwnership(int PBCIMLFPACJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x80E21C0", Offset = "0x80E09C0", VA = "0x1880E21C0")]
		public void TransferOwnership(EIGONBNGIIK KJEADPKKIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x80DE760", Offset = "0x80DCF60", VA = "0x1880DE760", Slot = "4")]
		public void Initialize(ViewId JNLMNIFMELA, ViewId LKGJHOBIBKA, Dictionary<int, object> FDLLKGDBNDF, GBNNBLFIGLH PKBMMFHCONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x80DE8E0", Offset = "0x80DD0E0", VA = "0x1880DE8E0")]
		public void Initialize(ViewId JNLMNIFMELA, ViewId LKGJHOBIBKA, object[] KDEGLDKLAGA, GBNNBLFIGLH PKBMMFHCONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x80DD7B0", Offset = "0x80DBFB0", VA = "0x1880DD7B0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x80DE570", Offset = "0x80DCD70", VA = "0x1880DE570")]
		private void ILHCMMDOHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1E6F820", Offset = "0x1E6E020", VA = "0x181E6F820")]
		internal void LHNLHDGLPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x80DDEC0", Offset = "0x80DC6C0", VA = "0x1880DDEC0", Slot = "6")]
		private void EMLODCFCMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x80DE940", Offset = "0x80DD140", VA = "0x1880DE940")]
		internal bool JPAAELPPKIA(RRNetworkView ACNOOEBGGFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x80DF0F0", Offset = "0x80DD8F0", VA = "0x1880DF0F0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x80DEEC0", Offset = "0x80DD6C0", VA = "0x1880DEEC0")]
		internal void MJCDMFHAEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x80DEF20", Offset = "0x80DD720", VA = "0x1880DEF20")]
		private void MJOOAICBKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x80DEE00", Offset = "0x80DD600", VA = "0x1880DEE00")]
		internal void LHIOAEEIGAN(EIGONBNGIIK KJEADPKKIEA, int PBCIMLFPACJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x80DFAE0", Offset = "0x80DE2E0", VA = "0x1880DFAE0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x80DFC00", Offset = "0x80DE400", VA = "0x1880DFC00")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x80DEF30", Offset = "0x80DD730", VA = "0x1880DEF30")]
		private void MMADOFHECKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x80DE0C0", Offset = "0x80DC8C0", VA = "0x1880DE0C0")]
		private void GKACJOCDKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x80DF830", Offset = "0x80DE030", VA = "0x1880DF830")]
		public void RPC(string PICMFECJKDH, MLCIMENIGOO OLBBKGLINIK, params object[] JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x80DF8C0", Offset = "0x80DE0C0", VA = "0x1880DF8C0")]
		public void RPC(string PICMFECJKDH, EIGONBNGIIK CBCINDIMJOG, params object[] JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x80DFB30", Offset = "0x80DE330", VA = "0x1880DFB30")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x80DD9D0", Offset = "0x80DC1D0", VA = "0x1880DD9D0", Slot = "8")]
		public void Bake(HDJJIILNIDG MJAGIMDGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x80DF070", Offset = "0x80DD870", VA = "0x1880DF070")]
		private static void NKPCMKHFJJI(EIGONBNGIIK PCJIBHNFPNF, [Out] EIGONBNGIIK NGHKAKJAOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x80DEA30", Offset = "0x80DD230", VA = "0x1880DEA30")]
		private static void LEFMIOLGINM(RRNetworkView AMHLEGGNPGI, Delegate LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x80DE9B0", Offset = "0x80DD1B0", VA = "0x1880DE9B0")]
		private static AKPFKMFKLAA JPIIMDIHLPI(RRNetworkView AMHLEGGNPGI)
		{
			return default(AKPFKMFKLAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x80DEFD0", Offset = "0x80DD7D0", VA = "0x1880DEFD0")]
		private static ACNLMKJJPMB MMNPFAFPKAK(RRNetworkView AMHLEGGNPGI)
		{
			return default(ACNLMKJJPMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x80DD8F0", Offset = "0x80DC0F0", VA = "0x1880DD8F0")]
		private static void BJBLJJOINAA(RRNetworkView AMHLEGGNPGI, Delegate LMGEPDDDDPA, EIGONBNGIIK JMOLOKDGADL, params object[] JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x80DD810", Offset = "0x80DC010", VA = "0x1880DD810")]
		private static void BJBLJJOINAA(RRNetworkView AMHLEGGNPGI, Delegate LMGEPDDDDPA, MLCIMENIGOO JMOLOKDGADL, params object[] JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x80DF5E0", Offset = "0x80DDDE0", VA = "0x1880DF5E0")]
		private static void PCIBAIDKMMB(RRNetworkView AMHLEGGNPGI, Delegate LMGEPDDDDPA, MLCIMENIGOO JMOLOKDGADL, CFKDLOOAPIO NFCDEMENAMP, params object[] JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x80DF730", Offset = "0x80DDF30", VA = "0x1880DF730")]
		public void RPCBuffered(string PICMFECJKDH, MLCIMENIGOO OLBBKGLINIK, CFKDLOOAPIO PFDDBFBACEP, params object[] JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x80DE420", Offset = "0x80DCC20", VA = "0x1880DE420")]
		private static bool IBNLNNPECGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x80E06C0", Offset = "0x80DEEC0", VA = "0x1880E06C0", Slot = "26")]
		public void RpcAll(CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3C89330", Offset = "0x3C87B30", VA = "0x183C89330", Slot = "9")]
		public void RpcAll<T1>(CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3C88B60", Offset = "0x3C87360", VA = "0x183C88B60", Slot = "10")]
		public void RpcAll<T1, T2>(CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B040", Offset = "0x3C89840", VA = "0x183C8B040", Slot = "27")]
		public void RpcAll<T1, T2, T3>(CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3C88D90", Offset = "0x3C87590", VA = "0x183C88D90", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A9E0", Offset = "0x3C891E0", VA = "0x183C8A9E0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B550", Offset = "0x3C89D50", VA = "0x183C8B550", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C020", Offset = "0x3C8A820", VA = "0x183C8C020", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3C90BF0", Offset = "0x3C8F3F0", VA = "0x183C90BF0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3C8BA00", Offset = "0x3C8A200", VA = "0x183C8BA00", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3C89DB0", Offset = "0x3C885B0", VA = "0x183C89DB0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3C97540", Offset = "0x3C95D40", VA = "0x183C97540", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3C96420", Offset = "0x3C94C20", VA = "0x183C96420", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3C95E30", Offset = "0x3C94630", VA = "0x183C95E30", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C894D0", Offset = "0x3C87CD0", VA = "0x183C894D0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x80E04B0", Offset = "0x80DECB0", VA = "0x1880E04B0")]
		public void RpcAll(CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E2C0", Offset = "0x3C8CAC0", VA = "0x183C8E2C0")]
		public void RpcAll<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3C8ED60", Offset = "0x3C8D560", VA = "0x183C8ED60")]
		public void RpcAll<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A6B0", Offset = "0x3C88EB0", VA = "0x183C8A6B0")]
		public void RpcAll<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3C9CC90", Offset = "0x3C9B490", VA = "0x183C9CC90")]
		public void RpcAll<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C6A0", Offset = "0x3C9AEA0", VA = "0x183C9C6A0")]
		public void RpcAll<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C000", Offset = "0x3C9A800", VA = "0x183C9C000")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B1E0", Offset = "0x3C999E0", VA = "0x183C9B1E0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A190", Offset = "0x3C98990", VA = "0x183C9A190")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C99CF0", Offset = "0x3C984F0", VA = "0x183C99CF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C98540", Offset = "0x3C96D40", VA = "0x183C98540")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C97A60", Offset = "0x3C96260", VA = "0x183C97A60")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C969A0", Offset = "0x3C951A0", VA = "0x183C969A0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C951B0", Offset = "0x3C939B0", VA = "0x183C951B0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3C93DF0", Offset = "0x3C925F0", VA = "0x183C93DF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x80E0280", Offset = "0x80DEA80", VA = "0x1880E0280", Slot = "36")]
		public void RpcAll(CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3CA18C0", Offset = "0x3CA00C0", VA = "0x183CA18C0", Slot = "37")]
		public void RpcAll<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F300", Offset = "0x3C9DB00", VA = "0x183C9F300", Slot = "38")]
		public void RpcAll<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DCD0", Offset = "0x3C9C4D0", VA = "0x183C9DCD0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3C9D1D0", Offset = "0x3C9B9D0", VA = "0x183C9D1D0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C380", Offset = "0x3C9AB80", VA = "0x183C9C380", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BC80", Offset = "0x3C9A480", VA = "0x183C9BC80", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AE00", Offset = "0x3C99600", VA = "0x183C9AE00", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A5D0", Offset = "0x3C98DD0", VA = "0x183C9A5D0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C99850", Offset = "0x3C98050", VA = "0x183C99850", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C98A40", Offset = "0x3C97240", VA = "0x183C98A40", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C97FD0", Offset = "0x3C967D0", VA = "0x183C97FD0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C96F70", Offset = "0x3C95770", VA = "0x183C96F70", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C957F0", Offset = "0x3C93FF0", VA = "0x183C957F0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C94B00", Offset = "0x3C93300", VA = "0x183C94B00", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x80DFEF0", Offset = "0x80DE6F0", VA = "0x1880DFEF0", Slot = "51")]
		public void RpcAllViaServer(CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C88860", Offset = "0x3C87060", VA = "0x183C88860", Slot = "52")]
		public void RpcAllViaServer<T1>(CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C807B0", Offset = "0x3C7EFB0", VA = "0x183C807B0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3C880E0", Offset = "0x3C868E0", VA = "0x183C880E0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C87D30", Offset = "0x3C86530", VA = "0x183C87D30", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3C876E0", Offset = "0x3C85EE0", VA = "0x183C876E0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3C86FB0", Offset = "0x3C857B0", VA = "0x183C86FB0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C861F0", Offset = "0x3C849F0", VA = "0x183C861F0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C85B90", Offset = "0x3C84390", VA = "0x183C85B90", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C854E0", Offset = "0x3C83CE0", VA = "0x183C854E0", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C84640", Offset = "0x3C82E40", VA = "0x183C84640", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C83610", Offset = "0x3C81E10", VA = "0x183C83610", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C828C0", Offset = "0x3C810C0", VA = "0x183C828C0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C81A80", Offset = "0x3C80280", VA = "0x183C81A80", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C80B20", Offset = "0x3C7F320", VA = "0x183C80B20", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x80E0150", Offset = "0x80DE950", VA = "0x1880E0150")]
		public void RpcAllViaServer(CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C88960", Offset = "0x3C87160", VA = "0x183C88960")]
		public void RpcAllViaServer<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C88700", Offset = "0x3C86F00", VA = "0x183C88700")]
		public void RpcAllViaServer<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C87F30", Offset = "0x3C86730", VA = "0x183C87F30")]
		public void RpcAllViaServer<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C87B30", Offset = "0x3C86330", VA = "0x183C87B30")]
		public void RpcAllViaServer<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C87240", Offset = "0x3C85A40", VA = "0x183C87240")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3C86A90", Offset = "0x3C85290", VA = "0x183C86A90")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C867B0", Offset = "0x3C84FB0", VA = "0x183C867B0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3C85EC0", Offset = "0x3C846C0", VA = "0x183C85EC0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3C84DE0", Offset = "0x3C835E0", VA = "0x183C84DE0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3C84A10", Offset = "0x3C83210", VA = "0x183C84A10")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3C83A30", Offset = "0x3C82230", VA = "0x183C83A30")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3C831A0", Offset = "0x3C819A0", VA = "0x183C831A0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C82400", Offset = "0x3C80C00", VA = "0x183C82400")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C81560", Offset = "0x3C7FD60", VA = "0x183C81560")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x80E0020", Offset = "0x80DE820", VA = "0x1880E0020", Slot = "65")]
		public void RpcAllViaServer(CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C88A60", Offset = "0x3C87260", VA = "0x183C88A60", Slot = "66")]
		public void RpcAllViaServer<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C885A0", Offset = "0x3C86DA0", VA = "0x183C885A0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C88290", Offset = "0x3C86A90", VA = "0x183C88290", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C87930", Offset = "0x3C86130", VA = "0x183C87930", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C87490", Offset = "0x3C85C90", VA = "0x183C87490", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C86D20", Offset = "0x3C85520", VA = "0x183C86D20", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C864D0", Offset = "0x3C84CD0", VA = "0x183C864D0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C85860", Offset = "0x3C84060", VA = "0x183C85860", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C85160", Offset = "0x3C83960", VA = "0x183C85160", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C84270", Offset = "0x3C82A70", VA = "0x183C84270", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C83E50", Offset = "0x3C82650", VA = "0x183C83E50", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C82D30", Offset = "0x3C81530", VA = "0x183C82D30", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C81F40", Offset = "0x3C80740", VA = "0x183C81F40", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C81040", Offset = "0x3C7F840", VA = "0x183C81040", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x80E1660", Offset = "0x80DFE60", VA = "0x1880E1660", Slot = "80")]
		public void RpcOthers(CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0460", Offset = "0x3CCEC60", VA = "0x183CD0460", Slot = "15")]
		public void RpcOthers<T1>(CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0D10", Offset = "0x3CCF510", VA = "0x183CD0D10", Slot = "81")]
		public void RpcOthers<T1, T2>(CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD01E0", Offset = "0x3CCE9E0", VA = "0x183CD01E0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9680", Offset = "0x3CD7E80", VA = "0x183CD9680", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1A70", Offset = "0x3CD0270", VA = "0x183CD1A70", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CD84D0", Offset = "0x3CD6CD0", VA = "0x183CD84D0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7BA0", Offset = "0x3CD63A0", VA = "0x183CD7BA0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7840", Offset = "0x3CD6040", VA = "0x183CD7840", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6670", Offset = "0x3CD4E70", VA = "0x183CD6670", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6280", Offset = "0x3CD4A80", VA = "0x183CD6280", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5660", Offset = "0x3CD3E60", VA = "0x183CD5660", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4950", Offset = "0x3CD3150", VA = "0x183CD4950", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3650", Offset = "0x3CD1E50", VA = "0x183CD3650", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CD26E0", Offset = "0x3CD0EE0", VA = "0x183CD26E0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x80E1900", Offset = "0x80E0100", VA = "0x1880E1900")]
		public void RpcOthers(CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0A70", Offset = "0x3CCF270", VA = "0x183CD0A70")]
		public void RpcOthers<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0890", Offset = "0x3CCF090", VA = "0x183CD0890")]
		public void RpcOthers<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA630", Offset = "0x3CD8E30", VA = "0x183CDA630")]
		public void RpcOthers<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD05B0", Offset = "0x3CCEDB0", VA = "0x183CD05B0")]
		public void RpcOthers<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1200", Offset = "0x3CCFA00", VA = "0x183CD1200")]
		public void RpcOthers<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1540", Offset = "0x3CCFD40", VA = "0x183CD1540")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7EB0", Offset = "0x3CD66B0", VA = "0x183CD7EB0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD74E0", Offset = "0x3CD5CE0", VA = "0x183CD74E0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6DD0", Offset = "0x3CD55D0", VA = "0x183CD6DD0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5E90", Offset = "0x3CD4690", VA = "0x183CD5E90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4DE0", Offset = "0x3CD35E0", VA = "0x183CD4DE0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4030", Offset = "0x3CD2830", VA = "0x183CD4030")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3B40", Offset = "0x3CD2340", VA = "0x183CD3B40")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CD21A0", Offset = "0x3CD09A0", VA = "0x183CD21A0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x80E17B0", Offset = "0x80DFFB0", VA = "0x1880E17B0", Slot = "93")]
		public void RpcOthers(CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB210", Offset = "0x3CD9A10", VA = "0x183CDB210", Slot = "94")]
		public void RpcOthers<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3CDAED0", Offset = "0x3CD96D0", VA = "0x183CDAED0", Slot = "95")]
		public void RpcOthers<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA460", Offset = "0x3CD8C60", VA = "0x183CDA460", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9460", Offset = "0x3CD7C60", VA = "0x183CD9460", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8F80", Offset = "0x3CD7780", VA = "0x183CD8F80", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8790", Offset = "0x3CD6F90", VA = "0x183CD8790", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3CD81C0", Offset = "0x3CD69C0", VA = "0x183CD81C0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7180", Offset = "0x3CD5980", VA = "0x183CD7180", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6A20", Offset = "0x3CD5220", VA = "0x183CD6A20", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5AA0", Offset = "0x3CD42A0", VA = "0x183CD5AA0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5220", Offset = "0x3CD3A20", VA = "0x183CD5220", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CD44C0", Offset = "0x3CD2CC0", VA = "0x183CD44C0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3160", Offset = "0x3CD1960", VA = "0x183CD3160", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2C20", Offset = "0x3CD1420", VA = "0x183CD2C20", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x80E12F0", Offset = "0x80DFAF0", VA = "0x1880E12F0", Slot = "108")]
		public void RpcMaster(CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5330", Offset = "0x3CB3B30", VA = "0x183CB5330", Slot = "109")]
		public void RpcMaster<T1>(CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5700", Offset = "0x3CB3F00", VA = "0x183CB5700", Slot = "17")]
		public void RpcMaster<T1, T2>(CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5050", Offset = "0x3CB3850", VA = "0x183CB5050", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4CE0", Offset = "0x3CB34E0", VA = "0x183CB4CE0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8F50", Offset = "0x3CB7750", VA = "0x183CB8F50", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB490", Offset = "0x3CB9C90", VA = "0x183CBB490", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3920", Offset = "0x3CC2120", VA = "0x183CC3920", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3500", Offset = "0x3CC1D00", VA = "0x183CC3500", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC22E0", Offset = "0x3CC0AE0", VA = "0x183CC22E0", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB86F0", Offset = "0x3CB6EF0", VA = "0x183CB86F0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3CB72A0", Offset = "0x3CB5AA0", VA = "0x183CB72A0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF920", Offset = "0x3CBE120", VA = "0x183CBF920", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDAD0", Offset = "0x3CBC2D0", VA = "0x183CBDAD0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC710", Offset = "0x3CBAF10", VA = "0x183CBC710", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x80E10D0", Offset = "0x80DF8D0", VA = "0x1880E10D0")]
		public void RpcMaster(CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CB54F0", Offset = "0x3CB3CF0", VA = "0x183CB54F0")]
		public void RpcMaster<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6410", Offset = "0x3CB4C10", VA = "0x183CB6410")]
		public void RpcMaster<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5960", Offset = "0x3CB4160", VA = "0x183CB5960")]
		public void RpcMaster<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5C40", Offset = "0x3CC4440", VA = "0x183CC5C40")]
		public void RpcMaster<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9A00", Offset = "0x3CB8200", VA = "0x183CB9A00")]
		public void RpcMaster<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4C00", Offset = "0x3CC3400", VA = "0x183CC4C00")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3CE0", Offset = "0x3CC24E0", VA = "0x183CC3CE0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2C20", Offset = "0x3CC1420", VA = "0x183CC2C20")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2750", Offset = "0x3CC0F50", VA = "0x183CC2750")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC18E0", Offset = "0x3CC00E0", VA = "0x183CC18E0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0430", Offset = "0x3CBEC30", VA = "0x183CC0430")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CBED60", Offset = "0x3CBD560", VA = "0x183CBED60")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE0C0", Offset = "0x3CBC8C0", VA = "0x183CBE0C0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD420", Offset = "0x3CBBC20", VA = "0x183CBD420")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x80E0E90", Offset = "0x80DF690", VA = "0x1880E0E90", Slot = "122")]
		public void RpcMaster(CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8960", Offset = "0x3CC7160", VA = "0x183CC8960", Slot = "123")]
		public void RpcMaster<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC79C0", Offset = "0x3CC61C0", VA = "0x183CC79C0", Slot = "124")]
		public void RpcMaster<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3CC61D0", Offset = "0x3CC49D0", VA = "0x183CC61D0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5940", Offset = "0x3CC4140", VA = "0x183CC5940", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3CC55F0", Offset = "0x3CC3DF0", VA = "0x183CC55F0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4850", Offset = "0x3CC3050", VA = "0x183CC4850", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3CC40F0", Offset = "0x3CC28F0", VA = "0x183CC40F0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3090", Offset = "0x3CC1890", VA = "0x183CC3090", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1E10", Offset = "0x3CC0610", VA = "0x183CC1E10", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0EE0", Offset = "0x3CBF6E0", VA = "0x183CC0EE0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFEB0", Offset = "0x3CBE6B0", VA = "0x183CBFEB0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF340", Offset = "0x3CBDB40", VA = "0x183CBF340", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE710", Offset = "0x3CBCF10", VA = "0x183CBE710", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3CBCD70", Offset = "0x3CBB570", VA = "0x183CBCD70", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x80E0CE0", Offset = "0x80DF4E0", VA = "0x1880E0CE0", Slot = "137")]
		public void RpcAuthority(CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4770", Offset = "0x3CA2F70", VA = "0x183CA4770", Slot = "138")]
		public void RpcAuthority<T1>(CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6E20", Offset = "0x3CA5620", VA = "0x183CA6E20", Slot = "139")]
		public void RpcAuthority<T1, T2>(CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7610", Offset = "0x3CA5E10", VA = "0x183CA7610", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6AD0", Offset = "0x3CA52D0", VA = "0x183CA6AD0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5620", Offset = "0x3CA3E20", VA = "0x183CA5620", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0230", Offset = "0x3CAEA30", VA = "0x183CB0230", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF260", Offset = "0x3CADA60", VA = "0x183CAF260", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEE30", Offset = "0x3CAD630", VA = "0x183CAEE30", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3CADBC0", Offset = "0x3CAC3C0", VA = "0x183CADBC0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC770", Offset = "0x3CAAF70", VA = "0x183CAC770", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC230", Offset = "0x3CAAA30", VA = "0x183CAC230", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5A40", Offset = "0x3CA4240", VA = "0x183CA5A40", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3CA9F60", Offset = "0x3CA8760", VA = "0x183CA9F60", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8570", Offset = "0x3CA6D70", VA = "0x183CA8570", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x80E0A90", Offset = "0x80DF290", VA = "0x1880E0A90")]
		public void RpcAuthority(CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4ED0", Offset = "0x3CA36D0", VA = "0x183CA4ED0")]
		public void RpcAuthority<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2640", Offset = "0x3CB0E40", VA = "0x183CB2640")]
		public void RpcAuthority<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2110", Offset = "0x3CB0910", VA = "0x183CB2110")]
		public void RpcAuthority<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1600", Offset = "0x3CAFE00", VA = "0x183CB1600")]
		public void RpcAuthority<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0C70", Offset = "0x3CAF470", VA = "0x183CB0C70")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFE70", Offset = "0x3CAE670", VA = "0x183CAFE70")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF630", Offset = "0x3CADE30", VA = "0x183CAF630")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE9B0", Offset = "0x3CAD1B0", VA = "0x183CAE9B0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE050", Offset = "0x3CAC850", VA = "0x183CAE050")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3CACC60", Offset = "0x3CAB460", VA = "0x183CACC60")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3CABCA0", Offset = "0x3CAA4A0", VA = "0x183CABCA0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3CAAB70", Offset = "0x3CA9370", VA = "0x183CAAB70")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3CA9900", Offset = "0x3CA8100", VA = "0x183CA9900")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7EB0", Offset = "0x3CA66B0", VA = "0x183CA7EB0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x80E0830", Offset = "0x80DF030", VA = "0x1880E0830", Slot = "152")]
		public void RpcAuthority(CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4CF0", Offset = "0x3CA34F0", VA = "0x183CA4CF0", Slot = "153")]
		public void RpcAuthority<T1>(CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2880", Offset = "0x3CB1080", VA = "0x183CB2880", Slot = "154")]
		public void RpcAuthority<T1, T2>(CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1C20", Offset = "0x3CB0420", VA = "0x183CB1C20", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1910", Offset = "0x3CB0110", VA = "0x183CB1910", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0FE0", Offset = "0x3CAF7E0", VA = "0x183CB0FE0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB05A0", Offset = "0x3CAEDA0", VA = "0x183CB05A0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFA50", Offset = "0x3CAE250", VA = "0x183CAFA50", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE530", Offset = "0x3CACD30", VA = "0x183CAE530", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD6E0", Offset = "0x3CABEE0", VA = "0x183CAD6E0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD1A0", Offset = "0x3CAB9A0", VA = "0x183CAD1A0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3CAB710", Offset = "0x3CA9F10", VA = "0x183CAB710", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA570", Offset = "0x3CA8D70", VA = "0x183CAA570", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3CA92A0", Offset = "0x3CA7AA0", VA = "0x183CA92A0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8BE0", Offset = "0x3CA73E0", VA = "0x183CA8BE0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x80E1A50", Offset = "0x80E0250", VA = "0x1880E1A50", Slot = "18")]
		public void RpcPlayer(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCF80", Offset = "0x3CDB780", VA = "0x183CDCF80", Slot = "19")]
		public void RpcPlayer<T1>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3CDDD20", Offset = "0x3CDC520", VA = "0x183CDDD20", Slot = "20")]
		public void RpcPlayer<T1, T2>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3CDD730", Offset = "0x3CDBF30", VA = "0x183CDD730", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3CDD150", Offset = "0x3CDB950", VA = "0x183CDD150", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1AE0", Offset = "0x3CE02E0", VA = "0x183CE1AE0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1670", Offset = "0x3CDFE70", VA = "0x183CE1670", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1ED0", Offset = "0x3CE06D0", VA = "0x183CE1ED0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3CE23A0", Offset = "0x3CE0BA0", VA = "0x183CE23A0", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3CEAA50", Offset = "0x3CE9250", VA = "0x183CEAA50", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9B10", Offset = "0x3CE8310", VA = "0x183CE9B10", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EIGONBNGIIK OINLJEGCCDI, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE610", Offset = "0x3CDCE10", VA = "0x183CDE610", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EIGONBNGIIK OINLJEGCCDI, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7F60", Offset = "0x3CE6760", VA = "0x183CE7F60", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EIGONBNGIIK OINLJEGCCDI, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3CE66B0", Offset = "0x3CE4EB0", VA = "0x183CE66B0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EIGONBNGIIK OINLJEGCCDI, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3CE52F0", Offset = "0x3CE3AF0", VA = "0x183CE52F0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EIGONBNGIIK OINLJEGCCDI, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x80E1C50", Offset = "0x80E0450", VA = "0x1880E1C50")]
		public void RpcPlayer(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3CDD500", Offset = "0x3CDBD00", VA = "0x183CDD500")]
		public void RpcPlayer<T1>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4100", Offset = "0x3CE2900", VA = "0x183CE4100")]
		public void RpcPlayer<T1, T2>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3CEEE40", Offset = "0x3CED640", VA = "0x183CEEE40")]
		public void RpcPlayer<T1, T2, T3>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE870", Offset = "0x3CED070", VA = "0x183CEE870")]
		public void RpcPlayer<T1, T2, T3, T4>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3CEDC10", Offset = "0x3CEC410", VA = "0x183CEDC10")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3CED4B0", Offset = "0x3CEBCB0", VA = "0x183CED4B0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC500", Offset = "0x3CEAD00", VA = "0x183CEC500")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB3E0", Offset = "0x3CE9BE0", VA = "0x183CEB3E0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA560", Offset = "0x3CE8D60", VA = "0x183CEA560")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EIGONBNGIIK OINLJEGCCDI, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA010", Offset = "0x3CE8810", VA = "0x183CEA010")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EIGONBNGIIK OINLJEGCCDI, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8510", Offset = "0x3CE6D10", VA = "0x183CE8510")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EIGONBNGIIK OINLJEGCCDI, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7340", Offset = "0x3CE5B40", VA = "0x183CE7340")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EIGONBNGIIK OINLJEGCCDI, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6040", Offset = "0x3CE4840", VA = "0x183CE6040")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EIGONBNGIIK OINLJEGCCDI, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5970", Offset = "0x3CE4170", VA = "0x183CE5970")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EIGONBNGIIK OINLJEGCCDI, DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x80E1F00", Offset = "0x80E0700", VA = "0x1880E1F00", Slot = "176")]
		public void RpcPlayer(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0650", Offset = "0x3CDEE50", VA = "0x183CE0650", Slot = "177")]
		public void RpcPlayer<T1>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE320", Offset = "0x3CDCB20", VA = "0x183CDE320", Slot = "24")]
		public void RpcPlayer<T1, T2>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3CDDFA0", Offset = "0x3CDC7A0", VA = "0x183CDDFA0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFE50", Offset = "0x3CDE650", VA = "0x183CDFE50", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3CED890", Offset = "0x3CEC090", VA = "0x183CED890", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3CED0D0", Offset = "0x3CEB8D0", VA = "0x183CED0D0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC930", Offset = "0x3CEB130", VA = "0x183CEC930", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBCA0", Offset = "0x3CEA4A0", VA = "0x183CEBCA0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(EIGONBNGIIK OINLJEGCCDI, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3CEAEF0", Offset = "0x3CE96F0", VA = "0x183CEAEF0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(EIGONBNGIIK OINLJEGCCDI, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3CE95C0", Offset = "0x3CE7DC0", VA = "0x183CE95C0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EIGONBNGIIK OINLJEGCCDI, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9010", Offset = "0x3CE7810", VA = "0x183CE9010", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EIGONBNGIIK OINLJEGCCDI, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7950", Offset = "0x3CE6150", VA = "0x183CE7950", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EIGONBNGIIK OINLJEGCCDI, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6CD0", Offset = "0x3CE54D0", VA = "0x183CE6CD0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(EIGONBNGIIK OINLJEGCCDI, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4C20", Offset = "0x3CE3420", VA = "0x183CE4C20", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EIGONBNGIIK OINLJEGCCDI, DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x80DFE50", Offset = "0x80DE650", VA = "0x1880DFE50", Slot = "189")]
		public void RpcAllBuffered(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3C80570", Offset = "0x3C7ED70", VA = "0x183C80570", Slot = "190")]
		public void RpcAllBuffered<T1>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3C80170", Offset = "0x3C7E970", VA = "0x183C80170", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FAC0", Offset = "0x3C7E2C0", VA = "0x183C7FAC0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F6A0", Offset = "0x3C7DEA0", VA = "0x183C7F6A0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EDA0", Offset = "0x3C7D5A0", VA = "0x183C7EDA0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E5C0", Offset = "0x3C7CDC0", VA = "0x183C7E5C0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DCF0", Offset = "0x3C7C4F0", VA = "0x183C7DCF0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D330", Offset = "0x3C7BB30", VA = "0x183C7D330", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CFA0", Offset = "0x3C7B7A0", VA = "0x183C7CFA0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C0C0", Offset = "0x3C7A8C0", VA = "0x183C7C0C0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CFKDLOOAPIO PFDDBFBACEP, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B050", Offset = "0x3C79850", VA = "0x183C7B050", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CFKDLOOAPIO PFDDBFBACEP, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A750", Offset = "0x3C78F50", VA = "0x183C7A750", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CFKDLOOAPIO PFDDBFBACEP, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3C79E00", Offset = "0x3C78600", VA = "0x183C79E00", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFKDLOOAPIO PFDDBFBACEP, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3C78F40", Offset = "0x3C77740", VA = "0x183C78F40", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFKDLOOAPIO PFDDBFBACEP, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x80DFD10", Offset = "0x80DE510", VA = "0x1880DFD10")]
		public void RpcAllBuffered(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3C80690", Offset = "0x3C7EE90", VA = "0x183C80690")]
		public void RpcAllBuffered<T1>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3C80000", Offset = "0x3C7E800", VA = "0x183C80000")]
		public void RpcAllBuffered<T1, T2>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FC80", Offset = "0x3C7E480", VA = "0x183C7FC80")]
		public void RpcAllBuffered<T1, T2, T3>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F8B0", Offset = "0x3C7E0B0", VA = "0x183C7F8B0")]
		public void RpcAllBuffered<T1, T2, T3, T4>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F240", Offset = "0x3C7DA40", VA = "0x183C7F240")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E860", Offset = "0x3C7D060", VA = "0x183C7E860")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E2D0", Offset = "0x3C7CAD0", VA = "0x183C7E2D0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D670", Offset = "0x3C7BE70", VA = "0x183C7D670")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CC10", Offset = "0x3C7B410", VA = "0x183C7CC10")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CFKDLOOAPIO PFDDBFBACEP, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C4A0", Offset = "0x3C7ACA0", VA = "0x183C7C4A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CFKDLOOAPIO PFDDBFBACEP, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B8B0", Offset = "0x3C7A0B0", VA = "0x183C7B8B0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CFKDLOOAPIO PFDDBFBACEP, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3C7ABD0", Offset = "0x3C793D0", VA = "0x183C7ABD0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CFKDLOOAPIO PFDDBFBACEP, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3C79460", Offset = "0x3C77C60", VA = "0x183C79460")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFKDLOOAPIO PFDDBFBACEP, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3C78500", Offset = "0x3C76D00", VA = "0x183C78500")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFKDLOOAPIO PFDDBFBACEP, DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x80DFDB0", Offset = "0x80DE5B0", VA = "0x1880DFDB0", Slot = "204")]
		public void RpcAllBuffered(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3C80450", Offset = "0x3C7EC50", VA = "0x183C80450", Slot = "205")]
		public void RpcAllBuffered<T1>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3C802E0", Offset = "0x3C7EAE0", VA = "0x183C802E0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FE40", Offset = "0x3C7E640", VA = "0x183C7FE40", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F490", Offset = "0x3C7DC90", VA = "0x183C7F490", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EFF0", Offset = "0x3C7D7F0", VA = "0x183C7EFF0", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EB00", Offset = "0x3C7D300", VA = "0x183C7EB00", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DFE0", Offset = "0x3C7C7E0", VA = "0x183C7DFE0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D9B0", Offset = "0x3C7C1B0", VA = "0x183C7D9B0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C880", Offset = "0x3C7B080", VA = "0x183C7C880", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CFKDLOOAPIO PFDDBFBACEP, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BCE0", Offset = "0x3C7A4E0", VA = "0x183C7BCE0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CFKDLOOAPIO PFDDBFBACEP, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B480", Offset = "0x3C79C80", VA = "0x183C7B480", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CFKDLOOAPIO PFDDBFBACEP, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A2D0", Offset = "0x3C78AD0", VA = "0x183C7A2D0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CFKDLOOAPIO PFDDBFBACEP, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3C79930", Offset = "0x3C78130", VA = "0x183C79930", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFKDLOOAPIO PFDDBFBACEP, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3C78A20", Offset = "0x3C77220", VA = "0x183C78A20", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFKDLOOAPIO PFDDBFBACEP, DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x80E1480", Offset = "0x80DFC80", VA = "0x1880E1480", Slot = "219")]
		public void RpcOthersBuffered(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.ECCAKPAJDHF LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3CD00C0", Offset = "0x3CCE8C0", VA = "0x183CD00C0", Slot = "220")]
		public void RpcOthersBuffered<T1>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.FNCEODEPAGE<T1> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFD10", Offset = "0x3CCE510", VA = "0x183CCFD10", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HHIAGACDKOO<T1, T2> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF6B0", Offset = "0x3CCDEB0", VA = "0x183CCF6B0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HELNCACANII<T1, T2, T3> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF2E0", Offset = "0x3CCDAE0", VA = "0x183CCF2E0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, T4> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC70", Offset = "0x3CCD470", VA = "0x183CCEC70", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, T5> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE290", Offset = "0x3CCCA90", VA = "0x183CCE290", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, T6> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD720", Offset = "0x3CCBF20", VA = "0x183CCD720", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, T7> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD0A0", Offset = "0x3CCB8A0", VA = "0x183CCD0A0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, T8> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC9D0", Offset = "0x3CCB1D0", VA = "0x183CCC9D0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, T9> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBAF0", Offset = "0x3CCA2F0", VA = "0x183CCBAF0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CFKDLOOAPIO PFDDBFBACEP, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAA80", Offset = "0x3CC9280", VA = "0x183CCAA80", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CFKDLOOAPIO PFDDBFBACEP, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA600", Offset = "0x3CC8E00", VA = "0x183CCA600", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CFKDLOOAPIO PFDDBFBACEP, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9830", Offset = "0x3CC8030", VA = "0x183CC9830", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFKDLOOAPIO PFDDBFBACEP, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC070", Offset = "0x3CDA870", VA = "0x183CDC070", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFKDLOOAPIO PFDDBFBACEP, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x80E15C0", Offset = "0x80DFDC0", VA = "0x1880E15C0")]
		public void RpcOthersBuffered(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.FNCEODEPAGE<AKPFKMFKLAA> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFE80", Offset = "0x3CCE680", VA = "0x183CCFE80")]
		public void RpcOthersBuffered<T1>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HHIAGACDKOO<T1, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFA30", Offset = "0x3CCE230", VA = "0x183CCFA30")]
		public void RpcOthersBuffered<T1, T2>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HELNCACANII<T1, T2, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF870", Offset = "0x3CCE070", VA = "0x183CCF870")]
		public void RpcOthersBuffered<T1, T2, T3>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEEC0", Offset = "0x3CCD6C0", VA = "0x183CCEEC0")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEA20", Offset = "0x3CCD220", VA = "0x183CCEA20")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDFF0", Offset = "0x3CCC7F0", VA = "0x183CCDFF0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDD00", Offset = "0x3CCC500", VA = "0x183CCDD00")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCD60", Offset = "0x3CCB560", VA = "0x183CCCD60")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, AKPFKMFKLAA> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC640", Offset = "0x3CCAE40", VA = "0x183CCC640")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CFKDLOOAPIO PFDDBFBACEP, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB710", Offset = "0x3CC9F10", VA = "0x183CCB710")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CFKDLOOAPIO PFDDBFBACEP, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAEB0", Offset = "0x3CC96B0", VA = "0x183CCAEB0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CFKDLOOAPIO PFDDBFBACEP, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9D00", Offset = "0x3CC8500", VA = "0x183CC9D00")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CFKDLOOAPIO PFDDBFBACEP, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCAB0", Offset = "0x3CDB2B0", VA = "0x183CDCAB0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFKDLOOAPIO PFDDBFBACEP, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3CDBB50", Offset = "0x3CDA350", VA = "0x183CDBB50")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFKDLOOAPIO PFDDBFBACEP, DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x80E1520", Offset = "0x80DFD20", VA = "0x1880E1520", Slot = "234")]
		public void RpcOthersBuffered(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.FNCEODEPAGE<ACNLMKJJPMB> LMGEPDDDDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFFA0", Offset = "0x3CCE7A0", VA = "0x183CCFFA0", Slot = "235")]
		public void RpcOthersBuffered<T1>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HHIAGACDKOO<T1, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFBA0", Offset = "0x3CCE3A0", VA = "0x183CCFBA0", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HELNCACANII<T1, T2, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF4F0", Offset = "0x3CCDCF0", VA = "0x183CCF4F0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KGCNKPPJNHA<T1, T2, T3, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF0D0", Offset = "0x3CCD8D0", VA = "0x183CCF0D0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.LDBMLBLFLDJ<T1, T2, T3, T4, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE7D0", Offset = "0x3CCCFD0", VA = "0x183CCE7D0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HNAOKGMDKJG<T1, T2, T3, T4, T5, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE530", Offset = "0x3CCCD30", VA = "0x183CCE530", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.HABHIFIFGBC<T1, T2, T3, T4, T5, T6, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDA10", Offset = "0x3CCC210", VA = "0x183CCDA10", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.EHLOHGNBAFN<T1, T2, T3, T4, T5, T6, T7, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD3E0", Offset = "0x3CCBBE0", VA = "0x183CCD3E0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CFKDLOOAPIO PFDDBFBACEP, CDAPLGKCOMB.KILNIIIJMJC<T1, T2, T3, T4, T5, T6, T7, T8, ACNLMKJJPMB> LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC2B0", Offset = "0x3CCAAB0", VA = "0x183CCC2B0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CFKDLOOAPIO PFDDBFBACEP, JPEHLKKJJKA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBED0", Offset = "0x3CCA6D0", VA = "0x183CCBED0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CFKDLOOAPIO PFDDBFBACEP, JKNAJBPAJFO LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB2E0", Offset = "0x3CC9AE0", VA = "0x183CCB2E0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CFKDLOOAPIO PFDDBFBACEP, GHJJNDLODEL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA180", Offset = "0x3CC8980", VA = "0x183CCA180", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CFKDLOOAPIO PFDDBFBACEP, FJMDIBKPCAL LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9360", Offset = "0x3CC7B60", VA = "0x183CC9360", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFKDLOOAPIO PFDDBFBACEP, KNLJOOKFKOD LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC590", Offset = "0x3CDAD90", VA = "0x183CDC590", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFKDLOOAPIO PFDDBFBACEP, DBIOIELAIMA LMGEPDDDDPA, T1 ICCFEABGHFO, T2 IIHEHOOHIEN, T3 MAADCENNJCN, T4 FLABGELNNFD, T5 HOIIFGCCDIL, T6 ONCMKPEMDPL, T7 LJNOAIDAFFH, T8 GOIAPDLJCEL, T9 HFJFKPGIBMH, T10 KMJJPLGFPAA, T11 EDDEGCOOKMB, T12 PDLCPBECONA, T13 DHPCFDBFGPL, T14 AFMEIIALJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x80DDAF0", Offset = "0x80DC2F0", VA = "0x1880DDAF0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x80DDD00", Offset = "0x80DC500", VA = "0x1880DDD00", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1EC08D0", Offset = "0x1EBF0D0", VA = "0x181EC08D0")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CJNBHGINNPK
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x80C4A60", Offset = "0x80C3260", VA = "0x1880C4A60")]
	private static bool AILIECKHFAA(ViewId EBHOIBHGECB, [Out] RRNetworkView KBMPEIPJGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x37B8890", Offset = "0x37B7090", VA = "0x1837B8890")]
	[CanBeNull]
	public static T BDKFGNMJHIJ<T>(this ViewId HEFGNKGLBJE)
	{
		return (T)null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class FLCAODCHFHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public EIGONBNGIIK[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public FLCAODCHFHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x80C8420", Offset = "0x80C6C20", VA = "0x1880C8420")]
			internal int FKPLBDOKLCO(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x80C84A0", Offset = "0x80C6CA0", VA = "0x1880C84A0")]
			internal void HMLGAAIGFNN(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly BMELPJIFPCL GLHOMCPEEHH;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static EIGONBNGIIK[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		internal int EPKNIAGHALN;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x80E2EC0", Offset = "0x80E16C0", VA = "0x1880E2EC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x80E34B0", Offset = "0x80E1CB0", VA = "0x1880E34B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x80E3860", Offset = "0x80E2060", VA = "0x1880E3860")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x80E38D0", Offset = "0x80E20D0", VA = "0x1880E38D0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x80E2D60", Offset = "0x80E1560", VA = "0x1880E2D60")]
		private void AHJHHAGAOLE(EIGONBNGIIK KFJHMGCHPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x80E2D60", Offset = "0x80E1560", VA = "0x1880E2D60")]
		private void DIPJLEHJBLP(EIGONBNGIIK IMKKGPDEFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x80E32E0", Offset = "0x80E1AE0", VA = "0x1880E32E0")]
		private void JOJKIHKMAAN(EIGONBNGIIK CBCINDIMJOG, IDictionary<object, object> HKAIOMBHIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x80E2D70", Offset = "0x80E1570", VA = "0x1880E2D70")]
		public static void AssignPlayerNumbers(int PLFOPONJBHE, int ODFGOJGJKNG, Func<int, int> MHDOJACELMI, Action<int, int> CJIFGGBMLOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x80E3970", Offset = "0x80E2170", VA = "0x1880E3970")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x80E33C0", Offset = "0x80E1BC0", VA = "0x1880E33C0")]
		private void LAGELJEGHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA39740", Offset = "0xA37F40", VA = "0x180A39740")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PHLPLELOEAM
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x80DBFC0", Offset = "0x80DA7C0", VA = "0x1880DBFC0")]
	public static int IIKNNICDFAO(this EIGONBNGIIK OINLJEGCCDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x80DC160", Offset = "0x80DA960", VA = "0x1880DC160")]
	public static void LFKFALAPDNF(this EIGONBNGIIK OINLJEGCCDI, int HLDDECJEFAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KMEMGMPDEHH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void MNBMEFNLGLF(Hashtable JKBGANBHBMG);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void AOHJJPANPJK(EIGONBNGIIK OINLJEGCCDI, Hashtable JKBGANBHBMG);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event MNBMEFNLGLF MHEMCMAJJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x80DA8A0", Offset = "0x80D90A0", VA = "0x1880DA8A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x80DAAE0", Offset = "0x80D92E0", VA = "0x1880DAAE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event MNBMEFNLGLF NDCFGFDEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x80DAC60", Offset = "0x80D9460", VA = "0x1880DAC60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x80DA960", Offset = "0x80D9160", VA = "0x1880DA960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event AOHJJPANPJK PKFAFAJJGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x80DAD20", Offset = "0x80D9520", VA = "0x1880DAD20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x80DADE0", Offset = "0x80D95E0", VA = "0x1880DADE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event AOHJJPANPJK FNIAFDDLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x80DABA0", Offset = "0x80D93A0", VA = "0x1880DABA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x80DAA20", Offset = "0x80D9220", VA = "0x1880DAA20")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class GKMEIFBJHEN
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static int BMBBJEHDGBD;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int EFKKPEIGEJD;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int MDBGLMNNNEB;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x80C9580", Offset = "0x80C7D80", VA = "0x1880C9580")]
	public static void HODDKCINPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x80C94A0", Offset = "0x80C7CA0", VA = "0x1880C94A0")]
	public static void FJBDNNJCCFJ(int[] HDLGBEIBAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x80C9200", Offset = "0x80C7A00", VA = "0x1880C9200")]
	public static int AGOBKGJKEGN(int OKBBFDAMBEO, bool MBAMEPAOIHD = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(INEJOBMMKOJ), new string[] { })]
public class INEJOBMMKOJ : AHOMPNPPOHL, EGBPELOCMDI, DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly Hashtable FDPJNICBIGF;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable CKCBONIPBFO;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable PPPNACMBPMG;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly IKNIODLHFBI JIPHKHBJEHL;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly IKNIODLHFBI DOKNDCLLFAL;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly IKNIODLHFBI NBPLCAAJAMM;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly IKNIODLHFBI HACJJLAPKNE;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly IKNIODLHFBI NKGCLIECEDA;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int HFKJIKHGKJP;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x80D7D70", Offset = "0x80D6570", VA = "0x1880D7D70", Slot = "18")]
	public void HAMEHJBFDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x80D7520", Offset = "0x80D5D20", VA = "0x1880D7520", Slot = "19")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x80D7A80", Offset = "0x80D6280", VA = "0x1880D7A80", Slot = "4")]
	public bool EMLGNAJAMHK(DKBEJJEFNCK JCPNJLMMOLN, bool HCBBMPKKMCB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x80D8DC0", Offset = "0x80D75C0", VA = "0x1880D8DC0", Slot = "5")]
	public int MFNAGHHIAKL(DKBEJJEFNCK[] IABGAPCJMBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x80D79F0", Offset = "0x80D61F0", VA = "0x1880D79F0", Slot = "6")]
	public bool ELKJBKDGNIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x80D8C30", Offset = "0x80D7430", VA = "0x1880D8C30", Slot = "7")]
	public bool KHBDDAEEOKB(int HEFGNKGLBJE, int FDPIKKAKNIC, bool DNGNBAJCLMC, GameObject EMOLHEPHCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x80D9710", Offset = "0x80D7F10", VA = "0x1880D9710", Slot = "8")]
	public void PJMFPMHDMDB(int FDPIKKAKNIC, [Optional] int? AJOOBFJKIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x80D7F30", Offset = "0x80D6730", VA = "0x1880D7F30", Slot = "9")]
	public bool IIDPKHBKAPN(IIBEMPIBOEO NPLHFNMEMBD, [Out] DKBEJJEFNCK ILMCHJANNEM, bool PPGKJMKGMBE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x80D88A0", Offset = "0x80D70A0", VA = "0x1880D88A0", Slot = "10")]
	public bool JPMCJMDDONA(IIBEMPIBOEO NPLHFNMEMBD, [Out] int BGBAHFKHLPL, [Out] DKBEJJEFNCK[] IABGAPCJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x80D8780", Offset = "0x80D6F80", VA = "0x1880D8780", Slot = "11")]
	public bool JJGADCMAOOP(IIBEMPIBOEO NPLHFNMEMBD, [Out] int FDPIKKAKNIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x80D76A0", Offset = "0x80D5EA0", VA = "0x1880D76A0", Slot = "12")]
	public void COKICBACPIA(IIBEMPIBOEO NPLHFNMEMBD, [Out] int OOPDCJLDMBJ, [Out] int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x80D9180", Offset = "0x80D7980", VA = "0x1880D9180", Slot = "13")]
	public void OFMBLNIILHP(int BGBAHFKHLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x80D7E10", Offset = "0x80D6610", VA = "0x1880D7E10", Slot = "14")]
	public void HHMGNEJPEMO(int BGBAHFKHLPL, int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x80D8B80", Offset = "0x80D7380", VA = "0x1880D8B80", Slot = "15")]
	public void KBAANJJMLHN(int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x80D7CA0", Offset = "0x80D64A0", VA = "0x1880D7CA0", Slot = "16")]
	public void GLIIKPFFCLB(int[] JCMNGOPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x80D7880", Offset = "0x80D6080", VA = "0x1880D7880", Slot = "17")]
	public void DOPIHBFOECJ(int BGBAHFKHLPL, int FDPIKKAKNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x80D92E0", Offset = "0x80D7AE0", VA = "0x1880D92E0")]
	private static void PFNOONKJIPE(DKBEJJEFNCK JCPNJLMMOLN, Hashtable LMOGGHBNICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x80D80A0", Offset = "0x80D68A0", VA = "0x1880D80A0")]
	private static bool IIDPKHBKAPN(Hashtable LMOGGHBNICE, EIGONBNGIIK GIJBBJGBHCJ, [Out] DKBEJJEFNCK ILMCHJANNEM, bool PPGKJMKGMBE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x80D7BB0", Offset = "0x80D63B0", VA = "0x1880D7BB0")]
	private static bool GEMAHPAEGCK(int FDPIKKAKNIC, DKBEJJEFNCK LMOGGHBNICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x80D75C0", Offset = "0x80D5DC0", VA = "0x1880D75C0")]
	private static int BODALHEBAOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public INEJOBMMKOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(FMIPHKPOPLI), new string[] { })]
public class FMIPHKPOPLI : FKHMCKMLEDD, EGBPELOCMDI, DEPOIAMCLIH
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static Hashtable IIPEKCKDJAB;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable KMGMABNNPDC;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static IKNIODLHFBI CDBKOINFDOJ;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly IKNIODLHFBI NAOHFLKALHF;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x80C8620", Offset = "0x80C6E20", VA = "0x1880C8620", Slot = "8")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x80C8FB0", Offset = "0x80C77B0", VA = "0x1880C8FB0", Slot = "7")]
	public void HAMEHJBFDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x80C8530", Offset = "0x80C6D30", VA = "0x1880C8530", Slot = "4")]
	public void AHPLKOAGDDK(ViewId HEFGNKGLBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x80C8C70", Offset = "0x80C7470", VA = "0x1880C8C70", Slot = "5")]
	public bool EBCLBEJGFCA(IIBEMPIBOEO NPLHFNMEMBD, [Out] ViewId HEFGNKGLBJE, [Out] string PICMFECJKDH, [Out] int DGFKOBCJLIP, [Out] object[] FKIDLMLIFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x80C86C0", Offset = "0x80C6EC0", VA = "0x1880C86C0", Slot = "6")]
	public void CKJKJOGJPKD(ViewId KBMPEIPJGHK, string PICMFECJKDH, MLCIMENIGOO ONBJOFHAOIN, EIGONBNGIIK OINLJEGCCDI, GMHJIAHJCPH FOIOOGEDCJG, object[] JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FMIPHKPOPLI()
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
