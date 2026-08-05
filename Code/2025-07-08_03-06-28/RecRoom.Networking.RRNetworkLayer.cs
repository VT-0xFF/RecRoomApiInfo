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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81F2EA0", Offset = "0x81F1CA0", VA = "0x1881F2EA0", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x22D3BE0", Offset = "0x22D29E0", VA = "0x1822D3BE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8200560", Offset = "0x81FF360", VA = "0x188200560")]
		private void AFKHLAMEPCM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8200BB0", Offset = "0x81FF9B0", VA = "0x188200BB0")]
		private void DBFIEBKHIEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8200E30", Offset = "0x81FFC30", VA = "0x188200E30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8200EE0", Offset = "0x81FFCE0", VA = "0x188200EE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGFKFFBAMFL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PHLHEDGDBJO HKDEGGMBIMJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PHLHEDGDBJO AGOJIEEFOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81F8520", Offset = "0x81F7320", VA = "0x1881F8520")]
		get
		{
			return default(PHLHEDGDBJO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DGONNPOHPBC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView CGEBGCELNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NKOKNJFKJGA DCIKPEKPEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EEJINDEGOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(FEKGHFHDHAB DBBCLDIEBFG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(JCLGCJKMNJI MDHOEKKPKHF, FEKGHFHDHAB DBBCLDIEBFG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface PJKBBHCPECG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CKILLEHMHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GODKLMNPPJF(JCLGCJKMNJI MDHOEKKPKHF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIDJPDKJMHF(JCLGCJKMNJI MDHOEKKPKHF, FEKGHFHDHAB DBBCLDIEBFG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface DJPLPDJDMDG : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIMDKAKGPHI(DGONNPOHPBC NLGJOEGNKNG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDMNNAOCPHL(DGONNPOHPBC NLGJOEGNKNG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GACDMJAOKOI(GOKBCIDGKFN.EECONGLOCEK NMBPHJEGCLB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBNIOPPCDHM();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOFCACNINJF(object IHKPBFJODHM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NKOKNJFKJGA : byte
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
public struct JCLGCJKMNJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int MELALKCBPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint PPOGGINPFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public double ODNOBGJPNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int FMKGOFNOFAB;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CKBDMKODLFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<(ViewId, NKOKNJFKJGA), PJKBBHCPECG> BAAJBEEECDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly List<DGONNPOHPBC> LDCJALGCBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HashSet<(ViewId, NKOKNJFKJGA)> KIOIECPCGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int HOCPEFIBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public bool EKEBHDLGILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private GOKBCIDGKFN.EECONGLOCEK NMBPHJEGCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MemoryStream OBFAEIENLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly FEKGHFHDHAB KPNIIONJIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FEKGHFHDHAB JNAJCOGHHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private byte[] GJJFOKCKLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float FKHAHKCFKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int IOMPKOFBEDL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81E2390", Offset = "0x81E1190", VA = "0x1881E2390")]
	public CKBDMKODLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81E1810", Offset = "0x81E0610", VA = "0x1881E1810")]
	public void GACDMJAOKOI(GOKBCIDGKFN.EECONGLOCEK NMBPHJEGCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81E0EE0", Offset = "0x81DFCE0", VA = "0x1881E0EE0")]
	public void BBNIOPPCDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x81E1410", Offset = "0x81E0210", VA = "0x1881E1410")]
	public void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81E1E70", Offset = "0x81E0C70", VA = "0x1881E1E70")]
	public bool OLHPIGGMIDE(DGONNPOHPBC NLGJOEGNKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x81E0F30", Offset = "0x81DFD30", VA = "0x1881E0F30")]
	public bool EBNLHEFHMEO(DGONNPOHPBC NLGJOEGNKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x81E1BF0", Offset = "0x81E09F0", VA = "0x1881E1BF0")]
	private PJKBBHCPECG LPAAGBOPMOD(ViewId JGOGKOHBDFC, NKOKNJFKJGA FCOJNLDPAAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81E0ED0", Offset = "0x81DFCD0", VA = "0x1881E0ED0")]
	public void APKPLEKODKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81E1E10", Offset = "0x81E0C10", VA = "0x1881E1E10")]
	private void MOOELFKKBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81E17F0", Offset = "0x81E05F0", VA = "0x1881E17F0")]
	private void FMBGFADFJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81E1060", Offset = "0x81DFE60", VA = "0x1881E1060")]
	public bool EKMCGJHHIGH(FastBufferWriter JAIJDFCBLCH, int AHDAJFEIPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81E1830", Offset = "0x81E0630", VA = "0x1881E1830")]
	public void KIDJPDKJMHF(JCLGCJKMNJI MDHOEKKPKHF, FastBufferReader DGMHJDFFMEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class NOJKFGLPEMP : PJKBBHCPECG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private DGONNPOHPBC OCAGDGJHIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private uint AALOGDBMIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int HEKIDGHHNCN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CKILLEHMHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public NOJKFGLPEMP(DGONNPOHPBC OCAGDGJHIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81F7430", Offset = "0x81F6230", VA = "0x1881F7430", Slot = "5")]
	public bool GODKLMNPPJF(JCLGCJKMNJI MDHOEKKPKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81F7540", Offset = "0x81F6340", VA = "0x1881F7540", Slot = "6")]
	public void KIDJPDKJMHF(JCLGCJKMNJI MDHOEKKPKHF, FEKGHFHDHAB DBBCLDIEBFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HHCCBILHDEA : PJKBBHCPECG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GOKBCIDGKFN.EECONGLOCEK NMBPHJEGCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ViewId JGOGKOHBDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int HEKIDGHHNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private uint AALOGDBMIGN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CKILLEHMHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B8CC20", Offset = "0x1B8BA20", VA = "0x181B8CC20")]
	public HHCCBILHDEA(ViewId JGOGKOHBDFC, GOKBCIDGKFN.EECONGLOCEK NMBPHJEGCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81EE3A0", Offset = "0x81ED1A0", VA = "0x1881EE3A0", Slot = "5")]
	public bool GODKLMNPPJF(JCLGCJKMNJI MDHOEKKPKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81EE3E0", Offset = "0x81ED1E0", VA = "0x1881EE3E0", Slot = "6")]
	public void KIDJPDKJMHF(JCLGCJKMNJI MDHOEKKPKHF, FEKGHFHDHAB DBBCLDIEBFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KHDFBAIMDCJ
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81F01E0", Offset = "0x81EEFE0", VA = "0x1881F01E0")]
	public static void NEJFHFKCOKJ(this EKOKDMBBAMI LMLJEKBBPAK, FEKGHFHDHAB NIPCFNIPIKB, ViewId IEOOLFDDEEF, bool HNACNMNDNKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81EFB70", Offset = "0x81EE970", VA = "0x1881EFB70")]
	public static void EKFDHABLEPH(this EKOKDMBBAMI LMLJEKBBPAK, FEKGHFHDHAB NIPCFNIPIKB, bool HNACNMNDNKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81F0070", Offset = "0x81EEE70", VA = "0x1881F0070")]
	public static EKOKDMBBAMI KIDJPDKJMHF(FEKGHFHDHAB NIPCFNIPIKB, ViewId IEOOLFDDEEF, bool HNACNMNDNKA = true)
	{
		return default(EKOKDMBBAMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81F03A0", Offset = "0x81EF1A0", VA = "0x1881F03A0")]
	public static void NGADEDOAAKI(this EKOKDMBBAMI LMLJEKBBPAK, FEKGHFHDHAB NIPCFNIPIKB, bool HNACNMNDNKA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(DJPLPDJDMDG), new string[] { })]
public class FLPKBHPMFDJ : DJPLPDJDMDG, INetworkUpdateSystem, NHPEKAEFMLG, GNJFBAIKFDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly PHLHEDGDBJO AJOPENHPJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private CKBDMKODLFI ODHCLLBBEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private uint MDOCIAMMBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float KDMDDODLLHI;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81EC460", Offset = "0x81EB260", VA = "0x1881EC460", Slot = "4")]
	public void HIMDKAKGPHI(DGONNPOHPBC NLGJOEGNKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81EC5E0", Offset = "0x81EB3E0", VA = "0x1881EC5E0", Slot = "5")]
	public void NDMNNAOCPHL(DGONNPOHPBC NLGJOEGNKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81EBF50", Offset = "0x81EAD50", VA = "0x1881EBF50", Slot = "10")]
	public void EDDKJIHBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x81EC7E0", Offset = "0x81EB5E0", VA = "0x1881EC7E0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage CGLAMPPLJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81EB800", Offset = "0x81EA600", VA = "0x1881EB800")]
	private void AKLAKNIPANK(uint AMCJOODLFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81EC430", Offset = "0x81EB230", VA = "0x1881EC430", Slot = "6")]
	public void GACDMJAOKOI(GOKBCIDGKFN.EECONGLOCEK NMBPHJEGCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81EBDD0", Offset = "0x81EABD0", VA = "0x1881EBDD0", Slot = "7")]
	public void BBNIOPPCDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81EC580", Offset = "0x81EB380", VA = "0x1881EC580", Slot = "8")]
	public void KOFCACNINJF(object BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81EC0B0", Offset = "0x81EAEB0", VA = "0x1881EC0B0")]
	private void FMGPJJJGALI(BNHAMMLICHE BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81EBE30", Offset = "0x81EAC30", VA = "0x1881EBE30", Slot = "11")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x81EC860", Offset = "0x81EB660", VA = "0x1881EC860")]
	public FLPKBHPMFDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FPLLMOFEBOK : PJKBBHCPECG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private float OLFAGLBABAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HEKIDGHHNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private uint AALOGDBMIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly NKOKNJFKJGA IJMNFNJBMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public JCLGCJKMNJI LPLOMGAKOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MCKOPCADHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte[] MCHMILFDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private JCLGCJKMNJI DPEBJECFFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int CJJNNNPLHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private byte[] DJMCFCPNPBB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CKILLEHMHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81ECE10", Offset = "0x81EBC10", VA = "0x1881ECE10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81ECE40", Offset = "0x81EBC40", VA = "0x1881ECE40")]
	public FPLLMOFEBOK(NKOKNJFKJGA IJMNFNJBMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81ECB10", Offset = "0x81EB910", VA = "0x1881ECB10", Slot = "5")]
	public bool GODKLMNPPJF(JCLGCJKMNJI MDHOEKKPKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81ECB50", Offset = "0x81EB950", VA = "0x1881ECB50", Slot = "6")]
	public void KIDJPDKJMHF(JCLGCJKMNJI MDHOEKKPKHF, FEKGHFHDHAB DBBCLDIEBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x81ECD00", Offset = "0x81EBB00", VA = "0x1881ECD00")]
	internal NOJKFGLPEMP PBOJOPOEGGF(DGONNPOHPBC NLGJOEGNKNG, FEKGHFHDHAB NIPCFNIPIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x81EC940", Offset = "0x81EB740", VA = "0x1881EC940")]
	private static void AEGJDFJKOAB(NOJKFGLPEMP BPPKGNNLOKF, FEKGHFHDHAB NIPCFNIPIKB, JCLGCJKMNJI IGBCHKILJEH, byte[] NHMENHDBHGG, int ONKBKDKMEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(BKALHCFGBBL), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class BKALHCFGBBL : FJBJAPEAIKB, NHPEKAEFMLG, GNJFBAIKFDH
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable IFFNNLCHKJN;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable DCCBABHPAHN;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly Hashtable PJHHKOAFCLI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly EIIAJLFMPKP FKNPENPBONA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly EIIAJLFMPKP OLANNBBFGGN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly EIIAJLFMPKP NADCBFHIEOP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly EIIAJLFMPKP GCLODPCFPDL;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly EIIAJLFMPKP HHNJOJMEMPE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int IHEEDCGCENC;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x81DFAD0", Offset = "0x81DE8D0", VA = "0x1881DFAD0", Slot = "4")]
	public bool GMANCOEPLLL(OJNEMHDMCGC OAEBFAAHGEJ, bool OLKDDMKGKGN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x81E04D0", Offset = "0x81DF2D0", VA = "0x1881E04D0", Slot = "5")]
	public int LIICFCPHPIJ(OJNEMHDMCGC[] KCLCNGHNCCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x81DF1A0", Offset = "0x81DDFA0", VA = "0x1881DF1A0", Slot = "6")]
	public bool BPKJMKKOBOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x81DF430", Offset = "0x81DE230", VA = "0x1881DF430", Slot = "7")]
	public bool DCIEOFNMBGC(int JGOGKOHBDFC, int BDHGHAPLPLK, bool FKNHIENNAMA, GameObject JLNNGPHDMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x81DF830", Offset = "0x81DE630", VA = "0x1881DF830", Slot = "8")]
	public void FFFGCAKDJII(int BDHGHAPLPLK, [Optional] int? MHIMCDHFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x81DFC10", Offset = "0x81DEA10", VA = "0x1881DFC10", Slot = "9")]
	public bool HDAKIJIALAJ(BNHAMMLICHE IHKPBFJODHM, [Out] OJNEMHDMCGC NJKFOFPCPIG, bool JIHKPEMLEHL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x81DE9B0", Offset = "0x81DD7B0", VA = "0x1881DE9B0", Slot = "10")]
	public bool AFBBKLOGILC(BNHAMMLICHE IHKPBFJODHM, [Out] int GNLHIAIEOJP, [Out] OJNEMHDMCGC[] KCLCNGHNCCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x81DF710", Offset = "0x81DE510", VA = "0x1881DF710", Slot = "11")]
	public bool ELHMIIJMHLA(BNHAMMLICHE IHKPBFJODHM, [Out] int BDHGHAPLPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x81E09F0", Offset = "0x81DF7F0", VA = "0x1881E09F0", Slot = "12")]
	public void NEAOLLGCBEG(BNHAMMLICHE IHKPBFJODHM, [Out] int MLHLNOKBILO, [Out] int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x81E0890", Offset = "0x81DF690", VA = "0x1881E0890", Slot = "13")]
	public void NBMLNIMGIIH(int GNLHIAIEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81DF230", Offset = "0x81DE030", VA = "0x1881DF230", Slot = "14")]
	public void CACCGKPOOLG(int GNLHIAIEOJP, int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81DFA20", Offset = "0x81DE820", VA = "0x1881DFA20", Slot = "15")]
	public void GDADNCJIAND(int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81DEC90", Offset = "0x81DDA90", VA = "0x1881DEC90", Slot = "16")]
	public void AKFDEFNPNDB(int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81E0360", Offset = "0x81DF160", VA = "0x1881E0360", Slot = "17")]
	public void IBOKELBCGON(int GNLHIAIEOJP, int BDHGHAPLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81DED60", Offset = "0x81DDB60", VA = "0x1881DED60")]
	private static void ANDPFFHIHBO(OJNEMHDMCGC OAEBFAAHGEJ, Hashtable BELKBDIIAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81DFD80", Offset = "0x81DEB80", VA = "0x1881DFD80")]
	private static bool HDAKIJIALAJ(Hashtable BELKBDIIAOC, CDKFIILELLC PHAEOJDOJAP, [Out] OJNEMHDMCGC NJKFOFPCPIG, bool JIHKPEMLEHL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81DF350", Offset = "0x81DE150", VA = "0x1881DF350")]
	private static int CPIIKLOOLPA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81DF670", Offset = "0x81DE470", VA = "0x1881DF670", Slot = "18")]
	public void EDDKJIHBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81DF5D0", Offset = "0x81DE3D0", VA = "0x1881DF5D0", Slot = "19")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public BKALHCFGBBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(KBGFIHIIKFP), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KBGFIHIIKFP : HAEEPICGHHB, NHPEKAEFMLG, GNJFBAIKFDH
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable NOPFPKPGAKH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static Hashtable JMBOKCDMPIH;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static EIIAJLFMPKP BEPPIOJKBNI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly EIIAJLFMPKP FODONNLDADP;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x81EEF50", Offset = "0x81EDD50", VA = "0x1881EEF50", Slot = "4")]
	public void HLMKHNDKNPD(ViewId JGOGKOHBDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81EF040", Offset = "0x81EDE40", VA = "0x1881EF040", Slot = "5")]
	public bool ILCKDLHDIJG(BNHAMMLICHE IHKPBFJODHM, [Out] ViewId JGOGKOHBDFC, [Out] string JAHAECILGDJ, [Out] int MILGEGKGJBE, [Out] object[] FLNLCOLLCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x81EF3A0", Offset = "0x81EE1A0", VA = "0x1881EF3A0", Slot = "6")]
	public void KHHOAAMNLGF(ViewId LNFFCKNEJCB, string JAHAECILGDJ, HGHJNEHJPNI MAGHDGOICLH, CDKFIILELLC IFADLDJHCLA, IJKPDLCOMPD AMAFDDKIFIG, object[] OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x81EEE10", Offset = "0x81EDC10", VA = "0x1881EEE10", Slot = "8")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x81EEEB0", Offset = "0x81EDCB0", VA = "0x1881EEEB0", Slot = "7")]
	public void EDDKJIHBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public KBGFIHIIKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HBDNHBMJCIH
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x81ECF00", Offset = "0x81EBD00", VA = "0x1881ECF00")]
	public static CDKFIILELLC HJCOFPMJOAN(this GLHCBKLDIDI DGOGGKOBPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x81ECEB0", Offset = "0x81EBCB0", VA = "0x1881ECEB0")]
	public static GLHCBKLDIDI AKBGFPHEOPG(this CDKFIILELLC IFADLDJHCLA)
	{
		return default(GLHCBKLDIDI);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, ONIPAMJOINA, JNHEPPEOGBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<IPKNNHNOELH> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId AAJNFEAFNCM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x81F8CF0", Offset = "0x81F7AF0", VA = "0x1881F8CF0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId DPPHEGJKDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x81F8CF0", Offset = "0x81F7AF0", VA = "0x1881F8CF0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView JPJFDCGGAFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x81F8D70", Offset = "0x81F7B70", VA = "0x1881F8D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView CGEBGCELNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x81F8D70", Offset = "0x81F7B70", VA = "0x1881F8D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CDKFIILELLC HANEPOCOCOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x81F8E70", Offset = "0x81F7C70", VA = "0x1881F8E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CDKFIILELLC PBHKHJPMFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x81F91D0", Offset = "0x81F7FD0", VA = "0x1881F91D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NHIOAFMOPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x81F8FD0", Offset = "0x81F7DD0", VA = "0x1881F8FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BLGOBCIKNEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x81F9140", Offset = "0x81F7F40", VA = "0x1881F9140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GCECOPNIBPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x81F8C20", Offset = "0x81F7A20", VA = "0x1881F8C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NFPOECFHBJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x81F8F00", Offset = "0x81F7D00", VA = "0x1881F8F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PCDGJHLIIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x81F8C20", Offset = "0x81F7A20", VA = "0x1881F8C20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool GCDODLLDCJH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x81F8CA0", Offset = "0x81F7AA0", VA = "0x1881F8CA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string GHODDDNKMEG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x81F8DE0", Offset = "0x81F7BE0", VA = "0x1881F8DE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool LBHAJMONDGP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x81F8BA0", Offset = "0x81F79A0", VA = "0x1881F8BA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<CDKFIILELLC> LIECLLGANMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x81F8A70", Offset = "0x81F7870", VA = "0x1881F8A70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x81F9260", Offset = "0x81F8060", VA = "0x1881F9260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81F89D0", Offset = "0x81F77D0", VA = "0x1881F89D0")]
		public bool WasSpawnedForPlayer(int NBLAILFJFBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7528340", Offset = "0x7527140", VA = "0x187528340")]
		private void OMGJPCBIIPI(RRNetworkView FCNMCCJKGMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81F8600", Offset = "0x81F7400", VA = "0x1881F8600", Slot = "9")]
		public void RegisterDestroyHandler(IPKNNHNOELH IOACPCLMBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81F8800", Offset = "0x81F7600", VA = "0x1881F8800", Slot = "10")]
		public void UnregisterDestroyHandler(IPKNNHNOELH IOACPCLMBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81F85E0", Offset = "0x81F73E0", VA = "0x1881F85E0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HCKHPDFJAEG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void DMJHNOOLPKF([In] OJNEMHDMCGC OAEBFAAHGEJ, bool GFLBPAOCEFL, bool BELKBDIIAOC, bool CMECIAGGAMD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void PKCIPAIICHH(GameObject EJNHDGCJKPM);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void BKNDIBEBGHA(GameObject EJNHDGCJKPM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void NPDNNPFOJFD(RRNetworkView LNFFCKNEJCB, string JAHAECILGDJ, CDKFIILELLC FIHFPAKJDIB, HGHJNEHJPNI? IMBAOPHEODM, bool EOBHMDNKIAC, IJKPDLCOMPD IGCDNMKDJDK, object[] OAEBFAAHGEJ, string PAEKIJDLKPM);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void NGLIHDGNMLG(RRNetworkView LNFFCKNEJCB, string JAHAECILGDJ, CDKFIILELLC FIHFPAKJDIB, HGHJNEHJPNI? IMBAOPHEODM, bool EOBHMDNKIAC, IJKPDLCOMPD IGCDNMKDJDK, object[] OAEBFAAHGEJ, string PAEKIJDLKPM);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void JLEOLDAABLE(RRNetworkView LNFFCKNEJCB, string JAHAECILGDJ, object[] FLNLCOLLCMF, string BAHNFGDNFGI);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void EINHOFJMDJH(RRNetworkView LNFFCKNEJCB, CDKFIILELLC PECNGGGEHEH);

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CompilerGenerated]
	private static PKCIPAIICHH AHFOBFAMKIK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event DMJHNOOLPKF JHAMPHGNLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x81ED0E0", Offset = "0x81EBEE0", VA = "0x1881ED0E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x81ED530", Offset = "0x81EC330", VA = "0x1881ED530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event PKCIPAIICHH EDFFFKPPGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x81ED020", Offset = "0x81EBE20", VA = "0x1881ED020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x81EDAF0", Offset = "0x81EC8F0", VA = "0x1881EDAF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event BKNDIBEBGHA LFGJGPLFAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81ED2F0", Offset = "0x81EC0F0", VA = "0x1881ED2F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81EDD30", Offset = "0x81ECB30", VA = "0x1881EDD30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event BKNDIBEBGHA OPEFMILNEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81EE2E0", Offset = "0x81ED0E0", VA = "0x1881EE2E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x81EDEB0", Offset = "0x81ECCB0", VA = "0x1881EDEB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event NPDNNPFOJFD GIMNGKMOLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x81ED7F0", Offset = "0x81EC5F0", VA = "0x1881ED7F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81ED970", Offset = "0x81EC770", VA = "0x1881ED970")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event NGLIHDGNMLG EAJHMDEKENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81EDC70", Offset = "0x81ECA70", VA = "0x1881EDC70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81ED470", Offset = "0x81EC270", VA = "0x1881ED470")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event JLEOLDAABLE LGCBEONIOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81EDBB0", Offset = "0x81EC9B0", VA = "0x1881EDBB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x81ED730", Offset = "0x81EC530", VA = "0x1881ED730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event EINHOFJMDJH JLINALNFNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x81EDDF0", Offset = "0x81ECBF0", VA = "0x1881EDDF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81ED3B0", Offset = "0x81EC1B0", VA = "0x1881ED3B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event EINHOFJMDJH FJNDGPLEGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81EDA30", Offset = "0x81EC830", VA = "0x1881EDA30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x81ED230", Offset = "0x81EC030", VA = "0x1881ED230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x81ED8B0", Offset = "0x81EC6B0", VA = "0x1881ED8B0")]
	public static void IBKNFDKLILA([In] OJNEMHDMCGC OAEBFAAHGEJ, bool GFLBPAOCEFL, bool BELKBDIIAOC, bool CMECIAGGAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x81EE150", Offset = "0x81ECF50", VA = "0x1881EE150")]
	public static void PABLCINBLDK(GameObject EJNHDGCJKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x81EDF70", Offset = "0x81ECD70", VA = "0x1881EDF70")]
	public static void NLACINPDEAA(GameObject EJNHDGCJKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x81ED1A0", Offset = "0x81EBFA0", VA = "0x1881ED1A0")]
	public static void CLOFACMKBCI(GameObject EJNHDGCJKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x81ECF90", Offset = "0x81EBD90", VA = "0x1881ECF90")]
	public static void AGFMNABAGEC(GameObject EJNHDGCJKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x81EE000", Offset = "0x81ECE00", VA = "0x1881EE000")]
	public static void OEFEIBIMOAI(RRNetworkView LNFFCKNEJCB, string JAHAECILGDJ, CDKFIILELLC FIHFPAKJDIB, HGHJNEHJPNI? IMBAOPHEODM, bool EOBHMDNKIAC, IJKPDLCOMPD IGCDNMKDJDK, object[] OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x81ED5F0", Offset = "0x81EC3F0", VA = "0x1881ED5F0")]
	public static void FLLLHOICCPD(RRNetworkView LNFFCKNEJCB, string JAHAECILGDJ, int OOJLCLENJEB, object[] FLNLCOLLCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x81EE1E0", Offset = "0x81ECFE0", VA = "0x1881EE1E0")]
	public static void PGLINLEACPF(int JGOGKOHBDFC, int DGOGGKOBPII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JNKCPALKKHL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x81EED60", Offset = "0x81EDB60", VA = "0x1881EED60")]
	[CanBeNull]
	private static bool NGHCEBPCHKI(ViewId PPPFBKMGIMA, [Out] RRNetworkView LNFFCKNEJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81EEC80", Offset = "0x81EDA80", VA = "0x1881EEC80")]
	[CanBeNull]
	public static Component HOMEABLIMOJ(this ViewId LNFFCKNEJCB, Type IJGHPBJEGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA690", Offset = "0x3BF9490", VA = "0x183BFA690")]
	[CanBeNull]
	public static T HOMEABLIMOJ<T>(this ViewId LNFFCKNEJCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA690", Offset = "0x3BF9490", VA = "0x183BFA690")]
	[CanBeNull]
	public static T BPHLFGHFPNC<T>(this ViewId LNFFCKNEJCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA6E0", Offset = "0x3BF94E0", VA = "0x183BFA6E0")]
	public static bool JPCCJOFHMGF<T>(this ViewId LNFFCKNEJCB, [Out] T OHLBIIOAJDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x81EEBB0", Offset = "0x81ED9B0", VA = "0x1881EEBB0")]
	[CanBeNull]
	public static RRNetworkView BHMODABOOPI(this ViewId LNFFCKNEJCB)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static RRNetworkHandler GBACACMKFBG;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler ODAOEPEFKDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x81F9390", Offset = "0x81F8190", VA = "0x1881F9390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81F9560", Offset = "0x81F8360", VA = "0x1881F9560")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81F9520", Offset = "0x81F8320", VA = "0x1881F9520")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(DODCDLFJBFC), new string[] { "Photon" })]
public sealed class DODCDLFJBFC : OLJFIKHANHM, NHPEKAEFMLG, GNJFBAIKFDH, PKEJCKJDDMB, AKJPHGCMHJK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DNOPGAAEMGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DNOPGAAEMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x81E2670", Offset = "0x81E1470", VA = "0x1881E2670")]
		internal object EOLGENMADEF((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static PHLHEDGDBJO KPOGHEIEDBH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static PHLHEDGDBJO LPFKBAKAJJC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, HashSet<int>> NOFGABOIJMM;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static Dictionary<int, int> PACKKNLDGEG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<(GameObject GameObject, int ParentCount)> HMIGNEOIINP;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GameObject> BMAENECLAAK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static List<int> CAIBNGKGDGP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<RRNetworkView> LEKLEDFFHJB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly EIIAJLFMPKP GCLODPCFPDL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly EIIAJLFMPKP HHNJOJMEMPE;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x81E6830", Offset = "0x81E5630", VA = "0x1881E6830", Slot = "8")]
	public void EDDKJIHBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x81E64B0", Offset = "0x81E52B0", VA = "0x1881E64B0", Slot = "9")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81E83D0", Offset = "0x81E71D0", VA = "0x1881E83D0", Slot = "10")]
	public void InitExternal(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81E3DD0", Offset = "0x81E2BD0", VA = "0x1881E3DD0", Slot = "11")]
	public void CHLEBEMPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81E3660", Offset = "0x81E2460", VA = "0x1881E3660")]
	private void BBHFFBHNMIM(ILCNLGIIPEB GLGGGCKLONE, ILCNLGIIPEB EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81E9C70", Offset = "0x81E8A70", VA = "0x1881E9C70")]
	private void NDBPBEHEGEK(CPJLNGDAGBF JBKAMLJMIOF, CPJLNGDAGBF IDIBODEMNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x81EA030", Offset = "0x81E8E30", VA = "0x1881EA030")]
	public GameObject OMOKKMOAHBC(string GGDFKFACHGG, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, Vector3 AMJKMJIBGNI, ViewId JGOGKOHBDFC, PIFBFEKACLF OAEBFAAHGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81E7570", Offset = "0x81E6370", VA = "0x1881E7570")]
	public GameObject GNCJCNJGCGJ(string GGDFKFACHGG, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float AMJKMJIBGNI, object[] OAEBFAAHGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81E6FE0", Offset = "0x81E5DE0", VA = "0x1881E6FE0")]
	public GameObject FMAGAIOLDHB(string GGDFKFACHGG, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, Vector3 AMJKMJIBGNI, ViewId LNFFCKNEJCB, PIFBFEKACLF OAEBFAAHGEJ, bool CMECIAGGAMD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x81E9BE0", Offset = "0x81E89E0", VA = "0x1881E9BE0")]
	public GameObject LLOGKFCMAIL(OJNEMHDMCGC OAEBFAAHGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x81E7EA0", Offset = "0x81E6CA0", VA = "0x1881E7EA0", Slot = "6")]
	public void HLLMGFNAKLD(GameObject EJNHDGCJKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x81E7EB0", Offset = "0x81E6CB0", VA = "0x1881E7EB0")]
	public void HNAEHDGLGIO(GameObject JLNNGPHDMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x81EA210", Offset = "0x81E9010", VA = "0x1881EA210", Slot = "7")]
	public void PAKJCBDJBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x81E80A0", Offset = "0x81E6EA0", VA = "0x1881E80A0", Slot = "4")]
	public GameObject[] INAOAKLEKAJ(IList<GCIJFIKDGLB> AEACCKLIIMF, bool FIFFPJJEKOG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x81E9010", Offset = "0x81E7E10", VA = "0x1881E9010", Slot = "5")]
	public void JPDIKIBCLAB(List<GameObject> EHPJPDMDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x81E7F20", Offset = "0x81E6D20", VA = "0x1881E7F20")]
	public void HPCAFIAFMHH(GameObject JLNNGPHDMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x81E7270", Offset = "0x81E6070", VA = "0x1881E7270")]
	private void FMGPJJJGALI(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x81E5610", Offset = "0x81E4410", VA = "0x1881E5610")]
	private void DFOLBIJMFIN(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x81E9D70", Offset = "0x81E8B70", VA = "0x1881E9D70")]
	private void NDGOBKHCLKH(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x81E6C00", Offset = "0x81E5A00", VA = "0x1881E6C00")]
	private void EJDPKKHLFIB(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x81E85A0", Offset = "0x81E73A0", VA = "0x1881E85A0")]
	private void JFEFLEIIGMI(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x81E3780", Offset = "0x81E2580", VA = "0x1881E3780")]
	private void BGCHHGKHEOG(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x81E7780", Offset = "0x81E6580", VA = "0x1881E7780")]
	private void HANKGAMOHCF(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x81E3FA0", Offset = "0x81E2DA0", VA = "0x1881E3FA0")]
	private GameObject CIINLCKFEIH(string FLHKIEKANIH, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, Vector3 AMJKMJIBGNI, byte HKDEGGMBIMJ = 0, [Optional] object[] BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x81EA460", Offset = "0x81E9260", VA = "0x1881EA460")]
	private GameObject PGFNJBMBNAN(OJNEMHDMCGC OAEBFAAHGEJ, bool GFLBPAOCEFL = false, bool BELKBDIIAOC = false, bool CMECIAGGAMD = true, bool CKFKEAEPHDI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x81E4190", Offset = "0x81E2F90", VA = "0x1881E4190")]
	private static GameObject CINIGHLGHDH(string FLHKIEKANIH, bool ACKIIECLNDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81E3B80", Offset = "0x81E2980", VA = "0x1881E3B80")]
	private static GameObject CBOIPHIDCGP(GameObject FLFNPLAKMCE, OJNEMHDMCGC OAEBFAAHGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x81E7670", Offset = "0x81E6470", VA = "0x1881E7670")]
	private static void GNMIFODLPLL(GameObject EJNHDGCJKPM, RRNetworkView LNFFCKNEJCB, [In] OJNEMHDMCGC OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x81E5CC0", Offset = "0x81E4AC0", VA = "0x1881E5CC0")]
	private GameObject[] EBFIGBHEFPM(IList<GCIJFIKDGLB> AEACCKLIIMF, bool FIFFPJJEKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x81EAB60", Offset = "0x81E9960", VA = "0x1881EAB60")]
	private GameObject[] PMBALBJAKJK(OJNEMHDMCGC[] KCLCNGHNCCK, int GNLHIAIEOJP, CDKFIILELLC IFADLDJHCLA, GameObject[] GEPOALMIIJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81E58B0", Offset = "0x81E46B0", VA = "0x1881E58B0")]
	private GameObject DMMHHIHGGHD([In] OJNEMHDMCGC OAEBFAAHGEJ, GameObject FLFNPLAKMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74F8600", Offset = "0x74F7400", VA = "0x1874F8600")]
	private static bool DBLKIMKPPPJ(bool GFLBPAOCEFL, bool CMECIAGGAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x81E4210", Offset = "0x81E3010", VA = "0x1881E4210")]
	private void CPMKLCIAJHH(IEnumerable<GameObject> EHPJPDMDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x81E2730", Offset = "0x81E1530", VA = "0x1881E2730")]
	private void ALMEENBNFEI(GameObject EJNHDGCJKPM, bool CKFKEAEPHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x81E96D0", Offset = "0x81E84D0", VA = "0x1881E96D0")]
	private static void LCBKPJPNGNO(IEnumerable<GameObject> BMEALHIEJJH, List<(GameObject GameObject, int ParentCount)> MIKBBPMDOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x81E8EB0", Offset = "0x81E7CB0", VA = "0x1881E8EB0")]
	private void JLJNGCJAGHE(int BDHGHAPLPLK, int GNLHIAIEOJP, bool CKFKEAEPHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x81E7E00", Offset = "0x81E6C00", VA = "0x1881E7E00")]
	private static int HHPCPGLFOKO(int BDHGHAPLPLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x81E6BA0", Offset = "0x81E59A0", VA = "0x1881E6BA0")]
	private void EJBMPOODEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x81E8960", Offset = "0x81E7760", VA = "0x1881E8960")]
	private void JLHPPCCLJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x81E9C10", Offset = "0x81E8A10", VA = "0x1881E9C10")]
	private static int MIHPAFGGIBE(int PONJACDINLH, bool CMECIAGGAMD = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x81E57D0", Offset = "0x81E45D0", VA = "0x1881E57D0")]
	private static int[] DGPFCCACHMH(int MKAAKEJJGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x81E6EE0", Offset = "0x81E5CE0", VA = "0x1881E6EE0")]
	private static int[] FFCLIKIHLHG(int PBHKHJPMFCF, int MKAAKEJJGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x81E3D90", Offset = "0x81E2B90", VA = "0x1881E3D90")]
	private void CGBHEFOCDEF(CDKFIILELLC LLBLGOOBCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x81E4E30", Offset = "0x81E3C30", VA = "0x1881E4E30")]
	private void DAHBLHHLKPG(CDKFIILELLC IFADLDJHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x81E93F0", Offset = "0x81E81F0", VA = "0x1881E93F0")]
	private void LBFAIAPBOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x81EA220", Offset = "0x81E9020", VA = "0x1881EA220")]
	private void PBPOCLOGHCJ(CDKFIILELLC IFADLDJHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x81E8000", Offset = "0x81E6E00", VA = "0x1881E8000")]
	private static void IEEEKPFMIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x81E9AE0", Offset = "0x81E88E0", VA = "0x1881E9AE0")]
	private void LKALILLEEDH(int[] GKLPDLAAFFF, int FBGOMDBCENN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public DODCDLFJBFC()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(NLCIBNPMLKH), new string[] { "Photon" })]
public class NLCIBNPMLKH : NHPEKAEFMLG, GNJFBAIKFDH, GCGHDNNCOPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct HMIEOIBEDCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MethodInfo DBJHNGDELCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Func<MonoBehaviour, object> DKGBKDLIDAJ;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
		public HMIEOIBEDCB(MethodInfo DBJHNGDELCK, [Optional] Func<MonoBehaviour, object> DKGBKDLIDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x74F5C10", Offset = "0x74F4A10", VA = "0x1874F5C10")]
		public object NIGKPIEPOKD(MonoBehaviour KEEHHLBKLFO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OGFCADCMFBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OGFCADCMFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x81F7620", Offset = "0x81F6420", VA = "0x1881F7620")]
		internal HMIEOIBEDCB BHMLDFJMEKN(MethodInfo methodInfo)
		{
			return default(HMIEOIBEDCB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x48C7AF0", Offset = "0x48C68F0", VA = "0x1848C7AF0")]
		internal object JPOFICNEFNC(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FPHPFBMFNKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FPHPFBMFNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x74F5E80", Offset = "0x74F4C80", VA = "0x1874F5E80")]
		internal HMIEOIBEDCB CNDCJHLHHBH(MethodInfo methodInfo)
		{
			return default(HMIEOIBEDCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KHAIIOCFJJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KHAIIOCFJJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x81EFB30", Offset = "0x81EE930", VA = "0x1881EFB30")]
		internal bool CKBALLIKBFB(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Stopwatch EHNDJBLEGGA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Dictionary<MethodInfo, ParameterInfo[]> PMOADIJGGGK;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<Type, List<HMIEOIBEDCB>> IJJPEMLDLJL;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x81F4410", Offset = "0x81F3210", VA = "0x1881F4410", Slot = "4")]
	public void EDDKJIHBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x81F42C0", Offset = "0x81F30C0", VA = "0x1881F42C0", Slot = "5")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x81F6250", Offset = "0x81F5050", VA = "0x1881F6250")]
	private void FMGPJJJGALI(BNHAMMLICHE IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x81F4290", Offset = "0x81F3090", VA = "0x1881F4290", Slot = "9")]
	public string DJJGCAMJNDA(BNHAMMLICHE IHKPBFJODHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x81F6600", Offset = "0x81F5400", VA = "0x1881F6600", Slot = "8")]
	public void HLMKHNDKNPD(ViewId JGOGKOHBDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x81F6BC0", Offset = "0x81F59C0", VA = "0x1881F6BC0", Slot = "6")]
	public void IHOINHFEDGK(ViewId LNFFCKNEJCB, string JAHAECILGDJ, CDKFIILELLC IFADLDJHCLA, IJKPDLCOMPD IGCDNMKDJDK, params object[] OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x81F6C90", Offset = "0x81F5A90", VA = "0x1881F6C90", Slot = "7")]
	public void IHOINHFEDGK(ViewId LNFFCKNEJCB, string JAHAECILGDJ, HGHJNEHJPNI IMBAOPHEODM, IJKPDLCOMPD IGCDNMKDJDK, params object[] OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x81F66E0", Offset = "0x81F54E0", VA = "0x1881F66E0")]
	private void IHOINHFEDGK(ViewId LNFFCKNEJCB, string JAHAECILGDJ, HGHJNEHJPNI IMBAOPHEODM, CDKFIILELLC IFADLDJHCLA, IJKPDLCOMPD IGCDNMKDJDK, params object[] OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x81F4510", Offset = "0x81F3310", VA = "0x1881F4510")]
	private void ELEJNOBOLBP(ViewId JGOGKOHBDFC, string JAHAECILGDJ, CDKFIILELLC DFODLDMBKGD, int MILGEGKGJBE, object[] FLNLCOLLCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x81F6CC0", Offset = "0x81F5AC0", VA = "0x1881F6CC0")]
	private static void LLOHBCJOEDD(HMIEOIBEDCB MNDHCKEIOBG, MonoBehaviour DGMMAMLEBFO, object[] ENDEOBGIMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x81F3630", Offset = "0x81F2430", VA = "0x1881F3630")]
	private static bool AKMKOEKLIKP(ParameterInfo[] JBAMGNNFLLL, Type[] AIELPKAGOLI, [Out] bool ALOGNLICCCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x81F3860", Offset = "0x81F2660", VA = "0x1881F3860")]
	private List<HMIEOIBEDCB> ALLCCNIBEMH(MonoBehaviour DGMMAMLEBFO, Type IIMOCECAHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x81F6500", Offset = "0x81F5300", VA = "0x1881F6500")]
	private static IEnumerable<MethodInfo> HBOAKMIIIGK(Type DGPNPBEKOOD, Type NNAJBBNBMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x81F7180", Offset = "0x81F5F80", VA = "0x1881F7180")]
	public static ParameterInfo[] NDLJDPBGMCH(MethodInfo NNNCJKKMHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public NLCIBNPMLKH()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, HGOBILCNGDO, EOPJNNNGOGB, JKBIKCFCCKN, HAHNHFHBMDO, AJFMFCCDCEG
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum AHGIPKCLIKH
		{
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class AADGPMIDEHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public AADGPMIDEHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x81DE950", Offset = "0x81DD750", VA = "0x1881DE950")]
			internal bool BOCALMBPJCM(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<int, RRNetworkView> ABDGJNMJGHP;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static EIIAJLFMPKP LDIJFGJKFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private bool AKHCGAMGMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal bool GODFJJBCHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public AHGIPKCLIKH hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool DPHJGLNAKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool DJGJOMFCHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int BGPAHDFEFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool FFHKHINIPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int PEBDNECPPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private CDKFIILELLC PBHKHJPMFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private CDKFIILELLC ELHNOIHIPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool? KBEAJGNBIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool IFLECGOEKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal bool IPGJPMEDHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal MonoBehaviour[] NNEGJMJFDBF;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly PHLHEDGDBJO EOHJEBJCJJB;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId DPPHEGJKDGI
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x81FE820", Offset = "0x81FD620", VA = "0x1881FE820")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId DHPFPMEOICF
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x81FE820", Offset = "0x81FD620", VA = "0x1881FE820", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId AAJNFEAFNCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x81FE820", Offset = "0x81FD620", VA = "0x1881FE820")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int KMGFLMFFNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA5E630", Offset = "0xA5D430", VA = "0x180A5E630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int LFNKDEMMHHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA80B80", Offset = "0xA7F980", VA = "0x180A80B80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xE78700", Offset = "0xE77500", VA = "0x180E78700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ViewId LPPCFPKHGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x81FE690", Offset = "0x81FD490", VA = "0x1881FE690")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool FKNHIENNAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA60460", Offset = "0xA5F260", VA = "0x180A60460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA60450", Offset = "0xA5F250", VA = "0x180A60450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EKDOHAJEGDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x81FE6A0", Offset = "0x81FD4A0", VA = "0x1881FE6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DGHGCIEONJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xABC540", Offset = "0xABB340", VA = "0x180ABC540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int DDIEDBBBOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAA74E0", Offset = "0xAA62E0", VA = "0x180AA74E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int CKBCOOLPDJI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x81FE630", Offset = "0x81FD430", VA = "0x1881FE630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CDKFIILELLC KNCEGBICJJD
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x81FE830", Offset = "0x81FD630", VA = "0x1881FE830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CDKFIILELLC ODDLKPGOFNG
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x81FE600", Offset = "0x81FD400", VA = "0x1881FE600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public CDKFIILELLC HANEPOCOCOA
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x81FE600", Offset = "0x81FD400", VA = "0x1881FE600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public CDKFIILELLC HGFHAPCAKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x81FE600", Offset = "0x81FD400", VA = "0x1881FE600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool NLDOPONFGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x81FE770", Offset = "0x81FD570", VA = "0x1881FE770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int NAEMLBGMFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x81FE660", Offset = "0x81FD460", VA = "0x1881FE660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public object[] CFLCCMNJHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA60470", Offset = "0xA5F270", VA = "0x180A60470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool NHIOAFMOPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x81FE860", Offset = "0x81FD660", VA = "0x1881FE860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool JAKBKEFKCDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x81FE7F0", Offset = "0x81FD5F0", VA = "0x1881FE7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OLOGEBJDKLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xE41700", Offset = "0xE40500", VA = "0x180E41700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xF9FD40", Offset = "0xF9EB40", VA = "0x180F9FD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JFHEADJNHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCE72D0", Offset = "0xCE60D0", VA = "0x180CE72D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> HNENAALLMFF
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x81FE4A0", Offset = "0x81FD2A0", VA = "0x1881FE4A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x81FEA20", Offset = "0x81FD820", VA = "0x1881FEA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<CDKFIILELLC> EMKFBFJEPDP
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x81FA990", Offset = "0x81F9790", VA = "0x1881FA990")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x81F9C20", Offset = "0x81F8A20", VA = "0x1881F9C20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<CDKFIILELLC> HNLNAJPEKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x81FA990", Offset = "0x81F9790", VA = "0x1881FA990")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x81F9C20", Offset = "0x81F8A20", VA = "0x1881F9C20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> LKNHGHCGPJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x81FB490", Offset = "0x81FA290", VA = "0x1881FB490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x81FA6D0", Offset = "0x81F94D0", VA = "0x1881FA6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> MLACNBKCLJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x81FB490", Offset = "0x81FA290", VA = "0x1881FB490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x81FA6D0", Offset = "0x81F94D0", VA = "0x1881FA6D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> MBOADPOHFAB
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x81FE550", Offset = "0x81FD350", VA = "0x1881FE550")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x81FEAD0", Offset = "0x81FD8D0", VA = "0x1881FEAD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action KAGAMIAMJDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x81FE3F0", Offset = "0x81FD1F0", VA = "0x1881FE3F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x81FE970", Offset = "0x81FD770", VA = "0x1881FE970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x81FE220", Offset = "0x81FD020", VA = "0x1881FE220")]
		public static bool TryGetNetworkView(int JGOGKOHBDFC, [Out] RRNetworkView LNFFCKNEJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x81FA030", Offset = "0x81F8E30", VA = "0x1881FA030")]
		public static RRNetworkView Find(int JGOGKOHBDFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x81FA1B0", Offset = "0x81F8FB0", VA = "0x1881FA1B0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int KBOFJIFLEDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x81FA140", Offset = "0x81F8F40", VA = "0x1881FA140")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x81FB990", Offset = "0x81FA790", VA = "0x1881FB990")]
		public static bool RemoveNetworkView(RRNetworkView LNFFCKNEJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x81FB760", Offset = "0x81FA560", VA = "0x1881FB760")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x81FB140", Offset = "0x81F9F40", VA = "0x1881FB140")]
		public static void OnPlayerJoinedRoom(CDKFIILELLC BCMGJKNFJIE, List<int> GKLPDLAAFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x81FA2F0", Offset = "0x81F90F0", VA = "0x1881FA2F0")]
		public static RRNetworkView Get(Component LPAADBJGJNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x81FA350", Offset = "0x81F9150", VA = "0x1881FA350")]
		public static RRNetworkView Get(GameObject PDPHLKIKPHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x81F95A0", Offset = "0x81F83A0", VA = "0x1881F95A0")]
		private void AJMNMEENKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x81F9BA0", Offset = "0x81F89A0", VA = "0x1881F9BA0")]
		public bool CreatedBy(CDKFIILELLC IFADLDJHCLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x81FE030", Offset = "0x81FCE30", VA = "0x1881FE030")]
		public void TransferOwnership(int BEDDBBMKBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x81FDFD0", Offset = "0x81FCDD0", VA = "0x1881FDFD0")]
		public void TransferOwnership(CDKFIILELLC PECNGGGEHEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x81FA3B0", Offset = "0x81F91B0", VA = "0x1881FA3B0", Slot = "4")]
		public void Initialize(ViewId KHDNAGBAKMK, ViewId CCOHEOMBEFE, Dictionary<int, object> OBJPMEDBNDI, GLHCBKLDIDI PBHKHJPMFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x81FA530", Offset = "0x81F9330", VA = "0x1881FA530")]
		public void Initialize(ViewId KHDNAGBAKMK, ViewId CCOHEOMBEFE, object[] OKFKOHOHAEI, GLHCBKLDIDI PBHKHJPMFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x81F9850", Offset = "0x81F8650", VA = "0x1881F9850")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x81F9D90", Offset = "0x81F8B90", VA = "0x1881F9D90")]
		private void FDEBFEABPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB41F0", Offset = "0x1FB2FF0", VA = "0x181FB41F0")]
		internal void CNKFMCBKDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x81FA780", Offset = "0x81F9580", VA = "0x1881FA780", Slot = "6")]
		private void MHLGNMOCFOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x81FA0D0", Offset = "0x81F8ED0", VA = "0x1881FA0D0")]
		internal bool GPJCBIPLMGN(RRNetworkView KPADCGAKHGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x81FAFA0", Offset = "0x81F9DA0", VA = "0x1881FAFA0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x81FA840", Offset = "0x81F9640", VA = "0x1881FA840")]
		internal void MOOCLIEFCGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x81FA0C0", Offset = "0x81F8EC0", VA = "0x1881FA0C0")]
		private void GKODBHLFBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x81F9CD0", Offset = "0x81F8AD0", VA = "0x1881F9CD0")]
		internal void EEBLGONPAPC(CDKFIILELLC PECNGGGEHEH, int BEDDBBMKBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x81FB8F0", Offset = "0x81FA6F0", VA = "0x1881FB8F0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x81FBA10", Offset = "0x81FA810", VA = "0x1881FBA10")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x81F9F90", Offset = "0x81F8D90", VA = "0x1881F9F90")]
		private void FPPOGBHBNFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x81FA8A0", Offset = "0x81F96A0", VA = "0x1881FA8A0")]
		private void MPNCGPBJLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x81FB640", Offset = "0x81FA440", VA = "0x1881FB640")]
		public void RPC(string JAHAECILGDJ, HGHJNEHJPNI IMBAOPHEODM, params object[] OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x81FB6D0", Offset = "0x81FA4D0", VA = "0x1881FB6D0")]
		public void RPC(string JAHAECILGDJ, CDKFIILELLC FIHFPAKJDIB, params object[] OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x81FB940", Offset = "0x81FA740", VA = "0x1881FB940")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x81F98B0", Offset = "0x81F86B0", VA = "0x1881F98B0", Slot = "8")]
		public void Bake(HLIDELEPHMC IEOOLFDDEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x81F97D0", Offset = "0x81F85D0", VA = "0x1881F97D0")]
		private static void APGOGBHCOOI(CDKFIILELLC BFIOOMKAEHA, [Out] CDKFIILELLC DLMFOKOOJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x81FAC00", Offset = "0x81F9A00", VA = "0x1881FAC00")]
		private static void OMPKECPEEJK(RRNetworkView JPJFDCGGAFF, Delegate MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x81FAF20", Offset = "0x81F9D20", VA = "0x1881FAF20")]
		private static HIMONOOAFHI OPMMCAGDLIH(RRNetworkView JPJFDCGGAFF)
		{
			return default(HIMONOOAFHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x81FA630", Offset = "0x81F9430", VA = "0x1881FA630")]
		private static HEBLDOMJFJP JHDNAGBCPLD(RRNetworkView JPJFDCGGAFF)
		{
			return default(HEBLDOMJFJP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA40", Offset = "0x81F9840", VA = "0x1881FAA40")]
		private static void OECPPIGHCDB(RRNetworkView JPJFDCGGAFF, Delegate MNDHCKEIOBG, CDKFIILELLC CMCHKODGJOJ, params object[] OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x81FAB20", Offset = "0x81F9920", VA = "0x1881FAB20")]
		private static void OECPPIGHCDB(RRNetworkView JPJFDCGGAFF, Delegate MNDHCKEIOBG, HGHJNEHJPNI CMCHKODGJOJ, params object[] OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x81F9680", Offset = "0x81F8480", VA = "0x1881F9680")]
		private static void AKMABCHJLDG(RRNetworkView JPJFDCGGAFF, Delegate MNDHCKEIOBG, HGHJNEHJPNI CMCHKODGJOJ, CBOIHFCDMJP KBNHPINNLCC, params object[] OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x81FB540", Offset = "0x81FA340", VA = "0x1881FB540")]
		public void RPCBuffered(string JAHAECILGDJ, HGHJNEHJPNI IMBAOPHEODM, CBOIHFCDMJP IGCDNMKDJDK, params object[] OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x81FA590", Offset = "0x81F9390", VA = "0x1881FA590")]
		private static bool JBIMDBIMMGN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x81FC2C0", Offset = "0x81FB0C0", VA = "0x1881FC2C0", Slot = "26")]
		public void RpcAll(BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3E397B0", Offset = "0x3E385B0", VA = "0x183E397B0", Slot = "9")]
		public void RpcAll<T1>(BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3E39000", Offset = "0x3E37E00", VA = "0x183E39000", Slot = "10")]
		public void RpcAll<T1, T2>(BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3E3BE30", Offset = "0x3E3AC30", VA = "0x183E3BE30", Slot = "27")]
		public void RpcAll<T1, T2, T3>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3E39220", Offset = "0x3E38020", VA = "0x183E39220", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3E39E90", Offset = "0x3E38C90", VA = "0x183E39E90", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C330", Offset = "0x3E3B130", VA = "0x183E3C330", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3E39940", Offset = "0x3E38740", VA = "0x183E39940", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3E40F40", Offset = "0x3E3FD40", VA = "0x183E40F40", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C7E0", Offset = "0x3E3B5E0", VA = "0x183E3C7E0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3E3ABD0", Offset = "0x3E399D0", VA = "0x183E3ABD0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3E47850", Offset = "0x3E46650", VA = "0x183E47850", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3E46CF0", Offset = "0x3E45AF0", VA = "0x183E46CF0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3E46120", Offset = "0x3E44F20", VA = "0x183E46120", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A2E0", Offset = "0x3E390E0", VA = "0x183E3A2E0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x81FC430", Offset = "0x81FB230", VA = "0x1881FC430")]
		public void RpcAll(BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F030", Offset = "0x3E3DE30", VA = "0x183E3F030")]
		public void RpcAll<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F8F0", Offset = "0x3E3E6F0", VA = "0x183E3F8F0")]
		public void RpcAll<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B4C0", Offset = "0x3E3A2C0", VA = "0x183E3B4C0")]
		public void RpcAll<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3E4D100", Offset = "0x3E4BF00", VA = "0x183E4D100")]
		public void RpcAll<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C8C0", Offset = "0x3E4B6C0", VA = "0x183E4C8C0")]
		public void RpcAll<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BF10", Offset = "0x3E4AD10", VA = "0x183E4BF10")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B0A0", Offset = "0x3E49EA0", VA = "0x183E4B0A0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A840", Offset = "0x3E49640", VA = "0x183E4A840")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3E496E0", Offset = "0x3E484E0", VA = "0x183E496E0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3E48CE0", Offset = "0x3E47AE0", VA = "0x183E48CE0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3E47D60", Offset = "0x3E46B60", VA = "0x183E47D60")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3E47280", Offset = "0x3E46080", VA = "0x183E47280")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3E45AE0", Offset = "0x3E448E0", VA = "0x183E45AE0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3E440D0", Offset = "0x3E42ED0", VA = "0x183E440D0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x81FC090", Offset = "0x81FAE90", VA = "0x1881FC090", Slot = "36")]
		public void RpcAll(BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3E51680", Offset = "0x3E50480", VA = "0x183E51680", Slot = "37")]
		public void RpcAll<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3E4F800", Offset = "0x3E4E600", VA = "0x183E4F800", Slot = "38")]
		public void RpcAll<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DCA0", Offset = "0x3E4CAA0", VA = "0x183E4DCA0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E4D3C0", Offset = "0x3E4C1C0", VA = "0x183E4D3C0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C5B0", Offset = "0x3E4B3B0", VA = "0x183E4C5B0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BBA0", Offset = "0x3E4A9A0", VA = "0x183E4BBA0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B7E0", Offset = "0x3E4A5E0", VA = "0x183E4B7E0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4AC70", Offset = "0x3E49A70", VA = "0x183E4AC70", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E49B70", Offset = "0x3E48970", VA = "0x183E49B70", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E491E0", Offset = "0x3E47FE0", VA = "0x183E491E0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E482C0", Offset = "0x3E470C0", VA = "0x183E482C0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3E46720", Offset = "0x3E45520", VA = "0x183E46720", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3E454A0", Offset = "0x3E442A0", VA = "0x183E454A0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3E44780", Offset = "0x3E43580", VA = "0x183E44780", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x81FBF60", Offset = "0x81FAD60", VA = "0x1881FBF60", Slot = "51")]
		public void RpcAllViaServer(BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3E38DE0", Offset = "0x3E37BE0", VA = "0x183E38DE0", Slot = "52")]
		public void RpcAllViaServer<T1>(BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3E317F0", Offset = "0x3E305F0", VA = "0x183E317F0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3E38700", Offset = "0x3E37500", VA = "0x183E38700", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3E38190", Offset = "0x3E36F90", VA = "0x183E38190", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3E37650", Offset = "0x3E36450", VA = "0x183E37650", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3E373A0", Offset = "0x3E361A0", VA = "0x183E373A0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3E36840", Offset = "0x3E35640", VA = "0x183E36840", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3E361F0", Offset = "0x3E34FF0", VA = "0x183E361F0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3E35070", Offset = "0x3E33E70", VA = "0x183E35070", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3E34C80", Offset = "0x3E33A80", VA = "0x183E34C80", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3E34060", Offset = "0x3E32E60", VA = "0x183E34060", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3E33350", Offset = "0x3E32150", VA = "0x183E33350", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3E31B60", Offset = "0x3E30960", VA = "0x183E31B60", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3E54C70", Offset = "0x3E53A70", VA = "0x183E54C70", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x81FBD00", Offset = "0x81FAB00", VA = "0x1881FBD00")]
		public void RpcAllViaServer(BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3E38EF0", Offset = "0x3E37CF0", VA = "0x183E38EF0")]
		public void RpcAllViaServer<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3E388B0", Offset = "0x3E376B0", VA = "0x183E388B0")]
		public void RpcAllViaServer<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3E38550", Offset = "0x3E37350", VA = "0x183E38550")]
		public void RpcAllViaServer<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3E37D70", Offset = "0x3E36B70", VA = "0x183E37D70")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3E378B0", Offset = "0x3E366B0", VA = "0x183E378B0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3E36E40", Offset = "0x3E35C40", VA = "0x183E36E40")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3E36540", Offset = "0x3E35340", VA = "0x183E36540")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3E35EA0", Offset = "0x3E34CA0", VA = "0x183E35EA0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3E35410", Offset = "0x3E34210", VA = "0x183E35410")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3E34890", Offset = "0x3E33690", VA = "0x183E34890")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3E337E0", Offset = "0x3E325E0", VA = "0x183E337E0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E32A30", Offset = "0x3E31830", VA = "0x183E32A30")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E32050", Offset = "0x3E30E50", VA = "0x183E32050")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E551B0", Offset = "0x3E53FB0", VA = "0x183E551B0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x81FBE30", Offset = "0x81FAC30", VA = "0x1881FBE30", Slot = "65")]
		public void RpcAllViaServer(BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E38CD0", Offset = "0x3E37AD0", VA = "0x183E38CD0", Slot = "66")]
		public void RpcAllViaServer<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E38A10", Offset = "0x3E37810", VA = "0x183E38A10", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E383A0", Offset = "0x3E371A0", VA = "0x183E383A0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E37F80", Offset = "0x3E36D80", VA = "0x183E37F80", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E37B10", Offset = "0x3E36910", VA = "0x183E37B10", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E370F0", Offset = "0x3E35EF0", VA = "0x183E370F0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E36B40", Offset = "0x3E35940", VA = "0x183E36B40", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E35B50", Offset = "0x3E34950", VA = "0x183E35B50", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E357B0", Offset = "0x3E345B0", VA = "0x183E357B0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E344A0", Offset = "0x3E332A0", VA = "0x183E344A0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E33C20", Offset = "0x3E32A20", VA = "0x183E33C20", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E32EC0", Offset = "0x3E31CC0", VA = "0x183E32EC0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E32540", Offset = "0x3E31340", VA = "0x183E32540", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E54730", Offset = "0x3E53530", VA = "0x183E54730", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x81FD5C0", Offset = "0x81FC3C0", VA = "0x1881FD5C0", Slot = "80")]
		public void RpcOthers(BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F4B0", Offset = "0x3E7E2B0", VA = "0x183E7F4B0", Slot = "15")]
		public void RpcOthers<T1>(BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FDB0", Offset = "0x3E7EBB0", VA = "0x183E7FDB0", Slot = "81")]
		public void RpcOthers<T1, T2>(BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F230", Offset = "0x3E7E030", VA = "0x183E7F230", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E88890", Offset = "0x3E87690", VA = "0x183E88890", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E80B60", Offset = "0x3E7F960", VA = "0x183E80B60", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E87E40", Offset = "0x3E86C40", VA = "0x183E87E40", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E87580", Offset = "0x3E86380", VA = "0x183E87580", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E864F0", Offset = "0x3E852F0", VA = "0x183E864F0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E86130", Offset = "0x3E84F30", VA = "0x183E86130", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E84D80", Offset = "0x3E83B80", VA = "0x183E84D80", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E84920", Offset = "0x3E83720", VA = "0x183E84920", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E836E0", Offset = "0x3E824E0", VA = "0x183E836E0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E822F0", Offset = "0x3E810F0", VA = "0x183E822F0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E812A0", Offset = "0x3E800A0", VA = "0x183E812A0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x81FD710", Offset = "0x81FC510", VA = "0x1881FD710")]
		public void RpcOthers(BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FAF0", Offset = "0x3E7E8F0", VA = "0x183E7FAF0")]
		public void RpcOthers<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F900", Offset = "0x3E7E700", VA = "0x183E7F900")]
		public void RpcOthers<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E89CC0", Offset = "0x3E88AC0", VA = "0x183E89CC0")]
		public void RpcOthers<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F610", Offset = "0x3E7E410", VA = "0x183E7F610")]
		public void RpcOthers<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E802C0", Offset = "0x3E7F0C0", VA = "0x183E802C0")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E80610", Offset = "0x3E7F410", VA = "0x183E80610")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E87260", Offset = "0x3E86060", VA = "0x183E87260")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E86BD0", Offset = "0x3E859D0", VA = "0x183E86BD0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3E859B0", Offset = "0x3E847B0", VA = "0x183E859B0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3E85190", Offset = "0x3E83F90", VA = "0x183E85190")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3E844C0", Offset = "0x3E832C0", VA = "0x183E844C0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3E83BA0", Offset = "0x3E829A0", VA = "0x183E83BA0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3E82800", Offset = "0x3E81600", VA = "0x183E82800")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E81D80", Offset = "0x3E80B80", VA = "0x183E81D80")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x81FD470", Offset = "0x81FC270", VA = "0x1881FD470", Slot = "93")]
		public void RpcOthers(BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A710", Offset = "0x3E89510", VA = "0x183E8A710", Slot = "94")]
		public void RpcOthers<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A230", Offset = "0x3E89030", VA = "0x183E8A230", Slot = "95")]
		public void RpcOthers<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E89900", Offset = "0x3E88700", VA = "0x183E89900", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E88CF0", Offset = "0x3E87AF0", VA = "0x183E88CF0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E88610", Offset = "0x3E87410", VA = "0x183E88610", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E878A0", Offset = "0x3E866A0", VA = "0x183E878A0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E86F40", Offset = "0x3E85D40", VA = "0x183E86F40", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E86860", Offset = "0x3E85660", VA = "0x183E86860", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E85D70", Offset = "0x3E84B70", VA = "0x183E85D70", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E855A0", Offset = "0x3E843A0", VA = "0x183E855A0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3E84060", Offset = "0x3E82E60", VA = "0x183E84060", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E83220", Offset = "0x3E82020", VA = "0x183E83220", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E82D10", Offset = "0x3E81B10", VA = "0x183E82D10", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E81810", Offset = "0x3E80610", VA = "0x183E81810", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x81FD100", Offset = "0x81FBF00", VA = "0x1881FD100", Slot = "108")]
		public void RpcMaster(BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3E66090", Offset = "0x3E64E90", VA = "0x183E66090", Slot = "109")]
		public void RpcMaster<T1>(BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E66440", Offset = "0x3E65240", VA = "0x183E66440", Slot = "17")]
		public void RpcMaster<T1, T2>(BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E65DC0", Offset = "0x3E64BC0", VA = "0x183E65DC0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E65A60", Offset = "0x3E64860", VA = "0x183E65A60", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E69B20", Offset = "0x3E68920", VA = "0x183E69B20", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3E6BFA0", Offset = "0x3E6ADA0", VA = "0x183E6BFA0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3E74860", Offset = "0x3E73660", VA = "0x183E74860", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E73BE0", Offset = "0x3E729E0", VA = "0x183E73BE0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E72E30", Offset = "0x3E71C30", VA = "0x183E72E30", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E692D0", Offset = "0x3E680D0", VA = "0x183E692D0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E67ED0", Offset = "0x3E66CD0", VA = "0x183E67ED0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E70430", Offset = "0x3E6F230", VA = "0x183E70430", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E6E5B0", Offset = "0x3E6D3B0", VA = "0x183E6E5B0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D880", Offset = "0x3E6C680", VA = "0x183E6D880", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x81FCCA0", Offset = "0x81FBAA0", VA = "0x1881FCCA0")]
		public void RpcMaster(BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E66240", Offset = "0x3E65040", VA = "0x183E66240")]
		public void RpcMaster<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E66EE0", Offset = "0x3E65CE0", VA = "0x183E66EE0")]
		public void RpcMaster<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E66690", Offset = "0x3E65490", VA = "0x183E66690")]
		public void RpcMaster<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E766F0", Offset = "0x3E754F0", VA = "0x183E766F0")]
		public void RpcMaster<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A560", Offset = "0x3E69360", VA = "0x183E6A560")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3E753D0", Offset = "0x3E741D0", VA = "0x183E753D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E74C20", Offset = "0x3E73A20", VA = "0x183E74C20")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E73FF0", Offset = "0x3E72DF0", VA = "0x183E73FF0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E732A0", Offset = "0x3E720A0", VA = "0x183E732A0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E71A30", Offset = "0x3E70830", VA = "0x183E71A30")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E70F60", Offset = "0x3E6FD60", VA = "0x183E70F60")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E6FE40", Offset = "0x3E6EC40", VA = "0x183E6FE40")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E6EBB0", Offset = "0x3E6D9B0", VA = "0x183E6EBB0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E6DEF0", Offset = "0x3E6CCF0", VA = "0x183E6DEF0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x81FCEC0", Offset = "0x81FBCC0", VA = "0x1881FCEC0", Slot = "122")]
		public void RpcMaster(BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E79370", Offset = "0x3E78170", VA = "0x183E79370", Slot = "123")]
		public void RpcMaster<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E78220", Offset = "0x3E77020", VA = "0x183E78220", Slot = "124")]
		public void RpcMaster<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3E76F50", Offset = "0x3E75D50", VA = "0x183E76F50", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3E769E0", Offset = "0x3E757E0", VA = "0x183E769E0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3E75AD0", Offset = "0x3E748D0", VA = "0x183E75AD0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3E75020", Offset = "0x3E73E20", VA = "0x183E75020", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3E74460", Offset = "0x3E73260", VA = "0x183E74460", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3E73770", Offset = "0x3E72570", VA = "0x183E73770", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3E72960", Offset = "0x3E71760", VA = "0x183E72960", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3E71F60", Offset = "0x3E70D60", VA = "0x183E71F60", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3E709D0", Offset = "0x3E6F7D0", VA = "0x183E709D0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F850", Offset = "0x3E6E650", VA = "0x183E6F850", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F200", Offset = "0x3E6E000", VA = "0x183E6F200", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D1C0", Offset = "0x3E6BFC0", VA = "0x183E6D1C0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x81FC890", Offset = "0x81FB690", VA = "0x1881FC890", Slot = "137")]
		public void RpcAuthority(BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3E55B00", Offset = "0x3E54900", VA = "0x183E55B00", Slot = "138")]
		public void RpcAuthority<T1>(BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3E57410", Offset = "0x3E56210", VA = "0x183E57410", Slot = "139")]
		public void RpcAuthority<T1, T2>(BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3E57BC0", Offset = "0x3E569C0", VA = "0x183E57BC0", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3E570D0", Offset = "0x3E55ED0", VA = "0x183E570D0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3E556F0", Offset = "0x3E544F0", VA = "0x183E556F0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3E60830", Offset = "0x3E5F630", VA = "0x183E60830", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3E600A0", Offset = "0x3E5EEA0", VA = "0x183E600A0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3E5EB30", Offset = "0x3E5D930", VA = "0x183E5EB30", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3E5E6A0", Offset = "0x3E5D4A0", VA = "0x183E5E6A0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3E5D7F0", Offset = "0x3E5C5F0", VA = "0x183E5D7F0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3E5BCE0", Offset = "0x3E5AAE0", VA = "0x183E5BCE0", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3E55CC0", Offset = "0x3E54AC0", VA = "0x183E55CC0", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3E59850", Offset = "0x3E58650", VA = "0x183E59850", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3E58430", Offset = "0x3E57230", VA = "0x183E58430", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x81FC640", Offset = "0x81FB440", VA = "0x1881FC640")]
		public void RpcAuthority(BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3E63B20", Offset = "0x3E62920", VA = "0x183E63B20")]
		public void RpcAuthority<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3E62BA0", Offset = "0x3E619A0", VA = "0x183E62BA0")]
		public void RpcAuthority<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3E62690", Offset = "0x3E61490", VA = "0x183E62690")]
		public void RpcAuthority<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3E61BC0", Offset = "0x3E609C0", VA = "0x183E61BC0")]
		public void RpcAuthority<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3E60F50", Offset = "0x3E5FD50", VA = "0x183E60F50")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3E60B90", Offset = "0x3E5F990", VA = "0x183E60B90")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3E5F860", Offset = "0x3E5E660", VA = "0x183E5F860")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3E5F3E0", Offset = "0x3E5E1E0", VA = "0x183E5F3E0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3E5DCE0", Offset = "0x3E5CAE0", VA = "0x183E5DCE0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3E5CD70", Offset = "0x3E5BB70", VA = "0x183E5CD70")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C7D0", Offset = "0x3E5B5D0", VA = "0x183E5C7D0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3E5AB30", Offset = "0x3E59930", VA = "0x183E5AB30")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A4D0", Offset = "0x3E592D0", VA = "0x183E5A4D0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3E59180", Offset = "0x3E57F80", VA = "0x183E59180")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x81FCA40", Offset = "0x81FB840", VA = "0x1881FCA40", Slot = "152")]
		public void RpcAuthority(BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3E63CF0", Offset = "0x3E62AF0", VA = "0x183E63CF0", Slot = "153")]
		public void RpcAuthority<T1>(BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3E62DD0", Offset = "0x3E61BD0", VA = "0x183E62DD0", Slot = "154")]
		public void RpcAuthority<T1, T2>(BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3E621C0", Offset = "0x3E60FC0", VA = "0x183E621C0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3E61EC0", Offset = "0x3E60CC0", VA = "0x183E61EC0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3E615C0", Offset = "0x3E603C0", VA = "0x183E615C0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3E60470", Offset = "0x3E5F270", VA = "0x183E60470", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3E5FC80", Offset = "0x3E5EA80", VA = "0x183E5FC80", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3E5EF60", Offset = "0x3E5DD60", VA = "0x183E5EF60", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3E5E1C0", Offset = "0x3E5CFC0", VA = "0x183E5E1C0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3E5D2B0", Offset = "0x3E5C0B0", VA = "0x183E5D2B0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C230", Offset = "0x3E5B030", VA = "0x183E5C230", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3E5B6E0", Offset = "0x3E5A4E0", VA = "0x183E5B6E0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3E59E70", Offset = "0x3E58C70", VA = "0x183E59E70", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3E58AB0", Offset = "0x3E578B0", VA = "0x183E58AB0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x81FDB10", Offset = "0x81FC910", VA = "0x1881FDB10", Slot = "18")]
		public void RpcPlayer(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E190", Offset = "0x3E8CF90", VA = "0x183E8E190", Slot = "19")]
		public void RpcPlayer<T1>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F0F0", Offset = "0x3E8DEF0", VA = "0x183E8F0F0", Slot = "20")]
		public void RpcPlayer<T1, T2>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8EB00", Offset = "0x3E8D900", VA = "0x183E8EB00", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E360", Offset = "0x3E8D160", VA = "0x183E8E360", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3E92E60", Offset = "0x3E91C60", VA = "0x183E92E60", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3E929F0", Offset = "0x3E917F0", VA = "0x183E929F0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3E93250", Offset = "0x3E92050", VA = "0x183E93250", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3E93720", Offset = "0x3E92520", VA = "0x183E93720", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C160", Offset = "0x3E9AF60", VA = "0x183E9C160", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3E9AD30", Offset = "0x3E99B30", VA = "0x183E9AD30", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CDKFIILELLC IFADLDJHCLA, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F9E0", Offset = "0x3E8E7E0", VA = "0x183E8F9E0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CDKFIILELLC IFADLDJHCLA, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3E99160", Offset = "0x3E97F60", VA = "0x183E99160", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CDKFIILELLC IFADLDJHCLA, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3E971F0", Offset = "0x3E95FF0", VA = "0x183E971F0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CDKFIILELLC IFADLDJHCLA, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3E95DA0", Offset = "0x3E94BA0", VA = "0x183E95DA0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CDKFIILELLC IFADLDJHCLA, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x81FD860", Offset = "0x81FC660", VA = "0x1881FD860")]
		public void RpcPlayer(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E700", Offset = "0x3E8D500", VA = "0x183E8E700")]
		public void RpcPlayer<T1>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3E95280", Offset = "0x3E94080", VA = "0x183E95280")]
		public void RpcPlayer<T1, T2>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FF90", Offset = "0x3E9ED90", VA = "0x183E9FF90")]
		public void RpcPlayer<T1, T2, T3>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F480", Offset = "0x3E9E280", VA = "0x183E9F480")]
		public void RpcPlayer<T1, T2, T3, T4>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3E9EA90", Offset = "0x3E9D890", VA = "0x183E9EA90")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3E9E350", Offset = "0x3E9D150", VA = "0x183E9E350")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DB50", Offset = "0x3E9C950", VA = "0x183E9DB50")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3E9CA30", Offset = "0x3E9B830", VA = "0x183E9CA30")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BC70", Offset = "0x3E9AA70", VA = "0x183E9BC70")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDKFIILELLC IFADLDJHCLA, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B230", Offset = "0x3E9A030", VA = "0x183E9B230")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CDKFIILELLC IFADLDJHCLA, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3E99720", Offset = "0x3E98520", VA = "0x183E99720")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CDKFIILELLC IFADLDJHCLA, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3E98B40", Offset = "0x3E97940", VA = "0x183E98B40")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CDKFIILELLC IFADLDJHCLA, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3E97EA0", Offset = "0x3E96CA0", VA = "0x183E97EA0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CDKFIILELLC IFADLDJHCLA, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3E96430", Offset = "0x3E95230", VA = "0x183E96430")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CDKFIILELLC IFADLDJHCLA, CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x81FDD10", Offset = "0x81FCB10", VA = "0x1881FDD10", Slot = "176")]
		public void RpcPlayer(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3E91A10", Offset = "0x3E90810", VA = "0x183E91A10", Slot = "177")]
		public void RpcPlayer<T1>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F6F0", Offset = "0x3E8E4F0", VA = "0x183E8F6F0", Slot = "24")]
		public void RpcPlayer<T1, T2>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F370", Offset = "0x3E8E170", VA = "0x183E8F370", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3E91230", Offset = "0x3E90030", VA = "0x183E91230", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F110", Offset = "0x3E9DF10", VA = "0x183E9F110", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DF80", Offset = "0x3E9CD80", VA = "0x183E9DF80", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D720", Offset = "0x3E9C520", VA = "0x183E9D720", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3E9CEC0", Offset = "0x3E9BCC0", VA = "0x183E9CEC0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(CDKFIILELLC IFADLDJHCLA, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B780", Offset = "0x3E9A580", VA = "0x183E9B780", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CDKFIILELLC IFADLDJHCLA, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A7E0", Offset = "0x3E995E0", VA = "0x183E9A7E0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CDKFIILELLC IFADLDJHCLA, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3E99CD0", Offset = "0x3E98AD0", VA = "0x183E99CD0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CDKFIILELLC IFADLDJHCLA, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3E98520", Offset = "0x3E97320", VA = "0x183E98520", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CDKFIILELLC IFADLDJHCLA, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3E97820", Offset = "0x3E96620", VA = "0x183E97820", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CDKFIILELLC IFADLDJHCLA, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3E96B10", Offset = "0x3E95910", VA = "0x183E96B10", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CDKFIILELLC IFADLDJHCLA, CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x81FBC60", Offset = "0x81FAA60", VA = "0x1881FBC60", Slot = "189")]
		public void RpcAllBuffered(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3E315B0", Offset = "0x3E303B0", VA = "0x183E315B0", Slot = "190")]
		public void RpcAllBuffered<T1>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3E311B0", Offset = "0x3E2FFB0", VA = "0x183E311B0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3E30E80", Offset = "0x3E2FC80", VA = "0x183E30E80", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3E304D0", Offset = "0x3E2F2D0", VA = "0x183E304D0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3E30010", Offset = "0x3E2EE10", VA = "0x183E30010", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F850", Offset = "0x3E2E650", VA = "0x183E2F850", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3E2EFA0", Offset = "0x3E2DDA0", VA = "0x183E2EFA0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E940", Offset = "0x3E2D740", VA = "0x183E2E940", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3E2DB20", Offset = "0x3E2C920", VA = "0x183E2DB20", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3E2CB70", Offset = "0x3E2B970", VA = "0x183E2CB70", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBOIHFCDMJP IGCDNMKDJDK, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C2D0", Offset = "0x3E2B0D0", VA = "0x183E2C2D0", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBOIHFCDMJP IGCDNMKDJDK, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B9E0", Offset = "0x3E2A7E0", VA = "0x183E2B9E0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CBOIHFCDMJP IGCDNMKDJDK, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3E2ABA0", Offset = "0x3E299A0", VA = "0x183E2ABA0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CBOIHFCDMJP IGCDNMKDJDK, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3E29700", Offset = "0x3E28500", VA = "0x183E29700", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CBOIHFCDMJP IGCDNMKDJDK, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x81FBB20", Offset = "0x81FA920", VA = "0x1881FBB20")]
		public void RpcAllBuffered(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3E316D0", Offset = "0x3E304D0", VA = "0x183E316D0")]
		public void RpcAllBuffered<T1>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3E31320", Offset = "0x3E30120", VA = "0x183E31320")]
		public void RpcAllBuffered<T1, T2>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3E30CC0", Offset = "0x3E2FAC0", VA = "0x183E30CC0")]
		public void RpcAllBuffered<T1, T2, T3>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3E306E0", Offset = "0x3E2F4E0", VA = "0x183E306E0")]
		public void RpcAllBuffered<T1, T2, T3, T4>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2FDB0", Offset = "0x3E2EBB0", VA = "0x183E2FDB0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F5A0", Offset = "0x3E2E3A0", VA = "0x183E2F5A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2ECA0", Offset = "0x3E2DAA0", VA = "0x183E2ECA0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E280", Offset = "0x3E2D080", VA = "0x183E2E280")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2DED0", Offset = "0x3E2CCD0", VA = "0x183E2DED0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CBOIHFCDMJP IGCDNMKDJDK, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D370", Offset = "0x3E2C170", VA = "0x183E2D370")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBOIHFCDMJP IGCDNMKDJDK, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C720", Offset = "0x3E2B520", VA = "0x183E2C720")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBOIHFCDMJP IGCDNMKDJDK, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B0A0", Offset = "0x3E29EA0", VA = "0x183E2B0A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CBOIHFCDMJP IGCDNMKDJDK, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A1A0", Offset = "0x3E28FA0", VA = "0x183E2A1A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CBOIHFCDMJP IGCDNMKDJDK, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3E29C50", Offset = "0x3E28A50", VA = "0x183E29C50")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CBOIHFCDMJP IGCDNMKDJDK, CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x81FBBC0", Offset = "0x81FA9C0", VA = "0x1881FBBC0", Slot = "204")]
		public void RpcAllBuffered(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3E31490", Offset = "0x3E30290", VA = "0x183E31490", Slot = "205")]
		public void RpcAllBuffered<T1>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3E31040", Offset = "0x3E2FE40", VA = "0x183E31040", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3E30B00", Offset = "0x3E2F900", VA = "0x183E30B00", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3E308F0", Offset = "0x3E2F6F0", VA = "0x183E308F0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3E30270", Offset = "0x3E2F070", VA = "0x183E30270", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2FB00", Offset = "0x3E2E900", VA = "0x183E2FB00", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F2A0", Offset = "0x3E2E0A0", VA = "0x183E2F2A0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E5E0", Offset = "0x3E2D3E0", VA = "0x183E2E5E0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D770", Offset = "0x3E2C570", VA = "0x183E2D770", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CBOIHFCDMJP IGCDNMKDJDK, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2CF70", Offset = "0x3E2BD70", VA = "0x183E2CF70", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBOIHFCDMJP IGCDNMKDJDK, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BE80", Offset = "0x3E2AC80", VA = "0x183E2BE80", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBOIHFCDMJP IGCDNMKDJDK, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B540", Offset = "0x3E2A340", VA = "0x183E2B540", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CBOIHFCDMJP IGCDNMKDJDK, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A6A0", Offset = "0x3E294A0", VA = "0x183E2A6A0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CBOIHFCDMJP IGCDNMKDJDK, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3E291B0", Offset = "0x3E27FB0", VA = "0x183E291B0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CBOIHFCDMJP IGCDNMKDJDK, CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x81FD3D0", Offset = "0x81FC1D0", VA = "0x1881FD3D0", Slot = "219")]
		public void RpcOthersBuffered(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.BBGKPGKLDCG MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F110", Offset = "0x3E7DF10", VA = "0x183E7F110", Slot = "220")]
		public void RpcOthersBuffered<T1>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OLABBJMHGAP<T1> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EBF0", Offset = "0x3E7D9F0", VA = "0x183E7EBF0", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OKHEIIHGGKP<T1, T2> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E700", Offset = "0x3E7D500", VA = "0x183E7E700", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, T3> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E330", Offset = "0x3E7D130", VA = "0x183E7E330", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, T4> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D7F0", Offset = "0x3E7C5F0", VA = "0x183E7D7F0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, T5> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D290", Offset = "0x3E7C090", VA = "0x183E7D290", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, T6> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C6E0", Offset = "0x3E7B4E0", VA = "0x183E7C6E0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, T7> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BCC0", Offset = "0x3E7AAC0", VA = "0x183E7BCC0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, T8> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B560", Offset = "0x3E7A360", VA = "0x183E7B560", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, T9> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7ADB0", Offset = "0x3E79BB0", VA = "0x183E7ADB0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBOIHFCDMJP IGCDNMKDJDK, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8DD40", Offset = "0x3E8CB40", VA = "0x183E8DD40", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBOIHFCDMJP IGCDNMKDJDK, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D400", Offset = "0x3E8C200", VA = "0x183E8D400", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CBOIHFCDMJP IGCDNMKDJDK, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C560", Offset = "0x3E8B360", VA = "0x183E8C560", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CBOIHFCDMJP IGCDNMKDJDK, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B070", Offset = "0x3E89E70", VA = "0x183E8B070", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CBOIHFCDMJP IGCDNMKDJDK, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x81FD290", Offset = "0x81FC090", VA = "0x1881FD290")]
		public void RpcOthersBuffered(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OLABBJMHGAP<HIMONOOAFHI> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EED0", Offset = "0x3E7DCD0", VA = "0x183E7EED0")]
		public void RpcOthersBuffered<T1>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OKHEIIHGGKP<T1, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EA80", Offset = "0x3E7D880", VA = "0x183E7EA80")]
		public void RpcOthersBuffered<T1, T2>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E540", Offset = "0x3E7D340", VA = "0x183E7E540")]
		public void RpcOthersBuffered<T1, T2, T3>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DF10", Offset = "0x3E7CD10", VA = "0x183E7DF10")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DA50", Offset = "0x3E7C850", VA = "0x183E7DA50")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CFE0", Offset = "0x3E7BDE0", VA = "0x183E7CFE0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C9E0", Offset = "0x3E7B7E0", VA = "0x183E7C9E0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C380", Offset = "0x3E7B180", VA = "0x183E7C380")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HIMONOOAFHI> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B910", Offset = "0x3E7A710", VA = "0x183E7B910")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CBOIHFCDMJP IGCDNMKDJDK, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A5B0", Offset = "0x3E793B0", VA = "0x183E7A5B0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBOIHFCDMJP IGCDNMKDJDK, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A160", Offset = "0x3E78F60", VA = "0x183E7A160")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBOIHFCDMJP IGCDNMKDJDK, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D8A0", Offset = "0x3E8C6A0", VA = "0x183E8D8A0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CBOIHFCDMJP IGCDNMKDJDK, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CA60", Offset = "0x3E8B860", VA = "0x183E8CA60")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CBOIHFCDMJP IGCDNMKDJDK, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B5C0", Offset = "0x3E8A3C0", VA = "0x183E8B5C0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CBOIHFCDMJP IGCDNMKDJDK, CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x81FD330", Offset = "0x81FC130", VA = "0x1881FD330", Slot = "234")]
		public void RpcOthersBuffered(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OLABBJMHGAP<HEBLDOMJFJP> MNDHCKEIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EFF0", Offset = "0x3E7DDF0", VA = "0x183E7EFF0", Slot = "235")]
		public void RpcOthersBuffered<T1>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.OKHEIIHGGKP<T1, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7ED60", Offset = "0x3E7DB60", VA = "0x183E7ED60", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.CKKNEFMEPFO<T1, T2, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E8C0", Offset = "0x3E7D6C0", VA = "0x183E7E8C0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MPLJODGKFIN<T1, T2, T3, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E120", Offset = "0x3E7CF20", VA = "0x183E7E120", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.KKLBNPABLCM<T1, T2, T3, T4, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DCB0", Offset = "0x3E7CAB0", VA = "0x183E7DCB0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.INHIOFKCKBP<T1, T2, T3, T4, T5, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D540", Offset = "0x3E7C340", VA = "0x183E7D540", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.IIENLGLGOIN<T1, T2, T3, T4, T5, T6, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CCE0", Offset = "0x3E7BAE0", VA = "0x183E7CCE0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.LBMDEHDNABJ<T1, T2, T3, T4, T5, T6, T7, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C020", Offset = "0x3E7AE20", VA = "0x183E7C020", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(CBOIHFCDMJP IGCDNMKDJDK, BEOFGIHGFIL.MIEILHFPMNJ<T1, T2, T3, T4, T5, T6, T7, T8, HEBLDOMJFJP> MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B1B0", Offset = "0x3E79FB0", VA = "0x183E7B1B0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CBOIHFCDMJP IGCDNMKDJDK, MKMLOFHLMNJ MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A9B0", Offset = "0x3E797B0", VA = "0x183E7A9B0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CBOIHFCDMJP IGCDNMKDJDK, PKDEEFIEAJL MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E79D10", Offset = "0x3E78B10", VA = "0x183E79D10", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CBOIHFCDMJP IGCDNMKDJDK, HCIEKJKMIGM MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CF60", Offset = "0x3E8BD60", VA = "0x183E8CF60", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CBOIHFCDMJP IGCDNMKDJDK, CCNMGJKBJNA MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C060", Offset = "0x3E8AE60", VA = "0x183E8C060", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CBOIHFCDMJP IGCDNMKDJDK, MCHMNBOMLLP MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BB10", Offset = "0x3E8A910", VA = "0x183E8BB10", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CBOIHFCDMJP IGCDNMKDJDK, CGHGOIMEDBE MNDHCKEIOBG, T1 FOEIHELLMJN, T2 KFEJMDDCMED, T3 JCKJPIJFKID, T4 COENGJKMFGG, T5 JMFMELGIJOC, T6 BIJIJGDIPOG, T7 HOLEIMNAONO, T8 DONAEDFALLF, T9 HJOELHFNPHO, T10 MNPFCNKINEB, T11 FDGEJKHGFIM, T12 DDBKNCNINGM, T13 HBMBAKABGBL, T14 MIHOHBILOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x81F9920", Offset = "0x81F8720", VA = "0x1881F9920", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x81F9B40", Offset = "0x81F8940", VA = "0x1881F9B40", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2003880", Offset = "0x2002680", VA = "0x182003880")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DCOOKBJPIPA
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x81E25B0", Offset = "0x81E13B0", VA = "0x1881E25B0")]
	private static bool MPJGEGGDDLO(ViewId PPPFBKMGIMA, [Out] RRNetworkView LNFFCKNEJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x39E1280", Offset = "0x39E0080", VA = "0x1839E1280")]
	[CanBeNull]
	public static T GHPEJJNLAFE<T>(this ViewId JGOGKOHBDFC)
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
		private sealed class OHHONIKAPEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public CDKFIILELLC[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public OHHONIKAPEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x81F7780", Offset = "0x81F6580", VA = "0x1881F7780")]
			internal int MDHEPLFDDKC(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x81F76F0", Offset = "0x81F64F0", VA = "0x1881F76F0")]
			internal void FNILPCGCOIE(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly PHLHEDGDBJO CFEMPAINFAM;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static CDKFIILELLC[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal int HBHANPMJFEE;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x81FECE0", Offset = "0x81FDAE0", VA = "0x1881FECE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x81FF300", Offset = "0x81FE100", VA = "0x1881FF300")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x81FF6D0", Offset = "0x81FE4D0", VA = "0x1881FF6D0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x81FF750", Offset = "0x81FE550", VA = "0x1881FF750")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x81FEB80", Offset = "0x81FD980", VA = "0x1881FEB80")]
		private void ACDBEIFBKLK(CDKFIILELLC BCMGJKNFJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x81FEB80", Offset = "0x81FD980", VA = "0x1881FEB80")]
		private void DAHBLHHLKPG(CDKFIILELLC OKJANENFBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x81FF210", Offset = "0x81FE010", VA = "0x1881FF210")]
		private void LJFOOGDGLAL(CDKFIILELLC FIHFPAKJDIB, IDictionary<object, object> CHHILENDCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x81FEB90", Offset = "0x81FD990", VA = "0x1881FEB90")]
		public static void AssignPlayerNumbers(int PLDDDAMGMLI, int EMJADOJNPJP, Func<int, int> ALNJOGEBHFE, Action<int, int> EHNOPKBNGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x81FF800", Offset = "0x81FE600", VA = "0x1881FF800")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x81FF120", Offset = "0x81FDF20", VA = "0x1881FF120")]
		private void KMNIGPCOIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA69900", Offset = "0xA68700", VA = "0x180A69900")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IFCHEFIAMDM
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x81EE990", Offset = "0x81ED790", VA = "0x1881EE990")]
	public static int FHAHCJHMNLG(this CDKFIILELLC IFADLDJHCLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x81EE5C0", Offset = "0x81ED3C0", VA = "0x1881EE5C0")]
	public static void DACMEBECKGI(this CDKFIILELLC IFADLDJHCLA, int NDNLAMEEMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class ELGNKBPNPCM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void ILNFNNANEMF(Hashtable MDOGLHGIMLE);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void FLBFGGOACOB(CDKFIILELLC IFADLDJHCLA, Hashtable MDOGLHGIMLE);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event ILNFNNANEMF NIEPOMMGJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x81EB380", Offset = "0x81EA180", VA = "0x1881EB380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x81EB5C0", Offset = "0x81EA3C0", VA = "0x1881EB5C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event ILNFNNANEMF PDKGJLDLIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x81EB200", Offset = "0x81EA000", VA = "0x1881EB200")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x81EB500", Offset = "0x81EA300", VA = "0x1881EB500")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event FLBFGGOACOB JJKIFADFLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x81EB440", Offset = "0x81EA240", VA = "0x1881EB440")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x81EB2C0", Offset = "0x81EA0C0", VA = "0x1881EB2C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event FLBFGGOACOB KBOCNHNKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x81EB740", Offset = "0x81EA540", VA = "0x1881EB740")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x81EB680", Offset = "0x81EA480", VA = "0x1881EB680")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class MHBBDNHFCME
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int FCMLLNMMGBC;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int CFOLJEHAMIP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int OCCIKIEELOE;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x81F3100", Offset = "0x81F1F00", VA = "0x1881F3100")]
	public static void GKMDAHIEKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x81F3400", Offset = "0x81F2200", VA = "0x1881F3400")]
	public static void NHEGFCNMBAF(int[] IMPPJEGHMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x81F3150", Offset = "0x81F1F50", VA = "0x1881F3150")]
	public static int MIHPAFGGIBE(int PONJACDINLH, bool CMECIAGGAMD = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(LMEADPAJPKF), new string[] { })]
public class LMEADPAJPKF : FJBJAPEAIKB, NHPEKAEFMLG, GNJFBAIKFDH
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable IFFNNLCHKJN;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable DCCBABHPAHN;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly Hashtable PJHHKOAFCLI;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly EIIAJLFMPKP FKNPENPBONA;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly EIIAJLFMPKP OLANNBBFGGN;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly EIIAJLFMPKP NADCBFHIEOP;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly EIIAJLFMPKP GCLODPCFPDL;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly EIIAJLFMPKP HHNJOJMEMPE;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int IHEEDCGCENC;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x81F1420", Offset = "0x81F0220", VA = "0x1881F1420", Slot = "18")]
	public void EDDKJIHBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x81F1380", Offset = "0x81F0180", VA = "0x1881F1380", Slot = "19")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x81F1880", Offset = "0x81F0680", VA = "0x1881F1880", Slot = "4")]
	public bool GMANCOEPLLL(OJNEMHDMCGC OAEBFAAHGEJ, bool OLKDDMKGKGN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x81F23B0", Offset = "0x81F11B0", VA = "0x1881F23B0", Slot = "5")]
	public int LIICFCPHPIJ(OJNEMHDMCGC[] KCLCNGHNCCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x81F0F50", Offset = "0x81EFD50", VA = "0x1881F0F50", Slot = "6")]
	public bool BPKJMKKOBOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x81F11E0", Offset = "0x81EFFE0", VA = "0x1881F11E0", Slot = "7")]
	public bool DCIEOFNMBGC(int JGOGKOHBDFC, int BDHGHAPLPLK, bool FKNHIENNAMA, GameObject JLNNGPHDMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x81F15E0", Offset = "0x81F03E0", VA = "0x1881F15E0", Slot = "8")]
	public void FFFGCAKDJII(int BDHGHAPLPLK, [Optional] int? MHIMCDHFMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x81F19C0", Offset = "0x81F07C0", VA = "0x1881F19C0", Slot = "9")]
	public bool HDAKIJIALAJ(BNHAMMLICHE IHKPBFJODHM, [Out] OJNEMHDMCGC NJKFOFPCPIG, bool JIHKPEMLEHL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x81F0760", Offset = "0x81EF560", VA = "0x1881F0760", Slot = "10")]
	public bool AFBBKLOGILC(BNHAMMLICHE IHKPBFJODHM, [Out] int GNLHIAIEOJP, [Out] OJNEMHDMCGC[] KCLCNGHNCCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x81F14C0", Offset = "0x81F02C0", VA = "0x1881F14C0", Slot = "11")]
	public bool ELHMIIJMHLA(BNHAMMLICHE IHKPBFJODHM, [Out] int BDHGHAPLPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x81F28D0", Offset = "0x81F16D0", VA = "0x1881F28D0", Slot = "12")]
	public void NEAOLLGCBEG(BNHAMMLICHE IHKPBFJODHM, [Out] int MLHLNOKBILO, [Out] int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x81F2770", Offset = "0x81F1570", VA = "0x1881F2770", Slot = "13")]
	public void NBMLNIMGIIH(int GNLHIAIEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x81F0FE0", Offset = "0x81EFDE0", VA = "0x1881F0FE0", Slot = "14")]
	public void CACCGKPOOLG(int GNLHIAIEOJP, int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x81F17D0", Offset = "0x81F05D0", VA = "0x1881F17D0", Slot = "15")]
	public void GDADNCJIAND(int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A40", Offset = "0x81EF840", VA = "0x1881F0A40", Slot = "16")]
	public void AKFDEFNPNDB(int[] FOOHLHMKCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x81F2240", Offset = "0x81F1040", VA = "0x1881F2240", Slot = "17")]
	public void IBOKELBCGON(int GNLHIAIEOJP, int BDHGHAPLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x81F0B10", Offset = "0x81EF910", VA = "0x1881F0B10")]
	private static void ANDPFFHIHBO(OJNEMHDMCGC OAEBFAAHGEJ, Hashtable BELKBDIIAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x81F1B30", Offset = "0x81F0930", VA = "0x1881F1B30")]
	private static bool HDAKIJIALAJ(Hashtable BELKBDIIAOC, CDKFIILELLC PHAEOJDOJAP, [Out] OJNEMHDMCGC NJKFOFPCPIG, bool JIHKPEMLEHL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x81F2AB0", Offset = "0x81F18B0", VA = "0x1881F2AB0")]
	private static bool PHDNMCENMOJ(int BDHGHAPLPLK, OJNEMHDMCGC BELKBDIIAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x81F1100", Offset = "0x81EFF00", VA = "0x1881F1100")]
	private static int CPIIKLOOLPA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LMEADPAJPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(OOGHKMEGFCP), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class OOGHKMEGFCP : HAEEPICGHHB, NHPEKAEFMLG, GNJFBAIKFDH
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable NOPFPKPGAKH;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static Hashtable JMBOKCDMPIH;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static EIIAJLFMPKP BEPPIOJKBNI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly EIIAJLFMPKP FODONNLDADP;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x81F7800", Offset = "0x81F6600", VA = "0x1881F7800", Slot = "8")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x81F78A0", Offset = "0x81F66A0", VA = "0x1881F78A0", Slot = "7")]
	public void EDDKJIHBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x81F7940", Offset = "0x81F6740", VA = "0x1881F7940", Slot = "4")]
	public void HLMKHNDKNPD(ViewId JGOGKOHBDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x81F7A30", Offset = "0x81F6830", VA = "0x1881F7A30", Slot = "5")]
	public bool ILCKDLHDIJG(BNHAMMLICHE IHKPBFJODHM, [Out] ViewId JGOGKOHBDFC, [Out] string JAHAECILGDJ, [Out] int MILGEGKGJBE, [Out] object[] FLNLCOLLCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x81F7D90", Offset = "0x81F6B90", VA = "0x1881F7D90", Slot = "6")]
	public void KHHOAAMNLGF(ViewId LNFFCKNEJCB, string JAHAECILGDJ, HGHJNEHJPNI MAGHDGOICLH, CDKFIILELLC IFADLDJHCLA, IJKPDLCOMPD AMAFDDKIFIG, object[] OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public OOGHKMEGFCP()
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
