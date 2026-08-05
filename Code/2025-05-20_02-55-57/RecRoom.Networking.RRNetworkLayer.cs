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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDD40", Offset = "0x7DBCF40", VA = "0x187DBDD40", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB7C0", Offset = "0x7BCA9C0", VA = "0x187BCB7C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DC64E0", Offset = "0x7DC56E0", VA = "0x187DC64E0")]
		private void NDIKJDPGAHM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6270", Offset = "0x7DC5470", VA = "0x187DC6270")]
		private void BKLJKGOJGMF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6920", Offset = "0x7DC5B20", VA = "0x187DC6920", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DC69D0", Offset = "0x7DC5BD0", VA = "0x187DC69D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PKAINOAAPFE
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FODGIOKBGBI DHOGCHOHKLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FODGIOKBGBI MOJLEIPDINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE320", Offset = "0x7DBD520", VA = "0x187DBE320")]
		get
		{
			return default(FODGIOKBGBI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FJNMJIBCMHF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView OCDHKACHOON
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KGLDABBDEJM EJMDKJAJDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool Serialize(GABDHFAJFMP KMDHNKLEICL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Deserialize(FKHJHHKHLEA HDDBABKJHIG, GABDHFAJFMP KMDHNKLEICL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KFGJEMPCNDA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PKFGGNJAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHGPAAKDPJB(FKHJHHKHLEA HDDBABKJHIG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKAINKAKBPB(FKHJHHKHLEA HDDBABKJHIG, GABDHFAJFMP KMDHNKLEICL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface JILJLLKJNGA : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOCHIMKFMHO(FJNMJIBCMHF LKJDOHNFOAC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDBNGFDLKBA(FJNMJIBCMHF LKJDOHNFOAC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDMKHHJOEAI(GCNLKJNIIBG.DDIFMKPJJDH FGPOEHIOFHK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPKJECPPFJN();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AAFLBJEPAAB(object ELJMGFIBFCP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KGLDABBDEJM : byte
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
	Invalid
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FKHJHHKHLEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public int IFJLLOBDJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public uint AHFGECBOIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public double JNEHHIOBMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int GBAJFAEPOGK;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BPEEINKJNHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Dictionary<(ViewId, KGLDABBDEJM), KFGJEMPCNDA> KDDCKOAEJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly List<FJNMJIBCMHF> IOMDIKEFEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HashSet<(ViewId, KGLDABBDEJM)> EHEPEECBCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int JPFCHOFBPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public bool PJIDDMKIDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCNLKJNIIBG.DDIFMKPJJDH FGPOEHIOFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MemoryStream DJIBDGOBIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly GABDHFAJFMP DNAIBFPDALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly GABDHFAJFMP JLJJNHLAOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private byte[] HIKLONNPAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private float PBOKKOMBMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int DENMGLOCBEE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD000", Offset = "0x7DAC200", VA = "0x187DAD000")]
	public BPEEINKJNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DACA90", Offset = "0x7DABC90", VA = "0x187DACA90")]
	public void MDMKHHJOEAI(GCNLKJNIIBG.DDIFMKPJJDH FGPOEHIOFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DABF50", Offset = "0x7DAB150", VA = "0x187DABF50")]
	public void FPKJECPPFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DABFA0", Offset = "0x7DAB1A0", VA = "0x187DABFA0")]
	public void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DACAD0", Offset = "0x7DABCD0", VA = "0x187DACAD0")]
	public bool OOLDDNFEGEK(FJNMJIBCMHF LKJDOHNFOAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DAC730", Offset = "0x7DAB930", VA = "0x187DAC730")]
	public bool KKKHDEJPLIG(FJNMJIBCMHF LKJDOHNFOAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DAC860", Offset = "0x7DABA60", VA = "0x187DAC860")]
	private KFGJEMPCNDA LNBGMFKKBCN(ViewId NDLKHGHIICJ, KGLDABBDEJM ENKPOMMNHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DACA80", Offset = "0x7DABC80", VA = "0x187DACA80")]
	public void LNEECJGNCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DABEF0", Offset = "0x7DAB0F0", VA = "0x187DABEF0")]
	private void EIIHBMMAMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DACAB0", Offset = "0x7DABCB0", VA = "0x187DACAB0")]
	private void OODKBHFFCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DABB50", Offset = "0x7DAAD50", VA = "0x187DABB50")]
	public bool DDDHJBBEPIG(FastBufferWriter GDEDILINNBI, int HNNKDCOJAFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DAC380", Offset = "0x7DAB580", VA = "0x187DAC380")]
	public void JKAINKAKBPB(FKHJHHKHLEA HDDBABKJHIG, FastBufferReader OHHBENOLPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class KNJCEGMHGPP : KFGJEMPCNDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private FJNMJIBCMHF OECALAIANBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private uint IEIKOAMHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int ECLLMMEHBNK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PKFGGNJAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public KNJCEGMHGPP(FJNMJIBCMHF OECALAIANBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCB20", Offset = "0x7DBBD20", VA = "0x187DBCB20", Slot = "5")]
	public bool PHGPAAKDPJB(FKHJHHKHLEA HDDBABKJHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCA40", Offset = "0x7DBBC40", VA = "0x187DBCA40", Slot = "6")]
	public void JKAINKAKBPB(FKHJHHKHLEA HDDBABKJHIG, GABDHFAJFMP KMDHNKLEICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PAKBGIJBIDJ : KFGJEMPCNDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GCNLKJNIIBG.DDIFMKPJJDH FGPOEHIOFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ViewId NDLKHGHIICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int ECLLMMEHBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private uint IEIKOAMHKGC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PKFGGNJAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x19A7B10", Offset = "0x19A6D10", VA = "0x1819A7B10")]
	public PAKBGIJBIDJ(ViewId NDLKHGHIICJ, GCNLKJNIIBG.DDIFMKPJJDH FGPOEHIOFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE2E0", Offset = "0x7DBD4E0", VA = "0x187DBE2E0", Slot = "5")]
	public bool PHGPAAKDPJB(FKHJHHKHLEA HDDBABKJHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE100", Offset = "0x7DBD300", VA = "0x187DBE100", Slot = "6")]
	public void JKAINKAKBPB(FKHJHHKHLEA HDDBABKJHIG, GABDHFAJFMP KMDHNKLEICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EMLGACDLADA
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD460", Offset = "0x7DAC660", VA = "0x187DAD460")]
	public static void CEBCPPBDNIB(this LKKBBGCNCDA GEOMNIANDLN, GABDHFAJFMP AOPJAJPHGPK, ViewId OPJOIGJBJKN, bool FGNEOMDCBNA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD620", Offset = "0x7DAC820", VA = "0x187DAD620")]
	public static void HDEGPJOCGBM(this LKKBBGCNCDA GEOMNIANDLN, GABDHFAJFMP AOPJAJPHGPK, bool FGNEOMDCBNA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DADB20", Offset = "0x7DACD20", VA = "0x187DADB20")]
	public static LKKBBGCNCDA JKAINKAKBPB(GABDHFAJFMP AOPJAJPHGPK, ViewId OPJOIGJBJKN, bool FGNEOMDCBNA = true)
	{
		return default(LKKBBGCNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DADC90", Offset = "0x7DACE90", VA = "0x187DADC90")]
	public static void OAKADNBBKEE(this LKKBBGCNCDA GEOMNIANDLN, GABDHFAJFMP AOPJAJPHGPK, bool FGNEOMDCBNA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(JILJLLKJNGA), new string[] { })]
public class LMLJJANJFDB : JILJLLKJNGA, INetworkUpdateSystem, BNKAFMBCILN, AOOLNAMPIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly FODGIOKBGBI MGBPCGDFOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private BPEEINKJNHO CCJJDPFMEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private uint FAKMDCAPBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private float ECEPKNANDDF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDB50", Offset = "0x7DBCD50", VA = "0x187DBDB50", Slot = "4")]
	public void OOCHIMKFMHO(FJNMJIBCMHF LKJDOHNFOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD5C0", Offset = "0x7DBC7C0", VA = "0x187DBD5C0", Slot = "5")]
	public void DDBNGFDLKBA(FJNMJIBCMHF LKJDOHNFOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD940", Offset = "0x7DBCB40", VA = "0x187DBD940", Slot = "10")]
	public void KAILFKOCFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDAD0", Offset = "0x7DBCCD0", VA = "0x187DBDAD0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage BDFLJMOIGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCC70", Offset = "0x7DBBE70", VA = "0x187DBCC70")]
	private void CAFJAJKDBNP(uint EIKIOIAMNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDAA0", Offset = "0x7DBCCA0", VA = "0x187DBDAA0", Slot = "6")]
	public void MDMKHHJOEAI(GCNLKJNIIBG.DDIFMKPJJDH FGPOEHIOFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD8E0", Offset = "0x7DBCAE0", VA = "0x187DBD8E0", Slot = "7")]
	public void FPKJECPPFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCC10", Offset = "0x7DBBE10", VA = "0x187DBCC10", Slot = "8")]
	public void AAFLBJEPAAB(object IMPAKIFFNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD240", Offset = "0x7DBC440", VA = "0x187DBD240")]
	private void CDHBHDDMNPE(KOEIHCIJPPL IMPAKIFFNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD7C0", Offset = "0x7DBC9C0", VA = "0x187DBD7C0", Slot = "11")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDC70", Offset = "0x7DBCE70", VA = "0x187DBDC70")]
	public LMLJJANJFDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AFHEIDHGCGF : KFGJEMPCNDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float DBGHPDAFENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int ECLLMMEHBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private uint IEIKOAMHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly KGLDABBDEJM DCILOPKGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public FKHJHHKHLEA EFNOAKCPNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int NMLNMNJJLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte[] HJCPIAGCMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private FKHJHHKHLEA AGDCAGOJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int BJIBLIEHCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private byte[] ALFADMHKFFN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PKFGGNJAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8A50", Offset = "0x7DA7C50", VA = "0x187DA8A50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8AC0", Offset = "0x7DA7CC0", VA = "0x187DA8AC0")]
	public AFHEIDHGCGF(KGLDABBDEJM DCILOPKGAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8A80", Offset = "0x7DA7C80", VA = "0x187DA8A80", Slot = "5")]
	public bool PHGPAAKDPJB(FKHJHHKHLEA HDDBABKJHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA86D0", Offset = "0x7DA78D0", VA = "0x187DA86D0", Slot = "6")]
	public void JKAINKAKBPB(FKHJHHKHLEA HDDBABKJHIG, GABDHFAJFMP KMDHNKLEICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DA85C0", Offset = "0x7DA77C0", VA = "0x187DA85C0")]
	internal KNJCEGMHGPP GKOJIBCFEDD(FJNMJIBCMHF LKJDOHNFOAC, GABDHFAJFMP AOPJAJPHGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8880", Offset = "0x7DA7A80", VA = "0x187DA8880")]
	private static void NHIJMMEOBBC(KNJCEGMHGPP CDCHJDEHFCB, GABDHFAJFMP AOPJAJPHGPK, FKHJHHKHLEA KIBNPNKILCF, byte[] KKCFCHBPMCG, int JFFHNJOHCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(AKPCKBANMAL), new string[] { })]
public class AKPCKBANMAL
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly Hashtable FDKDJIHCMKN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly Hashtable CCNDFENMMFM;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable PKJBLOGOGNN;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly BKJLKPIDHCH KILENIDNHMN;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly BKJLKPIDHCH GJJDGOALKCN;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly BKJLKPIDHCH BBMACGFOFCL;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly BKJLKPIDHCH GBOLEOPAMCN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly BKJLKPIDHCH IIPKIKGEAAI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int GIOIAEPJMLC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB650", Offset = "0x7DAA850", VA = "0x187DAB650")]
	public bool PGJOOOOALFO(BGKEGCLFFHG MGEECOGALOB, bool DJLIFPAFPLF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7DA9A20", Offset = "0x7DA8C20", VA = "0x187DA9A20")]
	public int COKKEKDEGEA(BGKEGCLFFHG[] JKMBFNCDHDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB510", Offset = "0x7DAA710", VA = "0x187DAB510")]
	public bool NNLPEKMOJNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB370", Offset = "0x7DAA570", VA = "0x187DAB370")]
	public bool MNCOLBNHIFC(RRNetworkView ONJKGMAPGIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DAA210", Offset = "0x7DA9410", VA = "0x187DAA210")]
	public void IJNLHLGANCJ(int KJCKPBJEEKE, [Optional] int? CDAPGHDNKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7DAA520", Offset = "0x7DA9720", VA = "0x187DAA520")]
	public static bool KFKNCCBJMLN(KOEIHCIJPPL ELJMGFIBFCP, [Out] BGKEGCLFFHG OEEEPGELEFK, bool FDCIDBMAIAG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7DAAC60", Offset = "0x7DA9E60", VA = "0x187DAAC60")]
	public bool LGBNPKGFNDD(KOEIHCIJPPL ELJMGFIBFCP, [Out] int IAPAHCODCIK, [Out] BGKEGCLFFHG[] JKMBFNCDHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7DAA400", Offset = "0x7DA9600", VA = "0x187DAA400")]
	public bool IMOMALADOEG(KOEIHCIJPPL ELJMGFIBFCP, [Out] int KJCKPBJEEKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB020", Offset = "0x7DAA220", VA = "0x187DAB020")]
	public void MHPMHDDPILI(KOEIHCIJPPL ELJMGFIBFCP, [Out] int MGJGKPIEDFL, [Out] int[] OPJOOLNPHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DA98B0", Offset = "0x7DA8AB0", VA = "0x187DA98B0")]
	public void CCDGGGOGFPA(int IAPAHCODCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DA96B0", Offset = "0x7DA88B0", VA = "0x187DA96B0")]
	public void AFIDJJHCJLL(int IAPAHCODCIK, int[] OPJOOLNPHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB5A0", Offset = "0x7DAA7A0", VA = "0x187DAB5A0")]
	public void NPAAHCFJJOE(int[] OPJOOLNPHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA97D0", Offset = "0x7DA89D0", VA = "0x187DA97D0")]
	public void BIAHGEHBCIG(int[] OPJOOLNPHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB200", Offset = "0x7DAA400", VA = "0x187DAB200")]
	public void MKCKAIKMNMI(int IAPAHCODCIK, int KJCKPBJEEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB780", Offset = "0x7DAA980", VA = "0x187DAB780")]
	public void PNNNDKBDICG(int[] GFMFHBFGJEN, int JJCLDAPFMDG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DA9DE0", Offset = "0x7DA8FE0", VA = "0x187DA9DE0")]
	private static void IFJDEADIKBP(BGKEGCLFFHG MGEECOGALOB, Hashtable KAOFJFDJEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DAA690", Offset = "0x7DA9890", VA = "0x187DAA690")]
	private static bool KFKNCCBJMLN(Hashtable KAOFJFDJEBH, KPDBONCIMNC MJJPIMBMHLM, [Out] BGKEGCLFFHG OEEEPGELEFK, bool FDCIDBMAIAG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DAAF40", Offset = "0x7DAA140", VA = "0x187DAAF40")]
	private static int LMOFADCBEPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AKPCKBANMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(AHJNAMNBDEN), new string[] { })]
public class AHJNAMNBDEN
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static Hashtable CFPOCGIBKJH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static Hashtable BLPGGPIAFHA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BKJLKPIDHCH INMCOBGKLCK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly BKJLKPIDHCH BABDAOIIINB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8B30", Offset = "0x7DA7D30", VA = "0x187DA8B30")]
	public void BLHBKMLOGAK(ViewId NDLKHGHIICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8C20", Offset = "0x7DA7E20", VA = "0x187DA8C20")]
	public static bool IEEAJPNDFFE(KOEIHCIJPPL ELJMGFIBFCP, [Out] ViewId NDLKHGHIICJ, [Out] string DPGONDFGJJB, [Out] int DDEGNPJNBGE, [Out] object[] OLHPCEIIIOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DA8F60", Offset = "0x7DA8160", VA = "0x187DA8F60")]
	public void LNMCBKINMNN(ViewId DMGGONLOPJG, string DPGONDFGJJB, NJCHOGHPIEO PPMJOEHCAHP, KPDBONCIMNC PNBFNEJFAPC, MBIPOABIIOF KEIEBPIDPDB, object[] MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AHJNAMNBDEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NOCOLPFCFFB
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE070", Offset = "0x7DBD270", VA = "0x187DBE070")]
	public static KPDBONCIMNC ADNILEHACJN(this MMNMPKDPAGK KOCMKKLCMKL)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, PKAAOCDFHFB, KCDOIJCMEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private List<KLBOHECHKNP> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ViewId NBLOIEFHFOH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEAE0", Offset = "0x7DBDCE0", VA = "0x187DBEAE0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId BEFPJHMMBLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEAE0", Offset = "0x7DBDCE0", VA = "0x187DBEAE0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView EADLIFECOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEB60", Offset = "0x7DBDD60", VA = "0x187DBEB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RRNetworkView OCDHKACHOON
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEB60", Offset = "0x7DBDD60", VA = "0x187DBEB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KPDBONCIMNC GFKMIFHBFLK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEC60", Offset = "0x7DBDE60", VA = "0x187DBEC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KPDBONCIMNC FNEFIOJLPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEFC0", Offset = "0x7DBE1C0", VA = "0x187DBEFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool NOMKFMKAKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEDC0", Offset = "0x7DBDFC0", VA = "0x187DBEDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LIIOKICCHHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEF30", Offset = "0x7DBE130", VA = "0x187DBEF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DOAODBIHDLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEA10", Offset = "0x7DBDC10", VA = "0x187DBEA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GNFMCCANHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7DBECF0", Offset = "0x7DBDEF0", VA = "0x187DBECF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BNIILIHNGAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEA10", Offset = "0x7DBDC10", VA = "0x187DBEA10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool DOLBCAHANKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEA90", Offset = "0x7DBDC90", VA = "0x187DBEA90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string LIEJABCOPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEBD0", Offset = "0x7DBDDD0", VA = "0x187DBEBD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool GHDPKOGLANC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE990", Offset = "0x7DBDB90", VA = "0x187DBE990", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<KPDBONCIMNC> MKGNGAOLLLM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE860", Offset = "0x7DBDA60", VA = "0x187DBE860")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF050", Offset = "0x7DBE250", VA = "0x187DBF050")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE7C0", Offset = "0x7DBD9C0", VA = "0x187DBE7C0")]
		public bool WasSpawnedForPlayer(int CIKJCNCBOHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x715CB10", Offset = "0x715BD10", VA = "0x18715CB10")]
		private void ONBPAOEMAEM(RRNetworkView NIDPEFPJBOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE3F0", Offset = "0x7DBD5F0", VA = "0x187DBE3F0", Slot = "9")]
		public void RegisterDestroyHandler(KLBOHECHKNP LKMFAJMIACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE5F0", Offset = "0x7DBD7F0", VA = "0x187DBE5F0", Slot = "10")]
		public void UnregisterDestroyHandler(KLBOHECHKNP LKMFAJMIACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE3D0", Offset = "0x7DBD5D0", VA = "0x187DBE3D0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HNMABLLCJHL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void HKDCPAACDGJ([In] BGKEGCLFFHG MGEECOGALOB, bool HKFCBABGEFA, bool KAOFJFDJEBH, bool BDGDNEPOFKJ);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void BHFJAGAEKKD(GameObject FOEGMFMLJCB);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void MMKEHPLGHDA(GameObject FOEGMFMLJCB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void EHFFBEDMBFA(RRNetworkView DMGGONLOPJG, string DPGONDFGJJB, KPDBONCIMNC HMFALEOPEFK, NJCHOGHPIEO? PJNHLGGHCLG, bool PDEBKBMLEBK, MBIPOABIIOF OCICPKKEFHG, object[] MGEECOGALOB, string FPCCAOEIJBC);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void DHCMDFGKIGD(RRNetworkView DMGGONLOPJG, string DPGONDFGJJB, KPDBONCIMNC HMFALEOPEFK, NJCHOGHPIEO? PJNHLGGHCLG, bool PDEBKBMLEBK, MBIPOABIIOF OCICPKKEFHG, object[] MGEECOGALOB, string FPCCAOEIJBC);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void IHNNCBELOAF(RRNetworkView DMGGONLOPJG, string DPGONDFGJJB, object[] OLHPCEIIIOL, string BLCOMNJDDKP);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void GEOJPOHDABK(RRNetworkView DMGGONLOPJG, KPDBONCIMNC FMILAEGCOGK);

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[CompilerGenerated]
	private static BHFJAGAEKKD ALAIOACIDAK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event HKDCPAACDGJ PAFNNNBPAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7910", Offset = "0x7DB6B10", VA = "0x187DB7910")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7850", Offset = "0x7DB6A50", VA = "0x187DB7850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event BHFJAGAEKKD GBLDNNFOPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7640", Offset = "0x7DB6840", VA = "0x187DB7640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8220", Offset = "0x7DB7420", VA = "0x187DB8220")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event MMKEHPLGHDA IMPPONNPIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7CD0", Offset = "0x7DB6ED0", VA = "0x187DB7CD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7C10", Offset = "0x7DB6E10", VA = "0x187DB7C10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event MMKEHPLGHDA EKPLHOBDIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8010", Offset = "0x7DB7210", VA = "0x187DB8010")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8900", Offset = "0x7DB7B00", VA = "0x187DB8900")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event EHFFBEDMBFA CLCLPNPKEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7DB86F0", Offset = "0x7DB78F0", VA = "0x187DB86F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8630", Offset = "0x7DB7830", VA = "0x187DB8630")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event DHCMDFGKIGD FEGHFBPOFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7790", Offset = "0x7DB6990", VA = "0x187DB7790")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB79D0", Offset = "0x7DB6BD0", VA = "0x187DB79D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event IHNNCBELOAF JIJMHFGLMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB87B0", Offset = "0x7DB79B0", VA = "0x187DB87B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7B50", Offset = "0x7DB6D50", VA = "0x187DB7B50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event GEOJPOHDABK IHEIFHMKCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7E50", Offset = "0x7DB7050", VA = "0x187DB7E50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8570", Offset = "0x7DB7770", VA = "0x187DB8570")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event GEOJPOHDABK HGAFNAGILLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7D90", Offset = "0x7DB6F90", VA = "0x187DB7D90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8370", Offset = "0x7DB7570", VA = "0x187DB8370")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7A90", Offset = "0x7DB6C90", VA = "0x187DB7A90")]
	public static void FKJIGOJHJFM([In] BGKEGCLFFHG MGEECOGALOB, bool HKFCBABGEFA, bool KAOFJFDJEBH, bool BDGDNEPOFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7700", Offset = "0x7DB6900", VA = "0x187DB7700")]
	public static void CHGALHAPDOK(GameObject FOEGMFMLJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7DB75B0", Offset = "0x7DB67B0", VA = "0x187DB75B0")]
	public static void AHNLAIGNPPN(GameObject FOEGMFMLJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7DB82E0", Offset = "0x7DB74E0", VA = "0x187DB82E0")]
	public static void KJCJENGIGGO(GameObject FOEGMFMLJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8870", Offset = "0x7DB7A70", VA = "0x187DB8870")]
	public static void ODLPDOHDLEK(GameObject FOEGMFMLJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7DB80D0", Offset = "0x7DB72D0", VA = "0x187DB80D0")]
	public static void KEDKNCKFCNK(RRNetworkView DMGGONLOPJG, string DPGONDFGJJB, KPDBONCIMNC HMFALEOPEFK, NJCHOGHPIEO? PJNHLGGHCLG, bool PDEBKBMLEBK, MBIPOABIIOF OCICPKKEFHG, object[] MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8430", Offset = "0x7DB7630", VA = "0x187DB8430")]
	public static void LECPDFGBOLF(RRNetworkView DMGGONLOPJG, string DPGONDFGJJB, int APPPDFKJPCG, object[] OLHPCEIIIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7F10", Offset = "0x7DB7110", VA = "0x187DB7F10")]
	public static void JGFLAAEEFPI(int NDLKHGHIICJ, int KOCMKKLCMKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IPAEJFLFFJF
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8C30", Offset = "0x7DB7E30", VA = "0x187DB8C30")]
	[CanBeNull]
	private static bool NKPCLLKOCPN(ViewId MKHHKDJKLDN, [Out] RRNetworkView DMGGONLOPJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8A80", Offset = "0x7DB7C80", VA = "0x187DB8A80")]
	[CanBeNull]
	public static Component IJAMIACFLML(this ViewId DMGGONLOPJG, Type INAGDPBAAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3853440", Offset = "0x3852640", VA = "0x183853440")]
	[CanBeNull]
	public static T IJAMIACFLML<T>(this ViewId DMGGONLOPJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3853440", Offset = "0x3852640", VA = "0x183853440")]
	[CanBeNull]
	public static T ECICILIBOLB<T>(this ViewId DMGGONLOPJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38533B0", Offset = "0x38525B0", VA = "0x1838533B0")]
	public static bool ANBPMJDJPDK<T>(this ViewId DMGGONLOPJG, [Out] T IGGKBIDIAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8B60", Offset = "0x7DB7D60", VA = "0x187DB8B60")]
	[CanBeNull]
	public static RRNetworkView MOJHFGDLPCC(this ViewId DMGGONLOPJG)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static RRNetworkHandler BJFPHBLMMJE;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		internal static RRNetworkHandler NDDGJHHDBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF180", Offset = "0x7DBE380", VA = "0x187DBF180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF330", Offset = "0x7DBE530", VA = "0x187DBF330")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF2F0", Offset = "0x7DBE4F0", VA = "0x187DBF2F0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(HCIFJGDEEDC), new string[] { "Photon" })]
public sealed class HCIFJGDEEDC : DEBGKLLICLI, BNKAFMBCILN, AOOLNAMPIBN, FDPAHGLNLAC, PLEAAKNHJFO
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JPPKINBHIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JPPKINBHIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8D40", Offset = "0x7DB7F40", VA = "0x187DB8D40")]
		internal object KOFAFCPGPOP((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static FODGIOKBGBI IDNMBDLBPBP;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static FODGIOKBGBI EMHPJJODONK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static Dictionary<int, HashSet<int>> NOLMGCAHNLO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, int> DPJFIPBIGAC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly List<(GameObject GameObject, int ParentCount)> HLGGIEKAOKN;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly List<GameObject> EMOPNKIOJBH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static List<int> PEBHHMGJFEG;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<RRNetworkView> PPELFDMHGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private AKPCKBANMAL FFHFGEEFAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3010", Offset = "0x7DB2210", VA = "0x187DB3010", Slot = "8")]
	public void KAILFKOCFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DB07F0", Offset = "0x7DAF9F0", VA = "0x187DB07F0", Slot = "9")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1600", Offset = "0x7DB0800", VA = "0x187DB1600", Slot = "10")]
	public void GNFFNDKIPII(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DB36C0", Offset = "0x7DB28C0", VA = "0x187DB36C0", Slot = "11")]
	public void KLCGJKGKFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1510", Offset = "0x7DB0710", VA = "0x187DB1510")]
	private void GLGLEBIJCIN(PKBJGPBGHDJ IIDOKMMFDKI, PKBJGPBGHDJ HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5E30", Offset = "0x7DB5030", VA = "0x187DB5E30")]
	private void OIANEEIPMAL(DKFFBNMFNOI FJMMKFOIHFF, DKFFBNMFNOI NGBAGCNCKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1900", Offset = "0x7DB0B00", VA = "0x187DB1900")]
	public GameObject HIICDPAANJL(string DGIAFBEDPNJ, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, Vector3 MMIJFAFPOOH, ViewId NDLKHGHIICJ, NPBKHGDHPBE MGEECOGALOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE780", Offset = "0x7DAD980", VA = "0x187DAE780")]
	public GameObject ANGINODNLGD(string DGIAFBEDPNJ, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float MMIJFAFPOOH, object[] MGEECOGALOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE450", Offset = "0x7DAD650", VA = "0x187DAE450")]
	public GameObject ADNKPIMNELA(string DGIAFBEDPNJ, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, Vector3 MMIJFAFPOOH, ViewId DMGGONLOPJG, NPBKHGDHPBE MGEECOGALOB, bool BDGDNEPOFKJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEEB0", Offset = "0x7DAE0B0", VA = "0x187DAEEB0")]
	public GameObject CIDAGJHDPLJ(BGKEGCLFFHG MGEECOGALOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE870", Offset = "0x7DADA70", VA = "0x187DAE870", Slot = "6")]
	public void BDINPEDJMAE(GameObject FOEGMFMLJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1AD0", Offset = "0x7DB0CD0", VA = "0x187DB1AD0")]
	public void HNKJLMBKKEO(GameObject GNOLFLMODHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB66C0", Offset = "0x7DB58C0", VA = "0x187DB66C0", Slot = "7")]
	public void PONFMNMIKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4860", Offset = "0x7DB3A60", VA = "0x187DB4860", Slot = "4")]
	public GameObject[] MDGEHAPBFOL(IList<ANAGNMGLHIF> AMEPKMJHNEA, bool GIAFCDMKNMI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0F30", Offset = "0x7DB0130", VA = "0x187DB0F30", Slot = "5")]
	public void EIOJCLDDKNL(List<GameObject> ODHBNGDHFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4780", Offset = "0x7DB3980", VA = "0x187DB4780")]
	public void LKGDGLDCMAP(GameObject GNOLFLMODHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEC50", Offset = "0x7DADE50", VA = "0x187DAEC50")]
	private void CDHBHDDMNPE(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7DB12F0", Offset = "0x7DB04F0", VA = "0x187DB12F0")]
	private void FKKLPAMHBNO(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE880", Offset = "0x7DADA80", VA = "0x187DAE880")]
	private void BEEAPDMEGGN(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7DB04B0", Offset = "0x7DAF6B0", VA = "0x187DB04B0")]
	private void DODNFNLMLFO(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0B90", Offset = "0x7DAFD90", VA = "0x187DB0B90")]
	private void EGNALNGHFHA(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3370", Offset = "0x7DB2570", VA = "0x187DB3370")]
	private void KAJBBKANCJJ(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2A70", Offset = "0x7DB1C70", VA = "0x187DB2A70")]
	private void JMMAKFPIIHE(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF2F0", Offset = "0x7DAE4F0", VA = "0x187DAF2F0")]
	private GameObject DIDFKILDNAD(string PGFEGIPOLEF, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, Vector3 MMIJFAFPOOH, byte DHOGCHOHKLD = 0, [Optional] object[] DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4040", Offset = "0x7DB3240", VA = "0x187DB4040")]
	private GameObject LENANMJGDOG(BGKEGCLFFHG MGEECOGALOB, bool HKFCBABGEFA = false, bool KAOFJFDJEBH = false, bool BDGDNEPOFKJ = true, bool ODHGMKKMDPL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5070", Offset = "0x7DB4270", VA = "0x187DB5070")]
	private static GameObject NECMAGNPOAF(string PGFEGIPOLEF, bool LLBKFIIFAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4E60", Offset = "0x7DB4060", VA = "0x187DB4E60")]
	private static GameObject NCNBLEGPIDN(GameObject IGJKKFNOEMM, BGKEGCLFFHG MGEECOGALOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEB40", Offset = "0x7DADD40", VA = "0x187DAEB40")]
	private static void BFBBBCLLGJL(GameObject FOEGMFMLJCB, RRNetworkView DMGGONLOPJG, [In] BGKEGCLFFHG MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5F30", Offset = "0x7DB5130", VA = "0x187DB5F30")]
	private GameObject[] OOJGFMFOAPB(IList<ANAGNMGLHIF> AMEPKMJHNEA, bool GIAFCDMKNMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1B40", Offset = "0x7DB0D40", VA = "0x187DB1B40")]
	private GameObject[] IBMPKCJNGBN(BGKEGCLFFHG[] JKMBFNCDHDF, int IAPAHCODCIK, KPDBONCIMNC PNBFNEJFAPC, GameObject[] DGHEHKIHDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB50F0", Offset = "0x7DB42F0", VA = "0x187DB50F0")]
	private GameObject NJKMDIFBHOM([In] BGKEGCLFFHG MGEECOGALOB, GameObject IGJKKFNOEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7142DD0", Offset = "0x7141FD0", VA = "0x187142DD0")]
	private static bool HLNINIOCDGN(bool HKFCBABGEFA, bool BDGDNEPOFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1DE0", Offset = "0x7DB0FE0", VA = "0x187DB1DE0")]
	private void JCBOPFAOCHC(IEnumerable<GameObject> ODHBNGDHFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF4E0", Offset = "0x7DAE6E0", VA = "0x187DAF4E0")]
	private void DJNMKPHBANC(GameObject FOEGMFMLJCB, bool ODHGMKKMDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5500", Offset = "0x7DB4700", VA = "0x187DB5500")]
	private static void OAGFCOMAKDJ(IEnumerable<GameObject> MAIJCLABKEH, List<(GameObject GameObject, int ParentCount)> HMINCOIKMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEEE0", Offset = "0x7DAE0E0", VA = "0x187DAEEE0")]
	private void DCFCNCIMACO(int KJCKPBJEEKE, int IAPAHCODCIK, bool ODHGMKKMDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE6E0", Offset = "0x7DAD8E0", VA = "0x187DAE6E0")]
	private static int AMPKJADNLBJ(int KJCKPBJEEKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0790", Offset = "0x7DAF990", VA = "0x187DB0790")]
	private void EAHGLHOMCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5900", Offset = "0x7DB4B00", VA = "0x187DB5900")]
	private void OHJPKHMNPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7DB18A0", Offset = "0x7DB0AA0", VA = "0x187DB18A0")]
	private static int HFKGHIDJKON(int PIPMNGJMGNF, bool BDGDNEPOFKJ = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DAEDD0", Offset = "0x7DADFD0", VA = "0x187DAEDD0")]
	private static int[] CGOFNENLCLH(int DKBHJJAMEPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB17A0", Offset = "0x7DB09A0", VA = "0x187DB17A0")]
	private static int[] HEKCPDLIMML(int FNEFIOJLPDJ, int DKBHJJAMEPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0B50", Offset = "0x7DAFD50", VA = "0x187DB0B50")]
	private void EGLNBJMLJNN(KPDBONCIMNC NMAPFLEKNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3820", Offset = "0x7DB2A20", VA = "0x187DB3820")]
	private void LCPKOGLPCEH(KPDBONCIMNC PNBFNEJFAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF010", Offset = "0x7DAE210", VA = "0x187DAF010")]
	private void DEDNCIFKOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4C20", Offset = "0x7DB3E20", VA = "0x187DB4C20")]
	private void NAPCIFIPACO(KPDBONCIMNC PNBFNEJFAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4B80", Offset = "0x7DB3D80", VA = "0x187DB4B80")]
	private static void MOLNLDIIBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HCIFJGDEEDC()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(KBFFIHEGDOP), new string[] { "Photon" })]
public class KBFFIHEGDOP : BNKAFMBCILN, AOOLNAMPIBN, IELLFNEFJEB, NCFJOFAJMFL
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GOMCDJHIGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly MethodInfo MDPHFPBGFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Func<MonoBehaviour, object> FNHMONHDOBP;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
		public GOMCDJHIGKN(MethodInfo MDPHFPBGFPH, [Optional] Func<MonoBehaviour, object> FNHMONHDOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7145CA0", Offset = "0x7144EA0", VA = "0x187145CA0")]
		public object OBGBHDNAMDK(MonoBehaviour ANNJCHDFJOJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CMHAKJBJDHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CMHAKJBJDHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DAD220", Offset = "0x7DAC420", VA = "0x187DAD220")]
		internal GOMCDJHIGKN GBOIHPKNBFM(MethodInfo methodInfo)
		{
			return default(GOMCDJHIGKN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x40E4490", Offset = "0x40E3690", VA = "0x1840E4490")]
		internal object LOALONBDCJE(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OIOMFICDEIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OIOMFICDEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7145BC0", Offset = "0x7144DC0", VA = "0x187145BC0")]
		internal GOMCDJHIGKN CAAADIMCEDK(MethodInfo methodInfo)
		{
			return default(GOMCDJHIGKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class FDIDAGMAAJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FDIDAGMAAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE040", Offset = "0x7DAD240", VA = "0x187DAE040")]
		internal bool NCBPELKFPIC(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private AHJNAMNBDEN HCBANCGPBOP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Stopwatch IKNOHADFEHF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Dictionary<MethodInfo, ParameterInfo[]> FFAPEAFJGJO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Dictionary<Type, List<GOMCDJHIGKN>> BJCLKPNBFAG;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9B30", Offset = "0x7DB8D30", VA = "0x187DB9B30", Slot = "4")]
	public void KAILFKOCFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9AE0", Offset = "0x7DB8CE0", VA = "0x187DB9AE0", Slot = "6")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9660", Offset = "0x7DB8860", VA = "0x187DB9660", Slot = "5")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9460", Offset = "0x7DB8660", VA = "0x187DB9460")]
	private void CDHBHDDMNPE(KOEIHCIJPPL ELJMGFIBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8E00", Offset = "0x7DB8000", VA = "0x187DB8E00", Slot = "10")]
	public string AAAKGCCIMJN(KOEIHCIJPPL ELJMGFIBFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8E30", Offset = "0x7DB8030", VA = "0x187DB8E30", Slot = "9")]
	public void BLHBKMLOGAK(ViewId NDLKHGHIICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9360", Offset = "0x7DB8560", VA = "0x187DB9360", Slot = "7")]
	public void CCPMJNKFGNK(ViewId DMGGONLOPJG, string DPGONDFGJJB, KPDBONCIMNC PNBFNEJFAPC, MBIPOABIIOF OCICPKKEFHG, params object[] MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9430", Offset = "0x7DB8630", VA = "0x187DB9430", Slot = "8")]
	public void CCPMJNKFGNK(ViewId DMGGONLOPJG, string DPGONDFGJJB, NJCHOGHPIEO PJNHLGGHCLG, MBIPOABIIOF OCICPKKEFHG, params object[] MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8F30", Offset = "0x7DB8130", VA = "0x187DB8F30")]
	private void CCPMJNKFGNK(ViewId DMGGONLOPJG, string DPGONDFGJJB, NJCHOGHPIEO PJNHLGGHCLG, KPDBONCIMNC PNBFNEJFAPC, MBIPOABIIOF OCICPKKEFHG, params object[] MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAB00", Offset = "0x7DB9D00", VA = "0x187DBAB00")]
	private void OAPNPHLPBOG(ViewId NDLKHGHIICJ, string DPGONDFGJJB, KPDBONCIMNC NEGFBCIAAFG, int DDEGNPJNBGE, object[] OLHPCEIIIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9C80", Offset = "0x7DB8E80", VA = "0x187DB9C80")]
	private static void KBBCJHFAHDP(GOMCDJHIGKN IPBOIENDBHP, MonoBehaviour EHJJGHNPHBO, object[] EFGHMCKPMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB98B0", Offset = "0x7DB8AB0", VA = "0x187DB98B0")]
	private static bool FOHPNKPBICJ(ParameterInfo[] FNABGLNILJD, Type[] EGOHMJFMONI, [Out] bool FLFAKCCJDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA110", Offset = "0x7DB9310", VA = "0x187DBA110")]
	private List<GOMCDJHIGKN> NIEAMNAGJGN(MonoBehaviour EHJJGHNPHBO, Type BJGCKNHFEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7DB97B0", Offset = "0x7DB89B0", VA = "0x187DB97B0")]
	private static IEnumerable<MethodInfo> FJINHFKJJEN(Type EDLOHJEBKFM, Type GLJHMAAOIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC7B0", Offset = "0x7DBB9B0", VA = "0x187DBC7B0")]
	public static ParameterInfo[] OIBIDLFIJJP(MethodInfo MGBCHEMMPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KBFFIHEGDOP()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, GHFHANGICMB, OPKBLCJLMNI, ENGCOENEKCO, KKHGLPKGNNB, LDPLMDFJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum KFCELFCDINJ
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
		private sealed class JFBBFMDMIHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public JFBBFMDMIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x7DB8CE0", Offset = "0x7DB7EE0", VA = "0x187DB8CE0")]
			internal bool MNPDEEPAHII(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static Dictionary<int, RRNetworkView> JGKOGICJJFF;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static BKJLKPIDHCH PEIJKMDHJCL;

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
		private bool HLKBKHIHGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal bool PINGFOIAGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public KFCELFCDINJ hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool BJHBKODMBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool JEMHIOJCOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int DICMJACLINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool GOKEAHJOHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int CIEFKLDIHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KPDBONCIMNC FNEFIOJLPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private KPDBONCIMNC JNGOBIONIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool? COHGNGBBMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool DDLBAOMHJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal bool BFAMMGDFMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal MonoBehaviour[] EFBOMDIGHKA;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly FODGIOKBGBI OPLLIJNCILB;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ViewId BEFPJHMMBLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4600", Offset = "0x7DC3800", VA = "0x187DC4600")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId MIJPAFJJHGO
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4600", Offset = "0x7DC3800", VA = "0x187DC4600", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId NBLOIEFHFOH
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4600", Offset = "0x7DC3800", VA = "0x187DC4600")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int NHGMGLMFLCM
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int FNAOOFCFNCI
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId PCJELJFJDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4470", Offset = "0x7DC3670", VA = "0x187DC4470")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ILFAPLBAJJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool NBKLKCGEGBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4480", Offset = "0x7DC3680", VA = "0x187DC4480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool BKEANHKJEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int CGJPMGAEDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int PBGDDPECBJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4410", Offset = "0x7DC3610", VA = "0x187DC4410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public KPDBONCIMNC PJJDEJHHGIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4610", Offset = "0x7DC3810", VA = "0x187DC4610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public KPDBONCIMNC CCCCIDMPBEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7DC43E0", Offset = "0x7DC35E0", VA = "0x187DC43E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KPDBONCIMNC GFKMIFHBFLK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7DC43E0", Offset = "0x7DC35E0", VA = "0x187DC43E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public KPDBONCIMNC IIAFCILIGFK
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7DC43E0", Offset = "0x7DC35E0", VA = "0x187DC43E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool EOOOLINGLDF
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4550", Offset = "0x7DC3750", VA = "0x187DC4550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int EJNFKBLOBMG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4440", Offset = "0x7DC3640", VA = "0x187DC4440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public object[] HBKEFCOLDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool NOMKFMKAKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4640", Offset = "0x7DC3840", VA = "0x187DC4640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool KGIFPHLMJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7DC45D0", Offset = "0x7DC37D0", VA = "0x187DC45D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EAJMLDDJJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xD34ED0", Offset = "0xD340D0", VA = "0x180D34ED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xE92CC0", Offset = "0xE91EC0", VA = "0x180E92CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HCBJHJGLDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xBE2720", Offset = "0xBE1920", VA = "0x180BE2720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> ACGABFALOEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4280", Offset = "0x7DC3480", VA = "0x187DC4280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4800", Offset = "0x7DC3A00", VA = "0x187DC4800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<KPDBONCIMNC> CDJEEKMLALA
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0E60", Offset = "0x7DC0060", VA = "0x187DC0E60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0920", Offset = "0x7DBFB20", VA = "0x187DC0920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<KPDBONCIMNC> OMCHGEHHCCA
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0E60", Offset = "0x7DC0060", VA = "0x187DC0E60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0920", Offset = "0x7DBFB20", VA = "0x187DC0920")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> LKPHNEKPDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0220", Offset = "0x7DBF420", VA = "0x187DC0220")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0DB0", Offset = "0x7DBFFB0", VA = "0x187DC0DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> EEJHCHHECOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0220", Offset = "0x7DBF420", VA = "0x187DC0220")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0DB0", Offset = "0x7DBFFB0", VA = "0x187DC0DB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> EFFNJMCNHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4330", Offset = "0x7DC3530", VA = "0x187DC4330")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x7DC48B0", Offset = "0x7DC3AB0", VA = "0x187DC48B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action MGIDKEKBIBC
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7DC41D0", Offset = "0x7DC33D0", VA = "0x187DC41D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4750", Offset = "0x7DC3950", VA = "0x187DC4750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4010", Offset = "0x7DC3210", VA = "0x187DC4010")]
		public static bool TryGetNetworkView(int NDLKHGHIICJ, [Out] RRNetworkView DMGGONLOPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFC90", Offset = "0x7DBEE90", VA = "0x187DBFC90")]
		public static RRNetworkView Find(int NDLKHGHIICJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFE30", Offset = "0x7DBF030", VA = "0x187DBFE30")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int OKKOLKBKJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFDC0", Offset = "0x7DBEFC0", VA = "0x187DBFDC0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1880", Offset = "0x7DC0A80", VA = "0x187DC1880")]
		public static bool RemoveNetworkView(RRNetworkView DMGGONLOPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1650", Offset = "0x7DC0850", VA = "0x187DC1650")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7DC10B0", Offset = "0x7DC02B0", VA = "0x187DC10B0")]
		public static void OnPlayerJoinedRoom(KPDBONCIMNC GHOGEGCBLDK, List<int> GFMFHBFGJEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFF70", Offset = "0x7DBF170", VA = "0x187DBFF70")]
		public static RRNetworkView Get(Component CBNJHLDNKAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFFD0", Offset = "0x7DBF1D0", VA = "0x187DBFFD0")]
		public static RRNetworkView Get(GameObject EFJIFHKGINM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7DC02D0", Offset = "0x7DBF4D0", VA = "0x187DC02D0")]
		private void ILFFEFPKAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF780", Offset = "0x7DBE980", VA = "0x187DBF780")]
		public bool CreatedBy(KPDBONCIMNC PNBFNEJFAPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3E20", Offset = "0x7DC3020", VA = "0x187DC3E20")]
		public void TransferOwnership(int CINCPAOIMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3DC0", Offset = "0x7DC2FC0", VA = "0x187DC3DC0")]
		public void TransferOwnership(KPDBONCIMNC FMILAEGCOGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0410", Offset = "0x7DBF610", VA = "0x187DC0410", Slot = "4")]
		public void Initialize(ViewId BHIKICEGEMH, ViewId EAKDKFBBGKE, Dictionary<int, object> IEEHHNMCCEB, MMNMPKDPAGK FNEFIOJLPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7DC03B0", Offset = "0x7DBF5B0", VA = "0x187DC03B0")]
		public void Initialize(ViewId BHIKICEGEMH, ViewId EAKDKFBBGKE, object[] KFAEEKKNEFG, MMNMPKDPAGK FNEFIOJLPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF370", Offset = "0x7DBE570", VA = "0x187DBF370")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7DC05F0", Offset = "0x7DBF7F0", VA = "0x187DC05F0")]
		private void KOFDKAJDDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1D8DDC0", Offset = "0x1D8CFC0", VA = "0x181D8DDC0")]
		internal void IINDOHLCBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFB30", Offset = "0x7DBED30", VA = "0x187DBFB30", Slot = "6")]
		private void EOJBMGFPHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0030", Offset = "0x7DBF230", VA = "0x187DC0030")]
		internal bool HGJMFBAPLMM(RRNetworkView FOABMPBBDPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0F10", Offset = "0x7DC0110", VA = "0x187DC0F10")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0590", Offset = "0x7DBF790", VA = "0x187DC0590")]
		internal void JNMGNJOACCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1400", Offset = "0x7DC0600", VA = "0x187DC1400")]
		private void PJAOABLHCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0CF0", Offset = "0x7DBFEF0", VA = "0x187DC0CF0")]
		internal void ODBMOBKGBCN(KPDBONCIMNC FMILAEGCOGK, int CINCPAOIMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7DC17E0", Offset = "0x7DC09E0", VA = "0x187DC17E0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1900", Offset = "0x7DC0B00", VA = "0x187DC1900")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFBF0", Offset = "0x7DBEDF0", VA = "0x187DBFBF0")]
		private void FCFMHOHIDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF800", Offset = "0x7DBEA00", VA = "0x187DBF800")]
		private void DDBGODPNHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1510", Offset = "0x7DC0710", VA = "0x187DC1510")]
		public void RPC(string DPGONDFGJJB, NJCHOGHPIEO PJNHLGGHCLG, params object[] MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7DC15B0", Offset = "0x7DC07B0", VA = "0x187DC15B0")]
		public void RPC(string DPGONDFGJJB, KPDBONCIMNC HMFALEOPEFK, params object[] MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1830", Offset = "0x7DC0A30", VA = "0x187DC1830")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF3D0", Offset = "0x7DBE5D0", VA = "0x187DBF3D0", Slot = "7")]
		public void Bake(IFLFAPHLPOC OPJOIGJBJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0140", Offset = "0x7DBF340", VA = "0x187DC0140")]
		private static void HONGKEPOIEK(KPDBONCIMNC MHLIPNBBNLC, [Out] HENKGHFDPIB MAGKLMEPFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC09D0", Offset = "0x7DBFBD0", VA = "0x187DC09D0")]
		private static void NNIJPIPJHMJ(RRNetworkView EADLIFECOGM, Delegate IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF440", Offset = "0x7DBE640", VA = "0x187DBF440")]
		private static IJHMLFCLBCG CIOMIIPJDML(RRNetworkView EADLIFECOGM)
		{
			return default(IJHMLFCLBCG);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC00A0", Offset = "0x7DBF2A0", VA = "0x187DC00A0")]
		private static KGOHIKKMGMD HGLIHGCHHEN(RRNetworkView EADLIFECOGM)
		{
			return default(KGOHIKKMGMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFA50", Offset = "0x7DBEC50", VA = "0x187DBFA50")]
		private static void DEFCDHPPHJA(RRNetworkView EADLIFECOGM, Delegate IPBOIENDBHP, KPDBONCIMNC MDLIOPAJPPH, params object[] MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF8F0", Offset = "0x7DBEAF0", VA = "0x187DBF8F0")]
		private static void DEFCDHPPHJA(RRNetworkView EADLIFECOGM, Delegate IPBOIENDBHP, NJCHOGHPIEO MDLIOPAJPPH, params object[] MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF9D0", Offset = "0x7DBEBD0", VA = "0x187DBF9D0")]
		private static void DEFCDHPPHJA(RRNetworkView EADLIFECOGM, Delegate IPBOIENDBHP, HENKGHFDPIB MDLIOPAJPPH, params object[] MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7DC07E0", Offset = "0x7DBF9E0", VA = "0x187DC07E0")]
		private static void LGEPDMCBEJH(RRNetworkView EADLIFECOGM, Delegate IPBOIENDBHP, NJCHOGHPIEO MDLIOPAJPPH, MNIEHAIJFAP GLBIMDFCCIJ, params object[] MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1410", Offset = "0x7DC0610", VA = "0x187DC1410")]
		public void RPCBuffered(string DPGONDFGJJB, NJCHOGHPIEO PJNHLGGHCLG, MNIEHAIJFAP OCICPKKEFHG, params object[] MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFD20", Offset = "0x7DBEF20", VA = "0x187DBFD20")]
		private static bool GFPJIJOIOBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2370", Offset = "0x7DC1570", VA = "0x187DC2370", Slot = "24")]
		public void RpcAll(OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3090", Offset = "0x3AE2290", VA = "0x183AE3090", Slot = "8")]
		public void RpcAll<T1>(OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3AE28C0", Offset = "0x3AE1AC0", VA = "0x183AE28C0", Slot = "9")]
		public void RpcAll<T1, T2>(OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4DA0", Offset = "0x3AE3FA0", VA = "0x183AE4DA0", Slot = "25")]
		public void RpcAll<T1, T2, T3>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2AF0", Offset = "0x3AE1CF0", VA = "0x183AE2AF0", Slot = "26")]
		public void RpcAll<T1, T2, T3, T4>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4740", Offset = "0x3AE3940", VA = "0x183AE4740", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4, T5>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE52B0", Offset = "0x3AE44B0", VA = "0x183AE52B0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4E10", Offset = "0x3AF4010", VA = "0x183AF4E10", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA440", Offset = "0x3AE9640", VA = "0x183AEA440", Slot = "10")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5760", Offset = "0x3AE4960", VA = "0x183AE5760", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3B10", Offset = "0x3AE2D10", VA = "0x183AE3B10", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1300", Offset = "0x3AF0500", VA = "0x183AF1300", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0810", Offset = "0x3AEFA10", VA = "0x183AF0810", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEA00", Offset = "0x3AEDC00", VA = "0x183AEEA00", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3230", Offset = "0x3AE2430", VA = "0x183AE3230", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7DC21B0", Offset = "0x7DC13B0", VA = "0x187DC21B0")]
		public void RpcAll(OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7970", Offset = "0x3AE6B70", VA = "0x183AE7970")]
		public void RpcAll<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3AE85B0", Offset = "0x3AE77B0", VA = "0x183AE85B0")]
		public void RpcAll<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4410", Offset = "0x3AE3610", VA = "0x183AE4410")]
		public void RpcAll<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6A20", Offset = "0x3AF5C20", VA = "0x183AF6A20")]
		public void RpcAll<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5EA0", Offset = "0x3AF50A0", VA = "0x183AF5EA0")]
		public void RpcAll<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3AF51A0", Offset = "0x3AF43A0", VA = "0x183AF51A0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4A30", Offset = "0x3AF3C30", VA = "0x183AF4A30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4210", Offset = "0x3AF3410", VA = "0x183AF4210")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3540", Offset = "0x3AF2740", VA = "0x183AF3540")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2290", Offset = "0x3AF1490", VA = "0x183AF2290")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1820", Offset = "0x3AF0A20", VA = "0x183AF1820")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0240", Offset = "0x3AEF440", VA = "0x183AF0240")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEFF0", Offset = "0x3AEE1F0", VA = "0x183AEEFF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDCF0", Offset = "0x3AECEF0", VA = "0x183AEDCF0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1F80", Offset = "0x7DC1180", VA = "0x187DC1F80", Slot = "35")]
		public void RpcAll(OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3AFAFA0", Offset = "0x3AFA1A0", VA = "0x183AFAFA0", Slot = "36")]
		public void RpcAll<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8B50", Offset = "0x3AF7D50", VA = "0x183AF8B50", Slot = "37")]
		public void RpcAll<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7790", Offset = "0x3AF6990", VA = "0x183AF7790", Slot = "38")]
		public void RpcAll<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3AF64E0", Offset = "0x3AF56E0", VA = "0x183AF64E0", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3AF61C0", Offset = "0x3AF53C0", VA = "0x183AF61C0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5520", Offset = "0x3AF4720", VA = "0x183AF5520", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4650", Offset = "0x3AF3850", VA = "0x183AF4650", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF39E0", Offset = "0x3AF2BE0", VA = "0x183AF39E0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF30A0", Offset = "0x3AF22A0", VA = "0x183AF30A0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1D90", Offset = "0x3AF0F90", VA = "0x183AF1D90", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0D90", Offset = "0x3AEFF90", VA = "0x183AF0D90", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFC70", Offset = "0x3AEEE70", VA = "0x183AEFC70", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF630", Offset = "0x3AEE830", VA = "0x183AEF630", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3AED640", Offset = "0x3AEC840", VA = "0x183AED640", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1BF0", Offset = "0x7DC0DF0", VA = "0x187DC1BF0", Slot = "50")]
		public void RpcAllViaServer(OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3B09E30", Offset = "0x3B09030", VA = "0x183B09E30", Slot = "51")]
		public void RpcAllViaServer<T1>(OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3B01B80", Offset = "0x3B00D80", VA = "0x183B01B80", Slot = "12")]
		public void RpcAllViaServer<T1, T2>(OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3B09660", Offset = "0x3B08860", VA = "0x183B09660", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3B09100", Offset = "0x3B08300", VA = "0x183B09100", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3B08860", Offset = "0x3B07A60", VA = "0x183B08860", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3B080F0", Offset = "0x3B072F0", VA = "0x183B080F0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3B078A0", Offset = "0x3B06AA0", VA = "0x183B078A0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B07290", Offset = "0x3B06490", VA = "0x183B07290", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3B061B0", Offset = "0x3B053B0", VA = "0x183B061B0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3B05640", Offset = "0x3B04840", VA = "0x183B05640", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3B04E00", Offset = "0x3B04000", VA = "0x183B04E00", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3B04100", Offset = "0x3B03300", VA = "0x183B04100", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3B037D0", Offset = "0x3B029D0", VA = "0x183B037D0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3B02410", Offset = "0x3B01610", VA = "0x183B02410", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1E50", Offset = "0x7DC1050", VA = "0x187DC1E50")]
		public void RpcAllViaServer(OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3B09C30", Offset = "0x3B08E30", VA = "0x183B09C30")]
		public void RpcAllViaServer<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3B09AD0", Offset = "0x3B08CD0", VA = "0x183B09AD0")]
		public void RpcAllViaServer<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3B09300", Offset = "0x3B08500", VA = "0x183B09300")]
		public void RpcAllViaServer<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3B08D00", Offset = "0x3B07F00", VA = "0x183B08D00")]
		public void RpcAllViaServer<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3B08AB0", Offset = "0x3B07CB0", VA = "0x183B08AB0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3B07E60", Offset = "0x3B07060", VA = "0x183B07E60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3B075C0", Offset = "0x3B067C0", VA = "0x183B075C0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3B06F60", Offset = "0x3B06160", VA = "0x183B06F60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3B06530", Offset = "0x3B05730", VA = "0x183B06530")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3B05DE0", Offset = "0x3B04FE0", VA = "0x183B05DE0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3B049E0", Offset = "0x3B03BE0", VA = "0x183B049E0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3B04570", Offset = "0x3B03770", VA = "0x183B04570")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3B03310", Offset = "0x3B02510", VA = "0x183B03310")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3B01EF0", Offset = "0x3B010F0", VA = "0x183B01EF0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1D20", Offset = "0x7DC0F20", VA = "0x187DC1D20", Slot = "64")]
		public void RpcAllViaServer(OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B09D30", Offset = "0x3B08F30", VA = "0x183B09D30", Slot = "65")]
		public void RpcAllViaServer<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B09970", Offset = "0x3B08B70", VA = "0x183B09970", Slot = "66")]
		public void RpcAllViaServer<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B094B0", Offset = "0x3B086B0", VA = "0x183B094B0", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B08F00", Offset = "0x3B08100", VA = "0x183B08F00", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B08610", Offset = "0x3B07810", VA = "0x183B08610", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B08380", Offset = "0x3B07580", VA = "0x183B08380", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B07B80", Offset = "0x3B06D80", VA = "0x183B07B80", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B06C30", Offset = "0x3B05E30", VA = "0x183B06C30", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3B068B0", Offset = "0x3B05AB0", VA = "0x183B068B0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3B05A10", Offset = "0x3B04C10", VA = "0x183B05A10", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3B05220", Offset = "0x3B04420", VA = "0x183B05220", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B03C90", Offset = "0x3B02E90", VA = "0x183B03C90", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B02E50", Offset = "0x3B02050", VA = "0x183B02E50", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3B02930", Offset = "0x3B01B30", VA = "0x183B02930", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DC33D0", Offset = "0x7DC25D0", VA = "0x187DC33D0", Slot = "79")]
		public void RpcOthers(OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B2EB40", Offset = "0x3B2DD40", VA = "0x183B2EB40", Slot = "13")]
		public void RpcOthers<T1>(OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3B2F3F0", Offset = "0x3B2E5F0", VA = "0x183B2F3F0", Slot = "80")]
		public void RpcOthers<T1, T2>(OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B2E8C0", Offset = "0x3B2DAC0", VA = "0x183B2E8C0", Slot = "81")]
		public void RpcOthers<T1, T2, T3>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3B32800", Offset = "0x3B31A00", VA = "0x183B32800", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B30150", Offset = "0x3B2F350", VA = "0x183B30150", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B31B30", Offset = "0x3B30D30", VA = "0x183B31B30", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B31250", Offset = "0x3B30450", VA = "0x183B31250", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B417E0", Offset = "0x3B409E0", VA = "0x183B417E0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B40CD0", Offset = "0x3B3FED0", VA = "0x183B40CD0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3B408E0", Offset = "0x3B3FAE0", VA = "0x183B408E0", Slot = "14")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B3F440", Offset = "0x3B3E640", VA = "0x183B3F440", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B3EB20", Offset = "0x3B3DD20", VA = "0x183B3EB20", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B3D7C0", Offset = "0x3B3C9C0", VA = "0x183B3D7C0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3B3CD40", Offset = "0x3B3BF40", VA = "0x183B3CD40", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3280", Offset = "0x7DC2480", VA = "0x187DC3280")]
		public void RpcOthers(OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3B2F150", Offset = "0x3B2E350", VA = "0x183B2F150")]
		public void RpcOthers<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3B2EF70", Offset = "0x3B2E170", VA = "0x183B2EF70")]
		public void RpcOthers<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B32E60", Offset = "0x3B32060", VA = "0x183B32E60")]
		public void RpcOthers<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3B2EC90", Offset = "0x3B2DE90", VA = "0x183B2EC90")]
		public void RpcOthers<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3B2F8E0", Offset = "0x3B2EAE0", VA = "0x183B2F8E0")]
		public void RpcOthers<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FC20", Offset = "0x3B2EE20", VA = "0x183B2FC20")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3B30F40", Offset = "0x3B30140", VA = "0x183B30F40")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B30BE0", Offset = "0x3B2FDE0", VA = "0x183B30BE0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B41430", Offset = "0x3B40630", VA = "0x183B41430")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B40100", Offset = "0x3B3F300", VA = "0x183B40100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B3FCC0", Offset = "0x3B3EEC0", VA = "0x183B3FCC0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B3E690", Offset = "0x3B3D890", VA = "0x183B3E690")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B3DCB0", Offset = "0x3B3CEB0", VA = "0x183B3DCB0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B3D280", Offset = "0x3B3C480", VA = "0x183B3D280")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3520", Offset = "0x7DC2720", VA = "0x187DC3520", Slot = "92")]
		public void RpcOthers(OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3B33E70", Offset = "0x3B33070", VA = "0x183B33E70", Slot = "93")]
		public void RpcOthers<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B338D0", Offset = "0x3B32AD0", VA = "0x183B338D0", Slot = "94")]
		public void RpcOthers<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B33200", Offset = "0x3B32400", VA = "0x183B33200", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3B32C40", Offset = "0x3B31E40", VA = "0x183B32C40", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3B32590", Offset = "0x3B31790", VA = "0x183B32590", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3B31870", Offset = "0x3B30A70", VA = "0x183B31870", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3B31560", Offset = "0x3B30760", VA = "0x183B31560", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3B30880", Offset = "0x3B2FA80", VA = "0x183B30880", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3B41080", Offset = "0x3B40280", VA = "0x183B41080", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B404F0", Offset = "0x3B3F6F0", VA = "0x183B404F0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3B3F880", Offset = "0x3B3EA80", VA = "0x183B3F880", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B3EFB0", Offset = "0x3B3E1B0", VA = "0x183B3EFB0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B3E1A0", Offset = "0x3B3D3A0", VA = "0x183B3E1A0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C800", Offset = "0x3B3BA00", VA = "0x183B3C800", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2AF0", Offset = "0x7DC1CF0", VA = "0x187DC2AF0", Slot = "107")]
		public void RpcMaster(OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A890", Offset = "0x3B19A90", VA = "0x183B1A890", Slot = "108")]
		public void RpcMaster<T1>(OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B1AC60", Offset = "0x3B19E60", VA = "0x183B1AC60", Slot = "15")]
		public void RpcMaster<T1, T2>(OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A5B0", Offset = "0x3B197B0", VA = "0x183B1A5B0", Slot = "109")]
		public void RpcMaster<T1, T2, T3>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A240", Offset = "0x3B19440", VA = "0x183B1A240", Slot = "110")]
		public void RpcMaster<T1, T2, T3, T4>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E4B0", Offset = "0x3B1D6B0", VA = "0x183B1E4B0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4, T5>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3B209F0", Offset = "0x3B1FBF0", VA = "0x183B209F0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3B296A0", Offset = "0x3B288A0", VA = "0x183B296A0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3B285F0", Offset = "0x3B277F0", VA = "0x183B285F0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3B27D10", Offset = "0x3B26F10", VA = "0x183B27D10", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DC50", Offset = "0x3B1CE50", VA = "0x183B1DC50", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C800", Offset = "0x3B1BA00", VA = "0x183B1C800", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3B242C0", Offset = "0x3B234C0", VA = "0x183B242C0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3B23680", Offset = "0x3B22880", VA = "0x183B23680", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B22320", Offset = "0x3B21520", VA = "0x183B22320", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2C80", Offset = "0x7DC1E80", VA = "0x187DC2C80")]
		public void RpcMaster(OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3B1AA50", Offset = "0x3B19C50", VA = "0x183B1AA50")]
		public void RpcMaster<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B760", Offset = "0x3B1A960", VA = "0x183B1B760")]
		public void RpcMaster<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3B1AEC0", Offset = "0x3B1A0C0", VA = "0x183B1AEC0")]
		public void RpcMaster<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AEA0", Offset = "0x3B2A0A0", VA = "0x183B2AEA0")]
		public void RpcMaster<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3B1EF60", Offset = "0x3B1E160", VA = "0x183B1EF60")]
		public void RpcMaster<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3B29E10", Offset = "0x3B29010", VA = "0x183B29E10")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3B29290", Offset = "0x3B28490", VA = "0x183B29290")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3B28180", Offset = "0x3B27380", VA = "0x183B28180")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3B27840", Offset = "0x3B26A40", VA = "0x183B27840")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3B26E40", Offset = "0x3B26040", VA = "0x183B26E40")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3B25410", Offset = "0x3B24610", VA = "0x183B25410")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3B24850", Offset = "0x3B23A50", VA = "0x183B24850")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B23C70", Offset = "0x3B22E70", VA = "0x183B23C70")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3B21C70", Offset = "0x3B20E70", VA = "0x183B21C70")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2E60", Offset = "0x7DC2060", VA = "0x187DC2E60", Slot = "121")]
		public void RpcMaster(OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3B2DD40", Offset = "0x3B2CF40", VA = "0x183B2DD40", Slot = "122")]
		public void RpcMaster<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3B2CF20", Offset = "0x3B2C120", VA = "0x183B2CF20", Slot = "123")]
		public void RpcMaster<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3B2BBF0", Offset = "0x3B2ADF0", VA = "0x183B2BBF0", Slot = "124")]
		public void RpcMaster<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B1A0", Offset = "0x3B2A3A0", VA = "0x183B2B1A0", Slot = "125")]
		public void RpcMaster<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AB50", Offset = "0x3B29D50", VA = "0x183B2AB50", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B29A60", Offset = "0x3B28C60", VA = "0x183B29A60", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3B28E80", Offset = "0x3B28080", VA = "0x183B28E80", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3B28A10", Offset = "0x3B27C10", VA = "0x183B28A10", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3B27370", Offset = "0x3B26570", VA = "0x183B27370", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3B26440", Offset = "0x3B25640", VA = "0x183B26440", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3B25990", Offset = "0x3B24B90", VA = "0x183B25990", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3B24E30", Offset = "0x3B24030", VA = "0x183B24E30", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3B23030", Offset = "0x3B22230", VA = "0x183B23030", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3B22980", Offset = "0x3B21B80", VA = "0x183B22980", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7DC26E0", Offset = "0x7DC18E0", VA = "0x187DC26E0", Slot = "136")]
		public void RpcAuthority(OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3B0AA70", Offset = "0x3B09C70", VA = "0x183B0AA70", Slot = "137")]
		public void RpcAuthority<T1>(OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3B0BAE0", Offset = "0x3B0ACE0", VA = "0x183B0BAE0", Slot = "138")]
		public void RpcAuthority<T1, T2>(OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3B0BF40", Offset = "0x3B0B140", VA = "0x183B0BF40", Slot = "139")]
		public void RpcAuthority<T1, T2, T3>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B790", Offset = "0x3B0A990", VA = "0x183B0B790", Slot = "140")]
		public void RpcAuthority<T1, T2, T3, T4>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3B09F30", Offset = "0x3B09130", VA = "0x183B09F30", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3B14B60", Offset = "0x3B13D60", VA = "0x183B14B60", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3B143D0", Offset = "0x3B135D0", VA = "0x183B143D0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3B13760", Offset = "0x3B12960", VA = "0x183B13760", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3B12010", Offset = "0x3B11210", VA = "0x183B12010", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3B110A0", Offset = "0x3B102A0", VA = "0x183B110A0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3B105D0", Offset = "0x3B0F7D0", VA = "0x183B105D0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A350", Offset = "0x3B09550", VA = "0x183B0A350", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DBD0", Offset = "0x3B0CDD0", VA = "0x183B0DBD0", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3B0C7E0", Offset = "0x3B0B9E0", VA = "0x183B0C7E0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7DC24E0", Offset = "0x7DC16E0", VA = "0x187DC24E0")]
		public void RpcAuthority(OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3B183D0", Offset = "0x3B175D0", VA = "0x183B183D0")]
		public void RpcAuthority<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3B16F70", Offset = "0x3B16170", VA = "0x183B16F70")]
		public void RpcAuthority<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3B16A40", Offset = "0x3B15C40", VA = "0x183B16A40")]
		public void RpcAuthority<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3B15C80", Offset = "0x3B14E80", VA = "0x183B15C80")]
		public void RpcAuthority<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3B15290", Offset = "0x3B14490", VA = "0x183B15290")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3B14ED0", Offset = "0x3B140D0", VA = "0x183B14ED0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3B13FB0", Offset = "0x3B131B0", VA = "0x183B13FB0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3B132E0", Offset = "0x3B124E0", VA = "0x183B132E0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3B12980", Offset = "0x3B11B80", VA = "0x183B12980")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3B11590", Offset = "0x3B10790", VA = "0x183B11590")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3B10B10", Offset = "0x3B0FD10", VA = "0x183B10B10")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F440", Offset = "0x3B0E640", VA = "0x183B0F440")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E840", Offset = "0x3B0DA40", VA = "0x183B0E840")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3B0CE50", Offset = "0x3B0C050", VA = "0x183B0CE50")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2890", Offset = "0x7DC1A90", VA = "0x187DC2890", Slot = "151")]
		public void RpcAuthority(OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3B185B0", Offset = "0x3B177B0", VA = "0x183B185B0", Slot = "152")]
		public void RpcAuthority<T1>(OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3B171B0", Offset = "0x3B163B0", VA = "0x183B171B0", Slot = "153")]
		public void RpcAuthority<T1, T2>(OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3B16550", Offset = "0x3B15750", VA = "0x183B16550", Slot = "154")]
		public void RpcAuthority<T1, T2, T3>(OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3B15F90", Offset = "0x3B15190", VA = "0x183B15F90", Slot = "155")]
		public void RpcAuthority<T1, T2, T3, T4>(OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3B15600", Offset = "0x3B14800", VA = "0x183B15600", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3B147A0", Offset = "0x3B139A0", VA = "0x183B147A0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3B13B90", Offset = "0x3B12D90", VA = "0x183B13B90", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3B12E60", Offset = "0x3B12060", VA = "0x183B12E60", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3B124A0", Offset = "0x3B116A0", VA = "0x183B124A0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3B11AD0", Offset = "0x3B10CD0", VA = "0x183B11AD0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3B10040", Offset = "0x3B0F240", VA = "0x183B10040", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FA40", Offset = "0x3B0EC40", VA = "0x183B0FA40", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E1E0", Offset = "0x3B0D3E0", VA = "0x183B0E1E0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D510", Offset = "0x3B0C710", VA = "0x183B0D510", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3BB0", Offset = "0x7DC2DB0", VA = "0x187DC3BB0", Slot = "16")]
		public void RpcPlayer(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3B424E0", Offset = "0x3B416E0", VA = "0x183B424E0", Slot = "17")]
		public void RpcPlayer<T1>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3B43280", Offset = "0x3B42480", VA = "0x183B43280", Slot = "18")]
		public void RpcPlayer<T1, T2>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3B42C90", Offset = "0x3B41E90", VA = "0x183B42C90", Slot = "19")]
		public void RpcPlayer<T1, T2, T3>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3B426B0", Offset = "0x3B418B0", VA = "0x183B426B0", Slot = "20")]
		public void RpcPlayer<T1, T2, T3, T4>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3B47040", Offset = "0x3B46240", VA = "0x183B47040", Slot = "166")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3B46BD0", Offset = "0x3B45DD0", VA = "0x183B46BD0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3B47430", Offset = "0x3B46630", VA = "0x183B47430", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3B47900", Offset = "0x3B46B00", VA = "0x183B47900", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3B4FFB0", Offset = "0x3B4F1B0", VA = "0x183B4FFB0", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3B4EB20", Offset = "0x3B4DD20", VA = "0x183B4EB20", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KPDBONCIMNC PNBFNEJFAPC, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3B43B70", Offset = "0x3B42D70", VA = "0x183B43B70", Slot = "21")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KPDBONCIMNC PNBFNEJFAPC, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3B4D4C0", Offset = "0x3B4C6C0", VA = "0x183B4D4C0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KPDBONCIMNC PNBFNEJFAPC, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3B4BC10", Offset = "0x3B4AE10", VA = "0x183B4BC10", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KPDBONCIMNC PNBFNEJFAPC, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A850", Offset = "0x3B49A50", VA = "0x183B4A850", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KPDBONCIMNC PNBFNEJFAPC, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3670", Offset = "0x7DC2870", VA = "0x187DC3670")]
		public void RpcPlayer(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3B42A60", Offset = "0x3B41C60", VA = "0x183B42A60")]
		public void RpcPlayer<T1>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3B49890", Offset = "0x3B48A90", VA = "0x183B49890")]
		public void RpcPlayer<T1, T2>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3B540F0", Offset = "0x3B532F0", VA = "0x183B540F0")]
		public void RpcPlayer<T1, T2, T3>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3B53800", Offset = "0x3B52A00", VA = "0x183B53800")]
		public void RpcPlayer<T1, T2, T3, T4>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3B53100", Offset = "0x3B52300", VA = "0x183B53100")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3B52A10", Offset = "0x3B51C10", VA = "0x183B52A10")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3B51A60", Offset = "0x3B50C60", VA = "0x183B51A60")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3B51200", Offset = "0x3B50400", VA = "0x183B51200")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3B50450", Offset = "0x3B4F650", VA = "0x183B50450")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KPDBONCIMNC PNBFNEJFAPC, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3B4F020", Offset = "0x3B4E220", VA = "0x183B4F020")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KPDBONCIMNC PNBFNEJFAPC, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3B4E020", Offset = "0x3B4D220", VA = "0x183B4E020")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KPDBONCIMNC PNBFNEJFAPC, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3B4CEB0", Offset = "0x3B4C0B0", VA = "0x183B4CEB0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KPDBONCIMNC PNBFNEJFAPC, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B5A0", Offset = "0x3B4A7A0", VA = "0x183B4B5A0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KPDBONCIMNC PNBFNEJFAPC, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3B4AED0", Offset = "0x3B4A0D0", VA = "0x183B4AED0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KPDBONCIMNC PNBFNEJFAPC, MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7DC38E0", Offset = "0x7DC2AE0", VA = "0x187DC38E0", Slot = "175")]
		public void RpcPlayer(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3B45970", Offset = "0x3B44B70", VA = "0x183B45970", Slot = "176")]
		public void RpcPlayer<T1>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3B43880", Offset = "0x3B42A80", VA = "0x183B43880", Slot = "22")]
		public void RpcPlayer<T1, T2>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3B43500", Offset = "0x3B42700", VA = "0x183B43500", Slot = "23")]
		public void RpcPlayer<T1, T2, T3>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3B453B0", Offset = "0x3B445B0", VA = "0x183B453B0", Slot = "177")]
		public void RpcPlayer<T1, T2, T3, T4>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3B53480", Offset = "0x3B52680", VA = "0x183B53480", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3B522C0", Offset = "0x3B514C0", VA = "0x183B522C0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3B51E90", Offset = "0x3B51090", VA = "0x183B51E90", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3B50D70", Offset = "0x3B4FF70", VA = "0x183B50D70", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(KPDBONCIMNC PNBFNEJFAPC, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3B4FAC0", Offset = "0x3B4ECC0", VA = "0x183B4FAC0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KPDBONCIMNC PNBFNEJFAPC, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3B4F570", Offset = "0x3B4E770", VA = "0x183B4F570", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KPDBONCIMNC PNBFNEJFAPC, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3B4DA70", Offset = "0x3B4CC70", VA = "0x183B4DA70", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KPDBONCIMNC PNBFNEJFAPC, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C8A0", Offset = "0x3B4BAA0", VA = "0x183B4C8A0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KPDBONCIMNC PNBFNEJFAPC, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C230", Offset = "0x3B4B430", VA = "0x183B4C230", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KPDBONCIMNC PNBFNEJFAPC, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A180", Offset = "0x3B49380", VA = "0x183B4A180", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KPDBONCIMNC PNBFNEJFAPC, MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1A10", Offset = "0x7DC0C10", VA = "0x187DC1A10", Slot = "188")]
		public void RpcAllBuffered(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3AE27A0", Offset = "0x3AE19A0", VA = "0x183AE27A0", Slot = "189")]
		public void RpcAllBuffered<T1>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2280", Offset = "0x3AE1480", VA = "0x183AE2280", Slot = "190")]
		public void RpcAllBuffered<T1, T2>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1F50", Offset = "0x3AE1150", VA = "0x183AE1F50", Slot = "191")]
		public void RpcAllBuffered<T1, T2, T3>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3AE15A0", Offset = "0x3AE07A0", VA = "0x183AE15A0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0EB0", Offset = "0x3AE00B0", VA = "0x183AE0EB0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0970", Offset = "0x3ADFB70", VA = "0x183AE0970", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3AE03E0", Offset = "0x3ADF5E0", VA = "0x183AE03E0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF780", Offset = "0x3ADE980", VA = "0x183ADF780", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF0B0", Offset = "0x3ADE2B0", VA = "0x183ADF0B0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3B017A0", Offset = "0x3B009A0", VA = "0x183B017A0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNIEHAIJFAP OCICPKKEFHG, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3B00F40", Offset = "0x3B00140", VA = "0x183B00F40", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNIEHAIJFAP OCICPKKEFHG, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFD90", Offset = "0x3AFEF90", VA = "0x183AFFD90", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNIEHAIJFAP OCICPKKEFHG, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF3F0", Offset = "0x3AFE5F0", VA = "0x183AFF3F0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNIEHAIJFAP OCICPKKEFHG, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3AFDFC0", Offset = "0x3AFD1C0", VA = "0x183AFDFC0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNIEHAIJFAP OCICPKKEFHG, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1AB0", Offset = "0x7DC0CB0", VA = "0x187DC1AB0")]
		public void RpcAllBuffered(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2560", Offset = "0x3AE1760", VA = "0x183AE2560")]
		public void RpcAllBuffered<T1>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2110", Offset = "0x3AE1310", VA = "0x183AE2110")]
		public void RpcAllBuffered<T1, T2>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1D90", Offset = "0x3AE0F90", VA = "0x183AE1D90")]
		public void RpcAllBuffered<T1, T2, T3>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3AE19C0", Offset = "0x3AE0BC0", VA = "0x183AE19C0")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1350", Offset = "0x3AE0550", VA = "0x183AE1350")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3AE06D0", Offset = "0x3ADF8D0", VA = "0x183AE06D0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3AE00F0", Offset = "0x3ADF2F0", VA = "0x183AE00F0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF440", Offset = "0x3ADE640", VA = "0x183ADF440")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADED20", Offset = "0x3ADDF20", VA = "0x183ADED20")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNIEHAIJFAP OCICPKKEFHG, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE1D0", Offset = "0x3ADD3D0", VA = "0x183ADE1D0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNIEHAIJFAP OCICPKKEFHG, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3B00B10", Offset = "0x3AFFD10", VA = "0x183B00B10")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNIEHAIJFAP OCICPKKEFHG, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3B00210", Offset = "0x3AFF410", VA = "0x183B00210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNIEHAIJFAP OCICPKKEFHG, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEF20", Offset = "0x3AFE120", VA = "0x183AFEF20")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNIEHAIJFAP OCICPKKEFHG, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE4E0", Offset = "0x3AFD6E0", VA = "0x183AFE4E0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNIEHAIJFAP OCICPKKEFHG, MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1B50", Offset = "0x7DC0D50", VA = "0x187DC1B50", Slot = "203")]
		public void RpcAllBuffered(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2680", Offset = "0x3AE1880", VA = "0x183AE2680", Slot = "204")]
		public void RpcAllBuffered<T1>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3AE23F0", Offset = "0x3AE15F0", VA = "0x183AE23F0", Slot = "205")]
		public void RpcAllBuffered<T1, T2>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1BD0", Offset = "0x3AE0DD0", VA = "0x183AE1BD0", Slot = "206")]
		public void RpcAllBuffered<T1, T2, T3>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3AE17B0", Offset = "0x3AE09B0", VA = "0x183AE17B0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1100", Offset = "0x3AE0300", VA = "0x183AE1100", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0C10", Offset = "0x3ADFE10", VA = "0x183AE0C10", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFE00", Offset = "0x3ADF000", VA = "0x183ADFE00", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFAC0", Offset = "0x3ADECC0", VA = "0x183ADFAC0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE990", Offset = "0x3ADDB90", VA = "0x183ADE990", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNIEHAIJFAP OCICPKKEFHG, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE5B0", Offset = "0x3ADD7B0", VA = "0x183ADE5B0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNIEHAIJFAP OCICPKKEFHG, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3B01370", Offset = "0x3B00570", VA = "0x183B01370", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNIEHAIJFAP OCICPKKEFHG, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3B00690", Offset = "0x3AFF890", VA = "0x183B00690", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNIEHAIJFAP OCICPKKEFHG, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF8C0", Offset = "0x3AFEAC0", VA = "0x183AFF8C0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNIEHAIJFAP OCICPKKEFHG, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEA00", Offset = "0x3AFDC00", VA = "0x183AFEA00", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNIEHAIJFAP OCICPKKEFHG, MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3140", Offset = "0x7DC2340", VA = "0x187DC3140", Slot = "218")]
		public void RpcOthersBuffered(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.KKFBDIPBCEH IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C6E0", Offset = "0x3B3B8E0", VA = "0x183B3C6E0", Slot = "219")]
		public void RpcOthersBuffered<T1>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.HIKMEKKILML<T1> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C330", Offset = "0x3B3B530", VA = "0x183B3C330", Slot = "220")]
		public void RpcOthersBuffered<T1, T2>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.NBOEKBECLPI<T1, T2> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3B3BCD0", Offset = "0x3B3AED0", VA = "0x183B3BCD0", Slot = "221")]
		public void RpcOthersBuffered<T1, T2, T3>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, T3> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3B3B900", Offset = "0x3B3AB00", VA = "0x183B3B900", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, T4> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3B3B040", Offset = "0x3B3A240", VA = "0x183B3B040", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, T5> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A8B0", Offset = "0x3B39AB0", VA = "0x183B3A8B0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, T6> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3B39D40", Offset = "0x3B38F40", VA = "0x183B39D40", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, T7> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3B39A00", Offset = "0x3B38C00", VA = "0x183B39A00", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, T8> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3B38C60", Offset = "0x3B37E60", VA = "0x183B38C60", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, T9> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3B384F0", Offset = "0x3B376F0", VA = "0x183B384F0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNIEHAIJFAP OCICPKKEFHG, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3B374D0", Offset = "0x3B366D0", VA = "0x183B374D0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNIEHAIJFAP OCICPKKEFHG, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3B367A0", Offset = "0x3B359A0", VA = "0x183B367A0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNIEHAIJFAP OCICPKKEFHG, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3B35E50", Offset = "0x3B35050", VA = "0x183B35E50", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNIEHAIJFAP OCICPKKEFHG, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3B34F90", Offset = "0x3B34190", VA = "0x183B34F90", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNIEHAIJFAP OCICPKKEFHG, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC30A0", Offset = "0x7DC22A0", VA = "0x187DC30A0")]
		public void RpcOthersBuffered(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.HIKMEKKILML<IJHMLFCLBCG> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C4A0", Offset = "0x3B3B6A0", VA = "0x183B3C4A0")]
		public void RpcOthersBuffered<T1>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.NBOEKBECLPI<T1, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C1C0", Offset = "0x3B3B3C0", VA = "0x183B3C1C0")]
		public void RpcOthersBuffered<T1, T2>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B3BE90", Offset = "0x3B3B090", VA = "0x183B3BE90")]
		public void RpcOthersBuffered<T1, T2, T3>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B3B6F0", Offset = "0x3B3A8F0", VA = "0x183B3B6F0")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B3ADF0", Offset = "0x3B39FF0", VA = "0x183B3ADF0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A610", Offset = "0x3B39810", VA = "0x183B3A610")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A320", Offset = "0x3B39520", VA = "0x183B3A320")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B396C0", Offset = "0x3B388C0", VA = "0x183B396C0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, IJHMLFCLBCG> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B38FF0", Offset = "0x3B381F0", VA = "0x183B38FF0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNIEHAIJFAP OCICPKKEFHG, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3B37D30", Offset = "0x3B36F30", VA = "0x183B37D30")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNIEHAIJFAP OCICPKKEFHG, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3B37900", Offset = "0x3B36B00", VA = "0x183B37900")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNIEHAIJFAP OCICPKKEFHG, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3B36C20", Offset = "0x3B35E20", VA = "0x183B36C20")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNIEHAIJFAP OCICPKKEFHG, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B354B0", Offset = "0x3B346B0", VA = "0x183B354B0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNIEHAIJFAP OCICPKKEFHG, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B34550", Offset = "0x3B33750", VA = "0x183B34550")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNIEHAIJFAP OCICPKKEFHG, MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DC31E0", Offset = "0x7DC23E0", VA = "0x187DC31E0", Slot = "233")]
		public void RpcOthersBuffered(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.HIKMEKKILML<KGOHIKKMGMD> IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C5C0", Offset = "0x3B3B7C0", VA = "0x183B3C5C0", Slot = "234")]
		public void RpcOthersBuffered<T1>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.NBOEKBECLPI<T1, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B3C050", Offset = "0x3B3B250", VA = "0x183B3C050", Slot = "235")]
		public void RpcOthersBuffered<T1, T2>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.AFJEPLFPHFH<T1, T2, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3B3BB10", Offset = "0x3B3AD10", VA = "0x183B3BB10", Slot = "236")]
		public void RpcOthersBuffered<T1, T2, T3>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.MIEHILLFOHK<T1, T2, T3, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B3B4E0", Offset = "0x3B3A6E0", VA = "0x183B3B4E0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.FJALDAFAIND<T1, T2, T3, T4, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3B3B290", Offset = "0x3B3A490", VA = "0x183B3B290", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BFDDCGIOFLE<T1, T2, T3, T4, T5, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B3AB50", Offset = "0x3B39D50", VA = "0x183B3AB50", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.PCDOAAAJGEN<T1, T2, T3, T4, T5, T6, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A030", Offset = "0x3B39230", VA = "0x183B3A030", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.OHLEPBMIMOP<T1, T2, T3, T4, T5, T6, T7, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B39380", Offset = "0x3B38580", VA = "0x183B39380", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MNIEHAIJFAP OCICPKKEFHG, OLOFHBBBFBF.BJKDOHJAGFD<T1, T2, T3, T4, T5, T6, T7, T8, KGOHIKKMGMD> IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B388D0", Offset = "0x3B37AD0", VA = "0x183B388D0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MNIEHAIJFAP OCICPKKEFHG, NIAGGLLJAMA IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B38110", Offset = "0x3B37310", VA = "0x183B38110", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MNIEHAIJFAP OCICPKKEFHG, EGGFFELFNJM IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3B370A0", Offset = "0x3B362A0", VA = "0x183B370A0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MNIEHAIJFAP OCICPKKEFHG, GFCKKBJNLEE IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B36320", Offset = "0x3B35520", VA = "0x183B36320", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MNIEHAIJFAP OCICPKKEFHG, GJMKBMNOFOF IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B35980", Offset = "0x3B34B80", VA = "0x183B35980", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MNIEHAIJFAP OCICPKKEFHG, BAFJBOBJFNC IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B34A70", Offset = "0x3B33C70", VA = "0x183B34A70", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MNIEHAIJFAP OCICPKKEFHG, MKCAKONNCHD IPBOIENDBHP, T1 HPBCICBDLGC, T2 GLIMNKHBIHC, T3 JFNDEHBDGCH, T4 BHKNLKDNALF, T5 CEHEOHKJOPN, T6 LFAAOEMMOME, T7 CAGIDMNGBOH, T8 MAILLCCGNCI, T9 NHNFAHGGPLE, T10 BJIMLMIFFAI, T11 MIKLLDEEKFO, T12 FEMBLBKJMEG, T13 FNHPOBCDFAP, T14 FGCPGGNDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF510", Offset = "0x7DBE710", VA = "0x187DBF510", Slot = "248")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF720", Offset = "0x7DBE920", VA = "0x187DBF720", Slot = "249")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2470", Offset = "0x1DE1670", VA = "0x181DE2470")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IEOBFHOLJDH
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DB89C0", Offset = "0x7DB7BC0", VA = "0x187DB89C0")]
	private static bool FFKCJCODPMA(ViewId MKHHKDJKLDN, [Out] RRNetworkView DMGGONLOPJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x3846870", Offset = "0x3845A70", VA = "0x183846870")]
	[CanBeNull]
	public static T CEIGEDBLOCH<T>(this ViewId NDLKHGHIICJ)
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
		private sealed class NLMAIHMGIFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public KPDBONCIMNC[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public NLMAIHMGIFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x7DBDF60", Offset = "0x7DBD160", VA = "0x187DBDF60")]
			internal int BLEKEKBKFKM(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x7DBDFE0", Offset = "0x7DBD1E0", VA = "0x187DBDFE0")]
			internal void FKJPGHFIIHP(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly FODGIOKBGBI FHEIHFBIKLF;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static KPDBONCIMNC[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		internal int AEEMMNBFOMP;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4AB0", Offset = "0x7DC3CB0", VA = "0x187DC4AB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DC50B0", Offset = "0x7DC42B0", VA = "0x187DC50B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5460", Offset = "0x7DC4660", VA = "0x187DC5460")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DC54D0", Offset = "0x7DC46D0", VA = "0x187DC54D0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4FB0", Offset = "0x7DC41B0", VA = "0x187DC4FB0")]
		private void GGMOIGMHNOO(KPDBONCIMNC GHOGEGCBLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4FB0", Offset = "0x7DC41B0", VA = "0x187DC4FB0")]
		private void LCPKOGLPCEH(KPDBONCIMNC LICKBIDNDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4ED0", Offset = "0x7DC40D0", VA = "0x187DC4ED0")]
		private void CECPNCNKDHI(KPDBONCIMNC HMFALEOPEFK, IDictionary<object, object> GMKLDGLGHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4960", Offset = "0x7DC3B60", VA = "0x187DC4960")]
		public static void AssignPlayerNumbers(int MEKNOAFMNEE, int MEPHACBDEHE, Func<int, int> GPNHHNNDKFI, Action<int, int> LBBBIMFAHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5570", Offset = "0x7DC4770", VA = "0x187DC5570")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4FC0", Offset = "0x7DC41C0", VA = "0x187DC4FC0")]
		private void OGCMBHJEPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA018E0", Offset = "0xA00AE0", VA = "0x180A018E0")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HLPINNMGJHN
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6FC0", Offset = "0x7DB61C0", VA = "0x187DB6FC0")]
	public static int DNDEOCOKLGD(this KPDBONCIMNC PNBFNEJFAPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7160", Offset = "0x7DB6360", VA = "0x187DB7160")]
	public static void HIKOEOFFBJD(this KPDBONCIMNC PNBFNEJFAPC, int NOOJEGDGEDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HEEGOMILPKC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void MBKHDFCCMHK(Hashtable PPDPHFAEOEG);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void EPEJLPBGGMN(KPDBONCIMNC PNBFNEJFAPC, Hashtable PPDPHFAEOEG);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event MBKHDFCCMHK JECCIIDIKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6B40", Offset = "0x7DB5D40", VA = "0x187DB6B40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6D80", Offset = "0x7DB5F80", VA = "0x187DB6D80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event MBKHDFCCMHK FIKHCGOODAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6C00", Offset = "0x7DB5E00", VA = "0x187DB6C00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7DB69C0", Offset = "0x7DB5BC0", VA = "0x187DB69C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event EPEJLPBGGMN DJJDGMAGDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6A80", Offset = "0x7DB5C80", VA = "0x187DB6A80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6E40", Offset = "0x7DB6040", VA = "0x187DB6E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event EPEJLPBGGMN OGILECGLCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6F00", Offset = "0x7DB6100", VA = "0x187DB6F00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6CC0", Offset = "0x7DB5EC0", VA = "0x187DB6CC0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class FINFOMOEJPM
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static int ALOAKHFDOAG;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int ILKAJFKBCND;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int GKNDNNNGPHG;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE400", Offset = "0x7DAD600", VA = "0x187DAE400")]
	public static void OGNEJHEECLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE080", Offset = "0x7DAD280", VA = "0x187DAE080")]
	public static void DOBMMKNJIHO(int[] KDGNCEMDDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE160", Offset = "0x7DAD360", VA = "0x187DAE160")]
	public static int HFKGHIDJKON(int PIPMNGJMGNF, bool BDGDNEPOFKJ = true)
	{
		return default(int);
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
