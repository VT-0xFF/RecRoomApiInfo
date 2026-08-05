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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82A3600", Offset = "0x82A2600", VA = "0x1882A3600", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2317030", Offset = "0x2316030", VA = "0x182317030", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82BA460", Offset = "0x82B9460", VA = "0x1882BA460")]
		private void MNKCLNFPDFM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82BA1F0", Offset = "0x82B91F0", VA = "0x1882BA1F0")]
		private void JFDGNDHPLAM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82BAAC0", Offset = "0x82B9AC0", VA = "0x1882BAAC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82BAB70", Offset = "0x82B9B70", VA = "0x1882BAB70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ILNHMCODLEE
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ONIHMLNNEEF HNLEHANEADB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ONIHMLNNEEF JIIPNHGKCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x829EC20", Offset = "0x829DC20", VA = "0x18829EC20")]
		get
		{
			return default(ONIHMLNNEEF);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EHOOAALNEDB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView ENHBJGICMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KKKGACMDFHO KMHPIBLDLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NGHNNMMLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(LBGMOHOPAOI KKHEEAJBAJM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(HNOIGICAEDD OGECODCBMEN, LBGMOHOPAOI KKHEEAJBAJM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface AKNIDNAMHLN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OFFJCELCDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHLBPKLCKOG(HNOIGICAEDD OGECODCBMEN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LABNBGADOBH(HNOIGICAEDD OGECODCBMEN, LBGMOHOPAOI KKHEEAJBAJM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface IGHCKBBPPKO : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMNFOKHCMAP(EHOOAALNEDB MIHJBNMEMOC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBLNIGGOIJH(EHOOAALNEDB MIHJBNMEMOC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMPOMNOOGCK(OHBJLJBJFEE.CBBPJDDFGFO KGDMJIPLNNO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHJIEGPNNHG();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCPBPCJMDEM(object PHDJPEOAFMD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KKKGACMDFHO : byte
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
public struct HNOIGICAEDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int JJOPMFIJCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint DBGNNDBBMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public double ODMDJLIKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int HIDOCDHAGAE;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NGPNKCHILOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<(ViewId, KKKGACMDFHO), AKNIDNAMHLN> GJMCICPJBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly List<EHOOAALNEDB> KKMAADJHGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HashSet<(ViewId, KKKGACMDFHO)> OHKCOADHAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int EPECPBMJNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public bool CJMFBAFNMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private OHBJLJBJFEE.CBBPJDDFGFO KGDMJIPLNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MemoryStream EGJLKCBPODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly LBGMOHOPAOI COLNCEKGEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LBGMOHOPAOI BIIMOCGHCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private byte[] HBHKJEJEPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float LCLFGCCCKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int HCELOFJLOPE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82AECF0", Offset = "0x82ADCF0", VA = "0x1882AECF0")]
	public NGPNKCHILOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82AD890", Offset = "0x82AC890", VA = "0x1882AD890")]
	public void DMPOMNOOGCK(OHBJLJBJFEE.CBBPJDDFGFO KGDMJIPLNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82AD840", Offset = "0x82AC840", VA = "0x1882AD840")]
	public void CHJIEGPNNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82AE560", Offset = "0x82AD560", VA = "0x1882AE560")]
	public void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82AD8B0", Offset = "0x82AC8B0", VA = "0x1882AD8B0")]
	public bool DOPEKGIEJEC(EHOOAALNEDB MIHJBNMEMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82AE1A0", Offset = "0x82AD1A0", VA = "0x1882AE1A0")]
	public bool LKIPLGLLFFP(EHOOAALNEDB MIHJBNMEMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82AE340", Offset = "0x82AD340", VA = "0x1882AE340")]
	private AKNIDNAMHLN PGANCLBFJDL(ViewId FKHACEBFNLD, KKKGACMDFHO JAAFBJOGJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82AE2D0", Offset = "0x82AD2D0", VA = "0x1882AE2D0")]
	public void MEHBIPNJCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82AE2E0", Offset = "0x82AD2E0", VA = "0x1882AE2E0")]
	private void NGIKJMKDBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82ADDD0", Offset = "0x82ACDD0", VA = "0x1882ADDD0")]
	private void FBOLCJNBEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82AE940", Offset = "0x82AD940", VA = "0x1882AE940")]
	public bool PNIIEBMMICI(FastBufferWriter NMCAGOGLPLD, int LLHIJCFMLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82ADDF0", Offset = "0x82ACDF0", VA = "0x1882ADDF0")]
	public void LABNBGADOBH(HNOIGICAEDD OGECODCBMEN, FastBufferReader AMPJMGIAGBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class JMAKJJDKIOI : AKNIDNAMHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private EHOOAALNEDB LIAONDJBLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private uint FHPBNDINPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int HFLNEKHHMII;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OFFJCELCDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public JMAKJJDKIOI(EHOOAALNEDB LIAONDJBLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82A2B80", Offset = "0x82A1B80", VA = "0x1882A2B80", Slot = "5")]
	public bool IHLBPKLCKOG(HNOIGICAEDD OGECODCBMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82A2C90", Offset = "0x82A1C90", VA = "0x1882A2C90", Slot = "6")]
	public void LABNBGADOBH(HNOIGICAEDD OGECODCBMEN, LBGMOHOPAOI KKHEEAJBAJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DKLICLGCFJP : AKNIDNAMHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OHBJLJBJFEE.CBBPJDDFGFO KGDMJIPLNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ViewId FKHACEBFNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int HFLNEKHHMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private uint FHPBNDINPDG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OFFJCELCDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1BF6BA0", Offset = "0x1BF5BA0", VA = "0x181BF6BA0")]
	public DKLICLGCFJP(ViewId FKHACEBFNLD, OHBJLJBJFEE.CBBPJDDFGFO KGDMJIPLNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x829D370", Offset = "0x829C370", VA = "0x18829D370", Slot = "5")]
	public bool IHLBPKLCKOG(HNOIGICAEDD OGECODCBMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x829D3B0", Offset = "0x829C3B0", VA = "0x18829D3B0", Slot = "6")]
	public void LABNBGADOBH(HNOIGICAEDD OGECODCBMEN, LBGMOHOPAOI KKHEEAJBAJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HLJNEPIKIEC
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x829E530", Offset = "0x829D530", VA = "0x18829E530")]
	public static void FBGBLPHHDGN(this BJLFHMKMEJE FOKDCDPHAON, LBGMOHOPAOI DADLBKBGKLK, ViewId IEGLIFIOOBM, bool EDILEMKEEMM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x829E030", Offset = "0x829D030", VA = "0x18829E030")]
	public static void DMMMAEDEECK(this BJLFHMKMEJE FOKDCDPHAON, LBGMOHOPAOI DADLBKBGKLK, bool EDILEMKEEMM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x829E6F0", Offset = "0x829D6F0", VA = "0x18829E6F0")]
	public static BJLFHMKMEJE LABNBGADOBH(LBGMOHOPAOI DADLBKBGKLK, ViewId IEGLIFIOOBM, bool EDILEMKEEMM = true)
	{
		return default(BJLFHMKMEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x829E860", Offset = "0x829D860", VA = "0x18829E860")]
	public static void OALKALOBDGD(this BJLFHMKMEJE FOKDCDPHAON, LBGMOHOPAOI DADLBKBGKLK, bool EDILEMKEEMM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(IGHCKBBPPKO), new string[] { })]
public class BGLNMCHCNHI : IGHCKBBPPKO, INetworkUpdateSystem, LHEPLCJNPLE, MEIFILLJDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly ONIHMLNNEEF NMOLGGNFDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NGPNKCHILOH LEHKBBINLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private uint IINHPIHKCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float HJOMBPLNIDO;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8298CC0", Offset = "0x8297CC0", VA = "0x188298CC0", Slot = "4")]
	public void AMNFOKHCMAP(EHOOAALNEDB MIHJBNMEMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8299820", Offset = "0x8298820", VA = "0x188299820", Slot = "5")]
	public void JBLNIGGOIJH(EHOOAALNEDB MIHJBNMEMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8299A20", Offset = "0x8298A20", VA = "0x188299A20", Slot = "10")]
	public void MGLFJJLMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8299B80", Offset = "0x8298B80", VA = "0x188299B80", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage LANPLGKBFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8299250", Offset = "0x8298250", VA = "0x188299250")]
	private void ILEBOJBEDDE(uint DMDBJANCBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82991C0", Offset = "0x82981C0", VA = "0x1882991C0", Slot = "6")]
	public void DMPOMNOOGCK(OHBJLJBJFEE.CBBPJDDFGFO KGDMJIPLNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8299160", Offset = "0x8298160", VA = "0x188299160", Slot = "7")]
	public void CHJIEGPNNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82991F0", Offset = "0x82981F0", VA = "0x1882991F0", Slot = "8")]
	public void GCPBPCJMDEM(object NPMBPMNFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8298DE0", Offset = "0x8297DE0", VA = "0x188298DE0")]
	private void BNMKLKKGILL(PMOFBKDCPEL NPMBPMNFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8299C00", Offset = "0x8298C00", VA = "0x188299C00", Slot = "11")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8299D20", Offset = "0x8298D20", VA = "0x188299D20")]
	public BGLNMCHCNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KNJGEALCKMH : AKNIDNAMHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private float GHGGPLBNJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HFLNEKHHMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private uint FHPBNDINPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly KKKGACMDFHO PKBMPCNDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HNOIGICAEDD JLMBNPEHLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int ICLAGMGALCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte[] PHEKBFAAAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private HNOIGICAEDD EICDFPNNLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int MNMDMCOEGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private byte[] KOFDCELDHJD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OFFJCELCDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82A2D70", Offset = "0x82A1D70", VA = "0x1882A2D70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82A3270", Offset = "0x82A2270", VA = "0x1882A3270")]
	public KNJGEALCKMH(KKKGACMDFHO PKBMPCNDPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82A2DA0", Offset = "0x82A1DA0", VA = "0x1882A2DA0", Slot = "5")]
	public bool IHLBPKLCKOG(HNOIGICAEDD OGECODCBMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82A2EF0", Offset = "0x82A1EF0", VA = "0x1882A2EF0", Slot = "6")]
	public void LABNBGADOBH(HNOIGICAEDD OGECODCBMEN, LBGMOHOPAOI KKHEEAJBAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82A2DE0", Offset = "0x82A1DE0", VA = "0x1882A2DE0")]
	internal JMAKJJDKIOI KOOOBCJJLMF(EHOOAALNEDB MIHJBNMEMOC, LBGMOHOPAOI DADLBKBGKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82A30A0", Offset = "0x82A20A0", VA = "0x1882A30A0")]
	private static void NNPDMPLKNEP(JMAKJJDKIOI FONCFPDNHDL, LBGMOHOPAOI DADLBKBGKLK, HNOIGICAEDD GCAHCHBCANI, byte[] MPPMMFHHGAK, int CKPCKINNAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(OLMGBMIPOOA), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class OLMGBMIPOOA : PKLFDEMCFPI, LHEPLCJNPLE, MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable KNOCLJMGHFL;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable KKFDHEFDBIP;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly Hashtable HDMOGGFMPPB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly NDFFKECCNKF FCFKHOPCDKK;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly NDFFKECCNKF BOBAEKEGEEC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly NDFFKECCNKF EAHOKJBEJKF;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly NDFFKECCNKF NNMKOCHIKFC;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly NDFFKECCNKF AAFNLKDIKGI;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int LABCJPEAOEA;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82B0690", Offset = "0x82AF690", VA = "0x1882B0690", Slot = "4")]
	public bool FCJHEFCOOKJ(JPLLLGDDHLG OGEALFKCCAP, bool EBMFINCHICL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x82B10F0", Offset = "0x82B00F0", VA = "0x1882B10F0", Slot = "5")]
	public int MGKAPLAFBKC(JPLLLGDDHLG[] DONGFMGPGAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82B09C0", Offset = "0x82AF9C0", VA = "0x1882B09C0", Slot = "6")]
	public bool GDKBEPFGJII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x82B0F50", Offset = "0x82AFF50", VA = "0x1882B0F50", Slot = "7")]
	public bool LHMKDLCHGJG(int FKHACEBFNLD, int NBLGAILFCHC, bool KNCGDJFCBKK, GameObject GLGAAAMILBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82B1CA0", Offset = "0x82B0CA0", VA = "0x1882B1CA0", Slot = "8")]
	public void MKFNKOBAMBM(int NBLGAILFCHC, [Optional] int? PBGEPNGBHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82B1550", Offset = "0x82B0550", VA = "0x1882B1550", Slot = "9")]
	public bool MJNHLACGDFH(PMOFBKDCPEL PHDJPEOAFMD, [Out] JPLLLGDDHLG BBABGPFNELB, bool JPIFAGBGBNP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82B0C70", Offset = "0x82AFC70", VA = "0x1882B0C70", Slot = "10")]
	public bool JIDDLHNLMHE(PMOFBKDCPEL PHDJPEOAFMD, [Out] int GFMHNEFFLCK, [Out] JPLLLGDDHLG[] DONGFMGPGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82B0490", Offset = "0x82AF490", VA = "0x1882B0490", Slot = "11")]
	public bool DOPGAGHBJPJ(PMOFBKDCPEL PHDJPEOAFMD, [Out] int NBLGAILFCHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82AFE70", Offset = "0x82AEE70", VA = "0x1882AFE70", Slot = "12")]
	public void DGFMJNOLICD(PMOFBKDCPEL PHDJPEOAFMD, [Out] int HDHDICGBNAD, [Out] int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82AFD10", Offset = "0x82AED10", VA = "0x1882AFD10", Slot = "13")]
	public void AECKHLIBLHJ(int GFMHNEFFLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82B08A0", Offset = "0x82AF8A0", VA = "0x1882B08A0", Slot = "14")]
	public void FGMFOLODKBE(int GFMHNEFFLCK, int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82B0BC0", Offset = "0x82AFBC0", VA = "0x1882B0BC0", Slot = "15")]
	public void HHAGBPHAAAP(int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82B07D0", Offset = "0x82AF7D0", VA = "0x1882B07D0", Slot = "16")]
	public void FELPCCCAIMA(int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82B0A50", Offset = "0x82AFA50", VA = "0x1882B0A50", Slot = "17")]
	public void GIFJPJNOCKD(int GFMHNEFFLCK, int NBLGAILFCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82B0050", Offset = "0x82AF050", VA = "0x1882B0050")]
	private static void DHJGINCFHGH(JPLLLGDDHLG OGEALFKCCAP, Hashtable EEEAAFAMLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82B16C0", Offset = "0x82B06C0", VA = "0x1882B16C0")]
	private static bool MJNHLACGDFH(Hashtable EEEAAFAMLLD, IALDHONKEJC DAKOFAPAGCA, [Out] JPLLLGDDHLG BBABGPFNELB, bool JPIFAGBGBNP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82B05B0", Offset = "0x82AF5B0", VA = "0x1882B05B0")]
	private static int DPMPIJBGJDB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82B14B0", Offset = "0x82B04B0", VA = "0x1882B14B0", Slot = "18")]
	public void MGLFJJLMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82B1E90", Offset = "0x82B0E90", VA = "0x1882B1E90", Slot = "19")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OLMGBMIPOOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(NKDDNAMOJLO), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class NKDDNAMOJLO : FPALJLNJIEN, LHEPLCJNPLE, MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable PLCJOJDDHKK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static Hashtable HECIFOFLJNC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static NDFFKECCNKF CDOAKJHFAPN;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly NDFFKECCNKF GKMEKAPKKAC;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82AF270", Offset = "0x82AE270", VA = "0x1882AF270", Slot = "4")]
	public void JNFLJIPKEIM(ViewId FKHACEBFNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82AEF10", Offset = "0x82ADF10", VA = "0x1882AEF10", Slot = "5")]
	public bool JMPBGIHHFOH(PMOFBKDCPEL PHDJPEOAFMD, [Out] ViewId FKHACEBFNLD, [Out] string PGEDMIEEBID, [Out] int DDNKPFFNBPO, [Out] object[] GHNOIAMBGEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82AF400", Offset = "0x82AE400", VA = "0x1882AF400", Slot = "6")]
	public void NHJBKCLABIG(ViewId GBKCMPDBPJK, string PGEDMIEEBID, OLHLIDNBNCP EIGJCNKKPKC, IALDHONKEJC MFOAOKBDIIM, JKPDADGJJHJ LJKPKJJEMGM, object[] OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82AF9D0", Offset = "0x82AE9D0", VA = "0x1882AF9D0", Slot = "8")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82AF360", Offset = "0x82AE360", VA = "0x1882AF360", Slot = "7")]
	public void MGLFJJLMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NKDDNAMOJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OJHBMNNLEOI
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82AFC30", Offset = "0x82AEC30", VA = "0x1882AFC30")]
	public static IALDHONKEJC AMDGFPNAIHP(this DOHKIBLNJFC KJENEIANJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82AFCC0", Offset = "0x82AECC0", VA = "0x1882AFCC0")]
	public static DOHKIBLNJFC PJJBKKOIMOD(this IALDHONKEJC MFOAOKBDIIM)
	{
		return default(DOHKIBLNJFC);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, EJEAGEEEHNF, NFAMKCPLNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<BONJPBBBMJP> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId BGAJFIDHOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x82B2990", Offset = "0x82B1990", VA = "0x1882B2990")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId MGADKAAPMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x82B2990", Offset = "0x82B1990", VA = "0x1882B2990", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView ELAKGDCNKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x82B2A10", Offset = "0x82B1A10", VA = "0x1882B2A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView ENHBJGICMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x82B2A10", Offset = "0x82B1A10", VA = "0x1882B2A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IALDHONKEJC PCJBDONIEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x82B2B10", Offset = "0x82B1B10", VA = "0x1882B2B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IALDHONKEJC FICFFHNKAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x82B2E70", Offset = "0x82B1E70", VA = "0x1882B2E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FDIJEJPNHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82B2C70", Offset = "0x82B1C70", VA = "0x1882B2C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NLPLDCBLDMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x82B2DE0", Offset = "0x82B1DE0", VA = "0x1882B2DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JAKKBFPCBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x82B28C0", Offset = "0x82B18C0", VA = "0x1882B28C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HADFCKGAKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x82B2BA0", Offset = "0x82B1BA0", VA = "0x1882B2BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool ABFKKPMLEEN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x82B28C0", Offset = "0x82B18C0", VA = "0x1882B28C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool AIFLLPDOOLN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x82B2940", Offset = "0x82B1940", VA = "0x1882B2940", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string EHJDKNHEDIO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x82B2A80", Offset = "0x82B1A80", VA = "0x1882B2A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool PJPHCJGPLCK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x82B2840", Offset = "0x82B1840", VA = "0x1882B2840", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<IALDHONKEJC> LEPKFAFOPIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x82B2710", Offset = "0x82B1710", VA = "0x1882B2710")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x82B2F00", Offset = "0x82B1F00", VA = "0x1882B2F00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82B2670", Offset = "0x82B1670", VA = "0x1882B2670")]
		public bool WasSpawnedForPlayer(int KNOJKGKOBBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x75BC1E0", Offset = "0x75BB1E0", VA = "0x1875BC1E0")]
		private void OEGFEPNDEFD(RRNetworkView CIABMLDDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x82B2250", Offset = "0x82B1250", VA = "0x1882B2250", Slot = "9")]
		public void RegisterDestroyHandler(BONJPBBBMJP NCAIPIHIMAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82B24A0", Offset = "0x82B14A0", VA = "0x1882B24A0", Slot = "10")]
		public void UnregisterDestroyHandler(BONJPBBBMJP NCAIPIHIMAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x82B2230", Offset = "0x82B1230", VA = "0x1882B2230", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MLOJMKKPMLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void GFEBJHIOLKO([In] JPLLLGDDHLG OGEALFKCCAP, bool BKPEODADMPF, bool EEEAAFAMLLD, bool EHCLBECEGIF);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void EJHHAKNDJFA(GameObject NCNIBCLAAID);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void CNGODNCKNJB(GameObject NCNIBCLAAID);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void POMDLNKNAAJ(RRNetworkView GBKCMPDBPJK, string PGEDMIEEBID, IALDHONKEJC AOLDFGCJAAE, OLHLIDNBNCP? AOJAHPGAGPO, bool IOKJLGLFJPA, JKPDADGJJHJ JPFCGKEELBF, object[] OGEALFKCCAP, string JHKDPNLMPLL);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void AFCIPGGBMDC(RRNetworkView GBKCMPDBPJK, string PGEDMIEEBID, IALDHONKEJC AOLDFGCJAAE, OLHLIDNBNCP? AOJAHPGAGPO, bool IOKJLGLFJPA, JKPDADGJJHJ JPFCGKEELBF, object[] OGEALFKCCAP, string JHKDPNLMPLL);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void KOLIBJNGHJM(RRNetworkView GBKCMPDBPJK, string PGEDMIEEBID, object[] GHNOIAMBGEA, string HDIDOPIAMCO);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void ACBGIAFAGFJ(RRNetworkView GBKCMPDBPJK, IALDHONKEJC FJFKJKFEHDA);

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CompilerGenerated]
	private static EJHHAKNDJFA LDIPFNGIIFF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event GFEBJHIOLKO NEJAGEJKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82A4350", Offset = "0x82A3350", VA = "0x1882A4350")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x82A3D80", Offset = "0x82A2D80", VA = "0x1882A3D80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event EJHHAKNDJFA AHONGINGMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x82A4050", Offset = "0x82A3050", VA = "0x1882A4050")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x82A41D0", Offset = "0x82A31D0", VA = "0x1882A41D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event CNGODNCKNJB DPLENPMDCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82A3CC0", Offset = "0x82A2CC0", VA = "0x1882A3CC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82A47A0", Offset = "0x82A37A0", VA = "0x1882A47A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event CNGODNCKNJB KIGKGFCHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82A4290", Offset = "0x82A3290", VA = "0x1882A4290")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x82A3F90", Offset = "0x82A2F90", VA = "0x1882A3F90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event POMDLNKNAAJ JNMHNDJBAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x82A3AB0", Offset = "0x82A2AB0", VA = "0x1882A3AB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82A38F0", Offset = "0x82A28F0", VA = "0x1882A38F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event AFCIPGGBMDC OOOMPJHENEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82A4860", Offset = "0x82A3860", VA = "0x1882A4860")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82A4BB0", Offset = "0x82A3BB0", VA = "0x1882A4BB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event KOLIBJNGHJM GLIHMHNGFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82A4110", Offset = "0x82A3110", VA = "0x1882A4110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82A46E0", Offset = "0x82A36E0", VA = "0x1882A46E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event ACBGIAFAGFJ GLGKLPJGIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82A3B70", Offset = "0x82A2B70", VA = "0x1882A3B70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82A3E40", Offset = "0x82A2E40", VA = "0x1882A3E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event ACBGIAFAGFJ CPHNNGIJDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82A4920", Offset = "0x82A3920", VA = "0x1882A4920")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x82A4620", Offset = "0x82A3620", VA = "0x1882A4620")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82A4410", Offset = "0x82A3410", VA = "0x1882A4410")]
	public static void KECHJLHMMLJ([In] JPLLLGDDHLG OGEALFKCCAP, bool BKPEODADMPF, bool EEEAAFAMLLD, bool EHCLBECEGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82A49E0", Offset = "0x82A39E0", VA = "0x1882A49E0")]
	public static void MJBCMOFBFEM(GameObject NCNIBCLAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x82A3F00", Offset = "0x82A2F00", VA = "0x1882A3F00")]
	public static void DEMFBPGCFFA(GameObject NCNIBCLAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82A3860", Offset = "0x82A2860", VA = "0x1882A3860")]
	public static void AGAOOCDFJFI(GameObject NCNIBCLAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82A3C30", Offset = "0x82A2C30", VA = "0x1882A3C30")]
	public static void BOALDIPNBNN(GameObject NCNIBCLAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x82A44D0", Offset = "0x82A34D0", VA = "0x1882A44D0")]
	public static void LGOOGIJCDIH(RRNetworkView GBKCMPDBPJK, string PGEDMIEEBID, IALDHONKEJC AOLDFGCJAAE, OLHLIDNBNCP? AOJAHPGAGPO, bool IOKJLGLFJPA, JKPDADGJJHJ JPFCGKEELBF, object[] OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x82A4A70", Offset = "0x82A3A70", VA = "0x1882A4A70")]
	public static void MNEADDDFNMD(RRNetworkView GBKCMPDBPJK, string PGEDMIEEBID, int KIMKOHJLGDI, object[] GHNOIAMBGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x82A39B0", Offset = "0x82A29B0", VA = "0x1882A39B0")]
	public static void ANDAKGILOBK(int FKHACEBFNLD, int KJENEIANJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LAJMGKNLFJI
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x82A3550", Offset = "0x82A2550", VA = "0x1882A3550")]
	[CanBeNull]
	private static bool OANKHECGEGA(ViewId PBJHGGBBAAF, [Out] RRNetworkView GBKCMPDBPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x82A33A0", Offset = "0x82A23A0", VA = "0x1882A33A0")]
	[CanBeNull]
	public static Component BHALOABIPGM(this ViewId GBKCMPDBPJK, Type FPENJCCAGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D8F0", Offset = "0x3D4C8F0", VA = "0x183D4D8F0")]
	[CanBeNull]
	public static T BHALOABIPGM<T>(this ViewId GBKCMPDBPJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D8F0", Offset = "0x3D4C8F0", VA = "0x183D4D8F0")]
	[CanBeNull]
	public static T GGLPHOIBKMM<T>(this ViewId GBKCMPDBPJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D940", Offset = "0x3D4C940", VA = "0x183D4D940")]
	public static bool GBOPNDPGABF<T>(this ViewId GBKCMPDBPJK, [Out] T BGOCMPMGKKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x82A3480", Offset = "0x82A2480", VA = "0x1882A3480")]
	[CanBeNull]
	public static RRNetworkView BMDLPJELJAG(this ViewId GBKCMPDBPJK)
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
		private static RRNetworkHandler KLKDHLJDBBB;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler KONBGMLOLPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x82B3030", Offset = "0x82B2030", VA = "0x1882B3030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x82B3200", Offset = "0x82B2200", VA = "0x1882B3200")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x82B31C0", Offset = "0x82B21C0", VA = "0x1882B31C0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(NGCLDOFJJIO), new string[] { "Photon" })]
public sealed class NGCLDOFJJIO : KDHAPJJKIPL, LHEPLCJNPLE, MEIFILLJDCJ, FOONNKPJAPP, EEIGNHCPHDL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FJDEKEELAMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public FJDEKEELAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x829D970", Offset = "0x829C970", VA = "0x18829D970")]
		internal object CLNCOOPIBMD((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static ONIHMLNNEEF GFHJFMEBEFO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static ONIHMLNNEEF MCNAABMKFNB;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, HashSet<int>> OCLGNNHMEBE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static Dictionary<int, int> BJEAGNFDMDG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<(GameObject GameObject, int ParentCount)> JBLBOINCEFP;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GameObject> APBJIHDJINO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static List<int> LAFFAHEMKKO;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<RRNetworkView> CDLPPKBKOOD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly NDFFKECCNKF NNMKOCHIKFC;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly NDFFKECCNKF AAFNLKDIKGI;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82AAA10", Offset = "0x82A9A10", VA = "0x1882AAA10", Slot = "8")]
	public void MGLFJJLMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x82AD0D0", Offset = "0x82AC0D0", VA = "0x1882AD0D0", Slot = "9")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82A97C0", Offset = "0x82A87C0", VA = "0x1882A97C0", Slot = "10")]
	public void InitExternal(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x82A7880", Offset = "0x82A6880", VA = "0x1882A7880", Slot = "11")]
	public void GKILICICKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x82A8FF0", Offset = "0x82A7FF0", VA = "0x1882A8FF0")]
	private void IDOMEMFJAHP(FLDLPBKPFFI OGIDGEBPOEM, FLDLPBKPFFI GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82A4E20", Offset = "0x82A3E20", VA = "0x1882A4E20")]
	private void ADPLKFECGGD(MIAOEPNMDKA IFGHLENOIBG, MIAOEPNMDKA JHMJBKIJIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x82ACEF0", Offset = "0x82ABEF0", VA = "0x1882ACEF0")]
	public GameObject PKLPDIEKKMJ(string HJLBILHBIIC, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, Vector3 AJNABLFIHCD, ViewId FKHACEBFNLD, ENKCMKGNHEJ OGEALFKCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x82A53E0", Offset = "0x82A43E0", VA = "0x1882A53E0")]
	public GameObject AHKKAHMMDDJ(string HJLBILHBIIC, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float AJNABLFIHCD, object[] OGEALFKCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x82A5880", Offset = "0x82A4880", VA = "0x1882A5880")]
	public GameObject DJJNPICIJEP(string HJLBILHBIIC, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, Vector3 AJNABLFIHCD, ViewId GBKCMPDBPJK, ENKCMKGNHEJ OGEALFKCCAP, bool EHCLBECEGIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x82AA600", Offset = "0x82A9600", VA = "0x1882AA600")]
	public GameObject LGCNPKLLCGO(JPLLLGDDHLG OGEALFKCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x82ACC00", Offset = "0x82ABC00", VA = "0x1882ACC00", Slot = "6")]
	public void PEJPNBPHFAH(GameObject NCNIBCLAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x82A6230", Offset = "0x82A5230", VA = "0x1882A6230")]
	public void FDHEEKGCKDE(GameObject GLGAAAMILBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x82A5B50", Offset = "0x82A4B50", VA = "0x1882A5B50", Slot = "7")]
	public void DLJIFDLNJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x82AA2D0", Offset = "0x82A92D0", VA = "0x1882AA2D0", Slot = "4")]
	public GameObject[] LCOBEONOFAH(IList<KNNJGEFDCOE> EJNMOKIGKGF, bool CEGGHPAKECJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82A4F20", Offset = "0x82A3F20", VA = "0x1882A4F20", Slot = "5")]
	public void AEIFINEJKLB(List<GameObject> KINOPACNLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x82A4D40", Offset = "0x82A3D40", VA = "0x1882A4D40")]
	public void ABPMOHOFPNE(GameObject GLGAAAMILBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x82A5580", Offset = "0x82A4580", VA = "0x1882A5580")]
	private void BNMKLKKGILL(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x82A6060", Offset = "0x82A5060", VA = "0x1882A6060")]
	private void FCDIGFEEDBD(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x82A5B60", Offset = "0x82A4B60", VA = "0x1882A5B60")]
	private void ECGEHPHPCAL(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x82AA730", Offset = "0x82A9730", VA = "0x1882AA730")]
	private void MBHNHAEILMI(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x82ABF80", Offset = "0x82AAF80", VA = "0x1882ABF80")]
	private void MJHMDDDANFJ(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x82A8BF0", Offset = "0x82A7BF0", VA = "0x1882A8BF0")]
	private void HLEMALPHFGK(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x82A8560", Offset = "0x82A7560", VA = "0x1882A8560")]
	private void HCMCJKJPJNG(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x82AAE60", Offset = "0x82A9E60", VA = "0x1882AAE60")]
	private GameObject MHPCDMBJAIH(string NIMMNBBALAD, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, Vector3 AJNABLFIHCD, byte HNLEHANEADB = 0, [Optional] object[] INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x82A7A50", Offset = "0x82A6A50", VA = "0x1882A7A50")]
	private GameObject HCBDPHFAHPE(JPLLLGDDHLG OGEALFKCCAP, bool BKPEODADMPF = false, bool EEEAAFAMLLD = false, bool EHCLBECEGIF = true, bool FMHOOAMMNDH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x82AAD80", Offset = "0x82A9D80", VA = "0x1882AAD80")]
	private static GameObject MHAJHDKBMFK(string NIMMNBBALAD, bool IFMNLGKKKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x82AC340", Offset = "0x82AB340", VA = "0x1882AC340")]
	private static GameObject NIAJMLODICP(GameObject OCKHDKNFOGO, JPLLLGDDHLG OGEALFKCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x82A6F70", Offset = "0x82A5F70", VA = "0x1882A6F70")]
	private static void FOIFENEHNFK(GameObject NCNIBCLAAID, RRNetworkView GBKCMPDBPJK, [In] JPLLLGDDHLG OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82A7080", Offset = "0x82A6080", VA = "0x1882A7080")]
	private GameObject[] GJCCBILKKNP(IList<KNNJGEFDCOE> EJNMOKIGKGF, bool CEGGHPAKECJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82A9110", Offset = "0x82A8110", VA = "0x1882A9110")]
	private GameObject[] IIEFLFDELLP(JPLLLGDDHLG[] DONGFMGPGAG, int GFMHNEFFLCK, IALDHONKEJC MFOAOKBDIIM, GameObject[] EOHDBJALKJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82A8150", Offset = "0x82A7150", VA = "0x1882A8150")]
	private GameObject HCJMDIEGHON([In] JPLLLGDDHLG OGEALFKCCAP, GameObject OCKHDKNFOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x75A1610", Offset = "0x75A0610", VA = "0x1875A1610")]
	private static bool AHGJKLJCPLH(bool BKPEODADMPF, bool EHCLBECEGIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82A62A0", Offset = "0x82A52A0", VA = "0x1882A62A0")]
	private void FFGONGKBAJI(IEnumerable<GameObject> KINOPACNLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x82AB050", Offset = "0x82AA050", VA = "0x1882AB050")]
	private void MIHELPJIKFI(GameObject NCNIBCLAAID, bool FMHOOAMMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x82A93C0", Offset = "0x82A83C0", VA = "0x1882A93C0")]
	private static void IJEFKPBDPPD(IEnumerable<GameObject> ACPLPPFJOJI, List<(GameObject GameObject, int ParentCount)> LBNBNGEKCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x82ACAA0", Offset = "0x82ABAA0", VA = "0x1882ACAA0")]
	private void OOMIEEDACMH(int NBLGAILFCHC, int GFMHNEFFLCK, bool FMHOOAMMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82A6ED0", Offset = "0x82A5ED0", VA = "0x1882A6ED0")]
	private static int FIJNIADBCBK(int NBLGAILFCHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x82AAE00", Offset = "0x82A9E00", VA = "0x1882AAE00")]
	private void MHDIDOCEPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x82AC550", Offset = "0x82AB550", VA = "0x1882AC550")]
	private void OKONPHOHIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82A9990", Offset = "0x82A8990", VA = "0x1882A9990")]
	private static int JAGFMEKOMOJ(int IJIDDFFALKB, bool EHCLBECEGIF = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82A5300", Offset = "0x82A4300", VA = "0x1882A5300")]
	private static int[] AHCKGCHAJAH(int NLBJDAPGCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x82A99F0", Offset = "0x82A89F0", VA = "0x1882A99F0")]
	private static int[] JPCPCNMMGOD(int FICFFHNKAMC, int NLBJDAPGCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x82A5B10", Offset = "0x82A4B10", VA = "0x1882A5B10")]
	private void DKJJDCIGHLD(IALDHONKEJC IFFACPNEAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x82A9AF0", Offset = "0x82A8AF0", VA = "0x1882A9AF0")]
	private void KKNHOOFNEOJ(IALDHONKEJC MFOAOKBDIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x82ACC10", Offset = "0x82ABC10", VA = "0x1882ACC10")]
	private void PHPNGGALOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x82A5E20", Offset = "0x82A4E20", VA = "0x1882A5E20")]
	private void EPJHHFNBAGI(IALDHONKEJC MFOAOKBDIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x82A54E0", Offset = "0x82A44E0", VA = "0x1882A54E0")]
	private static void BCIGBDLMHIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x82AA630", Offset = "0x82A9630", VA = "0x1882AA630")]
	private void LMOBNJHHIPE(int[] KKHOLNKACDI, int JJCDNJMOBMC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NGCLDOFJJIO()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(JLKPCEIDEDL), new string[] { "Photon" })]
public class JLKPCEIDEDL : LHEPLCJNPLE, MEIFILLJDCJ, BMNIFEMEAEI
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct EHAABEIDNDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MethodInfo NKGHCFOKFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Func<MonoBehaviour, object> JEDNHMHDDAP;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
		public EHAABEIDNDJ(MethodInfo NKGHCFOKFBM, [Optional] Func<MonoBehaviour, object> JEDNHMHDDAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x75879E0", Offset = "0x75869E0", VA = "0x1875879E0")]
		public object ICNNHHLECKD(MonoBehaviour GGAIDEBJGGH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MOBCBDKNFCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MOBCBDKNFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82A4C70", Offset = "0x82A3C70", VA = "0x1882A4C70")]
		internal EHAABEIDNDJ FNICECPFINL(MethodInfo methodInfo)
		{
			return default(EHAABEIDNDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x49A4D70", Offset = "0x49A3D70", VA = "0x1849A4D70")]
		internal object AOPCLNAHJNP(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OGJKPMMDMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OGJKPMMDMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7587AD0", Offset = "0x7586AD0", VA = "0x187587AD0")]
		internal EHAABEIDNDJ BEIJILOJLAG(MethodInfo methodInfo)
		{
			return default(EHAABEIDNDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JDIKPOALICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public JDIKPOALICL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x829ECE0", Offset = "0x829DCE0", VA = "0x18829ECE0")]
		internal bool CDHOCBCENEH(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Stopwatch LMAMALHAFOE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Dictionary<MethodInfo, ParameterInfo[]> NACHDCLHHKE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<Type, List<EHAABEIDNDJ>> FABNFCGKMJA;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x82A1D00", Offset = "0x82A0D00", VA = "0x1882A1D00", Slot = "4")]
	public void MGLFJJLMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x82A2830", Offset = "0x82A1830", VA = "0x1882A2830", Slot = "5")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x82A0A60", Offset = "0x829FA60", VA = "0x1882A0A60")]
	private void BNMKLKKGILL(PMOFBKDCPEL PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D10", Offset = "0x829FD10", VA = "0x1882A0D10", Slot = "9")]
	public string EOPPEHAFJOE(PMOFBKDCPEL PHDJPEOAFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x82A1B20", Offset = "0x82A0B20", VA = "0x1882A1B20", Slot = "8")]
	public void JNFLJIPKEIM(ViewId FKHACEBFNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D70", Offset = "0x829FD70", VA = "0x1882A0D70", Slot = "6")]
	public void EPLIGMFHLAB(ViewId GBKCMPDBPJK, string PGEDMIEEBID, IALDHONKEJC MFOAOKBDIIM, JKPDADGJJHJ JPFCGKEELBF, params object[] OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D40", Offset = "0x829FD40", VA = "0x1882A0D40", Slot = "7")]
	public void EPLIGMFHLAB(ViewId GBKCMPDBPJK, string PGEDMIEEBID, OLHLIDNBNCP AOJAHPGAGPO, JKPDADGJJHJ JPFCGKEELBF, params object[] OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x82A0E40", Offset = "0x829FE40", VA = "0x1882A0E40")]
	private void EPLIGMFHLAB(ViewId GBKCMPDBPJK, string PGEDMIEEBID, OLHLIDNBNCP AOJAHPGAGPO, IALDHONKEJC MFOAOKBDIIM, JKPDADGJJHJ JPFCGKEELBF, params object[] OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x829ED20", Offset = "0x829DD20", VA = "0x18829ED20")]
	private void BJNDEFHHIOO(ViewId FKHACEBFNLD, string PGEDMIEEBID, IALDHONKEJC JLNNGEFEACL, int DDNKPFFNBPO, object[] GHNOIAMBGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x82A1660", Offset = "0x82A0660", VA = "0x1882A1660")]
	private static void GCEBBLGJOPI(EHAABEIDNDJ JFPLGEEKCOD, MonoBehaviour EMGDAFDHNNB, object[] DELLHDJPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x82A1320", Offset = "0x82A0320", VA = "0x1882A1320")]
	private static bool EPPAIJDGHCO(ParameterInfo[] HFEEFBHKLGL, Type[] EAECEIOPLLN, [Out] bool EAINENPKBNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x82A1E00", Offset = "0x82A0E00", VA = "0x1882A1E00")]
	private List<EHAABEIDNDJ> OPODIMHPJCD(MonoBehaviour EMGDAFDHNNB, Type KNBGFIMGNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x82A1C00", Offset = "0x82A0C00", VA = "0x1882A1C00")]
	private static IEnumerable<MethodInfo> LPEGKJIBEAH(Type BJLNCBFOGNL, Type OCGKHPNLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x82A1550", Offset = "0x82A0550", VA = "0x1882A1550")]
	public static ParameterInfo[] FBKFLGGNNBL(MethodInfo HJGOAMNCMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JLKPCEIDEDL()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, KGEJCFCCIMK, MHJEFLLNKBL, OLPHJFIEJCK, ENHHOGMNBEM, PIFHPGJAAJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum KLAFFKJCIDD
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
		private sealed class JLNLGHIEBCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public JLNLGHIEBCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x82A2B20", Offset = "0x82A1B20", VA = "0x1882A2B20")]
			internal bool AJEHPDPIMHL(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<int, RRNetworkView> OALOJGOKDHA;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static NDFFKECCNKF NOOJNPCKBFJ;

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
		private bool LDBAGPOGIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal bool KLPPIGPMJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public KLAFFKJCIDD hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool FNICFMHHDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool KCOOBJHGBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int GGAHIOKNLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool DFFOADBFGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int FDEGHOHKIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IALDHONKEJC FICFFHNKAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IALDHONKEJC CNLHIMFIIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool? MNFAJFHAFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool JFFLJAMNCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal bool OCJJENMPKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal MonoBehaviour[] DEKHLKIDCPJ;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly ONIHMLNNEEF GFJONBIAADK;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId MGADKAAPMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x82B84C0", Offset = "0x82B74C0", VA = "0x1882B84C0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId NJEFCBHNOOD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x82B84C0", Offset = "0x82B74C0", VA = "0x1882B84C0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId BGAJFIDHOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x82B84C0", Offset = "0x82B74C0", VA = "0x1882B84C0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int MFCNNCBCKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int AEKMLACEDKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ViewId IELBICGBCNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x82B8330", Offset = "0x82B7330", VA = "0x1882B8330")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool KNCGDJFCBKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool JPNLDMBDPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x82B8340", Offset = "0x82B7340", VA = "0x1882B8340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DMKCHLHIAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int FANMJCBCJIM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAB2090", Offset = "0xAB1090", VA = "0x180AB2090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int JNBAKIIEJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x82B82D0", Offset = "0x82B72D0", VA = "0x1882B82D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IALDHONKEJC FMEKOCOHDGD
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x82B84D0", Offset = "0x82B74D0", VA = "0x1882B84D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IALDHONKEJC FDNMENIBIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x82B82A0", Offset = "0x82B72A0", VA = "0x1882B82A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IALDHONKEJC PCJBDONIEHD
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x82B82A0", Offset = "0x82B72A0", VA = "0x1882B82A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public IALDHONKEJC MDIGCIOLDPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x82B82A0", Offset = "0x82B72A0", VA = "0x1882B82A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool IDNBEFFFKAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x82B8410", Offset = "0x82B7410", VA = "0x1882B8410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int HLDAGCPHMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x82B8300", Offset = "0x82B7300", VA = "0x1882B8300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public object[] PCCAALAGPPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FDIJEJPNHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x82B8500", Offset = "0x82B7500", VA = "0x1882B8500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool PGLBDGEKELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x82B8490", Offset = "0x82B7490", VA = "0x1882B8490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OIEKHFOHMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xE60250", Offset = "0xE5F250", VA = "0x180E60250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xFBDCA0", Offset = "0xFBCCA0", VA = "0x180FBDCA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DJDBGPECKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCE6720", Offset = "0xCE5720", VA = "0x180CE6720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> GIMJDADMIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x82B8140", Offset = "0x82B7140", VA = "0x1882B8140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x82B86C0", Offset = "0x82B76C0", VA = "0x1882B86C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<IALDHONKEJC> KBFCBDFOBEM
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x82B3B30", Offset = "0x82B2B30", VA = "0x1882B3B30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x82B3C60", Offset = "0x82B2C60", VA = "0x1882B3C60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<IALDHONKEJC> JJMOFIBBNDH
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x82B3B30", Offset = "0x82B2B30", VA = "0x1882B3B30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x82B3C60", Offset = "0x82B2C60", VA = "0x1882B3C60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> FEOPIPHKFAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x82B4B90", Offset = "0x82B3B90", VA = "0x1882B4B90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x82B4C40", Offset = "0x82B3C40", VA = "0x1882B4C40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> MNKOPNGMNGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x82B4B90", Offset = "0x82B3B90", VA = "0x1882B4B90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x82B4C40", Offset = "0x82B3C40", VA = "0x1882B4C40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> FIBBCKMMPLA
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x82B81F0", Offset = "0x82B71F0", VA = "0x1882B81F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x82B8770", Offset = "0x82B7770", VA = "0x1882B8770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action AFMOADOFCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x82B8090", Offset = "0x82B7090", VA = "0x1882B8090")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x82B8610", Offset = "0x82B7610", VA = "0x1882B8610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x82B7EC0", Offset = "0x82B6EC0", VA = "0x1882B7EC0")]
		public static bool TryGetNetworkView(int FKHACEBFNLD, [Out] RRNetworkView GBKCMPDBPJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x82B3DD0", Offset = "0x82B2DD0", VA = "0x1882B3DD0")]
		public static RRNetworkView Find(int FKHACEBFNLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x82B3ED0", Offset = "0x82B2ED0", VA = "0x1882B3ED0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int NKMFCEDKALA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x82B3E60", Offset = "0x82B2E60", VA = "0x1882B3E60")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x82B5630", Offset = "0x82B4630", VA = "0x1882B5630")]
		public static bool RemoveNetworkView(RRNetworkView GBKCMPDBPJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82B5400", Offset = "0x82B4400", VA = "0x1882B5400")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x82B4E90", Offset = "0x82B3E90", VA = "0x1882B4E90")]
		public static void OnPlayerJoinedRoom(IALDHONKEJC DEHOOJMHOKK, List<int> KKHOLNKACDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x82B4010", Offset = "0x82B3010", VA = "0x1882B4010")]
		public static RRNetworkView Get(Component LDEFIHHDIJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x82B4070", Offset = "0x82B3070", VA = "0x1882B4070")]
		public static RRNetworkView Get(GameObject HFDNELMLBBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x82B4140", Offset = "0x82B3140", VA = "0x1882B4140")]
		private void HOEDMHGNEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82B35A0", Offset = "0x82B25A0", VA = "0x1882B35A0")]
		public bool CreatedBy(IALDHONKEJC MFOAOKBDIIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x82B7CD0", Offset = "0x82B6CD0", VA = "0x1882B7CD0")]
		public void TransferOwnership(int FHDCNNPLKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x82B7C70", Offset = "0x82B6C70", VA = "0x1882B7C70")]
		public void TransferOwnership(IALDHONKEJC FJFKJKFEHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x82B4400", Offset = "0x82B3400", VA = "0x1882B4400", Slot = "4")]
		public void Initialize(ViewId PHPJPMFKDOC, ViewId HCJDMIAFOLC, Dictionary<int, object> PBIFPLDBICK, DOHKIBLNJFC FICFFHNKAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x82B43A0", Offset = "0x82B33A0", VA = "0x1882B43A0")]
		public void Initialize(ViewId PHPJPMFKDOC, ViewId HCJDMIAFOLC, object[] ACDAOGABGBD, DOHKIBLNJFC FICFFHNKAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x82B3250", Offset = "0x82B2250", VA = "0x1882B3250")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x82B4990", Offset = "0x82B3990", VA = "0x1882B4990")]
		private void MJEHEEECJOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2005850", Offset = "0x2004850", VA = "0x182005850")]
		internal void HOEONKOJPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x82B3D10", Offset = "0x82B2D10", VA = "0x1882B3D10", Slot = "6")]
		private void FDLOALHGBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x82B40D0", Offset = "0x82B30D0", VA = "0x1882B40D0")]
		internal bool HACOMFKAFMD(RRNetworkView JIKNBPONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x82B4CF0", Offset = "0x82B3CF0", VA = "0x1882B4CF0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x82B4340", Offset = "0x82B3340", VA = "0x1882B4340")]
		internal void INGLOGOMCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x82B3240", Offset = "0x82B2240", VA = "0x1882B3240")]
		private void AEAMHMIGPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x82B4620", Offset = "0x82B3620", VA = "0x1882B4620")]
		internal void JILABIEPKGL(IALDHONKEJC FJFKJKFEHDA, int FHDCNNPLKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x82B5590", Offset = "0x82B4590", VA = "0x1882B5590")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x82B56B0", Offset = "0x82B46B0", VA = "0x1882B56B0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x82B3770", Offset = "0x82B2770", VA = "0x1882B3770")]
		private void DAMJHFCNADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x82B48A0", Offset = "0x82B38A0", VA = "0x1882B48A0")]
		private void KPEBBACABDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x82B52E0", Offset = "0x82B42E0", VA = "0x1882B52E0")]
		public void RPC(string PGEDMIEEBID, OLHLIDNBNCP AOJAHPGAGPO, params object[] OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x82B5370", Offset = "0x82B4370", VA = "0x1882B5370")]
		public void RPC(string PGEDMIEEBID, IALDHONKEJC AOLDFGCJAAE, params object[] OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x82B55E0", Offset = "0x82B45E0", VA = "0x1882B55E0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x82B32B0", Offset = "0x82B22B0", VA = "0x1882B32B0", Slot = "8")]
		public void Bake(ODDBPMPHPJL IEGLIFIOOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x82B3BE0", Offset = "0x82B2BE0", VA = "0x1882B3BE0")]
		private static void EFEHDFMNBDJ(IALDHONKEJC DEJHNGPBFGP, [Out] IALDHONKEJC FMGAAJMDEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x82B3810", Offset = "0x82B2810", VA = "0x1882B3810")]
		private static void DBJBALNELJP(RRNetworkView ELAKGDCNKOD, Delegate JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x82B42C0", Offset = "0x82B32C0", VA = "0x1882B42C0")]
		private static KODDFPHIGAD IJGOJPGFFMN(RRNetworkView ELAKGDCNKOD)
		{
			return default(KODDFPHIGAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x82B4220", Offset = "0x82B3220", VA = "0x1882B4220")]
		private static CFLNMMPBLFL HOFKBHGBDAF(RRNetworkView ELAKGDCNKOD)
		{
			return default(CFLNMMPBLFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x82B46E0", Offset = "0x82B36E0", VA = "0x1882B46E0")]
		private static void KFDEPDMLELG(RRNetworkView ELAKGDCNKOD, Delegate JFPLGEEKCOD, IALDHONKEJC NFJLNGFCOGD, params object[] OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x82B47C0", Offset = "0x82B37C0", VA = "0x1882B47C0")]
		private static void KFDEPDMLELG(RRNetworkView ELAKGDCNKOD, Delegate JFPLGEEKCOD, OLHLIDNBNCP NFJLNGFCOGD, params object[] OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x82B3620", Offset = "0x82B2620", VA = "0x1882B3620")]
		private static void DAINCFFHGCO(RRNetworkView ELAKGDCNKOD, Delegate JFPLGEEKCOD, OLHLIDNBNCP NFJLNGFCOGD, MNEHPJKOLEF HIMPDIPAKGF, params object[] OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x82B51E0", Offset = "0x82B41E0", VA = "0x1882B51E0")]
		public void RPCBuffered(string PGEDMIEEBID, OLHLIDNBNCP AOJAHPGAGPO, MNEHPJKOLEF JPFCGKEELBF, params object[] OGEALFKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x82B4580", Offset = "0x82B3580", VA = "0x1882B4580")]
		private static bool JECDKMMMKOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x82B6170", Offset = "0x82B5170", VA = "0x1882B6170", Slot = "26")]
		public void RpcAll(CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3F00000", Offset = "0x3EFF000", VA = "0x183F00000", Slot = "9")]
		public void RpcAll<T1>(CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF850", Offset = "0x3EFE850", VA = "0x183EFF850", Slot = "10")]
		public void RpcAll<T1, T2>(CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3F013F0", Offset = "0x3F003F0", VA = "0x183F013F0", Slot = "27")]
		public void RpcAll<T1, T2, T3>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFA70", Offset = "0x3EFEA70", VA = "0x183EFFA70", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF400", Offset = "0x3EFE400", VA = "0x183EFF400", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3F018F0", Offset = "0x3F008F0", VA = "0x183F018F0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEEB0", Offset = "0x3EFDEB0", VA = "0x183EFEEB0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3F06500", Offset = "0x3F05500", VA = "0x183F06500", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3F01DA0", Offset = "0x3F00DA0", VA = "0x183F01DA0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3F00190", Offset = "0x3EFF190", VA = "0x183F00190", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3F0AB20", Offset = "0x3F09B20", VA = "0x183F0AB20", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AEF0", Offset = "0x3F29EF0", VA = "0x183F2AEF0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A8F0", Offset = "0x3F298F0", VA = "0x183F2A8F0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3F27FB0", Offset = "0x3F26FB0", VA = "0x183F27FB0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x82B5D30", Offset = "0x82B4D30", VA = "0x1882B5D30")]
		public void RpcAll(CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3F04460", Offset = "0x3F03460", VA = "0x183F04460")]
		public void RpcAll<T1>(CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3F04EB0", Offset = "0x3F03EB0", VA = "0x183F04EB0")]
		public void RpcAll<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3F00A80", Offset = "0x3EFFA80", VA = "0x183F00A80")]
		public void RpcAll<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3F0FED0", Offset = "0x3F0EED0", VA = "0x183F0FED0")]
		public void RpcAll<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3F0F900", Offset = "0x3F0E900", VA = "0x183F0F900")]
		public void RpcAll<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3F0EFB0", Offset = "0x3F0DFB0", VA = "0x183F0EFB0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3F0E550", Offset = "0x3F0D550", VA = "0x183F0E550")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3F0D5F0", Offset = "0x3F0C5F0", VA = "0x183F0D5F0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3F0CD30", Offset = "0x3F0BD30", VA = "0x183F0CD30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BF50", Offset = "0x3F0AF50", VA = "0x183F0BF50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A5C0", Offset = "0x3F095C0", VA = "0x183F0A5C0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3F09FF0", Offset = "0x3F08FF0", VA = "0x183F09FF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A2B0", Offset = "0x3F292B0", VA = "0x183F2A2B0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3F28F50", Offset = "0x3F27F50", VA = "0x183F28F50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x82B5F40", Offset = "0x82B4F40", VA = "0x1882B5F40", Slot = "36")]
		public void RpcAll(CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3F140F0", Offset = "0x3F130F0", VA = "0x183F140F0", Slot = "37")]
		public void RpcAll<T1>(CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3F12270", Offset = "0x3F11270", VA = "0x183F12270", Slot = "38")]
		public void RpcAll<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F10E60", Offset = "0x3F0FE60", VA = "0x183F10E60", Slot = "39")]
		public void RpcAll<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F0FC10", Offset = "0x3F0EC10", VA = "0x183F0FC10", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F0F5F0", Offset = "0x3F0E5F0", VA = "0x183F0F5F0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F0E910", Offset = "0x3F0D910", VA = "0x183F0E910", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F0DE10", Offset = "0x3F0CE10", VA = "0x183F0DE10", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3F0D1C0", Offset = "0x3F0C1C0", VA = "0x183F0D1C0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C8A0", Offset = "0x3F0B8A0", VA = "0x183F0C8A0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3F0B590", Offset = "0x3F0A590", VA = "0x183F0B590", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F0B030", Offset = "0x3F0A030", VA = "0x183F0B030", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F09A20", Offset = "0x3F08A20", VA = "0x183F09A20", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3F29C70", Offset = "0x3F28C70", VA = "0x183F29C70", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3F288A0", Offset = "0x3F278A0", VA = "0x183F288A0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x82B5C00", Offset = "0x82B4C00", VA = "0x1882B5C00", Slot = "51")]
		public void RpcAllViaServer(CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3F27EA0", Offset = "0x3F26EA0", VA = "0x183F27EA0", Slot = "52")]
		public void RpcAllViaServer<T1>(CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F7E0", Offset = "0x3F1E7E0", VA = "0x183F1F7E0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3F276B0", Offset = "0x3F266B0", VA = "0x183F276B0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F27140", Offset = "0x3F26140", VA = "0x183F27140", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3F26AC0", Offset = "0x3F25AC0", VA = "0x183F26AC0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3F25DF0", Offset = "0x3F24DF0", VA = "0x183F25DF0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3F257F0", Offset = "0x3F247F0", VA = "0x183F257F0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3F24B00", Offset = "0x3F23B00", VA = "0x183F24B00", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F24760", Offset = "0x3F23760", VA = "0x183F24760", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F23C30", Offset = "0x3F22C30", VA = "0x183F23C30", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F22790", Offset = "0x3F21790", VA = "0x183F22790", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F21E70", Offset = "0x3F20E70", VA = "0x183F21E70", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F20B10", Offset = "0x3F1FB10", VA = "0x183F20B10", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F1FB50", Offset = "0x3F1EB50", VA = "0x183F1FB50", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x82B59A0", Offset = "0x82B49A0", VA = "0x1882B59A0")]
		public void RpcAllViaServer(CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F27D90", Offset = "0x3F26D90", VA = "0x183F27D90")]
		public void RpcAllViaServer<T1>(CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3F27B20", Offset = "0x3F26B20", VA = "0x183F27B20")]
		public void RpcAllViaServer<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3F27500", Offset = "0x3F26500", VA = "0x183F27500")]
		public void RpcAllViaServer<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3F26D20", Offset = "0x3F25D20", VA = "0x183F26D20")]
		public void RpcAllViaServer<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3F26600", Offset = "0x3F25600", VA = "0x183F26600")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3F260A0", Offset = "0x3F250A0", VA = "0x183F260A0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3F254F0", Offset = "0x3F244F0", VA = "0x183F254F0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3F251A0", Offset = "0x3F241A0", VA = "0x183F251A0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3F24020", Offset = "0x3F23020", VA = "0x183F24020")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3F23450", Offset = "0x3F22450", VA = "0x183F23450")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3F23010", Offset = "0x3F22010", VA = "0x183F23010")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F219E0", Offset = "0x3F209E0", VA = "0x183F219E0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F21000", Offset = "0x3F20000", VA = "0x183F21000")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F205D0", Offset = "0x3F1F5D0", VA = "0x183F205D0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x82B5AD0", Offset = "0x82B4AD0", VA = "0x1882B5AD0", Slot = "65")]
		public void RpcAllViaServer(CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F27C80", Offset = "0x3F26C80", VA = "0x183F27C80", Slot = "66")]
		public void RpcAllViaServer<T1>(CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F27860", Offset = "0x3F26860", VA = "0x183F27860", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F27350", Offset = "0x3F26350", VA = "0x183F27350", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F26F30", Offset = "0x3F25F30", VA = "0x183F26F30", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F26860", Offset = "0x3F25860", VA = "0x183F26860", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F26350", Offset = "0x3F25350", VA = "0x183F26350", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F25AF0", Offset = "0x3F24AF0", VA = "0x183F25AF0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F24E50", Offset = "0x3F23E50", VA = "0x183F24E50", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F243C0", Offset = "0x3F233C0", VA = "0x183F243C0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F23840", Offset = "0x3F22840", VA = "0x183F23840", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F22BD0", Offset = "0x3F21BD0", VA = "0x183F22BD0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F22300", Offset = "0x3F21300", VA = "0x183F22300", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F214F0", Offset = "0x3F204F0", VA = "0x183F214F0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F20090", Offset = "0x3F1F090", VA = "0x183F20090", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x82B7110", Offset = "0x82B6110", VA = "0x1882B7110", Slot = "80")]
		public void RpcOthers(CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F58360", Offset = "0x3F57360", VA = "0x183F58360", Slot = "15")]
		public void RpcOthers<T1>(CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F58C60", Offset = "0x3F57C60", VA = "0x183F58C60", Slot = "81")]
		public void RpcOthers<T1, T2>(CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F580E0", Offset = "0x3F570E0", VA = "0x183F580E0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F61C20", Offset = "0x3F60C20", VA = "0x183F61C20", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F61040", Offset = "0x3F60040", VA = "0x183F61040", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F59A10", Offset = "0x3F58A10", VA = "0x183F59A10", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F604B0", Offset = "0x3F5F4B0", VA = "0x183F604B0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F420", Offset = "0x3F5E420", VA = "0x183F5F420", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F5ECA0", Offset = "0x3F5DCA0", VA = "0x183F5ECA0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F5DCB0", Offset = "0x3F5CCB0", VA = "0x183F5DCB0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F5CF90", Offset = "0x3F5BF90", VA = "0x183F5CF90", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C610", Offset = "0x3F5B610", VA = "0x183F5C610", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B220", Offset = "0x3F5A220", VA = "0x183F5B220", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F5ACB0", Offset = "0x3F59CB0", VA = "0x183F5ACB0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x82B7260", Offset = "0x82B6260", VA = "0x1882B7260")]
		public void RpcOthers(CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F589A0", Offset = "0x3F579A0", VA = "0x183F589A0")]
		public void RpcOthers<T1>(CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3F587B0", Offset = "0x3F577B0", VA = "0x183F587B0")]
		public void RpcOthers<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F62BF0", Offset = "0x3F61BF0", VA = "0x183F62BF0")]
		public void RpcOthers<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F584C0", Offset = "0x3F574C0", VA = "0x183F584C0")]
		public void RpcOthers<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F59170", Offset = "0x3F58170", VA = "0x183F59170")]
		public void RpcOthers<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F594C0", Offset = "0x3F584C0", VA = "0x183F594C0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F5FE70", Offset = "0x3F5EE70", VA = "0x183F5FE70")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F790", Offset = "0x3F5E790", VA = "0x183F5F790")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E8E0", Offset = "0x3F5D8E0", VA = "0x183F5E8E0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E0C0", Offset = "0x3F5D0C0", VA = "0x183F5E0C0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D3F0", Offset = "0x3F5C3F0", VA = "0x183F5D3F0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C150", Offset = "0x3F5B150", VA = "0x183F5C150")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B730", Offset = "0x3F5A730", VA = "0x183F5B730")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A740", Offset = "0x3F59740", VA = "0x183F5A740")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x82B73B0", Offset = "0x82B63B0", VA = "0x1882B73B0", Slot = "93")]
		public void RpcOthers(CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F63770", Offset = "0x3F62770", VA = "0x183F63770", Slot = "94")]
		public void RpcOthers<T1>(CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F632F0", Offset = "0x3F622F0", VA = "0x183F632F0", Slot = "95")]
		public void RpcOthers<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F62830", Offset = "0x3F61830", VA = "0x183F62830", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F619F0", Offset = "0x3F609F0", VA = "0x183F619F0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F612C0", Offset = "0x3F602C0", VA = "0x183F612C0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3F60D70", Offset = "0x3F5FD70", VA = "0x183F60D70", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F60190", Offset = "0x3F5F190", VA = "0x183F60190", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F5FB00", Offset = "0x3F5EB00", VA = "0x183F5FB00", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F060", Offset = "0x3F5E060", VA = "0x183F5F060", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E4D0", Offset = "0x3F5D4D0", VA = "0x183F5E4D0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D850", Offset = "0x3F5C850", VA = "0x183F5D850", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F5CAD0", Offset = "0x3F5BAD0", VA = "0x183F5CAD0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BC40", Offset = "0x3F5AC40", VA = "0x183F5BC40", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A1D0", Offset = "0x3F591D0", VA = "0x183F5A1D0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x82B6B80", Offset = "0x82B5B80", VA = "0x1882B6B80", Slot = "108")]
		public void RpcMaster(CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BE20", Offset = "0x3F3AE20", VA = "0x183F3BE20", Slot = "109")]
		public void RpcMaster<T1>(CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C1D0", Offset = "0x3F3B1D0", VA = "0x183F3C1D0", Slot = "17")]
		public void RpcMaster<T1, T2>(CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BB50", Offset = "0x3F3AB50", VA = "0x183F3BB50", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B7F0", Offset = "0x3F3A7F0", VA = "0x183F3B7F0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F8B0", Offset = "0x3F3E8B0", VA = "0x183F3F8B0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3F41D30", Offset = "0x3F40D30", VA = "0x183F41D30", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F48560", Offset = "0x3F47560", VA = "0x183F48560", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F478E0", Offset = "0x3F468E0", VA = "0x183F478E0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F47000", Offset = "0x3F46000", VA = "0x183F47000", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F060", Offset = "0x3F3E060", VA = "0x183F3F060", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DC60", Offset = "0x3F3CC60", VA = "0x183F3DC60", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F43550", Offset = "0x3F42550", VA = "0x183F43550", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F42F50", Offset = "0x3F41F50", VA = "0x183F42F50", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F4E0D0", Offset = "0x3F4D0D0", VA = "0x183F4E0D0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x82B6D10", Offset = "0x82B5D10", VA = "0x1882B6D10")]
		public void RpcMaster(CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BFD0", Offset = "0x3F3AFD0", VA = "0x183F3BFD0")]
		public void RpcMaster<T1>(CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F3CE70", Offset = "0x3F3BE70", VA = "0x183F3CE70")]
		public void RpcMaster<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C420", Offset = "0x3F3B420", VA = "0x183F3C420")]
		public void RpcMaster<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A6E0", Offset = "0x3F496E0", VA = "0x183F4A6E0")]
		public void RpcMaster<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F402F0", Offset = "0x3F3F2F0", VA = "0x183F402F0")]
		public void RpcMaster<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F48D20", Offset = "0x3F47D20", VA = "0x183F48D20")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F48160", Offset = "0x3F47160", VA = "0x183F48160")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F47470", Offset = "0x3F46470", VA = "0x183F47470")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F46B30", Offset = "0x3F45B30", VA = "0x183F46B30")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F46130", Offset = "0x3F45130", VA = "0x183F46130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F446D0", Offset = "0x3F436D0", VA = "0x183F446D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F440E0", Offset = "0x3F430E0", VA = "0x183F440E0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F4EE00", Offset = "0x3F4DE00", VA = "0x183F4EE00")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F4E740", Offset = "0x3F4D740", VA = "0x183F4E740")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x82B6940", Offset = "0x82B5940", VA = "0x1882B6940", Slot = "122")]
		public void RpcMaster(CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F4CD50", Offset = "0x3F4BD50", VA = "0x183F4CD50", Slot = "123")]
		public void RpcMaster<T1>(CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BF20", Offset = "0x3F4AF20", VA = "0x183F4BF20", Slot = "124")]
		public void RpcMaster<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A9D0", Offset = "0x3F499D0", VA = "0x183F4A9D0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A3F0", Offset = "0x3F493F0", VA = "0x183F4A3F0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3F497D0", Offset = "0x3F487D0", VA = "0x183F497D0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3F49420", Offset = "0x3F48420", VA = "0x183F49420", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3F48920", Offset = "0x3F47920", VA = "0x183F48920", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3F47CF0", Offset = "0x3F46CF0", VA = "0x183F47CF0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3F46660", Offset = "0x3F45660", VA = "0x183F46660", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3F45C00", Offset = "0x3F44C00", VA = "0x183F45C00", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3F451A0", Offset = "0x3F441A0", VA = "0x183F451A0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3F43AF0", Offset = "0x3F42AF0", VA = "0x183F43AF0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3F4F450", Offset = "0x3F4E450", VA = "0x183F4F450", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3F4DA10", Offset = "0x3F4CA10", VA = "0x183F4DA10", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x82B62E0", Offset = "0x82B52E0", VA = "0x1882B62E0", Slot = "137")]
		public void RpcAuthority(CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B890", Offset = "0x3F2A890", VA = "0x183F2B890", Slot = "138")]
		public void RpcAuthority<T1>(CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D1A0", Offset = "0x3F2C1A0", VA = "0x183F2D1A0", Slot = "139")]
		public void RpcAuthority<T1, T2>(CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D950", Offset = "0x3F2C950", VA = "0x183F2D950", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE60", Offset = "0x3F2BE60", VA = "0x183F2CE60", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B480", Offset = "0x3F2A480", VA = "0x183F2B480", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3F36200", Offset = "0x3F35200", VA = "0x183F36200", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3F355F0", Offset = "0x3F345F0", VA = "0x183F355F0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3F34D40", Offset = "0x3F33D40", VA = "0x183F34D40", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3F33A70", Offset = "0x3F32A70", VA = "0x183F33A70", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3F33580", Offset = "0x3F32580", VA = "0x183F33580", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3F32010", Offset = "0x3F31010", VA = "0x183F32010", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BA50", Offset = "0x3F2AA50", VA = "0x183F2BA50", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F5E0", Offset = "0x3F2E5E0", VA = "0x183F2F5E0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2EF60", Offset = "0x3F2DF60", VA = "0x183F2EF60", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x82B66F0", Offset = "0x82B56F0", VA = "0x1882B66F0")]
		public void RpcAuthority(CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3F398B0", Offset = "0x3F388B0", VA = "0x183F398B0")]
		public void RpcAuthority<T1>(CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3F38930", Offset = "0x3F37930", VA = "0x183F38930")]
		public void RpcAuthority<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3F37F50", Offset = "0x3F36F50", VA = "0x183F37F50")]
		public void RpcAuthority<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3F376B0", Offset = "0x3F366B0", VA = "0x183F376B0")]
		public void RpcAuthority<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3F36CE0", Offset = "0x3F35CE0", VA = "0x183F36CE0")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3F36920", Offset = "0x3F35920", VA = "0x183F36920")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3F35DE0", Offset = "0x3F34DE0", VA = "0x183F35DE0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3F35170", Offset = "0x3F34170", VA = "0x183F35170")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3F33F00", Offset = "0x3F32F00", VA = "0x183F33F00")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3F32B00", Offset = "0x3F31B00", VA = "0x183F32B00")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3F32560", Offset = "0x3F31560", VA = "0x183F32560")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3F308C0", Offset = "0x3F2F8C0", VA = "0x183F308C0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3F2FC00", Offset = "0x3F2EC00", VA = "0x183F2FC00")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E1C0", Offset = "0x3F2D1C0", VA = "0x183F2E1C0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x82B6490", Offset = "0x82B5490", VA = "0x1882B6490", Slot = "152")]
		public void RpcAuthority(CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3F39C10", Offset = "0x3F38C10", VA = "0x183F39C10", Slot = "153")]
		public void RpcAuthority<T1>(CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3F38D40", Offset = "0x3F37D40", VA = "0x183F38D40", Slot = "154")]
		public void RpcAuthority<T1, T2>(CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3F381E0", Offset = "0x3F371E0", VA = "0x183F381E0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3F379B0", Offset = "0x3F369B0", VA = "0x183F379B0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3F37040", Offset = "0x3F36040", VA = "0x183F37040", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3F36560", Offset = "0x3F35560", VA = "0x183F36560", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3F359C0", Offset = "0x3F349C0", VA = "0x183F359C0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3F348C0", Offset = "0x3F338C0", VA = "0x183F348C0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3F343E0", Offset = "0x3F333E0", VA = "0x183F343E0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3F33040", Offset = "0x3F32040", VA = "0x183F33040", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3F31A70", Offset = "0x3F30A70", VA = "0x183F31A70", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3F30EC0", Offset = "0x3F2FEC0", VA = "0x183F30EC0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3F30260", Offset = "0x3F2F260", VA = "0x183F30260", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E890", Offset = "0x3F2D890", VA = "0x183F2E890", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x82B7A70", Offset = "0x82B6A70", VA = "0x1882B7A70", Slot = "18")]
		public void RpcPlayer(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3F641B0", Offset = "0x3F631B0", VA = "0x183F641B0", Slot = "19")]
		public void RpcPlayer<T1>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3F65110", Offset = "0x3F64110", VA = "0x183F65110", Slot = "20")]
		public void RpcPlayer<T1, T2>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3F64B20", Offset = "0x3F63B20", VA = "0x183F64B20", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3F64550", Offset = "0x3F63550", VA = "0x183F64550", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3F68E80", Offset = "0x3F67E80", VA = "0x183F68E80", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3F68A10", Offset = "0x3F67A10", VA = "0x183F68A10", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3F69270", Offset = "0x3F68270", VA = "0x183F69270", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3F69740", Offset = "0x3F68740", VA = "0x183F69740", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3F717A0", Offset = "0x3F707A0", VA = "0x183F717A0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3F712A0", Offset = "0x3F702A0", VA = "0x183F712A0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IALDHONKEJC MFOAOKBDIIM, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3F65A00", Offset = "0x3F64A00", VA = "0x183F65A00", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IALDHONKEJC MFOAOKBDIIM, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F180", Offset = "0x3F6E180", VA = "0x183F6F180", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IALDHONKEJC MFOAOKBDIIM, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D890", Offset = "0x3F6C890", VA = "0x183F6D890", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IALDHONKEJC MFOAOKBDIIM, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3F6BDC0", Offset = "0x3F6ADC0", VA = "0x183F6BDC0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IALDHONKEJC MFOAOKBDIIM, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x82B7500", Offset = "0x82B6500", VA = "0x1882B7500")]
		public void RpcPlayer(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3F648F0", Offset = "0x3F638F0", VA = "0x183F648F0")]
		public void RpcPlayer<T1>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3F6B4D0", Offset = "0x3F6A4D0", VA = "0x183F6B4D0")]
		public void RpcPlayer<T1, T2>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3F75D70", Offset = "0x3F74D70", VA = "0x183F75D70")]
		public void RpcPlayer<T1, T2, T3>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3F75A60", Offset = "0x3F74A60", VA = "0x183F75A60")]
		public void RpcPlayer<T1, T2, T3, T4>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3F74AB0", Offset = "0x3F73AB0", VA = "0x183F74AB0")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3F73FA0", Offset = "0x3F72FA0", VA = "0x183F73FA0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3F737A0", Offset = "0x3F727A0", VA = "0x183F737A0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3F72620", Offset = "0x3F71620", VA = "0x183F72620")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3F71C40", Offset = "0x3F70C40", VA = "0x183F71C40")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IALDHONKEJC MFOAOKBDIIM, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3F70D50", Offset = "0x3F6FD50", VA = "0x183F70D50")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IALDHONKEJC MFOAOKBDIIM, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F740", Offset = "0x3F6E740", VA = "0x183F6F740")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IALDHONKEJC MFOAOKBDIIM, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3F6EB60", Offset = "0x3F6DB60", VA = "0x183F6EB60")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IALDHONKEJC MFOAOKBDIIM, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D210", Offset = "0x3F6C210", VA = "0x183F6D210")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IALDHONKEJC MFOAOKBDIIM, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3F6CB30", Offset = "0x3F6BB30", VA = "0x183F6CB30")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IALDHONKEJC MFOAOKBDIIM, PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x82B77B0", Offset = "0x82B67B0", VA = "0x1882B77B0", Slot = "176")]
		public void RpcPlayer(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3F67620", Offset = "0x3F66620", VA = "0x183F67620", Slot = "177")]
		public void RpcPlayer<T1>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3F65710", Offset = "0x3F64710", VA = "0x183F65710", Slot = "24")]
		public void RpcPlayer<T1, T2>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3F65390", Offset = "0x3F64390", VA = "0x183F65390", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3F67250", Offset = "0x3F66250", VA = "0x183F67250", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3F75130", Offset = "0x3F74130", VA = "0x183F75130", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3F74370", Offset = "0x3F73370", VA = "0x183F74370", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3F73370", Offset = "0x3F72370", VA = "0x183F73370", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3F72AB0", Offset = "0x3F71AB0", VA = "0x183F72AB0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(IALDHONKEJC MFOAOKBDIIM, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3F72130", Offset = "0x3F71130", VA = "0x183F72130", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IALDHONKEJC MFOAOKBDIIM, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3F70800", Offset = "0x3F6F800", VA = "0x183F70800", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IALDHONKEJC MFOAOKBDIIM, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3F6FCF0", Offset = "0x3F6ECF0", VA = "0x183F6FCF0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IALDHONKEJC MFOAOKBDIIM, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E540", Offset = "0x3F6D540", VA = "0x183F6E540", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IALDHONKEJC MFOAOKBDIIM, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3F6DEC0", Offset = "0x3F6CEC0", VA = "0x183F6DEC0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IALDHONKEJC MFOAOKBDIIM, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3F6C450", Offset = "0x3F6B450", VA = "0x183F6C450", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IALDHONKEJC MFOAOKBDIIM, PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x82B5900", Offset = "0x82B4900", VA = "0x1882B5900", Slot = "189")]
		public void RpcAllBuffered(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F480", Offset = "0x3F1E480", VA = "0x183F1F480", Slot = "190")]
		public void RpcAllBuffered<T1>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F1A0", Offset = "0x3F1E1A0", VA = "0x183F1F1A0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3F1EAF0", Offset = "0x3F1DAF0", VA = "0x183F1EAF0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E4C0", Offset = "0x3F1D4C0", VA = "0x183F1E4C0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E260", Offset = "0x3F1D260", VA = "0x183F1E260", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DAF0", Offset = "0x3F1CAF0", VA = "0x183F1DAF0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3F1CF90", Offset = "0x3F1BF90", VA = "0x183F1CF90", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C270", Offset = "0x3F1B270", VA = "0x183F1C270", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1BB10", Offset = "0x3F1AB10", VA = "0x183F1BB10", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B360", Offset = "0x3F1A360", VA = "0x183F1B360", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNEHPJKOLEF JPFCGKEELBF, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A710", Offset = "0x3F19710", VA = "0x183F1A710", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNEHPJKOLEF JPFCGKEELBF, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3F19090", Offset = "0x3F18090", VA = "0x183F19090", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNEHPJKOLEF JPFCGKEELBF, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3F18B90", Offset = "0x3F17B90", VA = "0x183F18B90", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNEHPJKOLEF JPFCGKEELBF, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3F17C40", Offset = "0x3F16C40", VA = "0x183F17C40", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNEHPJKOLEF JPFCGKEELBF, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x82B57C0", Offset = "0x82B47C0", VA = "0x1882B57C0")]
		public void RpcAllBuffered(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F6C0", Offset = "0x3F1E6C0", VA = "0x183F1F6C0")]
		public void RpcAllBuffered<T1>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F310", Offset = "0x3F1E310", VA = "0x183F1F310")]
		public void RpcAllBuffered<T1, T2>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3F1ECB0", Offset = "0x3F1DCB0", VA = "0x183F1ECB0")]
		public void RpcAllBuffered<T1, T2, T3>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E8E0", Offset = "0x3F1D8E0", VA = "0x183F1E8E0")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E000", Offset = "0x3F1D000", VA = "0x183F1E000")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D840", Offset = "0x3F1C840", VA = "0x183F1D840")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D290", Offset = "0x3F1C290", VA = "0x183F1D290")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C930", Offset = "0x3F1B930", VA = "0x183F1C930")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3F1BEC0", Offset = "0x3F1AEC0", VA = "0x183F1BEC0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNEHPJKOLEF JPFCGKEELBF, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1AF60", Offset = "0x3F19F60", VA = "0x183F1AF60")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNEHPJKOLEF JPFCGKEELBF, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3F19E70", Offset = "0x3F18E70", VA = "0x183F19E70")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNEHPJKOLEF JPFCGKEELBF, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3F19530", Offset = "0x3F18530", VA = "0x183F19530")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNEHPJKOLEF JPFCGKEELBF, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3F18690", Offset = "0x3F17690", VA = "0x183F18690")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNEHPJKOLEF JPFCGKEELBF, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3F176F0", Offset = "0x3F166F0", VA = "0x183F176F0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNEHPJKOLEF JPFCGKEELBF, PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x82B5860", Offset = "0x82B4860", VA = "0x1882B5860", Slot = "204")]
		public void RpcAllBuffered(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F5A0", Offset = "0x3F1E5A0", VA = "0x183F1F5A0", Slot = "205")]
		public void RpcAllBuffered<T1>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F030", Offset = "0x3F1E030", VA = "0x183F1F030", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3F1EE70", Offset = "0x3F1DE70", VA = "0x183F1EE70", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E6D0", Offset = "0x3F1D6D0", VA = "0x183F1E6D0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DDA0", Offset = "0x3F1CDA0", VA = "0x183F1DDA0", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D590", Offset = "0x3F1C590", VA = "0x183F1D590", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1CC90", Offset = "0x3F1BC90", VA = "0x183F1CC90", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C5D0", Offset = "0x3F1B5D0", VA = "0x183F1C5D0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B760", Offset = "0x3F1A760", VA = "0x183F1B760", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNEHPJKOLEF JPFCGKEELBF, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3F1AB60", Offset = "0x3F19B60", VA = "0x183F1AB60", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNEHPJKOLEF JPFCGKEELBF, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A2C0", Offset = "0x3F192C0", VA = "0x183F1A2C0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNEHPJKOLEF JPFCGKEELBF, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3F199D0", Offset = "0x3F189D0", VA = "0x183F199D0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNEHPJKOLEF JPFCGKEELBF, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3F18190", Offset = "0x3F17190", VA = "0x183F18190", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNEHPJKOLEF JPFCGKEELBF, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3F171A0", Offset = "0x3F161A0", VA = "0x183F171A0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNEHPJKOLEF JPFCGKEELBF, PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x82B6F30", Offset = "0x82B5F30", VA = "0x1882B6F30", Slot = "219")]
		public void RpcOthersBuffered(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EHHBNAKIPAI JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3F57D80", Offset = "0x3F56D80", VA = "0x183F57D80", Slot = "220")]
		public void RpcOthersBuffered<T1>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDFKFHCHNGI<T1> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3F57AA0", Offset = "0x3F56AA0", VA = "0x183F57AA0", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EELJPLMGKNG<T1, T2> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3F573F0", Offset = "0x3F563F0", VA = "0x183F573F0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BNCPMHKBGNK<T1, T2, T3> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3F56DC0", Offset = "0x3F55DC0", VA = "0x183F56DC0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, T4> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3F56900", Offset = "0x3F55900", VA = "0x183F56900", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, T5> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3F563F0", Offset = "0x3F553F0", VA = "0x183F563F0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, T6> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3F55890", Offset = "0x3F54890", VA = "0x183F55890", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, T7> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3F54ED0", Offset = "0x3F53ED0", VA = "0x183F54ED0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, T8> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3F547C0", Offset = "0x3F537C0", VA = "0x183F547C0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, T9> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3F53860", Offset = "0x3F52860", VA = "0x183F53860", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNEHPJKOLEF JPFCGKEELBF, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3F53010", Offset = "0x3F52010", VA = "0x183F53010", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNEHPJKOLEF JPFCGKEELBF, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3F522D0", Offset = "0x3F512D0", VA = "0x183F522D0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNEHPJKOLEF JPFCGKEELBF, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F51490", Offset = "0x3F50490", VA = "0x183F51490", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNEHPJKOLEF JPFCGKEELBF, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F50540", Offset = "0x3F4F540", VA = "0x183F50540", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNEHPJKOLEF JPFCGKEELBF, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x82B6FD0", Offset = "0x82B5FD0", VA = "0x1882B6FD0")]
		public void RpcOthersBuffered(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDFKFHCHNGI<KODDFPHIGAD> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F57FC0", Offset = "0x3F56FC0", VA = "0x183F57FC0")]
		public void RpcOthersBuffered<T1>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EELJPLMGKNG<T1, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F57C10", Offset = "0x3F56C10", VA = "0x183F57C10")]
		public void RpcOthersBuffered<T1, T2>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BNCPMHKBGNK<T1, T2, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F575B0", Offset = "0x3F565B0", VA = "0x183F575B0")]
		public void RpcOthersBuffered<T1, T2, T3>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F56FD0", Offset = "0x3F55FD0", VA = "0x183F56FD0")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F566A0", Offset = "0x3F556A0", VA = "0x183F566A0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F55E90", Offset = "0x3F54E90", VA = "0x183F55E90")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F55590", Offset = "0x3F54590", VA = "0x183F55590")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F54B70", Offset = "0x3F53B70", VA = "0x183F54B70")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, KODDFPHIGAD> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F54410", Offset = "0x3F53410", VA = "0x183F54410")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNEHPJKOLEF JPFCGKEELBF, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F53460", Offset = "0x3F52460", VA = "0x183F53460")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNEHPJKOLEF JPFCGKEELBF, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F52770", Offset = "0x3F51770", VA = "0x183F52770")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNEHPJKOLEF JPFCGKEELBF, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F51E30", Offset = "0x3F50E30", VA = "0x183F51E30")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNEHPJKOLEF JPFCGKEELBF, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F50F90", Offset = "0x3F4FF90", VA = "0x183F50F90")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNEHPJKOLEF JPFCGKEELBF, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FFF0", Offset = "0x3F4EFF0", VA = "0x183F4FFF0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNEHPJKOLEF JPFCGKEELBF, PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x82B7070", Offset = "0x82B6070", VA = "0x1882B7070", Slot = "234")]
		public void RpcOthersBuffered(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDFKFHCHNGI<CFLNMMPBLFL> JFPLGEEKCOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3F57EA0", Offset = "0x3F56EA0", VA = "0x183F57EA0", Slot = "235")]
		public void RpcOthersBuffered<T1>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.EELJPLMGKNG<T1, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F57930", Offset = "0x3F56930", VA = "0x183F57930", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BNCPMHKBGNK<T1, T2, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F57770", Offset = "0x3F56770", VA = "0x183F57770", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LHBMAKOCNII<T1, T2, T3, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F571E0", Offset = "0x3F561E0", VA = "0x183F571E0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.IFLHHBDGFPK<T1, T2, T3, T4, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F56B60", Offset = "0x3F55B60", VA = "0x183F56B60", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LDAMEGDGMCD<T1, T2, T3, T4, T5, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F56140", Offset = "0x3F55140", VA = "0x183F56140", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.LBKBCMHFFMM<T1, T2, T3, T4, T5, T6, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F55B90", Offset = "0x3F54B90", VA = "0x183F55B90", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.HFKJCHKNOAM<T1, T2, T3, T4, T5, T6, T7, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F55230", Offset = "0x3F54230", VA = "0x183F55230", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNEHPJKOLEF JPFCGKEELBF, CPJADGCCENP.BFDPHHHGMMA<T1, T2, T3, T4, T5, T6, T7, T8, CFLNMMPBLFL> JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F54060", Offset = "0x3F53060", VA = "0x183F54060", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNEHPJKOLEF JPFCGKEELBF, BMDJDDPKODO JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F53C60", Offset = "0x3F52C60", VA = "0x183F53C60", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNEHPJKOLEF JPFCGKEELBF, ANEMJALPJEG JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F52BC0", Offset = "0x3F51BC0", VA = "0x183F52BC0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNEHPJKOLEF JPFCGKEELBF, NAGPOEBOIMA JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F51990", Offset = "0x3F50990", VA = "0x183F51990", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNEHPJKOLEF JPFCGKEELBF, AHCHOEFFMGF JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F50A90", Offset = "0x3F4FA90", VA = "0x183F50A90", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNEHPJKOLEF JPFCGKEELBF, MHKEKLBEHFJ JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FAA0", Offset = "0x3F4EAA0", VA = "0x183F4FAA0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNEHPJKOLEF JPFCGKEELBF, PNEKGBBEEKB JFPLGEEKCOD, T1 NLKIMELACNC, T2 CGDHCFDIFNJ, T3 FFHGPJBAAAC, T4 EIBDGENDEFD, T5 KLFMGKFPANN, T6 ICFBDEKIMHK, T7 FMGIMBOCIGH, T8 NNEGHLHNDGJ, T9 BAOIJKHNEAL, T10 KBHDAIJLJAG, T11 DCKILHGIIMP, T12 PGHPMLPMAKP, T13 AHLPILBCFFN, T14 BFJCFDBENLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x82B3320", Offset = "0x82B2320", VA = "0x1882B3320", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x82B3540", Offset = "0x82B2540", VA = "0x1882B3540", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2056820", Offset = "0x2055820", VA = "0x182056820")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LAIMFFMFJIG
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x82A32E0", Offset = "0x82A22E0", VA = "0x1882A32E0")]
	private static bool AMJKDDMCBHN(ViewId PBJHGGBBAAF, [Out] RRNetworkView GBKCMPDBPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D8A0", Offset = "0x3D4C8A0", VA = "0x183D4D8A0")]
	[CanBeNull]
	public static T BGHMAKEKLFI<T>(this ViewId FKHACEBFNLD)
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
		private sealed class BMKOCBALBBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public IALDHONKEJC[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public BMKOCBALBBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8299E00", Offset = "0x8298E00", VA = "0x188299E00")]
			internal int EMDJLEGEFFJ(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8299E80", Offset = "0x8298E80", VA = "0x188299E80")]
			internal void PMEOMPGKCNA(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly ONIHMLNNEEF EFJNGOKNPIL;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static IALDHONKEJC[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal int FCFABJCOKKN;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x82B8970", Offset = "0x82B7970", VA = "0x1882B8970")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x82B8F90", Offset = "0x82B7F90", VA = "0x1882B8F90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x82B9360", Offset = "0x82B8360", VA = "0x1882B9360")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x82B93E0", Offset = "0x82B83E0", VA = "0x1882B93E0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x82B8E90", Offset = "0x82B7E90", VA = "0x1882B8E90")]
		private void HMIEEKFGBNI(IALDHONKEJC DEHOOJMHOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x82B8E90", Offset = "0x82B7E90", VA = "0x1882B8E90")]
		private void KKNHOOFNEOJ(IALDHONKEJC MJGDLOJAIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x82B8DB0", Offset = "0x82B7DB0", VA = "0x1882B8DB0")]
		private void CPJDIIDMEEF(IALDHONKEJC AOLDFGCJAAE, IDictionary<object, object> KFHINLEDJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x82B8820", Offset = "0x82B7820", VA = "0x1882B8820")]
		public static void AssignPlayerNumbers(int IHDLHDMBDGL, int CHPPAIBBLHH, Func<int, int> BBCHKKHPPFN, Action<int, int> MEKHGLGNBGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x82B9490", Offset = "0x82B8490", VA = "0x1882B9490")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x82B8EA0", Offset = "0x82B7EA0", VA = "0x1882B8EA0")]
		private void OAHBPGDDGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA71910", Offset = "0xA70910", VA = "0x180A71910")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BDBGHMEIKMD
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x82986D0", Offset = "0x82976D0", VA = "0x1882986D0")]
	public static int FOGMEKEGJCA(this IALDHONKEJC MFOAOKBDIIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8298870", Offset = "0x8297870", VA = "0x188298870")]
	public static void ICOJHCFNFBC(this IALDHONKEJC MFOAOKBDIIM, int OHHIPPHJNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FLLDIHCKNOM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void EAOPIKNEMDP(Hashtable KAEILAKIAKE);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void LMAIJPDLEKM(IALDHONKEJC MFOAOKBDIIM, Hashtable KAEILAKIAKE);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event EAOPIKNEMDP LACMPBIHEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x829DDF0", Offset = "0x829CDF0", VA = "0x18829DDF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x829DBB0", Offset = "0x829CBB0", VA = "0x18829DBB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event EAOPIKNEMDP MDKPNMIDNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x829DAF0", Offset = "0x829CAF0", VA = "0x18829DAF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x829DF70", Offset = "0x829CF70", VA = "0x18829DF70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event LMAIJPDLEKM FANLKPALEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x829DA30", Offset = "0x829CA30", VA = "0x18829DA30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x829DD30", Offset = "0x829CD30", VA = "0x18829DD30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event LMAIJPDLEKM MPFNGPNJNCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x829DEB0", Offset = "0x829CEB0", VA = "0x18829DEB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x829DC70", Offset = "0x829CC70", VA = "0x18829DC70")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class DOMAAFDNINC
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int LDBOHICCOEN;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int FGEIKFBEAHP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int GDGKJKHHFCO;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x829D670", Offset = "0x829C670", VA = "0x18829D670")]
	public static void INLNIAEMCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x829D590", Offset = "0x829C590", VA = "0x18829D590")]
	public static void HMAAJFFPFHP(int[] HECOHADOHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x829D6C0", Offset = "0x829C6C0", VA = "0x18829D6C0")]
	public static int JAGFMEKOMOJ(int IJIDDFFALKB, bool EHCLBECEGIF = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(CCHCLAPPKAG), new string[] { })]
public class CCHCLAPPKAG : PKLFDEMCFPI, LHEPLCJNPLE, MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable KNOCLJMGHFL;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable KKFDHEFDBIP;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly Hashtable HDMOGGFMPPB;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly NDFFKECCNKF FCFKHOPCDKK;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly NDFFKECCNKF BOBAEKEGEEC;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly NDFFKECCNKF EAHOKJBEJKF;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly NDFFKECCNKF NNMKOCHIKFC;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly NDFFKECCNKF AAFNLKDIKGI;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int LABCJPEAOEA;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x829B7A0", Offset = "0x829A7A0", VA = "0x18829B7A0", Slot = "18")]
	public void MGLFJJLMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x829C2B0", Offset = "0x829B2B0", VA = "0x18829C2B0", Slot = "19")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x829A890", Offset = "0x8299890", VA = "0x18829A890", Slot = "4")]
	public bool FCJHEFCOOKJ(JPLLLGDDHLG OGEALFKCCAP, bool EBMFINCHICL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x829B3E0", Offset = "0x829A3E0", VA = "0x18829B3E0", Slot = "5")]
	public int MGKAPLAFBKC(JPLLLGDDHLG[] DONGFMGPGAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x829ABC0", Offset = "0x8299BC0", VA = "0x18829ABC0", Slot = "6")]
	public bool GDKBEPFGJII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x829B240", Offset = "0x829A240", VA = "0x18829B240", Slot = "7")]
	public bool LHMKDLCHGJG(int FKHACEBFNLD, int NBLGAILFCHC, bool KNCGDJFCBKK, GameObject GLGAAAMILBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x829C0C0", Offset = "0x829B0C0", VA = "0x18829C0C0", Slot = "8")]
	public void MKFNKOBAMBM(int NBLGAILFCHC, [Optional] int? PBGEPNGBHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x829BF50", Offset = "0x829AF50", VA = "0x18829BF50", Slot = "9")]
	public bool MJNHLACGDFH(PMOFBKDCPEL PHDJPEOAFMD, [Out] JPLLLGDDHLG BBABGPFNELB, bool JPIFAGBGBNP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x829AE70", Offset = "0x8299E70", VA = "0x18829AE70", Slot = "10")]
	public bool JIDDLHNLMHE(PMOFBKDCPEL PHDJPEOAFMD, [Out] int GFMHNEFFLCK, [Out] JPLLLGDDHLG[] DONGFMGPGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x829A690", Offset = "0x8299690", VA = "0x18829A690", Slot = "11")]
	public bool DOPGAGHBJPJ(PMOFBKDCPEL PHDJPEOAFMD, [Out] int NBLGAILFCHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x829A070", Offset = "0x8299070", VA = "0x18829A070", Slot = "12")]
	public void DGFMJNOLICD(PMOFBKDCPEL PHDJPEOAFMD, [Out] int HDHDICGBNAD, [Out] int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x8299F10", Offset = "0x8298F10", VA = "0x188299F10", Slot = "13")]
	public void AECKHLIBLHJ(int GFMHNEFFLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x829AAA0", Offset = "0x8299AA0", VA = "0x18829AAA0", Slot = "14")]
	public void FGMFOLODKBE(int GFMHNEFFLCK, int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x829ADC0", Offset = "0x8299DC0", VA = "0x18829ADC0", Slot = "15")]
	public void HHAGBPHAAAP(int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x829A9D0", Offset = "0x82999D0", VA = "0x18829A9D0", Slot = "16")]
	public void FELPCCCAIMA(int[] BOLCPBHHAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x829AC50", Offset = "0x8299C50", VA = "0x18829AC50", Slot = "17")]
	public void GIFJPJNOCKD(int GFMHNEFFLCK, int NBLGAILFCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x829A250", Offset = "0x8299250", VA = "0x18829A250")]
	private static void DHJGINCFHGH(JPLLLGDDHLG OGEALFKCCAP, Hashtable EEEAAFAMLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x829B840", Offset = "0x829A840", VA = "0x18829B840")]
	private static bool MJNHLACGDFH(Hashtable EEEAAFAMLLD, IALDHONKEJC DAKOFAPAGCA, [Out] JPLLLGDDHLG BBABGPFNELB, bool JPIFAGBGBNP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x829B150", Offset = "0x829A150", VA = "0x18829B150")]
	private static bool JJFPKPDPKAP(int NBLGAILFCHC, JPLLLGDDHLG EEEAAFAMLLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x829A7B0", Offset = "0x82997B0", VA = "0x18829A7B0")]
	private static int DPMPIJBGJDB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CCHCLAPPKAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(CMMKICJDIPF), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class CMMKICJDIPF : FPALJLNJIEN, LHEPLCJNPLE, MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable PLCJOJDDHKK;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static Hashtable HECIFOFLJNC;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static NDFFKECCNKF CDOAKJHFAPN;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly NDFFKECCNKF GKMEKAPKKAC;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x829D110", Offset = "0x829C110", VA = "0x18829D110", Slot = "8")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x829CAA0", Offset = "0x829BAA0", VA = "0x18829CAA0", Slot = "7")]
	public void MGLFJJLMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x829C9B0", Offset = "0x829B9B0", VA = "0x18829C9B0", Slot = "4")]
	public void JNFLJIPKEIM(ViewId FKHACEBFNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x829C650", Offset = "0x829B650", VA = "0x18829C650", Slot = "5")]
	public bool JMPBGIHHFOH(PMOFBKDCPEL PHDJPEOAFMD, [Out] ViewId FKHACEBFNLD, [Out] string PGEDMIEEBID, [Out] int DDNKPFFNBPO, [Out] object[] GHNOIAMBGEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x829CB40", Offset = "0x829BB40", VA = "0x18829CB40", Slot = "6")]
	public void NHJBKCLABIG(ViewId GBKCMPDBPJK, string PGEDMIEEBID, OLHLIDNBNCP EIGJCNKKPKC, IALDHONKEJC MFOAOKBDIIM, JKPDADGJJHJ LJKPKJJEMGM, object[] OGEALFKCCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CMMKICJDIPF()
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
