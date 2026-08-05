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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80E5A30", Offset = "0x80E4030", VA = "0x1880E5A30", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2251A10", Offset = "0x2250010", VA = "0x182251A10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80EE8D0", Offset = "0x80ECED0", VA = "0x1880EE8D0")]
		private void FKDKBEPAOOM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80EEF20", Offset = "0x80ED520", VA = "0x1880EEF20")]
		private void HCPAJCJNEGO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80EF1A0", Offset = "0x80ED7A0", VA = "0x1880EF1A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80EF250", Offset = "0x80ED850", VA = "0x1880EF250")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LBEGBPKAFOO
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LHMKAIAPMBI HLMMJBEMNBB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LHMKAIAPMBI OMAOPIFCGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80E5890", Offset = "0x80E3E90", VA = "0x1880E5890")]
		get
		{
			return default(LHMKAIAPMBI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KLLLLOBICDB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView FMKKJEMGABB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PAECPIFIIMN LFNMHNCBFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BAMLHHNPJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(LDNIIBCAMDE KADMGKOABJA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(EDHBHKMPCLC FGCEFPKBOEH, LDNIIBCAMDE KADMGKOABJA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MMHLOGFBGNH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IIJPNNHIOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBOMBLDKMDF(EDHBHKMPCLC FGCEFPKBOEH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJJOMODMCLM(EDHBHKMPCLC FGCEFPKBOEH, LDNIIBCAMDE KADMGKOABJA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HOECGJCMDCH : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCHHFLKMKEK(KLLLLOBICDB GMIHGCLFNIL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAEMAGCOOJI(KLLLLOBICDB GMIHGCLFNIL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFLDODKGCNL(ACCIKKDAEHK.HDMIMEDDAFF DHIBMENBFFJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPDGOONPHND();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKFJFLJBGML(object FLDOIECLDLD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PAECPIFIIMN : byte
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
public struct EDHBHKMPCLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int IDLICKGDHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint EDJJENGNFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public double LLGFHNPDBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int HHKGJMIOMBN;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KPIHNDCAHGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<(ViewId, PAECPIFIIMN), MMHLOGFBGNH> MKDOKINKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly List<KLLLLOBICDB> BGFLHBFKKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HashSet<(ViewId, PAECPIFIIMN)> APCLNJGMNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int MNIKJOKKJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public bool BNCAKEBPMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private ACCIKKDAEHK.HDMIMEDDAFF DHIBMENBFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MemoryStream LPNNMLDMAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly LDNIIBCAMDE FFPBLDLEDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LDNIIBCAMDE CJLEKIPJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private byte[] ICCACCIMMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float FNDDKBOBGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int PPCMGMPJIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80E5670", Offset = "0x80E3C70", VA = "0x1880E5670")]
	public KPIHNDCAHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80E42D0", Offset = "0x80E28D0", VA = "0x1880E42D0")]
	public void CFLDODKGCNL(ACCIKKDAEHK.HDMIMEDDAFF DHIBMENBFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80E4FE0", Offset = "0x80E35E0", VA = "0x1880E4FE0")]
	public void JPDGOONPHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80E46D0", Offset = "0x80E2CD0", VA = "0x1880E46D0")]
	public void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80E4AB0", Offset = "0x80E30B0", VA = "0x1880E4AB0")]
	public bool JDPCENHCAFL(KLLLLOBICDB GMIHGCLFNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80E41A0", Offset = "0x80E27A0", VA = "0x1880E41A0")]
	public bool BAFGFGCDOJB(KLLLLOBICDB GMIHGCLFNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80E5450", Offset = "0x80E3A50", VA = "0x1880E5450")]
	private MMHLOGFBGNH OMJIMKNALNG(ViewId KHKLDAJCFCJ, PAECPIFIIMN KADADLFANKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80E53E0", Offset = "0x80E39E0", VA = "0x1880E53E0")]
	public void LHLGMGGDIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80E53F0", Offset = "0x80E39F0", VA = "0x1880E53F0")]
	private void MGLEOEMCLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80E46B0", Offset = "0x80E2CB0", VA = "0x1880E46B0")]
	private void GNIGHEGJPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80E5030", Offset = "0x80E3630", VA = "0x1880E5030")]
	public bool LBEIIJOGMAL(FastBufferWriter DCGAFNKBAGF, int ANHMLDLBLAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80E42F0", Offset = "0x80E28F0", VA = "0x1880E42F0")]
	public void FJJOMODMCLM(EDHBHKMPCLC FGCEFPKBOEH, FastBufferReader KMBIKKJCMFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class KNMJHONALFP : MMHLOGFBGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KLLLLOBICDB AELDAJHFNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private uint GCJEDLHEFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int OGBJABDOALA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IIJPNNHIOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public KNMJHONALFP(KLLLLOBICDB AELDAJHFNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80E4090", Offset = "0x80E2690", VA = "0x1880E4090", Slot = "5")]
	public bool NBOMBLDKMDF(EDHBHKMPCLC FGCEFPKBOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80E3FB0", Offset = "0x80E25B0", VA = "0x1880E3FB0", Slot = "6")]
	public void FJJOMODMCLM(EDHBHKMPCLC FGCEFPKBOEH, LDNIIBCAMDE KADMGKOABJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JBJOJCLDBCE : MMHLOGFBGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private ACCIKKDAEHK.HDMIMEDDAFF DHIBMENBFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ViewId KHKLDAJCFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int OGBJABDOALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private uint GCJEDLHEFBE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IIJPNNHIOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F2A0", Offset = "0x1B3D8A0", VA = "0x181B3F2A0")]
	public JBJOJCLDBCE(ViewId KHKLDAJCFCJ, ACCIKKDAEHK.HDMIMEDDAFF DHIBMENBFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80D3280", Offset = "0x80D1880", VA = "0x1880D3280", Slot = "5")]
	public bool NBOMBLDKMDF(EDHBHKMPCLC FGCEFPKBOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80D30A0", Offset = "0x80D16A0", VA = "0x1880D30A0", Slot = "6")]
	public void FJJOMODMCLM(EDHBHKMPCLC FGCEFPKBOEH, LDNIIBCAMDE KADMGKOABJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DMOMNHDDGFC
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80D04F0", Offset = "0x80CEAF0", VA = "0x1880D04F0")]
	public static void LGGJGPOGIBH(this CJADACKPEDL BAOCIBMGJAC, LDNIIBCAMDE NHMPJPFDCGP, ViewId HILCMKALFIH, bool EHCDJEMEBHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80CFFF0", Offset = "0x80CE5F0", VA = "0x1880CFFF0")]
	public static void HOLCPGICDIK(this CJADACKPEDL BAOCIBMGJAC, LDNIIBCAMDE NHMPJPFDCGP, bool EHCDJEMEBHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80CFE80", Offset = "0x80CE480", VA = "0x1880CFE80")]
	public static CJADACKPEDL FJJOMODMCLM(LDNIIBCAMDE NHMPJPFDCGP, ViewId HILCMKALFIH, bool EHCDJEMEBHD = true)
	{
		return default(CJADACKPEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80CFAC0", Offset = "0x80CE0C0", VA = "0x1880CFAC0")]
	public static void BGFALKJPMAJ(this CJADACKPEDL BAOCIBMGJAC, LDNIIBCAMDE NHMPJPFDCGP, bool EHCDJEMEBHD = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(HOECGJCMDCH), new string[] { })]
public class CGEJNNBKEDI : HOECGJCMDCH, INetworkUpdateSystem, CEGGANPCFLD, JFAKIPDGBHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LHMKAIAPMBI DGAMDLGKBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KPIHNDCAHGH AIKAEGKEGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private uint HHFHJBCGJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float EFOHPNHGNPG;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80CEA20", Offset = "0x80CD020", VA = "0x1880CEA20", Slot = "4")]
	public void CCHHFLKMKEK(KLLLLOBICDB GMIHGCLFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80CF720", Offset = "0x80CDD20", VA = "0x1880CF720", Slot = "5")]
	public void PAEMAGCOOJI(KLLLLOBICDB GMIHGCLFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80CE8C0", Offset = "0x80CCEC0", VA = "0x1880CE8C0", Slot = "10")]
	public void BHAOPDEOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80CF6A0", Offset = "0x80CDCA0", VA = "0x1880CF6A0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage CCGAKABAJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80CF0D0", Offset = "0x80CD6D0", VA = "0x1880CF0D0")]
	private void MGOAHEPBDAG(uint IDDBPELFJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80CEB40", Offset = "0x80CD140", VA = "0x1880CEB40", Slot = "6")]
	public void CFLDODKGCNL(ACCIKKDAEHK.HDMIMEDDAFF DHIBMENBFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80CEEF0", Offset = "0x80CD4F0", VA = "0x1880CEEF0", Slot = "7")]
	public void JPDGOONPHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80CF070", Offset = "0x80CD670", VA = "0x1880CF070", Slot = "8")]
	public void KKFJFLJBGML(object OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80CEB70", Offset = "0x80CD170", VA = "0x1880CEB70")]
	private void GECLCGELJEL(FNFHFOLBALO OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80CEF50", Offset = "0x80CD550", VA = "0x1880CEF50", Slot = "11")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80CF920", Offset = "0x80CDF20", VA = "0x1880CF920")]
	public CGEJNNBKEDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AEPEICBGILA : MMHLOGFBGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private float JCHCFOBMGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int OGBJABDOALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private uint GCJEDLHEFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PAECPIFIIMN BJNJDHMFALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EDHBHKMPCLC DIHODMFBJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PGHPEOOLALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte[] NFKCBAPNDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EDHBHKMPCLC ONCGBDCNBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int GJOKPJDHNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private byte[] LGCINOHJAKF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IIJPNNHIOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80CCEC0", Offset = "0x80CB4C0", VA = "0x1880CCEC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80CD2B0", Offset = "0x80CB8B0", VA = "0x1880CD2B0")]
	public AEPEICBGILA(PAECPIFIIMN BJNJDHMFALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80CD270", Offset = "0x80CB870", VA = "0x1880CD270", Slot = "5")]
	public bool NBOMBLDKMDF(EDHBHKMPCLC FGCEFPKBOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80CCEF0", Offset = "0x80CB4F0", VA = "0x1880CCEF0", Slot = "6")]
	public void FJJOMODMCLM(EDHBHKMPCLC FGCEFPKBOEH, LDNIIBCAMDE KADMGKOABJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80CCDB0", Offset = "0x80CB3B0", VA = "0x1880CCDB0")]
	internal KNMJHONALFP ADJCHEKFCFO(KLLLLOBICDB GMIHGCLFNIL, LDNIIBCAMDE NHMPJPFDCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80CD0A0", Offset = "0x80CB6A0", VA = "0x1880CD0A0")]
	private static void MHANEDIOFPI(KNMJHONALFP NLCEPAJBDAG, LDNIIBCAMDE NHMPJPFDCGP, EDHBHKMPCLC JPJANIIGKJM, byte[] LBNJMEGEAHB, int OGJNIBDHDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(IEBJEJCLBDM), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class IEBJEJCLBDM : CDFJDLPGMFI, CEGGANPCFLD, JFAKIPDGBHA
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable EOLFOHMBGLH;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable KDICGNAGCIK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly Hashtable COOPGDHAAKC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly JCLKAOOIHID ECNMKDBOHAJ;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly JCLKAOOIHID ODHJBHEADOO;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly JCLKAOOIHID EEFBLANIKJA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly JCLKAOOIHID DAIJBBANCCM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly JCLKAOOIHID KBIJKENCMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int LFICEMDKING;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80D16A0", Offset = "0x80CFCA0", VA = "0x1880D16A0", Slot = "4")]
	public bool GKKJPNFJKHN(JGBANCDMBHO MJNKOFMOBDK, bool ANCEAEEIOGO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80D26D0", Offset = "0x80D0CD0", VA = "0x1880D26D0", Slot = "5")]
	public int OBOACPPDCOO(JGBANCDMBHO[] NJDBHJCEPHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80D14B0", Offset = "0x80CFAB0", VA = "0x1880D14B0", Slot = "6")]
	public bool ELOIBMCBBLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80D2410", Offset = "0x80D0A10", VA = "0x1880D2410", Slot = "7")]
	public bool MIMCOJFCNIH(int KHKLDAJCFCJ, int JIGCFPDKNLI, bool FDCNOLIDKPN, GameObject KGMBEOBCDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80D10E0", Offset = "0x80CF6E0", VA = "0x1880D10E0", Slot = "8")]
	public void DAKECFCAFDN(int JIGCFPDKNLI, [Optional] int? FPENDCNNLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80D1A00", Offset = "0x80D0000", VA = "0x1880D1A00", Slot = "9")]
	public bool MACAIFHFLIC(FNFHFOLBALO FLDOIECLDLD, [Out] JGBANCDMBHO OGIJGOGLNOD, bool AGIKINLJOGJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80D2130", Offset = "0x80D0730", VA = "0x1880D2130", Slot = "10")]
	public bool MHGKOHKEBCA(FNFHFOLBALO FLDOIECLDLD, [Out] int APPPOPKJKAA, [Out] JGBANCDMBHO[] NJDBHJCEPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80D25B0", Offset = "0x80D0BB0", VA = "0x1880D25B0", Slot = "11")]
	public bool MNDCHCGMNEO(FNFHFOLBALO FLDOIECLDLD, [Out] int JIGCFPDKNLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80D12D0", Offset = "0x80CF8D0", VA = "0x1880D12D0", Slot = "12")]
	public void ECAPELGGELK(FNFHFOLBALO FLDOIECLDLD, [Out] int BPPCCBFJCIO, [Out] int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80D1540", Offset = "0x80CFB40", VA = "0x1880D1540", Slot = "13")]
	public void GDGHNAMFAOA(int APPPOPKJKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80D2A90", Offset = "0x80D1090", VA = "0x1880D2A90", Slot = "14")]
	public void OFEJOIMFNBC(int APPPOPKJKAA, int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80D18B0", Offset = "0x80CFEB0", VA = "0x1880D18B0", Slot = "15")]
	public void IAEHCPPELEC(int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80D17E0", Offset = "0x80CFDE0", VA = "0x1880D17E0", Slot = "16")]
	public void HEBEAKDCKLI(int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80D0ED0", Offset = "0x80CF4D0", VA = "0x1880D0ED0", Slot = "17")]
	public void BDDACOLBBPK(int APPPOPKJKAA, int JIGCFPDKNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A90", Offset = "0x80CF090", VA = "0x1880D0A90")]
	private static void AKHOEKJIGIN(JGBANCDMBHO MJNKOFMOBDK, Hashtable ODGBFNBKDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80D1B70", Offset = "0x80D0170", VA = "0x1880D1B70")]
	private static bool MACAIFHFLIC(Hashtable ODGBFNBKDAA, KNOJHPOMDED DPPKHMGGMMM, [Out] JGBANCDMBHO OGIJGOGLNOD, bool AGIKINLJOGJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80D2BB0", Offset = "0x80D11B0", VA = "0x1880D2BB0")]
	private static int PABPMKDBJHH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80D1040", Offset = "0x80CF640", VA = "0x1880D1040", Slot = "18")]
	public void BHAOPDEOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80D1960", Offset = "0x80CFF60", VA = "0x1880D1960", Slot = "19")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IEBJEJCLBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(KAABIPCPEAP), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KAABIPCPEAP : CEJNGAAHCCJ, CEGGANPCFLD, JFAKIPDGBHA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable IOPLGCJABMP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static Hashtable GEHGAOKBOEI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static JCLKAOOIHID GLJFOKIAKFP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly JCLKAOOIHID CALBOBFEFII;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80DCF20", Offset = "0x80DB520", VA = "0x1880DCF20", Slot = "4")]
	public void BIBGDJHHDLC(ViewId KHKLDAJCFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80DCB30", Offset = "0x80DB130", VA = "0x1880DCB30", Slot = "5")]
	public bool BFDBOGIDPOM(FNFHFOLBALO FLDOIECLDLD, [Out] ViewId KHKLDAJCFCJ, [Out] string CDPMPGGLFJF, [Out] int CDIOMMNBKMD, [Out] object[] PAABDOHHHNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80DD010", Offset = "0x80DB610", VA = "0x1880DD010", Slot = "6")]
	public void GMCHIKDABMH(ViewId PHGOJDGOFOF, string CDPMPGGLFJF, MDFBHDODLPI AKJFMIDDDFO, KNOJHPOMDED OPOGJMFOAFI, JJGIIBPDLLN KLAOKOGJJME, object[] MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80DD5E0", Offset = "0x80DBBE0", VA = "0x1880DD5E0", Slot = "8")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80DCE80", Offset = "0x80DB480", VA = "0x1880DCE80", Slot = "7")]
	public void BHAOPDEOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KAABIPCPEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LDJDCMADLLO
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80E59A0", Offset = "0x80E3FA0", VA = "0x1880E59A0")]
	public static KNOJHPOMDED MBLMNCMFDHK(this PECONNHPBAN HKLGEDHKAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80E5950", Offset = "0x80E3F50", VA = "0x1880E5950")]
	public static PECONNHPBAN BOHFMHEHLBI(this KNOJHPOMDED OPOGJMFOAFI)
	{
		return default(PECONNHPBAN);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, HGKLMBMDGIA, AKKKLPFJHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<HHDDIJLLDKI> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId AHFIPNKBHFN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80E7060", Offset = "0x80E5660", VA = "0x1880E7060")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId DALNOMNLOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x80E7060", Offset = "0x80E5660", VA = "0x1880E7060", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView PNENHMDGAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x80E70E0", Offset = "0x80E56E0", VA = "0x1880E70E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView FMKKJEMGABB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x80E70E0", Offset = "0x80E56E0", VA = "0x1880E70E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KNOJHPOMDED ADMKLFECAIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x80E71E0", Offset = "0x80E57E0", VA = "0x1880E71E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KNOJHPOMDED FMBOIKGHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x80E7540", Offset = "0x80E5B40", VA = "0x1880E7540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BOFMDAHMCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x80E7340", Offset = "0x80E5940", VA = "0x1880E7340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NBEBJOANKNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x80E74B0", Offset = "0x80E5AB0", VA = "0x1880E74B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ODODEEHGIPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x80E6F90", Offset = "0x80E5590", VA = "0x1880E6F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MDCOBEEGCBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x80E7270", Offset = "0x80E5870", VA = "0x1880E7270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HOEAJNHFPBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x80E6F90", Offset = "0x80E5590", VA = "0x1880E6F90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HMAKFNKAJGK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x80E7010", Offset = "0x80E5610", VA = "0x1880E7010", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string JNDIDGCJFAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x80E7150", Offset = "0x80E5750", VA = "0x1880E7150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool AHPAHHDPEHF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x80E6F10", Offset = "0x80E5510", VA = "0x1880E6F10", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<KNOJHPOMDED> LNJOODAFNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x80E6DE0", Offset = "0x80E53E0", VA = "0x1880E6DE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x80E75D0", Offset = "0x80E5BD0", VA = "0x1880E75D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x80E6D40", Offset = "0x80E5340", VA = "0x1880E6D40")]
		public bool WasSpawnedForPlayer(int INELDJMBFAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7424AC0", Offset = "0x74230C0", VA = "0x187424AC0")]
		private void LLDJBJDLOMI(RRNetworkView HKKDKDDKEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80E6970", Offset = "0x80E4F70", VA = "0x1880E6970", Slot = "9")]
		public void RegisterDestroyHandler(HHDDIJLLDKI NKIIOMEEMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x80E6B70", Offset = "0x80E5170", VA = "0x1880E6B70", Slot = "10")]
		public void UnregisterDestroyHandler(HHDDIJLLDKI NKIIOMEEMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80E6950", Offset = "0x80E4F50", VA = "0x1880E6950", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BCNLKLIBEND
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void JJOFDIIPCBH([In] JGBANCDMBHO MJNKOFMOBDK, bool LBBMLMFIKEH, bool ODGBFNBKDAA, bool OAHMMFFHHOI);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void AJNCOFIJMPC(GameObject JLCFNKJMHLL);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void FLGHEMDOOOF(GameObject JLCFNKJMHLL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void IAHGGAPGLKP(RRNetworkView PHGOJDGOFOF, string CDPMPGGLFJF, KNOJHPOMDED NOFJGJEACCI, MDFBHDODLPI? OKOGHNMMGGB, bool LDPKKIJLIDP, JJGIIBPDLLN CDMBFDOICBK, object[] MJNKOFMOBDK, string DIGPKPFDEHE);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void AKMLHOCKCJA(RRNetworkView PHGOJDGOFOF, string CDPMPGGLFJF, KNOJHPOMDED NOFJGJEACCI, MDFBHDODLPI? OKOGHNMMGGB, bool LDPKKIJLIDP, JJGIIBPDLLN CDMBFDOICBK, object[] MJNKOFMOBDK, string DIGPKPFDEHE);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void PDHDGIMKONF(RRNetworkView PHGOJDGOFOF, string CDPMPGGLFJF, object[] PAABDOHHHNL, string OOFBHILAIOL);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void FKOLJMBGFMF(RRNetworkView PHGOJDGOFOF, KNOJHPOMDED ACBOBLAPFOI);

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CompilerGenerated]
	private static AJNCOFIJMPC JHNJCFGPKDM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event JJOFDIIPCBH JLMOANOHJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x80CDCD0", Offset = "0x80CC2D0", VA = "0x1880CDCD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x80CE090", Offset = "0x80CC690", VA = "0x1880CE090")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event AJNCOFIJMPC CFPCGBEMENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x80CE560", Offset = "0x80CCB60", VA = "0x1880CE560")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x80CE770", Offset = "0x80CCD70", VA = "0x1880CE770")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event FLGHEMDOOOF CDNNKGCMNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80CDD90", Offset = "0x80CC390", VA = "0x1880CDD90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x80CDC10", Offset = "0x80CC210", VA = "0x1880CDC10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event FLGHEMDOOOF FACLKKEJLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x80CD940", Offset = "0x80CBF40", VA = "0x1880CD940")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x80CDA00", Offset = "0x80CC000", VA = "0x1880CDA00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event IAHGGAPGLKP BAFGJPMGICL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x80CDB50", Offset = "0x80CC150", VA = "0x1880CDB50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x80CDE50", Offset = "0x80CC450", VA = "0x1880CDE50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event AKMLHOCKCJA MIILEEKLCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x80CD880", Offset = "0x80CBE80", VA = "0x1880CD880")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x80CD730", Offset = "0x80CBD30", VA = "0x1880CD730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event PDHDGIMKONF OEKJKEMPAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x80CDF10", Offset = "0x80CC510", VA = "0x1880CDF10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80CDFD0", Offset = "0x80CC5D0", VA = "0x1880CDFD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event FKOLJMBGFMF GIFHIGONNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80CD670", Offset = "0x80CBC70", VA = "0x1880CD670")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x80CE4A0", Offset = "0x80CCAA0", VA = "0x1880CE4A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event FKOLJMBGFMF COOAIKIPJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80CD5B0", Offset = "0x80CBBB0", VA = "0x1880CD5B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80CE3E0", Offset = "0x80CC9E0", VA = "0x1880CE3E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80CE6B0", Offset = "0x80CCCB0", VA = "0x1880CE6B0")]
	public static void OOOEEJEJLGD([In] JGBANCDMBHO MJNKOFMOBDK, bool LBBMLMFIKEH, bool ODGBFNBKDAA, bool OAHMMFFHHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80CE620", Offset = "0x80CCC20", VA = "0x1880CE620")]
	public static void LPBBIGMHPEG(GameObject JLCFNKJMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x80CE830", Offset = "0x80CCE30", VA = "0x1880CE830")]
	public static void PGHGKMPNALJ(GameObject JLCFNKJMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x80CDAC0", Offset = "0x80CC0C0", VA = "0x1880CDAC0")]
	public static void EBDAJKBBDLA(GameObject JLCFNKJMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80CD7F0", Offset = "0x80CBDF0", VA = "0x1880CD7F0")]
	public static void BNIDHHDNAIA(GameObject JLCFNKJMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x80CE290", Offset = "0x80CC890", VA = "0x1880CE290")]
	public static void KFMMJNGIOBM(RRNetworkView PHGOJDGOFOF, string CDPMPGGLFJF, KNOJHPOMDED NOFJGJEACCI, MDFBHDODLPI? OKOGHNMMGGB, bool LDPKKIJLIDP, JJGIIBPDLLN CDMBFDOICBK, object[] MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x80CE150", Offset = "0x80CC750", VA = "0x1880CE150")]
	public static void JPNBMCNNIKN(RRNetworkView PHGOJDGOFOF, string CDPMPGGLFJF, int DNLINFMODHH, object[] PAABDOHHHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x80CD4B0", Offset = "0x80CBAB0", VA = "0x1880CD4B0")]
	public static void ALJBMPHGKCG(int KHKLDAJCFCJ, int HKLGEDHKAEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KDDAAEGHHLL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x80E0110", Offset = "0x80DE710", VA = "0x1880E0110")]
	[CanBeNull]
	private static bool LKJNEDDKBKB(ViewId HLIPPIOIAJK, [Out] RRNetworkView PHGOJDGOFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x80E0030", Offset = "0x80DE630", VA = "0x1880E0030")]
	[CanBeNull]
	public static Component IECAGEKFNFO(this ViewId PHGOJDGOFOF, Type PMNIGOGOBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA4B0", Offset = "0x3BC8AB0", VA = "0x183BCA4B0")]
	[CanBeNull]
	public static T IECAGEKFNFO<T>(this ViewId PHGOJDGOFOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA4B0", Offset = "0x3BC8AB0", VA = "0x183BCA4B0")]
	[CanBeNull]
	public static T HIPAPIGMBKF<T>(this ViewId PHGOJDGOFOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA500", Offset = "0x3BC8B00", VA = "0x183BCA500")]
	public static bool PJHPBFOANJI<T>(this ViewId PHGOJDGOFOF, [Out] T HPCDHGHHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80DFF60", Offset = "0x80DE560", VA = "0x1880DFF60")]
	[CanBeNull]
	public static RRNetworkView HPMINBGCKDF(this ViewId PHGOJDGOFOF)
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
		private static RRNetworkHandler EFKLKBOLJNG;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler FNIBPMLJKFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x80E7700", Offset = "0x80E5D00", VA = "0x1880E7700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x80E78D0", Offset = "0x80E5ED0", VA = "0x1880E78D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x80E7890", Offset = "0x80E5E90", VA = "0x1880E7890")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(JLJGNCDGAFJ), new string[] { "Photon" })]
public sealed class JLJGNCDGAFJ : FPNGLNAIDLO, CEGGANPCFLD, JFAKIPDGBHA, EHDMDDBFMLM, KKCPJDIALJD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DFJPDLOICNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DFJPDLOICNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x80CFA00", Offset = "0x80CE000", VA = "0x1880CFA00")]
		internal object KJKBMDMNCOO((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static LHMKAIAPMBI ALPEDGKLMIL;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static LHMKAIAPMBI HBLOGCEKBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, HashSet<int>> NKBOPCOLGGL;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static Dictionary<int, int> IDHOGDJNPCP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<(GameObject GameObject, int ParentCount)> ACIHLAAPDEH;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GameObject> KNPNAIMFCLN;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static List<int> MIDJFJKNKAC;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<RRNetworkView> APPLNINPMLP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly JCLKAOOIHID DAIJBBANCCM;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly JCLKAOOIHID KBIJKENCMIJ;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80D47B0", Offset = "0x80D2DB0", VA = "0x1880D47B0", Slot = "8")]
	public void BHAOPDEOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80D8B00", Offset = "0x80D7100", VA = "0x1880D8B00", Slot = "9")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80D8010", Offset = "0x80D6610", VA = "0x1880D8010", Slot = "10")]
	public void InitExternal(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80DC2E0", Offset = "0x80DA8E0", VA = "0x1880DC2E0", Slot = "11")]
	public void OBGIKBGDGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x80D9AF0", Offset = "0x80D80F0", VA = "0x1880D9AF0")]
	private void LFOJMEMHFCN(JDLMMOCIBOE DJPPEFNEIHK, JDLMMOCIBOE DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80D7ED0", Offset = "0x80D64D0", VA = "0x1880D7ED0")]
	private void IHBAJGHAJGJ(EBBJHOMFMHH COCMFLCIFNH, EBBJHOMFMHH LHEIHNIHOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x80D4090", Offset = "0x80D2690", VA = "0x1880D4090")]
	public GameObject ABOOHNGLKCJ(string IEDAJGLJHNI, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, Vector3 HKINPNLCPPL, ViewId KHKLDAJCFCJ, AKGINPGMGBG MJNKOFMOBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x80D74A0", Offset = "0x80D5AA0", VA = "0x1880D74A0")]
	public GameObject GEEHPFMCKII(string IEDAJGLJHNI, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float HKINPNLCPPL, object[] MJNKOFMOBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x80DC4B0", Offset = "0x80DAAB0", VA = "0x1880DC4B0")]
	public GameObject PFPDPKNGEBL(string IEDAJGLJHNI, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, Vector3 HKINPNLCPPL, ViewId PHGOJDGOFOF, AKGINPGMGBG MJNKOFMOBDK, bool OAHMMFFHHOI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x80D99C0", Offset = "0x80D7FC0", VA = "0x1880D99C0")]
	public GameObject KJEOOGEFDLA(JGBANCDMBHO MJNKOFMOBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80D6550", Offset = "0x80D4B50", VA = "0x1880D6550", Slot = "6")]
	public void DENFCMNLELJ(GameObject JLCFNKJMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80D7D80", Offset = "0x80D6380", VA = "0x1880D7D80")]
	public void HFCAPGOGHOA(GameObject KGMBEOBCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x80D7190", Offset = "0x80D5790", VA = "0x1880D7190", Slot = "7")]
	public void GBDFMNFPCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x80D5220", Offset = "0x80D3820", VA = "0x1880D5220", Slot = "4")]
	public GameObject[] CLAFOIDEKMD(IList<BGMIICDLFLJ> BMFONFFIFOI, bool CFNFLGOHACP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80DBF00", Offset = "0x80DA500", VA = "0x1880DBF00", Slot = "5")]
	public void NPKNIKLDGAO(List<GameObject> BDPLFAFMGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x80D7DF0", Offset = "0x80D63F0", VA = "0x1880D7DF0")]
	public void IEPGJPLKLPG(GameObject KGMBEOBCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x80D71A0", Offset = "0x80D57A0", VA = "0x1880D71A0")]
	private void GECLCGELJEL(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x80D9C10", Offset = "0x80D8210", VA = "0x1880D9C10")]
	private void LGGOADJDFDM(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80DA2E0", Offset = "0x80D88E0", VA = "0x1880DA2E0")]
	private void LOLLAJLAJMK(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80D9090", Offset = "0x80D7690", VA = "0x1880D9090")]
	private void KEFCNPIAKOH(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80D68F0", Offset = "0x80D4EF0", VA = "0x1880D68F0")]
	private void FFPJBPPDOBI(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80D6D90", Offset = "0x80D5390", VA = "0x1880D6D90")]
	private void FOOKOMPNEMN(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80D8480", Offset = "0x80D6A80", VA = "0x1880D8480")]
	private void JJPCKBKIIMN(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x80D6600", Offset = "0x80D4C00", VA = "0x1880D6600")]
	private GameObject EDIAJAEEGJA(string HDCPENAKGHI, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, Vector3 HKINPNLCPPL, byte HLMMJBEMNBB = 0, [Optional] object[] ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80D4B20", Offset = "0x80D3120", VA = "0x1880D4B20")]
	private GameObject CIJLGIPJKFK(JGBANCDMBHO MJNKOFMOBDK, bool LBBMLMFIKEH = false, bool ODGBFNBKDAA = false, bool OAHMMFFHHOI = true, bool HLLDDLOAGLF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80D6CB0", Offset = "0x80D52B0", VA = "0x1880D6CB0")]
	private static GameObject FHLNMBJGION(string HDCPENAKGHI, bool HHMGCGNIMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80D8E80", Offset = "0x80D7480", VA = "0x1880D8E80")]
	private static GameObject KCBOFIOLINN(GameObject KFAEMGBGGCC, JGBANCDMBHO MJNKOFMOBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80DBDF0", Offset = "0x80DA3F0", VA = "0x1880DBDF0")]
	private static void NAFABLMMMCL(GameObject JLCFNKJMHLL, RRNetworkView PHGOJDGOFOF, [In] JGBANCDMBHO MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80DA880", Offset = "0x80D8E80", VA = "0x1880DA880")]
	private GameObject[] MMBHBFHIDIH(IList<BGMIICDLFLJ> BMFONFFIFOI, bool CFNFLGOHACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80D81E0", Offset = "0x80D67E0", VA = "0x1880D81E0")]
	private GameObject[] JDMBKPJJIGM(JGBANCDMBHO[] NJDBHJCEPHH, int APPPOPKJKAA, KNOJHPOMDED OPOGJMFOAFI, GameObject[] ENBKCNIFJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80D95B0", Offset = "0x80D7BB0", VA = "0x1880D95B0")]
	private GameObject KIENKPCOMBM([In] JGBANCDMBHO MJNKOFMOBDK, GameObject KFAEMGBGGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7402F80", Offset = "0x7401580", VA = "0x187402F80")]
	private static bool NDNNLEPGOGM(bool LBBMLMFIKEH, bool OAHMMFFHHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80DB070", Offset = "0x80D9670", VA = "0x1880DB070")]
	private void MPPBHDGJMDD(IEnumerable<GameObject> BDPLFAFMGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80D5550", Offset = "0x80D3B50", VA = "0x1880D5550")]
	private void CMAFOIIBPGD(GameObject JLCFNKJMHLL, bool HLLDDLOAGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80D9DD0", Offset = "0x80D83D0", VA = "0x1880D9DD0")]
	private static void LLLDMGHPICK(IEnumerable<GameObject> AKHABJHJCEO, List<(GameObject GameObject, int ParentCount)> CPPMONPBBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80DBC90", Offset = "0x80DA290", VA = "0x1880DBC90")]
	private void NACPNPJDKCA(int JIGCFPDKNLI, int APPPOPKJKAA, bool HLLDDLOAGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80D6560", Offset = "0x80D4B60", VA = "0x1880D6560")]
	private static int DHGOKMFFBMI(int JIGCFPDKNLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x80D6D30", Offset = "0x80D5330", VA = "0x1880D6D30")]
	private void FNMODDOJPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80D4260", Offset = "0x80D2860", VA = "0x1880D4260")]
	private void AKDFCGBOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x80D67F0", Offset = "0x80D4DF0", VA = "0x1880D67F0")]
	private static int EJBOEKONIOG(int LMELAEGHIJL, bool OAHMMFFHHOI = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x80D6470", Offset = "0x80D4A70", VA = "0x1880D6470")]
	private static int[] CNHFKPIEHDI(int PGOAEFKINLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x80DA1E0", Offset = "0x80D87E0", VA = "0x1880DA1E0")]
	private static int[] LOHACKECMJO(int FMBOIKGHIFL, int PGOAEFKINLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x80D7FD0", Offset = "0x80D65D0", VA = "0x1880D7FD0")]
	private void IMDOMLKACCL(KNOJHPOMDED BIMDGEMNEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x80D75A0", Offset = "0x80D5BA0", VA = "0x1880D75A0")]
	private void HBECLAAABPA(KNOJHPOMDED OPOGJMFOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x80DA5A0", Offset = "0x80D8BA0", VA = "0x1880DA5A0")]
	private void MLDBDMIEGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x80D9370", Offset = "0x80D7970", VA = "0x1880D9370")]
	private void KGEKEDGCKJH(KNOJHPOMDED OPOGJMFOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x80D6850", Offset = "0x80D4E50", VA = "0x1880D6850")]
	private static void FBCCHCNOLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x80D99F0", Offset = "0x80D7FF0", VA = "0x1880D99F0")]
	private void KOJOJHFFFIJ(int[] ADEJAODIBFD, int HNLMDDFIENJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JLJGNCDGAFJ()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(KLHHELAOBJF), new string[] { "Photon" })]
public class KLHHELAOBJF : CEGGANPCFLD, JFAKIPDGBHA, FOPENMLLMIM
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KIKDNAIDGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MethodInfo CPIHNFGEHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Func<MonoBehaviour, object> KEAOMKKDIOH;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
		public KIKDNAIDGMG(MethodInfo CPIHNFGEHIK, [Optional] Func<MonoBehaviour, object> KEAOMKKDIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x740E310", Offset = "0x740C910", VA = "0x18740E310")]
		public object DHPPHEHEMLF(MonoBehaviour EDHOPIKPIEJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PGEKAMBNJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PGEKAMBNJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x80E6880", Offset = "0x80E4E80", VA = "0x1880E6880")]
		internal KIKDNAIDGMG MLFEANDEAAA(MethodInfo methodInfo)
		{
			return default(KIKDNAIDGMG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4822B20", Offset = "0x4821120", VA = "0x184822B20")]
		internal object MIBDFNPDEGP(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PMGGBIIGAKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PMGGBIIGAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x740E2C0", Offset = "0x740C8C0", VA = "0x18740E2C0")]
		internal KIKDNAIDGMG JPAGBOOLJDC(MethodInfo methodInfo)
		{
			return default(KIKDNAIDGMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BCNLDMMOIBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BCNLDMMOIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x80CD470", Offset = "0x80CBA70", VA = "0x1880CD470")]
		internal bool FHJBOPBBPFM(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Stopwatch HFNOBMDLFGD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Dictionary<MethodInfo, ParameterInfo[]> FNECCALABNG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<Type, List<KIKDNAIDGMG>> EACFBIODIOG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80E1200", Offset = "0x80DF800", VA = "0x1880E1200", Slot = "4")]
	public void BHAOPDEOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80E3B60", Offset = "0x80E2160", VA = "0x1880E3B60", Slot = "5")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x80E1AD0", Offset = "0x80E00D0", VA = "0x1880E1AD0")]
	private void GECLCGELJEL(FNFHFOLBALO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x80E0BF0", Offset = "0x80DF1F0", VA = "0x1880E0BF0", Slot = "9")]
	public string ANDOBGCIBJE(FNFHFOLBALO FLDOIECLDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x80E1300", Offset = "0x80DF900", VA = "0x1880E1300", Slot = "8")]
	public void BIBGDJHHDLC(ViewId KHKLDAJCFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x80E1130", Offset = "0x80DF730", VA = "0x1880E1130", Slot = "6")]
	public void BGIMDKINFHB(ViewId PHGOJDGOFOF, string CDPMPGGLFJF, KNOJHPOMDED OPOGJMFOAFI, JJGIIBPDLLN CDMBFDOICBK, params object[] MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x80E0C20", Offset = "0x80DF220", VA = "0x1880E0C20", Slot = "7")]
	public void BGIMDKINFHB(ViewId PHGOJDGOFOF, string CDPMPGGLFJF, MDFBHDODLPI OKOGHNMMGGB, JJGIIBPDLLN CDMBFDOICBK, params object[] MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x80E0C50", Offset = "0x80DF250", VA = "0x1880E0C50")]
	private void BGIMDKINFHB(ViewId PHGOJDGOFOF, string CDPMPGGLFJF, MDFBHDODLPI OKOGHNMMGGB, KNOJHPOMDED OPOGJMFOAFI, JJGIIBPDLLN CDMBFDOICBK, params object[] MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80E1D80", Offset = "0x80E0380", VA = "0x1880E1D80")]
	private void HKDNDAIKILK(ViewId KHKLDAJCFCJ, string CDPMPGGLFJF, KNOJHPOMDED NDLIFLFKGJD, int CDIOMMNBKMD, object[] PAABDOHHHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80E1610", Offset = "0x80DFC10", VA = "0x1880E1610")]
	private static void FHCOBLPBCHM(KIKDNAIDGMG PBFMFMMGIGC, MonoBehaviour DHOACJCCJHN, object[] MMCAOMENGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x80E13E0", Offset = "0x80DF9E0", VA = "0x1880E13E0")]
	private static bool EHAKLAKJPCO(ParameterInfo[] KJDILICIHCL, Type[] OKLEEEKJPDD, [Out] bool CMCNDNACCAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x80E01C0", Offset = "0x80DE7C0", VA = "0x1880E01C0")]
	private List<KIKDNAIDGMG> ALAMJPBCGLA(MonoBehaviour DHOACJCCJHN, Type MIANFJJDLLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80E3CB0", Offset = "0x80E22B0", VA = "0x1880E3CB0")]
	private static IEnumerable<MethodInfo> LPCOPPBLLIE(Type JLPANLJHHFI, Type ADEHFABBCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x80E3A50", Offset = "0x80E2050", VA = "0x1880E3A50")]
	public static ParameterInfo[] HNKAJFBAMEG(MethodInfo OLJJCJHFEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KLHHELAOBJF()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, NGNGIBJEHLI, HLPFJCHFDEN, CJNDJDKIJBE, CMENDJNMJBF, EOCBGCJHMLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum JNDEBCNPMMA
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
		private sealed class KNDNDOOBOJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public KNDNDOOBOJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x80E3F50", Offset = "0x80E2550", VA = "0x1880E3F50")]
			internal bool GBMIINAEHJC(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<int, RRNetworkView> CEPJIIDNPGF;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static JCLKAOOIHID NIHECLGOGFN;

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
		private bool APLIIBAFMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal bool CCBHJKMLAJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public JNDEBCNPMMA hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool OHEFKMJBDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool GKKLFLNFLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int FBHAGGHNJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool HNLCNLBCFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int JAJPMNNOBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private KNOJHPOMDED FMBOIKGHIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private KNOJHPOMDED KFJKDEHPBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool? BOKLOFCDENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool HMNFDKLACAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal bool CEKLJNDHOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal MonoBehaviour[] BMFFBOLKGHN;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly LHMKAIAPMBI HMGLOLOADLM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId DALNOMNLOKM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x80ECB90", Offset = "0x80EB190", VA = "0x1880ECB90")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId HAKJGGBMIHA
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x80ECB90", Offset = "0x80EB190", VA = "0x1880ECB90", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId AHFIPNKBHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x80ECB90", Offset = "0x80EB190", VA = "0x1880ECB90")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int DBKJKABMDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int MIDHPHAELOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ViewId HOJDBHKJBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x80ECA00", Offset = "0x80EB000", VA = "0x1880ECA00")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool FDCNOLIDKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DNKIOFCJEHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x80ECA10", Offset = "0x80EB010", VA = "0x1880ECA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NFCPFIKJLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0E60", Offset = "0xAAF460", VA = "0x180AB0E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int JGJEMAFHHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1CE80", VA = "0x180D1E880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int MLNMJMHGEPM
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x80EC9A0", Offset = "0x80EAFA0", VA = "0x1880EC9A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public KNOJHPOMDED MPFPEEAEPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x80ECBA0", Offset = "0x80EB1A0", VA = "0x1880ECBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KNOJHPOMDED CGCAGFEJAPI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x80EC970", Offset = "0x80EAF70", VA = "0x1880EC970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public KNOJHPOMDED ADMKLFECAIP
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x80EC970", Offset = "0x80EAF70", VA = "0x1880EC970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public KNOJHPOMDED ABCHJDLCAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x80EC970", Offset = "0x80EAF70", VA = "0x1880EC970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool LGLDIMGKPFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x80ECAE0", Offset = "0x80EB0E0", VA = "0x1880ECAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int ANFIBFAPLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x80EC9D0", Offset = "0x80EAFD0", VA = "0x1880EC9D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public object[] PDBJEGPJKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool BOFMDAHMCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x80ECBD0", Offset = "0x80EB1D0", VA = "0x1880ECBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool CNPMHHOHAJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x80ECB60", Offset = "0x80EB160", VA = "0x1880ECB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool GKEDLOLAOJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xDED9D0", Offset = "0xDEBFD0", VA = "0x180DED9D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xF43C10", Offset = "0xF42210", VA = "0x180F43C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ICEMPBOOKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xC9F9A0", Offset = "0xC9DFA0", VA = "0x180C9F9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> JNHDODFAHHP
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x80EC810", Offset = "0x80EAE10", VA = "0x1880EC810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x80ECD90", Offset = "0x80EB390", VA = "0x1880ECD90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<KNOJHPOMDED> HNPFKKABIPC
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x80E7920", Offset = "0x80E5F20", VA = "0x1880E7920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x80E91C0", Offset = "0x80E77C0", VA = "0x1880E91C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<KNOJHPOMDED> IIKHFOFMBAK
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x80E7920", Offset = "0x80E5F20", VA = "0x1880E7920")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x80E91C0", Offset = "0x80E77C0", VA = "0x1880E91C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> CEICEDNHFMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x80E9800", Offset = "0x80E7E00", VA = "0x1880E9800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x80E7A30", Offset = "0x80E6030", VA = "0x1880E7A30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> FCDMFJJEDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x80E9800", Offset = "0x80E7E00", VA = "0x1880E9800")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x80E7A30", Offset = "0x80E6030", VA = "0x1880E7A30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> LMFBCDNKMGE
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x80EC8C0", Offset = "0x80EAEC0", VA = "0x1880EC8C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x80ECE40", Offset = "0x80EB440", VA = "0x1880ECE40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action NAENFMLONLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x80EC760", Offset = "0x80EAD60", VA = "0x1880EC760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x80ECCE0", Offset = "0x80EB2E0", VA = "0x1880ECCE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x80EC590", Offset = "0x80EAB90", VA = "0x1880EC590")]
		public static bool TryGetNetworkView(int KHKLDAJCFCJ, [Out] RRNetworkView PHGOJDGOFOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x80E8090", Offset = "0x80E6690", VA = "0x1880E8090")]
		public static RRNetworkView Find(int KHKLDAJCFCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80E8250", Offset = "0x80E6850", VA = "0x1880E8250")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int LPDADLLGOCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80E81E0", Offset = "0x80E67E0", VA = "0x1880E81E0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x80E9D00", Offset = "0x80E8300", VA = "0x1880E9D00")]
		public static bool RemoveNetworkView(RRNetworkView PHGOJDGOFOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80E9AD0", Offset = "0x80E80D0", VA = "0x1880E9AD0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x80E94B0", Offset = "0x80E7AB0", VA = "0x1880E94B0")]
		public static void OnPlayerJoinedRoom(KNOJHPOMDED PKIBCOHEODF, List<int> ADEJAODIBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80E8390", Offset = "0x80E6990", VA = "0x1880E8390")]
		public static RRNetworkView Get(Component DNCHHBPCLHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80E83F0", Offset = "0x80E69F0", VA = "0x1880E83F0")]
		public static RRNetworkView Get(GameObject CENPLCMNMPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x80E8510", Offset = "0x80E6B10", VA = "0x1880E8510")]
		private void HJPJFAOPMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x80E7F20", Offset = "0x80E6520", VA = "0x1880E7F20")]
		public bool CreatedBy(KNOJHPOMDED OPOGJMFOAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x80EC3A0", Offset = "0x80EA9A0", VA = "0x1880EC3A0")]
		public void TransferOwnership(int OFPILFCGPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x80EC340", Offset = "0x80EA940", VA = "0x1880EC340")]
		public void TransferOwnership(KNOJHPOMDED ACBOBLAPFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x80E8C10", Offset = "0x80E7210", VA = "0x1880E8C10", Slot = "4")]
		public void Initialize(ViewId AHLFOEEEPLN, ViewId BJBNKCEIIEM, Dictionary<int, object> JJAIEIEJJFM, PECONNHPBAN FMBOIKGHIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x80E8BB0", Offset = "0x80E71B0", VA = "0x1880E8BB0")]
		public void Initialize(ViewId AHLFOEEEPLN, ViewId BJBNKCEIIEM, object[] HCGDDJGEGKG, PECONNHPBAN FMBOIKGHIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x80E79D0", Offset = "0x80E5FD0", VA = "0x1880E79D0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80E8690", Offset = "0x80E6C90", VA = "0x1880E8690")]
		private void IBACCGDAEOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1F36300", Offset = "0x1F34900", VA = "0x181F36300")]
		internal void CHDGJAMEKIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x80E8450", Offset = "0x80E6A50", VA = "0x1880E8450", Slot = "6")]
		private void HEGFJEHDKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x80E90F0", Offset = "0x80E76F0", VA = "0x1880E90F0")]
		internal bool MGBOBBMMIJP(RRNetworkView JGAJLCKPINL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x80E9310", Offset = "0x80E7910", VA = "0x1880E9310")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x80E9160", Offset = "0x80E7760", VA = "0x1880E9160")]
		internal void NFKLONFBJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x80E7910", Offset = "0x80E5F10", VA = "0x1880E7910")]
		private void AHPCCBMPKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x80E8120", Offset = "0x80E6720", VA = "0x1880E8120")]
		internal void GNBPJFMCOFH(KNOJHPOMDED ACBOBLAPFOI, int OFPILFCGPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x80E9C60", Offset = "0x80E8260", VA = "0x1880E9C60")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x80E9D80", Offset = "0x80E8380", VA = "0x1880E9D80")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x80E85F0", Offset = "0x80E6BF0", VA = "0x1880E85F0")]
		private void HNGILLMHJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x80E7FA0", Offset = "0x80E65A0", VA = "0x1880E7FA0")]
		private void FNLDFKFNALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x80E9A40", Offset = "0x80E8040", VA = "0x1880E9A40")]
		public void RPC(string CDPMPGGLFJF, MDFBHDODLPI OKOGHNMMGGB, params object[] MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x80E99B0", Offset = "0x80E7FB0", VA = "0x1880E99B0")]
		public void RPC(string CDPMPGGLFJF, KNOJHPOMDED NOFJGJEACCI, params object[] MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x80E9CB0", Offset = "0x80E82B0", VA = "0x1880E9CB0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x80E7C30", Offset = "0x80E6230", VA = "0x1880E7C30", Slot = "8")]
		public void Bake(HPECJEKLOEK HILCMKALFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x80E8E30", Offset = "0x80E7430", VA = "0x1880E8E30")]
		private static void KNMEFCIOIJG(KNOJHPOMDED GEHCGKCBEID, [Out] KNOJHPOMDED DKKOHDCAINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x80E8890", Offset = "0x80E6E90", VA = "0x1880E8890")]
		private static void IFLPFKKJHIF(RRNetworkView PNENHMDGAJA, Delegate PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x80E8EB0", Offset = "0x80E74B0", VA = "0x1880E8EB0")]
		private static PEDEIDHCFOB LECIPLBIBDK(RRNetworkView PNENHMDGAJA)
		{
			return default(PEDEIDHCFOB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x80E8D90", Offset = "0x80E7390", VA = "0x1880E8D90")]
		private static BHNKNAFMDAL JGLFNMNDNGM(RRNetworkView PNENHMDGAJA)
		{
			return default(BHNKNAFMDAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x80E8F30", Offset = "0x80E7530", VA = "0x1880E8F30")]
		private static void LKKBKBOOOBD(RRNetworkView PNENHMDGAJA, Delegate PBFMFMMGIGC, KNOJHPOMDED DPLMHNDBKGP, params object[] MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x80E9010", Offset = "0x80E7610", VA = "0x1880E9010")]
		private static void LKKBKBOOOBD(RRNetworkView PNENHMDGAJA, Delegate PBFMFMMGIGC, MDFBHDODLPI DPLMHNDBKGP, params object[] MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x80E7AE0", Offset = "0x80E60E0", VA = "0x1880E7AE0")]
		private static void BOFODGBNHBI(RRNetworkView PNENHMDGAJA, Delegate PBFMFMMGIGC, MDFBHDODLPI DPLMHNDBKGP, KFICNNKGJFJ MAMPDHJINAI, params object[] MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x80E98B0", Offset = "0x80E7EB0", VA = "0x1880E98B0")]
		public void RPCBuffered(string CDPMPGGLFJF, MDFBHDODLPI OKOGHNMMGGB, KFICNNKGJFJ CDMBFDOICBK, params object[] MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x80E9270", Offset = "0x80E7870", VA = "0x1880E9270")]
		private static bool ONFLDCEIPJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x80EA400", Offset = "0x80E8A00", VA = "0x1880EA400", Slot = "26")]
		public void RpcAll(FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3DD80D0", Offset = "0x3DD66D0", VA = "0x183DD80D0", Slot = "9")]
		public void RpcAll<T1>(FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7950", Offset = "0x3DD5F50", VA = "0x183DD7950", Slot = "10")]
		public void RpcAll<T1, T2>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9D50", Offset = "0x3DD8350", VA = "0x183DD9D50", Slot = "27")]
		public void RpcAll<T1, T2, T3>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7B60", Offset = "0x3DD6160", VA = "0x183DD7B60", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9710", Offset = "0x3DD7D10", VA = "0x183DD9710", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA250", Offset = "0x3DD8850", VA = "0x183DDA250", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAD10", Offset = "0x3DD9310", VA = "0x183DDAD10", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3DDF6E0", Offset = "0x3DDDCE0", VA = "0x183DDF6E0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA6F0", Offset = "0x3DD8CF0", VA = "0x183DDA6F0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8B30", Offset = "0x3DD7130", VA = "0x183DD8B30", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5DD0", Offset = "0x3DE43D0", VA = "0x183DE5DD0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3DE52B0", Offset = "0x3DE38B0", VA = "0x183DE52B0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3AE0", Offset = "0x3DE20E0", VA = "0x183DE3AE0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8260", Offset = "0x3DD6860", VA = "0x183DD8260", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x80EA570", Offset = "0x80E8B70", VA = "0x1880EA570")]
		public void RpcAll(FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCD30", Offset = "0x3DDB330", VA = "0x183DDCD30")]
		public void RpcAll<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD930", Offset = "0x3DDBF30", VA = "0x183DDD930")]
		public void RpcAll<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9400", Offset = "0x3DD7A00", VA = "0x183DD9400")]
		public void RpcAll<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB230", Offset = "0x3DE9830", VA = "0x183DEB230")]
		public void RpcAll<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAC30", Offset = "0x3DE9230", VA = "0x183DEAC30")]
		public void RpcAll<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA610", Offset = "0x3DE8C10", VA = "0x183DEA610")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9BF0", Offset = "0x3DE81F0", VA = "0x183DE9BF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CF0", Offset = "0x3DE72F0", VA = "0x183DE8CF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8020", Offset = "0x3DE6620", VA = "0x183DE8020")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6D40", Offset = "0x3DE5340", VA = "0x183DE6D40")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6800", Offset = "0x3DE4E00", VA = "0x183DE6800")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5820", Offset = "0x3DE3E20", VA = "0x183DE5820")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3DE40C0", Offset = "0x3DE26C0", VA = "0x183DE40C0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2DE0", Offset = "0x3DE13E0", VA = "0x183DE2DE0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x80EA780", Offset = "0x80E8D80", VA = "0x1880EA780", Slot = "36")]
		public void RpcAll(FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFA60", Offset = "0x3DEE060", VA = "0x183DEFA60", Slot = "37")]
		public void RpcAll<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3DED750", Offset = "0x3DEBD50", VA = "0x183DED750", Slot = "38")]
		public void RpcAll<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBFF0", Offset = "0x3DEA5F0", VA = "0x183DEBFF0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB4E0", Offset = "0x3DE9AE0", VA = "0x183DEB4E0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAF30", Offset = "0x3DE9530", VA = "0x183DEAF30", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9FA0", Offset = "0x3DE85A0", VA = "0x183DE9FA0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE94D0", Offset = "0x3DE7AD0", VA = "0x183DE94D0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE6EE0", VA = "0x183DE88E0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7BA0", Offset = "0x3DE61A0", VA = "0x183DE7BA0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3DE76C0", Offset = "0x3DE5CC0", VA = "0x183DE76C0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3DE62C0", Offset = "0x3DE48C0", VA = "0x183DE62C0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4D00", Offset = "0x3DE3300", VA = "0x183DE4D00", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3DE46E0", Offset = "0x3DE2CE0", VA = "0x183DE46E0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3460", Offset = "0x3DE1A60", VA = "0x183DE3460", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x80EA1A0", Offset = "0x80E87A0", VA = "0x1880EA1A0", Slot = "51")]
		public void RpcAllViaServer(FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7750", Offset = "0x3DD5D50", VA = "0x183DD7750", Slot = "52")]
		public void RpcAllViaServer<T1>(FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF5A0", Offset = "0x3DCDBA0", VA = "0x183DCF5A0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7080", Offset = "0x3DD5680", VA = "0x183DD7080", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6B20", Offset = "0x3DD5120", VA = "0x183DD6B20", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD64D0", Offset = "0x3DD4AD0", VA = "0x183DD64D0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5880", Offset = "0x3DD3E80", VA = "0x183DD5880", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4FE0", Offset = "0x3DD35E0", VA = "0x183DD4FE0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4980", Offset = "0x3DD2F80", VA = "0x183DD4980", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD42D0", Offset = "0x3DD28D0", VA = "0x183DD42D0", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3430", Offset = "0x3DD1A30", VA = "0x183DD3430", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2C40", Offset = "0x3DD1240", VA = "0x183DD2C40", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1B20", Offset = "0x3DD0120", VA = "0x183DD1B20", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0870", Offset = "0x3DCEE70", VA = "0x183DD0870", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3DCFE30", Offset = "0x3DCE430", VA = "0x183DCFE30", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x80EA070", Offset = "0x80E8670", VA = "0x1880EA070")]
		public void RpcAllViaServer(FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7850", Offset = "0x3DD5E50", VA = "0x183DD7850")]
		public void RpcAllViaServer<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7390", Offset = "0x3DD5990", VA = "0x183DD7390")]
		public void RpcAllViaServer<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6ED0", Offset = "0x3DD54D0", VA = "0x183DD6ED0")]
		public void RpcAllViaServer<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6920", Offset = "0x3DD4F20", VA = "0x183DD6920")]
		public void RpcAllViaServer<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6280", Offset = "0x3DD4880", VA = "0x183DD6280")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5B10", Offset = "0x3DD4110", VA = "0x183DD5B10")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD52C0", Offset = "0x3DD38C0", VA = "0x183DD52C0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4CB0", Offset = "0x3DD32B0", VA = "0x183DD4CB0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3BD0", Offset = "0x3DD21D0", VA = "0x183DD3BD0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3800", Offset = "0x3DD1E00", VA = "0x183DD3800")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2820", Offset = "0x3DD0E20", VA = "0x183DD2820")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1F90", Offset = "0x3DD0590", VA = "0x183DD1F90")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0D30", Offset = "0x3DCF330", VA = "0x183DD0D30")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0350", Offset = "0x3DCE950", VA = "0x183DD0350")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA2D0", Offset = "0x80E88D0", VA = "0x1880EA2D0", Slot = "65")]
		public void RpcAllViaServer(FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7650", Offset = "0x3DD5C50", VA = "0x183DD7650", Slot = "66")]
		public void RpcAllViaServer<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3DD74F0", Offset = "0x3DD5AF0", VA = "0x183DD74F0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6D20", Offset = "0x3DD5320", VA = "0x183DD6D20", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6720", Offset = "0x3DD4D20", VA = "0x183DD6720", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6030", Offset = "0x3DD4630", VA = "0x183DD6030", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5DA0", Offset = "0x3DD43A0", VA = "0x183DD5DA0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3DD55A0", Offset = "0x3DD3BA0", VA = "0x183DD55A0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4650", Offset = "0x3DD2C50", VA = "0x183DD4650", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3F50", Offset = "0x3DD2550", VA = "0x183DD3F50", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3060", Offset = "0x3DD1660", VA = "0x183DD3060", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2400", Offset = "0x3DD0A00", VA = "0x183DD2400", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3DD16B0", Offset = "0x3DCFCB0", VA = "0x183DD16B0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DD11F0", Offset = "0x3DCF7F0", VA = "0x183DD11F0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF910", Offset = "0x3DCDF10", VA = "0x183DCF910", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x80EBA80", Offset = "0x80EA080", VA = "0x1880EBA80", Slot = "80")]
		public void RpcOthers(FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E990", Offset = "0x3E1CF90", VA = "0x183E1E990", Slot = "15")]
		public void RpcOthers<T1>(FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F240", Offset = "0x3E1D840", VA = "0x183E1F240", Slot = "81")]
		public void RpcOthers<T1, T2>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E710", Offset = "0x3E1CD10", VA = "0x183E1E710", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E27BB0", Offset = "0x3E261B0", VA = "0x183E27BB0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E1FFA0", Offset = "0x3E1E5A0", VA = "0x183E1FFA0", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E26CC0", Offset = "0x3E252C0", VA = "0x183E26CC0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E263E0", Offset = "0x3E249E0", VA = "0x183E263E0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E25A10", Offset = "0x3E24010", VA = "0x183E25A10", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E25300", Offset = "0x3E23900", VA = "0x183E25300", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E23FD0", Offset = "0x3E225D0", VA = "0x183E23FD0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E23750", Offset = "0x3E21D50", VA = "0x183E23750", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E22E80", Offset = "0x3E21480", VA = "0x183E22E80", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E21690", Offset = "0x3E1FC90", VA = "0x183E21690", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E21150", Offset = "0x3E1F750", VA = "0x183E21150", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x80EB7E0", Offset = "0x80E9DE0", VA = "0x1880EB7E0")]
		public void RpcOthers(FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EFA0", Offset = "0x3E1D5A0", VA = "0x183E1EFA0")]
		public void RpcOthers<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EDC0", Offset = "0x3E1D3C0", VA = "0x183E1EDC0")]
		public void RpcOthers<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E28B60", Offset = "0x3E27160", VA = "0x183E28B60")]
		public void RpcOthers<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EAE0", Offset = "0x3E1D0E0", VA = "0x183E1EAE0")]
		public void RpcOthers<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F730", Offset = "0x3E1DD30", VA = "0x183E1F730")]
		public void RpcOthers<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E1FA70", Offset = "0x3E1E070", VA = "0x183E1FA70")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E260D0", Offset = "0x3E246D0", VA = "0x183E260D0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E25D70", Offset = "0x3E24370", VA = "0x183E25D70")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3E24BA0", Offset = "0x3E231A0", VA = "0x183E24BA0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3E247B0", Offset = "0x3E22DB0", VA = "0x183E247B0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3E23B90", Offset = "0x3E22190", VA = "0x183E23B90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3E229F0", Offset = "0x3E20FF0", VA = "0x183E229F0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3E21B80", Offset = "0x3E20180", VA = "0x183E21B80")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E20C10", Offset = "0x3E1F210", VA = "0x183E20C10")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x80EB930", Offset = "0x80E9F30", VA = "0x1880EB930", Slot = "93")]
		public void RpcOthers(FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E299A0", Offset = "0x3E27FA0", VA = "0x183E299A0", Slot = "94")]
		public void RpcOthers<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E29280", Offset = "0x3E27880", VA = "0x183E29280", Slot = "95")]
		public void RpcOthers<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E28990", Offset = "0x3E26F90", VA = "0x183E28990", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E27DD0", Offset = "0x3E263D0", VA = "0x183E27DD0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E27240", Offset = "0x3E25840", VA = "0x183E27240", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E26A00", Offset = "0x3E25000", VA = "0x183E26A00", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E266F0", Offset = "0x3E24CF0", VA = "0x183E266F0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E256B0", Offset = "0x3E23CB0", VA = "0x183E256B0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E24F50", Offset = "0x3E23550", VA = "0x183E24F50", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E243C0", Offset = "0x3E229C0", VA = "0x183E243C0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3E23310", Offset = "0x3E21910", VA = "0x183E23310", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E22560", Offset = "0x3E20B60", VA = "0x183E22560", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E22070", Offset = "0x3E20670", VA = "0x183E22070", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E206D0", Offset = "0x3E1ECD0", VA = "0x183E206D0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x80EB250", Offset = "0x80E9850", VA = "0x1880EB250", Slot = "108")]
		public void RpcMaster(FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3E02D90", Offset = "0x3E01390", VA = "0x183E02D90", Slot = "109")]
		public void RpcMaster<T1>(FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E03120", Offset = "0x3E01720", VA = "0x183E03120", Slot = "17")]
		public void RpcMaster<T1, T2>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E02AD0", Offset = "0x3E010D0", VA = "0x183E02AD0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E02780", Offset = "0x3E00D80", VA = "0x183E02780", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E067A0", Offset = "0x3E04DA0", VA = "0x183E067A0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3E08B70", Offset = "0x3E07170", VA = "0x183E08B70", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3E11510", Offset = "0x3E0FB10", VA = "0x183E11510", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E104E0", Offset = "0x3E0EAE0", VA = "0x183E104E0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F780", Offset = "0x3E0DD80", VA = "0x183E0F780", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E05F70", Offset = "0x3E04570", VA = "0x183E05F70", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E04BA0", Offset = "0x3E031A0", VA = "0x183E04BA0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C2E0", Offset = "0x3E0A8E0", VA = "0x183E0C2E0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BD00", Offset = "0x3E0A300", VA = "0x183E0BD00", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AA60", Offset = "0x3E09060", VA = "0x183E0AA60", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x80EB3E0", Offset = "0x80E99E0", VA = "0x1880EB3E0")]
		public void RpcMaster(FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E02F30", Offset = "0x3E01530", VA = "0x183E02F30")]
		public void RpcMaster<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E03BC0", Offset = "0x3E021C0", VA = "0x183E03BC0")]
		public void RpcMaster<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E03370", Offset = "0x3E01970", VA = "0x183E03370")]
		public void RpcMaster<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E131C0", Offset = "0x3E117C0", VA = "0x183E131C0")]
		public void RpcMaster<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E071C0", Offset = "0x3E057C0", VA = "0x183E071C0")]
		public void RpcMaster<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3E118B0", Offset = "0x3E0FEB0", VA = "0x183E118B0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E10D30", Offset = "0x3E0F330", VA = "0x183E10D30")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E10090", Offset = "0x3E0E690", VA = "0x183E10090")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F2D0", Offset = "0x3E0D8D0", VA = "0x183E0F2D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EDC0", Offset = "0x3E0D3C0", VA = "0x183E0EDC0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D910", Offset = "0x3E0BF10", VA = "0x183E0D910")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CE20", Offset = "0x3E0B420", VA = "0x183E0CE20")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B0A0", Offset = "0x3E096A0", VA = "0x183E0B0A0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E09D40", Offset = "0x3E08340", VA = "0x183E09D40")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x80EB010", Offset = "0x80E9610", VA = "0x1880EB010", Slot = "122")]
		public void RpcMaster(FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E15AD0", Offset = "0x3E140D0", VA = "0x183E15AD0", Slot = "123")]
		public void RpcMaster<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E14D80", Offset = "0x3E13380", VA = "0x183E14D80", Slot = "124")]
		public void RpcMaster<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3E136C0", Offset = "0x3E11CC0", VA = "0x183E136C0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3E12EE0", Offset = "0x3E114E0", VA = "0x183E12EE0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3E12300", Offset = "0x3E10900", VA = "0x183E12300", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3E11C40", Offset = "0x3E10240", VA = "0x183E11C40", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3E11120", Offset = "0x3E0F720", VA = "0x183E11120", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3E108E0", Offset = "0x3E0EEE0", VA = "0x183E108E0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FBE0", Offset = "0x3E0E1E0", VA = "0x183E0FBE0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E8B0", Offset = "0x3E0CEB0", VA = "0x183E0E8B0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DE80", Offset = "0x3E0C480", VA = "0x183E0DE80", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C850", Offset = "0x3E0AE50", VA = "0x183E0C850", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B6D0", Offset = "0x3E09CD0", VA = "0x183E0B6D0", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A3D0", Offset = "0x3E089D0", VA = "0x183E0A3D0", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x80EAE60", Offset = "0x80E9460", VA = "0x1880EAE60", Slot = "137")]
		public void RpcAuthority(FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2D10", Offset = "0x3DF1310", VA = "0x183DF2D10", Slot = "138")]
		public void RpcAuthority<T1>(FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3EC0", Offset = "0x3DF24C0", VA = "0x183DF3EC0", Slot = "139")]
		public void RpcAuthority<T1, T2>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4670", Offset = "0x3DF2C70", VA = "0x183DF4670", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3B90", Offset = "0x3DF2190", VA = "0x183DF3B90", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2910", Offset = "0x3DF0F10", VA = "0x183DF2910", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3DF61D0", Offset = "0x3DF47D0", VA = "0x183DF61D0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3DF52B0", Offset = "0x3DF38B0", VA = "0x183DF52B0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3E01C70", Offset = "0x3E00270", VA = "0x183E01C70", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3E005C0", Offset = "0x3DFEBC0", VA = "0x183E005C0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3E000F0", Offset = "0x3DFE6F0", VA = "0x183E000F0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE680", Offset = "0x3DFCC80", VA = "0x183DFE680", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA830", Offset = "0x3DF8E30", VA = "0x183DFA830", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCF40", Offset = "0x3DFB540", VA = "0x183DFCF40", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB5D0", Offset = "0x3DF9BD0", VA = "0x183DFB5D0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x80EAC10", Offset = "0x80E9210", VA = "0x1880EAC10")]
		public void RpcAuthority(FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8C90", Offset = "0x3DF7290", VA = "0x183DF8C90")]
		public void RpcAuthority<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8300", Offset = "0x3DF6900", VA = "0x183DF8300")]
		public void RpcAuthority<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7730", Offset = "0x3DF5D30", VA = "0x183DF7730")]
		public void RpcAuthority<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6EC0", Offset = "0x3DF54C0", VA = "0x183DF6EC0")]
		public void RpcAuthority<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6B70", Offset = "0x3DF5170", VA = "0x183DF6B70")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5E20", Offset = "0x3DF4420", VA = "0x183DF5E20")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5670", Offset = "0x3DF3C70", VA = "0x183DF5670")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3E013B0", Offset = "0x3DFF9B0", VA = "0x183E013B0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3E00A30", Offset = "0x3DFF030", VA = "0x183E00A30")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFBD0", Offset = "0x3DFE1D0", VA = "0x183DFFBD0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF130", Offset = "0x3DFD730", VA = "0x183DFF130")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDB10", Offset = "0x3DFC110", VA = "0x183DFDB10")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC2C0", Offset = "0x3DFA8C0", VA = "0x183DFC2C0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAF30", Offset = "0x3DF9530", VA = "0x183DFAF30")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA9B0", Offset = "0x80E8FB0", VA = "0x1880EA9B0", Slot = "152")]
		public void RpcAuthority(FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8AC0", Offset = "0x3DF70C0", VA = "0x183DF8AC0", Slot = "153")]
		public void RpcAuthority<T1>(FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF80D0", Offset = "0x3DF66D0", VA = "0x183DF80D0", Slot = "154")]
		public void RpcAuthority<T1, T2>(FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF79B0", Offset = "0x3DF5FB0", VA = "0x183DF79B0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF71B0", Offset = "0x3DF57B0", VA = "0x183DF71B0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6820", Offset = "0x3DF4E20", VA = "0x183DF6820", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5A70", Offset = "0x3DF4070", VA = "0x183DF5A70", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4EB0", Offset = "0x3DF34B0", VA = "0x183DF4EB0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3E01810", Offset = "0x3DFFE10", VA = "0x183E01810", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3E00EF0", Offset = "0x3DFF4F0", VA = "0x183E00EF0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF6B0", Offset = "0x3DFDCB0", VA = "0x183DFF6B0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEBB0", Offset = "0x3DFD1B0", VA = "0x183DFEBB0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD530", Offset = "0x3DFBB30", VA = "0x183DFD530", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC900", Offset = "0x3DFAF00", VA = "0x183DFC900", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBC20", Offset = "0x3DFA220", VA = "0x183DFBC20", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x80EBE90", Offset = "0x80EA490", VA = "0x1880EBE90", Slot = "18")]
		public void RpcPlayer(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A080", Offset = "0x3E28680", VA = "0x183E2A080", Slot = "19")]
		public void RpcPlayer<T1>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2AC30", Offset = "0x3E29230", VA = "0x183E2AC30", Slot = "20")]
		public void RpcPlayer<T1, T2>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A650", Offset = "0x3E28C50", VA = "0x183E2A650", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3E30190", Offset = "0x3E2E790", VA = "0x183E30190", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3E317E0", Offset = "0x3E2FDE0", VA = "0x183E317E0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3E31380", Offset = "0x3E2F980", VA = "0x183E31380", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3E31BC0", Offset = "0x3E301C0", VA = "0x183E31BC0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3E32080", Offset = "0x3E30680", VA = "0x183E32080", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3E39090", Offset = "0x3E37690", VA = "0x183E39090", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3E377A0", Offset = "0x3E35DA0", VA = "0x183E377A0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KNOJHPOMDED OPOGJMFOAFI, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3E30520", Offset = "0x3E2EB20", VA = "0x183E30520", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNOJHPOMDED OPOGJMFOAFI, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3E35BB0", Offset = "0x3E341B0", VA = "0x183E35BB0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNOJHPOMDED OPOGJMFOAFI, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3E34310", Offset = "0x3E32910", VA = "0x183E34310", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNOJHPOMDED OPOGJMFOAFI, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3E33CA0", Offset = "0x3E322A0", VA = "0x183E33CA0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNOJHPOMDED OPOGJMFOAFI, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x80EC090", Offset = "0x80EA690", VA = "0x1880EC090")]
		public void RpcPlayer(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A250", Offset = "0x3E28850", VA = "0x183E2A250")]
		public void RpcPlayer<T1>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E810", Offset = "0x3E2CE10", VA = "0x183E2E810")]
		public void RpcPlayer<T1, T2>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CBA0", Offset = "0x3E3B1A0", VA = "0x183E3CBA0")]
		public void RpcPlayer<T1, T2, T3>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C890", Offset = "0x3E3AE90", VA = "0x183E3C890")]
		public void RpcPlayer<T1, T2, T3, T4>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3BC80", Offset = "0x3E3A280", VA = "0x183E3BC80")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3E3AE40", Offset = "0x3E39440", VA = "0x183E3AE40")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3AA20", Offset = "0x3E39020", VA = "0x183E3AA20")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3E39520", Offset = "0x3E37B20", VA = "0x183E39520")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3E38BC0", Offset = "0x3E371C0", VA = "0x183E38BC0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KNOJHPOMDED OPOGJMFOAFI, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3E381C0", Offset = "0x3E367C0", VA = "0x183E381C0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KNOJHPOMDED OPOGJMFOAFI, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3E36740", Offset = "0x3E34D40", VA = "0x183E36740")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNOJHPOMDED OPOGJMFOAFI, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3E36150", Offset = "0x3E34750", VA = "0x183E36150")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNOJHPOMDED OPOGJMFOAFI, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3E34920", Offset = "0x3E32F20", VA = "0x183E34920")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNOJHPOMDED OPOGJMFOAFI, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3E335E0", Offset = "0x3E31BE0", VA = "0x183E335E0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNOJHPOMDED OPOGJMFOAFI, MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x80EBBD0", Offset = "0x80EA1D0", VA = "0x1880EBBD0", Slot = "176")]
		public void RpcPlayer(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C5D0", Offset = "0x3E2ABD0", VA = "0x183E2C5D0", Slot = "177")]
		public void RpcPlayer<T1>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B210", Offset = "0x3E29810", VA = "0x183E2B210", Slot = "24")]
		public void RpcPlayer<T1, T2>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2AEA0", Offset = "0x3E294A0", VA = "0x183E2AEA0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3E30C20", Offset = "0x3E2F220", VA = "0x183E30C20", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B920", Offset = "0x3E39F20", VA = "0x183E3B920", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B200", Offset = "0x3E39800", VA = "0x183E3B200", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A600", Offset = "0x3E38C00", VA = "0x183E3A600", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3E39DC0", Offset = "0x3E383C0", VA = "0x183E39DC0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KNOJHPOMDED OPOGJMFOAFI, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3E386F0", Offset = "0x3E36CF0", VA = "0x183E386F0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KNOJHPOMDED OPOGJMFOAFI, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3E37C90", Offset = "0x3E36290", VA = "0x183E37C90", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KNOJHPOMDED OPOGJMFOAFI, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3E37210", Offset = "0x3E35810", VA = "0x183E37210", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNOJHPOMDED OPOGJMFOAFI, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3E355C0", Offset = "0x3E33BC0", VA = "0x183E355C0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNOJHPOMDED OPOGJMFOAFI, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3E34F70", Offset = "0x3E33570", VA = "0x183E34F70", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KNOJHPOMDED OPOGJMFOAFI, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3E32F20", Offset = "0x3E31520", VA = "0x183E32F20", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KNOJHPOMDED OPOGJMFOAFI, MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x80E9E90", Offset = "0x80E8490", VA = "0x1880E9E90", Slot = "189")]
		public void RpcAllBuffered(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF240", Offset = "0x3DCD840", VA = "0x183DCF240", Slot = "190")]
		public void RpcAllBuffered<T1>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3DCEF60", Offset = "0x3DCD560", VA = "0x183DCEF60", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3DCEC30", Offset = "0x3DCD230", VA = "0x183DCEC30", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE6A0", Offset = "0x3DCCCA0", VA = "0x183DCE6A0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDB90", Offset = "0x3DCC190", VA = "0x183DCDB90", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD8F0", Offset = "0x3DCBEF0", VA = "0x183DCD8F0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCDD0", Offset = "0x3DCB3D0", VA = "0x183DCCDD0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC120", Offset = "0x3DCA720", VA = "0x183DCC120", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBD90", Offset = "0x3DCA390", VA = "0x183DCBD90", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3DCAAD0", Offset = "0x3DC90D0", VA = "0x183DCAAD0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFICNNKGJFJ CDMBFDOICBK, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3DCA270", Offset = "0x3DC8870", VA = "0x183DCA270", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFICNNKGJFJ CDMBFDOICBK, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3DC90C0", Offset = "0x3DC76C0", VA = "0x183DC90C0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KFICNNKGJFJ CDMBFDOICBK, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8720", Offset = "0x3DC6D20", VA = "0x183DC8720", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KFICNNKGJFJ CDMBFDOICBK, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3DC72F0", Offset = "0x3DC58F0", VA = "0x183DC72F0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KFICNNKGJFJ CDMBFDOICBK, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x80E9FD0", Offset = "0x80E85D0", VA = "0x1880E9FD0")]
		public void RpcAllBuffered(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF480", Offset = "0x3DCDA80", VA = "0x183DCF480")]
		public void RpcAllBuffered<T1>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF0D0", Offset = "0x3DCD6D0", VA = "0x183DCF0D0")]
		public void RpcAllBuffered<T1, T2>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE8B0", Offset = "0x3DCCEB0", VA = "0x183DCE8B0")]
		public void RpcAllBuffered<T1, T2, T3>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE490", Offset = "0x3DCCA90", VA = "0x183DCE490")]
		public void RpcAllBuffered<T1, T2, T3, T4>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDDE0", Offset = "0x3DCC3E0", VA = "0x183DCDDE0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD650", Offset = "0x3DCBC50", VA = "0x183DCD650")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD0C0", Offset = "0x3DCB6C0", VA = "0x183DCD0C0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC7A0", Offset = "0x3DCADA0", VA = "0x183DCC7A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB670", Offset = "0x3DC9C70", VA = "0x183DCB670")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KFICNNKGJFJ CDMBFDOICBK, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB290", Offset = "0x3DC9890", VA = "0x183DCB290")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFICNNKGJFJ CDMBFDOICBK, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9E40", Offset = "0x3DC8440", VA = "0x183DC9E40")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFICNNKGJFJ CDMBFDOICBK, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3DC99C0", Offset = "0x3DC7FC0", VA = "0x183DC99C0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KFICNNKGJFJ CDMBFDOICBK, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8250", Offset = "0x3DC6850", VA = "0x183DC8250")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KFICNNKGJFJ CDMBFDOICBK, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7D30", Offset = "0x3DC6330", VA = "0x183DC7D30")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KFICNNKGJFJ CDMBFDOICBK, MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x80E9F30", Offset = "0x80E8530", VA = "0x1880E9F30", Slot = "204")]
		public void RpcAllBuffered(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF360", Offset = "0x3DCD960", VA = "0x183DCF360", Slot = "205")]
		public void RpcAllBuffered<T1>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3DCEDF0", Offset = "0x3DCD3F0", VA = "0x183DCEDF0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3DCEA70", Offset = "0x3DCD070", VA = "0x183DCEA70", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE280", Offset = "0x3DCC880", VA = "0x183DCE280", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE030", Offset = "0x3DCC630", VA = "0x183DCE030", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD3B0", Offset = "0x3DCB9B0", VA = "0x183DCD3B0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCAE0", Offset = "0x3DCB0E0", VA = "0x183DCCAE0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC460", Offset = "0x3DCAA60", VA = "0x183DCC460", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBA00", Offset = "0x3DCA000", VA = "0x183DCBA00", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KFICNNKGJFJ CDMBFDOICBK, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3DCAEB0", Offset = "0x3DC94B0", VA = "0x183DCAEB0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFICNNKGJFJ CDMBFDOICBK, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3DCA6A0", Offset = "0x3DC8CA0", VA = "0x183DCA6A0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFICNNKGJFJ CDMBFDOICBK, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9540", Offset = "0x3DC7B40", VA = "0x183DC9540", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KFICNNKGJFJ CDMBFDOICBK, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8BF0", Offset = "0x3DC71F0", VA = "0x183DC8BF0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KFICNNKGJFJ CDMBFDOICBK, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7810", Offset = "0x3DC5E10", VA = "0x183DC7810", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KFICNNKGJFJ CDMBFDOICBK, MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x80EB600", Offset = "0x80E9C00", VA = "0x1880EB600", Slot = "219")]
		public void RpcOthersBuffered(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.EFHLFLAKGLG PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E3B0", Offset = "0x3E1C9B0", VA = "0x183E1E3B0", Slot = "220")]
		public void RpcOthersBuffered<T1>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.HKJHLNLHFHK<T1> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3E1DF60", Offset = "0x3E1C560", VA = "0x183E1DF60", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LCMNKGBPCKM<T1, T2> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3E1DDA0", Offset = "0x3E1C3A0", VA = "0x183E1DDA0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, T3> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D810", Offset = "0x3E1BE10", VA = "0x183E1D810", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, T4> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3E1CF50", Offset = "0x3E1B550", VA = "0x183E1CF50", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, T5> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3E1CA60", Offset = "0x3E1B060", VA = "0x183E1CA60", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, T6> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C230", Offset = "0x3E1A830", VA = "0x183E1C230", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, T7> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B290", Offset = "0x3E19890", VA = "0x183E1B290", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, T8> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3E1AB70", Offset = "0x3E19170", VA = "0x183E1AB70", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, T9> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A400", Offset = "0x3E18A00", VA = "0x183E1A400", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFICNNKGJFJ CDMBFDOICBK, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3E19810", Offset = "0x3E17E10", VA = "0x183E19810", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFICNNKGJFJ CDMBFDOICBK, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3E18230", Offset = "0x3E16830", VA = "0x183E18230", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KFICNNKGJFJ CDMBFDOICBK, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E173C0", Offset = "0x3E159C0", VA = "0x183E173C0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KFICNNKGJFJ CDMBFDOICBK, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E16EA0", Offset = "0x3E154A0", VA = "0x183E16EA0", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KFICNNKGJFJ CDMBFDOICBK, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x80EB6A0", Offset = "0x80E9CA0", VA = "0x1880EB6A0")]
		public void RpcOthersBuffered(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.HKJHLNLHFHK<PEDEIDHCFOB> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E5F0", Offset = "0x3E1CBF0", VA = "0x183E1E5F0")]
		public void RpcOthersBuffered<T1>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LCMNKGBPCKM<T1, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E0D0", Offset = "0x3E1C6D0", VA = "0x183E1E0D0")]
		public void RpcOthersBuffered<T1, T2>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1DBE0", Offset = "0x3E1C1E0", VA = "0x183E1DBE0")]
		public void RpcOthersBuffered<T1, T2, T3>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D600", Offset = "0x3E1BC00", VA = "0x183E1D600")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D1A0", Offset = "0x3E1B7A0", VA = "0x183E1D1A0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C7C0", Offset = "0x3E1ADC0", VA = "0x183E1C7C0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BC50", Offset = "0x3E1A250", VA = "0x183E1BC50")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B910", Offset = "0x3E19F10", VA = "0x183E1B910")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, PEDEIDHCFOB> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A7E0", Offset = "0x3E18DE0", VA = "0x183E1A7E0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KFICNNKGJFJ CDMBFDOICBK, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E19C40", Offset = "0x3E18240", VA = "0x183E19C40")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFICNNKGJFJ CDMBFDOICBK, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E18FB0", Offset = "0x3E175B0", VA = "0x183E18FB0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFICNNKGJFJ CDMBFDOICBK, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E18B30", Offset = "0x3E17130", VA = "0x183E18B30")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KFICNNKGJFJ CDMBFDOICBK, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E17D60", Offset = "0x3E16360", VA = "0x183E17D60")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KFICNNKGJFJ CDMBFDOICBK, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E16460", Offset = "0x3E14A60", VA = "0x183E16460")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KFICNNKGJFJ CDMBFDOICBK, MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x80EB740", Offset = "0x80E9D40", VA = "0x1880EB740", Slot = "234")]
		public void RpcOthersBuffered(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.HKJHLNLHFHK<BHNKNAFMDAL> PBFMFMMGIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E4D0", Offset = "0x3E1CAD0", VA = "0x183E1E4D0", Slot = "235")]
		public void RpcOthersBuffered<T1>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LCMNKGBPCKM<T1, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E240", Offset = "0x3E1C840", VA = "0x183E1E240", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JCDCNEEIDMK<T1, T2, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E1DA20", Offset = "0x3E1C020", VA = "0x183E1DA20", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.DGIMNMNOAMA<T1, T2, T3, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D3F0", Offset = "0x3E1B9F0", VA = "0x183E1D3F0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.PDFKNLJMGMH<T1, T2, T3, T4, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E1CD00", Offset = "0x3E1B300", VA = "0x183E1CD00", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.LECPLGBGNBJ<T1, T2, T3, T4, T5, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C520", Offset = "0x3E1AB20", VA = "0x183E1C520", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.KNBGHLKKIJA<T1, T2, T3, T4, T5, T6, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BF40", Offset = "0x3E1A540", VA = "0x183E1BF40", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JLDIJFDMIHK<T1, T2, T3, T4, T5, T6, T7, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B5D0", Offset = "0x3E19BD0", VA = "0x183E1B5D0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(KFICNNKGJFJ CDMBFDOICBK, FJKNHBBJBAJ.JHBMHKANIEN<T1, T2, T3, T4, T5, T6, T7, T8, BHNKNAFMDAL> PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E1AF00", Offset = "0x3E19500", VA = "0x183E1AF00", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KFICNNKGJFJ CDMBFDOICBK, KEMFAKJECBH PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A020", Offset = "0x3E18620", VA = "0x183E1A020", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KFICNNKGJFJ CDMBFDOICBK, PCJGCCCIOPB PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E193E0", Offset = "0x3E179E0", VA = "0x183E193E0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KFICNNKGJFJ CDMBFDOICBK, DIDEKMICIHK PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E186B0", Offset = "0x3E16CB0", VA = "0x183E186B0", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KFICNNKGJFJ CDMBFDOICBK, OAIJJKKJGKN PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E17890", Offset = "0x3E15E90", VA = "0x183E17890", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KFICNNKGJFJ CDMBFDOICBK, KBJGKANGGED PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E16980", Offset = "0x3E14F80", VA = "0x183E16980", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KFICNNKGJFJ CDMBFDOICBK, MOJIFFIHEID PBFMFMMGIGC, T1 EPBIIOLMMAB, T2 FIMBMLOLNPD, T3 EHOMNHIAPNA, T4 IHLEPGADANC, T5 KLFDDANOFKM, T6 BCEAMPGEHMG, T7 DEBGMFAPPHL, T8 JBFHDLJMOPI, T9 DJBDNBGCFMN, T10 ELFCANJOJGP, T11 LHPKIHPCDBG, T12 BLFMDFGELMB, T13 PIFLKPEPNHM, T14 CGDFKGPHBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x80E7CA0", Offset = "0x80E62A0", VA = "0x1880E7CA0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x80E7EC0", Offset = "0x80E64C0", VA = "0x1880E7EC0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F88660", Offset = "0x1F86C60", VA = "0x181F88660")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JFMEFDKNCIF
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x80D32C0", Offset = "0x80D18C0", VA = "0x1880D32C0")]
	private static bool IONKOIKDEJL(ViewId HLIPPIOIAJK, [Out] RRNetworkView PHGOJDGOFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DB30", Offset = "0x3B9C130", VA = "0x183B9DB30")]
	[CanBeNull]
	public static T DOBEDBLJENM<T>(this ViewId KHKLDAJCFCJ)
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
		private sealed class JBBKCFPBFPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public KNOJHPOMDED[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public JBBKCFPBFPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x80D3020", Offset = "0x80D1620", VA = "0x1880D3020")]
			internal int PNACCDEEKLN(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x80D2F90", Offset = "0x80D1590", VA = "0x1880D2F90")]
			internal void LAEGFHEPNCE(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly LHMKAIAPMBI NDJJBNFFFGK;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static KNOJHPOMDED[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal int HBAAKLJNNCA;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x80ED050", Offset = "0x80EB650", VA = "0x1880ED050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x80ED670", Offset = "0x80EBC70", VA = "0x1880ED670")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x80EDA40", Offset = "0x80EC040", VA = "0x1880EDA40")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x80EDAC0", Offset = "0x80EC0C0", VA = "0x1880EDAC0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x80ECEF0", Offset = "0x80EB4F0", VA = "0x1880ECEF0")]
		private void AOACJDMOMHM(KNOJHPOMDED PKIBCOHEODF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x80ECEF0", Offset = "0x80EB4F0", VA = "0x1880ECEF0")]
		private void HBECLAAABPA(KNOJHPOMDED KCLMDJCLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x80ED580", Offset = "0x80EBB80", VA = "0x1880ED580")]
		private void KHAABDNABBC(KNOJHPOMDED NOFJGJEACCI, IDictionary<object, object> LDCPJJFBAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x80ECF00", Offset = "0x80EB500", VA = "0x1880ECF00")]
		public static void AssignPlayerNumbers(int BIDPMDLFPIJ, int PEHNLHKGEIJ, Func<int, int> OPOGFDECJGP, Action<int, int> ICLNLJPCPED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x80EDB70", Offset = "0x80EC170", VA = "0x1880EDB70")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x80ED490", Offset = "0x80EBA90", VA = "0x1880ED490")]
		private void FPBFOJNGNMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA56900", Offset = "0xA54F00", VA = "0x180A56900")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NLAKGMMHNFM
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x80E5C90", Offset = "0x80E4290", VA = "0x1880E5C90")]
	public static int CHHEDLEBNDJ(this KNOJHPOMDED OPOGJMFOAFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x80E5E30", Offset = "0x80E4430", VA = "0x1880E5E30")]
	public static void IOJKBACMPLE(this KNOJHPOMDED OPOGJMFOAFI, int EEPJBCNLONG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OPGCHOGIINO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void JOMCMBAIBFO(Hashtable BKADBAJOKKO);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void GAHACFGODHP(KNOJHPOMDED OPOGJMFOAFI, Hashtable BKADBAJOKKO);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event JOMCMBAIBFO FHEOONNIIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x80E6700", Offset = "0x80E4D00", VA = "0x1880E6700")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x80E6640", Offset = "0x80E4C40", VA = "0x1880E6640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event JOMCMBAIBFO IEGALPOPICM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x80E6400", Offset = "0x80E4A00", VA = "0x1880E6400")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x80E64C0", Offset = "0x80E4AC0", VA = "0x1880E64C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event GAHACFGODHP OCHEMPCJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x80E6340", Offset = "0x80E4940", VA = "0x1880E6340")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x80E6280", Offset = "0x80E4880", VA = "0x1880E6280")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event GAHACFGODHP BPBPECLPNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x80E6580", Offset = "0x80E4B80", VA = "0x1880E6580")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x80E67C0", Offset = "0x80E4DC0", VA = "0x1880E67C0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class IBAPIONELOC
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int LKEPOADBPPH;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int COGKEKIECNB;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int IPEMPOBHGMJ;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x80D0960", Offset = "0x80CEF60", VA = "0x1880D0960")]
	public static void FPGNLDAFGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x80D09B0", Offset = "0x80CEFB0", VA = "0x1880D09B0")]
	public static void PHIFGHAJFFK(int[] HBKNDMIBFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x80D06B0", Offset = "0x80CECB0", VA = "0x1880D06B0")]
	public static int EJBOEKONIOG(int LMELAEGHIJL, bool OAHMMFFHHOI = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(KBLIBANIPGF), new string[] { })]
public class KBLIBANIPGF : CDFJDLPGMFI, CEGGANPCFLD, JFAKIPDGBHA
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable EOLFOHMBGLH;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable KDICGNAGCIK;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly Hashtable COOPGDHAAKC;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly JCLKAOOIHID ECNMKDBOHAJ;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly JCLKAOOIHID ODHJBHEADOO;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly JCLKAOOIHID EEFBLANIKJA;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly JCLKAOOIHID DAIJBBANCCM;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly JCLKAOOIHID KBIJKENCMIJ;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int LFICEMDKING;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x80DDDF0", Offset = "0x80DC3F0", VA = "0x1880DDDF0", Slot = "18")]
	public void BHAOPDEOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x80DE800", Offset = "0x80DCE00", VA = "0x1880DE800", Slot = "19")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x80DE450", Offset = "0x80DCA50", VA = "0x1880DE450", Slot = "4")]
	public bool GKKJPNFJKHN(JGBANCDMBHO MJNKOFMOBDK, bool ANCEAEEIOGO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x80DF6A0", Offset = "0x80DDCA0", VA = "0x1880DF6A0", Slot = "5")]
	public int OBOACPPDCOO(JGBANCDMBHO[] NJDBHJCEPHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x80DE260", Offset = "0x80DC860", VA = "0x1880DE260", Slot = "6")]
	public bool ELOIBMCBBLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x80DF3E0", Offset = "0x80DD9E0", VA = "0x1880DF3E0", Slot = "7")]
	public bool MIMCOJFCNIH(int KHKLDAJCFCJ, int JIGCFPDKNLI, bool FDCNOLIDKPN, GameObject KGMBEOBCDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x80DDE90", Offset = "0x80DC490", VA = "0x1880DDE90", Slot = "8")]
	public void DAKECFCAFDN(int JIGCFPDKNLI, [Optional] int? FPENDCNNLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x80DE8A0", Offset = "0x80DCEA0", VA = "0x1880DE8A0", Slot = "9")]
	public bool MACAIFHFLIC(FNFHFOLBALO FLDOIECLDLD, [Out] JGBANCDMBHO OGIJGOGLNOD, bool AGIKINLJOGJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x80DF100", Offset = "0x80DD700", VA = "0x1880DF100", Slot = "10")]
	public bool MHGKOHKEBCA(FNFHFOLBALO FLDOIECLDLD, [Out] int APPPOPKJKAA, [Out] JGBANCDMBHO[] NJDBHJCEPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x80DF580", Offset = "0x80DDB80", VA = "0x1880DF580", Slot = "11")]
	public bool MNDCHCGMNEO(FNFHFOLBALO FLDOIECLDLD, [Out] int JIGCFPDKNLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x80DE080", Offset = "0x80DC680", VA = "0x1880DE080", Slot = "12")]
	public void ECAPELGGELK(FNFHFOLBALO FLDOIECLDLD, [Out] int BPPCCBFJCIO, [Out] int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x80DE2F0", Offset = "0x80DC8F0", VA = "0x1880DE2F0", Slot = "13")]
	public void GDGHNAMFAOA(int APPPOPKJKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x80DFA60", Offset = "0x80DE060", VA = "0x1880DFA60", Slot = "14")]
	public void OFEJOIMFNBC(int APPPOPKJKAA, int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x80DE660", Offset = "0x80DCC60", VA = "0x1880DE660", Slot = "15")]
	public void IAEHCPPELEC(int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x80DE590", Offset = "0x80DCB90", VA = "0x1880DE590", Slot = "16")]
	public void HEBEAKDCKLI(int[] CKEPFFICIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x80DDC80", Offset = "0x80DC280", VA = "0x1880DDC80", Slot = "17")]
	public void BDDACOLBBPK(int APPPOPKJKAA, int JIGCFPDKNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x80DD840", Offset = "0x80DBE40", VA = "0x1880DD840")]
	private static void AKHOEKJIGIN(JGBANCDMBHO MJNKOFMOBDK, Hashtable ODGBFNBKDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x80DEA10", Offset = "0x80DD010", VA = "0x1880DEA10")]
	private static bool MACAIFHFLIC(Hashtable ODGBFNBKDAA, KNOJHPOMDED DPPKHMGGMMM, [Out] JGBANCDMBHO OGIJGOGLNOD, bool AGIKINLJOGJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x80DE710", Offset = "0x80DCD10", VA = "0x1880DE710")]
	private static bool IONKADFPHIC(int JIGCFPDKNLI, JGBANCDMBHO ODGBFNBKDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x80DFB80", Offset = "0x80DE180", VA = "0x1880DFB80")]
	private static int PABPMKDBJHH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KBLIBANIPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(JKJDOLAOMCI), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class JKJDOLAOMCI : CEJNGAAHCCJ, CEGGANPCFLD, JFAKIPDGBHA
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable IOPLGCJABMP;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static Hashtable GEHGAOKBOEI;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static JCLKAOOIHID GLJFOKIAKFP;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly JCLKAOOIHID CALBOBFEFII;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x80D3E30", Offset = "0x80D2430", VA = "0x1880D3E30", Slot = "8")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x80D36D0", Offset = "0x80D1CD0", VA = "0x1880D36D0", Slot = "7")]
	public void BHAOPDEOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x80D3770", Offset = "0x80D1D70", VA = "0x1880D3770", Slot = "4")]
	public void BIBGDJHHDLC(ViewId KHKLDAJCFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x80D3380", Offset = "0x80D1980", VA = "0x1880D3380", Slot = "5")]
	public bool BFDBOGIDPOM(FNFHFOLBALO FLDOIECLDLD, [Out] ViewId KHKLDAJCFCJ, [Out] string CDPMPGGLFJF, [Out] int CDIOMMNBKMD, [Out] object[] PAABDOHHHNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x80D3860", Offset = "0x80D1E60", VA = "0x1880D3860", Slot = "6")]
	public void GMCHIKDABMH(ViewId PHGOJDGOFOF, string CDPMPGGLFJF, MDFBHDODLPI AKJFMIDDDFO, KNOJHPOMDED OPOGJMFOAFI, JJGIIBPDLLN KLAOKOGJJME, object[] MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JKJDOLAOMCI()
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
